using Covalent_Csharp_Wrapper;
using NUnit.Framework;

namespace Covalent_Csharp_Wrapper_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            CovalentSession session = new CovalentSession("YOUR_API_KEY_HERE", "json");
            //CovalentPricing p = new CovalentPricing(session);
            //0x495f947276749Ce646f68AC8c248420045cb7b5e
            //p.GetHistoricalByAddress(CovalentNetworks.BinanceSmartChain, CovalentQuoteCurrency.USD, "0xaA0C2e4fc2b57F60FceA0a5A7b09200C918fA71b");
            //p.GetHistoricalPriceByTickerSymbol(CovalentQuoteCurrency.USD, "ETH");

            CovalentClassA classA = new CovalentClassA(session);
            classA.GetTokenBalancesForAddress(CovalentNetworks.Ethereum, "0x829bd824b016326a401d083b33d092293333a830", false, false, CovalentQuoteCurrency.USD, "", "", "", "", -1, -1);

            Assert.Pass();
        }
    }
}