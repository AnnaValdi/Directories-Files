using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M06_RepteTry2
{
    public partial class Admin : Form
    {
        DirectoryInfo directoryActual;
        public Admin()
        {
            InitializeComponent();

            //Filter
            buttonType.Visible = false;
            groupBoxType.Visible = false;
            checkBoxDir.Visible = false;   
            checkBoxFile.Visible = false;
            buttonDate.Visible = false;
            dateTimePickerFilter.Visible = false;
            //Sort No funcionen els botons
            //radioButtonName.Visible = false;
            //radioButtonDate.Visible = false;
            //radioButtonType.Visible = false;
            buttonUpDown.Visible = false;

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();

            if(result.Equals(DialogResult.OK))
            {
                textBoxPath.Text = folder.SelectedPath;
                directoryActual = new DirectoryInfo(textBoxPath.Text);

                // Mostrem els directoris
                listBoxPath.Items.Clear();
                foreach (var directory in directoryActual.GetDirectories())
                {
                    listBoxPath.Items.Add(directory.Name);
                }

                // Mostrem els arxius
                foreach (var file in directoryActual.GetFiles())
                {
                    listBoxPath.Items.Add(file.Name);
                }
            }
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (buttonType.Visible == false)
            {
                //true filter
                buttonType.Visible = true;
                buttonDate.Visible = true;
                //false sort
                radioButtonName.Visible = false;
                radioButtonDate.Visible = false;
                radioButtonType.Visible = false;
                groupBoxType.Visible = false;
                buttonUpDown.Visible = false;
            }
            else
            {
                buttonType.Visible = false;
                groupBoxType.Visible = false;
                checkBoxDir.Visible = false;
                checkBoxFile.Visible = false;
                buttonDate.Visible = false;
                dateTimePickerFilter.Visible = false;
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (buttonUpDown.Visible == false)
            {
                //true sort
                radioButtonName.Visible = true;
                radioButtonDate.Visible = true;
                radioButtonType.Visible = true;
                buttonUpDown.Visible = true;
                groupBoxType.Visible = true;
                //false filtre
                buttonType.Visible = false;
                checkBoxDir.Visible = false;
                checkBoxFile.Visible = false;
                buttonDate.Visible = false;
                dateTimePickerFilter.Visible = false;
            }
            else
            {
                radioButtonName.Visible = false;
                radioButtonDate.Visible = false;
                radioButtonType.Visible = false;
                buttonUpDown.Visible = false;
                groupBoxType.Visible = false;
            }
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            if (groupBoxType.Visible == false)
            {
                groupBoxType.Visible = true;
                checkBoxDir.Visible = true;
                checkBoxFile.Visible = true;
            }
            else
            {
                groupBoxType.Visible = false;
                checkBoxDir.Visible = false;
                checkBoxFile.Visible = false;
            }
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFilter.Visible == false)
                dateTimePickerFilter.Visible = true;
            else
                dateTimePickerFilter.Visible = false;
        }

        private void buttonUpDown_Click(object sender, EventArgs e)
        {
            if (buttonUpDown.Text == "↑")
                    buttonUpDown.Text = "↓";
            else
                buttonUpDown.Text = "↑";
        }

    }
}