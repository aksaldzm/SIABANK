/*
SQLyog Ultimate v12.09 (64 bit)
MySQL - 10.1.32-MariaDB : Database - siabank
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`siabank` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `siabank`;

/*Table structure for table `nasabah` */

DROP TABLE IF EXISTS `nasabah`;

CREATE TABLE `nasabah` (
  `no_rek` char(7) NOT NULL,
  `nama_sabah` varchar(35) NOT NULL,
  `jenis_kelamin` char(1) NOT NULL,
  `alamat` varchar(150) DEFAULT NULL,
  `storan_awal` bigint(20) NOT NULL,
  `password` varchar(8) NOT NULL,
  PRIMARY KEY (`no_rek`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `nasabah` */

insert  into `nasabah`(`no_rek`,`nama_sabah`,`jenis_kelamin`,`alamat`,`storan_awal`,`password`) values ('2020','cewe','P','jln terawang',40004342,'55554'),('6666','Anjuuui','L','KOlea',5000,'2121');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
