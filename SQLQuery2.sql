USE Human
CREATE TABLE person(
	id nvarchar(50) PRIMARY KEY,
	name nvarchar(50),
	age int,
	birthday varchar(15),
	sick nvarchar(50),
	status BIT,
)
CREATE TABLE student(
	id nvarchar(50),
	mssv nvarchar(50) PRIMARY KEY,
	grade nvarchar(50),
	score decimal,
	FOREIGN KEY (id) REFERENCES person(id)

)
CREATE TABLE teacher(
	id nvarchar(50),
	mscb nvarchar(50) PRIMARY KEY,
	subject nvarchar(50),
	education nvarchar(50),
	FOREIGN KEY (id) REFERENCES person(id)
)
CREATE TABLE coure(
	courseName nvarchar(50),
	 mssv int PRIMARY KEY,
	 credit int,
	 teacher nvarchar(50)
	 FOREIGN KEY (mssv) REFERENCES student(mssv)
)