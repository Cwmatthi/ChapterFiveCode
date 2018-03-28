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


namespace Tutorial_5_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal sales;
                decimal total = 0m;

                StreamReader inputfile;

                inputfile = File.OpenText("sales.txt");

                while (!inputfile.EndOfStream)
                {
                    sales = decimal.Parse(inputfile.ReadLine());

                    total += sales;
                }
                inputfile.Close();

                totalLabel.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
