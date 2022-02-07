﻿using System;
using System.IO;
using Sample.AutoGenerated.GeneratedUtilities.SystemConstants;
using Sample.AutoGenerated.HelperClasses;
using Sample.AutoGenerated.GeneratedUtilities.HelperClasses;
using Sample.AutoGenerated.GeneratedStructure.T4GeneratedInterfaces;
using Sample.AutoGenerated.GeneratedStructure.ClassesGeneratedStructure;
using Sample.AutoGenerated.GeneratedStructure.T4GeneratedServices.T4GenratedMainService;

namespace Sample.AutoGenerated.GeneratedStructure.T4GeneratedServices.T4GenratedEntityServices
{
    public class T4GenerateEntityMapping : IT4GeneratedSingleEntity
    {
        public void Generate(string tableName, TableInfo tableInfo, string folderName)
        {
            var fileConvention = AutoGeneratedConstatnts.FileConvention.MAPPING_GENERATED;
            T4GeneratedArguments t4GeneratedArguments = new T4GeneratedArguments()
            {
                TableInfo = tableInfo,
                IsAlwaysGenerated = true,
                Class = typeof(EntitiesMappingTemplate),
                NameSpace = AutoGeneratedConstatnts.Projects.BL_PROJECT_NAME + AutoGeneratedConstatnts.Other.DOT +
                            folderName.Replace(AutoGeneratedConstatnts.Other.PATH_DASH, AutoGeneratedConstatnts.Other.DOT),
                Path = Path.Combine(AutoGeneratedConstatnts.Projects.BL_PROJECT_NAME,
                            folderName,
                            AutoGeneratedConstatnts.Folders.GENERATED,
                            tableName + fileConvention),
            };
            T4GeneratedMainService.AutoGenerateCode(t4GeneratedArguments);
        }
    }
}