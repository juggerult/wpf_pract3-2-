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
using wpf_pract3_2_;

namespace wpf_pract3_2_
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            txtMessage.Text = "Default message";
        }

        private void btnAction_Click(object sender, RoutedEventArgs e)
        {
            txtMessage.Text = "Activated";
            btnAction.Content = "Try again?";
        }

    }
}
