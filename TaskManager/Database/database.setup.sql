CREATE DATABASE BD_TASK_MANAGER;
GO

USE BD_TASK_MANAGER;
GO


CREATE TABLE USERS (
    Id INT PRIMARY KEY IDENTITY,
    UserName VARCHAR(100) NOT NULL,
    Passwordd VARCHAR(255) NOT NULL,
    Email VARCHAR(100) NOT NULL
);


CREATE TABLE TASKS (
    Id INT PRIMARY KEY IDENTITY,
    Title VARCHAR(255) NOT NULL,
    Descriptionn TEXT,
    ExpiryDate DATETIME,
    Statuss VARCHAR(50) DEFAULT 'Pending', --pending - in progress, - done
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME,
	UserId INT,  -- Columna que será la llave foránea
    CONSTRAINT FK_User_Task FOREIGN KEY (UserId) REFERENCES Users(Id)
);