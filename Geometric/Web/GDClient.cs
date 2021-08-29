#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

using System.Net.Http;
using System.Threading.Tasks;
using Geometric.Data.Parsed;
using Geometric.Data.Parsed.Levels;
using Geometric.Data.Raw;
using Newtonsoft.Json;

namespace Geometric.Web
{
    /// <summary>
    ///     Not rate-limited.
    /// </summary>
    public class GDClient
    {
        public HttpClient WebClient { get; protected set; }

        public GDClient()
        {
            WebClient = new HttpClient();
        }

        public async Task<ParsedLevel> GetLevelAsync(int level) => await GetLevelAsync(level.ToString());

        public async Task<ParsedLevel> GetLevelAsync(string level) =>
            await GetAsync<ParsedLevel, RawGDLevel>(WebUtilities.GetLevelUrl(level));

        public ParsedLevel GetLevel(int level) => GetLevel(level.ToString());

        public ParsedLevel GetLevel(string level) => Get<ParsedLevel, RawGDLevel>(WebUtilities.GetLevelUrl(level));

        public async Task<TParser> GetAsync<TParser, TParsed>(string url)
            where TParser : IParsedDataType<TParsed>, new()
        {
            using HttpResponseMessage response = await WebClient.GetAsync(url);
            TParser parser = new();
            string result = await response.Content.ReadAsStringAsync();
            TParsed parsed = JsonConvert.DeserializeObject<TParsed>(result);
            parser.ParseRawData(parsed);

            return await Task.FromResult(parser);
        }

        public TParser Get<TParser, TParsed>(string url) where TParser : IParsedDataType<TParsed>, new()
        {
            using HttpResponseMessage response = WebClient.GetAsync(url).Result;
            TParser parser = new();
            string result = response.Content.ReadAsStringAsync().Result;
            TParsed parsed = JsonConvert.DeserializeObject<TParsed>(result);
            parser.ParseRawData(parsed);

            return parser;
        }
    }
}