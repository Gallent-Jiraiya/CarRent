-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 07, 2021 at 11:25 AM
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
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `NIC` varchar(12) NOT NULL,
  `fName` varchar(20) NOT NULL,
  `lName` varchar(20) NOT NULL,
  `contactNo` varchar(10) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(50) DEFAULT NULL
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

CREATE TABLE `driver` (
  `NIC` varchar(12) NOT NULL,
  `fName` varchar(20) NOT NULL,
  `lName` varchar(20) NOT NULL,
  `d_Licence` varchar(9) NOT NULL,
  `chargePerDay` decimal(10,2) NOT NULL,
  `contactNo` varchar(10) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(50) DEFAULT NULL
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

CREATE TABLE `owner` (
  `NIC` varchar(12) NOT NULL,
  `vehicleRegNum` varchar(8) NOT NULL,
  `Fname` varchar(20) NOT NULL,
  `Lname` varchar(20) NOT NULL,
  `contactNo` varchar(10) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(50) DEFAULT NULL
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

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `NIC` varchar(12) NOT NULL,
  `userName` varchar(20) NOT NULL,
  `fName` varchar(20) NOT NULL,
  `lName` varchar(20) NOT NULL,
  `contactNo` varchar(10) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `password` varchar(20) NOT NULL,
  `type` varchar(10) NOT NULL
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

CREATE TABLE `vehicle` (
  `regNum` varchar(8) NOT NULL,
  `brand` varchar(20) NOT NULL,
  `picture` varchar(300) NOT NULL,
  `pricePerDay` decimal(10,0) NOT NULL,
  `freeMilage` int(10) NOT NULL,
  `pricePerExtraKM` decimal(10,0) NOT NULL,
  `transmissionType` varchar(10) NOT NULL,
  `airCondition` varchar(20) NOT NULL,
  `fuelType` varchar(10) NOT NULL,
  `Luggage` int(11) DEFAULT NULL,
  `modelYear` int(11) NOT NULL,
  `passengers` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vehicle`
--

INSERT INTO `vehicle` (`regNum`, `brand`, `picture`, `pricePerDay`, `freeMilage`, `pricePerExtraKM`, `transmissionType`, `airCondition`, `fuelType`, `Luggage`, `modelYear`, `passengers`) VALUES
('GR-8564', 'TOYOTA Corolla 141', 'Corolla 141 2008.png', '5000', 100, '50', 'Auto', 'Full', 'Petrol', 4, 2008, 4),
('KG-6075', 'TOYOTA  Premio', 'Premio 2008.png', '6500', 100, '65', 'Auto', 'Full', 'Petrol', 4, 2008, 3);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`NIC`);

--
-- Indexes for table `driver`
--
ALTER TABLE `driver`
  ADD PRIMARY KEY (`NIC`);

--
-- Indexes for table `owner`
--
ALTER TABLE `owner`
  ADD PRIMARY KEY (`vehicleRegNum`,`NIC`),
  ADD KEY `vehicleRegNum` (`vehicleRegNum`);

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
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`userName`);

--
-- Indexes for table `vehicle`
--
ALTER TABLE `vehicle`
  ADD PRIMARY KEY (`regNum`),
  ADD KEY `regNum` (`regNum`);

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

--
-- Constraints for table `vehicle`
--
ALTER TABLE `vehicle`
  ADD CONSTRAINT `vehicle_ibfk_1` FOREIGN KEY (`regNum`) REFERENCES `owner` (`vehicleRegNum`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
