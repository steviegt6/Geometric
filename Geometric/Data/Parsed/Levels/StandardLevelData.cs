#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

namespace Geometric.Data.Parsed.Levels
{
    /// <summary>
    ///     Represents basic, bare-bones level data.
    /// </summary>
    public readonly struct StandardLevelData
    {
        /// <summary>
        ///     The level's name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     The level's unique identifier.
        /// </summary>
        public int Identifier { get; }

        /// <summary>
        ///     The description of the level.
        /// </summary>
        public string Description { get; }

        /// <summary>
        ///     The level's difficulty, represented as a string. This includes demon ratings.
        /// </summary>
        public string Difficulty { get; }

        /// <summary>
        ///     The level's length, represented with a string (Tiny, Short, Medium, Long, or XL).
        /// </summary>
        public string Length { get; }

        /// <summary>
        ///     Whether the level is featured.
        /// </summary>
        public bool Featured { get; }

        /// <summary>
        ///     Whether the level has an epic rating.
        /// </summary>
        public bool EpicRating { get; }

        /// <summary>
        ///     If the level has two-player mode enabled.
        /// </summary>
        public bool TwoPlayer { get; }

        /// <summary>
        ///     The number of coins placed in the level.
        /// </summary>
        public int CoinsPlaced { get; }

        /// <summary>
        ///     Whether these coins are verified.
        /// </summary>
        public bool VerifiedCoins { get; }

        /// <summary>
        ///     Whether the level is considered large (specifically: whether the level has 40,000 or more objects).
        /// </summary>
        public bool Large { get; }

        /// <summary>
        ///     How many creator points the song is valued at.
        /// </summary>
        public int CreatorPoints { get; }

        /// <summary>
        ///     The URL of the difficulty face image the level uses.
        /// </summary>
        public string DifficultyFace { get; }

        /// <summary>
        ///     Extreme demons only. the level's position on the demon list.
        /// </summary>
        public int DemonList { get; }

        public StandardLevelData(string name, int identifier, string description, string difficulty, string length, bool featured, bool epicRating, bool twoPlayer, int coinsPlaced, bool verifiedCoins, bool large, int creatorPoints, string difficultyFace, int demonList)
        {
            Name = name;
            Identifier = identifier;
            Description = description;
            Difficulty = difficulty;
            Length = length;
            Featured = featured;
            EpicRating = epicRating;
            TwoPlayer = twoPlayer;
            CoinsPlaced = coinsPlaced;
            VerifiedCoins = verifiedCoins;
            Large = large;
            CreatorPoints = creatorPoints;
            DifficultyFace = difficultyFace;
            DemonList = demonList;
        }
    }
}