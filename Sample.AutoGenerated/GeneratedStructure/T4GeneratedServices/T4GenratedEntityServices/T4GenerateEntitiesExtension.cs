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
    public class T4GenerateEntitiesExtension : IT4GeneratedEntities
    {
        public void Generate(IEnumerable<string> entityFiles, string folderName)
        {
            var fileName = AutoGeneratedConstatnts.FileConvention.ENTITY_EXTENSIONS;
            T4GeneratedArguments t4GeneratedArguments = new T4GeneratedArguments()
            {
                EntityFiles = entityFiles,
                GeneratedClassName = AutoGeneratedConstatnts.FileClassName.ENTITY_EXTENSIONS,
                IsAlwaysGenerated = true,
                Class = typeof(EntitiesExtensionTemplate),
                NameSpace = AutoGeneratedConstatnts.Projects.BL_PROJECT_NAME + AutoGeneratedConstatnts.Other.DOT +
                            folderName.Replace(AutoGeneratedConstatnts.Other.PATH_DASH, AutoGeneratedConstatnts.Other.DOT),
                Path = Path.Combine(AutoGeneratedConstatnts.Projects.BL_PROJECT_NAME,
                            folderName,
                            fileName),
            };
            T4GeneratedMainService.AutoGenerateCode(t4GeneratedArguments);
        }
    }
}