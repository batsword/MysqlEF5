using EFCodeFirst;
using MysqlEF.models;
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

namespace MysqlEF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = new UserEntity()
                {
                    Name = "Test",
                    Hobby = "ddd",
                    Age = 29
                };
                using (var context = new DContext())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    var accountUsers = context.Users.ToList();
                }
                Console.Write("{0}", user.Id);
            }
            catch (Exception ex)
            {
                Console.Write("{0}", ex);
            }
        }

        private void read_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new DContext())
            {
                var s = context.Users.Select(u => u);
                foreach (var item in s)
                {

                }
            }
        }
    }
}
