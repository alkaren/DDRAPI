using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DDRAPI.Entities
{
    public class TransactionTimeChargesMetresDrilled
    {
        [Key]
        [Column("ID", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("id")]
        public string ID { get; set; }

        [Column("DDRTransactionHeaderId", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("transactionHeaderId")]
        [ForeignKey("TransactionHeader")]
        public string? TransactionHeaderId { get; set; }
        public virtual TransactionHeader TransactionHeader { get; set; }

        [Column("FromTime", TypeName = "INTERVAL")]
        [JsonPropertyName("fromTime")]
        public TimeSpan? FromTime { get; set; }

        [Column("To", TypeName = "INTERVAL")]
        [JsonPropertyName("to")]
        public TimeSpan? To { get; set; }

        [Column("MasterTimeChargesCodeId", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("timeChargesCodeId")]
        [ForeignKey("MasterTimeChargesCode")]
        public string? MasterTimeChargesCodeId { get; set; }
        public virtual MasterTimeChargesCode MasterTimeChargesCode { get; set; }

        [Column("Comments", TypeName = "TEXT")]
        [JsonPropertyName("comments")]
        public string? Comments { get; set; }

        [Column("Standby", TypeName = "INTERVAL")]
        [JsonPropertyName("standby")]
        public TimeSpan? Standby { get; set; }

        [Column("Active", TypeName = "INTERVAL")]
        [JsonPropertyName("active")]
        public TimeSpan? Active { get; set; }

        [Column("NoCharge", TypeName = "INTERVAL")]
        [JsonPropertyName("noCharge")]
        public TimeSpan? NoCharge { get; set; }

        [Column("MasterMetresDrilledCoreSizeId", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("masterMetresDrilledCoreSizeId")]
        [ForeignKey("MasterMetresDrilledCoreSize")]
        public string? MasterMetresDrilledCoreSizeId { get; set; }
        public virtual MasterMetresDrilledCoreSize MasterMetresDrilledCoreSize { get; set; }

        [Column("FromMetresDrilled", TypeName = "FLOAT")]
        [JsonPropertyName("fromMetresDrilled")]
        public float? FromMetresDrilled { get; set; }

        [Column("ToMetresDrilled", TypeName = "FLOAT")]
        [JsonPropertyName("toMetresDrilled")]
        public float? ToMetresDrilled { get; set; }

        [Column("RecoveredCore", TypeName = "FLOAT")]
        [JsonPropertyName("recoveredCore")]
        public float? RecoveredCore { get; set; }

        [Column("PercentageRecovered", TypeName = "FLOAT")]
        [JsonPropertyName("percentageRecovered")]
        public float? PercentageRecovered { get; set; }

        [Column("WaterReturn", TypeName = "FLOAT")]
        [JsonPropertyName("waterReturn")]
        public float? WaterReturn { get; set; }

        [Column("Circulation", TypeName = "FLOAT")]
        [JsonPropertyName("circulation")]
        public float? Circulation { get; set; }

        [Column("HoleId", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("holeId")]
        public string? HoleId { get; set; }

        [Column("HoleTypeId", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("holeTypeId")]
        [ForeignKey("MasterHoleType")]
        public string? HoleTypeId { get; set; }
        public virtual MasterHoleType MasterHoleType { get; set; }

        [Column("DIP", TypeName = "FLOAT")]
        [JsonPropertyName("dip")]
        public float? DIP { get; set; }

        [Column("IsBooster", TypeName = "BOOLEAN")]
        [JsonPropertyName("isBooster")]
        public bool? IsBooster { get; set; }

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
