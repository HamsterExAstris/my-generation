using System;

namespace Zeus
{
	public interface IZeusExecutionError
	{
		string FileName { get; }
		string Number { get; }
		string Source { get; }
	}
}