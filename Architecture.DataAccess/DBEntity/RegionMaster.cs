namespace LockTheVote.DataAccess.DBEntity
{
    public class RegionMaster
    {
        public long Id { get; set; }                 // Unique identifier for the region (Auto Generate)
        public string Name { get; set; }              // Name of the region
        public DateTime CreatedOn { get; set; }       // Date when the region was created
        public DateTime? UpdatedOn { get; set; }      // Date when the region was updated
        public bool IsActive { get; set; }            // Status (1: Active, 0: Inactive)
        public bool IsDeleted { get; set; }           // Soft delete flag
        public long CreatedBy { get; set; }           // Id for creator
        public long? UpdatedBy { get; set; }          // Id for the last updater
    }
}
