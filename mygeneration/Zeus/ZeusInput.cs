using System;
	/// <item><term>__defaultTemplatePath</term><description>The location of templates that should be displayed in the template browser.</description></item>
	/// <item><term>__defaultOutputPath</term><description>The default output path.</description></item>
	/// <item><term>__dbDriver</term><description>The default database driver.</description></item>
	/// <item><term>__dbConnectionString</term><description>The default database connection string.</description></item>
	/// <item><term>__domainOverride</term><description>True or false based on the Domain Override setting in the default Application Settings.</description></item>
	/// <item><term>__dbTarget</term><description>The selected DB Target</description></item>
	/// <item><term>__dbTargetMappingFileName</term><description>The DB Targets file path.</description></item>
	/// <item><term>__dbLanguageMappingFileName</term><description>The Language Mapping file path.</description></item>
	/// <item><term>__language</term><description>The selected language.</description></item>
	/// <item><term>__userMetaDataFileName</term><description>The User Meta-Data file path.</description></item>	/// </list>
	/// Dim tableNames
	/// databaseName = input.Item("cmbDatabase")
	/// Set tableNames = input.Item("lstTables")
	/// var tablenames = input.Item("lstTables"); 
	/// ArrayList tablenames = input["lstTables"] as ArrayList; 
		/// Creates a new ZeusInput object.
		/// </summary>
		/// Sets or retrieves the item that belongs to the passed in key.
		/// </summary>
		/// Removes the item that belongs to the passed in key.
		/// </summary>
		/// <param name="key"></param>
		/// Returns true if the passed in key exists.
		/// </summary>
		/// <param name="key"></param>
		/// <returns>True if the passed in key exists.</returns>
		/// Adds all of the items from the passed in collection.
		/// Supported collection types are, for example, HashTable, GuiController, and NameValueCollection
		/// </summary>
		/// <param name="collection"></param>
					{

		/// <summary>
		/// Returns an ICollection of all the keys from the ZeusInput hash
		/// </summary>
		public ICollection Keys
		{
			get 
			{
				return this._invars.Keys;
			}
		}

		/// Returns an ICollection of all the values from the ZeusInput hash
		/// </summary>
		public ICollection Values
		{
			get 
			{
				return this._invars.Values;
			}
		}

		/// Returns true if the array of keys all exist in the ZeusInput hash
		/// </summary>
		public bool ContainsKeys(object[] keys) 
			{
				{

		/// <summary>
		/// Returns a new instance of a serializable SimpleTable collection.
		/// </summary>
		/// <returns>A new instance of a serializable SimpleTable collection.</returns>
		public SimpleTable CreateSimpleTable() 
		{
			return new SimpleTable();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <exclude/>
		public string __Variables
		{
			get 
			{
				StringBuilder sb = new StringBuilder();
				foreach (string key in this._invars.Keys) 
				{
					sb.Append(key);
					sb.Append(": (");
					sb.Append(this._invars[key].GetType().FullName);
					sb.Append(") ");
					sb.Append(this._invars[key].ToString());
					sb.Append("\r\n");
				}

				return sb.ToString();
			}
		}
	}