// Итоговая проверочная работа
string[] CreateArray(int lengthArray)
{
    string[] array = new string[lengthArray];
    Console.WriteLine("Введите построчно " + lengthArray + " элемента массива");
    for (int i = 0; i < lengthArray; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}


void CreateResultArray(string[] array)
{
    int amount = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            amount++;
        }
    }
    string[] arrayResult = new string[amount];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayResult[index] = array[i];
            Console.Write(arrayResult[index] + " ");
            index++;

        }
    }

}


Console.WriteLine("Введите длину массива");
int lengthArray = int.Parse(Console.ReadLine());
string[] array = CreateArray(lengthArray);
CreateResultArray(array);
