DROP DATABASE service2bateau;

CREATE DATABASE service2bateau;

USE service2bateau;

CREATE TABLE _user(
   id_user INT AUTO_INCREMENT,
   name VARCHAR(50)  NOT NULL,
   surname VARCHAR(50)  NOT NULL,
   password VARCHAR(255)  NOT NULL,
   mail VARCHAR(255)  NOT NULL,
   PRIMARY KEY(id_user)
);

CREATE TABLE compagny(
   id_compagny INT AUTO_INCREMENT,
   IBAN VARCHAR(50) ,
   name VARCHAR(50)  NOT NULL,
   PRIMARY KEY(id_compagny),
   UNIQUE(IBAN)
);

CREATE TABLE race(
   id_race INT AUTO_INCREMENT,
   start_point_longitude VARCHAR(50) ,
   start_point_latitude VARCHAR(50) ,
   end_point_longitude VARCHAR(50) ,
   endt_point_latitude VARCHAR(50) ,
   dateRace DATE NOT NULL,
   PRIMARY KEY(id_race)
);

CREATE TABLE penalty(
   id_penalty INT AUTO_INCREMENT,
   duration INT NOT NULL,
   latitude VARCHAR(50)  NOT NULL,
   longitude VARCHAR(50)  NOT NULL,
   PRIMARY KEY(id_penalty)
);

CREATE TABLE step(
   id_step INT AUTO_INCREMENT,
   latitude VARCHAR(50)  NOT NULL,
   longitude VARCHAR(50)  NOT NULL,
   name VARCHAR(50)  NOT NULL,
   PRIMARY KEY(id_step)
);

CREATE TABLE employee(
   id_user INT,
   PRIMARY KEY(id_user),
   FOREIGN KEY(id_user) REFERENCES _user(id_user)
);

CREATE TABLE participant(
   id_user INT,
   PRIMARY KEY(id_user),
   FOREIGN KEY(id_user) REFERENCES _user(id_user)
);

CREATE TABLE role(
   id_role INT AUTO_INCREMENT,
   name VARCHAR(50)  NOT NULL,
   id_user INT NOT NULL,
   PRIMARY KEY(id_role),
   FOREIGN KEY(id_user) REFERENCES employee(id_user)
);

CREATE TABLE boat(
   id_boat INT AUTO_INCREMENT,
   name VARCHAR(50)  NOT NULL,
   id_compagny INT,
   PRIMARY KEY(id_boat),
   FOREIGN KEY(id_compagny) REFERENCES compagny(id_compagny)
);

CREATE TABLE registredBoat(
   id_registeredBoat INT AUTO_INCREMENT,
   inRace BOOLEAN NOT NULL DEFAULT 0,
   raceTime INT NOT NULL DEFAULT 0,
   realTime INT NOT NULL DEFAULT 0,
   id_race INT NOT NULL,
   id_boat INT NOT NULL,
   PRIMARY KEY(id_registeredBoat),
   UNIQUE(id_boat),
   FOREIGN KEY(id_race) REFERENCES race(id_race),
   FOREIGN KEY(id_boat) REFERENCES boat(id_boat)
);

CREATE TABLE boat_participant(
   id_boat INT,
   id_user INT,
   PRIMARY KEY(id_boat, id_user),
   FOREIGN KEY(id_boat) REFERENCES boat(id_boat),
   FOREIGN KEY(id_user) REFERENCES participant(id_user)
);

CREATE TABLE race_boat(
   id_boat INT,
   id_race INT,
   isRunning BOOLEAN NOT NULL DEFAULT 0,
   PRIMARY KEY(id_boat, id_race),
   FOREIGN KEY(id_boat) REFERENCES boat(id_boat),
   FOREIGN KEY(id_race) REFERENCES race(id_race)
);

CREATE TABLE boat_penalty(
   id_boat INT,
   id_penalty INT,
   PRIMARY KEY(id_boat, id_penalty),
   FOREIGN KEY(id_boat) REFERENCES boat(id_boat),
   FOREIGN KEY(id_penalty) REFERENCES penalty(id_penalty)
);

CREATE TABLE etape_course(
   id_race INT,
   id_step INT,
   PRIMARY KEY(id_race, id_step),
   FOREIGN KEY(id_race) REFERENCES race(id_race),
   FOREIGN KEY(id_step) REFERENCES step(id_step)
);

CREATE TABLE stap_penalty(
   id_penalty INT,
   id_step INT,
   PRIMARY KEY(id_penalty, id_step),
   FOREIGN KEY(id_penalty) REFERENCES penalty(id_penalty),
   FOREIGN KEY(id_step) REFERENCES step(id_step)
);

CREATE TABLE registeredBoat_penalty(
   id_penalty INT,
   id_registeredBoat INT,
   PRIMARY KEY(id_penalty, id_registeredBoat),
   FOREIGN KEY(id_penalty) REFERENCES penalty(id_penalty),
   FOREIGN KEY(id_registeredBoat) REFERENCES registredBoat(id_registeredBoat)
);
