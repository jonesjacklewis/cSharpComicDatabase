
namespace comicsDatabase
{
    partial class AddComic
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtMainCharacter = new System.Windows.Forms.TextBox();
            this.lblIdVal = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblMainCharacter = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnAddComic = new System.Windows.Forms.Button();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.fdSelectImage = new System.Windows.Forms.OpenFileDialog();
            this.pbImagePreview = new System.Windows.Forms.PictureBox();
            this.lblImagePreview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(119, 100);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(119, 126);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 0;
            // 
            // txtMainCharacter
            // 
            this.txtMainCharacter.Location = new System.Drawing.Point(119, 152);
            this.txtMainCharacter.Name = "txtMainCharacter";
            this.txtMainCharacter.Size = new System.Drawing.Size(100, 20);
            this.txtMainCharacter.TabIndex = 0;
            // 
            // lblIdVal
            // 
            this.lblIdVal.AutoSize = true;
            this.lblIdVal.Location = new System.Drawing.Point(149, 68);
            this.lblIdVal.Name = "lblIdVal";
            this.lblIdVal.Size = new System.Drawing.Size(13, 13);
            this.lblIdVal.TabIndex = 1;
            this.lblIdVal.Text = "0";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(42, 68);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(42, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(42, 129);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "ISBN";
            // 
            // lblMainCharacter
            // 
            this.lblMainCharacter.AutoSize = true;
            this.lblMainCharacter.Location = new System.Drawing.Point(22, 155);
            this.lblMainCharacter.Name = "lblMainCharacter";
            this.lblMainCharacter.Size = new System.Drawing.Size(79, 13);
            this.lblMainCharacter.TabIndex = 1;
            this.lblMainCharacter.Text = "Main Character";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(42, 200);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(36, 13);
            this.lblImage.TabIndex = 1;
            this.lblImage.Text = "Image";
            // 
            // btnAddComic
            // 
            this.btnAddComic.Location = new System.Drawing.Point(118, 286);
            this.btnAddComic.Name = "btnAddComic";
            this.btnAddComic.Size = new System.Drawing.Size(75, 23);
            this.btnAddComic.TabIndex = 2;
            this.btnAddComic.Text = "Add Comic";
            this.btnAddComic.UseVisualStyleBackColor = true;
            this.btnAddComic.Click += new System.EventHandler(this.btnAddComic_Click);
            // 
            // cmbRating
            // 
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbRating.Location = new System.Drawing.Point(119, 239);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(121, 21);
            this.cmbRating.TabIndex = 3;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(38, 247);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "Rating";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(119, 200);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(75, 23);
            this.btnSelectImage.TabIndex = 4;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // fdSelectImage
            // 
            this.fdSelectImage.FileName = "openFileDialog1";
            // 
            // pbImagePreview
            // 
            this.pbImagePreview.Location = new System.Drawing.Point(249, 360);
            this.pbImagePreview.Name = "pbImagePreview";
            this.pbImagePreview.Size = new System.Drawing.Size(100, 50);
            this.pbImagePreview.TabIndex = 5;
            this.pbImagePreview.TabStop = false;
            // 
            // lblImagePreview
            // 
            this.lblImagePreview.AutoSize = true;
            this.lblImagePreview.Location = new System.Drawing.Point(116, 384);
            this.lblImagePreview.Name = "lblImagePreview";
            this.lblImagePreview.Size = new System.Drawing.Size(77, 13);
            this.lblImagePreview.TabIndex = 6;
            this.lblImagePreview.Text = "Image Preview";
            // 
            // AddComic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.lblImagePreview);
            this.Controls.Add(this.pbImagePreview);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.cmbRating);
            this.Controls.Add(this.btnAddComic);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblMainCharacter);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblIdVal);
            this.Controls.Add(this.txtMainCharacter);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtTitle);
            this.MaximumSize = new System.Drawing.Size(396, 489);
            this.MinimumSize = new System.Drawing.Size(396, 489);
            this.Name = "AddComic";
            this.Text = "addComic";
            this.Load += new System.EventHandler(this.addComic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtMainCharacter;
        private System.Windows.Forms.Label lblIdVal;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblMainCharacter;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnAddComic;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.OpenFileDialog fdSelectImage;
        private System.Windows.Forms.PictureBox pbImagePreview;
        private System.Windows.Forms.Label lblImagePreview;
    }
}