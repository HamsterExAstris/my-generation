using System;
using System.Collections;
using System.Collections.Specialized;

namespace Zeus
{
	public interface IZeusTemplateStub
	{
		IZeusCodeSegmentStub BodySegmentStub { get; }
		string SourceType { get; }
	}
}