USE ClubMembership;

CREATE TABLE [Role] (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Description NVARCHAR(255),
    IsActive BIT NOT NULL
);

CREATE TABLE [User] (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    RoleID INT,
    IsActive BIT NOT NULL,
    FOREIGN KEY (RoleID) REFERENCES [Role](ID)
);

CREATE TABLE Major (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Code NVARCHAR(255) NOT NULL,
    IsActive BIT NOT NULL
);

CREATE TABLE Grade (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    StartDate DATETIME,
    ExpiryDate DATETIME,
    IsActive BIT NOT NULL
);

CREATE TABLE Student (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    MajorID INT,
    GradeID INT,
    IsActive BIT NOT NULL,
    FOREIGN KEY (MajorID) REFERENCES Major(ID),
    FOREIGN KEY (GradeID) REFERENCES Grade(ID)
);

CREATE TABLE Club (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    CreateDate DATETIME,
    IsActive BIT NOT NULL,
    Logo NVARCHAR(255)
);

CREATE TABLE Membership (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    StudentID INT,
    ClubID INT,
    JoinDate DATETIME,
    NickName NVARCHAR(255),
    Code NVARCHAR(255),
    Bio NVARCHAR(MAX),
    Avatar NVARCHAR(255),
    IsActive BIT NOT NULL,
    FOREIGN KEY (StudentID) REFERENCES Student(ID),
    FOREIGN KEY (ClubID) REFERENCES Club(ID)
);

CREATE TABLE Board (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    ClubID INT,
    FOREIGN KEY (ClubID) REFERENCES Club(ID)
);

CREATE TABLE BoardMember (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    BoardID INT,
    MembershipID INT,
    StartDate DATETIME,
    ExpiryDate DATETIME,
    IsActive BIT NOT NULL,
    Code TEXT,
    FOREIGN KEY (BoardID) REFERENCES Board(ID),
    FOREIGN KEY (MembershipID) REFERENCES Membership(ID)
);

CREATE TABLE Activity (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    ClubID INT NOT NULL,
    Name NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX),
    ShortDescription NVARCHAR(255),
    StartDate DATETIME,
    ExpiryDate DATETIME,
    IsActive BIT NOT NULL,
    CoverImage NVARCHAR(255),
    FOREIGN KEY (ClubID) REFERENCES Club(ID)
);

CREATE TABLE Participant (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    JoinDate DATETIME,
    ExpiryDate DATETIME,
    IsActive BIT NOT NULL,
    MembershipID INT,
    ActivityID INT,
    Mission NVARCHAR(MAX),
    FOREIGN KEY (MembershipID) REFERENCES Membership(ID),
    FOREIGN KEY (ActivityID) REFERENCES Activity(ID)
);



/* Create Roles */
INSERT INTO Role (Name, Description, IsActive)
VALUES ('Admin', 'Admin role with full system access', 1);
INSERT INTO Role (Name, Description, IsActive)
VALUES ('Club Manager', 'Club manager with permissions for managing club', 1);

/* Create Users */
INSERT INTO [User] (Name, RoleID, IsActive)
VALUES ('AdminUser', 1, 1);
INSERT INTO [User] (Name, RoleID, IsActive)
VALUES ('ClubManagerUser', 2, 1);

/* Admin User create Major, Grade, Student */
-- Inserting data into Major
INSERT INTO Major (Name, Code, IsActive)
VALUES ('Computer Science', 'CS', 1),
       ('Mathematics', 'MATH', 1),
       ('Physics', 'PHY', 1),
       ('Chemistry', 'CHEM', 1),
       ('Biology', 'BIO', 1);

-- Inserting data into Grade
INSERT INTO Grade (Name, StartDate, ExpiryDate, IsActive)
VALUES ('First Grade', '2023-09-01', '2024-08-31', 1),
       ('Second Grade', '2023-09-01', '2024-08-31', 1),
       ('Third Grade', '2023-09-01', '2024-08-31', 1),
       ('Fourth Grade', '2023-09-01', '2024-08-31', 1),
       ('Fifth Grade', '2023-09-01', '2024-08-31', 1);

-- Assuming that IDs for Major and Grade are in sequence from 1 to 5

-- Inserting data into Student
INSERT INTO Student (Name, MajorID, GradeID, IsActive)
VALUES 
('John Doe', 1, 1, 1),
('Jane Smith', 2, 2, 1),
('Bob Johnson', 3, 3, 1),
('Alice Williams', 4, 4, 1),
('Charlie Brown', 5, 5, 1),
('Emily Davis', 1, 1, 1),
('Thomas Miller', 2, 2, 1),
('Anna Wilson', 3, 3, 1),
('George Moore', 4, 4, 1),
('Sophia Taylor', 5, 5, 1),
('Michael Anderson', 1, 1, 1),
('Olivia Thomas', 2, 2, 1),
('James Jackson', 3, 3, 1),
('Isabella White', 4, 4, 1),
('William Harris', 5, 5, 1),
('Mia Martin', 1, 1, 1),
('Benjamin Thompson', 2, 2, 1),
('Ella Garcia', 3, 3, 1),
('Lucas Martinez', 4, 4, 1),
('Lily Robinson', 5, 5, 1);


/* Clubmanger inset clubs */
INSERT INTO Club (Name, CreateDate, IsActive, Logo)
VALUES 
('Club Alpha', GETDATE(), 1, 'https://link_to_logo_for_club_alpha.com'),
('Club Beta', GETDATE(), 1, 'https://link_to_logo_for_club_beta.com'),
('Club Gamma', GETDATE(), 1, 'https://link_to_logo_for_club_gamma.com'),
('Club Delta', GETDATE(), 1, 'https://link_to_logo_for_club_delta.com'),
('Club Epsilon', GETDATE(), 1, 'https://link_to_logo_for_club_epsilon.com');

/* Add student to Club */
INSERT INTO Membership (Name, StudentID, ClubID, JoinDate, IsActive)
VALUES 
('John Doe Membership', 1, 1, GETDATE(), 1),
('Jane Smith Membership', 2, 1, GETDATE(), 1),
('Bob Johnson Membership', 3, 1, GETDATE(), 1),
('Alice Williams Membership', 4, 1, GETDATE(), 1),
('Charlie Brown Membership', 5, 1, GETDATE(), 1),

('Emily Davis Membership', 6, 2, GETDATE(), 1),
('Thomas Miller Membership', 7, 2, GETDATE(), 1),
('Anna Wilson Membership', 8, 2, GETDATE(), 1),
('George Moore Membership', 9, 2, GETDATE(), 1),
('Sophia Taylor Membership', 10, 2, GETDATE(), 1),

('Michael Anderson Membership', 11, 3, GETDATE(), 1),
('Olivia Thomas Membership', 12, 3, GETDATE(), 1),
('James Jackson Membership', 13, 3, GETDATE(), 1),
('Isabella White Membership', 14, 3, GETDATE(), 1),
('William Harris Membership', 15, 3, GETDATE(), 1),

('Mia Martin Membership', 16, 4, GETDATE(), 1),
('Benjamin Thompson Membership', 17, 4, GETDATE(), 1),
('Ella Garcia Membership', 18, 4, GETDATE(), 1),
('Lucas Martinez Membership', 19, 4, GETDATE(), 1),
('Lily Robinson Membership', 20, 4, GETDATE(), 1),

('John Doe Membership2', 1, 5, GETDATE(), 1),
('Jane Smith Membership2', 2, 5, GETDATE(), 1),
('Bob Johnson Membership2', 3, 5, GETDATE(), 1),
('Alice Williams Membership2', 4, 5, GETDATE(), 1),
('Charlie Brown Membership2', 5, 5, GETDATE(), 1);


/* Create Board */
INSERT INTO Board (ClubID)
VALUES 
((SELECT ID FROM Club WHERE Name = 'Club Alpha')),
((SELECT ID FROM Club WHERE Name = 'Club Beta')),
((SELECT ID FROM Club WHERE Name = 'Club Gamma')),
((SELECT ID FROM Club WHERE Name = 'Club Delta')),
((SELECT ID FROM Club WHERE Name = 'Club Epsilon'));

/* Create BoardMemer */
-- Inserting sample data for BoardMember based on the Membership and Board tables
INSERT INTO BoardMember (BoardID, MembershipID, StartDate, IsActive, Code)
SELECT 
    b.ID AS BoardID, 
    m.ID AS MembershipID, 
    GETDATE() AS StartDate, 
    1 AS IsActive, 
    'SampleCode_' + CAST(b.ID AS NVARCHAR(255)) AS Code
FROM 
    Board b
INNER JOIN 
    Membership m ON b.ClubID = m.ClubID;

/* Create Activity */
INSERT INTO Activity (ClubID, Name, Description, ShortDescription, StartDate, ExpiryDate, IsActive, CoverImage)
VALUES 
(1, 'Alpha Event', 'Detailed description of Alpha Event.', 'Alpha Event Desc', GETDATE(), DATEADD(DAY, 30, GETDATE()), 1, 'https://link_to_cover_image_for_alpha_event.com'),
(2, 'Beta Event', 'Detailed description of Beta Event.', 'Beta Event Desc', GETDATE(), DATEADD(DAY, 30, GETDATE()), 1, 'https://link_to_cover_image_for_beta_event.com'),
(3, 'Gamma Event', 'Detailed description of Gamma Event.', 'Gamma Event Desc', GETDATE(), DATEADD(DAY, 30, GETDATE()), 1, 'https://link_to_cover_image_for_gamma_event.com'),
(4, 'Delta Event', 'Detailed description of Delta Event.', 'Delta Event Desc', GETDATE(), DATEADD(DAY, 30, GETDATE()), 1, 'https://link_to_cover_image_for_delta_event.com'),
(5, 'Epsilon Event', 'Detailed description of Epsilon Event.', 'Epsilon Event Desc', GETDATE(), DATEADD(DAY, 30, GETDATE()), 1, 'https://link_to_cover_image_for_epsilon_event.com');

/* Create Participant */
-- Sample Participants for each Activity and Membership
INSERT INTO Participant (JoinDate, ExpiryDate, IsActive, MembershipID, ActivityID, Mission)
SELECT 
    GETDATE() AS JoinDate, 
    DATEADD(DAY, 30, GETDATE()) AS ExpiryDate, 
    1 AS IsActive, 
    m.ID AS MembershipID, 
    a.ID AS ActivityID, 
    'Mission for ' + m.Name AS Mission
FROM 
    Membership m
JOIN 
    Activity a ON m.ClubID = a.ClubID;
