namespace MagiZile.Acadiverse
{
    public enum AcadiverseNotificationType
    {
        /// <summary>
        /// A user's submission was commented on.
        /// </summary>
        SubmissionComment,

        /// <summary>
        /// A user's submission was upvoted.
        /// </summary>
        SubmissionUpvote,

        /// <summary>
        /// A user's submission was featured.
        /// </summary>
        SubmissionFeatured,

        /// <summary>
        /// A user received an achievement.
        /// </summary>
        AcheivementReceived,

        /// <summary>
        /// A user received a PM.
        /// </summary>
        PMReceived,

        /// <summary>
        /// A user was mentioned in chat or in the comments for a submission.
        /// </summary>
        Mentioned
    };
}