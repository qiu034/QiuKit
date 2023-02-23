using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QiuKit.DocHandle;
using QiuKit.Translate;
using QiuKit.SendMessage;
using QiuKit.ClassCreate;
using QiuKit.RgbColor;

namespace QiuKit
{
    public class QiuForms
    {
        private static QiuForms _Instance = null;
        public static QiuForms Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QiuForms();
                return _Instance;
            }
        }

        public enum Name
        {
            DocForm,
            TranslateForm,
            MsgForm,
            ClassForm,
            RgbForm,
        }

        public void CreateNewForm(ref Form form, Name name)
        {
            if (name == Name.DocForm)
                form = new DocForm();
            if (name == Name.TranslateForm)
                form = new TranslateForm();
            if (name == Name.MsgForm)
                form = new MsgForm();
            if (name == Name.ClassForm)
                form = new ClassForm();
            if (name == Name.RgbForm)
                form = new RgbForm();
        }
    }
}
