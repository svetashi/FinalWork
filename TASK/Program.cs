
Console.WriteLine("Привет, введи любые значения через запятую: ");
string any = Console.ReadLine();
string [] array = any.Split(',');

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        Console.WriteLine(array[i] + " ");
    }
}
