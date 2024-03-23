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
    using System;
    
    
    public partial class EntitiesTypeScriptViewModelTemplate : EntitiesTypeScriptViewModelTemplateBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 7 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Sample Team Tools.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

");
            
            #line default
            #line hidden
            
            #line 16 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 var foreignKeysImported = Table.Properties.Where(s => bool.Parse(s.Attribute("InActive").Value) == false && bool.Parse(s.Attribute("IsDBField").Value) == true && bool.Parse(s.Attribute("IsForeignKey").Value) == true)
                                  .GroupBy(s=> s.Attribute("ForeignEntity").Value.Replace("\"", string.Empty) +"_" +s.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty)).ToList();
var foreignKeysImportedList = (from a in foreignKeysImported
                       select new XElement(a.Key, new XAttribute("ForeignEntity", a.Select(s=> s.Attribute("ForeignEntity").Value.Replace("\"", string.Empty)).FirstOrDefault()),
                          new XAttribute("NavigationPropertyName", a.Select(s => s.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty)).FirstOrDefault()),
                          new XAttribute("FieldName", string.Join(", ", a.Select(s => s.Attribute("FieldName").Value.Replace("\"", string.Empty)).ToList())))).ToList();
var importingList = new System.Collections.Generic.List<string>();
foreach (var property in foreignKeysImportedList) {
if (importingList.Contains(property.Attribute("ForeignEntity").Value.Replace("\"", string.Empty))) { continue; }
if (property.Attribute("ForeignEntity").Value.Replace("\"", string.Empty) == Table.Name) { continue; }
importingList.Add(property.Attribute("ForeignEntity").Value.Replace("\"", string.Empty));
            
            #line default
            #line hidden
            
            #line 27 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("import { ");
            
            #line default
            #line hidden
            
            #line 27 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("ForeignEntity").Value.Replace("\"", string.Empty)+"View" ));
            
            #line default
            #line hidden
            
            #line 27 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(" } from \"./");
            
            #line default
            #line hidden
            
            #line 27 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("ForeignEntity").Value.Replace("\"", string.Empty).SplitByCapital()+".view.model" ));
            
            #line default
            #line hidden
            
            #line 27 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("\";\r\n");
            
            #line default
            #line hidden
            
            #line 28 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 29 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("import { BaseModel } from \"../../extends/base-model.model\";\r\n");
            
            #line default
            #line hidden
            
            #line 30 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 foreach (string file in Table.EntityFiles) { 
            
            #line default
            #line hidden
            
            #line 31 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 XDocument fxmlFile = null; 
try { fxmlFile = XDocument.Load(file); 
if(bool.Parse(fxmlFile.Root.Attributes().Where(s => s.Name == "InActive").FirstOrDefault().Value)) { continue; } 
var tableProperties = fxmlFile.Root.Elements("field")?.Where(s=> bool.Parse(s.Attribute("IsForeignKey").Value) && s.Attribute("ForeignEntity").Value.Replace("\"", string.Empty) == Table.Name);
var foreignKeysMulti = tableProperties.Where(s => bool.Parse(s.Attribute("InActive").Value) == false && bool.Parse(s.Attribute("IsDBField").Value) == true && bool.Parse(s.Attribute("IsForeignKey").Value) == true)
                                  .GroupBy(s=> s.Attribute("ForeignEntity").Value.Replace("\"", string.Empty) +"_" +s.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty)).ToList();
var foreignKeysMultiList = (from a in foreignKeysMulti
                       select new XElement(a.Key, new XAttribute("ForeignEntity", a.Select(s=> s.Attribute("ForeignEntity").Value.Replace("\"", string.Empty)).FirstOrDefault()),
                          new XAttribute("NavigationPropertyName", a.Select(s => s.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty)).FirstOrDefault()),
                          new XAttribute("FieldName", string.Join(", ", a.Select(s => s.Attribute("FieldName").Value.Replace("\"", string.Empty)).ToList())))).ToList();
if (foreignKeysMulti != null && foreignKeysMulti.Count > 0 && fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) != Table.Name) {
if (!importingList.Contains(fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty))) { 
importingList.Add(fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty));
            
            #line default
            #line hidden
            
            #line 44 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("import { ");
            
            #line default
            #line hidden
            
            #line 44 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 44 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("View } from \"./");
            
            #line default
            #line hidden
            
            #line 44 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty).SplitByCapital()+".view.model" ));
            
            #line default
            #line hidden
            
            #line 44 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("\";\r\n");
            
            #line default
            #line hidden
            
            #line 45 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 } } 
            
            #line default
            #line hidden
            
            #line 46 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
} 
catch (Exception) { continue; } 
            
            #line default
            #line hidden
            
            #line 48 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 49 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(" \r\nexport class ");
            
            #line default
            #line hidden
            
            #line 50 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Table.Name ));
            
            #line default
            #line hidden
            
            #line 50 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("View extends BaseModel<");
            
            #line default
            #line hidden
            
            #line 50 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Table.IdTypeSciptType ));
            
            #line default
            #line hidden
            
            #line 50 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("> {\r\n");
            
            #line default
            #line hidden
            
            #line 51 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 foreach (var property in Table.Properties) { 
            
            #line default
            #line hidden
            
            #line 52 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 if(bool.Parse(property.Attribute("InActive").Value)) { continue; }
            
            #line default
            #line hidden
            
            #line 53 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 if(bool.Parse(property.Attribute("IsViewField").Value)) { 
            
            #line default
            #line hidden
            
            #line 54 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("    \r\n    private ");
            
            #line default
            #line hidden
            
            #line 55 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("FieldName").Value.Replace("\"", string.Empty).FirstCharToLowerCase() ));
            
            #line default
            #line hidden
            
            #line 55 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(" : ");
            
            #line default
            #line hidden
            
            #line 55 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.TypeScriptTypeName("View", Table.EntityFiles) ));
            
            #line default
            #line hidden
            
            #line 55 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(";\r\n    get ");
            
            #line default
            #line hidden
            
            #line 56 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("FieldName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 56 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("(): ");
            
            #line default
            #line hidden
            
            #line 56 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.TypeScriptTypeName("View", Table.EntityFiles) ));
            
            #line default
            #line hidden
            
            #line 56 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(" { return this.");
            
            #line default
            #line hidden
            
            #line 56 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("FieldName").Value.Replace("\"", string.Empty).FirstCharToLowerCase() ));
            
            #line default
            #line hidden
            
            #line 56 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("; }\r\n    set ");
            
            #line default
            #line hidden
            
            #line 57 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("FieldName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 57 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("(val: ");
            
            #line default
            #line hidden
            
            #line 57 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.TypeScriptTypeName("View", Table.EntityFiles) ));
            
            #line default
            #line hidden
            
            #line 57 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(") { this.");
            
            #line default
            #line hidden
            
            #line 57 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("FieldName").Value.Replace("\"", string.Empty).FirstCharToLowerCase() ));
            
            #line default
            #line hidden
            
            #line 57 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(" = val; }\r\n");
            
            #line default
            #line hidden
            
            #line 58 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 59 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 60 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 60 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 var foreignKeys = Table.Properties.Where(s => bool.Parse(s.Attribute("InActive").Value) == false && bool.Parse(s.Attribute("IsDBField").Value) == true && bool.Parse(s.Attribute("IsForeignKey").Value) == true)
                                  .GroupBy(s=> s.Attribute("ForeignEntity").Value.Replace("\"", string.Empty) +"_" +s.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty)).ToList();
var foreignKeysList = (from a in foreignKeys
                       select new XElement(a.Key, new XAttribute("ForeignEntity", a.Select(s=> s.Attribute("ForeignEntity").Value.Replace("\"", string.Empty)).FirstOrDefault()),
                          new XAttribute("NavigationPropertyName", a.Select(s => s.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty)).FirstOrDefault()),
                          new XAttribute("FieldName", string.Join(", ", a.Select(s => s.Attribute("FieldName").Value.Replace("\"", string.Empty)).ToList())))).ToList();
foreach (var property in foreignKeysList) { 
            
            #line default
            #line hidden
            
            #line 67 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("    \r\n    private ");
            
            #line default
            #line hidden
            
            #line 68 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty).FirstCharToLowerCase() ));
            
            #line default
            #line hidden
            
            #line 68 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(" : ");
            
            #line default
            #line hidden
            
            #line 68 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("ForeignEntity").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 68 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("View ;\r\n    get ");
            
            #line default
            #line hidden
            
            #line 69 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 69 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("(): ");
            
            #line default
            #line hidden
            
            #line 69 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("ForeignEntity").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 69 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("View  { return this.");
            
            #line default
            #line hidden
            
            #line 69 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty).FirstCharToLowerCase() ));
            
            #line default
            #line hidden
            
            #line 69 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("; }\r\n    set ");
            
            #line default
            #line hidden
            
            #line 70 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 70 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("(val: ");
            
            #line default
            #line hidden
            
            #line 70 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("ForeignEntity").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 70 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("View ) { this.");
            
            #line default
            #line hidden
            
            #line 70 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( property.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty).FirstCharToLowerCase() ));
            
            #line default
            #line hidden
            
            #line 70 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(" = val; }\r\n");
            
            #line default
            #line hidden
            
            #line 71 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 72 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 foreach (string file in Table.EntityFiles) { 
            
            #line default
            #line hidden
            
            #line 73 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 XDocument fxmlFile = null; 
try { fxmlFile = XDocument.Load(file); 
if(bool.Parse(fxmlFile.Root.Attributes().Where(s => s.Name == "InActive").FirstOrDefault().Value)) { continue; } 
var tableProperties = fxmlFile.Root.Elements("field")?.Where(s=> bool.Parse(s.Attribute("IsForeignKey").Value) && s.Attribute("ForeignEntity").Value.Replace("\"", string.Empty) == Table.Name);
var foreignKeysMulti = tableProperties.Where(s => bool.Parse(s.Attribute("InActive").Value) == false && bool.Parse(s.Attribute("IsDBField").Value) == true && bool.Parse(s.Attribute("IsForeignKey").Value) == true)
                                  .GroupBy(s=> s.Attribute("ForeignEntity").Value.Replace("\"", string.Empty) +"_" +s.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty)).ToList();
var foreignKeysMultiList = (from a in foreignKeysMulti
                       select new XElement(a.Key, new XAttribute("ForeignEntity", a.Select(s=> s.Attribute("ForeignEntity").Value.Replace("\"", string.Empty)).FirstOrDefault()),
                          new XAttribute("NavigationPropertyName", a.Select(s => s.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty)).FirstOrDefault()),
                          new XAttribute("FieldName", string.Join(", ", a.Select(s => s.Attribute("FieldName").Value.Replace("\"", string.Empty)).ToList())))).ToList();
foreach (var prop in foreignKeysMultiList) { 
            
            #line default
            #line hidden
            
            #line 84 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("    \r\n    private ");
            
            #line default
            #line hidden
            
            #line 85 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 85 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( prop.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty).FirstCharToLowerCase() ));
            
            #line default
            #line hidden
            
            #line 85 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(" : ");
            
            #line default
            #line hidden
            
            #line 85 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 85 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("View[] ;\r\n    get ");
            
            #line default
            #line hidden
            
            #line 86 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 86 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( prop.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 86 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("(): ");
            
            #line default
            #line hidden
            
            #line 86 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 86 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("View[]  { return this.");
            
            #line default
            #line hidden
            
            #line 86 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 86 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( prop.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty).FirstCharToLowerCase() ));
            
            #line default
            #line hidden
            
            #line 86 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("; }\r\n    set ");
            
            #line default
            #line hidden
            
            #line 87 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 87 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( prop.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 87 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("(val: ");
            
            #line default
            #line hidden
            
            #line 87 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 87 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write("View[] ) { this.");
            
            #line default
            #line hidden
            
            #line 87 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty) ));
            
            #line default
            #line hidden
            
            #line 87 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( prop.Attribute("NavigationPropertyName").Value.Replace("\"", string.Empty).FirstCharToLowerCase() ));
            
            #line default
            #line hidden
            
            #line 87 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(" = val; }\r\n");
            
            #line default
            #line hidden
            
            #line 88 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 89 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
} 
catch (Exception) { continue; } 
            
            #line default
            #line hidden
            
            #line 91 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 92 "GeneratedStructure\T4GeneratedTemplates\EntitiesTypeScriptViewModelTemplate.tt"
            this.Write(" \r\n}\r\n\r\n ");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class EntitiesTypeScriptViewModelTemplateBase {
        
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
