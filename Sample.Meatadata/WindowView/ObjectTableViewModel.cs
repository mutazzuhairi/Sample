﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Linq;
using System.Text;
using System;
using Sample.Meatadata.MetadataUtilities.HelperClasses;
using Sample.Meatadata.XmlServices;
using Microsoft.Toolkit.Mvvm.Input;
using Sample.AutoGenerated.GeneratedUtilities.SystemConstants;
using System.Text.RegularExpressions;
using Sample.Meatadata.MetadataUtilities.SystemConstants;
using System.IO;
using Sample.AutoGenerated.GeneratedStructure.T4GeneratedServices.T4GenratedMainService;

namespace Sample.Meatadata.WindowView
{
    public class ObjectTableViewModel : PropertyChangedImplementation
    {
        const string Alphabet = AutoGeneratedConstatnts.Other.ALPHABET;
        public List<string> BaseTypesList { get; set; } = MetadataConstatnts.Types.BASE_TYPES_LIST;
        public List<string> BaseIdTypesList { get; set; } = MetadataConstatnts.Types.BASE_ID_TYPES_LIST;
        public List<string> BaseEntityProperties { get; set; } = AutoGeneratedConstatnts.SystemList.BASE_ENTITY_PROPERTIES;
        public List<string> IBaseEntityProperties { get; set; } = AutoGeneratedConstatnts.SystemList.IBASE_ENTITY_PROPERTIES;
        public ObservableCollection<ObjectFieldsViewModel> ObjectTableFieldsList { get; set; }
        public ObservableCollection<ObjectFieldsViewModel> TempObjectTableFieldsList { get; set; }
		public ObjectFieldsControl FieldsControl { get; set; } 
        private void ObjectFieldsFilterTextChangedMethod(string filter)
        {

            TempObjectTableFieldsList.Clear();
            var temp = ObjectTableFieldsList.Where(a => a.FieldName.ToLower().Contains(filter.ToLower())).ToList();
            foreach (var item in temp)
            {
                if (SelectedObjectField != null)
                {
                    SelectedObjectField.ErrorsVisibility = Visibility.Collapsed;
                }
                item.ErrorsVisibility = Visibility.Collapsed;
                TempObjectTableFieldsList.Add(item);
            }
        }
        public RelayCommand<string> ObjectFieldsFilterTextChanged
        {
            get { return new RelayCommand<string>(i => this.ObjectFieldsFilterTextChangedMethod(i)); }
            set { }
        }

        Visibility fieldsEditControlVisibility;
        public Visibility FieldsEditControlVisibility
        {
            get { return fieldsEditControlVisibility; }
            set { fieldsEditControlVisibility = value; FirePropertyChanged("FieldsEditControlVisibility"); }
        }

        public ObjectTableViewModel()
        {
            FieldsEditControlVisibility = Visibility.Collapsed;
            ObjectTableFieldsList = new ObservableCollection<ObjectFieldsViewModel>();
            TempObjectTableFieldsList = new ObservableCollection<ObjectFieldsViewModel>();
        }

        public void BuildObjectTableFieldsListt(List<ObjectFieldsViewModel> fields)
        {
            ObjectTableFieldsList.Clear();
            foreach (ObjectFieldsViewModel item in fields)
            {
                item.OpjectFieldLength = item.FieldName.Length;
                ObjectTableFieldsList.Add(item);
            } 
            FieldsEditControlVisibility = (ObjectTableFieldsList.Count == 0) ? Visibility.Collapsed : Visibility.Visible;
            this.SelectedObjectField = ObjectTableFieldsList.FirstOrDefault();
            TempObjectTableFieldsList.Clear();
            foreach (var item in ObjectTableFieldsList)
            {
                TempObjectTableFieldsList.Add(item);
            }
        } 

        public void UpdateObjectTableFieldsList(ObjectFieldsViewModel item)
        {
            ObjectTableFieldsList.Add(item);
            TempObjectTableFieldsList.Add(item);
            FirePropertyChanged("ObjectTableFieldsList");
            FirePropertyChanged("TempObjectTableFieldsList");
            FieldsEditControlVisibility = (ObjectTableFieldsList.Count == 0) ? Visibility.Collapsed : Visibility.Visible;
            this.SelectedObjectField = item;
        }

        public string BaseEntityProperStrings
        {
            get {
                if (BaseType == AutoGeneratedConstatnts.BaseTypes.BASEENTITY)
                {
                    return String.Join(", ", BaseEntityProperties.ToArray());
                }
                else
                {
                    return String.Join(", ", IBaseEntityProperties.ToArray());
                }
            }
        }

        public string Id { get; set; }

        string tableName;
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; IsDirty = true; FirePropertyChanged("TableName"); }
        }
        string indexGroup1;
        public string IndexGroup1
        {
            get { return indexGroup1; }
            set { indexGroup1 = value; IsDirty = true; FirePropertyChanged("IndexGroup1"); }
        }
        string indexGroup2;
        public string IndexGroup2
        {
            get { return indexGroup2; }
            set { indexGroup2 = value; IsDirty = true; FirePropertyChanged("IndexGroup2"); }
        }
        string indexGroup3;
        public string IndexGroup3
        {
            get { return indexGroup3; }
            set { indexGroup3 = value; IsDirty = true; FirePropertyChanged("IndexGroup3"); }
        }
        string indexGroup4;
        public string IndexGroup4
        {
            get { return indexGroup4; }
            set { indexGroup4 = value; IsDirty = true; FirePropertyChanged("IndexGroup4"); }
        }
        string indexGroup5;
        public string IndexGroup5
        {
            get { return indexGroup5; }
            set { indexGroup5 = value; IsDirty = true; FirePropertyChanged("IndexGroup5"); }
        }
        string baseIdType = AutoGeneratedConstatnts.MetaDataTypes.LONG;
        public string BaseIdType
        {
            get { return baseIdType; }
            set { baseIdType = value; IsDirty = true; FirePropertyChanged("BaseIdType"); FirePropertyChanged("BaseEntityProperStrings"); }
        }
        string baseType = AutoGeneratedConstatnts.BaseTypes.BASEENTITY;
        public string BaseType
        {
            get { return baseType; }
            set { baseType = value; IsDirty = true; FirePropertyChanged("BaseType"); }
        }
        bool isBaseIdPrimaryKey = true;
        public bool IsBaseIdPrimaryKey
        {
            get { return isBaseIdPrimaryKey; }
            set { isBaseIdPrimaryKey = value; IsDirty = true; FirePropertyChanged("IsBaseIdPrimaryKey"); }
        }
        string defaultText;
        public string DefaultText
        {
            get { return defaultText; }
            set { defaultText = value; FirePropertyChanged("DefaultText"); }
        }

        string localDefaultText;
        public string LocalDefaultText
        {
            get { return localDefaultText; }
            set { localDefaultText = value; FirePropertyChanged("LocalDefaultText"); }
        }

        bool noDTOController;
        public bool NoDTOController
        {
            get { return noDTOController; }
            set { noDTOController = value; FirePropertyChanged("NoDTOController"); }
        }
 
		bool noViewController;
        public bool NoViewController
        {
            get { return noViewController; }
            set { noViewController = value; FirePropertyChanged("NoViewController"); }
        }  

        string oldTableName;
        public string OldTableName
        {
            get { return oldTableName; }
            set { oldTableName = value; FirePropertyChanged("OldTableName"); }
        }
 
        string descriptionDefaultText;
        public string DescriptionDefaultText
        {
            get { return descriptionDefaultText; }
            set { descriptionDefaultText = value; FirePropertyChanged("DescriptionDefaultText"); }
        }

        string descriptionLocalDefaultText;
        public string DescriptionLocalDefaultText
        {
            get { return descriptionLocalDefaultText; }
            set { descriptionLocalDefaultText = value; FirePropertyChanged("DescriptionLocalDefaultText"); }
        }

        bool isDirty;
        public bool IsDirty
        {
            get { return isDirty; }
            set { isDirty = value; FirePropertyChanged("IsDirty"); }
        }

        bool isNew;
        public bool IsNew
        {
            get { return isNew; }
            set { isNew = value; FirePropertyChanged("IsNew"); }
        } 

        bool inActive;
        public bool InActive
        {
            get { return inActive; }
            set { inActive = value; FirePropertyChanged("InActive"); }
        }
        bool indexGroupUnique1;
        public bool IndexGroupUnique1
        {
            get { return indexGroupUnique1; }
            set { indexGroupUnique1 = value; FirePropertyChanged("IndexGroupUnique1"); }
        }
        bool indexGroupUnique2;
        public bool IndexGroupUnique2
        {
            get { return indexGroupUnique2; }
            set { indexGroupUnique2 = value; FirePropertyChanged("IndexGroupUnique2"); }
        }
        bool indexGroupUnique3;
        public bool IndexGroupUnique3
        {
            get { return indexGroupUnique3; }
            set { indexGroupUnique3 = value; FirePropertyChanged("IndexGroupUnique3"); }
        }
        bool indexGroupUnique4;
        public bool IndexGroupUnique4
        {
            get { return indexGroupUnique4; }
            set { indexGroupUnique4 = value; FirePropertyChanged("IndexGroupUnique4"); }
        }
        bool indexGroupUnique5;
        public bool IndexGroupUnique5
        {
            get { return indexGroupUnique5; }
            set { indexGroupUnique5 = value; FirePropertyChanged("IndexGroupUnique5"); }
        }
        bool noObjectTable;
        public bool NoObjectTable
        {
            get { return noObjectTable; }
            set { noObjectTable = value; FirePropertyChanged("NoObjectTable"); }
        }
 
        public int fieldLength;
        public int FieldLength
        {
            get
            {
                return fieldLength;
            }
            set
            {
                fieldLength = value;
                FirePropertyChanged("FieldLength");
            }
        }

        ObjectFieldsViewModel selectedObjectField;
        public ObjectFieldsViewModel SelectedObjectField
        {
            get { return selectedObjectField; }
            set
            {
                selectedObjectField = value;
                if (value != null)
                    FieldLength = value.OpjectFieldLength;
                FirePropertyChanged("SelectedObjectField");
            }
        }

        public RelayCommand<ObjectFieldsViewModel> MoveFieldUpCommand
        {
            get { return new RelayCommand<ObjectFieldsViewModel>(Tmodel => this.MoveFieldUpMethod(Tmodel)); }
        }

        private void MoveFieldUpMethod(ObjectFieldsViewModel targetModel)
        {
            MoveTabUpMethodForObjectTableFieldsList(TempObjectTableFieldsList, targetModel);
            MoveTabUpMethodForObjectTableFieldsList(ObjectTableFieldsList, targetModel);
        }

        private void MoveTabUpMethodForObjectTableFieldsList(ObservableCollection<ObjectFieldsViewModel> objectFieldsViewModels, ObjectFieldsViewModel targetModel)
        {
            int index = objectFieldsViewModels.IndexOf(targetModel);
            if (index > 0)
            {
                objectFieldsViewModels.Remove(targetModel);
                objectFieldsViewModels.Insert(index - 1, targetModel);
                SelectedObjectField = targetModel;
            }

        }

        public RelayCommand<ObjectFieldsViewModel> MoveFieldDownCommand
        {
            get { return new RelayCommand<ObjectFieldsViewModel>(Tmodel => this.MoveFieldDownMethod(Tmodel)); }
        }

        private void MoveFieldDownMethod(ObjectFieldsViewModel targetModel)
        {
            MoveFieldDownMethodForObjectTableFieldsList(TempObjectTableFieldsList, targetModel);
            MoveFieldDownMethodForObjectTableFieldsList(ObjectTableFieldsList, targetModel);
        }

        private void MoveFieldDownMethodForObjectTableFieldsList(ObservableCollection<ObjectFieldsViewModel> objectFieldsViewModels, ObjectFieldsViewModel targetModel)
        {
            int index = objectFieldsViewModels.IndexOf(targetModel);
            if (index < objectFieldsViewModels.Count - 1)
            {
                objectFieldsViewModels.Remove(targetModel);
                objectFieldsViewModels.Insert(index + 1, targetModel);
                SelectedObjectField = targetModel;
            }

        }

        public RelayCommand<ObjectFieldsViewModel> RemoveFieldCommand
        {
            get { return new RelayCommand<ObjectFieldsViewModel>(m => this.RemoveFieldMethod(m)); }
        }

        public void RemoveFieldMethod(ObjectFieldsViewModel selected)
        {
            if (selected != null)
            {
                ObjectTableFieldsList.Where(a => a.FieldName == selected.FieldName).FirstOrDefault().IsDeleted = true;
                TempObjectTableFieldsList.Where(a => a.FieldName == selected.FieldName).FirstOrDefault().IsDeleted = true;
                int selectedIndex = ObjectTableFieldsList.IndexOf(selected);
                if(selectedIndex != 0)
                {
                    selectedIndex -= 1;
                }
                ObjectTableFieldsList.Remove(selected);
                TempObjectTableFieldsList.Remove(selected);
                if (ObjectTableFieldsList.Count > 0)
                    this.SelectedObjectField = ObjectTableFieldsList[selectedIndex];
                FirePropertyChanged("ObjectTableFieldsList");
                FirePropertyChanged("TempObjectTableFieldsList");
                FieldsEditControlVisibility = (ObjectTableFieldsList.Count == 0) ? Visibility.Collapsed : Visibility.Visible;
            }
        }  

        public RelayCommand AddFieldCommand
        {
            get { return new RelayCommand(() => this.AddFieldMethod()); }
        }

        public Window NewWindow = new Window();
        private void AddFieldMethod()
        {
            ObjectFieldsViewModel model = new ObjectFieldsViewModel(this, true);
            FieldsControl = new ObjectFieldsControl();
            FieldsControl.DataContext = model;
            NewWindow = new Window();
            NewWindow.Content = FieldsControl;
            NewWindow.Show(); 
        }

        public RelayCommand OkBtnCommand
        {
            get { return new RelayCommand(() => this.OkBtnMethod()); }
        }

        Visibility errorsVisibility = Visibility.Collapsed;
        public Visibility ErrorsVisibility
        {
            get { return errorsVisibility; }
            set { errorsVisibility = value; FirePropertyChanged("ErrorsVisibility"); }
        }

        public string errorMessages;
        public string ErrorMessages
        {
            get
            {
                return errorMessages;
            }
            set
            {
                errorMessages = value;
                FirePropertyChanged("ErrorMessages");
            }
        }    
        
        public List<ObjectFieldsViewModel> CheckedObjectFields = new List<ObjectFieldsViewModel>();

        private void OkBtnMethod()
        {
            SaveChanges();
        }

        public bool SaveChanges()
        {
            bool succeeded = false;
            try
            {
                ErrorsVisibility = Visibility.Collapsed;
                ErrorMessages = string.Empty;
                this.ValidateObjectTable();
                if (ObjectTableFieldsList != null)
                {
                    foreach (var item in ObjectTableFieldsList.GroupBy(p => p.FieldName).Select(g => g.First()))
                    {
                        this.ValidateObjectField(item); 
					}
                }
                else
                {
                    ObjectTableFieldsList = new ObservableCollection<ObjectFieldsViewModel>();
                }
            
                if (ErrorMessages == "")
                {
                    succeeded = true;
                    XmlGenerator.GenerateXmlFileFromTool(this);
                    ApplyAutoGenerateMessageBox();
                }
                else
                {
                    ErrorsVisibility = Visibility.Visible;
                }
            }

            catch (Exception ex)
            {
                string error = ex.Message + "\n" + ex.StackTrace != null ? ex.StackTrace : "";
                if (ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message))
                {
                    error += "\n" + ex.InnerException.Message;

                    if (ex.InnerException.StackTrace != null)
                    {
                        error += "\n" + ex.InnerException.StackTrace != null ? ex.InnerException.StackTrace : "";
                    }
                }
                MessageBox.Show(error);
            }
            return succeeded;
        }

        private void ApplyAutoGenerateMessageBox()
        {
            var entityFiles = Directory.EnumerateFiles("../../Sample.BLLayer/EntityFiles", "*.fxml");

            MessageBoxResult result = MessageBox.Show("Do you want to apply 'Auto Generate' or will you apply it later?\n*Recommended to be applied now*", "Auto Generate", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                new T4GeneratedMainService().ExecuteAutoGenerated(entityFiles);
                Environment.Exit(0);
            }
            else
            {
                if (result != MessageBoxResult.Cancel)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void ValidateObjectField(ObjectFieldsViewModel item)
        {
            StringBuilder str = new StringBuilder();
            if (string.IsNullOrEmpty(item.FieldName))
            {
                str.AppendLine("Field Name is Required.");
            }
            else if (!Alphabet.Any(c => char.ToLower(c) == char.ToLower(item.FieldName[0])))
            {
                str.AppendLine("Field Name couldn't start with number or speial Char.");
            }
            else if (BaseEntityProperties.Any(s => s.Equals(item.FieldName)))
            {
                str.AppendLine("Field Name already exist in Base Type Properties");
            }
            else if (ObjectTableFieldsList.Where(s=>s.FieldName == item.FieldName).ToList().Count > 1)
            {
                str.AppendLine("There are duplicate fields, one or more fields have the same Field Name.");
            }
            else if (ObjectTableFieldsList.Where(s => s.NavigationPropertyName == item.FieldName).ToList().Count > 1)
            {
                str.AppendLine("There are duplicate fields, one or more fields have the same Field Name in its Navigation Property Name.");
            }
            else if (item.FieldName.Length > 30)
            {
                str.AppendLine("FieldName Couldn't be more than 30 char.");
            }
            if (string.IsNullOrEmpty(item.FieldDataType))
            {
                str.AppendLine("Data Type is Required");
            }
            else
            {
                if (item.FieldDataType == "Text" || item.FieldDataType == "nText" || item.FieldDataType == "LookUp")
                {
                    if (item.IsMaxLength == false)
                    {
                        if (item.MinLength < 0)
                        {
                            str.AppendLine("Max Length is can't be less than zero.");
                        }
                        if (item.MaxLength == null)
                        {
                            str.AppendLine("Max Length is Required");
                        }
                        else if (item.MaxLength <= 0)
                        {
                            str.AppendLine("Max Length is can't be zero or less.");
                        }
                    }
                }
                if (item.FieldDataType == "Decimal" || item.FieldDataType == "Double" || item.FieldDataType == "SigDouble" || item.FieldDataType == "UnsDecimal")
                {
                    if (string.IsNullOrEmpty(item.NumberOfDigits?.ToString()))
                    {
                        str.AppendLine("Number Of Digits is Required.");
                    }
                    if (string.IsNullOrEmpty(item.DigitsAfterPoint?.ToString()))
                    {
                        str.AppendLine("Digits After Point is Required.");
                    }
                }
                if (item.FieldDataType == "LookUp")
                {
                    if (string.IsNullOrEmpty(item.LookUpTableName))
                    {
                        str.AppendLine("Look Up Table Name is Required.");
                    }
                    else
                    {
                        var entityFiles = Directory.EnumerateFiles("../../Sample.BLLayer/EntityFiles", "*.fxml");
                        bool isLookUpTableNameExist = false;
                        foreach (string file in entityFiles)
                        {
                            var fileNameWithExtension = file.Substring(file.IndexOf("\\") + "\\".Length);
                            var fileName = fileNameWithExtension.Substring(0, fileNameWithExtension.Length - ".fxml".Length);
                            if (fileName == item.LookUpTableName)
                            {
                                isLookUpTableNameExist = true;
                                break;
                            }
                        }
                        if (!isLookUpTableNameExist)
                        {
                            str.AppendLine("there's no Look Up entity with name " + item.LookUpTableName + ".");
                        }
                    }
                }
                if (item.FieldDataType != "LookUp")
                {
                    item.LookUpTableName = null;
                }
            } 
            if (item.IsForeignKey)
            {
                if (string.IsNullOrEmpty(item.ForeignEntity))
                {
                    str.AppendLine("Foreign Entity is Required.");
                }
                else
                {
                    var entityFiles = Directory.EnumerateFiles("../../Sample.BLLayer/EntityFiles", "*.fxml");
                    bool isForeignEntityExist = false;
                    foreach (string file in entityFiles)
                    {
                        var fileNameWithExtension = file.Substring(file.IndexOf("\\") + "\\".Length);
                        var fileName = fileNameWithExtension.Substring(0, fileNameWithExtension.Length - ".fxml".Length);
                        if (fileName == item.ForeignEntity)
                        {
                            isForeignEntityExist = true;
                            break;
                        }
                    }
                    if (!isForeignEntityExist)
                    {
                        str.AppendLine("there's no foreign entity with name " + item.ForeignEntity + ".");
                    }
                }
                if (string.IsNullOrEmpty(item.NavigationPropertyName))
                {
                    str.AppendLine("Navigation Property Name is Required.");
                }
                else if (item.NavigationPropertyName == item.FieldName)
                {
                    str.AppendLine("Navigation Property Name cannot be the same with Field Name");
                }
                else if (ObjectTableFieldsList.Where(s => s.FieldName == item.NavigationPropertyName).ToList().Count > 1)
                {
                    str.AppendLine("There are duplicate fields, one or more fields have the same Navigation Property Name in its Field Name.");
                }
                else if (ObjectTableFieldsList.Where(s => s.NavigationPropertyName == item.NavigationPropertyName && s.ForeignEntity != item.ForeignEntity).ToList().Count > 1)
                {
                    str.AppendLine("There are duplicate Navigation Property Name with different ForeignEntity, one or more fields Have the same Navigation Property Name (" + item.NavigationPropertyName + ").");
                }
            }
            if (!string.IsNullOrEmpty(ErrorMessages))
            {
                ErrorsVisibility = Visibility.Visible;
            }
            if (!string.IsNullOrEmpty(str.ToString()))
            {
                ErrorMessages = ErrorMessages + "\n" + item.FieldName + " Field Errors:\n" + str.ToString();
            } 
            FirePropertyChanged("ErrorMessages");
        } 

        private void ValidateObjectTable()
        {
            StringBuilder str = new StringBuilder();

            if (string.IsNullOrEmpty(TableName))
            {
                str.AppendLine("Table Name is required.");
            }
            else if (!Alphabet.Any(c => char.ToLower(c) == char.ToLower(TableName[0])))
            {
                str.AppendLine("Table Name couldn't start with number or speial Char.");
            }
            if (string.IsNullOrEmpty(BaseIdType))
            {
                str.AppendLine("Base Id Type is required.");
            }
            if (string.IsNullOrEmpty(BaseType))
            {
                str.AppendLine("Base Type is required.");
            }
            if (TableName.Length > 30)
            {
                str.AppendLine("Table Name Shouldn't be more than 30 char. length.");
            }
            ValidateIndexGroupS(str);
            ErrorMessages = str.ToString();
            if (!string.IsNullOrEmpty(ErrorMessages))
            {
                ErrorsVisibility = Visibility.Visible;
            }
            FirePropertyChanged("ErrorMessages");
        }

        private void ValidateIndexGroupS(StringBuilder str)
        {
            ValidateIndexGroup(IndexGroup1, IndexGroupUnique1, str);
            ValidateIndexGroup(IndexGroup2, IndexGroupUnique2, str);
            ValidateIndexGroup(IndexGroup3, IndexGroupUnique3, str);
            ValidateIndexGroup(IndexGroup4, IndexGroupUnique4, str);
            ValidateIndexGroup(IndexGroup5, IndexGroupUnique5, str);
        }

        private void ValidateIndexGroup(string indexGroup, bool indexGroupUnique, StringBuilder str)
        {
            if (!string.IsNullOrEmpty(indexGroup))
            {
                var fields = indexGroup.Split(",").Select(s => s.Trim()).ToList();
                if (fields.Count < 2)
                {
                    str.AppendLine("Index Group 1 should contain more than one field");
                }
                else
                {
                    if (fields.Any(s => !ObjectTableFieldsList.Any(j => j.FieldName == s)))
                    {
                        str.AppendLine("Index Group 1 contains one or more fields that are not in the entity");
                    }

                }

            }
            else if (indexGroupUnique)
            {
                str.AppendLine("Unable to add unique to Index Group 1 when it does not contain fields");
            }
        }

        public string SearchFields { get; set; }

    }   
}


