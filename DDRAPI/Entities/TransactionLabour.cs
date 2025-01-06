using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DDRAPI.Entities
{
    public class TransactionLabour
    {
        [Key]
        [Column("ID", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("id")]
        public string ID { get; set; }

        [Column("DDRTransactionHeaderId", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("ddrTransactionHeaderId")]
        [ForeignKey("TransactionHeader")]
        public string? TransactionHeaderId { get; set; }
        public virtual TransactionHeader TransactionHeader { get; set; }

        [Column("MasterManPowerId", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("masterManPowerId")]
        [ForeignKey("MasterManPower")]
        public string? MasterManPowerId { get; set; }
        public virtual MasterManPower MasterManPower { get; set; }

        [Column("IsSupervisor", TypeName = "BOOLEAN")]
        [JsonPropertyName("isSupervisor")]
        public bool? IsSupervisor { get; set; }

        [Column("IsDriller", TypeName = "BOOLEAN")]
        [JsonPropertyName("isDriller")]
        public bool? IsDriller { get; set; }

        [Column("IsOffsider", TypeName = "BOOLEAN")]
        [JsonPropertyName("isOffsider")]
        public bool? IsOffsider { get; set; }

        [Column("Position", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("position")]
        public string? Position { get; set; }

        [Column("Hours", TypeName = "FLOAT")]
        [JsonPropertyName("hours")]
        public float? Hours { get; set; }

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
