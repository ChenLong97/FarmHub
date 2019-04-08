Create Database FarmHub;

Use FarmHub;

-- FARMER --

-- Đăng ký tài khoản -- ✔

-- Authentication -- 
Create Table USER_KIND
(
	Id_UserKind int not null primary key identity(1,1),
	Name_UserKind nvarchar(50)
	-- Foreign Key --
);

Create Table USER_AUTHENTICATION
(
	Id_User int not null primary key identity(1,1),
	Id_UserKind int,
	Name_User varchar(50),
	Password_User varchar(50),
	-- Foreign Key --
	Foreign Key (Id_UserKind) references USER_KIND(Id_UserKind)
);

Create Table FARMER 
(
	Id_Farmer int not null primary key identity(1,1),
	Id_User int,
	Name_Farmer nvarchar(50),
	Birthday_Farmer nvarchar(50),
	Gender_Farmer tinyint,
	Address_Farmer nvarchar(200),
	Telephone_Farmer nvarchar(10),
	Email_Farmer nvarchar(100),
	Image_Farmer varchar(200),
	Farm_Count tinyint,
	Is_Deleted bit,
	-- Foreign Key --
	Foreign Key (Id_User) references USER_AUTHENTICATION(Id_User)
);

-- Nhập thông tin nông trại -- ✔
Create Table FARM
(
	Id_Farm int not null primary key identity(1,1),
	Id_Farmer int,
	Name_Farm nvarchar(50),
	Address_Farm nvarchar(200),
	City_Farm nvarchar(50),
	Acreage int,
	Description_Farm nvarchar(250),
	Is_Deleted bit,
	-- Foreign Key --
	Foreign Key (Id_Farmer) references FARMER(Id_Farmer)
);

-- Nhập tiêu chí phân loại nông sản và thông tin các loại giống -- ✔
Create Table CLASSIFICATION
(
	Id_Classification int not null primary key identity(1,1),
	Name_Classification nvarchar(50),
	Packing_Specifications nvarchar(50),
	Color_Classification nvarchar(50),
	Weight_Classification decimal,
	Size_Classification nvarchar(50),
	Is_Deleted bit
	-- Foreign Key --
);

Create Table SEED
(
	Id_Seed int not null primary key identity(1,1),
	Name_Seed nvarchar(50),
	Code_Seed nvarchar(50),
	Is_Deleted bit
	-- Foreign Key -- 
);

-- Nhập thông tin nông sản sẽ trồng ở Nông Trại -- ✔
Create Table PRODUCT_KIND
(
	Id_ProductKind int not null primary key identity(1,1),
	Name_ProductKind nvarchar(50),
	Is_Deleted bit
);
-- Có các Kind_Product: Hạt các loại, Rau, Củ, Quả, Nấm

-- Nhập lịch thời vụ của Nông Trại -- ✔
Create Table CROP
(
	Id_Crop int not null primary key identity(1,1),
	Name_Crop nvarchar(50),
	Start_Time date,
	End_Time date,
	Harvest_StartTime date,
	Harvest_EndTime date,
	Quantity_Expected int,
	Is_Deleted bit,
	-- Foreign Key --
);

Create Table PRODUCT
(
	Id_Product int not null primary key identity(1,1),
	Id_Crop int,
	Id_Classification int,
	Id_Seed int,
	Id_ProductKind int,
	Name_Product nvarchar(50),
	Geography_Location nvarchar(50),
	Image_Product varchar(200),
	Is_Deleted bit,
	-- Foreign Key --
	Foreign Key (Id_Crop) references CROP(Id_Crop),
	Foreign Key (Id_Classification) references CLASSIFICATION(Id_Classification),
	Foreign Key (Id_Seed) references SEED(Id_Seed),
	Foreign Key (Id_ProductKind) references PRODUCT_KIND(Id_ProductKind)
);

-- Một Farm có thể trồng nhiều Product khác nhau, một Product có thể được trồng ở nhiều nông trại khác nhau => quan hệ nhiều nhiều
-- => Tạo bảng trung gian FarmDetail ✔
Create Table FARM_DETAIL
(
	Id_FarmDetail int not null primary key identity(1,1),
	Id_Farm int,
	Id_Product int,
	Is_Deleted bit,
	-- Foreign Key --
	Foreign Key (Id_Farm) references FARM(Id_Farm),
	Foreign Key (Id_Product) references PRODUCT(Id_Product)
);

-- Xem lịch sử giá giao dịch của các vụ mùa trước -- ✔
Create Table MARKET_TRANS_HIS
(
	Id_MarketTransHis int not null primary key identity(1,1),
	Id_Product int,
	City_Market nvarchar(50),
	Average_TransPrice int,
	Average_OfferPrice int,
	Average_PurchasePrice int,
	Product_SupplyQuantity int,
	From_Date date,
	To_Date date,
	-- Foreign Key --
	Foreign Key (Id_Product) references PRODUCT(Id_Product)
);

-- Đặt bán theo vụ mùa -- ✔
Create Table SALE_OFFER
(
	Id_SaleOffer int not null primary key identity(1,1),
	Id_Farm int,
	Date_SaleOffer date,
	Price_Offer int,
	Quantity_Offer int,
	Status_SaleOffer tinyint,
	Is_Deleted bit,
	-- Foreign Key --
	Foreign Key (Id_Farm) references FARM(Id_Farm)
);

-- Một SalesOffer có thể chứa nhiều nhu cầu bán từ nhiều Farm, một Farm có thể bán nhiều Product, một Product có thể được rao bán ở nhiều Farm
-- => Quan hệ nhiều nhiều => Tạo bảng SalesOfferDetail ✔
Create Table SALE_OFFER_DETAIL
(
	Id_SaleOfferDetail int not null primary key identity(1,1),
	Id_SaleOffer int,
	Id_Product int,
	Price_SaleOfferDetail int,
	Quantity_SaleOfferDetail int,
	Status_SaleOfferDetail tinyint,
	Is_Deleted bit,
	-- Foreign Key --
	Foreign Key (Id_SaleOffer) references SALE_OFFER(Id_SaleOffer),
	Foreign Key (Id_Product) references PRODUCT(Id_Product)
);

--TRADER--

-- Đăng ký tài khoản -- ✔
Create Table TRADER
(
	Id_Trader int not null primary key identity(1,1),
	Id_User int,
	Name_Trader nvarchar(50),
	Birthday_Trader nvarchar(50),
	Gender_Trader tinyint,
	Address_Trader nvarchar(200),
	Telephone_Trader nvarchar(10),
	Email_Trader nvarchar(100),
	Image_Trader varchar(200),
	Is_Deleted bit,
	-- Foreign Key --
	Foreign Key (Id_User) references USER_AUTHENTICATION(Id_User)
);

-- Đặt mua theo vụ mùa -- ✔
Create Table PURCHASE_OFFER
(
	Id_PurchasesOffer int not null primary key identity(1,1),
	Id_Trader int,
	Date_PurchaseOffer date,
	Price_Purchase int,
	Quantity_Purchase int,
	Status_PurchaseOffer tinyint,
	Is_Deleted bit,
	-- Foreign Key --
	Foreign Key (Id_Trader) references TRADER(Id_Trader),
);

Create Table PURCHASE_OFFER_DETAIL
(
	Id_PurchaseOfferDetail int not null primary key identity(1,1),
	Id_PurchasesOffer int,
	Id_Product int,
	Price_PurchaseOfferDetail int,
	Quantity_PurchaseOfferDetail int,
	Status_PurchaseOfferDetail tinyint,
	Is_Deleted bit,
	-- Foreign Key --
	Foreign Key (Id_PurchasesOffer) references PURCHASE_OFFER(Id_PurchasesOffer),
	Foreign Key (Id_Product) references PRODUCT(Id_Product)
);

-- Phiếu Mua Hàng -- ✔
Create Table TRANSACTION_ORDER
(
	Id_TransactionOrder int not null primary key identity(1,1),
	Id_SaleOfferDetail int,
	Id_PurchaseOfferDetail int,
	Id_Product int,
	Transaction_Date date,
	Transaction_Mass int,
	Transaction_Price int,
	Status_TransactionOrder tinyint,
	Is_Deleted bit,
	-- Foreign Key --
	Foreign Key (Id_SaleOfferDetail) references SALE_OFFER_DETAIL(Id_SaleOfferDetail),
	Foreign Key (Id_PurchaseOfferDetail) references PURCHASE_OFFER_DETAIL(Id_PurchaseOfferDetail),
	Foreign Key (Id_Product) references PRODUCT(Id_Product)
);
