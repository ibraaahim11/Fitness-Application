using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Diagnostics;
using static Syncfusion.Windows.Forms.Tools.TextBoxExt;
using System.Security.Cryptography;
using System.Xml.Linq;
using Syncfusion.Windows.Forms.Tools;
using System.Windows.Forms.Design;
using System.Data.SqlClient;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        // Academy Functions
        public int GetAcademyID(string username)
        {
            string query = $"SELECT AcademyID FROM Academies WHERE Username = '{username}'";
            return (int)dbMan.ExecuteScalar(query);
        }
        public string GetAcademyName(int ID)
        {
            string query = $"SELECT Name FROM Academies WHERE AcademyID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        // Academy Profile Function

        // Profile part

        // Getting
        public string GetAcademyUsername(int ID)
        {
            string query = $"SELECT AreaOfExpertise FROM Academies WHERE AcademyID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string GetAcademyAOE(int ID)
        {
            string query = $"SELECT AreaOfExpertise FROM Academies WHERE AcademyID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string GetAcademyDescription(int ID)
        {
            string query = $"SELECT Description FROM Academies WHERE AcademyID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string GetAcademyPassword(string username)
        {
            string query = $"SELECT Password FROM Users WHERE Username = '{username}'";
            return (string)dbMan.ExecuteScalar(query);
        }


        // Updating
        public int UpdateBasicAcademyProfile(int ID, string Name, string Description, string AOE)
        {
            string query = $"UPDATE Academies SET Name = '{Name}', Description = '{Description}', AreaOfExpertise = '{AOE}' WHERE AcademyID = {ID}";
            return dbMan.ExecuteNonQuery(query);

        }
        public int UpdateUsernamePasswordAcademy(string OldUsername, string NewUsername, string password)
        {
            string query = $"UPDATE Users SET Username = '{NewUsername}', Password = '{password}' WHERE Username = '{OldUsername}'";
            return dbMan.ExecuteNonQuery(query);

        }

        // Certificate part
        // Getting
        public string GetAcademyCertificateTitle(int ID)
        {
            string query = $"SELECT CertificateTitle FROM Academies WHERE AcademyID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string GetAcademyCertificateDateOfIssue(int ID)
        {
            string query = $"SELECT CertificateDateOfIssue FROM Academies WHERE AcademyID = {ID}";
            object result = dbMan.ExecuteScalar(query);

            DateTime certificateDate = (DateTime)result;
            return certificateDate.ToString("yyyy-MM-dd"); // or any other desired forma

        }
        public string GetAcademyCertificateIssuingBody(int ID)
        {
            string query = $"SELECT CertificateIssuingBody FROM Academies WHERE AcademyID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string GetAcademyCertificateExpirationDate(int ID)
        {
            string query = $"SELECT CertificateExpirationDate FROM Academies WHERE AcademyID = {ID}";
            object result = dbMan.ExecuteScalar(query);

            DateTime certificateDate = (DateTime)result;
            return certificateDate.ToString("yyyy-MM-dd"); // or any other desired forma
        }
        // Updating
        public int UpdateAcademyCertificate(int ID, string Title, string DateOfIssue, string IssuingBody, string ExpirationDate)
        {
            string query = $"UPDATE Academies SET CertificateTitle = '{Title}', CertificateDateOfIssue = '{DateOfIssue}', CertificateIssuingBody = '{IssuingBody}', CertificateExpirationDate = '{ExpirationDate}'  WHERE AcademyID = {ID}";
            return dbMan.ExecuteNonQuery(query);

        }

        // Academy Post Session

        // Inserting 
        public int AcademyInsertSession(string description, float price, int limit, string duration, string location, string date, string time, int academyId)
        {
            // Session should not be empty
            int fullSession = 0;
            // new session id
            int SessionID = GetCountSessionFromAcademy(academyId) + 1;

            string query = $"INSERT INTO Sessions (SessionID, Description, Price, Limit, Duration, FullSession, Location, Date, Time, AcademyID) " +
                           $"VALUES ({SessionID},'{description}', {price}, {limit}, '{duration}',{fullSession}, '{location}', '{date}', '{time}', {academyId})";
            return dbMan.ExecuteNonQuery(query);
        }
        public int GetCountSessionFromAcademy(int ID)
        {
            string query = $"SELECT COUNT(*) FROM Sessions WHERE AcademyID = {ID}";
            return (int)dbMan.ExecuteScalar(query);
        }

        //coach functionalities 
        //getting all the coach info
        public int GetCoachID(string username)
        {
            string query = $"SELECT CoachID FROM Coaches WHERE Username ='{username}'";
            return (int)dbMan.ExecuteScalar(query);
        }
        public string GetCoachName(int ID)
        {
            string query = $"SELECT Fname FROM Coaches WHERE CoachID={ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string GetCoachLastName(int ID)
        {
            string query = $"SELECT Lname FROM Coaches WHERE CoachID={ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string GetGender(int ID)
        {
            string query = $"SELECT Gender FROM Coaches WHERE CoachID={ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int GetCoachAge(int ID)
        {
            string query = $"SELECT Age FROM Coaches WHERE CoachID={ID}";
            return (int)dbMan.ExecuteScalar(query);

        }

        public int GetMemberLimit(int ID)
        {
            string query = $"SELECT MemberLimit FROM Coaches WHERE CoachID={ID}";
            return (int)dbMan.ExecuteScalar(query);
        }

        public string GetCoachPassword(string username)
        {
            string query = $"SELECT Password FROM Users WHERE Username = '{username}'";
            return (string)dbMan.ExecuteScalar(query);
        }
        public int UpdateCoachProfile(string fname,string lname,int coachid,string gender, int age)
        {
            if (gender == "Female")
            {
                gender = "F";
            }
            else
            {
                gender = "M";
            }
            string query = $"UPDATE Coaches SET Fname = '{fname}', Lname = '{lname}', Age = '{age}', Gender='{gender}' WHERE CoachID = {coachid}";
            return dbMan.ExecuteNonQuery(query);

        }
        public int UpdateUsernamePasswordCoach(string OldUsername, string NewUsername, string password)
        {
            string query = $"UPDATE Users SET Username = '{NewUsername}', Password = '{password}' WHERE Username = '{OldUsername}'";
            return dbMan.ExecuteNonQuery(query);

        }
        public int UpdateCoachCertificate(int ID, string Title, string DateOfIssue, string IssuingBody, string ExpirationDate)
        {
            string query = $"UPDATE Coaches SET CertificateTitle = '{Title}', CertificateDateOfIssue = '{DateOfIssue}', CertificateIssuingBody = '{IssuingBody}', CertificateExpirationDate = '{ExpirationDate}'  WHERE AcademyID = {ID}";
            return dbMan.ExecuteNonQuery(query);

        }
        //to get all certificate info
        public string GetCoachCertificateTitle(int ID)
        {
            string query = $"SELECT CertificateTitle FROM Coaches WHERE CoachID={ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string GetCoachCertificateDateOfIssue(int ID)
        {
            string query = $"SELECT CertificateDateOfIssue FROM Coaches WHERE CoachID = {ID}";
            object result = dbMan.ExecuteScalar(query);

            DateTime certificateDate = (DateTime)result;
            return certificateDate.ToString("yyyy-MM-dd"); // or any other desired forma

        }
        public string GetCoachCertificateIssuingBody(int ID)
        {
            string query = $"SELECT CertificateIssuingBody FROM Coaches WHERE CoachID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string GetCoachCertificateExpirationDate(int ID)
        {
            string query = $"SELECT CertificateExpirationDate FROM Coaches WHERE CoachID = {ID}";
            object result = dbMan.ExecuteScalar(query);

            DateTime certificateDate = (DateTime)result;
            return certificateDate.ToString("yyyy-MM-dd"); // or any other desired forma
        }

        //view member 
        //public int GetMemberID(string username)
        //{
        //    string query = $"SELECT MemberID FROM Members WHERE Username={username}";
        //    return (int)dbMan.ExecuteScalar(query);
        //}

        public int GetMemberID(string username)
        {
            string query = $"SELECT MemberID FROM Members WHERE Username = '{username}'";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["MemberID"]);
            }
            else
            {
                throw new Exception("Username not found.");
            }
        }

        public DataTable ViewMember(int ID)
        {
            string query = $"SELECT m.Fname, m.Lname, m.Age, m.Weight, m.Height, m.AllowedCalorieIntake, m.Streak, m.Points, m.Gender, fg.GoalName, d.DietName  " +
                          $"FROM Members m  " +
                          $"LEFT JOIN FitnessGoals fg ON m.FitnessGoalID = fg.GoalID  " +
                          $"LEFT JOIN Diets d ON m.DietID = d.DietID WHERE m.MemberID = {ID}";
            return dbMan.ExecuteReader(query);

        }
        public DataTable GetUsernamesofMembers(int ID)
        {
            string query = $"SELECT m.Username, m.Points " +
                $"FROM Members m " +
                $"INNER JOIN CoachedBy cb ON m.MemberID = cb.MemberID " +
                $"WHERE cb.CoachID = {ID} AND cb.Ongoing = 1;";
            return dbMan.ExecuteReader(query);

        }

        public int GetMaxChallengeID()
        {
            string query = $"SELECT MAX(ChallengeID) AS MaxChallengeID FROM CoachChallenges ";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["MaxChallengeID"]);
            }
            else
            {
                throw new Exception("No Challenges found.");
                return 0;

            }

        }

        public int InsertCoachChallenge(string challengename,int points,string description,string startdate,string enddate,int coachid)
        {
            int challengeid = GetMaxChallengeID() + 1;

            string query = $"INSERT INTO CoachChallenges (ChallengeID,Description,PointsRewarded,ChallengeName,StartDate,EndDate,CoachID)" +
                           $" VALUES('{challengeid}','{description}','{points}','{challengename}','{startdate}','{enddate}','{coachid}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetAllCoachRequests(int ID)
        {
            string query = $"SELECT m.Username, m.Fname, m.Lname, m.Age, m.Weight, m.Height, m.Gender " + 
                           $"FROM Members m INNER JOIN CoachedBy cb ON m.MemberID = cb.MemberID " + 
                           $"WHERE cb.CoachID = {ID} AND cb.Accepted = 0;";
            return dbMan.ExecuteReader(query);
        }
        
        public int AcceptMember(string username, int coachid)
        {
            int memberid = GetMemberID(username);
            string query = $"UPDATE CoachedBy SET Accepted = 1, Ongoing = 1 WHERE MemberID = {memberid} AND CoachID = {coachid}";
            return dbMan.ExecuteNonQuery(query);

        }
        public int DeclineMember(string username, int coachid)
        {
            int memberid=GetMemberID(username);
            string query = $"UPDATE CoachedBy SET Accepted = 0, Ongoing = 0 WHERE MemberID = {memberid} AND CoachID = {coachid}";
            return dbMan.ExecuteNonQuery(query);

        }

        public int GetMaxMealID()
        {
            string query = $"SELECT MAX(MealID) AS MaxMealID FROM Meals ";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["MaxMealID"]);
            }
            else
            {
                throw new Exception("No Meals found.");
                return 0;

            }

        }
         
        public DataTable GetMealTypes()
        {
            string query = $"SELECT DISTINCT MealType FROM Meals";
            return dbMan.ExecuteReader(query);
        }

        public int InsertNewMeal(int coachid, string name, string ingredients, string steps, string dateposted, string duration, string mealtype, double fats, double protein, double carbs, int calories)
        {
            int mealid = GetMaxMealID() + 1;
            string query = $"INSERT INTO Meals (MealID, Steps, Ingredients, Duration, MealType, CaloriesPerServing, MealName, Fats, Protein, Carbs, DatePosted, CoachID)" +
                           $"VALUES ('{mealid}', '{steps}', '{ingredients}', '{duration}', '{mealtype}', '{calories}', '{name}', '{fats}', '{protein}', '{carbs}', '{dateposted}', '{coachid}')";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetMembersandBadges(int ID)
        {
            string query = $"SELECT m.Username, m.Points, b.BadgeName FROM Members m INNER JOIN CoachedBy cb ON m.MemberID = cb.MemberID LEFT JOIN BadgesEarned be ON m.MemberID = be.MemberID AND cb.CoachID = be.CoachID LEFT JOIN Badges b ON be.BadgeID = b.BadgeID WHERE cb.CoachID = {ID} AND cb.Ongoing = 1";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetAllBadges()
        {
            string query = "SELECT BadgeName, PointsNeeded FROM Badges;";
            return dbMan.ExecuteReader(query);
        }
        
        public int GetBadgeID(string badgename)
        {
            string query = $"SELECT BadgeID FROM Badges WHERE BadgeName = '{badgename}'";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["BadgeID"]);
            }
            else
            {
                throw new Exception("Badge not found.");
            }
        }
        public bool HasMemberBeenAwardedBadge(int memberID, int badgeID)
        {
            string query = $"SELECT COUNT(*) FROM BadgesEarned WHERE MemberID = {memberID} AND BadgeID = {badgeID}";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0][0]) > 0;
            }
            return false;
        }

        public int AwardBadge(string username, int coachid, string badgename, string date)
        {
            int memberid = GetMemberID(username);
            int badgeID = GetBadgeID(badgename);

            if (HasMemberBeenAwardedBadge(memberid, badgeID))
            {
                MessageBox.Show("Member has already been awarded this Badge");
                return 0;
            }

            string query = $"INSERT INTO BadgesEarned (MemberID, CoachID, BadgeID, DateEarned) " +
                           $"VALUES ({memberid}, {coachid}, {badgeID}, '{date}')";
            return dbMan.ExecuteNonQuery(query);
        }



        public int RemoveMember(int ID, string username)
        {
            int memberid = GetMemberID(username);
            string query = $"DELETE FROM CoachedBy WHERE MemberID = {memberid} AND CoachID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }
        public bool HasExerciseBeenSuggested(int memberID, int exerciseID)
        {
            string query = $"SELECT COUNT(*) FROM SuggestedExercises WHERE MemberID = {memberID} AND ExerciseID = {exerciseID}";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
        public bool HasCalorieBeenSuggested(int memberID, int calories)
        {
            string query = $"SELECT COUNT(*) FROM SuggestedCalories WHERE MemberID = {memberID} AND SuggestedCalroies = {calories}";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }


        public int GetExerciseID(string exercisename)
        {
            string query = $"SELECT ExerciseID FROM Exercises WHERE ExerciseName = '{exercisename}'";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["ExerciseID"]);
            }
            else
            {
                throw new Exception("Exercise not found.");
            }
        }

        public DataTable GetExerciseNames()
        {
            string query = $"SELECT ExerciseName FROM Exercises";
            return dbMan.ExecuteReader(query) ;
        }
        public int InsertSuggestedCalorie(string username, int coachid, int calories, string datesuggested)
        {
            int memberid = GetMemberID(username);

            if (HasCalorieBeenSuggested(memberid, calories))
            {
                MessageBox.Show("This calorie number has already been suggested to the member.");
                return 0; 
            }

            string query = $"INSERT INTO SuggestedCalories (MemberID, CoachID, SuggestedCalroies, DateSuggested) " +
                           $"VALUES ({memberid}, {coachid}, {calories}, '{datesuggested}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertSuggestedExercises(string username, int coachid, string exercisename, string dateposted)
        {
            int memberid = GetMemberID(username);
            int exerciseid = GetExerciseID(exercisename);

            if (HasExerciseBeenSuggested(memberid, exerciseid))
            {
                MessageBox.Show("This exercise has already been suggested to the member.");
                return 0;
            }

            string query = $"INSERT INTO SuggestedExercises (MemberID, CoachID, ExerciseID, DateSuggested) " +
                           $"VALUES ({memberid}, {coachid}, {exerciseid}, '{dateposted}')";
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable GetFeedbackTypes()
        {
            string query = $"SELECT TypeName FROM FeedbackTypes";
            return dbMan.ExecuteReader(query) ;
        }

        public int GetFeedbackID(string feedbackname)
        {
            string query = $"SELECT TypeID FROM FeedbackTypes WHERE TypeName = '{feedbackname}'";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["TypeID"]);
            }
            else
            {
                throw new Exception("Feedback type not found.");
            }
        }


        public int GetMaxFeedbackID()
        {
            string query = $"SELECT MAX(FeedbackID) AS MaxFeedbackID FROM Feedback";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["MaxFeedbackID"]);
            }
            else
            {
                throw new Exception("No Feedbacks found.");
                return 0;

            }

        }

        public int InsertFeedback(string comment, int rating, string typename, string dateposted)
        {
            int feedbacktypeID = GetFeedbackID(typename);
            string query = $"INSERT INTO Feedback (Comment, Rating, FeedbackTypeID, DatePosted) " +
                           $"VALUES ('{comment}', {rating}, {feedbacktypeID}, '{dateposted}')";
            return dbMan.ExecuteNonQuery(query);
        }



        public DataTable MembersWithHighestPoints(int ID)
        {
            string query = $"SELECT TOP 5 m.Username, m.Points " +
                           $"FROM Members m " +
                           $"INNER JOIN CoachedBy cb ON m.MemberID = cb.MemberID " +
                           $"WHERE cb.CoachID = {ID} AND cb.Ongoing = 1 " +
                           $"ORDER BY m.Points DESC";
            return dbMan.ExecuteReader(query);
        }

        public DataTable MostBadges(int ID)
        {
            string query = $"SELECT m.Username, COUNT(be.BadgeID) AS BadgeCount " +
                           $"FROM Members m " +
                           $"INNER JOIN CoachedBy cb ON m.MemberID = cb.MemberID " +
                           $"LEFT JOIN BadgesEarned be ON m.MemberID = be.MemberID AND cb.CoachID = be.CoachID " +
                           $"WHERE cb.CoachID = {ID} AND cb.Ongoing = 1 " +
                           $"GROUP BY m.Username " +
                           $"ORDER BY BadgeCount DESC";
            return dbMan.ExecuteReader(query);
        }


    }
}
