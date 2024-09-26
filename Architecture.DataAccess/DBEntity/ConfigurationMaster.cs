namespace LockTheVote.DataAccess.DBEntity
{
    public class ConfigurationMaster
    {
        public long Id { get; set; }                 // Unique identifier for the configuration
        public string Name { get; set; }              // It is configuration like AgeRange | Gender
        public string Value { get; set; }             // Value of the configuration
        public bool IsActive { get; set; }            // Status (1: Active, 0: Inactive)
        public DateTime CreatedOn { get; set; }       // Date and time the record was created (UTC)
        public DateTime? UpdatedOn { get; set; }      // Date and time the record was last updated (UTC)
        public long CreatedBy { get; set; }           // Id for creator
        public long? UpdatedBy { get; set; }          // Id for the last updater
    }
}
