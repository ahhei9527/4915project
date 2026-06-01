-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 2026-06-01 18:22:33
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

-- --------------------------------------------------------

--
-- 資料表結構 `audit_log`
--

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
(42, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-28 22:30:49', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(43, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 10:08:12', NULL, NULL, 'User Alice Cheung logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(44, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 10:16:51', NULL, NULL, 'User Alice Cheung logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(45, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 10:22:41', NULL, NULL, 'User Alice Cheung logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(46, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 10:25:53', NULL, NULL, 'User Alice Cheung logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(47, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-29 10:25:57', NULL, NULL, 'User Alice Cheung logged out', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(48, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 10:52:49', NULL, NULL, 'User Alice Cheung logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(49, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-29 10:54:43', NULL, NULL, 'User Alice Cheung logged out', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(50, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 11:16:44', NULL, NULL, 'User Alice Cheung logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(51, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-29 11:19:11', NULL, NULL, 'User Alice Cheung logged out', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(52, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 11:22:20', NULL, NULL, 'User Alice Cheung logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(53, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-29 11:22:30', NULL, NULL, 'User Alice Cheung logged out', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(54, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 11:23:17', NULL, NULL, 'User Alice Cheung logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(55, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-29 11:23:23', NULL, NULL, 'User Alice Cheung logged out', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(56, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 11:26:12', NULL, NULL, 'User Alice Cheung logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(57, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-29 11:26:56', NULL, NULL, 'User Alice Cheung logged out', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(58, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 11:45:59', NULL, NULL, 'User Alice Cheung logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(59, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 11:53:09', NULL, NULL, 'User Alice Cheung logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(60, 'user', '104', 'LOGIN', 104, 'Daniel Ng', '2026-05-29 11:54:03', NULL, NULL, 'User Daniel Ng logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(61, 'user', '104', 'LOGIN', 104, 'Daniel Ng', '2026-05-29 11:56:09', NULL, NULL, 'User Daniel Ng logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(62, 'user', '104', 'LOGIN', 104, 'Daniel Ng', '2026-05-29 11:57:55', NULL, NULL, 'User Daniel Ng logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(63, 'user', '104', 'LOGIN', 104, 'Daniel Ng', '2026-05-29 13:26:41', NULL, NULL, 'User Daniel Ng logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(64, 'user', '104', 'LOGIN', 104, 'Daniel Ng', '2026-05-29 13:37:55', NULL, NULL, 'User Daniel Ng logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(65, 'user', '104', 'LOGIN', 104, 'Daniel Ng', '2026-05-29 13:41:15', NULL, NULL, 'User Daniel Ng logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(66, 'user', '104', 'LOGIN', 104, 'Daniel Ng', '2026-05-29 13:51:33', NULL, NULL, 'User Daniel Ng logged in', 'fe80::5957:7bd:263d:1876%17', 'AHHEI_LAPTOP'),
(67, 'user', '104', 'LOGIN', 104, 'Daniel Ng', '2026-05-29 17:36:09', NULL, NULL, 'User Daniel Ng logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(68, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 17:48:07', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(69, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-29 17:48:47', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(70, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 19:04:05', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(71, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 19:07:13', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(72, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 19:12:54', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(73, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 19:50:06', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(74, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 19:51:15', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(75, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 19:52:43', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(76, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 19:56:56', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(77, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 20:07:52', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(78, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 20:09:59', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(79, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 20:18:09', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(80, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 20:25:31', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(81, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 20:26:10', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(82, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 20:27:34', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(83, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 21:01:03', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(84, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 21:01:56', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(85, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 21:45:08', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(86, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 21:52:11', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(87, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 21:52:51', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(88, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 21:53:38', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(89, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 21:54:42', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(90, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 21:55:25', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(91, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 21:57:07', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(92, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 21:58:36', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(93, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 22:00:05', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(94, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 22:00:53', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(95, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 22:02:34', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(96, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 22:03:51', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(97, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 22:04:55', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(98, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 22:48:07', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(99, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 22:49:13', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(100, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 22:56:44', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(101, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 22:57:41', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(102, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 22:58:14', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(103, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 22:58:29', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(104, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 23:02:06', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(105, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 23:04:20', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(106, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 23:05:05', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(107, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 23:05:23', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(108, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-29 23:59:55', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(109, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-30 00:01:15', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(110, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 00:07:35', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(111, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 00:16:30', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(112, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 00:24:06', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(113, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 00:25:47', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(114, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 00:28:38', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(115, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 00:29:19', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(116, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 00:30:26', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(117, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 00:31:25', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(118, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 00:33:37', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(119, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 00:39:52', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(120, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 00:40:03', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(121, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-30 00:40:17', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(122, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 14:20:02', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(123, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 14:22:46', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(124, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 14:23:54', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(125, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-30 14:24:13', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(126, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 16:12:20', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(127, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 16:26:09', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(128, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 16:28:44', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(129, 'user', '101', 'Create Order', 101, 'Alice Cheung', '2026-05-30 16:29:18', NULL, '\"ORD000005\"', 'User Alice Cheung create an order', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(130, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 16:31:15', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(131, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 16:37:58', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(132, 'salesorder', 'ORD000006', 'Create Order', 101, 'System', '2026-05-30 16:38:15', NULL, NULL, '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(133, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 16:39:12', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(134, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 16:40:12', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(135, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 17:54:03', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(136, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 18:05:11', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(137, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 18:06:45', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(138, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 18:08:04', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(139, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 18:11:09', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(140, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 18:13:20', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(141, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 18:14:54', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(142, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 18:50:06', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(143, 'user', '104', 'LOGIN', 104, 'Daniel Ng', '2026-05-30 18:54:39', NULL, NULL, 'User Daniel Ng logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(144, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 19:46:25', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(145, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 19:49:16', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(146, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 19:57:34', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(147, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 19:58:24', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(148, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 19:59:37', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(149, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 20:00:39', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(150, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 20:03:31', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(151, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 20:07:08', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(152, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 20:13:49', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(153, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 20:14:36', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(154, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 20:15:50', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(155, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 20:16:57', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(156, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 21:31:14', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(157, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 21:33:16', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(158, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 22:33:48', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(159, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-30 22:34:51', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(160, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 22:35:02', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(161, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-30 22:36:13', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(162, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 11:24:57', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(163, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 11:43:01', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(164, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 11:45:58', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(165, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 12:13:10', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(166, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-31 12:15:56', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(167, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 12:19:11', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(168, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-31 12:24:40', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(169, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 12:26:55', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(170, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 12:33:48', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(171, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-31 12:34:24', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(172, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 13:12:50', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(173, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 13:14:42', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(174, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 13:15:12', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(175, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-31 13:15:30', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(176, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 13:17:04', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(177, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-31 13:17:24', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(178, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 13:18:49', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(179, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-05-31 13:19:06', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(180, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 13:25:01', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(181, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 13:40:00', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(182, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 14:02:07', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(183, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 14:02:48', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(184, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 14:03:01', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(185, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 14:03:11', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(186, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 14:27:56', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(187, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 14:35:52', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(188, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 15:07:41', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(189, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 15:09:05', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(190, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 15:10:35', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(191, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 15:11:22', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(192, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 15:12:25', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(193, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 15:12:57', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(194, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 15:32:33', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(195, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 15:33:03', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(196, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 15:34:09', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(197, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 15:36:15', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(198, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 15:38:42', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(199, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 15:41:58', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(200, 'shipment', 'ORD000003', 'Create Shipment', 101, 'System', '2026-05-31 15:42:10', NULL, '\"SHIP003, Pending, Standard\"', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(201, 'SalesOrder', 'ORD000003', 'Update SalesOrder', 101, 'System', '2026-05-31 15:42:10', NULL, '\"ORD000003, Confirmed, 2025/5/22 00:00:00\"', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(202, 'shipment', 'ORD000004', 'Create Shipment', 101, 'System', '2026-05-31 15:52:21', NULL, '\"SHIP004, In Transit, Standard\"', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(203, 'SalesOrder', 'ORD000004', 'Update SalesOrder', 101, 'System', '2026-05-31 15:52:21', NULL, '\"ORD000004, Confirmed, 2026/6/5 00:00:00\"', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(204, 'salesorder', 'CONF001', 'Update Order', 101, 'System', '2026-05-31 15:53:44', '\", \"', '\"2025-04-08, Good\"', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(205, 'salesorder', 'CONF003', 'Update Order', 101, 'System', '2026-05-31 15:54:04', '\", \"', '\"2025-04-08, Good\"', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(206, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 15:56:25', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(207, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 16:00:47', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(208, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 16:02:56', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(209, 'Inventory', 'INV005', 'Add Inward', 101, 'System', '2026-05-31 16:03:05', NULL, '{\"InventoryID\":\"INV005\",\"MaterialID\":\"MAT001\",\"ProductID\":\"PROD002\",\"SerialNumber\":\"SN00000006\",\"WarehouseLocation\":\"WH-A-12-03\",\"QuantityOnHand\":\"0\",\"LastUpdated\":\"2026/5/31 16:02:59\",\"ReorderLevel\":\"50\"}', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(210, 'productionbatch', 'BATCH004', 'Add Production Batch', 101, 'System', '2026-05-31 16:03:05', NULL, '{\"BatchID\":\"BATCH004\",\"StartDate\":\"2026/5/31 16:02:59\",\"EndDate\":\"2026/6/7 16:02:59\",\"Status\":\"In Progress\"}', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(211, 'productinstance', 'SN00000006', 'Add Product Instance', 101, 'System', '2026-05-31 16:03:05', NULL, '{\"SerialNumber\":\"SN00000006\",\"ProductID\":\"PROD002\",\"BatchID\":\"BATCH004\",\"ProductionDate\":\"2026/5/31 16:02:59\",\"CurrentStatus\":\"In Stock\",\"WarrantyEndDate\":\"2029/5/31 16:02:59\"}', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(212, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 16:04:38', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(213, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 16:08:16', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(214, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 16:09:35', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(215, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 17:05:25', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(216, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 17:06:49', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(217, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 17:07:30', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(218, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 17:08:01', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(219, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 17:09:44', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(220, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 17:10:37', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(221, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 17:18:06', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(222, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 17:19:40', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(223, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 17:20:43', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(224, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-05-31 17:24:51', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(225, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 16:55:28', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(226, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:01:14', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(227, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:03:14', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(228, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 17:03:17', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(229, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:07:30', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(230, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:09:51', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(231, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 17:09:54', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(232, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:10:07', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(233, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 17:11:02', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(234, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:14:56', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(235, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 17:15:05', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(236, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:15:17', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(237, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 17:15:20', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(238, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:15:28', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(239, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 17:15:30', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(240, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:15:38', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(241, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 17:15:43', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(242, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:32:59', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(243, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:36:56', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(244, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:39:26', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(245, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:47:55', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(246, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:52:47', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(247, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 17:53:38', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(248, 'salesorder', 'ORD000007', 'Create Order', 101, 'System', '2026-06-01 17:53:57', NULL, NULL, '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(249, 'shipment', 'ORD000007', 'Create Shipment', 101, 'System', '2026-06-01 17:55:43', NULL, '\"SHIP005, In Transit, Standard\"', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(250, 'SalesOrder', 'ORD000007', 'Update SalesOrder', 101, 'System', '2026-06-01 17:55:43', NULL, '\"ORD000007, Paid, 2026/6/8 00:00:00\"', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(251, 'salesorder', 'CONF004', 'Update Order', 101, 'System', '2026-06-01 17:56:29', '\", \"', '\"2026-06-01, Good\"', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(252, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 18:33:08', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(253, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 18:34:08', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(254, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 18:35:04', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(255, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 18:35:23', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(256, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 18:36:44', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(257, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 18:37:49', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(258, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 18:38:31', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(259, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 18:39:01', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(260, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 19:13:29', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(261, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 19:14:00', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(262, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 19:21:17', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(263, 'salesorder', 'ORD000008', 'Create Order', 101, 'System', '2026-06-01 19:21:32', NULL, NULL, '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(264, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 19:21:39', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(265, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 19:27:56', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(266, 'salesorder', 'ORD000009', 'Create Order', 101, 'System', '2026-06-01 19:28:16', NULL, NULL, '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(267, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 19:28:23', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(268, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 19:29:51', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(269, 'shipment', 'ORD000009', 'Create Shipment', 101, 'System', '2026-06-01 19:30:10', NULL, '\"SHIP006, In Transit, Standard\"', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(270, 'SalesOrder', 'ORD000009', 'Update SalesOrder', 101, 'System', '2026-06-01 19:30:10', NULL, '\"ORD000009, Processing, 2026/6/8 00:00:00\"', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(271, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 19:30:32', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(272, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 19:36:16', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(273, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 19:37:21', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(274, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 19:37:58', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(275, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 19:40:18', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(276, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 19:44:02', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(277, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 19:44:13', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(278, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 19:50:34', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(279, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 19:51:34', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(280, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 19:53:39', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(281, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 19:54:15', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(282, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 19:54:42', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(283, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 19:55:02', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(284, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 20:18:47', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(285, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 20:19:03', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(286, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 20:19:46', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(287, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 20:20:31', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(288, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 20:20:59', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(289, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 20:21:34', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(290, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 20:23:01', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(291, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 20:25:18', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(292, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 20:53:03', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(293, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 20:53:10', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(294, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 21:00:13', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(295, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 21:00:30', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(296, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 21:01:59', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(297, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 21:30:48', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(298, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 21:32:20', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(299, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 21:33:22', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(300, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 21:33:41', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(301, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 22:26:04', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(302, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 22:28:58', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(303, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 22:31:28', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(304, 'replyslip', 'RS001', 'Create replyslip', 101, 'System', '2026-06-01 22:31:35', NULL, NULL, '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(305, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 22:34:32', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(306, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 22:35:02', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(307, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 22:36:33', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC');
INSERT INTO `audit_log` (`AuditLogId`, `TableName`, `RecordId`, `Action`, `UserID`, `Username`, `ChangedDate`, `OldValues`, `NewValues`, `Description`, `IpAddress`, `MachineName`) VALUES
(308, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 22:36:46', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(309, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 22:38:11', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(310, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 22:38:58', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(311, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 22:42:09', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(312, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 22:42:56', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(313, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-01 23:22:19', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(314, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-01 23:22:43', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(315, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-02 00:00:48', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(316, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-02 00:01:05', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(317, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-02 00:10:59', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(318, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-02 00:15:30', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(319, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-02 00:19:03', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(320, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-02 00:19:40', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(321, 'user', '101', 'LOGIN', 101, 'Alice Cheung', '2026-06-02 00:20:53', NULL, NULL, 'User Alice Cheung logged in', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(322, 'company', 'ABC Trading Ltd', 'Update  company', 101, 'System', '2026-06-02 00:21:05', NULL, '{\"Language\":\"Chinese\",\"Warehouse\":\"WH-A-12-04\",\"Currency\":\"HKD\",\"CompanyName\":\"ABC Trading Ltd\"}', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(323, 'company', 'Lee Manufacturing', 'Update  company', 101, 'System', '2026-06-02 00:21:35', NULL, '{\"Language\":\"English\",\"Warehouse\":\"WH-B-05-01\",\"Currency\":\"USD\",\"CompanyName\":\"Lee Manufacturing\"}', '', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC'),
(324, 'user', '101', 'LOGOUT', 101, 'Alice Cheung', '2026-06-02 00:21:46', NULL, NULL, 'User Alice Cheung logged out', 'fe80::2701:4f47:ed53:2876%21', 'AHHEI-PC');

-- --------------------------------------------------------

--
-- 資料表結構 `company`
--

CREATE TABLE `company` (
  `CompanyName` varchar(50) NOT NULL,
  `warehouse` varchar(100) DEFAULT NULL,
  `launage` varchar(50) DEFAULT NULL,
  `currency` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `company`
--

INSERT INTO `company` (`CompanyName`, `warehouse`, `launage`, `currency`) VALUES
('ABC Trading Ltd', 'WH-A-12-04', 'Chinese', 'HKD'),
('Lee Manufacturing', 'WH-B-05-01', 'English', 'USD'),
('Premium Furnishings', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `complaint`
--

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

CREATE TABLE `customer` (
  `CustomerID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Company` varchar(50) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  `Address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `customer`
--

INSERT INTO `customer` (`CustomerID`, `Name`, `Company`, `Email`, `Phone`, `Address`) VALUES
(1, 'John Chan', 'ABC Trading Ltd', 'john.chan@email.com', '852-98765432', 'Rm. 318 South China Cold Storage Bldg. 13-17 Wah Sing Street Kwai Chung N.T.'),
(2, 'Mary Wong', NULL, 'mary.wong@gmail.com', '852-91234567', ''),
(3, 'David Lee', 'Lee Manufacturing', 'david@leeco.hk', '852-23456789', ''),
(4, 'Sarah Lam', 'Premium Furnishings', 'sarah.lam@pfurnish.com', '852-87654321', '');

-- --------------------------------------------------------

--
-- 資料表結構 `deliveryconfirmation`
--

CREATE TABLE `deliveryconfirmation` (
  `ConfirmationID` varchar(10) NOT NULL,
  `ShipmentID` varchar(10) NOT NULL,
  `ReceivedDate` date DEFAULT NULL,
  `ReceiverName` varchar(50) DEFAULT NULL,
  `ItemCondition` varchar(50) DEFAULT NULL,
  `Notes` varchar(50) DEFAULT NULL,
  `CustomerConfirmation` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `deliveryconfirmation`
--

INSERT INTO `deliveryconfirmation` (`ConfirmationID`, `ShipmentID`, `ReceivedDate`, `ReceiverName`, `ItemCondition`, `Notes`, `CustomerConfirmation`) VALUES
('CONF001', 'SHIP001', '2025-04-08', 'John Chan', 'Good', 'All items perfect', 'Yes'),
('CONF002', 'SHIP003', NULL, NULL, 'Good', NULL, NULL),
('CONF003', 'SHIP004', '2025-04-08', '', 'Good', '', 'Yes'),
('CONF004', 'SHIP005', '2026-06-01', 'yee', 'Good', '', 'Yes'),
('CONF005', 'SHIP006', NULL, NULL, 'Good', NULL, NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `deliveryitem`
--

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
-- 資料表結構 `deliverynote`
--

CREATE TABLE `deliverynote` (
  `deliveryID` varchar(10) NOT NULL,
  `shipmentID` varchar(10) NOT NULL,
  `orderID` varchar(10) NOT NULL,
  `customerID` int(100) NOT NULL,
  `RecipientName` varchar(100) DEFAULT NULL,
  `DeliveryAddress` varchar(255) NOT NULL,
  `CreateDate` date DEFAULT NULL,
  `Status` varchar(20) DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `deliverynote`
--

INSERT INTO `deliverynote` (`deliveryID`, `shipmentID`, `orderID`, `customerID`, `RecipientName`, `DeliveryAddress`, `CreateDate`, `Status`) VALUES
('DN001', 'SHIP006', 'ORD000009', 1, 'John Chan', 'Rm. 318 South China Cold Storage Bldg. 13-17 Wah Sing Street Kwai Chung N.T.', '2026-06-01', 'Created');

-- --------------------------------------------------------

--
-- 資料表結構 `employee_salesorder`
--

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
('INV001', 'MAT001', 'PROD001', 'SN00000001', 'WH-A-12-03', 60, '2025-05-01', '50'),
('INV002', 'MAT002', 'PROD002', 'SN00000003', 'WH-B-05-01', 120, '2025-05-10', '200'),
('INV003', 'MAT003', 'PROD003', 'SN00000004', 'WH-C-08-02', 60, '2025-05-15', '50'),
('INV004', 'MAT001', 'PROD001', 'SN00000002', 'WH-A-12-04', 25, '2025-05-16', '50'),
('INV005', 'MAT001', 'PROD002', 'SN00000006', 'WH-A-12-03', 0, '2026-05-31', '50');

-- --------------------------------------------------------

--
-- 資料表結構 `materialrequest`
--

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

CREATE TABLE `orderitem` (
  `OrderItemID` varchar(10) NOT NULL,
  `Quantity` int(10) NOT NULL,
  `UnitPrice` decimal(12,2) NOT NULL,
  `Subtotal` decimal(12,2) DEFAULT NULL,
  `CustomNotes` varchar(255) DEFAULT NULL,
  `OrderID` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `orderitem`
--

INSERT INTO `orderitem` (`OrderItemID`, `Quantity`, `UnitPrice`, `Subtotal`, `CustomNotes`, `OrderID`) VALUES
('OI000001', 1, 2850.00, 2850.00, NULL, NULL),
('OI000002', 1, 4250.00, 4250.00, NULL, NULL),
('OI000003', 3, 1250.00, 3750.00, 'Black color', NULL),
('OI000004', 5, 4250.00, 21250.00, NULL, 'ORD000006'),
('OI000005', 5, 2850.00, 14250.00, NULL, 'ORD000007'),
('OI000006', 5, 4250.00, 21250.00, NULL, 'ORD000007'),
('OI000007', 5, 1250.00, 6250.00, NULL, 'ORD000007'),
('OI000010', 5, 2850.00, 14250.00, NULL, 'ORD000008'),
('OI000011', 5, 4250.00, 21250.00, NULL, 'ORD000008'),
('OI000012', 5, 2850.00, 14250.00, NULL, 'ORD000009'),
('OI000013', 5, 4250.00, 21250.00, NULL, 'ORD000009');

-- --------------------------------------------------------

--
-- 資料表結構 `orderitem_product`
--

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
('PROD003', 'OI000003'),
('PROD001', 'OI000008'),
('PROD002', 'OI000009'),
('PROD001', 'OI000012'),
('PROD002', 'OI000013');

-- --------------------------------------------------------

--
-- 資料表結構 `product`
--

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
('SN00000005', 'PROD003', 'BATCH002', '2025-04-10', 'Delivered', '2028-04-10'),
('SN00000006', 'PROD002', 'BATCH004', '2026-05-31', 'In Stock', '2029-05-31');

-- --------------------------------------------------------

--
-- 資料表結構 `productionbatch`
--

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
('BATCH003', '2025-05-01', '2025-05-18', 'In Progress'),
('BATCH004', '2026-05-31', '2026-06-07', 'In Progress');

-- --------------------------------------------------------

--
-- 資料表結構 `quotation`
--

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
-- 資料表結構 `replyslip`
--

CREATE TABLE `replyslip` (
  `replySlipID` varchar(10) NOT NULL,
  `OrderID` varchar(10) DEFAULT NULL,
  `deliverynoteID` varchar(10) DEFAULT NULL,
  `recipient` varchar(100) DEFAULT NULL,
  `DeliveryDate` date DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `replyslip`
--

INSERT INTO `replyslip` (`replySlipID`, `OrderID`, `deliverynoteID`, `recipient`, `DeliveryDate`, `Address`) VALUES
('RS001', 'ORD000009', 'DN001', 'John Chan', '2026-06-01', 'Rm. 318 South China Cold Storage Bldg. 13-17 Wah Sing Street Kwai Chung N.T.');

-- --------------------------------------------------------

--
-- 資料表結構 `salesorder`
--

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
('ORD000003', 3, '2025-05-01', 1250.00, '2025-05-25', 'Confirmed', '2025-05-22', NULL),
('ORD000004', 1, '2026-05-29', 6600.00, '2026-05-29', 'Confirmed', '2026-06-05', NULL),
('ORD000005', 2, '2026-05-30', 42500.00, '2026-05-30', 'Paid', '2026-06-06', NULL),
('ORD000006', 3, '2026-05-30', 21250.00, '2026-05-30', 'Paid', '2026-06-06', NULL),
('ORD000007', 1, '2026-06-01', 41750.00, '2026-06-01', 'Paid', '2026-06-08', NULL),
('ORD000008', 1, '2026-06-01', 35500.00, '2026-06-01', 'Paid', '2026-06-08', NULL),
('ORD000009', 1, '2026-06-01', 35500.00, '2026-06-01', 'Processing', '2026-06-08', NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `shipment`
--

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
('SHIP002', 'ORD000002', 105, 'Standard', 'TRK112233445', 'In Transit'),
('SHIP003', 'ORD000003', 101, 'Standard', NULL, 'Pending'),
('SHIP004', 'ORD000004', 101, 'Standard', NULL, 'In Transit'),
('SHIP005', 'ORD000007', 101, 'Standard', NULL, 'In Transit'),
('SHIP006', 'ORD000009', 101, 'Standard', NULL, 'In Transit');

-- --------------------------------------------------------

--
-- 資料表結構 `transfer`
--

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
(104, 'Daniel Ng', 'Sales Rep', 'STAFF', 'Sales', 'daniel.ng@company.com', '852-55501237', '11111111'),
(105, 'Emma Lau', 'Manager', 'STAFF', 'Warehouse', 'emma.lau@company.com', '852-55501238', '');

-- --------------------------------------------------------

--
-- 資料表結構 `user_productionbatch`
--

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
-- 資料表索引 `company`
--
ALTER TABLE `company`
  ADD PRIMARY KEY (`CompanyName`);

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
  ADD PRIMARY KEY (`CustomerID`),
  ADD KEY `fk_customer_company` (`Company`);

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
-- 資料表索引 `deliverynote`
--
ALTER TABLE `deliverynote`
  ADD PRIMARY KEY (`deliveryID`),
  ADD KEY `shipmentID` (`shipmentID`),
  ADD KEY `orderID` (`orderID`),
  ADD KEY `customerID` (`customerID`);

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
  ADD PRIMARY KEY (`OrderItemID`),
  ADD KEY `FK_OrderItem_SalesOrder` (`OrderID`);

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
-- 資料表索引 `replyslip`
--
ALTER TABLE `replyslip`
  ADD PRIMARY KEY (`replySlipID`),
  ADD KEY `OrderID` (`OrderID`),
  ADD KEY `deliverynoteID` (`deliverynoteID`);

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
  MODIFY `AuditLogId` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=325;

--
-- 已傾印資料表的限制式
--

--
-- 資料表的限制式 `customer`
--
ALTER TABLE `customer`
  ADD CONSTRAINT `fk_customer_company` FOREIGN KEY (`Company`) REFERENCES `company` (`CompanyName`);

--
-- 資料表的限制式 `deliverynote`
--
ALTER TABLE `deliverynote`
  ADD CONSTRAINT `deliverynote_ibfk_1` FOREIGN KEY (`shipmentID`) REFERENCES `shipment` (`ShipmentID`),
  ADD CONSTRAINT `deliverynote_ibfk_2` FOREIGN KEY (`orderID`) REFERENCES `salesorder` (`OrderID`),
  ADD CONSTRAINT `deliverynote_ibfk_3` FOREIGN KEY (`customerID`) REFERENCES `salesorder` (`CustomerID`);

--
-- 資料表的限制式 `materialrequest`
--
ALTER TABLE `materialrequest`
  ADD CONSTRAINT `materialrequest_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`),
  ADD CONSTRAINT `materialrequest_ibfk_2` FOREIGN KEY (`BatchID`) REFERENCES `productionbatch` (`BatchID`);

--
-- 資料表的限制式 `orderitem`
--
ALTER TABLE `orderitem`
  ADD CONSTRAINT `FK_OrderItem_SalesOrder` FOREIGN KEY (`OrderID`) REFERENCES `salesorder` (`OrderID`);

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
-- 資料表的限制式 `replyslip`
--
ALTER TABLE `replyslip`
  ADD CONSTRAINT `replyslip_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `salesorder` (`OrderID`),
  ADD CONSTRAINT `replyslip_ibfk_2` FOREIGN KEY (`deliverynoteID`) REFERENCES `deliverynote` (`deliveryID`);

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
