using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace IntelliShopMobile.Pages
{
    public partial class porShopping : PhoneApplicationPage
    {
        public porShopping()
        {
            InitializeComponent();
        }

        private void btnNewList_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/porNewList.xaml", UriKind.Relative));
        }
    }
}