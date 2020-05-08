namespace Factory01
{
    public class Fabrika
    {
        public Telefon TelefonOlustur(string telefon)
        {
            switch (telefon)
            {
                case "SamsungJ6Plus":
                    return new SamsungJ6Plus();   
                case "SamsungJ6":
                    return new SamsungJ6();
                case "Iphone8":
                    return new Iphone8();
                case "Iphone7":
                    return new Iphone7();
                case "Iphone6":
                    return new Iphone6();
                default:
                    return new UrunSecin();   
            }
        }
    }
}
