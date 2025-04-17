using System.ComponentModel;
using AppContext = LB4.Models.AppContext;

namespace LB4
{
    public partial class FormAddGenre : Form
    {
        private AppContext db;
        public FormAddGenre()
        {
            InitializeComponent();
            this.db = new AppContext();
        }
        private void TextBoxGenreName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenreName.Text))
            {
                errorProvider.SetError(textBoxGenreName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }

            string newGenreName = textBoxGenreName.Text;
            bool exists = db.Genres.Any(t => t.GenreName.ToLower() == newGenreName.ToLower());
            if (exists)
            {
                errorProvider.SetError(textBoxGenreName,"Жанр с таким именем уже существует.");
                btnSaveChanges.Enabled = false;
                return;
            }
        }

        private void TextBoxGenreName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenreName.Text))
            {
                errorProvider.SetError(textBoxGenreName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }

            string newGenreName = textBoxGenreName.Text;
            bool exists = db.Genres.Any(t => t.GenreName.ToLower() == newGenreName.ToLower());
            if (exists)
            {
                errorProvider.SetError(textBoxGenreName, "Жанр с таким именем уже существует.");
                btnSaveChanges.Enabled = false;
                return;
            }
        }
    }
}
