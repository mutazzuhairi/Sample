using System;
using System.Windows;
using System.Xml;
using System.IO;
using Sample.Meatadata.WindowView;

namespace Sample.Meatadata.XmlServices
{
    public class XmlGenerator
    {  
        public static void GenerateXmlFileFromTool(ObjectTableViewModel table)
        { 
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);
            XmlElement entityElement = (XmlElement)doc.AppendChild(doc.CreateElement("entity"));
            SetAttributesForObjectTableProperties(table, entityElement);
            SetAttributesForObjectFieldsProperties(table, entityElement, doc);
            if (!string.IsNullOrEmpty(App.DirectOpenPath))
            {
                FileStream fileStream = new FileStream(App.DirectOpenPath, FileMode.Truncate, FileAccess.Write);
                XmlWriterSettings settings = new XmlWriterSettings() { Indent = true, NewLineOnAttributes = true , OmitXmlDeclaration = false, WriteEndDocumentOnClose = false };
                XmlWriter xmlWriter = XmlWriter.Create(fileStream, settings);
                doc.Save(xmlWriter);
                xmlWriter.Close();
                xmlWriter.Dispose();
                fileStream.Close();
                fileStream.Dispose();
            }
            else
            {
                MessageBox.Show("file path in not valid!");
            }
        }  

        private static void SetAttributesForObjectTableProperties(ObjectTableViewModel table, XmlElement entityElement)
        {
            if (string.IsNullOrEmpty(table.Id))
            {
                SetAttribute("Id", GetStringValue(Guid.NewGuid()), entityElement);
            }
            else
            {
                SetAttribute("Id", GetStringValue(table.Id), entityElement);
            }
            SetAttribute("IsNew", table.IsNew.ToString().ToLower(), entityElement);
            SetAttribute("TableName", GetStringValue(table.TableName), entityElement);
            SetAttribute("BaseIdType", GetStringValue(table.BaseIdType), entityElement);
            SetAttribute("BaseType", GetStringValue(table.BaseType), entityElement);
            SetAttribute("IsBaseIdPrimaryKey", table.IsBaseIdPrimaryKey.ToString().ToLower(), entityElement);
            SetAttribute("OldTableName", GetStringValue(table.OldTableName), entityElement);
            SetAttribute("InActive", table.InActive.ToString().ToLower(), entityElement);
            SetAttribute("NoObjectTable", table.NoObjectTable.ToString().ToLower(), entityElement);
            SetAttribute("DefaultText", GetStringValue(table.DefaultText), entityElement);
            SetAttribute("LocalDefaultText", GetStringValue(table.LocalDefaultText), entityElement);
            SetAttribute("NoViewController", table.NoViewController.ToString().ToLower(), entityElement);
            SetAttribute("NoDTOController", table.NoDTOController.ToString().ToLower(), entityElement);

            if (!string.IsNullOrEmpty(table.IndexGroup1))
            {
                SetAttribute("IndexGroup1", GetStringValue(table.IndexGroup1), entityElement);
                SetAttribute("IndexGroupUnique1", table.IndexGroupUnique1.ToString().ToLower(), entityElement);
            }
            else
            {
                RemoveAttribute("IndexGroup1", entityElement);
                RemoveAttribute("IndexGroupUnique1", entityElement);
            }
            if (!string.IsNullOrEmpty(table.IndexGroup2))
            {
                SetAttribute("IndexGroup2", GetStringValue(table.IndexGroup2), entityElement);
                SetAttribute("IndexGroupUnique2", table.IndexGroupUnique2.ToString().ToLower(), entityElement);
            }
            else
            {
                RemoveAttribute("IndexGroup2", entityElement);
                RemoveAttribute("IndexGroupUnique2", entityElement);
            }
            if (!string.IsNullOrEmpty(table.IndexGroup3))
            {
                SetAttribute("IndexGroup3", GetStringValue(table.IndexGroup3), entityElement);
                SetAttribute("IndexGroupUnique3", table.IndexGroupUnique3.ToString().ToLower(), entityElement);
            }
            else
            {
                RemoveAttribute("IndexGroup3", entityElement);
                RemoveAttribute("IndexGroupUnique3", entityElement);
            }
            if (!string.IsNullOrEmpty(table.IndexGroup4))
            {
                SetAttribute("IndexGroup4", GetStringValue(table.IndexGroup4), entityElement);
                SetAttribute("IndexGroupUnique4", table.IndexGroupUnique4.ToString().ToLower(), entityElement);
            }
            else
            {
                RemoveAttribute("IndexGroup4", entityElement);
                RemoveAttribute("IndexGroupUnique4", entityElement);
            }
            if (!string.IsNullOrEmpty(table.IndexGroup5))
            {
                SetAttribute("IndexGroup5", GetStringValue(table.IndexGroup5), entityElement);
                SetAttribute("IndexGroupUnique5", table.IndexGroupUnique5.ToString().ToLower(), entityElement);
            }
            else
            {
                RemoveAttribute("IndexGroup5", entityElement);
                RemoveAttribute("IndexGroupUnique5", entityElement);
            }
            if (!string.IsNullOrEmpty(table.DescriptionDefaultText))
            {
                SetAttribute("DescriptionDefaultText", GetStringValue(table.DescriptionDefaultText), entityElement);
            }
            else
            {
                RemoveAttribute("DescriptionDefaultText", entityElement);
            }
            if (!string.IsNullOrEmpty(table.DescriptionLocalDefaultText))
            {
                SetAttribute("DescriptionLocalDefaultText", GetStringValue(table.DescriptionLocalDefaultText), entityElement);
            }
            else
            {
                RemoveAttribute("DescriptionLocalDefaultText", entityElement);
            }
            if (!string.IsNullOrEmpty(table.SearchFields))
            {
                SetAttribute("SearchFields", GetStringValue(table.SearchFields), entityElement);
            }
        }

        private static void SetAttributesForObjectFieldsProperties(ObjectTableViewModel table, XmlElement entityElement, XmlDocument doc)
        {
            foreach (ObjectFieldsViewModel f in table.ObjectTableFieldsList)
            {
                XmlElement fieldElement = doc.CreateElement("field");
                entityElement.AppendChild(fieldElement);
                if (string.IsNullOrEmpty(f.Id))
                {
                    SetAttribute("Id", GetStringValue(Guid.NewGuid()), fieldElement);
                }
                else
                {
                    SetAttribute("Id", GetStringValue(f.Id), fieldElement);
                }
                SetAttribute("FieldName", GetStringValue(f.FieldName), fieldElement);
                SetAttribute("OldFieldName", GetStringValue(f.OldFieldName), fieldElement);
                SetAttribute("IsNew", f.IsNew.ToString().ToLower(), fieldElement);
                SetAttribute("IsChecked", f.IsChecked.ToString().ToLower(), fieldElement);
                SetAttribute("IsDeleted", f.IsDeleted.ToString().ToLower(), fieldElement);
                SetAttribute("IsDBField", f.IsDBField.ToString().ToLower(), fieldElement);
                SetAttribute("IsDTOField", f.IsDTOField.ToString().ToLower(), fieldElement);
                SetAttribute("IsViewField", f.IsViewField.ToString().ToLower(), fieldElement);
                SetAttribute("FieldDataType", GetStringValue(f.FieldDataType), fieldElement);
                SetAttribute("LookUpTableName", GetStringValue(f.LookUpTableName), fieldElement);
                if (f.MinLength != null)
                {
                    SetAttribute("MinLength", f.MinLength.ToString(), fieldElement);
                }
                if (f.MaxLength != null)
                {
                    SetAttribute("MaxLength", f.MaxLength.ToString(), fieldElement);
                }
                if (f.IsRequired != null)
                {
                    SetAttribute("IsRequired", f.IsRequired.ToString().ToLower(), fieldElement);
                }
                if (f.UniqueField != null)
                {
                    SetAttribute("UniqueField", f.UniqueField.ToString().ToLower(), fieldElement);
                }
                if (f.HasIndex != null)
                {
                    SetAttribute("HasIndex", f.HasIndex.ToString().ToLower(), fieldElement);
                }
                if (f.NumberOfDigits != null)
                {
                    SetAttribute("NumberOfDigits", f.NumberOfDigits.ToString(), fieldElement);
                }
                if (f.DigitsAfterPoint != null)
                {
                    SetAttribute("DigitsAfterPoint", f.DigitsAfterPoint.ToString(), fieldElement);
                }
                SetAttribute("InActive", f.InActive.ToString().ToLower(), fieldElement);
                SetAttribute("DefaultText", GetStringValue(f.DefaultText), fieldElement);
                SetAttribute("DefaultValue", GetStringValue(f.DefaultValue), fieldElement);
                SetAttribute("LocalDefaultText", GetStringValue(f.LocalDefaultText), fieldElement);
                if (!string.IsNullOrEmpty(f.DescriptionDefaultText))
                {
                    SetAttribute("DescriptionDefaultText", GetStringValue(f.DescriptionDefaultText), fieldElement);
                    SetAttribute("DescriptionLocalDefaultText", GetStringValue(f.DescriptionLocalDefaultText), fieldElement);
                }
                if (f.IsNullable != null)
                {
                    SetAttribute("IsNullable", f.IsNullable.ToString().ToLower(), fieldElement);
                }
                SetAttribute("IsForeignKey", f.IsForeignKey.ToString().ToLower(), fieldElement);
                SetAttribute("ForeignEntity", f.ForeignEntity, fieldElement);
                SetAttribute("NavigationPropertyName", GetStringValue(f.NavigationPropertyName), fieldElement);
                SetAttribute("IsPrimaryKey", f.IsPrimaryKey.ToString().ToLower(), fieldElement);
                if (f.IsMaxLength != null)
                {
                    SetAttribute("IsMaxLength", f.IsMaxLength.ToString().ToLower(), fieldElement);
                }
                SetAttribute("IncludeInSearchField", f.IncludeInSearchField.ToString().ToLower(), fieldElement);
            }
        }

        private static string GetStringValue(object value)
        {
            if (value != null && (value.GetType() != typeof(string) || !string.IsNullOrEmpty((string)value)))
            {
                return "\"" + value.ToString().Replace("\"", "\u0022") + "\"";
            }
            else
            {
                return null;
            }
        }   

        private static void SetAttribute(string atrrName, string attrValue, XmlElement fieldElement)
        {
            if (!string.IsNullOrEmpty(attrValue))
            {
                fieldElement.SetAttribute(atrrName, attrValue);
            }
        }  

        private static void RemoveAttribute(string atrrName, XmlElement fieldElement)
        {
            fieldElement.RemoveAttribute(atrrName);

        } 
    }
}
