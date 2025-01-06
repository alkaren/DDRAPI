using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DDRAPI.Entities
{
    public class MasterManPower
    {
        [Key]
        [Column("ID", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("id")]
        public string ID { get; set; }

        [Column("Name", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [Column("ManPowerId", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("manPowerId")]
        public string? ManPowerId { get; set; }

        [Column("Position", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("position")]
        public string? Position { get; set; }

        [Column("MasterVendorDDRId", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("masterVendorDDRId")]
        public string? MasterVendorDDRId { get; set; }

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
