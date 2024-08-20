using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira_Music.Infrastructure.Inicialization
{
    internal class NpgsqlConfig
    {
        public string Endpoint { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
