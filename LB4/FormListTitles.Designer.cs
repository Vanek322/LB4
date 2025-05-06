namespace LB4
{
    partial class FormListTitles
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
            btnAddTitle = new Button();
            bntUpdateTitle = new Button();
            btnDeleteTitle = new Button();
            panelFill = new Panel();
            dataGridViewTitles = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTitles).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.Controls.Add(btnAddTitle);
            flowLayoutPanelTop.Controls.Add(bntUpdateTitle);
            flowLayoutPanelTop.Controls.Add(btnDeleteTitle);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Font = new Font("Segoe UI", 14.25F);
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Margin = new Padding(5);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(838, 65);
            flowLayoutPanelTop.TabIndex = 1;
            // 
            // btnAddTitle
            // 
            btnAddTitle.AutoSize = true;
            btnAddTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddTitle.Location = new Point(15, 15);
            btnAddTitle.Margin = new Padding(5);
            btnAddTitle.Name = "btnAddTitle";
            btnAddTitle.Size = new Size(150, 35);
            btnAddTitle.TabIndex = 0;
            btnAddTitle.Text = "Добавить";
            btnAddTitle.UseVisualStyleBackColor = true;
            // 
            // bntUpdateTitle
            // 
            bntUpdateTitle.AutoSize = true;
            bntUpdateTitle.Font = new Font("Segoe UI", 14.25F);
            bntUpdateTitle.Location = new Point(175, 15);
            bntUpdateTitle.Margin = new Padding(5);
            bntUpdateTitle.Name = "bntUpdateTitle";
            bntUpdateTitle.Size = new Size(151, 35);
            bntUpdateTitle.TabIndex = 1;
            bntUpdateTitle.Text = "Редактировать";
            bntUpdateTitle.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTitle
            // 
            btnDeleteTitle.AutoSize = true;
            btnDeleteTitle.Font = new Font("Segoe UI", 14.25F);
            btnDeleteTitle.Location = new Point(336, 15);
            btnDeleteTitle.Margin = new Padding(5);
            btnDeleteTitle.Name = "btnDeleteTitle";
            btnDeleteTitle.Size = new Size(150, 35);
            btnDeleteTitle.TabIndex = 2;
            btnDeleteTitle.Text = "Удалить";
            btnDeleteTitle.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTitles);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 65);
            panelFill.Margin = new Padding(5);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(838, 371);
            panelFill.TabIndex = 5;
            // 
            // dataGridViewTitles
            // 
            dataGridViewTitles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTitles.BackgroundColor = Color.White;
            dataGridViewTitles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTitles.Dock = DockStyle.Fill;
            dataGridViewTitles.GridColor = Color.Gray;
            dataGridViewTitles.Location = new Point(10, 10);
            dataGridViewTitles.Margin = new Padding(5);
            dataGridViewTitles.MultiSelect = false;
            dataGridViewTitles.Name = "dataGridViewTitles";
            dataGridViewTitles.ReadOnly = true;
            dataGridViewTitles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTitles.Size = new Size(818, 351);
            dataGridViewTitles.TabIndex = 3;
            // 
            // FormListTitles
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(838, 436);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListTitles";
            Text = "Тайтлы аниме";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTitles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btnAddTitle;
        private Button bntUpdateTitle;
        private Button btnDeleteTitle;
        private Panel panelFill;
        private DataGridView dataGridViewTitles;
    }
}