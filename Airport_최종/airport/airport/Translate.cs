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
    public partial class Translate : Form
    {
        public Translate()
        {
            InitializeComponent();
            gvPassenger.AllowUserToAddRows = false;
        }
        SqlConnection sqlcon = new SqlConnection("Server=192.168.0.6; Database=edu2; uid = edu2; pwd = edukornec!@#");


        // 'back'버튼
        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        //gridview
        
        private void gvPassenger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblAdult.Show();
            lblChild.Show();
            cbLeave.Text = gvPassenger.SelectedRows[0].Cells[4].Value.ToString();
            cbArrive.Text = gvPassenger.SelectedRows[0].Cells[5].Value.ToString();
            txtAdult.Text = gvPassenger.SelectedRows[0].Cells[6].Value.ToString();
            txtChild.Text = gvPassenger.SelectedRows[0].Cells[7].Value.ToString();

            if(txtAdult.Text == "1")
            {
                lblChild.Hide();
            }
            else
            {
                lblAdult.Hide();
            }
        }


        private void SearchNamePhone()
        {
            string query = "select *from tbOne where Name='" + txtName.Text + "'and Phone='"+txtPhone.Text+"'";
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

        // 'Update'버튼
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("정보가 없습니다.");
            }
            else
            {
                try
                {
                    sqlcon.Open();
                    string query = "update tbOne set Arrive = '"+cbLeave.Text+"', Leave ='"+cbArrive.Text+"'where Name = '"+txtName.Text+"'and Phone='"+txtPhone.Text+"'";
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("정상적으로 변경되었습니다.");
                    sqlcon.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
