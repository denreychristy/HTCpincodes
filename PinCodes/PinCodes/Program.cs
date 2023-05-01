/*
* PinCodes
* You’re are given a list of pin codes that can be between 3 - 10 numbers.  A PIN code
* is considered a duplicate of another PIN code if it is in the same or reversed order.
*
*  Example:
*     123 is a duplicate of 123
*     123 is a duplicate of 321
*     123 is not a duplicate of 213 or 312, etc
*
* Given pin codes 123,213,321, there are a total of 2 distinct pin codes, 123 and 213
*
* Write a function that will return the count of distinct PIN codes
*
* The ideal time complexity for a solution is O(n) 
*
* public int solve(String[] codes);
*/

internal class Program
{
	private static void Main(string[] args)
	{
		// Get user's code list
		Console.Write("Enter the code list here: ");
		String userInput = Console.ReadLine() + "";
		String userInputTrimmed = String.Concat(userInput.Where(c => !Char.IsWhiteSpace(c)));
		String[] codes = userInputTrimmed.Split(',');

		Console.WriteLine("Unique Pin Codes: " + solve(codes));
		Console.ReadLine();
	}

	public static int solve(String[] codes)
	{
		HashSet<String> codesSet = new HashSet<String>();
		foreach (var code in codes)
		{
			codesSet.Add(code);
			codesSet.Add(reverse(code));
		}

		return codesSet.Count / 2;
	}

	public static String reverse(String text)
	{
		char[] array = text.ToCharArray();
		Array.Reverse(array);
		return new String(array);
	}
}