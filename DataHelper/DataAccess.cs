using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataHelper
{
    /* 
                 Data Class Library
     * All transactions to Database goes through here
     * All computations are computed here
     * All Database queries are in Stored Procedure
     */

    public class DataAccess
    {
        bool recordFound;
        string statusName;
        decimal equipmentCost;
        int organizationID, totalPosition, perEquipmentQty, posEquipmentQty;

        //Connection String to MySql localhost
        static string con = @"server=localhost;user id=root;pwd=root;persistsecurityinfo=True;database=netcsys;SslMode=none";
        MySqlConnection myCon = new MySqlConnection(con);

        /*
         Data from this class can be transferred to other class by encapsulation
         */
        public string StatusName
        {
            get { return statusName; }
            set { statusName = value; }
        }

        public int PerEquipmentQty
        {
            get { return perEquipmentQty; }
            set { perEquipmentQty = value; }
        }

        public int PosEquipmentQty
        {
            get { return posEquipmentQty; }
            set { posEquipmentQty = value; }
        }

        public decimal EquipmentCost
        {
            get { return equipmentCost; }
            set { equipmentCost = value; }
        }

        public int TotalPosition
        {
            get { return totalPosition; }
            set { totalPosition = value; }
        }

        public void OrganizationID(int organizationID)
        {
            this.organizationID = organizationID;
        }

        //Insert Equipment to Database
        public void AddEquipment(string EquipmentName, decimal EquipmentCost, int YearID) //Needed parameters in the Stored Procedure from Create Equipment from
        {
            myCon.Open();
            MySqlCommand SaveEquipment = new MySqlCommand("AddEquipment", myCon);
            SaveEquipment.CommandType = CommandType.StoredProcedure;

            SaveEquipment.Parameters.Add("EquipmentName", MySqlDbType.VarChar).Value = EquipmentName;
            SaveEquipment.Parameters.Add("EquipmentCost", MySqlDbType.VarChar).Value = EquipmentCost;
            SaveEquipment.Parameters.Add("YearID", MySqlDbType.Int32).Value = YearID;

            SaveEquipment.ExecuteNonQuery();
            myCon.Close();
        }

        //Insert Rank to Database
        public void AddRank(string RankName, decimal RankSalary, int YearID, string RankCode) //Needed parameters in the Stored Procedure from Create Rank from
        {

            myCon.Open();
            MySqlCommand SaveRank = new MySqlCommand("AddRank", myCon);
            SaveRank.CommandType = CommandType.StoredProcedure;

            SaveRank.Parameters.Add("RankName", MySqlDbType.VarChar).Value = RankName;
            SaveRank.Parameters.Add("RankSalary", MySqlDbType.Decimal).Value = RankSalary;
            SaveRank.Parameters.Add("YearID", MySqlDbType.Int32).Value = YearID;
            SaveRank.Parameters.Add("RankCode", MySqlDbType.VarChar).Value = RankCode;

            SaveRank.ExecuteNonQuery();
            myCon.Close();
        }

        //Insert and Update Hierarchy to Databse
        public bool AddChild(int ParentID, int ChildID) //Needed parameters in the Stored Procedure from Create Organization Child form
        {
            myCon.Open();
            recordFound = false;
            try
            {
                MySqlCommand SaveChild = new MySqlCommand("CreateChild", myCon);
                SaveChild.CommandType = CommandType.StoredProcedure;

                SaveChild.Parameters.Add("ParentID", MySqlDbType.Int32).Value = ParentID;
                SaveChild.Parameters.Add("ChildID", MySqlDbType.Int32).Value = ChildID;

                SaveChild.ExecuteNonQuery();
                myCon.Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("" + e);
                recordFound = true;
            }
            myCon.Close();
            return recordFound;
        }

        //Insert Year to Database
        public void AddYear(int YearStart, int YearEnd) //Needed parameters in the Stored Procedure from Create Year form
        {
            myCon.Open();
            MySqlCommand SaveYear = new MySqlCommand("AddYear", myCon);
            SaveYear.CommandType = CommandType.StoredProcedure;

            SaveYear.Parameters.Add("YearStart", MySqlDbType.Int32).Value = YearStart;
            SaveYear.Parameters.Add("YearEnd", MySqlDbType.Int32).Value = YearEnd;

            SaveYear.ExecuteNonQuery();
            myCon.Close();
        }

        //Insert User to Database
        public bool AddUser(string UserName, string UserPassword) //Needed parameters in the Stored Procedure from User Register form
        {
            recordFound = false;
            myCon.Open();

            try
            {
                MySqlCommand SaveUser = new MySqlCommand("AddUser", myCon);
                SaveUser.CommandType = CommandType.StoredProcedure;

                SaveUser.Parameters.Add("UserName", MySqlDbType.VarChar).Value = UserName;
                SaveUser.Parameters.Add("UserPassword", MySqlDbType.VarChar).Value = UserPassword;

                SaveUser.ExecuteNonQuery();
                myCon.Close();
            }

            catch(Exception e)
            {
                Console.Error.WriteLine("" + e);
                recordFound = true;
            }
            myCon.Close();
            return recordFound;
        }

        //Insert Echelon to Database
        public void AddEchelon(string EchelonName, string EchelonCode) //Needed parameters in the Stored Procedure from Create Echelon
        {
            myCon.Open();

           MySqlCommand SaveEchelon = new MySqlCommand("AddEchelon", myCon);
           SaveEchelon.CommandType = CommandType.StoredProcedure;

           SaveEchelon.Parameters.Add("EchelonName", MySqlDbType.VarChar).Value = EchelonName;
            SaveEchelon.Parameters.Add("EchelonCode", MySqlDbType.VarChar).Value = EchelonCode;

           SaveEchelon.ExecuteNonQuery();
           myCon.Close();
        }

        //Insert Organization to Database
        public void AddOrganization(string OrganizationName, int OrganizationEchelon, int OrganizationStatus, int YearID, string OrganizationCode) //Needed parameters in the Stored Procedure from Create Organization form
        {
            myCon.Open();

            MySqlCommand SaveOrganization = new MySqlCommand("AddOrganization", myCon);
            SaveOrganization.CommandType = CommandType.StoredProcedure;

            SaveOrganization.Parameters.Add("OrganizationName", MySqlDbType.VarChar).Value = OrganizationName;
            SaveOrganization.Parameters.Add("OrganizationEchelon", MySqlDbType.Int32).Value = OrganizationEchelon;
            SaveOrganization.Parameters.Add("OrganizationStatus", MySqlDbType.Int32).Value = OrganizationStatus;
            SaveOrganization.Parameters.Add("YearID", MySqlDbType.Int32).Value = YearID;
            SaveOrganization.Parameters.Add("OrganizationCode", MySqlDbType.VarChar).Value = OrganizationCode;

            SaveOrganization.ExecuteNonQuery();
            myCon.Close();
        }

        //Insert Position to Database
        public void AddPosition(string PositionName, int PersonnelQuantity, int RankID, int OrganizationID) //Needed parameters in the Stored Procedure from Create Position form
        {
            myCon.Open();

            MySqlCommand SavePosition = new MySqlCommand("AddPosition", myCon);
            SavePosition.CommandType = CommandType.StoredProcedure;

            SavePosition.Parameters.Add("PositionName", MySqlDbType.VarChar).Value = PositionName;
            SavePosition.Parameters.Add("PersonnelQuantity", MySqlDbType.Int32).Value = PersonnelQuantity;
            SavePosition.Parameters.Add("RankID", MySqlDbType.Int32).Value = RankID;
            SavePosition.Parameters.Add("OrganizationID", MySqlDbType.Int32).Value = OrganizationID;

            SavePosition.ExecuteNonQuery();
            myCon.Close();
        }

        //Insert Position Equipment to Database
        public void AddPositionEquipment(int EquipmentID,int EquipmentQuantity) //Needed parameters in the Stored Procedure from Create Position Form
        {
            myCon.Open();

            MySqlCommand SavePosEquipment = new MySqlCommand("AddPositionEquipment", myCon);
            SavePosEquipment.CommandType = CommandType.StoredProcedure;

            SavePosEquipment.Parameters.Add("EquipmentID", MySqlDbType.Int32).Value = EquipmentID;
            SavePosEquipment.Parameters.Add("EquipmentQuantity", MySqlDbType.Int32).Value = EquipmentQuantity;

            SavePosEquipment.ExecuteNonQuery();
            myCon.Close();
        }

        //Insert Personal Equipment to Database
        public void AddPersonalEquipment(int EquipmentID, int EquipmentQuantity) //Needed parameters in the Stored Procedure from Create Position Form
        {
            myCon.Open();

            MySqlCommand SavePerEquipment = new MySqlCommand("AddPersonalEquipment", myCon);
            SavePerEquipment.CommandType = CommandType.StoredProcedure;

            SavePerEquipment.Parameters.Add("EquipmentID", MySqlDbType.Int32).Value = EquipmentID;
            SavePerEquipment.Parameters.Add("EquipmentQuantity", MySqlDbType.Int32).Value = EquipmentQuantity;

            SavePerEquipment.ExecuteNonQuery();
            myCon.Close();
        }

        //Get number of Position per Organization
        public bool CountPosition(int OrganizationID)
        {
            recordFound = false;
            myCon.Open();

            MySqlCommand count = new MySqlCommand("CountPosition", myCon);
            count.CommandType = CommandType.StoredProcedure;

            count.Parameters.Add("OrganizationID", MySqlDbType.Int32).Value = OrganizationID;

            MySqlDataReader dr = count.ExecuteReader();

            while(dr.Read())
            {
                recordFound = true;

                totalPosition = Convert.ToInt32(dr["TotalPosition"]);

                break;
            }

            myCon.Close();
            return recordFound;
        }

        //Delete Echelon from Database
        public void DeleteEchelon(int EchelonID) //Needed parameter in the stored procedure from Manage Echelon form
        {
            myCon.Open();

            MySqlCommand DeleteEchelon = new MySqlCommand("DeleteEchelon", myCon);
            DeleteEchelon.CommandType = CommandType.StoredProcedure;

            DeleteEchelon.Parameters.Add("EchelonID", MySqlDbType.Int32).Value = EchelonID;

            DeleteEchelon.ExecuteNonQuery();
            myCon.Close();
        }

        //Delete Equipment from Database
        public void DeleteEquipment(int EquipmentID) //Needed parameter in the stored procedure from Manage Equipment Form
        {
            myCon.Open();

            MySqlCommand DeleteEquipment = new MySqlCommand("DeleteEquipment", myCon);
            DeleteEquipment.CommandType = CommandType.StoredProcedure;

            DeleteEquipment.Parameters.Add("EquipmentID", MySqlDbType.Int32).Value = EquipmentID;

            DeleteEquipment.ExecuteNonQuery();
            myCon.Close();
        }

        //Delete Organization from Database
        public void DeleteOrganization(int OrganizationID) //Needed parameter in stored procedure from Manage Organization Forms
        {
            myCon.Open();

            MySqlCommand DeleteOrganization = new MySqlCommand("DeleteOrganization", myCon);
            DeleteOrganization.CommandType = CommandType.StoredProcedure;

            DeleteOrganization.Parameters.Add("OrganizationID", MySqlDbType.Int32).Value = OrganizationID;

            DeleteOrganization.ExecuteNonQuery();
            myCon.Close();
        }

        //Delete Rank from database
        public void DeleteRank(int RankID) //Needed parameter in stored procedure from Manage Rank Forms
        {
            myCon.Open();

            MySqlCommand DeleteRank = new MySqlCommand("DeleteRank", myCon);
            DeleteRank.CommandType = CommandType.StoredProcedure;

            DeleteRank.Parameters.Add("RankID", MySqlDbType.Int32).Value = RankID;

            DeleteRank.ExecuteNonQuery();
            myCon.Close();
        }

        //Read all data from echelon table
        public DataSet DisplayEchelon()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayEchelon", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "EchelonRecord");
            return ds;
        }

        //Read all data from status table
        public DataSet DisplayStatus()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayStatus", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "StatusRecord");
            return ds;
        }

        //Read all data from equipment table according to Year
        public DataSet DisplayEquipmentAccdgToYear(int YearID) //Needed parameter in stored procedure
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayEquipmentAccdgToYear", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("YearID", MySqlDbType.Int32).Value = YearID;

            DataSet ds = new DataSet();
            da.Fill(ds, "EquipmentRecord");
            return ds;
        }

        //Read all data from year table
        public DataSet DisplayYear()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayYear", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "YearRecord");
            return ds;
        }

        //Display all data from position table according to organization
        public DataSet DisplayPositionAccdgToOrganization(int OrganizationID) //Needed parameter in stored procedure
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayPositionAccdgToOrganization", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("OrganizationID", MySqlDbType.Int32).Value = OrganizationID;

            DataSet ds = new DataSet();
            da.Fill(ds, "PositionRecord");
            return ds;
        }

        //Display all data from personal equipment table according to position
        public DataSet DisplayPerEquipmentAccdgToPositions(int PositionID) //Needed parameter in stored procedure
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayPerEquipmentAccdgToPositions", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("PositionID", MySqlDbType.Int32).Value = PositionID;

            DataSet ds = new DataSet();
            da.Fill(ds, "PerEquipRecord");
            return ds;
        }

        //Display Hierarchy according to parent_id
        public DataSet DisplayOrganizationTree(int Ancestor) //Needed parameter in stored procedure
        {
            MySqlDataAdapter da = new MySqlDataAdapter("GetTree", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("Ancestor", MySqlDbType.Int32).Value = Ancestor;

            DataSet ds = new DataSet();
            da.Fill(ds, "Organizationrecord");
            return ds;
        }

        //Display all data from position equipment according to positions
        public DataSet DisplayPosEquipmentAccdgToPositions(int PositionID) //Needed parameter in stored procedure
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayPosEquipmentAccdgToPositions", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("PositionID", MySqlDbType.Int32).Value = PositionID;

            DataSet ds = new DataSet();
            da.Fill(ds, "PosEquipRecord");
            return ds;
        }

        //Get Status name from status table
        public bool DisplayStatusName(int StatusID) //Needed parameter in stored procedure
        {
            recordFound = false;
            myCon.Open();

            MySqlCommand readStatusID = new MySqlCommand("DisplayStatus", myCon);
            readStatusID.CommandType = CommandType.StoredProcedure;

            readStatusID.Parameters.Add("StatusID", MySqlDbType.Int32).Value = StatusID;

            MySqlDataReader dr = readStatusID.ExecuteReader();

            while(dr.Read())
            {
                recordFound = true;

                statusName = Convert.ToString(dr["status_desc"]);

                break;
            }

            myCon.Close();
            return recordFound;
        }

        //Display all data from equipment
        public bool DisplayEquipmentForPosition(int EquipmentID) //Needed parameter in stored procedure
        {
            recordFound = false;
            myCon.Open();

            MySqlCommand readEquipmentID = new MySqlCommand("DisplayEquipmentForPosition", myCon);
            readEquipmentID.CommandType = CommandType.StoredProcedure;

            readEquipmentID.Parameters.Add("EquipmentID", MySqlDbType.Int32).Value = EquipmentID;
       
            MySqlDataReader dr = readEquipmentID.ExecuteReader();

            while (dr.Read())
            {
                recordFound = true;

                equipmentCost = Convert.ToDecimal(dr["equipment_cost"]);

                break;
            }

            myCon.Close();
            return recordFound;
        }

        //Display all data from organization according to status
        public DataSet DisplayOrganization(int StatusID) //Needed parameter in stored procedure
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayOrganization", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("StatusID", MySqlDbType.Int32).Value = StatusID;

            DataSet ds = new DataSet();
            da.Fill(ds, "OrganizationRecord");
            return ds;
        }

        //Display all data from organization according to status
        public DataSet DisplayOrganizationAccdgToStatus(int StatusID) //Needed parameter in stored procedure
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayOrganizationAccdgToStatus", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("StatusID", MySqlDbType.Int32).Value = StatusID;

            DataSet ds = new DataSet();
            da.Fill(ds, "StatusRecord");
            return ds;
        }

        //Display Organization with echelon name
        public DataSet DisplayOrganizationWithEchelonName(int YearID, int StatusID) //Needed parameter in stored procedure
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayOrganizationWithEchelonName", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("StatusID", MySqlDbType.Int32).Value = StatusID;
            da.SelectCommand.Parameters.Add("YearID", MySqlDbType.Int32).Value = YearID;

            DataSet ds = new DataSet();
            da.Fill(ds, "OrganizationRecord");
            return ds;
        }

        //Display alll data from rank table according to year
        public DataSet DisplayRankAccdgToYear(int YearID) //Needed parameter in stored procedure
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayRankAccdgToYear", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("YearID", MySqlDbType.Int32).Value = YearID;

            DataSet ds = new DataSet();
            da.Fill(ds, "RankRecord");
            return ds;
        }

        //Read account for login
        public bool LocateAccount(string UserName, string UserPassword) //Needed parameter in stored procedure
        {
            recordFound = false;

            myCon.Open();
            MySqlCommand readUser = new MySqlCommand("LocateAccount", myCon);
            readUser.CommandType = CommandType.StoredProcedure;

            readUser.Parameters.Add("UserName", MySqlDbType.VarChar).Value = UserName;
            readUser.Parameters.Add("UserPassword", MySqlDbType.VarChar).Value = UserPassword;

            MySqlDataReader dr = readUser.ExecuteReader();

            while(dr.Read())
            {
                recordFound = true;
                break;
            }

            myCon.Close();
            return recordFound;
        }

        //Update records from echeon table
        public bool UpdateEchelon(int EchelonID, string EchelonName, string EchelonCode) //Needed parameter in stored procedure
        {
            recordFound = false;
            myCon.Open();

            try
            {
                MySqlCommand UpdateEchelon = new MySqlCommand("UpdateEchelon", myCon);
                UpdateEchelon.CommandType = CommandType.StoredProcedure;

                UpdateEchelon.Parameters.Add("EchelonID", MySqlDbType.Int32).Value = EchelonID;
                UpdateEchelon.Parameters.Add("EchelonName", MySqlDbType.VarChar).Value = EchelonName;
                UpdateEchelon.Parameters.Add("EchelonCode", MySqlDbType.VarChar).Value = EchelonCode;

                UpdateEchelon.ExecuteNonQuery();
                myCon.Close();
            }

            catch(Exception e)
            {
                Console.Error.WriteLine("" + e);
                myCon.Close();
                recordFound = true;
            }

            return recordFound;
        }

        //Update records from equipment table
        public bool UpdateEquipment(int EquipmentID, string EquipmentName, decimal EquipmentCost) //Needed parameter in stored procedure
        {
            recordFound = false;
            myCon.Open();

            try
            {
                MySqlCommand UpdateEquipment = new MySqlCommand("UpdateEquipment", myCon);
                UpdateEquipment.CommandType = CommandType.StoredProcedure;

                UpdateEquipment.Parameters.Add("EquipmentID", MySqlDbType.Int32).Value = EquipmentID;
                UpdateEquipment.Parameters.Add("EquipmentName", MySqlDbType.VarChar).Value = EquipmentName;
                UpdateEquipment.Parameters.Add("EquipmentCost", MySqlDbType.Decimal).Value = EquipmentCost;

                UpdateEquipment.ExecuteNonQuery();
                myCon.Close();
            }

            catch(Exception e)
            {
                Console.Error.WriteLine("" + e);
                myCon.Close();
                recordFound = true;
            }

            return recordFound;
        }

        //Update records from organization table
        public bool UpdateOrganization(int OrganizationID, string OrganizationName, int OrganizationEchelon, string OrganizationCode) //Needed parameter in stored procedure
        {
            recordFound = false;
            myCon.Open();

            try
            {
                MySqlCommand UpdateOrganization = new MySqlCommand("UpdateOrganization", myCon);
                UpdateOrganization.CommandType = CommandType.StoredProcedure;

                UpdateOrganization.Parameters.Add("OrganizationID", MySqlDbType.Int32).Value = OrganizationID;
                UpdateOrganization.Parameters.Add("OrganizationName", MySqlDbType.VarChar).Value = OrganizationName;
                UpdateOrganization.Parameters.Add("OrganizationEchelon", MySqlDbType.Int32).Value = OrganizationEchelon;
                UpdateOrganization.Parameters.Add("OrganizationCode", MySqlDbType.VarChar).Value = OrganizationCode;

                UpdateOrganization.ExecuteNonQuery();
                myCon.Close();
            }

            catch (Exception e)
            {
                Console.Error.WriteLine("" + e);
                myCon.Close();
                recordFound = true;
            }

            return recordFound;
        }

        //update records from rank table
        public bool UpdateRank(int RankID, string RankName, decimal RankSalary, string RankCode) //Needed parameter in stored procedure
        {
            recordFound = false;
            myCon.Open();

            try
            {
                MySqlCommand UpdateRank = new MySqlCommand("UpdateRanks", myCon);
                UpdateRank.CommandType = CommandType.StoredProcedure;

                UpdateRank.Parameters.Add("RankID", MySqlDbType.Int32).Value = RankID;
                UpdateRank.Parameters.Add("RankName", MySqlDbType.VarChar).Value = RankName;
                UpdateRank.Parameters.Add("RankSalary", MySqlDbType.Decimal).Value = RankSalary;
                UpdateRank.Parameters.Add("RankCode", MySqlDbType.VarChar).Value = RankCode;

                UpdateRank.ExecuteNonQuery();
                myCon.Close();
            }

            catch(Exception e)
            {
                Console.Error.WriteLine("" + e);
                myCon.Close();
                recordFound = true;
            }

            return recordFound;
        }

        //Returns Total Organization Salary Cost
        public decimal TotalOrgSalaryCost()
        {
            myCon.Open();

            decimal totalOrgSalaryCost = 0;

            //Gets position_id and rank_id according to organization
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayPositionAccdgToOrganization", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("OrganizationID", MySqlDbType.Int32).Value = organizationID;
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach(DataRow dataRow in dt.Rows)  //loops the data from the datatable dt
            {
                int posID = Convert.ToInt32(dataRow["position_id"].ToString());
                int rankID = Convert.ToInt32(dataRow["rank_id"].ToString());

                MySqlCommand daSalary = new MySqlCommand("GetCostForRank", myCon);
                daSalary.CommandType = CommandType.StoredProcedure;
                daSalary.Parameters.Add("PositionID", MySqlDbType.Int32).Value = posID;
                daSalary.Parameters.Add("RankID", MySqlDbType.Int32).Value = rankID;

                using(MySqlDataReader dr = daSalary.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        totalOrgSalaryCost += Convert.ToDecimal(dr["TotalCostOfRank"]); // Adds all the listed salary according to organization
                        break;
                    }
                }
            }
            myCon.Close();
            return totalOrgSalaryCost;
        }

        //Returns Total Personal Equipment Cost
        public decimal TotalPersonalCost()
        {
            myCon.Open();

            decimal totalPersonalCost = 0;

            MySqlDataAdapter dispPos = new MySqlDataAdapter("DisplayPositionAccdgToOrganization", myCon);
            dispPos.SelectCommand.CommandType = CommandType.StoredProcedure;
            dispPos.SelectCommand.Parameters.Add("OrganizationID", MySqlDbType.Int32).Value = organizationID;
            DataTable dt = new DataTable();
            dispPos.Fill(dt);

            foreach(DataRow dataRow in dt.Rows) //Loops the data from the datatable dt
            {
                int posID = Convert.ToInt32(dataRow["position_id"].ToString());

                MySqlDataAdapter dispPer = new MySqlDataAdapter("DisplayPerEquipmentAccdgToPositions", myCon);
                dispPer.SelectCommand.CommandType = CommandType.StoredProcedure;
                dispPer.SelectCommand.Parameters.Add("PositionID", MySqlDbType.Int32).Value = posID;
                DataTable dtPer = new DataTable();
                dispPer.Fill(dtPer);

                foreach (DataRow perRow in dtPer.Rows) //Loops the data from the datatable dtPer
                {
                    
                    int equipID = Convert.ToInt32(perRow["equipment_id"].ToString()); 

                    MySqlCommand getPerCost = new MySqlCommand("GetCostForPerEquip", myCon);
                    getPerCost.CommandType = CommandType.StoredProcedure;
                    getPerCost.Parameters.Add("PositionID", MySqlDbType.Int32).Value = posID;
                    getPerCost.Parameters.Add("EquipmentID", MySqlDbType.Int32).Value = equipID;

                    using(MySqlDataReader dr = getPerCost.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            totalPersonalCost += Convert.ToDecimal(dr["CostOfPerEquip"]); //Adds all the listed Personal Equipment Cost

                            break;
                        }
                    }
                }
            }
            myCon.Close();
            return totalPersonalCost;
        }

        //Returns Total Position Equipment Cost
        public decimal TotalPositionCost()
        {
            myCon.Open();

            decimal totalPositionCost = 0;

            MySqlDataAdapter dispPos = new MySqlDataAdapter("DisplayPositionAccdgToOrganization", myCon);
            dispPos.SelectCommand.CommandType = CommandType.StoredProcedure;
            dispPos.SelectCommand.Parameters.Add("OrganizationID", MySqlDbType.Int32).Value = organizationID;
            DataTable dt = new DataTable();
            dispPos.Fill(dt);

            foreach (DataRow dataRow in dt.Rows) //Loops the data from datatable dt
            {
                int posID = Convert.ToInt32(dataRow["position_id"].ToString());

                MySqlDataAdapter dispPer = new MySqlDataAdapter("DisplayPosEquipmentAccdgToPositions", myCon);
                dispPer.SelectCommand.CommandType = CommandType.StoredProcedure;
                dispPer.SelectCommand.Parameters.Add("PositionID", MySqlDbType.Int32).Value = posID;
                DataTable dtPer = new DataTable();
                dispPer.Fill(dtPer);

                foreach (DataRow perRow in dtPer.Rows) //Loops the data from datatable dtPer
                {

                    int equipID = Convert.ToInt32(perRow["equipment_id"].ToString());

                    MySqlCommand getPerCost = new MySqlCommand("GetCostForPosEquip", myCon);
                    getPerCost.CommandType = CommandType.StoredProcedure;
                    getPerCost.Parameters.Add("PositionID", MySqlDbType.Int32).Value = posID;
                    getPerCost.Parameters.Add("EquipmentID", MySqlDbType.Int32).Value = equipID;

                    using (MySqlDataReader dr = getPerCost.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            totalPositionCost += Convert.ToDecimal(dr["CostOfPosEquip"]);  //Adds all the listed Position Equipment Cost

                            break;
                        }
                    }
                }
            }
            myCon.Close();
            return totalPositionCost;
        }

        //Returns all Personal Equipment Hierarchy Cost
        public decimal TotalTreePerCost()
        {
            myCon.Open();

            decimal totalTreePerCost = 0;

            MySqlDataAdapter disTreePos = new MySqlDataAdapter("GetTree", myCon);
            disTreePos.SelectCommand.CommandType = CommandType.StoredProcedure;
            disTreePos.SelectCommand.Parameters.Add("Ancestor", MySqlDbType.Int32).Value = organizationID;
            DataTable dt = new DataTable();
            disTreePos.Fill(dt);

            foreach (DataRow dataRow in dt.Rows) //Loops the data from datatable dt
            {
                int orgID = Convert.ToInt32(dataRow["organization_id"].ToString());

                MySqlDataAdapter dispPos = new MySqlDataAdapter("DisplayPositionAccdgToOrganization", myCon);
                dispPos.SelectCommand.CommandType = CommandType.StoredProcedure;
                dispPos.SelectCommand.Parameters.Add("OrganizationID", MySqlDbType.Int32).Value = orgID;
                DataTable dtOrg = new DataTable();
                dispPos.Fill(dtOrg);

                foreach (DataRow dataRowPer in dtOrg.Rows) //Loops the data from datatable dtOrg
                {
                    int posID = Convert.ToInt32(dataRowPer["position_id"].ToString());

                    MySqlDataAdapter dispPer = new MySqlDataAdapter("DisplayPerEquipmentAccdgToPositions", myCon);
                    dispPer.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dispPer.SelectCommand.Parameters.Add("PositionID", MySqlDbType.Int32).Value = posID;
                    DataTable dtPer = new DataTable();
                    dispPer.Fill(dtPer);

                    foreach (DataRow perRow in dtPer.Rows) //Loops the data from datatable dtPer
                    {

                        int equipID = Convert.ToInt32(perRow["equipment_id"].ToString());

                        MySqlCommand getPerCost = new MySqlCommand("GetCostForPerEquip", myCon);
                        getPerCost.CommandType = CommandType.StoredProcedure;
                        getPerCost.Parameters.Add("PositionID", MySqlDbType.Int32).Value = posID;
                        getPerCost.Parameters.Add("EquipmentID", MySqlDbType.Int32).Value = equipID;

                        using (MySqlDataReader dr = getPerCost.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                totalTreePerCost += Convert.ToDecimal(dr["CostOfPerEquip"]); //Adds all the listed Personal Equipment Cost from hierarchy

                                break;
                            }
                        }
                    }
                }
            }
            myCon.Close();
            return totalTreePerCost;
        }

        //Returns all Position Equipment Hierarchy Cost
        public decimal TotalTreePosCost()
        {
            myCon.Open();

            decimal totalTreePosCost = 0;

            MySqlDataAdapter disTreePos = new MySqlDataAdapter("GetTree", myCon);
            disTreePos.SelectCommand.CommandType = CommandType.StoredProcedure;
            disTreePos.SelectCommand.Parameters.Add("Ancestor", MySqlDbType.Int32).Value = organizationID;
            DataTable dt = new DataTable();
            disTreePos.Fill(dt);

            foreach(DataRow dataRow in dt.Rows) //Loops the data from datatable dataRow
            {
                int orgID = Convert.ToInt32(dataRow["organization_id"].ToString());

                MySqlDataAdapter dispPos = new MySqlDataAdapter("DisplayPositionAccdgToOrganization", myCon);
                dispPos.SelectCommand.CommandType = CommandType.StoredProcedure;
                dispPos.SelectCommand.Parameters.Add("OrganizationID", MySqlDbType.Int32).Value = orgID;
                DataTable dtOrg = new DataTable();
                dispPos.Fill(dtOrg);

                foreach (DataRow dataRowPos in dtOrg.Rows) //Loops the data from datatable dtOrg
                {
                    int posID = Convert.ToInt32(dataRowPos["position_id"].ToString());

                    MySqlDataAdapter dispPer = new MySqlDataAdapter("DisplayPosEquipmentAccdgToPositions", myCon);
                    dispPer.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dispPer.SelectCommand.Parameters.Add("PositionID", MySqlDbType.Int32).Value = posID;
                    DataTable dtPer = new DataTable();
                    dispPer.Fill(dtPer);

                    foreach (DataRow perRow in dtPer.Rows) //Loops the data from datatable dtPer
                    {

                        int equipID = Convert.ToInt32(perRow["equipment_id"].ToString());

                        MySqlCommand getPerCost = new MySqlCommand("GetCostForPosEquip", myCon);
                        getPerCost.CommandType = CommandType.StoredProcedure;
                        getPerCost.Parameters.Add("PositionID", MySqlDbType.Int32).Value = posID;
                        getPerCost.Parameters.Add("EquipmentID", MySqlDbType.Int32).Value = equipID;

                        using (MySqlDataReader dr = getPerCost.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                totalTreePosCost += Convert.ToDecimal(dr["CostOfPosEquip"]); //Adds all the listed Position Equipment Cost from hierarchy

                                break;
                            }
                        }
                    }
                }
            }
            myCon.Close();
            return totalTreePosCost;
        }

        //Returns all Salary Hierarchy Cost
        public decimal TotalTreeSalaryCost()
        {
            myCon.Open();

            decimal totalTreeSalaryCost = 0;

            MySqlDataAdapter disTreePos = new MySqlDataAdapter("GetTree", myCon);
            disTreePos.SelectCommand.CommandType = CommandType.StoredProcedure;
            disTreePos.SelectCommand.Parameters.Add("Ancestor", MySqlDbType.Int32).Value = organizationID;
            DataTable dt = new DataTable();
            disTreePos.Fill(dt);

            foreach(DataRow dataRow in dt.Rows) //Loops the data from datatable dataRow
            {
                int orgID = Convert.ToInt32(dataRow["organization_id"].ToString());

                MySqlDataAdapter da = new MySqlDataAdapter("DisplayPositionAccdgToOrganization", myCon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("OrganizationID", MySqlDbType.Int32).Value = orgID;
                DataTable dtOrg = new DataTable();
                da.Fill(dtOrg);

                foreach (DataRow perRow in dtOrg.Rows) //Loops the data from datatable perRow
                {
                    int posID = Convert.ToInt32(perRow["position_id"].ToString());
                    int rankID = Convert.ToInt32(perRow["rank_id"].ToString());

                    MySqlCommand daSalary = new MySqlCommand("GetCostForRank", myCon);
                    daSalary.CommandType = CommandType.StoredProcedure;
                    daSalary.Parameters.Add("PositionID", MySqlDbType.Int32).Value = posID;
                    daSalary.Parameters.Add("RankID", MySqlDbType.Int32).Value = rankID;

                    using (MySqlDataReader dr = daSalary.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            totalTreeSalaryCost += Convert.ToDecimal(dr["TotalCostOfRank"]); //Adds all the listed Salary Cost from hierarchy
                            break;
                        }
                    }
                }
            }
            myCon.Close();
            return totalTreeSalaryCost;
        }

        //Returns Total equipment Cost per Organization
        public decimal TotalOrgEquipmentCost()
        {
            decimal totalOrgEquipmentCost = TotalPositionCost() + TotalPersonalCost();
            return totalOrgEquipmentCost;
        }

        //Returns Total Organization Cost per Organization
        public decimal TotalCurrentOrgCost()
        {
            decimal totalCurrentOrgCost = TotalOrgEquipmentCost() + TotalOrgSalaryCost();
            return totalCurrentOrgCost;
        }

        //Returns Total Position Equipment Cost per hierarchy
        public decimal TotalPositionEquipmentCost()
        {
            decimal totalPositionEquipmentCost = TotalTreePosCost() + TotalPositionCost();
            return totalPositionEquipmentCost;
        }

        //Returns Total Personal Equipment Cost per hierarchy
        public decimal TotalPersonalEquipmentCost()
        {
            decimal totalPersonalEquipmentCost = TotalTreePerCost() + TotalPersonalCost();
            return totalPersonalEquipmentCost;
        }

        //Returns Total Equipment Cost per hierarchy
        public decimal TotalEquipmentCost()
        {
            decimal totalEquipmentCost = TotalPositionEquipmentCost() + TotalPersonalEquipmentCost();
            return totalEquipmentCost;
        }

        //Returns Total Salary Cost per hierarchy
        public decimal TotalSalaryCost()
        {
            decimal totalSalaryCost = TotalTreeSalaryCost() + TotalOrgSalaryCost();
            return totalSalaryCost;
        }

        //Returns Total Cost of whole hierarchy
        public decimal TotalOrgCost()
        {
            decimal totalOrgCost = TotalEquipmentCost() + TotalSalaryCost();
            return totalOrgCost;
        }
    }
}