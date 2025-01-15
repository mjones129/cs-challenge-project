string pangram = "The quick brown fox jumps over the lazy dog";

// split string into an array of words
string[] words = pangram.Split(' ');

// iterate over the array of words backwards
// for (int i = words.Length - 1; i >= 0; i--)
// iterate over the array of words forwards
for (int i = 0; i < words.Length; i++)
{
    char[] letters = words[i].ToCharArray();
    //reverse the array of letters
    Array.Reverse(letters);
    //join the array of letters back into a string
    string reversedWord = string.Join("", letters);
    //print the reversed word
    Console.Write(reversedWord);
    // add a space after each word
    Console.Write(" ");
}
