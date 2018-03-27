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


namespace Tutorial_5_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText("Friend.txt");

                outputFile.WriteLine(nameTextBox.Text);

                outputFile.Close();

                MessageBox.Show("The name was written.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
