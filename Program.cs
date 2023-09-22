//Emma Lind, Edugrade .NET23

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lets user choose number of squares (in sq) to be output as a chessboard on the screen.

            Console.WriteLine("Hej! Hur många rutor ska schackbrädet ha? ");

            int chosenNum;
            while (int.TryParse(Console.ReadLine(), out chosenNum) == false) //converts users string input to int, if it is possible.
            {
                Console.WriteLine("Vänligen skriv ett heltal istället."); //If chosenNum is not an integer, user is asked to try again.
            }

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //Nested for-loop that creates rows and columns

            for (int row = 1; row <= chosenNum; row++) //loops the rows
            {
                for (int column = 1; column <= chosenNum; column++) //Loops the columns
                {
                    if ((row + column) % 2 == 0) //Checks if the cells are even
                    {
                        Console.Write("◻︎"); //outputs white if the cells are even
                    }
                    else
                    {
                        Console.Write("◼︎"); // else black square
                    }
                }
                Console.WriteLine(); //Switch to a new line
            }
        }
    }
}
