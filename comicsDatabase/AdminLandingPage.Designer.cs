
namespace comicsDatabase
{
    partial class AdminLandingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMyComics = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMyComics
            // 
            this.btnMyComics.Location = new System.Drawing.Point(37, 65);
            this.btnMyComics.Name = "btnMyComics";
            this.btnMyComics.Size = new System.Drawing.Size(412, 95);
            this.btnMyComics.TabIndex = 0;
            this.btnMyComics.Text = "My Comics";
            this.btnMyComics.UseVisualStyleBackColor = true;
            this.btnMyComics.Click += new System.EventHandler(this.btnMyComics_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Location = new System.Drawing.Point(249, 249);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(200, 112);
            this.btnViewUsers.TabIndex = 1;
            this.btnViewUsers.Text = "View Users";
            this.btnViewUsers.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(37, 249);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(200, 112);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // AdminLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnViewUsers);
            this.Controls.Add(this.btnMyComics);
            this.Name = "AdminLandingPage";
            this.Text = "AdminLandingPage";
            this.Load += new System.EventHandler(this.AdminLandingPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMyComics;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.Button btnAddUser;
    }
}