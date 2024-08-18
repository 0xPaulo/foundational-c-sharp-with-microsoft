// // string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
// // string[] rsvps = new string[10];
// // int count = 0;

// // void RSVP(string name, int partySize, string allergies, bool inviteOnly)
// // {
// //     if (inviteOnly)
// //     {
// //         bool found = false;
// //         foreach (string guest in guestList)
// //         {
// //             if (guest.Equals(name))
// //             {
// //                 found = true;
// //                 break;
// //             }
// //         }
// //         if (!found)
// //         {
// //             Console.WriteLine($"Sorry, {name} is not on the guest list");
// //             return;
// //         }
// //     }

// //     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
// //     count++;
// // }

// // void ShowRSVPs()
// // {
// //     Console.WriteLine("\nTotal RSVPs:");
// //     for (int i = 0; i < count; i++)
// //     {
// //         Console.WriteLine(rsvps[i]);
// //     }
// // }

// // RSVP("Rebecca", 1, "none", true);
// // RSVP("Nadia", 2, "Nuts", true);
// // RSVP("Linh", 2, "none", false);
// // RSVP("Tony", 1, "Jackfruit", true);
// // RSVP("Noor", 4, "none", false);
// // RSVP("Jonte", 2, "Stone fruit", false);
// // ShowRSVPs();


// string[,] corporate =
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external =
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// string externalDomain = "hayworth.com";

// for (int i = 0; i < corporate.GetLength(0); i++)
// {
//     displayEmails(corporate[i, 0], corporate[i, 1]);
// }

// for (int i = 0; i < external.GetLength(0); i++)
// {
//     displayEmails(external[i, 0], external[i, 1], externalDomain);
// }

// void displayEmails(string firstName, string lastName, string domain = "contoso.com")
// {
//     firstName = firstName.Substring(0, 2);
//     string email = firstName + lastName + "@" + domain;
//     System.Console.WriteLine(email.ToLower());
// }

// // robavin@contoso.com
// // sibright@contoso.com
// // kisinclair@contoso.com
// // aakamath@contoso.com
// // sadelucchi@contoso.com
// // siali@contoso.com

// // viashton@hayworth.com
// // codysart@hayworth.com
// // shlawrence@hayworth.com
// // davaldes@hayworth.com