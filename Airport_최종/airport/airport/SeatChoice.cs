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
    public partial class SeatChoice : Form
    {
        public SeatChoice()
        {
            InitializeComponent();
           
            ConnectionDB.Open();

            foreach (RadioButton item in this.tableLayoutPanel1.Controls)
            {
                item.CheckedChanged += Item_CheckedChanged;
            }
        }
        SqlConnection sqlcon = new SqlConnection("Server=192.168.0.6; Database=edu2; uid = edu2; pwd = edukornec!@#");

        private void Item_CheckedChanged(object sender, EventArgs e)
        {
            txtChosenSeat.Text = (sender as RadioButton).Text;
        }
       
        // 'x'버튼
        private void btnClose_Click(object sender, EventArgs e)
        {
            Identity identity = new Identity();
            identity.Show();
            this.Hide();
        }
        

        public void SeatChoice_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            string query = "select * from tbOne";
            SqlDataAdapter sda = new SqlDataAdapter(query, ConnectionDB.sqlcon);
            SqlCommandBuilder sbd = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.IsNullOrWhiteSpace(row["Seat"].ToString()))
                {
                    continue;
                }
                if (this.tableLayoutPanel1.Controls.Find("rb" + row["Seat"].ToString(), false).Count() > 0)
                {
                    (this.tableLayoutPanel1.Controls.Find("rb" + row["Seat"].ToString(), false)[0] as RadioButton).Enabled = false;
                }

            }
        }

        // '예약'버튼
        private void btnReservation_Click(object sender, EventArgs e)
        {
            if(txtChosenSeat.Text == "")
            {
                MessageBox.Show("자리를 선택해 주세요");
            }
            else
            {
                try
                {
                    SeatCheck(txtChosenSeat.Text);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                MessageBox.Show("결제창으로 넘어갑니다.");
                Card card = new Card();
                card.Show();
                this.Hide();
            }
            
        }


        public void SeatCheck(string Seatseat)
        {
            string query2 = "select Seat from tbOne";
            SqlDataAdapter sda = new SqlDataAdapter(query2, ConnectionDB.sqlcon);
            SqlCommandBuilder sbd = new SqlCommandBuilder();
            var ds = new DataSet();
            DataTable dt = new DataTable();
            sda.Fill(ds);


            if(ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ConnectionDB.Open();
                    string query = "update tbOne set Seat = @seat where Name = @Name";//"Phone = @phone ";
                    SqlCommand comm = new SqlCommand(query, ConnectionDB.sqlcon);
                    comm.Parameters.Add("@seat", SqlDbType.VarChar);
                    comm.Parameters.Add("@Name", SqlDbType.VarChar);

                    comm.Parameters["@seat"].Value = txtChosenSeat.Text;
                    comm.Parameters["@Name"].Value = txtName1.Text;

                    comm.ExecuteNonQuery();
                    ConnectionDB.Close();
                    MessageBox.Show("예약되었습니다.");
                    break;
                }
            }
        }
    }
}
