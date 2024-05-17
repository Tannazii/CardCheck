
public class CardValidator
{
    private bool ValidateCard(string card)
    {
        bool result = true;

        if (card.Length != 16)
            return false;

        int firstDigit = Convert.ToInt32(card[0].ToString());

        if (firstDigit == 5 || firstDigit == 6)
        {
            result = Luhn(card);
        }
        else if (firstDigit == 8 || firstDigit == 9)
        {
            //etebary
        }
        else//essential?
        {
            result = false;
        }
        return result;
    }

    public bool Luhn(string cardNumber)
    {
        bool result = false;
        int sum = 0;
        int stab = 0;

        for (int i = cardNumber.Length - 2; i >= 0; i -= 2)
        {
            stab = Convert.ToInt32(cardNumber[i].ToString()) * 2;

            if (stab > 9)
            {
                while (stab != 0)
                {
                    sum += stab % 10;
                    stab /= 10;
                }
            }
            sum += stab;
        }

        for (int i = cardNumber.Length - 1; i >= 0; i -= 2)
        {
            sum += Convert.ToInt32(cardNumber[i].ToString());
        }

        if (sum % 10 == 0)
        {
            result = true;
        }
        return result;
    }

    public bool Validate(Card card)
    {
        bool result = false;
        if (ValidateCard(card.CardNumber) == true && Luhn(card.CardNumber) == true)
        {
            result = true;
        }
        return result;
    }















}





