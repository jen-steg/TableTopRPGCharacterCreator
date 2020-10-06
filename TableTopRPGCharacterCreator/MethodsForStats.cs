namespace TableTopRPGCharacterCreator
{
    internal class MethodsForStats
    {
        static int disposableAbilityScorePoints = 54; // total disposable points used for manually setting 6 ability scores
        //str, per, end, ch, _int, ag, lk  - order in abilityScoresArray
        public static int[] abilityScoresArray = { 5, 5, 5, 5, 5, 5, 5 };

        public static int increment = 1;

        public static int DisposableAbilityScorePoints
        {
            get => disposableAbilityScorePoints;
            set
            {
                if (value > 0)
                {
                    disposableAbilityScorePoints = value;
                }// end if
                else
                {
                    disposableAbilityScorePoints = 0;
                } // end else
            } // end setter
        } // end properties for the disposableAbilityScorePoints

        public static int ModifyDisposableAbilityScorePoints(int currentScore, int savedScore, out int setScore)
        {
            setScore = 0;
            if (currentScore > savedScore)
            {
                if (DisposableAbilityScorePoints == 0)
                {
                    setScore = savedScore;
                    DisposableAbilityScorePoints--;
                } // end nested if
            } // end outer if
            else if (currentScore < savedScore)
            {
                DisposableAbilityScorePoints++;
            } // end else if
            return DisposableAbilityScorePoints;
        } // end method to modify the disposable ability score points
    }
}