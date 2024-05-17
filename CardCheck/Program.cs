namespace CheckCard
{
    class Program
    {
        public static void Main(String[] args)
        {
            bool isValid = false;
            do
            {
                Console.WriteLine("start");

                Card cardAp = new Card();

                Console.WriteLine("ENTER Card Number :");
                cardAp.CardNumber = Console.ReadLine();


                CardValidator service = new CardValidator();

                bool isvalid = service.Validate(cardAp);
                Console.WriteLine($" Card Number is {isvalid} ");


                Console.WriteLine("end");
            }
            while (isValid == false);
        }
    }
}
