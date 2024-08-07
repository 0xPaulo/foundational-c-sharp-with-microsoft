
// // A solução deve declarar uma variável inteira chamada periodLocation que pode ser usada para manter o local do caractere de ponto dentro de uma cadeia de caracteres.

// // A solução deve incluir um loop foreach ou for externo que possa ser usado para processar cada elemento da cadeia de caracteres na matriz. A variável da cadeia de caracteres que será processada dentro dos loops deve ser chamada de myString.

// // No loop externo, a solução deve usar o método IndexOf() da classe String para obter a localização do primeiro caractere de ponto na variável myString. A chamada de método deve ser semelhante a: myString.IndexOf("."). Se não houver nenhum caractere de ponto na cadeia de caracteres, um valor de -1 será retornado.

// // A solução deve incluir um loop do-while ou while interno que possa ser usado para processar a variável myString.

// // No loop interno, a solução deve extrair e exibir (gravar no console) cada frase contida em cada uma das cadeias de caracteres processadas.

// // No loop interno, a solução não deve exibir o caractere de ponto.

// // No loop interno, a solução deve usar os métodos Remove(), Substring() e TrimStart() para processar as informações da cadeia de caracteres.

// // I like pizza
// // I like roast chicken
// // I like salad
// // I like all three of the menu choices

// O código usa uma instrução for para o loop externo porque não é possível modificar o valor atribuído a uma "variável de iteração foreach" como eu fiz abaixo

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int stringsCount = myStrings.Length;

// string myString = "";
// int periodLocation = 0;

// for (int i = 0; i < stringsCount; i++)
// {
//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");

//     string mySentence;

//     // extract sentences from each string and display them one at a time
//     while (periodLocation != -1)
//     {

//         // first sentence is the string value to the left of the period location
//         mySentence = myString.Remove(periodLocation);

//         // the remainder of myString is the string value to the right of the location
//         myString = myString.Substring(periodLocation + 1);

//         // remove any leading white-space from myString
//         myString = myString.TrimStart();

//         // update the comma location and increment the counter
//         periodLocation = myString.IndexOf(".");

//         Console.WriteLine(mySentence);
//     }

//     mySentence = myString.Trim();
//     Console.WriteLine(mySentence);
// }



// int periodLocation = 0;
// bool finish = false;

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };


// foreach (var myString in myStrings)
// {
//     periodLocation = myString.IndexOf(".");
//     if (periodLocation == -1) continue;
//     while (finish != true)
//     {
//         string pizza = myString.Substring(0, periodLocation);
//         System.Console.WriteLine(pizza);

//         string chickenSalad = myString.Substring(periodLocation);
//         periodLocation = chickenSalad.TrimStart('.').TrimStart().IndexOf(".");
//         string chicken = chickenSalad.TrimStart('.').TrimStart().Substring(0, periodLocation);
//         System.Console.WriteLine(chicken);

//         string salad = chickenSalad.TrimStart('.').TrimStart().Substring(periodLocation);
//         string salada = salad.TrimStart('.').TrimStart();
//         System.Console.WriteLine(salada);
//         finish = true;
//     }
//     System.Console.WriteLine("I like all three of the menu choices");
// }



