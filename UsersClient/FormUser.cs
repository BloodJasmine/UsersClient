using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using UsersClient.Requests;
using UsersClient.ViewModels;

namespace UsersClient
{
    public partial class FormUser : Form
    {
        private IRequester _requester;
        public FormUser()
        {
            _requester = new Requester();
            InitializeComponent();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var phone = textBoxFindPhone.Text;

            string resp = await _requester.DeleteUserAsync(phone);

            MessageBox.Show(resp);

        }
        private async void buttonFindPhone_Click(object sender, EventArgs e)
        {
            dataGridViewFindUser.Columns.Clear();

            var phoneNumber = textBoxFindPhone.Text;

            var user = await _requester.GetUserAsync(phoneNumber);

            if (!user.response.Error)
            {
                dataGridViewFindUser.BackgroundColor = Color.AliceBlue;

                DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
                column0.Name = "phoneNumber";
                column0.HeaderText = "Номер телефона";

                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.Name = "FIO";
                column1.HeaderText = "ФИО";

                DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                column2.Name = "email";
                column2.HeaderText = "Email";

                DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
                column3.Name = "position";
                column3.HeaderText = "Должность";

                DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
                column4.Name = "additionalPhones";
                column4.HeaderText = "Доп телефоны";

                dataGridViewFindUser.Columns.AddRange(column0, column1, column2, column3, column4);

                dataGridViewFindUser.Rows.Clear();

                DataGridViewCell phoneNumberCell = new DataGridViewTextBoxCell();
                DataGridViewCell fioCell = new DataGridViewTextBoxCell();
                DataGridViewCell emailCell = new DataGridViewTextBoxCell();
                DataGridViewCell positionCell = new DataGridViewTextBoxCell();
                DataGridViewCell additionalNumbersCell = new DataGridViewTextBoxCell();

                phoneNumberCell.Value = user.PhoneNumber;
                fioCell.Value = user.FIO;
                emailCell.Value = user.Email;
                positionCell.Value = user.Position;

                foreach (var phone in user.Phones)
                {
                    additionalNumbersCell.Value += phone;
                    additionalNumbersCell.Value += " ";
                }

                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(phoneNumberCell, fioCell, emailCell, positionCell, additionalNumbersCell);
                dataGridViewFindUser.Rows.Add(row);
                phoneNumberCell.ReadOnly = true;


                dataGridViewFindUser.Visible = true;
                buttonChangeUser.Visible = true;
                buttonDeleteUser.Visible = true;
            }
        }

        private void textBoxFindPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private async void buttonChangeUser_Click(object sender, EventArgs e)
        {
            var userViewModel = new UserViewModel
            {
                PhoneNumber = dataGridViewFindUser.Rows[0].Cells[0].Value.ToString(),
                FIO = dataGridViewFindUser.Rows[0].Cells[1].Value.ToString(),
                Email = dataGridViewFindUser.Rows[0].Cells[2].Value.ToString(),
                Position = dataGridViewFindUser.Rows[0].Cells[3].Value.ToString(),
                Phones = new List<string>()
            };

            var phones = dataGridViewFindUser.Rows[0].Cells[4].Value.ToString()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var phone in phones)
            {
                userViewModel.Phones.Add(phone);
            }

            var resp = await _requester.ChangeUserAsync(userViewModel);

            MessageBox.Show(resp.ToString());

        }

        private async void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            var phone = textBoxFindPhone.Text;

            string resp = await _requester.DeleteUserAsync(phone);

            MessageBox.Show(resp);

        }
    }
}
