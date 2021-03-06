namespace RetroAchievementTracker.Data.GameData
{
    public class GameData
    {
        public int Id { get; set; }
        public string RAURL { get; set; }
        public string Title { get; set; }
        public string ConsoleName { get; set; }
        public string ImageIcon { get; set; }
        public string ImageIngame { get; set; }
        public string ImageBoxArt { get; set; }
        public string Genre { get; set; }
        public int AchievementCount { get; set; }
        public int AchievementsUnlocked { get; set; }
        public string PercentageCompleted { get; set; }
        public int PlayersCasual { get; set; }
        public int PlayersHardcore { get; set; }
        public Dictionary<string, Achievement> Achievements { get; set; }
        public bool GameTracked { get; set; }
        public string LoggedInUser { get; set; }
    }
    public class Achievement
    {
        public long NumAwarded { get; set; }
        public long NumAwardedHardcore { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long Points { get; set; }
        public string BadgeUrl { get; set; }
        public DateTimeOffset? DateEarned { get; set; }
        public DateTimeOffset? DateEarnedHardcore { get; set; }
    }
}
