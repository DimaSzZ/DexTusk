namespace Task_3
{
    internal abstract class Currency
    {
        public double CurDol { get; set; }

        public static  Currency Convertator(Currency inConvertCurrency,double cash, Currency outConvertCurrency)
        {
            if(outConvertCurrency is Rub rub )
            {
                rub.Cash = cash / inConvertCurrency.CurDol * rub.CurDol;
                return rub;
            }
            if (outConvertCurrency is Lei lei)
            {
                lei.Cash = cash / inConvertCurrency.CurDol * lei.CurDol;
                return lei;
            }
            if (outConvertCurrency is Griv griv)
            {
                griv.Cash = cash / inConvertCurrency.CurDol * griv.CurDol;
                return griv;
            }
            return outConvertCurrency;
        }
        public virtual void GetMoney(){}
    }
}
