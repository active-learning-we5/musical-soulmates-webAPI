using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalSoulmates.Models
{
    public class BaseData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public BaseData Parent { get; set; }
        public int Order { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<BaseDataTranslation> BaseDataTranslations { get; set; }
    }
}
