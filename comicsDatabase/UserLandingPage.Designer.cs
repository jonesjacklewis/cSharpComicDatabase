
namespace comicsDatabase
{
    partial class UserLandingPage
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
            this.btnViewComic = new System.Windows.Forms.Button();
            this.btnAddComic = new System.Windows.Forms.Button();
            this.btnDeleteComic = new System.Windows.Forms.Button();
            this.btnEditComic = new System.Windows.Forms.Button();
            this.btnComicStat = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewComic
            // 
            this.btnViewComic.Location = new System.Drawing.Point(70, 46);
            this.btnViewComic.Name = "btnViewComic";
            this.btnViewComic.Size = new System.Drawing.Size(121, 92);
            this.btnViewComic.TabIndex = 0;
            this.btnViewComic.Text = "View My Comics";
            this.btnViewComic.UseVisualStyleBackColor = true;
            this.btnViewComic.Click += new System.EventHandler(this.btnViewComic_Click);
            // 
            // btnAddComic
            // 
            this.btnAddComic.Location = new System.Drawing.Point(275, 46);
            this.btnAddComic.Name = "btnAddComic";
            this.btnAddComic.Size = new System.Drawing.Size(121, 92);
            this.btnAddComic.TabIndex = 1;
            this.btnAddComic.Text = "Add New Comic";
            this.btnAddComic.UseVisualStyleBackColor = true;
            this.btnAddComic.Click += new System.EventHandler(this.btnAddComic_Click);
            // 
            // btnDeleteComic
            // 
            this.btnDeleteComic.Location = new System.Drawing.Point(275, 193);
            this.btnDeleteComic.Name = "btnDeleteComic";
            this.btnDeleteComic.Size = new System.Drawing.Size(121, 92);
            this.btnDeleteComic.TabIndex = 2;
            this.btnDeleteComic.Text = "Delete a Comic";
            this.btnDeleteComic.UseVisualStyleBackColor = true;
            this.btnDeleteComic.Click += new System.EventHandler(this.btnDeleteComic_Click);
            // 
            // btnEditComic
            // 
            this.btnEditComic.Location = new System.Drawing.Point(70, 193);
            this.btnEditComic.Name = "btnEditComic";
            this.btnEditComic.Size = new System.Drawing.Size(121, 92);
            this.btnEditComic.TabIndex = 3;
            this.btnEditComic.Text = "Edit a Comic";
            this.btnEditComic.UseVisualStyleBackColor = true;
            this.btnEditComic.Click += new System.EventHandler(this.btnEditComic_Click);
            // 
            // btnComicStat
            // 
            this.btnComicStat.Location = new System.Drawing.Point(70, 332);
            this.btnComicStat.Name = "btnComicStat";
            this.btnComicStat.Size = new System.Drawing.Size(121, 92);
            this.btnComicStat.TabIndex = 4;
            this.btnComicStat.Text = "Comic Stats";
            this.btnComicStat.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(275, 332);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(121, 92);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // UserLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnComicStat);
            this.Controls.Add(this.btnEditComic);
            this.Controls.Add(this.btnDeleteComic);
            this.Controls.Add(this.btnAddComic);
            this.Controls.Add(this.btnViewComic);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "UserLandingPage";
            this.Text = "UserLandingPage";
            this.Load += new System.EventHandler(this.UserLandingPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewComic;
        private System.Windows.Forms.Button btnAddComic;
        private System.Windows.Forms.Button btnDeleteComic;
        private System.Windows.Forms.Button btnEditComic;
        private System.Windows.Forms.Button btnComicStat;
        private System.Windows.Forms.Button btnLogOut;
    }
}