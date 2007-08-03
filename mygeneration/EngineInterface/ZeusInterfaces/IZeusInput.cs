using System;
using System.Collections;

namespace Zeus
{
	public interface IZeusInput
	{
		object this[string key] { get; set; }
		ICollection Values { get; }
		void Remove(object key);
		bool ContainsKeys(object[] keys); 
}