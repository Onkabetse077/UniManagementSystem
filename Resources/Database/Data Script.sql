﻿CREATE TABLE users(
id INT PRIMARY KEY IDENTITY(1,1),
username VARCHAR(MAX) NULL,
password VARCHAR(MAX) NULL
);

SELECT * FROM users;

CREATE TABLE students
(
	id INT PRIMARY KEY IDENTITY(1,1),
	student_id VARCHAR(MAX) NULL,
	student_name VARCHAR(MAX) NULL,
	student_gender VARCHAR(MAX) NULL,
	student_address VARCHAR(MAX) NULL,
	student_grade VARCHAR(MAX) NULL,
	student_section VARCHAR(MAX) NULL,
	student_image VARCHAR(MAX) NULL,
	student_status VARCHAR(MAX) NULL,
	date_inserterd DATE NULL,
	date_updated DATE NULL,
	date_deleted DATE NULL
);

SELECT * FROM students;

CREATE TABLE teachers
(
	id INT PRIMARY KEY IDENTITY(1,1),
	teacher_id VARCHAR(MAX) NULL,
	teacher_name VARCHAR(MAX) NULL,
	teacher_gender VARCHAR(MAX) NULL,
	teacher_address VARCHAR(MAX) NULL,
	teacher_image VARCHAR(MAX) NULL,
	teacher_status VARCHAR(MAX) NULL,
	date_inserterd DATE NULL,
	date_updated DATE NULL,
	date_deleted DATE NULL
	);

	SELECT * FROM teachers;