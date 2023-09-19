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
    public partial class Card : Form
    {
        public Card()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SeatChoice seatChoice = new SeatChoice();
            seatChoice.Show();
            this.Hide();
        }

        private void btnKoreaCard_Click(object sender, EventArgs e)
        {
            gbKoreaPay1.Show();
            gbKoreaPay2.Show();

            gbNaverPay2.Hide();
            gbKakaoPay2.Hide();
            gbTossPay2.Hide();
            gbBankTransfer1.Hide();
            gbBankTransfer2.Hide();

            btnCost.Show();
        }

        private void btnNaverPay_Click(object sender, EventArgs e)
        {
            gbNaverPay2.Show();

            gbKoreaPay1.Hide();
            gbKoreaPay2.Hide();
            gbKakaoPay2.Hide();
            gbTossPay2.Hide();
            gbBankTransfer1.Hide();
            gbBankTransfer2.Hide();

            btnCost.Show();
        }

        private void btnKakaoPay_Click(object sender, EventArgs e)
        {
            gbKakaoPay2.Show();

            gbKoreaPay1.Hide();
            gbKoreaPay2.Hide();
            gbNaverPay2.Hide();
            gbTossPay2.Hide();
            gbBankTransfer1.Hide();
            gbBankTransfer2.Hide();

            btnCost.Show();
        }

        private void btnTossPay_Click(object sender, EventArgs e)
        {
            gbTossPay2.Show();

            gbKoreaPay1.Hide();
            gbKoreaPay2.Hide();
            gbNaverPay2.Hide();
            gbKakaoPay2.Hide();
            gbBankTransfer1.Hide();
            gbBankTransfer2.Hide();

            btnCost.Show();
        }

        private void btnBankTransfer_Click(object sender, EventArgs e)
        {
            gbBankTransfer1.Show();
            gbBankTransfer2.Show();

            gbKoreaPay1.Hide();
            gbKoreaPay2.Hide();
            gbNaverPay2.Hide();
            gbKakaoPay2.Hide();
            gbTossPay2.Hide();

            btnCost.Show();
        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("정상적으로 결제되었습니다.");
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
