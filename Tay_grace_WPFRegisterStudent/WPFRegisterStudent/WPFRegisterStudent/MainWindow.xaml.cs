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

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Course choice;
        int TotalCreditHours = 0; //Used to increment how many credit hours have been registered

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");


            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);


            this.textBox.Text = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            choice = (Course)(this.comboBox.SelectedItem);
            string courseName = choice.ToString();

            switch (validateUserSelection(choice))
            {
                case 0://Display error confirmation: Already registered
                    label3.Content = "You have already registered for this course " + courseName;
                    break;

                case 1: //Display error confirmation: Too many credit hours
                    label3.Content = "You cannot register for more than 9 credit hours.";
                    break;

                case 2:
                    choice.SetToRegistered(); //Sets registration bool to true (See ValidateUserSelection function)

                    listBox.Items.Add(choice); // Display a registration confirmation message 
                    label3.Content = "Registration confirmed for course " + courseName;

                    TotalCreditHours += 3; // update the total credit hours textbox if registration is confirmed for a selected course
                    textBox.Text = TotalCreditHours.ToString();

                    break;
            }

        }

        private int validateUserSelection(Course selectedCourse) //Create code to validate user selection (the choice object)

        {
            if (selectedCourse.IsRegisteredAlready()) //Checks to see if course is already registered
            {
                return 0;
            } 
            else if (TotalCreditHours > 8) //Checks to see if exceeded 8/ reached 9 credit hours
            {
                return 1;
            }
            return 2;
        }

    }
}
