-- grup by yapısı
--gruplandırma işlemi için kullanılan anahtar kelimedir asıl ortaya çıkış amacı avg, max,min,sum,count gibi aggregate fonksiyonlarla birlikte bağlı bulundukları
--kolonları da sorgu içine dahil etmektir.-

-- ülkelere göre çalışan sayımız nedir ?
select Country, COUNT(country) as 'ToplamCalısan' from Employees group by Country

--hangi kategoride kaç tane ürün var raporlayınız.
select CategoryID, COUNT(CategoryID) as 'Urun' from Products group by CategoryID

--çalışanlara göre almış oldukları sipariş sayılarını tersten sıralayınız
select EmployeeID, Count(OrderID) as 'Calısan' from Orders group by EmployeeID order by Calısan desc

--ülkelere göre sipariş sayılarını raporlayınız ve en cok sipariş veren 3 ülkeyi sıralayınız
select top 3 ShipCountry, Count(OrderID) as 'Sayi' from Orders group by ShipCountry order by Sayi desc

--Her bir kategoride ücret bazlı toplam ne kadarlık ürünüm vardır.
select Sum(UnitPrice*UnitsInStock) as toplam, CategoryID as 'kategori' from Products
group by CategoryID 

--hangi personel kaç satışta yer almıştır.
select *from orders
select EmployeeID, Count(*) as 'e' from Orders group by EmployeeID

--hangi müşteri kaç kere alışveriş yapmıştır
select CustomerID, Count(*) as 'c' from Orders group by CustomerID

--hangi tedarikçi hangi üründen kaç dolarlık ürünü mevcuttur.
select SupplierID, sum(UnitPrice*UnitsInStock) as 'toplam fiyat' , COUNT(*) as 'Ürün' from Products group by SupplierID order by SupplierID desc

--SUBQUERY
--iç içe select sorgularıdır
--içteki select sorgusundan gelen cevabın dıştaki select sorgusuna dahil edilerek bir sonuc dahilinde raporlarnmasına yardımcı olur
--having işleminin size cevap vermediği durumlarda kullanılır

--ortalama ücretin üzerinde yer alan ürünleri gösteriniz.
select ProductName, UnitPrice from Products
where UnitPrice > (select avg(UnitPrice) from Products)

--'NANCY' almış oldugu siparişlerin idlerini raporlayınız.
select * from Orders where EmployeeID = (select EmployeeID from Employees where FirstName = 'NANCY')