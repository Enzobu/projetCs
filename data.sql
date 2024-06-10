-- Insertion des utilisateurs
INSERT INTO _user (name, surname, password, mail) VALUES
                                                      ('John', 'Doe', 'password123', 'john.doe@example.com'),
                                                      ('Jane', 'Smith', 'password123', 'jane.smith@example.com'),
                                                      ('Alice', 'Brown', 'password123', 'alice.brown@example.com'),
                                                      ('Bob', 'Davis', 'password123', 'bob.davis@example.com');

-- Insertion des compagnies
INSERT INTO compagny (IBAN, name) VALUES
                                      ('FR7630006000011234567890189', 'Company A'),
                                      ('FR7630006000019876543210123', 'Company B');

-- Insertion des pénalités
INSERT INTO penalty (duration, latitude, longitude) VALUES
                                                        (10, '48.8566', '2.3522'),
                                                        (20, '51.5074', '-0.1278');

-- Insertion des étapes
INSERT INTO step (latitude, longitude, name) VALUES
                                                 ('34.0522', '-118.2437', 'Step 1'),
                                                 ('40.7128', '-74.0060', 'Step 2');

-- Insertion des employés
INSERT INTO employee (id_user) VALUES
                                   (1),
                                   (2);

-- Insertion des participants
INSERT INTO participant (id_user) VALUES
                                      (3),
                                      (4);

-- Insertion des rôles
INSERT INTO role (name, id_user) VALUES
                                     ('Captain', 1),
                                     ('Navigator', 2);

-- Insertion des bateaux
INSERT INTO boat (name, id_compagny) VALUES
                                         ('Boat 1', 1),
                                         ('Boat 2', 2);

-- Insertion des bateaux enregistrés
INSERT INTO registredBoat (inRace, raceTime, realTime, id_boat) VALUES
                                                                    (0, 0, 0, 1),
                                                                    (1, 3600, 3700, 2);

-- Insertion des courses
INSERT INTO race (start_point_longitude, start_point_latitude, end_point_longitude, endt_point_latitude, dateRace, id_registeredBoat) VALUES
                                                                                                                                          ('2.3522', '48.8566', '-0.1278', '51.5074', '2024-07-01', 1),
                                                                                                                                          ('2.3522', '48.8566', '-118.2437', '34.0522', '2024-08-01', 2);

-- Insertion des participants de bateau
INSERT INTO boat_participant (id_boat, id_user) VALUES
                                                    (1, 3),
                                                    (2, 4);

-- Insertion des bateaux de course
INSERT INTO race_boat (id_boat, id_race, isRunning) VALUES
                                                        (1, 1, 1),
                                                        (2, 2, 0);

-- Insertion des pénalités de bateau
INSERT INTO boat_penalty (id_boat, id_penalty) VALUES
                                                   (1, 1),
                                                   (2, 2);

-- Insertion des étapes de course
INSERT INTO etape_course (id_race, id_step) VALUES
                                                (1, 1),
                                                (2, 2);

-- Insertion des pénalités d'étape
INSERT INTO stap_penalty (id_penalty, id_step) VALUES
                                                   (1, 1),
                                                   (2, 2);

-- Insertion des pénalités des bateaux enregistrés
INSERT INTO registeredBoat_penalty (id_penalty, id_registeredBoat) VALUES
                                                                       (1, 1),
                                                                       (2, 2);
