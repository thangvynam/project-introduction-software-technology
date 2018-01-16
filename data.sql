create database QLGiai
go
use QLGiai
go

create table CLB(
	MaCLB int not null primary key,
	TenCLB varchar(30),
	NamTL int,
	LichSu nvarchar(500),
	NhaThiDau nvarchar(200),
	MauAo nvarchar(50),
	HLV nvarchar(50)
)



create table CauThu(
	MaCT int,
	MaCLB int,
	Ten nvarchar(50),
	ViTri char(30),
	CanNang int,
	ChieuCao int,
	constraint PK_CT primary key (MaCT)
)

create table LichThiDau(
	ngaythidau datetime,
	maCLB1 int,
	maCLB2 int,
	maTran int,
	maVong int,
	sanDau nvarchar(50),
	constraint PK_LTD primary key (maTran, maVong)
)

Alter table CauThu add constraint FK_CauThu_CLB foreign key (MaCLB) references  CLB(MaCLB)
go

insert into LichThiDau values (N'2017/08/19', 0, 5, 101, 1, N'NTD Can Tho');
insert into LichThiDau values (N'2017/09/05', 1, 4, 102, 1, N'Quân khu 5');
insert into LichThiDau values (N'2017/09/07', 2, 3, 103, 1, N'Bách Khoa');

insert into LichThiDau values (N'2017/09/09', 0, 4, 201, 2, N'NTD Can Tho');
insert into LichThiDau values (N'2017/09/11', 1, 3, 202, 2, N'Quân khu 5');
insert into LichThiDau values (N'2017/09/13', 2, 5, 203, 2, N'Bách Khoa');

insert into LichThiDau values (N'2017/09/19', 0, 3, 301, 3, N'NTD Can Tho');
insert into LichThiDau values (N'2017/09/21', 1, 2, 302, 3, N'Quân khu 5');
insert into LichThiDau values (N'2017/09/25', 4, 5, 303, 3, N'CIS');

insert into LichThiDau values (N'2017/09/30', 0, 2, 401, 4, N'NTD Can Tho');
insert into LichThiDau values (N'2017/10/05', 1, 5, 402, 4, N'Quân khu 5');
insert into LichThiDau values (N'2017/10/06', 3, 4, 403, 4, N'Hồ Xuân Hương');

insert into LichThiDau values (N'2017/10/08', 0, 1, 501, 5, N'NTD Can Tho');
insert into LichThiDau values (N'2017/10/12', 2, 4, 502, 5, N'Bách Khoa');
insert into LichThiDau values (N'2017/10/15', 3, 5, 503, 5, N'Hồ Xuân Hương');

insert into LichThiDau values (N'2017/11/01', 5, 0, 601, 6, N'Su Pham');
insert into LichThiDau values (N'2017/11/05', 4, 1, 602, 6, N'CIS');
insert into LichThiDau values (N'2017/11/07', 3, 2, 603, 6, N'Hồ Xuân Hương');

insert into LichThiDau values (N'2017/11/19', 4, 0, 701, 7, N'CIS');
insert into LichThiDau values (N'2017/11/24', 3, 1, 702, 7, N'Hồ Xuân Hương');
insert into LichThiDau values (N'2017/11/30', 5, 2, 703, 7, N'Su Pham');

insert into LichThiDau values (N'2017/12/03', 3, 0, 801, 8, N'Hồ Xuân Hương');
insert into LichThiDau values (N'2017/12/09', 2, 1, 802, 8, N'Bách Khoa');
insert into LichThiDau values (N'2017/12/15', 5, 4, 803, 8, N'Su Pham');

insert into LichThiDau values (N'2017/12/19', 2, 0, 901, 9, N'Bách Khoa');
insert into LichThiDau values (N'2017/12/23', 5, 1, 902, 9, N'Su Pham');
insert into LichThiDau values (N'2017/12/25', 4, 3, 903, 9, N'CIS');

insert into LichThiDau values (N'2018/01/05', 1, 0, 1001, 10, N'Quân khu 5');
insert into LichThiDau values (N'2018/01/10', 4, 2, 1002, 10, N'CIS');
insert into LichThiDau values (N'2018/01/17', 5, 3, 1003, 10, N'Su Pham');

Insert into CLB values(005,'Thang Long Warriors',2017,
N'Đương kim vô địch Giải bóng rổ chuyên nghiệp Việt Nam - VBA 2017',
N'Nhà thi đấu Đại Học Sư Phạm Hà Nội',
N'Đỏ, Đen',N'Lee Tao Dana')
Insert into CLB values(000,'CanTho Catfish',2016,
N'Đội bóng rổ đại diện cho Khu vực Sông Mekong thi đấu tại VBA',
N'Nhà thi đấu Cần Thơ',
N'Xanh lá, Vàng',N'Kevin Yurkus')
Insert into CLB values(004,'SaiGon Heat',2011,
N'Saigon Heat được thành lập bởi Trung tâm Đào tạo Thể thao Sài Gòn (SSA), một đơn vị đào tạo nhiều môn thể thao tại TP Hồ Chí Minh được thành lập từ tháng 1 năm 2009. Cơ sở này do một Việt kiều, Connor Nguyễn (Nguyễn Tăng Cường) đầu tư. Khác với hầu hết các câu lạc bộ thể thao khác được duy trì bằng tiền của nhà nước, Saigon Heat "tự thân vận động" và thi đấu chuyên nghiệp trên đấu trường quốc tế.',
N'Nhà thi đấu Trường Quốc tế Canada',
N'Đỏ, Vàng',N'Anthony Garbelotto')
Insert into CLB values(002,'HaNoi Buffaloes',2016,
N'Đội bóng rổ Hanoi Buffaloes ra đời với nguồn lực sẵn có là những tài năng đã khẳng định được chỗ đứng, tinh thần đoàn kết chặt chẽ, chiến đấu vì màu cờ sắc áo thủ đô cùng quyết tâm khẳng định vị thế trong nền bóng rổ nước nhà.',
N'Nhà thi đấu Bách Khoa Hà Nội',
N'Xanh, Cam',N'Todd Purves')
Insert into CLB values(001,'DaNang Dragons',2016,
N'Đại diện duy nhất của bóng rổ khu vực miền Trung, đội bóng Danang Dragons luôn mang trong mình khao khát chiến thắng và ý chí kiên cường đậm khí chất của người dân nơi đây.',
N'Nhà thi đấu Quân Khu 5',
N'Cam, Đen',N'Donte Hill')
Insert into CLB values(003,'Hochiminh City Wings',2016,
N'Hochiminh City Wings tham dự VBA với sự tự tin tuyệt đối và mục tiêu chiến thắng ở mọi trận đấu, trở thành một thần tượng bóng rổ mới của thành phố.',
N'Nhà thi đấu TDTT Hồ Xuân Hương',
N'Tím, Vàng',N'Ricky Magallanes')

Insert into CauThu values(401,null,N'NGUYỄN HUỲNH HẢI','Shooting Guard',75,174)
Insert into CauThu values(402,null,N'PHẠM DUY HẬU','Shooting Guard',74,180)
Insert into CauThu values(403,null,N'VÕ HUY HOÀN','Power Forward',70,183)
Insert into CauThu values(404,null,N'HORACE NGUYỄN ','Shooting Guard',75,165)
Insert into CauThu values(405,null,N'STEFAN NGUYỄN','Power Forward',87,190)
Insert into CauThu values(406,null,N'LÊ NGỌC TÚ','Small Forward',75,182)
Insert into CauThu values(407,null,N'KIỀU PHÚ TỶ','Shooting Guard',70,176)
Insert into CauThu values(408,null,N'VÕ THÁI CƯỜNG','Small Guard',74,190)
Insert into CauThu values(409,null,N'VIET ARNOLD','Shooting Guard',88,192)
Insert into CauThu values(410,null,N'ANTHONY VO','Shooting Guard',84,188)

Update CauThu Set MaCLB = 004 Where MaCT = 401 
Update CauThu Set MaCLB = 004 Where MaCT = 402
Update CauThu Set MaCLB = 004 Where MaCT = 403 
Update CauThu Set MaCLB = 004 Where MaCT = 404 
Update CauThu Set MaCLB = 004 Where MaCT = 405
Update CauThu Set MaCLB = 004 Where MaCT = 406 
Update CauThu Set MaCLB = 004 Where MaCT = 407 
Update CauThu Set MaCLB = 004 Where MaCT = 408
Update CauThu Set MaCLB = 004 Where MaCT = 409 
Update CauThu Set MaCLB = 004 Where MaCT = 410 

Insert into CauThu values(501,null,N'BÙI THÁI HÀ','Shooting Guard',73,178)
Insert into CauThu values(502,null,N'TÔ QUANG TRUNG','Shooting Guard',80,180)
Insert into CauThu values(503,null,N'TRƯƠNG HOÀNG TRUNG','Power Forward',75,175)
Insert into CauThu values(504,null,N'NGUYỄN XUÂN QUỐC','Power Forward',78,187)
Insert into CauThu values(505,null,N'VŨ ĐÌNH TÚ','Small Forward',72,181)
Insert into CauThu values(506,null,N'ĐỖ XUÂN NAM','Shooting Guard',75,182)
Insert into CauThu values(507,null,N'NGUYỄN VĂN HÙNG','Center',90,195)
Insert into CauThu values(508,null,N'JUSTIN YOUNG','Power Forward',95,193)
Insert into CauThu values(509,null,N'PHAN MINH LUYẾN','Shooting Guard',79,182)
Insert into CauThu values(510,null,N'HOÀNG THẾ HIỂN','Small Forward',78,187)

Update CauThu Set MaCLB = 005 Where MaCT = 501 
Update CauThu Set MaCLB = 005 Where MaCT = 502
Update CauThu Set MaCLB = 005 Where MaCT = 503 
Update CauThu Set MaCLB = 005 Where MaCT = 504 
Update CauThu Set MaCLB = 005 Where MaCT = 505
Update CauThu Set MaCLB = 005 Where MaCT = 506 
Update CauThu Set MaCLB = 005 Where MaCT = 507 
Update CauThu Set MaCLB = 005 Where MaCT = 508
Update CauThu Set MaCLB = 005 Where MaCT = 509 
Update CauThu Set MaCLB = 005 Where MaCT = 510 


Insert into CauThu values(201,null,N'ĐINH TIẾN CÔNG','Power Forward',72,186)
Insert into CauThu values(202,null,N'NGUYỄN THÀNH ĐẠT','Shooting Guard',68,174)
Insert into CauThu values(203,null,N'VINCENT NGUYEN','Point Guard',80,180)
Insert into CauThu values(204,null,N'ĐẶNG THÁI HƯNG','Center',78,185)
Insert into CauThu values(205,null,N'NGUYỄN PHÚ HOÀNG','Shooting Guard',67,174)
Insert into CauThu values(206,null,N'PHẠM THANH TÙNG','Center',90,188)
Insert into CauThu values(207,null,N'NGUYỄN VĂN HÙNG','Center, Power Forward',85,190)
Insert into CauThu values(208,null,N'ĐỖ HUY HOÀNG','Shooting Guard, Small Forward',78,182)

Update CauThu Set MaCLB = 002 Where MaCT = 201 
Update CauThu Set MaCLB = 002 Where MaCT = 202
Update CauThu Set MaCLB = 002 Where MaCT = 203 
Update CauThu Set MaCLB = 002 Where MaCT = 204 
Update CauThu Set MaCLB = 002 Where MaCT = 205
Update CauThu Set MaCLB = 002 Where MaCT = 206 
Update CauThu Set MaCLB = 002 Where MaCT = 207 
Update CauThu Set MaCLB = 002 Where MaCT = 208

Insert into CauThu values(001,null,N'NGUYỄN LÊ QUỐC CƯỜNG','Small Forward',72,186)
Insert into CauThu values(002,null,N'HUỲNH THANH TÂM','Center',68,174)
Insert into CauThu values(003,null,N'HOÀNG NGUYỄN TẤN DŨNG','Power Forward',82,188)
Insert into CauThu values(004,null,N'DƯ MINH AN','Power Forward, Small Forward',78,180)
Insert into CauThu values(005,null,N'NGUYỄN NGỌC THÀNH','Shooting Guard',67,174)
Insert into CauThu values(006,null,N'SANG DINH','Center',68,185)
Insert into CauThu values(007,null,N'LÊ VĂN ĐẦY','Small Forward',73,185)
Insert into CauThu values(008,null,N'LÂM THANH CẢNH','Shooting Guard, Small Forward',70,177)
Insert into CauThu values(009,null,N'NGUYỄN VŨ BÌNH NGUYÊN','Shooting Guard, Small Forward',72,175)
Insert into CauThu values(010,null,N'DE ANGELO HAMILTON','Center',105,203)



Update CauThu Set MaCLB = 000 Where MaCT = 001
Update CauThu Set MaCLB = 000 Where MaCT = 002
Update CauThu Set MaCLB = 000 Where MaCT = 003
Update CauThu Set MaCLB = 000 Where MaCT = 004
Update CauThu Set MaCLB = 000 Where MaCT = 005
Update CauThu Set MaCLB = 000 Where MaCT = 006 
Update CauThu Set MaCLB = 000 Where MaCT = 007 
Update CauThu Set MaCLB = 000 Where MaCT = 008
Update CauThu Set MaCLB = 000 Where MaCT = 009
Update CauThu Set MaCLB = 000 Where MaCT = 010


Insert into CauThu values(101,null,N'HORACE NGUYEN','Guard',80,185)
Insert into CauThu values(102,null,N'ĐÀM HUY ĐẠI','Shooting Guard',74,176)
Insert into CauThu values(103,null,N'VÕ VĂN MỸ','Small Forward',73,188)
Insert into CauThu values(104,null,N'LÊ PHƯỚC THẮNG ','Center',75,170)
Insert into CauThu values(105,null,N'TRẦN TIẾN THỊNH','Power Forward',77,177)
Insert into CauThu values(106,null,N'TIM WAALE','Center,Power Forward',86,190)
Insert into CauThu values(107,null,N'NGUYỄN HOÀNG TUẤN','Power Forward',75,176)
Insert into CauThu values(108,null,N'PHẠM TẤN HOÀNG NGUYÊN','Power Forward',80,192)
Insert into CauThu values(109,null,N'RUDOLPHE JOLY','Center',88,192)
Insert into CauThu values(110,null,N'STEFAN NGUYEN','Guard',84,188)

Update CauThu Set MaCLB = 001 Where MaCT = 101 
Update CauThu Set MaCLB = 001 Where MaCT = 102
Update CauThu Set MaCLB = 001 Where MaCT = 103 
Update CauThu Set MaCLB = 001 Where MaCT = 104 
Update CauThu Set MaCLB = 001 Where MaCT = 105
Update CauThu Set MaCLB = 001 Where MaCT = 106 
Update CauThu Set MaCLB = 001 Where MaCT = 107 
Update CauThu Set MaCLB = 001 Where MaCT = 108
Update CauThu Set MaCLB = 001 Where MaCT = 109 
Update CauThu Set MaCLB = 001 Where MaCT = 110 


Insert into CauThu values(301,null,N'TRIỆU HÁN MINH','Shooting Guard',86,188)
Insert into CauThu values(302,null,N'NGÔ TUẤN TRUNG','Power Forward',85,190)
Insert into CauThu values(303,null,N'CHONG PAUL','Power Forward',70,180)
Insert into CauThu values(304,null,N'LÊ CÔNG TUẤN ANH ','Center',75,178)
Insert into CauThu values(305,null,N'NGUYỄN THÀNH NHÂN','Power Forward',72,171)
Insert into CauThu values(306,null,N'NGUYỄN LÂM ANH DUY','Small Forward,Power Forward',80,180)
Insert into CauThu values(307,null,N'HOÀNG NGUYỄN TUẤN DŨNG','Small Forward,Power Forward',71,174)
Insert into CauThu values(308,null,N'NGUYỄN KỲ QUAN','Small Forward',75,183)
Insert into CauThu values(309,null,N'NGUYỄN QUỐC THANH','Shooting Guard',74,175)
Insert into CauThu values(310,null,N'LÊ TRẦN ĐĂNG HUỲNH','Power Forward',78,183)

Update CauThu Set MaCLB = 003 Where MaCT = 301 
Update CauThu Set MaCLB = 003 Where MaCT = 302
Update CauThu Set MaCLB = 003 Where MaCT = 303 
Update CauThu Set MaCLB = 003 Where MaCT = 304 
Update CauThu Set MaCLB = 003 Where MaCT = 305
Update CauThu Set MaCLB = 003 Where MaCT = 306 
Update CauThu Set MaCLB = 003 Where MaCT = 307 
Update CauThu Set MaCLB = 003 Where MaCT = 308
Update CauThu Set MaCLB = 003 Where MaCT = 309 
Update CauThu Set MaCLB = 003 Where MaCT = 310 


select *
from LichThiDau where maVong=10

select MaCLB,count(*)
from CauThu
group by MaCLB

