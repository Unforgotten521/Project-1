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

namespace Project1
{
    /// <summary>
    /// Логика взаимодействия для ImageWin.xaml
    /// </summary>
    public partial class ImageWin : Window
    {
        public ImageWin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window bac = new MainWindow();
            bac.Show();
            this.Close();
        }
    }
}
