using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DDRAPI.Entities
{
    public class TransactionHeader
    {
        [Key]
        [Column("ID", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("id")]
        public string ID { get; set; }

        [Column("MasterRigId", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("masterRigId")]
        public string? MasterRigId { get; set; }

        [Column("Month", TypeName = "VARCHAR(20)")]
        [JsonPropertyName("month")]
        public string? Month { get; set; }

        [Column("DDRNumber", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("ddrNumber")]
        public string? DDRNumber { get; set; }

        [Column("DDRDate", TypeName = "TIMESTAMP")]
        [JsonPropertyName("ddrDate")]
        public DateTime? DDRDate { get; set; }

        [Column("Shift", TypeName = "VARCHAR(50)")]
        [JsonPropertyName("shift")]
        public string? Shift { get; set; }

        [Column("Client", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("client")]
        public string? Client { get; set; }

        [Column("Project", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("project")]
        public string? Project { get; set; }

        [Column("Location", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("location")]
        public string? Location { get; set; }

        [Column("Level", TypeName = "VARCHAR(50)")]
        [JsonPropertyName("level")]
        public string? Level { get; set; }

        [Column("HoleID", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("holeId")]
        public string? HoleID { get; set; }

        [Column("DIP", TypeName = "VARCHAR(50)")]
        [JsonPropertyName("dip")]
        public string? DIP { get; set; }

        [Column("HazardsReported", TypeName = "VARCHAR(100)")]
        [JsonPropertyName("hazardsReported")]
        public string? HazardsReported { get; set; }

        [Column("IncidentsReported", TypeName = "VARCHAR(100)")]
        [JsonPropertyName("incidentsReported")]
        public string? IncidentsReported { get; set; }

        [Column("EngineHoursStart", TypeName = "FLOAT")]
        [JsonPropertyName("engineHoursStart")]
        public float? EngineHoursStart { get; set; }

        [Column("EngineHoursFinish", TypeName = "FLOAT")]
        [JsonPropertyName("engineHoursFinish")]
        public float? EngineHoursFinish { get; set; }

        [Column("EngineHours", TypeName = "FLOAT")]
        [JsonPropertyName("engineHours")]
        public float? EngineHours { get; set; }

        [Column("DrillMethod", TypeName = "VARCHAR(50)")]
        [JsonPropertyName("drillMethod")]
        public string? DrillMethod { get; set; }

        [Column("DrillHours", TypeName = "INTERVAL")]
        [JsonPropertyName("drillHours")]
        public TimeSpan? DrillHours { get; set; }

        [Column("PTIIComments", TypeName = "VARCHAR(200)")]
        [JsonPropertyName("ptiiComments")]
        public string? PTIIComments { get; set; }

        [Column("BSIRepresentativeComments", TypeName = "VARCHAR(200)")]
        [JsonPropertyName("bsiRepresentativeComments")]
        public string? BSIRepresentativeComments { get; set; }

        [Column("MyPWaterHydrologyCommentsroperty", TypeName = "VARCHAR(200)")]
        [JsonPropertyName("myPWaterHydrologyCommentsroperty")]
        public string? MyPWaterHydrologyCommentsroperty { get; set; }

        [Column("Status", TypeName = "INTEGER")]
        [JsonPropertyName("status")]
        public int Status { get; set; }

        [Column("CurrentApproval", TypeName = "INTEGER")]
        [JsonPropertyName("currentApproval")]
        public int CurrentApproval { get; set; }

        [Column("NextApproval", TypeName = "INTEGER")]
        [JsonPropertyName("nextApproval")]
        public int NextApproval { get; set; }

        [Column("DownHoleToolType", TypeName = "VARCHAR(200)")]
        [JsonPropertyName("downHoleToolType")]
        public string? DownHoleToolType { get; set; }

        [Column("DownHoleUnit", TypeName = "VARCHAR(200)")]
        [JsonPropertyName("downHoleUnit")]
        public string? DownHoleUnit { get; set; }

        [Column("MasterVendorDDRId", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("masterVendorDDRId")]
        public string? MasterVendorDDRId { get; set; }

        [Column("FieldComment", TypeName = "TEXT")]
        [JsonPropertyName("fieldComment")]
        public string? FieldComment { get; set; }

        [Column("CompanyId", TypeName = "VARCHAR(128)")]
        [JsonPropertyName("companyId")]
        public string? CompanyId { get; set; }

        [Column("TenantId", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("tenantId")]
        public string? TenantId { get; set; }

        [Column("CreatedBy", TypeName = "VARCHAR(128)")]
        [JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        [Column("CreatedDate", TypeName = "TIMESTAMP")]
        [JsonPropertyName("createdDate")]
        public DateTime? CreatedDate { get; set; }

        [Column("UpdatedBy", TypeName = "VARCHAR(128)")]
        [JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        [Column("UpdatedDate", TypeName = "TIMESTAMP")]
        [JsonPropertyName("updatedDate")]
        public DateTime? UpdatedDate { get; set; }

        [Column("DeletedBy", TypeName = "VARCHAR(128)")]
        [JsonPropertyName("deletedBy")]
        public string? DeletedBy { get; set; }

        [Column("DeletedDate", TypeName = "TIMESTAMP")]
        [JsonPropertyName("deletedDate")]
        public DateTime? DeletedDate { get; set; }

        [Column("IsActived")]
        [JsonPropertyName("isActived")]
        public bool IsActived { get; set; }

    }
}
