// // try
// // {
// //     OperatingProcedure1();
// // }
// // catch (Exception ex)
// // {
// //     Console.WriteLine(ex.Message);
// //     Console.WriteLine("Exiting application.");
// // }

// // static void OperatingProcedure1()
// // {
// //     string[][] userEnteredValues = new string[][]
// //     {
// //         new string[] { "1", "two", "3"},
// //         new string[] { "0", "1", "2"}
// //     };

// //     foreach (string[] userEntries in userEnteredValues)
// //     {
// //         try
// //         {
// //             BusinessProcess1(userEntries);
// //         }
// //         catch (Exception ex)
// //         {
// //             if (ex.StackTrace.Contains("BusinessProcess1"))
// //             {
// //                 if (ex is FormatException)
// //                 {
// //                     Console.WriteLine(ex.Message);
// //                     Console.WriteLine("Corrective action taken in OperatingProcedure1");
// //                 }
// //                 else if (ex is DivideByZeroException)
// //                 {
// //                     Console.WriteLine(ex.Message);
// //                     Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

// //                     // re-throw the original exception
// //                     throw;
// //                 }
// //                 else
// //                 {
// //                     // create a new exception object that wraps the original exception
// //                     throw new ApplicationException("An error occurred - ", ex);
// //                 }
// //             }
// //         }

// //     }
// // }

// // static void BusinessProcess1(string[] userEntries)
// // {
// //     int valueEntered;

// //     foreach (string userValue in userEntries)
// //     {
// //         try
// //         {
// //             valueEntered = int.Parse(userValue);

// //             checked
// //             {
// //                 int calculatedValue = 4 / valueEntered;
// //             }
// //         }
// //         catch (FormatException)
// //         {
// //             FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
// //             throw invalidFormatException;
// //         }
// //         catch (DivideByZeroException)
// //         {
// //             DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
// //             throw unexpectedDivideByZeroException;

// //         }
// //     }
// // }
// bool finish = false;
// do
// {
//     // Prompt the user for the lower and upper bounds
//     Console.Write("Enter the lower bound: ");
//     int lowerBound = int.Parse(Console.ReadLine());

//     Console.Write("Enter the upper bound: ");
//     int upperBound = int.Parse(Console.ReadLine());

//     decimal averageValue = 0;

//     // Calculate the sum of the even numbers between the bounds

//     try
//     {
//         // Calculate the sum of the even numbers between the bounds
//         averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

//         // Display the result to the user
//         Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");
//         finish = true;
//     }
//     catch (ArgumentOutOfRangeException ex)
//     {
//         Console.WriteLine("An error has occurred.");
//         Console.WriteLine(ex.Message);
//         Console.WriteLine($"The upper bound must be greater than {lowerBound}");
//         Console.Write($"Enter a new upper bound: ");
//         upperBound = int.Parse(Console.ReadLine());
//     }

// } while (!finish);
// // Wait for user input
// Console.ReadLine();
// static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
// {
//     if (lowerBound >= upperBound)
//     {
//         throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
//     }

//     int sum = 0;
//     int count = 0;
//     decimal average = 0;

//     for (int i = lowerBound; i <= upperBound; i++)
//     {
//         if (i % 2 == 0)
//         {
//             sum += i;
//             count++;
//         }
//     }
//     average = (decimal)sum / count;
//     return average;

// }