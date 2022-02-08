using System;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.DBContext;
using Sample.DataLayer.DataUtilities.Abstractions;
using Sample.DataLayer.Data.Repositries.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.DataLayer.Data.Repositries
{
 
    public class BusinessAbsenceTypeRepositry : EntityRepository<BusinessAbsenceType>, IBusinessAbsenceTypeRepositry
    {
    
        private readonly MainContext _context;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;

        public BusinessAbsenceTypeRepositry(MainContext context, 
                                          Lazy<ISystemServiceProvider> systemServiceProvider) : 
                                          base(context, systemServiceProvider)
        {
            _context = context;
            _systemServiceProvider = systemServiceProvider;
        }
 
    }

}


