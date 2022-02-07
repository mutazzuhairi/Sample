//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:6.0.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample.AutoGenerated.GeneratedStructure.ClassesGeneratedStructure {
    using System.Linq;
    using System.Xml.Linq;
    using Sample.AutoGenerated.HelperClasses;
    using System;
    
    
    public partial class EntitiesExtensionTemplate : EntitiesExtensionTemplateBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 7 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Sample Team Tools.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Microsoft.Extensions.DependencyInjection;
using Sample.BLLayer.Mapping;
using Sample.BLLayer.QueryServices;
using Sample.BLLayer.UpdateServices;
using Sample.BLLayer.Validating;
using Sample.DataLayer.Data.Repositries;
using Sample.DataLayer.Data.Repositries.Interfaces;
using Sample.BLLayer.Mapping.Interfaces;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.BLLayer.UpdateServices.Interfaces;
using Sample.BLLayer.Validating.Interfaces;

namespace ");
            
            #line default
            #line hidden
            
            #line 27 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( NameSpace ));
            
            #line default
            #line hidden
            
            #line 27 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("\r\n{\r\n \r\n    public static class ");
            
            #line default
            #line hidden
            
            #line 30 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ExtensiontName ));
            
            #line default
            #line hidden
            
            #line 30 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(@"
    {

        public static void AddEntityServicesToConfigure(this IServiceCollection services)
        {
            AddRepositriesToScope(services);
            AddMappingToScope(services);
            AddValidatingToScope(services);
            AddQueryServicesToScope(services);
            AddUpdateServicesToScope(services);
        }

        private static void AddRepositriesToScope(IServiceCollection services)
        {

       ");
            
            #line default
            #line hidden
            
            #line 45 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 foreach (string file in EntityFiles) { 
            
            #line default
            #line hidden
            
            #line 46 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 XDocument fxmlFile = null;
   try
   {
      fxmlFile = XDocument.Load(file);
   }
   catch (Exception)
   {
      continue;
   } 
            
            #line default
            #line hidden
            
            #line 55 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 if(bool.Parse(fxmlFile.Root.Attribute("InActive").Value)) { continue; }
            
            #line default
            #line hidden
            
            #line 56 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("    services.AddScoped<I");
            
            #line default
            #line hidden
            
            #line 56 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 56 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("Repositry, ");
            
            #line default
            #line hidden
            
            #line 56 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 56 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("Repositry>();\r\n       ");
            
            #line default
            #line hidden
            
            #line 57 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 58 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("\r\n        }\r\n\r\n        private static void AddValidatingToScope(IServiceCollectio" +
                    "n services)\r\n        {\r\n\r\n       ");
            
            #line default
            #line hidden
            
            #line 64 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 foreach (string file in EntityFiles) { 
            
            #line default
            #line hidden
            
            #line 65 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 XDocument fxmlFile = null;
   try
   {
      fxmlFile = XDocument.Load(file);
   }
   catch (Exception)
   {
      continue;
   } 
            
            #line default
            #line hidden
            
            #line 74 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 if(bool.Parse(fxmlFile.Root.Attribute("InActive").Value)) { continue; }
            
            #line default
            #line hidden
            
            #line 75 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("    services.AddScoped<I");
            
            #line default
            #line hidden
            
            #line 75 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 75 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("Validating, ");
            
            #line default
            #line hidden
            
            #line 75 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 75 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("Validating>();\r\n       ");
            
            #line default
            #line hidden
            
            #line 76 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 77 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("\r\n        }\r\n\r\n        private static void AddMappingToScope(IServiceCollection s" +
                    "ervices)\r\n        {\r\n\r\n       ");
            
            #line default
            #line hidden
            
            #line 83 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 foreach (string file in EntityFiles) { 
            
            #line default
            #line hidden
            
            #line 84 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 XDocument fxmlFile = null;
   try
   {
      fxmlFile = XDocument.Load(file);
   }
   catch (Exception)
   {
      continue;
   } 
            
            #line default
            #line hidden
            
            #line 93 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 if(bool.Parse(fxmlFile.Root.Attribute("InActive").Value)) { continue; }
            
            #line default
            #line hidden
            
            #line 94 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("    services.AddScoped<I");
            
            #line default
            #line hidden
            
            #line 94 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 94 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("Mapping, ");
            
            #line default
            #line hidden
            
            #line 94 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 94 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("Mapping>();\r\n       ");
            
            #line default
            #line hidden
            
            #line 95 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 96 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("\r\n        }\r\n\r\n        private static void AddUpdateServicesToScope(IServiceColle" +
                    "ction services)\r\n        {\r\n\r\n       ");
            
            #line default
            #line hidden
            
            #line 102 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 foreach (string file in EntityFiles) { 
            
            #line default
            #line hidden
            
            #line 103 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 XDocument fxmlFile = null;
   try
   {
      fxmlFile = XDocument.Load(file);
   }
   catch (Exception)
   {
      continue;
   } 
            
            #line default
            #line hidden
            
            #line 112 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 if(bool.Parse(fxmlFile.Root.Attribute("InActive").Value)) { continue; }
            
            #line default
            #line hidden
            
            #line 113 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("    services.AddScoped<I");
            
            #line default
            #line hidden
            
            #line 113 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 113 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("UpdateService, ");
            
            #line default
            #line hidden
            
            #line 113 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 113 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("UpdateService>();\r\n       ");
            
            #line default
            #line hidden
            
            #line 114 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 115 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("\r\n        }\r\n\r\n        private static void AddQueryServicesToScope(IServiceCollec" +
                    "tion services)\r\n        {\r\n\r\n       ");
            
            #line default
            #line hidden
            
            #line 121 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 foreach (string file in EntityFiles) { 
            
            #line default
            #line hidden
            
            #line 122 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 XDocument fxmlFile = null;
   try
   {
      fxmlFile = XDocument.Load(file);
   }
   catch (Exception)
   {
      continue;
   } 
            
            #line default
            #line hidden
            
            #line 131 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 if(bool.Parse(fxmlFile.Root.Attribute("InActive").Value)) { continue; }
            
            #line default
            #line hidden
            
            #line 132 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("    services.AddScoped<I");
            
            #line default
            #line hidden
            
            #line 132 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 132 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("QueryService, ");
            
            #line default
            #line hidden
            
            #line 132 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 132 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("QueryService>();\r\n       ");
            
            #line default
            #line hidden
            
            #line 133 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 134 "GeneratedStructure\T4GeneratedTemplates\EntitiesExtensionTemplate.tt"
            this.Write("\r\n        }\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class EntitiesExtensionTemplateBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
