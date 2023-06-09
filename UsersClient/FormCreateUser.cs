using UsersClient.Requests;
using UsersClient.ViewModels;

namespace UsersClient
{
    public partial class FormCreateUser : Form
    {
        private IRequester _requester;

        public FormCreateUser()
        {
            InitializeComponent();
            _requester = new Requester();
        }

        private void buttonAddPhone_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBoxAddPhone.Text);
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxAddPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private async void buttonCreateUser_Click(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == string.Empty)
            {
                MessageBox.Show("Укажите номер телефона");
                return;
            }

            var userViewModel = new UserViewModel
            {
                PhoneNumber = textBoxPhone.Text,
                FIO = textBoxFIO.Text,
                Email = textBoxEmail.Text,
                Position = textBoxPosition.Text,
                Phones = new List<string>()
            };

            foreach (var number in listBox1.Items)
            {
                userViewModel.Phones.Add(number.ToString());
            }

            string resp = await _requester.CreateUserAsync(userViewModel);

            listBox1.Items.Clear();

            MessageBox.Show(resp);
        }
    }
}
