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
    
    public partial class TimePeriod
    {
        public int Id { get; set; }
        public System.DateTime Start { get; set; }
        public System.DateTime Stop { get; set; }
        public short Interval { get; set; }
    
        public virtual Activity Activity { get; set; }
    }
}
