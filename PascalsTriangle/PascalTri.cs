using System;


namespace PascalsTriangle
{
    public class PascalTri
    {
        static void Main(string[] args)
        {
            string[] InputVal = Console.ReadLine().Split(',');
            int Col = int.Parse(InputVal[0]);
            int Row = int.Parse(InputVal[1]);
            int answer = Pascal(Col, Row);
            Console.WriteLine(answer.ToString());
            Console.ReadLine();

        }

        public static int Pascal(int Col, int Row)
        {
            int answer = 0;
            answer = pascaltrirecur(Row, Col);
            return answer;
        }

        private static int pascaltrirecur(int row, int col)
        {
            if (col == 0 || col == row) return 1;
            else if (col == 1 || (col + 1) == row) return row;
            else return pascaltrirecur(row - 1, col - 1) + pascaltrirecur(row - 1, col);
        }

    }
}
