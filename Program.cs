System.Console.Write("A szóközzel elválasztott karaktersor: ");
string [] betuk = Console.ReadLine().Split(' ');
int[] kodok=new int[betuk.Length];
System.Console.WriteLine("A karakterek kódjai: ");
for (int i = 0; i < betuk.Length; i++)
{
    int kod=Convert.ToChar(betuk[i]);
    kodok[i]=kod;
    System.Console.Write($"{kodok[i]} ");
}
Console.ReadKey();