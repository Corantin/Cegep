# Fonction

delimiter //

CREATE FUNCTION additionner
(operande1 INT,operande2 INT)
RETURNS INT
BEGIN
	DECLARE resultat INT;
    SET resultat = operande1 + operande2;
    return resultat;
END //

delimiter ;

DROP FUNCTION additionner;

SELECT @@log_bin_trust_function_creators;

SELECT additionner(30,5);

# Procédure

CREATE TABLE IF NOT EXISTS Clients
(idClient INT AUTO_INCREMENT PRIMARY KEY,
nom VARCHAR(20) NOT NULL,
prenom VARCHAR(20) NOT NULL);

delimiter //

CREATE PROCEDURE entrerClient
(IN nomClient VARCHAR(20),IN prenomClient VARCHAR(20))
BEGIN
	INSERT INTO Clients
    (prenom,nom)
    VALUES
    (nomClient,
    prenomClient);
END //

delimiter ;

DROP PROCEDURE entrerClient;

# Ne marche que pour les fonctions (SELECT)
SELECT entrerClient('Corantin','Noll');

# Il faut utiliser CALL
CALL entrerClient('Corantin','Noll');

DELETE FROM Clients WHERE idClient = 3;

SELECT * FROM Clients;

delimiter //

CREATE PROCEDURE testRetours
(OUT valeurOut INT,INOUT valeurInOut INT)
BEGIN
	SET valeurOut = 10;
    SET valeurInOut = valeurInOut + 10;
END //

delimiter ;

SET @O = 100;
SET @I_O = 100;
SELECT @O,@I_O;