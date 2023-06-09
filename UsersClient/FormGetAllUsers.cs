using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersClient.Requests;

namespace UsersClient
{
    public partial class FormGetAllUsers : Form
    {
        private IRequester _requester;
        public FormGetAllUsers()
        {
            _requester = new Requester();
            InitializeComponent();
        }

        private async void FormGetAllUsers_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.Size = new Size(800, 1000);

            dataGridViewUsers.BackgroundColor = Color.AliceBlue;

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

            dataGridViewUsers.Columns.AddRange(column0, column1, column2, column3, column4);

            var users = await _requester.GetAllUsersAsync();

            if (users != null)
            {
                foreach (var user in users)
                {
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
                    dataGridViewUsers.Rows.Add(row);
                }
            }
        }
    }
}
