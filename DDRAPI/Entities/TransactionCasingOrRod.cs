using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DDRAPI.Entities
{
    public class TransactionCasingOrRod
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

        [Column("Size", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("size")]
        public string? Size { get; set; }

        [Column("Comment", TypeName = "TEXT")]
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        [Column("Length", TypeName = "FLOAT")]
        [JsonPropertyName("length")]
        public float? Length { get; set; }

        [Column("Units", TypeName = "FLOAT")]
        [JsonPropertyName("units")]
        public float? Units { get; set; }

        [Column("DepthMetre", TypeName = "FLOAT")]
        [JsonPropertyName("depthMetre")]
        public float? DepthMetre { get; set; }

        [Column("LeftInHole", TypeName = "FLOAT")]
        [JsonPropertyName("leftInHole")]
        public float? LeftInHole { get; set; }

        [Column("Metre", TypeName = "FLOAT")]
        [JsonPropertyName("metre")]
        public float? Metre { get; set; }

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
