-- 1. Создаем БД
DROP DATABASE IF EXISTS hwsql3; -- Удаляем БД, если она существует 
CREATE DATABASE IF NOT EXISTS hwsql3; -- Создаем БД lesson3, если ее раньше не было

-- 2. Выбираем конкретную БД
USE hwsql3;


-- DECIMAL(общее количество знаков, количество знаков после запятой)
  -- DECIMAL(5,2) будут числа от -999.99 до 999.99
  -- это числа от -999999.99 до 999999.99


-- 3. Создание таблицы
CREATE TABLE IF NOT EXISTS salespeople (
  snum INT, 
  sname VARCHAR(45), 
  city VARCHAR(45), 
  comm decimal (3,2)
);

# Заполнение данными
INSERT salespeople (
  snum, sname, city, comm) 
VALUES 
  ("1001", "Peel", "London", 0.12),
  ("1002", "Serres", "San Jose", 0.13),
  ("1004", "Motika", "London", 0.11),
  ("1007", "Rifkin", "Barcelona", 0.15),
  ("1003", "Axelrod", "New York", 0.10);
  
  Select * from salespeople; 

CREATE TABLE IF NOT EXISTS customers (
  cnum INT, 
  cname VARCHAR(45), 
  ccity VARCHAR(45), 
  rating int,
  ssnum int not null
);

INSERT customers (
  cnum, cname, ccity, rating, ssnum) 
VALUES 
  ("2001", "Hoffman", "London", 100, 1001),
  ("2002", "Giovanni", "Rome", 200, 1003),
  ("2003", "Liu", "SanJose", 200, 1002),
  ("2004", "Grass", "Berlin", 300, 1002),
  ("2006", "Clemens", "London", 100, 1001),
  ("2008", "Cisneros", "SanJose", 300, 1007),
  ("2007", "Pereira", "Rome", 100, 1004);
  
  Select * from customers;

  SELECT city, sname, snum, comm FROM salespeople;
  
  SELECT rating, cname FROM customers WHERE ccity = 'SanJose';
  
  SELECT DISTINCT snum FROM salespeople;
  
  SELECT * FROM customers WHERE cname LIKE 'G%';
  
  CREATE TABLE Orders (
   onum INT,
   amt DECIMAL(10, 2),
   odate DATE,
   cnum INT,
   snum INT
);

INSERT INTO Orders (onum, amt, odate, cnum, snum)
VALUES 
    (3001, 18.69, '1990-03-10', 2008, 1007),
    (3003, 767.19, '1990-03-10', 2001, 1001),
    (3002, 1900.10, '1990-03-10', 2007, 1004),
    (3005, 5160.45, '1990-03-10', 2003, 1002),
    (3006, 1098.16, '1990-03-10', 2008, 1007),
    (3009, 1713.23, '1990-04-10', 2002, 1003),
    (3007, 75.75, '1990-04-10', 2004, 1002),
    (3008, 4723.00, '1990-05-10', 2006, 1001),
    (3010, 1309.95, '1990-06-10', 2004, 1002),
    (3011, 9891.88, '1990-06-10', 2006, 1001);
    
SELECT *
FROM Orders
WHERE amt > 1000;

SELECT MIN(amt)
FROM orders;

SELECT cname, ccity
FROM customers
WHERE rating > 100 AND ccity <> 'Rome';

SELECT *
FROM lesson3
ORDER BY salary DESC;
  
  
SELECT *
FROM lesson3
ORDER BY salary ASC
LIMIT 5;

SELECT post, salary 
FROM staff
GROUP BY post
HAVING salary > 100000;

