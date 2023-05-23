using Kii.odbConnectHelper;
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
using System.IO;
using Microsoft.Win32;

namespace Kii.MainPage
{
    /// <summary>
    /// Логика взаимодействия для PageFirst.xaml
    /// </summary>
    public partial class PageFirst : Page
    {
        byte[] UserImage;
        public PageFirst()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            test s = new test()
            {
                date1 = Convert.ToDateTime(da.SelectedDate),
                date2 = Convert.ToDateTime(ne.SelectedDate)
            };
            odbConnectApp.odbObj.test.Add(s);
            odbConnectApp.odbObj.SaveChanges();
        }

        private void btnImageLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Title = "Выберите картинку";
                op.Filter = "All Image|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
                if (op.ShowDialog() == true)
                {
                    imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
                    UserImage = File.ReadAllBytes(op.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
