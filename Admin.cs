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
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();

            if(result.Equals(DialogResult.OK))
            {
                textBoxPath.Text = folder.SelectedPath;
                directoryActual = new DirectoryInfo(textBoxPath.Text);
            }
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            filter.ShowDialog(); 
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();
            sort.ShowDialog();
        }

    }
}
