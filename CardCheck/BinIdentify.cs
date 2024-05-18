public class BinIdentify
{
    Dictionary<string, string> bins = new Dictionary<string, string>()
    {
        {"Ayendeh","636214"},
        {"E.Novin","627412" },
        {"Ansar","627381"},
        {"IranZamin","505785"},
        {"IranVene","581874"},
        {"Parsian","622106"},
        {"Pasargad1","639341"},
        {"Pasargad2","502229"},
        {"PostBank","627760"},
        {"Tejarat1","627353"},
        {"Tejarat2","585983"},
        {"Saderat","627648"},
        {"Ta'avon","502908"},
        {"H.Iranian","636949"},
        {"Khavarmiyaneh1","505809"},
        {"Khavarmiyaneh2","585947"},
        {"Dey","502938"},
        {"Refah","589463" },
        {"Saman","621986"},
        {"Sepah1","589210"},
        {"Sepah2","604932"},
        {"Sarmayeh","639607"},
        {"Sina","639346"},
        {"Shahr","504706"},
        {"Saderat1","603769"},
        {"Sanat-Madan","627961"},
        {"Resalat","504172"},
        {"Mehr-Iran","606373"},
        {"Ghavamin","639599"},
        {"KarAfarin1","627488"},
        {"KarAfarin2","502910"},
        {"Keshavarzi1","603770"},
        {"Keshavarzi2","639217"},
        {"Gardeshgary","505416"},
        {"Markazi","636790"},
        {"Maskan","628023"},
        {"Melat","610433"},
        {"Melli","603799"},
        {"Tose'e","628157"},
        {"Kosar","505801"},
        {"Melal","606256"},
        {"Noor","507677"},
        {"Wallet","983255"},
        {"Debit","888888" },
        {"Tali","999999"},
    };

    public string DetectBin(string card)
    {
        string bank = " ";
        foreach (KeyValuePair<string, string> bin in bins)
        {
            if (card.Substring(0 , 6) == bin.Value)
            {
                bank = bin.Key;
            }
        }
        return bank;
    }















}

