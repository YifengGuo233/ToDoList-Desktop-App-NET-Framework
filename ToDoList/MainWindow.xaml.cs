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

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private String t;
        private ToDoItem list;

        public MainWindow()
        {
            InitializeComponent();
            initPage();
        }

        private void initPage()
        {
            int i = 0;
            while(i <= 60)
            {
                minute.Items.Add(i);
                i += 10;
            }
            i = 0;
            while (i <= 23)
            {
                hour.Items.Add(i);
                i += 1;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ToDoItem item;
            item.Name = t;

            //Console.WriteLine(t);
            Button subscribeButton = new Button();
            subscribeButton.Content = t;
            Stack.Children.Add(subscribeButton);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textbox = e.Source as TextBox;
            t = textbox.Text;
        }
    }
}
