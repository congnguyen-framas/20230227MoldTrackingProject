using System;

namespace MoldTracking.InterfacesModels
{
    public class tblMoldChangedInfoModel
    {
        public Guid Id { get; set; }
        public string MachineCode { get; set; }
        public string MachineName { get; set; }
        public string MoldCode { get; set; }
        public string MoldName { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ColorCode { get; set; }
        public string ColorName { get; set; }
        public string SizeCode { get; set; }
        public string SizeName { get; set; }
        public DateTime ReceiveTime { get; set; }
        public DateTime ActualReceiveTime { get; set; }
        public int? CreatedById { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public string CreatedMachine { get; set; }

    }
}
