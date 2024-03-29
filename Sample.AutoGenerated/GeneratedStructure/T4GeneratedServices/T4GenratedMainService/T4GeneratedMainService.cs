﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using AutoMapper;
using Sample.DataLayer.DataUtilities.DBContext;
using Sample.DataLayer.DataUtilities.Abstractions;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;
using Sample.Web.WebUtilities.Interfaces;
using Sample.AutoGenerated.HelperClasses;
using Sample.AutoGenerated.HelperClasses.Interfaces;
using Sample.AutoGenerated.GeneratedUtilities.HelperClasses;
using Sample.AutoGenerated.GeneratedStructure.T4GeneratedServices.T4GenratedEntityServices;
using Sample.AutoGenerated.GeneratedUtilities.SystemConstants;
using System.Xml.Linq;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;
using Sample.AutoGenerated.GeneratedStructure.ClassesGeneratedStructure;
using Sample.BLLayer.Extends.ExtendServices.Interfaces;

namespace Sample.AutoGenerated.GeneratedStructure.T4GeneratedServices.T4GenratedMainService
{
    public class T4GeneratedMainService
    {
        private Assembly assembly { set; get; }
        private T4GenerateEntity entity { set; get; }
        private T4GenerateEntityDTO entityDTO { set; get; }
        private T4GenerateEntityView eEntityView { set; get; }
        private T4GenerateEntityPartial entityPartial { set; get; }
        private T4GenerateEntityDTOPartial entityDTOPartial { set; get; }
        private T4GenerateEntityViewPartial entityViewPartial { set; get; }
        private T4GenerateEntityIQueryService entityIQueryService { set; get; }
        private T4GenerateEntityEntityQueryService entityQueryService { set; get; }
        private T4GenerateEntityIRepositry entityIRepositry { set; get; }
        private T4GenerateEntityRepositry entityRepositry { set; get; }
        private T4GenerateEntityConfiguration entityConfiguration { set; get; }
        private T4GenerateEntityConfigurationPartial entityConfigurationPartial { set; get; }
        private T4GenerateEntityIUpdateService entityIUpdateService { set; get; }
        private T4GenerateEntityUpdateService entityUpdateService { set; get; }
        private T4GenerateEntityMapping entityMapping { set; get; }
        private T4GenerateEntityMappingPartial entityMappingPartial { set; get; }
        private T4GenerateEntityIValidating entityIValidating { set; get; }
        private T4GenerateEntityValidating entityValidating { set; get; }
        private T4GenerateEntityControllerDTO entityControllerDTO { set; get; }
        private T4GenerateEntityControllerView entityControllerView { set; get; }
        private T4GenerateEntityIMapping entityIMapping { set; get; }
        private T4GenerateEntitiesContext entitiesContext { set; get; }
        private T4GenerateEntitiesExtension entitiesExtension { set; get; }
        private T4GenerateEntitiesAutoMapper entitiesAutoMapper { set; get; }
        private T4GenerateEntityTypeScriptDTOModel entityTypeScriptDTOModel { set; get; }
        private T4GenerateEntityTypeScriptViewModel entityTypeScriptViewModel { set; get; }
        private T4GenerateEntityTypeScriptDTOService entityTypeScriptDTOService { set; get; }
        private T4GenerateEntityTypeScriptViewService entityTypeScriptViewService { set; get; }
        private T4GenerateEntityAutoMapperConfiguration entityAutoMapperConfiguration { set; get; }

        public T4GeneratedMainService()
        {
            InitializeProperties();
        }

        public void ExecuteAutoGenerated(IEnumerable<string> files = null)
        {
            var entityFiles = files != null ? files : Directory.EnumerateFiles("../../../../Sample.BLLayer/EntityFiles", "*.fxml");
            foreach (string file in entityFiles)
            {
                XDocument fxmlFile = null;
                try
                {
                    fxmlFile = XDocument.Load(file);
                }
                catch (Exception)
                {
                    continue;
                }
                var tableName = fxmlFile.Root.Attribute("TableName").Value.Replace("\"", string.Empty);
                var tableAttributes = fxmlFile.Root.Attributes();
                var isTableInActive = bool.Parse(tableAttributes.Where(s => s.Name == "InActive").FirstOrDefault().Value);
                if (isTableInActive)
                {
                    continue;
                }
                var tableProperties = fxmlFile.Root.Elements("field");
                var primaryKeys = tableProperties.Where(s=> bool.Parse(s.Attribute("IsPrimaryKey").Value) == true).ToList().Select(S=>S.Attribute("FieldName").Value.Replace("\"", string.Empty)).ToList();
                TableInfo tableInfo = new TableInfo()
                {
                    TableAttributes = tableAttributes,
                    BaseType = tableAttributes.Where(s => s.Name == "BaseType").FirstOrDefault().Value.Replace("\"", string.Empty),
                    IdType = tableAttributes.Where(s => s.Name == "BaseIdType").FirstOrDefault().Value.Replace("\"", string.Empty).ConverteCSharpGeniricTypeToCamelCase(),
                    IdTypeSciptType = tableAttributes.Where(s => s.Name == "BaseIdType").FirstOrDefault().Value.Replace("\"", string.Empty).ConverteTypeScriptGeniricTypeToCamelCase(),
                    IsBaseIdPrimaryKey = bool.Parse(tableAttributes.Where(s => s.Name == "IsBaseIdPrimaryKey").FirstOrDefault().Value),
                    Name = tableName,
                    EntityFiles = entityFiles ?? default,
                    Properties = tableProperties ?? default,
                    Context = typeof(MainContext),
                    Profile = typeof(Profile),
                    CommonServices = typeof(ICommonServices),
                    ServiceBuildException = typeof(IServiceBuildException),
                    ICacheProvider = typeof(ICacheProvider),
                    Mapper = typeof(IMapper),
                    PaginationHelperServices = typeof(IPaginationHelper),
                    UriService = typeof(IUriService),
                    SystemServiceProvider = typeof(ISystemServiceProvider),
                    ApiExceptionBuilder = typeof(IApiExceptionBuilder)
                };
                entity.Generate(tableName, tableInfo, Path.Combine(AutoGeneratedConstatnts.Folders.DATA, AutoGeneratedConstatnts.Folders.MODELS, AutoGeneratedConstatnts.Folders.ENTITIES));
                entityPartial.Generate(tableName, tableInfo, Path.Combine(AutoGeneratedConstatnts.Folders.DATA, AutoGeneratedConstatnts.Folders.MODELS, AutoGeneratedConstatnts.Folders.ENTITIES));
                entityConfigurationPartial.Generate(tableName, tableInfo, Path.Combine(AutoGeneratedConstatnts.Folders.DATA, AutoGeneratedConstatnts.Folders.CONFIGURATION));
                entityConfiguration.Generate(tableName, tableInfo, Path.Combine(AutoGeneratedConstatnts.Folders.DATA, AutoGeneratedConstatnts.Folders.CONFIGURATION));
                entityIRepositry.Generate(tableName, tableInfo, Path.Combine(AutoGeneratedConstatnts.Folders.DATA, AutoGeneratedConstatnts.Folders.REPOSITRIES, AutoGeneratedConstatnts.Folders.INTERFACES));
                entityRepositry.Generate(tableName, tableInfo, Path.Combine(AutoGeneratedConstatnts.Folders.DATA, AutoGeneratedConstatnts.Folders.REPOSITRIES));
                entityDTO.Generate(tableName, tableInfo, AutoGeneratedConstatnts.Folders.ENTITY_DTOS);
                entityDTOPartial.Generate(tableName, tableInfo, AutoGeneratedConstatnts.Folders.ENTITY_DTOS);
                eEntityView.Generate(tableName, tableInfo, AutoGeneratedConstatnts.Folders.ENTITY_VIEWS);
                entityViewPartial.Generate(tableName, tableInfo, AutoGeneratedConstatnts.Folders.ENTITY_VIEWS);
                entityIQueryService.Generate(tableName, tableInfo, Path.Combine(AutoGeneratedConstatnts.Folders.QUERY_SERVICES, AutoGeneratedConstatnts.Folders.INTERFACES));
                entityQueryService.Generate(tableName, tableInfo, AutoGeneratedConstatnts.Folders.QUERY_SERVICES);
                entityIMapping.Generate(tableName, tableInfo, Path.Combine(AutoGeneratedConstatnts.Folders.MAPPING, AutoGeneratedConstatnts.Folders.INTERFACES));
                entityMapping.Generate(tableName, tableInfo, AutoGeneratedConstatnts.Folders.MAPPING);
                entityMappingPartial.Generate(tableName, tableInfo, AutoGeneratedConstatnts.Folders.MAPPING);
                entityIValidating.Generate(tableName, tableInfo, Path.Combine(AutoGeneratedConstatnts.Folders.VALIDATING, AutoGeneratedConstatnts.Folders.INTERFACES));
                entityValidating.Generate(tableName, tableInfo, AutoGeneratedConstatnts.Folders.VALIDATING);
                entityIUpdateService.Generate(tableName, tableInfo, Path.Combine(AutoGeneratedConstatnts.Folders.UPDATE_SERVICES, AutoGeneratedConstatnts.Folders.INTERFACES));
                entityUpdateService.Generate(tableName, tableInfo, AutoGeneratedConstatnts.Folders.UPDATE_SERVICES);
                entityAutoMapperConfiguration.Generate(tableName, tableInfo, Path.Combine(AutoGeneratedConstatnts.Folders.BL_UTILITIES, AutoGeneratedConstatnts.Folders.CONFIGURATION, "AutoMapper", "Entities"));
                //entityTypeScriptDTOModel.Generate(tableName, tableInfo, "ClientApp/src/app/shared/models/generated/dto");
                //entityTypeScriptViewModel.Generate(tableName, tableInfo, "ClientApp/src/app/shared/models/generated/view");
                //entityTypeScriptDTOService.Generate(tableName, tableInfo, "ClientApp/src/app/shared/api/basics/dto");
                //entityTypeScriptViewService.Generate(tableName, tableInfo, "ClientApp/src/app/shared/api/basics/view");
                var isTypeHasExcludeDTOController = bool.Parse(tableAttributes.Where(s => s.Name == "NoDTOController").FirstOrDefault().Value);
                if (!isTypeHasExcludeDTOController)
                {
                    entityControllerDTO.Generate(tableName, tableInfo, Path.Combine(AutoGeneratedConstatnts.Folders.CONTROLLERS, AutoGeneratedConstatnts.Folders.BASICS, AutoGeneratedConstatnts.Folders.DTOS));
                }
                var isTypeHasExcludeViewController = bool.Parse(tableAttributes.Where(s => s.Name == "NoViewController").FirstOrDefault().Value);
                if (!isTypeHasExcludeViewController)
                {
                    entityControllerView.Generate(tableName, tableInfo, Path.Combine(AutoGeneratedConstatnts.Folders.CONTROLLERS, AutoGeneratedConstatnts.Folders.BASICS, AutoGeneratedConstatnts.Folders.VIEWS));
                }
            }
            entitiesContext.Generate(entityFiles, Path.Combine(AutoGeneratedConstatnts.Folders.DATAUTILITIES, AutoGeneratedConstatnts.Folders.DBCONTEXT));
            entitiesExtension.Generate(entityFiles, Path.Combine(AutoGeneratedConstatnts.Folders.BL_UTILITIES, AutoGeneratedConstatnts.Folders.EXTENSIONS));
            entitiesAutoMapper.Generate(entityFiles, typeof(Profile), Path.Combine(AutoGeneratedConstatnts.Folders.BL_UTILITIES, AutoGeneratedConstatnts.Folders.CONFIGURATION, "AutoMapper", "Configuration", AutoGeneratedConstatnts.Folders.GENERATED));
        }

        private void InitializeProperties()
        {
            assembly = Assembly.Load(AutoGeneratedConstatnts.Projects.DATA_PROJECT_NAME);
            entity = new T4GenerateEntity();
            entityDTO = new T4GenerateEntityDTO();
            eEntityView = new T4GenerateEntityView();
            entityPartial = new T4GenerateEntityPartial();
            entityDTOPartial = new T4GenerateEntityDTOPartial();
            entityViewPartial = new T4GenerateEntityViewPartial();
            entityIQueryService = new T4GenerateEntityIQueryService();
            entityQueryService = new T4GenerateEntityEntityQueryService();
            entityIRepositry = new T4GenerateEntityIRepositry();
            entityRepositry = new T4GenerateEntityRepositry();
            entityConfiguration = new T4GenerateEntityConfiguration();
            entityConfigurationPartial = new T4GenerateEntityConfigurationPartial();
            entityIUpdateService = new T4GenerateEntityIUpdateService();
            entityUpdateService = new T4GenerateEntityUpdateService();
            entityMapping = new T4GenerateEntityMapping();
            entityMappingPartial = new T4GenerateEntityMappingPartial();
            entityIValidating = new T4GenerateEntityIValidating();
            entityValidating = new T4GenerateEntityValidating();
            entityControllerDTO = new T4GenerateEntityControllerDTO();
            entityControllerView = new T4GenerateEntityControllerView();
            entityIMapping = new T4GenerateEntityIMapping();
            entitiesContext = new T4GenerateEntitiesContext();
            entitiesExtension = new T4GenerateEntitiesExtension();
            entitiesAutoMapper = new T4GenerateEntitiesAutoMapper();
            entityTypeScriptDTOModel = new T4GenerateEntityTypeScriptDTOModel();
            entityTypeScriptViewModel = new T4GenerateEntityTypeScriptViewModel();
            entityTypeScriptDTOService = new T4GenerateEntityTypeScriptDTOService();
            entityTypeScriptViewService = new T4GenerateEntityTypeScriptViewService();
            entityAutoMapperConfiguration = new T4GenerateEntityAutoMapperConfiguration();
        }
        public static void AutoGenerateCode(T4GeneratedArguments arguments)
        {
            ITextTemplate template = null;
            var solutionPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            solutionPath = solutionPath.Substring(0, solutionPath.LastIndexOf("\\Sample\\") + "\\Sample".Length);
            string fullPath = Path.Combine(solutionPath, arguments.Path);
            if (!arguments.IsAlwaysGenerated && File.Exists(fullPath))
                return;
            switch (arguments.Class.Name.ToLower())
            {
                case AutoGeneratedConstatnts.AutoGenerated.ENTITIES_CONTEXT_TEMPLATE:
                    {
                        template = (ITextTemplate)Activator.CreateInstance(arguments.Class, arguments.NameSpace, arguments.GeneratedClassName, arguments.EntityConfigurationConvention, arguments.EntityFiles);
                        break;
                    }
                case AutoGeneratedConstatnts.AutoGenerated.ENTITIES_EXTENSION_TEMPLATE:
                    {
                        template = (ITextTemplate)Activator.CreateInstance(arguments.Class, arguments.NameSpace, arguments.GeneratedClassName, arguments.EntityFiles);
                        break;
                    }
                case AutoGeneratedConstatnts.AutoGenerated.ENTITIES_AUTOMAPPER_TEMPLATE:
                    {
                        template = (ITextTemplate)Activator.CreateInstance(arguments.Class, arguments.NameSpace, arguments.GeneratedClassName, arguments.Profile, arguments.EntityFiles);
                        break;
                    }
                default:
                    {
                        template = (ITextTemplate)Activator.CreateInstance(arguments.Class, arguments.NameSpace, arguments.TableInfo);
                        break;
                    }
            }
            File.WriteAllText(fullPath, template.TransformText().RemoveGarbageLinesFromString());
        }
    }
}
