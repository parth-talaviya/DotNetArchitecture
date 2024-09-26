using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockTheVote.DataAccess.DBEntity
{
    public class CandidateMaster
    {
        public long Id { get; set; }        // Unique identifier for the candidate
        public long UserId { get; set; }     // Reference to UserMaster(Id)
        public long ElectionId { get; set; } // Reference to ElectionMaster(Id)
        public DateTime CreatedOn { get; set; } // Date and time the election record was created (UTC)
        public DateTime? UpdatedOn { get; set; } // Date and time the record was last updated (UTC)
        public bool IsActive { get; set; }      // Status (1: Active, 0: Inactive)
        public bool IsDeleted { get; set; }      // Soft delete flag (1: Deleted, 0: Not Deleted)
        public long CreatedBy { get; set; }      // FK to UserMaster(Id) for the admin who created the candidate
        public long UpdatedBy { get; set; }     // FK to UserMaster(Id) for the admin who updated the candidate
    }
}
