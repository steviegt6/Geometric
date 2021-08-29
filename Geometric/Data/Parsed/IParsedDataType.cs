#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

namespace Geometric.Data.Parsed
{
    /// <summary>
    ///     Indicates that the object is a parsed version of an existing object representing raw data.
    /// </summary>
    public interface IParsedDataType<T>
    {
        T RawData { get; }

        void ParseRawData(T rawData);
    }
}