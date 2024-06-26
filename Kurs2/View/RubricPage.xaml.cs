using Kurs2.ModelView;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kurs2.View
{
    /// <summary>
    /// Логика взаимодействия для RubricPage.xaml
    /// </summary>
    public partial class RubricPage : Page
    {
        public RubricPage()
        {
            InitializeComponent();
            DataContext = new RubricPageModelView(this);
        }
    }
}
