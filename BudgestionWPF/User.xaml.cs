﻿using System;
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
