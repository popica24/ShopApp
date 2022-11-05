using Newtonsoft.Json;
namespace ShopApp
{
    public partial class LoginForm : Form
    {
        UserList Users;
        ShopForm S = new ShopForm();
        public LoginForm()
        {
            
            Users = new UserList();
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User U = new User() { Username = UsernameBox.Text, Password = PasswordBox.Text };
            if (Users.CheckCredidentials(U) == true)
            {
                S.Show();
                this.Hide();
            }
        }

        private void SignUpBox_Click(object sender, EventArgs e)
        {
           
            User U = new User() { Username = UsernameBox.Text, Password = PasswordBox.Text };
          
            if (Users.CheckDuplicate(U) == true)
            {
                UsernameBox.Text = "";
                PasswordBox.Text = "";
            }
            else
            {
                Users.Add(U);
                S.Show();
                this.Hide();
            }
        }
    }
}