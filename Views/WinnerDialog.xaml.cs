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
using System.Windows.Shapes;

namespace Othello.Views
{
    /// <summary>
    /// Interaction logic for WinnerDialog.xaml
    /// </summary>
    public partial class WinnerDialog : Window
    {
        public WinnerDialog(string winner)
        {
            InitializeComponent();
            WinnerText.Text = $"{winner} wins!";
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
