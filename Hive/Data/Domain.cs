using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class Domain
    {

        public Domain()
        {
            this.Created = System.DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        [Display(Name = "Website")]
        [Index(IsUnique = true)]
        [MaxLength(100)]
        public string Name { get; set; }

        public DateTime Created { get; set; }

        /** Get the base domain for a given host or url. E.g. mail.google.com will return google.com */
        [Display(Name = "Domain")]
        public string BaseDomain
        {
            get
            {
                String host = getHost(this.Name);

                int startIndex = 0;
                int nextIndex = host.IndexOf('.');
                int lastIndex = host.LastIndexOf('.');
                while (nextIndex < lastIndex)
                {
                    startIndex = nextIndex + 1;
                    nextIndex = host.IndexOf('.', startIndex);
                }
                if (startIndex > 0)
                {
                    return host.Substring(startIndex);
                }
                else
                {
                    return host;
                }
            }
        }


        public static String getHost(String url)
        {
            if (url == null || url.Length == 0)
                return "";

            int doubleslash = url.IndexOf("//");
            if (doubleslash == -1)
                doubleslash = 0;
            else
                doubleslash += 2;

            int end = url.IndexOf('/', doubleslash);
            end = end >= 0 ? end : url.Length;

            int port = url.IndexOf(':', doubleslash);
            end = (port > 0 && port < end) ? port : end;

            return url.Substring(doubleslash, end);
        }

    }
}