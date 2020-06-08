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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BinaryConverter
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

        private string ToBinary(string str)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in str.ToCharArray())
            {
                sb.Append(System.Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        private void Convert(object sender, RoutedEventArgs e)
        {
            var text = input_text.Text;
            txt_result.Text = ToBinary(text);
        }
    }
}
