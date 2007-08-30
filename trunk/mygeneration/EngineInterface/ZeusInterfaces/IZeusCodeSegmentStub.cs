using System;
using System.Collections;

namespace Zeus
{
	public interface IZeusCodeSegmentStub
	{
		string SegmentType { get; }
		string Engine { get; }
		string Language { get; }
		string Mode { get; }
		string CodeUnparsed { get; }
		string Code { get; }
	}
}