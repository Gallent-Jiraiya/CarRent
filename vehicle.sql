-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 07, 2021 at 09:15 AM
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
('GR-8564', 'TOYOTA Corolla 141', 'C:\\Users\\thari\\source\\repos\\CarRent\\Images\\Vehicles\\Corolla 141 2008.png', '5000', 100, '50', 'Auto', 'Full', 'Petrol', 4, 2008, 4),
('KG-6075', 'TOYOTA  Premio', 'C:\\Users\\thari\\source\\repos\\CarRent\\Images\\Vehicles\\Premio 2008.png', '6500', 100, '65', 'Auto', 'Full', 'Petrol', 4, 2008, 3);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `vehicle`
--
ALTER TABLE `vehicle`
  ADD PRIMARY KEY (`regNum`),
  ADD KEY `regNum` (`regNum`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `vehicle`
--
ALTER TABLE `vehicle`
  ADD CONSTRAINT `vehicle_ibfk_1` FOREIGN KEY (`regNum`) REFERENCES `owner` (`vehicleRegNum`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
