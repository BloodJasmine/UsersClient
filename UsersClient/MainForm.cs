namespace UsersClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreateUserForm_Click(object sender, EventArgs e)
        {
            FormCreateUser newForm = new FormCreateUser();
            newForm.Show();
        }

        private void buttonRedactUserForm_Click(object sender, EventArgs e)
        {
            FormUser newForm = new FormUser();
            newForm.Show();
        }

        private void buttonGetAllUsersForm_Click(object sender, EventArgs e)
        {
            FormGetAllUsers newForm = new FormGetAllUsers();
            newForm.Show();
        }
    }
}