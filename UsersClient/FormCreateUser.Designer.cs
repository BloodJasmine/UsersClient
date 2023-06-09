namespace UsersClient
{
    partial class FormCreateUser
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonCreateUser = new Button();
            label6 = new Label();
            textBoxPhone = new TextBox();
            textBoxFIO = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPosition = new TextBox();
            textBoxAddPhone = new TextBox();
            listBox1 = new ListBox();
            label7 = new Label();
            buttonAddPhone = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(220, 35);
            label1.TabIndex = 0;
            label1.Text = "Заполните форму";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Телефон:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "ФИО:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 225);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 4;
            label5.Text = "Должность:";
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Location = new Point(12, 530);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(555, 29);
            buttonCreateUser.TabIndex = 5;
            buttonCreateUser.Text = "Создать";
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += buttonCreateUser_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 275);
            label6.Name = "label6";
            label6.Size = new Size(206, 20);
            label6.TabIndex = 6;
            label6.Text = "Дополнительные телефоны:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(240, 72);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(327, 27);
            textBoxPhone.TabIndex = 7;
            textBoxPhone.KeyPress += textBoxPhone_KeyPress;
            // 
            // textBoxFIO
            // 
            textBoxFIO.Location = new Point(240, 122);
            textBoxFIO.Name = "textBoxFIO";
            textBoxFIO.Size = new Size(327, 27);
            textBoxFIO.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(240, 172);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(327, 27);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(240, 222);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(327, 27);
            textBoxPosition.TabIndex = 10;
            // 
            // textBoxAddPhone
            // 
            textBoxAddPhone.Location = new Point(286, 437);
            textBoxAddPhone.Name = "textBoxAddPhone";
            textBoxAddPhone.Size = new Size(281, 27);
            textBoxAddPhone.TabIndex = 11;
            textBoxAddPhone.KeyPress += textBoxAddPhone_KeyPress;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 317);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(555, 104);
            listBox1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 440);
            label7.Name = "label7";
            label7.Size = new Size(269, 20);
            label7.TabIndex = 13;
            label7.Text = "Добавить дополнительный телефон: ";
            // 
            // buttonAddPhone
            // 
            buttonAddPhone.Location = new Point(215, 484);
            buttonAddPhone.Name = "buttonAddPhone";
            buttonAddPhone.Size = new Size(136, 29);
            buttonAddPhone.TabIndex = 15;
            buttonAddPhone.Text = "Добавить";
            buttonAddPhone.UseVisualStyleBackColor = true;
            buttonAddPhone.Click += buttonAddPhone_Click;
            // 
            // FormCreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 586);
            Controls.Add(buttonAddPhone);
            Controls.Add(label7);
            Controls.Add(listBox1);
            Controls.Add(textBoxAddPhone);
            Controls.Add(textBoxPosition);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxFIO);
            Controls.Add(textBoxPhone);
            Controls.Add(label6);
            Controls.Add(buttonCreateUser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCreateUser";
            Text = "Создать пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonCreateUser;
        private Label label6;
        private TextBox textBoxPhone;
        private TextBox textBoxFIO;
        private TextBox textBoxEmail;
        private TextBox textBoxPosition;
        private TextBox textBoxAddPhone;
        private ListBox listBox1;
        private Label label7;
        private Button buttonAddPhone;
    }
}