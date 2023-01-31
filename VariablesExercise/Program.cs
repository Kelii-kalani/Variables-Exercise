namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Michael";
            int myAge = 35;
            char myFile = 'C';
            bool yay = true;
            double price = 5.27d;
            decimal myMoney = 10.00m;

            Console.WriteLine($"Hello my name is {myName}.\nI am {myAge} years old.\nI secretly hide my stash of money in my file cabinet under {myFile} for cheddar.\n" +
                $"But who knows only I know if thats {yay}.\nSo I took ${myMoney} because I wanted some bananas from the grocery store.\n" +
                $"I got a few pounds of bananas and it cost me ${price}, I paid and got my change.\nWent home home to find Bubbles the monkey hanging with Billy the sloth.\n" +
                $"I am glad I got a few pounds of bananas so we all could share.");
        }
    }
}
