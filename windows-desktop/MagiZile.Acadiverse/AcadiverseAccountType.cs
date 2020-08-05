namespace MagiZile.Acadiverse
{
    public enum AcadiverseAccountType
    { 
        /// <summary>
        /// Student accounts can be used to access the game as well as most functions of the website and desktop/mobile clients.
        /// </summary>
        Student,

        /// <summary>
        /// Parent accounts can be used for all features available to Student accounts as well as to view the progress of their children (Student accounts created by them).
        /// </summary>
        Parent,

        /// <summary>
        /// Teacher accounts can be used for all features available to Student and Parent accounts ("View Child PRogress" is replaced with "View Student Progress"), as well as to create classroom discussions and use Acadiverse LEsson Studio.
        /// </summary>
        Teacher
    };
}
