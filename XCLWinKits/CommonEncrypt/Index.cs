using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Security.Cryptography;

namespace CommonEncrypt
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
            var encryptLst = XCLNetTools.Enum.EnumObj.GetList(typeof(CommonHelper.CommonEnum.EncryptEnum));
            this.comboxEncryptType.DisplayMember = "Text";
            this.comboxEncryptType.ValueMember = "Text";
            this.comboxEncryptType.DataSource = encryptLst;
            this.comboxEncryptType_SelectedIndexChanged(this.comboxEncryptType, null);
        }

        public override string SubAssemblyName
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Name;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtInput.Text))
            {
                MessageBox.Show("请输入明文！");
                return;
            }
            var type = (CommonHelper.CommonEnum.EncryptEnum)Enum.Parse(typeof(CommonHelper.CommonEnum.EncryptEnum), this.comboxEncryptType.Text);
            this.txtResult.Text= this.GetResult(type, this.txtInput.Text,true);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtResult.Text))
            {
                MessageBox.Show("请输入密文！");
                return;
            }
            var type = (CommonHelper.CommonEnum.EncryptEnum)Enum.Parse(typeof(CommonHelper.CommonEnum.EncryptEnum), this.comboxEncryptType.Text);
            this.txtInput.Text=this.GetResult(type, this.txtResult.Text,false);
        }

        private string GetResult(CommonHelper.CommonEnum.EncryptEnum encryptEnum, string str,bool isEncrypt)
        {
            string result = string.Empty;
            try
            {
                switch (encryptEnum)
                {
                    case CommonHelper.CommonEnum.EncryptEnum.AES:
                        XCLNetTools.StringHander.AESEncrypt aes = new XCLNetTools.StringHander.AESEncrypt(this.ckContainKey.Checked);
                        if (string.IsNullOrEmpty(this.txtKey.Text))
                        {
                            result = isEncrypt ? aes.Encrypt(this.txtInput.Text) : aes.Decrypt(this.txtResult.Text);
                        }
                        else
                        {
                            result = isEncrypt ? aes.Encrypt(this.txtInput.Text, this.txtKey.Text) : aes.Decrypt(this.txtResult.Text, this.txtKey.Text);
                        }
                        break;
                    case CommonHelper.CommonEnum.EncryptEnum.Base64:
                        result = isEncrypt ? XCLNetTools.StringHander.StringUtil.Base64Code(str) : XCLNetTools.StringHander.StringUtil.Base64Decode(str);
                        break;
                    case CommonHelper.CommonEnum.EncryptEnum.DES:
                        if (string.IsNullOrEmpty(this.txtKey.Text))
                        {
                            result = isEncrypt ? XCLNetTools.StringHander.DESEncrypt.Encrypt(this.txtInput.Text) : XCLNetTools.StringHander.DESEncrypt.Decrypt(this.txtResult.Text);
                        }
                        else
                        {
                            result = isEncrypt ? XCLNetTools.StringHander.DESEncrypt.Encrypt(this.txtInput.Text, this.txtKey.Text) : XCLNetTools.StringHander.DESEncrypt.Decrypt(this.txtResult.Text, this.txtKey.Text);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                result = "处理失败！";
            }
            return result;
        }

        private void comboxEncryptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = (CommonHelper.CommonEnum.EncryptEnum)Enum.Parse(typeof(CommonHelper.CommonEnum.EncryptEnum), this.comboxEncryptType.Text);
            switch (type)
            {
                case CommonHelper.CommonEnum.EncryptEnum.AES:
                    this.txtKey.Enabled = true;
                    this.ckContainKey.Checked = false;
                    this.ckContainKey.Enabled = true;
                    break;
                case CommonHelper.CommonEnum.EncryptEnum.DES:
                    this.txtKey.Enabled = true;
                    this.ckContainKey.Checked = false;
                    this.ckContainKey.Enabled = false;
                    break;
                default:
                    this.txtKey.Text = "";
                    this.txtKey.Enabled = false;
                    this.ckContainKey.Checked = false;
                    this.ckContainKey.Enabled = false;
                    break;
            }
        }
    }
}
