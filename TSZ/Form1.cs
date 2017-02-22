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
        public static string xmlpath;
        string PATH = Properties.Settings.Default.path;

        public Form1()
        {
            InitializeComponent();
            tehenGridView.DataSource = dSTehen.dtTehen;
            
        }


        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.

                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "XML files(*.xml;*.ccnx)|*.xml;*.ccnx";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                //TehenData tehenek = new TehenData();
                xmlpath = openFileDialog.FileName;
                dSTehen.dtTehen.ReadXml(openFileDialog.FileName);
               
                    //comboBox1.Enabled = true;
                    //tehenGridView.DataSource = TehenData.tehenTable;
                }
            
        }

        private void ujTehen_Click(object sender, EventArgs e)
        {
            DSTehen.dtTehenRow newtehen = dSTehen.dtTehen.NewdtTehenRow();
            TehenDialog ujtehen = new TehenDialog();
            ujtehen.ShowDialog();

            DialogResult result = ujtehen.DialogResult;

            if (result == DialogResult.OK)
            {
                newtehen.Id = dSTehen.dtTehen.Count + 1;
                newtehen.Nev = ujtehen.tempnev;
                newtehen.Tejhozam = ujtehen.temptej;
                newtehen.Fajta = ujtehen.tempfajta;

                dSTehen.dtTehen.Rows.Add(newtehen);


                    FileStream xmlstream = new FileStream(PATH, FileMode.OpenOrCreate);

                    dSTehen.dtTehen.WriteXml(xmlstream);
                xmlstream.Close();
            }



        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tehenGridView.Update();
            tehenGridView.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void editTehen_Click(object sender, EventArgs e)
        {
            DSTehen.dtTehenRow temptehen = dSTehen.dtTehen.NewdtTehenRow();
            TehenDialog edittehen = new TehenDialog(tehenGridView.CurrentRow);
            edittehen.ShowDialog();

            DialogResult result = edittehen.DialogResult;

            if (result == DialogResult.OK)
            {

                dSTehen.dtTehen.Rows[edittehen.tempid-1]["Nev"] = edittehen.tempnev;
                dSTehen.dtTehen.Rows[edittehen.tempid - 1]["Tejhozam"] = edittehen.temptej;
                dSTehen.dtTehen.Rows[edittehen.tempid - 1]["Fajta"] = edittehen.tempfajta;

                //dSTehen.dtTehen.Rows.Add(temptehen);


                FileStream xmlstream = new FileStream(PATH, FileMode.OpenOrCreate);

                dSTehen.dtTehen.WriteXml(xmlstream);
                xmlstream.Close();
            }
        }

        private void killTehen_Click(object sender, EventArgs e)
        {
            int selectedid = Int32.Parse(tehenGridView.CurrentRow.Cells[0].Value.ToString());
            DialogResult kill = new DialogResult();
            kill = MessageBox.Show("Biztosan törlöd a kiválasztott tehenet?", "Gyilkos!", MessageBoxButtons.OKCancel);

            for (int i = 0; i < dSTehen.dtTehen.Rows.Count; i++)
            {
                if (dSTehen.dtTehen.Rows[i][0].ToString()  == selectedid.ToString())
                {

                }
            }

            if (kill == DialogResult.OK)
            {
                foreach (DSTehen.dtTehenRow item in dSTehen.dtTehen)
                {
                    if (item.Field<int>(0) == selectedid)
                    {
                        dSTehen.dtTehen.Rows.Remove(item);
                        break;
                    }
                }
            }

            FileStream xmlstream = new FileStream(PATH, FileMode.OpenOrCreate);
            xmlstream.SetLength(0);

            dSTehen.dtTehen.WriteXml(xmlstream);
            xmlstream.Close();

        }
    }
}
