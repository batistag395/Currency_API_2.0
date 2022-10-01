CREATE TABLE "Currency"
(
    "Id" SERIAL PRIMARY KEY,
    "Name" VARCHAR(80),
    "Rate" DECIMAL
);

INSERT INTO "Currency" ("Name", "Rate")
VALUES('USD', 5.0);

INSERT INTO "Currency" ("Name", "Rate")
VALUES('JPY', 0.37);

INSERT INTO "Currency" ("Name", "Rate")
VALUES('EUR', 6.0);

INSERT INTO "Currency" ("Name", "Rate")
VALUES('GBP', 7.0);

INSERT INTO "Currency" ("Name", "Rate")
VALUES('BRL', 1.0);

CREATE TABLE "Product"
(
	"ProductName" VARCHAR(150) NOT NULL,
	"Price" DECIMAL NOT NULL,
	"IdCurrency" INT NOT NULL,
	
	CONSTRAINT "FK_PRODUCT_CURRENCY" FOREIGN KEY ("IdCurrency") REFERENCES "Currency" ("Id")
);
INSERT INTO "Product" ("ProductName", "Price", "IdCurrency")
VALUES('Ipad', 5400, 5)
