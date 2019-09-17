namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            Console.WriteLine(quote);
            Console.WriteLine(quote.Substring(10));
            Console.WriteLine(quote.IndexOf("It"));
            Console.WriteLine(quote.IndexOf("you"));

            string fixedQuote = quote.Substring(0, quote.IndexOf("It")+2) + " always takes longer than " + quote.Substring(quote.IndexOf("you"));

            Console.WriteLine(fixedQuote);
        }
    }
}