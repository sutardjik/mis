window.repositoryObject = {"columns_custom_fields":[],"relations_custom_fields":[],"unique_keys_custom_fields":[],"triggers_custom_fields":[],"object_id":"t3752","name":"CourseInfo","subtype":"TABLE","is_user_defined":false,"description":null,"summary":[{"field":"Documentation","value":{"_type":"link","name":"master@LAPTOP-DCOJKS07\\MSSQLSERVER01","id":"d10"}},{"field":"Schema","value":"dbo"},{"field":"Name","value":"CourseInfo"},{"field":"Type","value":"Table"}],"columns":[{"id":"column-34708","object_id":"column-34708","name":"CourseID","name_without_path":"CourseID","description":"CourseInfo primary key","is_pk":true,"is_identity":false,"data_type":"varchar","data_length":"7","is_nullable":false,"computed_formula":null,"default_value":null,"path":null,"level":1,"item_type":"COLUMN","is_user_defined":false,"custom_fields":{},"linked_terms":[],"references":[]},{"id":"column-34709","object_id":"column-34709","name":"CourseName","name_without_path":"CourseName","description":"Name of course","is_pk":false,"is_identity":false,"data_type":"varchar","data_length":"20","is_nullable":false,"computed_formula":null,"default_value":null,"path":null,"level":1,"item_type":"COLUMN","is_user_defined":false,"custom_fields":{},"linked_terms":[],"references":[]},{"id":"column-34710","object_id":"column-34710","name":"TeacherID","name_without_path":"TeacherID","description":"Foreign key referencing TeacherInfo","is_pk":false,"is_identity":false,"data_type":"varchar","data_length":"5","is_nullable":false,"computed_formula":null,"default_value":null,"path":null,"level":1,"item_type":"COLUMN","is_user_defined":false,"custom_fields":{},"linked_terms":[],"references":[{"id":"t3756","name":"TeacherInfo","name_show_schema":"dbo.TeacherInfo"}]},{"id":"column-34711","object_id":"column-34711","name":"Credit","name_without_path":"Credit","description":"Course's credit range: 1 to 6","is_pk":false,"is_identity":false,"data_type":"int","data_length":null,"is_nullable":false,"computed_formula":null,"default_value":null,"path":null,"level":1,"item_type":"COLUMN","is_user_defined":false,"custom_fields":{},"linked_terms":[],"references":[]},{"id":"column-34712","object_id":"column-34712","name":"CourseGrade","name_without_path":"CourseGrade","description":"Qualified grades to take a course: 1 to 4","is_pk":false,"is_identity":false,"data_type":"int","data_length":null,"is_nullable":false,"computed_formula":null,"default_value":null,"path":null,"level":1,"item_type":"COLUMN","is_user_defined":false,"custom_fields":{},"linked_terms":[],"references":[]},{"id":"column-34713","object_id":"column-34713","name":"CancelYear","name_without_path":"CancelYear","description":"Year that course is no longer available or NULL","is_pk":false,"is_identity":false,"data_type":"int","data_length":null,"is_nullable":true,"computed_formula":null,"default_value":null,"path":null,"level":1,"item_type":"COLUMN","is_user_defined":false,"custom_fields":{},"linked_terms":[],"references":[]}],"relations":[{"name":"FK__CourseInf__Teach__40058253","title":null,"description":null,"is_user_defined":false,"foreign_table":"CourseInfo","foreign_table_show_schema":"dbo.CourseInfo","foreign_table_verbose":"CourseInfo","foreign_table_verbose_show_schema":"dbo.CourseInfo","foreign_table_object_id":"t3752","primary_table":"TeacherInfo","primary_table_show_schema":"dbo.TeacherInfo","primary_table_verbose":"TeacherInfo","primary_table_verbose_show_schema":"dbo.TeacherInfo","primary_table_object_id":"t3756","pk_cardinality":"1x","fk_cardinality":"mx","constraints":[{"primary_column_path":null,"primary_column":"TeacherID","foreign_column_path":null,"foreign_column":"TeacherID"}],"custom_fields":{}},{"name":"FK__ChooseCou__Cours__44CA3770","title":null,"description":null,"is_user_defined":false,"foreign_table":"ChooseCourse","foreign_table_show_schema":"dbo.ChooseCourse","foreign_table_verbose":"ChooseCourse","foreign_table_verbose_show_schema":"dbo.ChooseCourse","foreign_table_object_id":"t3751","primary_table":"CourseInfo","primary_table_show_schema":"dbo.CourseInfo","primary_table_verbose":"CourseInfo","primary_table_verbose_show_schema":"dbo.CourseInfo","primary_table_object_id":"t3752","pk_cardinality":"1x","fk_cardinality":"mx","constraints":[{"primary_column_path":null,"primary_column":"CourseID","foreign_column_path":null,"foreign_column":"CourseID"}],"custom_fields":{}}],"unique_keys":[{"name":"PK__CourseIn__C92D7187DFCD4687","description":null,"is_pk":true,"is_user_defined":false,"columns":[{"path":null,"name_without_path":"CourseID","name":"CourseID"}],"custom_fields":{}}],"triggers":[],"dependencies":{"uses":[{"object_name":"CourseInfo","object_name_show_schema":"dbo.CourseInfo","object_type":"TABLE","object_id":"t3752","type":"NORMAL","object_user_defined":false,"user_defined":false,"children":[{"object_name":"TeacherInfo","object_name_show_schema":"dbo.TeacherInfo","object_type":"TABLE","object_id":"t3756","type":"RELATION","pk_cardinality":"1x","fk_cardinality":"mx","object_user_defined":false,"user_defined":false,"children":[]}]}],"used_by":[{"object_name":"CourseInfo","object_name_show_schema":"dbo.CourseInfo","object_type":"TABLE","object_id":"t3752","type":"NORMAL","object_user_defined":false,"user_defined":false,"children":[{"object_name":"ChooseCourse","object_name_show_schema":"dbo.ChooseCourse","object_type":"TABLE","object_id":"t3751","type":"RELATION","pk_cardinality":"1x","fk_cardinality":"mx","object_user_defined":false,"user_defined":false,"children":[]}]}]},"imported_at":"2022-05-05 06:05"};