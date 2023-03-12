string article = Console.ReadLine();
string content = Console.ReadLine();

List<string> listComments = new List<string>();

while (true)
{
    string comment = Console.ReadLine();

	if (comment == "end of comments")
	{
		break;
	}

	listComments.Add(comment);
}

Console.WriteLine("<h1>");
Console.WriteLine(article);
Console.WriteLine("</h1>");

Console.WriteLine("<article>");
Console.WriteLine(content);
Console.WriteLine("</article>");

foreach (var comment in listComments)
{
	Console.WriteLine("<div>");
	Console.WriteLine(comment);
	Console.WriteLine("</div>");
}