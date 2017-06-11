namespace File_Organizer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datItems = new System.Windows.Forms.DataGridView();
            this.chkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dlgAddFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datItems)).BeginInit();
            this.SuspendLayout();
            // 
            // datItems
            // 
            this.datItems.AllowUserToAddRows = false;
            this.datItems.AllowUserToDeleteRows = false;
            this.datItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkBox,
            this.colName,
            this.colType,
            this.colSize,
            this.colCreated,
            this.colModified,
            this.colPath});
            this.datItems.Location = new System.Drawing.Point(12, 155);
            this.datItems.Name = "datItems";
            this.datItems.ReadOnly = true;
            this.datItems.Size = new System.Drawing.Size(897, 290);
            this.datItems.TabIndex = 0;
            // 
            // chkBox
            // 
            this.chkBox.HeaderText = "";
            this.chkBox.Name = "chkBox";
            this.chkBox.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colSize
            // 
            this.colSize.HeaderText = "Size";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            // 
            // colCreated
            // 
            this.colCreated.HeaderText = "Date Created";
            this.colCreated.Name = "colCreated";
            this.colCreated.ReadOnly = true;
            // 
            // colModified
            // 
            this.colModified.HeaderText = "Date Modified";
            this.colModified.Name = "colModified";
            this.colModified.ReadOnly = true;
            // 
            // lstFolders
            // 
            this.lstFolders.FormattingEnabled = true;
            this.lstFolders.Location = new System.Drawing.Point(590, 12);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(319, 82);
            this.lstFolders.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(594, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(701, 111);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 24);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // dlgAddFolder
            // 
            this.dlgAddFolder.ShowNewFolderButton = false;
            // 
            // colPath
            // 
            this.colPath.HeaderText = "Path";
            this.colPath.Name = "colPath";
            this.colPath.ReadOnly = true;
            // 
            // btnGetItems
            // 
            this.btnGetItems.Location = new System.Drawing.Point(811, 111);
            this.btnGetItems.Name = "btnGetItems";
            this.btnGetItems.Size = new System.Drawing.Size(88, 24);
            this.btnGetItems.TabIndex = 4;
            this.btnGetItems.Text = "Get Items";
            this.btnGetItems.UseVisualStyleBackColor = true;
            this.btnGetItems.Click += new System.EventHandler(this.btnGetItems_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 457);
            this.Controls.Add(this.btnGetItems);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstFolders);
            this.Controls.Add(this.datItems);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datItems;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModified;
        private System.Windows.Forms.ListBox lstFolders;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.FolderBrowserDialog dlgAddFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
        private System.Windows.Forms.Button btnGetItems;
    }
}

