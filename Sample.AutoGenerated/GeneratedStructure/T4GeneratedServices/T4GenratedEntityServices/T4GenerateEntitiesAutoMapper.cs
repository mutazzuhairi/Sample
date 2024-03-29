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
    public class T4GenerateEntitiesAutoMapper : IT4GeneratedEntitiesAutoMapper
    {
        public void Generate(IEnumerable<string> entityFiles, Type profile, string folderName)
        {
            var fileName = AutoGeneratedConstatnts.FileConvention.AUTO_MAPPER;
            T4GeneratedArguments t4GeneratedArguments = new T4GeneratedArguments()
            {
                EntityFiles = entityFiles,
                GeneratedClassName = AutoGeneratedConstatnts.FileClassName.AUTO_MAPPER,
                Profile = profile,
                IsAlwaysGenerated = true,
                Class = typeof(EntitiesAutoMapperTemplate),
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
