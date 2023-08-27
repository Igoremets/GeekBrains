CREATE TABLE cars
(
	id INT NOT NULL PRIMARY KEY,
    name VARCHAR(45),
    cost INT
);

INSERT cars
VALUES
	(1, "Audi", 52642),
    (2, "Mercedes", 57127 ),
    (3, "Skoda", 9000 ),
    (4, "Volvo", 29000),
	(5, "Bentley", 350000),
    (6, "Citroen ", 21000 ), 
    (7, "Hummer", 41400), 
    (8, "Volkswagen ", 21600);
    
 SELECT *
FROM cars;
 
SELECT *
FROM cars_under_25000;

CREATE VIEW cars_under_25000 AS
SELECT *
FROM cars
WHERE cost <= 25000;

ALTER VIEW cars_under_25000
AS
SELECT *
FROM cars
WHERE cost <= 30000;

CREATE VIEW skoda_and_audi_cars AS
SELECT *
FROM cars
WHERE name IN ('Skoda', 'Audi');

SELECT *
FROM skoda_and_audi_cars;

CREATE TABLE train_schedule (
  train_id_integer int,
  station character varying(20),
  station_time_without_time_zone time,  
  time_to_next_station time
);

INSERT INTO train_schedule (train_id_integer, station, station_time_without_time_zone, time_to_next_station)
VALUES
  (110, 'San Francisco', '10:00:00', '00:54:00'),
  (110, 'Redwood City', '10:54:00', '00:08:00'),
  (110, 'Palo Alto', '11:02:00', '01:33:00'),
  (110, 'San Jose', '12:35:00', null),
  (120, 'San Francisco', '11:00:00', '01:49:00'),
  (120, 'Palo Alto', '12:49:00', '00:41:00'),
  (120, 'San Jose', '13:30:00', null);

SELECT *
FROM train_schedule;

SELECT *
FROM trainschedule;

DROP TABLE IF EXISTS train_schedule; 
DROP TABLE IF EXISTS trainschedule; 

CREATE TABLE trainschedule (
  train_id_integer int,
  station character varying(20),
  station_time_without_time_zone time  
);

INSERT INTO trainschedule (train_id_integer, station, station_time_without_time_zone)
VALUES
  (110, 'San Francisco', '10:00:00'),
  (110, 'Redwood City', '10:54:00'),
  (110, 'Palo Alto', '11:02:00'),
  (110, 'San Jose', '12:35:00'),
  (120, 'San Francisco', '11:00:00'),
  (120, 'Palo Alto', '12:49:00'),
  (120, 'San Jose', '13:30:00');

SELECT * FROM trainschedule;

ALTER TABLE trainschedule
ADD COLUMN timetonextstation time;

SELECT *, 
SUBTIME (
LEAD (station_time_without_time_zone, 1, 'null')
OVER (PARTITION BY train_id_integer ORDER BY station_time_without_time_zone),station_time_without_time_zone)
FROM trainschedule;

SELECT SUBTIME('15:30:00', '14:30:00');





  