using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Services
{
    class Created_Updated
    {
        public String created_at { get; private set; }
        public String updated_at { get; private set; }
        public Created_Updated()
        {
            created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            updated_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
