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
    using System;
    
    
    public partial class EntitiesIQueryServiceTemplate : EntitiesIQueryServiceTemplateBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 6 "GeneratedStructure\T4GeneratedTemplates\EntitiesIQueryServiceTemplate.tt"
            this.Write("using Sample.BLLayer.EntityDTOs;\r\nusing Sample.BLLayer.EntityViews;\r\nusing Sample" +
                    ".BLLayer.BLUtilities.Interfaces;\r\n\r\nnamespace ");
            
            #line default
            #line hidden
            
            #line 10 "GeneratedStructure\T4GeneratedTemplates\EntitiesIQueryServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( NameSpace ));
            
            #line default
            #line hidden
            
            #line 10 "GeneratedStructure\T4GeneratedTemplates\EntitiesIQueryServiceTemplate.tt"
            this.Write("\r\n{\r\n \r\n    public interface I");
            
            #line default
            #line hidden
            
            #line 13 "GeneratedStructure\T4GeneratedTemplates\EntitiesIQueryServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Table.Name ));
            
            #line default
            #line hidden
            
            #line 13 "GeneratedStructure\T4GeneratedTemplates\EntitiesIQueryServiceTemplate.tt"
            this.Write("QueryService : IQueryService<");
            
            #line default
            #line hidden
            
            #line 13 "GeneratedStructure\T4GeneratedTemplates\EntitiesIQueryServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Table.Name ));
            
            #line default
            #line hidden
            
            #line 13 "GeneratedStructure\T4GeneratedTemplates\EntitiesIQueryServiceTemplate.tt"
            this.Write("DTO, ");
            
            #line default
            #line hidden
            
            #line 13 "GeneratedStructure\T4GeneratedTemplates\EntitiesIQueryServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Table.Name ));
            
            #line default
            #line hidden
            
            #line 13 "GeneratedStructure\T4GeneratedTemplates\EntitiesIQueryServiceTemplate.tt"
            this.Write("View>\r\n    {\r\n\r\n\r\n    }\r\n\r\n}");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class EntitiesIQueryServiceTemplateBase {
        
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
