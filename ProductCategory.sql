-- MS SQL
CREATE TABLE Product(ID int, name varchar, PRIMARY KEY (ID));
CREATE TABLE Category(ID int, name varchar, PRIMARY KEY (ID));
CREATE TABLE ProductCategory(ID int, ProductId int, CategoryId int, PRIMARY KEY (ID), FOREIGN KEY (ProductId) REFERENCES Product(ID), FOREIGN KEY (CategoryId) REFERENCES Category(ID));

INSERT INTO Product (ID, name)
VALUES (0, 'Утка'), 
	   (1, 'Кошка'), 
	   (2, 'Бутылка'), 
	   (3, 'Чайник'), 
	   (4, 'Лампочка'), 
	   (5, 'Лотерейный билет');

INSERT INTO Category (ID, name)
VALUES (0, 'Животные'), 
	   (1, 'Стеклянные изделия'), 
	   (2, 'Для дома'), 
	   (3, 'Автомобили'), 
	   (4, 'Освещение');

INSERT INTO ProductCategory (ID, ProductId, CategoryId)
VALUES (0, 0, 0), -- Утка - животное
	   (1, 1, 0), -- Кошка - животное 
       (2, 2, 1), -- Бутылка - Стеклянные изделия
       (3, 2, 2), -- Бутылка - Для дома
       (4, 3, 2), -- Чайник - Для дома 
       (5, 4, 1), -- Лампочка - Стеклянные изделия
       (6, 4, 4); -- Лампочка - Освещение
        
SELECT p.name as 'Продукт', c.name as 'Категория' FROM Product p 
LEFT JOIN ProductCategory pc on p.ID = pc.ProductId
LEFT JOIN Category c ON c.ID = pc.CategoryId
       
--Вывод
--=========================================
--||Продукт			||Категория
--||Утка			||Животные
--||Кошка			||Животные
--||Бутылка			||Стеклянные изделия
--||Бутылка			||Для дома
--||Чайник			||Для дома
--||Лампочка		||Стеклянные изделия
--||Лампочка		||Освещение
--||Лотерейный билет||	
--=========================================
--Для категории 'Автомобили' нету ни одного продукта и она не выводится