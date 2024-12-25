using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

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
            string query = "SELECT Fname, Lname, CoachID, MemberLimit FROM Coaches";
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
    }
}
