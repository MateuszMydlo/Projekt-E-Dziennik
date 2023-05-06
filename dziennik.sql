-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: dzienniknowy
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `attendance`
--

DROP TABLE IF EXISTS `attendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `attendance` (
  `id_attendace` int NOT NULL AUTO_INCREMENT,
  `present` tinyint(1) DEFAULT NULL,
  `student` int DEFAULT NULL,
  `subject` int DEFAULT NULL,
  `attendance_date` date DEFAULT NULL,
  PRIMARY KEY (`id_attendace`),
  KEY `student` (`student`),
  KEY `subject` (`subject`),
  CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`student`) REFERENCES `students` (`id_student`),
  CONSTRAINT `attendance_ibfk_2` FOREIGN KEY (`subject`) REFERENCES `subjects` (`id_subject`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendance`
--

LOCK TABLES `attendance` WRITE;
/*!40000 ALTER TABLE `attendance` DISABLE KEYS */;
INSERT INTO `attendance` VALUES (1,1,1,3,'2023-03-27'),(2,1,2,3,'2023-03-27'),(3,0,3,3,'2023-03-27'),(4,1,4,3,'2023-03-27'),(5,0,5,3,'2023-03-27');
/*!40000 ALTER TABLE `attendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classes`
--

DROP TABLE IF EXISTS `classes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `classes` (
  `id_class` int NOT NULL AUTO_INCREMENT,
  `year` char(1) DEFAULT NULL,
  `subclass` char(1) DEFAULT NULL,
  `homeroom_teacher` int DEFAULT NULL,
  PRIMARY KEY (`id_class`),
  KEY `homeroom_teacher` (`homeroom_teacher`),
  CONSTRAINT `classes_ibfk_1` FOREIGN KEY (`homeroom_teacher`) REFERENCES `teachers` (`id_teacher`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classes`
--

LOCK TABLES `classes` WRITE;
/*!40000 ALTER TABLE `classes` DISABLE KEYS */;
INSERT INTO `classes` VALUES (1,'1','a',5),(2,'1','b',4),(3,'2','a',6),(4,'3','a',2),(5,'3','b',1);
/*!40000 ALTER TABLE `classes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grades`
--

DROP TABLE IF EXISTS `grades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `grades` (
  `id_grade` int NOT NULL AUTO_INCREMENT,
  `grade` char(1) DEFAULT NULL,
  `type` char(1) DEFAULT NULL,
  `teacher` int DEFAULT NULL,
  `student` int DEFAULT NULL,
  `date` date DEFAULT NULL,
  PRIMARY KEY (`id_grade`),
  KEY `student` (`student`),
  KEY `teacher` (`teacher`),
  CONSTRAINT `grades_ibfk_1` FOREIGN KEY (`student`) REFERENCES `students` (`id_student`),
  CONSTRAINT `grades_ibfk_2` FOREIGN KEY (`teacher`) REFERENCES `teachers` (`id_teacher`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grades`
--

LOCK TABLES `grades` WRITE;
/*!40000 ALTER TABLE `grades` DISABLE KEYS */;
INSERT INTO `grades` VALUES (1,'5','S',5,5,'2023-03-28'),(2,'2','S',5,3,'2023-03-28'),(3,'3','K',6,12,'2023-03-25'),(4,'5','K',6,11,'2023-03-25'),(5,'4','O',1,19,'2023-03-28'),(6,'1','O',1,17,'2023-03-28'),(7,'1','P',3,24,'2023-03-27'),(8,'3','P',3,22,'2023-03-27'),(9,'3','O',2,8,'2023-03-28'),(10,'3','O',2,9,'2023-03-28');
/*!40000 ALTER TABLE `grades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permissions`
--

DROP TABLE IF EXISTS `permissions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `permissions` (
  `id_perm` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `modify_students` char(1) DEFAULT NULL,
  `modify_teachers` char(1) DEFAULT NULL,
  `modify_timetable` char(1) DEFAULT NULL,
  `modify_subjects` char(1) DEFAULT NULL,
  PRIMARY KEY (`id_perm`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permissions`
--

LOCK TABLES `permissions` WRITE;
/*!40000 ALTER TABLE `permissions` DISABLE KEYS */;
INSERT INTO `permissions` VALUES (1,'Dyrektor','1','1','1','1'),(2,'Wice Dyrektor','1','0','1','1'),(3,'Nauczyciel','0','0','0','0');
/*!40000 ALTER TABLE `permissions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `students` (
  `id_student` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `surname` varchar(255) DEFAULT NULL,
  `pesel` varchar(11) DEFAULT NULL,
  `bth_date` date DEFAULT NULL,
  `class` int DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_student`),
  KEY `class` (`class`),
  CONSTRAINT `students_ibfk_1` FOREIGN KEY (`class`) REFERENCES `classes` (`id_class`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (1,'Marta','Marciniak','62160787265','2008-02-15',1,'MMarciniak2008','MMarciniak2008@gmail.com'),(2,'Tadeusz','Wilk','13584726747','2008-05-16',1,'TWilk2008','TWilk2008@gmail.com'),(3,'Oskar','Szulc','93113106401','2008-12-27',1,'OSzulc2008','OSzulc2008@gmail.com'),(4,'Maurycy','Duda','28135229714','2008-08-01',1,'MDuda2008','MDuda2008@gmail.com'),(5,'Daria','Zalewska','43283074404','2008-03-17',1,'DZalewska2008','DZalewska2008@gmail.com'),(6,'Julianna','Kowalska','45001239153','2008-10-10',2,'JKowalska2008','JKowalska2008@gmail.com'),(7,'Wiktoria','Biegun','79669849757','2008-02-18',2,'WBiegun2008','WBiegun2008@gmail.com'),(8,'Kinga','Szulc','09755869333','2008-01-30',2,'KSzulc2008','KSzulc2008@gmail.com'),(9,'Alan','Wozniak','10300450230','2008-09-12',2,'AWozniak2008','AWozniak2008@gmail.com'),(10,'Andrzej','Witkowski','64129146227','2008-05-16',2,'AWitkowski2008','AWitkowski2008@gmail.com'),(11,'Fryderyk','Lis','52043613797','2007-06-14',3,'FLis2007','FLis2007@gmail.com'),(12,'Emil','Maciejewski','94411107381','2007-11-30',3,'EMaciejewski2007','EMaciejewski2007@gmail.com'),(13,'Aleks','Wojciechowski','67213832056','2007-12-31',3,'AWojciechowski2007','AWojciechowski2007@gmail.com'),(14,'Daniel','Chmieleski','31012442293','2007-08-09',3,'Dchmielewski2007','Dchmielewski2007@gmail.com'),(15,'Juliusz','Jaworski','65998374344','2007-11-05',3,'JJaworski2007','JJaworski2007@gmail.com'),(16,'Sylwia','Sikora','77292982215','2006-02-17',4,'SSikora2006','SSikora2006@gmail.com'),(17,'Kacper','Mazur','46509224964','2006-09-11',4,'KMazur2006','KMazur2006@gmail.com'),(18,'Eustachy','Kondratowicz','19503029894','2006-02-28',4,'EKondratowicz2006','EKondratowicz2006@gmail.com'),(19,'Wiktor','Laskowski','63043512745','2006-04-01',4,'WLaskowicz2006','WLaskowicz2006@gmail.com'),(20,'Antoni','Kalinowski','49023047245','2006-04-02',4,'AKalinowski2006','AKalinowski2006@gmail.com'),(21,'Krystian','Kwiatkowski','14298329789','2006-07-25',5,'KKwiatkowski2006','KKwiatkowski2006@gmail.com'),(22,'Agnieszka','Majewska','75837503822','2006-09-28',5,'AMajewska','AMajewska@gmail.com'),(23,'Maksymilian','Lis','46710326791','2006-02-24',5,'MLis2006','MLis2006@gmail.com'),(24,'Monika','Dudek','02935123673','2006-05-18',5,'MDudek2006','MDudek2006@gmail.com'),(25,'Olaf','Michalak','92008120787','2006-06-01',5,'OMichalak2006','OMichalak2006@gmail.com');
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subjects`
--

DROP TABLE IF EXISTS `subjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `subjects` (
  `id_subject` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_subject`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjects`
--

LOCK TABLES `subjects` WRITE;
/*!40000 ALTER TABLE `subjects` DISABLE KEYS */;
INSERT INTO `subjects` VALUES (3,'Math'),(4,'English'),(5,'Polish'),(6,'German'),(7,'Chemistry'),(8,'Biology'),(9,'Geography'),(10,'Physics'),(11,'IT'),(12,'PE'),(13,'History'),(14,'Homeroom');
/*!40000 ALTER TABLE `subjects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teachers`
--

DROP TABLE IF EXISTS `teachers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `teachers` (
  `id_teacher` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `surname` varchar(255) DEFAULT NULL,
  `pesel` varchar(11) DEFAULT NULL,
  `bth_date` date DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `permissions` int DEFAULT NULL,
  PRIMARY KEY (`id_teacher`),
  KEY `permissions` (`permissions`),
  CONSTRAINT `teachers_ibfk_1` FOREIGN KEY (`permissions`) REFERENCES `permissions` (`id_perm`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teachers`
--

LOCK TABLES `teachers` WRITE;
/*!40000 ALTER TABLE `teachers` DISABLE KEYS */;
INSERT INTO `teachers` VALUES (1,'Adam','Nowak','12345678901','1990-10-23','ANowak1990','ANowak1990@gmail.com',3),(2,'Jan','Kowalski','21378654901','1975-05-13','JKowalski1975','JKowalski1975@gmail.com',2),(3,'Anna','Bocian','84652487956','1993-06-29','ABocian1993','ABocian1993@gmail.com',1),(4,'Grzegorz','Bielik','93756385746','1988-02-04','GBielik1988','GBielik1988@gmail.com',3),(5,'Wojciech','Chmiel','18346836585','1995-08-10','WChmiel1995','WChmiel1995@gmail.com',3),(6,'Andrzej','Brodnicki','84657358647','1980-12-24','ABrodnicki1980','ABrodnicki1980@gmail.com',3);
/*!40000 ALTER TABLE `teachers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `test_schedule`
--

DROP TABLE IF EXISTS `test_schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `test_schedule` (
  `id_test` int NOT NULL AUTO_INCREMENT,
  `sheduled_date` date DEFAULT NULL,
  `entry_date` date DEFAULT NULL,
  `subject` int DEFAULT NULL,
  `teacher` int DEFAULT NULL,
  `comment` varchar(255) DEFAULT NULL,
  `test_type` char(1) DEFAULT NULL,
  PRIMARY KEY (`id_test`),
  KEY `teacher` (`teacher`),
  KEY `subject` (`subject`),
  CONSTRAINT `test_schedule_ibfk_1` FOREIGN KEY (`teacher`) REFERENCES `teachers` (`id_teacher`),
  CONSTRAINT `test_schedule_ibfk_2` FOREIGN KEY (`subject`) REFERENCES `subjects` (`id_subject`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `test_schedule`
--

LOCK TABLES `test_schedule` WRITE;
/*!40000 ALTER TABLE `test_schedule` DISABLE KEYS */;
INSERT INTO `test_schedule` VALUES (1,'2023-04-09','2023-03-28',3,5,'testowy sprawdzian1','S'),(2,'2023-04-10','2023-03-28',3,5,'testowy sprawdzian2','S'),(3,'2023-04-06','2023-03-28',3,5,'testowa kartkówka1','K');
/*!40000 ALTER TABLE `test_schedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `timetable`
--

DROP TABLE IF EXISTS `timetable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `timetable` (
  `id_entry` int NOT NULL AUTO_INCREMENT,
  `class` int DEFAULT NULL,
  `subject` int DEFAULT NULL,
  `teacher` int DEFAULT NULL,
  `day_of_the_week` int DEFAULT NULL,
  `hour` int DEFAULT NULL,
  PRIMARY KEY (`id_entry`),
  KEY `teacher` (`teacher`),
  KEY `class` (`class`),
  KEY `subject` (`subject`),
  CONSTRAINT `timetable_ibfk_1` FOREIGN KEY (`teacher`) REFERENCES `teachers` (`id_teacher`),
  CONSTRAINT `timetable_ibfk_2` FOREIGN KEY (`class`) REFERENCES `classes` (`id_class`),
  CONSTRAINT `timetable_ibfk_3` FOREIGN KEY (`subject`) REFERENCES `subjects` (`id_subject`)
) ENGINE=InnoDB AUTO_INCREMENT=174 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `timetable`
--

LOCK TABLES `timetable` WRITE;
/*!40000 ALTER TABLE `timetable` DISABLE KEYS */;
INSERT INTO `timetable` VALUES (61,1,3,1,2,8),(62,1,3,1,2,9),(63,1,4,2,2,10),(64,1,4,2,2,11),(65,1,14,5,2,12),(67,2,5,2,2,8),(68,2,5,2,2,9),(69,2,6,3,2,10),(70,2,6,3,2,11),(71,2,14,4,2,12),(72,3,7,4,2,8),(73,3,7,4,2,9),(74,3,8,5,2,10),(75,3,8,5,2,11),(76,3,14,6,2,12),(77,4,9,6,2,8),(78,4,9,6,2,9),(79,4,10,1,2,10),(80,4,10,1,2,11),(81,4,14,2,2,12),(82,5,11,5,2,8),(83,5,11,5,2,9),(84,5,12,6,2,10),(85,5,12,6,2,11),(86,5,14,1,2,12),(87,1,5,2,3,8),(88,1,5,2,3,9),(89,1,6,3,3,10),(90,1,6,3,3,11),(91,2,7,4,3,8),(92,2,7,4,3,9),(93,2,8,5,3,10),(94,2,8,5,3,11),(95,3,9,6,3,8),(96,3,9,6,3,9),(97,3,10,2,3,10),(98,3,10,2,3,11),(99,4,11,5,3,8),(100,4,11,5,3,9),(101,4,12,6,3,10),(102,4,12,6,3,11),(105,5,3,1,3,10),(106,5,3,1,3,11),(107,5,13,3,3,8),(108,5,13,3,3,9),(109,1,7,4,4,8),(110,1,7,4,4,9),(111,1,8,5,4,10),(112,1,8,5,4,11),(113,2,9,6,4,8),(114,2,9,6,4,9),(115,2,10,2,4,10),(116,2,10,2,4,11),(117,3,11,5,4,8),(118,3,11,5,4,9),(119,3,12,6,4,10),(120,3,12,6,4,11),(121,4,13,3,4,8),(122,4,13,3,4,9),(123,4,3,1,4,10),(124,4,3,1,4,11),(125,5,5,2,4,8),(126,5,5,2,4,9),(127,5,6,3,4,10),(128,5,6,3,4,11),(129,1,9,1,5,8),(130,1,9,1,5,9),(131,1,10,2,5,10),(132,1,10,2,5,11),(133,2,11,2,5,8),(134,2,11,2,5,9),(135,2,12,3,5,10),(136,2,12,3,5,11),(137,3,13,3,5,8),(138,3,13,3,5,9),(139,3,3,5,5,10),(140,3,3,5,5,11),(141,4,4,6,5,8),(142,4,4,6,5,9),(143,4,5,1,5,10),(144,4,5,1,5,11),(145,5,6,5,5,8),(146,5,6,5,5,9),(147,5,7,6,5,10),(148,5,7,6,5,11),(149,1,11,1,6,8),(150,1,11,1,6,9),(151,1,12,2,6,10),(152,1,12,2,6,11),(153,1,13,2,6,12),(154,2,13,2,6,8),(155,2,13,2,6,9),(156,2,3,3,6,10),(157,2,3,3,6,11),(158,2,4,3,6,12),(159,3,4,4,6,8),(160,3,4,4,6,9),(161,3,5,5,6,10),(162,3,5,5,6,11),(163,3,6,5,6,12),(164,4,6,6,6,8),(165,4,6,6,6,9),(166,4,7,1,6,10),(167,4,7,1,6,11),(168,4,8,1,6,12),(169,5,8,5,6,8),(170,5,8,5,6,9),(171,5,9,6,6,10),(172,5,9,6,6,11),(173,5,10,6,6,12);
/*!40000 ALTER TABLE `timetable` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-05 19:45:44