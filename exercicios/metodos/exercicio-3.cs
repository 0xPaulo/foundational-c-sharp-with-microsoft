// // string input = "there are snakes at the zoo";

// // Console.WriteLine(input);
// // Console.WriteLine(ReverseSentence(input));

// // string ReverseSentence(string input)
// // {
// //     string result = "";
// //     string[] words = input.Split(" ");
// //     foreach (string word in words)
// //     {
// //         result += ReverseWord(word) + " ";
// //     }
// //     return result.Trim();
// // }

// // string ReverseWord(string word)
// // {
// //     string result = "";
// //     for (int i = word.Length - 1; i >= 0; i--)
// //     {
// //         result += word[i];
// //     }
// //     return result;
// // }

// // string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

// // Console.WriteLine("Is it a palindrome?");
// // foreach (string word in words)
// // {
// //     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// // }

// // bool IsPalindrome(string word) 
// // {
// //     int start = 0;
// //     int end = word.Length - 1;

// //     while (start < end) 
// //     {
// //         if (word[start] != word[end]) 
// //         {
// //             return false;
// //         }
// //         start++;
// //         end--;
// //     }

// //     return true;
// // }



// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay())
// {
//     PlayGame();
// }

// void PlayGame()
// {
//     var play = true;

//     while (play)
//     {
//         var target = random.Next(1, 6);
//         var roll = random.Next(1, 6); ;

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(target, roll));
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }

// bool ShouldPlay()
// {
//     string input = Console.ReadLine();
//     if (input == "y")
//     {
//         return true;
//     }
//     return false;
// }

// string WinOrLose(int target, int roll)
// {
//     if (target >= roll)
//     {
//         // System.Console.WriteLine("You lose");
//         return "You lose";
//     }
//     else
//         return "You win";
// }