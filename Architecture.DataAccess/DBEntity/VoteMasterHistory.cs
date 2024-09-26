namespace LockTheVote.DataAccess.DBEntity
{
    public class VoteMasterHistory
    {
        public long VoteId { get; set; } // Unique identifier for the historical vote (copied from VoteMaster)
        public long ElectionId { get; set; } // Reference to the ElectionMaster(Id)
        public long UserId { get; set; } // Reference to the UserMaster(Id) (voter ID)
        public bool IsFinalVote { get; set; } // Status (1: IsVoted, 0: IsNotVoted)
        public long CandidateId { get; set; } // Reference to the CandidateMaster(Id)
        public DateTime VoteDate { get; set; } // Date when the vote was cast (UTC)
        public DateTime CreatedOn { get; set; } // Date and time when the historical record was created
        public DateTime? UpdatedOn { get; set; } // Date and time the record was last updated (UTC)
        public long CreatedBy { get; set; } // FK to UserMaster(Id) for the admin who created the vote
        public long UpdatedBy { get; set; } // FK to UserMaster(Id) for the admin who updated the vote
    }
}
