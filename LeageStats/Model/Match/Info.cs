
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model.Match
{
    /// <summary>
    /// Основной класс в котором описана вся игра
    /// </summary>
    public class Info
    {
        public Info(long gameCreation, int gameDuration, int gameId, string gameMode, string gameName, long gameStartTimestamp, string gameType, string gameVersion, int mapId, List<Participant> participants, string platformId, int queueId, List<Team> teams)
        {
            this.gameCreation = gameCreation;
            this.gameDuration = gameDuration;
            this.gameId = gameId;
            this.gameMode = gameMode;
            this.gameName = gameName;
            this.gameStartTimestamp = gameStartTimestamp;
            this.gameType = gameType;
            this.gameVersion = gameVersion;
            this.mapId = mapId;
            this.participants = participants;
            this.platformId = platformId;
            this.queueId = queueId;
            this.teams = teams;
        }

        public long gameCreation { get; set; }
        public int gameDuration { get; set; }
        public int gameId { get; set; }
        public string gameMode { get; set; }
        public string gameName { get; set; }
        public long gameStartTimestamp { get; set; }
        public string gameType { get; set; }
        public string gameVersion { get; set; }
        public int mapId { get; set; }
        public List<Participant> participants { get; set; }
        public string platformId { get; set; }
        public int queueId { get; set; }
        public List<Team> teams { get; set; }
    }

}
