using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Cryptography;

namespace MD5Tool
{
    public partial class Index : BaseForm.BaseFormClass
    {
        public Index()
        {
            InitializeComponent();
            this.InitData();
        }

        private enum MD5TypeEnum
        {
            [Description("16")]
            _16,
            [Description("32")]
            _32
        }

        private void InitData()
        {
            var MD5TypeList=XCLNetTools.Enum.EnumHelper.GetEnumFieldModelList(typeof(MD5TypeEnum));
            foreach (var m in MD5TypeList)
            {
                this.listBoxTypes.Items.Add(m.Description);
            }
            for (int i = 0; i < this.listBoxTypes.Items.Count; i++)
            {
                this.listBoxTypes.SetSelected(i, true);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtInputString.Text))
            {
                MessageBox.Show("请输入待处理内容！");
                return;
            }
            List<string> lstStr = new List<string>();
            byte[] inputBytes = Encoding.Default.GetBytes(this.txtInputString.Text);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] outputBytes=md5.ComputeHash(inputBytes);
            string result = string.Empty;

            if (this.listBoxTypes.SelectedItems.Contains(XCLNetTools.Enum.EnumHelper.GetEnumDesc<MD5TypeEnum>(MD5TypeEnum._16)))
            {
                result=BitConverter.ToString(outputBytes,4,8).Replace("-", "");
                lstStr.Add(string.Format("16位大写：{0}", result.ToUpper()));
                lstStr.Add(string.Format("16位小写：{0}", result.ToLower()));
            }
            if (this.listBoxTypes.SelectedItems.Contains(XCLNetTools.Enum.EnumHelper.GetEnumDesc<MD5TypeEnum>(MD5TypeEnum._32)))
            {
                result=BitConverter.ToString(outputBytes).Replace("-", "");
                lstStr.Add(string.Format("32位大写：{0}", result.ToUpper()));
                lstStr.Add(string.Format("32位小写：{0}", result.ToLower()));
            }

            this.txtResult.Text = string.Join("\r\n\r\n", lstStr.ToArray());
        }

        public override string SubAssemblyName
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Name;
            }
        }
    }
}
