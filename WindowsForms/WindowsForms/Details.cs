using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Details : Form
    {
        public string TextDisplay
        {
            set
            {
                detailsTextBox.Text = value;
            }
        }
        public Details()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void detailsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void HandleCountChanged(object sender, EventArgs e)
        {
            Form1 mainForm = sender as Form1;

            detailsTextBox.Text = mainForm.ItemCount.ToString();
        }
    }
}
