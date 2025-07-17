using Microsoft.EntityFrameworkCore;

using Newtonsoft.Json;

using SMARTV3.Models;

namespace SMARTV3.Helpers
{
    public class ForcePackageHelper
    {
        private SMARTV3DbContext _context;

        public ForcePackageHelper(SMARTV3DbContext context)
        {
            _context = context;
        }

        public IQueryable<ForcePackage> GetForcePackageQueryWIncludes()
        {
            return _context.ForcePackages.Include(p => p.PackageOwner)
                                         .Include(p => p.ForcePackagePurposeNavigation)
                                         .Include(p => p.LastEditUserNavigation)
                                         .Include(p => p.Conplans)
                                         .Include(p => p.Operations)
                                         .Include(p => p.ForcePackageKpis)
                                         .Include(p => p.Users)
                                                .ThenInclude(u => u.Organization)
                                         .Include(p => p.DummyForceElements)
                                                .ThenInclude(d => d.Weighting)
                                         .Include(p => p.DummyForceElements)
                                                .ThenInclude(d => d.DummyDataCards)
                                                       .ThenInclude(d => d.Capability)
                                         .Include(p => p.DummyForceElements)
                                                .ThenInclude(d => d.DummyDataCards)
                                                       .ThenInclude(d => d.Category)
                                         .Include(p => p.DummyForceElements)
                                                .ThenInclude(d => d.DummyDataCards)
                                                       .ThenInclude(d => d.DeployedStatus)
                                         .Include(p => p.DummyForceElements)
                                                .ThenInclude(d => d.DummyDataCards)
                                                       .ThenInclude(d => d.Designation)
                                         .Include(p => p.DummyForceElements)
                                                .ThenInclude(d => d.DummyDataCards)
                                                       .ThenInclude(d => d.SrStatus)
                                         .Include(p => p.DummyForceElements)
                                                .ThenInclude(d => d.DummyDataCards)
                                                       .ThenInclude(d => d.CommandOverrideStatus)
                                         .Include(p => p.DummyForceElements)
                                                .ThenInclude(d => d.DummyDataCards)
                                                       .ThenInclude(d => d.PersonnelStatus)
                                         .Include(p => p.DummyForceElements)
                                                .ThenInclude(d => d.DummyDataCards)
                                                       .ThenInclude(d => d.EquipmentStatus)
                                         .Include(p => p.DummyForceElements)
                                                .ThenInclude(d => d.DummyDataCards)
                                                       .ThenInclude(d => d.TrainingStatus)
                                         .Include(p => p.DummyForceElements)
                                                .ThenInclude(d => d.DummyDataCards)
                                                       .ThenInclude(d => d.SustainmentStatus);
        }

        public IQueryable<DummyForceElement> GetDummyForceElementsQueryWIncludes()
        {
            return _context.DummyForceElements.Include(d => d.ForceElement)
                                              .Include(d => d.ForcePackage)
                                                 .ThenInclude(d => d.Operations)
                                              .Include(d => d.ForcePackage)
                                                 .ThenInclude(d => d.Conplans)
                                              .Include(d => d.Organization)
                                              .Include(d => d.Weighting)
                                              .Include(d => d.DummyDataCards)
                                                 .ThenInclude(dataCard => dataCard.Capability)
                                              .Include(d => d.DummyDataCards)
                                                 .ThenInclude(dataCard => dataCard.Category)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.CommandOverrideStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.DeployedStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.Designation)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.Echelon)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.EquipmentCombatVehicleStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.EquipmentCommunicationsEquipmentStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.EquipmentSpecialEquipmentStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.EquipmentStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.EquipmentSupportVehicleStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.EquipmentWeaponsServiceRateStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.LastEditUserNavigation)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.NatoNationalDeployNavigation)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.NatoStratLiftCapacityNavigation)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.NoticeToMove)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.PersonnelStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.Service)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.SrStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.SustainmentAmmunitionStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.SustainmentCombatRationsStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.SustainmentOtherStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.SustainmentPersonalEquipmentStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.SustainmentPetrolStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.SustainmentSparesStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.SustainmentStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.TrainingCollectiveTrainingStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.TrainingCrevalNavigation)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.TrainingIndividualTrainingStatus)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.TrainingSpecialtySkills)
                                              .Include(d => d.DummyDataCards)
                                                  .ThenInclude(dataCard => dataCard.TrainingStatus);
        }

        public List<ForcePackage> CreateFPListFromSerialized(string? serializedForcePackageIds)
        {
            List<int>? forcePackageIds;
            List<ForcePackage> forcePackages = new();
            if (serializedForcePackageIds == null)
            {
                return forcePackages;
            }
            try
            {
                forcePackageIds = JsonConvert.DeserializeObject<List<string>>(serializedForcePackageIds)?.Select(int.Parse).ToList();
            }
            catch (Exception)
            {
                return forcePackages;
            }
            if (forcePackageIds == null || forcePackageIds.Count == 0)
            {
                return forcePackages;
            }
            foreach (int forcePackageId in forcePackageIds)
            {
                ForcePackage? tempForcePackage = GetForcePackageQueryWIncludes().Where(fp => fp.Id == forcePackageId).FirstOrDefault();
                if (tempForcePackage != null)
                {
                    forcePackages.Add(tempForcePackage);
                }
            }
            return forcePackages;
        }

        public static DummyForceElement ForceElementToDummy(int forcePackageId, ForceElement forceElement)
        {
            DummyForceElement dummyForceElement = new()
            {
                IsTiedToRealFelm = true,
                IsActiveInForcePackage = true,
                ForceElementId = forceElement.Id,
                ForcePackageId = forcePackageId,
                ElementName = forceElement.ElementName,
                ElementNameFre = forceElement.ElementNameFre,
                OrganizationId = forceElement.OrganizationId,
                WeightingId = forceElement.WeightingId,
                Ordered = forceElement.Ordered,
                Archived = forceElement.Archived
            };
            return dummyForceElement;
        }

        public static DummyDataCard DatacardToDummy(int forcePackageId, DataCard dataCard, DataCardPETS dataCardPETS)
        {
            DummyDataCard dummyDataCard = new()
            {
                DataCardComplete = dataCard.DataCardComplete,
                Division = dataCard.Division,
                Brigade = dataCard.Brigade,
                Unit = dataCard.Unit,
                Subunit = dataCard.Subunit,
                SrStatusId = dataCard.SrStatusId,
                CommandOverrideStatusId = dataCard.CommandOverrideStatusId,
                CommandOverrideAuthority = dataCard.CommandOverrideAuthority,
                CommandOverrideComments = dataCard.CommandOverrideComments,
                ReadinessFromDate = dataCard.ReadinessFromDate,
                ReadinessToDate = dataCard.ReadinessToDate,
                Validitydate = dataCard.Validitydate,
                DeployedStatusId = dataCard.DeployedStatusId,
                DesignationId = dataCard.DesignationId,
                ServiceId = dataCard.ServiceId,
                EchelonId = dataCard.EchelonId,
                CapabilityId = dataCard.CapabilityId,
                CategoryId = dataCard.CategoryId,
                NoticeToMoveId = dataCard.NoticeToMoveId,
                NatoActive = dataCard.NatoActive,
                NFMActive = dataCard.NFMActive,
                NatoLocation = dataCard.NatoLocation,
                NatoCoordinates = dataCard.NatoCoordinates,
                NatoMajorEquipmentComments = dataCard.NatoMajorEquipmentComments,
                NatoCavets = dataCard.NatoCavets,
                NatoGeneralComments = dataCard.NatoGeneralComments,
                NatoStratLiftCapacityId = dataCard.NatoStratLiftCapacityId,
                NatoStratLiftCapacity = dataCard.NatoStratLiftCapacity,
                NatoStratLiftCapacityComments = dataCard.NatoStratLiftCapacityComments,
                NatoNationalDeployId = dataCard.NatoNationalDeployId,
                NatoNationalDeploy = dataCard.NatoNationalDeploy,
                NatoNationalDeployComments = dataCard.NatoNationalDeployComments,
                NatoFph = dataCard.NatoFph,
                NatoNationalAssesmentComments = dataCard.NatoNationalAssesmentComments,
                NatoAfstraining = dataCard.NatoAfstraining,
                PersonnelStatusId = dataCardPETS.PersonnelStatusId,
                PersonnelDesignatedStrength = dataCardPETS.PersonnelDesignatedStrength,
                PersonnelActualStrength = dataCardPETS.PersonnelActualStrength,
                PersonnelLob = dataCardPETS.PersonnelLOB,
                PersonnelMedical = dataCardPETS.PersonnelMedical,
                PersonnelDental = dataCardPETS.PersonnelDental,
                PersonnelAps = dataCardPETS.PersonnelAPS,
                PersonnelLightDuties = dataCardPETS.PersonnelLightDuties,
                PersonnelFitness = dataCardPETS.PersonnelFitness,
                PersonnelIt = dataCardPETS.PersonnelIT,
                PersonnelComments = dataCardPETS.PersonnelComments,
                EquipmentStatusId = dataCardPETS.EquipmentStatusId,
                EquipmentCombatVehicleStatusId = dataCardPETS.EquipmentCombatVehicleStatusId,
                EquipmentSupportVehicleStatusId = dataCardPETS.EquipmentSupportVehicleStatusId,
                EquipmentWeaponsServiceRateStatusId = dataCardPETS.EquipmentWeaponsServiceRateStatusId,
                EquipmentCommunicationsEquipmentStatusId = dataCardPETS.EquipmentCommunicationsEquipmentStatusId,
                EquipmentSpecialEquipmentStatusId = dataCardPETS.EquipmentSpecialEquipmentStatusId,
                EquipmentVehicalsReadinessFactor = dataCardPETS.EquipmentVehicalsReadinessFactor,
                EquipmentWeaponsReadinessFactor = dataCardPETS.EquipmentWeaponsReadinessFactor,
                EquipmentCommunicationsReadinessFactor = dataCardPETS.EquipmentCommunicationsReadinessFactor,
                EquipmentSpecialEquimentReadinessFactor = dataCardPETS.EquipmentSpecialEquimentReadinessFactor,
                EquipmentTechniciansReadinessFactor = dataCardPETS.EquipmentTechniciansReadinessFactor,
                EquipmentLifeEntensionDelays = dataCardPETS.EquipmentLifeEntensionDelays,
                EquipmentProtectionSuites = dataCardPETS.EquipmentProtectionSuites,
                EquipmentOther = dataCardPETS.EquipmentOther,
                EquipmentComments = dataCardPETS.EquipmentComments,
                TrainingStatusId = dataCardPETS.TrainingStatusId,
                TrainingProjectedCrevaldate = dataCardPETS.TrainingProjectedCREVALDate,
                TrainingCreval = dataCardPETS.TrainingCREVAL,
                TrainingCrevaldate = dataCardPETS.TrainingCREVALDate,
                TrainingAmmoReadinessFactor = dataCardPETS.TrainingAmmoReadinessFactor,
                TrainingFuelReadinessFactor = dataCardPETS.TrainingFuelReadinessFactor,
                TrainingRationsReadinessFactor = dataCardPETS.TrainingRationsReadinessFactor,
                TrainingWeaponsReadinessFactor = dataCardPETS.TrainingWeaponsReadinessFactor,
                TrainingRadiosReadinessFactor = dataCardPETS.TrainingRadiosReadinessFactor,
                TrainingEquipmentReadinessFactor = dataCardPETS.TrainingEquipmentReadinessFactor,
                TrainingSparePartssReadinessFactor = dataCardPETS.TrainingSparePartssReadinessFactor,
                TrainingItreadinessFactor = dataCardPETS.TrainingITReadinessFactor,
                TrainingRangeAvailabilityReadinessFactor = dataCardPETS.TrainingRangeAvailabilityReadinessFactor,
                TrainingCtreadinessFactor = dataCardPETS.TrainingCTReadinessFactor,
                TrainingSpecialQuals = dataCardPETS.TrainingSpecialQuals,
                TrainingTrgFleets = dataCardPETS.TrainingTrgFleets,
                TrainingComments = dataCardPETS.TrainingComments,
                TrainingCollectiveTrainingStatusId = dataCardPETS.TrainingCollectiveTrainingStatusId,
                TrainingIndividualTrainingStatusId = dataCardPETS.TrainingIndividualTrainingStatusId,
                TrainingSpecialtySkillsId = dataCardPETS.TrainingSpecialtySkillsId,
                SustainmentStatusId = dataCardPETS.SustainmentStatusId,
                SustainmentCombatRationsStatusId = dataCardPETS.SustainmentCombatRationsStatusId,
                SustainmentPersonalEquipmentStatusId = dataCardPETS.SustainmentPersonalEquipmentStatusId,
                SustainmentPetrolStatusId = dataCardPETS.SustainmentPetrolStatusId,
                SustainmentAmmunitionStatusId = dataCardPETS.SustainmentAmmunitionStatusId,
                SustainmentOtherStatusId = dataCardPETS.SustainmentOtherStatusId,
                SustainmentSparesStatusId = dataCardPETS.SustainmentSparesStatusId,
                SustainmentRationsReadinessFactor = dataCardPETS.SustainmentRationsReadinessFactor,
                SustainmentUniformsReadinessFactor = dataCardPETS.SustainmentUniformsReadinessFactor,
                SustainmentPpereadinessFactor = dataCardPETS.SustainmentPPEReadinessFactor,
                SustainmentFuelReadinessFactor = dataCardPETS.SustainmentFuelReadinessFactor,
                SustainmentAmmunitionReadinessFactor = dataCardPETS.SustainmentAmmunitionReadinessFactor,
                SustainmentOtherReadinessFactor = dataCardPETS.SustainmentOtherReadinessFactor,
                SustainmentSparePartsReadinessFactor = dataCardPETS.SustainmentSparePartsReadinessFactor,
                SustainmentComments = dataCardPETS.SustainmentComments,
                LastEditUser = dataCard.LastEditUser,
                LastEditDate = dataCard.LastEditDate,
                Concurrency = dataCard.Concurrency,
                ConcurrencyComments = dataCard.ConcurrencyComments,
                NatoAssetsDeclared = dataCard.NatoAssetsDeclared,
                Rds = dataCard.Rds,
                EquipmentSensorsReadinessFactor = dataCardPETS.EquipmentSensorsReadinessFactor,
                PersonnelTradeInsufficienciesReadinessFactor = dataCardPETS.PersonnelTradeInsufficienciesReadinessFactor,
                Capability = dataCard.Capability,
                Category = dataCard.Category,
                CommandOverrideStatus = dataCard.CommandOverrideStatus,
                DeployedStatus = dataCard.DeployedStatus,
                Designation = dataCard.Designation,
                Echelon = dataCard.Echelon,
                EquipmentCombatVehicleStatus = dataCardPETS.EquipmentCombatVehicleStatus,
                EquipmentCommunicationsEquipmentStatus = dataCardPETS.EquipmentCommunicationsEquipmentStatus,
                EquipmentSpecialEquipmentStatus = dataCardPETS.EquipmentSpecialEquipmentStatus,
                EquipmentStatus = dataCardPETS.EquipmentStatus,
                EquipmentSupportVehicleStatus = dataCardPETS.EquipmentSupportVehicleStatus,
                EquipmentWeaponsServiceRateStatus = dataCardPETS.EquipmentWeaponsServiceRateStatus,
                LastEditUserNavigation = dataCard.LastEditUserNavigation,
                NatoNationalDeployNavigation = dataCard.NatoNationalDeployNavigation,
                NatoStratLiftCapacityNavigation = dataCard.NatoStratLiftCapacityNavigation,
                NoticeToMove = dataCard.NoticeToMove,
                PersonnelStatus = dataCardPETS.PersonnelStatus,
                Service = dataCard.Service,
                SrStatus = dataCard.SrStatus,
                SustainmentAmmunitionStatus = dataCardPETS.SustainmentAmmunitionStatus,
                SustainmentCombatRationsStatus = dataCardPETS.SustainmentCombatRationsStatus,
                SustainmentOtherStatus = dataCardPETS.SustainmentOtherStatus,
                SustainmentPersonalEquipmentStatus = dataCardPETS.SustainmentPersonalEquipmentStatus,
                SustainmentPetrolStatus = dataCardPETS.SustainmentPetrolStatus,
                SustainmentSparesStatus = dataCardPETS.SustainmentSparesStatus,
                SustainmentStatus = dataCardPETS.SustainmentStatus,
                TrainingCollectiveTrainingStatus = dataCardPETS.TrainingCollectiveTrainingStatus,
                TrainingCrevalNavigation = dataCardPETS.TrainingCREVALNavigation,
                TrainingIndividualTrainingStatus = dataCardPETS.TrainingIndividualTrainingStatus,
                TrainingSpecialtySkills = dataCardPETS.TrainingSpecialtySkills,
                TrainingStatus = dataCardPETS.TrainingStatus,
                DummyForceElement = new()
                {
                    IsTiedToRealFelm = true,
                    IsActiveInForcePackage = true,
                    ForceElementId = dataCard.ForceElementId,
                    ForcePackageId = forcePackageId,
                    ElementId = dataCard.ForceElement!.ElementId,
                    ElementName = dataCard.ForceElement?.ElementName,
                    ElementNameFre = dataCard.ForceElement?.ElementNameFre,
                    OrganizationId = dataCard.ForceElement!.OrganizationId,
                    WeightingId = dataCard.ForceElement?.WeightingId,
                    Ordered = dataCard.ForceElement!.Ordered,
                    Archived = dataCard.ForceElement.Archived
                }
            };
            return dummyDataCard;
        }

        public DummyDataCard? CopyForceElementAndDatacard(int ForcePackageId, DummyForceElement dummyForceElement)
        {
            DummyDataCard? dummyDataCardToCopy = dummyForceElement.DummyDataCards.FirstOrDefault();
            if (dummyDataCardToCopy == null)
            {
                return null;
            }
            return new DummyDataCard()
            {
                DataCardComplete = dummyDataCardToCopy.DataCardComplete,
                Division = dummyDataCardToCopy.Division,
                Brigade = dummyDataCardToCopy.Brigade,
                Unit = dummyDataCardToCopy.Unit,
                Subunit = dummyDataCardToCopy.Subunit,
                SrStatusId = dummyDataCardToCopy.SrStatusId,
                CommandOverrideStatusId = dummyDataCardToCopy.CommandOverrideStatusId,
                CommandOverrideAuthority = dummyDataCardToCopy.CommandOverrideAuthority,
                CommandOverrideComments = dummyDataCardToCopy.CommandOverrideComments,
                ReadinessFromDate = dummyDataCardToCopy.ReadinessFromDate,
                ReadinessToDate = dummyDataCardToCopy.ReadinessToDate,
                Validitydate = dummyDataCardToCopy.Validitydate,
                DeployedStatusId = dummyDataCardToCopy.DeployedStatusId,
                DesignationId = dummyDataCardToCopy.DesignationId,
                ServiceId = dummyDataCardToCopy.ServiceId,
                EchelonId = dummyDataCardToCopy.EchelonId,
                CapabilityId = dummyDataCardToCopy.CapabilityId,
                CategoryId = dummyDataCardToCopy.CategoryId,
                NoticeToMoveId = dummyDataCardToCopy.NoticeToMoveId,
                NatoActive = dummyDataCardToCopy.NatoActive,
                NFMActive = dummyDataCardToCopy.NFMActive,
                NatoLocation = dummyDataCardToCopy.NatoLocation,
                NatoCoordinates = dummyDataCardToCopy.NatoCoordinates,
                NatoMajorEquipmentComments = dummyDataCardToCopy.NatoMajorEquipmentComments,
                NatoCavets = dummyDataCardToCopy.NatoCavets,
                NatoGeneralComments = dummyDataCardToCopy.NatoGeneralComments,
                NatoStratLiftCapacityId = dummyDataCardToCopy.NatoStratLiftCapacityId,
                NatoStratLiftCapacity = dummyDataCardToCopy.NatoStratLiftCapacity,
                NatoStratLiftCapacityComments = dummyDataCardToCopy.NatoStratLiftCapacityComments,
                NatoNationalDeployId = dummyDataCardToCopy.NatoNationalDeployId,
                NatoNationalDeploy = dummyDataCardToCopy.NatoNationalDeploy,
                NatoNationalDeployComments = dummyDataCardToCopy.NatoNationalDeployComments,
                NatoFph = dummyDataCardToCopy.NatoFph,
                NatoNationalAssesmentComments = dummyDataCardToCopy.NatoNationalAssesmentComments,
                NatoAfstraining = dummyDataCardToCopy.NatoAfstraining,
                PersonnelStatusId = dummyDataCardToCopy.PersonnelStatusId,
                PersonnelDesignatedStrength = dummyDataCardToCopy.PersonnelDesignatedStrength,
                PersonnelActualStrength = dummyDataCardToCopy.PersonnelActualStrength,
                PersonnelLob = dummyDataCardToCopy.PersonnelLob,
                PersonnelMedical = dummyDataCardToCopy.PersonnelMedical,
                PersonnelDental = dummyDataCardToCopy.PersonnelDental,
                PersonnelAps = dummyDataCardToCopy.PersonnelAps,
                PersonnelLightDuties = dummyDataCardToCopy.PersonnelLightDuties,
                PersonnelFitness = dummyDataCardToCopy.PersonnelFitness,
                PersonnelIt = dummyDataCardToCopy.PersonnelIt,
                PersonnelComments = dummyDataCardToCopy.PersonnelComments,
                EquipmentStatusId = dummyDataCardToCopy.EquipmentStatusId,
                EquipmentCombatVehicleStatusId = dummyDataCardToCopy.EquipmentCombatVehicleStatusId,
                EquipmentSupportVehicleStatusId = dummyDataCardToCopy.EquipmentSupportVehicleStatusId,
                EquipmentWeaponsServiceRateStatusId = dummyDataCardToCopy.EquipmentWeaponsServiceRateStatusId,
                EquipmentCommunicationsEquipmentStatusId = dummyDataCardToCopy.EquipmentCommunicationsEquipmentStatusId,
                EquipmentSpecialEquipmentStatusId = dummyDataCardToCopy.EquipmentSpecialEquipmentStatusId,
                EquipmentVehicalsReadinessFactor = dummyDataCardToCopy.EquipmentVehicalsReadinessFactor,
                EquipmentWeaponsReadinessFactor = dummyDataCardToCopy.EquipmentWeaponsReadinessFactor,
                EquipmentCommunicationsReadinessFactor = dummyDataCardToCopy.EquipmentCommunicationsReadinessFactor,
                EquipmentSpecialEquimentReadinessFactor = dummyDataCardToCopy.EquipmentSpecialEquimentReadinessFactor,
                EquipmentTechniciansReadinessFactor = dummyDataCardToCopy.EquipmentTechniciansReadinessFactor,
                EquipmentLifeEntensionDelays = dummyDataCardToCopy.EquipmentLifeEntensionDelays,
                EquipmentProtectionSuites = dummyDataCardToCopy.EquipmentProtectionSuites,
                EquipmentOther = dummyDataCardToCopy.EquipmentOther,
                EquipmentComments = dummyDataCardToCopy.EquipmentComments,
                TrainingStatusId = dummyDataCardToCopy.TrainingStatusId,
                TrainingProjectedCrevaldate = dummyDataCardToCopy.TrainingProjectedCrevaldate,
                TrainingCreval = dummyDataCardToCopy.TrainingCreval,
                TrainingCrevaldate = dummyDataCardToCopy.TrainingCrevaldate,
                TrainingAmmoReadinessFactor = dummyDataCardToCopy.TrainingAmmoReadinessFactor,
                TrainingFuelReadinessFactor = dummyDataCardToCopy.TrainingFuelReadinessFactor,
                TrainingRationsReadinessFactor = dummyDataCardToCopy.TrainingRationsReadinessFactor,
                TrainingWeaponsReadinessFactor = dummyDataCardToCopy.TrainingWeaponsReadinessFactor,
                TrainingRadiosReadinessFactor = dummyDataCardToCopy.TrainingRadiosReadinessFactor,
                TrainingEquipmentReadinessFactor = dummyDataCardToCopy.TrainingEquipmentReadinessFactor,
                TrainingSparePartssReadinessFactor = dummyDataCardToCopy.TrainingSparePartssReadinessFactor,
                TrainingItreadinessFactor = dummyDataCardToCopy.TrainingItreadinessFactor,
                TrainingRangeAvailabilityReadinessFactor = dummyDataCardToCopy.TrainingRangeAvailabilityReadinessFactor,
                TrainingCtreadinessFactor = dummyDataCardToCopy.TrainingCtreadinessFactor,
                TrainingSpecialQuals =  dummyDataCardToCopy.TrainingSpecialQuals,
                TrainingTrgFleets = dummyDataCardToCopy.TrainingTrgFleets,
                TrainingComments = dummyDataCardToCopy.TrainingComments,
                TrainingCollectiveTrainingStatusId = dummyDataCardToCopy.TrainingCollectiveTrainingStatusId,
                TrainingIndividualTrainingStatusId = dummyDataCardToCopy.TrainingIndividualTrainingStatusId,
                TrainingSpecialtySkillsId = dummyDataCardToCopy.TrainingSpecialtySkillsId,
                SustainmentStatusId = dummyDataCardToCopy.SustainmentStatusId,
                SustainmentCombatRationsStatusId = dummyDataCardToCopy.SustainmentCombatRationsStatusId,
                SustainmentPersonalEquipmentStatusId = dummyDataCardToCopy.SustainmentPersonalEquipmentStatusId,
                SustainmentPetrolStatusId = dummyDataCardToCopy.SustainmentPetrolStatusId,
                SustainmentAmmunitionStatusId = dummyDataCardToCopy.SustainmentAmmunitionStatusId,
                SustainmentOtherStatusId = dummyDataCardToCopy.SustainmentOtherStatusId,
                SustainmentSparesStatusId = dummyDataCardToCopy.SustainmentSparesStatusId,
                SustainmentRationsReadinessFactor = dummyDataCardToCopy.SustainmentRationsReadinessFactor,
                SustainmentUniformsReadinessFactor = dummyDataCardToCopy.SustainmentUniformsReadinessFactor,
                SustainmentPpereadinessFactor = dummyDataCardToCopy.SustainmentPpereadinessFactor,
                SustainmentFuelReadinessFactor = dummyDataCardToCopy.SustainmentFuelReadinessFactor,
                SustainmentAmmunitionReadinessFactor = dummyDataCardToCopy.SustainmentAmmunitionReadinessFactor,
                SustainmentOtherReadinessFactor = dummyDataCardToCopy.SustainmentOtherReadinessFactor,
                SustainmentSparePartsReadinessFactor = dummyDataCardToCopy.SustainmentSparePartsReadinessFactor,
                SustainmentComments = dummyDataCardToCopy.SustainmentComments,
                LastEditUser = dummyDataCardToCopy.LastEditUser,
                LastEditDate = dummyDataCardToCopy.LastEditDate,
                Concurrency = dummyDataCardToCopy.Concurrency,
                ConcurrencyComments = dummyDataCardToCopy.ConcurrencyComments,
                NatoAssetsDeclared = dummyDataCardToCopy.NatoAssetsDeclared,
                Rds = dummyDataCardToCopy.Rds,
                DummyForceElement = new()
                {
                    IsTiedToRealFelm = dummyForceElement.IsTiedToRealFelm,
                    IsActiveInForcePackage = dummyForceElement.IsActiveInForcePackage,
                    ForceElementId = dummyForceElement.ForceElementId,
                    ForcePackageId = ForcePackageId,
                    ElementId = dummyForceElement.ElementId,
                    ElementName = dummyForceElement.ElementName,
                    ElementNameFre = dummyForceElement.ElementNameFre,
                    OrganizationId = dummyForceElement.OrganizationId,
                    WeightingId = dummyForceElement.WeightingId,
                    Ordered = dummyForceElement.Ordered,
                    Archived = dummyForceElement.Archived
                }
            };
        }
    }
}