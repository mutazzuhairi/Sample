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
    public class T4GenerateEntityControllerDTO : IT4GeneratedSingleEntity
    {
        public void Generate(string tableName, TableInfo tableInfo, string folderName)
        {
            var fileConvention = AutoGeneratedConstatnts.FileConvention.CONTROLLER;
            T4GeneratedArguments t4GeneratedArguments = new T4GeneratedArguments()
            {
                TableInfo = tableInfo,
                IsAlwaysGenerated = false,
                Class = typeof(EntitiesControllerDTOTemplate),
                NameSpace = AutoGeneratedConstatnts.Projects.WEB_PROJECT_NAME + AutoGeneratedConstatnts.Other.DOT +
                            folderName.Replace(AutoGeneratedConstatnts.Other.PATH_DASH, AutoGeneratedConstatnts.Other.DOT),
                Path = Path.Combine(AutoGeneratedConstatnts.Projects.WEB_PROJECT_NAME,
                            folderName,
                            tableName + fileConvention),
            };
            T4GeneratedMainService.AutoGenerateCode(t4GeneratedArguments);
        }
    }
}
