using System;
using System.Collections;

namespace Zeus
{
	public interface IZeusOutput
	{
		void write(string text);
		string getPreserveBlock(string key);
	}
}