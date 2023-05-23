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
using Kii.odbConnectHelper;

namespace Kii.MainPage
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var userObj = odbConnectApp.odbObj.User.FirstOrDefault(x => x.Login == txbLogin.Text && x.Password == txbPassword.Text);
            if (userObj!=null)
            {
                FrameApp.frmObj.Navigate(new PageMenu());
            }
        }
    }
}
