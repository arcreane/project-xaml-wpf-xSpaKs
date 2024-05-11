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
    /// Logique d'interaction pour User.xaml
    /// </summary>
    public partial class User : Page
    {
        public User(String name, String password)
        {
            InitializeComponent();
            
            this.name = name;
            this.password = password;

            UsernameLabel.Content = "Nom d'utilisateur : " + name;
        }

        public int id;

        public String name;

        public String password;

        public List<Budget> budgets;

        public float money;

        /// <summary>
        /// @param String name 
        /// @param String password
        /// </summary>

        /// <summary>
        /// @param float amount 
        /// @param Budget budget
        /// </summary>
        /// 
        private void AddBudget(object sender, RoutedEventArgs e)
        {
            AddBudgetButton.Visibility = Visibility.Collapsed;
            AddBudgetPanel.Visibility = Visibility.Visible;
        }

        private void ValidateBudget(object sender, RoutedEventArgs e)
        {
            String name = NameBudgetInput.Text;
            String amount = AmountBudgetInput.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(amount))
            {
                MessageBox.Show("Veuillez saisir un nom de budget et un montant.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            float amountFloat = float.Parse(amount);

            Budget newBudget = new Budget(name, amountFloat);
            this.budgets.Add(newBudget);

            AddBudgetPanel.Visibility = Visibility.Collapsed;
        }

        private void CancelBudget(object sender, RoutedEventArgs e) 
        {
            AddBudgetButton.Visibility = Visibility.Visible;
            AddBudgetPanel.Visibility = Visibility.Collapsed;
            NameBudgetInput.Text = "";
            AmountBudgetInput.Text = "";
            
        }

        public void setMoney(float money)
        {
            this.money = money;
        }

        public void spendMoney(float amount, Budget budget)
        {
            // TODO implement here
        }

        public void viewBudgets()
        {
            // TODO implement here
        }

        public void editName()
        {
            // TODO implement here
        }

        public void editPassword()
        {
            // TODO implement here
        }

        public void getName()
        {
            // TODO implement here
        }

        public void getPassword()
        {
            // TODO implement here
        }

        public void getBudgets()
        {
            // TODO implement here
        }
    }
}
