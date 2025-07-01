create database KimNgocTam_2310900094
go

use KimNgocTam_2310900094
go

create table kntEmployee (
	kntEmpId bigint primary key not null,
	kntEmpName nvarchar(255) not null,
	kntEmpLevel nvarchar(150) not null,
	kntEmpStartDate date not null,
	kntEmpStatus bit not null
)

insert into kntEmployee values(231090094, N'Kim Ngọc Tâm', N'Intern	', '2025-07-20', 0),
(1, N'Nguyễn Văn A', N'Intern', '2025-07-20', 0),
(2, N'Trần Văn B', N'Senior', '2024-06-02', 1)

