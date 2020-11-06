using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_5
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Messeg { get; set; }
        public int Number { get; set; }
    }
}
