using System.Windows;

namespace calculadora1
{
    public partial class MainWindow : Window
    {
        private double firstNumber = 0; // Almacena el primer número ingresado
        private string operation = ""; // Almacena la operación seleccionada

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Buttonborrar(object sender, RoutedEventArgs e)
        {
            cuadrodetexto.Text = "";
        }

        private void Button1(object sender, RoutedEventArgs e)
        {
            cuadrodetexto.Text += "1";
        }

        private void Button2(object sender, RoutedEventArgs e)
        {
            cuadrodetexto.Text += "2";
        }

        private void Button3(object sender, RoutedEventArgs e)
        {
            cuadrodetexto.Text += "3";
        }

        private void Buttonrestar(object sender, RoutedEventArgs e)
        {
            // Guardar el primer número
            if (double.TryParse(cuadrodetexto.Text, out double parsedNumber))
            {
                firstNumber = parsedNumber;
            }
            else
            {
                MessageBox.Show("Número no válido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            // Establecer la operación como resta
            operation = "-";

            // Limpiar el TextBox para el próximo número
            cuadrodetexto.Text = "";
        }

        private void Button4(object sender, RoutedEventArgs e)
        {
            cuadrodetexto.Text += "4";
        }

        private void Button5(object sender, RoutedEventArgs e)
        {
            cuadrodetexto.Text += "5";
        }

        private void Button6(object sender, RoutedEventArgs e)
        {
            cuadrodetexto.Text += "6";
        }

        private void Buttonsumar(object sender, RoutedEventArgs e)
        {
            // Guardar el primer número
            if (double.TryParse(cuadrodetexto.Text, out double parsedNumber))
            {
                firstNumber = parsedNumber;
            }
            else
            {
                MessageBox.Show("Número no válido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            // Establecer la operación como suma
            operation = "+";

            // Limpiar el TextBox para el próximo número
            cuadrodetexto.Text = "";
        }

        private void Button7(object sender, RoutedEventArgs e)
        {
            cuadrodetexto.Text += "7";
        }

        private void Button8(object sender, RoutedEventArgs e)
        {
            cuadrodetexto.Text += "8";
        }

        private void Button9(object sender, RoutedEventArgs e)
        {
            cuadrodetexto.Text += "9";
        }

        private void Buttonmultiplicar(object sender, RoutedEventArgs e)
        {
            // Guardar el primer número
            if (double.TryParse(cuadrodetexto.Text, out double parsedNumber))
            {
                firstNumber = parsedNumber;
            }
            else
            {
                MessageBox.Show("Número no válido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            // Establecer la operación como multiplicación
            operation = "*";

            // Limpiar el TextBox para el próximo número
            cuadrodetexto.Text = "";
        }

        private void Button0(object sender, RoutedEventArgs e)
        {
            cuadrodetexto.Text += "0";
        }

        private void Buttondividir(object sender, RoutedEventArgs e)
        {
            // Guardar el primer número
            if (double.TryParse(cuadrodetexto.Text, out double parsedNumber))
            {
                firstNumber = parsedNumber;
            }
            else
            {
                MessageBox.Show("Número no válido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            // Establecer la operación como división
            operation = "/";

            // Limpiar el TextBox para el próximo número
            cuadrodetexto.Text = "";
        }

        private void Buttonigual(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(cuadrodetexto.Text, out double secondNumber))
            {
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
                            MessageBox.Show("No se puede dividir por cero", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        MessageBox.Show("Operación no válida", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                }

                // Mostrar el resultado en el cuadro de texto
                cuadrodetexto.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Número no válido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
