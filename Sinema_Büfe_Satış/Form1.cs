using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, water, tea, ticket, total;
            popcorn = Convert.ToInt16(txtmısır.Text);
            water = Convert.ToInt16(txtsu.Text);
            tea = Convert.ToInt16(txtçay.Text);
            ticket = Convert.ToInt16(txtbilet.Text);
            total = popcorn * 4 + water * 1 + tea * 2 + ticket * 8;
            lbltoplam.Text = total.ToString() + " TL";
            kasatutar = kasatutar + total;
            lblkasa.Text = kasatutar.ToString() + " TL";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtmısır.Text = "";
            txtsu.Text = "";
            txtçay.Text = "";
            txtbilet.Text = "";
            lbltoplam.Text = "00 TL";
            txtmısır.Focus();


        }
    }
}
