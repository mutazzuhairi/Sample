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
 
    public partial class BusinessAbsenceTypeView : BaseEntityView<long>
    {
         public long BusinessId { get; set; }
         public long AbsenceTypeId { get; set; }
         public virtual BusinessView Business { get; set; }
         public virtual AbsenceTypeView AbsenceType { get; set; }
         public virtual ICollection<AbsenceView> AbsenceBusinessAbsenceType { get; set; }
 
    }
}