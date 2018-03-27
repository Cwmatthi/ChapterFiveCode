using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            const int START_SPEED = 30;
            const int END_SPEED = 230;
            const int INTERVAL = 10;
            const double CONVERSION_FACTOR = 0.6214;

            int kph;
            double mph;
            try
            {
                for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
                {
                    mph = kph * CONVERSION_FACTOR;

                    outputListBox.Items.Add(kph + " KPH is the as " + mph + " MPH ");

                }
            }
            catch
            { }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
