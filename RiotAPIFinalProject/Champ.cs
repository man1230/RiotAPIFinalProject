namespace RiotAPIFinalProject
{
    public class Champ
    {
        public string ChampName { get; set; }

        public int ChampLevel { get; set; }

        public int ChampPoints { get; set; }

        public long PointsToNextLevel { get; set; }

        public bool ChestGranted { get; set; }

        public int TokensEarned { get; set; }


        public Champ(string name = null, int level = 0, int points = 0, long nextLevel = 0, bool chestGranted = false, int tokens = 0)
        {
            ChampName = name;
            ChampLevel = level;
            ChampPoints = points;
            PointsToNextLevel = nextLevel;
            ChestGranted = chestGranted;
            TokensEarned = tokens;
        }
    }
}
