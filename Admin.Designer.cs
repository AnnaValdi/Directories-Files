namespace M06_RepteTry2
{
    partial class Admin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCreateDirectory = new System.Windows.Forms.Button();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxPath.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(9, 19);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(326, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(341, 20);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(109, 19);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(499, 19);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(109, 19);
            this.buttonFilter.TabIndex = 3;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(614, 19);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(109, 19);
            this.buttonSort.TabIndex = 4;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.buttonSort);
            this.groupBoxPath.Controls.Add(this.buttonFilter);
            this.groupBoxPath.Controls.Add(this.buttonSelect);
            this.groupBoxPath.Controls.Add(this.textBoxPath);
            this.groupBoxPath.Location = new System.Drawing.Point(23, 25);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(741, 50);
            this.groupBoxPath.TabIndex = 5;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Path";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 238);
            this.listBox1.TabIndex = 0;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.buttonCreateFile);
            this.groupBoxEdit.Controls.Add(this.buttonCreateDirectory);
            this.groupBoxEdit.Controls.Add(this.buttonDelete);
            this.groupBoxEdit.Controls.Add(this.buttonModify);
            this.groupBoxEdit.Controls.Add(this.buttonCreate);
            this.groupBoxEdit.Location = new System.Drawing.Point(522, 109);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(242, 312);
            this.groupBoxEdit.TabIndex = 7;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(42, 194);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(170, 20);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(42, 121);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(170, 22);
            this.buttonModify.TabIndex = 1;
            this.buttonModify.Text = "Modify name";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(42, 56);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(170, 20);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonCreateDirectory
            // 
            this.buttonCreateDirectory.Location = new System.Drawing.Point(42, 89);
            this.buttonCreateDirectory.Name = "buttonCreateDirectory";
            this.buttonCreateDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateDirectory.TabIndex = 3;
            this.buttonCreateDirectory.Text = "Directory";
            this.buttonCreateDirectory.UseVisualStyleBackColor = true;
            this.buttonCreateDirectory.Visible = false;
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Location = new System.Drawing.Point(137, 89);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateFile.TabIndex = 4;
            this.buttonCreateFile.Text = "File";
            this.buttonCreateFile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(26, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 311);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxPath);
            this.Name = "Admin";
            this.Text = "Admin";
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCreateDirectory;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

