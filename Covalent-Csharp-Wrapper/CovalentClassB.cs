using System;
using System.Collections.Generic;
using System.Text;

namespace Covalent_Csharp_Wrapper
{
    public class CovalentClassB
    {

		private CovalentSession covSession;
		public CovalentClassB(CovalentSession covSession)
		{
			this.covSession = covSession;
		}
		// GET {chain_id}/address/{address}/stacks/aave_v2/balances/
		public string GetAaveV2AddressBalances(CovalentNetworks cn, string address) 
		{
			string req = (int)cn+"/address/"+address+"/stacks/aave_v2/balances/";
		return covSession.Query(req);
		}
		// GET {chain_id}/address/{address}/stacks/sushiswap/acts/
		public string GetSushiswapAddressExchangeLiquidityTransactions(CovalentNetworks cn, string address, CovalentQuoteCurrency cqc, string swaps)
		{
			string req = (int)cn+"/address/"+address+"/stacks/sushiswap/acts/";
			string [] param = new string[] { "quote-currency", "swaps"};
			Object[] paramValues = new Object[] { cqc, swaps };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/address/{address}/stacks/sushiswap/balances/
		public string GetSushiswapAddressExchange(CovalentNetworks cn, string address, CovalentQuoteCurrency cqc)
		{
			string req = (int)cn+"/address/"+address+"/stacks/sushiswap/balances/";
			string [] param = new string[] { "quote-currency" };
			Object[] paramValues = new Object[] { cqc };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/networks/aave_v2/assets/
		public string GetAaveV2NetworkAssets(CovalentNetworks cn) 
		{
			string req = (int)cn+"/networks/aave_v2/assets/";
			return covSession.Query(req);
		}
		// GET {chain_id}/networks/sushiswap/assets/
		public string GetSushiswapNetworkAssets(CovalentNetworks cn, string tickers)
		{
			string req = (int)cn+"/networks/aave_v2/assets/";
			string [] param = new string[] { "tickers" };
			Object[] paramValues = new Object[] { tickers };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET 1/address/{address}/stacks/aave_v2/balances/
		public string GetAaveV2AddressBalance(/*CovalentNetworks cn,*/ string address)
		{
			string req = "1/address/"+address+"/stacks/aave_v2/balances/";
			return covSession.Query(req);
		}
		// GET 1/address/{address}/stacks/aave/balances/
		public string GetAaveAddressBalance(string address)
		{
			string req = "1/address/"+address+"/stacks/aave/balances/";
			return covSession.Query(req);
		}
		// GET 1/address/{address}/stacks/balancer/balances/
		public string GetBalancerExchangeAddressBalance(string address)
		{
			string req = "1/address/"+address+"/stacks/balancer/balances/";
			return covSession.Query(req);
		}
		// GET 1/address/{address}/stacks/compound/acts/
		public string GetCompoundAddressActivity(string address)
		{
			string req = "1/address/"+address+"/stacks/compound/acts/";
			return covSession.Query(req);
		}
		// GET 1/address/{address}/stacks/compound/balances/
		public string GetCompoundAddressBalances(string address)
		{
			string req = "1/address/"+address+"/stacks/compound/balances/";
			return covSession.Query(req);
		}
		// GET 1/address/{address}/stacks/curve/balances/
		public string GetCurveAddressBalances(string address)
		{
			string req = "1/address/"+address+"/stacks/curve/balances/";
			return covSession.Query(req);
		}
		// GET 1/address/{address}/stacks/farming/positions/
		public string GetFarminAddressStats(string address)
		{
			string req = "1/address/"+address+"/stacks/farming/positions/";
			return covSession.Query(req);
		}
		// GET 1/address/{address}/stacks/uniswap_v1/balances/
		public string GetUniswapV1AddressExchangeBalances(string address)
		{
			string req = "1/address/"+address+"/stacks/uniswap_v1/balances/";
				return covSession.Query(req);
		}
		// GET 1/address/{address}/stacks/uniswap_v2/acts/
		public string GetUniswapV2AddressLquidityTransactions(string address, string swaps)
		{
			string req = "1/address/"+address+"/stacks/uniswap_v2/acts/";
			string [] param = new string[] { "swaps" };
			Object[] paramValues = new Object[] { swaps };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET 1/address/{address}/stacks/uniswap_v2/balances/
		public string GetUniswapV2AddressExchangeBalances(string address)
		{
			string req = "1/address/"+address+"/stacks/uniswap_v2/balances/";
			return covSession.Query(req);
		}
		// GET networks/aave/assets/
		public string GetAaveNetworkAssets()
		{
			string req = "1/networks/aave/assets/";
			return covSession.Query(req);
		}
		// GET 1/networks/augur/affiliate_fee/
		public string GetAugurMarketAffiliateFeeDivisors()
		{
			string req = "1/networks/augur/affiliate_fee/";
			return covSession.Query(req);
		}
		// GET 1/networks/compound/assets/
		public string GetCompoundNetworkAssets()
		{
			string req = "1/networks/compound/assets/";
			return covSession.Query(req);
		}
		// GET 1/networks/uniswap_v2/assets/
		public string GetUniswapV2NetworkAssets() 
		{
			string req = "1/networks/uniswap_v2/assets/";
			return covSession.Query(req);
		}
		// GET 56/address/{address}/stacks/pancakeswap_v2/balances/
		public string GetPancakeswapV2AddressExchangeBalances(string address, CovalentQuoteCurrency cqc)
		{
			string req = "56/address/"+address+"/stacks/pancakeswap_v2/balances/";
			string [] param = new string[] { "quote-currency" };
			Object[] paramValues = new Object[] { cqc };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
			// GET 56/address/{address}/stacks/pancakeswap/acts/
			public string GetPancakeswapV2AddressExchangeLiquidityTransactions(string address, CovalentQuoteCurrency cqc, string swaps)
		{
			string req = "56/address/"+address+"/stacks/pancakeswap/acts/";
			string [] param = new string[] { "quote-currency", "swaps" };
			Object[] paramValues = new Object[] { cqc, swaps };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET 56/address/{address}/stacks/pancakeswap/balances/
		public string GetPancakeswapAddressExchangeBalances(string address, CovalentQuoteCurrency cqc)
		{
			string req = "56/address/"+address+"/stacks/pancakeswap/balances/";
			string [] param = new string[] { "quote-currency" };
			Object[] paramValues = new Object[] { cqc };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
			// GET 56/networks/pancakeswap_v2/assets/
		public string GetPancakeswapV2NetworkAssets(string tickers, string contract_addresses)
		{
			string req = "56/networks/pancakeswap_v2/assets/";
			string [] param = new string[] { "tickers", "contract-addresses" };
			Object[] paramValues = new Object[] { tickers, contract_addresses };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET 56/networks/pancakeswap_v2/assets/{address}/
		public string GetPancakeswapV2NetworkAssetsByAddress(string addresses)
		{
			string req = "56/networks/pancakeswap_v2/assets/"+addresses+"/";
			return covSession.Query(req);
		}
		// GET 56/networks/pancakeswap/assets/
		public string GetPancakeswapNetworkAssets(string tickers)
		{
			string req = "56/networks/pancakeswap/assets/";
			string [] param = new string[] { "tickers" };
			Object[] paramValues = new Object[] { tickers };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
    }
}
