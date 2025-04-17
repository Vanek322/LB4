using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using AppContext = LB4.Models.AppContext;
using Genre = LB4.Models.Genre;

namespace LB4
{
    public partial class FormListGenres : Form
    {
        private AppContext db;
        public FormListGenres()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); 
            this.db = new AppContext();
            this.db.Genres.Load();
            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();

            //скрытие столбцов
            dataGridViewGenres.Columns["Id"].Visible = false;
           // dataGridViewGenres.Columns["AnimeTitles"].Visible = false;

            //переименование заголовков столбцов
            dataGridViewGenres.Columns["GenreName"].HeaderText = "Жанр аниме";

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre formAddGenre = new();
            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            string newGenreName = formAddGenre.textBoxGenreName.Text;

            bool exists = db.Genres.Any(t => t.GenreName.ToLower() == newGenreName.ToLower());
            if (exists)
            {
                MessageBox.Show("Жанр с таким именем уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Genre genre = new Genre();
            genre.GenreName = formAddGenre.textBoxGenreName.Text;

            db.Genres.Add(genre);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }

        private void BntUpdateGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenres.SelectedRows.Count == 0)
            {
                return;
            }
            int index = dataGridViewGenres.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewGenres[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }

            Genre genre = db.Genres.Find(id);
            FormAddGenre formAddGenre = new();
            formAddGenre.textBoxGenreName.Text = genre.GenreName;

            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            genre.GenreName = formAddGenre.textBoxGenreName.Text;
            db.Genres.Update(genre);
            db.SaveChanges();

            MessageBox.Show("Объект изменен");

            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }

        private void BtnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenres.SelectedRows.Count == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show
                (
                    "Вы уверены, что хотите удалить объект? \nВсе связанные данные будут удалены.",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            if (result == DialogResult.No)
            {
                return;
            }

            int index = dataGridViewGenres.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewGenres[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }
            Genre genre = db.Genres.Find(id);

            db.Genres.Remove(genre);
            db.SaveChanges();

            MessageBox.Show("Объект удален");
            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }
    }
}
