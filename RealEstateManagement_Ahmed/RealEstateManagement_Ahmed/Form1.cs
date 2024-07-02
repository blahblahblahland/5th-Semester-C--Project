namespace RealEstateManagement_Ahmed
{
    public partial class Start_Screen : Form
    {
        public Start_Screen()
        {
            InitializeComponent();
        }

        private void buy_button_Click(object sender, EventArgs e)
        {
            buy_screen f2 = new buy_screen();
            f2.Show();
        }

        private void sell_button_Click(object sender, EventArgs e)
        {
            sell_screen f3 = new sell_screen();
            f3.Show();
        }

        private void Status_btn_Click(object sender, EventArgs e)
        {
            status_screen f4 = new status_screen();
            f4.Show(); 
        }
    }
}
