// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполиения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)'] -> ["2", ":)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] ->[]


string[] mass1 = {"hello", "2", "world", ":-)"};
string[] mass2 = {"1234", "1567", "-2", "computer science"};
string[] mass3 = {"Russia", "Denmark", "Kazan"};

string[] FetchString3Symb(string [] mass)
{
    string[] rez = new string[mass.Length];
    int count = 0;
    for(int i = 0; i < mass.Length; i++)
    {
        if(mass[i].Length <= 3)
        {
            rez[count] = mass[i];
            count++;
        }
    }
    return rez[0..count];
}


void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}


string[] m1 = FetchString3Symb(mass1);
PrintArray(mass1);
PrintArray(m1);

string[] m2 = FetchString3Symb(mass2);
PrintArray(mass2);
PrintArray(m2);

string[] m3 = FetchString3Symb(mass3);
PrintArray(mass3);
PrintArray(m3);

