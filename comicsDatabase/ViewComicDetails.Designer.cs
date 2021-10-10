
namespace comicsDatabase
{
    partial class ViewComicDetails
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
            this.lblRating = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblMainCharacter = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdVal = new System.Windows.Forms.Label();
            this.fdSelectImage = new System.Windows.Forms.OpenFileDialog();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblTitleVal = new System.Windows.Forms.Label();
            this.lblISBNVal = new System.Windows.Forms.Label();
            this.lblMainCharacterVal = new System.Windows.Forms.Label();
            this.lblRatingVal = new System.Windows.Forms.Label();
            this.lLblLink = new System.Windows.Forms.LinkLabel();
            this.lblLink = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(47, 306);
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
            // fdSelectImage
            // 
            this.fdSelectImage.FileName = "openFileDialog1";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(129, 165);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(174, 102);
            this.pbImage.TabIndex = 20;
            this.pbImage.TabStop = false;
            // 
            // lblTitleVal
            // 
            this.lblTitleVal.AutoSize = true;
            this.lblTitleVal.Location = new System.Drawing.Point(131, 86);
            this.lblTitleVal.Name = "lblTitleVal";
            this.lblTitleVal.Size = new System.Drawing.Size(59, 13);
            this.lblTitleVal.TabIndex = 21;
            this.lblTitleVal.Text = "Comic Title";
            // 
            // lblISBNVal
            // 
            this.lblISBNVal.AutoSize = true;
            this.lblISBNVal.Location = new System.Drawing.Point(131, 115);
            this.lblISBNVal.Name = "lblISBNVal";
            this.lblISBNVal.Size = new System.Drawing.Size(64, 13);
            this.lblISBNVal.TabIndex = 21;
            this.lblISBNVal.Text = "Comic ISBN";
            // 
            // lblMainCharacterVal
            // 
            this.lblMainCharacterVal.AutoSize = true;
            this.lblMainCharacterVal.Location = new System.Drawing.Point(131, 141);
            this.lblMainCharacterVal.Name = "lblMainCharacterVal";
            this.lblMainCharacterVal.Size = new System.Drawing.Size(111, 13);
            this.lblMainCharacterVal.TabIndex = 21;
            this.lblMainCharacterVal.Text = "Comic Main Character";
            // 
            // lblRatingVal
            // 
            this.lblRatingVal.AutoSize = true;
            this.lblRatingVal.Location = new System.Drawing.Point(132, 306);
            this.lblRatingVal.Name = "lblRatingVal";
            this.lblRatingVal.Size = new System.Drawing.Size(70, 13);
            this.lblRatingVal.TabIndex = 21;
            this.lblRatingVal.Text = "Comic Rating";
            // 
            // lLblLink
            // 
            this.lLblLink.AutoSize = true;
            this.lLblLink.Location = new System.Drawing.Point(129, 352);
            this.lLblLink.Name = "lLblLink";
            this.lLblLink.Size = new System.Drawing.Size(59, 13);
            this.lLblLink.TabIndex = 22;
            this.lLblLink.TabStop = true;
            this.lLblLink.Text = "Comic Link";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(50, 352);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(27, 13);
            this.lblLink.TabIndex = 23;
            this.lblLink.Text = "Link";
            // 
            // viewComicDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lLblLink);
            this.Controls.Add(this.lblRatingVal);
            this.Controls.Add(this.lblMainCharacterVal);
            this.Controls.Add(this.lblISBNVal);
            this.Controls.Add(this.lblTitleVal);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblMainCharacter);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblIdVal);
            this.Controls.Add(this.pbImage);
            this.MaximumSize = new System.Drawing.Size(396, 489);
            this.MinimumSize = new System.Drawing.Size(396, 489);
            this.Name = "viewComicDetails";
            this.Text = "viewComicDetails";
            this.Load += new System.EventHandler(this.viewComicDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblMainCharacter;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdVal;
        private System.Windows.Forms.OpenFileDialog fdSelectImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblTitleVal;
        private System.Windows.Forms.Label lblISBNVal;
        private System.Windows.Forms.Label lblMainCharacterVal;
        private System.Windows.Forms.Label lblRatingVal;
        private System.Windows.Forms.LinkLabel lLblLink;
        private System.Windows.Forms.Label lblLink;
    }
}