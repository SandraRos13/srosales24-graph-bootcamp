using System.Threading.Tasks;
//using Neo4j.Driver;
using NUnit.Framework;

namespace Neoflix.Challenges
{
    public class _01_ConnectToNeo4j : Neo4jChallengeTests
    {
        public override Task SetupAsync() => Task.CompletedTask;

        [Test, Order(1)]
        public async Task InitDriverAsync_should_create_driver_and_connect_to_server()
        {    
            //var (uri, username, password) = Config.UnpackNeo4jConfig();
            var (uri, username, password) = Config.UnpackNeo4jConfig();

            Assert.NotNull(uri);
            Assert.NotNull(username);
            Assert.NotNull(password);

            await Neo4j.InitDriverAsync(uri, username, password);
            
        }

        [Test, Order(2)]

        public async void Driver_should_have_been_instantiated()
        {
            var driver = Neo4j.Driver;
            //InitDriverAsync_should_create_driver_and_connect_to_server.Run();
            //string username="neo4j";
            //string password="wastes-masts-hotels";
            Assert.NotNull(driver);
        }

        [Test, Order(3)]
        public async Task Driver_should_be_able_to_verify_connectivity()
        {
            var driver = Neo4j.Driver;
            //Console.WriteLine("Connection Verified!");
            Assert.NotNull(driver);

            await driver.VerifyConnectivityAsync();
            
        }
    }
}