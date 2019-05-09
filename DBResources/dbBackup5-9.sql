-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: May 09, 2019 at 11:53 PM
-- Server version: 5.6.38
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

--
-- Database: `botc`
--

-- --------------------------------------------------------

--
-- Table structure for table `bandits`
--

CREATE TABLE `bandits` (
  `id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL DEFAULT 'Deckhand',
  `CurrentHealth` int(11) NOT NULL,
  `class_id` int(11) DEFAULT NULL,
  `User_Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bandits`
--

INSERT INTO `bandits` (`id`, `Name`, `CurrentHealth`, `class_id`, `User_Id`) VALUES
(1, '\"Sir\" Deckhand', 100, 1, 0),
(2, 'todd', 0, 3, 0),
(3, 'Dustin', 0, 1, 0),
(4, 'Dustin', 0, 1, 0),
(5, 'Dustin', 0, 4, 0),
(6, 'jennifer', 0, 2, 0),
(7, 'Bashful Brian', 0, 3, 0),
(8, 'Crazy Joe', 0, 2, 0),
(9, 'todd', 0, 3, 0);

-- --------------------------------------------------------

--
-- Table structure for table `bandit_items`
--

CREATE TABLE `bandit_items` (
  `id` int(11) NOT NULL,
  `bandit_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `Quanity` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `classes`
--

CREATE TABLE `classes` (
  `id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL DEFAULT 'Pirate',
  `Health` int(11) NOT NULL DEFAULT '100',
  `Strength` int(11) NOT NULL DEFAULT '10',
  `Dexterity` int(11) NOT NULL DEFAULT '10'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `classes`
--

INSERT INTO `classes` (`id`, `Name`, `Health`, `Strength`, `Dexterity`) VALUES
(1, 'Swashbuckler', 75, 8, 18),
(2, 'Marauder', 85, 16, 10),
(3, 'Mystic', 75, 6, 10),
(4, 'Marine', 130, 13, 13);

-- --------------------------------------------------------

--
-- Table structure for table `Items`
--

CREATE TABLE `Items` (
  `id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL DEFAULT 'Sponge',
  `Type` varchar(255) NOT NULL DEFAULT 'Tool'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Items`
--

INSERT INTO `Items` (`id`, `Name`, `Type`) VALUES
(1, 'Sponge', 'Tool'),
(2, 'Gold', 'Currency'),
(3, 'Brestplate', 'BodyArmor'),
(4, 'Cutlass', 'Weapon'),
(5, 'Iron Helmet', 'HeadArmor'),
(6, 'Hook', 'Weapon'),
(16, 'Blade Of Slowing', 'weapon'),
(18, 'Hammer of Crushing', 'weapon'),
(19, 'Jared Of Knowing', 'weapon'),
(20, 'Rock of Throwing', 'weapon');

-- --------------------------------------------------------

--
-- Table structure for table `Users`
--

CREATE TABLE `Users` (
  `id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `SessionId` varchar(255) NOT NULL,
  `Privileges` varchar(255) NOT NULL DEFAULT 'User'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Users`
--

INSERT INTO `Users` (`id`, `Name`, `password`, `SessionId`, `Privileges`) VALUES
(2, 'Dustin', 'root', 'c35ab983-528a-b61d-42cc-955643dc7fdd', 'user'),
(3, 'Todd', 'root', 'a70f8463-eb62-d93d-f5ff-f057167f214c', 'user');

-- --------------------------------------------------------

--
-- Table structure for table `WeaponStats`
--

CREATE TABLE `WeaponStats` (
  `id` int(11) NOT NULL,
  `Item_Id` int(11) NOT NULL,
  `Speed` int(11) NOT NULL,
  `DamageDie` int(11) NOT NULL,
  `DamageType` varchar(255) NOT NULL,
  `AttackRange` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `WeaponStats`
--

INSERT INTO `WeaponStats` (`id`, `Item_Id`, `Speed`, `DamageDie`, `DamageType`, `AttackRange`) VALUES
(2, 16, 13, 4, 'Slashing', 2),
(4, 18, 8, 12, 'Bludgeon', 4),
(5, 19, 14, 4, 'Mental', 10),
(6, 20, 4, 5, 'Bludgeon', 7);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bandits`
--
ALTER TABLE `bandits`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `bandit_items`
--
ALTER TABLE `bandit_items`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `classes`
--
ALTER TABLE `classes`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Items`
--
ALTER TABLE `Items`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Users`
--
ALTER TABLE `Users`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `WeaponStats`
--
ALTER TABLE `WeaponStats`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bandits`
--
ALTER TABLE `bandits`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `bandit_items`
--
ALTER TABLE `bandit_items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `classes`
--
ALTER TABLE `classes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `Items`
--
ALTER TABLE `Items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `Users`
--
ALTER TABLE `Users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `WeaponStats`
--
ALTER TABLE `WeaponStats`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
