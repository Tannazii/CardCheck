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


                CardValidator validatorService = new CardValidator();

                bool isvalid = validatorService.Validate(cardAp);
                Console.WriteLine($" Card Number is {isvalid} ");

                BinIdentify binService = new BinIdentify();
                string bankName = binService.DetectBin(cardAp.CardNumber);
                Console.WriteLine(bankName);


                Console.WriteLine("end");
            }
            while (isValid == false);
        }
    }
}
