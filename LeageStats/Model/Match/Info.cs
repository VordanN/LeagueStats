
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model.Match
{

    public class Info
    {
        public Info(
            long gameCreation,
            int gameDuration,
            int gameId,
            string gameMode,
            string gameName,
            long gameStartTimestamp,
            string gameType,
            string gameVersion,
            int mapId,
            List<Participant> participants,
            string platformId,
            int queueId,
            List<Team> teams
        )
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

        public long gameCreation { get; }
        public int gameDuration { get; }
        public int gameId { get; }
        public string gameMode { get; }
        public string gameName { get; }
        public long gameStartTimestamp { get; }
        public string gameType { get; }
        public string gameVersion { get; }
        public int mapId { get; }
        public List<Participant> participants { get; }
        public string platformId { get; }
        public int queueId { get; }
        public List<Team> teams { get; }
    }


}
