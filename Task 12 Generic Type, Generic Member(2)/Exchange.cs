namespace Task_12_Generic_Type__Generic_Member_2_
{
    internal class Exchange : IExchange
    { public double Convertation<T, B>(double money, T valueIn, B valueOut)
        {
            switch (valueIn)
            {
                case Rub rub:
                    money /= rub.Curs;
                    break;
                case Lei lei:
                    money /= lei.Curs;
                    break;
                case Grivna grivna:
                    money /= grivna.Curs;
                    break;
            }
            switch (valueOut)
            {
                case Rub rub:
                    return money * rub.Curs;
                case Lei lei:
                    return money * lei.Curs;
                case Grivna grivna:
                    return money * grivna.Curs;
            }
            Console.WriteLine("Что то пошло не так");
            return 0;
        }
    }
}
