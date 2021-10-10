// Encryption Source = https://www.c-sharpcorner.com/article/encryption-and-decryption-using-a-symmetric-key-in-c-sharp/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;

namespace comicsDatabase
{
    public partial class LogInForm : Form
    {
        // Class Variables
        readonly String key = "b14ca5898a4e4133bbce2ea2315a1916"; // Encryption Key (In a real world application should be kept hidden)
        readonly Sql db = new Sql("comicsDB"); // Connects to comicsDb.db
        readonly AesOperation encryptor = new AesOperation();

        public LogInForm()
        {
            InitializeComponent();
        }

        // On Load
        private void LogInForm_Load(object sender, EventArgs e)
        {
           
        }

        // When Log In Button Is Clicked
        private void btnLogIn_Click(object sender, EventArgs e)
        {

            // Gets Form value
            String inputtedUser = txtUser.Text;


            // Encrypts Password
            String encryptedPassword = encryptor.EncryptString(key, txtPass.Text);

            // Check variable
            bool match = false;

            // Get All Rows
            var userRows = db.GetAllValues("users");


            // Variables to hold row info
            String rUserID, rUser, rPass, rRole;
            NameValueCollection currentRow;

            rRole = "user";
            rUserID = "";

            // Loop over rows
            foreach (var row in userRows)
            {
                currentRow = (NameValueCollection)row;  // Cast row to NameValueCollectoin

                rUserID = currentRow["user_id"].ToString();
                rUser = currentRow["username"];
                rPass = currentRow["password"];
                rRole = currentRow["role"];



                // If username and password are in db
                if (inputtedUser.Equals(rUser) && encryptedPassword.Equals(rPass))
                {
                    match = true;
                    break;
                }

            }

            if (match)
            {

                if (rRole.Equals("admin"))
                {
                    AdminLandingPage adminLandingPage = new AdminLandingPage();
                    this.Hide();
                    adminLandingPage.Closed += (s, args) => this.Close();
                    adminLandingPage.Show();
                    adminLandingPage.loggedInUser = rUserID;




                }
                else
                {
                    UserLandingPage userLandingPage = new UserLandingPage();
                    this.Hide();
                    userLandingPage.Closed += (s, args) => this.Close();
                    userLandingPage.Show();
                    userLandingPage.loggedInUser = rUserID;



                }
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }


        }
    }
}
