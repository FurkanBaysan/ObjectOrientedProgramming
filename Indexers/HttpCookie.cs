using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<String, String> dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            dictionary = new Dictionary<String, String>();
        }

        public string this[string key]
        {
            get
            {
                return this.dictionary[key];
            }
            set
            {
                this.dictionary[key] = value;
            }
        }

    }
}
