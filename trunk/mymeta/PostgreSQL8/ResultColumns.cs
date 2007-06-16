using System;
using System.Data;
using System.Data.OleDb;

namespace MyMeta.PostgreSQL8
{
#if ENTERPRISE
	using System.Runtime.InteropServices;
	[ComVisible(true), ClassInterface(ClassInterfaceType.AutoDual), ComDefaultInterface(typeof(IResultColumns))]
#endif 
	public class PostgreSQL8ResultColumns : ResultColumns
	{
		public PostgreSQL8ResultColumns()
		{

		}

		override internal void LoadAll()
		{
			try
			{
				string schema = "";

				if(-1 == this.Procedure.Schema.IndexOf("."))
				{
					schema = this.Procedure.Schema + ".";
				}

				string select = "SET FMTONLY ON EXEC " + this.Procedure.Database.Name + "." + schema + 
					this.Procedure.Name + " ";

				int paramCount = this.Procedure.Parameters.Count;

				if(paramCount > 0)
				{
					IParameters parameters = this.Procedure.Parameters;
					IParameter param = null;

					int c = parameters.Count;

					for(int i = 0; i < c; i++)
					{
						param = parameters[i];

						if(param.Direction == ParamDirection.ReturnValue)
						{
							paramCount--;
						}
					}
				}

				for(int i = 0; i < paramCount; i++)
				{
					if(i > 0) 
					{
						select += ",";
					}

					select += "null";
				}
											 
				OleDbDataAdapter adapter = new OleDbDataAdapter(select, this.dbRoot.ConnectionString);
				DataTable metaData = new DataTable();

				adapter.Fill(metaData);

				PostgreSQL8ResultColumn resultColumn = null;

				int count = metaData.Columns.Count;
				for(int i = 0; i < count; i++)
				{
					resultColumn = this.dbRoot.ClassFactory.CreateResultColumn() as PostgreSQL8.PostgreSQL8ResultColumn;
					resultColumn.dbRoot = this.dbRoot;
					resultColumn.ResultColumns = this;
					resultColumn._column = metaData.Columns[i];
					this._array.Add(resultColumn);
				}
			}
			catch {}
		}
	}
}
