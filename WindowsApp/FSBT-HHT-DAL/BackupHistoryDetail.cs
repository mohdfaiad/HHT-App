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
    
    public partial class BackupHistoryDetail
    {
        public int BackupID { get; set; }
        public int BackupSeq { get; set; }
        public string BackupTable { get; set; }
        public string FileName { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
    
        public virtual BackupHistory BackupHistory { get; set; }
    }
}
