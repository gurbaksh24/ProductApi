//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductWebApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarBrand { get; set; }
        public string CarColor { get; set; }
        public Nullable<decimal> CarPrice { get; set; }
        public string IsSaved { get; set; }
        public string IsBooked { get; set; }
    }
}
