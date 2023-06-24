using UseCase10.RegularExpression;

while (true)
{
	var maxLength = Console.ReadLine();
	var input = Console.ReadLine();

	if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(maxLength) || !int.TryParse(maxLength, out var maxLengthInt))
	{
		continue;
	}

	var result = RegularExpressionHelper.ValidateString(input, maxLengthInt);

	Console.WriteLine(result);
}