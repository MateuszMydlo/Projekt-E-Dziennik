-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: dziennik
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
/*!50503 SET character_set_client = utf8mb4 */;
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `classes` (
  `id_class` int NOT NULL AUTO_INCREMENT,
  `year` char(1) DEFAULT NULL,
  `subclass` char(1) DEFAULT NULL,
  `homeroom_teacher` int DEFAULT NULL,
  PRIMARY KEY (`id_class`),
  KEY `homeroom_teacher` (`homeroom_teacher`),
  CONSTRAINT `classes_ibfk_1` FOREIGN KEY (`homeroom_teacher`) REFERENCES `teachers` (`id_teacher`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
/*!50503 SET character_set_client = utf8mb4 */;
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
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `id_student` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `surname` varchar(255) DEFAULT NULL,
  `pesel` varchar(11) DEFAULT NULL,
  `bth_date` date DEFAULT NULL,
  `class` int DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_student`),
  KEY `class` (`class`),
  CONSTRAINT `students_ibfk_1` FOREIGN KEY (`class`) REFERENCES `classes` (`id_class`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (1,'Marta','Marciniak','62160787265','2008-02-15',1,'MMarciniak2008'),(2,'Tadeusz','Wilk','13584726747','2008-05-16',1,'TWilk2008'),(3,'Oskar','Szulc','93113106401','2008-12-27',1,'OSzulc2008'),(4,'Maurycy','Duda','28135229714','2008-08-01',1,'MDuda2008'),(5,'Daria','Zalewska','43283074404','2008-03-17',1,'DZalewska2008'),(6,'Julianna','Kowalska','45001239153','2008-10-10',2,'JKowalska2008'),(7,'Wiktoria','Biegun','79669849757','2008-02-18',2,'WBiegun2008'),(8,'Kinga','Szulc','09755869333','2008-01-30',2,'KSzulc2008'),(9,'Alan','Wozniak','10300450230','2008-09-12',2,'AWozniak2008'),(10,'Andrzej','Witkowski','64129146227','2008-05-16',2,'AWitkowski2008'),(11,'Fryderyk','Lis','52043613797','2007-06-14',3,'FLis2007'),(12,'Emil','Maciejewski','94411107381','2007-11-30',3,'EMaciejewski2007'),(13,'Aleks','Wojciechowski','67213832056','2007-12-31',3,'AWojciechowski2007'),(14,'Daniel','Chmieleski','31012442293','2007-08-09',3,'Dchmielewski2007'),(15,'Juliusz','Jaworski','65998374344','2007-11-05',3,'JJaworski2007'),(16,'Sylwia','Sikora','77292982215','2006-02-17',4,'SSikora2006'),(17,'Kacper','Mazur','46509224964','2006-09-11',4,'KMazur2006'),(18,'Eustachy','Kondratowicz','19503029894','2006-02-28',4,'EKondratowicz2006'),(19,'Wiktor','Laskowski','63043512745','2006-04-01',4,'WLaskowicz2006'),(20,'Antoni','Kalinowski','49023047245','2006-04-02',4,'AKalinowski2006'),(21,'Krystian','Kwiatkowski','14298329789','2006-07-25',5,'KKwiatkowski2006'),(22,'Agnieszka','Majewska','75837503822','2006-09-28',5,'AMajewska'),(23,'Maksymilian','Lis','46710326791','2006-02-24',5,'MLis2006'),(24,'Monika','Dudek','02935123673','2006-05-18',5,'MDudek2006'),(25,'Olaf','Michalak','92008120787','2006-06-01',5,'OMichalak2006');
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subjects`
--

DROP TABLE IF EXISTS `subjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subjects` (
  `id_subject` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_subject`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teachers` (
  `id_teacher` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `surname` varchar(255) DEFAULT NULL,
  `pesel` varchar(11) DEFAULT NULL,
  `bth_date` date DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_teacher`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teachers`
--

LOCK TABLES `teachers` WRITE;
/*!40000 ALTER TABLE `teachers` DISABLE KEYS */;
INSERT INTO `teachers` VALUES (1,'Adam','Nowak','12345678901','1990-10-23','ANowak1990'),(2,'Jan','Kowalski','21378654901','1975-05-13','JKowalski1975'),(3,'Anna','Bocian','84652487956','1993-06-29','ABocian1993'),(4,'Grzegorz','Bielik','93756385746','1988-02-04','GBielik1988'),(5,'Wojciech','Chmiel','18346836585','1995-08-10','WChmiel1995'),(6,'Andrzej','Brodnicki','84657358647','1980-12-24','ABrodnicki1980');
/*!40000 ALTER TABLE `teachers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `test_schedule`
--

DROP TABLE IF EXISTS `test_schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `timetable` (
  `id_entry` int NOT NULL AUTO_INCREMENT,
  `class` int DEFAULT NULL,
  `subject` int DEFAULT NULL,
  `teacher` int DEFAULT NULL,
  `day_of_the_week` varchar(255) DEFAULT NULL,
  `hour` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_entry`),
  KEY `teacher` (`teacher`),
  KEY `class` (`class`),
  KEY `subject` (`subject`),
  CONSTRAINT `timetable_ibfk_1` FOREIGN KEY (`teacher`) REFERENCES `teachers` (`id_teacher`),
  CONSTRAINT `timetable_ibfk_2` FOREIGN KEY (`class`) REFERENCES `classes` (`id_class`),
  CONSTRAINT `timetable_ibfk_3` FOREIGN KEY (`subject`) REFERENCES `subjects` (`id_subject`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `timetable`
--

LOCK TABLES `timetable` WRITE;
/*!40000 ALTER TABLE `timetable` DISABLE KEYS */;
INSERT INTO `timetable` VALUES (1,1,3,1,'Monday','8 - 10'),(2,1,4,2,'Monday','10 - 12'),(3,1,14,3,'Monday','12 - 13'),(4,2,5,2,'Monday','8 - 10'),(5,2,6,3,'Monday','10 - 12'),(6,2,14,4,'Monday','12 - 13'),(7,3,7,4,'Monday','8 - 10'),(8,3,8,5,'Monday','10 - 12'),(9,3,14,6,'Monday','12 - 13'),(10,4,9,6,'Monday','8 - 10'),(11,4,10,1,'Monday','10 - 12'),(12,4,14,2,'Monday','12 - 13'),(13,5,11,5,'Monday','8 - 10'),(14,5,12,6,'Monday','10 - 12'),(15,5,14,1,'Monday','12 - 13'),(16,1,5,2,'Tuesday','8 - 10'),(17,1,6,3,'Tuesday','10 - 12'),(18,2,7,4,'Tuesday','8 - 10'),(19,2,8,5,'Tuesday','10 - 12'),(20,3,9,6,'Tuesday','8 - 10'),(21,3,10,2,'Tuesday','10 - 12'),(22,4,11,5,'Tuesday','8 - 10'),(23,4,12,6,'Tuesday','10 - 12'),(24,5,13,6,'Tuesday','8 - 10'),(25,5,3,1,'Tuesday','10 - 12'),(26,1,7,4,'Wednesday','8 - 10'),(27,1,8,5,'Wednesday','10 - 12'),(28,2,9,6,'Wednesday','8 - 10'),(29,2,10,2,'Wednesday','10 - 12'),(30,3,11,5,'Wednesday','8 - 10'),(31,3,12,6,'Wednesday','10 - 12'),(32,4,13,5,'Wednesday','8 - 10'),(33,4,3,1,'Wednesday','10 - 12'),(34,5,5,2,'Wednesday','8 - 10'),(35,5,6,3,'Wednesday','10 - 12'),(36,1,9,1,'Thursday','8 - 10'),(37,1,10,2,'Thursday','10 - 12'),(38,2,11,2,'Thursday','8 - 10'),(39,2,12,3,'Thursday','10 - 12'),(40,3,13,4,'Thursday','8 - 10'),(41,3,3,5,'Thursday','10 - 12'),(42,4,4,6,'Thursday','8 - 10'),(43,4,5,1,'Thursday','10 - 12'),(44,5,6,5,'Thursday','8 - 10'),(45,5,7,6,'Thursday','10 - 12'),(46,1,11,1,'Friday','8 - 10'),(47,1,12,2,'Friday','10 - 12'),(48,1,13,2,'Friday','10 - 12'),(49,2,13,2,'Friday','8 - 10'),(50,2,3,3,'Friday','10 - 12'),(51,2,4,3,'Friday','10 - 12'),(52,3,4,4,'Friday','8 - 10'),(53,3,5,5,'Friday','10 - 12'),(54,3,6,5,'Friday','10 - 12'),(55,4,6,6,'Friday','8 - 10'),(56,4,7,1,'Friday','10 - 12'),(57,4,8,1,'Friday','10 - 12'),(58,5,8,5,'Friday','8 - 10'),(59,5,9,6,'Friday','10 - 12'),(60,5,10,6,'Friday','10 - 12');
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

-- Dump completed on 2023-03-28 19:04:11
