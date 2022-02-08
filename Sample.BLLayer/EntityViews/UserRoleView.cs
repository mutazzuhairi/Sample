using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sample.BLLayer.BLUtilities.Abstractions;

namespace Sample.BLLayer.EntityViews
{
 
    public class UserRoleView : BaseEntityView<long>
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }

    }
}