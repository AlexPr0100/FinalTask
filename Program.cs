//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 


string FindElements(string [] array) 
{
    string result = ""; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) result += array[i] + " ";
    }
    return result;
}

string [] ChangeStringToArray(string newstring)
{
    return newstring.Split(' ', StringSplitOptions.RemoveEmptyEntries);  
}


