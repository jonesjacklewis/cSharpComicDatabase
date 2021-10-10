// Source Byte Array to Image: https://stackoverflow.com/questions/11488191/picturebox-from-file-to-blob-to-sql-server-database-then-from-db-to-picturebox

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comicsDatabase
{
    public partial class ViewComicDetails : Form
    {

        public String comicId;
        private String target;
        readonly Sql db = new Sql("comicsDB"); // Connects to comicsDb.db

        public ViewComicDetails()
        {
            InitializeComponent();
        }

        private void viewComicDetails_Load(object sender, EventArgs e)
        {
            NameValueCollection details = db.GetValue("SELECT * FROM comics where comic_id=" + comicId + ";");

            lblIdVal.Text = comicId;
            lblTitleVal.Text = details["title"];
            


            if (details["isbn"].Length > 10)
            {
                lblISBNVal.Text = details["isbn"];
            }
            else
            {
                lblISBNVal.Text = "No ISBN";
                lblISBNVal.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            }

            lblMainCharacterVal.Text = details["mainCharacter"];
            lblRatingVal.Text = details["rating"];

            lLblLink.Text = details["link"];
            this.target = details["link"];
            this.lLblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLblLink_LinkClicked);

            byte[] byteImage = db.getByteArray("SELECT * FROM comics WHERE comic_id=" + comicId + ";", 5);
           

            pbImage.Image = ByteArrayToImage(byteImage);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void lLblLink_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.lLblLink.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start(this.target);
        }

        private static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
            ms.Seek(0, SeekOrigin.Begin);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);

            return returnImage;
        }

 


    }
}
