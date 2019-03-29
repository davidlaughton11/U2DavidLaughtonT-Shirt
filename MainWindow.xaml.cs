//David Laughton
//March 28, 2019
//Make your own shirt program

using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace U2DavidLaughtonT_Shirt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {               
        //to make string for checkered sleeves 
        string checkerColour = "white";
        string otherCheckerColour = "white";

        public MainWindow()
        {
            InitializeComponent();
            //Creates white sleeves when program initialize
            CreateLeftSleeve(checkerColour, otherCheckerColour);
            CreateRightSleeve(checkerColour, otherCheckerColour);
        }
        
        private void shirtCustom_Click(object sender, RoutedEventArgs e)
        {            
            //For shirt colour
            string colour;
            //Int for jersey number
            int number;
            int.TryParse(numberEnter.Text, out number);
            //Gets shirt jersey number from textbox
            shirtNumber.Text = number.ToString();
            //With the colour for a colour for the jersey number entered in the textbox it will 
            //try to run it and if invalid an error message will pop up
            try
            {
                shirtNumber.Foreground = (SolidColorBrush)new BrushConverter()
                    .ConvertFromString(numberColourEnter.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ". error  message: 2");
                //Exits program if the colour is invalid
                Environment.Exit(0);
            }
            //colour of shirt is filled with the colour entered in the textbox
            colour = colourEnter.Text;
            try
            {
                rectangleColour.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(colour);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ". error  message: 1");
                //Exits program if the colour is invalid
                Environment.Exit(0);
            }
            //use the checker colour entered in the texbox
            checkerColour = colourEnterChecker.Text;
            otherCheckerColour = colourEnterChecker2.Text;               

            //Makes a custom sleeves when called upon
            CreateLeftSleeve(checkerColour, otherCheckerColour);
            CreateRightSleeve(checkerColour, otherCheckerColour);            
        }
        //creates sleeve when the program is initialized
        private void CreateRightSleeve(string checkerColour, string otherCheckerColour)
        {
            //uses a loop to create the sleeve
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Rectangle w = new Rectangle();
                    w.Height = 9;
                    w.Width = 9;
                    if ((j + i) % 2 == 0)
                    {
                        try
                        {
                            //fills with white 
                            //when the colour is entered it changes the string
                            w.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(checkerColour);
                        }
                        catch (Exception ex)
                        {
                            //If colour is invailid the message will show
                            MessageBox.Show(ex.Message);
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        try
                        {
                            //fills with white
                            //when the colour is entered it changes the string
                            w.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(otherCheckerColour);
                        }
                        catch (Exception ex)
                        {
                            //If colour is invailid the message will show
                            MessageBox.Show(ex.Message);
                            Environment.Exit(0);
                        }
                    }
                    canvas1.Children.Add(w);
                    Canvas.SetTop(w, i * 9);
                    Canvas.SetLeft(w, j * 9);
                }
            }
        }
        private void CreateLeftSleeve(string checkerColour, string otherCheckerColour)
        {
            //Uses a loop to create the checker sleeve
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Rectangle w = new Rectangle();
                    w.Height = 9;
                    w.Width = 9;
                    if ((j + i) % 2 == 0)
                    {
                        try
                        {
                            //fills with white
                            //when the colour is entered it changes the string
                            w.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(checkerColour);
                        }
                        catch (Exception ex)
                        {
                            //If colour is invailid the message will show
                            MessageBox.Show(ex.Message);
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        try
                        {
                            //fills with white
                            //when the colour is entered it changes the string
                            w.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(otherCheckerColour);
                        }
                        catch (Exception ex)
                        {
                            //If colour is invailid the message will show
                            MessageBox.Show(ex.Message);
                            Environment.Exit(0);
                        }
                    }
                    canvas.Children.Add(w);
                    Canvas.SetTop(w, i * 9);
                    Canvas.SetLeft(w, j * 9);
                }
            }
        }
    }
}
