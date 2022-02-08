using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityViews
{
 
    public class AbsenceTypeView : BaseEntityView<long>
    {
         public string Name { get; set; }
         public int? ValidAfterDays { get; set; }
         public virtual ICollection<BusinessAbsenceTypeView> BusinessAbsenceTypeAbsenceType { get; set; }
 
    }
}