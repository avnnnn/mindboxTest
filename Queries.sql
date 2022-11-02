CREATE TABlE IF NOT EXISTS category(
  id integer PRIMARY key AUTOINCREMENT,
  name varchar(20)
);


CREATE TABlE IF NOT EXISTS product(
  id integer PRIMARY KEY AUTOINCREMENT,
  name varchar(20),
  categoryId integer,
  FOREIGN key(categoryId) REFERENCES category(id))

INSERT INTO category(categoryname) VALUES("first");
INSERT INTO category(categoryname) VALUES("second");
INSERT INTO category(categoryname) VALUES("third");

INSERT INTO product(productname, categoryid) VALUES("product1" ,1);
INSERT INTO product(productname, categoryid) VALUES("product2" ,1);
INSERT INTO product(productname, categoryid) VALUES("product3" ,1);
INSERT INTO product(productname, categoryid) VALUES("product4" ,2);
INSERT INTO product(productname, categoryid) VALUES("product5" ,2);
INSERT INTO product(productname, categoryid) VALUES("product6" ,3);
INSERT INTO product(productname) VALUES("product7");
INSERT INTO product(productname) VALUES("product8");

select productname as "Product Name", categoryname as "Category Name" 
from product p 
left join category c
on p.categoryId = c.id
