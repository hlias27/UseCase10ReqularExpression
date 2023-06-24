using UseCase10.RegularExpression;

while (true)
{
	Console.WriteLine("Enter max length of input:");
	var maxLength = Console.ReadLine();

	if (string.IsNullOrEmpty(maxLength) || !int.TryParse(maxLength, out var maxLengthInt))
	{
		continue;
	}

	Console.WriteLine("Enter input string to validate:");
	var input = Console.ReadLine();

	if (string.IsNullOrEmpty(input))
	{
		continue;
	}

	var result = RegularExpressionHelper.ValidateString(input, maxLengthInt);

	Console.WriteLine($"Match result: {result}");
}