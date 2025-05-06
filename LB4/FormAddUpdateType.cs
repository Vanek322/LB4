using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using AppContext = LB4.Models.AppContext;

namespace LB4
{
    public partial class FormAddUpdateType : Form
    {
        private AppContext db;
        public FormAddUpdateType()
        {
            InitializeComponent();
            this.db = new AppContext();
        }

        private void TextBoxTypeName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }
            
            string newTypeName = textBoxTypeName.Text;
            bool exists = db.Types.Any(t => t.TypeName.ToLower() == newTypeName.ToLower());
            if (exists)
            {
                errorProvider.SetError(textBoxTypeName, "Тип с таким именем уже существует.");
                btnSaveChanges.Enabled = false;
                return;
            }
        }

        private void TextBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }

            string newTypeName = textBoxTypeName.Text;
            bool exists = db.Types.Any(t => t.TypeName.ToLower() == newTypeName.ToLower());
            if (exists)
            {
                errorProvider.SetError(textBoxTypeName, "Тип с таким именем уже существует.");
                btnSaveChanges.Enabled = false;
                return;
            }
        }
    }
}
