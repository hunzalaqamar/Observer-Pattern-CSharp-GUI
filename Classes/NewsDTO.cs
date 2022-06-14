using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCD_LAB_W14.Classes
{
    public class NewsDTO
    {
        private string newstype;
        private string newsdetails;

        public NewsDTO()
        {
            this.Newstype = "";
            this.Newsdetails = "";
        }

        public NewsDTO(string newstype, string newsdetails)
        {
            this.Newstype = newstype;
            this.Newsdetails = newsdetails;
        }

        public string Newstype { get => newstype; set => newstype = value; }
        public string Newsdetails { get => newsdetails; set => newsdetails = value; }
    }
}
