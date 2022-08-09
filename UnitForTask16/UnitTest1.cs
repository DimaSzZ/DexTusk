using System;
using System.Collections.Generic;
using System.IO;
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
            dicClients["Иван"] = new List<InfoValuteAccount>(){new InfoValuteAccount("Rub",322)};

            FileStreamClass.SaveDictionaryClients(dicClients);
            var SearchClient = FileStreamClass.DropDictionaryClients();

            Assert.Equal(1, SearchClient["Иван"].Count);
            SearchClient.Remove("Иван");
            FileStreamClass.SaveDictionaryClients(SearchClient);
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
            var dicClients = new Dictionary<string, List<InfoValuteAccount>>();
            dicClients["Иван"] = new List<InfoValuteAccount>() { new InfoValuteAccount("Rub", 322) };

            //BankSystem.Convertation(donnor.Cash, donnor.Type, recipient.Type,);
        }
        [Fact]
        public void Convertation_ZeroTrans_Negative()
        {

        }
    }
}