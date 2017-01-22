using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squares
{
    public class Squares
    {
        private int value;
        private int sum;
        private int result;

        public Squares(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException();
            this.value = value;
        }

        public int SquareOfSums()
        {
            for (int i = 1; i <= value; i++)
                sum += i;
            return (int)Math.Pow(sum, 2);
        }
        public int SumOfSquares()
        {
            for (int i = 1; i <= value; i++)
                result += (int)Math.Pow(i, 2);
            return result;
        }
        public int DifferenceOfSquares()
        {
            result = SquareOfSums() - SumOfSquares();   
            return result;
        }

        
    }
}
