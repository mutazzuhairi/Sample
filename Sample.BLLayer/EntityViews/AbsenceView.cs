using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityViews
{
 
    public class AbsenceView : BaseEntityView<long>
    {
         public long UserId { get; set; }
         public long BusinessAbsenceTypeId { get; set; }
         public DateTime FromDate { get; set; }
         public DateTime ToDate { get; set; }
         public string Status { get; set; }
         public virtual UserView User { get; set; }
         public virtual BusinessAbsenceTypeView BusinessAbsenceType { get; set; }
         public virtual ICollection<AbsenceApprovalView> AbsenceApprovalAbsence { get; set; }
 
    }
}