#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

using System.Text.Json.Serialization;

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
        [JsonPropertyName("name")] public string Name;

        /// <summary>
        ///     The ID of the level.
        /// </summary>
        [JsonPropertyName("id")] public string Id;

        /// <summary>
        ///     The description.
        /// </summary>
        [JsonPropertyName("description")] public string Description;

        /// <summary>
        ///     The name of the level's author.
        /// </summary>
        [JsonPropertyName("author")] public string Author;

        /// <summary>
        ///     The unique player ID of the level's author.
        /// </summary>
        [JsonPropertyName("playerID")] public string PlayerId;
        
        /// <summary>
        ///     The account ID of the level's author.
        /// </summary>
        [JsonPropertyName("accountID")] public string AccountId;

        /// <summary>
        ///     The difficulty of the level. Includes demon rating.
        /// </summary>
        [JsonPropertyName("difficulty")] public string Difficulty;

        /// <summary>
        ///     Number of downloads.
        /// </summary>
        [JsonPropertyName("downloads")] public string Downloads;

        /// <summary>
        ///     Number of likes.
        /// </summary>
        [JsonPropertyName("likes")] public string Likes;

        /// <summary>
        ///     If the level has a negative number of likes.
        /// </summary>
        [JsonPropertyName("disliked")] public string Disliked;

        /// <summary>
        ///     The length of the level (Tiny, Short, Medium, Long, or XL).
        /// </summary>
        [JsonPropertyName("length")] public string Length;

        /// <summary>
        ///     Amount of stars received for beating the level.
        /// </summary>
        [JsonPropertyName("stars")] public string Stars;

        /// <summary>
        ///     Amount of mana orbs received for beating the level.
        /// </summary>
        [JsonPropertyName("orbs")] public string Orbs;

        /// <summary>
        ///     Amount of diamonds received for beating the level.
        /// </summary>
        [JsonPropertyName("diamonds")] public string Diamonds;

        /// <summary>
        ///     Whether the level is featured or not.
        /// </summary>
        [JsonPropertyName("featured")] public string Featured;

        /// <summary>
        ///     Whether the level has an "epic" rating or not.
        /// </summary>
        [JsonPropertyName("epic")] public string Epic;

        /// <summary>
        ///     The version of Geometry Dash the level was released on (1.9, 2.1, etc.).
        /// </summary>
        [JsonPropertyName("gameVersion")] public string GameVersion;

        /// <summary>
        ///     Number of times the level was updated.
        /// </summary>
        [JsonPropertyName("version")] public string Version;

        /// <summary>
        ///     The original level ID, if the level was copied. Otherwise returns 0.
        /// </summary>
        [JsonPropertyName("copiedID")] public string CopiedId;

        /// <summary>
        ///     If the level has two player mode enabled.
        /// </summary>
        [JsonPropertyName("twoPlayer")] public string TwoPlayer;

        /// <summary>
        ///     The level number of the song, if no custom song is used. Otherwise returns 0.
        /// </summary>
        [JsonPropertyName("officialSong")] public string OfficialSong;

        /// <summary>
        ///     The Id of the song, if a custom song was used. Otherwise returns 0.
        /// </summary>
        [JsonPropertyName("customSong")] public string CustomSong;

        /// <summary>
        ///     Number of user coins placed in the level.
        /// </summary>
        [JsonPropertyName("coins")] public string Coins;

        /// <summary>
        ///     Whether these coins are verified or not.
        /// </summary>
        [JsonPropertyName("verifiedCoins")] public string VerifiedCoins;

        /// <summary>
        ///     How many stars the author requested the level to be rated. 0 if no request was given.
        /// </summary>
        [JsonPropertyName("starsRequested")] public string StarsRequested;

        /// <summary>
        ///     The number of objects in the level. This was added in a recent version of Geometry Dash, so older levels will simply return 0.
        /// </summary>
        [JsonPropertyName("objects")] public string Objects;

        /// <summary>
        ///     Whether the level is considered "large" (more than 40k objects).
        /// </summary>
        [JsonPropertyName("large")] public string Large;

        /// <summary>
        ///     How many creator points the level is worth (1 for star rating, 1 for feature, and 1 for epic rating).
        /// </summary>
        [JsonPropertyName("cp")] public string Cp;

        // ReSharper disable once CommentTypo
        /// <summary>
        ///     The URL of the difficulty face image for this level.
        /// </summary>
        /// <remarks>
        ///     You can easily access this image using <c>gdbrowser.com/assets/difficulties/{difficultyFace}.png</c>.
        /// </remarks>
        [JsonPropertyName("difficultyFace")] public string DifficultyFace;

        /// <summary>
        ///     The name of the song used for the level.
        /// </summary>
        [JsonPropertyName("songName")] public string SongName;

        /// <summary>
        ///     The name of the author of said song.
        /// </summary>
        [JsonPropertyName("songAuthor")] public string SongAuthor;

        /// <summary>
        ///     The size of the song in megabytes, if a custom song was used.
        /// </summary>
        [JsonPropertyName("songSize")] public string SongSize;

        /// <summary>
        ///     The ID of the song (again). If a non-custom song was used, this will return a level number of the song.
        /// </summary>
        [JsonPropertyName("songID")] public string SongId;

        /// <summary>
        ///     The link to the raw MP3 of the song, if available.
        /// </summary>
        [JsonPropertyName("songLink")] public string SongLink;

        // ReSharper disable once CommentTypo
        /// <summary>
        ///     The level's position on the Demon List (Pointercrate). Extreme demons only.
        /// </summary>
        [JsonPropertyName("demonList")] public string DemonList;

        /// <summary>
        ///     Time since the level was uploaded (sent as "x days/weeks/months ago", since it's all the API sends).
        /// </summary>
        [JsonPropertyName("uploaded")] public string Uploaded;

        /// <summary>
        ///     Time since the level was last updated.
        /// </summary>
        [JsonPropertyName("updated")] public string Updated;

        /// <summary>
        ///     The password to copy the level. 0 means the level isn't copyable and 1 means it's free to copy.
        /// </summary>
        [JsonPropertyName("password")] public string Password;

        /// <summary>
        ///     The amount of seconds spent in the editor (currently only works when using GDBrowser locally).
        /// </summary>
        [JsonPropertyName("editorTime")] public string EditorTime;

        /// <summary>
        ///     The amount of seconds spent in the editor, including time from the level it was copied from.
        /// </summary>
        [JsonPropertyName("totalEditorTime")] public string TotalEditorTime;
        [JsonPropertyName("ldm")] public string Ldm;
        [JsonPropertyName("weekly")] public string Weekly;
        [JsonPropertyName("dailyNumber")] public string DailyNumber;
        [JsonPropertyName("nextDaily")] public string NextDaily;
        [JsonPropertyName("nextDailyTimestamp")] public string NextDailyTimestamp;
        [JsonPropertyName("extraString")] public string ExtraString;
        [JsonPropertyName("data")] public string Data;
    }
}