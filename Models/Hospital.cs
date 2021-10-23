using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BloodBank_Backend.Base;

namespace bloodbank.Models {
    public class Hospital : IEntityBase {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        //Relationships
        //OutgoingBlood
        public List<OutgoingBlood> OutgoingBloods { get; set; }
        //Request
        public List<Request> Requests { get; set; }
        //ContactInfo
        public int? ContactInfoId { get; set; }
        [ForeignKey("ContactInfoId")]
        public ContactInfo ContactInfo { get; set; }
    }
}