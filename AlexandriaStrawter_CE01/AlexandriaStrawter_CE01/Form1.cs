using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexandriaStrawter_CE01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Students Data
        {
            get
            {
                Students s = new Students();
                s.FirstName = firstTextBox.Text;
                s.LastName = lastTextBox.Text;
                s.Age = ageNumeric.Value;
                s.Gender = genderComboBox.Text;
                return s;
            }
            set
            {
                firstTextBox.Text = value.FirstName;
                lastTextBox.Text = value.LastName;
                ageNumeric.Value = value.Age;
                genderComboBox.Text = value.Gender;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data = new Students();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                    using (Stream save = File.Open(saveFile.FileName, FileMode.Create))
                    using (StreamWriter sw = new StreamWriter(save))
                    {
                        sw.Write(firstTextBox.Text + "\r\n");
                        sw.Write(lastTextBox.Text + "\r\n");
                        sw.Write(ageNumeric.Value + "\r\n");
                        sw.Write(genderComboBox.Text + "\r\n");
                    }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream firstStream = null;

            OpenFileDialog loadFiles = new OpenFileDialog();
            loadFiles.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (loadFiles.ShowDialog() == DialogResult.OK)
                        {
                if ((firstStream = loadFiles.OpenFile()) != null) {
                    string fileName = loadFiles.FileName;

                    string fileText = File.ReadAllText(fileName);

                    string[] lines = File.ReadLines(fileName).ToArray();
                    string value = lines[2];
                    decimal ageD;

                    firstTextBox.Text = lines[0];
                    lastTextBox.Text = lines[1];
                    if (Decimal.TryParse(value, out ageD))
                        ageNumeric.Value = ageD;
                    else
                        Console.WriteLine("A valid age was not provided.");
                    genderComboBox.Text = lines[3];
                }
          }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                firstTextBox.ResetText();
                lastTextBox.ResetText();
                ageNumeric.Value = 0;
                genderComboBox.ResetText();
                genderComboBox.SelectedIndex = -1;

        }
    }
}





