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
 
    public partial class BusinessView : BaseEntityView<long>
    {
         public string Name { get; set; }
         public virtual ICollection<BusinessAbsenceTypeView> BusinessAbsenceTypeBusiness { get; set; }
         public virtual ICollection<UserView> UserBusiness { get; set; }
 
    }
}