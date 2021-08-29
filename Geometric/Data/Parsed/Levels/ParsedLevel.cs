#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

using System;
using Geometric.Data.Raw;

namespace Geometric.Data.Parsed.Levels
{
    /// <summary>
    ///     Contains parsed and cleaned-up level information.
    /// </summary>
    // TODO: Downloaded and Weekly data.
    public class ParsedLevel : IParsedDataType<RawGDLevel>
    {
        public RawGDLevel RawData { get; set; }

        public StandardLevelData StandardLevelData { get; protected set; }

        public AuthorData AuthorData { get; protected set; }

        public StatisticLevelData StatisticLevelData { get; protected set; }

        public SongLevelData SongLevelData { get; protected set; }

        public ParsedLevel()
        {
        }

        public ParsedLevel(RawGDLevel rawLevel)
        {
            RawData = rawLevel;
            ParseRawData(RawData);
        }

        // TODO: ew.
        public void ParseRawData(RawGDLevel rawData)
        {
            StandardLevelData = new StandardLevelData(rawData.Name, int.Parse(rawData.Id), rawData.Description, rawData.Difficulty, rawData.Length, rawData.Featured, rawData.Epic, rawData.TwoPlayer, rawData.Coins, rawData.VerifiedCoins, rawData.Large, rawData.Cp, rawData.DifficultyFace, rawData.DemonList);
            AuthorData = new AuthorData(int.Parse(rawData.PlayerId), int.Parse(rawData.AccountId));
            StatisticLevelData = new StatisticLevelData(rawData.Downloads, rawData.Likes, rawData.Disliked, rawData.Stars, rawData.Orbs, rawData.Diamonds, Version.Parse(rawData.GameVersion), rawData.Version, int.Parse(rawData.CopiedId), rawData.Objects);
            SongLevelData = new SongLevelData(rawData.OfficialSong, rawData.CustomSong, rawData.SongName, rawData.SongAuthor, rawData.SongSize, rawData.SongId, rawData.SongLink);
        }
    }
}