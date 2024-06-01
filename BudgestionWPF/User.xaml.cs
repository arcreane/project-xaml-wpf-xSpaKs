using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public User(string name, string password)
        {
            InitializeComponent();
            
            this.name = name;
            this.password = password;

            UsernameLabel.Content = "Nom d'utilisateur : " + name;

            this.budgets = new ObservableCollection<Budget>();

            this.DataContext = this;
            BudgetsListBox.ItemsSource = budgets;

            if (budgets.Count ==  0) 
            { 
                BudgetsListBox.Visibility = Visibility.Collapsed;
                BudgetListEmpty.Visibility = Visibility.Visible;
            }
            else
            { 
                BudgetsListBox.Visibility= Visibility.Visible; 
                BudgetListEmpty.Visibility= Visibility.Collapsed;
            }
        }

        public int id;

        public string name;

        public string password;

        public ObservableCollection<Budget> budgets;

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
            string name = NameBudgetInput.Text;
            string amount = AmountBudgetInput.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(amount))
            {
                MessageBox.Show("Veuillez saisir un nom de budget et un montant.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            float amountFloat;
            if (float.TryParse(amount, out amountFloat)) {
                Budget newBudget = new Budget(name, amountFloat);
                this.budgets.Add(newBudget);

                BudgetsListBox.Items.Refresh();
                AddBudgetPanel.Visibility = Visibility.Collapsed;
                AddBudgetButton.Visibility = Visibility.Visible;
                BudgetsListBox.Visibility = Visibility.Visible;
                BudgetListEmpty.Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageBox.Show("Veuillez saisir une valeur numérique pour le montant du budget", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelBudget(object sender, RoutedEventArgs e) 
        {
            AddBudgetButton.Visibility = Visibility.Visible;
            AddBudgetPanel.Visibility = Visibility.Collapsed;
            NameBudgetInput.Text = "";
            AmountBudgetInput.Text = "";
            
        }

        private void ModifyBudget(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.CommandParameter is Budget selectedBudget)
            {
                ModifyBudgetNameTextBox.Text = selectedBudget.name;
                ModifyBudgetAmountTextBox.Text = selectedBudget.amount.ToString();
                ModifyBudgetPanel.Visibility = Visibility.Visible;
                
            }
        }

        private void SaveModifiedBudget(object sender, RoutedEventArgs e)
        {

            float number = 0;
            if (float.TryParse(ModifyBudgetAmountTextBox.Text, out number))
            {
                var budget = this.budgets.FirstOrDefault(b => b.name == ModifyBudgetNameTextBox.Text);
                if (budget != null)
                {
                    budget.amount = number;
                    budget.currentAmount = number;
                    ModifyBudgetPanel.Visibility = Visibility.Hidden;

                    BudgetsListBox.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Aucun budget correspondant n'a été trouvé.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir une valeur numérique pour le montant du budget", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
           

        private void CancelModification(object sender, RoutedEventArgs e)
        {
            ModifyBudgetPanel.Visibility = Visibility.Hidden;
        }

        private void DeleteBudget(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.CommandParameter is Budget budget)
            {
                budgets.Remove(budget);
            }

            if (budgets.Count == 0)
            {
                BudgetsListBox.Visibility = Visibility.Collapsed;
                BudgetListEmpty.Visibility = Visibility.Visible;
            }
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
