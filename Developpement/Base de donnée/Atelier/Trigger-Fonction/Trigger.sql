CREATE TRIGGER Acces_AI
AFTER INSERT ON Acces
FOR EACH ROW
INSERT INTO Evenements
(moment,raison)
VALUES
(NEW.moment,
'Acces');

CREATE TRIGGER Alarmes_AI
AFTER INSERT ON Alarmes
FOR EACH ROW
INSERT INTO Evenements
(moment,raison)
VALUES
(NEW.moment,
'Alarmes');

INSERT INTO Acces
(moment,endroit)
VALUES
(NOW(),1);

INSERT INTO Alarmes
(moment,zone)
VALUES
(NOW(),5);

INSERT INTO Acces
(moment,endroit)
VALUES
(DATE('2001-09-11'),25);

CREATE TRIGGER Acces_BI
BEFORE INSERT ON Acces
FOR EACH ROW
SET NEW.moment = NOW();

DROP TRIGGER Acces_AI;

delimiter //

CREATE TRIGGER Acces_AI
AFTER INSERT ON Acces
FOR EACH ROW
BEGIN
	IF NEW.endroit < 10 THEN
		INSERT INTO Evenements
		(moment,raison)
		VALUES
		(NEW.moment,
		'Acces');
	END IF;
END //

delimiter ;

INSERT INTO Acces
(endroit)
VALUES
(5);

INSERT INTO Acces
(endroit)
VALUES
(15);

delimiter //

CREATE TRIGGER Acces_AI
AFTER INSERT ON Acces
FOR EACH ROW
BEGIN
	DECLARE valeur INT;
    SET valeur = NEW.endroit;
    IF valeur < 10 THEN
		INSERT INTO Evenements
		(moment,raison)
		VALUES
		(NEW.moment,
		'Acces');
	END IF;
END //

delimiter ;



CREATE TABLE Valeurs
(val INT);

CREATE TRIGGER Valeur_AI
AFTER INSERT ON Valeurs
FOR EACH ROW
SET @total = @total + NEW.val;

SET @total = 0;

INSERT INTO Valeurs (val) VALUES(15);

SELECT @total;

# ICI, on reconnecte ...


INSERT INTO Valeurs (val) VALUES(15);

SELECT @total;

