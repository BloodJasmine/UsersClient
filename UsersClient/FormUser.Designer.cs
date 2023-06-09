namespace UsersClient
{
    partial class FormUser
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
            label1 = new Label();
            textBoxFindPhone = new TextBox();
            buttonFindPhone = new Button();
            dataGridViewFindUser = new DataGridView();
            buttonChangeUser = new Button();
            buttonDeleteUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFindUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите номер телефона: ";
            // 
            // textBoxFindPhone
            // 
            textBoxFindPhone.Location = new Point(210, 22);
            textBoxFindPhone.Name = "textBoxFindPhone";
            textBoxFindPhone.Size = new Size(555, 27);
            textBoxFindPhone.TabIndex = 1;
            textBoxFindPhone.KeyPress += textBoxFindPhone_KeyPress;
            // 
            // buttonFindPhone
            // 
            buttonFindPhone.Location = new Point(771, 21);
            buttonFindPhone.Name = "buttonFindPhone";
            buttonFindPhone.Size = new Size(125, 29);
            buttonFindPhone.TabIndex = 2;
            buttonFindPhone.Text = "Получить";
            buttonFindPhone.UseVisualStyleBackColor = true;
            buttonFindPhone.Click += buttonFindPhone_Click;
            // 
            // dataGridViewFindUser
            // 
            dataGridViewFindUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFindUser.Location = new Point(12, 84);
            dataGridViewFindUser.Name = "dataGridViewFindUser";
            dataGridViewFindUser.RowHeadersWidth = 51;
            dataGridViewFindUser.RowTemplate.Height = 29;
            dataGridViewFindUser.Size = new Size(884, 188);
            dataGridViewFindUser.TabIndex = 3;
            dataGridViewFindUser.Visible = false;
            // 
            // buttonChangeUser
            // 
            buttonChangeUser.Location = new Point(12, 322);
            buttonChangeUser.Name = "buttonChangeUser";
            buttonChangeUser.Size = new Size(137, 36);
            buttonChangeUser.TabIndex = 4;
            buttonChangeUser.Text = "Изменить";
            buttonChangeUser.UseVisualStyleBackColor = true;
            buttonChangeUser.Visible = false;
            buttonChangeUser.Click += buttonChangeUser_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Location = new Point(759, 322);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(137, 36);
            buttonDeleteUser.TabIndex = 5;
            buttonDeleteUser.Text = "Удалить";
            buttonDeleteUser.UseVisualStyleBackColor = true;
            buttonDeleteUser.Visible = false;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 372);
            Controls.Add(buttonDeleteUser);
            Controls.Add(buttonChangeUser);
            Controls.Add(dataGridViewFindUser);
            Controls.Add(buttonFindPhone);
            Controls.Add(textBoxFindPhone);
            Controls.Add(label1);
            Name = "FormUser";
            Text = "Работа с пользователем";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFindUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxFindPhone;
        private Button buttonFindPhone;
        private DataGridView dataGridViewFindUser;
        private Button buttonChangeUser;
        private Button buttonDeleteUser;
    }
}