namespace LB4
{
    partial class FormListStatuses
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
            bntUpdateStatus = new Button();
            flowLayoutPanelTop = new FlowLayoutPanel();
            btnAddStatus = new Button();
            btnDeleteStatus = new Button();
            panelFill = new Panel();
            dataGridViewStatuses = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatuses).BeginInit();
            SuspendLayout();
            // 
            // bntUpdateStatus
            // 
            bntUpdateStatus.AutoSize = true;
            bntUpdateStatus.Font = new Font("Segoe UI", 14.25F);
            bntUpdateStatus.Location = new Point(175, 15);
            bntUpdateStatus.Margin = new Padding(5);
            bntUpdateStatus.Name = "bntUpdateStatus";
            bntUpdateStatus.Size = new Size(151, 35);
            bntUpdateStatus.TabIndex = 1;
            bntUpdateStatus.Text = "Редактировать";
            bntUpdateStatus.UseVisualStyleBackColor = true;
            bntUpdateStatus.Click += BntUpdateStatus_Click;
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.Controls.Add(btnAddStatus);
            flowLayoutPanelTop.Controls.Add(bntUpdateStatus);
            flowLayoutPanelTop.Controls.Add(btnDeleteStatus);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Font = new Font("Segoe UI", 14.25F);
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Margin = new Padding(5);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(800, 65);
            flowLayoutPanelTop.TabIndex = 8;
            // 
            // btnAddStatus
            // 
            btnAddStatus.AutoSize = true;
            btnAddStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddStatus.Location = new Point(15, 15);
            btnAddStatus.Margin = new Padding(5);
            btnAddStatus.Name = "btnAddStatus";
            btnAddStatus.Size = new Size(150, 35);
            btnAddStatus.TabIndex = 0;
            btnAddStatus.Text = "Добавить";
            btnAddStatus.UseVisualStyleBackColor = true;
            btnAddStatus.Click += BtnAddStatus_Click;
            // 
            // btnDeleteStatus
            // 
            btnDeleteStatus.AutoSize = true;
            btnDeleteStatus.Font = new Font("Segoe UI", 14.25F);
            btnDeleteStatus.Location = new Point(336, 15);
            btnDeleteStatus.Margin = new Padding(5);
            btnDeleteStatus.Name = "btnDeleteStatus";
            btnDeleteStatus.Size = new Size(150, 35);
            btnDeleteStatus.TabIndex = 2;
            btnDeleteStatus.Text = "Удалить";
            btnDeleteStatus.UseVisualStyleBackColor = true;
            btnDeleteStatus.Click += BtnDeleteStatus_Click;
            // 
            // panelFill
            // 
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Margin = new Padding(5);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 450);
            panelFill.TabIndex = 9;
            // 
            // dataGridViewStatuses
            // 
            dataGridViewStatuses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatuses.BackgroundColor = Color.White;
            dataGridViewStatuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatuses.Dock = DockStyle.Fill;
            dataGridViewStatuses.GridColor = Color.Gray;
            dataGridViewStatuses.Location = new Point(0, 65);
            dataGridViewStatuses.Margin = new Padding(5);
            dataGridViewStatuses.MultiSelect = false;
            dataGridViewStatuses.Name = "dataGridViewStatuses";
            dataGridViewStatuses.ReadOnly = true;
            dataGridViewStatuses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStatuses.Size = new Size(800, 385);
            dataGridViewStatuses.TabIndex = 10;
            // 
            // FormListStatuses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewStatuses);
            Controls.Add(flowLayoutPanelTop);
            Controls.Add(panelFill);
            Name = "FormListStatuses";
            Text = "FormListStatuses";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatuses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntUpdateStatus;
        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btnAddStatus;
        private Button btnDeleteStatus;
        private Panel panelFill;
        private DataGridView dataGridViewStatuses;
    }
}