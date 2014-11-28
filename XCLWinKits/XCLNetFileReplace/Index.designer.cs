namespace XCLNetFileReplace
{
    partial class Index
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_FileInfo = new System.Windows.Forms.GroupBox();
            this.dgFiles = new System.Windows.Forms.DataGridView();
            this.文件名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.路径 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.扩展名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否已处理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否处理成功 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处理用时 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_LBoxWait = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckIsContent = new System.Windows.Forms.CheckBox();
            this.ckIsFileName = new System.Windows.Forms.CheckBox();
            this.ckIsWhole = new System.Windows.Forms.CheckBox();
            this.ckIsNotIgnoreLowerCase = new System.Windows.Forms.CheckBox();
            this.ckIsRegexp = new System.Windows.Forms.CheckBox();
            this.txtOldValue = new System.Windows.Forms.TextBox();
            this.groupBox_Replace = new System.Windows.Forms.GroupBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox_OutPut = new System.Windows.Forms.GroupBox();
            this.txtFileLastName = new System.Windows.Forms.TextBox();
            this.txtFileFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenOutPath = new System.Windows.Forms.Button();
            this.btnOutPutPath = new System.Windows.Forms.Button();
            this.txtOutPutPath = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox_FileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).BeginInit();
            this.contextMenuStrip_LBoxWait.SuspendLayout();
            this.groupBox_Search.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox_Replace.SuspendLayout();
            this.groupBox_OutPut.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.打开文件夹ToolStripMenuItem,
            this.导出ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 打开文件夹ToolStripMenuItem
            // 
            this.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem";
            this.打开文件夹ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打开文件夹ToolStripMenuItem.Text = "打开文件夹";
            this.打开文件夹ToolStripMenuItem.Click += new System.EventHandler(this.打开文件夹ToolStripMenuItem_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.导出ToolStripMenuItem.Text = "导出";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // groupBox_FileInfo
            // 
            this.groupBox_FileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_FileInfo.Controls.Add(this.dgFiles);
            this.groupBox_FileInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_FileInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox_FileInfo.Location = new System.Drawing.Point(12, 28);
            this.groupBox_FileInfo.Name = "groupBox_FileInfo";
            this.groupBox_FileInfo.Size = new System.Drawing.Size(873, 180);
            this.groupBox_FileInfo.TabIndex = 1;
            this.groupBox_FileInfo.TabStop = false;
            // 
            // dgFiles
            // 
            this.dgFiles.AllowUserToAddRows = false;
            this.dgFiles.AllowUserToDeleteRows = false;
            this.dgFiles.AllowUserToOrderColumns = true;
            this.dgFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.文件名,
            this.路径,
            this.扩展名,
            this.是否已处理,
            this.是否处理成功,
            this.处理用时,
            this.备注});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFiles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFiles.Location = new System.Drawing.Point(3, 17);
            this.dgFiles.Name = "dgFiles";
            this.dgFiles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgFiles.RowTemplate.Height = 23;
            this.dgFiles.Size = new System.Drawing.Size(867, 160);
            this.dgFiles.TabIndex = 2;
            this.dgFiles.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgFiles_RowPostPaint);
            // 
            // 文件名
            // 
            this.文件名.DataPropertyName = "文件名";
            this.文件名.HeaderText = "文件名";
            this.文件名.Name = "文件名";
            this.文件名.ReadOnly = true;
            // 
            // 路径
            // 
            this.路径.DataPropertyName = "路径";
            this.路径.HeaderText = "路径";
            this.路径.Name = "路径";
            this.路径.ReadOnly = true;
            // 
            // 扩展名
            // 
            this.扩展名.DataPropertyName = "扩展名";
            this.扩展名.HeaderText = "扩展名";
            this.扩展名.Name = "扩展名";
            this.扩展名.ReadOnly = true;
            // 
            // 是否已处理
            // 
            this.是否已处理.DataPropertyName = "是否已处理";
            this.是否已处理.HeaderText = "是否已处理";
            this.是否已处理.Name = "是否已处理";
            this.是否已处理.ReadOnly = true;
            // 
            // 是否处理成功
            // 
            this.是否处理成功.DataPropertyName = "是否处理成功";
            this.是否处理成功.HeaderText = "是否处理成功";
            this.是否处理成功.Name = "是否处理成功";
            this.是否处理成功.ReadOnly = true;
            // 
            // 处理用时
            // 
            this.处理用时.DataPropertyName = "处理用时";
            this.处理用时.HeaderText = "处理用时（秒）";
            this.处理用时.Name = "处理用时";
            this.处理用时.ReadOnly = true;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "备注";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            // 
            // contextMenuStrip_LBoxWait
            // 
            this.contextMenuStrip_LBoxWait.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.全选ToolStripMenuItem,
            this.反选ToolStripMenuItem});
            this.contextMenuStrip_LBoxWait.Name = "contextMenuStrip_LBoxWait";
            this.contextMenuStrip_LBoxWait.Size = new System.Drawing.Size(69, 70);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            // 
            // 反选ToolStripMenuItem
            // 
            this.反选ToolStripMenuItem.Name = "反选ToolStripMenuItem";
            this.反选ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.tableLayoutPanel3);
            this.groupBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox_Search.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(432, 132);
            this.groupBox_Search.TabIndex = 2;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "查找内容：";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtOldValue, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.96429F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.03571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(426, 112);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckIsContent);
            this.panel2.Controls.Add(this.ckIsFileName);
            this.panel2.Controls.Add(this.ckIsWhole);
            this.panel2.Controls.Add(this.ckIsNotIgnoreLowerCase);
            this.panel2.Controls.Add(this.ckIsRegexp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 31);
            this.panel2.TabIndex = 0;
            // 
            // ckIsContent
            // 
            this.ckIsContent.AutoSize = true;
            this.ckIsContent.Location = new System.Drawing.Point(337, 8);
            this.ckIsContent.Name = "ckIsContent";
            this.ckIsContent.Size = new System.Drawing.Size(72, 16);
            this.ckIsContent.TabIndex = 11;
            this.ckIsContent.Text = "文件内容";
            this.ckIsContent.UseVisualStyleBackColor = true;
            // 
            // ckIsFileName
            // 
            this.ckIsFileName.AutoSize = true;
            this.ckIsFileName.Location = new System.Drawing.Point(271, 8);
            this.ckIsFileName.Name = "ckIsFileName";
            this.ckIsFileName.Size = new System.Drawing.Size(60, 16);
            this.ckIsFileName.TabIndex = 10;
            this.ckIsFileName.Text = "文件名";
            this.ckIsFileName.UseVisualStyleBackColor = true;
            // 
            // ckIsWhole
            // 
            this.ckIsWhole.AutoSize = true;
            this.ckIsWhole.Location = new System.Drawing.Point(192, 8);
            this.ckIsWhole.Name = "ckIsWhole";
            this.ckIsWhole.Size = new System.Drawing.Size(72, 16);
            this.ckIsWhole.TabIndex = 9;
            this.ckIsWhole.Text = "整字匹配";
            this.ckIsWhole.UseVisualStyleBackColor = true;
            // 
            // ckIsNotIgnoreLowerCase
            // 
            this.ckIsNotIgnoreLowerCase.AutoSize = true;
            this.ckIsNotIgnoreLowerCase.Location = new System.Drawing.Point(101, 8);
            this.ckIsNotIgnoreLowerCase.Name = "ckIsNotIgnoreLowerCase";
            this.ckIsNotIgnoreLowerCase.Size = new System.Drawing.Size(84, 16);
            this.ckIsNotIgnoreLowerCase.TabIndex = 8;
            this.ckIsNotIgnoreLowerCase.Text = "区分大小写";
            this.ckIsNotIgnoreLowerCase.UseVisualStyleBackColor = true;
            // 
            // ckIsRegexp
            // 
            this.ckIsRegexp.AutoSize = true;
            this.ckIsRegexp.Location = new System.Drawing.Point(10, 8);
            this.ckIsRegexp.Name = "ckIsRegexp";
            this.ckIsRegexp.Size = new System.Drawing.Size(84, 16);
            this.ckIsRegexp.TabIndex = 7;
            this.ckIsRegexp.Text = "正则表达式";
            this.ckIsRegexp.UseVisualStyleBackColor = true;
            // 
            // txtOldValue
            // 
            this.txtOldValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldValue.Location = new System.Drawing.Point(3, 3);
            this.txtOldValue.Multiline = true;
            this.txtOldValue.Name = "txtOldValue";
            this.txtOldValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOldValue.Size = new System.Drawing.Size(420, 69);
            this.txtOldValue.TabIndex = 6;
            // 
            // groupBox_Replace
            // 
            this.groupBox_Replace.Controls.Add(this.txtNew);
            this.groupBox_Replace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Replace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox_Replace.Location = new System.Drawing.Point(441, 3);
            this.groupBox_Replace.Name = "groupBox_Replace";
            this.groupBox_Replace.Size = new System.Drawing.Size(432, 132);
            this.groupBox_Replace.TabIndex = 3;
            this.groupBox_Replace.TabStop = false;
            this.groupBox_Replace.Text = "替换内容：";
            // 
            // txtNew
            // 
            this.txtNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNew.Location = new System.Drawing.Point(3, 17);
            this.txtNew.Multiline = true;
            this.txtNew.Name = "txtNew";
            this.txtNew.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNew.Size = new System.Drawing.Size(426, 112);
            this.txtNew.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 44);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "执  行";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox_OutPut
            // 
            this.groupBox_OutPut.Controls.Add(this.txtFileLastName);
            this.groupBox_OutPut.Controls.Add(this.txtFileFirstName);
            this.groupBox_OutPut.Controls.Add(this.label3);
            this.groupBox_OutPut.Controls.Add(this.label2);
            this.groupBox_OutPut.Controls.Add(this.label1);
            this.groupBox_OutPut.Controls.Add(this.btnOpenOutPath);
            this.groupBox_OutPut.Controls.Add(this.btnOutPutPath);
            this.groupBox_OutPut.Controls.Add(this.txtOutPutPath);
            this.groupBox_OutPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_OutPut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox_OutPut.Location = new System.Drawing.Point(3, 3);
            this.groupBox_OutPut.Name = "groupBox_OutPut";
            this.groupBox_OutPut.Size = new System.Drawing.Size(694, 68);
            this.groupBox_OutPut.TabIndex = 6;
            this.groupBox_OutPut.TabStop = false;
            this.groupBox_OutPut.Text = "输出选项：";
            // 
            // txtFileLastName
            // 
            this.txtFileLastName.Location = new System.Drawing.Point(519, 38);
            this.txtFileLastName.Name = "txtFileLastName";
            this.txtFileLastName.Size = new System.Drawing.Size(109, 21);
            this.txtFileLastName.TabIndex = 7;
            // 
            // txtFileFirstName
            // 
            this.txtFileFirstName.Location = new System.Drawing.Point(519, 13);
            this.txtFileFirstName.Name = "txtFileFirstName";
            this.txtFileFirstName.Size = new System.Drawing.Size(109, 21);
            this.txtFileFirstName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "文件名后缀：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "文件名前缀：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "输出目录：";
            // 
            // btnOpenOutPath
            // 
            this.btnOpenOutPath.Location = new System.Drawing.Point(383, 26);
            this.btnOpenOutPath.Name = "btnOpenOutPath";
            this.btnOpenOutPath.Size = new System.Drawing.Size(45, 23);
            this.btnOpenOutPath.TabIndex = 2;
            this.btnOpenOutPath.Text = "打开";
            this.btnOpenOutPath.UseVisualStyleBackColor = true;
            this.btnOpenOutPath.Click += new System.EventHandler(this.btnOpenOutPath_Click);
            // 
            // btnOutPutPath
            // 
            this.btnOutPutPath.Location = new System.Drawing.Point(332, 26);
            this.btnOutPutPath.Name = "btnOutPutPath";
            this.btnOutPutPath.Size = new System.Drawing.Size(45, 23);
            this.btnOutPutPath.TabIndex = 1;
            this.btnOutPutPath.Text = "浏览";
            this.btnOutPutPath.UseVisualStyleBackColor = true;
            this.btnOutPutPath.Click += new System.EventHandler(this.btnOutPutPath_Click);
            // 
            // txtOutPutPath
            // 
            this.txtOutPutPath.Location = new System.Drawing.Point(72, 26);
            this.txtOutPutPath.Name = "txtOutPutPath";
            this.txtOutPutPath.ReadOnly = true;
            this.txtOutPutPath.Size = new System.Drawing.Size(254, 21);
            this.txtOutPutPath.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(897, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "处理进度：";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(400, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(346, 17);
            this.toolStripStatusLabel2.Text = "已完成0%，0成功，0失败，正在处理第[0]个文件，共[0]个文件";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Search, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Replace, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 214);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 138);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.93079F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0692F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox_OutPut, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 358);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(876, 74);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(703, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 68);
            this.panel1.TabIndex = 7;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 463);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox_FileInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(913, 483);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " XCLWinKits——Windows软件工具箱  1.0.1.0，Copyright ©2014 by:XCL qq:80213876 ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_FileInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).EndInit();
            this.contextMenuStrip_LBoxWait.ResumeLayout(false);
            this.groupBox_Search.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox_Replace.ResumeLayout(false);
            this.groupBox_Replace.PerformLayout();
            this.groupBox_OutPut.ResumeLayout(false);
            this.groupBox_OutPut.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_FileInfo;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.GroupBox groupBox_Replace;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox_OutPut;
        private System.Windows.Forms.Button btnOutPutPath;
        private System.Windows.Forms.TextBox txtOutPutPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_LBoxWait;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反选ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DataGridView dgFiles;
        private System.Windows.Forms.Button btnOpenOutPath;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 文件名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 路径;
        private System.Windows.Forms.DataGridViewTextBoxColumn 扩展名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否已处理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否处理成功;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处理用时;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileLastName;
        private System.Windows.Forms.TextBox txtFileFirstName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ckIsContent;
        private System.Windows.Forms.CheckBox ckIsFileName;
        private System.Windows.Forms.CheckBox ckIsWhole;
        private System.Windows.Forms.CheckBox ckIsNotIgnoreLowerCase;
        private System.Windows.Forms.CheckBox ckIsRegexp;
        private System.Windows.Forms.TextBox txtOldValue;



    }
}

