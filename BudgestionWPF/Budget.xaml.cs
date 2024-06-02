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

   public partial class Budget
{
        public Budget(string name, float amount)
        {
            this.name = name;
            this.amount = amount;
            this.currentAmount = amount;
        }

        public string name { get; set; }
        public float amount { get; set; }
        public float currentAmount { get; set; }

        /// <summary>
        /// @param String name 
        /// @param float amount
        /// </summary>

        /// <summary>
        /// @param amount
        /// </summary>
        public void addExpense(float _amount)
        {
            if (amount > 0)
            {
                this.currentAmount -= _amount;
            }
            else
            {
                MessageBox.Show("Veuillez ajouter une dépense supérieure à 0.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void getName()
        {
            // TODO implement here
        }

        public void getAmount()
        {
            // TODO implement here
        }
    }
}
