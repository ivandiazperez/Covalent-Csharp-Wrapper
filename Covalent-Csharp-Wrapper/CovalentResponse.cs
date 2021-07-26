using System;
using System.Collections.Generic;
using System.Text;

namespace Covalent_Csharp_Wrapper
{
    public class CovalentResponse
    {

		private string _data;
		private Boolean _error;
		private string _errorMessage;
		private string _errorCode;

		public Boolean IsError
		{
            get
            {
				return _error;
			}
			set
            {
				_error = value;
            }		
		}

		public String Data
		{
			get
			{
				return _data;
			}
			set
			{
				_data = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return _errorMessage;
			}
			set
			{
				_errorMessage = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return _errorCode;
			}
			set
			{
				_errorCode = value;
			}
		}

	}
}
