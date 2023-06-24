using System.Text.RegularExpressions;

namespace UseCase10.RegularExpression
{
	public static class RegularExpressionHelper
	{
		#region Private constants

		/// <summary>
		/// Holds Regular Expression
		/// </summary>
		private const string RegularExpression = @"^(?=^.{{5,{0}}}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!""#$%&'()*+,-./:;<=>?@[\]^_`{{|}}~])[\S]+$";
		
		#endregion

		/// <summary>
		/// Validates input string by regex
		/// </summary>
		/// <param name="input">The input string.</param>
		/// <param name="maxLength">The max length of input string.</param>
		/// <returns>Result of validation. True if input string matches regex, otherwise false.</returns>
		public static bool ValidateString(string input, int maxLength)
		{
			var pattern = string.Format(RegularExpression, maxLength);
			return Regex.IsMatch(input, pattern);
		}
	}
}
