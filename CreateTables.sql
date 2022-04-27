CREATE TABLE StudentInfo(
	StuID VARCHAR(10) UNIQUE NOT NULL,
	StuName VARCHAR(10) NOT NULL,
	Sex VARCHAR(6) CHECK (Sex = 'Male' OR Sex = 'Female') NOT NULL,
	EntAge INT CHECK (EntAge >= 10 AND EntAge <= 50) NOT NULL,
	EntYear INT CHECK (EntYear >= 2018 AND EntYear <= 2022) NOT NULL,
	StuGrade INT CHECK (StuGrade >= 1 AND StuGrade <= 4) NOT NULL,
	Class VARCHAR(20) CHECK (Class = 'International' OR Class = 'Excellent Engineer' OR Class = 'Innovation') NOT NULL
	PRIMARY KEY (StuID)
)

CREATE TABLE TeacherInfo(
	TeacherID VARCHAR(5) NOT NULL,
	TeacherName VARCHAR(10) NOT NULL,
	TeachCourse VARCHAR(20) NOT NULL
	PRIMARY KEY (TeacherID)
)

CREATE TABLE CourseInfo(
	CourseID VARCHAR(7) NOT NULL,
	CourseName VARCHAR(20) NOT NULL,
	TeacherID VARCHAR(5) NOT NULL,
	Credit INT CHECK (Credit > 0 AND Credit < 7) NOT NULL,
	CourseGrade INT CHECK (CourseGrade >= 1 AND CourseGrade <= 4) NOT NULL,
	CancelYear INT NULL,
	PRIMARY KEY (CourseID),
	FOREIGN KEY (TeacherID) REFERENCES TeacherInfo
)

CREATE TABLE ChooseCourse(
	StuID VARCHAR(10) NOT NULL,
	CourseID VARCHAR(7) NOT NULL,
	TeacherID VARCHAR(5) NOT NULL,
	ChosenYear INT CHECK (ChosenYear >= 2018 AND ChosenYear <= 2022) NOT NULL,
	Score INT NULL,
	FOREIGN KEY (StuID) REFERENCES StudentInfo,
	FOREIGN KEY (TeacherID) REFERENCES TeacherInfo,
	FOREIGN KEY (CourseID) REFERENCES CourseInfo
)

CREATE TABLE StudentAuthority(
	StuID VARCHAR(10) UNIQUE NOT NULL,
	StuPassword VARCHAR(10) NOT NULL,
	PRIMARY KEY (StuID)
)

CREATE TABLE TeacherAuthority(
	TeacherID VARCHAR(5) NOT NULL,
	TeacherPassword VARCHAR(10) NOT NULL,
	PRIMARY KEY (TeacherID)
)

CREATE TABLE AdminAuthority(
	AdminID VARCHAR(7) NOT NULL,
	AdminPassword VARCHAR(10) NOT NULL,
	PRIMARY KEY (AdminID)
)