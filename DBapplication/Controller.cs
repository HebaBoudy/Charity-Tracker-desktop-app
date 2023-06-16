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

        public DataTable getBusses()
        {
            string query = "Select ID from Bus";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getQuantity(string btype)
        {
            string query = "select quantity from blood_stock where type='" + btype + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getQuantityFood(string ftype)
        {
            string query = "select quantity from Food_stock where name='" + ftype + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getQuantityClothes(string ctype,string size, string gender)
        {
            string query = "select quantity from Clothes_stock where Type='" + ctype + "' and size='"+size+"' and gender='"+gender+"' ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getQuantityBooks(string btype, string eduyear, string subject)
        {
            string query = "select quantity from book_stock where Name='" + btype + "' and Educational_year='" + eduyear + "' and subject='" + subject + "' ";
            return dbMan.ExecuteReader(query);
        }
        public int InsertFoodInStock(string type, int Quantity)
        {
            string query = "insert into Food_Stock values('" + type + "', " + Quantity + ")";

            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable CheckFoodsInStock(string type)
        {
            string query = "select * from Food_Stock where Name = '" + type + "'";

            return dbMan.ExecuteReader(query);
        }

        public int AddFoodQuantity(string type, int Quantity)
        {
            string query = "update Food_Stock set Quantity += " + Quantity + " where Name = '" + type + "' ";

            return dbMan.ExecuteNonQuery(query);
        }


        public int RemoveFood(string type, int Quantity)
        {
            string query = "update Food_Stock set Quantity -= " + Quantity + " where Name = '" + type + "' ";

            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectAllBloodStock()
        {
            string query = "select * from blood_stock";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllFoodStock()
        {
            string query = "select * from food_stock";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllClothesStock()
        {
            string query = "select * from clothes_stock";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllBooksStock()
        {
            string query = "select * from book_stock";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllClothesStockSize()
        {
            string query = "select Distinct size from clothes_stock";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllClothesStockGender()
        {
            string query = "select distinct gender from clothes_stock";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllBooksStockEduYear()
        {
            string query = "select distinct Educational_year from book_stock";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllBooksStockSubject()
        {
            string query = "select distinct subject from book_stock";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllEmployees()
        {
            string storedProcedureName = StoredProcedures.SelectAllEmployees;
            return dbMan.ExecuteReader(storedProcedureName, null);
        }

        public DataTable SelectEventName()
        {
            string query = "select distinct name from event";
            return dbMan.ExecuteReader(query);
        }

      

        public DataTable SelectVisitName()
        {
            string query = "select distinct Name from event, visit where visit.Event_ID=Event.ID ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllVolunteersInEvent(int eventid)
        {
            string query = "Select F_Name, M_Name, L_name from Participant, Event,Volunteers_In where Event.ID=" + eventid + " and Event.ID=Volunteers_In.Event_ID and Volunteers_In.Volunteer_ID=Participant.ID";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDrivers()
        {
            string query = "select F_name,M_name,L_name from Employee where Dep_ID=7";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectVisits()
        {
            string query = "select Name from event where Is_visit=1";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllDepartments()
        {
            string storedProcedureName = StoredProcedures.SelectAllDepartments;
            return dbMan.ExecuteReader(storedProcedureName, null);
        }

        public DataTable SelectEmployeesByDepartmentID(int id)
        {
            string query = "SELECT * From Employee Where Dep_ID='" + id + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllEvents()
        {
            string storedProcedureName = StoredProcedures.SelectAllEvents;
            return dbMan.ExecuteReader(storedProcedureName, null);
        }

        public DataTable SelectDateByEventName(string name)
        {
            string query = "Select Date From Event where Name = '" + name + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectVisitDateByEventName(string name)
        {
            string query = "Select Date From Event,visit where Name = '" + name + "' and visit.event_id=event.id";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllBloodDonations()
        {
            string storedProcedureName = StoredProcedures.SelectAllBloodDon;
            return dbMan.ExecuteReader(storedProcedureName, null);
        }

        public DataTable SelectAllFoodDonations()
        {
            string storedProcedureName = StoredProcedures.SelectAllFoodDon;
            return dbMan.ExecuteReader(storedProcedureName, null);
        }

        public DataTable SelectAllBookDonations()
        {
            string storedProcedureName = StoredProcedures.SelectAllBookDon;
            return dbMan.ExecuteReader(storedProcedureName, null);
        }

        public DataTable SelectAllClothesDonations()
        {
            string storedProcedureName = StoredProcedures.SelectAllClothesDon;
            return dbMan.ExecuteReader(storedProcedureName, null);
        }

        public DataTable SelectAllMoneyDonations()
        {
            string storedProcedureName = StoredProcedures.SelectAllMoneyDon;
            return dbMan.ExecuteReader(storedProcedureName, null);
        }

        public DataTable SelectDonationByPhoneNumber(string phonenum, string usertype, string formtype)
        {
            if (formtype == "blood")
            {
                if (usertype == "employee")
                {
                    string query = "Select F_name,M_name,L_name,Quantity,Donation_date From Blood_Donation,Employee where Employee.ID=Blood_Donation.Handler_ID and Employee.Phone_No='" + phonenum + "'";
                    return dbMan.ExecuteReader(query);
                }
                else
                {
                    string query = "Select F_name,M_name,L_name,Quantity,Donation_date From Blood_Donation,Participant where Participant.ID=Blood_Donation.Donor_ID and Participant.Phone_No='" + phonenum + "'";
                    return dbMan.ExecuteReader(query);
                }
            }
            else if (formtype == "food")
            {
                if (usertype == "employee")
                {
                    string query = "Select F_name,M_name,L_name,Quantity,Donation_date From Food_Donation,Employee where Employee.ID=Food_Donation.Handler_ID and Employee.Phone_No='" + phonenum + "'";
                    return dbMan.ExecuteReader(query);
                }
                else
                {
                    string query = "Select F_name,M_name,L_name,Quantity,Donation_date From Food_Donation,Participant where Participant.ID=Food_Donation.Donor_ID and Participant.Phone_No='" + phonenum + "'";
                    return dbMan.ExecuteReader(query);
                }
            }

            else if (formtype == "books")
            {
                if (usertype == "employee")
                {
                    string query = "Select F_name,M_name,L_name,Quantity,Donation_date From Books_Donation,Employee where Employee.ID=Books_Donation.Handler_ID and Employee.Phone_No='" + phonenum + "'";
                    return dbMan.ExecuteReader(query);
                }
                else
                {
                    string query = "Select F_name,M_name,L_name,Quantity,Donation_date From Books_Donation,Participant where Participant.ID=Books_Donation.Donor_ID and Participant.Phone_No='" + phonenum + "'";
                    return dbMan.ExecuteReader(query);
                }
            }

            else if (formtype == "clothes")
            {
                if (usertype == "employee")
                {
                    string query = "Select F_name,M_name,L_name,Quantity,Donation_date From Clothes_Donation,Employee where Employee.ID=Clothes_Donation.Handler_ID and Employee.Phone_No='" + phonenum + "'";
                    return dbMan.ExecuteReader(query);
                }
                else
                {
                    string query = "Select F_name,M_name,L_name,Quantity,Donation_date From Clothes_Donation,Participant where Participant.ID=CLothes_Donation.Donor_ID and Participant.Phone_No='" + phonenum + "'";
                    return dbMan.ExecuteReader(query);
                }
            }
            else
            {
                if (usertype == "employee")
                {
                    string query = "Select F_name,M_name,L_name,Amount,Donation_date From Money_Donations,Employee where Employee.ID=Money_Donations.Handler_ID and Employee.Phone_No='" + phonenum + "'";
                    return dbMan.ExecuteReader(query);
                }
                else
                {
                    string query = "Select F_name,M_name,L_name,Amount,Donation_date From Money_Donations,Participant where Participant.ID=Money_Donations.Donor_ID and Participant.Phone_No='" + phonenum + "'";
                    return dbMan.ExecuteReader(query);

                }
            }
        }

        public DataTable isExistingEvent(string name, string date)
        {
            string query = "select * from event where Name='" + name + "' and date ='" + date + "'";
            return dbMan.ExecuteReader(query);
        }



        public DataTable SelectBookDonationByYear(string year)
        {
            string query = "Select Name,subject,Quantity from Books_Donation where Educational_year='" + year + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectBookDonationBySubject(string subject)
        {
            string query = "Select Name,educational_year,Quantity from Books_Donation where Subject='" + subject + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectByEduYear()
        {
            string query = "select distinct Educational_Year from Books_Donation";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectParticipantCount(int eventID)
        {
            string query = "Select Count(Volunteer_ID) from Volunteers_In Where Event_ID=" + eventID + "";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectBySubject()
        {
            string query = "select distinct Subject from Books_Donation";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDistinctDate(string ftype)
        {
            if (ftype == "blood")
            {
                string query = "select distinct Donation_date from Blood_Donation";
                return dbMan.ExecuteReader(query);

            }
            else if (ftype == "clothes")
            {
                string query = "select distinct Donation_date from Clothes_Donation";
                return dbMan.ExecuteReader(query);
            }
            else if (ftype == "food")
            {
                string query = "select distinct Donation_date from Food_Donation";
                return dbMan.ExecuteReader(query);
            }
            else
            {
                string query = "select distinct Donation_date from Books_Donation";
                return dbMan.ExecuteReader(query);
            }
        }


        public DataTable SelectDistinctExpiry(string ftype)
        {
            if (ftype == "blood")
            {
                string query = "select distinct Expiry_date from Blood_Donation";
                return dbMan.ExecuteReader(query);
            }
            else
            {
                string query = "select distinct Expiry_date from Food_Donation";
                return dbMan.ExecuteReader(query);
            }
        }

        public DataTable SelectByDestination()
        {
            string query = "select distinct Destination from Money_Donations";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectByClothesType()
        {
            string query = "select distinct Type from Clothes_Donation";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectByFoodType()
        {
            string query = "select distinct Name from Food_Donation";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectByBloodType(string type)
        {
            string query = "Select Type, Quantity,Expiry_date from Blood_Donation where Type='" + type + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectFoodDonationByType(string type)
        {
            string query = "Select Quantity, Expiry_date from Food_Donation where Name='" + type + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectFoodDonationByExpDate(string date)
        {
            string query = "Select Name, Quantity from Food_Donation where Expiry_date='" + date + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectBloodByDate(string date, string type)
        {
            if (type == "Expiry")
            {
                string query = "Select Type,Quantity from Blood_Donation where Expiry_date='" + date + "'";
                return dbMan.ExecuteReader(query);
            }
            else
            {
                string query = "Select Type,Quantity from Blood_Donation where Donation_date='" + date + "'";
                return dbMan.ExecuteReader(query);
            }
        }

        public DataTable SelectClothesByType(string type)
        {
            string query = "Select Quantity,Gender,Size from Clothes_Donation where Type = '" + type + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectClothesByGender(string gender)
        {
            string query = "Select Quantity,Type,Size from Clothes_Donation where Gender = '" + gender + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectClothesBySize(string size)
        {
            string query = "Select Quantity,Gender,Type from Clothes_Donation where Size = '" + size + "'";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectEventByNameAndDate(string name, string date)
        {
            string query = "Select Cost , Participants_No,status,duration,supervisor_id From Event Where Name = '" + name + "' and date = '" + date + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectVisitByNameAndDate(string name, string date)
        {
            string query = "Select Participants_No,ID From Event,visit Where Name = '" + name + "' and date = '" + date + "' and visit.Event_id=event.id ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable EventByNameAndDate(string name, string date)
        {
            string query = "Select Participants_No, status,ID From Event Where Name = '" + name + "' and date = '" + date + "'";
            return dbMan.ExecuteReader(query);
        }
        public int AddBusToEvent(int driverid, int eventid, int busid)
        {
            string query = "insert into drives values(" + busid + "," + eventid + "," + driverid + ")";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectEmployeesByPhoneNumber(string phoneNum)
        {
            string query = "SELECT * From Employee Where Phone_No='" + phoneNum + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectParticipantIDByPhoneNumber(string phoneNum)
        {
            string query = "SELECT ID From Participant Where Phone_No='" + phoneNum + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GenerateID()
        {
            string query = "SELECT max(ID) From Employee ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GenerateBookID()
        {
            string query = "SELECT max(ID) From Books_Donation ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GenerateParticipantID()
        {
            string query = "SELECT max(ID) From Participant ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GenerateClothesID()
        {
            string query = "SELECT max(ID) From Clothes_Donation";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GenerateBloodID()
        {
            string query = "SELECT max(ID) From Blood_Donation";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GenerateFoodID()
        {
            string query = "SELECT max(ID) From Food_Donation";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GenerateEventID()
        {
            string query = "SELECT max(ID) From Event";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GenerateMoneyID()
        {
            string query = "SELECT max(ID) From Money_Donations";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GenerateBusID()
        {
            string query = "SELECT max(ID) From Bus";
            return dbMan.ExecuteReader(query);
        }

        public int InsertBus(int id,int capacity)
        {
            string query = "insert into bus values("+id+","+capacity+")";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectAllBusses()
        {
            string query = "SELECT * From Bus";
            return dbMan.ExecuteReader(query);
        }
        public int InsertParticipant(int id, string fname, string mname, string lname, string phone, int age, string gender, string address, string email)
        {
            string StoredProcedureName = StoredProcedures.InsertParticipant;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            Parameters.Add("@F_Name", fname);
            Parameters.Add("@M_Name", mname);
            Parameters.Add("@L_Name", lname);
            Parameters.Add("@Phone_No", phone);
            Parameters.Add("@Age", age);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@Address", address);
            Parameters.Add("@email", email);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int InsertVolunteer(int eventID, int volunteerID)
        {
            string StoredProcedureName = StoredProcedures.InsertVolunteer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Volunteer_ID", volunteerID);
            Parameters.Add("@Event_ID", eventID);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertVisit(int eventID, string ename)
        {
            string StoredProcedureName = StoredProcedures.InsertVisit;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Establishment_Name", ename);
            Parameters.Add("@Event_ID", eventID);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertNonVisit(int eventID, string location)
        {
            string StoredProcedureName = StoredProcedures.InsertNonVisit;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Location", location);
            Parameters.Add("@Event_ID", eventID);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int InsertEmployee(int id, string fname, string mname, string lname, string phone, int age, string gender, int salary, int dep_id, string mail, int hrs)
        {

            string StoredProcedureName = StoredProcedures.InsertEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            Parameters.Add("@F_Name", fname);
            Parameters.Add("@M_Name", mname);
            Parameters.Add("@L_Name", lname);
            Parameters.Add("@Phone_No", phone);
            Parameters.Add("@Age", age);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@Salary", salary);
            Parameters.Add("@Dep_ID", dep_id);
            Parameters.Add("@E_Address", mail);
            Parameters.Add("@Working_Hrs", hrs);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int UpdateEmployeePhoneNumber(string number1, string newnumber)
        {
            string query = "update Employee set Phone_No='" + newnumber + "' where Phone_No='" + number1 + "'";

            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteEmployeeByPhoneNumber(string phone)
        {

            string query = "delete from Employee where Phone_No='" + phone + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteEventByNameandDate(string eventname, string date)
        {
            string query = "delete from Event where Name='" + eventname + "' and date='" + date + "'";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateEmployeeDepartment(int id, string phoneNum)
        {
            string query = "update Employee set Dep_ID='" + id + "' where Phone_No='" + phoneNum + "'";

            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectDepartmentByPhoneNumber(string phoneNum)
        {
            string query = "select Department.ID from Department ,Employee where Employee.Dep_ID=Department.ID and Employee.Phone_No='" + phoneNum + "'";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateEmployeeSalaryByPhoneNumber(int salary, string phoneNum)
        {
            string query = "update Employee set Salary='" + salary + "' where Phone_No='" + phoneNum + "'";

            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateEmployeeHrsByPhoneNumber(int hrs, string phoneNum)
        {
            string query = "update Employee set Working_hrs= " + hrs + " where Phone_No='" + phoneNum + "'";

            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateEmployeeEmailByPhoneNumber(string mail, string phoneNum)
        {
            string query = "update Employee set E_Address ='" + mail + "' where Phone_No='" + phoneNum + "'";

            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertBook(int id, string name, int atOff, string date, int Quantity, string EduYear, string Sub, int HandlerId, int DonorID)
        {
            string StoredProcedureName = StoredProcedures.InsertBook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            Parameters.Add("@Name", name);
            Parameters.Add("@At_Office", atOff);
            Parameters.Add("@Donation_date", date);
            Parameters.Add("@Quantity", Quantity);
            Parameters.Add("@Educational_year", EduYear);
            Parameters.Add("@Subject", Sub);
            Parameters.Add("@Handler_ID", HandlerId);
            Parameters.Add("@Donor_ID", DonorID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int InsertClothes(int id, string size, string gender, int quantity, string date, int atOffice, string cType, int HandlerID, int DonorID)
        {
            string StoredProcedureName = StoredProcedures.InsertClothes;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            Parameters.Add("@Size", size);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@Quantity", quantity);
            Parameters.Add("@Donation_date", date);
            Parameters.Add("@At_Office", atOffice);
            Parameters.Add("@Type", cType);
            Parameters.Add("@Handler_ID", HandlerID);
            Parameters.Add("@Donor_ID", DonorID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertBlood(int id, int quantity, string expirydate, string donationdate, string type, string destination, int handlerid, int donorid)
        {
            string StoredProcedureName = StoredProcedures.InsertBlood;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            Parameters.Add("@Quantity", quantity);
            Parameters.Add("@Expiry_date", expirydate);
            Parameters.Add("@Donation_date", donationdate);
            Parameters.Add("@Type", type);
            Parameters.Add("@Destination", destination);
            Parameters.Add("@Handler_ID", handlerid);
            Parameters.Add("@Donor_ID", donorid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertFood(int id, string type, int quantity, string expirydate, string donationdate, int handlerid, int donorid)
        {
            string StoredProcedureName = StoredProcedures.InsertFood;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            Parameters.Add("@Name", type);
            Parameters.Add("@Quantity", quantity);
            Parameters.Add("@Donation_date", donationdate);
            Parameters.Add("@Expiry_date", expirydate);
            Parameters.Add("@Handler_ID", handlerid);
            Parameters.Add("@Donor_ID", donorid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertMoney(int id, string donationdate, int amount, string destination, int atoffice, int handlerid, int donorid)
        {
            string StoredProcedureName = StoredProcedures.InsertMoney;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            Parameters.Add("@Donation_date", donationdate);
            Parameters.Add("@Amount", amount);
            Parameters.Add("@Destination", destination);
            Parameters.Add("@At_office", atoffice);
            Parameters.Add("@Handler_ID", handlerid);
            Parameters.Add("@Donor_ID", donorid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }



        public int InsertEvent(int id, int isvisit, string name, int cost, int pnum, int supervisorid, string status, string date, int duration)
        {
            string StoredProcedureName = StoredProcedures.InsertEvent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            Parameters.Add("@Is_Visit", isvisit);
            Parameters.Add("@Name", name);
            Parameters.Add("@Cost", cost);
            Parameters.Add("@Participants_No", pnum);
            Parameters.Add("@Supervisor_ID", supervisorid);
            Parameters.Add("@status", status);
            Parameters.Add("@date", date);
            Parameters.Add("@duration", duration);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable SelectAllEstablishments()
        {
            string storedProcedureName = StoredProcedures.SelectAllEstablishments;
            return dbMan.ExecuteReader(storedProcedureName, null);
        }
        public DataTable SelectEstablishmentByName(string name)
        {
            string query = "select * from Establishment where Name = '" + name + "'";
            return dbMan.ExecuteReader(query);
        }
        public int DeleteEstablishment(string name)
        {
            string query = "delete from Establishment where Name = '" + name + "' ";
            return dbMan.ExecuteNonQuery(query);
        }
        public int AddEstablishment(string name, string phone, string Bank_Account, string Email, int donations, int visits, string location)
        {
            string StoredProcedureName = StoredProcedures.InsertEstablishment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Phone_No", phone);
            Parameters.Add("@Bank_Account", Bank_Account);
            Parameters.Add("@Email", Email);
            Parameters.Add("@Total_Donations", donations);
            Parameters.Add("@Total_Visits", visits);
            Parameters.Add("@Location", location);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteFromU_Login()
        {
            string query = "DELETE from U_Login WHERE pass = 'User Deleted'";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateU_LoginDepartment(int newDepID, string Phone)
        {
            string query = "UPDATE U_Login SET Dep_ID = " + newDepID + " where U_ID = (SELECT ID FROM Employee WHERE Phone_No='" + Phone + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectAllUsers()
        {
            string storedProcedureName = StoredProcedures.SelectAllUsers;
            return dbMan.ExecuteReader(storedProcedureName, null);
        }

        public int ChangePassword(string newPass, string username)
        {
            string query = " UPDATE U_Login SET Pass='" + newPass + "' where  UserName='" + username + "'";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable IsPasswordExists(string newpass)
        {
            string query = " SELECT pass from u_login where pass = '" + newpass + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectBusses()
        {
            string query = "Select ID from Bus;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectBusByID(int id)
        {
            string query = "Select Capacity from bus where id=" + id + "";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectDonationsByDestination(string destination)
        {
            string query = "Select Sum(Amount) from Money_Donations where Destination ='" + destination + "'";
            return dbMan.ExecuteReader(query);
        }


        public int UpdateVisits(string name)
        {
            string query = "update Establishment set Total_Visits += 1 where Name = '" + name + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateDonations(string name, int amount)
        {
            string query = "update Establishment set Total_Donations += " + amount + " where Name = '" + name + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateEventCost(string eventname, string date, int newcost)
        {
            string query = "update Event set Cost=" + newcost + " where Name='" + eventname + "' and date='" + date + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateEventStatus(string eventname, string date, string status)
        {
            string query = "update Event set Status='" + status + "' where Name='" + eventname + "' and date='" + date + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateEventDuration(string eventname, string date, int duration)
        {
            string query = "update Event set duration=" + duration + " where Name='" + eventname + "' and date='" + date + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateEventSupervisor(string eventname, string date, int supID)
        {
            string query = "update Event set Supervisor_Id=" + supID + " where Name='" + eventname + "' and date='" + date + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertBookInStock(string name, int Quantity, string EduYear, string Sub)
        {
            string query = "insert into Book_Stock values('" + name + "', '" + EduYear + "', '" + Sub + "', " + Quantity + ")";

            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable CheckBookInStock(string name, string EduYear, string Sub)
        {
            string query = "SELECT * FROM BOOK_STOCK WHERE NAME = '" + name + "' AND EDUCATIONAL_YEAR = '" + EduYear + "' AND SUBJECT = '" + Sub + "'";

            return dbMan.ExecuteReader(query);
        }


        public int AddBookQuantity(string name, int Quantity, string EduYear, string Sub)
        {
            string query = "update Book_Stock set Quantity+= " + Quantity + " where Name = '" + name + "' and    Educational_year = '" + EduYear + "' and Subject = '" + Sub + "'  ";

            return dbMan.ExecuteNonQuery(query);

        }

        public int RemoveBook(string name, int Quantity, string EduYear, string Sub)
        {
            string query = "update Book_Stock set Quantity-= " + Quantity + " where Name = '" + name + "' and    Educational_year = '" + EduYear + "' and Subject = '" + Sub + "'  ";

            return dbMan.ExecuteNonQuery(query);

        }

        public int InsertBloodInStock(string type, int Quantity)
        {
            string query = "insert into Blood_Stock values('" + type + "', " + Quantity + ")";

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable CheckBloodInStock(string type)
        {
            string query = "select * from Blood_Stock where type = '" + type + "'";

            return dbMan.ExecuteReader(query);
        }
        public int AddBloodQuantity(string type, int Quantity)
        {
            string query = "update Blood_Stock set Quantity += " + Quantity + " where Type = '" + type + "' ";

            return dbMan.ExecuteNonQuery(query);
        }

        public int RemoveBlood(string type, int Quantity)
        {
            string query = "update Blood_Stock set Quantity -= " + Quantity + " where Type = '" + type + "' ";

            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertClothesInStock(string type, string size, string gender, int Quantity)
        {
            string query = "insert into Clothes_Stock values('" + type + "', '" + size + "','" + gender + "', " + Quantity + ")";

            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable CheckClothesInStock(string type, string size, string gender)
        {
            string query = "select * from Clothes_Stock where Type = '" + type + "' and Size = '" + size + "' and gender = '" + gender + "'";

            return dbMan.ExecuteReader(query);
        }
        public int AddClothesQuantity(string type, string size, string gender, int Quantity)
        {
            string query = "update Clothes_Stock set Quantity += " + Quantity + " where Type = '" + type + "'and Size = '" + size + "' and gender = '" + gender + "' ";

            return dbMan.ExecuteNonQuery(query);
        }

        public int RemoveClothes(string type, string size, string gender, int Quantity)
        {
            string query = "update Clothes_Stock set Quantity -= " + Quantity + " where Type = '" + type + "'and Size = '" + size + "' and gender = '" + gender + "' ";

            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertIntoU_login(int ID, int dep, string username)
        {
            string query = "insert into U_Login values(" + ID + ", '1234', " + dep + ", '" + username + "')";

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable IsUsernameExists(string UserName)
        {
            string query = " SELECT UserName from u_login where UserName = '" + UserName + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetNameOfHighestCostEvent()
        {
            string query = "select  Name from Event where Participants_No = (SELECT MAX(Participants_No)FROM Event)";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetNameOfMaxParticipantsEvent()
        {
            string query = "select  Name from Event where Cost = (SELECT MAX(Cost)FROM Event)";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetCountOfVisits()
        {
            string query = "select count(*) from Non_Visit";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetCountOfNonVisits()
        {
            string query = "select count(*) from Visit";
            return dbMan.ExecuteReader(query);
        }
        public DataTable AvgSalary_Group_By_Dep()
        {
            string query = "select ((SELECT Name  FROM Department where ID=Dep_ID)) , AVG(Salary) as average_salary from Employee\r\nGROUP BY Dep_ID";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetCurrentBalance()
        {
            string query = "SELECT count(Amount) from Money_Donations where Destination = 'Main Office'\r\n";
            return dbMan.ExecuteReader(query);
        }

        public int SubtractFromAmount(int amount)
        {
            amount *= -1;
            string query = "UPDATE Money_Donations set Amount = "+amount+" where Destination = 'Main Office'";

            return dbMan.ExecuteNonQuery(query);
        }

        
    }

}
