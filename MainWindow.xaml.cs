using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

namespace DailyPositivity
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringCollection positivity = new StringCollection();
            string[] pos = new string[] { "Keep Going!", "You are awesome!", "Just because it is hard now does not mean it always will be!", "Make today great!","Yesterday is not ours to recover, but tomorrow is ours to win or lose.",
            "In every day, there are 1,440 minutes. That means we have 1,440 daily opportunities to make a positive impact.",
                "Let us rise up and be thankful, for if we didn’t learn a lot today, at least we learned a little, and if we didn’t learn a little, at least we didn’t get sick, and if we got sick, at least we didn’t die; so let us all be thankful.", "Stay true to who you are!" };
            positivity.AddRange(pos);

            Random rand = new Random();

            int index = rand.Next(positivity.Count);

            MessageBox.Show($"Daily Dose of Positivity is: {positivity[index]}");
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window = new ChatWindow();
            window.ShowDialog();

        }
    }
}
