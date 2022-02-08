using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityViews
{
 
    public class BusinessView : BaseEntityView<long>
    {
         public string Name { get; set; }
         public virtual ICollection<BusinessAbsenceTypeView> BusinessAbsenceTypeBusiness { get; set; }
         public virtual ICollection<UserView> UserBusiness { get; set; }
 
    }
}