char first = char.Parse(Console.ReadLine());
char second = char.Parse(Console.ReadLine());
string chars = Console.ReadLine();

int start = Math.Min(first, second);
int end = Math.Max(first,second);

string result = string.Empty;
int sum = 0;

for (int i = 0; i < chars.Length; i++)
{
	int ch = chars[i];
	if (ch > start && ch < end)
	{
		sum += ch;
	}
}

Console.WriteLine(sum);