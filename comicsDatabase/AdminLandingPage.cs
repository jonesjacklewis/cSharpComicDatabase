using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comicsDatabase
{
    public partial class AdminLandingPage : Form
    {

        public String loggedInUser;
        public AdminLandingPage()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void AdminLandingPage_Load(object sender, EventArgs e)
        {

        }

        private void btnMyComics_Click(object sender, EventArgs e)
        {
            UserLandingPage userLandingPage = new UserLandingPage();
            this.Hide();
            userLandingPage.Closed += (s, args) => this.Close();
            userLandingPage.Show();
            userLandingPage.loggedInUser = loggedInUser;
        }
    }
}
