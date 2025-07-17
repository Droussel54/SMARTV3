using System;
using System.Collections.Generic;

namespace SMARTV3.Models
{
    public partial class Creval
    {
        public Creval()
        {
            DataCardPETS = new HashSet<DataCardPETS>();
            DummyDataCards = new HashSet<DummyDataCard>();
        }

        public int Id { get; set; }
        public string? CrevalName { get; set; }
        public string? CrevalNameFre { get; set; }

        public virtual ICollection<DataCardPETS> DataCardPETS { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCards { get; set; }
    }
}
