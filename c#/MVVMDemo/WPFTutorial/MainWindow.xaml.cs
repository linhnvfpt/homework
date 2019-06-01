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

namespace WPFTutorial
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

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    txt1.Text = "button is clicked";
        //}

        //private void StackPanel_Click(object sender, RoutedEventArgs e)
        //{
        //    txt2.Text = "click event is bubbled to stack panel";
        //    e.Handled = true;  // stop event bubbled
        //}

        //private void Window_Click(object sender, RoutedEventArgs e)
        //{
        //    txt3.Text = "Click event is bubbled to Window";
        //}
    }
}
