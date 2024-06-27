using Kurs2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kurs2.View
{
    /// <summary>
    /// Логика взаимодействия для AddArticle.xaml
    /// </summary>
    public partial class AddArticle : Window
    {
        public Article Article { get; set; }
        public AddArticle(Article article)
        {
            InitializeComponent();
            Article = article;
            DataContext = Article;
            using (KursDbContext db = new KursDbContext())
            {
                AutorId.ItemsSource = db.Autors.ToList();
                MagazineId.ItemsSource = db.Magazines.ToList();
                RubricId.ItemsSource = db.Rubrics.ToList();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
