-- ---
-- Globals
-- ---

-- SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
-- SET FOREIGN_KEY_CHECKS=0;

-- ---
-- Table 'Bandits'
--
-- ---

DROP TABLE IF EXISTS `Bandits`;

CREATE TABLE `Bandits` (
  `id` INTEGER NULL AUTO_INCREMENT DEFAULT NULL,
  `Name` VARCHAR(255) NOT NULL DEFAULT '"Deckhand"',
  `class_id` INTEGER NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
);

-- ---
-- Table 'Class'
--
-- ---

DROP TABLE IF EXISTS `Class`;

CREATE TABLE `Class` (
  `id` INTEGER NULL AUTO_INCREMENT DEFAULT NULL,
  `Name` VARCHAR(255) NOT NULL DEFAULT 'Pirate',
  `Health` INTEGER NOT NULL DEFAULT 100,
  `Strength` INTEGER NOT NULL DEFAULT 10,
  `Dexterity` INTEGER NOT NULL DEFAULT 10,
  PRIMARY KEY (`id`)
);

-- ---
-- Table 'bandit_items'
--
-- ---

DROP TABLE IF EXISTS `bandit_items`;

CREATE TABLE `bandit_items` (
  `id` INTEGER NULL AUTO_INCREMENT DEFAULT NULL,
  `bandit_id` INTEGER NOT NULL,
  `item_id` INTEGER NOT NULL,
  `Quanity` INTEGER NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`)
);

-- ---
-- Table 'item'
--
-- ---

DROP TABLE IF EXISTS `item`;

CREATE TABLE `item` (
  `id` INTEGER NULL AUTO_INCREMENT DEFAULT NULL,
  -- `Name` VARCHAR NOT NULL DEFAULT 'Sponge',
  -- `Type` VARCHAR NOT NULL DEFAULT 'Tool',
  PRIMARY KEY (`id`)
);

-- ---
-- Foreign Keys
-- ---


-- ---
-- Table Properties
-- ---

-- ALTER TABLE `Bandits` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE `Class` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE `bandit_items` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE `item` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ---
-- Test Data
-- ---

-- INSERT INTO `Bandits` (`id`,`Name`,`class_id`) VALUES
-- ('','','');
-- INSERT INTO `Class` (`id`,`Name`,`Health`,`Strength`,`Dexterity`) VALUES
-- ('','','','','');
-- INSERT INTO `bandit_items` (`id`,`bandit_id`,`item_id`,`Quanity`) VALUES
-- ('','','','');
-- INSERT INTO `item` (`id`,`Name`,`Type`) VALUES
-- ('','','');
