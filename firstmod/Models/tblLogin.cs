//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace firstmod.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblLogin
    {
        public tblLogin()
        {
            this.Projects = new HashSet<Project>();
            this.TimeSheetDetails = new HashSet<TimeSheetDetail>();
        }
    
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<TimeSheetDetail> TimeSheetDetails { get; set; }
    }
}