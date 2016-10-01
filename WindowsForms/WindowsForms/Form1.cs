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
                return charactersListBox.Items.Count;
            }
        }
        public Character Data
        {
            get
            {
                Character c = new Character();
                c.FirstName = textBox1.Text;
                c.LastName = textBox2.Text;
                c.Gender = genderComboBox.Text;
                c.Age = numericUpDown1.Value;
                c.Immortal = immortalCheckBox.Checked;
                c.Weapon = textBox3.Text;

                return c;
            }
            set
            {
                textBox1.Text = value.FirstName;
                textBox2.Text = value.LastName;
                genderComboBox.Text = value.Gender;
                numericUpDown1.Value = value.Age;
                immortalCheckBox.Checked = value.Immortal;
                textBox3.Text = value.Weapon;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            charactersListBox.Items.Add(Data);

            Data = new Character();

            if(ItemCountChanged != null) { 
            ItemCountChanged(this, new EventArgs());
            }
        }

        private void charactersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charactersListBox.SelectedIndex >= 0 && charactersListBox.SelectedIndex < charactersListBox.Items.Count) { 
            Character c = charactersListBox.Items[charactersListBox.SelectedIndex] as Character;

                Data = c;

            }
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Details form = new Details();

            ItemCountChanged += form.HandleCountChanged;

            form.TextDisplay = charactersListBox.Items.Count.ToString();

            form.Show();
        }
    }
}
