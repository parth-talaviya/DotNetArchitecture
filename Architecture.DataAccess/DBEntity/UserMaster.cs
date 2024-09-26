namespace LockTheVote.DataAccess.DBEntity
{
    public class UserMaster
    {
        public long Id { get; set; }             // Unique identifier for the user
        public long RoleId { get; set; }        // FK to RoleMaster(Id) representing the user's role
        public string UserName { get; set; }    // Username for login
        public string Email { get; set; }       // Email address of the user
        public string PasswordHash { get; set; } // Encrypted password for login
        public DateTime CreatedOn { get; set; } // Date and time the user record was created (UTC)
        public DateTime? UpdatedOn { get; set; } // Date and time the record was last updated (UTC)
        public bool IsActive { get; set; }      // Status (1: Active, 0: Inactive)
        public bool IsDeleted { get; set; }     // Soft delete flag (1: Deleted, 0: Not Deleted)
        public string FirstName { get; set; }   // First name of the user
        public string LastName { get; set; }    // Last name of the user
        public long Gender { get; set; }        // FK to ConfigurationMaster for Gender
        public string Other { get; set; }       // Specification of other Gender
        public long Age { get; set; }           // FK to ConfigurationMaster for Age
        public string VotingIdNumber { get; set; } // Government-certified voting ID number
        public string VotingDocumentProofUrl { get; set; } // URL for the uploaded voting document proof
        public long RegionId { get; set; }      // FK to RegionMaster(Id) for user's region
        public string AuthProvider { get; set; } // Stored as string (e.g., "Google", "Apple").
        public string ExternalAuthID { get; set; } // Unique ID from Google/Apple login.
    }

    public enum AuthProvider
    {
        Google,
        Apple
    }
}
