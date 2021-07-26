using System;
using System.Collections.Generic;
using System.Text;

namespace Covalent_Csharp_Wrapper
{
    public static class StringUtil
    {

		//a more dynamic way to concatenate url parameters 
		public static string ConcatUrlParams(string url, string[] param, Object[] paramValues)
		{
			if (param.Length != paramValues.Length)
			{
				 return url;
			}
			for (int i = 0; i < param.Length; i++) 
			{
				if (paramValues[i]!=null && !string.IsNullOrEmpty(paramValues[i].ToString()) && !"-1".Equals(paramValues[i].ToString()))
				{
					string separator = i == 0 ? "?" : "&";
					url += separator + param[i] + "=" + paramValues[i];
				}
			}
			return url;
		}

	}
}
