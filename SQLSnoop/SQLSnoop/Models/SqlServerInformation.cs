using System;

namespace SQLSnoop.Models
{
    class SqlServerInformation
    {
        public string BuildClrVersion { get; set; }
        public string Collation { get; set; }
        public int CollationID { get; set; }
        public int ComparisonStyle { get; set; }
        public string ComputerNamePhysicalNetBIOS { get; set; }
        public string Edition { get; set; }
        public int EditionID { get; set; }
        public int EngineEdition { get; set; }
        public int FilestreamConfiguredLevel { get; set; }
        public int FilestreamEffectiveLevel { get; set; }
        public string FilestreamShareName { get; set; }
        public int HadrManagerStatus { get; set; }
        public string InstanceName { get; set; }
        public int IsClustered { get; set; }
        public int IsFullTextInstalled { get; set; }
        public int IsHadrEnabled { get; set; }
        public int IsIntegratedSecurityOnly { get; set; }
        public int IsLocalDB { get; set; }
        public int IsSingleUser { get; set; }
        public int IsXTPSupported { get; set; }
        public int LCID { get; set; }
        public string LicenseType { get; set; }
        public string MachineName { get; set; }
        public int NumLicenses { get; set; }
        public int ProcessID { get; set; }
        public string ProductLevel { get; set; }
        public string ProductVersion { get; set; }
        public DateTime ResourceLastUpdateDateTime { get; set; }
        public string ResourceVersion { get; set; }
        public string ServerName { get; set; }
        public int SqlCharSet { get; set; }
        public string SqlCharSetName { get; set; }
        public int SqlSortOrder { get; set; }
        public string SqlSortOrderName { get; set; }
    }
}
