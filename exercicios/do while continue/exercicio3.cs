
// // Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um dos três nomes de função: Administrador, Gerente ou Usuário.

// // Dentro do bloco de iteração:

// // A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
// // A solução deve garantir que o valor inserido corresponda a uma das três opções de função.
// // Sua solução deve usar o método Trim() no valor de entrada para ignorar caracteres de espaço de entrelinhamento e à direita.
// // A solução deve usar o método ToLower() no valor de entrada para ignorar maiúsculas e minúsculas.
// // Se o valor inserido não corresponder a uma das opções de função, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário uma entrada válida.

// // Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito.


// // Enter your role name (Administrator, Manager, or User)
// // Admin
// // The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
// //    Administrator
// // Your input value (Administrator) has been accepted.

// string? entryValue;
// bool accepted = false;

// System.Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// do
// {
//     entryValue = Console.ReadLine();
//     entryValue.Trim().ToLower();

//     switch (entryValue)
//     {
//         case "Administrator":
//             accepted = true;
//             break;
//         case "Manager":
//             accepted = true;
//             break;
//         case "User":
//             accepted = true;
//             break;
//         default:
//             System.Console.WriteLine($@"The role name that you entered, ""{entryValue}"" is not valid. Enter your role name (Administrator, Manager, or User)");
//             break;
//     }


// } while (accepted != true);

// System.Console.WriteLine($@"Your input value ({entryValue}) has been accepted.");