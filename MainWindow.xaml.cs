using System.Windows;

namespace WPFTutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            tbHello.Text = "Hello from Code Behind!";
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            if(tbHello.Text == "Hello from Code Behind!")
            {
                tbHello.Text = "Hello Jeff!";
            }
            else
            {
                tbHello.Text = "Hello from Code Behind!";
            }
        }
    }
}
