using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace calculadora
{
    public partial class MainWindow : Window
    {
        private double firstNumber = 0;
        private string operation = "";

        public object displayTextBox { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Content.ToString();
            displayTextBox.Text += number;
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Content.ToString();
            firstNumber = double.Parse(displayTextBox.Text);
            displayTextBox.Text = "";
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            displayTextBox.Text = "";
            firstNumber = 0;
            operation = "";
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double secondNumber = double.Parse(displayTextBox.Text);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Division by zero is not allowed!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            return; // Exit the function to prevent incorrect result display
                        }
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        MessageBox.Show("Invalid operation!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                }

                displayTextBox.Text = result.ToString();
                firstNumber = 0;
                operation = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numbers only.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
