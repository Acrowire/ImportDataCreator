namespace FakeData.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProNetModel : DbContext
    {
        public ProNetModel()
            : base("name=ProNetModel")
        {
        }

        public virtual DbSet<ProNetScanResultStage> ProNetScanResultStages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.ScannerName)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.DataCenter)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.DeviceType)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.SystemType)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.PrimaryIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.listeners)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.DNSName)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.VM)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.SoftwareSource)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.ScanStart)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.Hostname)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.UCentralAuth)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.WhiteListAgent)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.AntiVirusAgent)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.SIEMAgent)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.DBSIEMAgent)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.FIMSAgent)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.DLPAgent)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.Patched)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.PwdChg)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.NetForensicsAgent)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.PatchAgent)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.OSSupportSts)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.EncryptionAgent)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.AuthdWindowsDomain)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.Owner)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.ProxyAgent)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.MalwareAgent)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.HWSupportSts)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.DBSupportSts)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.IntegrationStatus)
                .IsUnicode(false);

            modelBuilder.Entity<ProNetScanResultStage>()
                .Property(e => e.IntegrationError)
                .IsUnicode(false);
        }
    }
}
