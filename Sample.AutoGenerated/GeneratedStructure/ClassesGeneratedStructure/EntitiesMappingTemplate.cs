﻿using Sample.AutoGenerated.HelperClasses;
using Sample.AutoGenerated.HelperClasses.Interfaces;

namespace Sample.AutoGenerated.GeneratedStructure.ClassesGeneratedStructure
{
    public partial class EntitiesMappingTemplate : ITextTemplate
    {

        /// <summary>
        /// Entity's Namespace.
        /// </summary>
        public string NameSpace { get; }

        /// <summary>
        /// Table Data.
        /// </summary>
        public TableInfo Table { get; }

        /// <summary>
        /// Creates an Instance of TableEntityTemplate.
        /// </summary>
        /// <param name="nameSpace">Entity's Namespace.</param>
        /// <param name="table">Table Data.</param>
        public EntitiesMappingTemplate(string nameSpace, TableInfo table)
            => (NameSpace, Table) = (nameSpace, table);


    }
}