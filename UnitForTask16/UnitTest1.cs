using System;
using System.Collections.Generic;
using System.Linq;
using Task_16FileStream;
using Xunit;

namespace UnitForTask16
{
    public class UnitTest1
    {
        [Obsolete("Obsolete")]
        [Fact]
        public void SaveDictionaryClients_Save_Positive()
        {
            var dicClients = FileStreamClass.DropDictionaryClients();
            if (dicClients != null)
            {
                dicClients["Иван"] = new List<InfoValuteAccount>() { new InfoValuteAccount("Rub", 322) };

                FileStreamClass.SaveDictionaryClients(dicClients);
            }

            var SearchClient = FileStreamClass.DropDictionaryClients();

            if (SearchClient != null)
            {
                Assert.Equal(1, SearchClient["Иван"].Count);
                SearchClient.Remove("Иван");
                FileStreamClass.SaveDictionaryClients(SearchClient);
            }
        }
        [Fact]
        [Obsolete("Obsolete")]
        public void DropDictionaryClients_Give_Positive()
        {
            var dicClients = new Dictionary<string, List<InfoValuteAccount>>();

            dicClients = FileStreamClass.DropDictionaryClients();

            Assert.Equal(true,dicClients != null);

        }
        [Fact]
        public void Convertation_LeiRub_Positive()
        {
            BankSystem.DictionaryCleints = new Dictionary<string, List<InfoValuteAccount>>();
            BankSystem.DictionaryCleints["Иван"] = new List<InfoValuteAccount>() { new InfoValuteAccount("Lei", 19.22),
                new InfoValuteAccount("Rub",0)};

            BankSystem.Convertation(19.22, "Lei","Rub","Иван");

            Assert.Equal(53.5, BankSystem.DictionaryCleints["Иван"].First(x => x.Type == "Rub").Cash);
            Assert.Equal(0, BankSystem.DictionaryCleints["Иван"].First(x => x.Type == "Lei").Cash);

        }
        [Fact]
        public void Convertation_ZeroTrans_Negative()
        {
            BankSystem.DictionaryCleints = new Dictionary<string, List<InfoValuteAccount>>();
            BankSystem.DictionaryCleints["Иван"] = new List<InfoValuteAccount>() { new InfoValuteAccount("Lei", 19.22),
                new InfoValuteAccount("Rub",53.5)};
            var oldValdonnor = BankSystem.DictionaryCleints["Иван"].First(x => x.Type == "Lei").Cash;
            var oldValrecipient = BankSystem.DictionaryCleints["Иван"].First(x => x.Type == "Rub").Cash;

            BankSystem.Convertation(0, "Lei", "Rub", "Иван");


            Assert.Equal(true,oldValdonnor == BankSystem.DictionaryCleints["Иван"].First(x => x.Type == "Lei").Cash 
                              && oldValrecipient == BankSystem.DictionaryCleints["Иван"].First(x => x.Type == "Rub").Cash);
        }
    }
}