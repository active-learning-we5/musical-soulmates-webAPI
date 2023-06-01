using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MusicalSoulmates.Models
{
    public class BaseDataTranslation
    {
        public BaseData BaseData { get; set; }
        public string Lang { get; set; }
        public string Title { get; set; }
    }
}
