-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jul 18, 2021 at 10:47 AM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `car_rent`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
CREATE TABLE IF NOT EXISTS `customer` (
  `NIC` varchar(12) NOT NULL,
  `fName` varchar(20) NOT NULL,
  `lName` varchar(20) NOT NULL,
  `contactNo` varchar(10) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`NIC`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`NIC`, `fName`, `lName`, `contactNo`, `address`, `email`) VALUES
('785421584V', 'Lakshitha', 'Sadaruwan', '0714587652', 'No45, Main Road, Gampola', 'laka78@gmail.com'),
('864521302V', 'Saman', 'Perera', '0715484585', 'NO7,Perawatta rd,Pasyala', 'saman86@gamil.com');

-- --------------------------------------------------------

--
-- Table structure for table `driver`
--

DROP TABLE IF EXISTS `driver`;
CREATE TABLE IF NOT EXISTS `driver` (
  `NIC` varchar(12) NOT NULL,
  `fName` varchar(20) NOT NULL,
  `lName` varchar(20) NOT NULL,
  `d_Licence` varchar(9) NOT NULL,
  `chargePerDay` decimal(10,2) NOT NULL,
  `contactNo` varchar(10) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`NIC`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `driver`
--

INSERT INTO `driver` (`NIC`, `fName`, `lName`, `d_Licence`, `chargePerDay`, `contactNo`, `address`, `email`) VALUES
('854875417V', 'Pasan', 'Jeewantha', 'B8654721', '0.00', '0721548756', 'NO8,Temple Rd,Gampaha', 'pasan85@gamil.com'),
('960445871V', 'Lahiru', 'Priyadarshana', 'G1254875', '0.00', '0751245849', 'No65, Main Road, Ragama', 'lahiru78@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `owner`
--

DROP TABLE IF EXISTS `owner`;
CREATE TABLE IF NOT EXISTS `owner` (
  `NIC` varchar(12) NOT NULL,
  `vehicleRegNum` varchar(8) NOT NULL,
  `Fname` varchar(20) NOT NULL,
  `Lname` varchar(20) NOT NULL,
  `contactNo` varchar(10) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`vehicleRegNum`,`NIC`),
  KEY `vehicleRegNum` (`vehicleRegNum`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `owner`
--

INSERT INTO `owner` (`NIC`, `vehicleRegNum`, `Fname`, `Lname`, `contactNo`, `address`, `email`) VALUES
('87548742V', 'GR-8564', 'Kamal', 'Rathnayaka', '0786584874', 'No75, Main Road, Ragama', 'krath@gmail.com'),
('854658748V', 'KG-6075', 'Sumith', 'Chandrasiri', '0715485235', 'NO 07,2nd Lane,Gampaha', 'sumithsam850@gamil.com');

-- --------------------------------------------------------

--
-- Table structure for table `rent`
--

DROP TABLE IF EXISTS `rent`;
CREATE TABLE IF NOT EXISTS `rent` (
  `rentID` varchar(100) NOT NULL,
  `customerNIC` varchar(12) NOT NULL,
  `vehicleRegNum` varchar(8) NOT NULL,
  `rentType` varchar(20) NOT NULL,
  `fromDate` date NOT NULL,
  `toDate` date NOT NULL,
  `driverNeed` varchar(20) NOT NULL,
  `driverNIC` varchar(12) DEFAULT NULL,
  `advancePayment` decimal(10,2) NOT NULL,
  `finalPayment` decimal(10,2) DEFAULT NULL,
  `startMilage` decimal(10,2) NOT NULL,
  `endMilage` decimal(10,2) DEFAULT NULL,
  `userName` varchar(20) NOT NULL,
  `timeStamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`rentID`),
  UNIQUE KEY `userName` (`userName`),
  KEY `customerNIC` (`customerNIC`,`vehicleRegNum`),
  KEY `vehicleRegNum` (`vehicleRegNum`),
  KEY `driverNIC` (`driverNIC`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
CREATE TABLE IF NOT EXISTS `staff` (
  `NIC` varchar(12) NOT NULL,
  `userName` varchar(20) NOT NULL,
  `fName` varchar(20) NOT NULL,
  `lName` varchar(20) NOT NULL,
  `contactNo` varchar(10) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `password` varchar(20) NOT NULL,
  `type` varchar(10) NOT NULL,
  PRIMARY KEY (`userName`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`NIC`, `userName`, `fName`, `lName`, `contactNo`, `address`, `email`, `password`, `type`) VALUES
('850957840V', 'Admin', 'Sumith', 'Samarasinghe', '0714584513', 'No12, Kovil Road, Mahara', 'sumithsam850@gamil.com', 'Abcd1234', 'Admin'),
('990448752V', 'Mad123', 'Maduranga', 'Perera', '0726923548', 'NO7,Perawatta Rd,Gampaha', 'mad99@gamil.com', '123Abc', 'Cashier');

-- --------------------------------------------------------

--
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
CREATE TABLE IF NOT EXISTS `vehicle` (
  `regNum` varchar(8) NOT NULL,
  `brand` varchar(20) NOT NULL,
  `picture` varchar(300) NOT NULL,
  `pricePerDay` decimal(10,0) NOT NULL,
  `freeMilage` int(10) NOT NULL,
  `pricePerExtraKM` decimal(10,0) NOT NULL,
  `transmissionType` varchar(10) NOT NULL,
  `rentStatus` varchar(20) NOT NULL,
  `airCondition` varchar(20) NOT NULL,
  `fuelType` varchar(10) NOT NULL,
  PRIMARY KEY (`regNum`),
  KEY `regNum` (`regNum`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vehicle`
--

INSERT INTO `vehicle` (`regNum`, `brand`, `picture`, `pricePerDay`, `freeMilage`, `pricePerExtraKM`, `transmissionType`, `rentStatus`, `airCondition`, `fuelType`) VALUES
('GR-8564', 'TOYOTA Corolla 141', 'D:\\Uni Studies\\From Cal\\2nd Year\\2nd Year 1st Sem\\Interactive Application Development\\Carsons\\Imgs\\corolla141.jpg', '5000', 100, '50', 'Auto', 'free', 'Full', 'Petrol'),
('KG-6075', 'TOYOTA  Premio', 'D:\\Uni Studies\\From Cal\\2nd Year\\2nd Year 1st Sem\\Interactive Application Development\\Carsons\\Imgs\\premio260.jpg', '6500', 100, '65', 'Auto', 'free', 'Full', 'Petrol');

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

--
-- Constraints for table `vehicle`
--
ALTER TABLE `vehicle`
  ADD CONSTRAINT `vehicle_ibfk_1` FOREIGN KEY (`regNum`) REFERENCES `owner` (`vehicleRegNum`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
