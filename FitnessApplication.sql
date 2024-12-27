--
-- Step 1: Drop the database if it exists to reset it
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'Fitness Application')
BEGIN
    -- Ensure no active connections and drop the database
    USE master;
    ALTER DATABASE [Fitness Application] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [Fitness Application];
END;

-- Step 2: Create the database
CREATE DATABASE [Fitness Application];
GO

-- Step 3: Switch to the new database context
USE [Fitness Application];
GO


------------Table Creation-----------------

create table Users 
(
Username varchar(50) not null,
[Password] varchar(50) not null,
type_of_user VARCHAR(20) NOT NULL,
PRIMARY KEY (Username),
CONSTRAINT chk_type_of_user CHECK (type_of_user IN ('admin', 'member', 'coach', 'academy'))
);


create table FitnessGoals
(  
GoalName varchar(50) not null,
GoalID int IDENTITY(1,1),
Description TEXT,
RecommendedBMI DECIMAL(5, 2),
-- Exercise focus multivalued attribute to be added
primary key(GoalID),
)

create table Diets
(  
DietID int IDENTITY(1,1),
Description TEXT,
DietName varchar(50) not null,
Primary Key(DietID)
)
create table Members
(  

Fname varchar(50) not null,
Lname varchar(50) not null,
MemberID int IDENTITY(1,1),
Age int not null,
Weight DECIMAL(5, 2) not null,
Height DECIMAL(5, 2) not null,
AllowedCalorieIntake int,
Streak int not null,
Points int not null,
Gender char(1) not null,
FitnessGoalID int,
DietID int,
Username varchar(50),

Foreign Key (Username) References Users(Username)
ON DELETE SET NULL
ON UPDATE NO ACTION,

Foreign Key (FitnessGoalID) References FitnessGoals(GoalID)
ON DELETE SET NULL
ON UPDATE CASCADE,

Foreign Key (DietID) References Diets(DietID)
ON DELETE SET NULL
ON UPDATE CASCADE,



primary key(MemberID)
)

create table Coaches
(  
Fname varchar(50) not null,
Lname varchar(50) not null,
CoachID int IDENTITY(1,1),
Age int not null,
Gender char(1),
MemberLimit int,
Accepted BIT not null, -- BIT as bool does not exist in sql. 1 = true, 0 = false. 
-- Composite attribute - certificate
CertificateTitle VARCHAR(100) not null,      
CertificateDateOfIssue DATE not null,        
CertificateExpirationDate DATE not null,     
CertificateIssuingBody VARCHAR(100) not null,
Username varchar(50) not null,

Foreign Key (Username) References Users(Username)
ON DELETE NO ACTION
ON UPDATE CASCADE,
primary key(CoachID),
)

create table CoachedBy
(
MemberID int,
CoachID int,
Rating DECIMAL(2, 1),
CONSTRAINT chk_coachedby_rating CHECK (Rating >= 0 AND Rating <= 5), -- Look for some way to limit ratings to be 0 - 5
Ongoing BIT not null,
Accepted BIT not null,
Foreign Key (MemberID) References Members(MemberID)
ON DELETE CASCADE
ON UPDATE NO ACTION,
Foreign Key (CoachID) References Coaches(CoachID)
ON DELETE  CASCADE
ON UPDATE CASCADE,
Primary Key(MemberID, CoachID) -- both pk to be referenced in other tables
)


create table SuggestedCalories
(
MemberID int,
CoachID int,
SuggestedCalroies INT not null,
DateSuggested DATE,
Foreign Key (MemberID, CoachID) References CoachedBy(MemberID,CoachID)
ON DELETE  CASCADE
ON UPDATE CASCADE,
Primary Key(MemberID, CoachID)
)
-- Weak entity that depends on Coaches
create table CoachChallenges
(  
ChallengeID int,
Description TEXT not null,
PointsRewarded int not null,
ChallengeName VARCHAR(100) not null,
StartDate DATE not null,
EndDate DATE not null,
CoachID int,

Foreign Key (CoachID) References Coaches(CoachID)
ON DELETE  CASCADE
ON UPDATE CASCADE,
Primary Key(ChallengeID, CoachID),

)

-- Weak entity that depends on Coaches
create table Meals
(  
MealID int,
Steps TEXT not null,
Ingredients TEXT not null,
Duration TIME not null,
MealType VARCHAR(20) not null,
CHECK (MealType IN ('Breakfast', 'Lunch', 'Dinner', 'Snack', 'Anything')),
CaloriesPerServing INT not null,
MealName VARCHAR(100) not null,
Fats DECIMAL(5, 2) NOT NULL,
Protein DECIMAL(5, 2) NOT NULL,
Carbs DECIMAL(5, 2) NOT NULL,
DatePosted DATE not null,
CoachID int,
Foreign Key (CoachID) References Coaches(CoachID)
ON DELETE  CASCADE
ON UPDATE CASCADE,
Primary Key(MealID, CoachID),

)

create table Academies
(  
Name varchar(50) not null,
AcademyID int IDENTITY(1,1),
Description TEXT not null,
AreaOfExpertise VARCHAR(100) not null,
Accepted BIT not null, -- BIT as bool does not exist in sql. 1 = true, 0 = false. 
-- Composite attribute - certificate
CertificateTitle VARCHAR(100) not null,      
CertificateDateOfIssue DATE not null,        
CertificateExpirationDate DATE not null,     
CertificateIssuingBody VARCHAR(100) not null,

Username varchar(50) not null,

Foreign Key (Username) References Users(Username)
ON DELETE NO ACTION
ON UPDATE  CASCADE,
primary key(AcademyID),
)

-- Weak entity that depends on Academies
create table Sessions
(  
SessionID int,
Description TEXT not null,
Price float,
Limit int not null,
FullSession BIT not null,
Duration TIME not null,
Location VARCHAR(100) not null,
Date DATE not null,
Time TIME not null,
AcademyID int,

Foreign Key (AcademyID) References Academies(AcademyID)
ON DELETE  CASCADE
ON UPDATE CASCADE,
Primary Key(SessionID, AcademyID)

)

CREATE TABLE Exercises (
    ExerciseName VARCHAR(50) NOT NULL,
    ExerciseID INT IDENTITY(1,1),
    Description TEXT,
    CaloriesBurnedPerMin DECIMAL(7, 2) NOT NULL,
    PointsPerMin INT NOT NULL,
	Primary Key(ExerciseID)
)

create table HabitTypes
(
    TypeID int IDENTITY(1,1),
    TypeName VARCHAR(20) not null,
    Primary key(TypeID)
)

create table DailyHabits
(  
HabitName varchar(50) not null,
HabitID int IDENTITY(1,1),
Description TEXT,
Points int not null,
TypeID int,
Foreign key(TypeID) References HabitTypes(TypeID)
ON DELETE SET NULL
ON UPDATE CASCADE,
primary key(HabitID),
)



create table Badges
(  
BadgeName varchar(50) not null,
BadgeID int IDENTITY(1,1),
Description TEXT,
PointsNeeded int,
primary key(BadgeID),
)

create table FeedbackTypes
(
TypeID int IDENTITY(1,1),
TypeName varchar(20) not null,
primary key(TypeID)

)
create table Feedback
(  
FeedbackID int IDENTITY(1,1),
Comment TEXT not null,
Rating DECIMAL(2, 1),
FeedbackTypeID int,
Foreign Key(FeedbackTypeID) References FeedbackTypes(TypeID)
ON DELETE SET NULL
ON UPDATE CASCADE,
CONSTRAINT chk_Feedback_rating CHECK (Rating >= 0 AND Rating <= 5),  -- Look for some way to limit ratings to be 0 - 5
DatePosted DATETIME not null,
primary key(FeedbackID)
)

create table CoachFeedback
(
FeedbackID int,
CoachID int,

Foreign Key (FeedbackID) References Feedback(FeedbackID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign Key (CoachID) References Coaches(CoachID)
ON DELETE CASCADE
ON UPDATE CASCADE,

Primary Key(FeedbackID)
)

create table MemberFeedback
(
FeedbackID int,
MemberID int,
Foreign Key (FeedbackID) References Feedback(FeedbackID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign Key (MemberID) References Members(MemberID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Primary Key(FeedbackID)
)

create table MealBelongsToDiets
(
MealID int,
CoachID int,
DietID int,

Foreign Key (MealID, CoachID) References Meals(MealID, CoachID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign Key (DietID) References Diets(DietID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Primary Key(MealID, CoachID, DietID)
)

create table TracksHabit
(
MemberID int,
HabitID int,
DateTracked DATE,

Foreign Key (MemberID) References Members(MemberID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign Key (HabitID) References DailyHabits(HabitID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Primary Key(MemberID,HabitID, DateTracked)
)

create table ReservedSession
(
MemberID int,
SessionID int,
AcademyID int,
NumberOfSeats int not null,

Foreign Key (MemberID) References Members(MemberID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign Key (SessionID, AcademyID) References Sessions(SessionID,AcademyID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Primary Key(MemberID,SessionID, AcademyID)
)

create table CompletedChallenge
(
MemberID int,
CoachID int,
ChallengeID int,

Foreign Key (ChallengeID, CoachID) References CoachChallenges(ChallengeID, CoachID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign Key (MemberID) References Members(MemberID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Primary Key(MemberID, CoachID, ChallengeID)
)

create table BadgesEarned
(
MemberID int,
CoachID int,
BadgeID int,
DateEarned DATE not null,

Foreign Key (MemberID, CoachID) References CoachedBy(MemberID,CoachID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign Key (BadgeID) References Badges(BadgeID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Primary Key(MemberID, BadgeID)
)

create table SuggestedExercises
(
MemberID int,
CoachID int,
ExerciseID int,
DateSuggested DATE,
Foreign Key (MemberID, CoachID) References CoachedBy(MemberID,CoachID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign Key (ExerciseID) References Exercises(ExerciseID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Primary Key(MemberID, CoachID,ExerciseID)
)
create table GoalExerciseFocus
(
GoalID int,
ExerciseID int,
Foreign Key (ExerciseID) References Exercises(ExerciseID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign Key (GoalID) References FitnessGoals(GoalID)
ON DELETE CASCADE
ON UPDATE CASCADE,

Primary Key(GoalID, ExerciseID)
)
-- For multivalued attribute
create table TypesOfExercises
(
TypeID int IDENTITY(1,1),
TypeName VARCHAR(20) not null,
Primary key(TypeID)
)
create table ExerciseTypes
(
ExerciseID int,
TypeID int,
Foreign Key (ExerciseID) References Exercises(ExerciseID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign Key (TypeID) References TypesOfExercises(TypeID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Primary Key(ExerciseID, TypeID)
)

create table MemberLogExercise
(
MemberID int,
ExerciseID int,
DateTimeLogged DATETIME,
MinutesExercised int not null,
CaloriesBurned int not null,
PointsAwarded int not null,
Foreign Key (ExerciseID) References Exercises(ExerciseID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign Key (MemberID) References Members(MemberID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Primary Key(MemberID, ExerciseID, DateTimeLogged)

)

create table MemberLogCalories
(
MemberID int,

DateTimeLogged DATETIME,

CaloriesConsumed int not null,
Foreign Key (MemberID) References Members(MemberID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Primary Key(MemberID,DateTimeLogged)

)




-----------------Inserting values into tables----------------


-- Inserting coaches into Users
INSERT INTO Users (Username, [Password], type_of_user)
VALUES
('john_doe', 'password123', 'coach'),
('jane_smith', 'password123', 'coach'),
('emily_johnson', 'password123', 'coach'),
('michael_williams', 'password123', 'coach'),
('olivia_brown', 'password123', 'coach'),
('liam_davis', 'password123', 'coach'),
('sophia_martinez', 'password123', 'coach'),
('noah_garcia', 'password123', 'coach'),
('isabella_rodriguez', 'password123', 'coach'),
('ethan_wilson', 'password123', 'coach'),
('miaa_lee', 'password123', 'coach'),
('james_harris', 'password123', 'coach'),
('charlotte_clark', 'password123', 'coach'),
('alexander_lewis', 'password123', 'coach'),
('amelia_walker', 'password123', 'coach'),
('benjamin_young', 'password123', 'coach'),
('harper_allen', 'password123', 'coach'),
('jack_king', 'password123', 'coach'),
('ella_scott', 'password123', 'coach'),
('lucas_adams', 'password123', 'coach');

-- inserting members into users

INSERT INTO Users (Username, [Password], type_of_user)
VALUES
('alice_johnson', 'password123', 'member'),
('bob_smith', 'password123', 'member'),
('clara_davis', 'password123', 'member'),
('david_wilson', 'password123', 'member'),
('eva_martinez', 'password123', 'member'),
('frank_lopez', 'password123', 'member'),
('grace_hernandez', 'password123', 'member'),
('henry_gonzalez', 'password123', 'member'),
('isla_rodriguez', 'password123', 'member'),
('jack_brown', 'password123', 'member'),
('kara_martinez', 'password123', 'member'),
('liam_taylor', 'password123', 'member'),
('mia_lee', 'password123', 'member'),
('nina_scott', 'password123', 'member'),
('oscar_walker', 'password123', 'member'),
('penny_adams', 'password123', 'member'),
('quinn_roberts', 'password123', 'member'),
('rachel_green', 'password123', 'member'),
('sam_baker', 'password123', 'member'),
('tina_harris', 'password123', 'member');


INSERT INTO Coaches (Username, Fname, Lname, Age, Gender, MemberLimit, Accepted, CertificateTitle, CertificateDateOfIssue, CertificateExpirationDate, CertificateIssuingBody)
VALUES
('john_doe', 'John', 'Doe', 35, 'M', 15, 1, 'Certified Fitness Coach', '2018-06-15', '2023-06-15', 'International Fitness Federation'),
('jane_smith', 'Jane', 'Smith', 42, 'F', 10, 0, 'Certified Yoga Instructor', '2015-03-20', '2025-03-20', 'Yoga Alliance'),
('emily_johnson', 'Emily', 'Johnson', 28, 'F', 20, 1, 'Strength Training Specialist', '2020-01-10', '2025-01-10', 'National Strength and Conditioning Association'),
('michael_williams', 'Michael', 'Williams', 50, 'M', 12, 1, 'Sports Nutrition Expert', '2019-07-25', '2024-07-25', 'Academy of Nutrition and Dietetics'),
('olivia_brown', 'Olivia', 'Brown', 30, 'F', 18, 0, 'Certified Personal Trainer', '2017-08-05', '2027-08-05', 'American Council on Exercise'),
('liam_davis', 'Liam', 'Davis', 33, 'M', 25, 1, 'Pilates Instructor', '2021-11-10', '2026-11-10', 'Pilates Method Alliance'),
('sophia_martinez', 'Sophia', 'Martinez', 38, 'F', 10, 1, 'Dance Fitness Instructor', '2016-04-12', '2026-04-12', 'Zumba Fitness'),
('noah_garcia', 'Noah', 'Garcia', 45, 'M', 30, 0, 'Rehabilitation Specialist', '2014-05-25', '2024-05-25', 'American Physical Therapy Association'),
('isabella_rodriguez', 'Isabella', 'Rodriguez', 40, 'F', 12, 1, 'CrossFit Level 1 Trainer', '2019-09-18', '2024-09-18', 'CrossFit Inc.'),
('ethan_wilson', 'Ethan', 'Wilson', 29, 'M', 14, 1, 'Kettlebell Instructor', '2021-03-05', '2026-03-05', 'Kettlebell Athletics'),
('miaa_lee', 'Mia', 'Lee', 26, 'F', 22, 0, 'Swimming Coach', '2022-07-11', '2027-07-11', 'United States Swimming'),
('james_harris', 'James', 'Harris', 37, 'M', 10, 1, 'Boxing Coach', '2018-11-02', '2023-11-02', 'USA Boxing'),
('charlotte_clark', 'Charlotte', 'Clark', 31, 'F', 8, 1, 'Outdoor Adventure Coach', '2020-06-22', '2025-06-22', 'Outdoor Educators'),
('alexander_lewis', 'Alexander', 'Lewis', 43, 'M', 20, 0, 'Running Coach', '2017-01-18', '2027-01-18', 'USA Track & Field'),
('amelia_walker', 'Amelia', 'Walker', 50, 'F', 18, 1, 'Mindfulness Coach', '2015-12-01', '2025-12-01', 'International Mindfulness Teachers Association'),
('benjamin_young', 'Benjamin', 'Young', 32, 'M', 14, 1, 'Cycling Coach', '2018-08-09', '2023-08-09', 'USA Cycling'),
('harper_allen', 'Harper', 'Allen', 27, 'F', 12, 0, 'Martial Arts Instructor', '2016-05-14', '2026-05-14', 'World Martial Arts Federation'),
('jack_king', 'Jack', 'King', 34, 'M', 16, 1, 'Strength and Conditioning Coach', '2021-02-20', '2026-02-20', 'National Strength and Conditioning Association'),
('ella_scott', 'Ella', 'Scott', 41, 'F', 14, 1, 'Triathlon Coach', '2020-10-30', '2025-10-30', 'USA Triathlon'),
('lucas_adams', 'Lucas', 'Adams', 28, 'M', 24, 1, 'Soccer Coach', '2019-04-16', '2024-04-16', 'United States Soccer Federation');



-- Inserting academies into users
INSERT INTO Users (Username, [Password], type_of_user)
VALUES
('KickFitAcademy', 'password123', 'academy'),
('ZenYogaAcademy', 'password123', 'academy'),
('RockClimbProAcademy', 'password123', 'academy'),
('StrengthXAcademy', 'password123', 'academy'),
('FlexFitAcademy', 'password123', 'academy'),
('TriathleteAcademy', 'password123', 'academy'),
('CrossFitNationAcademy', 'password123', 'academy'),
('PilatesCoreAcademy', 'password123', 'academy'),
('BoxingProAcademy', 'password123', 'academy'),
('EnduranceFitnessAcademy', 'password123', 'academy'),
('YogaFlowAcademy', 'password123', 'academy'),
('ClimbingEdgeAcademy', 'password123', 'academy'),
('FitDanceAcademy', 'password123', 'academy'),
('MindBodyAcademy', 'password123', 'academy'),
('TrailRunnerAcademy', 'password123', 'academy'),
('BikramYogaAcademy', 'password123', 'academy'),
('MixedMartialArtsAcademy', 'password123', 'academy'),
('PowerCycleAcademy', 'password123', 'academy'),
('BeachFitAcademy', 'password123', 'academy'),
('StrengthLabAcademy', 'password123', 'academy');

-- Inserting our first admin
INSERT INTO Users (Username, [Password], type_of_user)
VALUES
('admin1', 'password123', 'admin');

-- Inserting generic users to be used for testing
--INSERT INTO Users (Username, [Password], type_of_user)
--VALUES
--('generic_member', 'password123', 'member'),
--('generic_coach', 'password123', 'coach'),
--('generic_academy', 'password123', 'academy'),
--('generic_coach', 'password123', 'coach'),

INSERT INTO Badges (BadgeName, Description, PointsNeeded)
VALUES
('Beginner', 'Awarded to new members who have started using the system.', NULL),
('Intermediate', 'Awarded to members who have accumulated 500 points.', 500),
('Advanced', 'Awarded to members who have accumulated 1500 points.', 1500),
('Elite', 'Awarded to members who have accumulated 5000 points.', 5000),
('Champion', 'Awarded to members who have accumulated 10000 points.', 10000),
('Fitness Enthusiast', 'Awarded to members who show excellent dedication to their fitness journey.', NULL),
('Overachiever', 'Awarded to members who have reached a total of 25000 points.', 25000),
('Superstar', 'Awarded to members who have achieved 50000 points and above.', 50000),
('Master', 'Awarded to members who have accumulated 100000 points.', 100000),
('Coach’s Choice', 'Awarded to members for outstanding dedication and progress in fitness.', NULL),
('Most Consistent', 'Awarded to members who are consistent', NULL),
('Stretch Master', 'Awarded to members who regularly incorporate stretching into their fitness routine.', NULL),
('Beast Mode', 'Awarded to members who push their limits, consistently hitting their personal bests in workouts.', NULL),
('Resilient Spirit', 'Awarded to members who show significant improvement.', NULL),
('Challenge Master', 'Awarded to members who put in the most effort, whether during training or in completing assignments.', NULL),
('Top Trainee', 'Awarded to the member with the most visible improvements based on a coach’s assessment.', NULL),
('Performance Excellence', 'Awarded to members who consistently perform at their highest level during training, as evaluated by the coach.', NULL);



INSERT INTO CoachChallenges (ChallengeID, Description, PointsRewarded, ChallengeName, StartDate, EndDate, CoachID)
VALUES
(1, 'Run 2 km in under 12 minutes.', 150, 'Speed Run', '2024-12-01', '2024-12-05', 1),
(2, 'Do 50 push-ups in one go.', 100, 'Push-up Power', '2024-12-01', '2024-12-07', 2),
(3, 'Complete 5 rounds of 10 burpees.', 120, 'Burpee Blast', '2024-12-01', '2024-12-03', 3),
(4, 'Run 5 km in under 30 minutes.', 200, 'Endurance Run', '2024-12-02', '2024-12-10', 4),
(5, 'Do 30 squats in 2 minutes.', 100, 'Squat Challenge', '2024-12-01', '2024-12-05', 5),
(6, 'Hold a plank for 3 minutes.', 150, 'Plank Master', '2024-12-01', '2024-12-06', 6),
(7, 'Do 100 jumping jacks in 5 minutes.', 130, 'Jumping Jack Challenge', '2024-12-03', '2024-12-08', 7),
(8, 'Run 3 km every day for a week.', 250, 'Running Streak', '2024-12-01', '2024-12-07', 8),
(9, 'Complete 3 sets of 20 sit-ups.', 80, 'Core Challenge', '2024-12-02', '2024-12-06', 5),
(10, 'Do 20 triceps dips in 2 minutes.', 90, 'Arm Strength Challenge', '2024-12-01', '2024-12-04', 10),
(11, 'Do 10 pull-ups in a row.', 180, 'Pull-up Power', '2024-12-05', '2024-12-10', 11),
(12, 'Cycle for 30 minutes at moderate pace.', 160, 'Cycling Endurance', '2024-12-02', '2024-12-08', 12),
(13, 'Complete 50 lunges (25 per leg).', 120, 'Lunge Challenge', '2024-12-01', '2024-12-05', 13),
(14, 'Do 20 mountain climbers in 1 minute.', 110, 'Mountain Climber Sprint', '2024-12-03', '2024-12-07', 14),
(15, 'Run a total of 10 km over 3 days.', 180, 'Weekly Runner', '2024-12-01', '2024-12-04', 15),
(16, 'Complete 30 push-ups in 3 minutes.', 150, 'Push-up Challenge', '2024-12-04', '2024-12-07', 16),
(17, 'Do 3 sets of 15 jump squats.', 140, 'Jump Squat Challenge', '2024-12-01', '2024-12-05', 17),
(18, 'Hold a wall sit for 2 minutes.', 100, 'Wall Sit Endurance', '2024-12-02', '2024-12-05', 19),
(19, 'Do 30 minutes of yoga or stretching.', 130, 'Yoga Flexibility', '2024-12-01', '2024-12-07', 19),
(20, 'Complete a 5 km run each week for 2 weeks.', 300, '5 km Challenge', '2024-12-01', '2024-12-14', 20);

INSERT INTO FitnessGoals ( GoalName, Description, RecommendedBMI)
VALUES
( 'Lose Weight', 'Aimed at reducing body fat and achieving a healthier body composition.', 18.50),
( 'Gain Muscle', 'Focuses on building lean muscle mass through strength training and nutrition.', 22.50),
( 'Maintain Weight', 'Helps individuals maintain their current weight by balancing exercise and nutrition.', 22.00),
( 'Improve Endurance', 'Improving cardiovascular and muscular endurance through consistent aerobic exercises.', NULL),
( 'Increase Flexibility', 'Enhancing flexibility and range of motion through stretching and mobility exercises.', NULL);

INSERT INTO Diets ( Description, DietName)
VALUES 
( 'A plant-based diet excluding all animal products like meat, dairy, and eggs.', 'Vegan'),
( 'A diet excluding meat, but includes dairy products and eggs.', 'Vegetarian'),
( 'A diet that includes meat and animal products, but excludes dairy.', 'Pescetarian'),
( 'A diet that includes all food groups, focusing on balance and moderation.', 'Omnivore'),
( 'A diet with high fat, adequate protein, and low carbohydrates, promoting ketosis for weight loss.', 'Keto');

INSERT INTO Members (Username, Fname, Lname, Age, Weight, Height, AllowedCalorieIntake, Streak, Points, Gender, FitnessGoalID, DietID)
VALUES
('alice_johnson', 'Alice', 'Johnson', 25, 70.5, 165.3, 2000, 7, 150, 'F', 1, 1),
('bob_smith', 'Bob', 'Smith', 32, 85.0, 178.0, 2500, 12, 200, 'M', 2, 2),
('clara_davis', 'Clara', 'Davis', 28, 60.2, 160.5, 1800, 15, 180, 'F', 3, 3),
('david_wilson', 'David', 'Wilson', 35, 92.3, 183.2, 2700, 8, 210, 'M', 4, 4),
('eva_martinez', 'Eva', 'Martinez', 26, 75.0, 167.0, 2200, 10, 170, 'F', 5, 5),
('frank_lopez', 'Frank', 'Lopez', 30, 78.5, 172.5, NULL, 0, 0, 'M', 2, 2),
('grace_hernandez', 'Grace', 'Hernandez', 29, 64.0, 158.2, NULL, 0, 0, 'F', 3, 1),
('henry_gonzalez', 'Henry', 'Gonzalez', 27, 80.3, 175.8, 2600, 18, 250, 'M', 1, 4),
('isla_rodriguez', 'Isla', 'Rodriguez', 24, 68.9, 162.0, 2100, 22, 180, 'F', 4, 5),
('jack_brown', 'Jack', 'Brown', 33, 85.2, 180.3, 2400, 9, 190, 'M', 2, 3),
('kara_martinez', 'Kara', 'Martinez', 22, 59.8, 155.5, 1850, 6, 140, 'F', 3, 1),
('liam_taylor', 'Liam', 'Taylor', 31, 95.0, 185.0, NULL, 0, 0, 'M', 2, 4),
('mia_lee', 'Mia', 'Lee', 29, 70.2, 160.0, NULL, 0, 0, 'F', 5, 2),
('nina_scott', 'Nina', 'Scott', 26, 63.5, 162.5, 1900, 5, 160, 'F', 3, 1),
('oscar_walker', 'Oscar', 'Walker', 33, 89.0, 176.5, NULL, 0, 0, 'M', 4, 3),
('penny_adams', 'Penny', 'Adams', 24, 58.0, 154.5, 1800, 4, 130, 'F', 1, 5),
('quinn_roberts', 'Quinn', 'Roberts', 28, 77.5, 169.0, 2200, 12, 190, 'M', 5, 4),
('rachel_green', 'Rachel', 'Green', 34, 85.5, 180.0, NULL, 0, 0, 'F', 2, 3),
('sam_baker', 'Sam', 'Baker', 27, 80.0, 175.5, NULL, 0, 0, 'M', 1, 2),
('tina_harris', 'Tina', 'Harris', 29, 66.0, 168.5, NULL, 0, 0, 'F', 4, 5);



INSERT INTO HabitTypes ( TypeName)
VALUES
( 'Physical'),        -- Physical activities like exercise, walking, etc.
( 'Mental'),          -- Activities focused on mental health, mindfulness, meditation
( 'Dietary'),         -- Eating habits, calorie tracking, balanced nutrition
( 'Sleep'),           -- Sleep hygiene, getting enough rest, sleep consistency
( 'Hydration'),       -- Water intake, drinking adequate fluids
( 'Stress Management'); -- Managing stress, using techniques like breathing exercises


INSERT INTO DailyHabits ( HabitName, Description, Points, TypeID)
VALUES
('Morning Stretch', 'A daily stretching routine to start the day and improve flexibility.', 5, 1), -- Physical
('30-Minute Walk', 'A walk around the block to get fresh air and stay active.', 7, 1), -- Physical
('Meditation Session', 'A 10-minute daily meditation to improve mental clarity and reduce stress.', 10, 2), -- Mental
('Journaling', 'Write down your thoughts and feelings to improve mental well-being.', 8, 2), -- Mental
('Eat Vegetables', 'Include at least one serving of vegetables in your meals.', 6, 3), -- Dietary
('Sleep by 10 PM', 'Go to bed before 10 PM for better sleep quality and consistency.', 12, 4), -- Sleep
('Avoid Screen Time Before Bed', 'Refrain from using screens at least 30 minutes before bed.', 8, 4), -- Sleep
('Drink 2L of Water', 'Drink at least 2 liters of water throughout the day to stay hydrated.', 6, 5), -- Hydration
('Morning Hydration', 'Start your day by drinking a glass of water to rehydrate.', 4, 5), -- Hydration
( 'Practice Deep Breathing', 'Take 5 minutes to focus on deep breathing to reduce stress.', 10, 6); -- Stress Management


INSERT INTO TypesOfExercises ( TypeName)
VALUES
('Cardio'),         -- Activities that increase heart rate (e.g., running, cycling, swimming)
('Strength Training'), -- Exercises that build muscle strength (e.g., weightlifting, resistance training)
('Flexibility'),    -- Exercises that improve flexibility and range of motion (e.g., yoga, stretching)
('Balance & Stability'), -- Exercises focusing on balance, core strength, and stability (e.g., Pilates, stability ball)
('Endurance'),      -- Activities that improve stamina and long-term physical performance (e.g., long-distance running, swimming)
('HIIT'),           -- High-Intensity Interval Training, alternating between short intense bursts and rest
('Sports'),         -- Exercise activities that include team or individual sports (e.g., soccer, tennis)
('Functional Training'), -- Training that simulates real-life movements to improve overall strength and coordination (e.g., kettlebells, bodyweight exercises)
('Aquatic Exercise'), -- Exercises done in water to reduce impact on joints (e.g., water aerobics, swimming)
( 'Circuit Training'); -- A combination of strength and cardio exercises performed in a sequence (e.g., alternating squats, push-ups, and jump rope)


INSERT INTO Exercises ( ExerciseName, Description, CaloriesBurnedPerMin, PointsPerMin)
VALUES
('Running', 'Cardio workout that improves heart health and burns calories.', 10.0, 10),
('Swimming', 'Full-body workout that improves endurance and is low impact.', 8.5, 8),
('Cycling', 'Leg workout that builds strength and endurance.', 7.0, 7),
('Jumping Rope', 'High-intensity cardio that works the whole body.', 12.0, 12),
('Squats', 'Strengthens legs, glutes, and core muscles.', 5.5, 5),
('Push-ups', 'Bodyweight exercise for chest, arms, and core strength.', 4.5, 5),
('Pull-ups', 'Strengthens back, shoulders, and arms.', 6.0, 6),
('Burpees', 'Full-body, high-intensity exercise for strength and cardio.', 15.0, 15),
('Lunges', 'Targets legs and glutes, improves balance.', 6.0, 6),
( 'Planks', 'Core exercise for building stability and strength.', 3.0, 3),
( 'Deadlifts', 'Strength training for lower back, glutes, and hamstrings.', 7.5, 8),
( 'Box Jumps', 'Plyometric exercise to build leg power and stamina.', 11.0, 11),
( 'Mountain Climbers', 'Full-body exercise to improve core and cardiovascular fitness.', 8.0, 8),
( 'Kettlebell Swings', 'Full-body exercise for strength and conditioning.', 9.0, 9),
( 'Bicep Curls', 'Isolates biceps to build arm strength.', 2.5, 3),
( 'Tricep Dips', 'Bodyweight exercise to strengthen triceps and chest.', 4.0, 4),
( 'Leg Raises', 'Core exercise to strengthen lower abs.', 4.0, 4),
( 'Sprints', 'High-intensity running for leg strength and fat loss.', 15.0, 15),
( 'Treadmill Walking', 'Low-impact cardio for stamina and endurance.', 4.5, 4),
( 'Rowing', 'Full-body workout for back, arms, and core endurance.', 6.5, 7),
( 'Zumba', 'Dance workout for cardio, fun, and full-body toning.', 7.0, 7),
( 'Yoga', 'Flexibility and relaxation workout focusing on breathing and movement.', 3.5, 4),
( 'Pilates', 'Core strengthening and flexibility workout.', 4.0, 4),
( 'Kickboxing', 'Cardio and strength workout involving punching and kicking movements.', 9.5, 10),
( 'Tai Chi', 'Gentle martial art focusing on balance, coordination, and relaxation.', 3.0, 3),
( 'Barbell Rows', 'Strength training for back and shoulders using a barbell.', 6.0, 6),
( 'Chest Press', 'Strength training for chest and arms using weights.', 5.5, 5),
( 'Leg Press', 'Strengthens quads, hamstrings, and glutes using a machine.', 5.0, 5),
( 'Cable Machine Rows', 'Strengthens back, arms, and shoulders using cable machine.', 5.5, 6),
( 'Medicine Ball Slams', 'Full-body workout with explosive movements for strength and power.', 12.0, 12),
( 'Glute Bridges', 'Targets glutes and core, improves posture and strength.', 4.0, 4),
( 'Seated Shoulder Press', 'Strengthens shoulders and arms using a seated position and weights.', 4.5, 5),
( 'Tuck Jumps', 'Plyometric exercise for explosiveness and leg power.', 10.0, 10),
( 'Russian Twists', 'Core exercise for obliques using a twist movement.', 5.5, 6),
( 'Climbing Stairs', 'Cardio and strength workout for legs and cardiovascular health.', 7.5, 7),
( 'Bodyweight Squats', 'Strengthens legs and glutes using only body weight.', 4.5, 4),
( 'High Knees', 'Cardio workout that targets lower body and engages core.', 8.0, 8),
( 'Side Lunges', 'Targets glutes, hamstrings, and quads with a side step movement.', 6.5, 6),
( 'Trampoline Jumping', 'Fun, low-impact cardio that strengthens legs and improves cardiovascular health.', 9.0, 9),
( 'Handstand Push-ups', 'Advanced bodyweight exercise for shoulder strength and stability.', 7.0, 7);



INSERT INTO MemberLogExercise (MemberID, ExerciseID, DateTimeLogged, MinutesExercised, CaloriesBurned, PointsAwarded)
VALUES
(1, 1, '2024-11-01 08:00:00', 30, 250, 5),
(1, 2, '2024-11-01 10:30:00', 20, 180, 4),
(2, 3, '2024-11-02 09:00:00', 45, 350, 7),
(2, 4, '2024-11-02 14:15:00', 25, 220, 5),
(3, 5, '2024-11-03 11:00:00', 60, 500, 10),
(4, 6, '2024-11-03 12:30:00', 15, 120, 3),
(5, 7, '2024-11-04 08:15:00', 40, 320, 7),
(6, 8, '2024-11-04 09:45:00', 55, 440, 9),
(7, 9, '2024-11-05 07:30:00', 35, 280, 6),
(7, 10, '2024-11-05 13:00:00', 50, 400, 8),
(8, 11, '2024-11-06 06:45:00', 25, 200, 5),
(9, 12, '2024-11-06 11:30:00', 30, 270, 6),
(10, 13, '2024-11-07 10:00:00', 60, 550, 11),
(11, 14, '2024-11-07 13:15:00', 20, 150, 3),
(12, 15, '2024-11-08 09:30:00', 40, 320, 7),
(13, 16, '2024-11-08 14:00:00', 30, 240, 6),
(14, 17, '2024-11-09 07:00:00', 45, 375, 8),
(15, 18, '2024-11-09 12:30:00', 50, 420, 9),
(16, 19, '2024-11-10 08:00:00', 30, 250, 6),
(17, 20, '2024-11-10 10:30:00', 60, 500, 10),
(18, 1, '2024-11-11 09:15:00', 40, 350, 7),
(18, 3, '2024-11-11 14:00:00', 35, 300, 6),
(19, 2, '2024-11-12 08:30:00', 30, 250, 5),
(19, 5, '2024-11-12 10:00:00', 50, 420, 9),
(20, 6, '2024-11-13 11:30:00', 60, 500, 10),
(1, 7, '2024-11-13 14:00:00', 25, 200, 5),
(2, 8, '2024-11-14 09:15:00', 40, 320, 7),
(3, 9, '2024-11-14 12:30:00', 30, 270, 6),
(4, 10, '2024-11-15 08:00:00', 55, 440, 9),
(5, 11, '2024-11-15 14:30:00', 15, 120, 3),
(6, 12, '2024-11-16 09:00:00', 50, 400, 8),
(7, 13, '2024-11-16 13:15:00', 35, 300, 6),
(8, 14, '2024-11-17 07:30:00', 45, 375, 8),
(9, 15, '2024-11-17 10:30:00', 60, 500, 10),
(10, 16, '2024-11-18 09:00:00', 40, 350, 7),
(11, 17, '2024-11-18 13:00:00', 25, 220, 5),
(12, 18, '2024-11-19 11:15:00', 60, 550, 11),
(13, 19, '2024-11-19 13:45:00', 30, 270, 6),
(14, 20, '2024-11-20 09:30:00', 35, 320, 7),
(15, 1, '2024-11-20 14:00:00', 50, 420, 9),
(16, 2, '2024-11-21 08:30:00', 60, 500, 10),
(17, 3, '2024-11-21 12:00:00', 45, 375, 8),
(18, 4, '2024-11-22 07:00:00', 30, 250, 6),
(19, 5, '2024-11-22 09:30:00', 50, 420, 9),
(20, 6, '2024-11-23 13:30:00', 60, 500, 10),
(1, 7, '2024-11-23 16:00:00', 25, 220, 5),
(2, 8, '2024-11-24 10:15:00', 35, 300, 6),
(3, 9, '2024-11-24 14:00:00', 40, 350, 7),
(4, 10, '2024-11-25 09:00:00', 55, 440, 9),
(5, 11, '2024-11-25 12:00:00', 20, 180, 4),
(6, 12, '2024-11-26 08:30:00', 45, 375, 8),
(7, 13, '2024-11-26 13:30:00', 25, 220, 5),
(8, 14, '2024-11-27 10:00:00', 50, 420, 9),
(9, 15, '2024-11-27 15:00:00', 30, 270, 6),
(10, 16, '2024-11-28 08:30:00', 60, 500, 10),
(11, 17, '2024-11-28 13:00:00', 40, 320, 7),
(12, 18, '2024-11-29 09:15:00', 50, 420, 9),
(13, 19, '2024-11-29 12:30:00', 60, 550, 11),
(14, 20, '2024-11-30 10:00:00', 35, 300, 6),
(15, 1, '2024-11-30 13:15:00', 50, 400, 8),
(16, 2, '2024-12-01 07:30:00', 45, 375, 8),
(17, 3, '2024-12-01 10:00:00', 30, 270, 6),
(18, 4, '2024-12-02 09:00:00', 60, 500, 10);



INSERT INTO MemberLogCalories (MemberID, DateTimeLogged, CaloriesConsumed)
VALUES
(1, '2024-11-01 08:00:00', 450),
(1, '2024-11-01 18:00:00', 550),
(2, '2024-11-02 07:30:00', 600),
(2, '2024-11-02 13:00:00', 450),
(3, '2024-11-03 10:00:00', 700),
(3, '2024-11-03 20:00:00', 300),
(4, '2024-11-04 09:00:00', 350),
(4, '2024-11-04 14:00:00', 500),
(5, '2024-11-05 08:30:00', 400),
(5, '2024-11-05 19:30:00', 600),
(6, '2024-11-06 07:00:00', 500),
(6, '2024-11-06 12:30:00', 400),
(7, '2024-11-07 08:15:00', 700),
(8, '2024-11-07 13:30:00', 550),
(9, '2024-11-08 09:45:00', 350),
(9, '2024-11-08 16:00:00', 450),
(10, '2024-11-09 07:30:00', 600),
(10, '2024-11-09 18:00:00', 650),
(11, '2024-11-10 08:00:00', 750),
(11, '2024-11-10 19:00:00', 400),
(12, '2024-11-11 06:30:00', 450),
(13, '2024-11-11 12:00:00', 600),
(13, '2024-11-11 18:15:00', 500),
(14, '2024-11-12 07:45:00', 350),
(15, '2024-11-12 12:30:00', 400),
(15, '2024-11-12 16:00:00', 500),
(16, '2024-11-13 09:00:00', 600),
(16, '2024-11-13 13:00:00', 700),
(17, '2024-11-14 07:30:00', 500),
(17, '2024-11-14 15:00:00', 400),
(18, '2024-11-15 08:15:00', 550),
(18, '2024-11-15 14:30:00', 650),
(19, '2024-11-16 09:30:00', 300),
(19, '2024-11-16 18:30:00', 400),
(20, '2024-11-17 08:30:00', 500),
(1, '2024-11-17 19:00:00', 350),
(2, '2024-11-18 07:00:00', 600),
(3, '2024-11-18 13:30:00', 450),
(4, '2024-11-18 19:00:00', 700),
(5, '2024-11-19 08:00:00', 600),
(6, '2024-11-19 14:00:00', 500),
(7, '2024-11-20 08:45:00', 400),
(8, '2024-11-20 13:30:00', 350),
(9, '2024-11-21 08:00:00', 450),
(10, '2024-11-21 14:15:00', 550),
(11, '2024-11-22 10:00:00', 300),
(12, '2024-11-22 19:00:00', 650),
(13, '2024-11-23 08:30:00', 500),
(14, '2024-11-23 13:30:00', 700),
(15, '2024-11-24 09:15:00', 400),
(16, '2024-11-24 16:00:00', 600),
(17, '2024-11-25 07:00:00', 450),
(18, '2024-11-25 14:45:00', 500),
(19, '2024-11-26 09:30:00', 350),
(20, '2024-11-26 13:00:00', 550),
(1, '2024-11-27 08:30:00', 650),
(2, '2024-11-27 13:30:00', 400),
(3, '2024-11-28 07:00:00', 500),
(4, '2024-11-28 16:00:00', 600),
(5, '2024-11-29 08:00:00', 550),
(6, '2024-11-29 12:15:00', 400),
(7, '2024-11-30 08:30:00', 450),
(8, '2024-11-30 15:00:00', 700),
(9, '2024-12-01 07:30:00', 400),
(10, '2024-12-01 13:15:00', 500);


INSERT INTO Academies (Username, Name, Description, AreaOfExpertise, Accepted, CertificateTitle, CertificateDateOfIssue, CertificateExpirationDate, CertificateIssuingBody)
VALUES
('KickFitAcademy', 'KickFit Academy', 'A specialized academy for kickboxing and martial arts training', 'Kickboxing', 1, 'Kickboxing Instructor Certification', '2024-01-15', '2026-01-15', 'KickFit Certification Board'),
('ZenYogaAcademy', 'ZenYoga Academy', 'Focused on yoga training and mindfulness practices', 'Yoga', 1, 'Certified Yoga Instructor', '2023-10-01', '2025-10-01', 'ZenYoga Certification Authority'),
('RockClimbProAcademy', 'RockClimb Pro Academy', 'Rock climbing and bouldering expertise for all levels', 'Rock Climbing', 1, 'Rock Climbing Instructor Certificate', '2023-11-01', '2025-11-01', 'RockClimb Pro Institute'),
('StrengthXAcademy', 'StrengthX Academy', 'Strength and conditioning academy with focus on powerlifting', 'Powerlifting', 1, 'Certified Strength Coach', '2024-02-20', '2026-02-20', 'StrengthX Certifying Body'),
('FlexFitAcademy', 'FlexFit Academy', 'A fitness academy dedicated to flexibility and mobility', 'Flexibility & Mobility', 1, 'Mobility Specialist Certification', '2023-09-05', '2025-09-05', 'FlexFit Certification Authority'),
('TriathleteAcademy', 'Triathlete Academy', 'Training for triathlons, focusing on swimming, cycling, and running', 'Triathlon', 1, 'Certified Triathlon Coach', '2024-03-15', '2026-03-15', 'Triathlete Coaching Institute'),
('CrossFitNationAcademy', 'CrossFit Nation Academy', 'CrossFit training academy with dynamic fitness routines', 'CrossFit', 1, 'Certified CrossFit Trainer', '2024-04-10', '2026-04-10', 'CrossFit National Org'),
('PilatesCoreAcademy', 'PilatesCore Academy', 'Pilates training with a focus on core strength and posture', 'Pilates', 1, 'Certified Pilates Instructor', '2023-12-12', '2025-12-12', 'PilatesCore Certification Body'),
('BoxingProAcademy', 'BoxingPro Academy', 'Boxing skills academy for amateur and professional training', 'Boxing', 1, 'Certified Boxing Coach', '2024-05-30', '2026-05-30', 'BoxingPro Certification Authority'),
('EnduranceFitnessAcademy', 'Endurance Fitness Academy', 'Endurance training for marathon, ultra, and obstacle races', 'Endurance Sports', 1, 'Endurance Coach Certification', '2024-06-01', '2026-06-01', 'Endurance Fitness Institute'),
('YogaFlowAcademy', 'YogaFlow Academy', 'Advanced yoga techniques for strength and mental clarity', 'Yoga', 0, 'Advanced Yoga Certification', '2023-08-20', '2025-08-20', 'YogaFlow Certification Body'),
('ClimbingEdgeAcademy', 'ClimbingEdge Academy', 'Outdoor and indoor rock climbing courses for all ages', 'Rock Climbing', 1, 'Certified Climbing Instructor', '2024-07-15', '2026-07-15', 'ClimbingEdge Institute'),
('FitDanceAcademy', 'FitDance Academy', 'Dance and fitness fusion academy for fun workouts', 'Dance Fitness', 0, 'Certified Dance Fitness Instructor', '2024-02-25', '2026-02-25', 'FitDance Academy Body'),
('MindBodyAcademy', 'MindBody Academy', 'Meditation and fitness combined for holistic wellness', 'Meditation & Fitness', 1, 'Holistic Fitness Coach', '2023-10-25', '2025-10-25', 'MindBody Wellness Council'),
('TrailRunnerAcademy', 'TrailRunner Academy', 'Training for trail running with a focus on endurance and technique', 'Trail Running', 1, 'Certified Trail Running Coach', '2024-01-05', '2026-01-05', 'TrailRunner Org'),
('BikramYogaAcademy', 'Bikram Yoga Academy', 'Hot yoga training for strength and detoxification', 'Bikram Yoga', 1, 'Bikram Yoga Certification', '2023-11-25', '2025-11-25', 'Bikram Yoga Certifying Body'),
('MixedMartialArtsAcademy', 'MixedMartialArts Academy', 'MMA training and conditioning with a focus on combat sports', 'MMA', 0, 'Certified MMA Trainer', '2024-05-10', '2026-05-10', 'MixedMartialArts Certification Org'),
('PowerCycleAcademy', 'PowerCycle Academy', 'Cycling academy for road and mountain biking enthusiasts', 'Cycling', 1, 'Certified Cycling Coach', '2023-09-10', '2025-09-10', 'PowerCycle Academy Body'),
('BeachFitAcademy', 'BeachFit Academy', 'Beach fitness programs combining bodyweight training and cardio', 'Beach Fitness', 1, 'Certified Beach Fitness Trainer', '2024-06-30', '2026-06-30', 'BeachFit Certification Authority'),
('StrengthLabAcademy', 'StrengthLab Academy', 'Strength training and bodybuilding academy focused on hypertrophy', 'Bodybuilding', 1, 'Certified Bodybuilding Coach', '2024-04-22', '2026-04-22', 'StrengthLab Certification Body');

INSERT INTO Sessions (SessionID, Description, Price, Limit, FullSession, Duration, Location, Date, Time, AcademyID)
VALUES
(1, 'Kickboxing training session for beginners', 30, 20, 0, '01:30:00', 'KickFit Academy Main Hall', '2024-12-05', '10:00:00', 1),
(2, 'Advanced kickboxing techniques for experienced practitioners', 50, 15, 0, '01:45:00', 'KickFit Academy Main Hall', '2024-12-06', '12:00:00', 1),
(1, 'Relaxing yoga session focusing on flexibility', 20, 25, 0, '01:00:00', 'ZenYoga Academy Studio A', '2024-12-07', '09:00:00', 2),
(1, 'Intense powerlifting workout with expert coaching', 40, 2, 1, '02:00:00', 'StrengthX Academy Gym', '2024-12-08', '14:00:00', 4),
(2, 'Strength and endurance training session', 35, 15, 0, '01:30:00', 'StrengthX Academy Gym', '2024-12-09', '16:00:00', 4),
(1, 'Rock climbing training for beginners', 45, 12, 0, '02:00:00', 'RockClimb Pro Academy Boulder Room', '2024-12-10', '11:00:00', 3),
(2, 'Advanced rock climbing techniques for experienced climbers', 60, 8, 0, '02:30:00', 'RockClimb Pro Academy Boulder Room', '2024-12-11', '14:00:00', 3),
(1, 'Hot yoga session for strength and detox', 30, 20, 0, '01:30:00', 'Bikram Yoga Academy Studio 1', '2024-12-12', '17:00:00', 16),
(1, 'Cycling training session for endurance athletes', 25, 20, 0, '01:30:00', 'PowerCycle Academy Outdoor Track', '2024-12-13', '08:00:00', 18),
(2, 'Advanced cycling techniques for competitive riders', 40, 10, 0, '02:00:00', 'PowerCycle Academy Outdoor Track', '2024-12-14', '11:00:00', 18);


INSERT INTO ReservedSession (MemberID, SessionID, AcademyID, NumberOfSeats)
VALUES
(1, 1, 1, 3),  -- Member 1 reserves 3 seats for Session 1 (Kickboxing training)
(2, 2, 1, 2),  -- Member 2 reserves 2 seats for Session 2 (Advanced kickboxing)
(11, 1, 2, 1),  -- Member 11 reserves 1 seat for Session 1 (Relaxing yoga)
(4, 1, 4, 2) -- Member 4 reserves 2 seats for Session 1 (Powerlifting workout)



INSERT INTO Meals 
(MealID, Steps, Ingredients, Duration, MealType, CaloriesPerServing, MealName, Fats, Protein, Carbs, DatePosted, CoachID)
VALUES
(1, 'Mix oats with milk and let sit overnight.', 'Oats, Milk, Honey, Berries', '00:05:00', 'Breakfast', 350, 'Overnight Oats', 7.5, 12.0, 45.0, '2024-12-01', 3),
(2, 'Grill chicken and steam vegetables.', 'Chicken, Broccoli, Carrots, Olive Oil', '00:25:00', 'Lunch', 400, 'Grilled Chicken with Veggies', 8.0, 35.0, 20.0, '2024-12-02', 1),
(3, 'Boil eggs and toast bread.', 'Eggs, Whole-grain Bread, Avocado', '00:10:00', 'Breakfast', 300, 'Avocado Toast with Eggs', 12.0, 15.0, 25.0, '2024-12-01', 5),
(4, 'Cook lentils with spices.', 'Lentils, Onions, Garlic, Spices', '00:30:00', 'Dinner', 380, 'Spicy Lentil Soup', 5.0, 20.0, 50.0, '2024-12-01', 2),
(5, 'Blend fruits and milk.', 'Banana, Milk, Peanut Butter', '00:05:00', 'Snack', 250, 'Banana Smoothie', 7.0, 10.0, 30.0, '2024-12-02', 7),
(6, 'Bake salmon with lemon and garlic.', 'Salmon, Lemon, Garlic, Olive Oil', '00:20:00', 'Dinner', 450, 'Baked Lemon Garlic Salmon', 15.0, 40.0, 5.0, '2024-12-03', 3),
(7, 'Mix yogurt with fruits and nuts.', 'Greek Yogurt, Berries, Almonds', '00:05:00', 'Snack', 200, 'Fruit and Yogurt Parfait', 6.0, 10.0, 20.0, '2024-12-02', 8),
(8, 'Cook rice and chicken together.', 'Chicken, Rice, Vegetables', '00:40:00', 'Lunch', 500, 'Chicken Fried Rice', 10.0, 25.0, 60.0, '2024-12-01', 1),
(9, 'Chop vegetables and prepare dressing.', 'Lettuce, Tomatoes, Cucumbers, Olive Oil', '00:10:00', 'Anything', 180, 'Garden Salad', 8.0, 2.0, 15.0, '2024-12-03', 4),
(10, 'Grill beef and slice cheese.', 'Beef, Cheese, Whole-grain Bun', '00:15:00', 'Dinner', 600, 'Beef Cheeseburger', 25.0, 35.0, 40.0, '2024-12-02', 5),
(11, 'Bake granola with honey.', 'Oats, Honey, Almonds, Raisins', '00:35:00', 'Snack', 220, 'Homemade Granola', 6.0, 8.0, 30.0, '2024-12-04', 10),
(12, 'Roast sweet potatoes.', 'Sweet Potatoes, Olive Oil, Cinnamon', '00:25:00', 'Snack', 180, 'Roasted Sweet Potatoes', 3.0, 2.0, 35.0, '2024-12-01', 7),
(13, 'Bake chicken wings with BBQ sauce.', 'Chicken Wings, BBQ Sauce, Spices', '00:30:00', 'Dinner', 420, 'BBQ Chicken Wings', 15.0, 30.0, 15.0, '2024-12-03', 3),
(14, 'Toast bread and spread peanut butter.', 'Whole-grain Bread, Peanut Butter', '00:05:00', 'Breakfast', 250, 'Peanut Butter Toast', 10.0, 8.0, 25.0, '2024-12-02', 8),
(15, 'Cook spaghetti and prepare sauce.', 'Spaghetti, Tomato Sauce, Cheese', '00:25:00', 'Lunch', 400, 'Spaghetti Marinara', 9.0, 15.0, 60.0, '2024-12-02', 12),
(16, 'Prepare green smoothie.', 'Spinach, Banana, Almond Milk', '00:05:00', 'Snack', 150, 'Green Smoothie', 2.5, 5.0, 25.0, '2024-12-04', 15),
(17, 'Marinate and grill steak.', 'Beef, Garlic, Olive Oil', '00:35:00', 'Dinner', 550, 'Grilled Steak', 20.0, 50.0, 0.0, '2024-12-05', 11),
(18, 'Cook quinoa and mix with veggies.', 'Quinoa, Bell Peppers, Olive Oil', '00:20:00', 'Lunch', 350, 'Quinoa Veggie Bowl', 10.0, 12.0, 45.0, '2024-12-02', 6),
(19, 'Prepare hummus with pita.', 'Chickpeas, Tahini, Pita Bread', '00:10:00', 'Snack', 300, 'Hummus and Pita', 12.0, 10.0, 35.0, '2024-12-01', 9),
(20, 'Roast vegetables with herbs.', 'Carrots, Zucchini, Olive Oil, Herbs', '00:30:00', 'Dinner', 250, 'Herb-Roasted Veggies', 8.0, 3.0, 20.0, '2024-12-03', 3);


INSERT INTO MealBelongsToDiets (MealID, CoachID, DietID)
VALUES
-- Vegan Meals
(1, 3, 1), -- Overnight Oats (Vegan)
(4, 2, 1), -- Spicy Lentil Soup (Vegan)
(5, 7, 1), -- Banana Smoothie (Vegan)
(9, 4, 1), -- Garden Salad (Vegan)
(11, 10, 1), -- Homemade Granola (Vegan)
(16, 15, 1), -- Green Smoothie (Vegan)
(18, 6, 1), -- Quinoa Veggie Bowl (Vegan)
(19, 9, 1), -- Hummus and Pita (Vegan)

-- Vegetarian Meals
(3, 5, 2), -- Avocado Toast with Eggs (Vegetarian)
(7, 8, 2), -- Fruit and Yogurt Parfait (Vegetarian)
(9, 4, 2), -- Garden Salad (Vegetarian)
(14, 8, 2), -- Peanut Butter Toast (Vegetarian)
(15, 12, 2), -- Spaghetti Marinara (Vegetarian)

-- Pescetarian Meals
(6, 3, 3), -- Baked Lemon Garlic Salmon (Pescetarian)

-- Omnivore Meals
(2, 1, 4), -- Grilled Chicken with Veggies (Omnivore)
(6, 3, 4), -- Baked Lemon Garlic Salmon (Omnivore)
(8, 1, 4), -- Chicken Fried Rice (Omnivore)
(10, 5, 4), -- Beef Cheeseburger (Omnivore)
(13, 3, 4), -- BBQ Chicken Wings (Omnivore)
(17, 11, 4), -- Grilled Steak (Omnivore)

-- Keto Meals
(20, 3, 5); -- Zucchini Noodles with Pesto (Keto)


INSERT INTO FeedbackTypes ( TypeName) VALUES
( 'Recommendation'),       -- Suggesting new features or changes
( 'Complaint'),            -- Complaints about services, coaches, or system issues
( 'Positive Feedback'),    -- Praising the coach, service, or experience
( 'Bug Report');          -- Reporting bugs in the system (app, website, etc.)

INSERT INTO Feedback ( Comment, Rating, FeedbackTypeID, DatePosted) VALUES
( 'The app could use a feature for saving favorite workouts.', 4.5, 1, '2024-12-01 10:30:00'),  -- Member Feedback: Recommendation
( 'The coach was rude and didn’t explain the exercises well.', 1.0, 2, '2024-12-02 14:00:00'),  -- Member Feedback: Complaint
( 'Great workout session, really enjoying the app!', 5.0, 3, '2024-12-02 15:15:00'),  -- Member Feedback: Positive Feedback
( 'There’s a bug where the app crashes when trying to load my profile.', 2.5, 4, '2024-12-03 09:45:00'),  -- Member Feedback: Bug Report
( 'I would suggest adding more flexibility in the workout plans.', 4.0, 1, '2024-12-04 16:00:00');  -- Coach Feedback: Recommendation

INSERT INTO MemberFeedback (FeedbackID, MemberID) VALUES
(1, 5),  
(2, 3),  
(3, 7),  
(4, 3);


INSERT INTO CoachFeedback (FeedbackID, CoachID) VALUES
(5, 2);

INSERT INTO CoachedBy(MemberID,CoachID,Rating,Ongoing,Accepted)
VALUES
(1,1,5,0,1),
(1,2,3,0,1),
(1,3,NULL,0,1),
(1,4,5,1,1),

(2,1,5,0,1),
(2,5,NULL,0,1),
(2,3,4,0,1),
(2,4,5,1,1),

(3,6,5,0,1),
(3,7,3,0,1),
(3,8,NULL,0,1),


(4,1,0,0,1),
(4,2,NULL,0,1),
(4,3,2,0,1),
(4,12,NULL,1,1),

(5,1,5,0,1),

(6,2,3,0,1),
(6,3,NULL,0,1),
(6,4,5,1,1),

(7,2,3,1,1)

INSERT INTO BadgesEarned(MemberID, CoachID, BadgeID, DateEarned) VALUES
(1,1,17,'2024-01-15'),
(1,2,16,'2024-05-22'),
(1,NULL,1,'2024-01-15'),
(1,NULL,2,'2024-01-15'),
(1,NULL,3,'2024-01-15'),

(2,1,17,'2024-01-15'),
(2,3,16,'2024-05-22'),
(2,5,12,'2024-01-15'),
(2,NULL,2,'2024-01-15'),
(2,NULL,3,'2024-01-15'),

(10,NULL,1,'2024-01-15'),
(10,NULL,2,'2024-05-22'),
(10,NULL,3,'2024-01-15'),
(10,NULL,4,'2024-01-15'),
(10,NULL,5,'2024-01-15'),

(3,6,17,'2024-01-15'),
(3,7,16,'2024-05-22'),
(3,8,12,'2024-01-15'),

(8,NULL,2,'2024-01-15'),
(8,NULL,3,'2024-01-15')

INSERT INTO CompletedChallenge(MemberID,CoachID,ChallengeID)
Values
(1,1,1),
(1,2,2),
(1,3,3),

(2,1,1),
(2,5,5),
(2,3,3),
(2,4,4)


INSERT INTO ExerciseTypes (ExerciseID, TypeID) VALUES
(1, 1),  -- Running -> Cardio
(1, 5),  -- Running -> Endurance
(2, 9),  -- Swimming -> Aquatic Exercise
(2, 1),  -- Swimming -> Cardio
(2, 5),  -- Swimming -> Endurance
(3, 1),  -- Cycling -> Cardio
(3, 5),  -- Cycling -> Endurance
(4, 6),  -- Jumping Rope -> HIIT
(4, 1),  -- Jumping Rope -> Cardio
(4, 5),  -- Jumping Rope -> Endurance
(5, 2),  -- Squats -> Strength Training
(5, 4),  -- Squats -> Balance & Stability
(6, 2),  -- Push-ups -> Strength Training
(6, 4),  -- Push-ups -> Balance & Stability
(7, 2),  -- Pull-ups -> Strength Training
(7, 5),  -- Pull-ups -> Endurance
(8, 6),  -- Burpees -> HIIT
(8, 1),  -- Burpees -> Cardio
(9, 2),  -- Lunges -> Strength Training
(9, 4),  -- Lunges -> Balance & Stability
(10, 3), -- Planks -> Flexibility
(10, 4), -- Planks -> Balance & Stability
(11, 2), -- Deadlifts -> Strength Training
(11, 5), -- Deadlifts -> Endurance
(12, 6), -- Box Jumps -> HIIT
(12, 2), -- Box Jumps -> Strength Training
(13, 6), -- Mountain Climbers -> HIIT
(13, 1), -- Mountain Climbers -> Cardio
(14, 6), -- Kettlebell Swings -> HIIT
(14, 2), -- Kettlebell Swings -> Strength Training
(15, 2), -- Bicep Curls -> Strength Training
(16, 2), -- Tricep Dips -> Strength Training
(16, 4), -- Tricep Dips -> Balance & Stability
(17, 4), -- Leg Raises -> Balance & Stability
(17, 3), -- Leg Raises -> Flexibility
(18, 1), -- Sprints -> Cardio
(18, 5), -- Sprints -> Endurance
(19, 5), -- Treadmill Walking -> Endurance
(19, 1), -- Treadmill Walking -> Cardio
(20, 8), -- Rowing -> Functional Training
(20, 1), -- Rowing -> Cardio
(21, 1), -- Zumba -> Cardio
(21, 5), -- Zumba -> Endurance
(22, 3), -- Yoga -> Flexibility
(22, 4), -- Yoga -> Balance & Stability
(23, 3), -- Pilates -> Flexibility
(23, 4), -- Pilates -> Balance & Stability
(24, 10), -- Kickboxing -> Circuit Training
(24, 1),  -- Kickboxing -> Cardio
(24, 2),  -- Kickboxing -> Strength Training
(25, 4), -- Tai Chi -> Balance & Stability
(25, 3), -- Tai Chi -> Flexibility
(26, 2), -- Barbell Rows -> Strength Training
(27, 2), -- Chest Press -> Strength Training
(27, 5), -- Chest Press -> Endurance
(28, 2), -- Leg Press -> Strength Training
(29, 2), -- Cable Machine Rows -> Strength Training
(30, 6), -- Medicine Ball Slams -> HIIT
(30, 2), -- Medicine Ball Slams -> Strength Training
(31, 2), -- Glute Bridges -> Strength Training
(31, 4), -- Glute Bridges -> Balance & Stability
(32, 2), -- Seated Shoulder Press -> Strength Training
(33, 6), -- Tuck Jumps -> HIIT
(33, 1), -- Tuck Jumps -> Cardio
(34, 2), -- Russian Twists -> Strength Training
(34, 4), -- Russian Twists -> Balance & Stability
(35, 1), -- Climbing Stairs -> Cardio
(35, 5), -- Climbing Stairs -> Endurance
(36, 2), -- Bodyweight Squats -> Strength Training
(36, 4), -- Bodyweight Squats -> Balance & Stability
(37, 1), -- High Knees -> Cardio
(37, 6), -- High Knees -> HIIT
(38, 2), -- Side Lunges -> Strength Training
(38, 4), -- Side Lunges -> Balance & Stability
(39, 1), -- Trampoline Jumping -> Cardio
(39, 5), -- Trampoline Jumping -> Endurance
(40, 2), -- Handstand Push-ups -> Strength Training
(40, 4); -- Handstand Push-ups -> Balance & Stability




INSERT INTO TracksHabit (MemberID, HabitID, DateTracked) VALUES
(1, 1, '2024-12-01'), -- Member 1 tracks Habit 1
(1, 1, '2024-12-05'), -- Member 1 tracks Habit 1 again on a different day
(2, 2, '2024-12-02'), -- Member 2 tracks Habit 2
(2, 2, '2024-12-06'), -- Member 2 tracks Habit 2 again
(3, 3, '2024-12-03'), -- Member 3 tracks Habit 3
(3, 3, '2024-12-07'), -- Member 3 tracks Habit 3 again
(4, 4, '2024-12-01'), -- Member 4 tracks Habit 4
(4, 4, '2024-12-02'), -- Member 4 tracks Habit 4 on a different day
(5, 5, '2024-12-01'), -- Member 5 tracks Habit 5
(5, 5, '2024-12-06'), -- Member 5 tracks Habit 5 again
(6, 6, '2024-12-03'), -- Member 6 tracks Habit 6
(7, 7, '2024-12-04'), -- Member 7 tracks Habit 7
(7, 7, '2024-12-05'), -- Member 7 tracks Habit 7 on a different day
(8, 8, '2024-12-01'), -- Member 8 tracks Habit 8
(8, 8, '2024-12-06'), -- Member 8 tracks Habit 8 again
(9, 9, '2024-12-02'), -- Member 9 tracks Habit 9
(9, 9, '2024-12-07'), -- Member 9 tracks Habit 9 again
(10, 10, '2024-12-03'), -- Member 10 tracks Habit 10
(11, 1, '2024-12-04'), -- Member 11 tracks Habit 1
(12, 2, '2024-12-01'), -- Member 12 tracks Habit 2
(13, 3, '2024-12-06'), -- Member 13 tracks Habit 3
(14, 4, '2024-12-07'), -- Member 14 tracks Habit 4
(15, 5, '2024-12-02'), -- Member 15 tracks Habit 5
(16, 6, '2024-12-05'); -- Member 16 tracks Habit 6

INSERT INTO SuggestedCalories (MemberID, CoachID, SuggestedCalroies, DateSuggested)
VALUES
-- Member 1
(1, 1, 2500, '2024-01-15'),
(1, 2, 2300, '2024-01-15'),
(1, 3, 2200, '2024-01-15'),
(1, 4, 2500, '2024-02-01'),

-- Member 2
(2, 1, 2700, '2024-01-15'),
(2, 5, 2400, '2024-01-15'),
(2, 3, 2300, '2024-02-01'),
(2, 4, 2700, '2024-02-01'),

-- Member 3
(3, 6, 2500, '2024-01-15'),
(3, 7, 2400, '2024-01-15'),
(3, 8, 2200, '2024-02-01'),

-- Member 4
(4, 1, 2000, '2024-01-15'),
(4, 2, 2100, '2024-01-15'),
(4, 3, 1800, '2024-02-01'),
(4, 12, 1900, '2024-02-01'),

-- Member 5
(5, 1, 2600, '2024-01-15'),

-- Member 6
(6, 2, 2300, '2024-01-15'),
(6, 3, 2200, '2024-01-15'),
(6, 4, 2500, '2024-02-01'),

-- Member 7
(7, 2, 2400, '2024-01-15');


INSERT INTO SuggestedExercises (MemberID, CoachID, ExerciseID, DateSuggested)
VALUES
-- Member 1
(1, 1, 1, '2024-01-15'),   -- Running
(1, 1, 3, '2024-01-15'),   -- Cycling
(1, 2, 2, '2024-01-15'),   -- Swimming
(1, 2, 4, '2024-01-15'),   -- Jumping Rope
(1, 3, 5, '2024-01-15'),   -- Squats
(1, 3, 9, '2024-01-15'),   -- Lunges
(1, 4, 6, '2024-02-01'),   -- Push-ups
(1, 4, 8, '2024-02-01'),   -- Burpees

-- Member 2
(2, 1, 10, '2024-01-15'),  -- Planks
(2, 1, 13, '2024-01-15'),  -- Mountain Climbers
(2, 5, 7, '2024-01-15'),   -- Pull-ups
(2, 5, 11, '2024-02-01'),  -- Deadlifts
(2, 3, 15, '2024-02-01'),  -- Bicep Curls
(2, 3, 17, '2024-02-01'),  -- Leg Raises
(2, 4, 18, '2024-03-01'),  -- Sprints
(2, 4, 16, '2024-03-01'),  -- Tricep Dips

-- Member 3
(3, 6, 20, '2024-01-15'),  -- Rowing
(3, 6, 12, '2024-01-15'),  -- Box Jumps
(3, 7, 19, '2024-02-01'),  -- Treadmill Walking
(3, 7, 14, '2024-02-01'),  -- Kettlebell Swings
(3, 8, 5, '2024-02-01'),   -- Squats
(3, 8, 3, '2024-03-01'),   -- Cycling

-- Member 4
(4, 1, 6, '2024-02-01'),   -- Push-ups
(4, 1, 8, '2024-02-01'),   -- Burpees
(4, 2, 15, '2024-02-01'),  -- Bicep Curls
(4, 2, 17, '2024-03-01'),  -- Leg Raises
(4, 3, 20, '2024-03-01'),  -- Rowing
(4, 3, 10, '2024-03-01'),  -- Planks
(4, 12, 16, '2024-04-01'), -- Tricep Dips
(4, 12, 18, '2024-04-01'), -- Sprints

-- Member 5
(5, 1, 7, '2024-01-15'),   -- Pull-ups
(5, 1, 19, '2024-01-15')  -- Treadmill Walking


-- trigger that happens when user is deleted instead of cascading deletes
GO
CREATE TRIGGER trg_DeleteUser
ON Users
FOR DELETE
AS
BEGIN

    DELETE FROM Members
    WHERE Username IN (SELECT Username FROM DELETED);


    DELETE FROM Coaches
    WHERE Username IN (SELECT Username FROM DELETED);


    DELETE FROM Academies
    WHERE Username IN (SELECT Username FROM DELETED);
END;

---- Creating a trigger for sessions so that pk autoincrements
--Go
--CREATE TRIGGER trg_SessionID
--ON Sessions
--INSTEAD OF INSERT
--AS
--BEGIN
--    DECLARE @NewSessionID INT, @AcademyID INT;
--
--    -- hageeb the academy id
--    SELECT @AcademyID = AcademyID FROM inserted;
--
--    -- get the new session id
--	-- is null -> incase there are no sessions from this academy
--    SELECT @NewSessionID = ISNULL(MAX(SessionID), 0) + 1 FROM Sessions WHERE AcademyID = @AcademyID;
--
--
--    INSERT INTO Sessions (SessionID, Description, Price, Limit, Duration, FullSession, Location, Date, Time, AcademyID)
--    SELECT @NewSessionID, Description, Price, Limit, Duration, FullSession, Location, Date, Time, AcademyID
--    FROM inserted;
--END;

