Console.Write("Введите количество элементов:");
int size = int.Parse(Console.ReadLine());
string[] MainArray = new string[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    MainArray[i] = element; 
} 

string[] ResultArray = new string[size];

int count = 0;

for (int j = 0; j < size; j++)
{
    if (MainArray[j].Length <= 3)
    {
        ResultArray[count] = MainArray[j];
        count++;
    }
}

Console.WriteLine();
PrintArray(ResultArray);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}