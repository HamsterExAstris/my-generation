﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyGeneration.UI.Plugins.CodeSmith2MyGen.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MyGeneration.UI.Plugins.CodeSmith2MyGen.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static System.Drawing.Icon CodeSmithConverter {
            get {
                object obj = ResourceManager.GetObject("CodeSmithConverter", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;configuration&gt;
        ///	&lt;mygeneration exepath=&quot;&quot; templatepath=&quot;&quot; launch=&quot;True&quot;/&gt;
        ///	&lt;codesmith applicationpath=&quot;C:\Program Files\CodeSmith&quot; templatepath=&quot;C:\Program Files\CodeSmith\Samples\Collections&quot; /&gt;
        ///&lt;/configuration&gt;
        ///.
        /// </summary>
        internal static string Config {
            get {
                return ResourceManager.GetString("Config", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;maps&gt;
        ///	&lt;map source=&quot;Response.WriteLine()&quot; target=&quot;output.writeln(&amp;quot;&amp;quot;)&quot;/&gt;
        ///	&lt;map source=&quot;Response.WriteLine(&quot; target=&quot;output.writeln(&quot;/&gt;
        ///	&lt;map source=&quot;Response.Write(&quot; target=&quot;output.write(&quot;/&gt;
        ///	&lt;map source=&quot;.cst&quot; target=&quot;.zeus&quot;/&gt;
        ///&lt;/maps&gt;
        ///.
        /// </summary>
        internal static string DefaultCSMap {
            get {
                return ResourceManager.GetString("DefaultCSMap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;maps&gt;
        ///	&lt;map source=&quot;Response.WriteLine &amp;quot;&quot; target=&quot;output.writeln &amp;quot;&quot;/&gt;
        ///	&lt;map source=&quot;Response.WriteLine&quot; target=&quot;output.writeln &amp;quot;&amp;quot;&quot;/&gt;
        ///	&lt;map source=&quot;Response.Write&quot; target=&quot;output.write&quot;/&gt;
        ///	&lt;map source=&quot;.cst&quot; target=&quot;.zeus&quot;/&gt;
        ///&lt;/maps&gt;.
        /// </summary>
        internal static string DefaultVBMap {
            get {
                return ResourceManager.GetString("DefaultVBMap", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap Hammer {
            get {
                object obj = ResourceManager.GetObject("Hammer", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.IO;
        ///using System.Collections;
        ///using System.Text;
        ///using System.Reflection;
        ///
        ///using MyGeneration.CodeSmithConversion;
        ///using MyGeneration.CodeSmithConversion.Plugins;
        ///using MyGeneration.CodeSmithConversion.Template;
        ///
        ////*
        ///The DLLs Referenced are:
        ///	System.dll
        ///	System.Xml.dll
        ///	System.Data.dll
        ///	System.Drawing.dll
        ///	System.Windows.Forms.dll
        ///	MyGeneration.CodeSmithConversion.dll
        ///*/
        ///namespace MyGeneration.CodeSmithConversion
        ///{
        ///	/// &lt;summary&gt;
        ///	/// A Sample Plugin for custo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SamplePlugin_plugin {
            get {
                return ResourceManager.GetString("SamplePlugin_plugin", resourceCulture);
            }
        }
    }
}