using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityViews
{
 
    public class BusinessAbsenceTypeView : BaseEntityView<long>
    {
         public long BusinessId { get; set; }
         public long AbsenceTypeId { get; set; }
         public virtual BusinessView Business { get; set; }
         public virtual AbsenceTypeView AbsenceType { get; set; }
         public virtual ICollection<AbsenceView> AbsenceBusinessAbsenceType { get; set; }
 
    }
}