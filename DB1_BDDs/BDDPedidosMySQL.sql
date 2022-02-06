CREATE DATABASE  IF NOT EXISTS `bddpedidos` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bddpedidos`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: bddpedidos
-- ------------------------------------------------------
-- Server version	5.1.51-community

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `id_cliente` smallint(6) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(50) DEFAULT NULL,
  `primer_apellido` varchar(50) DEFAULT NULL,
  `segundo_apellido` varchar(50) DEFAULT NULL,
  `credito` decimal(18,2) DEFAULT NULL,
  `delete` tinyint(4) NOT NULL DEFAULT '0',
  `fecha_actualizacion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'Juan','Peres','Sanchez',200000.00,0,'0000-00-00 00:00:00'),(2,'Jose','Sanchez','Vargas',22000.00,0,'0000-00-00 00:00:00'),(3,'Armando','Hoyos',NULL,200000.00,0,'0000-00-00 00:00:00'),(4,'Maria','Ramirez','Luna',48400.00,0,'0000-00-00 00:00:00'),(5,'Viviana','Gutierrez','Miranda',33000.00,0,'0000-00-00 00:00:00'),(6,'Julia','Vargas','Montes',16500.00,0,'0000-00-00 00:00:00'),(7,'Marcela ','Torrico','Siles',12100.00,0,'0000-00-00 00:00:00'),(8,'Magali Liliana','Merida','Suarez',132000.00,0,'0000-00-00 00:00:00'),(9,'Guillermina','Peñarrieta','Flores',8580.00,0,'0000-00-00 00:00:00'),(10,'David','Gutierrez','Mendez',19798.35,0,'0000-00-00 00:00:00'),(11,'Jorge','Soliz','Bolivar',7425.00,0,'0000-00-00 00:00:00'),(12,'Juan','Tamayo',NULL,14700.00,0,'0000-00-00 00:00:00'),(13,'Torrejon','Armando',NULL,10780.00,0,'0000-00-00 00:00:00'),(14,'Mario',NULL,NULL,7150.00,0,'0000-00-00 00:00:00'),(15,'Juan','Gutierrez','Miranda',2860.00,0,'0000-00-00 00:00:00'),(16,'Ana Marina','Sanchez','Rojas',3000.00,0,'0000-00-00 00:00:00'),(17,'Jose Mariano','Vargas','Lopez',2000.00,0,'0000-00-00 00:00:00');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `oficina`
--

DROP TABLE IF EXISTS `oficina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `oficina` (
  `id_oficina` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `nombre_oficina` varchar(40) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `delete` tinyint(4) NOT NULL DEFAULT '0',
  `fecha_actualizacion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_oficina`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `oficina`
--

LOCK TABLES `oficina` WRITE;
/*!40000 ALTER TABLE `oficina` DISABLE KEYS */;
INSERT INTO `oficina` VALUES (1,'Oficina Center','Cine Center, Planta baja, Nro 1A',0,'0000-00-00 00:00:00'),(2,'Oficina IC Norte 1','IC Norte, Melchor Perez de Olguin, 2do Piso',0,'0000-00-00 00:00:00'),(3,'Oficina IC Norte 2','IC Norte, Av. America, 2do Piso, Nro 2-12',0,'0000-00-00 00:00:00'),(4,'Oficina Heroinas','Avenida Heroinas 745, Ayacucho y Junin',0,'0000-00-00 00:00:00'),(5,'Oficina Prado','Avenida Ballivian 789 y Oruro',0,'0000-00-00 00:00:00');
/*!40000 ALTER TABLE `oficina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedido` (
  `id_pedido` int(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` smallint(6) NOT NULL,
  `id_representante` smallint(6) NOT NULL,
  `fecha` datetime DEFAULT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT '1',
  `fecha_actualizacion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_pedido`),
  KEY `FK_Pedido_Cliente` (`id_cliente`),
  KEY `FK_Pedido_Representante` (`id_representante`),
  CONSTRAINT `FK_Pedido_Cliente` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_Pedido_Representante` FOREIGN KEY (`id_representante`) REFERENCES `representante` (`id_representante`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido` VALUES (1,1,6,'2012-03-01 00:00:00',1,'0000-00-00 00:00:00'),(2,2,4,'2012-03-02 00:00:00',1,'0000-00-00 00:00:00'),(3,3,5,'2013-03-02 00:00:00',1,'0000-00-00 00:00:00'),(4,4,7,'2012-03-01 00:00:00',1,'0000-00-00 00:00:00'),(5,5,8,'2012-03-03 00:00:00',1,'0000-00-00 00:00:00'),(6,6,10,'2012-03-05 00:00:00',1,'0000-00-00 00:00:00'),(7,7,6,'2012-03-03 00:00:00',1,'0000-00-00 00:00:00'),(8,8,8,'2012-03-03 00:00:00',1,'0000-00-00 00:00:00'),(9,9,9,'2012-03-03 00:00:00',1,'0000-00-00 00:00:00'),(10,1,6,'2012-03-06 00:00:00',1,'0000-00-00 00:00:00'),(11,9,4,'2015-11-24 11:39:04',1,'0000-00-00 00:00:00');
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido_producto`
--

DROP TABLE IF EXISTS `pedido_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedido_producto` (
  `id_pedido` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio_unitario` decimal(18,2) DEFAULT NULL,
  PRIMARY KEY (`id_pedido`,`id_producto`),
  KEY `FK_Pedido_Producto_Producto` (`id_producto`),
  CONSTRAINT `FK_Pedido_Producto_Pedido` FOREIGN KEY (`id_pedido`) REFERENCES `pedido` (`id_pedido`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_Pedido_Producto_Producto` FOREIGN KEY (`id_producto`) REFERENCES `producto` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido_producto`
--

LOCK TABLES `pedido_producto` WRITE;
/*!40000 ALTER TABLE `pedido_producto` DISABLE KEYS */;
INSERT INTO `pedido_producto` VALUES (1,3,25,5.00),(1,5,20,2.50),(1,7,10,8.50),(1,9,5,21.00),(1,11,80,5.00),(1,14,50,24.50),(2,2,50,2.50),(2,4,10,20.50),(2,6,15,3.00),(2,8,25,35.00),(2,10,20,5.00),(2,12,5,5.00),(2,14,10,24.50),(3,4,25,20.50),(3,5,30,2.50),(3,6,35,3.00),(3,7,15,8.50),(3,8,10,35.00),(3,14,5,24.50),(4,6,5,3.00),(4,9,5,21.00),(4,10,70,5.00),(4,11,10,5.00),(4,12,45,5.00),(4,13,35,7.50),(4,14,50,24.50),(5,1,2000,0.10),(5,3,35,5.00),(5,6,5,3.00),(5,9,10,21.00),(5,13,15,7.50),(5,14,20,24.50),(6,1,1000,0.10),(6,2,20,2.50),(6,3,10,5.00),(6,4,20,20.50),(6,5,10,2.50),(6,6,5,3.00),(6,7,10,8.50),(6,8,20,35.00),(7,1,1500,0.10),(7,11,5,5.00),(7,12,10,5.00),(7,13,25,7.50),(7,14,10,24.50),(8,5,5,2.50),(8,6,10,3.00),(8,7,5,8.50),(8,8,10,35.00),(8,9,15,21.00),(8,10,20,5.00),(9,10,70,5.00),(9,11,15,5.00),(9,12,25,5.00),(9,13,50,7.50),(9,14,60,24.50),(10,1,200,0.10),(10,2,5,2.50),(10,7,5,8.50),(10,8,15,35.00),(10,9,10,21.00),(10,12,25,5.00),(10,14,30,24.50),(11,4,50,10.50),(11,6,55,3.00),(11,7,25,12.00);
/*!40000 ALTER TABLE `pedido_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto` (
  `id_producto` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(150) DEFAULT NULL,
  `unidad_medida` varchar(25) DEFAULT NULL,
  `saldo` int(11) DEFAULT NULL,
  `precio_base` decimal(18,2) DEFAULT NULL,
  `delete` tinyint(4) NOT NULL,
  `fecha_actualizacion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_producto`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'Hojas Bond Oficio','Pieza',150000,0.10,0,'0000-00-00 00:00:00'),(2,'Lapiz Negro HB 2.0','Pieza',1000,2.50,0,'0000-00-00 00:00:00'),(3,'Borrador de Tinta','Pieza',500,5.00,0,'0000-00-00 00:00:00'),(4,'Estuche Geométrico','Estuche',250,20.50,0,'0000-00-00 00:00:00'),(5,'Cartulina de Color','Pliego',400,2.50,0,'0000-00-00 00:00:00'),(6,'Archivador Rápido','Pieza',4945,3.00,0,'0000-00-00 00:00:00'),(7,'Micropunta Negro 0.8','Pieza',150,8.50,0,'0000-00-00 00:00:00'),(8,'Marcadores (12 Colores)','Estuche',650,35.00,0,'0000-00-00 00:00:00'),(9,'Cuaderno 100 Hojas C/espiral','Pieza',905,21.00,0,'0000-00-00 00:00:00'),(10,'Boligrafo Pilot Negro','Pieza',1500,5.00,0,'0000-00-00 00:00:00'),(11,'Boligrafo Pilot Rojo','Pieza',745,5.00,0,'0000-00-00 00:00:00'),(12,'Boligrafo Pilot Azul','Pieza',800,5.00,0,'0000-00-00 00:00:00'),(13,'Pegamento de 250 ml','Bote',234,7.50,0,'0000-00-00 00:00:00'),(14,'Acuarelas de color','Docena',65,24.50,0,'0000-00-00 00:00:00'),(15,'Marcadores Faber Castell','Caja',450,19.55,0,'0000-00-00 00:00:00'),(16,'Tajador Faber Castell sin Diseño','Pieza',600,0.50,0,'0000-00-00 00:00:00'),(17,'Filp Tamaño Carta','Pieza',800,2.00,0,'0000-00-00 00:00:00');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `representante`
--

DROP TABLE IF EXISTS `representante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `representante` (
  `id_representante` smallint(6) NOT NULL AUTO_INCREMENT,
  `id_oficina` tinyint(3) unsigned NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `nombre_usuario` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `delete` tinyint(4) NOT NULL DEFAULT '0',
  `estado` tinyint(4) NOT NULL,
  `fecha_actualizacion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_representante`),
  KEY `FK_Representante_Oficina` (`id_oficina`),
  CONSTRAINT `FK_Representante_Oficina` FOREIGN KEY (`id_oficina`) REFERENCES `oficina` (`id_oficina`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `representante`
--

LOCK TABLES `representante` WRITE;
/*!40000 ALTER TABLE `representante` DISABLE KEYS */;
INSERT INTO `representante` VALUES (4,1,'Jaime','1995-02-07','jaime','fde2fdb1dbf604aede0ffee76d26e4ce',0,0,'2018-11-22 12:00:01'),(5,1,'Jose','1998-06-27','jose','662eaa47199461d01a623884080934ab',0,0,'2018-11-22 12:00:01'),(6,2,'Gabriela','1996-09-25','gabriela','276e697e74e8b5264465139a480db556',0,0,'2018-11-22 12:00:01'),(7,2,'Paulo','1990-05-28','paulo','dd41cb18c930753cbecf993f828603dc',0,0,'2018-11-22 12:00:01'),(8,3,'Tony','1985-03-13','tony','ddc5f5e86d2f85e1b1ff763aff13ce0a',0,0,'2018-11-22 12:00:01'),(9,4,'Junior','1989-06-13','junior','b03e3fd2b3d22ff6df2796c412b09311',0,0,'2018-11-22 12:00:01'),(10,5,'Mirtha','1994-08-04','mirtha','9592e419fcf1e13324e5fee29d428bd3',0,0,'2018-11-22 12:00:01'),(11,2,'Ivan','1994-12-12','ivan','2c42e5cf1cdbafea04ed267018ef1511',0,0,'2018-11-22 12:00:01');
/*!40000 ALTER TABLE `representante` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-22  8:02:31
