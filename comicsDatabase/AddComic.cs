// Image to Byte Array Code: https://stackoverflow.com/questions/11488191/picturebox-from-file-to-blob-to-sql-server-database-then-from-db-to-picturebox
// Upload Imag Code: https://www.campuslife.co.in/CSharp-WindowApplication/how-to-upload-image-in-database.php

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comicsDatabase
{
    public partial class AddComic : Form
    {
        public String loggedInUser;
        readonly Sql db = new Sql("comicsDB"); // Connects to comicsDb.db
        public AddComic()
        {
            InitializeComponent();
        }

        private void addComic_Load(object sender, EventArgs e)
        {
            int currentId = 0;
            try
            {
                currentId = int.Parse(db.GetValue("SELECT MAX(comic_id) FROM comics")["MAX(comic_id)"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                currentId = 0;
            }

            int nextId = currentId + 1;
            lblIdVal.Text = nextId.ToString();
            cmbRating.SelectedItem = "3";
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            fdSelectImage.InitialDirectory = ".";
            fdSelectImage.Title = "Select The Comic Cover";
            fdSelectImage.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            fdSelectImage.FilterIndex = 1;

            try
            {
                if (fdSelectImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (fdSelectImage.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(fdSelectImage.FileName);
                        pbImagePreview.Image = new Bitmap(fdSelectImage.FileName);
                        pbImagePreview.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload Image...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void btnAddComic_Click(object sender, EventArgs e)
        {
            String id = lblIdVal.Text;
            String title = txtTitle.Text;
            String isbn = txtISBN.Text;
            String mainCharacter = txtMainCharacter.Text;
            Image cover = pbImagePreview.Image;
            String rating = cmbRating.Text;

            byte[] imageBlob = new byte[] { };

            try
            {
                imageBlob = ImageToByteArray(cover);
            }
            catch
            {
                imageBlob = new byte[] { };
            }

            bool allowed = true;

            var required = new ArrayList();

            required.Add(title);
            required.Add(mainCharacter);

            if (required.Contains("") || imageBlob.Length == 0)
            {
                allowed = false;
            }

            if (allowed)
            {
                String criteria;
                if (isbn != "")
                {
                    criteria = isbn;
                }
                else
                {
                    criteria = title;
                }
                FormattableString link = $"https://www.amazon.co.uk/s?k={criteria}&i=stripbooks&Adv-Srch-Books-Submit.x=36&Adv-Srch-Books-Submit.y=7&__mk_en_GB=%C3%85M%C3%85Z%C3%95%C3%91&unfiltered=1&ref=sr_adv_b";

                String comicLink = link.ToString();

                FormattableString sql = $@"
                INSERT INTO `comics` VALUES (
                {id},
                '{title}',
                '{isbn}',
                '{mainCharacter}',
                {rating},
                @image,
                '{link}'

                   );";

                try
                {
                    db.InsertBlob(sql.ToString(), imageBlob);
                    sql = $"INSERT INTO userComics VALUES (null, {loggedInUser}, {id});";
                    db.InsertOrDeleteRow(sql.ToString());

                    int currentId = 0;
                    try
                    {
                        currentId = int.Parse(db.GetValue("SELECT MAX(comic_id) FROM comics")["MAX(comic_id)"]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        currentId = 0;
                    }

                    int nextId = currentId + 1;
                    lblIdVal.Text = nextId.ToString();
                    cmbRating.SelectedItem = "3";

                    txtTitle.Text = "";
                    txtISBN.Text = "";
                    txtMainCharacter.Text = "";
                    pbImagePreview.Image = null;



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Adding Comic: " + ex.Message);
                }


            }


        }
    }
}
