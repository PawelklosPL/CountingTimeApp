using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace CountingTimeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ProcessList procesList = new ProcessList();
            lvUsers.ItemsSource = procesList.processes;
        }

        private async void RefreshButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            refreshButton.IsEnabled = false;
            await Task.Run(() =>
            {
                ProcessList procesList = new ProcessList();
                this.Dispatcher.Invoke(() =>
                {
                    lvUsers.ItemsSource = procesList.processes;
                });
            });
            refreshButton.IsEnabled = true;
        }

        private void AddProc_Click(object sender, RoutedEventArgs e)
        {
            var procesList = lvUsers.SelectedItems;
            foreach(var a in lvUsers.SelectedItems)
            {
                totalProc.Items.Add(a);
            }
        }
        private void RemoveProc_Click(object sender, RoutedEventArgs e)
        {
           var selectedItems = totalProc.SelectedItems;

            if (totalProc.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    totalProc.Items.Remove(selectedItems[i]);
            }
            else
                MessageBox.Show("Debe seleccionar un email");
        }
    }
}
