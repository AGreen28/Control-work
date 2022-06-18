string Print(string[] array) 
{
    string res = string.Empty;
    int size = array.Length;
    res = "[ ";
    for(int i = 0; i < size; i++)
    {
        res+= $"{array[i]} ";
    }
    res += " ]";

    return res;
}

string[] ThreeSimbolMass(string[] array)
{
    int size = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) size++;
    }

    string[] massUpToThree = new string[size];
    for(int j = 0, i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            massUpToThree[j] = array[i];
            j++;
        }
    }

    return massUpToThree;
}

string[] mass1 = {"hello", "2", "world", ":-)"};
string[] mass2 = {"1234", "1567", "-2", "computer science"};
string[] mass3 = {"Russia", "Denmark", "Kazan"};

Console.WriteLine();
Console.WriteLine(Print(ThreeSimbolMass(mass1)));
Console.WriteLine();
Console.WriteLine(Print(ThreeSimbolMass(mass2)));
Console.WriteLine();
Console.WriteLine(Print(ThreeSimbolMass(mass3)));
Console.WriteLine();