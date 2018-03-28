using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_5_8
{
    public partial class CoinToss : Form
    {
        public CoinToss()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            int sideUp;

            Random rand = new Random();

            sideUp = rand.Next(2);
            
            if (sideUp == 0)
            {
                  //if Tails is displayed
                tailsPictureBox.Visible = true;
                headsPicturebox.Visible = false;
            }
            else
            {
                //If Heads is displayed
                headsPicturebox.Visible = true;
                tailsPictureBox.Visible = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
