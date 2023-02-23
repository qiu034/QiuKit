using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QiuKit.ProgramHelper;

namespace QiuKit.ClassCreate
{
    public partial class ClassForm : Form
    {
        public string Host { get; set; }
        public string User { get; set; }
        public string Pwd { get; set; }

        public string ConnStr;

        private string path = "";

        public ClassForm()
        {
            InitializeComponent();
        }

        private void blueButton1_Click(object sender, EventArgs e)
        {
            ConnDialog conn = new ConnDialog();
            conn.SetData += Conn_SetData;
            conn.StartPosition = FormStartPosition.CenterParent;
            conn.ShowDialog();
        }

        private void Conn_SetData(string host, string user, string pwd, bool state)
        {
            this.Host = host;
            this.User = user;
            this.Pwd = pwd;
            if (state)
            {
                MessageBox.Show("连接成功！");
                ConnStr = string.Format("Data Source={0};Initial Catalog=master;User ID={1};password={2}", host, user, pwd);
                //加载所有数据库
                DataTable dt = ExecSql(ConnStr, "SELECT dbid,name FROM sysdatabases");
                if (null != dt)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        ListBoxDb.Items.Add(item["name"].ToString());
                    }
                }
            }
            else
            {
                ListBoxDb.Items.Clear();
                MessageBox.Show("连接失败！");
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = this.dataGridView1.SelectedRows;
            if (selectedRow.Count > 0)
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < selectedRow.Count; i++)
                    {
                        var table = selectedRow[i].Cells[0].Value.ToString();
                        path = folder.SelectedPath.ToString() + "\\" + table + ".cs";
                        ExecSqlPrint(table);
                    }
                    MessageBox.Show("导出完成！");
                }
            }
            else
            {
                MessageBox.Show("请先选择数据！");
            }
        }

        private void ListBoxDb_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTD.Text = "";
            if (ListBoxDb.SelectedItem == null) return;
            string dbName = ListBoxDb.SelectedItem.ToString();
            CreateSqlStr(dbName);
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns["table_name"].HeaderText = "表名";
            dataGridView1.Columns["table_name"].Width = 400;
        }

        private void txtTD_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxDb.SelectedItem == null) return;
            string dbName = ListBoxDb.SelectedItem.ToString();
            if (string.IsNullOrEmpty(txtTD.Text))
            {
                CreateSqlStr(dbName);
                return;
            }
            CreateSqlStr(dbName, txtTD.Text.Trim());
        }


        #region 私有方法
        /// <summary>
        /// 查询所有表
        /// </summary>
        /// <param name="dbName"></param>
        private void CreateSqlStr(string dbName)
        {
            ConnStr = string.Format("Data Source={0};Initial Catalog={1};User ID={2};password={3}", Host, dbName, User, Pwd);
            DataTable dt = ExecSql(ConnStr,"select table_name from information_schema.tables");
            if (null != dt)
            {
                dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = dt;
            }
        }

        /// <summary>
        /// 模糊查询表
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="condition"></param>
        private void CreateSqlStr(string dbName,string condition)
        {
            ConnStr = string.Format("Data Source={0};Initial Catalog={1};User ID={2};password={3}", Host, dbName, User, Pwd);
            DataTable dt = ExecSql(ConnStr, string.Format("select table_name from information_schema.tables  where table_name Like'%{0}%' ", condition));
            if (null != dt)
            {
                dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = dt;
            }
        }

        /// <summary>
        /// 执行Sql，返回dt
        /// </summary>
        /// <param name="connstr"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable ExecSql(string connstr, string sql)
        {
            return SqlHelper.Instance.ExecuteDataset(connstr, sql).Tables[0];
        }

        /// <summary>
        /// 执行Sql,打印需求内容
        /// </summary>
        /// <param name="tableName"></param>
        private void ExecSqlPrint(string tableName)
        {           
            string dbName = ListBoxDb.SelectedItem.ToString();
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};password={3}", Host, dbName, User, Pwd);
            DataTable dt = ExecSql(connectionString,SqlHelper.Instance.GetModelStr(tableName));
            StringBuilder result = new StringBuilder($"public class {tableName}Model \r\n");
            result.AppendLine("{");
            for (int i=0;i<dt.Rows.Count;i++)
            {
                result.AppendLine($"    private {dt.Rows[i]["ColumnType"]} _{dt.Rows[i]["ColumnName"]};");
                result.AppendLine($"    public {dt.Rows[i]["ColumnType"]} {dt.Rows[i]["ColumnName"]}");
                result.AppendLine("    {");
                result.AppendLine($"        get{{ return _{dt.Rows[i]["ColumnName"]}; }}");
                result.AppendLine($"        set{{ _{dt.Rows[i]["ColumnName"]} = value; }}");
                result.AppendLine("    }");
                result.AppendLine("");
            }
            result.AppendLine("}");
            System.IO.File.AppendAllText(path, result.ToString());
        }

        #endregion
    }
}
