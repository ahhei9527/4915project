-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 2026-05-29 02:57:04
-- 伺服器版本： 10.4.32-MariaDB
-- PHP 版本： 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `4915`
--
CREATE DATABASE IF NOT EXISTS `4915` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `4915`;

-- --------------------------------------------------------

--
-- 資料表結構 `audit_log`
--

DROP TABLE IF EXISTS `audit_log`;
CREATE TABLE `audit_log` (
  `AuditLogId` bigint(20) NOT NULL,
  `TableName` varchar(100) NOT NULL,
  `RecordId` varchar(50) NOT NULL,
  `Action` varchar(20) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `Username` varchar(100) DEFAULT NULL,
  `ChangedDate` datetime DEFAULT current_timestamp(),
  `OldValues` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`OldValues`)),
  `NewValues` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`NewValues`)),
  `Description` varchar(500) DEFAULT NULL,
  `IpAddress` varchar(45) DEFAULT NULL,
  `MachineName` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `audit_log`
--

INSERT INTO `audit_log` (`AuditLogId`, `TableName`, `RecordId`, `Action`, `UserID`, `Username`, `ChangedDate`, `OldValues`, `NewValues`, `Description`, `IpAddress`, `MachineName`) VALUES
(1, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 20:23:35', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(2, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 20:42:06', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(3, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 20:44:52', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(4, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 20:45:51', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(5, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 20:47:03', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(6, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 20:48:47', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(7, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 20:51:32', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(8, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 20:52:28', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(9, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 20:55:08', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(10, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 20:56:56', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(11, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 20:59:31', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(12, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:02:25', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(13, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:04:50', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(14, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:06:00', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(15, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:07:48', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(16, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:08:23', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(17, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:11:00', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(18, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:11:28', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(19, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:13:05', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(20, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:16:05', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(21, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:19:00', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(22, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:20:10', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(23, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:21:36', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(24, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:22:33', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(25, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:23:45', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(26, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:24:57', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(27, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:27:50', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(28, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:30:40', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(29, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:33:36', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(30, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:34:04', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(31, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:36:49', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(32, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:42:52', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(33, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 21:59:14', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(34, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 22:07:48', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(35, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 22:15:27', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(36, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 22:18:57', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(37, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 22:19:59', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(38, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 22:24:48', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(39, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 22:28:19', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(40, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 22:29:13', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(41, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 22:29:40', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(42, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 22:30:49', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC');

-- --------------------------------------------------------

--
-- 資料表結構 `complaint`
--

DROP TABLE IF EXISTS `complaint`;
CREATE TABLE `complaint` (
  `ComplaintID` varchar(10) NOT NULL,
  `CustomerID` int(100) NOT NULL,
  `OrderID` varchar(10) NOT NULL,
  `SerialNumber` varchar(10) NOT NULL,
  `UserID` int(100) NOT NULL,
  `IssueDate` date NOT NULL,
  `Description` varchar(255) NOT NULL,
  `TYPE` varchar(20) NOT NULL,
  `Resolution` varchar(255) DEFAULT NULL,
  `ResolutionDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `complaint`
--

INSERT INTO `complaint` (`ComplaintID`, `CustomerID`, `OrderID`, `SerialNumber`, `UserID`, `IssueDate`, `Description`, `TYPE`, `Resolution`, `ResolutionDate`) VALUES
('COMP001', 2, 'ORD000002', 'SN00000005', 101, '2025-05-12', 'Minor scratch on leg', 'Quality', 'Repaired on site', '2025-05-15');

-- --------------------------------------------------------

--
-- 資料表結構 `customdesign`
--

DROP TABLE IF EXISTS `customdesign`;
CREATE TABLE `customdesign` (
  `DesignID` varchar(10) NOT NULL,
  `CustomerID` int(100) NOT NULL,
  `UserID` int(100) NOT NULL,
  `SketchDetail` varchar(255) NOT NULL,
  `RequirementsText` varchar(255) NOT NULL,
  `ApprovalDate` date DEFAULT NULL,
  `Status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `customdesign`
--

INSERT INTO `customdesign` (`DesignID`, `CustomerID`, `UserID`, `SketchDetail`, `RequirementsText`, `ApprovalDate`, `Status`) VALUES
('DES001', 4, 102, 'Modern minimalist style', 'Custom dimensions and walnut finish', '2025-04-20', 'Approved');

-- --------------------------------------------------------

--
-- 資料表結構 `customdesign_orderitem`
--

DROP TABLE IF EXISTS `customdesign_orderitem`;
CREATE TABLE `customdesign_orderitem` (
  `DesignID` varchar(10) NOT NULL,
  `OrderItemID` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `customdesign_orderitem`
--

INSERT INTO `customdesign_orderitem` (`DesignID`, `OrderItemID`) VALUES
('DES001', 'OI000003');

-- --------------------------------------------------------

--
-- 資料表結構 `customer`
--

DROP TABLE IF EXISTS `customer`;
CREATE TABLE `customer` (
  `CustomerID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Company` varchar(50) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `customer`
--

INSERT INTO `customer` (`CustomerID`, `Name`, `Company`, `Email`, `Phone`) VALUES
(1, 'John Chan', 'ABC Trading Ltd', 'john.chan@email.com', '852-98765432'),
(2, 'Mary Wong', NULL, 'mary.wong@gmail.com', '852-91234567'),
(3, 'David Lee', 'Lee Manufacturing', 'david@leeco.hk', '852-23456789'),
(4, 'Sarah Lam', 'Premium Furnishings', 'sarah.lam@pfurnish.com', '852-87654321');

-- --------------------------------------------------------

--
-- 資料表結構 `deliveryconfirmation`
--

DROP TABLE IF EXISTS `deliveryconfirmation`;
CREATE TABLE `deliveryconfirmation` (
  `ConfirmationID` varchar(10) NOT NULL,
  `ShipmentID` varchar(10) NOT NULL,
  `ReceivedDate` date NOT NULL,
  `ReceiverName` varchar(50) NOT NULL,
  `ItemCondition` varchar(50) NOT NULL,
  `Notes` varchar(50) DEFAULT NULL,
  `CustomerConfirmation` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `deliveryconfirmation`
--

INSERT INTO `deliveryconfirmation` (`ConfirmationID`, `ShipmentID`, `ReceivedDate`, `ReceiverName`, `ItemCondition`, `Notes`, `CustomerConfirmation`) VALUES
('CONF001', 'SHIP001', '2025-04-08', 'John Chan', 'Good', 'All items perfect', 'YES');

-- --------------------------------------------------------

--
-- 資料表結構 `deliveryitem`
--

DROP TABLE IF EXISTS `deliveryitem`;
CREATE TABLE `deliveryitem` (
  `DeliveryItemID` varchar(10) NOT NULL,
  `ShipmentID` varchar(10) NOT NULL,
  `SerialNumber` varchar(10) NOT NULL,
  `Quantity` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `deliveryitem`
--

INSERT INTO `deliveryitem` (`DeliveryItemID`, `ShipmentID`, `SerialNumber`, `Quantity`) VALUES
('DI001', 'SHIP001', 'SN00000003', 1),
('DI002', 'SHIP002', 'SN00000005', 3);

-- --------------------------------------------------------

--
-- 資料表結構 `employee_salesorder`
--

DROP TABLE IF EXISTS `employee_salesorder`;
CREATE TABLE `employee_salesorder` (
  `UserID` int(100) NOT NULL,
  `OrderID` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `employee_salesorder`
--

INSERT INTO `employee_salesorder` (`UserID`, `OrderID`) VALUES
(104, 'ORD000001'),
(104, 'ORD000002'),
(101, 'ORD000003');

-- --------------------------------------------------------

--
-- 資料表結構 `inventory`
--

DROP TABLE IF EXISTS `inventory`;
CREATE TABLE `inventory` (
  `InventoryID` varchar(10) NOT NULL,
  `MaterialID` varchar(10) NOT NULL,
  `ProductID` varchar(10) NOT NULL,
  `SerialNumber` varchar(10) NOT NULL,
  `WarehouseLocation` varchar(255) NOT NULL,
  `QuantityOnHand` int(10) DEFAULT NULL,
  `LastUpdated` date NOT NULL,
  `ReorderLevel` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `inventory`
--

INSERT INTO `inventory` (`InventoryID`, `MaterialID`, `ProductID`, `SerialNumber`, `WarehouseLocation`, `QuantityOnHand`, `LastUpdated`, `ReorderLevel`) VALUES
('INV001', 'MAT001', 'PROD001', 'SN00000001', 'WH-A-12-03', 45, '2025-05-01', '50'),
('INV002', 'MAT002', 'PROD002', 'SN00000003', 'WH-B-05-01', 120, '2025-05-10', '200'),
('INV003', 'MAT003', 'PROD003', 'SN00000004', 'WH-C-08-02', 30, '2025-05-15', '50'),
('INV004', 'MAT001', 'PROD001', 'SN00000002', 'WH-A-12-04', 25, '2025-05-16', '50');

-- --------------------------------------------------------

--
-- 資料表結構 `materialrequest`
--

DROP TABLE IF EXISTS `materialrequest`;
CREATE TABLE `materialrequest` (
  `RequestID` varchar(10) NOT NULL,
  `UserID` int(100) NOT NULL,
  `BatchID` varchar(10) NOT NULL,
  `RequestDate` date NOT NULL,
  `RequestByDate` date NOT NULL,
  `Urgency` varchar(10) NOT NULL,
  `Status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `materialrequest`
--

INSERT INTO `materialrequest` (`RequestID`, `UserID`, `BatchID`, `RequestDate`, `RequestByDate`, `Urgency`, `Status`) VALUES
('REQ001', 103, 'BATCH003', '2025-05-01', '2025-05-10', 'High', 'Approved');

-- --------------------------------------------------------

--
-- 資料表結構 `materialrequestitem`
--

DROP TABLE IF EXISTS `materialrequestitem`;
CREATE TABLE `materialrequestitem` (
  `RequestItemID` varchar(10) NOT NULL,
  `RequestID` varchar(10) NOT NULL,
  `MaterialID` varchar(10) NOT NULL,
  `QuantityRequested` int(10) NOT NULL,
  `QuantityApproved` int(10) DEFAULT NULL,
  `QuantityIssued` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `materialrequestitem`
--

INSERT INTO `materialrequestitem` (`RequestItemID`, `RequestID`, `MaterialID`, `QuantityRequested`, `QuantityApproved`, `QuantityIssued`) VALUES
('RITEM001', 'REQ001', 'MAT001', 80, 80, '75');

-- --------------------------------------------------------

--
-- 資料表結構 `orderitem`
--

DROP TABLE IF EXISTS `orderitem`;
CREATE TABLE `orderitem` (
  `OrderItemID` varchar(10) NOT NULL,
  `Quantity` int(10) NOT NULL,
  `UnitPrice` decimal(12,2) NOT NULL,
  `Subtotal` decimal(12,2) DEFAULT NULL,
  `CustomNotes` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `orderitem`
--

INSERT INTO `orderitem` (`OrderItemID`, `Quantity`, `UnitPrice`, `Subtotal`, `CustomNotes`) VALUES
('OI000001', 1, 2850.00, 2850.00, NULL),
('OI000002', 1, 4250.00, 4250.00, NULL),
('OI000003', 3, 1250.00, 3750.00, 'Black color');

-- --------------------------------------------------------

--
-- 資料表結構 `orderitem_product`
--

DROP TABLE IF EXISTS `orderitem_product`;
CREATE TABLE `orderitem_product` (
  `ProductID` varchar(10) NOT NULL,
  `OrderItemID` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `orderitem_product`
--

INSERT INTO `orderitem_product` (`ProductID`, `OrderItemID`) VALUES
('PROD001', 'OI000001'),
('PROD002', 'OI000002'),
('PROD003', 'OI000003');

-- --------------------------------------------------------

--
-- 資料表結構 `product`
--

DROP TABLE IF EXISTS `product`;
CREATE TABLE `product` (
  `ProductID` varchar(10) NOT NULL,
  `UserID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `Category` varchar(100) NOT NULL,
  `UnitPrice` decimal(12,2) NOT NULL,
  `Type` varchar(10) NOT NULL,
  `Dimensions` varchar(100) DEFAULT NULL,
  `MaterialSummary` varchar(100) NOT NULL,
  `ApprovedDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `product`
--

INSERT INTO `product` (`ProductID`, `UserID`, `Name`, `Description`, `Category`, `UnitPrice`, `Type`, `Dimensions`, `MaterialSummary`, `ApprovedDate`) VALUES
('PROD001', 102, 'Executive Desk', 'Large oak executive desk', 'Furniture', 2850.00, 'Standard', '180x90x75cm', 'Oak + Steel', '2025-01-15'),
('PROD002', 102, 'Meeting Table', '10-seater conference table', 'Furniture', 4250.00, 'Standard', '300x120x75cm', 'Oak + Glass', '2025-02-10'),
('PROD003', 102, 'Office Chair Premium', 'Ergonomic leather chair', 'Furniture', 1250.00, 'Standard', '60x60x110cm', 'Fabric + Foam', '2025-01-20'),
('PROD004', 102, 'Custom Bookshelf', 'Modular bookshelf', 'Furniture', 980.00, 'Custom', '200x40x220cm', 'Oak', '2025-03-05');

-- --------------------------------------------------------

--
-- 資料表結構 `productinstance`
--

DROP TABLE IF EXISTS `productinstance`;
CREATE TABLE `productinstance` (
  `SerialNumber` varchar(10) NOT NULL,
  `ProductID` varchar(10) NOT NULL,
  `BatchID` varchar(10) NOT NULL,
  `ProductionDate` date NOT NULL,
  `CurrentStatus` varchar(20) NOT NULL,
  `WarrantyEndDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `productinstance`
--

INSERT INTO `productinstance` (`SerialNumber`, `ProductID`, `BatchID`, `ProductionDate`, `CurrentStatus`, `WarrantyEndDate`) VALUES
('SN00000001', 'PROD001', 'BATCH001', '2025-03-10', 'In Stock', '2028-03-10'),
('SN00000002', 'PROD001', 'BATCH001', '2025-03-10', 'In Stock', '2028-03-10'),
('SN00000003', 'PROD002', 'BATCH001', '2025-03-12', 'Delivered', '2028-03-12'),
('SN00000004', 'PROD003', 'BATCH002', '2025-04-10', 'In Stock', '2028-04-10'),
('SN00000005', 'PROD003', 'BATCH002', '2025-04-10', 'Delivered', '2028-04-10');

-- --------------------------------------------------------

--
-- 資料表結構 `productionbatch`
--

DROP TABLE IF EXISTS `productionbatch`;
CREATE TABLE `productionbatch` (
  `BatchID` varchar(10) NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `Status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `productionbatch`
--

INSERT INTO `productionbatch` (`BatchID`, `StartDate`, `EndDate`, `Status`) VALUES
('BATCH001', '2025-03-01', '2025-03-15', 'Completed'),
('BATCH002', '2025-04-01', '2025-04-20', 'Completed'),
('BATCH003', '2025-05-01', '2025-05-18', 'In Progress');

-- --------------------------------------------------------

--
-- 資料表結構 `quotation`
--

DROP TABLE IF EXISTS `quotation`;
CREATE TABLE `quotation` (
  `QuotationID` varchar(10) NOT NULL,
  `CustomerID` int(100) NOT NULL,
  `EmployeeID` int(100) NOT NULL,
  `QuotationDate` date NOT NULL,
  `TotalAmount` decimal(12,2) NOT NULL,
  `EstimatedDeliveryDate` date NOT NULL,
  `PaymentTerms` varchar(20) DEFAULT NULL,
  `Status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `quotation`
--

INSERT INTO `quotation` (`QuotationID`, `CustomerID`, `EmployeeID`, `QuotationDate`, `TotalAmount`, `EstimatedDeliveryDate`, `PaymentTerms`, `Status`) VALUES
('QUO00001', 1, 104, '2025-03-15', 7125.00, '2025-04-10', '30 Days', 'Accepted'),
('QUO00002', 2, 104, '2025-04-01', 3750.00, '2025-05-20', 'Net 15', 'Accepted');

-- --------------------------------------------------------

--
-- 資料表結構 `quotation_salesorder`
--

DROP TABLE IF EXISTS `quotation_salesorder`;
CREATE TABLE `quotation_salesorder` (
  `QuotationID` varchar(10) NOT NULL,
  `OrderID` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `quotation_salesorder`
--

INSERT INTO `quotation_salesorder` (`QuotationID`, `OrderID`) VALUES
('QUO00001', 'ORD000001'),
('QUO00002', 'ORD000002');

-- --------------------------------------------------------

--
-- 資料表結構 `rawmaterial`
--

DROP TABLE IF EXISTS `rawmaterial`;
CREATE TABLE `rawmaterial` (
  `MaterialID` varchar(10) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Type` varchar(100) NOT NULL,
  `Unit` varchar(10) NOT NULL,
  `UnitCost` int(10) NOT NULL,
  `ReorderLevel` int(10) DEFAULT NULL,
  `PreferredSupplier` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `rawmaterial`
--

INSERT INTO `rawmaterial` (`MaterialID`, `Name`, `Type`, `Unit`, `UnitCost`, `ReorderLevel`, `PreferredSupplier`) VALUES
('MAT001', 'Oak Wood Panel', 'Wood', 'sqm', 450, 50, 'Timber Supplies HK'),
('MAT002', 'Steel Frame', 'Metal', 'kg', 120, 200, 'MetalWorks Ltd'),
('MAT003', 'Fabric Cover', 'Textile', 'meter', 85, 100, 'Textile Depot'),
('MAT004', 'Glass Panel', 'Glass', 'sqm', 320, 30, 'Crystal Glass Co'),
('MAT005', 'Foam Padding', 'Foam', 'kg', 65, 150, 'Comfort Materials');

-- --------------------------------------------------------

--
-- 資料表結構 `salesorder`
--

DROP TABLE IF EXISTS `salesorder`;
CREATE TABLE `salesorder` (
  `OrderID` varchar(10) NOT NULL,
  `CustomerID` int(100) NOT NULL,
  `OrderDate` date NOT NULL,
  `TotalAmount` decimal(12,2) NOT NULL,
  `RequestDeliveryDate` date NOT NULL,
  `Status` varchar(20) NOT NULL,
  `EstimatedDeliveryDate` date NOT NULL,
  `ActualDeliveryDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `salesorder`
--

INSERT INTO `salesorder` (`OrderID`, `CustomerID`, `OrderDate`, `TotalAmount`, `RequestDeliveryDate`, `Status`, `EstimatedDeliveryDate`, `ActualDeliveryDate`) VALUES
('ORD000001', 1, '2025-03-20', 7125.00, '2025-04-15', 'Delivered', '2025-04-10', '2025-04-08'),
('ORD000002', 2, '2025-04-05', 3750.00, '2025-05-10', 'Processing', '2025-05-20', NULL),
('ORD000003', 3, '2025-05-01', 1250.00, '2025-05-25', 'Confirmed', '2025-05-22', NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `shipment`
--

DROP TABLE IF EXISTS `shipment`;
CREATE TABLE `shipment` (
  `ShipmentID` varchar(10) NOT NULL,
  `OrderID` varchar(10) NOT NULL,
  `UserID` int(100) NOT NULL,
  `DeliveryMethod` varchar(50) NOT NULL,
  `TrackingInfo` varchar(100) DEFAULT NULL,
  `STATUS` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `shipment`
--

INSERT INTO `shipment` (`ShipmentID`, `OrderID`, `UserID`, `DeliveryMethod`, `TrackingInfo`, `STATUS`) VALUES
('SHIP001', 'ORD000001', 105, 'Express Delivery', 'TRK987654321', 'Delivered'),
('SHIP002', 'ORD000002', 105, 'Standard', 'TRK112233445', 'In Transit');

-- --------------------------------------------------------

--
-- 資料表結構 `transfer`
--

DROP TABLE IF EXISTS `transfer`;
CREATE TABLE `transfer` (
  `TransferID` varchar(10) NOT NULL,
  `RequestID` varchar(10) NOT NULL,
  `BatchID` varchar(10) NOT NULL,
  `ApprovedBy` int(100) NOT NULL,
  `TransferDate` date NOT NULL,
  `TransferNumber` int(10) NOT NULL,
  `FromDepartment` varchar(50) NOT NULL,
  `ToDepartment` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `transfer`
--

INSERT INTO `transfer` (`TransferID`, `RequestID`, `BatchID`, `ApprovedBy`, `TransferDate`, `TransferNumber`, `FromDepartment`, `ToDepartment`) VALUES
('TRF001', 'REQ001', 'BATCH003', 101, '2025-05-05', 1, 'Warehouse', 'Production');

-- --------------------------------------------------------

--
-- 資料表結構 `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `UserID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `position` varchar(10) DEFAULT NULL,
  `Role` varchar(10) DEFAULT NULL,
  `Department` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` varchar(20) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `user`
--

INSERT INTO `user` (`UserID`, `Name`, `position`, `Role`, `Department`, `Email`, `Phone`, `password`) VALUES
(101, 'Alice Cheung', 'Manager', 'ADMIN', 'Sales', 'alice.cheung@company.com', '852-55501234', '12345678'),
(102, 'Bob Tam', 'Designer', 'STAFF', 'Design', 'bob.tam@company.com', '852-55501235', ''),
(103, 'Carol Ho', 'Supervisor', 'STAFF', 'Production', 'carol.ho@company.com', '852-55501236', ''),
(104, 'Daniel Ng', 'Sales Rep', 'STAFF', 'Sales', 'daniel.ng@company.com', '852-55501237', ''),
(105, 'Emma Lau', 'Manager', 'STAFF', 'Warehouse', 'emma.lau@company.com', '852-55501238', '');

-- --------------------------------------------------------

--
-- 資料表結構 `user_productionbatch`
--

DROP TABLE IF EXISTS `user_productionbatch`;
CREATE TABLE `user_productionbatch` (
  `BatchID` varchar(10) NOT NULL,
  `UserID` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `audit_log`
--
ALTER TABLE `audit_log`
  ADD PRIMARY KEY (`AuditLogId`),
  ADD KEY `idx_audit_table` (`TableName`,`RecordId`),
  ADD KEY `idx_audit_date` (`ChangedDate`);

--
-- 資料表索引 `complaint`
--
ALTER TABLE `complaint`
  ADD PRIMARY KEY (`ComplaintID`),
  ADD KEY `CustomerID` (`CustomerID`),
  ADD KEY `OrderID` (`OrderID`),
  ADD KEY `SerialNumber` (`SerialNumber`),
  ADD KEY `UserID` (`UserID`);

--
-- 資料表索引 `customdesign`
--
ALTER TABLE `customdesign`
  ADD PRIMARY KEY (`DesignID`),
  ADD KEY `CustomerID` (`CustomerID`),
  ADD KEY `UserID` (`UserID`);

--
-- 資料表索引 `customdesign_orderitem`
--
ALTER TABLE `customdesign_orderitem`
  ADD KEY `DesignID` (`DesignID`),
  ADD KEY `OrderItemID` (`OrderItemID`);

--
-- 資料表索引 `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- 資料表索引 `deliveryconfirmation`
--
ALTER TABLE `deliveryconfirmation`
  ADD PRIMARY KEY (`ConfirmationID`),
  ADD KEY `ShipmentID` (`ShipmentID`);

--
-- 資料表索引 `deliveryitem`
--
ALTER TABLE `deliveryitem`
  ADD PRIMARY KEY (`DeliveryItemID`),
  ADD KEY `ShipmentID` (`ShipmentID`),
  ADD KEY `SerialNumber` (`SerialNumber`);

--
-- 資料表索引 `employee_salesorder`
--
ALTER TABLE `employee_salesorder`
  ADD KEY `UserID` (`UserID`),
  ADD KEY `OrderID` (`OrderID`);

--
-- 資料表索引 `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`InventoryID`),
  ADD KEY `MaterialID` (`MaterialID`),
  ADD KEY `ProductID` (`ProductID`),
  ADD KEY `SerialNumber` (`SerialNumber`);

--
-- 資料表索引 `materialrequest`
--
ALTER TABLE `materialrequest`
  ADD PRIMARY KEY (`RequestID`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `BatchID` (`BatchID`);

--
-- 資料表索引 `materialrequestitem`
--
ALTER TABLE `materialrequestitem`
  ADD PRIMARY KEY (`RequestItemID`),
  ADD KEY `RequestID` (`RequestID`),
  ADD KEY `MaterialID` (`MaterialID`);

--
-- 資料表索引 `orderitem`
--
ALTER TABLE `orderitem`
  ADD PRIMARY KEY (`OrderItemID`);

--
-- 資料表索引 `orderitem_product`
--
ALTER TABLE `orderitem_product`
  ADD KEY `ProductID` (`ProductID`),
  ADD KEY `OrderItemID` (`OrderItemID`);

--
-- 資料表索引 `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductID`),
  ADD KEY `UserID` (`UserID`);

--
-- 資料表索引 `productinstance`
--
ALTER TABLE `productinstance`
  ADD PRIMARY KEY (`SerialNumber`),
  ADD KEY `ProductID` (`ProductID`),
  ADD KEY `BatchID` (`BatchID`);

--
-- 資料表索引 `productionbatch`
--
ALTER TABLE `productionbatch`
  ADD PRIMARY KEY (`BatchID`);

--
-- 資料表索引 `quotation`
--
ALTER TABLE `quotation`
  ADD PRIMARY KEY (`QuotationID`),
  ADD KEY `CustomerID` (`CustomerID`),
  ADD KEY `EmployeeID` (`EmployeeID`);

--
-- 資料表索引 `quotation_salesorder`
--
ALTER TABLE `quotation_salesorder`
  ADD KEY `QuotationID` (`QuotationID`),
  ADD KEY `OrderID` (`OrderID`);

--
-- 資料表索引 `rawmaterial`
--
ALTER TABLE `rawmaterial`
  ADD PRIMARY KEY (`MaterialID`);

--
-- 資料表索引 `salesorder`
--
ALTER TABLE `salesorder`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `CustomerID` (`CustomerID`);

--
-- 資料表索引 `shipment`
--
ALTER TABLE `shipment`
  ADD PRIMARY KEY (`ShipmentID`),
  ADD KEY `OrderID` (`OrderID`),
  ADD KEY `UserID` (`UserID`);

--
-- 資料表索引 `transfer`
--
ALTER TABLE `transfer`
  ADD PRIMARY KEY (`TransferID`),
  ADD KEY `RequestID` (`RequestID`),
  ADD KEY `BatchID` (`BatchID`),
  ADD KEY `ApprovedBy` (`ApprovedBy`);

--
-- 資料表索引 `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`UserID`);

--
-- 資料表索引 `user_productionbatch`
--
ALTER TABLE `user_productionbatch`
  ADD KEY `BatchID` (`BatchID`),
  ADD KEY `UserID` (`UserID`);

--
-- 在傾印的資料表使用自動遞增(AUTO_INCREMENT)
--

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `audit_log`
--
ALTER TABLE `audit_log`
  MODIFY `AuditLogId` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- 已傾印資料表的限制式
--

--
-- 資料表的限制式 `complaint`
--
ALTER TABLE `complaint`
  ADD CONSTRAINT `complaint_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `complaint_ibfk_2` FOREIGN KEY (`OrderID`) REFERENCES `salesorder` (`OrderID`),
  ADD CONSTRAINT `complaint_ibfk_3` FOREIGN KEY (`SerialNumber`) REFERENCES `productinstance` (`SerialNumber`),
  ADD CONSTRAINT `complaint_ibfk_4` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`);

--
-- 資料表的限制式 `customdesign`
--
ALTER TABLE `customdesign`
  ADD CONSTRAINT `customdesign_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `customdesign_ibfk_2` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`);

--
-- 資料表的限制式 `customdesign_orderitem`
--
ALTER TABLE `customdesign_orderitem`
  ADD CONSTRAINT `customdesign_orderitem_ibfk_1` FOREIGN KEY (`DesignID`) REFERENCES `customdesign` (`DesignID`),
  ADD CONSTRAINT `customdesign_orderitem_ibfk_2` FOREIGN KEY (`OrderItemID`) REFERENCES `orderitem` (`OrderItemID`);

--
-- 資料表的限制式 `deliveryconfirmation`
--
ALTER TABLE `deliveryconfirmation`
  ADD CONSTRAINT `deliveryconfirmation_ibfk_1` FOREIGN KEY (`ShipmentID`) REFERENCES `shipment` (`ShipmentID`);

--
-- 資料表的限制式 `deliveryitem`
--
ALTER TABLE `deliveryitem`
  ADD CONSTRAINT `deliveryitem_ibfk_1` FOREIGN KEY (`ShipmentID`) REFERENCES `shipment` (`ShipmentID`),
  ADD CONSTRAINT `deliveryitem_ibfk_2` FOREIGN KEY (`SerialNumber`) REFERENCES `productinstance` (`SerialNumber`);

--
-- 資料表的限制式 `employee_salesorder`
--
ALTER TABLE `employee_salesorder`
  ADD CONSTRAINT `employee_salesorder_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`),
  ADD CONSTRAINT `employee_salesorder_ibfk_2` FOREIGN KEY (`OrderID`) REFERENCES `salesorder` (`OrderID`);

--
-- 資料表的限制式 `inventory`
--
ALTER TABLE `inventory`
  ADD CONSTRAINT `inventory_ibfk_1` FOREIGN KEY (`MaterialID`) REFERENCES `rawmaterial` (`MaterialID`),
  ADD CONSTRAINT `inventory_ibfk_2` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`),
  ADD CONSTRAINT `inventory_ibfk_3` FOREIGN KEY (`SerialNumber`) REFERENCES `productinstance` (`SerialNumber`);

--
-- 資料表的限制式 `materialrequest`
--
ALTER TABLE `materialrequest`
  ADD CONSTRAINT `materialrequest_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`),
  ADD CONSTRAINT `materialrequest_ibfk_2` FOREIGN KEY (`BatchID`) REFERENCES `productionbatch` (`BatchID`);

--
-- 資料表的限制式 `materialrequestitem`
--
ALTER TABLE `materialrequestitem`
  ADD CONSTRAINT `materialrequestitem_ibfk_1` FOREIGN KEY (`RequestID`) REFERENCES `materialrequest` (`RequestID`),
  ADD CONSTRAINT `materialrequestitem_ibfk_2` FOREIGN KEY (`MaterialID`) REFERENCES `rawmaterial` (`MaterialID`);

--
-- 資料表的限制式 `orderitem_product`
--
ALTER TABLE `orderitem_product`
  ADD CONSTRAINT `orderitem_product_ibfk_1` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`),
  ADD CONSTRAINT `orderitem_product_ibfk_2` FOREIGN KEY (`OrderItemID`) REFERENCES `orderitem` (`OrderItemID`);

--
-- 資料表的限制式 `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`);

--
-- 資料表的限制式 `productinstance`
--
ALTER TABLE `productinstance`
  ADD CONSTRAINT `productinstance_ibfk_1` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`),
  ADD CONSTRAINT `productinstance_ibfk_2` FOREIGN KEY (`BatchID`) REFERENCES `productionbatch` (`BatchID`);

--
-- 資料表的限制式 `quotation`
--
ALTER TABLE `quotation`
  ADD CONSTRAINT `quotation_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `quotation_ibfk_2` FOREIGN KEY (`EmployeeID`) REFERENCES `user` (`UserID`);

--
-- 資料表的限制式 `quotation_salesorder`
--
ALTER TABLE `quotation_salesorder`
  ADD CONSTRAINT `quotation_salesorder_ibfk_1` FOREIGN KEY (`QuotationID`) REFERENCES `quotation` (`QuotationID`),
  ADD CONSTRAINT `quotation_salesorder_ibfk_2` FOREIGN KEY (`OrderID`) REFERENCES `salesorder` (`OrderID`);

--
-- 資料表的限制式 `salesorder`
--
ALTER TABLE `salesorder`
  ADD CONSTRAINT `salesorder_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`);

--
-- 資料表的限制式 `shipment`
--
ALTER TABLE `shipment`
  ADD CONSTRAINT `shipment_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `salesorder` (`OrderID`),
  ADD CONSTRAINT `shipment_ibfk_2` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`);

--
-- 資料表的限制式 `transfer`
--
ALTER TABLE `transfer`
  ADD CONSTRAINT `transfer_ibfk_1` FOREIGN KEY (`RequestID`) REFERENCES `materialrequest` (`RequestID`),
  ADD CONSTRAINT `transfer_ibfk_2` FOREIGN KEY (`BatchID`) REFERENCES `productionbatch` (`BatchID`),
  ADD CONSTRAINT `transfer_ibfk_3` FOREIGN KEY (`ApprovedBy`) REFERENCES `user` (`UserID`);

--
-- 資料表的限制式 `user_productionbatch`
--
ALTER TABLE `user_productionbatch`
  ADD CONSTRAINT `user_productionbatch_ibfk_1` FOREIGN KEY (`BatchID`) REFERENCES `productionbatch` (`BatchID`),
  ADD CONSTRAINT `user_productionbatch_ibfk_2` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
