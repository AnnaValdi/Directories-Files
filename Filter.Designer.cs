namespace M06_RepteTry2
{
    partial class Filter
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
            this.checkBoxDir = new System.Windows.Forms.CheckBox();
            this.checkBoxFile = new System.Windows.Forms.CheckBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonFiltered = new System.Windows.Forms.Button();
            this.groupBoxType.SuspendLayout();
            this.SuspendLayout();
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
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.checkBoxFile);
            this.groupBoxType.Controls.Add(this.checkBoxDir);
            this.groupBoxType.Location = new System.Drawing.Point(15, 12);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(105, 67);
            this.groupBoxType.TabIndex = 2;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Type";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 91);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // buttonFiltered
            // 
            this.buttonFiltered.Location = new System.Drawing.Point(101, 265);
            this.buttonFiltered.Name = "buttonFiltered";
            this.buttonFiltered.Size = new System.Drawing.Size(106, 26);
            this.buttonFiltered.TabIndex = 5;
            this.buttonFiltered.Text = "Filter";
            this.buttonFiltered.UseVisualStyleBackColor = true;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 296);
            this.Controls.Add(this.buttonFiltered);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBoxType);
            this.Name = "Filter";
            this.Text = "Filter";
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDir;
        private System.Windows.Forms.CheckBox checkBoxFile;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonFiltered;
    }
}