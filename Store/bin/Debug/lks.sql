-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Agu 2019 pada 05.02
-- Versi server: 10.1.38-MariaDB
-- Versi PHP: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lks`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `detailtrx`
--

CREATE TABLE `detailtrx` (
  `trxid` char(11) DEFAULT NULL,
  `productid` char(10) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `buyprice` int(11) DEFAULT NULL,
  `sellprice` int(11) DEFAULT NULL,
  `promoid` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `detailtrx`
--

INSERT INTO `detailtrx` (`trxid`, `productid`, `qty`, `buyprice`, `sellprice`, `promoid`) VALUES
('20190800001', 'PR0001', 3, 3000, 3000, NULL),
('20190800001', 'PR0003', 5, 5000, 7000, '2'),
('20190800001', 'PR0008', 1, 18500, 20000, NULL),
('20190800001', 'PR0007', 2, 7800, 8500, NULL),
('20190800002', 'PR0001', 5, 3000, 3000, NULL),
('20190800002', 'PR0007', 2, 7800, 8500, NULL),
('20190800002', 'PR0006', 4, 2200, 2700, NULL),
('20190800003', 'PR0003', 4, 5000, 7000, NULL),
('20190800004', 'PR0007', 3, 7800, 8500, NULL),
('20190800005', 'PR0001', 2, 3000, 3000, NULL),
('20190800005', 'PR0005', 5, 2500, 3000, '3'),
('20190800005', 'PR0003', 7, 5000, 7000, '2'),
('20190800006', 'PR0011', 1, 3000, 5000, NULL),
('20190800006', 'PR0012', 8, 1300, 2200, '5'),
('20190800007', 'PR0001', 4, 3000, 3000, NULL),
('20190800007', 'PR0011', 3, 3000, 5000, '6'),
('20190800007', 'PR0006', 10, 2200, 2700, NULL),
('20190800008', 'PR0001', 1, 3000, 3000, NULL),
('20190800008', 'PR0005', 1, 2500, 3000, NULL),
('20190800008', 'PR0002', 1, 3000, 5000, NULL),
('20190800009', 'PR0011', 1, 3000, 5000, NULL),
('20190800009', 'PR0012', 8, 1300, 2200, '5'),
('20190800010', 'PR0001', 100, 3000, 3000, NULL),
('20190800010', 'PR0002', 10, 3000, 5000, NULL),
('20190800011', 'PR0001', 4, 3000, 3000, NULL),
('20190800011', 'PR0005', 10, 2500, 3000, '3'),
('20190800012', 'PR0003', 5, 5000, 7000, '2'),
('20190800013', 'PR0005', 10, 2500, 3000, '3'),
('20190800014', 'PR0001', 2, 3000, 3000, NULL),
('20190800014', 'PR0005', 5, 2500, 3000, '3'),
('20190800014', 'PR0007', 1, 7800, 8500, NULL),
('20190800015', 'PR0005', 6, 2500, 3000, '3'),
('20190800015', 'PR0001', 4, 3000, 3000, NULL),
('20190800016', 'PR0001', 4, 3000, 3000, NULL),
('20190800016', 'PR0008', 5, 18500, 20000, '4'),
('20190800016', 'PR0005', 7, 2500, 3000, '3'),
('20190800016', 'PR0007', 2, 7800, 8500, NULL),
('20190800017', 'PR0001', 2, 3000, 3000, NULL),
('20190800017', 'PR0005', 7, 2500, 3000, '3'),
('20190800017', 'PR0008', 1, 18500, 20000, NULL),
('20190800018', 'PR0005', 10, 2500, 3000, '3'),
('20190800019', 'PR0001', 5, 3000, 3000, NULL),
('20190800019', 'PR0002', 2, 3000, 5000, NULL),
('20190800019', 'PR0003', 3, 5000, 7000, NULL),
('20190800019', 'PR0004', 7, 1000, 1500, NULL),
('20190800019', 'PR0005', 20, 2500, 3000, '3'),
('20190800019', 'PR0007', 1, 7800, 8500, NULL),
('20190800020', 'PR0003', 5, 5000, 7000, NULL),
('20190800020', 'PR0007', 5, 7800, 8500, NULL),
('20190800020', 'PR0012', 15, 1300, 2200, '5'),
('20190800020', 'PR0006', 5, 2200, 2700, NULL),
('20190800021', 'PR0011', 4, 3000, 5000, '6'),
('20190800022', 'PR0012', 5, 1300, 2200, '5'),
('20190800023', 'PR0005', 10, 2500, 3000, '3'),
('20190800023', 'PR0006', 5, 2200, 2700, NULL),
('20190800023', 'PR0008', 7, 18500, 20000, '4'),
('20190800023', 'PR0012', 10, 1300, 2200, '5'),
('20190800023', 'PR0007', 3, 7800, 8500, NULL),
('20190800024', 'PR0011', 2, 3000, 5000, '6'),
('20190800024', 'PR0005', 5, 2500, 3000, NULL),
('20190800025', 'PR0011', 2, 3000, 5000, '6'),
('20190800025', 'PR0012', 6, 1300, 2200, '5'),
('20190800026', 'PR0003', 5, 5000, 7000, NULL),
('20190800026', 'PR0001', 3, 3000, 3000, NULL),
('20190800026', 'PR0007', 1, 7800, 8500, NULL),
('20190800027', 'PR0011', 2, 3000, 5000, '6');

-- --------------------------------------------------------

--
-- Struktur dari tabel `employee`
--

CREATE TABLE `employee` (
  `employeeid` char(10) NOT NULL,
  `name` varchar(20) DEFAULT NULL,
  `position` varchar(20) DEFAULT NULL,
  `email` varchar(40) DEFAULT NULL,
  `password` varchar(10) DEFAULT NULL,
  `handphone` varchar(12) DEFAULT NULL,
  `birthdate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `employee`
--

INSERT INTO `employee` (`employeeid`, `name`, `position`, `email`, `password`, `handphone`, `birthdate`) VALUES
('EP20190001', 'Maya Nur Estiwati', 'Kasir', 'maya.esti@yahoo.com', 'Mm1234', '081999027786', '1998-08-13'),
('EP20190002', 'Lisa Amri', 'Kasir', 'lisa@gmail.com', 'Lisa01', '081355670010', '2001-01-01'),
('EP20190003', 'Adi Zaenul Mustaqim', 'Admin', 'adizaenul2000@gmail.com', 'Mamas09', '087720152906', '2000-08-21'),
('EP20190004', 'Liza Kumalasari', 'Admin', 'liza@gmail.com', 'Liza1234', '081908771098', '2000-03-28');

-- --------------------------------------------------------

--
-- Struktur dari tabel `headertrx`
--

CREATE TABLE `headertrx` (
  `trxid` char(11) NOT NULL,
  `date` date DEFAULT NULL,
  `employeeid` char(10) DEFAULT NULL,
  `memberid` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `headertrx`
--

INSERT INTO `headertrx` (`trxid`, `date`, `employeeid`, `memberid`) VALUES
('20190800001', '2019-08-14', 'EP20190001', NULL),
('20190800002', '2019-08-14', 'EP20190001', NULL),
('20190800003', '2019-08-14', 'EP20190001', NULL),
('20190800004', '2019-08-14', 'EP20190001', 'M201900006'),
('20190800005', '2019-08-15', 'EP20190001', NULL),
('20190800006', '2019-08-15', 'EP20190001', NULL),
('20190800007', '2019-08-15', 'EP20190001', 'M201900001'),
('20190800008', '2019-08-16', 'EP20190001', NULL),
('20190800009', '2019-08-16', 'EP20190001', 'M201900007'),
('20190800010', '2019-08-17', 'EP20190001', 'M201900008'),
('20190800011', '2019-08-17', 'EP20190001', NULL),
('20190800012', '2019-08-17', 'EP20190001', 'M201900004'),
('20190800013', '2019-08-17', 'EP20190001', 'M201900008'),
('20190800014', '2019-08-18', 'EP20190001', NULL),
('20190800015', '2019-08-18', 'EP20190001', NULL),
('20190800016', '2019-08-18', 'EP20190001', NULL),
('20190800017', '2019-08-18', 'EP20190001', 'M201900004'),
('20190800018', '2019-08-18', 'EP20190001', 'M201900008'),
('20190800019', '2019-08-18', 'EP20190001', 'M201900005'),
('20190800020', '2019-08-18', 'EP20190001', NULL),
('20190800021', '2019-08-18', 'EP20190001', NULL),
('20190800022', '2019-08-18', 'EP20190001', NULL),
('20190800023', '2019-08-19', 'EP20190001', 'M201900001'),
('20190800024', '2019-08-21', 'EP20190001', NULL),
('20190800025', '2019-08-21', 'EP20190001', 'M201900007'),
('20190800026', '2019-08-24', 'EP20190001', NULL),
('20190800027', '2019-08-24', 'EP20190001', NULL);

-- --------------------------------------------------------

--
-- Struktur dari tabel `member`
--

CREATE TABLE `member` (
  `memberid` char(10) NOT NULL,
  `name` varchar(20) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  `handphone` varchar(12) DEFAULT NULL,
  `expired` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `member`
--

INSERT INTO `member` (`memberid`, `name`, `email`, `handphone`, `expired`) VALUES
('M201900001', 'Liza Kumalasari', 'liza@gmail.com', '087720182905', '2019-08-31'),
('M201900002', 'Adi Zaenul Mustaqim', 'adizaenul2000@gmail.com', '087720152907', '2019-08-30'),
('M201900003', 'Lisa Amri Mubarokah', 'lisa.sa@gmail.com', '087712365500', '2019-08-22'),
('M201900004', 'Hartono Susanto', 'harto120@yahoo.com', '081988991023', '2019-08-29'),
('M201900005', 'Ali Hasan Azis', 'hasan@rocketmail.com', '081588756999', '2019-08-28'),
('M201900006', 'Silvia Wahyu Palupi', 'wahyu@gmail.com', '085100239870', '2019-08-21'),
('M201900007', 'Suyatno', 'yatno.yatno@yahoo.com', '087745620018', '2019-08-27'),
('M201900008', 'Ayuni Fitria', 'nia254@gmail.com', '081522364401', '2019-08-24'),
('M201900009', 'Hermenegildus Agus W', '4gus@yahoo.com', '081966358901', '2019-08-15'),
('M201900010', 'Mulia Sulistiyono', 'mulia@amikom.ac.id', '081322695540', '2019-08-18'),
('M201900011', 'Bambang', 'bambang@yahoo.com', '081900872687', '2019-08-16'),
('M201900012', 'Uyock Anggoro', 'uyock@yahoo.com', '0819000033', '2019-08-17');

-- --------------------------------------------------------

--
-- Struktur dari tabel `product`
--

CREATE TABLE `product` (
  `productid` char(10) NOT NULL,
  `name` varchar(20) DEFAULT NULL,
  `specification` varchar(15) DEFAULT NULL,
  `buyprice` int(11) DEFAULT NULL,
  `sellprice` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `product`
--

INSERT INTO `product` (`productid`, `name`, `specification`, `buyprice`, `sellprice`) VALUES
('PR0001', 'Teh Pucuk Harum', '100 ml', 3000, 3000),
('PR0002', 'Kinderjoy', '100 gram', 3000, 5000),
('PR0003', 'Lasegar Leci', '250 ml', 5000, 7000),
('PR0004', 'Sosis Ayam So Nice', '100 gram', 1000, 1500),
('PR0005', 'Sedap Mie Goreng', '250 gram', 2500, 3000),
('PR0006', 'Sedap Mie Rasa Soto', '250 gram', 2200, 2700),
('PR0007', 'Pillow Coklat', '300 gram', 7800, 8500),
('PR0008', 'Downy Lafender', '1000 ml', 18500, 20000),
('PR0009', 'HIT Anti Nyamuk', '50 gram', 1000, 1000),
('PR0010', 'Minyak Goreng Bimoli', '500 ml', 14500, 17200),
('PR0011', 'Pasta Gigi', '70 gram', 3000, 5000),
('PR0012', 'Mie Instant Goreng', '85 gram', 1300, 2200);

-- --------------------------------------------------------

--
-- Struktur dari tabel `promo`
--

CREATE TABLE `promo` (
  `promoid` char(10) NOT NULL,
  `productid` char(10) DEFAULT NULL,
  `buyqty` int(11) DEFAULT NULL,
  `type` varchar(10) DEFAULT NULL,
  `reward` int(11) DEFAULT NULL,
  `startdate` date DEFAULT NULL,
  `enddate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `promo`
--

INSERT INTO `promo` (`promoid`, `productid`, `buyqty`, `type`, `reward`, `startdate`, `enddate`) VALUES
('1', 'PR0007', 2, 'DISC', 1000, '2019-08-10', '2019-08-10'),
('2', 'PR0003', 5, 'DISC', 3500, '2019-08-10', '2019-08-17'),
('3', 'PR0005', 5, 'FREE', 2, '2019-08-14', '2019-08-20'),
('4', 'PR0008', 5, 'FREE', 1, '2019-08-10', '2019-08-22'),
('5', 'PR0012', 5, 'FREE', 2, '2019-08-15', '2019-08-29'),
('6', 'PR0011', 2, 'DISC', 1500, '2019-08-15', '2019-08-30');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `detailtrx`
--
ALTER TABLE `detailtrx`
  ADD KEY `productid` (`productid`),
  ADD KEY `promoid` (`promoid`),
  ADD KEY `trxid` (`trxid`);

--
-- Indeks untuk tabel `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`employeeid`);

--
-- Indeks untuk tabel `headertrx`
--
ALTER TABLE `headertrx`
  ADD PRIMARY KEY (`trxid`),
  ADD KEY `employeeid` (`employeeid`),
  ADD KEY `memberid` (`memberid`);

--
-- Indeks untuk tabel `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`memberid`);

--
-- Indeks untuk tabel `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`productid`);

--
-- Indeks untuk tabel `promo`
--
ALTER TABLE `promo`
  ADD PRIMARY KEY (`promoid`),
  ADD KEY `productid` (`productid`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `detailtrx`
--
ALTER TABLE `detailtrx`
  ADD CONSTRAINT `detailtrx_ibfk_2` FOREIGN KEY (`productid`) REFERENCES `product` (`productid`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detailtrx_ibfk_3` FOREIGN KEY (`promoid`) REFERENCES `promo` (`promoid`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detailtrx_ibfk_4` FOREIGN KEY (`trxid`) REFERENCES `headertrx` (`trxid`);

--
-- Ketidakleluasaan untuk tabel `headertrx`
--
ALTER TABLE `headertrx`
  ADD CONSTRAINT `headertrx_ibfk_1` FOREIGN KEY (`employeeid`) REFERENCES `employee` (`employeeid`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `headertrx_ibfk_2` FOREIGN KEY (`memberid`) REFERENCES `member` (`memberid`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `promo`
--
ALTER TABLE `promo`
  ADD CONSTRAINT `promo_ibfk_1` FOREIGN KEY (`productid`) REFERENCES `product` (`productid`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
