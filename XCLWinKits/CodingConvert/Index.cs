using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace CodingConvert
{
    public partial class Index : BaseForm.BaseFormClass
    {
        public Index()
        {
            InitializeComponent();
            this.InitData();
        }

        private void InitData()
        {
            var codingLst = XCLNetTools.Enum.EnumHelper.GetEnumFieldModelList(typeof(CommonHelper.CommonEnum.CodingEnum));
            this.commboxCodingName.DisplayMember = "Text";
            this.commboxCodingName.ValueMember = "Description";
            this.commboxCodingName.DataSource = codingLst;
        }

        public override string SubAssemblyName
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Name;
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtInputString.Text))
            {
                MessageBox.Show("请输入要编码的内容！");
                return;
            }
            this.txtResult.Text = this.GetCodeString(this.txtInputString.Text,true);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtResult.Text))
            {
                MessageBox.Show("请输入要解码的内容！");
                return;
            }
            this.txtInputString.Text = this.GetCodeString(this.txtResult.Text,false);
        }

        private string GetCodeString(string str,bool isEncode)
        {
            if (isEncode)
            {
                this.txtResult.Text = string.Empty;
            }
            else
            {
                this.txtInputString.Text = string.Empty;
            }
            string strResult = string.Empty;
            try
            {
                var coding = System.Text.Encoding.GetEncoding(this.commboxCodingName.SelectedValue.ToString());
                if (isEncode)
                {
                    strResult = System.Web.HttpUtility.UrlEncode(str, coding);
                }
                else
                { 
                    strResult = System.Web.HttpUtility.UrlDecode(str,coding);
                }
            }
            catch (Exception ex)
            {
                strResult="处理失败！";
            }
            return strResult;
        }
    }
}
