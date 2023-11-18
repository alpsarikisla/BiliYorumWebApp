--Uyeler
--Yonetici
--YoneticiTurleri
--Kategoriler
--Makaleler
--Yorumlar

CREATE DATABASE Biliyorum_DB
GO
USE Biliyorum_DB
GO
CREATE TABLE Uyeler
(
	ID int IDENTITY(1,1),
	Isim nvarchar(75) NOT NULL,
	Soyisim nvarchar(75),
	KullaniciAdi nvarchar(20) NOT NULL,
	Mail nvarchar(150) NOT NULL,
	Sifre nvarchar(20) NOT NULL,
	KayitTarihi date,
	Silinmis bit,
	Durum bit,
	CONSTRAINT pk_uye PRIMARY KEY(ID)
)
GO
CREATE TABLE YoneticiTurleri
(
	ID int IDENTITY(1,1),
	Isim nvarchar(50),
	CONSTRAINT pk_yoneticiTur PRIMARY KEY(ID)
)
GO
INSERT INTO YoneticiTurleri(Isim) VALUES ('Admin')
INSERT INTO YoneticiTurleri(Isim) VALUES ('Moderatör')
GO
CREATE TABLE Yoneticiler
(
	ID int IDENTITY(1,1),
	YoneticiTur_ID int,
	Isim nvarchar(75) NOT NULL,
	Soyisim nvarchar(75),
	KullaniciAdi nvarchar(20) NOT NULL,
	Mail nvarchar(150) NOT NULL,
	Sifre nvarchar(20) NOT NULL,
	KayitTarihi date,
	Silinmis bit,
	Durum bit,
	CONSTRAINT pk_yonetici PRIMARY KEY(ID),
	CONSTRAINT fk_yoneticiYoneticiTur FOREIGN KEY(YoneticiTur_ID)
	REFERENCES YoneticiTurleri(ID)
)
GO
INSERT INTO Yoneticiler(YoneticiTur_ID, Isim, Soyisim,KullaniciAdi,Mail,Sifre, KayitTarihi,Silinmis,Durum)
VALUES(1, 'Alp', 'Sarýkýþla', 'YetkiliAbi', 'yetkiliabi@hotmail.com','1234','2023-11-18', 0,1)
GO
CREATE TABLE Kategoriler
(
	ID int IDENTITY(1,1),
	Isim nvarchar(50),
	CONSTRAINT pk_kategori PRIMARY KEY(ID)
)
GO
CREATE TABLE Makaleler
(
	ID int IDENTITY(1,1),
	Kategori_ID int,
	Yazar_ID int,
	Baslik nvarchar(150),
	Ozet nvarchar(250),
	Icerik ntext,
	Resim nvarchar(75),
	EklemeTarih datetime,
	GoruntulemeSayi int,
	Silinmis bit,
	Durum bit,
	CONSTRAINT pk_makale PRIMARY KEY(ID),
	CONSTRAINT fk_makaleKategori FOREIGN KEY(Kategori_ID) REFERENCES Kategoriler(ID),
	CONSTRAINT fk_makaleYazar FOREIGN KEY(Yazar_ID) REFERENCES Yoneticiler(ID)
)
GO
CREATE TABLE Yorumlar
(
	ID int IDENTITY(1,1),
	Makale_ID int,
	Uye_ID int,
	Yonetici_ID int,
	Icerik nvarchar(500),
	YorumTarihi datetime,
	OnayTarihi datetime,
	Durum bit,
	CONSTRAINT pk_yorum PRIMARY KEY(ID),
	CONSTRAINT fk_yorumMakale FOREIGN KEY(Makale_ID) REFERENCES Makaleler(ID),
	CONSTRAINT fk_yorumUye FOREIGN KEY(Uye_ID) REFERENCES Uyeler(ID),
	CONSTRAINT fk_yorumYonetici FOREIGN KEY(Yonetici_ID) REFERENCES Yoneticiler(ID)
)

SELECT * FROM YoneticiTurleri
SELECT * FROM Yoneticiler
