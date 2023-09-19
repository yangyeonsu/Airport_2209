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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 타이머
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();   
            
            Menu menu = new Menu();
            menu.Show();
            pictureBox1.Dispose();
        }










        /*private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("아이디와 비밀번호를 입력해 주세요.");
            }
            else if(txtUsername.Text == "admin" && txtPassword.Text == "0000")
            {
                MessageBox.Show("로그인 되었습니다.");
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("잘못된 정보입니다.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }*/
    }
}
