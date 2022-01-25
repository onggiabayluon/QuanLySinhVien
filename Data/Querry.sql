CREATE DATABASE QUANLYSINHVIEN
GO

USE QUANLYSINHVIEN
GO

-- 1. SINHVIEN
-- 2. TAIKHOAN
-- 3. LOP
-- 4. KHOA
-- 5. MONHOC
-- 6. HOCPHAN
-- 7. HOCPHANMONHOC


-- 3. LOP
CREATE TABLE LOP (
 MALOP INT IDENTITY PRIMARY KEY
 , TENLOP NVARCHAR(100) NOT NULL
)
GO

-- 1. SINHVIEN
CREATE TABLE SINHVIEN (
 MASINHVIEN INT IDENTITY PRIMARY KEY
 , HOTEN NVARCHAR(100) NOT NULL
 , DIACHI NVARCHAR(100) NOT NULL
 , DIENTHOAI NVARCHAR(100) NOT NULL
 , MALOP INT NOT NULL
 , FOREIGN KEY (MALOP) REFERENCES DBO.LOP(MALOP)
)
GO


-- 2. TAIKHOAN
CREATE TABLE TAIKHOAN (
 MATAIKHOAN INT IDENTITY PRIMARY KEY
 , TENTAIKHOAN NVARCHAR(100) NOT NULL
 , MATKHAU NVARCHAR(100) NOT NULL
 , MASINHVIEN INT NOT NULL
 , FOREIGN KEY (MASINHVIEN) REFERENCES DBO.SINHVIEN(MASINHVIEN)
)
GO

-- 4. KHOA
CREATE TABLE KHOA (
 MAKHOA INT IDENTITY PRIMARY KEY
 , TENKHOA NVARCHAR(100) NOT NULL
)
GO


-- 5. MONHOC
CREATE TABLE MONHOC (
 MAMONHOC INT IDENTITY PRIMARY KEY
 , TENMONHOC NVARCHAR(100) NOT NULL
 , SOTINCHI INT NOT NULL
 , MAKHOA INT NOT NULL
 , FOREIGN KEY (MAKHOA) REFERENCES DBO.KHOA(MAKHOA)
)
GO


-- 6. HOCPHAN
CREATE TABLE HOCPHAN (
 MAHOCPHAN INT IDENTITY PRIMARY KEY
 , TENHOCPHAN NVARCHAR(100) NOT NULL
)
GO


-- 7. HOCPHANMONHOC
CREATE TABLE HOCPHANMONHOC (
 MAHOCPHAN INT NOT NULL
 , MAMONHOC INT NOT NULL
 , MASINHVIEN INT NOT NULL
 , UNIQUE (MAHOCPHAN, MAMONHOC, MASINHVIEN)
 , FOREIGN KEY (MAHOCPHAN) REFERENCES DBO.HOCPHAN(MAHOCPHAN)
 , FOREIGN KEY (MAMONHOC) REFERENCES DBO.MONHOC(MAMONHOC)
 , FOREIGN KEY (MASINHVIEN) REFERENCES DBO.SINHVIEN(MASINHVIEN)
)
GO

-- Insert new KHOA
INSERT INTO dbo.KHOA( TENKHOA )
VALUES  ( 
	      N'CONG NGHE THONG TIN' -- TENKHOA - nvarchar(100)
        )
        
        
-- Insert new MONHOC
INSERT INTO dbo.MONHOC( TENMONHOC, SOTINCHI, MAKHOA )
VALUES  ( 
	      N'Toan Cao Cap' , -- TENMONHOC - nvarchar(100)
          1 , -- SOTINCHI - int
          1  -- MAKHOA - int
        )
        
-- Insert new LOP
INSERT INTO dbo.LOP( TENLOP )
VALUES  ( 
	      N'DH19IT01'  -- TENLOP - nvarchar(100)
        )
        
-- Insert new SINHVIEN
INSERT INTO dbo.SINHVIEN( HOTEN , DIACHI , DIENTHOAI, MALOP)
VALUES  ( 
	      N'NGUYEN VAN A' , -- HOTEN - nvarchar(100)
          N'358 Le Duc Tho' , -- DIACHI - nvarchar(1000)
          N'0827362522' , -- DIENTHOAI - nvarchar(1000) 
          1  -- MALOP - int
        )
INSERT INTO dbo.SINHVIEN( HOTEN , DIACHI , DIENTHOAI, MALOP)
VALUES  ( 
	      N'NGUYEN VAN B' , -- HOTEN - nvarchar(100)
          N'313113 Le Duc Tho' , -- DIACHI - nvarchar(1000)
          N'0827362522' , -- DIENTHOAI - nvarchar(1000) 
          1  -- MALOP - int
        )

-- Insert new TAIKHOAN
INSERT INTO dbo.TAIKHOAN( TENTAIKHOAN , MATKHAU , MASINHVIEN)
VALUES  ( 
	      N'K9' , -- TENTAIKHOAN - nvarchar(100)
          N'1' , -- MATKHAU - nvarchar(1000)
          1  -- MASINHVIEN - int
        )
INSERT INTO dbo.TAIKHOAN( TENTAIKHOAN , MATKHAU , MASINHVIEN)
VALUES  ( 
		  N'staff' , -- TENTAIKHOAN - nvarchar(100)
          N'1' , -- MATKHAU - nvarchar(1000)
          2  -- MASINHVIEN - int
        )
GO

