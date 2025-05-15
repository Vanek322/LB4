namespace LB4
{
    partial class FormAddStatus
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
            components = new System.ComponentModel.Container();
            panelFill = new Panel();
            textBoxStatusName = new TextBox();
            labelStatusName = new Label();
            errorProvider = new ErrorProvider(components);
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            flowLayoutPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(textBoxStatusName);
            panelFill.Controls.Add(labelStatusName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10, 10, 20, 10);
            panelFill.Size = new Size(409, 171);
            panelFill.TabIndex = 4;
            // 
            // textBoxStatusName
            // 
            textBoxStatusName.Dock = DockStyle.Top;
            textBoxStatusName.Location = new Point(10, 35);
            textBoxStatusName.Margin = new Padding(5);
            textBoxStatusName.Name = "textBoxStatusName";
            textBoxStatusName.Size = new Size(379, 33);
            textBoxStatusName.TabIndex = 1;
            textBoxStatusName.TextChanged += TextBoxStatusName_TextChanged;
            textBoxStatusName.Validating += TextBoxGenreName_Validating;
            // 
            // labelStatusName
            // 
            labelStatusName.AutoSize = true;
            labelStatusName.Dock = DockStyle.Top;
            labelStatusName.Location = new Point(10, 10);
            labelStatusName.Margin = new Padding(5, 0, 5, 0);
            labelStatusName.Name = "labelStatusName";
            labelStatusName.Size = new Size(128, 25);
            labelStatusName.TabIndex = 0;
            labelStatusName.Text = "Статус аниме";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.Controls.Add(btnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(btnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 106);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10, 10, 20, 10);
            flowLayoutPanelBottom.Size = new Size(409, 65);
            flowLayoutPanelBottom.TabIndex = 7;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.DialogResult = DialogResult.OK;
            btnSaveChanges.Location = new Point(15, 15);
            btnSaveChanges.Margin = new Padding(5);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(115, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(140, 15);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(409, 171);
            Controls.Add(flowLayoutPanelBottom);
            Controls.Add(panelFill);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о статусе аниме";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelFill;
        protected internal TextBox textBoxStatusName;
        private Label labelStatusName;
        private ErrorProvider errorProvider;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button btnSaveChanges;
        private Button btnCancel;
    }
}