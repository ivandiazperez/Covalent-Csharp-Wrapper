using System;
using System.Collections.Generic;
using System.Text;

namespace Covalent_Csharp_Wrapper
{
    public class CovalentClassA
    {

		private CovalentSession covSession;
		public CovalentClassA(CovalentSession covSession)
		{
			this.covSession = covSession;
		}
		// GET {chain_id}/address/{address}/balances_v2/
		public string GetTokenBalancesForAddress(CovalentNetworks cn, string address, Boolean nft, Boolean noNftFetch, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/address/"+address+"/balances_v2/";
			string[] param = new string[] {"nft", "no-nft-fetch", "match", "group", "sort", "skip", "primer", "quote-currency", "limit"};
			Object[] paramValues = new Object[] { nft ? "true" : "false", noNftFetch ? "true" : "false", match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/address/{address}/portfolio_v2/
		public string GetHistoricalPortfolioValueOverTime(CovalentNetworks cn, string address, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/address/"+address+"/portfolio_v2/";
			string [] param = new string[] { "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/address/{address}/transactions_v2/
		public string GetTransactions(CovalentNetworks cn, string address, CovalentQuoteCurrency cqc, Boolean block_signed_at_asc, Boolean no_logs, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/address/"+address+"/transactions_v2/";
			string [] param = new string[] { "block-signed-at-asc", "no-logs", "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { block_signed_at_asc ? "true" : "false", no_logs ? "true" : "false", match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/address/{address}/transfers_v2/
		public string GetERC20Transfers(CovalentNetworks cn, string address, string contract_address, CovalentQuoteCurrency cqc, /*Boolean block_signed_at_asc, Boolean no_logs,*/ string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/address/"+address+"/transfers_v2/";
			string [] param = new string[] { "contract-address", "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { contract_address, match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/block_v2/{block_height}/
		public string GetBlock(CovalentNetworks cn, string blockHeight, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/block_v2/"+blockHeight+"/";
			string [] param = new string[] { "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/block_v2/{start_date}/{end_date}/
		public string GetBlockHeights(CovalentNetworks cn, string start_date, string end_date, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/block_v2/"+start_date+"/"+end_date+"/";
			string [] param = new string[] { "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/events/address/{address}/
		public string GetLogEventsByContractAddress(CovalentNetworks cn, string address, string starting_block, string ending_block, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/events/address/"+address+"/";
			string [] param = new string[] { "starting-block", "ending-block", "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { starting_block, ending_block, match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/events/topics/{topic}/
		public string GetLogEventsByTopicHashes(CovalentNetworks cn, string topic, string secondary_topic, string starting_block, string ending_block, string sender_address, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/events/topics/"+topic+"/";
			string [] param = new string[] { "secondary-topic", "starting-block", "ending-block", "sender-address", "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { secondary_topic, starting_block, ending_block, sender_address, match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/tokens/{address}/nft_metadata/{token_id}/
		public string GetExternalNFTMetadata(CovalentNetworks cn, string address, string token_id, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/tokens/"+address+"/nft_metadata/"+token_id+"/";
			string [] param = new string[] { "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/tokens/{address}/nft_token_ids/
		public string GetNFTTokensIDs(CovalentNetworks cn, string address, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/tokens/"+address+"/nft_token_ids/";
			string [] param = new string[] { "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/tokens/{address}/nft_transactions/{token_id}/
		public string GetNFTTransactions(CovalentNetworks cn, string address, string token_id, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/tokens/"+address+"/nft_transactions/"+token_id+"/";
			string [] param = new string[] { "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/tokens/{address}/token_holders_changes/
		public string GetChangesInTokenHolders(CovalentNetworks cn, string address, CovalentQuoteCurrency cqc, string starting_block, string ending_block, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/tokens/"+address+"/token_holders_changes/";
			string [] param = new string[] { "starting-block", "ending-block", "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { starting_block, ending_block, match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		
		}
		// GET {chain_id}/tokens/{address}/token_holders/
		public string GetTokenHoldersASOfBlockHeight(CovalentNetworks cn, string address, string block_height, CovalentQuoteCurrency cqc, string starting_block, string ending_block, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/tokens/"+address+"/token_holders/";
			string[] param = new string[] { "starting-block", "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { starting_block, match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/tokens/tokenlists/{id}/
		public string GetAllContractMetaData(CovalentNetworks cn, string id, string block_height, CovalentQuoteCurrency cqc, string starting_block, string ending_block, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/tokens/tokenlists/"+id+"/";
			string [] param = new string[] { "starting-block", "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { starting_block, match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET {chain_id}/transaction_v2/{tx_hash}/
		public string GetTransaction(CovalentNetworks cn, string tx_hash, Boolean no_logs, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit)
		{
			string req = (int)cn+"/transaction_v2/"+tx_hash+"/";
			string [] param = new string[] { "no-logs", "match", "group", "sort", "skip", "primer", "quote-currency", "limit" };
			Object[] paramValues = new Object[] { no_logs ? "true" : "false", match, group, sort, skip, primer, cqc, limit };
			return covSession.Query(StringUtil.ConcatUrlParams(req, param, paramValues));
		}
		// GET chains/
		public string GetAllChain()
		{
			string req = "chains/";
			return covSession.Query(req);
		}
		// GET chains/status/
		public string GetAllChainStatuses()
		{
			string req = "chains/status/";
			return covSession.Query(req);
		}
    }
}
