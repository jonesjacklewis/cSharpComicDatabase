using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class EditComic : Form
    {
        public String loggedInUser;
        public String comicId;
        private String target;
        readonly Sql db = new Sql("comicsDB"); // Connects to comicsDb.db
        public EditComic()
        {
            InitializeComponent();
        }

        private void editComic_Load(object sender, EventArgs e)
        {
            
            NameValueCollection details = db.GetValue("SELECT * FROM comics where comic_id=" + this.comicId + ";");
           


            lblIdVal.Text = this.comicId;

            txtTitle.Text = details["title"];

            MessageBox.Show(txtTitle.Text);

            if (details["isbn"].Length >= 10)
            {
                txtISBN.Text = details["isbn"];
            }
           

            txtMainCharacter.Text = details["mainCharacter"];
            cmbRating.Text = details["rating"];

            txtLink.Text = details["link"];
            

            byte[] byteImage = db.getByteArray("SELECT * FROM comics WHERE comic_id=" + comicId + ";", 5);


            pbImage.Image = ByteArrayToImage(byteImage);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;


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
                        pbImage.Image = new Bitmap(fdSelectImage.FileName);
                        pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
            ms.Seek(0, SeekOrigin.Begin);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);

            return returnImage;
        }



        private void btnEditComic_Click(object sender, EventArgs e)
        {
            String id = lblIdVal.Text;
            String title = txtTitle.Text;
            String isbn = txtISBN.Text;
            String mainCharacter = txtMainCharacter.Text;
            Image cover = pbImage.Image;
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
                
                String link = txtLink.Text;

                FormattableString sql = $@"
                                UPDATE comics
                SET title='{title}',
                isbn='{isbn}',
                mainCharacter='{mainCharacter}',
                rating={rating},
                image=@image,
                link='{link}'
                WHERE comic_id={id};";

                try
                {
                    db.InsertBlob(sql.ToString(), imageBlob);

                    SelectEditComic selectEditComic = new SelectEditComic();

                    this.Hide();
                    selectEditComic.Closed += (s, args) => this.Close();
                    selectEditComic.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Adding Comic: " + ex.Message);
                }
            }
            }

        private void btnSelectImage_Click_1(object sender, EventArgs e)
        {
            btnSelectImage_Click(sender, e);
        }
    }
}
