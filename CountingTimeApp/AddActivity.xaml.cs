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
using System.Windows.Shapes;

namespace CountingTimeApp
{
    /// <summary>
    /// Interaction logic for AddActivity.xaml
    /// </summary>
    public partial class AddActivity : Window
    {
        public AddActivity()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            createNewProcessList();
            this.Close();
        }
        private void createNewProcessList()
        {
            MyProces currentProcesInput = new MyProces();
            currentProcesInput.Name = LabelInputName.Text;
            currentProcesInput.Path = LabelInputPath.Text;
            currentProcesInput.MainWindowTitle = LabelInputName.Text;
            currentProcesInput.TimeIsCounted = false;
            currentProcesInput.StartTime = DateTime.Now;
            currentProcesInput.Time = TimeSpan.Zero;

            ProcessList processList = ProcessList.Instance;
            processList.processes.Add(currentProcesInput);
        }
    }
}
