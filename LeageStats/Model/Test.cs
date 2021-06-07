using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LeageStats.Model
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Metadata1
    {
        public Metadata1(string dataVersion, string matchId, List<string> participants)
        {
            this.dataVersion = dataVersion;
            this.matchId = matchId;
            this.participants = participants;
        }

        public string dataVersion { get; set; }
        public string matchId { get; set; }
        public List<string> participants { get; set; }
    }

    public class StatPerks1
    {
        public StatPerks1(int defense, int flex, int offense)
        {
            this.defense = defense;
            this.flex = flex;
            this.offense = offense;
        }

        public int defense { get; set; }
        public int flex { get; set; }
        public int offense { get; set; }
    }

    public class Selection1
    {
        public Selection1(int perk, int var1, int var2, int var3)
        {
            this.perk = perk;
            this.var1 = var1;
            this.var2 = var2;
            this.var3 = var3;
        }

        public int perk { get; set; }
        public int var1 { get; set; }
        public int var2 { get; set; }
        public int var3 { get; set; }
    }

    public class Style1
    {
        public Style1(string description, List<Selection1> selections, int style)
        {
            this.description = description;
            this.selections = selections;
            this.style = style;
        }

        public string description { get; set; }
        public List<Selection1> selections { get; set; }
        public int style { get; set; }
    }

    public class Perks1
    {
        public Perks1(StatPerks1 statPerks, List<Style1> styles)
        {
            this.statPerks = statPerks;
            this.styles = styles;
        }

        public StatPerks1 statPerks { get; set; }
        public List<Style1> styles { get; set; }
    }
    
    public class Participant1
    {
        public Participant1()
        {
        }

        public Participant1(int assists, int baronKills, int bountyLevel, int champExperience, int champLevel, int championId, string championName, int championTransform, int consumablesPurchased, int damageDealtToBuildings, int damageDealtToObjectives, int damageDealtToTurrets, int damageSelfMitigated, int deaths, int detectorWardsPlaced, int doubleKills, int dragonKills, bool firstBloodAssist, bool firstBloodKill, bool firstTowerAssist, bool firstTowerKill, bool gameEndedInEarlySurrender, bool gameEndedInSurrender, int goldEarned, int goldSpent, string individualPosition, int inhibitorKills, int inhibitorsLost, int item0, int item1, int item2, int item3, int item4, int item5, int item6, int itemsPurchased, int killingSprees, int kills, string lane, int largestCriticalStrike, int largestKillingSpree, int largestMultiKill, int longestTimeSpentLiving, int magicDamageDealt, int magicDamageDealtToChampions, int magicDamageTaken, int neutralMinionsKilled, int nexusKills, int nexusLost, int objectivesStolen, int objectivesStolenAssists, int participantId, int pentaKills, Perks1 perks, int physicalDamageDealt, int physicalDamageDealtToChampions, int physicalDamageTaken, int profileIcon, string puuid, int quadraKills, string riotIdName, string riotIdTagline, string role, int sightWardsBoughtInGame, int spell1Casts, int spell2Casts, int spell3Casts, int spell4Casts, int summoner1Casts, int summoner1Id, int summoner2Casts, int summoner2Id, string summonerId, int summonerLevel, string summonerName, bool teamEarlySurrendered, int teamId, string teamPosition, int timeCCingOthers, int timePlayed, int totalDamageDealt, int totalDamageDealtToChampions, int totalDamageShieldedOnTeammates, int totalDamageTaken, int totalHeal, int totalHealsOnTeammates, int totalMinionsKilled, int totalTimeCCDealt, int totalTimeSpentDead, int totalUnitsHealed, int tripleKills, int trueDamageDealt, int trueDamageDealtToChampions, int trueDamageTaken, int turretKills, int turretsLost, int unrealKills, int visionScore, int visionWardsBoughtInGame, int wardsKilled, int wardsPlaced, bool win)
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
        public Perks1 perks { get; set; }
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

    public class Ban1
    {
        public Ban1(int championId, int pickTurn)
        {
            this.championId = championId;
            this.pickTurn = pickTurn;
        }

        public int championId { get; set; }
        public int pickTurn { get; set; }
    }

    public class Baron1
    {
        public Baron1(bool first, int kills)
        {
            this.first = first;
            this.kills = kills;
        }

        public bool first { get; set; }
        public int kills { get; set; }
    }

    public class Champion1
    {
        public Champion1(bool first, int kills)
        {
            this.first = first;
            this.kills = kills;
        }

        public bool first { get; set; }
        public int kills { get; set; }
    }

    public class Dragon1
    {
        public Dragon1(bool first, int kills)
        {
            this.first = first;
            this.kills = kills;
        }

        public bool first { get; set; }
        public int kills { get; set; }
    }

    public class Inhibitor1
    {
        public Inhibitor1(bool first, int kills)
        {
            this.first = first;
            this.kills = kills;
        }

        public bool first { get; set; }
        public int kills { get; set; }
    }

    public class RiftHerald1
    {
        public RiftHerald1(bool first, int kills)
        {
            this.first = first;
            this.kills = kills;
        }

        public bool first { get; set; }
        public int kills { get; set; }
    }

    public class Tower1
    {
        public Tower1(bool first, int kills)
        {
            this.first = first;
            this.kills = kills;
        }

        public bool first { get; set; }
        public int kills { get; set; }
    }

    public class Objectives1
    {
        public Objectives1(Baron1 baron, Champion1 champion, Dragon1 dragon, Inhibitor1 inhibitor, RiftHerald1 riftHerald, Tower1 tower)
        {
            this.baron = baron;
            this.champion = champion;
            this.dragon = dragon;
            this.inhibitor = inhibitor;
            this.riftHerald = riftHerald;
            this.tower = tower;
        }

        public Baron1 baron { get; set; }
        public Champion1 champion { get; set; }
        public Dragon1 dragon { get; set; }
        public Inhibitor1 inhibitor { get; set; }
        public RiftHerald1 riftHerald { get; set; }
        public Tower1 tower { get; set; }
    }

    public class Team1
    {
        public Team1(List<Ban1> bans, Objectives1 objectives, int teamId, bool win)
        {
            this.bans = bans;
            this.objectives = objectives;
            this.teamId = teamId;
            this.win = win;
        }

        public List<Ban1> bans { get; set; }
        public Objectives1 objectives { get; set; }
        public int teamId { get; set; }
        public bool win { get; set; }
    }

    public class Info1
    {
        public Info1(long gameCreation, int gameDuration, int gameId, string gameMode, string gameName, long gameStartTimestamp, string gameType, string gameVersion, int mapId, List<Participant1> participants, string platformId, int queueId, List<Team1> teams)
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
        public List<Participant1> participants { get; set; }
        public string platformId { get; set; }
        public int queueId { get; set; }
        public List<Team1> teams { get; set; }
    }

    public class Root
    {
        public Root()
        {
        }

        public Root(Metadata1 metadata, Info1 info)
        {
            this.metadata = metadata;
            this.info = info;
        }

        public Metadata1 metadata { get; set; }
        public Info1 info { get; set; }
    }



}
