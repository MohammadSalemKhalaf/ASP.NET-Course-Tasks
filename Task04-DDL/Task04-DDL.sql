--DDL
create database BikeStores;
use BikeStores;
GO
CREATE SCHEMA Production;
GO
CREATE SCHEMA Sales;
GO


CREATE TABLE Production.categories(
category_id int PRIMARY KEY IDENTITY(1,1),
category_name varchar(20)
);

CREATE TABLE Production.brands(
brand_id int PRIMARY KEY IDENTITY(1,1),
brand_name varchar(20)
);

CREATE TABLE Production.products (
    product_id INT PRIMARY KEY IDENTITY(1,1),
    product_name VARCHAR(20),
	brand_id INT,
    FOREIGN KEY (brand_id) REFERENCES Production.brands(brand_id),
     category_id int,
    FOREIGN KEY (category_id) REFERENCES Production.categories(category_id)

);


CREATE TABLE Production.stocks(
store_id int PRIMARY KEY IDENTITY(1,1),
product_id int,
    FOREIGN KEY (product_id) REFERENCES Production.products(product_id),
quantity int
);

CREATE TABLE Sales.customers(
customer_id int PRIMARY KEY IDENTITY(1,1),
first_name varchar(20) not null,
last_name varchar (20),
phone varchar(20),
email varchar(30),
street varchar(20),
city varchar(15),
state varchar(15),
zip_code varchar(20)
);

CREATE TABLE Sales.stores(
store_id int PRIMARY KEY IDENTITY(1,1),
store_name varchar(20) not null,
phone varchar(20),
email varchar(30),
street varchar(20),
city varchar(15),
state varchar(15),
zip_code varchar(20)
);

CREATE TABLE Sales.staffs(
staff_id int PRIMARY KEY IDENTITY(1,1),
first_name varchar(20) not null,
last_name varchar (20),
email varchar(30),
phone varchar(20),
active varchar(20),
store_id int,
    FOREIGN KEY (store_id) REFERENCES Sales.stores(store_id),
manager_id int,
    FOREIGN KEY (manager_id) REFERENCES Sales.staffs(staff_id)
);

CREATE TABLE Sales.orders(
order_id int PRIMARY KEY IDENTITY(1,1),
customer_id int,
    FOREIGN KEY (customer_id) REFERENCES Sales.customers(customer_id),
order_status varchar (20),
order_date varchar(30),
required_date varchar(20),
shipped_date varchar(20),
store_id int,
    FOREIGN KEY (store_id) REFERENCES Sales.stores(store_id),
staff_id int,
    FOREIGN KEY (staff_id) REFERENCES Sales.staffs(staff_id)
);

CREATE TABLE Sales.order_items(
order_id int,
item_id int,
    FOREIGN KEY (order_id) REFERENCES Sales.orders(order_id),
product_id int,
    FOREIGN KEY (product_id) REFERENCES Production.products(product_id),
quantity varchar(20),
list_price varchar(100),
discount varchar(30),
PRIMARY KEY (order_id,item_id)
);

DROP TABLE IF EXISTS Production.stocks;

CREATE TABLE Production.stocks (
    store_id INT,
    product_id INT,
    quantity INT,
    PRIMARY KEY (store_id, product_id),
    FOREIGN KEY (store_id) REFERENCES Sales.stores(store_id),
    FOREIGN KEY (product_id) REFERENCES Production.products(product_id)
);






