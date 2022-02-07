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
    public class T4GenerateEntityTypeScriptViewService : IT4GeneratedSingleEntity
    {
        public void Generate(string tableName, TableInfo tableInfo, string clietPath)
        {
            var fileConvention = ".view.service.ts"; 

            T4GeneratedArguments t4GeneratedArguments = new T4GeneratedArguments()
            {
                TableInfo = tableInfo,
                IsAlwaysGenerated = false,
                Class = typeof(EntitiesTypeScriptViewServiceTemplate),
                Path = Path.Combine(AutoGeneratedConstatnts.Projects.UI_PROJECT_NAME,
                            clietPath,
                            tableName.SplitByCapital() + fileConvention),
            };
            T4GeneratedMainService.AutoGenerateCode(t4GeneratedArguments);
        }
    }
}