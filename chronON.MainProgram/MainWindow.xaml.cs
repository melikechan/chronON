using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using chronON.UserControls;

namespace chronON.MainProgram
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
            ControlGrid.Children.Clear();
            var chronoControl = new ChronoControl();
            ControlGrid.Children.Add(chronoControl);
        }

        private void TimerButton_Click(object sender, RoutedEventArgs e)
        {
            ControlGrid.Children.Clear();
            var timerControl = new TimerControl();
            ControlGrid.Children.Add(timerControl);
        }

        private void PomodoroButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
