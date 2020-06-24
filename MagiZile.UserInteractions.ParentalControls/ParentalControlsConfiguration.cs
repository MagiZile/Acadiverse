using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.UserInteractions.ParentalControls
{
    class ParentalControlsConfiguration
    {
        public string filename = "";
        public MovieRating maxMoveRating = MovieRating.NC17;
        public GameRating maxGameRating = GameRating.AdultPlayers;
        public TimeSpan timeLimit = new TimeSpan(2, 0, 0);
        public DateTime punishmentEndDate = new DateTime();
        public bool punishmentActive = true;

        public ParentalControlsConfiguration(string filename)
        {
            this.filename = filename;
            maxGameRating = GameRating.AdultPlayers;
            maxMoveRating = MovieRating.NC17;
            timeLimit = new TimeSpan(2, 0, 0);
        }

        public override string ToString()
        {
            return "Filename: " + filename + "\nMaximum Game Rating: " + maxGameRating + "\nMaximum Movie Rating: " + maxGameRating + "\nTime Limit" + timeLimit;
        }
    }
}