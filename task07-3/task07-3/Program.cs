using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Task07_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию ферзя");
            var QueenPosition = Console.ReadLine();

            Console.WriteLine("Введите позицию ладьи");
            var RookPosition = Console.ReadLine();

            if (IsFigureIncorrect(RookPosition, QueenPosition) ||
                           IsQueenCanStrike(QueenPosition, RookPosition))
            {
                Console.WriteLine("Ладья не может стоять на занятом квадрате " +
                    "или находиться под боем");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию хода ферзя");
            var move = Console.ReadLine();

            bool isValidMove = IsQueenMoveCorrect(QueenPosition, move, RookPosition);
            Console.WriteLine(isValidMove ? "Ход ферзя возможен." : "Ход ферзя невозможен.");

            Console.ReadKey();
        }

        static bool IsFigureIncorrect(string queenPosition, string position)
        {
            int qRow, qColumn, rRow, rColumn;

            DecodePosition(queenPosition, out qColumn, out qRow);
            DecodePosition(position, out rColumn, out rRow);

            return rRow == qRow && rColumn == qColumn;
        }

        static bool IsQueenCanStrike(string queenPosition, string position)
        {
            int qRow, qColumn, rRow, rColumn;

            DecodePosition(queenPosition, out qColumn, out qRow);
            DecodePosition(position, out rColumn, out rRow);

            return qRow == rRow || rColumn == qColumn || Math.Abs(qRow - rRow) == Math.Abs(qColumn - rColumn);
        }

        static bool IsRookCanStrike(string queenPosition, string position)
        {
            int qRow, qColumn, rRow, rColumn;

            DecodePosition(queenPosition, out qColumn, out qRow);
            DecodePosition(position, out rColumn, out rRow);

            return qRow == rRow || rColumn == qColumn;
        }

        static bool IsQueenCanMove(
            string queenPosition, string move, string rookPosition)
        {
            int qr, qc, rr, rc, mr, mc;

            DecodePosition(queenPosition, out qc, out qr);
            DecodePosition(rookPosition, out rc, out rr);
            DecodePosition(move, out mc, out mr);

            var middlePosition = queenPosition[0] +
                (int.Parse(queenPosition[1].ToString()) + 1).ToString();

            return IsQueenMoveCorrect(queenPosition, move, rookPosition) &&
                IsRookCanStrike(rookPosition, move) &&
                (!IsRookCanStrike(rookPosition, middlePosition));
        }

        static bool IsQueenMoveCorrect(
            string queenPosition, string move, string rookPosition)
        {
            int qr, qc, rr, rc, mr, mc;

            DecodePosition(queenPosition, out qc, out qr);
            DecodePosition(rookPosition, out rc, out rr);
            DecodePosition(move, out mc, out mr);

            bool isValidMove = ((qc == mc && qr != mr) ||
                                 (qr == mr && qc != mc) ||
                                 (Math.Abs(qr - mr) == Math.Abs(qc - mc)));

            bool isUnderAttackByRook = (mr == rr || mc == rc);

            return isValidMove && !isUnderAttackByRook;
        }



        static void DecodePosition(string position, out int column, out int row)
        {
            column = (int)position[0] - 0x60;
            row = int.Parse(position[1].ToString());
        }
    }
}