#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

using System.ComponentModel;

namespace Geometric.Json
{
    public class FallbackStringAttribute : DefaultValueAttribute
    {
        public FallbackStringAttribute() : base("")
        {
        }
    }
}