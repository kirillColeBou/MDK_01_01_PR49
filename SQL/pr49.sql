-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Май 26 2024 г., 22:36
-- Версия сервера: 8.0.30
-- Версия PHP: 8.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `pr49`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Dishes`
--

CREATE TABLE `Dishes` (
  `Id` int NOT NULL,
  `Category` varchar(255) NOT NULL,
  `NameDish` varchar(255) NOT NULL,
  `Price` varchar(50) NOT NULL,
  `Icon` varchar(255) NOT NULL,
  `Version` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Dishes`
--

INSERT INTO `Dishes` (`Id`, `Category`, `NameDish`, `Price`, `Icon`, `Version`) VALUES
(1, 'йцу1', 'йцу1', '123', 'фывыв', 1),
(2, 'йцу2', 'йцу2', '1234', 'фывывфывфывфыв', 3);

-- --------------------------------------------------------

--
-- Структура таблицы `Order`
--

CREATE TABLE `Order` (
  `Id` int NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Date` date NOT NULL,
  `DishId` int NOT NULL,
  `Count` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Order`
--

INSERT INTO `Order` (`Id`, `Address`, `Date`, `DishId`, `Count`) VALUES
(1, 'qwe', '0001-01-01', 1, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `Users`
--

CREATE TABLE `Users` (
  `Id` int NOT NULL,
  `Login` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Token` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Users`
--

INSERT INTO `Users` (`Id`, `Login`, `Email`, `Password`, `Token`) VALUES
(1, 'asd', 'asd', 'asd', 'test'),
(3, 'asdf', 'asdf', 'asdf', 'dbdDCrEhvxwnrAH8');

-- --------------------------------------------------------

--
-- Структура таблицы `Versions`
--

CREATE TABLE `Versions` (
  `Id` int NOT NULL,
  `Version` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Versions`
--

INSERT INTO `Versions` (`Id`, `Version`) VALUES
(1, 'версия 1'),
(2, 'версия 2'),
(3, 'версия 3'),
(4, 'версия 4');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Dishes`
--
ALTER TABLE `Dishes`
  ADD PRIMARY KEY (`Id`);

--
-- Индексы таблицы `Order`
--
ALTER TABLE `Order`
  ADD PRIMARY KEY (`Id`);

--
-- Индексы таблицы `Users`
--
ALTER TABLE `Users`
  ADD PRIMARY KEY (`Id`);

--
-- Индексы таблицы `Versions`
--
ALTER TABLE `Versions`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Dishes`
--
ALTER TABLE `Dishes`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `Order`
--
ALTER TABLE `Order`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `Users`
--
ALTER TABLE `Users`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `Versions`
--
ALTER TABLE `Versions`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
