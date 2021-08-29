#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

namespace Geometric.Web
{
    /// <summary>
    ///     Web-related utilities.
    /// </summary>
    public static class WebUtilities
    {
        /// <summary>
        ///     <c>/</c>. Used for valid URL joining.
        /// </summary>
        public const char SeparatorCharacter = '/';

        /// <summary>
        ///     Base API link.
        /// </summary>
        public const string ApiLink = "https://gdbrowser.com/api";

        /// <summary>
        ///     Joins strings together using <see cref="SeparatorCharacter"/> for valid URL creation.
        /// </summary>
        /// <param name="strings">The strings to join together.</param>
        /// <returns>A single string joined by <see cref="SeparatorCharacter"/>.</returns>
        public static string CombineUrlValid(params string[] strings) => string.Join(SeparatorCharacter, strings);

        /// <summary>
        ///     Appends the given <paramref name="strings"/> to <see cref="ApiLink"/> using <see cref="CombineUrlValid"/>.
        /// </summary>
        /// <param name="strings">The strings to append together.</param>
        /// <returns>A single string beginning with <see cref="ApiLink"/>, along with the <paramref name="strings"/> joined together with <see cref="SeparatorCharacter"/>.</returns>
        public static string AppendToApi(params string[] strings) => CombineUrlValid(ApiLink, CombineUrlValid(strings));

        /// <summary>
        ///     Gets a valid level URL based on the level.
        /// </summary>
        public static string GetLevelUrl(string level) => AppendToApi("level", level);

        /// <summary>
        ///     Gets a valid profile URL based on the profile.
        /// </summary>
        /// <remarks>
        ///     Accepts either an account's username or its ID.
        /// </remarks>
        public static string GetProfile(string user) => AppendToApi("level", user);

        /// <summary>
        ///     Gets a valid search URL.
        /// </summary>
        public static string GetSearch(string query) => AppendToApi("search", query);
        
        /// <summary>
        ///     Gets the leaderboard URL.
        /// </summary>
        public static string GetLeaderboard() => AppendToApi("leaderboard");

        /// <summary>
        ///     Gets a valid level leaderboard URL.
        /// </summary>
        public static string GetLeaderboardLevel(string level) => AppendToApi("leaderboardLevel", level);

        /// <summary>
        ///     Gets a valid comment list URL.
        /// </summary>
        /// <remarks>
        ///     Accepts either an account's username or its ID.
        /// </remarks>
        public static string GetComments(string user) => AppendToApi("comments", user);

        /// <summary>
        ///     Gets a valid level analysis URL.
        /// </summary>
        public static string GetLevelAnalysis(string level) => AppendToApi("analyze", level);

        /// <summary>
        ///     Gets a valid commenting URL.
        /// </summary>
        public static string GetCommenting() => AppendToApi("postComment");

        /// <summary>
        ///     Gets a valid profile commenting URL.
        /// </summary>
        public static string GetProfileCommenting() => AppendToApi("postProfileComment");

        /// <summary>
        ///     Gets a valid messages URL.
        /// </summary>
        public static string GetMessages() => AppendToApi("messages");

        /// <summary>
        ///     Gets a valid liking URL.
        /// </summary>
        public static string GetLiking() => AppendToApi("like");

        /// <summary>
        ///     Gets a valid user icon request URL.
        /// </summary>
        public static string GetIcon(string user) => AppendToApi("icon", user);
    }
}