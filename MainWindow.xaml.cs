using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;


namespace WPF_timer
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4;)
                {
                    Button newButton = new Button();
                    MyGrid.Children.Add(newButton);
                    Grid.SetRow(newButton, row);
                    Grid.SetColumn(newButton, col);
                    newButton.Style = (Style)FindResource("buttons");
                }
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += HandleTick;
            timer.Start();
        }

        int increment = 0;

        private void HandleTick(object? sender, EventArgs e)
        {
            increment++;
            lblTime.Content = increment.ToString();
        }
    }


}