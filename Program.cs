System.Console.WriteLine("Введите массив");
string? input = Console.ReadLine();
string  input1 = Delete (input, '[');
string  input2 = Delete (input1, ']');
string  input3 = Delete (input2, '"');    
string[] figure = input3.Split(",");
string [] b = NoMoreThanThree (figure);
Print (b);
string [] NoMoreThanThree (string [] a)
{
    string [] b = new string [0];
    for (int i = 0; i <a.Length; i ++)
    {
        if (a[i].Length <4)
        {
            b = b.Append (a[i]).ToArray();
        }
    }
    return b;
}
void Print (string [] a)
{
    for (int i = 0; i <a.Length; i ++)
    {
        System.Console.Write($"'{a[i]}', ");
    }
}
string Delete (string text, char ValueForDelete)
{
    string result = string.Empty;
    int length = text.Length;
    int i = 0;
    while (i<length)
    {
        if (text [i] != ValueForDelete) 
        {
            result += $"{text [i]}"; 
            i++ ;
        }
        else i++;
    }
    return result;
}