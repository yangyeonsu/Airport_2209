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
    public partial class Translate_mem : Form
    {
        public Translate_mem()
        {
            InitializeComponent();
            gvPassenger.AllowUserToAddRows = false;
        }
        SqlConnection sqlcon = new SqlConnection("Server=192.168.0.6; Database=edu2; uid = edu2; pwd = edukornec!@#");
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("정보가 없습니다.");
            }
            else
            {
                try
                {
                    sqlcon.Open();
                    string query = "update tbOne set Name = '" + txtName1.Text + "', Phone ='" + txtPhone1.Text + "', Birth='" + txtBirth1.Text + "', Email='" + txtEmail1.Text + "'where Name = '" + txtName.Text + "'and Phone='" + txtPhone.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("정상적으로 변경되었습니다.");
                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // 'Back'버튼
        private void btnBack_Click(object sender, EventArgs e)
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
            gvPassenger.DataSource = ds.Tables[0];
        }
        // 'Search'버튼
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchNamePhone();
        }

        // gridview
        private void gvPassenger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName1.Text = gvPassenger.SelectedRows[0].Cells[0].Value.ToString();
            txtPhone1.Text = gvPassenger.SelectedRows[0].Cells[2].Value.ToString();
            txtBirth1.Text = gvPassenger.SelectedRows[0].Cells[1].Value.ToString();
            txtEmail1.Text = gvPassenger.SelectedRows[0].Cells[3].Value.ToString();
        }

        // 'Delete'버튼
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("성함과 번호를 적어주세요");
            }
            else
            {
                try
                {
                    sqlcon.Open();
                    string query = "delete from tbOne where Name = '"+txtName1.Text+"'and Phone='"+txtPhone1.Text+"'";
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("정상적으로 정보가 삭제되었습니다.");
                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
