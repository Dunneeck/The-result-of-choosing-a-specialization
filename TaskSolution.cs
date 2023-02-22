Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizeArray];
Console.WriteLine("Заполните массив любыми словами: ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine() ?? "0";
}

Console.WriteLine($"Вот ваш массив:\n{string.Join("\n", array)}");

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        count++;
}

string[] secondArray = new string[count];

count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        secondArray[count] = array[i];
        count++;
    }  
}
if(secondArray.Length == 0)
    Console.WriteLine("Ваш второй массив пуст");
else
Console.WriteLine($"Вот ваш второй массив:\n{string.Join("\n", secondArray)}");