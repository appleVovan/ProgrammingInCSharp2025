using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Models
{
    class UserCandidate
    {
		#region Fields
		private string _login;
		private string _password;
		#endregion

		#region Properties
		public string Login
		{
			get { return _login; }
			set { _login = value; }
		}
		public string Password
		{
			get { return _password; }
			set { _password = value; }
		} 
		#endregion

	}
}
