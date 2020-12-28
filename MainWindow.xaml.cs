using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace chronON
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

        private void ChronoButton_Click(object sender, RoutedEventArgs e)
        {
            var chronoControl = new ChronoControl();
            ControlGrid.Children.Clear();
            ControlGrid.Children.Add();
        }

        private void TimerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PomodoroButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
