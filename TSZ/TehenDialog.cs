using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TSZ
{
    public partial class TehenDialog : Form
    {
        public TehenDialog()
        {
            InitializeComponent();
            FajtaBox.DataSource = Enum.GetValues(typeof(Fajta));
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            

            if (textNev.Text.Length != 0 && textTejhozam.Text.Length != 0 && (Regex.IsMatch(textTejhozam.Text, @"^[0-9]*$")))
            {
                DataRow temprow = TehenData.tehenTable.NewRow();
                Tehen newtehen = new Tehen(textNev.Text, Int32.Parse(textTejhozam.Text), (Fajta)FajtaBox.SelectedIndex);
                temprow[0] = newtehen.Id;
                temprow[1] = newtehen.Nev;
                temprow[2] = newtehen.Tejhozam;
                temprow[3] = newtehen.Fajta;
                TehenData.tehenTable.Rows.Add(temprow);
                
                TehenData.tehenTable.WriteXml(Form1.xmlpath);
                this.Close();
            }
            else
            {
                MessageBox.Show("Valami nincs kitöltve!");
            }

            
            
        }


        private void textTejhozam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)/* && (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }


    }
}
