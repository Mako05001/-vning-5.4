Console.WriteLine("Hur många namn vill du skriva?");
int S = int.Parse(Console.ReadLine());
string[] N = new string[S];
string F = N[0];
Console.WriteLine("Skiv ett namn");
N[0] = Console.ReadLine();
for (int i =1; i < N.Length; i++)  {
    Console.WriteLine("Skiv ett namn");
    N[i] = Console.ReadLine();
    if (N[i].CompareTo(N[0]) < 0)   {
        F = N[i];
    }
}
Console.WriteLine("Första namnet i bokstavsordning är " + F);