using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;

namespace XCLRegexpTool
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
            this.lbMsg.Text = "";
            this.ckAnyTime.Checked = true;
            this.btnOK.Visible = false;

            this.txtInputRegexp.KeyUp += new KeyEventHandler(this.DoAutoWork);
            this.txtInputString.KeyUp += new KeyEventHandler(this.DoAutoWork);
            this.txtReplaceString.KeyUp += new KeyEventHandler(this.DoAutoWork);
            this.ckAnyTime.Click += new EventHandler((sender, e) =>
            {
                if (!this.ckAnyTime.Checked)
                {
                    this.lbMsg.Text = "";
                }
                this.btnOK.Visible = !this.ckAnyTime.Checked;
                this.DoAutoWork(sender, e);
            });
            this.btnOK.Click += new EventHandler((sender, e) =>
            {
                this.ReplaceWork();
            });

            this.txtFindResult.ReadOnly = true;
            this.txtReplaceResult.ReadOnly = true;
        }

        private void DoAutoWork(object sender, EventArgs e)
        {
            if (this.ckAnyTime.Checked)
            {
                this.ReplaceWork();
            }
        }

        private void ReplaceWork()
        {
            #region 验证
            if (string.IsNullOrEmpty(this.txtInputRegexp.Text))
            {
                this.lbMsg.Text = "请输入正则表达式！";
                return;
            }
            if (string.IsNullOrEmpty(this.txtInputString.Text))
            {
                this.lbMsg.Text = "请输入待处理文本！";
                return;
            }
            this.lbMsg.Text = "";
            #endregion

            StringBuilder strFindResult = new StringBuilder();
            Regex reg = null;
            RegexOptions regexOption = RegexOptions.None;
            if (this.ckIgnoreCase.Checked)
            {
                regexOption = RegexOptions.IgnoreCase;
            }

            try
            {
                reg = new Regex(this.txtInputRegexp.Text, regexOption);
            }
            catch
            {
                reg = null;
            }
            if (null == reg)
            {
                this.lbMsg.Text = "请输入有效的正则表达式！";
                return;
            }


            MatchCollection matchs = reg.Matches(this.txtInputString.Text);
            if (null != matchs && matchs.Count > 0)
            {
                for (int i = 0; i < matchs.Count; i++)
                {
                    strFindResult.AppendFormat("{0}：{1}\r\n", i + 1, matchs[i].Value);
                }
            }
            this.txtFindResult.Text = strFindResult.Length > 0 ? strFindResult.ToString() : "未匹配到任何结果！";

            this.txtReplaceResult.Text = Regex.Replace(this.txtInputString.Text, this.txtInputRegexp.Text, this.txtReplaceString.Text,regexOption);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtReplaceResult.Text))
            {
                MessageBox.Show("当前没有任何数据可供导出！");
                return;
            }
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            openFolder.Description = "请选择要存放的目录！";
            if (openFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folderPath = openFolder.SelectedPath.TrimEnd('\\');
                string filePath = string.Format(@"{0}\XCLWinKits_{1:yyyyMMddHHmmssfff}.txt", folderPath, DateTime.Now);
                if (XCLNetTools.FileHandler.FileDirectory.CreateTextFile(filePath))
                {
                    XCLNetTools.FileHandler.FileDirectory.AppendText(filePath, this.txtReplaceResult.Text);
                    if (MessageBox.Show("导出成功，是否打开该文件？", "系统提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(filePath);
                    }
                }
                else
                {
                    MessageBox.Show("导出失败，请重试！");
                    return;
                }
            }
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
