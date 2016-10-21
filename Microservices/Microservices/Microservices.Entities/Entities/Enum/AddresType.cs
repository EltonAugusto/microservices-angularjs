using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Entities.Entities.Enum
{
    /// <summary>
    /// Enum address type.
    /// </summary>
    public enum AddresType
    {
        [Description("Avenida")]
        Avenue,

        [Description("Rua")]

        Street,

        [Description("Viela")]
        Alley
    }
}
