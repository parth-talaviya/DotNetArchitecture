namespace LockTheVote.DataAccess.DBEntity
{
    public class VoteMaster
    {
        public long Id { get; set; } // Unique identifier for the vote
        public long VoterId { get; set; } // Reference to UserMaster(Id) for the voter
        public bool IsFinalVote { get; set; } // Status (1: IsVoted, 0: IsNotVoted)
        public long CandidateId { get; set; } // Reference to CandidateMaster(Id)
        public long ElectionId { get; set; } // Reference to ElectionMaster(Id)
        public DateTime VoteDate { get; set; } // Date when the vote was cast (UTC)
        public DateTime CreatedOn { get; set; } // Date and time the election record was created (UTC)
        public DateTime? UpdatedOn { get; set; } // Date and time the record was last updated (UTC)
        public long? CreatedBy { get; set; } // FK to UserMaster(Id) for the admin who created the vote
        public long? UpdatedBy { get; set; } // FK to UserMaster(Id) for the admin who updated the vote
    }

}
