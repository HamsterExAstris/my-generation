using System;
using System.Collections;
using System.Collections.Specialized;

namespace Zeus
{
	public interface IZeusTemplate
	{
		IZeusCodeSegment BodySegment { get; }
		string SourceType { get; set; }
		void Save();
		void Compile();
		void Encrypt();
	}
}