using System;
using System.Collections.Generic;

namespace SMARTV3.Models
{
    public partial class PetsoverallStatus
    {
        public PetsoverallStatus()
        {
            ChangeLogEquipmentStatuses = new HashSet<ChangeLog>();
            ChangeLogPersonnelStatuses = new HashSet<ChangeLog>();
            ChangeLogSrStatuses = new HashSet<ChangeLog>();
            ChangeLogSustainmentStatuses = new HashSet<ChangeLog>();
            ChangeLogTrainingStatuses = new HashSet<ChangeLog>();
            DataCardEquipmentCombatVehicleStatuses = new HashSet<DataCardPETS>();
            DataCardEquipmentCommunicationsEquipmentStatuses = new HashSet<DataCardPETS>();
            DataCardEquipmentSpecialEquipmentStatuses = new HashSet<DataCardPETS>();
            DataCardEquipmentStatuses = new HashSet<DataCardPETS>();
            DataCardEquipmentSupportVehicleStatuses = new HashSet<DataCardPETS>();
            DataCardEquipmentWeaponsServiceRateStatuses = new HashSet<DataCardPETS>();
            DataCardHistoryEquipmentStatuses = new HashSet<DataCardHistory>();
            DataCardHistoryPersonnelStatuses = new HashSet<DataCardHistory>();
            DataCardHistorySrStatuses = new HashSet<DataCardHistory>();
            DataCardHistorySustainmentStatuses = new HashSet<DataCardHistory>();
            DataCardHistoryTrainingStatuses = new HashSet<DataCardHistory>();
            DataCardPersonnelStatuses = new HashSet<DataCardPETS>();
            DataCardSrStatuses = new HashSet<DataCard>();
            DataCardSustainmentAmmunitionStatuses = new HashSet<DataCardPETS>();
            DataCardSustainmentCombatRationsStatuses = new HashSet<DataCardPETS>();
            DataCardSustainmentOtherStatuses = new HashSet<DataCardPETS>();
            DataCardSustainmentPersonalEquipmentStatuses = new HashSet<DataCardPETS>();
            DataCardSustainmentPetrolStatuses = new HashSet<DataCardPETS>();
            DataCardSustainmentSparesStatuses = new HashSet<DataCardPETS>();
            DataCardSustainmentStatuses = new HashSet<DataCardPETS>();
            DataCardTrainingCollectiveTrainingStatuses = new HashSet<DataCardPETS>();
            DataCardTrainingIndividualTrainingStatuses = new HashSet<DataCardPETS>();
            DataCardTrainingStatuses = new HashSet<DataCardPETS>();
            DatacardKpiOverallStatusAboves = new HashSet<DatacardKpi>();
            DatacardKpiOverallStatusBelows = new HashSet<DatacardKpi>();
            DummyDataCardEquipmentCombatVehicleStatuses = new HashSet<DummyDataCard>();
            DummyDataCardEquipmentCommunicationsEquipmentStatuses = new HashSet<DummyDataCard>();
            DummyDataCardEquipmentSpecialEquipmentStatuses = new HashSet<DummyDataCard>();
            DummyDataCardEquipmentStatuses = new HashSet<DummyDataCard>();
            DummyDataCardEquipmentSupportVehicleStatuses = new HashSet<DummyDataCard>();
            DummyDataCardEquipmentWeaponsServiceRateStatuses = new HashSet<DummyDataCard>();
            DummyDataCardPersonnelStatuses = new HashSet<DummyDataCard>();
            DummyDataCardSrStatuses = new HashSet<DummyDataCard>();
            DummyDataCardSustainmentAmmunitionStatuses = new HashSet<DummyDataCard>();
            DummyDataCardSustainmentCombatRationsStatuses = new HashSet<DummyDataCard>();
            DummyDataCardSustainmentOtherStatuses = new HashSet<DummyDataCard>();
            DummyDataCardSustainmentPersonalEquipmentStatuses = new HashSet<DummyDataCard>();
            DummyDataCardSustainmentPetrolStatuses = new HashSet<DummyDataCard>();
            DummyDataCardSustainmentSparesStatuses = new HashSet<DummyDataCard>();
            DummyDataCardSustainmentStatuses = new HashSet<DummyDataCard>();
            DummyDataCardTrainingCollectiveTrainingStatuses = new HashSet<DummyDataCard>();
            DummyDataCardTrainingIndividualTrainingStatuses = new HashSet<DummyDataCard>();
            DummyDataCardTrainingStatuses = new HashSet<DummyDataCard>();
        }

        public int Id { get; set; }
        public string? StatusDisplayColour { get; set; }
        public string? StatusDisplayValue { get; set; }
        public int? StatusValue { get; set; }
        public int? Ordering { get; set; }
        public bool? Archived { get; set; }

        public virtual ICollection<ChangeLog> ChangeLogEquipmentStatuses { get; set; }
        public virtual ICollection<ChangeLog> ChangeLogPersonnelStatuses { get; set; }
        public virtual ICollection<ChangeLog> ChangeLogSrStatuses { get; set; }
        public virtual ICollection<ChangeLog> ChangeLogSustainmentStatuses { get; set; }
        public virtual ICollection<ChangeLog> ChangeLogTrainingStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardEquipmentCombatVehicleStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardEquipmentCommunicationsEquipmentStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardEquipmentSpecialEquipmentStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardEquipmentStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardEquipmentSupportVehicleStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardEquipmentWeaponsServiceRateStatuses { get; set; }
        public virtual ICollection<DataCardHistory> DataCardHistoryEquipmentStatuses { get; set; }
        public virtual ICollection<DataCardHistory> DataCardHistoryPersonnelStatuses { get; set; }
        public virtual ICollection<DataCardHistory> DataCardHistorySrStatuses { get; set; }
        public virtual ICollection<DataCardHistory> DataCardHistorySustainmentStatuses { get; set; }
        public virtual ICollection<DataCardHistory> DataCardHistoryTrainingStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardPersonnelStatuses { get; set; }
        public virtual ICollection<DataCard> DataCardSrStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardSustainmentAmmunitionStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardSustainmentCombatRationsStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardSustainmentOtherStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardSustainmentPersonalEquipmentStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardSustainmentPetrolStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardSustainmentSparesStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardSustainmentStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardTrainingCollectiveTrainingStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardTrainingIndividualTrainingStatuses { get; set; }
        public virtual ICollection<DataCardPETS> DataCardTrainingStatuses { get; set; }
        public virtual ICollection<DatacardKpi> DatacardKpiOverallStatusAboves { get; set; }
        public virtual ICollection<DatacardKpi> DatacardKpiOverallStatusBelows { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardEquipmentCombatVehicleStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardEquipmentCommunicationsEquipmentStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardEquipmentSpecialEquipmentStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardEquipmentStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardEquipmentSupportVehicleStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardEquipmentWeaponsServiceRateStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardPersonnelStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardSrStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardSustainmentAmmunitionStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardSustainmentCombatRationsStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardSustainmentOtherStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardSustainmentPersonalEquipmentStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardSustainmentPetrolStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardSustainmentSparesStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardSustainmentStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardTrainingCollectiveTrainingStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardTrainingIndividualTrainingStatuses { get; set; }
        public virtual ICollection<DummyDataCard> DummyDataCardTrainingStatuses { get; set; }
    }
}
