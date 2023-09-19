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
    public partial class Departure : Form
    {
        //List<UserInfoModel> IstUserModel = new List<UserInfoModel>();

        public Departure()
        {
            InitializeComponent();
        }
       
   

/*
        public void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Dispose();
        }
        public void timerstop()
        {
            pictureBox1.Dispose();
        }
*/

        private void btnClose_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

       

        public void btnCost_Click(object sender, EventArgs e)
        {
            if(cbLeave.Text == "")
            {
                MessageBox.Show("출발지를 선택해 주세요");
            }
            else if (cbArrive.Text == "" )
            {
                MessageBox.Show("도착지를 선택해 주세요");
            }

            else if(cbAdult.Text == "" || cbChild.Text == "")
            {
                MessageBox.Show("승객 수를 입력해 주세요");
            }
            else
            {
                try
                {
                    //string query = "insert into tbDeparture(Seat) values('" + cbArrive.SelectedItem.ToString() + "','" + cbLeave.SelectedItem.ToString() + "','" + cbAdult.SelectedItem.ToString() + "','" + cbChild.SelectedItem.ToString() + "','"+null+"')";
                    string query = "insert into tbOne values('" +null+"','"+null+"','"+null+"','"+null+"','"+ cbArrive.SelectedItem.ToString() + "','" + cbLeave.SelectedItem.ToString() + "','" + cbAdult.SelectedIndex + "','" + cbChild.SelectedIndex + "','" + null + "')";
                    SqlCommand comm = new SqlCommand(query, ConnectionDB.sqlcon);
                    comm.ExecuteNonQuery();
                    
                    /*
                    string query2 = "insert into tbFinal select tbDeparture.*, tbGuest.* from tbDeparture cross join tbGuest";
                    SqlCommand comm2 = new SqlCommand(query2, ConnectionDB.sqlcon);
                    comm2.ExecuteNonQuery();
                    */
                }
                catch
                {
                    //throw;
                }

                MessageBox.Show("결제되었습니다. 비행기 좌석을 선택해 주세요.");
                SeatChoice seatChoice = new SeatChoice();
                seatChoice.Show();
                this.Hide();

                /*Identity identity = new Identity();
                identity.Show();*/
                /*SeatChoice seatChoice = new SeatChoice();
                seatChoice.Show();*/
                // this.Hide();

                // 콤보박스id.selectedindex - 0;
                // 0 번째 인덱스 있는 값을 디폴트 값으로 선택되어져 나옴

                // 자리페이지로 이동
            }

           

        }
        /// <summary>
        /// 인원 불러와서
        /// 가격 띄우기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
           // txtCost.Text = cbAdult.SelectedItem.ToString() * 250000 + (cbChild.SelectedIndex+1) * 150000;
        }
    }

    
}
