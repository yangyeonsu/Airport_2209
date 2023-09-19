using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airport
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnLReservation_Click(object sender, EventArgs e)
        {
            if (btnReservation1.Visible == true)
            {
                btnReservation1.Hide();
            }
            else
            {
                btnReservation1.Show();
            }
        }

        private void btnLTranslate_Click(object sender, EventArgs e)
        {
            if (btnTranslate1.Visible == true)
            {
                btnTranslate1.Hide();
                btnTranslate2.Hide();
            }
            else
            {
                btnTranslate1.Show();
                btnTranslate2.Show();
            }
        }

        private void btnLRefund_Click(object sender, EventArgs e)
        {
            if (btnRefund1.Visible == true)
            {
                btnRefund1.Hide();
            }
            else
            {
                btnRefund1.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnReservation1_Click(object sender, EventArgs e)
        {
            Identity identity = new Identity();
            identity.Show();
            this.Hide();
        }


        private void btnTranslate1_Click(object sender, EventArgs e)
        {
            Translate translate = new Translate();
            translate.Show();
            this.Hide();
        }
        private void btnTranslate2_Click(object sender, EventArgs e)
        {
            Translate_mem translate_mem = new Translate_mem();
            translate_mem.Show();
            this.Hide();
        }


        private void btnRefund1_Click(object sender, EventArgs e)
        {
            Refund refund = new Refund();
            refund.Show();
            this.Hide();
        }
    }
}
