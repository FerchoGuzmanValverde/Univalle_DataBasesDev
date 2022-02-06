if object_id('empleados') is not null
  drop table empleados;

 create table empleados(
  id int identity primary key, 
  nombre varchar(30),
  apellido varchar(30),
  edad tinyint constraint CK_empleados_edad check (edad>=0 and edad<=100)
 );

 insert into empleados values('Ana', ' Acosta',80);
 insert into empleados values('Carlos', 'Caseres',40);
 insert into empleados values('Federico', 'Fuentes',20);
 insert into empleados values('Gaston', 'Guzman',30);
 insert into empleados values('Hector', 'Herrero',50);
 insert into empleados values('Luis', 'Luna',100);
 insert into empleados values('Marcela', 'Morales',70);
 insert into empleados values('Juan', 'Morales',null);

 select concat(nombre, ' ', apellido) as 'Nombre comleto', edad, resultado=
 case edad
  when 0 then 'joven'
  when 10 then 'joven'
  when 20 then 'joven'
  when 30 then 'joven'
  when 40 then 'maduro'
  when 50 then 'maduro'
  when 60 then 'maduro'
  when 70 then 'adulto'
  when 80 then 'adulto'
  when 90 then 'adulto'
  when 100 then 'adulto'
 end
from empleados;


select concat(nombre, ' ', apellido) as 'Nombre completo', condicion=
  case 
   when edad<40 then 'joven'
   when edad >=40 and edad<70 then 'maduro'
   when edad>=70 then 'adulto'
   else 'edad erronea'
  end
 from empleados;

 alter table empleados
  add condicion varchar(20);


 update empleados set condicion=
  case
   when edad<40 then 'joven'
   when edad between 40 and 70 then 'maduro'
   when edad >70 then 'adulto'
  end;

 
 select condicion, count(*) as cantidad,resultado=
  case condicion
    when 'joven' then 'fuertes'
    when 'maduro' then 'inteligentes'
    when 'adulto' then 'sabios'
    else 'sin datos'
  end
 from empleados
 group by condicion
 order by cantidad;

 alter table empleados
  add indice tinyint;

Declare @indice tinyint
set @indice = 1
while (@indice <= (select max(id) from empleados))
 begin
 print '@indice = ' + CONVERT(NVARCHAR,@indice)
 update empleados set indice=@indice where id = @indice
 set @indice = @indice +1
 end