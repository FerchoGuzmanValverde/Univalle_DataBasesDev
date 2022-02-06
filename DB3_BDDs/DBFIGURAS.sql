--Creando un TIPO
CREATE OR REPLACE TYPE RECTAGULO_T AS OBJECT 
(

  base INTEGER,
  altura INTEGER,
  MEMBER FUNCTION ufcArea RETURN INTEGER,
  MEMBER FUNCTION ufcPerimetro RETURN INTEGER

);
--Si no tiene metodos no hace falta crear body
CREATE OR REPLACE TYPE BODY RECTAGULO_T 
AS

  MEMBER FUNCTION ufcArea RETURN INTEGER
  AS
    res INTEGER;
  BEGIN
    res:=base*altura;
    RETURN res;
  END ufcArea;
  
  MEMBER FUNCTION ufcPerimetro RETURN INTEGER
  AS
    res INTEGER;
  BEGIN
    res:=2*base+2*altura;
    RETURN res;
  END ufcPerimetro;

END;


--Insertando Figuras
INSERT INTO FIGURA (COLOR, RECT) VALUES('Rojo', RECTAGULO_T(4,6));
INSERT INTO FIGURA (COLOR, RECT) VALUES('Azul', RECTAGULO_T(9,0));

--Para llamar objetos colocar alias de referencia como F
SELECT F.IDFIGURA, F.COLOR, F.RECT.BASE AS BASE, 
        F.RECT.ufcArea() AS AREA
FROM FIGURA F;