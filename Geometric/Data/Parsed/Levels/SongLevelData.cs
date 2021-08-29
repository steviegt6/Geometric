#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

namespace Geometric.Data.Parsed.Levels
{
    /// <summary>
    ///     Contains data relating to song identification for levels.
    /// </summary>
    public readonly struct SongLevelData
    {
        /// <summary>
        ///     The official song identifier if an official song was used, otherwise zero.
        /// </summary>
        public int OfficialSongId { get; }

        /// <summary>
        ///     The identifier for a custom song if an unofficial song was used, otherwise zero.
        /// </summary>
        public int CustomSongId { get; }

        /// <summary>
        ///     The song's human-readable name.
        /// </summary>
        public string SongName { get; }

        /// <summary>
        ///     The author credited for composing the song.
        /// </summary>
        public string SongAuthor { get; }

        /// <summary>
        ///     Human-readable non-precise string representation of a song's file size.
        /// </summary>
        public string SongSize { get; }

        /// <summary>
        ///     Repeated identifier. If a non-custom song was used, this will be a string with the level number of the song, I guess?
        /// </summary>
        public string SongIdAgainNotSureOfItsPurpose { get; }

        /// <summary>
        ///     The link to the song's mp3 file.
        /// </summary>
        public string SongLink { get; }

        public SongLevelData(int officialSongId, int customSongId, string songName, string songAuthor, string songSize, string songIdAgainNotSureOfItsPurpose, string songLink)
        {
            OfficialSongId = officialSongId;
            CustomSongId = customSongId;
            SongName = songName;
            SongAuthor = songAuthor;
            SongSize = songSize;
            SongIdAgainNotSureOfItsPurpose = songIdAgainNotSureOfItsPurpose;
            SongLink = songLink;
        }

        /// <summary>
        ///     Returns the identifier of the official song if an official song were used, otherwise returns the custom song.
        /// </summary>
        /// <returns></returns>
        public int GetSongId() => OfficialSongId == 0 ? CustomSongId : OfficialSongId;
    }
}