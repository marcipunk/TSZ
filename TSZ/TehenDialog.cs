using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TSZ
{
    public partial class TehenDialog : Form
    {
        public TehenDialog()
        {
            InitializeComponent();
            FajtaBox.DataSource = Enum.GetNames(typeof(Fajta));
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DataRow temprow = TehenData.tehenTable.NewRow();

            if (textNev.Text.Length != 0 && textTejhozam.Text.Length != 0 && FajtaBox.SelectedValue is TSZ.Fajta)
            {
                Tehen newtehen = new Tehen(textNev.Text, Int32.Parse(textTejhozam.Text), (TSZ.Fajta)FajtaBox.SelectedValue);
            }


            TehenData.tehenTable.Rows.Add();

        }
    }
}
