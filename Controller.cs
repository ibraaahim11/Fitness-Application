using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Diagnostics;
using System.Xml.Linq;

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
            return (int) dbMan.ExecuteScalar(query);
        }


        // Delete academy account

        public int DeleteAcademyUser(string username)
        {
            string query = $"DELETE FROM Users WHERE Username = '{username}'";
            return dbMan.ExecuteNonQuery(query);

        }

        public int DeleteAcademy(int ID)
        {
            string query = $"DELETE FROM Academies WHERE AcademyID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////// ROZA //////////////////// MEMBER STUFF///////////////////////////////////////////////////
        // Member Functions for loading info
        public int GetMemberID(string username)
        {
            string query = $"SELECT MemberID FROM Members WHERE Username = '{username}'";
            return (int)dbMan.ExecuteScalar(query);
        }

        public string GetMemberName(int ID)
        {
            string query = $"SELECT Fname + ' ' + Lname AS FullName FROM Members WHERE MemberID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        // Member Profile Functions

        // Getting
        public string GetMemberUsername(int ID)
        {
            string query = $"SELECT Username FROM Members WHERE MemberID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string GetMemberPassword(string username)
        {
            string query = $"SELECT Password FROM Users WHERE Username = '{username}'";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string GetMemberFirstName(int ID)
        {
            string query = $"SELECT Fname FROM Members WHERE MemberID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string GetMemberLastName(int ID)
        {
            string query = $"SELECT Lname FROM Members WHERE MemberID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int GetMemberAge(int ID)
        {
            string query = $"SELECT Age FROM Members WHERE MemberID = {ID}";
            return (int)dbMan.ExecuteScalar(query);
        }

        public decimal GetMemberWeight(int ID)
        {
            string query = $"SELECT Weight FROM Members WHERE MemberID = {ID}";
            return (decimal)dbMan.ExecuteScalar(query);
        }

        public DataTable GetNonAcceptedCoachesData()
        {
            string query = "SELECT Fname, Lname, CoachID, Age, Gender, CertificateTitle, CertificateDateOfIssue, CertificateExpirationDate, CertificateIssuingBody FROM Coaches WHERE Accepted = 0";
            return dbMan.ExecuteReader(query);
        }

        public int AcceptCoach(int ID)
        {
            string query = $"UPDATE Coaches SET Accepted = 1 WHERE CoachID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }
        public int RejectCoach(int ID)
        {
            string query = $"DELETE Coaches WHERE CoachID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetAllCoachesData()
        {
            string query = "SELECT Fname, Lname, CoachID, MemberLimit FROM Coaches WHERE Accepted = 1";
            return dbMan.ExecuteReader(query);
        }
        public double GetAvgRating(int ID)
        {
            string query = $"SELECT AVG(Rating) as avgrating FROM CoachedBy WHERE CoachID = {ID}";
            object result = dbMan.ExecuteScalar(query);

            if (result == null || result == DBNull.Value)
                return 0;
            return Convert.ToDouble(result);
        }
        public int GetCoachedMemCount(int CoachID)
        {
            string query = $"SELECT COUNT(MemberID) FROM CoachedBy WHERE CoachID = {CoachID}";
            object result = dbMan.ExecuteScalar(query); 
            if (result == null || result == DBNull.Value)
                return 0;
            return (int)result;
        }
        
        public decimal GetMemberHeight(int ID)
        {
            string query = $"SELECT Height FROM Members WHERE MemberID = {ID}";
            return (decimal)dbMan.ExecuteScalar(query);
        }

        public string GetMemberGender(int ID)
        {
            string query = $"SELECT Gender FROM Members WHERE MemberID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int UpdateMemberLimit(int CoachID, int memberLimit)
        {
            string query = $"UPDATE Coaches SET MemberLimit = {memberLimit} WHERE CoachID = {CoachID}";
            return dbMan.ExecuteNonQuery(query);
        }
        public int RemoveCoach(int CoachID)
        {
            string query = $"DELETE Coaches WHERE CoachID = {CoachID}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int CheckifUsernameExist(string username)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE Username = '{username}';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int UpdateAdminUsername(string OldUsername, string username)
        {
            string query = $"UPDATE Users SET Username = '{username}' where Username = '{OldUsername}';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateAdminPasswords(string username, string password)
        {
            string query = $"UPDATE Users SET Password = '{password}' where Username = '{username}';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetAdminUsers()
        {
            string query = "select Username from Users where type_of_user = 'admin';";
            return dbMan.ExecuteReader(query);
        }
        public int AddNewAdmin(string username, string password)
        {
            string query = $"Insert into Users values ('{username}', '{password}', 'admin')";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataRow getCoachdetails(int ID)
        {
            string query = $"Select Fname, Lname, CertificateTitle from Coaches where CoachID = {ID}";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }
        public DataTable getCoachesRankings()
        {
            string query = "SELECT Fname, Lname, CoachID, (SELECT AVG(Rating) FROM CoachedBy WHERE CoachedBy.CoachID = Coaches.CoachID) AS AvgRating, (SELECT Count(*) from CoachedBy WHERE CoachedBy.CoachID = Coaches.CoachID and Ongoing = 1) as MemberCount FROM Coaches WHERE Accepted = 1 ORDER BY AvgRating DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getAllmembersOfCoach(int ID)
        {
            string query = $"Select Fname, Lname, m.MemberID FROM Members m, CoachedBy c WHERE m.MemberID = c.MemberID and CoachID = {ID} and Ongoing = 1";
            return dbMan.ExecuteReader(query);
        }
        
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //1)edit profile 
        ///////////////////////////////////////////////////////////////
        ///   
        public int UpdateMemberProfile(string username, string firstName, string lastName, int age, float weight, float height, int dietId)
        {
            string query = $"UPDATE Members " +
                           $"SET Fname = '{firstName}', Lname = '{lastName}', Age = {age}, Weight = {weight}, Height = {height}, DietID = {dietId} " +
                           $"WHERE Username = '{username}'";
            return dbMan.ExecuteNonQuery(query);
        }
        ////////////////////////////////////////////////////////////
        //2)Choose a Fitness Goal
        ////////////////////////////////////////////////////////////////////
        public int SetFitnessGoal(string username, string goalName)
        {
            string query = $"UPDATE Members " +
                           $"SET FitnessGoalID = (SELECT GoalID FROM FitnessGoals WHERE GoalName = '{goalName}') " +
                           $"WHERE Username = '{username}'";
            return dbMan.ExecuteNonQuery(query);
        }
        ////////////////////////////////////////////////////////////////
        //3)Log Exercise
        //////////////////////////////////////////////////////////
        public int LogMemberExercise(string username, int exerciseId, int minutesExercised, int caloriesBurned, int pointsAwarded)
        {
            string query = $"INSERT INTO MemberLogExercise (MemberID, ExerciseID, DateTimeLogged, MinutesExercised, CaloriesBurned, PointsAwarded) " +
                           $"VALUES ((SELECT MemberID FROM Members WHERE Username = '{username}'), {exerciseId}, GETDATE(), {minutesExercised}, {caloriesBurned}, {pointsAwarded})";
            return dbMan.ExecuteNonQuery(query);
        }
        ///////////////////////////////////////////////////////////////

        public int CheckIfUserExist(string username, string password)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE Username = '{username}' AND Password = '{password}';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataRow GetTypeOfUser(string username)
        {
            string query = $"Select type_of_user from Users where username = '{username}'";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }
    }
}
