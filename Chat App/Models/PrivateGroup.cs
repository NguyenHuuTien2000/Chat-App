using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.Models
{
    public class PrivateGroup : Group
    {
        public User Admin { get; set; }
    }
}
