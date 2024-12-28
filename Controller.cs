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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Data.SqlClient;
using FitnessApplication;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static Syncfusion.Windows.Forms.Tools.NavigationView;

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


        /////////////////////////////////////fitness goal /////////////////////////////////////
        ///////////////////////////////remove the check after fixing the notnull in db/////////////////////
        public int GetMemberFitnessGoalID(int ID)
        {
            string query = $"SELECT FitnessGoalID FROM Members WHERE MemberID = {ID}";
            object result = dbMan.ExecuteScalar(query);

            if (result == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return (int)result;
            }
        }

        /// /////////////////////////////////////////////////////////////////////////

        public string GetFitnessGoalName(int goalID)
        {
            if (goalID == 0)
                return "";

            string query = $"SELECT GoalName FROM FitnessGoals WHERE GoalID = {goalID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int UpdateUsernamePasswordmember(string OldUsername, string NewUsername, string password)
        {
            string query = $"UPDATE Users SET Username = '{NewUsername}', Password = '{password}' WHERE Username = '{OldUsername}'";
            return dbMan.ExecuteNonQuery(query);
        }

        //public int UpdateUsernamePasswordmember(string OldUsername, string NewUsername, string password)
        //{
        //    // First, set the old username to null
        //    string query1 = $"UPDATE Members SET Username = NULL WHERE Username = '{OldUsername}'";
        //    dbMan.ExecuteNonQuery(query1);

        //    // Then, update the username 
        //    string query = $"UPDATE Users SET Username = '{NewUsername}', Password = '{password}' WHERE Username IS NULL";
        //    return dbMan.ExecuteNonQuery(query);

        //}
        public int DeleteMemberByID(int ID)
        {
            // Update the Username in Users table to NULL
            string query1 = $"UPDATE Users SET Username = NULL WHERE MemberID = {ID}";
            dbMan.ExecuteNonQuery(query1);

            // Delete the member from the Members table
            string query = $"DELETE FROM Members WHERE MemberID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //1)edit profile 
        ///////////////////////////////////////////////////////////////
        ///   
        public int UpdateMemberProfile(string username, string firstName, string lastName, int age, decimal weight, decimal height, char gender)
        {
            string query = $"UPDATE Members " +
                           $"SET Fname = '{firstName}', Lname = '{lastName}', Age = {age}, Weight = {weight}, Height = {height}, Gender='{gender}'" +
                           $"WHERE Username = '{username}'";
            return dbMan.ExecuteNonQuery(query);
        }
        ////////////////////////////////////////////////////////////
        //2)Choose a Fitness Goal
        ////////////////////////////////////////////////////////////////////
        public int GetFitnessGoalIDByName(string goalName)
        {
            string query = $"SELECT GoalID FROM FitnessGoals WHERE GoalName = '{goalName}'";
            object result = dbMan.ExecuteScalar(query);
            return (int)result;
        }

        public int UpdateMemberFitnessGoal(string username, int goalID)
        {
            string query = $"UPDATE Members SET FitnessGoalID = {goalID} WHERE Username = '{username}'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int SetFitnessGoal(string username, string fitnessgoalName)
        {
            int goalID = GetFitnessGoalIDByName(fitnessgoalName);
            return UpdateMemberFitnessGoal(username, goalID);
        }
        ////////////////////////////////////////////////////////////////
        //////////////////////////

        public DataTable GetExercises()
        {
            string query = "SELECT * FROM Exercises";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt;
        }
        /////////////////////////////////////////////////////////////

        public decimal GetCaloriesBurnedByExerciseID(string exercisen)
        {
            string query = $"SELECT CaloriesBurnedPerMin FROM Exercises WHERE ExerciseName =  '{exercisen}' ";


            return (decimal)(dbMan.ExecuteScalar(query));


        }
        public int Getpointsearned(string exercisen)
        {
            string query = $"SELECT PointsPerMin FROM Exercises WHERE ExerciseName =  '{exercisen}' ";


            return Convert.ToInt32(dbMan.ExecuteScalar(query));


        }
        public int GetExerciseID(string exerciseName)
        {
            string query = $"SELECT ExerciseID FROM Exercises WHERE ExerciseName = '{exerciseName}'";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int UpdateMemberPoints(int ID, int pointsToAdd)
        {
            string query = $"UPDATE Members SET Points = Points + {pointsToAdd} WHERE MemberID = {ID}";
            return dbMan.ExecuteNonQuery(query);


        }

        // 4. Log Calories
        ///////////////////////////////////////////////
        //public int LogCalories(int ID, string Datetime , int caloriesConsumed)   
        //  {
        //      string query = $"INSERT INTO MemberLogCalories (MemberID, DateTimeLogged, CaloriesConsumed)" +
        //                     $"VALUES ({ID},'{Datetime}', {caloriesConsumed} )";
        //      return dbMan.ExecuteNonQuery(query);
        //  }

        //public int LogData(int memberID, string dataName, string dataValue)
        //{
        //    string query = $"INSERT INTO MemberLogData (MemberID, DataName, DataValue, LogDate) " +
        //                   $"VALUES ({memberID}, '{dataName}', '{dataValue}', GETDATE())";
        //    return dbMan.ExecuteNonQuery(query);
        //}
        //3)Log Exercise
        //////////////////////////////////////////////////////////
        public int LogCalories(int ID, string Datetime, int caloriesConsumed)
        {
            int count = countofCaloriesRecordExist(ID, Datetime);
            if (count > 0)
            {
                // Calorie entry for this member and date already exists
                MessageBox.Show("Calories for this member on this date is already logged.");
                return 0;
            }

            string query = $"INSERT INTO MemberLogCalories (MemberID, DateTimeLogged, CaloriesConsumed) " +
                           $"VALUES ({ID}, '{Datetime}', {caloriesConsumed})";

            return dbMan.ExecuteNonQuery(query);
        }
        private int countofCaloriesRecordExist(int memberID, string datetime)
        {
            string query = $"SELECT COUNT(*) FROM MemberLogCalories " +
                           $"WHERE MemberID = {memberID} AND DateTimeLogged = '{datetime}'";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        /// for streak 
        //private int countofCaloriesRecordExist(int memberID, string datetime, int caloriesConsumed)
        //{
        //    string query = $"SELECT COUNT(*) FROM MemberLogCalories " +
        //                   $"WHERE MemberID = {memberID} AND DateTimeLogged = '{datetime}' ";

        //    return Convert.ToInt32(dbMan.ExecuteScalar(query));
        //}
        ////////////////////////////////////////////////////////////////////////////
        public int LogMemberExercise(int ID, int exerciseId, string Datetime, int minutesExercised, decimal caloriesBurned, int pointsAwarded)
        {
            int count = countofLogExerciseRecordExist(ID, exerciseId, Datetime);
            if (count > 0)
            {
                MessageBox.Show("Exercise for this member and date already logged.");
                return 0;
            }
            string query = $"INSERT INTO  MemberLogExercise(MemberID, ExerciseID, DateTimeLogged, MinutesExercised, CaloriesBurned, PointsAwarded) " +
                           $"VALUES ({ID},{exerciseId},'{Datetime}', {minutesExercised},{caloriesBurned},{pointsAwarded})";
            return dbMan.ExecuteNonQuery(query);
        }
        ///////////////////////////////////////////////////////////////to count law dakhal before //////////////////
        private int countofLogExerciseRecordExist(int ID, int exerciseId, string datetime)
        {
            string query = $"SELECT COUNT(*) FROM MemberLogExercise WHERE MemberID = {ID} AND ExerciseID = {exerciseId} AND DateTimeLogged = '{datetime}'";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        ////////////////////////////////////////////////////////////////////////////////////////for streak///////////////////////////////////////////////
        //public int GetSuggestedCalories(int ID)
        //{
        //    string query = $"SELECT SuggestedCalories FROM Members WHERE MemberID = {ID}";

        //    return Convert.ToInt32(dbMan.ExecuteScalar(query));
        //}
        public int GetAllowedCalories(int memberID)
        {
            string query = $"SELECT AllowedCalorieIntake FROM Members WHERE MemberID = {memberID}";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int LogCalories(int memberID, string datetime, int caloriesConsumed, int allowedcalories)
        {
            int count = countofCaloriesRecordExist(memberID, datetime);
            if (count > 0)
            {
                MessageBox.Show("Calories for this member and date already logged.");
                return 0;
            }

            string query = $"INSERT INTO MemberLogCalories (MemberID, DateTimeLogged, CaloriesConsumed) " +
                           $"VALUES ({memberID}, '{datetime}', {caloriesConsumed})";

            int insertion = dbMan.ExecuteNonQuery(query);

            if (insertion > 0)
            {
                if (caloriesConsumed <= allowedcalories)
                {
                    UpdateStreak(memberID);
                }
                else
                {
                    ResetStreak(memberID);
                }
            }

            return insertion;
        }



        private void UpdateStreak(int ID)
        {
            string query = $"UPDATE Members SET Streak = Streak + 1 WHERE MemberID = {ID}";

            dbMan.ExecuteNonQuery(query);
        }

        private void ResetStreak(int ID)
        {
            string query = $"UPDATE Members SET Streak = 0 WHERE MemberID = {ID}";

            dbMan.ExecuteNonQuery(query);
        }
        public int GetStreak(int ID)
        {
            string query = $"SELECT Streak FROM Members WHERE MemberID = {ID}";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        /////////////////////updating allowed calories with weight and height ....///////
        public int UpdateAllowedCalorieIntake(decimal weight, decimal height, int age, char gender, string username)
        {
            int caloriess;

           
            if (gender == 'M')
            {
               
                caloriess = (int)(88.362 + (13.397 * (double)weight) + (4.799 * (double)height) - (5.677 * age));
            }
            else if (gender == 'F')
            {
               
                caloriess = (int)(447.593 + (9.247 * (double)weight) + (3.098 * (double)height) - (4.330 * age));
            }
            else
            {
                MessageBox.Show(" problem with gender in update allowedcalorieintake function");
                caloriess = 0;
            }


            // SQL query to update the AllowedCalorieIntake
            string query = $"UPDATE Members " +
                           $"SET AllowedCalorieIntake = {caloriess} " +
                           $"WHERE Username = '{username}'";

            return dbMan.ExecuteNonQuery(query);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////
        ///new but also fih fo2 new///////////////////////////////////////////////////////////
        ///ibrahim ask
        public int GetMemberRankById(int memberId)
        {
            string query = $"SELECT 1 + (SELECT COUNT(*) FROM Members AS OtherMembers WHERE OtherMembers.Points > (SELECT Points FROM Members WHERE MemberID = {memberId}))";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public DataTable getbadgesearnedbyMember(int memberId)
        {
            string query = $"SELECT b.BadgeName, b.Description, b.PointsNeeded, be.DateEarned " +
                           $"FROM Badges b, BadgesEarned be " +
                           $"WHERE b.BadgeID = be.BadgeID AND be.MemberID = {memberId}";

            return dbMan.ExecuteReader(query);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////for feedback//////////////////////////////////
        public DataTable GetFeedbackTypes()
        {
            string query = "SELECT TypeID, TypeName FROM FeedbackTypes";
            return dbMan.ExecuteReader(query);
        }

     
        public int Insertfeedback(int Id, string feedbackText, int rating, int feedbackTypeId, string feedbackDate)
        {
         
            string query1 = $"INSERT INTO Feedback (Comment, Rating, FeedbackTypeID, DatePosted) " +
                                     $"VALUES ('{feedbackText}', {rating}, {feedbackTypeId}, '{feedbackDate}')";

            dbMan.ExecuteNonQuery(query1);

          
            string getLastInsertedIdQuery = "SELECT MAX(FeedbackID) FROM Feedback";
            int feedbackId = Convert.ToInt32(dbMan.ExecuteScalar(getLastInsertedIdQuery));

            // inserting into MemberFeedback table //ask ibrahim abt identity (1,1)
            string q2 = $"INSERT INTO MemberFeedback (FeedbackID, MemberID) VALUES ({feedbackId}, {Id});";
            dbMan.ExecuteNonQuery(q2);

            return feedbackId; 
        }

        public bool DoesMemberHaveCoach(int memberId)
        {
            string query = $"SELECT COUNT(*) FROM CoachedBy WHERE MemberID = {memberId} AND Ongoing = 1";
            int count = Convert.ToInt32(dbMan.ExecuteScalar(query));
            if (count > 0)
            { return true; }
            else { return false; }
           
        }

        public int GetFeedbackTypeID(string feedbackTypeName)
        {
            string query = $"SELECT TypeID FROM FeedbackTypes WHERE TypeName = '{feedbackTypeName}'";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int UpdateCoachedByRating(int memberId, decimal newRating)
        {
            
            string query = $"UPDATE CoachedBy SET Rating = {newRating} WHERE MemberID = {memberId} AND Ongoing = {1}";

           
            return dbMan.ExecuteNonQuery(query);
        }
        public decimal GetAverageCaloriesIntake(int memberId)
        {
            string query = $"SELECT AVG(CaloriesConsumed) FROM MemberLogCalories WHERE MemberID = {memberId}";
            return Convert.ToDecimal(dbMan.ExecuteScalar(query));
        }
        public decimal GetAverageCaloriesBurned(int memberId)
        {
            string query = $"SELECT AVG(CaloriesBurned) FROM MemberLogExercise WHERE MemberID = {memberId}";
            return Convert.ToDecimal(dbMan.ExecuteScalar(query));
        }
        public bool DeleteMember(int memberId)
        {
            string query = $"DELETE FROM Members WHERE MemberID = {memberId}";
            return dbMan.ExecuteNonQuery(query) > 0;
        }
        public bool DeleteUser(string username)
        {
            string query = $"DELETE FROM Users WHERE Username = '{username}'";
            return dbMan.ExecuteNonQuery(query) > 0;
        }
    }
}
