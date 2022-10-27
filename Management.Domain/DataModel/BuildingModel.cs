using Management.Domain.Base;
using Management.Domain.Departments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Management.Domain.DataModel
{
    public class BuildingModel 
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public int? Id_Account { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Code_Address { get; set; }
        [DataMember]
        public string Image { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Utilites { get; set; }
        [DataMember]
        public string Rules { get; set; }
    }
}
