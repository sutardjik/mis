# School MIS
Written in C# using Visual Studio Windows Forms for UI and SQL for database creation using MSSQL Server Management Studio performing CRUD operations.

### Tables
* StudentInfo
* TeacherInfo
* CourseInfo
* ChooseCourse
* StudentAuthority
* TeacherAuthority
* AdminAuthority
--------------------
#### Student's interface functionalities
* Choose course to enroll in
* Query personal info
* Query course choosing info
* Query score — all enrolled courses

#### Teacher's interface functionalities
* Query personal info 
* Query course score — all students enrolled in such course
* Query average course score
* Modify a student's score

#### Administrator's interface functionalities
* Query student personal info — collective and individual
* Query teacher personal info — collective and individual
* Query course info — collective and individual
* Query course choosing & score — student ID / teacher ID / course ID / student's score — collective and individual
* Query average score — individual student / all students / class / course
* Modify a record's column value — StudentInfo / TeacherInfo / CourseInfo / ChooseCourse
* Delete an item — student / course / course choice
* Add a new record into a table — StudentInfo / TeacherInfo / CourseInfo / ChooseCourse
--------------------
#### Database design documents (DatabaseDesignDoc subfolder)
* index.html or index.local.html — open in preferred web browser
* DatabaseModelDiagram.pdf
