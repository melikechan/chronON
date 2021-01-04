using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using chronON.UserControls.StatusControls;
using chronON.UserControls.InputControls;

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
            var chronoInput = new ChronoInputControl();
            UserInputGrid.Children.Add(chronoInput);
            ControlGrid.Children.Add(chronoControl);
        }

        private void TimerButton_Click(object sender, RoutedEventArgs e)
        {
            ControlGrid.Children.Clear();
            var timerControl = new TimerControl();
            var timerInput = new TimerInputControl();
            ControlGrid.Children.Add(timerControl);
            UserInputGrid.Children.Add(timerInput);
        }

        private void PomodoroButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
