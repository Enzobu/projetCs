using ProjetCs;

namespace TestProject;

public class TestRace
{
    private RegisteredBoat registeredBoat;
    private RegisteredBoat registeredBoat2;
    private Race race;
    private Step step;
    private Step step2;

    [SetUp]
    public void Setup()
    {
        race = new Race(1, 1, 1, 1, DateTime.Now.AddDays(5));
        registeredBoat = new RegisteredBoat(1, "test boat", race);
        registeredBoat2 = new RegisteredBoat(2, "test boat 2", race);
        step = new Step(1, "test step", 1, 1);
        step2 = new Step(2, "test step 2", 2, 2);
    }

    [Test]
    public void TestStartRaceWith0Boat()
    {
        List<Step> listStep = new List<Step> { step };
        race.AddStep(listStep);
        bool result = race.StartRace();
        Assert.That(result, Is.False);
    }

    [Test]
    public void TestStartRaceWith0Step()
    {
        List<RegisteredBoat> listRegisteredBoat = new List<RegisteredBoat> { registeredBoat };
        race.AddRegisteredBoat(listRegisteredBoat);
        bool result = race.StartRace();
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void TestStartRaceWithStepAndBoat()
    {
        List<Step> listStep = new List<Step> { step, step2 };
        List<RegisteredBoat> listRegisteredBoat = new List<RegisteredBoat> { registeredBoat, registeredBoat2 };
        
        race.AddStep(listStep);
        race.AddRegisteredBoat(listRegisteredBoat);
        bool result = race.StartRace();
        
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void TestSetAttributesRaceTime()
    {
        List<Step> listStep = new List<Step> { step, step2 };
        List<RegisteredBoat> listRegisteredBoat = new List<RegisteredBoat> { registeredBoat, registeredBoat2 };
        
        race.AddStep(listStep);
        race.AddRegisteredBoat(listRegisteredBoat);
        bool result = race.StartRace();
        
        Assert.That(registeredBoat.RaceTime, Is.Not.Zero);
        Assert.That(registeredBoat2.RaceTime, Is.Not.Zero);
    }
    
    [Test]
    public void TestSetAttributesRealTime()
    {
        List<Step> listStep = new List<Step> { step, step2 };
        List<RegisteredBoat> listRegisteredBoat = new List<RegisteredBoat> { registeredBoat, registeredBoat2 };
        
        race.AddStep(listStep);
        race.AddRegisteredBoat(listRegisteredBoat);
        bool result = race.StartRace();
        
        Assert.That(registeredBoat.RealTime, Is.Not.Zero);
        Assert.That(registeredBoat2.RealTime, Is.Not.Zero);
    }
    
}

