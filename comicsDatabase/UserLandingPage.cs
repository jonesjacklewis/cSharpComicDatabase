// Code for Close All Forms: https://www.c-sharpcorner.com/forums/closing-of-previous-form-and-opening-of-new-form-in-c-sharp
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
    public partial class UserLandingPage : Form
    {
        public String loggedInUser;
        public UserLandingPage()
        {
            InitializeComponent();
        }

        private void UserLandingPage_Load(object sender, EventArgs e)
        {

        }

        private void btnAddComic_Click(object sender, EventArgs e)
        {
            AddComic addComic = new AddComic();
            addComic.loggedInUser = loggedInUser;
            addComic.Show();
        }

        private void btnViewComic_Click(object sender, EventArgs e)
        {
            ViewComics viewComics = new ViewComics();
            viewComics.loggedInUser = loggedInUser;
            viewComics.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Hide();
            logInForm.Closed += (s, args) => this.Close();
            logInForm.Show();
          



        }

        private void btnDeleteComic_Click(object sender, EventArgs e)
        {
            DeleteComic delete = new DeleteComic();
            delete.loggedInUser = loggedInUser;
            delete.Show();
        }

        private void btnEditComic_Click(object sender, EventArgs e)
        {
            SelectEditComic selectEditComic = new SelectEditComic();
            selectEditComic.loggedInUser = loggedInUser;
            this.Hide();
            selectEditComic.Closed += (s, args) => this.Close();
            selectEditComic.Show();
        }
    }
}
