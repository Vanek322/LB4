namespace LB4
{
    partial class FormListTypes
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
            btnAddType = new Button();
            bntUpdateType = new Button();
            btnDeleteType = new Button();
            dataGridViewTypes = new DataGridView();
            panelFill = new Panel();
            flowLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.Controls.Add(btnAddType);
            flowLayoutPanelTop.Controls.Add(bntUpdateType);
            flowLayoutPanelTop.Controls.Add(btnDeleteType);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Font = new Font("Segoe UI", 14.25F);
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Margin = new Padding(5);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(800, 65);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // btnAddType
            // 
            btnAddType.AutoSize = true;
            btnAddType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddType.Location = new Point(15, 15);
            btnAddType.Margin = new Padding(5);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(150, 35);
            btnAddType.TabIndex = 0;
            btnAddType.Text = "Добавить";
            btnAddType.UseVisualStyleBackColor = true;
            btnAddType.Click += BtnAddType_Click;
            // 
            // bntUpdateType
            // 
            bntUpdateType.AutoSize = true;
            bntUpdateType.Font = new Font("Segoe UI", 14.25F);
            bntUpdateType.Location = new Point(175, 15);
            bntUpdateType.Margin = new Padding(5);
            bntUpdateType.Name = "bntUpdateType";
            bntUpdateType.Size = new Size(151, 35);
            bntUpdateType.TabIndex = 1;
            bntUpdateType.Text = "Редактировать";
            bntUpdateType.UseVisualStyleBackColor = true;
            bntUpdateType.Click += BntUpdateType_Click;
            // 
            // btnDeleteType
            // 
            btnDeleteType.AutoSize = true;
            btnDeleteType.Font = new Font("Segoe UI", 14.25F);
            btnDeleteType.Location = new Point(336, 15);
            btnDeleteType.Margin = new Padding(5);
            btnDeleteType.Name = "btnDeleteType";
            btnDeleteType.Size = new Size(150, 35);
            btnDeleteType.TabIndex = 2;
            btnDeleteType.Text = "Удалить";
            btnDeleteType.UseVisualStyleBackColor = true;
            btnDeleteType.Click += BtnDeleteType_Click;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTypes.BackgroundColor = Color.White;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.GridColor = Color.Gray;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.Margin = new Padding(5);
            dataGridViewTypes.MultiSelect = false;
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.ReadOnly = true;
            dataGridViewTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTypes.Size = new Size(780, 365);
            dataGridViewTypes.TabIndex = 3;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTypes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 65);
            panelFill.Margin = new Padding(5);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 385);
            panelFill.TabIndex = 4;
            panelFill.Paint += panelFill_Paint;
            // 
            // FormListTypes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список типов аниме";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btnAddType;
        private Button bntUpdateType;
        private Button btnDeleteType;
        private DataGridView dataGridViewTypes;
        private Panel panelFill;
    }
}