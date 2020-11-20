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

namespace WpfKwistet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem groupname = (ListBoxItem)lbxGroupNames.SelectedItem;
            lbxGroupNames.Items.Add(txtGroupName.Text);
            txtGroupName.Text = "";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbxGroupNames.SelectedItem != null)
            {
                lbxGroupNames.Items.RemoveAt(lbxGroupNames.Items.IndexOf(lbxGroupNames.SelectedItem));
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            lbxGroupNames.Items.Clear();
        }
    }
}
