using System.Windows;

namespace Loginusercontrol
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            MainContent.Content = new LoginView();
        }
    }
}
