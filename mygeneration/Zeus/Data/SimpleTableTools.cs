using System;
		}
		public void FilterTable(SimpleTable table, string filterExpression) 
		public void SortTable(SimpleTable table, string sortExpression) 
		public SimpleTable JoinTables(SimpleTableJoinType joinType, SimpleTable table1, SimpleTable table2, string filterExpression) 
			PropertyInfo[] props;
			object obj = null;
			SimpleRow newrow = null;
			
			int idx = 0;
			foreach (object item in collection) 
			{
				props = item.GetType().GetProperties();
				newrow = newtable.Rows.Add();

				foreach (PropertyInfo prop in props) 
				{
					if (idx == 0) 
					{
						if (prop.CanRead &&
							((prop.PropertyType == typeof(String)) ||
							(prop.PropertyType == typeof(Char)) ||
							(prop.PropertyType == typeof(Byte)) ||
							(prop.PropertyType == typeof(Int64)) ||
							(prop.PropertyType == typeof(Int32)) ||
							(prop.PropertyType == typeof(Int16)) ||
							(prop.PropertyType == typeof(UInt64)) ||
							(prop.PropertyType == typeof(UInt32)) ||
							(prop.PropertyType == typeof(UInt16)) ||
							(prop.PropertyType == typeof(Boolean)) ||
							(prop.PropertyType == typeof(Decimal)) ||
							(prop.PropertyType == typeof(Double)) ||
							(prop.PropertyType == typeof(DateTime)) ||
							(prop.PropertyType == typeof(TimeSpan)))
							) 
						{
							newtable.Columns.Add(prop.Name);
						}
					}
					
					if (newtable.Columns.IndexOf(prop.Name) != -1) 
					{
						obj = prop.GetGetMethod().Invoke(item, null);
						newrow[prop.Name] = obj;
					}
				}

				idx++;
			}
		private static SimpleTable BuildSimpleTable(DataTable table)
				for (int i = 0; i < items.Length; i++) 
				for (int i = 0; i < items.Length; i++) 
			for (int i = 0; i < reader.FieldCount; i++) 
			while (reader.Read()) 
				for (int i = 0; i < reader.FieldCount; i++) 
			return newtable;
			{
			{
			{
			{
			{
				foreach (SimpleColumn column in table.Columns) 
				{
					newrow[column.Name] = row[column.Name];
				}