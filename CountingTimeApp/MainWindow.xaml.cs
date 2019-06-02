using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
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
        ProcessList processList = ProcessList.Instance;

        public MainWindow()
        {
            InitializeComponent();
            InitTimer();
            //ProcessList procesList = new ProcessList();
            //lvUsers.ItemsSource = procesList.processes;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            AddActivity addActivity = new AddActivity();
            addActivity.Show();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Row_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int selected_index = dataGrid.SelectedIndex;
            processList.startCountingTimeForProcess(selected_index);
        }
        private void AddProcesListToDataGreed()
        {
            dataGrid.Items.Clear();
            foreach (MyProces proc in processList.processes)
            {
                proc.Time = DateTime.Now.Subtract(proc.StartTime);
                dataGrid.Items.Add(proc);
            }
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AddProcesListToDataGreed();
        }

        //private async void RefreshButton_ClickAsync(object sender, RoutedEventArgs e)
        //{
        //    refreshButton.IsEnabled = false;
        //    await Task.Run(() =>
        //    {
        //        ProcessList procesList = new ProcessList();
        //        this.Dispatcher.Invoke(() =>
        //        {
        //            lvUsers.ItemsSource = procesList.processes;
        //        });
        //    });
        //    refreshButton.IsEnabled = true;
        //}

        //private void AddProc_Click(object sender, RoutedEventArgs e)
        //{
        //    var procesList = lvUsers.SelectedItems;
        //    foreach(var a in lvUsers.SelectedItems)
        //    {
        //        totalProc.Items.Add(a);
        //    }
        //}
        //private void RemoveProc_Click(object sender, RoutedEventArgs e)
        //{
        //   var selectedItems = totalProc.SelectedItems;

        //    if (totalProc.SelectedIndex != -1)
        //    {
        //        for (int i = selectedItems.Count - 1; i >= 0; i--)
        //            totalProc.Items.Remove(selectedItems[i]);
        //    }
        //    else
        //        MessageBox.Show("Debe seleccionar un email");
        //}
    }
}
