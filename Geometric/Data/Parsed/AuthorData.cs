#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

namespace Geometric.Data.Parsed
{
    /// <summary>
    ///     Contains data about an author.
    /// </summary>
    public readonly struct AuthorData
    {
        /// <summary>
        ///     The unique player identifier of the author.
        /// </summary>
        public int PlayerId { get; }

        /// <summary>
        ///     The account identifier of the author. Will be zero if the user is green (unregistered).
        /// </summary>
        public int AccountId { get; }

        public AuthorData(int playerId, int accountId)
        {
            PlayerId = playerId;
            AccountId = accountId;
        }
    }
}