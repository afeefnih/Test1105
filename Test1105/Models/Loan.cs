namespace Test1105.Models
{
    public class Loan
    {
        double topCalc;
        double botCalc;

        public string id { get; set; }
        public string name { get; set; }

        public Char Gender { get; set; }

        public char CreditInput { get; set; }

        public Double CreditRisk
        {
            get
            {
                if (CreditInput == 'A')
                {
                    return 0.03 / 12;
                } else if (CreditInput == 'B')
                {
                    return 0.031 / 12;
                }
                else
                {
                    return 0.032 / 12;
                }
            }
        }

        public double interestRate
        {
            get
            {
                if (CreditInput == 'A')
                {
                    return 3.0;
                }
                else if (CreditInput == 'B')
                {
                    return 3.1;
                }
                else
                {
                    return 3.2;
                }
            }
        }


        public double Principle { get; set; }

        public int NumberOfYears { get; set; }

        public double MonthlyPayment


        {
            get
            {

                // calc =  (CreditRisk(1+CreditRisk)Math.Pow(NumberOfYears/12);

                //P * (I * Math.Pow(1 + I, N)) / (Math.Pow(1 + I, N) - 1); //

                //return Principle * ( CreditRisk * Math.Pow(1 + CreditRisk,(NumberOfYears*12) ))/ (Math.Pow(1+ CreditRisk,(NumberOfYears*12) ) - 1);
                return Principle * (CreditRisk * Math.Pow(1 + CreditRisk, NumberOfYears * 12)) / (Math.Pow(1 + CreditRisk, NumberOfYears * 12) - 1);

            }


        }
    }
}
