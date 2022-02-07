using Sample.Meatadata.WindowView;
using System.Collections.Generic;
using System.Xml;

namespace Sample.Meatadata.XmlServices
{
    public class XmlParser
    {
        public ObjectTableViewModel LoadObjectTableData(XmlDocument document)
        {
            XmlElement entity = document["entity"];
            ObjectTableViewModel objectTable = BuildObjectTable(entity);
            List<ObjectFieldsViewModel> fields = new List<ObjectFieldsViewModel>();
            foreach (XmlNode fieldNode in entity.ChildNodes)
            {
                if (fieldNode.Name == "field")
                {
                    fields.Add(BuildObjectField(fieldNode, objectTable));
                }
            }
            objectTable.BuildObjectTableFieldsListt(fields);
            return objectTable;
        }

        public ObjectTableViewModel BuildObjectTable(XmlElement entity)
        {
            ObjectTableViewModel objectTable = new ObjectTableViewModel();
            if (entity != null)
            {
                objectTable.Id = GetAttributeStringValue(entity.Attributes["Id"]);
                objectTable.TableName = GetAttributeStringValue(entity.Attributes["TableName"]);
                objectTable.IsNew = GetAttributeBoolValue(entity.Attributes["IsNew"]);
                objectTable.IsDirty = GetAttributeBoolValue(entity.Attributes["IsDirty"]);
                objectTable.DefaultText = GetAttributeStringValue(entity.Attributes["DefaultText"]);
                objectTable.BaseIdType = GetAttributeStringValue(entity.Attributes["BaseIdType"]);
                objectTable.BaseType = GetAttributeStringValue(entity.Attributes["BaseType"]);
                objectTable.IsBaseIdPrimaryKey = GetAttributeBoolValue(entity.Attributes["IsBaseIdPrimaryKey"]);
                objectTable.LocalDefaultText = GetAttributeStringValue(entity.Attributes["LocalDefaultText"]);
                objectTable.DescriptionDefaultText = GetAttributeStringValue(entity.Attributes["DescriptionDefaultText"]);
                objectTable.DescriptionLocalDefaultText = GetAttributeStringValue(entity.Attributes["DescriptionLocalDefaultText"]);
                objectTable.IndexGroupUnique1 = GetAttributeBoolValue(entity.Attributes["IndexGroupUnique1"]);
                objectTable.IndexGroupUnique2 = GetAttributeBoolValue(entity.Attributes["IndexGroupUnique2"]);
                objectTable.IndexGroupUnique3 = GetAttributeBoolValue(entity.Attributes["IndexGroupUnique3"]);
                objectTable.IndexGroupUnique4 = GetAttributeBoolValue(entity.Attributes["IndexGroupUnique4"]);
                objectTable.IndexGroupUnique5 = GetAttributeBoolValue(entity.Attributes["IndexGroupUnique5"]);
                objectTable.IndexGroup1 = GetAttributeStringValue(entity.Attributes["IndexGroup1"]);
                objectTable.IndexGroup2 = GetAttributeStringValue(entity.Attributes["IndexGroup2"]);
                objectTable.IndexGroup3 = GetAttributeStringValue(entity.Attributes["IndexGroup3"]);
                objectTable.IndexGroup4 = GetAttributeStringValue(entity.Attributes["IndexGroup4"]);
                objectTable.IndexGroup5 = GetAttributeStringValue(entity.Attributes["IndexGroup5"]);

                if (string.IsNullOrEmpty(objectTable.Id))
                {
                    if (objectTable.IsNew == false)
                    {
                        objectTable.IsNew = true;
                    }
                }
                if (entity.Attributes["OldTableName"] != null)
                {
                    objectTable.OldTableName = GetAttributeStringValue(entity.Attributes["OldTableName"]);
                }
                else
                {
                    objectTable.OldTableName = GetAttributeStringValue(entity.Attributes["TableName"]);
                }
                if (entity.Attributes["NoViewController"] != null)
                {
                    objectTable.NoViewController = GetAttributeBoolValue(entity.Attributes["NoViewController"]);
                }
                else
                {
                    objectTable.NoViewController = false;
                }
                if (entity.Attributes["NoDTOController"] != null)
                {
                    objectTable.NoDTOController = GetAttributeBoolValue(entity.Attributes["NoDTOController"]);
                }
                else
                {
                    objectTable.NoDTOController = false;
                }
                if (entity.Attributes["InActive"] != null)
                {
                    objectTable.InActive = GetAttributeBoolValue(entity.Attributes["InActive"]);
                }
                else
                {
                    objectTable.InActive = false;
                }
                if (entity.Attributes["NoObjectTable"] != null)
                {
                    objectTable.NoObjectTable = GetAttributeBoolValue(entity.Attributes["NoObjectTable"]);
                }
                else
                {
                    objectTable.NoObjectTable = false;
                }
                if (entity.Attributes["SearchFields"] != null)
                {
                    objectTable.SearchFields = GetAttributeStringValue(entity.Attributes["SearchFields"]);

                }
            }
            return objectTable;

        }

        public ObjectFieldsViewModel BuildObjectField(XmlNode fieldNode, ObjectTableViewModel table)
        {
            ObjectFieldsViewModel field = new ObjectFieldsViewModel(table, false);
            field.Id = GetAttributeStringValue(fieldNode.Attributes["Id"]);
            field.FieldName = GetAttributeStringValue(fieldNode.Attributes["FieldName"]);
            field.DefaultText = GetAttributeStringValue(fieldNode.Attributes["DefaultText"]);
            field.DefaultValue = GetAttributeStringValue(fieldNode.Attributes["DefaultValue"]);
            field.DigitsAfterPoint = GetAttributeNullableIntegerValue(fieldNode.Attributes["DigitsAfterPoint"]);
            field.NumberOfDigits = GetAttributeNullableIntegerValue(fieldNode.Attributes["NumberOfDigits"]);
            field.FieldDataType = GetAttributeStringValue(fieldNode.Attributes["FieldDataType"]);
            field.ForeignEntity = GetAttributeStringValue(fieldNode.Attributes["ForeignEntity"]);
            field.LocalDefaultText = GetAttributeStringValue(fieldNode.Attributes["LocalDefaultText"]);
            field.DescriptionLocalDefaultText = GetAttributeStringValue(fieldNode.Attributes["DescriptionLocalDefaultText"]);
            field.DescriptionDefaultText = GetAttributeStringValue(fieldNode.Attributes["DescriptionDefaultText"]);
            field.InActive = GetAttributeBoolValue(fieldNode.Attributes["InActive"]);
            field.IsDBField = GetAttributeBoolValue(fieldNode.Attributes["IsDBField"]);
            field.IsForeignKey = GetAttributeBoolValue(fieldNode.Attributes["IsForeignKey"]);
            field.IsDTOField = GetAttributeBoolValue(fieldNode.Attributes["IsDTOField"]);
            field.IsPrimaryKey = GetAttributeBoolValue(fieldNode.Attributes["IsPrimaryKey"]);
            field.LookUpTableName = GetAttributeStringValue(fieldNode.Attributes["LookUpTableName"]);          
            field.NavigationPropertyName = GetAttributeStringValue(fieldNode.Attributes["NavigationPropertyName"]);
            field.NoObjectField = GetAttributeBoolValue(fieldNode.Attributes["NoMetaDataField"]);
            field.IsViewField = GetAttributeBoolValue(fieldNode.Attributes["IsViewField"]);
            field.IncludeInSearchField = GetAttributeBoolValue(fieldNode.Attributes["IncludeInSearchField"]);
            field.IsChecked = GetAttributeBoolValue(fieldNode.Attributes["IsChecked"]);
            field.IsDeleted = GetAttributeBoolValue(fieldNode.Attributes["IsDeleted"]);
            field.IsNew = GetAttributeBoolValue(fieldNode.Attributes["IsNew"]);
            if (string.IsNullOrEmpty(field.Id))
            {
                if (field.IsNew == false)
                {
                    field.IsNew = true;
                }
            }
            if (fieldNode.Attributes["UniqueField"] != null)
            {
                field.UniqueField = GetAttributeBoolValue(fieldNode.Attributes["UniqueField"]);
            }
            else
            {
                field.UniqueField = null;
            }
            if (fieldNode.Attributes["HasIndex"] != null)
            {
                field.HasIndex = GetAttributeBoolValue(fieldNode.Attributes["HasIndex"]);
            }
            else
            {
                field.HasIndex = null;
            }
            if (fieldNode.Attributes["IsRequired"] != null)
            {
                field.IsRequired = GetAttributeBoolValue(fieldNode.Attributes["IsRequired"]);
            }
            else
            {
                field.IsRequired = null;
            }
            if (fieldNode.Attributes["IsNullable"] != null)
            {
                field.IsNullable = GetAttributeBoolValue(fieldNode.Attributes["IsNullable"]);
            }
            else
            {
                field.IsNullable = null;
            }
            if (fieldNode.Attributes["IsMaxLength"] != null)
            {
                field.IsMaxLength = GetAttributeBoolValue(fieldNode.Attributes["IsMaxLength"]);
            }
            else
            {
                field.IsMaxLength = null;
            }
            if (fieldNode.Attributes["MaxLength"] != null)
            {
                field.MaxLength = GetAttributeIntegerValue(fieldNode.Attributes["MaxLength"]);
            }
            else
            {
                field.MaxLength = null;
            }
            if (fieldNode.Attributes["MinLength"] != null)
            {
                field.MinLength = GetAttributeIntegerValue(fieldNode.Attributes["MinLength"]);
            }
            else
            {
                field.MinLength = null;
            }
            if (fieldNode.Attributes["OldFieldDataType"] != null)
            {
                field.OldFieldDataType = GetAttributeStringValue(fieldNode.Attributes["OldFieldDataType"]);
            }
            else
            {
                field.OldFieldDataType = GetAttributeStringValue(fieldNode.Attributes["FieldDataType"]);
            }
            if (fieldNode.Attributes["OldFieldName"] != null)
            {
                field.OldFieldName = GetAttributeStringValue(fieldNode.Attributes["OldFieldName"]);
            }
            else
            {
                field.OldFieldName = GetAttributeStringValue(fieldNode.Attributes["FieldName"]);
            }
            if (fieldNode.Attributes["OldIsPrimaryKey"] != null)
            {
                field.OldIsPrimaryKey = GetAttributeBoolValue(fieldNode.Attributes["OldIsPrimaryKey"]);
            }
            else
            {
                field.OldIsPrimaryKey = GetAttributeBoolValue(fieldNode.Attributes["IsPrimaryKey"]);
            }
            if (fieldNode.Attributes["OldIsNullable"] != null)
            {
                field.OldIsNullable = GetAttributeBoolValue(fieldNode.Attributes["OldIsNullable"]);
            }
            else
            {
                field.OldIsNullable = GetAttributeBoolValue(fieldNode.Attributes["IsNullable"]);
            }
            return field;
        }
 
        public bool GetAttributeBoolValue(XmlAttribute att)
        {
            bool result = false;
            if (att != null)
            {
                if (!string.IsNullOrEmpty(att.Value))
                {
                    result = bool.Parse(att.Value);
                }
            }

            return result;
        }

        public int GetAttributeIntegerValue(XmlAttribute att)
        {
            int result = 0;
            if (att != null)
            {
                if (!string.IsNullOrEmpty(att.Value))
                {
                    result = int.Parse(att.Value);
                }
            }

            return result;
        }

        public int? GetAttributeNullableIntegerValue(XmlAttribute att)
        {
            int? result = null;
            if (att != null)
            {
                if (!string.IsNullOrEmpty(att.Value))
                {
                    result = int.Parse(att.Value);
                }
            }

            return result;
        }
         
        public string GetAttributeStringValue(XmlAttribute att)
        {
            string result = null;
            if (att != null)
            {
                if (!string.IsNullOrEmpty(att.Value))
                {
                    if (att.Value != null)
                    {
                        result = att.Value.Trim('"');
                    }
                }
            }
            return result;
        }

    }
}
