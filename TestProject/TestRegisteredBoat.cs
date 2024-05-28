using ProjetCs;

namespace TestProject;

    public class TestRegisteredBoat
    {
        private RegisteredBoat registeredBoat;
        private Race race;

        [SetUp]
        public void Setup()
        {
            race = new Race(1,1,1,1,DateTime.Now.AddDays(5)); // future date race
            registeredBoat = new RegisteredBoat(1, "test boat", race);
        }

        private Penalty CreateTestPenalty(int duration)
        {
            return new Penalty(1, duration, 1000.0, 1000.0);
        }

        [Test]
        public void TestAddPenalty()
        {
            var penalty = CreateTestPenalty(5);

            bool result = registeredBoat.GivePenalty(penalty);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True);
                Assert.That(registeredBoat.ListPenalty, Contains.Item(penalty));
            });
        }

        [Test]
        public void TestAddDuplicatePenalty()
        {
            var penalty = CreateTestPenalty(5);

            bool firstResult = registeredBoat.GivePenalty(penalty);
            bool secondResult = registeredBoat.GivePenalty(penalty);

            Assert.Multiple(() =>
            {
                Assert.That(firstResult, Is.True);
                Assert.That(secondResult, Is.False);
                Assert.That(registeredBoat.ListPenalty.Count, Is.EqualTo(1));
            });
        }

        [Test]
        public void TestRemovePenalty()
        {
            var penalty = CreateTestPenalty(5);

            registeredBoat.GivePenalty(penalty);
            registeredBoat.RemovePenalty(penalty);

            Assert.That(registeredBoat.ListPenalty, Does.Not.Contain(penalty));
        }

        [Test]
        public void TestGiveUpInRaceFalse()
        {
            var boat = new RegisteredBoat(45, "test", race, false, 54, 85);
            var result = boat.GiveUp();
            Assert.That(result, Is.False);
        }
        
        [Test]
        public void TestGiveUpInRaceTrue()
        {
            var boat = new RegisteredBoat(45, "test", race, true, 54, 85);
            var result = boat.GiveUp();
            Assert.That(result, Is.True);
        }
        
        [Test]
        public void TestCalculateRealTimeWithPenalties()
        {
            registeredBoat.RaceTime = 100;

            var penalty1 = CreateTestPenalty(5);

            registeredBoat.GivePenalty(penalty1);
            
            Assert.That(registeredBoat.RealTime, Is.EqualTo(105)); 
        }

        [Test]
        public void TestCalculateRealTimeWithoutPenalties()
        {
            registeredBoat.RaceTime = 100;

            Assert.That(registeredBoat.RealTime, Is.EqualTo(100));
        }

        [Test]
        public void TestValidRace()
        {
            var futureRace =  new Race(100.0, 100.0, 100.0, 100.0, DateTime.Now.AddDays(5));
            registeredBoat.Race = futureRace;

            Assert.That(registeredBoat.Race, Is.EqualTo(futureRace));
        }
    }
