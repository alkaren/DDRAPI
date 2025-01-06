using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DDRAPI.Entities
{
    public class TransactionDownholeSurvey
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

        [Column("Depth", TypeName = "FLOAT")]
        [JsonPropertyName("depth")]
        public float? Depth { get; set; }

        [Column("Azimuth", TypeName = "FLOAT")]
        [JsonPropertyName("azimuth")]
        public float? Azimuth { get; set; }

        [Column("Dip", TypeName = "FLOAT")]
        [JsonPropertyName("dip")]
        public float? Dip { get; set; }

        [Column("Temp", TypeName = "FLOAT")]
        [JsonPropertyName("temp")]
        public float? Temp { get; set; }

        [Column("Magnetics", TypeName = "FLOAT")]
        [JsonPropertyName("magnetics")]
        public float? Magnetics { get; set; }

        [Column("Roll", TypeName = "FLOAT")]
        [JsonPropertyName("roll")]
        public float? Roll { get; set; }

        [Column("Remark", TypeName = "TEXT")]
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }

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
