use master

INSERT INTO StudentInfo 
VALUES
	('0000000001', 'Becky', 'Female', 19, 2019, 3, 'International'),
	('0000000002', 'Chad', 'Male', 20, 2019, 3, 'Excellent Engineer'),
	('0000000003', 'Richard', 'Male', 17, 2018, 4, 'Innovation'),
	('0000000004', 'Vivian', 'Female', 18, 2018, 4, 'International')

INSERT INTO TeacherInfo 
VALUES 
	('11111', 'Johnson', 'Database'), 
	('22222', 'Anderson', 'Algorithms'), 
	('33333', 'Miller', 'C++'), 
	('44444', 'Smith', 'AI')

INSERT INTO CourseInfo 
VALUES 
	('0000000', 'Database', '11111', 2, 2, 2024), 
	('1111111', 'Algorithms', '22222', 3, 2, NULL), 
	('2222222', 'C++', '33333', 2, 1, NULL), 
	('3333333', 'AI', '44444', 3, 3, 2023)

INSERT INTO ChooseCourse 
VALUES 
	('0000000001', '0000000', '11111', 2021, 60), 
	('0000000002', '1111111', '22222', 2020, 90), 
	('0000000003', '2222222', '33333', 2019, 74), 
	('0000000004', '3333333', '44444', 2020, 70)

INSERT INTO StudentAuthority 
VALUES 
	('0000000001', 'Becky'), 
	('0000000002', 'Chad'), 
	('0000000003', 'Richard'), 
	('0000000004', 'Vivian')

INSERT INTO TeacherAuthority 
VALUES 
	('11111', 'Johnson'), 
	('22222', 'Anderson'), 
	('33333', 'Miller'), 
	('44444', 'Smith')

INSERT INTO AdminAuthority 
VALUES 
	('00000', 'ADMIN')

SELECT * FROM StudentInfo
SELECT * FROM TeacherInfo
SELECT * FROM CourseInfo
SELECT * FROM ChooseCourse ORDER BY StuID
SELECT * FROM StudentAuthority
SELECT * FROM TeacherAuthority
SELECT * FROM AdminAuthority