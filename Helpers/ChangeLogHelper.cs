using SMARTV3.Models;

namespace SMARTV3.Helpers
{
    public class ChangeLogHelper
    {
        private SMARTV3DbContext _context;

        public ChangeLogHelper(SMARTV3DbContext context)
        {
            _context = context;
        }

        public void AddChangeLogItem(DataCard dc, DataCardPETS dcPETS)
        {
            ChangeLog changeLog = new()
            {
                ForceElementId = dc.ForceElementId,
                SrStatusId = dc.SrStatusId,
                CommandOverrideStatusId = dc.CommandOverrideStatusId,
                CommandOverrideComments = dc.CommandOverrideComments,
                NatoGeneralComments = dc.NatoGeneralComments,
                NatoMajorEquipmentComments = dc.NatoMajorEquipmentComments,
                NatoCavets = dc.NatoCavets,
                NatoStratLiftCapacityComments = dc.NatoStratLiftCapacityComments,
                NatoNationalDeployComments = dc.NatoNationalDeployComments,
                NatoNationalAssesmentComments = dc.NatoNationalAssesmentComments,
                PersonnelStatusId = dcPETS.PersonnelStatusId,
                PersonnelComments = dcPETS.PersonnelComments,
                TrainingStatusId = dcPETS.TrainingStatusId,
                TrainingComments = dcPETS.TrainingComments,
                EquipmentStatusId = dcPETS.EquipmentStatusId,
                EquipmentComments = dcPETS.EquipmentComments,
                SustainmentStatusId = dcPETS.SustainmentStatusId,
                SustainmentComments = dcPETS.SustainmentComments,
                ChangedDate = DateTime.Now,
                LastEditUser = null
            };

            _context.ChangeLogs.Add(changeLog);
            _context.SaveChanges();
        }
    }
}