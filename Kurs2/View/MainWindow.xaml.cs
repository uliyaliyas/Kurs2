using Kurs2.View;
using KursProject.View;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kurs2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameContainer.Navigate(new AutorPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameContainer.Navigate(new MainViewPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameContainer.Navigate(new RubricPage());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FrameContainer.Navigate(new MagazinePage());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FrameContainer.Navigate(new ArticlePage());
        }
    }
}