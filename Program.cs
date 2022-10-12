// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] newArray = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    newArray[i] = element;
}

string[] finalArray = new string[size];
int count = 0;

for (int j = 0; j < size; j++)
{
    if (newArray[j].Length <= 3)
    {
        finalArray[count] = newArray[j];
        count++;
    }
}
Console.WriteLine();
Console.Write("Массив из строк, длина которых меньше, либо равна 3 символа: ");
PrintArray(finalArray);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}