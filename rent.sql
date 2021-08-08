-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 07, 2021 at 09:00 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `carrent`
--

-- --------------------------------------------------------

--
-- Table structure for table `rent`
--

CREATE TABLE `rent` (
  `rentID` int(100) NOT NULL,
  `customerNIC` varchar(12) NOT NULL,
  `vehicleRegNum` varchar(8) NOT NULL,
  `rentType` varchar(20) NOT NULL,
  `fromDate` date NOT NULL,
  `toDate` date NOT NULL,
  `driverNeed` varchar(20) NOT NULL,
  `driverNIC` varchar(12) DEFAULT NULL,
  `advancePayment` decimal(10,2) NOT NULL,
  `finalPayment` decimal(10,2) DEFAULT NULL,
  `startMilage` decimal(10,2) DEFAULT NULL,
  `endMilage` decimal(10,2) DEFAULT NULL,
  `userName` varchar(20) DEFAULT NULL,
  `timeStamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rent`
--

INSERT INTO `rent` (`rentID`, `customerNIC`, `vehicleRegNum`, `rentType`, `fromDate`, `toDate`, `driverNeed`, `driverNIC`, `advancePayment`, `finalPayment`, `startMilage`, `endMilage`, `userName`, `timeStamp`) VALUES
(1, '785421584V', 'GR-8564', 'Reserved', '2021-08-01', '2021-08-03', 'No', NULL, '5000.00', NULL, NULL, NULL, 'Admin', '2021-07-18 20:03:12'),
(4, '785421584V', 'KG-6075', 'Reserved', '2021-08-01', '2021-08-03', 'No', NULL, '5000.00', NULL, NULL, NULL, 'Admin', '2021-07-18 20:03:12'),
(5, '864521302V', 'KG-6075', 'Reserved', '2021-08-09', '2021-08-10', 'No', NULL, '5000.00', NULL, NULL, NULL, 'Admin', '2021-07-18 20:03:12'),
(6, '785421584V', 'GR-8564', 'Reserved', '2021-08-16', '2021-08-18', 'No', NULL, '5000.00', NULL, NULL, NULL, 'Admin', '2021-07-18 20:03:12'),
(7, '785421584V', 'KG-6075', 'Reserved', '2021-08-19', '2021-08-21', 'No', NULL, '5000.00', NULL, NULL, NULL, 'Admin', '2021-07-18 20:03:12'),
(8, '864521302V', 'KG-6075', 'Reserved', '2021-07-22', '2021-07-25', 'No', NULL, '5000.00', NULL, NULL, NULL, 'Admin', '2021-07-18 20:03:12'),
(9, '785421584V', 'GR-8564', 'OnRent', '2021-08-01', '2021-08-03', 'No', NULL, '5000.00', NULL, NULL, NULL, 'Admin', '2021-07-18 20:03:12'),
(10, '785421584V', 'KG-6075', 'OnRent', '2021-08-01', '2021-08-03', 'No', NULL, '5000.00', NULL, NULL, NULL, 'Admin', '2021-07-18 20:03:12'),
(11, '864521302V', 'KG-6075', 'OnRent', '2021-08-09', '2021-08-10', 'No', NULL, '5000.00', NULL, NULL, NULL, 'Admin', '2021-07-18 20:03:12'),
(12, '785421584V', 'GR-8564', 'OnRent', '2021-08-16', '2021-08-18', 'No', NULL, '5000.00', NULL, NULL, NULL, 'Admin', '2021-07-18 20:03:12'),
(13, '785421584V', 'KG-6075', 'OnRent', '2021-08-19', '2021-08-21', 'No', NULL, '5000.00', NULL, NULL, NULL, 'Admin', '2021-07-18 20:03:12'),
(14, '864521302V', 'KG-6075', 'OnRent', '2021-07-22', '2021-07-25', 'No', NULL, '5000.00', NULL, NULL, NULL, 'Admin', '2021-07-18 20:03:12');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `rent`
--
ALTER TABLE `rent`
  ADD PRIMARY KEY (`rentID`),
  ADD KEY `customerNIC` (`customerNIC`,`vehicleRegNum`),
  ADD KEY `vehicleRegNum` (`vehicleRegNum`),
  ADD KEY `driverNIC` (`driverNIC`),
  ADD KEY `userName` (`userName`) USING BTREE;

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `rent`
--
ALTER TABLE `rent`
  MODIFY `rentID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `rent`
--
ALTER TABLE `rent`
  ADD CONSTRAINT `rent_ibfk_1` FOREIGN KEY (`customerNIC`) REFERENCES `customer` (`NIC`),
  ADD CONSTRAINT `rent_ibfk_2` FOREIGN KEY (`vehicleRegNum`) REFERENCES `vehicle` (`regNum`),
  ADD CONSTRAINT `rent_ibfk_3` FOREIGN KEY (`userName`) REFERENCES `staff` (`userName`),
  ADD CONSTRAINT `rent_ibfk_4` FOREIGN KEY (`driverNIC`) REFERENCES `driver` (`NIC`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
