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
using System.Windows;

namespace DailyPositivity
{
    /// <summary>
    /// Interaction logic for ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window

    {
        
        Object selectedItem;

        public ChatWindow()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var input = userInput.Text;
            //int selectedIndex = ComboBox1.SelectedIndex;
            //Object selectedItem = ComboBox1.SelectedItem;

            

            

            MessageBox.Show("I know that " + input  + " seems hard right now, but it will get better.\n The first step is to talk to someone."); ;
        }

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //    int selectedIndex = ComboBox1.SelectedIndex;
        //    Object selectedItem = ComboBox1.SelectedItem;

        //    var labeltext = lbl.Content.ToString();

        //    labeltext = ComboBox1.Text;
            
        //}

        
    }
}
