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
		"IdUser" int not null,
		"Cep" varchar(25) not null,
		"Logradouro" varchar(200) not null,
		"Numero" varchar(15) not null,
		"Complemento" varchar(200) not null,
		"Bairro"  varchar(50) not null,
		"Localidade" varchar(50) not null,
		"Uf" char(3) not null,
		"Ibge"  varchar(100) not null,
		"Gia"  varchar(100) not null,
		"DDD"  varchar(5) not null,
		"Siafi"  varchar(100) not null,

	CONSTRAINT "FK_ADRESS_USER" FOREIGN KEY ("IdUser") REFERENCES "User" ("Id")

)

CRETE TABLE "ProductData"(
		id serial PRIMARY KEY,
		idProduct int,
			peso varchar(255) not null,
			formato int,
			comprimento DECIMAL,
			altura DECIMAL,
			largura decimal,
			maoPropria varchar(1),
			valorDeclarado decimal,
			codServico varchar(10),
			diametro decimal,

			CONSTRAINT "FK_PRODUCTDATA_PRODUCT" FOREIGN KEY (idProduct) REFERENCES "Product" ("Id")
)

""peso"", ""formato"", ""comprimento"", ""altura"", ""largura"", ""maopropria"", ""valordeclarado"", ""codservico"", ""diametro""