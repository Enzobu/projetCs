using ProjetCs;

namespace TestProject
{
    public class TestBoat
    {
        private Boat boat;

        [SetUp]
        public void Setup()
        {
            boat = new Boat(1, "test boat");
        }

        private List<Participant> CreateTestParticipants()
        {
            var testParticipant1 = new Participant(1, "test", "test", new DateTime(2000, 12, 12));
            var testParticipant2 = new Participant(2, "test", "test", new DateTime(2000, 12, 12));
            var testParticipant3 = new Participant(3, "test", "test", new DateTime(2000, 12, 12));

            return new List<Participant> { testParticipant1, testParticipant2, testParticipant3 };
        }

        private List<Compagny> CreateTestCompagnies()
        {
            var testCompagny1 = new Compagny(1, "test", "FR7610057191570002025600271");
            var testCompagny2 = new Compagny(2, "test", "FR7610057191570002025600271");
            var testCompagny3 = new Compagny(3, "test", "FR7610057191570002025600271");

            return new List<Compagny> { testCompagny1, testCompagny2, testCompagny3 };
        }

        [Test]
        public void TestAddUsers()
        {
            var listParticipant = CreateTestParticipants();
            boat.AddParticipants(listParticipant);
            
            Assert.Multiple(() =>
            {
                // verifie que les participants sont bien des objets participants
                Assert.That(boat.ListParticipant, Is.All.TypeOf<Participant>());

                // verifie que tous les participants ont bien été ajoutes
                Assert.That(boat.ListParticipant, Is.EquivalentTo(listParticipant));
            });
        }

        [Test]
        public void TestDeleteUser()
        {
            var listParticipant = CreateTestParticipants();
            boat.AddParticipants(listParticipant);
            boat.DeleteParticipant(1);

            // vérifie que le bateau avec l'id 1 a bien été supprimé
            Assert.That(boat.ListParticipant, Has.None.Matches<Participant>(p => p.Id == 1));
        }

        [Test]
        public void TestAddCompagny()
        {
            var listCompagny = CreateTestCompagnies();
            boat.AddCompagny(listCompagny);
            
            Assert.Multiple(() =>
            {
                // verifie qu'on ajoute bien des instances de compagny 
                Assert.That(boat.ListCompagny, Is.All.TypeOf<Compagny>());
                
                // vérifie que les compagny s'ajoutent 
                Assert.That(boat.ListCompagny, Is.EquivalentTo(listCompagny));
            });
        }

        [Test]
        public void TestDeleteCompany()
        {
            var listCompagny = CreateTestCompagnies();
            boat.AddCompagny(listCompagny);
            boat.deleteCompagny(1);
            
            // vérifie que la comagny est supprimé
            Assert.That(boat.ListCompagny, Has.None.Matches<Compagny>(c => c.Id == 1));
        }
    }
}