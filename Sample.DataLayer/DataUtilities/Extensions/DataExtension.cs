using System.Linq;
using Sample.DataLayer.DataUtilities.HelperServices;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.DataLayer.DataUtilities.Extensions
{
    public static class DataExtension
    {
        public static void AddDataServicesToConfigure(this IServiceCollection services)
        {
            services.AddSingleton<ISystemServiceProvider, SystemServiceProvider>();
        }

        public static void AddRestrictToRelationshipOnDelete(this ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

        } 

    }
}
