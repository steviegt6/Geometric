#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

using Newtonsoft.Json;

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
        [JsonProperty("name")] public string Name;

        /// <summary>
        ///     The ID of the level.
        /// </summary>
        [JsonProperty("id")] public string Id;

        /// <summary>
        ///     The description.
        /// </summary>
        [JsonProperty("description")] public string Description;

        /// <summary>
        ///     The name of the level's author.
        /// </summary>
        [JsonProperty("author")] public string Author;

        /// <summary>
        ///     The unique player ID of the level's author.
        /// </summary>
        [JsonProperty("playerID")] public string PlayerId;

        /// <summary>
        ///     The account ID of the level's author.
        /// </summary>
        [JsonProperty("accountID")] public string AccountId;

        /// <summary>
        ///     The difficulty of the level. Includes demon rating.
        /// </summary>
        [JsonProperty("difficulty")] public string Difficulty;

        /// <summary>
        ///     Number of downloads.
        /// </summary>
        [JsonProperty("downloads")] public int Downloads;

        /// <summary>
        ///     Number of likes.
        /// </summary>
        [JsonProperty("likes")] public int Likes;

        /// <summary>
        ///     If the level has a negative number of likes.
        /// </summary>
        [JsonProperty("disliked")] public bool Disliked;

        /// <summary>
        ///     The length of the level (Tiny, Short, Medium, Long, or XL).
        /// </summary>
        [JsonProperty("length")] public string Length;

        /// <summary>
        ///     Amount of stars received for beating the level.
        /// </summary>
        [JsonProperty("stars")] public int Stars;

        /// <summary>
        ///     Amount of mana orbs received for beating the level.
        /// </summary>
        [JsonProperty("orbs")] public int Orbs;

        /// <summary>
        ///     Amount of diamonds received for beating the level.
        /// </summary>
        [JsonProperty("diamonds")] public int Diamonds;

        /// <summary>
        ///     Whether the level is featured or not.
        /// </summary>
        [JsonProperty("featured")] public bool Featured;

        /// <summary>
        ///     Whether the level has an "epic" rating or not.
        /// </summary>
        [JsonProperty("epic")] public bool Epic;

        /// <summary>
        ///     The version of Geometry Dash the level was released on (1.9, 2.1, etc.).
        /// </summary>
        [JsonProperty("gameVersion")] public string GameVersion;

        /// <summary>
        ///     Number of times the level was updated.
        /// </summary>
        [JsonProperty("version")] public int Version;

        /// <summary>
        ///     The original level ID, if the level was copied. Otherwise returns 0.
        /// </summary>
        [JsonProperty("copiedID")] public string CopiedId;

        /// <summary>
        ///     If the level has two player mode enabled.
        /// </summary>
        [JsonProperty("twoPlayer")] public bool TwoPlayer;

        /// <summary>
        ///     The level number of the song, if no custom song is used. Otherwise returns 0.
        /// </summary>
        [JsonProperty("officialSong")] public int OfficialSong;

        /// <summary>
        ///     The Id of the song, if a custom song was used. Otherwise returns 0.
        /// </summary>
        [JsonProperty("customSong")] public int CustomSong;

        /// <summary>
        ///     Number of user coins placed in the level.
        /// </summary>
        [JsonProperty("coins")] public int Coins;

        /// <summary>
        ///     Whether these coins are verified or not.
        /// </summary>
        [JsonProperty("verifiedCoins")] public bool VerifiedCoins;

        /// <summary>
        ///     How many stars the author requested the level to be rated. 0 if no request was given.
        /// </summary>
        [JsonProperty("starsRequested")] public int StarsRequested;

        /// <summary>
        ///     The number of objects in the level. This was added in a recent version of Geometry Dash, so older levels will simply return 0.
        /// </summary>
        [JsonProperty("objects")] public int Objects;

        /// <summary>
        ///     Whether the level is considered "large" (more than 40k objects).
        /// </summary>
        [JsonProperty("large")] public bool Large;

        /// <summary>
        ///     How many creator points the level is worth (1 for star rating, 1 for feature, and 1 for epic rating).
        /// </summary>
        [JsonProperty("cp")] public int Cp;

        // ReSharper disable once CommentTypo
        /// <summary>
        ///     The URL of the difficulty face image for this level.
        /// </summary>
        /// <remarks>
        ///     You can easily access this image using <c>gdbrowser.com/assets/difficulties/{difficultyFace}.png</c>.
        /// </remarks>
        [JsonProperty("difficultyFace")] public string DifficultyFace;

        /// <summary>
        ///     The name of the song used for the level.
        /// </summary>
        [JsonProperty("songName")] public string SongName;

        /// <summary>
        ///     The name of the author of said song.
        /// </summary>
        [JsonProperty("songAuthor")] public string SongAuthor;

        /// <summary>
        ///     The size of the song in megabytes, if a custom song was used.
        /// </summary>
        [JsonProperty("songSize")] public string SongSize;

        /// <summary>
        ///     The ID of the song (again). If a non-custom song was used, this will return a level number of the song.
        /// </summary>
        [JsonProperty("songID")] public string SongId;

        /// <summary>
        ///     The link to the raw MP3 of the song, if available.
        /// </summary>
        [JsonProperty("songLink")] public string SongLink;

        // ReSharper disable once CommentTypo
        /// <summary>
        ///     The level's position on the Demon List (Pointercrate). Extreme demons only.
        /// </summary>
        [JsonProperty("demonList")] public int DemonList;

        /// <summary>
        ///     Time since the level was uploaded (sent as "x days/weeks/months ago", since it's all the API sends).
        /// </summary>
        [JsonProperty("uploaded")] public string Uploaded;

        /// <summary>
        ///     Time since the level was last updated.
        /// </summary>
        [JsonProperty("updated")] public string Updated;

        /// <summary>
        ///     The password to copy the level. 0 means the level isn't copyable and 1 means it's free to copy.
        /// </summary>
        [JsonProperty("password")] public string Password;

        /// <summary>
        ///     The amount of seconds spent in the editor (currently only works when using GDBrowser locally).
        /// </summary>
        [JsonProperty("editorTime")] public int EditorTime;

        /// <summary>
        ///     The amount of seconds spent in the editor, including time from the level it was copied from.
        /// </summary>
        [JsonProperty("totalEditorTime")] public int TotalEditorTime;

        /// <summary>
        ///     If the level contains a checkbox for Low Detail Mode.
        /// </summary>
        [JsonProperty("ldm")] public bool Ldm;

        /// <summary>
        ///     If the values below represent the weekly demon rather than the daily level.
        /// </summary>
        [JsonProperty("weekly")] public bool Weekly;

        /// <summary>
        ///     Which daily/weekly the level is (e.g. 1,000th daily level).
        /// </summary>
        [JsonProperty("dailyNumber")] public int DailyNumber;

        /// <summary>
        ///     The amount of seconds until the daily/weekly level expires.
        /// </summary>
        [JsonProperty("nextDaily")] public ulong NextDaily;

        /// <summary>
        ///     The Unix timestamp for when the daily/weekly level expires.
        /// </summary>
        [JsonProperty("nextDailyTimestamp")]
        public string NextDailyTimestamp;

        /// <summary>
        ///     An unknown data string.
        /// </summary>
        [JsonProperty("extraString")] public string ExtraString;

        /// <summary>
        ///     The actual data of the level, compressed with GZIP.
        /// </summary>
        [JsonProperty("data")] public string Data;
    }
}