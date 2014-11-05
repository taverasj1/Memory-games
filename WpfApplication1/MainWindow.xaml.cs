using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfApplication1
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        private readonly DispatcherTimer _timer;
        private int _time = 12;
        private int _totalTime;

        public MainWindow()
        {
            InitializeComponent();
            /*_timer = new DispatcherTimer {Interval = TimeSpan.FromSeconds(0.9)}; // Starts timer.
            _timer.Tick += Timer_Tick;
            _timer.Start();
            _totalTime = _time; // Makes a copy for background to divide from. 
            DTimer.Text = _time.ToString();
             * */

        }
        /* Running a ticking clock
         **/
        private void Timer_Tick(Object sendor, EventArgs e)
        {
            _time--;
            DTimer.Text = _time.ToString();
            if (_time > 0)
            {
                if (_time <= 10)
                {
                    if (_time%2 == 0)
                    {
                        DTimer.Background = Brushes.DarkRed;
                    }
                    else
                    {
                        DTimer.Foreground = Brushes.MintCream;
                    }
                    
                    DTimer.Text = String.Format(_time.ToString()); // display timer
                }
                else
                {
                    
                    DTimer.Text = String.Format(_time.ToString());
                }
            }
            else
            {
                _timer.Stop();
                MessageBox.Show("Remember Faster!");
                MessageBox.Show(" OR ELSE {!!} ");
            }
            if (DTimer.Width > 0)
            {
                DTimer.Width = DTimer.Width - (Background1.Width/_totalTime);  // provides a progress bar of the time left.
            }
         }

        private void GridMousedDown (object sender, MouseButtonEventArgs e)
        {
            e.Handled = true; // prevents clicking of several layers.
           
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            //Create the game window
            var game = new GameWindow();
            game.Show(); //Makes the window visible

        }
    }
}