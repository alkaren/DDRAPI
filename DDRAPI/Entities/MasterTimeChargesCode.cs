using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DDRAPI.Entities
{
    public class MasterTimeChargesCode
    {
        [Key]
        [Column("ID", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("id")]
        public string ID { get; set; }

        [Column("NameCode", TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        [JsonPropertyName("nameCode")]
        public string? NameCode { get; set; }

        [Column("Description", TypeName = "VARCHAR(180)")]
        [StringLength(180)]
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [Column("Active", TypeName = "VARCHAR(180)")]
        [StringLength(180)]
        [JsonPropertyName("active")]
        public string? Active { get; set; }

        [Column("InActive", TypeName = "VARCHAR(180)")]
        [StringLength(180)]
        [JsonPropertyName("inActive")]
        public string? InActive { get; set; }

        [Column("Nochargeable", TypeName = "VARCHAR(180)")]
        [StringLength(180)]
        [JsonPropertyName("nochargeable")]
        public string? Nochargeable { get; set; }

        [Column("Condition", TypeName = "VARCHAR(180)")]
        [StringLength(180)]
        [JsonPropertyName("condition")]
        public string? Condition { get; set; }

        [Column("ActiveColumn", TypeName = "BOOLEAN")]
        [JsonPropertyName("activeColumn")]
        public bool? ActiveColumn { get; set; }

        [Column("InActiveColumn", TypeName = "BOOLEAN")]
        [JsonPropertyName("inActiveColumn")]
        public bool? InActiveColumn { get; set; }

        [Column("NonChargeableColumn", TypeName = "BOOLEAN")]
        [JsonPropertyName("nonChargeableColumn")]
        public bool? NonChargeableColumn { get; set; }

        [Column("SurfaceOrUnderground", TypeName = "VARCHAR(150)")]
        [JsonPropertyName("surfaceOrUnderground")]
        public string? SurfaceOrUnderground { get; set; }

        [Column("DrillMethod", TypeName = "VARCHAR(50)")]
        [JsonPropertyName("drillMethod")]
        public string? DrillMethod { get; set; }

        [Column("MetersDrilled", TypeName = "BOOLEAN")]
        [JsonPropertyName("metersDrilled")]
        public bool? MetersDrilled { get; set; }

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
