SELECT * FROM practicegb55.mobilephones;
-- Задание 2
SELECT * From practicegb55.mobilephones where productcount > 2; 

-- Задание 3
SELECT * FROM practicegb55.mobilephones where manufacturer = 'samsung'; 

-- Задание 4.1
SELECT * 
FROM practicegb55.mobilephones 
where manufacturer LIKE 'iphone%';

-- Задание 4.2
SELECT * 
FROM practicegb55.mobilephones 
where manufacturer LIKE 'Samsung%';

-- задание 4.3
SELECT *
FROm practicegb55.mobilephones
WHERE productname REGEXP '[0-9]+$';

-- задание 4.4
SELECT * 
FROM practicegb55.mobilephones
where productname like '%8%'; 
