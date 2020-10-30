using System;
using System.Collections.Generic;

namespace digitalmarketingjobs.ph.Data.Models
{
    public partial class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }
        public string CompanyName { get; set; }
        public byte[] CompanyLogo { get; set; }
        public string Website { get; set; }
    }
}
