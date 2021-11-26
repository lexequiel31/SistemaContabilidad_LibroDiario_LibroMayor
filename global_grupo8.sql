/*
SQLyog Community v12.09 (64 bit)
MySQL - 10.4.19-MariaDB : Database - globallab3
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`globallab3` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `globallab3`;

/*Table structure for table `cuentas` */

DROP TABLE IF EXISTS `cuentas`;

CREATE TABLE `cuentas` (
  `idcuentas` int(11) NOT NULL,
  `codigo` varchar(45) DEFAULT NULL,
  `tipo` varchar(45) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idcuentas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `cuentas` */

insert  into `cuentas`(`idcuentas`,`codigo`,`tipo`,`nombre`) values (1,'1.1.1','AC','Caja'),(2,'2.2.1','PNC','Credito_Banco'),(3,'1.1.2','AC','Inventarios'),(4,'1.1.3','AC','Instalacion'),(5,'1.1.4','AC','Muebles'),(6,'1.2.5','ANC','CC'),(7,'2.1.1','PC','Proveedores'),(8,'2.1.2','PC','Sueldos'),(9,'3.1','PN','Capital'),(10,'3.2','PN','Resultado_Ejercicio');

/*Table structure for table `registros` */

DROP TABLE IF EXISTS `registros`;

CREATE TABLE `registros` (
  `idregistros` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `cuentadebe` varchar(45) DEFAULT NULL,
  `debe` varchar(45) DEFAULT NULL,
  `cuentahaber` varchar(45) DEFAULT NULL,
  `haber` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idregistros`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4;

/*Data for the table `registros` */

insert  into `registros`(`idregistros`,`fecha`,`cuentadebe`,`debe`,`cuentahaber`,`haber`) values (20,'2020-04-03','Credito_Banco','567','Proveedores','567'),(21,'2020-05-03','Credito_Banco','567','Proveedores','567'),(22,'2020-06-03','Credito_Banco','567','Proveedores','567'),(23,'2020-07-03','Credito_Banco','567','Proveedores','567'),(24,'2020-07-03','Credito_Banco','567','Proveedores','567'),(25,'2020-08-03','Proveedores','7258527','Caja','7258527'),(26,'2020-08-03','Proveedores','5647','Sueldos','5647'),(27,'2020-08-01','Proveedores','2345','Caja','2345'),(28,'2020-08-03','Caja','123','Proveedores','123'),(29,'2021-10-31','Sueldos','1234','Caja','1234'),(30,'2021-11-23','Credito_Banco','123','Caja','123'),(31,'2021-03-24','Proveedores','9999','Capital','9999'),(32,'2021-11-26','Instalacion','31312','Credito_Banco','31312');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
