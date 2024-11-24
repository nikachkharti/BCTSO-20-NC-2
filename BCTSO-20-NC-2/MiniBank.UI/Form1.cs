namespace MiniBank.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void msgBtn1_Click(object sender, EventArgs e)
        {
            Thread t1 = new(() => ChangeLabelText("მესიჯი 1", 2000));
            t1.Start();
        }

        private void msgBtn2_Click(object sender, EventArgs e)
        {
            Thread t2 = new(() => ChangeLabelText("მესიჯი 2", 3000));
            t2.Start();
        }

        private void ChangeLabelText(string message, int delay)
        {
            Thread.Sleep(delay);
            msgLabel.Text = message;
        }
    }
}
