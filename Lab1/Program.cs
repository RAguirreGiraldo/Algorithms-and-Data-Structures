
/* Count Words */

string[] arrayNewWord;  //Creation of my array

Console.WriteLine("Number of words you wish to enter "); 
int sizeOfarraywords = Int32.Parse(Console.ReadLine()); // Create variable type Int to number of the length of my array.

arrayNewWord = new string[sizeOfarraywords];  //initializate a array with size of declarate by user.

//Input the worlds 
for (int i = 0; i < arrayNewWord.Length; i++)
{
    Console.WriteLine("Enter a Word {0}: ", i + 1); //World
    arrayNewWord[i] = Console.ReadLine();
}


// Print word
Console.WriteLine();
Console.WriteLine(" Press any key to show the words ");
Console.ReadKey();

for (int i = 0; i < sizeOfarraywords; i++)
{
    Console.WriteLine("{0}. {1}", i + 1, arrayNewWord[i]);
}



