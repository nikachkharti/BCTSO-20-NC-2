namespace Lecture23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            loadingLabel.Text = "Loading....";

            var user = await GetUserDetails();
            var order = await GetOrderDetails();

            userLabel.Text = user;
            ordersLabel.Text = order;
        }

        static async Task<string> GetUserDetails()
        {
            await Task.Delay(100);
            return "Nika,Chkhartishvili,29,nika@gmail.com";
        }

        static async Task<string> GetOrderDetails()
        {
            await Task.Delay(100);
            return "12345,Laptop,1,1200$";
        }

    }
}
