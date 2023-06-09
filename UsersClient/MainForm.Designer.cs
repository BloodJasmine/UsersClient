namespace UsersClient
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonRedactUserForm = new Button();
            buttonCreateUserForm = new Button();
            label1 = new Label();
            buttonGetAllUsersForm = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonRedactUserForm
            // 
            buttonRedactUserForm.Location = new Point(236, 71);
            buttonRedactUserForm.Name = "buttonRedactUserForm";
            buttonRedactUserForm.Size = new Size(94, 29);
            buttonRedactUserForm.TabIndex = 1;
            buttonRedactUserForm.Text = "Получить";
            buttonRedactUserForm.UseVisualStyleBackColor = true;
            buttonRedactUserForm.Click += buttonRedactUserForm_Click;
            // 
            // buttonCreateUserForm
            // 
            buttonCreateUserForm.Location = new Point(236, 121);
            buttonCreateUserForm.Name = "buttonCreateUserForm";
            buttonCreateUserForm.Size = new Size(94, 29);
            buttonCreateUserForm.TabIndex = 2;
            buttonCreateUserForm.Text = "Создать";
            buttonCreateUserForm.UseVisualStyleBackColor = true;
            buttonCreateUserForm.Click += buttonCreateUserForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 5;
            label1.Text = "Получить всех пользователей:";
            // 
            // buttonGetAllUsersForm
            // 
            buttonGetAllUsersForm.Location = new Point(236, 21);
            buttonGetAllUsersForm.Name = "buttonGetAllUsersForm";
            buttonGetAllUsersForm.Size = new Size(94, 29);
            buttonGetAllUsersForm.TabIndex = 6;
            buttonGetAllUsersForm.Text = "Получить";
            buttonGetAllUsersForm.UseVisualStyleBackColor = true;
            buttonGetAllUsersForm.Click += buttonGetAllUsersForm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 7;
            label2.Text = "Получить пользователя:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 8;
            label3.Text = "Создать пользователя:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 190);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonGetAllUsersForm);
            Controls.Add(label1);
            Controls.Add(buttonCreateUserForm);
            Controls.Add(buttonRedactUserForm);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Клиент для UserService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonRedactUserForm;
        private Button buttonCreateUserForm;
        private Label label1;
        private Button buttonGetAllUsersForm;
        private Label label2;
        private Label label3;
    }
}