using System;
using System.IO;
using System.Net;

namespace Covalent_Csharp_Wrapper
{
	public class CovalentSession
	{


		private string _apiKey;
		private string _format = "";
		private string _fromDate = "";
		private string _toDate = "";
		private int _pageSize;
		private int _pageNumber;
		private Boolean _pricesAscending;

		//private OkHttpClient client;

		private const string serverUrl = "https://api.covalenthq.com/v1/";

		public CovalentSession(string apiKey)
		{
			_apiKey = apiKey;
			_format = "json";

			//client = new OkHttpClient();
		}

		public CovalentSession(String apiKey, String format)
		{
			_apiKey = apiKey;
			_format = format;

			//client = new OkHttpClient();
		}

		public string Key
		{
			get
			{
				return _apiKey;
			}
			set
			{
				_apiKey = value;
			}
		}

		public Boolean IsPricesAscending
		{
			get
			{
				return _pricesAscending;
			}
			set

			{
				_pricesAscending = value;
			}
		}

		public int PageNumber
		{
			get
			{
				return _pageNumber;
			}
			set

			{
				_pageNumber = value;
			}
		}

		public int PageSize
		{
			get
			{
				return _pageSize;
			}
			set

			{
				_pageSize = value;
			}
		}

		public string ToDate
		{
			get
			{
				return _toDate;
			}
			set

			{
				_toDate = value;
			}
		}

		public string FromDate
		{
			get
			{
				return _fromDate;
			}
			set

			{
				_fromDate = value;
			}
		}

		public string Format
		{
			get
			{
				return _format;
			}
			set

			{
				_format = value;
			}
		}


		public string Query(string requestURL)
		{
			string url = serverUrl + requestURL;
			if (requestURL.Substring(requestURL.Length - 1).Equals("/"))
			{
				url += "?key=" + _apiKey;
			}
			else
			{
				url += "&key=" + _apiKey;
			}
			if (!string.IsNullOrEmpty(_format))
			{
				url += "&format=" + _format;
			}
			if (!string.IsNullOrEmpty(_fromDate))
			{
				url += "&from=" + _fromDate;
			}
			if (!string.IsNullOrEmpty(_toDate))
			{
				url += "&to=" + _toDate;
			}
			if (_pricesAscending)
			{
				url += "&prices-at-asc=true";
			}
			if (_pageSize > 0)
			{
				url += "&page-size=" + _pageSize;
			}
			if (_pageNumber > 0)
			{
				url += "&page-number=" + _pageNumber;
			}

			Console.WriteLine(url);
			//Request request = new Request.Builder()
			//			  .url(url)
			//			  .build();

			try
			{
				//Response response = client.newCall(request).execute()
				//string responseString = response.body().string ();
				//Console.WriteLine(responseString);
				//return responseString;

				WebRequest wrequestGETURL = WebRequest.Create(url);
				WebResponse wresponseGETURL = wrequestGETURL.GetResponse();
				Stream objStream = wresponseGETURL.GetResponseStream();
				
				StreamReader objReader = new StreamReader(objStream);
				
				string responseString = objReader.ReadToEnd();

				wresponseGETURL.Close();
				objReader.Close();

				Console.WriteLine(responseString);
				return responseString;

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				throw e;
			}


		}

	}

}
