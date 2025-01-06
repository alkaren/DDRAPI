using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DDRAPI.Entities
{
    public class TransactionApprovalComment
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

        [Column("Comments", TypeName = "TEXT")]
        [JsonPropertyName("comments")]
        public string? Comments { get; set; }

        [Column("Others", TypeName = "TEXT")]
        [JsonPropertyName("others")]
        public string? Others { get; set; }

        [Column("Status", TypeName = "INTEGER")]
        [JsonPropertyName("status")]
        public int? Status { get; set; } // 1: Approved, 2: Revised, null: pending

        [Column("SignOffBy", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("signOffBy")]
        public string? SignOffBy { get; set; }

        [Column("SignOffDateTime", TypeName = "TIMESTAMP")]
        [JsonPropertyName("signOffDateTime")]
        public DateTime? SignOffDateTime { get; set; }

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
