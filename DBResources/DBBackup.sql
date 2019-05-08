-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: May 08, 2019 at 06:41 PM
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
  `Name` varchar(255) NOT NULL DEFAULT '"Deckhand"',
  `class_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
-- Table structure for table `class`
--

CREATE TABLE `class` (
  `id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL DEFAULT 'Pirate',
  `Health` int(11) NOT NULL DEFAULT '100',
  `Strength` int(11) NOT NULL DEFAULT '10',
  `Dexterity` int(11) NOT NULL DEFAULT '10'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `Item`
--

CREATE TABLE `Item` (
  `id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL DEFAULT 'Sponge',
  `Type` varchar(255) NOT NULL DEFAULT 'Tool'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
-- Indexes for table `class`
--
ALTER TABLE `class`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Item`
--
ALTER TABLE `Item`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bandits`
--
ALTER TABLE `bandits`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `bandit_items`
--
ALTER TABLE `bandit_items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `class`
--
ALTER TABLE `class`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `Item`
--
ALTER TABLE `Item`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
