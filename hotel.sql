-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 27, 2023 at 03:57 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotel`
--

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `id` int(10) NOT NULL,
  `number` varchar(20) NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`id`, `number`, `price`) VALUES
(1, 'single', 250),
(2, 'double', 100),
(3, 'family', 1000);

-- --------------------------------------------------------

--
-- Table structure for table `guest`
--

CREATE TABLE `guest` (
  `GuestId` varchar(20) NOT NULL,
  `First_name` varchar(30) NOT NULL,
  `Last_name` varchar(30) NOT NULL,
  `phone` varchar(30) NOT NULL,
  `city` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `guest`
--

INSERT INTO `guest` (`GuestId`, `First_name`, `Last_name`, `phone`, `city`) VALUES
('EE15', 'Ashraf', 'Essaadi', '0659585747', 'Marrakech'),
('EE17', 'Ahmed', 'sabir', '0232154842', 'Marrakech'),
('EE18', 'chaymae', 'lamrabet', '201515141', 'Marrakech');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `RecervId` int(25) NOT NULL,
  `GuestId` varchar(20) NOT NULL,
  `RoomNo` varchar(15) NOT NULL,
  `DateIn` date NOT NULL,
  `DateOut` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`RecervId`, `GuestId`, `RoomNo`, `DateIn`, `DateOut`) VALUES
(24, 'EE18', '3', '2023-12-27', '2023-12-29'),
(25, 'EE15', '1', '2023-12-27', '2023-12-30');

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `id` varchar(15) NOT NULL,
  `type` int(10) NOT NULL,
  `phone` varchar(25) NOT NULL,
  `Status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`id`, `type`, `phone`, `Status`) VALUES
('1', 1, '20202020', 'Busy'),
('2', 1, '0232323', 'Free'),
('3', 2, '5555555', 'Busy'),
('4', 2, '4545445', 'Free');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(10) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `guest`
--
ALTER TABLE `guest`
  ADD PRIMARY KEY (`GuestId`),
  ADD UNIQUE KEY `GuestId` (`GuestId`);

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`RecervId`),
  ADD UNIQUE KEY `GuestId` (`GuestId`),
  ADD UNIQUE KEY `RoomNo` (`RoomNo`),
  ADD KEY `GuestId_2` (`GuestId`),
  ADD KEY `RoomNo_2` (`RoomNo`),
  ADD KEY `GuestId_3` (`GuestId`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`),
  ADD KEY `id_2` (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `RecervId` int(25) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`GuestId`) REFERENCES `guest` (`GuestId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `reservation_ibfk_2` FOREIGN KEY (`RoomNo`) REFERENCES `room` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `reservation_ibfk_3` FOREIGN KEY (`GuestId`) REFERENCES `guest` (`GuestId`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
