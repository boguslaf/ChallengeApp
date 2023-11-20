// Zadanie dnia piątego

int number = 18776;

string numberToString = number.ToString();
char[] letters = numberToString.ToArray();

int[] counters = {0,0,0,0,0,0,0,0,0,0};
char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

foreach (char l in letters)
{
    for (int i=0; i<numbers.Length; i++)
    {
        if (l == numbers[i]) { counters[i]++; }
    }

   /*if (l == '0') { counters[0]++; }
    if (l == '1') { counters[1]++; }
    if (l == '2') { counters[2]++; }
    if (l == '3') { counters[3]++; }
    if (l == '4') { counters[4]++; }
    if (l == '5') { counters[5]++; }
    if (l == '6') { counters[6]++; }
    if (l == '7') { counters[7]++; }
    if (l == '8') { counters[8]++; }
    i  (l == '9') { counters[9]++; } */
}

for (int i = 0; i < counters.Length; i++)
{
    Console.WriteLine(i + " -> " + counters[i]);
}

    
var keyInfo = Console.ReadKey(); 

