
string[] morseCode = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

string message = string.Empty;

foreach (var code in morseCode)
{
    char ch = ' ';

    switch (code)
    {
        case "|": ch = ' '; break;
        case ".-": ch = 'A'; break;
        case "-...": ch = 'B'; break;
        case "-.-.": ch = 'C'; break;
        case "-..": ch = 'D'; break;
        case ".": ch = 'E'; break;
        case "..-.": ch = 'F'; break;
        case "--.": ch = 'G'; break;
        case "....": ch = 'H'; break;
        case "..": ch = 'I'; break;
        case ".---": ch = 'J'; break;
        case "-.-": ch = 'K'; break;
        case ".-..": ch = 'L'; break;
        case "--": ch = 'M'; break;
        case "-.": ch = 'N'; break;
        case "---": ch = 'O'; break;
        case ".--.": ch = 'P'; break;
        case "--.-": ch = 'Q'; break;
        case ".-.": ch = 'R'; break;
        case "...": ch = 'S'; break;
        case "-": ch = 'T'; break;
        case "..-": ch = 'U'; break;
        case "...-": ch = 'V'; break;
        case ".--": ch = 'W'; break;
        case "-..-": ch = 'X'; break;
        case "-.--": ch = 'Y'; break;
        case "--..": ch = 'Z'; break;
    }

    message += ch;
}

Console.WriteLine(message);

