//  Дан текст. В тексте нужно все пробелы заменить чёрточками, 
// маленькие буквы "к" хаменить большими "К", 
// а большие "С" заменить маленькими "c".

string text = "- Я думаю, - сказал князь, улыбаясь, - что"
            + "ежели б вас послали вмеCто нашего милого Винценгероде,"
            + "вы бы ввзяли приCтупом согласие прусCкого короля."
            + "Вы так красноречивы. Вы даддите мне чаю?";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();

string newText1 = Replace(newText, 'к', 'К');
Console.WriteLine(newText1);
Console.WriteLine();

string newText2 = Replace(newText1, 'С', 'с');
Console.WriteLine(newText2);