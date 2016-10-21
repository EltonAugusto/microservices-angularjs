using Microservices.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Domain.Entities
{
    /// <summary>
    /// Customer entitie.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Customer code.
        /// </summary>
        public int CustomerId { get; private set; }

        /// <summary>
        /// Customer name.
        /// </summary>
        public int Name { get; private set; }

        /// <summary>
        /// Contact phone number.
        /// </summary>
        public string PhoneNumber { get; private set; }

        /// <summary>
        /// Customer Address.
        /// </summary>
        public Address Address { get; private set; }

    }
}
