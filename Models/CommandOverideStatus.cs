using System;
using System.Collections.Generic;

namespace SMARTV3.Models
{
    public partial class CommandOverrideStatus
    {
        public CommandOverrideStatus()
        {
            ChangeLogs = new HashSet<ChangeLog>();
            DataCardHistories = new HashSet<DataCardHistory>();
            DataCards = new HashSet<DataCard>();
            DummyDataCards = new HashSet<DummyDataCard>();
        }

        public int Id { get; set; }
        public string? StatusDisplayColour { get; set; }
        public string? StatusDisplayValue { get; set; }
        public string? StatusDisplayValueFre { get; set; }
        public int? StatusValue { get; set; }
        public int? Ordering { get; set; }
        public bool? Archived { get; set; }

        public virtual ICollection<ChangeLog> ChangeLogs { get; set; }
        public virtual ICollection<DataCardHistory> DataCardHistories { get; set; }
        public virtual ICollection<DataCard> DataCards { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCards { get; set; }
    }
}
