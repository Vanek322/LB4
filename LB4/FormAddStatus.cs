using System.ComponentModel;
using AppContext = LB4.Models.AppContext;

namespace LB4
{
    public partial class FormAddStatus : Form
    {
        private AppContext db;
        public FormAddStatus()
        {
            InitializeComponent();
            this.db = new AppContext();
        }
        private void TextBoxGenreName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatusName.Text))
            {
                errorProvider.SetError(textBoxStatusName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }

            string newStatusName = textBoxStatusName.Text;
            bool exists = db.Statuses.Any(t => t.StatusName.ToLower() == newStatusName.ToLower());
            if (exists)
            {
                errorProvider.SetError(textBoxStatusName, "Жанр с таким именем уже существует.");
                btnSaveChanges.Enabled = false;
                return;
            }
        }

        private void TextBoxStatusName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatusName.Text))
            {
                errorProvider.SetError(textBoxStatusName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }

            string newStatusName = textBoxStatusName.Text;

            bool exists = db.Statuses.Any(t => t.StatusName.ToLower() == newStatusName.ToLower());
            if (exists)
            {
                errorProvider.SetError(textBoxStatusName, "Жанр с таким именем уже существует.");
                btnSaveChanges.Enabled = false;
                return;
            }
        }
    }
}
