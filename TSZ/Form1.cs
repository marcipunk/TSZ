using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TSZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.

                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "XML files(*.xml;*.ccnx)|*.xml;*.ccnx";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TehenData tehenek = new TehenData();
                    TehenData.tehenTable.ReadXml(openFileDialog.FileName);
                    //comboBox1.Enabled = true;
                    dataGridView1.DataSource = TehenData.tehenTable;
                }


            
        }

        private void ujTehen_Click(object sender, EventArgs e)
        {
            TehenDialog ujtehen = new TehenDialog();
            ujtehen.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
