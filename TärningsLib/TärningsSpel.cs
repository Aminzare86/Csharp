using System;

namespace TärningsLib
{
	public class TärningsSpel
	{
		private int v;

		public TärningsSpel(int v)
		{
			this.v = v;
		}

		public string Feedback
		{
			get
			{
				
					return $"You are Winner.";
			}
		}
	}
}
