﻿
using Sample.AutoGenerated.GeneratedUtilities.SystemConstants;
using System.Collections.Generic;

namespace Sample.Meatadata.MetadataUtilities.SystemConstants
{
    public class MetadataConstatnts
    {
        public static class Types{
            public static readonly List<string> META_DATA_TYPES_List = new List<string>() { AutoGeneratedConstatnts.MetaDataTypes.TEXT,
                                                                                            AutoGeneratedConstatnts.MetaDataTypes.N_TEXT,
                                                                                            AutoGeneratedConstatnts.MetaDataTypes.LONG,
                                                                                            AutoGeneratedConstatnts.MetaDataTypes.INTEGER,
                                                                                            AutoGeneratedConstatnts.MetaDataTypes.DECIMAL,
                                                                                            AutoGeneratedConstatnts.MetaDataTypes.DOUBLE,
                                                                                            AutoGeneratedConstatnts.MetaDataTypes.BOOLEAN,
                                                                                            AutoGeneratedConstatnts.MetaDataTypes.DATETIME,
                                                                                            AutoGeneratedConstatnts.MetaDataTypes.DATETIMEOFFSET,
                                                                                            AutoGeneratedConstatnts.MetaDataTypes.BYTE,
                                                                                            AutoGeneratedConstatnts.MetaDataTypes.LOOKUP };

            public static readonly List<string> BASE_ID_TYPES_LIST = new List<string>() { AutoGeneratedConstatnts.MetaDataTypes.TEXT,
                                                                                          AutoGeneratedConstatnts.MetaDataTypes.LONG,
                                                                                          AutoGeneratedConstatnts.MetaDataTypes.INTEGER };

            public static readonly List<string> BASE_TYPES_LIST = new List<string>() { AutoGeneratedConstatnts.BaseTypes.BASEENTITY,
                                                                                       AutoGeneratedConstatnts.BaseTypes.IBASEENTITY };
        }

    }
}
