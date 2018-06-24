USE exercises;
DROP DATABASE IF EXISTS guitar_hub;
CREATE DATABASE guitar_hub;

USE guitar_hub;

CREATE TABLE guitar (
    serial_no int NOT NULL PRIMARY KEY,
    guitar_type varchar(8) NOT NULL,
    style varchar(80) NOT NULL,
    price decimal(9,2) NOT NULL,
    quantity int NOT NULL,
    tremolo varchar(1),
    pickup varchar(2),
    electric varchar(1),
    hollow varchar(4)  
);

CREATE TABLE guitar_types (
    guitar_type varchar(8) NOT NULL PRIMARY KEY,
    guitar_desc varchar(100) NOT NULL
);

CREATE TABLE orderitems (
	orderitems_id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    order_id int NOT NULL,
    serial_no int NOT NULL,
    price decimal(9,2) NOT NULL
);

CREATE TABLE orders (
    order_id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    order_date datetime NOT NULL,
    total_price decimal(9,2) NOT NULL,
    customer_name varchar(50) NOT NULL,
    customer_address varchar(50) NOT NULL,
    customer_phone varchar(15) NOT NULL,
    customer_email varchar(80) NOT NULL
);


INSERT INTO guitar VALUES (1001,'Electric','Telecaster',1399.00,3,'N','SC',null,null),
						  (1002,'Electric','Stratocaster',1199.00,6,'Y','HB',null,null),
						  (1003,'Acoustic','Fender',499.00,8,null,null,'N','Full'),
						  (1004,'Acoustic','Epiphone',699.00,12,null,null,'Y','Semi');

INSERT INTO guitar_types VALUES ('Electric','This is an electric guitar.'), ('Acoustic','This is an acoustic guitar.');

INSERT INTO orderitems (order_id,serial_no,price) VALUES (1,1001,1499.00), (1,1002,1199.00), (2,1002,1199.00), (3,1003,499.00), (4,1004,699.00);

INSERT INTO orders (order_date,total_price,customer_name,customer_address,customer_phone,customer_email) VALUES (6/01/18,2698.99,'Jerry Smith','92 Victory Road','020 012 9809','Jerry.Smith@gmail.com');
INSERT INTO orders (order_date,total_price,customer_name,customer_address,customer_phone,customer_email) VALUES (05/27/18,1199.99,'Smith Thomas','83 Grove Street','021 415 9697','Smith.Thomas@gmail.com');
INSERT INTO orders (order_date,total_price,customer_name,customer_address,customer_phone,customer_email) VALUES (02/20/18,499.00,'Thomas Ryan','74 Queens Avenue','029 077 2589','Thomas.Ryan@gmail.com');
INSERT INTO orders (order_date,total_price,customer_name,customer_address,customer_phone,customer_email) VALUES (02/03/18,699.00,'Ryan Brandt ','65 Cloverfield Lane','025 319 1236','Ryan.Brandt@gmail.com');

netsh http add urlacl url=http://+:60064/ user=desktop-avdkvqm\arnogrupp