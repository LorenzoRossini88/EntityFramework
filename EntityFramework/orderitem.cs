//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderitem
    {
        public int orderid { get; set; }
        public string item { get; set; }
        public int qty { get; set; }
        public int price { get; set; }
    
        public virtual item item1 { get; set; }
        public virtual order order { get; set; }
    }
}
