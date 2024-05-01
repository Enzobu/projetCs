using ProjetCs;
using System;
using System.Collections.Generic;

//création employé
Employee Yanis = new Employee(1, "Capelle", "Yanis", new DateTime(2004, 08, 19), "Président");

//création participant
Participant Enzo = new Participant(1, "Palermo", "Enzo", new DateTime(1952, 12, 8));
Participant Louis = new Participant(2, "Nectoux", "Louis", new DateTime(1952, 12, 8));
Participant Charlie = new Participant(3, "Petre", "Charlie", new DateTime(1952, 12, 8));
Participant JeanLuc = new Participant(4, "Bompard", "Jean-Luc", new DateTime(201, 12, 8));


//création etapes
Step step1 = new Step(1, "Etape de la mort", 100.0, 100.0);
Step step2 = new Step(2, "Etape de la vie", 100.0, 100.0);
Step step3 = new Step(3, "Etape de la sertitude", 100.0, 100.0);
Step step4 = new Step(4, "Etape de la rabe", 100.0, 100.0);

List<Step> listStep = new List<Step> {step1, step2, step3, step4};

//création entreprise
Compagny Adidas = new Compagny(1, "adidas", "FR7610057191570002025600271");
List<Compagny> listCompagny = new List<Compagny> { Adidas };

//création course
Race FirstRace = new Race(100.0, 100.0, 100.0, 100.0, new DateTime(2024,05,29));

//création bateau
Boat Boat1 = new Boat(1, "MarcoPolo");

//équipage
List<Participant> Equipage = new List<Participant> { Enzo, Louis, Charlie, JeanLuc };

//test méthode
Boat1.AddParticipants(Equipage);
Boat1.DeleteParticipant(2);
Boat1.AddCompagny(listCompagny);

Boat1.Presentation();

//inscription bateau
RegisteredBoat Boat1Registered = new RegisteredBoat(Boat1.Id, Boat1.Name, FirstRace);

