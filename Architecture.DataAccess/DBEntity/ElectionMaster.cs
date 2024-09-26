namespace LockTheVote.DataAccess.DBEntity
{
    public class ElectionMaster
    {
        public long Id { get; set; }        // Unique identifier for the election
        public string Name { get; set; }     // Name of the election
        public string Description { get; set; } // Description of the election
        public DateTime ElectionDate { get; set; } // Date and time of the election (UTC)
        public DateTime CreatedOn { get; set; } // Date and time the election record was created (UTC)
        public DateTime? UpdatedOn { get; set; } // Date and time the record was last updated (UTC)
        public bool IsActive { get; set; } // Status (1: Active, 0: Inactive)
        public bool IsDeleted { get; set; } // Soft delete flag (1: Deleted, 0: Not Deleted)
        public long CreatedBy { get; set; } // FK to UserMaster(Id) for the admin who created the election
        public long? UpdatedBy { get; set; } // FK to UserMaster(Id) for the admin who updated the election
    }
}
