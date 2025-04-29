namespace LB4
{
    partial class FormListGenres
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            btnAddGenre = new Button();
            bntUpdateGenre = new Button();
            btnDeleteGenre = new Button();
            panelFill = new Panel();
            dataGridViewGenres = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.Controls.Add(btnAddGenre);
            flowLayoutPanelTop.Controls.Add(bntUpdateGenre);
            flowLayoutPanelTop.Controls.Add(btnDeleteGenre);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Font = new Font("Segoe UI", 14.25F);
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Margin = new Padding(5);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(800, 65);
            flowLayoutPanelTop.TabIndex = 5;
            flowLayoutPanelTop.Click += BntUpdateGenre_Click;
            // 
            // btnAddGenre
            // 
            btnAddGenre.AutoSize = true;
            btnAddGenre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddGenre.Location = new Point(15, 15);
            btnAddGenre.Margin = new Padding(5);
            btnAddGenre.Name = "btnAddGenre";
            btnAddGenre.Size = new Size(150, 35);
            btnAddGenre.TabIndex = 0;
            btnAddGenre.Text = "Добавить";
            btnAddGenre.UseVisualStyleBackColor = true;
            btnAddGenre.Click += BtnAddGenre_Click;
            // 
            // bntUpdateGenre
            // 
            bntUpdateGenre.AutoSize = true;
            bntUpdateGenre.Font = new Font("Segoe UI", 14.25F);
            bntUpdateGenre.Location = new Point(175, 15);
            bntUpdateGenre.Margin = new Padding(5);
            bntUpdateGenre.Name = "bntUpdateGenre";
            bntUpdateGenre.Size = new Size(151, 35);
            bntUpdateGenre.TabIndex = 1;
            bntUpdateGenre.Text = "Редактировать";
            bntUpdateGenre.UseVisualStyleBackColor = true;
            bntUpdateGenre.Click += BntUpdateGenre_Click;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.AutoSize = true;
            btnDeleteGenre.Font = new Font("Segoe UI", 14.25F);
            btnDeleteGenre.Location = new Point(336, 15);
            btnDeleteGenre.Margin = new Padding(5);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(150, 35);
            btnDeleteGenre.TabIndex = 2;
            btnDeleteGenre.Text = "Удалить";
            btnDeleteGenre.UseVisualStyleBackColor = true;
            btnDeleteGenre.Click += BtnDeleteGenre_Click;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewGenres);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 65);
            panelFill.Margin = new Padding(5);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 385);
            panelFill.TabIndex = 7;
            // 
            // dataGridViewGenres
            // 
            dataGridViewGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGenres.BackgroundColor = Color.White;
            dataGridViewGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenres.Dock = DockStyle.Fill;
            dataGridViewGenres.GridColor = Color.Gray;
            dataGridViewGenres.Location = new Point(10, 10);
            dataGridViewGenres.Margin = new Padding(5);
            dataGridViewGenres.MultiSelect = false;
            dataGridViewGenres.Name = "dataGridViewGenres";
            dataGridViewGenres.ReadOnly = true;
            dataGridViewGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGenres.Size = new Size(780, 365);
            dataGridViewGenres.TabIndex = 3;
            // 
            // FormListGenres
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListGenres";
            Text = "Список жанров аниме";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btnAddGenre;
        private Button bntUpdateGenre;
        private Button btnDeleteGenre;
        private Panel panelFill;
        private DataGridView dataGridViewGenres;
    }
}