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

namespace SCD_LAB_W14
{
    public partial class UserMainForm : Form
    {
        NewsSubject NS = new NewsSubject();
        LoginDTO tempUserData = new LoginDTO();

        public UserMainForm(LoginDTO logincred)
        {
            InitializeComponent();
            for (int i = 0; i < NS.getNewsTypes().Count; i++)
            {
                cb_newstype.Items.Add(NS.getNewsTypes()[i]);
            }
            tempUserData = logincred;
            label5.Text = "Signed In " + logincred.Username;
            rtb_headlines.SelectAll();
            rtb_headlines.SelectionAlignment = HorizontalAlignment.Center;
            Observer o1 = new Observer(tempUserData.Username, NS);

        }

        private void lv_subtopics_DoubleClick(object sender, EventArgs e)
        {
            if (lv_subtopics.SelectedItems.Count == 1)
            {
                DialogResult DR = MessageBox.Show("Do You Really Want to Unsubscribe " + lv_subtopics.SelectedItems[0].Text + " Topic?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DR == DialogResult.Yes)
                {
                    lv_subtopics.Items.Remove(lv_subtopics.SelectedItems[0]);
                    rtb_headlines.Clear();
                    helperFunctionForNews();
                }
            }
        }

        private void btn_addNewsType_Click(object sender, EventArgs e)
        {
            ListViewItem item = lv_subtopics.FindItemWithText(cb_newstype.Text.ToString());

            if (cb_newstype.Text.ToString().Equals("None") || cb_newstype.Text.ToString().Equals(""))
            {
                MessageBox.Show("Invalid Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(item == null)
                {
                    lv_subtopics.Items.Add(cb_newstype.Text.ToString());
                    NS.NotifyObservers(cb_newstype.Text.ToString());
                    rtb_headlines.Clear();
                    helperFunctionForNews();
                }
                else
                {
                    MessageBox.Show("Topic Already Subscribed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void helperFunctionForNews()
        {
            int count = 1;

            foreach (ListViewItem anItem in lv_subtopics.Items)
            {
                for (int i = 0; i < NS.getAllNews().Count; i++)
                {
                    if (NS.getAllNews()[i].Newstype.Equals(anItem.Text))
                    {
                        rtb_headlines.Text += "*************" + " News # " + Convert.ToString(count) + "*************";
                        rtb_headlines.Text += Environment.NewLine;
                        rtb_headlines.Text += "*************" + NS.getAllNews()[i].Newstype + "*************";
                        rtb_headlines.Text += Environment.NewLine;
                        rtb_headlines.Text += NS.getAllNews()[i].Newsdetails;
                        rtb_headlines.Text += Environment.NewLine;
                        count++;
                    }
                }
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
