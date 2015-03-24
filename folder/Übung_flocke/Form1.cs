using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Übung_flocke
{
    public partial class Form1 : Form
    {
        bool speed = false;
        int v;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rEin.Checked)
            {
                tmr1.Enabled = true;
            }
            
            try
            {
                if(rAus.Checked)
                {
                    int a;
                    a = Convert.ToInt16(txtZahl.Text);
                    lblAusgabe.Text ="der wert ist" + a.ToString();

                 }
            }
                catch(FormatException)
                {
                    MessageBox.Show("geben sie eine ganze zahl ein");
                }
                
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            v += 6;
            i++;
            picFlocke.Location = new Point(picFlocke.Location.X, picFlocke.Location.Y + i);

          


            if(speed == true)
            {
                picSchuss.Location = new Point(picSchuss.Location.X + v, picSchuss.Location.Y);
            }

            if (picSchuss.Bounds.IntersectsWith(picFlocke.Bounds))
            {
                lblAusgabe.Text = "GETROFFEN";
                tmr1.Enabled = false;
            }

            if(picFlocke.Bounds.IntersectsWith(picBoden.Bounds))
            {
                lblAusgabe.Text = "Nicht Getroffen";
                tmr1.Enabled = false;
            }

            
        }

        private void btnSchuss_Click(object sender, EventArgs e)
        {
          if(speed == false)
          {
              speed = true;
          }
        }
    }
}
