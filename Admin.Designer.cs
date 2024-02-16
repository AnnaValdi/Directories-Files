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
            this.dateTimePickerFilter = new System.Windows.Forms.DateTimePicker();
            this.buttonDate = new System.Windows.Forms.Button();
            this.buttonType = new System.Windows.Forms.Button();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioButtonType = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.buttonUpDown = new System.Windows.Forms.Button();
            this.radioButtonDate = new System.Windows.Forms.RadioButton();
            this.checkBoxFile = new System.Windows.Forms.CheckBox();
            this.checkBoxDir = new System.Windows.Forms.CheckBox();
            this.listBoxPath = new System.Windows.Forms.ListBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.textBoxCreate = new System.Windows.Forms.TextBox();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.buttonCreateDirectory = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxJSON = new System.Windows.Forms.GroupBox();
            this.textBoxJSON = new System.Windows.Forms.TextBox();
            this.buttonCreateJSON = new System.Windows.Forms.Button();
            this.groupBoxPath.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxJSON.SuspendLayout();
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
            this.buttonSelect.Size = new System.Drawing.Size(85, 19);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(453, 20);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(99, 19);
            this.buttonFilter.TabIndex = 3;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(578, 20);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(109, 19);
            this.buttonSort.TabIndex = 4;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.dateTimePickerFilter);
            this.groupBoxPath.Controls.Add(this.buttonDate);
            this.groupBoxPath.Controls.Add(this.buttonType);
            this.groupBoxPath.Controls.Add(this.groupBoxType);
            this.groupBoxPath.Controls.Add(this.buttonSort);
            this.groupBoxPath.Controls.Add(this.buttonFilter);
            this.groupBoxPath.Controls.Add(this.buttonSelect);
            this.groupBoxPath.Controls.Add(this.textBoxPath);
            this.groupBoxPath.Location = new System.Drawing.Point(23, 25);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(701, 149);
            this.groupBoxPath.TabIndex = 5;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Path";
            // 
            // dateTimePickerFilter
            // 
            this.dateTimePickerFilter.Location = new System.Drawing.Point(431, 111);
            this.dateTimePickerFilter.Name = "dateTimePickerFilter";
            this.dateTimePickerFilter.Size = new System.Drawing.Size(143, 20);
            this.dateTimePickerFilter.TabIndex = 9;
            // 
            // buttonDate
            // 
            this.buttonDate.Location = new System.Drawing.Point(471, 84);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(65, 21);
            this.buttonDate.TabIndex = 13;
            this.buttonDate.Text = "Date";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // buttonType
            // 
            this.buttonType.Location = new System.Drawing.Point(471, 44);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(65, 21);
            this.buttonType.TabIndex = 12;
            this.buttonType.Text = "Type";
            this.buttonType.UseVisualStyleBackColor = true;
            this.buttonType.Click += new System.EventHandler(this.buttonType_Click);
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioButtonType);
            this.groupBoxType.Controls.Add(this.radioButtonName);
            this.groupBoxType.Controls.Add(this.buttonUpDown);
            this.groupBoxType.Controls.Add(this.radioButtonDate);
            this.groupBoxType.Controls.Add(this.checkBoxFile);
            this.groupBoxType.Controls.Add(this.checkBoxDir);
            this.groupBoxType.Location = new System.Drawing.Point(578, 45);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(105, 86);
            this.groupBoxType.TabIndex = 9;
            this.groupBoxType.TabStop = false;
            // 
            // radioButtonType
            // 
            this.radioButtonType.AutoSize = true;
            this.radioButtonType.Location = new System.Drawing.Point(9, 64);
            this.radioButtonType.Name = "radioButtonType";
            this.radioButtonType.Size = new System.Drawing.Size(49, 17);
            this.radioButtonType.TabIndex = 16;
            this.radioButtonType.TabStop = true;
            this.radioButtonType.Text = "Type";
            this.radioButtonType.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(9, 17);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(53, 17);
            this.radioButtonName.TabIndex = 14;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Name";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // buttonUpDown
            // 
            this.buttonUpDown.Location = new System.Drawing.Point(71, 19);
            this.buttonUpDown.Name = "buttonUpDown";
            this.buttonUpDown.Size = new System.Drawing.Size(28, 21);
            this.buttonUpDown.TabIndex = 10;
            this.buttonUpDown.Text = "↑";
            this.buttonUpDown.UseVisualStyleBackColor = true;
            this.buttonUpDown.Click += new System.EventHandler(this.buttonUpDown_Click);
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Location = new System.Drawing.Point(9, 40);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(48, 17);
            this.radioButtonDate.TabIndex = 15;
            this.radioButtonDate.TabStop = true;
            this.radioButtonDate.Text = "Date";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxFile
            // 
            this.checkBoxFile.AutoSize = true;
            this.checkBoxFile.Location = new System.Drawing.Point(9, 44);
            this.checkBoxFile.Name = "checkBoxFile";
            this.checkBoxFile.Size = new System.Drawing.Size(47, 17);
            this.checkBoxFile.TabIndex = 1;
            this.checkBoxFile.Text = "Files";
            this.checkBoxFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxDir
            // 
            this.checkBoxDir.AutoSize = true;
            this.checkBoxDir.Location = new System.Drawing.Point(9, 19);
            this.checkBoxDir.Name = "checkBoxDir";
            this.checkBoxDir.Size = new System.Drawing.Size(76, 17);
            this.checkBoxDir.TabIndex = 0;
            this.checkBoxDir.Text = "Directories";
            this.checkBoxDir.UseVisualStyleBackColor = true;
            // 
            // listBoxPath
            // 
            this.listBoxPath.FormattingEnabled = true;
            this.listBoxPath.Location = new System.Drawing.Point(37, 38);
            this.listBoxPath.Name = "listBoxPath";
            this.listBoxPath.Size = new System.Drawing.Size(400, 238);
            this.listBoxPath.TabIndex = 0;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.textBoxCreate);
            this.groupBoxEdit.Controls.Add(this.buttonCreateFile);
            this.groupBoxEdit.Controls.Add(this.buttonCreateDirectory);
            this.groupBoxEdit.Controls.Add(this.buttonDelete);
            this.groupBoxEdit.Controls.Add(this.buttonModify);
            this.groupBoxEdit.Location = new System.Drawing.Point(522, 302);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(202, 175);
            this.groupBoxEdit.TabIndex = 7;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit";
            // 
            // textBoxCreate
            // 
            this.textBoxCreate.Location = new System.Drawing.Point(34, 19);
            this.textBoxCreate.Name = "textBoxCreate";
            this.textBoxCreate.Size = new System.Drawing.Size(150, 20);
            this.textBoxCreate.TabIndex = 6;
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Location = new System.Drawing.Point(34, 45);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(150, 23);
            this.buttonCreateFile.TabIndex = 4;
            this.buttonCreateFile.Text = "Create file";
            this.buttonCreateFile.UseVisualStyleBackColor = true;
            // 
            // buttonCreateDirectory
            // 
            this.buttonCreateDirectory.Location = new System.Drawing.Point(34, 74);
            this.buttonCreateDirectory.Name = "buttonCreateDirectory";
            this.buttonCreateDirectory.Size = new System.Drawing.Size(150, 23);
            this.buttonCreateDirectory.TabIndex = 3;
            this.buttonCreateDirectory.Text = "Create directory";
            this.buttonCreateDirectory.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(34, 131);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 20);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(34, 103);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(150, 22);
            this.buttonModify.TabIndex = 1;
            this.buttonModify.Text = "Modify name";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 311);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxJSON
            // 
            this.groupBoxJSON.Controls.Add(this.textBoxJSON);
            this.groupBoxJSON.Controls.Add(this.buttonCreateJSON);
            this.groupBoxJSON.Location = new System.Drawing.Point(524, 195);
            this.groupBoxJSON.Name = "groupBoxJSON";
            this.groupBoxJSON.Size = new System.Drawing.Size(202, 93);
            this.groupBoxJSON.TabIndex = 8;
            this.groupBoxJSON.TabStop = false;
            this.groupBoxJSON.Text = "JSON";
            // 
            // textBoxJSON
            // 
            this.textBoxJSON.Location = new System.Drawing.Point(32, 19);
            this.textBoxJSON.Name = "textBoxJSON";
            this.textBoxJSON.Size = new System.Drawing.Size(150, 20);
            this.textBoxJSON.TabIndex = 5;
            // 
            // buttonCreateJSON
            // 
            this.buttonCreateJSON.Location = new System.Drawing.Point(32, 45);
            this.buttonCreateJSON.Name = "buttonCreateJSON";
            this.buttonCreateJSON.Size = new System.Drawing.Size(150, 23);
            this.buttonCreateJSON.TabIndex = 4;
            this.buttonCreateJSON.Text = "Create JSON";
            this.buttonCreateJSON.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 504);
            this.Controls.Add(this.groupBoxJSON);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxPath);
            this.Name = "Admin";
            this.Text = "Admin";
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxJSON.ResumeLayout(false);
            this.groupBoxJSON.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.ListBox listBoxPath;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonCreateDirectory;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.CheckBox checkBoxFile;
        private System.Windows.Forms.CheckBox checkBoxDir;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.Button buttonType;
        private System.Windows.Forms.Button buttonUpDown;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilter;
        private System.Windows.Forms.RadioButton radioButtonType;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonDate;
        private System.Windows.Forms.GroupBox groupBoxJSON;
        private System.Windows.Forms.Button buttonCreateJSON;
        private System.Windows.Forms.TextBox textBoxJSON;
        private System.Windows.Forms.TextBox textBoxCreate;
    }
}

