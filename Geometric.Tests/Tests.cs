using System;
using System.Linq;
using Geometric.Data.Parsed.Levels;
using Geometric.Web;
using NUnit.Framework;

namespace Geometric.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            static void WriteMany(params object[] objects) => objects.ToList().ForEach(x => Console.WriteLine(x.ToString()));

            try
            {
                GDClient client = new();
                ParsedLevel level = client.GetLevel(68044804);

                WriteMany(level.AuthorData.AccountId, level.AuthorData.PlayerId, level.SongLevelData.SongAuthor,
                    level.SongLevelData.GetSongId(), level.SongLevelData.SongName, level.SongLevelData.SongLink,
                    level.StandardLevelData.Name, level.StandardLevelData.Description);

                Assert.Pass();
            }
            catch (Exception e)
            {
                if (e is SuccessException)
                    return;

                Assert.Fail($"Exception thrown: {e}");
            }
        }
    }
}