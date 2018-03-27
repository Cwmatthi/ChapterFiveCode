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

namespace Tutorial_5_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                string countryname;

                StreamReader inputfile;

                inputfile = File.OpenText("The Countries.txt");

                countriesListBox.Items.Clear();

                while (!inputfile.EndOfStream)
                {
                    countryname = inputfile.ReadLine();

                    countriesListBox.Items.Add(countryname);
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
