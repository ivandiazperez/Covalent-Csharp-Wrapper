using System;
using System.Collections.Generic;
using System.Text;

namespace Covalent_Csharp_Wrapper
{
    public class CovalentPricing
    {
		private CovalentSession covSession;
		public CovalentPricing(CovalentSession covSession)
		{
			this.covSession = covSession;
		}

		// GET pricing/historical_by_address/{chain_id}/{quote_currency}/{contract_address}/
		public String GetHistoricalByAddress(CovalentNetworks cn, CovalentQuoteCurrency cqc, String contractAddress)
		{
			String req = "pricing/historical_by_address/"+(int)cn+"/"+cqc+"/"+contractAddress+"/";
		return covSession.Query(req);
	}
	// GET pricing/historical_by_addresses_v2/{chain_id}/{quote_currency}/{contract_addresses}/
	public String GetHistoricalByAddressesV2(CovalentNetworks cn, CovalentQuoteCurrency cqc, String contractAddresses) 
	{
		String req = "pricing/historical_by_addresses_v2/"+(int)cn+"/"+cqc+"/"+contractAddresses+"/";
		return covSession.Query(req);
	}
	// GET pricing/historical_by_addresses/{chain_id}/{quote_currency}/{contract_addresses}/
	public String GetHistoricalByAddresses(CovalentNetworks cn, CovalentQuoteCurrency cqc, String contractAddresses) //throws IOException
	{
		String req = "pricing/historical_by_addresses/"+(int)cn+"/"+cqc+"/"+contractAddresses+"/";
		return covSession.Query(req);
	}
	// GET pricing/historical/{quote_currency}/{ticker_symbol}/
	public String GetHistoricalPriceByTickerSymbol(CovalentQuoteCurrency cqc, String tickerSymbol) //throws IOException
	{
		String req = "pricing/historical/"+cqc+"/"+tickerSymbol+"/";
		return covSession.Query(req);
	}
	// GET pricing/tickers/
	public String GetSpotPrices(CovalentQuoteCurrency cqc)
	{
		string req = "pricing/tickers/"+cqc+"/";
		return covSession.Query(req);
	}
	public String GetSpotPricesByTickerSymbol(CovalentQuoteCurrency cqc, String tickersSymbols)
	{
		String req = "pricing/tickers/"+cqc+"/?tickers="+tickersSymbols;
		return covSession.Query(req);
	}
	// GET pricing/volatility/
	public String GetPricesVolatility(CovalentQuoteCurrency cqc)
	{
		String req = "pricing/volatility/"+cqc+"/";
		return covSession.Query(req);
	}
	/**
	 * @param cqc
	 * @param tickersSymbols
	 */
	public String GetPricesVolatilityByTickerSymbol(CovalentQuoteCurrency cqc, String tickersSymbols)
	{
		String req = "pricing/volatility/"+cqc+"/?tickers="+tickersSymbols;
		return covSession.Query(req);
	}

}
}
