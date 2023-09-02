// 1. Создайте функцию, которая принимает кол-во сек и формат их в кол-во дней часов. Пример: 123456 ->'1 days 10 hours 17 minutes 36 seconds '

USE hw6; 

DELIMITER //

CREATE FUNCTION format_seconds(seconds INT) 
RETURNS VARCHAR(255)
DETERMINISTIC
BEGIN
    DECLARE days INT;
    DECLARE hours INT;
    DECLARE minutes INT;
    DECLARE formatted_string VARCHAR(255);

    SET days = seconds DIV 86400;
    SET seconds = seconds MOD 86400;
    SET hours = seconds DIV 3600;
    SET seconds = seconds MOD 3600;
    SET minutes = seconds DIV 60;
    SET seconds = seconds MOD 60;

    SET formatted_string = CONCAT(days, ' days ', hours, ' hours ', minutes, ' minutes ', seconds, ' seconds');

    RETURN formatted_string;
    
END //

DELIMITER ;

SELECT format_seconds(1000000);



// 2. Выведите только четные числа от 1 до 10 (Через цикл).
Пример: 2,4,6,8,10

DELIMITER // 

SET @num = 1;
WHILE @num <= 10 DO
    IF @num % 2 = 0 THEN
        SELECT @num;
    END IF;

    SET @num = @num + 1;
END WHILE //

DELIMITER ; 

SELECT @num; 


