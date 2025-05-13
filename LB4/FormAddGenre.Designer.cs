namespace LB4
{
    partial class FormAddGenre
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
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            errorProvider = new ErrorProvider(components);
            panelFill = new Panel();
            textBoxGenreName = new TextBox();
            labelGenreName = new Label();
            flowLayoutPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            panelFill.SuspendLayout();
            SuspendLayout();
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
            flowLayoutPanelBottom.TabIndex = 1;
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
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxGenreName);
            panelFill.Controls.Add(labelGenreName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10, 10, 20, 10);
            panelFill.Size = new Size(409, 106);
            panelFill.TabIndex = 0;
            // 
            // textBoxGenreName
            // 
            textBoxGenreName.Dock = DockStyle.Top;
            textBoxGenreName.Location = new Point(10, 35);
            textBoxGenreName.Margin = new Padding(5);
            textBoxGenreName.Name = "textBoxGenreName";
            textBoxGenreName.Size = new Size(379, 33);
            textBoxGenreName.TabIndex = 1;
            textBoxGenreName.TextChanged += TextBoxGenreName_TextChanged;
            textBoxGenreName.Validating += TextBoxGenreName_Validating;
            // 
            // labelGenreName
            // 
            labelGenreName.AutoSize = true;
            labelGenreName.Dock = DockStyle.Top;
            labelGenreName.Location = new Point(10, 10);
            labelGenreName.Margin = new Padding(5, 0, 5, 0);
            labelGenreName.Name = "labelGenreName";
            labelGenreName.Size = new Size(120, 25);
            labelGenreName.TabIndex = 0;
            labelGenreName.Text = "Жанр аниме";
            // 
            // FormAddGenre
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(409, 171);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddGenre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о жанре аниме";
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button btnSaveChanges;
        private Button btnCancel;
        private ErrorProvider errorProvider;
        private Panel panelFill;
        protected internal TextBox textBoxGenreName;
        private Label labelGenreName;
    }
}