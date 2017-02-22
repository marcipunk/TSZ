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
        //private DSTehen.dtTehenRow temptehen;
        public string tempnev;
        public int temptej;
        public string tempfajta;
        //public DataGridViewSelectedRowCollection tempRows;
        public int tempid;

        public TehenDialog()
        {
            InitializeComponent();
            FajtaBox.DataSource = Enum.GetValues(typeof(Fajta));

      

        }

        public TehenDialog(DataGridViewRow CurrentRow)
        {
            InitializeComponent();
            FajtaBox.DataSource = Enum.GetValues(typeof(Fajta));

            this.tempid = Int32.Parse(CurrentRow.Cells[0].Value.ToString());
            textNev.Text = CurrentRow.Cells[1].Value.ToString();
            textTejhozam.Text = CurrentRow.Cells[2].Value.ToString();
            FajtaBox.SelectedIndex = (Int32)Enum.Parse(typeof(Fajta), CurrentRow.Cells[3].Value.ToString());

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            

            if (textNev.Text.Length != 0 && textTejhozam.Text.Length != 0 && (Regex.IsMatch(textTejhozam.Text, @"^[0-9]*$")))
            {
                

                tempnev = textNev.Text;
                temptej= Int32.Parse(textTejhozam.Text);
                tempfajta = FajtaBox.SelectedValue.ToString();
                this.DialogResult = DialogResult.OK;
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
