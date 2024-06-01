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
            this.users = new List<User>();

        }

        public User currentUser;

        public List<User> users;

        public void initializeBudgestion(object sender, RoutedEventArgs e)
        {
            Start.Visibility = Visibility.Collapsed;
            ProfileFormPanel.Visibility = Visibility.Visible;
        }

        public void createFirstUser(object sender, RoutedEventArgs e)
        {
            string username = UsernameInput.Text;
            string password = PasswordInput.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez saisir un nom d'utilisateur et un mot de passe.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            User newUser = new User(username, password);
            this.users.Add(newUser);
            this.currentUser = newUser;

            UsernameInput.Clear();
            PasswordInput.Clear();
            ProfileFormPanel.Visibility = Visibility.Collapsed;
            UserFrame.Visibility = Visibility.Visible;
            UserFrame.Content = this.currentUser;

            DisconnectButton.Visibility = Visibility.Visible;
            
        }


        /// <summary>
        /// @param String name 
        /// @param String password
        /// </summary>
        public void connectUser(object sender, RoutedEventArgs e)
        {
            string name = UsernameInput.Text;
            string password = PasswordInput.Text;

            foreach (User user in users)
            {
                if (user.name == name && user.password == password)
                {
                    this.currentUser = user;
                    UserFrame.Content = this.currentUser;
                    UsernameInput.Clear();
                    PasswordInput.Clear();
                    DisconnectButton.Visibility = Visibility.Visible;
                    ProfileFormPanel.Visibility = Visibility.Collapsed;
                    return;
                }
            }

            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void isUserConnected()
        {
            // TODO implement here
        }

        public void disconnectUser(object sender, RoutedEventArgs e)
        {
            this.currentUser = null;
            UserFrame.Content = null;
            ProfileFormPanel.Visibility= Visibility.Visible;
            DisconnectButton.Visibility = Visibility.Collapsed;
        }

        public void getUsers()
        {
            // TODO implement here
        }

        public void getCurrentUser()
        {
            // TODO implement here
        }

        public void budgetClick(object sender, RoutedEventArgs e)
        {
            if (currentUser == null) 
            {
                MessageBox.Show("Veuillez vous connecter pour ajouter un budget", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}
