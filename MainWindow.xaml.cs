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

namespace DataGridFilasconDetalle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl = "https://static.wikia.nocookie.net/los-simpsom/images/4/4a/Homero-simpson-2.jpg/revision/latest?cb=20130413015655&path-prefix=es" });
            users.Add(new User() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17), ImageUrl= "https://static.wikia.nocookie.net/los-simpsom/images/3/38/3179_13910_1_marge.jpg/revision/latest?cb=20130413183220&path-prefix=es" });
            users.Add(new User() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), ImageUrl= "https://img.favpng.com/18/23/10/bart-simpson-homer-simpson-marge-simpson-maggie-simpson-lisa-simpson-png-favpng-ZkeRyvTDwie2yAzpWcJ5PpLUd.jpg" });

            dgUsers.ItemsSource = users;
        }

        public class User
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public DateTime Birthday { get; set; }

            public string ImageUrl { get; set; }
        }
    }
}
