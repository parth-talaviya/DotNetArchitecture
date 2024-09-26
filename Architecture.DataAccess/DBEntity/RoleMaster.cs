namespace LockTheVote.DataAccess.DBEntity
{
    public class RoleMaster
    {
        public long Id { get; set; }                 // Unique identifier for the role
        public string Name { get; set; }              // Name of the role (e.g., Voter, Admin, Candidate)
        public DateTime CreatedOn { get; set; }       // Date and time the record was created (UTC)
        public DateTime? UpdatedOn { get; set; }      // Date and time the record was last updated (UTC)
        public bool IsActive { get; set; }            // Status (1: Active, 0: Inactive)
        public bool IsDeleted { get; set; }           // Soft delete flag (1: Deleted, 0: Not Deleted)
        public long? CreatedBy { get; set; }          // Id for creator
        public long? UpdatedBy { get; set; }          // Id for the last updater
    }
}
