-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 16, 2025 at 07:54 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `quizems`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_lecture`
--

CREATE TABLE `tbl_lecture` (
  `Lecture_ID` varchar(100) NOT NULL,
  `Lecture_Name` varchar(150) NOT NULL,
  `Lecture_MobNum` varchar(100) NOT NULL,
  `LecPassword` varchar(100) NOT NULL,
  `Department` enum('HNDIT','HNDE','HNDA','HNDTHM') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_lecture`
--

INSERT INTO `tbl_lecture` (`Lecture_ID`, `Lecture_Name`, `Lecture_MobNum`, `LecPassword`, `Department`) VALUES
('HNDIT001', 'Lect_IT', '+94751234567', 'HNDIT', 'HNDIT');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_marks`
--

CREATE TABLE `tbl_marks` (
  `Stu_RegiNum` varchar(100) NOT NULL,
  `Mark_Set1` varchar(50) NOT NULL DEFAULT '0',
  `Mark_Set2` varchar(50) NOT NULL DEFAULT '0',
  `Mark_Set3` varchar(50) NOT NULL DEFAULT '0',
  `Mark_Set4` varchar(50) NOT NULL DEFAULT '0',
  `Mark_Set5` varchar(50) NOT NULL DEFAULT '0',
  `Mark_Set6` varchar(50) NOT NULL DEFAULT '0',
  `Date_Mrk1` varchar(50) DEFAULT NULL,
  `Date_Mrk2` varchar(50) DEFAULT NULL,
  `Date_Mrk3` varchar(50) DEFAULT NULL,
  `Date_Mrk4` varchar(50) DEFAULT NULL,
  `Date_Mrk5` varchar(50) DEFAULT NULL,
  `Date_Mrk6` varchar(50) DEFAULT NULL,
  `Result_mrk1` varchar(10) DEFAULT NULL,
  `Result_mrk2` varchar(10) DEFAULT NULL,
  `Result_mrk3` varchar(10) DEFAULT NULL,
  `Result_mrk4` varchar(10) DEFAULT NULL,
  `Result_mrk5` varchar(10) DEFAULT NULL,
  `Result_mrk6` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_quiz`
--

CREATE TABLE `tbl_quiz` (
  `Que_ID` varchar(100) NOT NULL,
  `Que_Set` varchar(100) NOT NULL,
  `Que_Num` int(50) NOT NULL,
  `Department` varchar(100) DEFAULT NULL,
  `Que_Question` varchar(1100) NOT NULL,
  `Que_OptA` varchar(100) NOT NULL,
  `Que_OptB` varchar(100) NOT NULL,
  `Que_OptC` varchar(100) NOT NULL,
  `Que_OptD` varchar(100) NOT NULL,
  `Que_Ans` varchar(250) NOT NULL,
  `Lecture_ID` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_quiz`
--

INSERT INTO `tbl_quiz` (`Que_ID`, `Que_Set`, `Que_Num`, `Department`, `Que_Question`, `Que_OptA`, `Que_OptB`, `Que_OptC`, `Que_OptD`, `Que_Ans`, `Lecture_ID`) VALUES
('HNDA011', '01', 1, 'HNDA', 'Is this Account', 'Yes', 'Not Sure', 'No', 'Propabaly Yes ', 'Propabaly Yes ', ''),
('HNDE011', '01', 1, 'HNDE', 'English Alphabates', 'a', 'e', 'o', 'a,e,i,o,u', 'a,e,i,o,u', ''),
('HNDIT011', '01', 1, 'HNDIT', 'What is OS ?', 'Operating System', 'Linux', 'Window', 'Management System', 'Operating System', ''),
('HNDIT012', '01', 2, 'HNDIT', 'What is Data', 'Inforation Collection', 'Collection of Raw facts', 'Collection of Process data', 'NiC number', 'Collection of Raw facts', ''),
('HNDIT013', '01', 3, 'HNDIT', 'The relational database model introduced a progrmming-language independent Structured Query Language (SQL).', 'True', 'False', 'Can be true or false', 'Can not say', 'True', ''),
('HNDIT021', '02', 1, 'HNDIT', 'What is informaton', 'Processed Data ', 'unorderd Datas collection', 'Set of rules', 'Rules collection', 'Processed Data ', ''),
('HNDIT022', '02', 2, NULL, 'Which one is the first search engine in internet?', 'Google', 'Archie', 'Altavista', 'WAIS', 'Archie', ''),
('HNDIT023', '02', 3, NULL, 'Number of bit used by the IPv6 address?', ' 32 bit', '64 bit', '128 bit', ' 256 bit', '128 bit', ''),
('HNDIT031', '03', 1, NULL, 'Accuracy, purpose, relevance, validity and timeliness are the features of?', 'Data', 'Information', 'Knowledge', 'All of the above', 'Information', ''),
('HNDIT032', '03', 2, NULL, 'Database Management Systems (DMS) emerged in the 1960s to address the problem of storing and retrieving large amounts of data accurately and quickly.', 'Yes', 'No', 'Can be yes or no', 'Can not say', 'Yes', ''),
('HNDIT033', '03', 3, NULL, 'Earlier name of Java Programming language was -', 'Eclipse', 'OAK', 'Netbean', 'D', 'OAK', ''),
('HNDIT041', '04', 1, NULL, 'Which of the following personality is called as father of Java Programming language', ' James Gosling', 'Larry Page', 'Bjarne Stroustrup', 'None of these', ' James Gosling', ''),
('HNDIT042', '04', 2, NULL, 'Which kind of language java.', 'Object Oriented', ' Procedural', ' Event Driven', 'None of these', 'Object Oriented', ''),
('HNDIT043', '04', 3, NULL, 'Which of the following are correct advantage of java?', 'Java is Simple', 'Java is Secure', ' Java is Portable', 'All of the above', 'All of the above', ''),
('HNDIT051', '05', 1, NULL, 'C++ was originally developed by', 'Sir Richard Hadlee', 'Clocksin and Mellish', 'Donald E. Knuth', ' Bjame Stroustrup', ' Bjame Stroustrup', ''),
('HNDIT052', '05', 2, NULL, 'Which of the following provides a reuse mechanism?', 'Abstraction', 'Inheritance', 'Dynamic binding', 'Encapsulation', 'Inheritance', ''),
('HNDIT053', '05', 3, 'HNDIT', 'In a class, encapsulating an object of another class is called', 'Encapsulation', ' Inheritance', 'Composition', 'None of the above', 'Composition', ''),
('HNDIT061', '06', 1, NULL, 'What is C language?', ' C language is a structure/procedure oriented', ' C language is a middle level programming language', ' C language was invented for implementing UNIX operating system', 'All of the above', 'All of the above', ''),
('HNDIT062', '06', 2, NULL, 'Many features of C were derived from which language ?', 'PASCAL', 'B', 'BASIC', ' FORTRAN', 'B', ''),
('HNDIT063', '06', 3, NULL, ' C was initially used for', 'General purpose', 'System development work', 'Data processing', 'None of these', 'System development work', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_student`
--

CREATE TABLE `tbl_student` (
  `Stu_RegNum` varchar(100) NOT NULL,
  `Stu_FullName` varchar(150) NOT NULL,
  `Stu_MobNum` varchar(100) DEFAULT NULL,
  `Stu_Gender` enum('Male','Female') NOT NULL,
  `Stu_NIC` varchar(100) NOT NULL,
  `Stu_Pass` varchar(100) NOT NULL,
  `Stu_Gmail` varchar(150) DEFAULT NULL,
  `Department` enum('HNDIT','HNDE','HNDA','HNDTHM') DEFAULT NULL,
  `Que_ID` varchar(100) NOT NULL,
  `Lecture_ID` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_student`
--

INSERT INTO `tbl_student` (`Stu_RegNum`, `Stu_FullName`, `Stu_MobNum`, `Stu_Gender`, `Stu_NIC`, `Stu_Pass`, `Stu_Gmail`, `Department`, `Que_ID`, `Lecture_ID`) VALUES
('ATI/IT/2021/F/005', 'Admin Rishe', '+94767123341', 'Male', '19993210452', 'HNDIT', 'adminR@gmail.com', 'HNDIT', '', 'HNDIT001');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_lecture`
--
ALTER TABLE `tbl_lecture`
  ADD PRIMARY KEY (`Lecture_ID`);

--
-- Indexes for table `tbl_marks`
--
ALTER TABLE `tbl_marks`
  ADD PRIMARY KEY (`Stu_RegiNum`);

--
-- Indexes for table `tbl_quiz`
--
ALTER TABLE `tbl_quiz`
  ADD PRIMARY KEY (`Que_ID`);

--
-- Indexes for table `tbl_student`
--
ALTER TABLE `tbl_student`
  ADD PRIMARY KEY (`Stu_RegNum`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
