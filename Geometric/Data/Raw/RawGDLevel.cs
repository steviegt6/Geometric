#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

using System.Text.Json.Serialization;
using Geometric.Json;

namespace Geometric.Data.Raw
{
    /// <summary>
    ///     Raw GD API level data.
    /// </summary>
    public sealed class RawGDLevel
    {
        /// <summary>
        ///     The name of the level.
        /// </summary>
        [JsonPropertyName("name")] [FallbackString]
        public string Name;

        /// <summary>
        ///     The ID of the level.
        /// </summary>
        [JsonPropertyName("id")] [FallbackString]
        public string Id;

        /// <summary>
        ///     The description.
        /// </summary>
        [JsonPropertyName("description")] [FallbackString]
        public string Description;

        /// <summary>
        ///     The name of the level's author.
        /// </summary>
        [JsonPropertyName("author")] [FallbackString]
        public string Author;

        /// <summary>
        ///     The unique player ID of the level's author.
        /// </summary>
        [JsonPropertyName("playerID")] [FallbackString]
        public string PlayerId;

        /// <summary>
        ///     The account ID of the level's author.
        /// </summary>
        [JsonPropertyName("accountID")] [FallbackString]
        public string AccountId;

        /// <summary>
        ///     The difficulty of the level. Includes demon rating.
        /// </summary>
        [JsonPropertyName("difficulty")] [FallbackString]
        public string Difficulty;

        /// <summary>
        ///     Number of downloads.
        /// </summary>
        [JsonPropertyName("downloads")] public int Downloads;

        /// <summary>
        ///     Number of likes.
        /// </summary>
        [JsonPropertyName("likes")] public int Likes;

        /// <summary>
        ///     If the level has a negative number of likes.
        /// </summary>
        [JsonPropertyName("disliked")] public bool Disliked;

        /// <summary>
        ///     The length of the level (Tiny, Short, Medium, Long, or XL).
        /// </summary>
        [JsonPropertyName("length")] [FallbackString]
        public string Length;

        /// <summary>
        ///     Amount of stars received for beating the level.
        /// </summary>
        [JsonPropertyName("stars")] public int Stars;

        /// <summary>
        ///     Amount of mana orbs received for beating the level.
        /// </summary>
        [JsonPropertyName("orbs")] public int Orbs;

        /// <summary>
        ///     Amount of diamonds received for beating the level.
        /// </summary>
        [JsonPropertyName("diamonds")] public int Diamonds;

        /// <summary>
        ///     Whether the level is featured or not.
        /// </summary>
        [JsonPropertyName("featured")] public bool Featured;

        /// <summary>
        ///     Whether the level has an "epic" rating or not.
        /// </summary>
        [JsonPropertyName("epic")] public bool Epic;

        /// <summary>
        ///     The version of Geometry Dash the level was released on (1.9, 2.1, etc.).
        /// </summary>
        [JsonPropertyName("gameVersion")] [FallbackString]
        public string GameVersion;

        /// <summary>
        ///     Number of times the level was updated.
        /// </summary>
        [JsonPropertyName("version")] public int Version;

        /// <summary>
        ///     The original level ID, if the level was copied. Otherwise returns 0.
        /// </summary>
        [JsonPropertyName("copiedID")] [FallbackString]
        public string CopiedId;

        /// <summary>
        ///     If the level has two player mode enabled.
        /// </summary>
        [JsonPropertyName("twoPlayer")] public bool TwoPlayer;

        /// <summary>
        ///     The level number of the song, if no custom song is used. Otherwise returns 0.
        /// </summary>
        [JsonPropertyName("officialSong")] public int OfficialSong;

        /// <summary>
        ///     The Id of the song, if a custom song was used. Otherwise returns 0.
        /// </summary>
        [JsonPropertyName("customSong")] public int CustomSong;

        /// <summary>
        ///     Number of user coins placed in the level.
        /// </summary>
        [JsonPropertyName("coins")] public int Coins;

        /// <summary>
        ///     Whether these coins are verified or not.
        /// </summary>
        [JsonPropertyName("verifiedCoins")] public bool VerifiedCoins;

        /// <summary>
        ///     How many stars the author requested the level to be rated. 0 if no request was given.
        /// </summary>
        [JsonPropertyName("starsRequested")] public int StarsRequested;

        /// <summary>
        ///     The number of objects in the level. This was added in a recent version of Geometry Dash, so older levels will simply return 0.
        /// </summary>
        [JsonPropertyName("objects")] public int Objects;

        /// <summary>
        ///     Whether the level is considered "large" (more than 40k objects).
        /// </summary>
        [JsonPropertyName("large")] public bool Large;

        /// <summary>
        ///     How many creator points the level is worth (1 for star rating, 1 for feature, and 1 for epic rating).
        /// </summary>
        [JsonPropertyName("cp")] public int Cp;

        // ReSharper disable once CommentTypo
        /// <summary>
        ///     The URL of the difficulty face image for this level.
        /// </summary>
        /// <remarks>
        ///     You can easily access this image using <c>gdbrowser.com/assets/difficulties/{difficultyFace}.png</c>.
        /// </remarks>
        [JsonPropertyName("difficultyFace")] [FallbackString]
        public string DifficultyFace;

        /// <summary>
        ///     The name of the song used for the level.
        /// </summary>
        [JsonPropertyName("songName")] [FallbackString]
        public string SongName;

        /// <summary>
        ///     The name of the author of said song.
        /// </summary>
        [JsonPropertyName("songAuthor")] [FallbackString]
        public string SongAuthor;

        /// <summary>
        ///     The size of the song in megabytes, if a custom song was used.
        /// </summary>
        [JsonPropertyName("songSize")] [FallbackString]
        public string SongSize;

        /// <summary>
        ///     The ID of the song (again). If a non-custom song was used, this will return a level number of the song.
        /// </summary>
        [JsonPropertyName("songID")] [FallbackString]
        public string SongId;

        /// <summary>
        ///     The link to the raw MP3 of the song, if available.
        /// </summary>
        [JsonPropertyName("songLink")] [FallbackString]
        public string SongLink;

        // ReSharper disable once CommentTypo
        /// <summary>
        ///     The level's position on the Demon List (Pointercrate). Extreme demons only.
        /// </summary>
        [JsonPropertyName("demonList")] public int DemonList;

        /// <summary>
        ///     Time since the level was uploaded (sent as "x days/weeks/months ago", since it's all the API sends).
        /// </summary>
        [JsonPropertyName("uploaded")] [FallbackString]
        public string Uploaded;

        /// <summary>
        ///     Time since the level was last updated.
        /// </summary>
        [JsonPropertyName("updated")] [FallbackString]
        public string Updated;

        /// <summary>
        ///     The password to copy the level. 0 means the level isn't copyable and 1 means it's free to copy.
        /// </summary>
        [JsonPropertyName("password")] [FallbackString]
        public string Password;

        /// <summary>
        ///     The amount of seconds spent in the editor (currently only works when using GDBrowser locally).
        /// </summary>
        [JsonPropertyName("editorTime")] public int EditorTime;

        /// <summary>
        ///     The amount of seconds spent in the editor, including time from the level it was copied from.
        /// </summary>
        [JsonPropertyName("totalEditorTime")] public int TotalEditorTime;

        /// <summary>
        ///     If the level contains a checkbox for Low Detail Mode.
        /// </summary>
        [JsonPropertyName("ldm")] public bool Ldm;

        /// <summary>
        ///     If the values below represent the weekly demon rather than the daily level.
        /// </summary>
        [JsonPropertyName("weekly")] public bool Weekly;

        /// <summary>
        ///     Which daily/weekly the level is (e.g. 1,000th daily level).
        /// </summary>
        [JsonPropertyName("dailyNumber")] public int DailyNumber;

        /// <summary>
        ///     The amount of seconds until the daily/weekly level expires.
        /// </summary>
        [JsonPropertyName("nextDaily")] public ulong NextDaily;

        /// <summary>
        ///     The Unix timestamp for when the daily/weekly level expires.
        /// </summary>
        [JsonPropertyName("nextDailyTimestamp")] [FallbackString]
        public string NextDailyTimestamp;

        /// <summary>
        ///     An unknown data string.
        /// </summary>
        [JsonPropertyName("extraString")] [FallbackString]
        public string ExtraString;

        /// <summary>
        ///     The actual data of the level, compressed with GZIP.
        /// </summary>
        [JsonPropertyName("data")] [FallbackString]
        public string Data;
    }
}