using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using PlayersManagerLib;

namespace PlayerManagerTests
{
    [TestFixture]
    public class Class1
    {
        private IPlayerMapper mockPlayerMapper;
        private Player player;

        [OneTimeSetUp]
        public void Init()
        {
            mockPlayerMapper = Mock.Of<IPlayerMapper>();
            Mock.Get(mockPlayerMapper)
                .Setup(m => m.IsPlayerNameExistsInDb(It.IsAny<string>()))
                .Returns(false);
            Mock.Get(mockPlayerMapper)
                .Setup(m => m.AddNewPlayerIntoDb(It.IsAny<string>()));

            player = new Player(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<string>(), It.IsAny<int>());
        }

        [Test]
        public void PlayerMapperTest()
        {
            var messege = Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer(It.IsAny<string>(), mockPlayerMapper));
            Assert.Fail(messege.Message);
        }

        [Test]
        public void PlayerTest()
        {
            player = Player.RegisterNewPlayer("test", mockPlayerMapper);
            Assert.That(player.Name.Contains("test"));
            Assert.AreEqual(23, player.Age);
            Assert.That(player.Country.Contains("India"));
            Assert.AreEqual(30, player.NoOfMatches);
        }
    }
}