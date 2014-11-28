using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace XCLNetFileReplace
{
    public partial class Index : BaseForm.BaseFormClass
    {
        private string openFileFolderPath = string.Empty;//打开的文件所在的公共目录,如"C:\XCL\"
        private object lockObject = new object();
        delegate void Delegate_UpdateStatus(Model.DoState doState);
        delegate DataGridViewRow Delegate_DoIt(DataGridViewRow dr);
        delegate void Delegate_VoidMethod();

        public Index()
        {
            InitializeComponent();
            this.groupBox_FileInfo.Text = "待处理文件：（支持xls、xlsx、csv、doc、docx及其它文本文件[如：txt、html等]），无需安装Office！";
            this.InitData();
        }

        private void InitData()
        {
            #region 匿名方法：当正则表达式选择后，禁用掉【全字匹配】
            Delegate_VoidMethod checkWholeReplace = new Delegate_VoidMethod(delegate(){
                if (this.ckIsRegexp.Checked)
                {
                    this.ckIsWhole.Checked = false;
                    this.ckIsWhole.Enabled = false;
                }
                else
                {
                    this.ckIsWhole.Enabled = true;
                }
            });
            this.ckIsRegexp.Click += new EventHandler(delegate
            {
                checkWholeReplace.Invoke();
            });
            #endregion

            #region 初始化选项
            string searchOptions = CommonHelper.ConfigHelper.GetBaseConfigStringValue(this.SubAssemblyName, "SearchOptions");
            if (!string.IsNullOrEmpty(searchOptions))
            {
                string[] so=searchOptions.Split(',');
                if (so.Contains(this.ckIsContent.Text))
                {
                    this.ckIsContent.Checked = true;
                }
                if (so.Contains(this.ckIsFileName.Text))
                {
                    this.ckIsFileName.Checked = true;
                }
                if (so.Contains(this.ckIsNotIgnoreLowerCase.Text))
                {
                    this.ckIsNotIgnoreLowerCase.Checked = true;
                }
                if (so.Contains(this.ckIsRegexp.Text))
                {
                    this.ckIsRegexp.Checked = true;
                }
                if (so.Contains(this.ckIsWhole.Text))
                {
                    this.ckIsWhole.Checked = true;
                }
                checkWholeReplace.Invoke();
            }

            this.txtOutPutPath.Text = CommonHelper.ConfigHelper.GetBaseConfigStringValue(this.SubAssemblyName, "OutPutPath");
            #endregion
        }

        #region 导航菜单
        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.InitFiles(openFile.FileNames);
                    if (null != openFile.FileNames && openFile.FileNames.Length > 0)
                    {
                        string fName = XCLNetTools.FileHandler.ComFile.GetFileName(openFile.FileNames[0]);
                        this.openFileFolderPath = openFile.FileNames[0].Replace(fName, "");
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("系统错误，请重新打开有效文件！");
                }
            }
        }

        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            if (openFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string[] files = XCLNetTools.FileHandler.ComFile.GetFolderFilesByRecursion(openFolder.SelectedPath);
                    this.InitFiles(files);
                    this.openFileFolderPath = openFolder.SelectedPath;
                }
                catch (Exception exp)
                {
                    MessageBox.Show("系统错误，请重新打开有效文件夹！");
                }
            }
        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == this.dgFiles.DataSource)
            {
                MessageBox.Show("当前没有任何数据可供导出！");
                return;
            }
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            openFolder.Description = "请选择要存放的目录！";
            if (openFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folderPath=openFolder.SelectedPath.TrimEnd('\\');
                Aspose.Cells.Workbook wb = new Aspose.Cells.Workbook();
                List<Model.FileInfo> lst = this.dgFiles.DataSource as List<Model.FileInfo>;
                wb.Worksheets[0].Cells.ImportDataTable(XCLNetTools.Generic.ListHelper<Model.FileInfo>.ToDataTable((IList<Model.FileInfo>)lst), true, 0, 0);
                string filePath=string.Format(@"{0}\XCLNetFileRelace_{1:yyyyMMddHHmmssfff}.xlsx", folderPath,DateTime.Now);
                wb.Save(filePath, Aspose.Cells.SaveFormat.Xlsx);
                if (MessageBox.Show("导出成功，是否打开该文件？", "系统提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        /// <summary>
        /// 执行
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isRegexp = this.ckIsRegexp.Checked;
            bool isContent = this.ckIsContent.Checked;
            bool isFileName = this.ckIsFileName.Checked;
            bool isNotIgnoreLowerCase = this.ckIsNotIgnoreLowerCase.Checked;
            bool isWhole = this.ckIsWhole.Checked;

            #region 合法性验证
            if (null == this.dgFiles.DataSource)
            {
                MessageBox.Show("请先选择待处理的文件！");
                return;
            }
            if (!isFileName && !isContent)
            {
                MessageBox.Show("查找内容中的【文件名】和【文件内容】至少选一个！");
                return;
            }
            if (string.IsNullOrEmpty(this.txtOldValue.Text))
            {
                MessageBox.Show("查找内容不能为空！");
                return;
            }
            if (!XCLNetTools.FileHandler.FileDirectory.DirectoryExists(this.txtOutPutPath.Text))
            {
                if (!XCLNetTools.FileHandler.FileDirectory.MakeDirectory(this.txtOutPutPath.Text))
                {
                    MessageBox.Show("输出目录不存在，请选择有效的输出目录！");
                    return;
                }
            }
            List<Model.FileInfo> lstFiles = this.dgFiles.DataSource as List<Model.FileInfo>;
            if (null != lstFiles && lstFiles.Count > 0)
            {
                if (!lstFiles.Exists(k => k.是否已处理 == "否"))
                {
                    MessageBox.Show("文件都已处理，请重新打开要处理的文件！");
                    return;
                }
            }
            #endregion

            #region 将选项保存至配置文件中
            List<string> searchOptions = new List<string>();
            if (this.ckIsRegexp.Checked)
            {
                searchOptions.Add(this.ckIsRegexp.Text);
            }
            if (this.ckIsContent.Checked)
            {
                searchOptions.Add(this.ckIsContent.Text);
            }
            if (this.ckIsFileName.Checked)
            {
                searchOptions.Add(this.ckIsFileName.Text);
            }
            if (this.ckIsNotIgnoreLowerCase.Checked)
            {
                searchOptions.Add(this.ckIsNotIgnoreLowerCase.Text);
            }
            if (this.ckIsWhole.Checked)
            {
                searchOptions.Add(this.ckIsWhole.Text);
            }
            CommonHelper.ConfigHelper.SetBaseConfigValue(this.SubAssemblyName, "SearchOptions", string.Join(",", searchOptions.ToArray()));
            CommonHelper.ConfigHelper.SetBaseConfigValue(this.SubAssemblyName, "OutPutPath", this.txtOutPutPath.Text);
            #endregion

            #region 任务处理
            this.SetControlEnable(false);
            Model.DoState doState = new Model.DoState();
            doState.SumCount = this.dgFiles.Rows.Count;
            for (int i = 0; i < this.dgFiles.Rows.Count; i++)
            {
                DataGridViewRow dr = this.dgFiles.Rows[i];
                Delegate_DoIt dg = new Delegate_DoIt(DoIt);
                IAsyncResult result = dg.BeginInvoke(dr, new AsyncCallback(this.GetResultCallBack), doState);
            } 
            #endregion
        }

        /// <summary>
        /// 开始处理文件
        /// </summary>
        private DataGridViewRow DoIt(DataGridViewRow dr)
        {
            DateTime dtStart = DateTime.Now;
            StringBuilder strRemark = new StringBuilder();
            dr.Cells["是否已处理"].Value = "是";
            try
            {
                #region 验证扩展名及是否为文本文件
                string currentExt = dr.Cells["扩展名"].Value.ToString();
                string[] defaultExt = { "xls", "xlsx","csv" , "doc", "docx"/*, "ppt", "pptx","pdf"*/ };//这些格式由aspose去处理
                string[] excelExt = { "xls", "xlsx", "csv" };
                string[] docExt = { "doc", "docx" };
                //string[] pptExt = { "ppt", "pptx" };
                //string[] pdfExt = { "pdf"};
                bool isDefaultExt = defaultExt.Contains(currentExt);
                bool isExcelExt = excelExt.Contains(currentExt);
                bool isDocExt = docExt.Contains(currentExt);
                //bool isPPTExt = pptExt.Contains(currentExt);
                //bool isPdfExt = pdfExt.Contains(currentExt);
                bool isTxtFile = XCLNetTools.FileHandler.ComFile.IsTextFile(dr.Cells["路径"].Value.ToString());

                if (!isDefaultExt && !isTxtFile && this.ckIsContent.Checked)
                {
                    //非aspose能处理的文件，且非文本文件，则不能替换内容，只能替换文件名！
                    dr.Cells["备注"].Value = "不支持替换该文件的内容！";
                    dr.Cells["是否处理成功"].Value = "否";
                    dr.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    return dr;
                }
                #endregion

                Regex reg = null;

                #region 是否启用正则替换
                if (this.ckIsRegexp.Checked)
                {
                    reg = this.ckIsNotIgnoreLowerCase.Checked?new Regex(this.txtOldValue.Text):new Regex(this.txtOldValue.Text, RegexOptions.IgnoreCase);
                }
                else
                {
                    string newExpStr = this.ckIsWhole.Checked ? string.Format(@"\b{0}\b",Regex.Escape(this.txtOldValue.Text)) :Regex.Escape(this.txtOldValue.Text);
                    reg = this.ckIsNotIgnoreLowerCase.Checked ? new Regex(newExpStr) : new Regex(newExpStr, RegexOptions.IgnoreCase);
                }
                #endregion

                #region 复制到输出目录并判断是否替换文件名
                string filePath = dr.Cells["路径"].Value.ToString();
                filePath = filePath.Replace(this.openFileFolderPath.TrimEnd('\\'), this.txtOutPutPath.Text.TrimEnd('\\'));
                string filetitle = XCLNetTools.FileHandler.ComFile.GetFileName(filePath, false);

                #region 是否替换文件名
                if (this.ckIsFileName.Checked)
                {
                    strRemark.AppendFormat("文件名替换【{0}】处；", reg.Matches(filetitle).Count);
                    filetitle = reg.Replace(filetitle, this.txtNew.Text);
                }
                #endregion

                filetitle = string.Format("{0}{1}{2}", this.txtFileFirstName.Text, filetitle, this.txtFileLastName.Text);
                filePath = XCLNetTools.FileHandler.ComFile.GetFileFolderPath(filePath) + "\\" + filetitle + "." + XCLNetTools.FileHandler.ComFile.GetExtName(filePath);

                XCLNetTools.FileHandler.ComFile.CopyFile(dr.Cells["路径"].Value.ToString(), filePath);
                if (!System.IO.File.Exists(filePath))
                {
                    dr.Cells["备注"].Value = "输出目录中的文件未找到！";
                    dr.Cells["是否处理成功"].Value = "否";
                    dr.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    return dr;
                }
                #endregion

                #region 开始替换文件内容
                if (this.ckIsContent.Checked)
                {
                    int replaceCount = 0;
                    if (isDefaultExt)
                    {
                        if (isExcelExt)
                        {
                            #region 处理excel文件
                            Aspose.Cells.Workbook wb = new Aspose.Cells.Workbook(filePath);
                            for (int i = 0; i < wb.Worksheets.Count; i++)
                            {
                                Aspose.Cells.Cells sheetCells = wb.Worksheets[i].Cells;
                                for (int cellsRowIndex = 0; cellsRowIndex < sheetCells.MaxDataRow+1; cellsRowIndex++)
                                {
                                    for (int cellsColumn = 0; cellsColumn < sheetCells.MaxDataColumn+1; cellsColumn++)
                                    {
                                        Aspose.Cells.Cell currentCell = sheetCells[cellsRowIndex, cellsColumn];
                                        string cellValue = Convert.ToString(currentCell.Value);
                                        if (!string.IsNullOrEmpty(cellValue))
                                        {
                                            replaceCount += reg.Matches(cellValue).Count;
                                            cellValue = reg.Replace(cellValue, this.txtNew.Text);
                                            currentCell.PutValue(cellValue);
                                        }
                                    }
                                }
                            }
                            if (replaceCount > 0)
                            {
                                wb.Save(filePath);
                            }
                            #endregion
                        }
                        else if (isDocExt)
                        {
                            #region 处理word
                            //正则无法使用特殊正则，如\s带\的。
                            Aspose.Words.Document wordDocument = new Aspose.Words.Document(filePath);
                            replaceCount= wordDocument.Range.Replace(reg, this.txtNew.Text);
                            wordDocument.Save(filePath);
                            #endregion
                        }
                        //else if (isPPTExt)
                        //{
                        //    #region 处理PPT
                        //    Aspose.Slides.Pptx.PresentationEx pptPres = new Aspose.Slides.Pptx.PresentationEx(filePath);
                        //    #endregion
                        //}
                        //else if (isPdfExt)
                        //{
                        //    #region 处理pdf文件
                        //    Aspose.Pdf.Kit.PdfContentEditor pdfEditor = new Aspose.Pdf.Kit.PdfContentEditor();
                        //    pdfEditor.BindPdf(filePath);
                        //    pdfEditor.ReplaceText(this.txtOldValue.Text, this.txtNew.Text);
                        //    pdfEditor.Save(filePath);
                        //    #endregion
                        //}
                    }
                    else
                    {
                        #region 处理文本文件
                        string fileContent = System.IO.File.ReadAllText(filePath, System.Text.Encoding.Default);
                        replaceCount = reg.Matches(fileContent).Count;
                        fileContent = reg.Replace(fileContent, this.txtNew.Text);
                        System.IO.File.WriteAllText(filePath, fileContent, System.Text.Encoding.Default); 
                        #endregion
                    }
                    strRemark.AppendFormat("文件内容替换【{0}】处；", replaceCount);
                }
                #endregion

                if (strRemark.Length > 0)
                {
                    dr.Cells["备注"].Value = strRemark.ToString();
                }
                dr.Cells["是否处理成功"].Value = "是";
                dr.DefaultCellStyle.ForeColor = System.Drawing.Color.Green;
            }
            catch(Exception e)
            {
                dr.Cells["是否处理成功"].Value = "否";
                dr.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                dr.Cells["备注"].Value = e.Message;
            }
            DateTime dtEnd = DateTime.Now;
            dr.Cells["处理用时"].Value =Math.Round((decimal)(dtEnd.Subtract(dtStart).TotalMilliseconds/1000.0),1);
            return dr;
        }

        /// <summary>
        /// 处理文件回调函数
        /// </summary>
        private void GetResultCallBack(IAsyncResult asyncResult)
        {
            lock (this.lockObject)
            {
                Model.DoState doState = asyncResult.AsyncState as Model.DoState;
                AsyncResult result = (AsyncResult)asyncResult;
                Delegate_DoIt delegateDoit = (Delegate_DoIt)result.AsyncDelegate;
                DataGridViewRow dr=delegateDoit.EndInvoke(asyncResult);
                doState.CurrentCount += 1;
                if (dr.Cells["是否处理成功"].Value.ToString() == "是")
                {
                    doState.SuccessCount += 1;
                }
                else
                {
                    doState.FailCount += 1;
                }
                if (this.InvokeRequired)
                {
                    this.Invoke(new Delegate_UpdateStatus(this.UpdateStatus), new object[] { doState });
                }
                else
                {
                    this.UpdateStatus(doState);
                }
            }
        }

        /// <summary>
        /// 更新状态栏
        /// </summary>
        private void UpdateStatus(Model.DoState doState)
        {
            this.toolStripStatusLabel2.Text = doState.ToString();
            this.toolStripProgressBar1.Value = (int)doState.DoPercent;
            if (doState.CurrentCount == doState.SumCount)
            {
                this.SetControlEnable(true);
            }
        }

        /// <summary>
        /// 初始化状态栏
        /// </summary>
        private void InitStatus()
        {
            Model.DoState doState = new Model.DoState();
            this.toolStripStatusLabel2.Text = doState.ToString();
            this.toolStripProgressBar1.Value = (int)doState.DoPercent;
        }

        /// <summary>
        /// 设置输出目录
        /// </summary>
        private void btnOutPutPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            if (openFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtOutPutPath.Text = openFolder.SelectedPath;
            }
        }

        /// <summary>
        /// 初始化待处理文件
        /// </summary>
        private void InitFiles(string[] files)
        {
            if (null != files&&files.Length>0)
            {
                List<Model.FileInfo> lst = new List<Model.FileInfo>();
                for (int i = 0; i < files.Length; i++)
                {
                    try
                    {
                        Model.FileInfo model = new Model.FileInfo();
                        model.路径 = files[i];
                        model.扩展名 = XCLNetTools.FileHandler.ComFile.GetExtName(files[i]);
                        model.文件名 = XCLNetTools.FileHandler.ComFile.GetFileName(files[i]);
                        model.是否已处理 = "否";
                        model.是否处理成功 = "";
                        lst.Add(model);
                    }
                    catch
                    { 
                        
                    }
                }
                this.dgFiles.DataSource = lst;
                this.InitStatus();
            }
        }

        /// <summary>
        /// 给datagridview添加行号
        /// </summary>
        private void dgFiles_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv != null)
            {
                Rectangle rect = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height);
                TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgv.RowHeadersDefaultCellStyle.Font, rect, dgv.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
            }
        }

        /// <summary>
        /// 设置控件是否可用
        /// </summary>
        private void SetControlEnable(bool enable)
        {
            this.btnOutPutPath.Enabled = enable;
            this.btnSave.Enabled = enable;

            this.txtNew.ReadOnly = !enable;
            this.txtOldValue.ReadOnly = !enable;

            this.ckIsContent.Enabled = enable;
            this.ckIsFileName.Enabled = enable;
            this.ckIsNotIgnoreLowerCase.Enabled = enable;
            this.ckIsRegexp.Enabled = enable;
            this.ckIsWhole.Enabled = enable;
            if (this.ckIsRegexp.Checked)
            {
                this.ckIsWhole.Enabled = false;
                this.ckIsWhole.Checked = false;
            }

            this.txtFileFirstName.Enabled = enable;
            this.txtFileLastName.Enabled = enable;

            this.打开文件ToolStripMenuItem.Enabled = enable;
            this.打开文件夹ToolStripMenuItem.Enabled = enable;
            this.导出ToolStripMenuItem.Enabled = enable;
        }

        /// <summary>
        /// 打开输出目录
        /// </summary>
        private void btnOpenOutPath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtOutPutPath.Text))
            {
                if (XCLNetTools.FileHandler.FileDirectory.DirectoryExists(this.txtOutPutPath.Text))
                {
                    System.Diagnostics.Process.Start("Explorer.exe", this.txtOutPutPath.Text);
                }
                else
                {
                    if (MessageBox.Show("该目录不存在，是否要创建？", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (XCLNetTools.FileHandler.FileDirectory.MakeDirectory(this.txtOutPutPath.Text))
                        {
                            MessageBox.Show("目录创建成功！");
                        }
                        else
                        {
                            MessageBox.Show("目录创建失败，请手动选择有效目录！");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择输出目录！");
            }
        }

        public override string SubAssemblyName
        {
            get { return Assembly.GetExecutingAssembly().GetName().Name; }
        } 
    }
}
