DROP DATABASE IF EXISTS VeloMax;
CREATE DATABASE VeloMax;
USE VeloMax

CREATE TABLE admin (
	idA INT(10) NOT NULL AUTO_INCREMENT PRIMARY KEY,
	login VARCHAR(50) NULL DEFAULT NULL,
	mdp VARCHAR(50) NULL DEFAULT NULL
);

INSERT INTO `admin` (`idA`, `login`, `mdp`) VALUES (1, 'flexboy', 'test');

CREATE TABLE employe (
    idEmploye INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(100) NOT NULL,
    type_contrat ENUM('plein temps', 'temps partiel') NOT NULL,
    role VARCHAR(100),
    salaire FLOAT NOT NULL,
    prime FLOAT DEFAULT NULL
);

CREATE TABLE chiffre_affaires (
    idCA INT AUTO_INCREMENT PRIMARY KEY,
    date DATE NOT NULL,
    montant_ca DECIMAL(10,2) NOT NULL,
    satisfaction_client INT NOT NULL
);

CREATE TABLE client (
    idClient INT AUTO_INCREMENT PRIMARY KEY,
    type ENUM('boutique', 'individu') NOT NULL,
    nom VARCHAR(100) NOT NULL,
    prenom VARCHAR(100) NOT NULL,
    adresse VARCHAR(100) NOT NULL,
    ville VARCHAR(100) NOT NULL,
    cp VARCHAR(10) NOT NULL,
    province VARCHAR(100) NOT NULL,
    telephone VARCHAR(20),
    courriel VARCHAR(100),
    nom_boutique VARCHAR(100),
    nom_contact VARCHAR(100),
    UNIQUE KEY (idClient)
);

CREATE TABLE programmes (
    idProgramme INT AUTO_INCREMENT PRIMARY KEY,
    description VARCHAR(255) NOT NULL,
    cout DECIMAL(10,2),
    duree INT NOT NULL,
    pourcentage_rabais DECIMAL(5,2) NOT NULL
);

CREATE TABLE adhesions (
    id_adhesion INT AUTO_INCREMENT PRIMARY KEY,
    id_client INT,
    id_programme INT,
    date_adhesion DATE,
    date_expiration DATE,
    FOREIGN KEY (id_client) REFERENCES client(idClient),
    FOREIGN KEY (id_programme) REFERENCES programmes(idProgramme)
);

CREATE TABLE fournisseur (
    siret VARCHAR(20) PRIMARY KEY,
    nom_fournisseur VARCHAR(100) NOT NULL,
    contact VARCHAR(100),
    adresse VARCHAR(255),
    reactivite ENUM('très bon', 'bon', 'moyen', 'mauvais')
);

CREATE TABLE velo (
    numero_produit VARCHAR(20) PRIMARY KEY,
    nom VARCHAR(100) NOT NULL,
    grandeur VARCHAR(50),
    prix_unitaire DECIMAL(10,2),
    ligne_produit ENUM('VTT', 'Classique', 'BMX', 'Vélo de course'),
    date_introduction DATE,
    date_discontinuation DATE
);

CREATE TABLE piece (
    numero_produit VARCHAR(20) PRIMARY KEY,
    description VARCHAR(255) NOT NULL,
    prix_unitaire DECIMAL(10,2),
    date_introduction DATE,
    date_discontinuation DATE,
    siret_fournisseur VARCHAR(20),
    delai_fournisseur INT,
    FOREIGN KEY (siret_fournisseur) REFERENCES fournisseur(siret)
);

CREATE TABLE commandes (
    numero_commande INT AUTO_INCREMENT PRIMARY KEY,
    date_commande DATE NOT NULL,
    adresse_livraison VARCHAR(255) NOT NULL,
    date_livraison DATE,
    prix_total DECIMAL(10,2) NOT NULL,
    client_id INT,
    employe_id INT,
    FOREIGN KEY (client_id) REFERENCES client(idClient)
    FOREIGN KEY (employe_id) REFERENCES employe(idEmploye)
);

CREATE TABLE details_commande_velos (
    id_detail INT AUTO_INCREMENT PRIMARY KEY,
    numero_commande INT,
    numero_produit VARCHAR(20),
    quantite INT,
    FOREIGN KEY (numero_commande) REFERENCES commandes(numero_commande),
    FOREIGN KEY (numero_produit) REFERENCES velo(numero_produit)
);

CREATE TABLE details_commande_pieces (
    id_detail INT AUTO_INCREMENT PRIMARY KEY,
    numero_commande INT,
    numero_produit VARCHAR(20),
    quantite INT,
    FOREIGN KEY (numero_commande) REFERENCES commandes(numero_commande),
    FOREIGN KEY (numero_produit) REFERENCES piece(numero_produit)
);
