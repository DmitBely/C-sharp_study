// Метод 1: Ничего не возвращает и ничего не принимает

void Method1()
{
    Console.WriteLine("Belyaev Dmiitriy. All rights reserved");

}

Method1(); // Вызов метода

// Метод 2: Метод ничего не возвращает, но может принимать какие-то аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения"); // можно явно прописать какому аргументу присваивается значение
// Прим : Method2(msg:"Текст сообщения"); 

void Method2_1(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);    
        i++;
    }
}

Method2_1(msg: "Текст", count: 4); // при исп-ии именнованных переменных их последовательность подачи в метод не важна

// Метод 3: Что-то возвращают, но нчего не принимают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine($"Сейчас {year} год");


// Метод 4: Что-то принимают и что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // String.Empty; - начальное значение пустой строки

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "lol");
Console.WriteLine(res);