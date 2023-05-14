-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : dim. 14 mai 2023 à 15:23
-- Version du serveur : 5.7.41
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `ap2`
--
CREATE DATABASE IF NOT EXISTS `ap2` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `ap2`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int(2) NOT NULL,
  `datedebut` datetime NOT NULL,
  `idmotif` int(2) NOT NULL,
  `datefin` datetime DEFAULT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `FK_absence_motif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `idmotif`, `datefin`) VALUES
(5, '2023-01-05 06:06:40', 2, '2023-01-24 06:06:40'),
(7, '2022-11-22 07:10:28', 3, '2022-11-23 08:00:00'),
(2, '2023-09-13 02:45:36', 3, '2023-09-15 22:00:00'),
(9, '2022-06-23 16:01:32', 1, '2023-09-13 23:48:35'),
(2, '2022-09-28 11:32:37', 3, '2022-11-05 07:29:45'),
(3, '2022-04-22 01:22:37', 1, '2023-01-29 01:08:21'),
(9, '2022-02-13 18:11:07', 3, '2022-07-23 10:29:20'),
(1, '2023-01-26 15:07:33', 1, '2024-04-04 11:57:47'),
(7, '2022-08-05 17:06:13', 2, '2023-10-20 10:19:39'),
(10, '2022-01-29 14:22:04', 2, '2024-01-16 00:00:32'),
(9, '2022-12-25 23:53:07', 2, '2022-11-27 00:52:34'),
(1, '2022-03-14 22:06:26', 3, '2022-11-13 10:37:33'),
(2, '2023-06-19 06:04:27', 2, '2023-02-19 13:21:19'),
(3, '2022-10-25 23:24:25', 4, '2023-09-21 08:23:33'),
(6, '2023-09-09 20:57:03', 3, '2023-09-26 22:55:52'),
(8, '2022-03-24 22:03:12', 3, '2023-06-06 23:49:57'),
(2, '2022-02-10 12:51:01', 2, '2023-05-03 20:17:35'),
(7, '2022-06-14 04:37:52', 3, '2022-11-08 11:58:59'),
(9, '2022-09-11 17:09:11', 3, '2023-08-01 13:48:41'),
(1, '2022-12-06 13:06:27', 1, '2023-02-24 00:00:39'),
(5, '2022-12-07 11:44:59', 2, '2023-09-16 07:17:30'),
(1, '2022-10-15 17:05:57', 3, '2022-07-09 02:45:39'),
(7, '2022-12-21 13:18:07', 3, '2024-04-20 13:56:11'),
(6, '2022-02-20 22:30:43', 3, '2022-07-05 16:22:34'),
(4, '2023-04-06 07:33:39', 4, '2024-04-27 16:20:24'),
(7, '2023-11-15 18:55:32', 2, '2023-06-06 20:42:25'),
(10, '2023-02-15 09:35:17', 2, '2024-03-27 16:28:46'),
(2, '2023-11-02 10:22:32', 3, '2024-01-09 04:28:20'),
(7, '2022-07-18 09:59:28', 1, '2024-04-01 05:41:06'),
(2, '2022-02-16 15:08:45', 2, '2023-03-13 07:37:25'),
(10, '2023-10-02 03:53:45', 2, '2023-08-25 22:43:04'),
(8, '2023-12-05 12:00:00', 2, '2024-01-01 21:14:20'),
(5, '2023-04-20 22:12:20', 3, '2023-07-21 23:41:56'),
(5, '2022-04-06 02:45:25', 2, '2023-02-05 04:13:15'),
(9, '2022-01-30 14:04:27', 2, '2023-09-12 22:06:14'),
(4, '2023-04-14 05:59:05', 1, '2022-09-30 02:16:53'),
(4, '2023-10-06 12:01:48', 3, '2022-07-24 19:36:05'),
(6, '2022-06-13 12:17:18', 2, '2023-11-21 12:17:06'),
(9, '2023-11-17 16:20:23', 3, '2022-08-22 06:03:43'),
(4, '2023-02-15 17:26:21', 4, '2024-03-30 09:08:47'),
(2, '2022-06-19 00:29:51', 2, '2023-05-15 06:51:21'),
(4, '2022-04-02 06:00:56', 2, '2022-07-29 23:41:39'),
(7, '2023-05-27 23:34:07', 2, '2023-09-11 18:17:49'),
(7, '2022-05-27 22:45:34', 3, '2023-09-14 15:08:54'),
(9, '2023-02-02 13:32:44', 4, '2024-01-17 23:17:26'),
(7, '2023-05-09 19:18:13', 3, '2023-11-24 22:06:46'),
(3, '2022-03-02 21:38:05', 4, '2023-12-10 09:59:35'),
(7, '2023-02-08 10:09:49', 3, '2022-07-06 20:43:37'),
(4, '2024-02-29 06:32:33', 2, '2023-08-16 12:25:48'),
(2, '2022-09-16 20:14:37', 3, '2024-05-03 13:07:51'),
(10, '2022-06-26 00:27:45', 1, '2023-06-01 10:14:47'),
(7, '2022-11-04 21:04:03', 2, '2022-11-03 14:30:57'),
(2, '2022-06-12 00:26:38', 1, '2024-04-18 02:37:22'),
(3, '2022-04-02 20:05:44', 1, '2022-08-13 20:43:23'),
(2, '2023-07-02 21:58:07', 1, '2023-05-24 06:48:51'),
(5, '2023-09-02 14:19:17', 3, '2023-03-11 05:04:10'),
(7, '2023-04-20 22:44:40', 1, '2023-06-11 12:13:36'),
(8, '2022-11-04 04:32:25', 3, '2023-04-13 01:03:39'),
(7, '2022-10-31 16:00:35', 2, '2023-11-16 14:13:08'),
(4, '2022-09-25 15:58:49', 4, '2023-12-19 18:46:57'),
(2, '2023-02-17 19:15:36', 1, '2023-05-01 06:28:10'),
(6, '2023-04-26 14:37:15', 3, '2023-06-17 14:39:23'),
(2, '2022-03-22 20:51:05', 3, '2023-10-21 11:49:27'),
(4, '2022-10-03 20:52:45', 1, '2022-05-12 09:46:43'),
(8, '2023-10-20 04:16:22', 2, '2023-04-23 11:53:08'),
(4, '2023-08-25 22:31:48', 3, '2023-09-09 01:10:04'),
(5, '2022-01-27 12:13:42', 1, '2023-06-02 14:07:50'),
(10, '2023-03-16 15:51:14', 2, '2023-03-12 07:40:29'),
(7, '2024-01-22 22:04:37', 3, '2023-01-26 11:35:39');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int(2) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int(2) NOT NULL AUTO_INCREMENT,
  `idservice` int(2) NOT NULL,
  `nom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `FK_personnel_service` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `idservice`, `nom`, `prenom`, `tel`, `mail`) VALUES
(1, 1, 'Aaron', 'Barton', '0725789885', 'quis.arcu@google.edu'),
(2, 2, 'Armand', 'Wall', '0625778294', 'ante@yahoo.edu'),
(3, 1, 'Owen', 'Albert', '0225778478', 'mauris.magna.duis@icloud.net'),
(4, 2, 'Brian', 'Bartlett', '0625784785', 'quisque.ac@aol.net'),
(5, 3, 'Elliott', 'Powell', '0778542794', 'tristique.pharetra@protonmail.org'),
(6, 1, 'Kennan', 'Emerson', '0778489841', 'orci.adipiscing.non@google.edu'),
(7, 2, 'Mannix', 'Stokes', '0625488728', 'dolor@hotmail.net'),
(8, 2, 'Samuel', 'Edwards', '0549857414', 'gravida.praesent.eu@google.com'),
(9, 1, 'Pascal', 'Michel', '0245412847', 'Pmichel241@protonmail.com'),
(10, 3, 'JeanPatrick', 'Dupont', '0754568714', 'patrick@supastart.com');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('patrick', '6d572805340520a111a1edc2f24b9cdf27bc17cffb2cfdca0a8e3e3d9ff585ac');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int(2) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
--
-- Base de données : `habilitations`
--
CREATE DATABASE IF NOT EXISTS `habilitations` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `habilitations`;

-- --------------------------------------------------------

--
-- Structure de la table `developpeur`
--

DROP TABLE IF EXISTS `developpeur`;
CREATE TABLE IF NOT EXISTS `developpeur` (
  `iddeveloppeur` int(2) NOT NULL AUTO_INCREMENT,
  `idprofil` int(2) NOT NULL,
  `nom` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prenom` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `mail` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`iddeveloppeur`),
  KEY `FK_developpeur_profil` (`idprofil`)
) ENGINE=MyISAM AUTO_INCREMENT=21 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `developpeur`
--

INSERT INTO `developpeur` (`iddeveloppeur`, `idprofil`, `nom`, `prenom`, `tel`, `mail`, `pwd`) VALUES
(1, 5, 'Nolan', 'Rooney', '09 65 36 85 44', 'Vivamus.non@egestasSedpharetra.org', '71f90b7c03aad530eafa769b2ad97cb333ca6dd455fce1080bc0b302e4231220'),
(2, 2, 'Good', 'Lucy', '03 03 67 71 47', 'a.scelerisque@NullafacilisiSed.org', 'c939327ca16dcf97ca32521d8b834bf1de16573d21deda3bb2a337cf403787a6'),
(3, 3, 'Blevins', 'Abel', '06 21 51 89 92', 'ipsum.Phasellus@sociosqu.edu', '3b17e2b513a94fc551bcaa6f8abba00f4cb52db9f5828689b8f8fefd9aaaba48'),
(5, 1, 'Bailey', 'Burton', '09 70 53 44 50', 'Nunc.commodo.auctor@sollicitudinorci.org', 'ceb32b93931ce2ef0af1fcefb67c2e5ea38d67d3fb9424c53d53a0688381636f'),
(6, 3, 'Delacruz', 'Owen', '04 60 51 48 15', 'in.aliquet@risusodio.edu', '6bf96b25f549f6dc3ef7f491c7ed763357a9baae5f392dfa0bb5b5c92747b954'),
(7, 4, 'Garza', 'Jillian', '08 86 47 61 67', 'sem.eget.massa@hendreritconsectetuer.org', '2d49cda934944bfb136364f82d151585edfe3a78c9c988da451ea12a56fb956c'),
(9, 3, 'Booth', 'Ryder', '08 53 71 05 71', 'porttitor.tellus@risusvariusorci.net', '59a286a9bbb686814b08ffc09917162dd03cafd0f90982a7d37abbbd809a9e7e'),
(10, 2, 'Blackwell', 'Marte', '08 94 29 37 55', 'pellentesque@NulladignissimMaecenas.net', '1d39692d4ee10540bc02074e58a7fedcf00ec356a3f19ccd6d909bd9370394a8'),
(11, 1, 'Paul', 'Harding', '02 79 83 05 14', 'placerat.augue.Sed@Donecfelis.edu', '818b5cc5f21d3e6e4e6071c06294528d44595022218446d8b79304d2b766327a'),
(12, 5, 'Justice', 'Hamilton', '05 12 98 01 13', 'eros@sedpede.net', '5f9740dd7874801f460dfe0f92e5be0cf2cfd04088d7d5ab996c92a428d3ee8b'),
(13, 1, 'Laws', 'Yolanda', '05 69 69 73 20', 'elit@laciniaorci.edu', '9950fd2c5b1854dcf27d5f1c8cfcec3563c57694ba3ce6e4c3871c22836f8a50'),
(14, 1, 'Moon', 'Kaseem', '09 46 08 25 44', 'auctor@eu.edu', '5fc165254f4f817ba6f8b6f80c08b3174c0fea225398b5b84c17c0af975feacf'),
(17, 4, 'Barr', 'Wanda', '05 49 47 03 82', 'odio@Crasdolor.org', 'c0e17070d53e6b3362fa17221c1d501f7d7a76cacf69174d0a312a8159be6471'),
(19, 5, 'Valentine', 'Clinton', '05 08 28 27 67', 'id@atfringillapurus.edu', 'cef5c43e526793983cbd17f5c53ab76e48dc92584a83cbfa63820e82190fd8a5'),
(20, 1, 'Hendrix', 'Christian', '08 09 24 53 25', 'Nunc.quis@tinciduntDonec.ca', '0ceec16c3d3170168bd3acfd48748d95eb98992c15399cd9a495ec2212f71bc2');

-- --------------------------------------------------------

--
-- Structure de la table `fonctionnalite`
--

DROP TABLE IF EXISTS `fonctionnalite`;
CREATE TABLE IF NOT EXISTS `fonctionnalite` (
  `idfonctionnalite` int(2) NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idfonctionnalite`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `fonctionnalite`
--

INSERT INTO `fonctionnalite` (`idfonctionnalite`, `nom`) VALUES
(1, 'CSS'),
(2, 'HTML'),
(3, 'JavaScript'),
(4, 'PHP');

-- --------------------------------------------------------

--
-- Structure de la table `habilitation`
--

DROP TABLE IF EXISTS `habilitation`;
CREATE TABLE IF NOT EXISTS `habilitation` (
  `idfonctionnalite` int(2) NOT NULL,
  `idoperation` int(2) NOT NULL,
  `idprofil` int(2) NOT NULL,
  PRIMARY KEY (`idfonctionnalite`,`idoperation`,`idprofil`),
  KEY `FK_habilitation_operation` (`idoperation`),
  KEY `FK_habilitation_profil` (`idprofil`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `habilitation`
--

INSERT INTO `habilitation` (`idfonctionnalite`, `idoperation`, `idprofil`) VALUES
(1, 1, 1),
(1, 1, 2),
(1, 1, 3),
(1, 1, 4),
(1, 2, 2),
(1, 2, 3),
(1, 3, 5),
(2, 1, 1),
(2, 1, 2),
(2, 1, 3),
(2, 1, 4),
(2, 2, 3),
(2, 2, 4),
(2, 3, 5),
(3, 1, 1),
(3, 1, 2),
(3, 1, 3),
(3, 1, 4),
(3, 2, 3),
(3, 2, 4),
(3, 3, 5),
(4, 1, 1),
(4, 1, 2),
(4, 1, 3),
(4, 1, 4),
(4, 2, 4),
(4, 3, 5);

-- --------------------------------------------------------

--
-- Structure de la table `operation`
--

DROP TABLE IF EXISTS `operation`;
CREATE TABLE IF NOT EXISTS `operation` (
  `idoperation` int(2) NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idoperation`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `operation`
--

INSERT INTO `operation` (`idoperation`, `nom`) VALUES
(1, 'consulter'),
(2, 'modifier'),
(3, 'administrer');

-- --------------------------------------------------------

--
-- Structure de la table `profil`
--

DROP TABLE IF EXISTS `profil`;
CREATE TABLE IF NOT EXISTS `profil` (
  `idprofil` int(2) NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idprofil`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `profil`
--

INSERT INTO `profil` (`idprofil`, `nom`) VALUES
(1, 'stagiaire'),
(2, 'designer'),
(3, 'dev-front'),
(4, 'dev-back'),
(5, 'admin');
--
-- Base de données : `mlr1`
--
CREATE DATABASE IF NOT EXISTS `mlr1` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `mlr1`;
--
-- Base de données : `test`
--
CREATE DATABASE IF NOT EXISTS `test` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `test`;
--
-- Base de données : `teste2`
--
CREATE DATABASE IF NOT EXISTS `teste2` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `teste2`;

-- --------------------------------------------------------

--
-- Structure de la table `developpeur`
--

DROP TABLE IF EXISTS `developpeur`;
CREATE TABLE IF NOT EXISTS `developpeur` (
  `iddeveloppeur` int(2) NOT NULL AUTO_INCREMENT,
  `idprofil` int(2) NOT NULL,
  `nom` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prenom` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `mail` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`iddeveloppeur`),
  KEY `FK_developpeur_profil` (`idprofil`)
) ENGINE=MyISAM AUTO_INCREMENT=21 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `developpeur`
--

INSERT INTO `developpeur` (`iddeveloppeur`, `idprofil`, `nom`, `prenom`, `tel`, `mail`, `pwd`) VALUES
(1, 5, 'Nolan', 'Rooney', '09 65 36 85 44', 'Vivamus.non@egestasSedpharetra.org', '71f90b7c03aad530eafa769b2ad97cb333ca6dd455fce1080bc0b302e4231220'),
(2, 2, 'Good', 'Lucy', '03 03 67 71 47', 'a.scelerisque@NullafacilisiSed.org', 'c939327ca16dcf97ca32521d8b834bf1de16573d21deda3bb2a337cf403787a6'),
(3, 3, 'Blevins', 'Abel', '06 21 51 89 92', 'ipsum.Phasellus@sociosqu.edu', '3b17e2b513a94fc551bcaa6f8abba00f4cb52db9f5828689b8f8fefd9aaaba48'),
(4, 2, 'Levine', 'Ira', '02 04 78 08 64', 'ridiculus.mus@ligulaelitpretium.net', '3a0eb3ea56e7f5e8f6f87aa9710717f8f0330060f8517b4249dab182d9b9d9c8'),
(5, 1, 'Bailey', 'Burton', '09 70 53 44 50', 'Nunc.commodo.auctor@sollicitudinorci.org', 'ceb32b93931ce2ef0af1fcefb67c2e5ea38d67d3fb9424c53d53a0688381636f'),
(6, 3, 'Delacruz', 'Owen', '04 60 51 48 15', 'in.aliquet@risusodio.edu', '6bf96b25f549f6dc3ef7f491c7ed763357a9baae5f392dfa0bb5b5c92747b954'),
(7, 4, 'Garza', 'Jillian', '08 86 47 61 67', 'sem.eget.massa@hendreritconsectetuer.org', '2d49cda934944bfb136364f82d151585edfe3a78c9c988da451ea12a56fb956c'),
(8, 1, 'West', 'Quintessa', '02 70 51 65 26', 'morbi.tristique@neque.net', '41a6741e9a0faee34fec1fce082d6c634d48b44aee0d15bee819d12917073df8'),
(9, 3, 'Booth', 'Ryder', '08 53 71 05 71', 'porttitor.tellus@risusvariusorci.net', '59a286a9bbb686814b08ffc09917162dd03cafd0f90982a7d37abbbd809a9e7e'),
(10, 2, 'Blackwell', 'Martena', '08 94 29 37 55', 'pellentesque@NulladignissimMaecenas.net', '1d39692d4ee10540bc02074e58a7fedcf00ec356a3f19ccd6d909bd9370394a8'),
(11, 1, 'Paul', 'Harding', '02 79 83 05 14', 'placerat.augue.Sed@Donecfelis.edu', '818b5cc5f21d3e6e4e6071c06294528d44595022218446d8b79304d2b766327a'),
(12, 5, 'Justice', 'Hamilton', '05 12 98 01 13', 'eros@sedpede.net', '5f9740dd7874801f460dfe0f92e5be0cf2cfd04088d7d5ab996c92a428d3ee8b'),
(13, 1, 'Lawson', 'Yolanda', '05 69 69 73 20', 'elit@laciniaorci.edu', '9950fd2c5b1854dcf27d5f1c8cfcec3563c57694ba3ce6e4c3871c22836f8a50'),
(14, 1, 'Moon', 'Kaseem', '09 46 08 25 44', 'auctor@eu.edu', '5fc165254f4f817ba6f8b6f80c08b3174c0fea225398b5b84c17c0af975feacf'),
(15, 4, 'Solis', 'Justine', '03 82 07 14 43', 'penatibus@Utnec.co.uk', '7fc5e56ec97a6943a8e656a0b2480b92ed6bd25c8da6ec1775220ef925d79b7c'),
(16, 3, 'Stuart', 'Ingrid', '09 29 08 45 60', 'consectetuer.adipiscing@eget.edu', '74452134eb5884242a688cd5214e50595e950b8ac83de37d4c75ff7582b5a798'),
(17, 4, 'Barr', 'Wanda', '05 49 47 03 82', 'odio@Crasdolor.org', 'c0e17070d53e6b3362fa17221c1d501f7d7a76cacf69174d0a312a8159be6471'),
(18, 5, 'Parker', 'Brooke', '05 33 06 99 16', 'dui@ipsumcursus.co.uk', '92039f1a7ad82575787e314975b24ac559b72031e5b7f84702e75821225f2929'),
(19, 5, 'Valentine', 'Clinton', '05 08 28 27 67', 'id@atfringillapurus.edu', 'cef5c43e526793983cbd17f5c53ab76e48dc92584a83cbfa63820e82190fd8a5'),
(20, 1, 'Hendrix', 'Christian', '08 09 24 53 25', 'Nunc.quis@tinciduntDonec.ca', '0ceec16c3d3170168bd3acfd48748d95eb98992c15399cd9a495ec2212f71bc2');

-- --------------------------------------------------------

--
-- Structure de la table `fonctionnalite`
--

DROP TABLE IF EXISTS `fonctionnalite`;
CREATE TABLE IF NOT EXISTS `fonctionnalite` (
  `idfonctionnalite` int(2) NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idfonctionnalite`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `fonctionnalite`
--

INSERT INTO `fonctionnalite` (`idfonctionnalite`, `nom`) VALUES
(1, 'CSS'),
(2, 'HTML'),
(3, 'JavaScript'),
(4, 'PHP');

-- --------------------------------------------------------

--
-- Structure de la table `habilitation`
--

DROP TABLE IF EXISTS `habilitation`;
CREATE TABLE IF NOT EXISTS `habilitation` (
  `idfonctionnalite` int(2) NOT NULL,
  `idoperation` int(2) NOT NULL,
  `idprofil` int(2) NOT NULL,
  PRIMARY KEY (`idfonctionnalite`,`idoperation`,`idprofil`),
  KEY `FK_habilitation_operation` (`idoperation`),
  KEY `FK_habilitation_profil` (`idprofil`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `habilitation`
--

INSERT INTO `habilitation` (`idfonctionnalite`, `idoperation`, `idprofil`) VALUES
(1, 1, 1),
(1, 1, 2),
(1, 1, 3),
(1, 1, 4),
(1, 2, 2),
(1, 2, 3),
(1, 3, 5),
(2, 1, 1),
(2, 1, 2),
(2, 1, 3),
(2, 1, 4),
(2, 2, 3),
(2, 2, 4),
(2, 3, 5),
(3, 1, 1),
(3, 1, 2),
(3, 1, 3),
(3, 1, 4),
(3, 2, 3),
(3, 2, 4),
(3, 3, 5),
(4, 1, 1),
(4, 1, 2),
(4, 1, 3),
(4, 1, 4),
(4, 2, 4),
(4, 3, 5);

-- --------------------------------------------------------

--
-- Structure de la table `operation`
--

DROP TABLE IF EXISTS `operation`;
CREATE TABLE IF NOT EXISTS `operation` (
  `idoperation` int(2) NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idoperation`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `operation`
--

INSERT INTO `operation` (`idoperation`, `nom`) VALUES
(1, 'consulter'),
(2, 'modifier'),
(3, 'administrer');

-- --------------------------------------------------------

--
-- Structure de la table `profil`
--

DROP TABLE IF EXISTS `profil`;
CREATE TABLE IF NOT EXISTS `profil` (
  `idprofil` int(2) NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idprofil`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `profil`
--

INSERT INTO `profil` (`idprofil`, `nom`) VALUES
(1, 'stagiaire'),
(2, 'designer'),
(3, 'dev-front'),
(4, 'dev-back'),
(5, 'admin');
--
-- Base de données : `tp141`
--
CREATE DATABASE IF NOT EXISTS `tp141` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `tp141`;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
