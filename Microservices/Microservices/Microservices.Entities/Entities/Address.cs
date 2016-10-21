using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Entities.Entities
{
    /// <summary>
    /// Address entitie
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Address code.
        /// </summary>
        public int AddressId { get; private set; }

        /// <summary>
        /// UF of the State.
        /// </summary>
        public string UF { get; private set; }

        /// <summary>
        /// City name.
        /// </summary>
        public string City { get; private set; }

        /// <summary>
        /// Address type E.g: Avenue, Street.
        /// </summary>
        public AddressType AddresType { get; private set; }

        /// <summary>
        /// Address name.
        /// </summary>
        public string AddressName { get; private set; }

        /// <summary>
        /// Address number.
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// More information about address E.g: Home, Apartment identification.
        /// </summary>
        public string Complement { get; private set; }

        /// <summary>
        /// Old address name.
        /// </summary>
        public string AddressIdentification { get; private set; }

        /// <summary>
        /// Address CEP.
        /// </summary>
        public int CEP { get; private set; } //int type to more performace in the search.

        /// <summary>
        /// Latitude cordenation.
        /// </summary>
        public string Latitude { get; private set; }

        /// <summary>
        /// Longitude cordenation.
        /// </summary>
        public string Longitude { get; private set; }
    }
}
