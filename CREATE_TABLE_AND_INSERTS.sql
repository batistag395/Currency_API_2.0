CREATE TABLE "Currency"
(
    "Id" SERIAL PRIMARY KEY,
    "Name" VARCHAR(80),
);

INSERT INTO "Currency" ("Name", "Rate")
VALUES('USD', 5.0);

INSERT INTO "Currency" ("Name", "Rate")
VALUES('JPY', 0.37);

INSERT INTO "Currency" ("Name", "Rate")
VALUES('EUR', 6.0);

INSERT INTO "Currency" ("Name", "Rate")
VALUES('GBP', .0);

INSERT INTO "Currency" ("Name")
VALUES('BRL');

CREATE TABLE "Product"
(
	"ProductName" VARCHAR(150) NOT NULL,
	"Price" DECIMAL NOT NULL,
	"IdCurrency" INT NOT NULL,
	
	CONSTRAINT "FK_PRODUCT_CURRENCY" FOREIGN KEY ("IdCurrency") REFERENCES "Currency" ("Id")
);
INSERT INTO "Product" ("ProductName", "Price", "IdCurrency")
VALUES('Ipad', 5400, 5)

CREATE TABLE "Adress"(
		"Id" SERIAL PRIMARY KEY,
		"IdUser" int not nul,
		"cep" varchar(25) not null,
		"logradouro" varchar(200) not null,
		"complemento" varchar(200) not null,
		"bairro":  varchar(50) not null,
		"localidade" varchar(50) not null,
		"uf": char(3) not null,
		"ibge":  varchar(100) not null,
		"gia":  varchar(100) not null,
		"ddd":  varchar(5) not null,
		"siafi":  varchar(100) not null,

	CONSTRAINT "FK_ADRESS_USER" FOREIGN KEY ("IdUser") REFERENCES "User" ("Id")

)