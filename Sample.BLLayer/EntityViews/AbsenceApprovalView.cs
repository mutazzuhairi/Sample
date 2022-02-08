using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityViews
{
 
    public class AbsenceApprovalView : BaseEntityView<long>
    {
         public long AbsenceId { get; set; }
         public bool Approved { get; set; }
         public long ManagerId { get; set; }
         public virtual AbsenceView Absence { get; set; }
         public virtual UserView User { get; set; }
 
    }
}