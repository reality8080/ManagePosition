USE Person
CREATE TABLE Student(
	id varchar(20) PRIMARY KEY,
	name nvarchar(50),
	birth varchar(20),
	mssv varchar(20),
	grade varchar(50),
	status bit,
	password varchar(50),
	namecourse varchar(50),
	teacher varchar(50),
	score Decimal,
)