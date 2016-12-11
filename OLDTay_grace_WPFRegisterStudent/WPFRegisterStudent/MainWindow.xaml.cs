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

        int TotalCredits = 0;
        int firstChoice = 0, secondChoice = 0, thirdChoice = 0;

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
            /*int numericalCourseIdentifier = 0;

            choice = (Course)(this.comboBox.SelectedItem);
            string chosenCourseName = choice.ToString(); //Retrieves string of course name

            numericalCourseIdentifier = IdentifyCourse(chosenCourseName, numericalCourseIdentifier); //Takes the course name and converts it to an integer representative

            switch (ValidateUserSelection(numericalCourseIdentifier, firstChoice, secondChoice, thirdChoice, TotalCredits)) //Updates the label3 text based on selection
            {
                case -1:
                    label3.Content = chosenCourseName + " is not a recognized course."; //Not really necessary, but I included it just in case
                    break;
                case -2:
                    label3.Content = "You have already registered for this " + chosenCourseName + " course.";
                    break;
                case -3:
                    label3.Content = "You cannot register for more than 9 credit hours.";
                    break;
                case -4:
                    label3.Content = "Registration confirmed for course " + chosenCourseName; //Updates label to confirm registration

                    TotalCredits += 3;
                    textBox.Text = TotalCredits.ToString();

                    if (firstChoice == 0)
                        firstChoice = numericalCourseIdentifier;
                    else if (secondChoice == 0)
                        secondChoice = numericalCourseIdentifier;
                    else if (thirdChoice == 0)
                        thirdChoice = numericalCourseIdentifier;
                    
                    listBox.Items.Add(choice); //Update the listBox with each registration

                    break;
            }
            choice = (Course)(this.comboBox.SelectedItem);
            string chosenCourseName = choice.ToString(); //Retrieves string of course name

            switch (validateSelection(choice))
            {
                case 1:
                    label3.Content = "You have already registered for this " + chosenCourseName + " course.";
                    break;
                case 2:
                    label3.Content = "You cannot register for more than 9 credit hours.";
                    break;
                case 0:
                    label3.Content = "Registration confirmed for course " + chosenCourseName; //Updates label to confirm registration
                    choice.SetToRegistered();
                    TotalCredits += 3;
                    textBox.Text = TotalCredits.ToString();
                    listBox.Items.Add(choice); //Update the listBox with each registration
                    break;
            }
        }

        int ValidateUserSelection (int choice, int firstChoice, int secondChoice, int thirdChoice, int totalCredit)
        {
            if (choice < 1 || choice > 7)
                return -1;
            else if (choice == firstChoice || choice == secondChoice || choice == thirdChoice)
                return -2;
            else if (totalCredit > 8)
                return -3;
            return -4;
        */
            choice = (Course)(this.comboBox.SelectedItem);
            string chosenCourseName = choice.ToString(); //Retrieves string of course name

            switch (ValidateUserSelection(choice))
            {
                case 1:
                    label3.Content = "You have already registered for this " + chosenCourseName + " course.";
                    break;
                case 2:
                    label3.Content = "You cannot register for more than 9 credit hours.";
                    break;
                case 0:
                    label3.Content = "Registration confirmed for course " + chosenCourseName; //Updates label to confirm registration
                    choice.SetToRegistered();
                    TotalCredits += 3;
                    textBox.Text = TotalCredits.ToString();
                    listBox.Items.Add(choice); //Update the listBox with each registration
                    break;
            }

        }
        int ValidateUserSelection(Course selectedCourse)
        {
            if (selectedCourse.IsRegisteredAlready())
                return 1;
            else if (TotalCredits > 8)
                return 2;
            return 0;
        }
    }
}
