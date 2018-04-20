﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataHelper
{
    public class DataAccess
    {
        bool recordFound;
        string positionName;
        decimal equipmentCost, perEquipmentTotalCost;
        int positionID, personnelQty, rankID, organizationID, equipmentID, equipmentQty, totalPosition;

        static string con = @"server=localhost;user id=root;pwd=root;persistsecurityinfo=True;database=netcsys;SslMode=none";
        MySqlConnection myCon = new MySqlConnection(con);

        public int PositionID
        {
            get { return positionID; }
            set { positionID = value; }
        }

        public string PositionName
        {
            get { return positionName; }
            set { positionName = value; }
        }
        public int EquipmentID
        {
            get { return equipmentID; }
            set { equipmentID = value; }
        }

        public decimal PerEquipmentTotalCost
        {
            get { return perEquipmentTotalCost; }
            set { perEquipmentTotalCost = value; }
        }

        public decimal EquipmentCost
        {
            get { return equipmentCost; }
            set { equipmentCost = value; }
        }

        public int PersonnelQuantity
        {
            get { return personnelQty; }
            set { personnelQty = value; }
        }

        public int RankID
        {
            get { return rankID; }
            set { rankID = value; }
        }

        public int TotalPosition
        {
            get { return totalPosition; }
            set { totalPosition = value; }
        }

        public int OrganizationID
        {
            get { return organizationID; }
            set { organizationID = value; }
        }

        //Add Equipment
        public void AddEquipment(string EquipmentName, decimal EquipmentCost)
        {
            myCon.Open();
            MySqlCommand SaveEquipment = new MySqlCommand("AddEquipment", myCon);
            SaveEquipment.CommandType = CommandType.StoredProcedure;

            SaveEquipment.Parameters.Add("EquipmentName", MySqlDbType.VarChar).Value = EquipmentName;
            SaveEquipment.Parameters.Add("EquipmentCost", MySqlDbType.VarChar).Value = EquipmentCost;

            SaveEquipment.ExecuteNonQuery();
            myCon.Close();
        }

        //Add Rank
        public void AddRank(string RankName, decimal RankSalary)
        {

            myCon.Open();
            MySqlCommand SaveRank = new MySqlCommand("AddRank", myCon);
            SaveRank.CommandType = CommandType.StoredProcedure;

            SaveRank.Parameters.Add("RankName", MySqlDbType.VarChar).Value = RankName;
            SaveRank.Parameters.Add("RankSalary", MySqlDbType.VarChar).Value = RankSalary;

            SaveRank.ExecuteNonQuery();
            myCon.Close();
        }

        //Add User
        public bool AddUser(string UserName, string UserPassword)
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

            return recordFound;
        }

        //Add Echelon
        public void AddEchelon(string EchelonName)
        {
            //recordFound = false;
            myCon.Open();

           MySqlCommand SaveEchelon = new MySqlCommand("AddEchelon", myCon);
           SaveEchelon.CommandType = CommandType.StoredProcedure;

           SaveEchelon.Parameters.Add("EchelonName", MySqlDbType.VarChar).Value = EchelonName;

           SaveEchelon.ExecuteNonQuery();
           myCon.Close();

            
        }

        //Add Organization
        public void AddOrganization(string OrganizationName, int OrganizationEchelon, int OrganizationStatus, int YearStart, int YearEnd)
        {
            myCon.Open();

            MySqlCommand SaveOrganization = new MySqlCommand("AddOrganization", myCon);
            SaveOrganization.CommandType = CommandType.StoredProcedure;

            SaveOrganization.Parameters.Add("OrganizationName", MySqlDbType.VarChar).Value = OrganizationName;
            SaveOrganization.Parameters.Add("OrganizationEchelon", MySqlDbType.Int32).Value = OrganizationEchelon;
            SaveOrganization.Parameters.Add("OrganizationStatus", MySqlDbType.Int32).Value = OrganizationStatus;
            SaveOrganization.Parameters.Add("YearStart", MySqlDbType.Int32).Value = YearStart;
            SaveOrganization.Parameters.Add("YearEnd", MySqlDbType.Int32).Value = YearEnd;

            SaveOrganization.ExecuteNonQuery();
            myCon.Close();
        }

        //Add Position
        public void AddPosition(string PositionName, int PersonnelQuantity, int RankID, int OrganizationID)
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

        //Add Equipment for Position
        public void AddPositionEquipment(int EquipmentID,int EquipmentQuantity)
        {
            myCon.Open();

            MySqlCommand SavePosEquipment = new MySqlCommand("AddPositionEquipment", myCon);
            SavePosEquipment.CommandType = CommandType.StoredProcedure;

            SavePosEquipment.Parameters.Add("EquipmentID", MySqlDbType.Int32).Value = EquipmentID;
            SavePosEquipment.Parameters.Add("EquipmentQuantity", MySqlDbType.Int32).Value = EquipmentQuantity;

            SavePosEquipment.ExecuteNonQuery();
            myCon.Close();
        }

        //Add Equipment for Personnel
        public void AddPersonalEquipment(int EquipmentID, int EquipmentQuantity)
        {
            myCon.Open();

            MySqlCommand SavePerEquipment = new MySqlCommand("AddPersonalEquipment", myCon);
            SavePerEquipment.CommandType = CommandType.StoredProcedure;

            SavePerEquipment.Parameters.Add("EquipmentID", MySqlDbType.Int32).Value = EquipmentID;
            SavePerEquipment.Parameters.Add("EquipmentQuantity", MySqlDbType.Int32).Value = EquipmentQuantity;

            SavePerEquipment.ExecuteNonQuery();
            myCon.Close();
        }

        //Count Position
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

        //Delete Echelon
        public void DeleteEchelon(int EchelonID)
        {
            myCon.Open();

            MySqlCommand DeleteEchelon = new MySqlCommand("DeleteEchelon", myCon);
            DeleteEchelon.CommandType = CommandType.StoredProcedure;

            DeleteEchelon.Parameters.Add("EchelonID", MySqlDbType.Int32).Value = EchelonID;

            DeleteEchelon.ExecuteNonQuery();
            myCon.Close();
        }

        //Delete Equipment
        public void DeleteEquipment(int EquipmentID)
        {
            myCon.Open();

            MySqlCommand DeleteEquipment = new MySqlCommand("DeleteEquipment", myCon);
            DeleteEquipment.CommandType = CommandType.StoredProcedure;

            DeleteEquipment.Parameters.Add("EquipmentID", MySqlDbType.Int32).Value = EquipmentID;

            DeleteEquipment.ExecuteNonQuery();
            myCon.Close();
        }

        //Delete Organization
        public void DeleteOrganization(int OrganizationID)
        {
            myCon.Open();

            MySqlCommand DeleteOrganization = new MySqlCommand("DeleteOrganization", myCon);
            DeleteOrganization.CommandType = CommandType.StoredProcedure;

            DeleteOrganization.Parameters.Add("OrganizationID", MySqlDbType.Int32).Value = OrganizationID;

            DeleteOrganization.ExecuteNonQuery();
            myCon.Close();
        }

        //Delete Rank
        public void DeleteRank(int RankID)
        {
            myCon.Open();

            MySqlCommand DeleteRank = new MySqlCommand("DeleteRank", myCon);
            DeleteRank.CommandType = CommandType.StoredProcedure;

            DeleteRank.Parameters.Add("RankID", MySqlDbType.Int32).Value = RankID;

            DeleteRank.ExecuteNonQuery();
            myCon.Close();
        }

        // Display Echelon in Table
        public DataSet DisplayEchelon()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayEchelon", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "EchelonRecord");
            return ds;
        }

        public DataSet DisplayStatus()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayStatus", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "StatusRecord");
            return ds;
        }

        public DataSet DisplayEquipment()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayEquipment", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "EquipmentRecord");
            return ds;
        }

        public DataSet DisplayPositionAccdgToOrganization(int OrganizationID)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayPositionAccdgToOrganization", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("OrganizationID", MySqlDbType.Int32).Value = OrganizationID;

            DataSet ds = new DataSet();
            da.Fill(ds, "PositionRecord");
            return ds;
        }

        public DataSet DisplayPerEquipmentAccdgToPositions(int PositionID)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayPerEquipmentAccdgToPositions", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("PositionID", MySqlDbType.Int32).Value = PositionID;

            DataSet ds = new DataSet();
            da.Fill(ds, "PerEquipRecord");
            return ds;
        }

        public DataSet DisplayPosEquipmentAccdgToPositions(int PositionID)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayPosEquipmentAccdgToPositions", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("PositionID", MySqlDbType.Int32).Value = PositionID;

            DataSet ds = new DataSet();
            da.Fill(ds, "PosEquipRecord");
            return ds;
        }

        public bool GetCostForPerEquip (int PositionID, int EquipmentID)
        {
            recordFound = false;
            myCon.Open();

            MySqlCommand getTotalCost = new MySqlCommand("GetCostForPerEquip", myCon);
            getTotalCost.CommandType = CommandType.StoredProcedure;

            getTotalCost.Parameters.Add("PositionID", MySqlDbType.Int32).Value = PositionID;
            getTotalCost.Parameters.Add("EquipmentID", MySqlDbType.Int32).Value = EquipmentID;

            MySqlDataReader dr = getTotalCost.ExecuteReader();

            while(dr.Read())
            {
                recordFound = true;

                perEquipmentTotalCost = Convert.ToDecimal(dr["CostOfPerEquip"]);

                break;
            }

            myCon.Close();
            return recordFound;
        }

        public bool DisplayEquipmentForPosition(int EquipmentID)
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

        public DataSet DisplayOrganization(int StatusID)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayOrganization", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("StatusID", MySqlDbType.Int32).Value = StatusID;

            DataSet ds = new DataSet();
            da.Fill(ds, "OrganizationRecord");
            return ds;
        }

        public DataSet DisplayOrganizationAccdgToStatus(int StatusID)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayOrganizationAccdgToStatus", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("StatusID", MySqlDbType.Int32).Value = StatusID;

            DataSet ds = new DataSet();
            da.Fill(ds, "StatusRecord");
            return ds;
        }

        public DataSet DisplayOrganizationWithEchelonName()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayOrganizationWithEchelonName", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "OrganizationRecord");
            return ds;
        }

        public DataSet DisplayRank()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DisplayRank", myCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "RankRecord");
            return ds;
        }

        public bool LocateAccount(string UserName, string UserPassword)
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

        public bool UpdateEchelon(int EchelonID, string EchelonName)
        {
            recordFound = false;
            myCon.Open();

            try
            {
                MySqlCommand UpdateEchelon = new MySqlCommand("UpdateEchelon", myCon);
                UpdateEchelon.CommandType = CommandType.StoredProcedure;

                UpdateEchelon.Parameters.Add("EchelonID", MySqlDbType.Int32).Value = EchelonID;
                UpdateEchelon.Parameters.Add("EchelonName", MySqlDbType.VarChar).Value = EchelonName;

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

        public bool UpdateEquipment(int EquipmentID, string EquipmentName, decimal EquipmentCost)
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

        public bool UpdateOrganization(int OrganizationID, string OrganizationName, int OrganizationEchelon)
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

        public bool UpdateRank(int RankID, string RankName, decimal RankSalary)
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
    }
}