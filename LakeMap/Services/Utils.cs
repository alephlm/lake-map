using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LakeMap.Services
{
	public static class Utils
	{
		public static char[][] CreateMatrix(string value)
		{
			string[] lines = Regex.Split(value, "\r\n");
			return lines.Select(a => a.ToCharArray()).ToArray();
		}
	}
}
