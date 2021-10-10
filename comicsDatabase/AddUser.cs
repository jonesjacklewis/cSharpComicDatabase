using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comicsDatabase
{
    public partial class AddUser : Form
    {
        readonly Sql db = new Sql("comicsDB"); // Connects to comicsDb.db
        readonly String key = "b14ca5898a4e4133bbce2ea2315a1916"; // Encryption Key (In a real world application should be kept hidden)
        readonly AesOperation encryptor = new AesOperation();

        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            int currentId = int.Parse(db.GetValue("SELECT MAX(user_id) FROM users")["MAX(user_id)"]);
            int nextId = currentId + 1;
            lblIdVal.Text = nextId.ToString();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            String id = lblIdVal.Text;
            String inputtedUser = txtUser.Text;
            String encryptedPassword = encryptor.EncryptString(key, txtPass.Text);
            String role = cmbRole.Text;

            // Check variable
            bool match = false;

            // Get All Rows
            var userRows = db.GetAllValues("users");
            NameValueCollection currentRow;

            String rUser;

            // Loop over rows
            foreach (var row in userRows)
            {
                currentRow = (NameValueCollection)row;  // Cast row to NameValueCollectoin

                rUser = currentRow["username"];

                // If username and password are in db
                if (inputtedUser.Equals(rUser))
                {
                    match = true;
                    break;
                }
            }

            if (match)
            {
                MessageBox.Show("User '" + inputtedUser + "' already exists!", "Duplicate User");
            }
            else
            {
                FormattableString sql = $"INSERT INTO users VALUES ({id}, '{inputtedUser}', '{encryptedPassword}', '{role}');";

                if (db.InsertOrDeleteRow(sql.ToString()))
                {
                    MessageBox.Show("Created User '" + inputtedUser + "'!", "Successfully Added User");
                    int nextId = int.Parse(id) + 1;
                    lblIdVal.Text = nextId.ToString();
                }
                else
                {
                    MessageBox.Show("Failed to created User '" + inputtedUser + "'!", "Unable to Add User");
                }
            }

            txtUser.Text = "";
            txtPass.Text = "";

            this.Refresh();

            }
    }
}
