
namespace comicsDatabase
{
    partial class EditComic
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
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.btnEditComic = new System.Windows.Forms.Button();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblMainCharacter = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdVal = new System.Windows.Forms.Label();
            this.txtMainCharacter = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.fdSelectImage = new System.Windows.Forms.OpenFileDialog();
            this.lblImagePreview = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(124, 186);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(75, 23);
            this.btnSelectImage.TabIndex = 19;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click_1);
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
            this.cmbRating.Location = new System.Drawing.Point(124, 225);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(121, 21);
            this.cmbRating.TabIndex = 18;
            // 
            // btnEditComic
            // 
            this.btnEditComic.Location = new System.Drawing.Point(124, 305);
            this.btnEditComic.Name = "btnEditComic";
            this.btnEditComic.Size = new System.Drawing.Size(75, 23);
            this.btnEditComic.TabIndex = 17;
            this.btnEditComic.Text = "Edit Comic";
            this.btnEditComic.UseVisualStyleBackColor = true;
            this.btnEditComic.Click += new System.EventHandler(this.btnEditComic_Click);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(43, 233);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 10;
            this.lblRating.Text = "Rating";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(47, 186);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(36, 13);
            this.lblImage.TabIndex = 11;
            this.lblImage.Text = "Image";
            // 
            // lblMainCharacter
            // 
            this.lblMainCharacter.AutoSize = true;
            this.lblMainCharacter.Location = new System.Drawing.Point(27, 141);
            this.lblMainCharacter.Name = "lblMainCharacter";
            this.lblMainCharacter.Size = new System.Drawing.Size(79, 13);
            this.lblMainCharacter.TabIndex = 12;
            this.lblMainCharacter.Text = "Main Character";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(47, 115);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 13;
            this.lblISBN.Text = "ISBN";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(47, 86);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Title";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(47, 54);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "ID";
            // 
            // lblIdVal
            // 
            this.lblIdVal.AutoSize = true;
            this.lblIdVal.Location = new System.Drawing.Point(154, 54);
            this.lblIdVal.Name = "lblIdVal";
            this.lblIdVal.Size = new System.Drawing.Size(13, 13);
            this.lblIdVal.TabIndex = 16;
            this.lblIdVal.Text = "0";
            // 
            // txtMainCharacter
            // 
            this.txtMainCharacter.Location = new System.Drawing.Point(124, 138);
            this.txtMainCharacter.Name = "txtMainCharacter";
            this.txtMainCharacter.Size = new System.Drawing.Size(100, 20);
            this.txtMainCharacter.TabIndex = 7;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(124, 112);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(124, 86);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 9;
            // 
            // fdSelectImage
            // 
            this.fdSelectImage.FileName = "openFileDialog1";
            // 
            // lblImagePreview
            // 
            this.lblImagePreview.AutoSize = true;
            this.lblImagePreview.Location = new System.Drawing.Point(121, 370);
            this.lblImagePreview.Name = "lblImagePreview";
            this.lblImagePreview.Size = new System.Drawing.Size(77, 13);
            this.lblImagePreview.TabIndex = 21;
            this.lblImagePreview.Text = "Image Preview";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(254, 346);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(100, 50);
            this.pbImage.TabIndex = 20;
            this.pbImage.TabStop = false;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(124, 273);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(100, 20);
            this.txtLink.TabIndex = 22;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(41, 276);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(27, 13);
            this.lblLink.TabIndex = 10;
            this.lblLink.Text = "Link";
            // 
            // EditComic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.cmbRating);
            this.Controls.Add(this.btnEditComic);
            this.Controls.Add(this.lblLink);
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
            this.Controls.Add(this.lblImagePreview);
            this.Controls.Add(this.pbImage);
            this.MaximumSize = new System.Drawing.Size(396, 489);
            this.MinimumSize = new System.Drawing.Size(396, 489);
            this.Name = "EditComic";
            this.Text = "editComic";
            this.Load += new System.EventHandler(this.editComic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Button btnEditComic;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblMainCharacter;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdVal;
        private System.Windows.Forms.TextBox txtMainCharacter;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.OpenFileDialog fdSelectImage;
        private System.Windows.Forms.Label lblImagePreview;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblLink;
    }
}