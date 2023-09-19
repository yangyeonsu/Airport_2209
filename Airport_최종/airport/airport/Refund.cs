using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace airport
{
    public partial class Refund : Form
    {
        public Refund()
        {
            InitializeComponent();
            gvRefund.AllowUserToAddRows = false;
        }
        SqlConnection sqlcon = new SqlConnection("Server=192.168.0.6; Database=edu2; uid = edu2; pwd = edukornec!@#");

        // 'x'버튼
        private void btnClose_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void SearchNamePhone()
        {
            string query = "select *from tbOne where Name='" + txtName.Text + "'and Phone='" + txtPhone.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            SqlCommandBuilder sbd = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            gvRefund.DataSource = ds.Tables[0];
            infomation();
        }

        // '확인'버튼
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("이름과 전화번호를 적어주세요");
            }
            else
            {
                SearchNamePhone();
                Cost();
            }
        }


        public void infomation()
        {
            txtLeave.Text = gvRefund.Rows[0].Cells[4].Value.ToString();
            txtArrive.Text = gvRefund.Rows[0].Cells[5].Value.ToString();
            txtAdult.Text = gvRefund.Rows[0].Cells[6].Value.ToString();
            txtChild.Text = gvRefund.Rows[0].Cells[7].Value.ToString();
        }

        public void Cost()
        {
            int Cost = int.Parse(txtAdult.Text)*55000 + int.Parse(txtChild.Text)*39000;
            txtCost.Text = Cost.ToString();
        }


        // '환불하기'버튼
        private void btnRefund_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "delete from tbOne where Name = '" + txtName.Text + "'and Phone='" + txtPhone.Text + "'";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("성공적으로 환불되었습니다.");
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
