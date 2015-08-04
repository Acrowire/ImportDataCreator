namespace FakeData.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProNetScanResultStage")]
    public partial class ProNetScanResultStage
    {
        public int id { get; set; }

        public int idCurrentScans { get; set; }

        [StringLength(20)]
        public string ScannerName { get; set; }

        [StringLength(15)]
        public string IP { get; set; }

        public DateTime? ScanTime { get; set; }

        [StringLength(15)]
        public string DataCenter { get; set; }

        [StringLength(15)]
        public string DeviceType { get; set; }

        [StringLength(45)]
        public string SystemType { get; set; }

        public int? PrimaryIP { get; set; }

        [StringLength(15)]
        public string PrimaryIPAddress { get; set; }

        public int? wmi { get; set; }

        public int? wmiIndex { get; set; }

        public int? cim { get; set; }

        public int? cimIndex { get; set; }

        public int? ssh { get; set; }

        public int? sshIndex { get; set; }

        public int? snmp { get; set; }

        public int? snmpIndex { get; set; }

        public int? sysedge { get; set; }

        public int? sysedgeIndex { get; set; }

        [StringLength(256)]
        public string listeners { get; set; }

        [StringLength(120)]
        public string Location { get; set; }

        [StringLength(60)]
        public string DNSName { get; set; }

        public int? IsCurrent { get; set; }

        [StringLength(5)]
        public string VM { get; set; }

        [StringLength(20)]
        public string SoftwareSource { get; set; }

        public int? IsDuplicate { get; set; }

        [StringLength(20)]
        public string ScanStart { get; set; }

        [StringLength(50)]
        public string Hostname { get; set; }

        [StringLength(1)]
        public string UCentralAuth { get; set; }

        [StringLength(1)]
        public string WhiteListAgent { get; set; }

        [StringLength(1)]
        public string AntiVirusAgent { get; set; }

        [StringLength(1)]
        public string SIEMAgent { get; set; }

        [StringLength(1)]
        public string DBSIEMAgent { get; set; }

        [StringLength(1)]
        public string FIMSAgent { get; set; }

        [StringLength(1)]
        public string DLPAgent { get; set; }

        [StringLength(1)]
        public string Patched { get; set; }

        [StringLength(1)]
        public string PwdChg { get; set; }

        [StringLength(1)]
        public string NetForensicsAgent { get; set; }

        [StringLength(1)]
        public string PatchAgent { get; set; }

        [StringLength(1)]
        public string OSSupportSts { get; set; }

        [StringLength(1)]
        public string EncryptionAgent { get; set; }

        [StringLength(1)]
        public string AuthdWindowsDomain { get; set; }

        [StringLength(25)]
        public string Owner { get; set; }

        [StringLength(1)]
        public string ProxyAgent { get; set; }

        [StringLength(1)]
        public string MalwareAgent { get; set; }

        public DateTime? DiscoverTime { get; set; }

        public DateTime? ModelStarted { get; set; }

        public DateTime? ModelFinished { get; set; }

        public int? HungThreadCnt { get; set; }

        [StringLength(1)]
        public string HWSupportSts { get; set; }

        [StringLength(1)]
        public string DBSupportSts { get; set; }

        [StringLength(10)]
        public string IntegrationStatus { get; set; }

        public DateTime? IntegrationProcessDate { get; set; }

        public string IntegrationError { get; set; }
    }
}
