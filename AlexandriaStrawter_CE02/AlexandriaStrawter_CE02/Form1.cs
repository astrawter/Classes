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
    public partial class Form1 : Form
    {
        private EventHandler ItemCountChanged;

        public Form1()
        {
            InitializeComponent();
        }

        public int ItemCount
        {
            get
            {
                return listBox1.Items.Count;
            }
        }

        public int ItemCount2
        {
            get
            {
                return listBox2.Items.Count;
            }
        }
        public Character Data
        {
            get
            {
                Character c = new Character();
                c.Name = textBox1.Text;
                c.Gender = comboBox1.Text;
                c.Description = richTextBox1.Text;
                c.Race = checkBox1.Checked;

                return c;
            }
            set
            {
                textBox1.Text = value.Name;
                comboBox1.Text = value.Gender;
                richTextBox1.Text = value.Description;
                checkBox1.Checked = value.Race;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Data);

            Data = new Character();

            if (ItemCountChanged != null)
            {
                ItemCountChanged(this, new EventArgs());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < listBox1.Items.Count)
            {
                Character c = listBox1.Items[listBox1.SelectedIndex] as Character;

                Data = c;

            }
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stats form = new Stats();

            ItemCountChanged += form.HandleCountChanged;

            form.TextDisplay = listBox1.Items.Count.ToString();
            form.TextDisplay = listBox2.Items.Count.ToString();

            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            comboBox1.ResetText();
            comboBox1.SelectedIndex = -1;
            richTextBox1.ResetText();
            checkBox1.Checked = false;
        }
    }
}
