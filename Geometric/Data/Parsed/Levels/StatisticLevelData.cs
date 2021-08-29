#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

using System;

namespace Geometric.Data.Parsed.Levels
{
    /// <summary>
    ///     Represents more statistical level data.
    /// </summary>
    public readonly struct StatisticLevelData
    {
        /// <summary>
        ///     Amount of total level downloads.
        /// </summary>
        public int Downloads { get; }

        /// <summary>
        ///     The amount of likes a level has.
        /// </summary>
        public int Likes { get; }

        /// <summary>
        ///     Whether the total number of <see cref="Likes"/> is negative.
        /// </summary>
        public bool Disliked { get; }

        /// <summary>
        ///     The amount of stars received for beating this level.
        /// </summary>
        public int Stars { get; }

        /// <summary>
        ///     The amount of mana orbs received for beating this level.
        /// </summary>
        public int Orbs { get; }

        /// <summary>
        ///     The amount of diamonds received for beating this level.
        /// </summary>
        public int Diamonds { get; }

        /// <summary>
        ///     The version of Geometry Dash this level was published on.
        /// </summary>
        public Version GameVersion { get; }

        /// <summary>
        ///     The amount of times the level was updated.
        /// </summary>
        public int TimesUpdated { get; }

        /// <summary>
        ///     The original level identifier if it were copied, otherwise zero.
        /// </summary>
        public int CopiedId { get; }

        /// <summary>
        ///     Total number of objects in a level.
        /// </summary>
        public int Objects { get; }

        public StatisticLevelData(int downloads, int likes, bool disliked, int stars, int orbs, int diamonds, Version gameVersion, int timesUpdated, int copiedId, int objects)
        {
            Downloads = downloads;
            Likes = likes;
            Disliked = disliked;
            Stars = stars;
            Orbs = orbs;
            Diamonds = diamonds;
            GameVersion = gameVersion;
            TimesUpdated = timesUpdated;
            CopiedId = copiedId;
            Objects = objects;
        }
    }
}