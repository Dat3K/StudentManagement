CREATE DATABASE StudentManagement;
USE StudentManagement;

CREATE TABLE Student (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE,
    Gender NVARCHAR(10),
    Address NVARCHAR(100),
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(50),
    EducationLevel NVARCHAR(50),
    Major NVARCHAR(50),
    WorkExperience NVARCHAR(50),
    Language NVARCHAR(50)
);

INSERT INTO Student (FullName, DateOfBirth, Gender, Address, PhoneNumber, Email, EducationLevel, Major, WorkExperience, Language) 
VALUES 
    (N'Nguyễn Văn A', '2000-01-01', N'Nam', N'Hà Nội', '0987654321', 'nguyenvana@gmail.com', N'Đại học', N'Công nghệ thông tin', N'1 năm', N'Tiếng Anh'),
    (N'Trần Thị B', '2001-05-10', N'Nữ', N'Hà Nam', '0912345678', 'tranthib@gmail.com', N'Cao đẳng', N'Kế toán', N'2 năm', N'Tiếng Anh'),
    (N'Lê Văn C', '1999-12-30', N'Nam', N'Hồ Chí Minh', '0967890123', 'levanc@gmail.com', N'Trung cấp', N'Điện tử viễn thông', N'3 năm', N'Tiếng Trung'),
    (N'Phạm Thị D', '2000-07-20', N'Nữ', N'Hải Phòng', '0945678901', 'phamthid@gmail.com', N'Đại học', N'Luật', N'1 năm', N'Tiếng Anh'),
    (N'Hoàng Văn E', '2002-03-15', N'Nam', N'Ninh Bình', '0912345678', 'hoangvane@gmail.com', N'Cao đẳng', N'Cơ khí', N'2 năm', N'Tiếng Nhật');
 select * from Student
 delete from Student