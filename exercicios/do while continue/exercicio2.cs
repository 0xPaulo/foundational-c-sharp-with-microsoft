
// // A solução deve garantir que a entrada seja uma representação válida de um inteiro.
// // Se o valor inteiro não estiver entre 5 e 10, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.
// // A solução deve garantir que o valor inteiro esteja entre 5 e 10 antes de sair da iteração.
// // Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito.


// // Enter an integer value between 5 and 10
// // two
// // Sorry, you entered an invalid number, please try again
// // 2
// // You entered 2. Please enter a number between 5 and 10.
// // 7
// // Your input value (7) has been accepted.

// string? value;
// int validValue;
// bool validEntry = false;
// bool accepted = false;
// System.Console.WriteLine("Enter an integer value between 5 and 10");
// do
// {
//     value = Console.ReadLine();
//     if (value != null)
//     {
//         validEntry = int.TryParse(value, out validValue);
//         if (validEntry)
//         {
//             if (validValue >= 5 && validValue <= 10)
//             {
//                 System.Console.WriteLine($"Your input value ({validValue}) has been accepted.");
//                 accepted = true;
//             }
//             else
//             {
//                 System.Console.WriteLine($"You entered {validValue}. Please enter a number between 5 and 10.");
//             }
//         }
//         else
//         {
//             System.Console.WriteLine($"Sorry, you entered an invalid number, please try again");
//         }
//     }


// } while (accepted != true);