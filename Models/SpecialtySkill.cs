using System;
using System.Collections.Generic;

namespace SMARTV3.Models
{
    public partial class SpecialtySkill
    {
        public SpecialtySkill()
        {
            DataCardPETS = new HashSet<DataCardPETS>();
            DummyDataCards = new HashSet<DummyDataCard>();
        }

        public int Id { get; set; }
        public string SpecialtySkillName { get; set; } = null!;
        public string SpecialtySkillNameFre { get; set; } = null!;

        public virtual ICollection<DataCardPETS> DataCardPETS { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCards { get; set; }
    }
}
