//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Embracer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity
    {
        public Activity()
        {
            this.TimePeriod = new HashSet<TimePeriod>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<TimePeriod> TimePeriod { get; set; }
    }
}
