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

    public partial class Identity : Form
    {

        public Identity()
        {
            InitializeComponent();
            pnDeparture.Hide();

            this.txtName.KeyDown+= btn_KeyDown;
            this.txtPhone.KeyDown += btn_KeyDown;
            this.txtEmail.KeyDown += btn_KeyDown;
            this.txtBirth.KeyDown += btn_KeyDown;
        }

        // 엔터키 == btnCheck_Click
        private void btn_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCheck_Click(sender, e);
            }
        }

        // 'x' 버튼
        private void btnClose_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        private void btnClose2_Click(object sender, EventArgs e)
        {
            Identity identity = new Identity();
            this.Hide();
        }

        // 백스페이스와 숫자를 제외한 나머지를 바로 처리
        private void txtBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar == Convert.ToChar(Keys.Back) || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        public int Adult()
        {
            if(rbAdult.Checked == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int Child()
        {
            if(rbChild.Checked == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        

        // '확인' 버튼
        SqlConnection sqlcon = new SqlConnection("Server=192.168.0.6; Database=edu2; uid = edu2; pwd = edukornec!@#");
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtBirth.Text == "" || txtPhone.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("정보를 모두 기입해 주세요.");
            }
            else
            {
                pnDeparture.Show();
            }
        }

        
        // '비행기좌석선택' 버튼
        private void btnSeat_Click(object sender, EventArgs e)
        {
            
            if (cbLeave.Text == "")
            {
                MessageBox.Show("출발지를 선택해 주세요");
            }
            else if (cbArrive.Text == "")
            {
                MessageBox.Show("도착지를 선택해 주세요");
            }

            else if (rbAdult.Checked == false && rbChild.Checked == false)
            {
                MessageBox.Show("승객을 선택해 주세요");
            }
            else if(txtCost.Text == "")
            {
                MessageBox.Show("가격을 확인해 주세요");
            }
            else
            {
                try
                {
                    //string query = "insert into tbDeparture(Seat) values('" + cbArrive.SelectedItem.ToString() + "','" + cbLeave.SelectedItem.ToString() + "','" + cbAdult.SelectedItem.ToString() + "','" + cbChild.SelectedItem.ToString() + "','"+null+"')";
                    string query = "insert into tbOne values('" + txtName.Text + "','" + txtBirth.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" 
                        + cbLeave.SelectedItem.ToString() + "','" + cbArrive.SelectedItem.ToString() + "','" + Adult() + "','" + Child() + "','" + null + "')";
                    SqlCommand comm = new SqlCommand(query, ConnectionDB.sqlcon);
                    comm.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }

                MessageBox.Show("비행기 좌석선택 페이지로 넘어갑니다.");

                SeatChoice seatChoice = new SeatChoice();
                seatChoice.Show();
                // 이름넘기기
                seatChoice.txtName1.Text = txtName.Text;

                this.Hide();  
            }
        }

        
        // 금액계산
        public void Cost()
        {
            decimal Account = Adult();
            decimal Ccount = Child();
            decimal Cost = Account * 550000 + Ccount * 390000;
            this.txtCost.Text = Cost.ToString();
        }


        // '확인'버튼
        public void btnPNum_Click(object sender, EventArgs e)
        {
            int adult = Adult();
            int child = Child();
            if (adult == 0 && child == 0)
            {
                MessageBox.Show("대인/소인을 선택을 해 주세요.");
            }
            else 
            {
                Cost();
            }
        }
    }
}
