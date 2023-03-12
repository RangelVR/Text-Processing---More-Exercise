
int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();

List<string> fileMessages = new List<string>();

while (true)
{
    string inpput = Console.ReadLine();

    if (inpput == "find")
    {
        break;
    }

    string message = string.Empty;
    int length = key.Length;

    while (inpput.Length > 0)
    {
        for (int i = 0; i < length; i++)
        {
            message += (char)(inpput[i] - key[i]);
        }

        inpput = inpput.Remove(0, length);

        if (inpput.Length < key.Length)
        {
            length = inpput.Length;
        }
    }

    fileMessages.Add(message);
}

foreach (var mesage in fileMessages)
{
    string treasure = mesage.Split('&')[1].Split('&')[0];
    string coordinates = mesage.Split('<')[1].Split('>')[0];

    Console.WriteLine($"Found {treasure} at {coordinates}");
}