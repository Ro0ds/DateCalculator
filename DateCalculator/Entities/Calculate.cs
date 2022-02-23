using System.Globalization;
using System.Text;

namespace DateCalculator.Entities {
    class Calculate {
        public double Years { get; set; }
        public double Months { get; set; }
        public double Weeks { get; set; }
        public double Days { get; set; }

        public Calculate() { }

        public void Calc(double value, char choice) {
            double daysYear = 365;

            /*
             1 - Years 
             2 - Months
             3 - Weeks
             4 - Days
             */

            if (choice == '1') {
                Years = value;
                Months = value * 12;
                Days = daysYear * value;
                Weeks = Days / 7;
            }
            else if (choice == '2') {
                Months = value;
                Days = value * 30.4;
                Years = value / 12;
                Weeks = Days / 7;
            }
            else if (choice == '3') {
                Weeks = value;
                Days = value * 7;
                Years = Days / daysYear;
                Months = Days / 30.4;
            }
            else if (choice == '4') {
                Days = value;
                Weeks = value / 7;
                Years = value / daysYear;
                Months = value / 30.4;
            }
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine($"Years: {Years.ToString("F1", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Months: {Months.ToString("F1", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Weeks: {Weeks.ToString("F1", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Days: {Days.ToString("F1", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
