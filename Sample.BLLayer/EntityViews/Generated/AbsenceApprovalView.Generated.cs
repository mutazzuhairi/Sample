//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Sample Team Tools.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityViews
{
 
    public partial class AbsenceApprovalView : BaseEntityView<long>
    {
         public long AbsenceId { get; set; }
         public bool Approved { get; set; }
         public long ManagerId { get; set; }
         public virtual AbsenceView Absence { get; set; }
         public virtual UserView User { get; set; }
 
    }
}