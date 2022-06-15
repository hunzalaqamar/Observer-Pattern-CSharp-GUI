using SCD_LAB_W14.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCD_LAB_W14.Admin
{
    public partial class AdminMainForm : Form
    {
        NewsSubject NS = new NewsSubject();
        public AdminMainForm()
        {
            InitializeComponent();

            for(int i = 0; i < NS.getNewsTypes().Count; i++)
            {
                cb_newstype.Items.Add(NS.getNewsTypes()[i]);
            }
            cb_newstype.SelectedIndex = 0;
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_addNewsType_Click(object sender, EventArgs e)
        {
            if (txt_addNewsType.Text.ToString().Equals(""))
            {
                MessageBox.Show("Invalid Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (NS.getNewsTypes().Contains(txt_addNewsType.Text.ToString()))
                {
                    MessageBox.Show("Type Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NS.getNewsTypes().Add(txt_addNewsType.Text.ToString());
                    cb_newstype.Items.Add(txt_addNewsType.Text.ToString());
                    MessageBox.Show("Type Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cb_newstype.SelectedIndex = 0;
            txt_newsdetails.Clear();
        }

        private void btn_postNews_Click(object sender, EventArgs e)
        {
            if(txt_newsdetails.Text.ToString().Equals("") || cb_newstype.Text.ToString().Equals("None") || cb_newstype.Text.ToString().Equals(""))
            {
                MessageBox.Show("Invalid Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                NS.addNews(cb_newstype.Text.ToString(), txt_newsdetails.Text.ToString());
                MessageBox.Show("News Posted Successfully under " + cb_newstype.Text.ToString() + " Topic ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_newstype.SelectedIndex = 0;
                txt_newsdetails.Clear();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LF = new LoginForm();
            LF.Show();
        }
    }
}
