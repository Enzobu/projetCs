﻿using ProjetCs;
using System;
using System.Collections.Generic;
using Penalty = ProjetCs.Penalty;

/*

//création employé
Employee Yanis = new Employee(1, "Capelle", "Yanis", new DateTime(2004, 08, 19), "Président");

//création pénalité
Penalty penalty1 = new Penalty(1, 1000, 1000.0, 1000.0);
Penalty penalty2 = new Penalty(1, 1000, 1000.0, 1000.0);


//création participant
Participant Enzo = new Participant(1, "Palermo", "Enzo", new DateTime(1952, 12, 8));
Participant Louis = new Participant(2, "Nectoux", "Louis", new DateTime(1952, 12, 8));
Participant Charlie = new Participant(3, "Petre", "Charlie", new DateTime(1952, 12, 8));
Participant JeanLuc = new Participant(4, "Bompard", "Jean-Luc", new DateTime(1612, 12, 8));
Console.WriteLine(JeanLuc.Age());

//création etapes
Step step1 = new Step(1, "Etape compliquée", 100.0, 100.0);
Step step2 = new Step(2, "Etape un peu plus compliquée que l'étape d'avant", 100.0, 100.0);
Step step3 = new Step(3, "Etape encore un peu plus compliquée que l'étape d'avant qui était elle-même plus compliquée que celle encore d'avant", 100.0, 100.0);
Step step4 = new Step(4, "Etape de la rabe", 100.0, 100.0);

List<Step> listStep = new List<Step> {step1, step2, step3, step4};

//création entreprise
Compagny Adidas = new Compagny(1, "adidas", "FR7610057191570002025600271");
List<Compagny> listCompagny = new List<Compagny> { Adidas };

//création course
Race FirstRace = new Race(100.0, 100.0, 100.0, 100.0, new DateTime(2024,05,30));

//création bateau
Boat Boat1 = new Boat(1, "MarcoPolo");

//création bateau inscrit
RegisteredBoat registeredBoat1 = new RegisteredBoat(1, "MarcoPolo", FirstRace);
RegisteredBoat registeredBoat2 = new RegisteredBoat(2, "Black Pearl", FirstRace);

//équipage
List<Participant> Equipage = new List<Participant> { Enzo, Louis, Charlie, JeanLuc };

//ajout des étapes à une course
FirstRace.AddStep(listStep);

//test méthode
Boat1.AddParticipants(Equipage);
Boat1.DeleteParticipant(2);
Boat1.AddCompagny(listCompagny);

Boat1.Presentation();
List<RegisteredBoat> RegisteredBoat = new List<RegisteredBoat> {registeredBoat1, registeredBoat2};
FirstRace.AddRegisteredBoat(RegisteredBoat);
FirstRace.StartRace();

//inscription bateau
RegisteredBoat Boat1Registered = new RegisteredBoat(Boat1.Id, Boat1.Name, FirstRace);

//afficher le classement de la course
string ranking = FirstRace.printRanking();
Console.WriteLine(ranking);

//test pénalités 
Console.WriteLine($"{ registeredBoat1.RaceTime }, { registeredBoat1.RealTime }");

//donner pénalités
registeredBoat1.GivePenalty(penalty1);
//registeredBoat1.GivePenalty(penalty2);
registeredBoat1.RemovePenalty(penalty1);
Console.WriteLine($"{ registeredBoat1.RaceTime }, { registeredBoat1.RealTime }");

*/


// Entity Framework


