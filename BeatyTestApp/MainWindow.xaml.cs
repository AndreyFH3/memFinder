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

namespace BeatyTestApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void home_btn_Click(object sender, RoutedEventArgs e)
        {
            Home_page.Margin = new Thickness(0, 0, 0, 0);
            Link_page.Margin = new Thickness(800, 0, 0, 0);
            Sort_page.Margin = new Thickness(0, 800, 0, 0);
            info_page.Margin = new Thickness(0, 0, 800, 0);
        }

        private void sort_btn_Click(object sender, RoutedEventArgs e)
        {
            Home_page.Margin = new Thickness(0, 800, 0, 0);
            Link_page.Margin = new Thickness(800, 0, 0, 0);
            Sort_page.Margin = new Thickness(0, 0, 0, 0);
            info_page.Margin = new Thickness(0, 0, 800, 0);
        }

        private void link_btn_Click(object sender, RoutedEventArgs e)
        {
            Home_page.Margin = new Thickness(0, 800, 0, 0);
            Link_page.Margin = new Thickness(0, 0, 0, 0);
            Sort_page.Margin = new Thickness(0, 0, 0, 800);
            info_page.Margin = new Thickness(0, 0, 800, 0);
        }

        private void info_btn_Click(object sender, RoutedEventArgs e)
        {
            Home_page.Margin = new Thickness(0, 800, 0, 0);
            Link_page.Margin = new Thickness(800, 0, 0, 0);
            Sort_page.Margin = new Thickness(0, 0, 800, 0);
            info_page.Margin = new Thickness(0, 0, 0, 0);
        }
    }
}
