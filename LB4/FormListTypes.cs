using LB4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContext = LB4.Models.AppContext;

namespace LB4
{
    public partial class FormListTypes : Form
    {
        private AppContext db;


        public FormListTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Types.Load();
            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();

            //скрытие столбцов
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

            //переименование заголовков столбцов
            dataGridViewTypes.Columns["TypeName"].HeaderText = "Тип аниме";

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            FormAddType formAddType = new FormAddType();
            formAddType.ShowDialog();
        }
    }
}
