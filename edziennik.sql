-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 20 Mar 2023, 13:13
-- Wersja serwera: 10.4.25-MariaDB
-- Wersja PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `edziennik`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klasa_1a`
--

CREATE TABLE `klasa_1a` (
  `ID` bigint(20) DEFAULT NULL,
  `Imie` varchar(500) DEFAULT NULL,
  `Nazwisko` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `klasa_1a`
--

INSERT INTO `klasa_1a` (`ID`, `Imie`, `Nazwisko`) VALUES
(1, 'Rebecca', 'Mccall'),
(2, 'Aleksandra', 'Fulton'),
(3, 'Callie', 'Abbot'),
(4, 'Megan', 'Woodcock'),
(5, 'Sebastian', 'Lunt'),
(6, 'Hayden', 'Sanchez'),
(7, 'Benny', 'Leslie'),
(8, 'Eryn', 'Hunt'),
(9, 'Mark', 'Alexander'),
(10, 'Enoch', 'Cork'),
(11, 'Noemi', 'Ainsworth'),
(12, 'Hanna', 'Woods'),
(13, 'Cadence', 'Rainford'),
(14, 'Anthony', 'Cassidy'),
(15, 'Lucy', 'Thorne'),
(16, 'Russel', 'Graham'),
(17, 'Abdul', 'Alcroft'),
(18, 'Hank', 'Rehman'),
(19, 'Iris', 'Walton'),
(20, 'Henry', 'Walter'),
(21, 'John', 'Purvis'),
(22, 'Aiden', 'Vincent');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klasa_1b`
--

CREATE TABLE `klasa_1b` (
  `ID` bigint(20) DEFAULT NULL,
  `Imie` varchar(500) DEFAULT NULL,
  `Nazwisko` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `klasa_1b`
--

INSERT INTO `klasa_1b` (`ID`, `Imie`, `Nazwisko`) VALUES
(1, 'Mark', 'Dunbar'),
(2, 'Lorraine', 'Stevenson'),
(3, 'Chuck', 'Sawyer'),
(4, 'Marvin', 'Zaoui'),
(5, 'Fred', 'Gordon'),
(6, 'Barney', 'Wilcox'),
(7, 'Trisha', 'Archer'),
(8, 'Michelle', 'Burnley'),
(9, 'Sebastian', 'Pickard'),
(10, 'Camellia', 'Allcott'),
(11, 'Logan', 'Vaughan'),
(12, 'Carmella', 'Duvall'),
(13, 'Leah', 'Harrington'),
(14, 'Johnathan', 'Norman'),
(15, 'Cadence', 'Rehman'),
(16, 'Mackenzie', 'Oldfield'),
(17, 'Drew', 'Savage'),
(18, 'Taylor', 'Collis'),
(19, 'Ramon', 'Baxter'),
(20, 'Danny', 'Lynch');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klasa_2a`
--

CREATE TABLE `klasa_2a` (
  `ID` bigint(20) DEFAULT NULL,
  `Imie` varchar(500) DEFAULT NULL,
  `Nazwisko` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `klasa_2a`
--

INSERT INTO `klasa_2a` (`ID`, `Imie`, `Nazwisko`) VALUES
(1, 'Johnny', 'Carter'),
(2, 'Danny', 'Vaughan'),
(3, 'Nancy', 'Gray'),
(4, 'Kurt', 'Lloyd'),
(5, 'Johnathan', 'Martin'),
(6, 'Mark', 'Miller'),
(7, 'Matthew', 'Khan'),
(8, 'Clarissa', 'Downing'),
(9, 'Samantha', 'Morrow'),
(10, 'Valerie', 'Vallory'),
(11, 'Carter', 'Bradshaw'),
(12, 'Roger', 'Lee'),
(13, 'Mavis', 'Fowler'),
(14, 'Cristal', 'Oakley'),
(15, 'Quinn', 'Kennedy'),
(16, 'Elijah', 'Whinter'),
(17, 'Payton', 'Kirby'),
(18, 'Tyler', 'Donovan'),
(19, 'Doris', 'Knight'),
(20, 'Nathan', 'Saunders'),
(21, 'Luke', 'Oakley'),
(22, 'Rufus', 'Ulyatt'),
(23, 'Wade', 'Cadman'),
(24, 'Benny', 'Eaton'),
(25, 'Catherine', 'Powell'),
(26, 'Kurt', 'Radley');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klasa_2b`
--

CREATE TABLE `klasa_2b` (
  `ID` bigint(20) DEFAULT NULL,
  `Imie` varchar(500) DEFAULT NULL,
  `Nazwisko` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `klasa_2b`
--

INSERT INTO `klasa_2b` (`ID`, `Imie`, `Nazwisko`) VALUES
(1, 'Josephine', 'Lucas'),
(2, 'Chris', 'Long'),
(3, 'Estrella', 'Ellwood'),
(4, 'Valerie', 'Baldwin'),
(5, 'Luke', 'Heaton'),
(6, 'Ruth', 'Villiger'),
(7, 'Stephanie', 'Corbett'),
(8, 'Sarah', 'Norman'),
(9, 'Jazmin', 'Partridge'),
(10, 'Maddison', 'Eastwood'),
(11, 'Nathan', 'Hall'),
(12, 'Monica', 'Thompson'),
(13, 'Sasha', 'Redden'),
(14, 'Caitlyn', 'Whitmore'),
(15, 'Alison', 'Ellis'),
(16, 'Tony', 'Driscoll'),
(17, 'Ethan', 'Moore'),
(18, 'Alex', 'Savage'),
(19, 'Benny', 'Walker'),
(20, 'Chad', 'Walker'),
(21, 'Karen', 'Tait'),
(22, 'Rocco', 'Tyler'),
(23, 'Martin', 'Fall');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klasa_3a`
--

CREATE TABLE `klasa_3a` (
  `ID` bigint(20) DEFAULT NULL,
  `Imie` varchar(500) DEFAULT NULL,
  `Nazwisko` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `klasa_3a`
--

INSERT INTO `klasa_3a` (`ID`, `Imie`, `Nazwisko`) VALUES
(1, 'Janice', 'Becker'),
(2, 'Kirsten', 'Tindall'),
(3, 'Jacob', 'Squire'),
(4, 'Chester', 'Tait'),
(5, 'Dalia', 'Everett'),
(6, 'Percy', 'Hancock'),
(7, 'Barry', 'Flett'),
(8, 'Miriam', 'Weatcroft'),
(9, 'Enoch', 'Rixon'),
(10, 'Leah', 'Edley'),
(11, 'Christine', 'Thomson'),
(12, 'Nate', 'Varndell'),
(13, 'Josh', 'Edwards'),
(14, 'Anais', 'Burge'),
(15, 'Olivia', 'Mills'),
(16, 'Alan', 'Pratt'),
(17, 'Alice', 'Jackson'),
(18, 'Phillip', 'Snow'),
(19, 'Stephanie', 'Cork'),
(20, 'Gloria', 'Drummond'),
(21, 'Julian', 'Farrant'),
(22, 'Clarissa', 'Dale'),
(23, 'Susan', 'Simpson'),
(24, 'Rihanna', 'Taylor'),
(25, 'Francesca', 'Mould');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klasa_3b`
--

CREATE TABLE `klasa_3b` (
  `ID` bigint(20) DEFAULT NULL,
  `Imie` varchar(500) DEFAULT NULL,
  `Nazwisko` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `klasa_3b`
--

INSERT INTO `klasa_3b` (`ID`, `Imie`, `Nazwisko`) VALUES
(1, 'Leroy', 'Bloom'),
(2, 'Alba', 'Broomfield'),
(3, 'Chris', 'Calderwood'),
(4, 'Doug', 'Broomfield'),
(5, 'Luke', 'Parker'),
(6, 'Norah', 'Taylor'),
(7, 'Chad', 'Uddin'),
(8, 'Megan', 'Irwin'),
(9, 'Tom', 'Drummond'),
(10, 'Maya', 'Ranks'),
(11, 'Jacqueline', 'Robinson'),
(12, 'Bob', 'Shaw'),
(13, 'Dasha', 'Price'),
(14, 'Clint', 'Olivier'),
(15, 'Amelia', 'Whitehouse'),
(16, 'Chanelle', 'Whittle'),
(17, 'Fiona', 'Newton'),
(18, 'Matthew', 'Drummond'),
(19, 'Camden', 'Utterson'),
(20, 'Benny', 'Ellery'),
(21, 'Carrie', 'Wilkinson'),
(22, 'Jackeline', 'Shields'),
(23, 'Mark', 'Ballard'),
(24, 'Danielle', 'Harris');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klasa_4a`
--

CREATE TABLE `klasa_4a` (
  `ID` bigint(20) DEFAULT NULL,
  `Imie` varchar(500) DEFAULT NULL,
  `Nazwisko` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `klasa_4a`
--

INSERT INTO `klasa_4a` (`ID`, `Imie`, `Nazwisko`) VALUES
(1, 'Doug', 'Murray'),
(2, 'Chuck', 'Redden'),
(3, 'Johnathan', 'Ellis'),
(4, 'Agnes', 'Andersson'),
(5, 'Hadley', 'Ward'),
(6, 'Gabriel', 'Thomas'),
(7, 'Ron', 'Brown'),
(8, 'Matthew', 'Blackwall'),
(9, 'Candice', 'Grant'),
(10, 'Jolene', 'John'),
(11, 'Dani', 'Graves'),
(12, 'Leroy', 'Williams'),
(13, 'Bryon', 'Vernon'),
(14, 'Jayden', 'Pond'),
(15, 'Amelia', 'Bradley'),
(16, 'Carissa', 'Hudson'),
(17, 'Leanne', 'Oswald'),
(18, 'Nate', 'Corbett'),
(19, 'Karen', 'Donovan');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klasa_4b`
--

CREATE TABLE `klasa_4b` (
  `ID` bigint(20) DEFAULT NULL,
  `Imie` varchar(500) DEFAULT NULL,
  `Nazwisko` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `klasa_4b`
--

INSERT INTO `klasa_4b` (`ID`, `Imie`, `Nazwisko`) VALUES
(1, 'Ilona', 'Plumb'),
(2, 'Chadwick', 'Moore'),
(3, 'Barney', 'Doherty'),
(4, 'Rufus', 'Avery'),
(5, 'Macy', 'Bentley'),
(6, 'Kurt', 'Moore'),
(7, 'Rufus', 'Oswald'),
(8, 'Alice', 'Furnell'),
(9, 'Willow', 'Gonzales'),
(10, 'Selena', 'Potter'),
(11, 'Logan', 'Emmott'),
(12, 'Chuck', 'Pope'),
(13, 'Boris', 'Wilkinson'),
(14, 'Camila', 'Robertson'),
(15, 'Joseph', 'Lomax'),
(16, 'Liam', 'Collins'),
(17, 'Isla', 'Roman'),
(18, 'Valerie', 'Knight'),
(19, 'Michelle', 'Larsen'),
(20, 'Zara', 'Whitmore'),
(21, 'Fred', 'Clarkson');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `nauczyciele`
--

CREATE TABLE `nauczyciele` (
  `id_nauczyciela` int(11) NOT NULL,
  `Imię` text NOT NULL,
  `Nazwisko` text NOT NULL,
  `Przedmiot` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `nauczyciele`
--

INSERT INTO `nauczyciele` (`id_nauczyciela`, `Imię`, `Nazwisko`, `Przedmiot`) VALUES
(101, 'Andrzej', 'Nowak', 'Biologia'),
(102, 'Bartłomiej', 'Kowalski', 'Fizyka'),
(103, 'Cezary', 'Twardowski', 'Matematyka'),
(104, 'Daniel', 'Andrzejewicz', 'Język polski'),
(105, 'Elżbieta', 'Makłowicz', 'Język angielski'),
(106, 'Florian', 'Brzęczyszczykiewicz', 'Historia'),
(107, 'Grzegorz', 'Maj', 'Geografia'),
(108, 'Alicja', 'Wolna', 'Język niemiecki'),
(109, 'Małgorzata', 'Lipiec', 'Wiedza o społeczeństwie'),
(110, 'Franciszka', 'Skalska', 'Wychowanie fizyczne');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `terminarz_sprawdzianow`
--

CREATE TABLE `terminarz_sprawdzianow` (
  `data` date DEFAULT NULL,
  `przedmiot` text DEFAULT NULL,
  `temat` text DEFAULT NULL,
  `klasa` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `nauczyciele`
--
ALTER TABLE `nauczyciele`
  ADD PRIMARY KEY (`id_nauczyciela`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `nauczyciele`
--
ALTER TABLE `nauczyciele`
  MODIFY `id_nauczyciela` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=111;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
