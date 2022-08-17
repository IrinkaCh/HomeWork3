Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
string copy = number.ToString();
Console.WriteLine(DeployCopy(copy));

string DeployCopy(string number)  
{
    string copy = "";
    for (int i = number.Length - 1; i >= 0; i--)
    {
        copy += number[i];
    }
    return copy;  
}

 bool CheckPalindrom(string input)
 {
     string reverseString = DeployCopy(input);
     if(reverseString == copy)
         {return true;}
     else
         {return false;}
}

bool result = CheckPalindrom(copy);
if(result == true)
{
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}