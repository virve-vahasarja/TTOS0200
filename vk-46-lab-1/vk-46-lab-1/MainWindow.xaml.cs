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

namespace vk_46_lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> list = new List<string>(new string[] { "kissa", "koira", "lisko" });
            foreach (string name in list)
            {
                CheckBox boxi = new CheckBox();
                boxi.Content = name;
                stackPanel1.Children.Add(boxi);
            }
        }

        private void buyItems_Click(object sender, RoutedEventArgs e)
        {
            shoppingList.Text = "suppilo";
        }

    }
}
