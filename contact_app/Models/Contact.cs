using System;

namespace contact_app.Models
{
    public class Contact
    {
        public long? id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}