using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexandriaStrawter_CE02
{
    public partial class Stats : Form
    {
        public string TextDisplay
        {
            set
            {
                goodTextBox.Text = value;
                evilTextBox.Text = value;
            }
        }

        public Stats()
        {
            InitializeComponent();
        }

        public void HandleCountChanged(object sender, EventArgs e)
        {
            Form1 mainForm = sender as Form1;

            goodTextBox.Text = mainForm.ItemCount.ToString();
            evilTextBox.Text = mainForm.ItemCount2.ToString();
        }
    }
}
