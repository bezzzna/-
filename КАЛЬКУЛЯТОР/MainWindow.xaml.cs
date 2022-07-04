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

namespace КАЛЬКУЛЯТОР
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       


        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }
        float a, b;
        int count;
        bool znak = true; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "1";
        }

        private void n2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "2";
        }

        private void n3_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "3";
        }

        private void n4_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "4";
        }

        private void n5_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "5";
        }

        private void n6_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "6";
        }

        private void n7_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "7";
        }

        private void n8_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "8";
        }

        private void n9_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "9";
        }

        private void nc_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            label1.Text = " ";
            
        }

        private void zp_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += ",";
           
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void res_Click(object sender, RoutedEventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void star_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void ce_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            label1.Text = " ";
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text[0] == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = "-" + textBox1.Text;
        }

        private void sqrt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void n0_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "0";
        }

        
    }
}
