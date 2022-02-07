﻿using System;
using System.IO;
using System.Collections.Generic;
using Sample.AutoGenerated.GeneratedUtilities.SystemConstants;
using Sample.AutoGenerated.GeneratedUtilities.HelperClasses;
using Sample.AutoGenerated.GeneratedStructure.T4GeneratedInterfaces;
using Sample.AutoGenerated.GeneratedStructure.ClassesGeneratedStructure;
using Sample.AutoGenerated.GeneratedStructure.T4GeneratedServices.T4GenratedMainService;

namespace Sample.AutoGenerated.GeneratedStructure.T4GeneratedServices.T4GenratedEntityServices
{
    public class T4GenerateEntitiesContext : IT4GeneratedEntities
    {
        public void Generate(IEnumerable<string> entityFiles, string folderName)
        {
            var fileName = AutoGeneratedConstatnts.FileConvention.CONTEXT;
            T4GeneratedArguments t4GeneratedArguments = new T4GeneratedArguments()
            {
                EntityFiles = entityFiles,
                EntityConfigurationConvention = AutoGeneratedConstatnts.FileConvention.CONTEXT_CONFIGURATION,
                GeneratedClassName = AutoGeneratedConstatnts.FileClassName.CONTEXT,
                IsAlwaysGenerated = true,
                Class = typeof(EntitiesContextTemplate),
                NameSpace = AutoGeneratedConstatnts.Projects.DATA_PROJECT_NAME + AutoGeneratedConstatnts.Other.DOT +
                            folderName.Replace(AutoGeneratedConstatnts.Other.PATH_DASH, AutoGeneratedConstatnts.Other.DOT),
                Path = Path.Combine(AutoGeneratedConstatnts.Projects.DATA_PROJECT_NAME,
                            folderName,
                            fileName),
            };
            T4GeneratedMainService.AutoGenerateCode(t4GeneratedArguments);
        }
    }
}
