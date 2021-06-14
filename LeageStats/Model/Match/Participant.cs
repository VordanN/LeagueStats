using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeageStats.Model.Match
{
    /// <summary>
    /// я кстати один раз писал его своими ручками
    /// и конструктор
    /// авыхха
    /// класс информации о игроке и его персонажа
    /// </summary>
    public class Participant
    {
        public Participant()
        {
        }

        public Participant(int assists, int baronKills, int bountyLevel, int champExperience, int champLevel, int championId, string championName, int championTransform, int consumablesPurchased, int damageDealtToBuildings, int damageDealtToObjectives, int damageDealtToTurrets, int damageSelfMitigated, int deaths, int detectorWardsPlaced, int doubleKills, int dragonKills, bool firstBloodAssist, bool firstBloodKill, bool firstTowerAssist, bool firstTowerKill, bool gameEndedInEarlySurrender, bool gameEndedInSurrender, int goldEarned, int goldSpent, string individualPosition, int inhibitorKills, int inhibitorsLost, int item0, int item1, int item2, int item3, int item4, int item5, int item6, int itemsPurchased, int killingSprees, int kills, string lane, int largestCriticalStrike, int largestKillingSpree, int largestMultiKill, int longestTimeSpentLiving, int magicDamageDealt, int magicDamageDealtToChampions, int magicDamageTaken, int neutralMinionsKilled, int nexusKills, int nexusLost, int objectivesStolen, int objectivesStolenAssists, int participantId, int pentaKills, Perks perks, int physicalDamageDealt, int physicalDamageDealtToChampions, int physicalDamageTaken, int profileIcon, string puuid, int quadraKills, string riotIdName, string riotIdTagline, string role, int sightWardsBoughtInGame, int spell1Casts, int spell2Casts, int spell3Casts, int spell4Casts, int summoner1Casts, int summoner1Id, int summoner2Casts, int summoner2Id, string summonerId, int summonerLevel, string summonerName, bool teamEarlySurrendered, int teamId, string teamPosition, int timeCCingOthers, int timePlayed, int totalDamageDealt, int totalDamageDealtToChampions, int totalDamageShieldedOnTeammates, int totalDamageTaken, int totalHeal, int totalHealsOnTeammates, int totalMinionsKilled, int totalTimeCCDealt, int totalTimeSpentDead, int totalUnitsHealed, int tripleKills, int trueDamageDealt, int trueDamageDealtToChampions, int trueDamageTaken, int turretKills, int turretsLost, int unrealKills, int visionScore, int visionWardsBoughtInGame, int wardsKilled, int wardsPlaced, bool win)
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

        public int assists { get; set; }
        public int baronKills { get; set; }
        public int bountyLevel { get; set; }
        public int champExperience { get; set; }
        public int champLevel { get; set; }
        public int championId { get; set; }
        public string championName { get; set; }
        public int championTransform { get; set; }
        public int consumablesPurchased { get; set; }
        public int damageDealtToBuildings { get; set; }
        public int damageDealtToObjectives { get; set; }
        public int damageDealtToTurrets { get; set; }
        public int damageSelfMitigated { get; set; }
        public int deaths { get; set; }
        public int detectorWardsPlaced { get; set; }
        public int doubleKills { get; set; }
        public int dragonKills { get; set; }
        public bool firstBloodAssist { get; set; }
        public bool firstBloodKill { get; set; }
        public bool firstTowerAssist { get; set; }
        public bool firstTowerKill { get; set; }
        public bool gameEndedInEarlySurrender { get; set; }
        public bool gameEndedInSurrender { get; set; }
        public int goldEarned { get; set; }
        public int goldSpent { get; set; }
        public string individualPosition { get; set; }
        public int inhibitorKills { get; set; }
        public int inhibitorsLost { get; set; }
        public int item0 { get; set; }
        public int item1 { get; set; }
        public int item2 { get; set; }
        public int item3 { get; set; }
        public int item4 { get; set; }
        public int item5 { get; set; }
        public int item6 { get; set; }
        public int itemsPurchased { get; set; }
        public int killingSprees { get; set; }
        public int kills { get; set; }
        public string lane { get; set; }
        public int largestCriticalStrike { get; set; }
        public int largestKillingSpree { get; set; }
        public int largestMultiKill { get; set; }
        public int longestTimeSpentLiving { get; set; }
        public int magicDamageDealt { get; set; }
        public int magicDamageDealtToChampions { get; set; }
        public int magicDamageTaken { get; set; }
        public int neutralMinionsKilled { get; set; }
        public int nexusKills { get; set; }
        public int nexusLost { get; set; }
        public int objectivesStolen { get; set; }
        public int objectivesStolenAssists { get; set; }
        public int participantId { get; set; }
        public int pentaKills { get; set; }
        public Perks perks { get; set; }
        public int physicalDamageDealt { get; set; }
        public int physicalDamageDealtToChampions { get; set; }
        public int physicalDamageTaken { get; set; }
        public int profileIcon { get; set; }
        public string puuid { get; set; }
        public int quadraKills { get; set; }
        public string riotIdName { get; set; }
        public string riotIdTagline { get; set; }
        public string role { get; set; }
        public int sightWardsBoughtInGame { get; set; }
        public int spell1Casts { get; set; }
        public int spell2Casts { get; set; }
        public int spell3Casts { get; set; }
        public int spell4Casts { get; set; }
        public int summoner1Casts { get; set; }
        public int summoner1Id { get; set; }
        public int summoner2Casts { get; set; }
        public int summoner2Id { get; set; }
        public string summonerId { get; set; }
        public int summonerLevel { get; set; }
        public string summonerName { get; set; }
        public bool teamEarlySurrendered { get; set; }
        public int teamId { get; set; }
        public string teamPosition { get; set; }
        public int timeCCingOthers { get; set; }
        public int timePlayed { get; set; }
        public int totalDamageDealt { get; set; }
        public int totalDamageDealtToChampions { get; set; }
        public int totalDamageShieldedOnTeammates { get; set; }
        public int totalDamageTaken { get; set; }
        public int totalHeal { get; set; }
        public int totalHealsOnTeammates { get; set; }
        public int totalMinionsKilled { get; set; }
        public int totalTimeCCDealt { get; set; }
        public int totalTimeSpentDead { get; set; }
        public int totalUnitsHealed { get; set; }
        public int tripleKills { get; set; }
        public int trueDamageDealt { get; set; }
        public int trueDamageDealtToChampions { get; set; }
        public int trueDamageTaken { get; set; }
        public int turretKills { get; set; }
        public int turretsLost { get; set; }
        public int unrealKills { get; set; }
        public int visionScore { get; set; }
        public int visionWardsBoughtInGame { get; set; }
        public int wardsKilled { get; set; }
        public int wardsPlaced { get; set; }
        public bool win { get; set; }
    }
}

