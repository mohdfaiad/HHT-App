//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FSBT_HHT_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserGroupScreenMap
    {
        public UserGroupScreenMap()
        {
            this.UserGroupScreenPermissions = new HashSet<UserGroupScreenPermission>();
        }
    
        public string GroupID { get; set; }
        public string ScreenID { get; set; }
        public bool Visible { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    
        public virtual UserGroup UserGroup { get; set; }
        public virtual UserScreen UserScreen { get; set; }
        public virtual ICollection<UserGroupScreenPermission> UserGroupScreenPermissions { get; set; }
    }
}
