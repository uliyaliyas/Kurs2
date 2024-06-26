﻿using Kurs2.Model;
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
    /// Логика взаимодействия для AddRubric.xaml
    /// </summary>
    public partial class AddRubric : Window
    {
        public Rubric Rubric { get; set; }
        public AddRubric(Rubric rubric)
        {
            InitializeComponent();
            Rubric = rubric;
            DataContext = Rubric; // Привязка данных
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
