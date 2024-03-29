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
    using System.Xml.Linq;
    using Sample.AutoGenerated.HelperClasses;
    using Sample.AutoGenerated.GeneratedUtilities.SystemConstants;
    using System;
    
    
    public partial class EntitiesContextTemplate : EntitiesContextTemplateBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 8 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Sample Team Tools.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.Data.Configuration;
using Sample.DataLayer.DataUtilities.Extensions;

namespace ");
            
            #line default
            #line hidden
            
            #line 22 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( NameSpace ));
            
            #line default
            #line hidden
            
            #line 22 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write("\r\n{\r\n \r\n    public sealed class ");
            
            #line default
            #line hidden
            
            #line 25 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ContextName ));
            
            #line default
            #line hidden
            
            #line 25 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(" : IdentityDbContext<User, Role, long, UserClaim, UserRole, UserLogin, RoleClaim," +
                    " UserToken>\r\n    {\r\n        \r\n        public ");
            
            #line default
            #line hidden
            
            #line 28 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ContextName ));
            
            #line default
            #line hidden
            
            #line 28 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(" (DbContextOptions<");
            
            #line default
            #line hidden
            
            #line 28 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ContextName ));
            
            #line default
            #line hidden
            
            #line 28 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(@"> options) : base(options)
        {

            this.ChangeTracker.LazyLoadingEnabled = false;
            this.ChangeTracker.AutoDetectChangesEnabled = false;
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.AddRestrictToRelationshipOnDelete();
            ");
            
            #line default
            #line hidden
            
            #line 41 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
 foreach (string file in EntityFiles) { 
            
            #line default
            #line hidden
            
            #line 42 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
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
            
            #line 51 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
 if(bool.Parse(fxmlFile.Root.Attribute("InActive").Value)) { continue; }
            
            #line default
            #line hidden
            
            #line 52 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write("modelBuilder.ApplyConfiguration(new  ");
            
            #line default
            #line hidden
            
            #line 52 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 52 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( EntityConfigurationConvention ));
            
            #line default
            #line hidden
            
            #line 52 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write("());\r\n            ");
            
            #line default
            #line hidden
            
            #line 53 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 54 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write("\r\n        } \r\n\r\n       ");
            
            #line default
            #line hidden
            
            #line 57 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
 foreach (string file in EntityFiles) { 
            
            #line default
            #line hidden
            
            #line 58 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
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
            
            #line 67 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
 if(bool.Parse(fxmlFile.Root.Attribute("InActive").Value)) { continue; }
            
            #line default
            #line hidden
            
            #line 68 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
 if (AutoGeneratedConstatnts.IdentityEntities.IDENTITY_ENTITIES_LIST.Contains(fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty))) { 
            
            #line default
            #line hidden
            
            #line 69 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(" public override DbSet<");
            
            #line default
            #line hidden
            
            #line 69 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 69 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write("> ");
            
            #line default
            #line hidden
            
            #line 69 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty).Pluralize() ));
            
            #line default
            #line hidden
            
            #line 69 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(" { get; set; }\r\n");
            
            #line default
            #line hidden
            
            #line 70 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            
            #line 71 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(" public DbSet<");
            
            #line default
            #line hidden
            
            #line 71 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 71 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write("> ");
            
            #line default
            #line hidden
            
            #line 71 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty).Pluralize() ));
            
            #line default
            #line hidden
            
            #line 71 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write(" { get; set; }\r\n");
            
            #line default
            #line hidden
            
            #line 72 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 73 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write("       ");
            
            #line default
            #line hidden
            
            #line 73 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 74 "GeneratedStructure\T4GeneratedTemplates\EntitiesContextTemplate.tt"
            this.Write("\r\n    }\r\n}\r\n\r\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class EntitiesContextTemplateBase {
        
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
