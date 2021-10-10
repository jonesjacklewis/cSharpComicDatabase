// Dialog Box Code: https://stackoverflow.com/questions/3845695/is-there-a-builtin-confirmation-dialog-in-windows-forms
using System;
using System.Collections;
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
    public partial class ViewComics : Form
    {
        public String loggedInUser;
        readonly Sql db = new Sql("comicsDB"); // Connects to comicsDb.db
        public ViewComics()
        {
            InitializeComponent();
        }

        private void ViewComics_Load(object sender, EventArgs e)
        {
            ArrayList allComics = db.GetAllValuesCondition("userComics", "user_id=" + loggedInUser);
            NameValueCollection currentRow;
            ArrayList userComics = new ArrayList();

            foreach (var comic in allComics)
            {
                currentRow = (NameValueCollection)comic;
                userComics.Add(currentRow["comic_id"]);
            }

            ArrayList userComicsDetails = new ArrayList();

            foreach(var cid in userComics)
            {
                foreach (var comic in db.GetAllValuesCondition("comics", "comic_id=" + cid))
                {
                    userComicsDetails.Add(comic);
               
                }
            }

            lvComics.Columns.Add("comic_id", 120, HorizontalAlignment.Left);
            lvComics.Columns.Add("title", 120, HorizontalAlignment.Left);
            lvComics.Columns.Add("isbn", 120, HorizontalAlignment.Left);
            lvComics.Columns.Add("mainCharacter", 120, HorizontalAlignment.Left);
            lvComics.Columns.Add("rating", 120, HorizontalAlignment.Left);
            lvComics.Columns.Add("link", 120, HorizontalAlignment.Left);


            foreach (var comic in userComicsDetails) {
                currentRow = (NameValueCollection)comic;
                ListViewItem lvi = new ListViewItem();

                lvi.Text = currentRow["comic_id"];
                lvi.SubItems.Add(currentRow["title"]);
                lvi.SubItems.Add(currentRow["isbn"]);
                lvi.SubItems.Add(currentRow["mainCharacter"]);
                lvi.SubItems.Add(currentRow["rating"]);
                lvi.SubItems.Add(currentRow["link"]);


                ListViewItem alreadyExists = lvComics.FindItemWithText(lvi.Text);

                if(alreadyExists == null)
                {
                    lvComics.Items.Add(lvi);
                }

                

            }


            lvComics.View = View.Details;
            this.lvComics.EndUpdate();
        }

        private void lvComics_DoubleClick(object sender, System.EventArgs e)
        {
            String id = lvComics.SelectedItems[0].Text;

            ViewComicDetails viewComicDetails = new ViewComicDetails();
            viewComicDetails.comicId = id;
            viewComicDetails.Show();


        }



        }
}
