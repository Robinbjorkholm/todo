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

namespace todo
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

        
        private void addToListBox(string item)
        {

            LBTasks.Items.Add(TodoText.Text);
        }
        //ADD knapp
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            addToListBox(TodoText.Text);
            TodoText.Text = "";
            AddBtn.IsEnabled = false;
        }

        //Delete knapp
        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            LBTasks.Items.Remove(LBTasks.SelectedItem);
            DeleteBtn.IsEnabled = false;
        }

        //listo me todos
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DeleteBtn.IsEnabled = true;
        }

            // ta bort placeholder när man klickar på ruto
        private void TodoText_GotFocus(object sender, RoutedEventArgs e){
            TodoText.Text = "";
        }

         // gör så man kan tryck på knappa om man skriva na i ruto
        private void TodoText_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (TodoText.Text.Length == 0)
            {
                AddBtn.IsEnabled = false;
            }
            else
            {
                AddBtn.IsEnabled = true;
                if (e.Key == Key.Enter)
                {

                    addToListBox(TodoText.Text);
                    TodoText.Text = "";
                    AddBtn.IsEnabled = false;
                }
            }
           
        }
    }
}
