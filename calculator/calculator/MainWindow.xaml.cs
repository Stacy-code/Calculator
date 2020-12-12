using System;
using System.Collections.Generic;
using System.Data;
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

namespace calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double res = 0.0;
        bool dor = false;
       
        public MainWindow()
        {
            InitializeComponent();
            TextBoxBig.Text = "Привет, я калькулятор!";
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            TextBoxBig.Text = "";
            res = 0.0;
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
             if (dor == true)
            {
                if (TextBoxSmall.Text != "")
                    TextBoxSmall.Text += "/";
                TextBoxBig.Text = "";
                dor = false;
            }
            else
            {
                if (TextBoxSmall.Text != "")
                    TextBoxSmall.Text += "/";
                TextBoxBig.Text = "";
            }
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            TextBoxBig.Text = "";
            TextBoxSmall.Text = "";
            res = 0.0;
           
        }

        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxBig.Text != ""&&TextBoxSmall.Text!="")
            {
                string s = TextBoxBig.Text.Remove(TextBoxBig.Text.Length - 1);
                TextBoxBig.Text = s;

                string s2 = TextBoxSmall.Text.Remove(TextBoxSmall.Text.Length - 1);
                TextBoxSmall.Text = s2;
            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (dor == false) 
            {
                TextBoxBig.Text += "7";
                TextBoxSmall.Text += "7";
            }
            else
            {
                TextBoxBig.Text = "";
                TextBoxSmall.Text = "";
                TextBoxBig.Text += "7";
                TextBoxSmall.Text += "7";
                dor = false;
            }
            
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (dor == false)
            {
                TextBoxBig.Text += "8";
                TextBoxSmall.Text += "8";
            }
            else
            {
                TextBoxBig.Text = "";
                TextBoxSmall.Text = "";
                TextBoxBig.Text += "8";
                TextBoxSmall.Text += "8";
                dor = false;
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (dor == false)
            {
                TextBoxBig.Text += "9";
                TextBoxSmall.Text += "9";
            }
            else
            {
                TextBoxBig.Text = "";
                TextBoxSmall.Text = "";
                TextBoxBig.Text += "9";
                TextBoxSmall.Text += "9";
                dor = false;
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (dor == false)
            {
                TextBoxBig.Text += "4";
                TextBoxSmall.Text += "4";
            }
            else
            {
                TextBoxBig.Text = "";
                TextBoxSmall.Text = "";
                TextBoxBig.Text += "4";
                TextBoxSmall.Text += "4";
                dor = false;
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (dor == false)
            {
                TextBoxBig.Text += "5";
                TextBoxSmall.Text += "5";
            }
            else
            {
                TextBoxBig.Text = "";
                TextBoxSmall.Text = "";
                TextBoxBig.Text += "5";
                TextBoxSmall.Text += "5";
                dor = false;
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (dor == false)
            {
                TextBoxBig.Text += "6";
                TextBoxSmall.Text += "6";
            }
            else
            {
                TextBoxBig.Text = "";
                TextBoxSmall.Text = "";
                TextBoxBig.Text += "6";
                TextBoxSmall.Text += "6";
                dor = false;
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (dor == false)
            {
                TextBoxBig.Text += "1";
                TextBoxSmall.Text += "1";
            }
            else
            {
                TextBoxBig.Text = "";
                TextBoxSmall.Text = "";
                TextBoxBig.Text += "1";
                TextBoxSmall.Text += "1";
                dor = false;
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (dor == false)
            {
                TextBoxBig.Text += "2";
                TextBoxSmall.Text += "2";
            }
            else
            {
                TextBoxBig.Text = "";
                TextBoxSmall.Text = "";
                TextBoxBig.Text += "2";
                TextBoxSmall.Text += "2";
                dor = false;
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (dor == false)
            {
                TextBoxBig.Text += "3";
                TextBoxSmall.Text += "3";
            }
            else
            {
                TextBoxBig.Text = "";
                TextBoxSmall.Text = "";
                TextBoxBig.Text += "3";
                TextBoxSmall.Text += "3";
                dor = false;
            }
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (dor == false)
            {
                TextBoxBig.Text += "0";
                TextBoxSmall.Text += "0";
            }
            else
            {
                TextBoxBig.Text = "";
                TextBoxSmall.Text = "";
                TextBoxBig.Text += "0";
                TextBoxSmall.Text += "0";
                dor = false;
            }
        }
            

        private void ButtonPoint_Click(object sender, RoutedEventArgs e)
        {
           
            if (TextBoxBig.Text == "")
            {
                if (dor == false)
                {
                    TextBoxBig.Text = "0.";
                    TextBoxSmall.Text += "0.";
                }
                else
                {
                    TextBoxBig.Text = "";
                    TextBoxSmall.Text = "";
                    dor = false;
                    TextBoxBig.Text = "0.";
                    TextBoxSmall.Text += "0.";
                }
                
            }
            else if (TextBoxBig.Text != "" && !TextBoxBig.Text.Contains("."))
            {
                if (dor == false)
                {
                    TextBoxBig.Text += ".";
                    TextBoxSmall.Text += ".";
                }
                else
                {
                    TextBoxBig.Text = "";
                    TextBoxSmall.Text = "";
                    TextBoxBig.Text += ".";
                    TextBoxSmall.Text += ".";
                    dor = false;
                }
               
            }
            
        }

        private void TextboxBig_Changed(object sender, TextChangedEventArgs e)
        {
            if (TextBoxBig.Text != "")
            {
                //if (TextBoxBig.Text[0] == '0' && TextBoxBig.Text.Length > 1 && !TextBoxBig.Text.Contains("."))
                //{
                //    TextBoxBig.Text.Remove(TextBoxBig.Text[0]);
                //}
                if (TextBoxBig.Text.StartsWith("0"))
                {
                    if (TextBoxBig.Text.Length > 1)
                    {
                        if (!TextBoxBig.Text.Contains("."))
                        {
                           TextBoxBig.Text =  TextBoxBig.Text.Remove(0, 1);
                            TextBoxSmall.Text= TextBoxSmall.Text.Remove(0, 1);
                        }
                    }
                }
            }
            
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if(dor == true)
            {
                if (TextBoxSmall.Text != "")
                    TextBoxSmall.Text += "+";
                TextBoxBig.Text = "";
                dor = false;
            }
            else
            {
                if (TextBoxSmall.Text != "")
                    TextBoxSmall.Text += "+";
                TextBoxBig.Text = "";
            }
            
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (dor == true)
            {
                if (TextBoxSmall.Text != "")
                    TextBoxSmall.Text += "-";
                TextBoxBig.Text = "";
                dor = false;
            }
            else
            {
                if (TextBoxSmall.Text != "")
                    TextBoxSmall.Text += "-";
                TextBoxBig.Text = "";
            }
        }

        private void ButtonDoriv_Click(object sender, RoutedEventArgs e)
        {
            TextBoxBig.Text = "";
            
             string res = new DataTable().Compute(TextBoxSmall.Text, null).ToString();
             TextBoxBig.Text += res;
            dor = true;
            
        }

        private void ButtonMult_Click(object sender, RoutedEventArgs e)
        {
            if (dor == true)
            {
                if (TextBoxSmall.Text != "")
                    TextBoxSmall.Text += "*";
                TextBoxBig.Text = "";
                dor = false;
            }
            else
            {
                if (TextBoxSmall.Text != "")
                    TextBoxSmall.Text += "*";
                TextBoxBig.Text = "";
            }
        }
    }
}
