
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    int indexNameStart = input.IndexOf("@");
    int indexNameStop = input.IndexOf('|');
    string name = input.Substring(indexNameStart + 1, indexNameStop - indexNameStart - 1);

    int indexAgeStart = input.IndexOf('#');
    int indexAgeStop = input.IndexOf('*');
    string age = input.Substring(indexAgeStart + 1, indexAgeStop - indexAgeStart - 1);

    
    Console.WriteLine($"{name} is {age} years old.");
}

//--------------------------------------------------------
//int n = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//    string input = Console.ReadLine();
//    string name = input.Split('@')[1].Split('|')[0];
//    string age = input.Split('#')[1].Split('*')[0];
//    Console.WriteLine($"{name} is {age} years old.");
//}

