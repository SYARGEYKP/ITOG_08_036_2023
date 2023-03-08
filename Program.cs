// 
void PrintArray(string[] array)
{
    foreach (string item in array)
    {
        System.Console.Write($"{item} ");
    }
}
string[] array = { "hellow", "2", ":-)" };
string[] newArray= new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[i] = array[i];
    }
}
    System.Console.WriteLine("Текущий массив");
    PrintArray(array);
    System.Console.WriteLine();
    System.Console.WriteLine("Новый массив");
    PrintArray(newArray);



