-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 14, 2023 at 11:20 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dziennik`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `id_attendace` int(11) NOT NULL,
  `present` tinyint(1) DEFAULT NULL,
  `student` int(11) DEFAULT NULL,
  `subject` int(11) DEFAULT NULL,
  `attendance_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`id_attendace`, `present`, `student`, `subject`, `attendance_date`) VALUES
(1, 1, 1, 3, '2023-03-27'),
(2, 1, 2, 3, '2023-03-27'),
(3, 0, 3, 3, '2023-03-27'),
(4, 1, 4, 3, '2023-03-27'),
(5, 0, 5, 3, '2023-03-27');

-- --------------------------------------------------------

--
-- Table structure for table `classes`
--

CREATE TABLE `classes` (
  `id_class` int(11) NOT NULL,
  `year` char(1) DEFAULT NULL,
  `subclass` char(1) DEFAULT NULL,
  `homeroom_teacher` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `classes`
--

INSERT INTO `classes` (`id_class`, `year`, `subclass`, `homeroom_teacher`) VALUES
(1, '1', 'a', 5),
(2, '1', 'b', 4),
(3, '2', 'a', 6),
(4, '3', 'a', 2),
(5, '3', 'b', 1);

-- --------------------------------------------------------

--
-- Table structure for table `grades`
--

CREATE TABLE `grades` (
  `id_grade` int(11) NOT NULL,
  `grade` char(1) DEFAULT NULL,
  `type` char(1) DEFAULT NULL,
  `subject` int(1) NOT NULL,
  `teacher` int(11) DEFAULT NULL,
  `student` int(11) DEFAULT NULL,
  `date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `grades`
--

INSERT INTO `grades` (`id_grade`, `grade`, `type`, `subject`, `teacher`, `student`, `date`) VALUES
(1, '5', 'S', 11, 5, 5, '2023-03-28'),
(2, '2', 'S', 11, 5, 3, '2023-03-28'),
(3, '3', 'K', 9, 6, 12, '2023-03-25'),
(4, '5', 'K', 9, 6, 11, '2023-03-25'),
(5, '4', 'O', 10, 1, 19, '2023-03-28'),
(6, '1', 'O', 10, 1, 17, '2023-03-28'),
(7, '1', 'P', 6, 3, 24, '2023-03-27'),
(8, '3', 'P', 6, 3, 22, '2023-03-27'),
(9, '3', 'O', 5, 2, 8, '2023-03-28'),
(10, '3', 'O', 5, 2, 9, '2023-03-28'),
(11, '5', 'K', 3, 1, 5, '2023-05-14'),
(12, '2', 'S', 3, 1, 5, '2023-05-08'),
(13, '3', 'O', 11, 5, 5, '2023-05-01');

-- --------------------------------------------------------

--
-- Table structure for table `permissions`
--

CREATE TABLE `permissions` (
  `id_perm` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `modify_students` char(1) DEFAULT NULL,
  `modify_teachers` char(1) DEFAULT NULL,
  `modify_timetable` char(1) DEFAULT NULL,
  `modify_subjects` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `permissions`
--

INSERT INTO `permissions` (`id_perm`, `name`, `modify_students`, `modify_teachers`, `modify_timetable`, `modify_subjects`) VALUES
(1, 'Dyrektor', '1', '1', '1', '1'),
(2, 'Wice Dyrektor', '1', '0', '1', '1'),
(3, 'Nauczyciel', '0', '0', '0', '0');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `id_student` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `surname` varchar(255) DEFAULT NULL,
  `pesel` varchar(11) DEFAULT NULL,
  `bth_date` date DEFAULT NULL,
  `class` int(11) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`id_student`, `name`, `surname`, `pesel`, `bth_date`, `class`, `password`, `email`) VALUES
(1, 'Marta', 'Marciniak', '62160787265', '2008-02-15', 1, 'MMarciniak2008', 'MMarciniak2008@gmail.com'),
(2, 'Tadeusz', 'Wilk', '13584726747', '2008-05-16', 1, 'TWilk2008', 'TWilk2008@gmail.com'),
(3, 'Oskar', 'Szulc', '93113106401', '2008-12-27', 1, 'OSzulc2008', 'OSzulc2008@gmail.com'),
(4, 'Maurycy', 'Duda', '28135229714', '2008-08-01', 1, 'MDuda2008', 'MDuda2008@gmail.com'),
(5, 'Daria', 'Zalewska', '43283074404', '2008-03-17', 1, 'DZalewska2008', 'DZalewska2008@gmail.com'),
(6, 'Julianna', 'Kowalska', '45001239153', '2008-10-10', 2, 'JKowalska2008', 'JKowalska2008@gmail.com'),
(7, 'Wiktoria', 'Biegun', '79669849757', '2008-02-18', 2, 'WBiegun2008', 'WBiegun2008@gmail.com'),
(8, 'Kinga', 'Szulc', '09755869333', '2008-01-30', 2, 'KSzulc2008', 'KSzulc2008@gmail.com'),
(9, 'Alan', 'Wozniak', '10300450230', '2008-09-12', 2, 'AWozniak2008', 'AWozniak2008@gmail.com'),
(10, 'Andrzej', 'Witkowski', '64129146227', '2008-05-16', 2, 'AWitkowski2008', 'AWitkowski2008@gmail.com'),
(11, 'Fryderyk', 'Lis', '52043613797', '2007-06-14', 3, 'FLis2007', 'FLis2007@gmail.com'),
(12, 'Emil', 'Maciejewski', '94411107381', '2007-11-30', 3, 'EMaciejewski2007', 'EMaciejewski2007@gmail.com'),
(13, 'Aleks', 'Wojciechowski', '67213832056', '2007-12-31', 3, 'AWojciechowski2007', 'AWojciechowski2007@gmail.com'),
(14, 'Daniel', 'Chmieleski', '31012442293', '2007-08-09', 3, 'Dchmielewski2007', 'Dchmielewski2007@gmail.com'),
(15, 'Juliusz', 'Jaworski', '65998374344', '2007-11-05', 3, 'JJaworski2007', 'JJaworski2007@gmail.com'),
(16, 'Sylwia', 'Sikora', '77292982215', '2006-02-17', 4, 'SSikora2006', 'SSikora2006@gmail.com'),
(17, 'Kacper', 'Mazur', '46509224964', '2006-09-11', 4, 'KMazur2006', 'KMazur2006@gmail.com'),
(18, 'Eustachy', 'Kondratowicz', '19503029894', '2006-02-28', 4, 'EKondratowicz2006', 'EKondratowicz2006@gmail.com'),
(19, 'Wiktor', 'Laskowski', '63043512745', '2006-04-01', 4, 'WLaskowicz2006', 'WLaskowicz2006@gmail.com'),
(20, 'Antoni', 'Kalinowski', '49023047245', '2006-04-02', 4, 'AKalinowski2006', 'AKalinowski2006@gmail.com'),
(21, 'Krystian', 'Kwiatkowski', '14298329789', '2006-07-25', 5, 'KKwiatkowski2006', 'KKwiatkowski2006@gmail.com'),
(22, 'Agnieszka', 'Majewska', '75837503822', '2006-09-28', 5, 'AMajewska', 'AMajewska@gmail.com'),
(23, 'Maksymilian', 'Lis', '46710326791', '2006-02-24', 5, 'MLis2006', 'MLis2006@gmail.com'),
(24, 'Monika', 'Dudek', '02935123673', '2006-05-18', 5, 'MDudek2006', 'MDudek2006@gmail.com'),
(25, 'Olaf', 'Michalak', '92008120787', '2006-06-01', 5, 'OMichalak2006', 'OMichalak2006@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `id_subject` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`id_subject`, `name`) VALUES
(3, 'Matematyka'),
(4, 'Język Angielski'),
(5, 'Język Polski'),
(6, 'Język Niemiecki'),
(7, 'Chemia'),
(8, 'Biologia'),
(9, 'Geografia'),
(10, 'Fizyka'),
(11, 'Informatyka'),
(12, 'Wf'),
(13, 'Historia'),
(14, 'Godzina Wychowawcza');

-- --------------------------------------------------------

--
-- Table structure for table `teachers`
--

CREATE TABLE `teachers` (
  `id_teacher` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `surname` varchar(255) DEFAULT NULL,
  `pesel` varchar(11) DEFAULT NULL,
  `bth_date` date DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `permissions` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `teachers`
--

INSERT INTO `teachers` (`id_teacher`, `name`, `surname`, `pesel`, `bth_date`, `password`, `email`, `permissions`) VALUES
(1, 'Adam', 'Nowak', '12345678901', '1990-10-23', 'ANowak1990', 'ANowak1990@gmail.com', 3),
(2, 'Jan', 'Kowalski', '21378654901', '1975-05-13', 'JKowalski1975', 'JKowalski1975@gmail.com', 2),
(3, 'Anna', 'Bocian', '84652487956', '1993-06-29', 'ABocian1993', 'ABocian1993@gmail.com', 1),
(4, 'Grzegorz', 'Bielik', '93756385746', '1988-02-04', 'GBielik1988', 'GBielik1988@gmail.com', 3),
(5, 'Wojciech', 'Chmiel', '18346836585', '1995-08-10', 'WChmiel1995', 'WChmiel1995@gmail.com', 3),
(6, 'Andrzej', 'Brodnicki', '84657358647', '1980-12-24', 'ABrodnicki1980', 'ABrodnicki1980@gmail.com', 3);

-- --------------------------------------------------------

--
-- Table structure for table `test_schedule`
--

CREATE TABLE `test_schedule` (
  `id_test` int(11) NOT NULL,
  `sheduled_date` date DEFAULT NULL,
  `entry_date` date DEFAULT NULL,
  `subject` int(11) DEFAULT NULL,
  `teacher` int(11) DEFAULT NULL,
  `class` int(11) NOT NULL,
  `comment` varchar(255) DEFAULT NULL,
  `test_type` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `test_schedule`
--

INSERT INTO `test_schedule` (`id_test`, `sheduled_date`, `entry_date`, `subject`, `teacher`, `class`, `comment`, `test_type`) VALUES
(1, '2023-04-09', '2023-03-28', 3, 5, 3, 'testowy sprawdzian1', 'S'),
(2, '2023-04-10', '2023-03-28', 3, 5, 5, 'testowy sprawdzian2', 'S'),
(3, '2023-04-06', '2023-03-28', 3, 5, 4, 'testowa kartkówka1', 'K');

-- --------------------------------------------------------

--
-- Table structure for table `timetable`
--

CREATE TABLE `timetable` (
  `id_entry` int(11) NOT NULL,
  `class` int(11) DEFAULT NULL,
  `subject` int(11) DEFAULT NULL,
  `teacher` int(11) DEFAULT NULL,
  `day_of_the_week` int(11) DEFAULT NULL,
  `hour` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `timetable`
--

INSERT INTO `timetable` (`id_entry`, `class`, `subject`, `teacher`, `day_of_the_week`, `hour`) VALUES
(61, 1, 3, 1, 2, 8),
(62, 1, 3, 1, 2, 9),
(63, 1, 4, 2, 2, 10),
(64, 1, 4, 2, 2, 11),
(65, 1, 14, 5, 2, 12),
(67, 2, 5, 2, 2, 8),
(68, 2, 5, 2, 2, 9),
(69, 2, 6, 3, 2, 10),
(70, 2, 6, 3, 2, 11),
(71, 2, 14, 4, 2, 12),
(72, 3, 7, 4, 2, 8),
(73, 3, 7, 4, 2, 9),
(74, 3, 8, 5, 2, 10),
(75, 3, 8, 5, 2, 11),
(76, 3, 14, 6, 2, 12),
(77, 4, 9, 6, 2, 8),
(78, 4, 9, 6, 2, 9),
(79, 4, 10, 1, 2, 10),
(80, 4, 10, 1, 2, 11),
(81, 4, 14, 2, 2, 12),
(82, 5, 11, 5, 2, 8),
(83, 5, 11, 5, 2, 9),
(84, 5, 12, 6, 2, 10),
(85, 5, 12, 6, 2, 11),
(86, 5, 14, 1, 2, 12),
(87, 1, 5, 2, 3, 8),
(88, 1, 5, 2, 3, 9),
(89, 1, 6, 3, 3, 10),
(90, 1, 6, 3, 3, 11),
(91, 2, 7, 4, 3, 8),
(92, 2, 7, 4, 3, 9),
(93, 2, 8, 5, 3, 10),
(94, 2, 8, 5, 3, 11),
(95, 3, 9, 6, 3, 8),
(96, 3, 9, 6, 3, 9),
(97, 3, 10, 2, 3, 10),
(98, 3, 10, 2, 3, 11),
(99, 4, 11, 5, 3, 8),
(100, 4, 11, 5, 3, 9),
(101, 4, 12, 6, 3, 10),
(102, 4, 12, 6, 3, 11),
(105, 5, 3, 1, 3, 10),
(106, 5, 3, 1, 3, 11),
(107, 5, 13, 3, 3, 8),
(108, 5, 13, 3, 3, 9),
(109, 1, 7, 4, 4, 8),
(110, 1, 7, 4, 4, 9),
(111, 1, 8, 5, 4, 10),
(112, 1, 8, 5, 4, 11),
(113, 2, 9, 6, 4, 8),
(114, 2, 9, 6, 4, 9),
(115, 2, 10, 2, 4, 10),
(116, 2, 10, 2, 4, 11),
(117, 3, 11, 5, 4, 8),
(118, 3, 11, 5, 4, 9),
(119, 3, 12, 6, 4, 10),
(120, 3, 12, 6, 4, 11),
(121, 4, 13, 3, 4, 8),
(122, 4, 13, 3, 4, 9),
(123, 4, 3, 1, 4, 10),
(124, 4, 3, 1, 4, 11),
(125, 5, 5, 2, 4, 8),
(126, 5, 5, 2, 4, 9),
(127, 5, 6, 3, 4, 10),
(128, 5, 6, 3, 4, 11),
(129, 1, 9, 1, 5, 8),
(130, 1, 9, 1, 5, 9),
(131, 1, 10, 2, 5, 10),
(132, 1, 10, 2, 5, 11),
(133, 2, 11, 2, 5, 8),
(134, 2, 11, 2, 5, 9),
(135, 2, 12, 3, 5, 10),
(136, 2, 12, 3, 5, 11),
(137, 3, 13, 3, 5, 8),
(138, 3, 13, 3, 5, 9),
(139, 3, 3, 5, 5, 10),
(140, 3, 3, 5, 5, 11),
(141, 4, 4, 6, 5, 8),
(142, 4, 4, 6, 5, 9),
(143, 4, 5, 1, 5, 10),
(144, 4, 5, 1, 5, 11),
(145, 5, 6, 5, 5, 8),
(146, 5, 6, 5, 5, 9),
(147, 5, 7, 6, 5, 10),
(148, 5, 7, 6, 5, 11),
(149, 1, 11, 1, 6, 8),
(150, 1, 11, 1, 6, 9),
(151, 1, 12, 2, 6, 10),
(152, 1, 12, 2, 6, 11),
(153, 1, 13, 2, 6, 12),
(154, 2, 13, 2, 6, 8),
(155, 2, 13, 2, 6, 9),
(156, 2, 3, 3, 6, 10),
(157, 2, 3, 3, 6, 11),
(158, 2, 4, 3, 6, 12),
(159, 3, 4, 4, 6, 8),
(160, 3, 4, 4, 6, 9),
(161, 3, 5, 5, 6, 10),
(162, 3, 5, 5, 6, 11),
(163, 3, 6, 5, 6, 12),
(164, 4, 6, 6, 6, 8),
(165, 4, 6, 6, 6, 9),
(166, 4, 7, 1, 6, 10),
(167, 4, 7, 1, 6, 11),
(168, 4, 8, 1, 6, 12),
(169, 5, 8, 5, 6, 8),
(170, 5, 8, 5, 6, 9),
(171, 5, 9, 6, 6, 10),
(172, 5, 9, 6, 6, 11),
(173, 5, 10, 6, 6, 12);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`id_attendace`),
  ADD KEY `student` (`student`),
  ADD KEY `subject` (`subject`);

--
-- Indexes for table `classes`
--
ALTER TABLE `classes`
  ADD PRIMARY KEY (`id_class`),
  ADD KEY `homeroom_teacher` (`homeroom_teacher`);

--
-- Indexes for table `grades`
--
ALTER TABLE `grades`
  ADD PRIMARY KEY (`id_grade`),
  ADD KEY `student` (`student`),
  ADD KEY `teacher` (`teacher`);

--
-- Indexes for table `permissions`
--
ALTER TABLE `permissions`
  ADD PRIMARY KEY (`id_perm`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`id_student`),
  ADD KEY `class` (`class`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`id_subject`);

--
-- Indexes for table `teachers`
--
ALTER TABLE `teachers`
  ADD PRIMARY KEY (`id_teacher`),
  ADD KEY `permissions` (`permissions`);

--
-- Indexes for table `test_schedule`
--
ALTER TABLE `test_schedule`
  ADD PRIMARY KEY (`id_test`),
  ADD KEY `teacher` (`teacher`),
  ADD KEY `subject` (`subject`);

--
-- Indexes for table `timetable`
--
ALTER TABLE `timetable`
  ADD PRIMARY KEY (`id_entry`),
  ADD KEY `teacher` (`teacher`),
  ADD KEY `class` (`class`),
  ADD KEY `subject` (`subject`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `id_attendace` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `classes`
--
ALTER TABLE `classes`
  MODIFY `id_class` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `grades`
--
ALTER TABLE `grades`
  MODIFY `id_grade` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `permissions`
--
ALTER TABLE `permissions`
  MODIFY `id_perm` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `id_student` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `id_subject` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `teachers`
--
ALTER TABLE `teachers`
  MODIFY `id_teacher` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `test_schedule`
--
ALTER TABLE `test_schedule`
  MODIFY `id_test` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `timetable`
--
ALTER TABLE `timetable`
  MODIFY `id_entry` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=174;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`student`) REFERENCES `students` (`id_student`),
  ADD CONSTRAINT `attendance_ibfk_2` FOREIGN KEY (`subject`) REFERENCES `subjects` (`id_subject`);

--
-- Constraints for table `classes`
--
ALTER TABLE `classes`
  ADD CONSTRAINT `classes_ibfk_1` FOREIGN KEY (`homeroom_teacher`) REFERENCES `teachers` (`id_teacher`);

--
-- Constraints for table `grades`
--
ALTER TABLE `grades`
  ADD CONSTRAINT `grades_ibfk_1` FOREIGN KEY (`student`) REFERENCES `students` (`id_student`),
  ADD CONSTRAINT `grades_ibfk_2` FOREIGN KEY (`teacher`) REFERENCES `teachers` (`id_teacher`);

--
-- Constraints for table `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `students_ibfk_1` FOREIGN KEY (`class`) REFERENCES `classes` (`id_class`);

--
-- Constraints for table `teachers`
--
ALTER TABLE `teachers`
  ADD CONSTRAINT `teachers_ibfk_1` FOREIGN KEY (`permissions`) REFERENCES `permissions` (`id_perm`);

--
-- Constraints for table `test_schedule`
--
ALTER TABLE `test_schedule`
  ADD CONSTRAINT `test_schedule_ibfk_1` FOREIGN KEY (`teacher`) REFERENCES `teachers` (`id_teacher`),
  ADD CONSTRAINT `test_schedule_ibfk_2` FOREIGN KEY (`subject`) REFERENCES `subjects` (`id_subject`);

--
-- Constraints for table `timetable`
--
ALTER TABLE `timetable`
  ADD CONSTRAINT `timetable_ibfk_1` FOREIGN KEY (`teacher`) REFERENCES `teachers` (`id_teacher`),
  ADD CONSTRAINT `timetable_ibfk_2` FOREIGN KEY (`class`) REFERENCES `classes` (`id_class`),
  ADD CONSTRAINT `timetable_ibfk_3` FOREIGN KEY (`subject`) REFERENCES `subjects` (`id_subject`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
