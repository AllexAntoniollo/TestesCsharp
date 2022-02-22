using System;
namespace teste.Entities
{
    class HourContract
    {
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        public DateTime Date { get; set; }

        public HourContract()
        {
        }

        public HourContract(double valuePerHour, int hours, DateTime date)
        {
            ValuePerHour = valuePerHour;
            Hours = hours;
            Date = date;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
