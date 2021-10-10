
namespace comicsDatabase
{
    partial class SelectEditComic
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
            this.lvComics = new System.Windows.Forms.ListView();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvComics
            // 
            this.lvComics.HideSelection = false;
            this.lvComics.HoverSelection = true;
            this.lvComics.Location = new System.Drawing.Point(57, 43);
            this.lvComics.MaximumSize = new System.Drawing.Size(687, 365);
            this.lvComics.MinimumSize = new System.Drawing.Size(687, 365);
            this.lvComics.Name = "lvComics";
            this.lvComics.Size = new System.Drawing.Size(687, 365);
            this.lvComics.TabIndex = 1;
            this.lvComics.UseCompatibleStateImageBehavior = false;
            this.lvComics.DoubleClick += new System.EventHandler(this.lvComics_DoubleClick);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(381, 415);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // SelectEditComic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lvComics);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "SelectEditComic";
            this.Text = "SelectEditComic";
            this.Load += new System.EventHandler(this.SelectEditComic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvComics;
        private System.Windows.Forms.Button btnHome;
    }
}