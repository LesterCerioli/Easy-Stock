using System;
using System.Collections.Generic;
using System.Text;

namespace EasyStock.Domain.Entities
{
    public class Provider : Entity
    {
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string RazaoSocial { get; set; }
        public string DocNumber { get; set; }
        public int Kind { get; set; }
        public string TelephoneNumber { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string PostalBox { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public bool Active { get; set; }




        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
