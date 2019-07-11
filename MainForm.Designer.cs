namespace DatabaseDocumentGenerator
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelConnectionType = new System.Windows.Forms.Label();
            this.comboBoxConnectionType = new System.Windows.Forms.ComboBox();
            this.labelConnectionString = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.dataGridViewTables = new System.Windows.Forms.DataGridView();
            this.labelEngineType = new System.Windows.Forms.Label();
            this.comboBoxGenerationEngineType = new System.Windows.Forms.ComboBox();
            this.labelTemplateType = new System.Windows.Forms.Label();
            this.comboBoxGenerationTemplateType = new System.Windows.Forms.ComboBox();
            this.dataGridViewTableColumns = new System.Windows.Forms.DataGridView();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelTables = new System.Windows.Forms.Label();
            this.labelTableColumns = new System.Windows.Forms.Label();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConnectionType
            // 
            resources.ApplyResources(this.labelConnectionType, "labelConnectionType");
            this.labelConnectionType.Name = "labelConnectionType";
            // 
            // comboBoxConnectionType
            // 
            this.comboBoxConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConnectionType.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxConnectionType, "comboBoxConnectionType");
            this.comboBoxConnectionType.Name = "comboBoxConnectionType";
            this.comboBoxConnectionType.SelectedIndexChanged += new System.EventHandler(this.Connection_Selected);
            // 
            // labelConnectionString
            // 
            resources.ApplyResources(this.labelConnectionString, "labelConnectionString");
            this.labelConnectionString.Name = "labelConnectionString";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // buttonConnect
            // 
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTables
            // 
            this.dataGridViewTables.AllowUserToAddRows = false;
            this.dataGridViewTables.AllowUserToDeleteRows = false;
            this.dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3});
            resources.ApplyResources(this.dataGridViewTables, "dataGridViewTables");
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.ReadOnly = true;
            this.dataGridViewTables.RowTemplate.Height = 37;
            // 
            // labelEngineType
            // 
            resources.ApplyResources(this.labelEngineType, "labelEngineType");
            this.labelEngineType.Name = "labelEngineType";
            // 
            // comboBoxGenerationEngineType
            // 
            this.comboBoxGenerationEngineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenerationEngineType.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxGenerationEngineType, "comboBoxGenerationEngineType");
            this.comboBoxGenerationEngineType.Name = "comboBoxGenerationEngineType";
            this.comboBoxGenerationEngineType.SelectedIndexChanged += new System.EventHandler(this.Engine_Selected);
            // 
            // labelTemplateType
            // 
            resources.ApplyResources(this.labelTemplateType, "labelTemplateType");
            this.labelTemplateType.Name = "labelTemplateType";
            // 
            // comboBoxGenerationTemplateType
            // 
            this.comboBoxGenerationTemplateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenerationTemplateType.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxGenerationTemplateType, "comboBoxGenerationTemplateType");
            this.comboBoxGenerationTemplateType.Name = "comboBoxGenerationTemplateType";
            this.comboBoxGenerationTemplateType.SelectedIndexChanged += new System.EventHandler(this.Template_Selected);
            // 
            // dataGridViewTableColumns
            // 
            this.dataGridViewTableColumns.AllowUserToAddRows = false;
            this.dataGridViewTableColumns.AllowUserToDeleteRows = false;
            this.dataGridViewTableColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column6});
            resources.ApplyResources(this.dataGridViewTableColumns, "dataGridViewTableColumns");
            this.dataGridViewTableColumns.Name = "dataGridViewTableColumns";
            this.dataGridViewTableColumns.ReadOnly = true;
            this.dataGridViewTableColumns.RowTemplate.Height = 37;
            // 
            // buttonGenerate
            // 
            resources.ApplyResources(this.buttonGenerate, "buttonGenerate");
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.Generate);
            // 
            // labelTables
            // 
            resources.ApplyResources(this.labelTables, "labelTables");
            this.labelTables.Name = "labelTables";
            // 
            // labelTableColumns
            // 
            resources.ApplyResources(this.labelTableColumns, "labelTableColumns");
            this.labelTableColumns.Name = "labelTableColumns";
            // 
            // Column7
            // 
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Column8
            // 
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTableColumns);
            this.Controls.Add(this.labelTables);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.dataGridViewTableColumns);
            this.Controls.Add(this.comboBoxGenerationTemplateType);
            this.Controls.Add(this.labelTemplateType);
            this.Controls.Add(this.comboBoxGenerationEngineType);
            this.Controls.Add(this.labelEngineType);
            this.Controls.Add(this.dataGridViewTables);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelConnectionString);
            this.Controls.Add(this.comboBoxConnectionType);
            this.Controls.Add(this.labelConnectionType);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConnectionType;
        private System.Windows.Forms.ComboBox comboBoxConnectionType;
        private System.Windows.Forms.Label labelConnectionString;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.DataGridView dataGridViewTables;
        private System.Windows.Forms.Label labelEngineType;
        private System.Windows.Forms.ComboBox comboBoxGenerationEngineType;
        private System.Windows.Forms.Label labelTemplateType;
        private System.Windows.Forms.ComboBox comboBoxGenerationTemplateType;
        private System.Windows.Forms.DataGridView dataGridViewTableColumns;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelTables;
        private System.Windows.Forms.Label labelTableColumns;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

