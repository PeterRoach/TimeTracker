CREATE DATABASE TIME_TRACKER;
GO

USE TIME_TRACKER;
GO

/* Tables */

CREATE TABLE tt_user (
	 id int not null identity(1,1) primary key
	,username varchar(255) unique
	,password_hash varchar(max)
	,password_salt varchar(max)
	,first_name varchar(max)
	,last_name varchar(max)
	,email varchar(max)
);

CREATE TABLE tt_role (
	 id int not null identity(1,1) primary key
	,role_description varchar(max)
);

CREATE TABLE user_role (
	 id int not null identity(1,1) primary key
	,tt_user_id int not null foreign key references tt_user(id)
	,tt_role_id int not null foreign key references tt_role(id)
);

CREATE TABLE clock_entry (
	 id int not null identity(1,1) primary key
	,tt_user_id int not null foreign key references tt_user(id)
	,start_time datetime2
	,end_time datetime2
);

CREATE TABLE task_entry (
	 id int not null identity(1,1) primary key
	,clock_entry_id int not null foreign key references clock_entry(id)
	,task_description varchar(max)
);

GO

/* Procedures */

CREATE PROCEDURE uspInsertUser
 @username varchar(max)
,@password_hash varchar(max)
,@password_salt varchar(max)
,@first_name varchar(max)
,@last_name varchar(max)
,@email varchar(max)
AS
BEGIN
	INSERT INTO tt_user (username, password_hash, password_salt, first_name, last_name, email) 
	VALUES (@username, @password_hash, @password_salt, @first_name, @last_name, @email);
END;
GO

CREATE PROCEDURE uspInsertRole
 @role_description varchar(max)
AS
BEGIN
	INSERT INTO tt_role (role_description) 
	VALUES (@role_description);
END;
GO

CREATE PROCEDURE uspInsertUserRole
 @tt_user_id int
,@tt_role_id int
AS
BEGIN
	INSERT INTO user_role (tt_user_id, tt_role_id) 
	VALUES (@tt_user_id, @tt_role_id);
END;
GO

CREATE PROCEDURE uspInsertClockEntry
 @tt_user_id int
,@start_time datetime2
,@end_time datetime2
AS
BEGIN
	INSERT INTO clock_entry (tt_user_id, start_time, end_time) 
	VALUES (@tt_user_id, @start_time, @end_time);
	SELECT SCOPE_IDENTITY();
END;
GO

CREATE PROCEDURE uspInsertTaskEntry
 @clock_entry_id int
,@task_description varchar(max)
AS
BEGIN
	INSERT INTO task_entry (clock_entry_id, task_description)
	VALUES (@clock_entry_id, @task_description);
	SELECT SCOPE_IDENTITY();
END;
GO

CREATE PROCEDURE uspUpdateClockEntryEndTime
 @id int
,@end_time datetime2
AS
BEGIN
	UPDATE clock_entry SET end_time = @end_time WHERE id = @id;
END;
GO

CREATE PROCEDURE uspUpdateTaskEntryDescription
 @id int
,@task_description varchar(max)
AS
BEGIN
	UPDATE task_entry SET task_description = @task_description WHERE id = @id;
END;
GO

CREATE PROCEDURE uspDeleteTaskEntry
 @id int
AS
BEGIN
	DELETE FROM task_entry WHERE id = @id;
END;
GO

CREATE PROCEDURE uspCountUsername
 @username varchar(max)
AS
BEGIN
	SELECT COUNT(*) FROM tt_user WHERE username = @username;
END;
GO

CREATE PROCEDURE uspSelectUserPasswordData
 @username varchar(max)
AS
BEGIN
	SELECT 
		 password_hash
		,password_salt 
	FROM tt_user 
	WHERE username = @username;
END;
GO

CREATE PROCEDURE uspSelectUserData
 @username varchar(max)
AS
BEGIN
	SELECT
		 id
		,username
		,first_name
		,last_name
		,email
	FROM tt_user
	WHERE username = @username;
END;
GO

CREATE PROCEDURE uspSelectUserRole
 @tt_user_id int
AS
BEGIN
	SELECT 
		 ur.id
		,ur.tt_role_id
		,r.role_description
	FROM user_role ur LEFT JOIN tt_role r ON ur.tt_role_id = r.id
END;
GO

CREATE PROCEDURE uspSelectUserClockEntry
 @tt_user_id int
AS
BEGIN
	SELECT 
		 id 
		,start_time 
		,end_time
	FROM clock_entry
	WHERE tt_user_id = @tt_user_id;
END;
GO

CREATE PROCEDURE uspSelectUserTaskEntry
 @tt_user_id int
AS
BEGIN
	SELECT 
		 te.id
		,te.clock_entry_id
		,te.task_description
	FROM task_entry te
	LEFT JOIN clock_entry ce ON te.clock_entry_id = ce.id
	WHERE ce.tt_user_id = @tt_user_id;
END;
GO

CREATE PROCEDURE uspSelectTaskEntry
 @clock_entry_id int
AS
BEGIN
	SELECT 
		 id
		,task_description
	FROM task_entry
	WHERE clock_entry_id = @clock_entry_id;
END;
GO

/* Test */

SELECT * FROM tt_user;
SELECT * FROM clock_entry;
SELECT * FROM task_entry;