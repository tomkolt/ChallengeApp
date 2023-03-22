using System.Diagnostics.Metrics;

int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

for (int i = 0; i < 10; i++)
{
   int count = 0;

    foreach (char letter in letters)
    {
        if ((int)Char.GetNumericValue(letter) == i)
        {
            count++;
        }
    }
    Console.WriteLine(i + " => " + count);
}