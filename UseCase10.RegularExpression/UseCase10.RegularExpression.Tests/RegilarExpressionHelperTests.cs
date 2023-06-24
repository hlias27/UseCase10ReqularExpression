namespace UseCase10.RegularExpression.Tests
{
	public class RegilarExpressionHelperTests
	{
		[Fact]
		public void ValidateString_TooShortInput_False()
		{
			var input = "Qw1$";
			var maxLength = 10;

			var result = RegularExpressionHelper.ValidateString(input, maxLength);

			Assert.False(result);
		}

		[Fact]
		public void ValidateString_InputExceedMaxLength_False()
		{
			var input = "Qwerty123!!";
			var maxLength = 10;

			var result = RegularExpressionHelper.ValidateString(input, maxLength);

			Assert.False(result);
		}

		[Fact]
		public void ValidateString_InputIsCorrect_True()
		{
			var input = "Qwerty123!";
			var maxLength = 10;

			var result = RegularExpressionHelper.ValidateString(input, maxLength);

			Assert.True(result);
		}

		[Fact]
		public void ValidateString_InputMissingUppercase_False()
		{
			var input = "qwerty123!";
			var maxLength = 10;

			var result = RegularExpressionHelper.ValidateString(input, maxLength);

			Assert.False(result);
		}

		[Fact]
		public void ValidateString_InputMissingLowercase_False()
		{
			var input = "QWERTY123!";
			var maxLength = 10;

			var result = RegularExpressionHelper.ValidateString(input, maxLength);

			Assert.False(result);
		}

		[Fact]
		public void ValidateString_InputMissingSpecialCharacter_False()
		{
			var input = "Qwerty123";
			var maxLength = 10;

			var result = RegularExpressionHelper.ValidateString(input, maxLength);

			Assert.False(result);
		}

		[Fact]
		public void ValidateString_InputMissingDigit_False()
		{
			var input = "Qwerty!";
			var maxLength = 10;

			var result = RegularExpressionHelper.ValidateString(input, maxLength);

			Assert.False(result);
		}

		[Theory]
		[InlineData("Qwerty 123!")]
		[InlineData(" Qwerty123!")]
		[InlineData("Qwerty123! ")]
		public void ValidateString_InputHasWhitespace_False(string input)
		{
			var maxLength = 12;

			var result = RegularExpressionHelper.ValidateString(input, maxLength);

			Assert.False(result);
		}
	}
}