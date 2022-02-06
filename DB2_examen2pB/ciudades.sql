# Host: localhost  (Version 5.5.5-10.1.28-MariaDB)
# Date: 2018-05-23 02:35:18
# Generator: MySQL-Front 6.0  (Build 2.20)


#
# Structure for table "ciudades"
#

CREATE TABLE `ciudades` (
  `idciudad` int(11) NOT NULL AUTO_INCREMENT,
  `ciudad` varchar(255) DEFAULT NULL,
  `pais` varchar(255) DEFAULT NULL,
  `pobciudad` varchar(255) DEFAULT NULL,
  `pobpais` varchar(255) DEFAULT NULL,
  `estado` varchar(255) NOT NULL DEFAULT '1',
  PRIMARY KEY (`idciudad`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

#
# Data for table "ciudades"
#

INSERT INTO `ciudades` VALUES (1,'TOKIO ','JAPON ','39800000','127000000','1'),(2,'SHANGHAI ','CHINA ','31100000','1379000000','1'),(3,'YAKARTA ','INDONESIA ','28900000','262000000','1'),(4,'DELHI ','INDIA ','27200000','1324000000','1'),(5,'KARACHI ','PAKISTÁN ','25100000','193000000','1'),(6,'SEÚL ','COREA DEL SUR ','24800000','52000000','1'),(7,'MANILA ','FILIPINAS ','24600000','104000000','1'),(8,'BOMBAY ','INDIA ','24300000','1324000000','0'),(9,'CDMX ','MÉXICO ','22300000','127000000','0'),(10,'NUEVA YORK ','ESTADOS UNIDOS ','22200000','326000000','0');
