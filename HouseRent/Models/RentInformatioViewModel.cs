using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HouseRent.Models
{
    public class RentInformatioViewModel
    {
        //public int Id { get; set; }
        //[Required]
        //[DisplayName("Flat or Shop No")]
        //public string FlatOrShopNo { get; set; }
        //[DisplayName("Floor Name")]
        //public string FloorName { get; set; }
        //[Required]
        //[DisplayName("Type Name")]
        //public string TypeName { get; set; }
        //[Required]
        //public string Name { get; set; }
        //public double Rent { get; set; }
        //public double? Bill { get; set; }
        //public double? Due { get; set; }
        //public double? Amount { get; set; }
        //public DateTime? Date { get; set; }
        //[DisplayName("Receipt No")]
        //public string ReceiptNo { get; set; }
        //public string Comments { get; set; }

        public List<RentInformation> RentInformations { get; set; }
    }
}