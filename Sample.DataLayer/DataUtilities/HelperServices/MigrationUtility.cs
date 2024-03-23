using System;
using System.IO;

namespace Sample.DataLayer.DataUtilities.HelperServices
{
    public static class MigrationUtility
    {
        /// <summary>
        /// Read a SQL script that is embedded into a resource.
        /// </summary>
        /// <param name="sqlFileName">The embedded SQL file name.</param>
        /// <returns>The content of the SQL file.</returns>
        public static string ReadSql(string sqlFileName)
        {
            try
            {
                var resourceName = Path.Combine(AppContext.BaseDirectory, $"SQL\\{sqlFileName}");
                return File.ReadAllText(resourceName);
            }
            catch (Exception)
            {
                throw new FileNotFoundException("Unable to find the SQL file from an embedded resource", sqlFileName);
            }
        }
    }
}
