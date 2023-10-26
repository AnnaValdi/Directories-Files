namespace M06_RepteTry2
{
    partial class Sort
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxSortName = new System.Windows.Forms.CheckBox();
            this.checkBoxSortDate = new System.Windows.Forms.CheckBox();
            this.checkBoxSortType = new System.Windows.Forms.CheckBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "upward";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "downward";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBoxSortName
            // 
            this.checkBoxSortName.AutoSize = true;
            this.checkBoxSortName.Location = new System.Drawing.Point(19, 29);
            this.checkBoxSortName.Name = "checkBoxSortName";
            this.checkBoxSortName.Size = new System.Drawing.Size(54, 17);
            this.checkBoxSortName.TabIndex = 4;
            this.checkBoxSortName.Text = "Name";
            this.checkBoxSortName.UseVisualStyleBackColor = true;
            // 
            // checkBoxSortDate
            // 
            this.checkBoxSortDate.AutoSize = true;
            this.checkBoxSortDate.Location = new System.Drawing.Point(19, 52);
            this.checkBoxSortDate.Name = "checkBoxSortDate";
            this.checkBoxSortDate.Size = new System.Drawing.Size(49, 17);
            this.checkBoxSortDate.TabIndex = 5;
            this.checkBoxSortDate.Text = "Date";
            this.checkBoxSortDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxSortType
            // 
            this.checkBoxSortType.AutoSize = true;
            this.checkBoxSortType.Location = new System.Drawing.Point(19, 75);
            this.checkBoxSortType.Name = "checkBoxSortType";
            this.checkBoxSortType.Size = new System.Drawing.Size(50, 17);
            this.checkBoxSortType.TabIndex = 6;
            this.checkBoxSortType.Text = "Type";
            this.checkBoxSortType.UseVisualStyleBackColor = true;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(61, 118);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(57, 25);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 155);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.checkBoxSortType);
            this.Controls.Add(this.checkBoxSortDate);
            this.Controls.Add(this.checkBoxSortName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Sort";
            this.Text = "Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxSortName;
        private System.Windows.Forms.CheckBox checkBoxSortDate;
        private System.Windows.Forms.CheckBox checkBoxSortType;
        private System.Windows.Forms.Button buttonSort;
    }
}