using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;
namespace LeageStats.Model.Match
{
    public class Participant
    {
        public Participant()
        {
        }

        public Participant(
            int assists,
            int baronKills,
            int bountyLevel,
            int champExperience,
            int champLevel,
            int championId,
            string championName,
            int championTransform,
            int consumablesPurchased,
            int damageDealtToBuildings,
            int damageDealtToObjectives,
            int damageDealtToTurrets,
            int damageSelfMitigated,
            int deaths,
            int detectorWardsPlaced,
            int doubleKills,
            int dragonKills,
            bool firstBloodAssist,
            bool firstBloodKill,
            bool firstTowerAssist,
            bool firstTowerKill,
            bool gameEndedInEarlySurrender,
            bool gameEndedInSurrender,
            int goldEarned,
            int goldSpent,
            string individualPosition,
            int inhibitorKills,
            int inhibitorsLost,
            int item0,
            int item1,
            int item2,
            int item3,
            int item4,
            int item5,
            int item6,
            int itemsPurchased,
            int killingSprees,
            int kills,
            string lane,
            int largestCriticalStrike,
            int largestKillingSpree,
            int largestMultiKill,
            int longestTimeSpentLiving,
            int magicDamageDealt,
            int magicDamageDealtToChampions,
            int magicDamageTaken,
            int neutralMinionsKilled,
            int nexusKills,
            int nexusLost,
            int objectivesStolen,
            int objectivesStolenAssists,
            int participantId,
            int pentaKills,
            Perks perks,
            int physicalDamageDealt,
            int physicalDamageDealtToChampions,
            int physicalDamageTaken,
            int profileIcon,
            string puuid,
            int quadraKills,
            string riotIdName,
            string riotIdTagline,
            string role,
            int sightWardsBoughtInGame,
            int spell1Casts,
            int spell2Casts,
            int spell3Casts,
            int spell4Casts,
            int summoner1Casts,
            int summoner1Id,
            int summoner2Casts,
            int summoner2Id,
            string summonerId,
            int summonerLevel,
            string summonerName,
            bool teamEarlySurrendered,
            int teamId,
            string teamPosition,
            int timeCCingOthers,
            int timePlayed,
            int totalDamageDealt,
            int totalDamageDealtToChampions,
            int totalDamageShieldedOnTeammates,
            int totalDamageTaken,
            int totalHeal,
            int totalHealsOnTeammates,
            int totalMinionsKilled,
            int totalTimeCCDealt,
            int totalTimeSpentDead,
            int totalUnitsHealed,
            int tripleKills,
            int trueDamageDealt,
            int trueDamageDealtToChampions,
            int trueDamageTaken,
            int turretKills,
            int turretsLost,
            int unrealKills,
            int visionScore,
            int visionWardsBoughtInGame,
            int wardsKilled,
            int wardsPlaced,
            bool win
        )
        {
            this.assists = assists;
            this.baronKills = baronKills;
            this.bountyLevel = bountyLevel;
            this.champExperience = champExperience;
            this.champLevel = champLevel;
            this.championId = championId;
            this.championName = championName;
            this.championTransform = championTransform;
            this.consumablesPurchased = consumablesPurchased;
            this.damageDealtToBuildings = damageDealtToBuildings;
            this.damageDealtToObjectives = damageDealtToObjectives;
            this.damageDealtToTurrets = damageDealtToTurrets;
            this.damageSelfMitigated = damageSelfMitigated;
            this.deaths = deaths;
            this.detectorWardsPlaced = detectorWardsPlaced;
            this.doubleKills = doubleKills;
            this.dragonKills = dragonKills;
            this.firstBloodAssist = firstBloodAssist;
            this.firstBloodKill = firstBloodKill;
            this.firstTowerAssist = firstTowerAssist;
            this.firstTowerKill = firstTowerKill;
            this.gameEndedInEarlySurrender = gameEndedInEarlySurrender;
            this.gameEndedInSurrender = gameEndedInSurrender;
            this.goldEarned = goldEarned;
            this.goldSpent = goldSpent;
            this.individualPosition = individualPosition;
            this.inhibitorKills = inhibitorKills;
            this.inhibitorsLost = inhibitorsLost;
            this.item0 = item0;
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item5 = item5;
            this.item6 = item6;
            this.itemsPurchased = itemsPurchased;
            this.killingSprees = killingSprees;
            this.kills = kills;
            this.lane = lane;
            this.largestCriticalStrike = largestCriticalStrike;
            this.largestKillingSpree = largestKillingSpree;
            this.largestMultiKill = largestMultiKill;
            this.longestTimeSpentLiving = longestTimeSpentLiving;
            this.magicDamageDealt = magicDamageDealt;
            this.magicDamageDealtToChampions = magicDamageDealtToChampions;
            this.magicDamageTaken = magicDamageTaken;
            this.neutralMinionsKilled = neutralMinionsKilled;
            this.nexusKills = nexusKills;
            this.nexusLost = nexusLost;
            this.objectivesStolen = objectivesStolen;
            this.objectivesStolenAssists = objectivesStolenAssists;
            this.participantId = participantId;
            this.pentaKills = pentaKills;
            this.perks = perks;
            this.physicalDamageDealt = physicalDamageDealt;
            this.physicalDamageDealtToChampions = physicalDamageDealtToChampions;
            this.physicalDamageTaken = physicalDamageTaken;
            this.profileIcon = profileIcon;
            this.puuid = puuid;
            this.quadraKills = quadraKills;
            this.riotIdName = riotIdName;
            this.riotIdTagline = riotIdTagline;
            this.role = role;
            this.sightWardsBoughtInGame = sightWardsBoughtInGame;
            this.spell1Casts = spell1Casts;
            this.spell2Casts = spell2Casts;
            this.spell3Casts = spell3Casts;
            this.spell4Casts = spell4Casts;
            this.summoner1Casts = summoner1Casts;
            this.summoner1Id = summoner1Id;
            this.summoner2Casts = summoner2Casts;
            this.summoner2Id = summoner2Id;
            this.summonerId = summonerId;
            this.summonerLevel = summonerLevel;
            this.summonerName = summonerName;
            this.teamEarlySurrendered = teamEarlySurrendered;
            this.teamId = teamId;
            this.teamPosition = teamPosition;
            this.timeCCingOthers = timeCCingOthers;
            this.timePlayed = timePlayed;
            this.totalDamageDealt = totalDamageDealt;
            this.totalDamageDealtToChampions = totalDamageDealtToChampions;
            this.totalDamageShieldedOnTeammates = totalDamageShieldedOnTeammates;
            this.totalDamageTaken = totalDamageTaken;
            this.totalHeal = totalHeal;
            this.totalHealsOnTeammates = totalHealsOnTeammates;
            this.totalMinionsKilled = totalMinionsKilled;
            this.totalTimeCCDealt = totalTimeCCDealt;
            this.totalTimeSpentDead = totalTimeSpentDead;
            this.totalUnitsHealed = totalUnitsHealed;
            this.tripleKills = tripleKills;
            this.trueDamageDealt = trueDamageDealt;
            this.trueDamageDealtToChampions = trueDamageDealtToChampions;
            this.trueDamageTaken = trueDamageTaken;
            this.turretKills = turretKills;
            this.turretsLost = turretsLost;
            this.unrealKills = unrealKills;
            this.visionScore = visionScore;
            this.visionWardsBoughtInGame = visionWardsBoughtInGame;
            this.wardsKilled = wardsKilled;
            this.wardsPlaced = wardsPlaced;
            this.win = win;
        }

        public int assists { get; }
        public int baronKills { get; }
        public int bountyLevel { get; }
        public int champExperience { get; }
        public int champLevel { get; }
        public int championId { get; }
        public string championName { get; }
        public int championTransform { get; }
        public int consumablesPurchased { get; }
        public int damageDealtToBuildings { get; }
        public int damageDealtToObjectives { get; }
        public int damageDealtToTurrets { get; }
        public int damageSelfMitigated { get; }
        public int deaths { get; }
        public int detectorWardsPlaced { get; }
        public int doubleKills { get; }
        public int dragonKills { get; }
        public bool firstBloodAssist { get; }
        public bool firstBloodKill { get; }
        public bool firstTowerAssist { get; }
        public bool firstTowerKill { get; }
        public bool gameEndedInEarlySurrender { get; }
        public bool gameEndedInSurrender { get; }
        public int goldEarned { get; }
        public int goldSpent { get; }
        public string individualPosition { get; }
        public int inhibitorKills { get; }
        public int inhibitorsLost { get; }
        public int item0 { get; }
        public int item1 { get; }
        public int item2 { get; }
        public int item3 { get; }
        public int item4 { get; }
        public int item5 { get; }
        public int item6 { get; }
        public int itemsPurchased { get; }
        public int killingSprees { get; }
        public int kills { get; }
        public string lane { get; }
        public int largestCriticalStrike { get; }
        public int largestKillingSpree { get; }
        public int largestMultiKill { get; }
        public int longestTimeSpentLiving { get; }
        public int magicDamageDealt { get; }
        public int magicDamageDealtToChampions { get; }
        public int magicDamageTaken { get; }
        public int neutralMinionsKilled { get; }
        public int nexusKills { get; }
        public int nexusLost { get; }
        public int objectivesStolen { get; }
        public int objectivesStolenAssists { get; }
        public int participantId { get; }
        public int pentaKills { get; }
        public Perks perks { get; }
        public int physicalDamageDealt { get; }
        public int physicalDamageDealtToChampions { get; }
        public int physicalDamageTaken { get; }
        public int profileIcon { get; }
        public string puuid { get; }
        public int quadraKills { get; }
        public string riotIdName { get; }
        public string riotIdTagline { get; }
        public string role { get; }
        public int sightWardsBoughtInGame { get; }
        public int spell1Casts { get; }
        public int spell2Casts { get; }
        public int spell3Casts { get; }
        public int spell4Casts { get; }
        public int summoner1Casts { get; }
        public int summoner1Id { get; }
        public int summoner2Casts { get; }
        public int summoner2Id { get; }
        public string summonerId { get; }
        public int summonerLevel { get; }
        public string summonerName { get; }
        public bool teamEarlySurrendered { get; }
        public int teamId { get; }
        public string teamPosition { get; }
        public int timeCCingOthers { get; }
        public int timePlayed { get; }
        public int totalDamageDealt { get; }
        public int totalDamageDealtToChampions { get; }
        public int totalDamageShieldedOnTeammates { get; }
        public int totalDamageTaken { get; }
        public int totalHeal { get; }
        public int totalHealsOnTeammates { get; }
        public int totalMinionsKilled { get; }
        public int totalTimeCCDealt { get; }
        public int totalTimeSpentDead { get; }
        public int totalUnitsHealed { get; }
        public int tripleKills { get; }
        public int trueDamageDealt { get; }
        public int trueDamageDealtToChampions { get; }
        public int trueDamageTaken { get; }
        public int turretKills { get; }
        public int turretsLost { get; }
        public int unrealKills { get; }
        public int visionScore { get; }
        public int visionWardsBoughtInGame { get; }
        public int wardsKilled { get; }
        public int wardsPlaced { get; }
        public bool win { get; }
    }
}

