using System;
using System.Collections.Generic;
using System.Text;

namespace Teamplate.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
