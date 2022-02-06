--A través de un Cursor recorrer la tabla producto, 
--luego incrementar en un 10% el precio de aquellos productos que tengan 
--un movimiento mayor a 100 unidades 

SET SERVEROUTPUT ON

DECLARE

  CURSOR c_prod_cursor IS
  
    SELECT P.PRODUCT_ID as id, SUM(OI.QUANTITY) AS mov
    FROM DEMO_PRODUCT_INFO P
    INNER JOIN DEMO_ORDER_ITEMS OI ON P.PRODUCT_ID = OI.PRODUCT_ID
    GROUP BY P.PRODUCT_ID;
  
  v_prod_rec c_prod_cursor%ROWTYPE;
BEGIN

  OPEN c_prod_cursor;
  LOOP
  
    FETCH c_prod_cursor INTO v_prod_rec;
    EXIT WHEN c_prod_cursor%NOTFOUND;
    IF v_prod_rec.mov>100 THEN
      UPDATE DEMO_PRODUCT_INFO SET LIST_PRICE=1.1*LIST_PRICE
      WHERE PRODUCT_ID=v_prod_rec.id;
    END IF;
  END LOOP;
  CLOSE c_prod_cursor;
END;


--------------------------------------------------------------------------------


DECLARE

  CURSOR c_cli_prod IS
    SELECT C.CUSTOMER_ID as idCliente, P.PRODUCT_ID as idProducto, NVL(SUM(OI.QUANTITY),0) as cantidad, P.LIST_PRICE as precio, NVL((SUM(OI.QUANTITY)*P.LIST_PRICE),0) as importe
    FROM DEMO_CUSTOMERS C
    LEFT JOIN DEMO_ORDERS O ON O.CUSTOMER_ID = C.CUSTOMER_ID
    LEFT JOIN DEMO_ORDER_ITEMS OI ON OI.ORDER_ID = O.ORDER_ID
    LEFT JOIN DEMO_PRODUCT_INFO P ON P.PRODUCT_ID=OI.PRODUCT_ID
    GROUP BY C.CUSTOMER_ID, P.PRODUCT_ID, P.LIST_PRICE
    ORDER BY C.CUSTOMER_ID;
    
BEGIN

  FOR rec_cli IN c_cli_prod
    LOOP
      INSERT INTO CLIENTEPRODUCTO (IDCLIENTE, IDPRODUCTO, CANTIDADPRODUCTO, PRECIOUNITARIO, IMPORTE) 
      VALUES(rec_cli.idCliente, rec_cli.idProducto, rec_cli.cantidad, rec_cli.precio, rec_cli.importe);
    END LOOP;
END;


--------------------------------------------------------------------------------


--Crear un procedimiento almacenado que reciba un registro (en base a la estructura 
--de la tabla cliente) y luego realice su inserción en la tabla DEMO_CUSTOMERS. 
--Ejecutar el procedimiento almacenado desde un bloque anónimo. Los valores de los 
--campos del registro pueden ser otorgados a criterio 
--Manejar excepciones (Genérica) 


CREATE OR REPLACE PROCEDURE usp_add_customer (p_rec DEMO_CUSTOMERS%ROWTYPE) 
IS
BEGIN
  INSERT INTO DEMO_CUSTOMERS VALUES p_rec;
EXCEPTION 
WHEN OTHERS THEN
    DBMS_OUTPUT.PUT_LINE('Error al ejecutar el procedimiento');
END;


DECLARE
  rec_cliente DEMO_CUSTOMERS%ROWTYPE;
  v_exception EXCEPTION;
BEGIN
  rec_cliente.CUST_FIRST_NAME:='Gonzalo';
  rec_cliente.CUST_LAST_NAME:='Gonzales';
  rec_cliente.CUST_STREET_ADDRESS1:='Heroinas';
  
  ups_add_customer(rec_cliente);
  
  RAISE v_exception;
  
  EXCEPTION
    WHEN v_exception THEN
    DBMS_OUTPUT.PUT_LINE('Esta es mi excepcion');
END;

--------------------------------------------------------------------------------

--Crear una función que reciba el ID de un cliente, y retorne el total en $us. 
--De todos los productos adquiridos. Luego, a través de un ciclo, recorrer la 
--tabla cliente, para desplegar por consola su nombre completo y el total en $us. 
--De los productos adquiridos (Llamando a la función escrita anteriormente) 


CREATE FUNCTION total_sus (id_c DEMO_CUSTOMERS.CUSTOMER_ID%TYPE) RETURN NUMBER 
IS
v_total NUMBER;
BEGIN
  SELECT SUM()
  FROM DEMO_CUSTOMERS C
  LEFT JOIN DEMO_ORDERS O ON O.CUSTOMER_ID = C.CUSTOMER_ID
  LEFT JOIN DEMO_ORDER_ITEMS OI ON OI.ORDER_ID = O.ORDER_ID
  LEFT JOIN DEMO_PRODUCT_INFO P ON P.PRODUCT_ID=OI.PRODUCT_ID
  GROUP BY C.CUSTOMER_ID, P.PRODUCT_ID, P.LIST_PRICE
  WHERE C.CUSTOMER_ID=id_c
  
  RETURN v_total
END;


--------------------------------------------------------------------------------

--Crear una función que reciba el id de un cliente, y retorne en una matriz 
--asociativa, que debe llenarse por cada producto comprado por dicho cliente,  
--el nombre del producto, su precio actual, la cantidad total de dicho producto 
--adquirido y el Total en Bs. Por el importe de dicho producto (cantidad total * precio actual  en Bs.). 

--Crear un paquete que implemente la función desarrollada en el punto anterior, 
--luego la llame en un Bloque anónimo... con un ID existente de un Cliente 
--(Verificar su existencia) y despliegue por consola todos los productos 
--adquiridos por dicho cliente incluyendo los atributos arriba mencionados. 
CREATE OR REPLACE PACKAGE pkgClientes
IS
  TYPE rec_prod IS RECORD (productos DEMO_PROUDCT_INFO.PRODUCT_NAME%TYPE,
                          precio DEMO_PROUDCT_INFO.LIST_PRICE%TYPE,
                          cantidad NUMBER,
                          total NUMBER);
                          
  TYPE matriz_type IS TABLE OF (rec_productos INDEX BY PLS_INTEGER;

  FUNCTION ufc_productos(p_id DEMO_CUSTOMERS.CUSTOMER_ID%TYPE)
  RETURN matriz_type;
  
END;



CREATE OR REPLACE PACKAGE BODY pkgClientes
IS
  CURSOR c_productos IS SELECT P.PRODUCT_NAME, P.LIST_PRICE, SUM(I.QUANTITY) AS cantidad,
                        FROM DEMO_PRODUCT_INFO P
                        INNER JOIN DEMO_ORDER_ITEMS I ON I.PRODUCT_ID=P.PRODUCT_ID
                        INNER JOIN DEMO_ORDERS O ON O.ORDER_ID=I-ORDER_ID
                        WHERE O.CUSTOMER_ID = 1
                        GROUP BY P.PRODUCT_NAME, P.LIST_PRICE;
  v_indice NUMBER:=1;
  v_res matriz_type;
BEGIN

  FOR rec IN c_productos LOOP
    v_res(v_indice):=rec;
    v_indice=v_indice+1;
  END LOOP;
  RETURN v_res;
END;
  
DECLARE

  v_id DEMO_CUSTOMERS.CUSTOMER_ID%TYPE:=1;
  v_existe NUMBER;
  v_matriz pkg_ejercicio.matriz_type;
BEGIN
  SELECT COUNT(*) INTO v_existe FROM DEMO_CUSTOMERS WHERE CUSTOMER_ID=v_id;
  IF v_existe>0 THEN
    v_matriz:=pkgClientes.ufc_productos(v_id);
    FOR i IN v_matriz.FIRST..v_matriz.LAST LOOP
      IF v_matriz.EXISTS 
    END LOOP;
  END IF;
END;




































