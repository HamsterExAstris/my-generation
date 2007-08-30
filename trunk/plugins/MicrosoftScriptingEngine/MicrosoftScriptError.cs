using System;
using MSScriptControl;

namespace Zeus.MicrosoftScript
{
	/// <summary>
	/// Summary description for MicrosoftScriptError.
	/// </summary>
	public class MicrosoftScriptError : IZeusExecutionError
	{
		private string _fileName;
		private string _number;
		private string _source;
		private bool _isWarning = false;

		public MicrosoftScriptError(MSScriptControl.Error error, IZeusContext context)
		{
			if (context != null)
				this._fileName = context.ExecutingTemplate.FilePath + context.ExecutingTemplate.FileName;

		public string FileName { get { return _fileName; } }
		public string Number { get { return _number; } }
		public string Source { get { return _source; } }
		public bool IsWarning { get { return _isWarning; } }
	}
}