-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: dziennik6
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
-- Table structure for table `attendace`
--

DROP TABLE IF EXISTS `attendace`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `attendace` (
  `id_attendace` int NOT NULL AUTO_INCREMENT,
  `present` tinyint(1) DEFAULT NULL,
  `student` int DEFAULT NULL,
  `subject` int DEFAULT NULL,
  PRIMARY KEY (`id_attendace`),
  KEY `student` (`student`),
  KEY `subject` (`subject`),
  CONSTRAINT `attendace_ibfk_1` FOREIGN KEY (`student`) REFERENCES `students` (`id_student`),
  CONSTRAINT `attendace_ibfk_2` FOREIGN KEY (`subject`) REFERENCES `subjects` (`id_subject`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendace`
--

LOCK TABLES `attendace` WRITE;
/*!40000 ALTER TABLE `attendace` DISABLE KEYS */;
/*!40000 ALTER TABLE `attendace` ENABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classes`
--

LOCK TABLES `classes` WRITE;
/*!40000 ALTER TABLE `classes` DISABLE KEYS */;
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
  `grade` int DEFAULT NULL,
  `type` char(1) DEFAULT NULL,
  `teacher` int DEFAULT NULL,
  `student` int DEFAULT NULL,
  PRIMARY KEY (`id_grade`),
  KEY `student` (`student`),
  KEY `teacher` (`teacher`),
  CONSTRAINT `grades_ibfk_1` FOREIGN KEY (`student`) REFERENCES `students` (`id_student`),
  CONSTRAINT `grades_ibfk_2` FOREIGN KEY (`teacher`) REFERENCES `teachers` (`id_teacher`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grades`
--

LOCK TABLES `grades` WRITE;
/*!40000 ALTER TABLE `grades` DISABLE KEYS */;
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
  `pesel` int DEFAULT NULL,
  `bth_date` date DEFAULT NULL,
  `class` int DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_student`),
  KEY `class` (`class`),
  CONSTRAINT `students_ibfk_1` FOREIGN KEY (`class`) REFERENCES `classes` (`id_class`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjects`
--

LOCK TABLES `subjects` WRITE;
/*!40000 ALTER TABLE `subjects` DISABLE KEYS */;
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
  `pesel` int DEFAULT NULL,
  `bth_date` date DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_teacher`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teachers`
--

LOCK TABLES `teachers` WRITE;
/*!40000 ALTER TABLE `teachers` DISABLE KEYS */;
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
  PRIMARY KEY (`id_test`),
  KEY `teacher` (`teacher`),
  KEY `subject` (`subject`),
  CONSTRAINT `test_schedule_ibfk_1` FOREIGN KEY (`teacher`) REFERENCES `teachers` (`id_teacher`),
  CONSTRAINT `test_schedule_ibfk_2` FOREIGN KEY (`subject`) REFERENCES `subjects` (`id_subject`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `test_schedule`
--

LOCK TABLES `test_schedule` WRITE;
/*!40000 ALTER TABLE `test_schedule` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `timetable`
--

LOCK TABLES `timetable` WRITE;
/*!40000 ALTER TABLE `timetable` DISABLE KEYS */;
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

-- Dump completed on 2023-03-22 12:42:59
