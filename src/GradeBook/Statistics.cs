using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90.0:
                        return 'A';

                    case var d when d >= 80.0:
                        return 'B';

                    case var d when d >= 70.0:
                        return 'C';

                    case var d when d >= 60.0:
                        return 'D';

                    default:
                        return 'F';
                }
            }
        } // Property
        public double Sum;
        public int Count;

        public Statistics()
        {
            High = double.MinValue;
            Low = double.MaxValue;
        }

        public void Add(double grade)
        {
            Sum += grade;
            Count += 1;
            Low = Math.Min(grade, Low);
            High = Math.Max(grade, High);
        }
    }
}
