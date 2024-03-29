//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:8.0.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample.AutoGenerated.GeneratedStructure.ClassesGeneratedStructure {
    using System.Linq;
    using Sample.AutoGenerated.HelperClasses;
    using Sample.AutoGenerated.GeneratedUtilities.SystemConstants;
    using System;
    
    
    public partial class EntitiesConfigurationTemplate : EntitiesConfigurationTemplateBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 7 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Sample Team Tools.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace ");
            
            #line default
            #line hidden
            
            #line 20 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( NameSpace ));
            
            #line default
            #line hidden
            
            #line 20 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write("\r\n{\r\n \r\n    public partial class ");
            
            #line default
            #line hidden
            
            #line 23 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Table.Name ));
            
            #line default
            #line hidden
            
            #line 23 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write("Configuration : BaseEntityTypeConfiguration<");
            
            #line default
            #line hidden
            
            #line 23 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Table.Name ));
            
            #line default
            #line hidden
            
            #line 23 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(", ");
            
            #line default
            #line hidden
            
            #line 23 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Table.IdType ));
            
            #line default
            #line hidden
            
            #line 23 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write("> \r\n    {\r\n        public override void Configure(EntityTypeBuilder<");
            
            #line default
            #line hidden
            
            #line 25 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Table.Name ));
            
            #line default
            #line hidden
            
            #line 25 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write("> builder)\r\n        {\r\n            ");
            
            #line default
            #line hidden
            
            #line 27 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Table.Name ));
            
            #line default
            #line hidden
            
            #line 27 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write("Configure(builder);\r\n");
            
            #line default
            #line hidden
            
            #line 28 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
 var primaryKeys = Table.Properties.Where(s=> bool.Parse(s.Attribute("InActive").Value) == false && bool.Parse(s.Attribute("IsDBField").Value) == true && bool.Parse(s.Attribute("IsPrimaryKey").Value) == true).ToList();
if(primaryKeys.Count > 1) {  
            
            #line default
            #line hidden
            
            #line 30 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write("            builder.HasKey(p => new { p.");
            
            #line default
            #line hidden
            
            #line 30 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(", p.", primaryKeys.Select(S=>S.Attribute("FieldName").Value.Replace("\"", string.Empty)).ToList()) ));
            
            #line default
            #line hidden
            
            #line 30 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(" });\r\n");
            
            #line default
            #line hidden
            
            #line 31 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 32 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write("       ");
            
            #line default
            #line hidden
            
            #line 32 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
 foreach (var property in Table.Properties) { 
            
            #line default
            #line hidden
            
            #line 33 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
 if(bool.Parse(property.Attribute("InActive").Value)) { continue; }
            
            #line default
            #line hidden
            
            #line 34 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
 if(!bool.Parse(property.Attribute("IsDBField").Value)) { continue; }
            
            #line default
            #line hidden
            
            #line 35 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
 if(property.Attribute("FieldDataType").Value.Replace("\"", string.Empty) == AutoGeneratedConstatnts.MetaDataTypes.N_TEXT) { 
            
            #line default
            #line hidden
            
            #line 36 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write("     builder.Property(e => e.");
            
            #line default
            #line hidden
            
            #line 36 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("FieldName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 36 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(").IsUnicode();\r\n       ");
            
            #line default
            #line hidden
            
            #line 37 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 38 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
 if(property.Attribute("FieldDataType").Value.Replace("\"", string.Empty).ConverteCSharpGeniricTypeToCamelCase(property, Table.EntityFiles) == AutoGeneratedConstatnts.SystemTypes.DOUBLE || property.Attribute("FieldDataType").Value.Replace("\"", string.Empty).ConverteCSharpGeniricTypeToCamelCase(property, Table.EntityFiles) == AutoGeneratedConstatnts.SystemTypes.DECIMAL) { 
            
            #line default
            #line hidden
            
            #line 39 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write("     builder.Property(e => e.");
            
            #line default
            #line hidden
            
            #line 39 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("FieldName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 39 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(").HasPrecision(");
            
            #line default
            #line hidden
            
            #line 39 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( int.Parse(property.Attribute("NumberOfDigits").Value) ));
            
            #line default
            #line hidden
            
            #line 39 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(", ");
            
            #line default
            #line hidden
            
            #line 39 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( int.Parse(property.Attribute("DigitsAfterPoint").Value) ));
            
            #line default
            #line hidden
            
            #line 39 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(");\r\n       ");
            
            #line default
            #line hidden
            
            #line 40 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 41 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
 if(!string.IsNullOrEmpty(property.Attribute("DefaultValue")?.Value?.Replace("\"", string.Empty))) { 
            
            #line default
            #line hidden
            
            #line 42 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write("     builder.Property(e => e.");
            
            #line default
            #line hidden
            
            #line 42 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("FieldName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 42 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(").HasDefaultValueSql(");
            
            #line default
            #line hidden
            
            #line 42 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("DefaultValue").Value ));
            
            #line default
            #line hidden
            
            #line 42 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write(");\r\n       ");
            
            #line default
            #line hidden
            
            #line 43 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 44 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 45 "GeneratedStructure\T4GeneratedTemplates\EntitiesConfigurationTemplate.tt"
            this.Write("     base.Configure(builder);\r\n        }\r\n    }\r\n\r\n}\r\n\r\n\r\n\r\n\r\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class EntitiesConfigurationTemplateBase {
        
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
