using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> myChessBoard = GenerateChessBoard("X", 8); // Generate an 8x8 chessboard that starts with the letter X

            foreach (string chessBoardLine in myChessBoard) // print each line of the chessboard to console
            {
                Console.WriteLine(chessBoardLine);
            }
        }

        private static string GenerateSingleLine(string startCharacter, int dimension)
        {
            string line = startCharacter;
            string currentCharacter = startCharacter;

            for (int i = 1; i < dimension;  i++)
            {
                currentCharacter = GetNextCharacter(currentCharacter);
                line = line + currentCharacter;
            };

            return line;
        }

        private static List<string> GenerateChessBoard(string startCharacter, int dimension)
        {
            List<string> chessboard = new List<string>();
            string currentCharacter = startCharacter;

            for (int i = 1; i <= dimension; i++)
            {
                chessboard.Add(GenerateSingleLine(currentCharacter, dimension));
                currentCharacter = GetNextCharacter(currentCharacter);
            }

            return chessboard;
        }

        private static string GetNextCharacter(string previousCharacter)
        {
            return previousCharacter == "X" ? "O" : "X";
        }
    }
}
