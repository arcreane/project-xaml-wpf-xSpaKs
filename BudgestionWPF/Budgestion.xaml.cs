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
using System.Xml.Linq;

namespace BudgestionWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class Budgestion : Window
    {
        public Budgestion()
        {
            InitializeComponent();
            
        }

        public User currentUser;

        public List<User> users;

        public void InitializeBudgestion(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// @param String name 
        /// @param String password
        /// </summary>
        public void connectUser(String name, String password)
        {
            currentUser = new User(name, password);
        }

        public void isUserConnected()
        {
            // TODO implement here
        }

        public void disconnectUser()
        {
            // TODO implement here
        }

        public void getUsers()
        {
            // TODO implement here
        }

        public void getCurrentUser()
        {
            // TODO implement here
        }
    }
}
