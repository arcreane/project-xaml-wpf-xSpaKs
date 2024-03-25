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
    /// Logique d'interaction pour Page1.xaml
    /// </summary>
    public partial class Budget : Page
    {
        public Budget()
        {
            InitializeComponent();
        }

        public String name;

        public float amount;

        public float currentAmount;

        /// <summary>
        /// @param String name 
        /// @param float amount
        /// </summary>
        public void __init__(String name, float amount)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param amount
        /// </summary>
        public void addExpense(float amount)
        {
            // TODO implement here
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
