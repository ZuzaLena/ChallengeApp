int number = 658455940;
string numberInString = number.ToString();
char[] numbers = numberInString.ToCharArray();
Console.WriteLine("Moja liczba to:" + number);
Console.WriteLine("Ilość poszczególnych cyfr, kóre zawiera moja liczba:");
int[] counter = new int[10];

foreach (char digit in numbers)
{ 
    if (digit == '0') counter[0]++;
    else if (digit == '1') counter[1]++;
    else if (digit == '2') counter[2]++;
    else if (digit == '3') counter[3]++;
    else if (digit == '4') counter[4]++;
    else if (digit == '5') counter[5]++;
    else if (digit == '6') counter[6]++;
    else if (digit == '7') counter[7]++;
    else if (digit == '8') counter[8]++;
    else if (digit =='9') counter[9]++;
    }
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine( i + "->" + counter[i]);
}