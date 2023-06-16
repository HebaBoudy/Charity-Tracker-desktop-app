﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBapplication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FinalCharityTrackerEntities : DbContext
    {
        public FinalCharityTrackerEntities()
            : base("name=FinalCharityTrackerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Blood_Donation> Blood_Donation { get; set; }
        public virtual DbSet<Blood_Stock> Blood_Stock { get; set; }
        public virtual DbSet<Book_Stock> Book_Stock { get; set; }
        public virtual DbSet<Books_Donation> Books_Donation { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<@class> classes { get; set; }
        public virtual DbSet<Clothes_Donation> Clothes_Donation { get; set; }
        public virtual DbSet<Clothes_Stock> Clothes_Stock { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Drive> Drives { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Establishment> Establishments { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Food_Donation> Food_Donation { get; set; }
        public virtual DbSet<Food_Stock> Food_Stock { get; set; }
        public virtual DbSet<Money_Donations> Money_Donations { get; set; }
        public virtual DbSet<Non_Visit> Non_Visit { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<U_Login> U_Login { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
    
        public virtual ObjectResult<getAllBloodDonations_Result> getAllBloodDonations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllBloodDonations_Result>("getAllBloodDonations");
        }
    
        public virtual ObjectResult<getAllBookDonations_Result> getAllBookDonations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllBookDonations_Result>("getAllBookDonations");
        }
    
        public virtual ObjectResult<getAllClothesDonations_Result> getAllClothesDonations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllClothesDonations_Result>("getAllClothesDonations");
        }
    
        public virtual ObjectResult<getAllDeps_Result> getAllDeps()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllDeps_Result>("getAllDeps");
        }
    
        public virtual ObjectResult<getAllEmps_Result> getAllEmps()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllEmps_Result>("getAllEmps");
        }
    
        public virtual ObjectResult<getAllEstablishments_Result> getAllEstablishments()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllEstablishments_Result>("getAllEstablishments");
        }
    
        public virtual ObjectResult<getAllEvents_Result> getAllEvents()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllEvents_Result>("getAllEvents");
        }
    
        public virtual ObjectResult<getAllFoodDonations_Result> getAllFoodDonations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllFoodDonations_Result>("getAllFoodDonations");
        }
    
        public virtual ObjectResult<getAllMoneyDonations_Result> getAllMoneyDonations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllMoneyDonations_Result>("getAllMoneyDonations");
        }
    
        public virtual ObjectResult<getAllUsers_Result> getAllUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllUsers_Result>("getAllUsers");
        }
    
        public virtual int insertBlood(Nullable<int> iD, Nullable<int> quantity, Nullable<System.DateTime> expiry_date, Nullable<System.DateTime> donation_date, string type, string destination, Nullable<int> handler_ID, Nullable<int> donor_ID)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var expiry_dateParameter = expiry_date.HasValue ?
                new ObjectParameter("Expiry_date", expiry_date) :
                new ObjectParameter("Expiry_date", typeof(System.DateTime));
    
            var donation_dateParameter = donation_date.HasValue ?
                new ObjectParameter("Donation_date", donation_date) :
                new ObjectParameter("Donation_date", typeof(System.DateTime));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var destinationParameter = destination != null ?
                new ObjectParameter("Destination", destination) :
                new ObjectParameter("Destination", typeof(string));
    
            var handler_IDParameter = handler_ID.HasValue ?
                new ObjectParameter("Handler_ID", handler_ID) :
                new ObjectParameter("Handler_ID", typeof(int));
    
            var donor_IDParameter = donor_ID.HasValue ?
                new ObjectParameter("Donor_ID", donor_ID) :
                new ObjectParameter("Donor_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertBlood", iDParameter, quantityParameter, expiry_dateParameter, donation_dateParameter, typeParameter, destinationParameter, handler_IDParameter, donor_IDParameter);
        }
    
        public virtual int insertBook(Nullable<int> iD, string name, Nullable<int> at_Office, Nullable<System.DateTime> donation_date, Nullable<int> quantity, string educational_year, string subject, Nullable<int> handler_ID, Nullable<int> donor_ID)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var at_OfficeParameter = at_Office.HasValue ?
                new ObjectParameter("At_Office", at_Office) :
                new ObjectParameter("At_Office", typeof(int));
    
            var donation_dateParameter = donation_date.HasValue ?
                new ObjectParameter("Donation_date", donation_date) :
                new ObjectParameter("Donation_date", typeof(System.DateTime));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var educational_yearParameter = educational_year != null ?
                new ObjectParameter("Educational_year", educational_year) :
                new ObjectParameter("Educational_year", typeof(string));
    
            var subjectParameter = subject != null ?
                new ObjectParameter("Subject", subject) :
                new ObjectParameter("Subject", typeof(string));
    
            var handler_IDParameter = handler_ID.HasValue ?
                new ObjectParameter("Handler_ID", handler_ID) :
                new ObjectParameter("Handler_ID", typeof(int));
    
            var donor_IDParameter = donor_ID.HasValue ?
                new ObjectParameter("Donor_ID", donor_ID) :
                new ObjectParameter("Donor_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertBook", iDParameter, nameParameter, at_OfficeParameter, donation_dateParameter, quantityParameter, educational_yearParameter, subjectParameter, handler_IDParameter, donor_IDParameter);
        }
    
        public virtual int insertClothes(Nullable<int> iD, string size, string gender, Nullable<int> quantity, Nullable<System.DateTime> donation_date, Nullable<int> at_Office, string type, Nullable<int> handler_ID, Nullable<int> donor_ID)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var sizeParameter = size != null ?
                new ObjectParameter("Size", size) :
                new ObjectParameter("Size", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var donation_dateParameter = donation_date.HasValue ?
                new ObjectParameter("Donation_date", donation_date) :
                new ObjectParameter("Donation_date", typeof(System.DateTime));
    
            var at_OfficeParameter = at_Office.HasValue ?
                new ObjectParameter("At_Office", at_Office) :
                new ObjectParameter("At_Office", typeof(int));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var handler_IDParameter = handler_ID.HasValue ?
                new ObjectParameter("Handler_ID", handler_ID) :
                new ObjectParameter("Handler_ID", typeof(int));
    
            var donor_IDParameter = donor_ID.HasValue ?
                new ObjectParameter("Donor_ID", donor_ID) :
                new ObjectParameter("Donor_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertClothes", iDParameter, sizeParameter, genderParameter, quantityParameter, donation_dateParameter, at_OfficeParameter, typeParameter, handler_IDParameter, donor_IDParameter);
        }
    
        public virtual int insertEmployee(Nullable<int> iD, string f_name, string m_name, string l_name, string phone_No, Nullable<int> age, string gender, Nullable<long> salary, Nullable<int> dep_ID, string e_Address, Nullable<int> working_Hrs)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var f_nameParameter = f_name != null ?
                new ObjectParameter("F_name", f_name) :
                new ObjectParameter("F_name", typeof(string));
    
            var m_nameParameter = m_name != null ?
                new ObjectParameter("M_name", m_name) :
                new ObjectParameter("M_name", typeof(string));
    
            var l_nameParameter = l_name != null ?
                new ObjectParameter("L_name", l_name) :
                new ObjectParameter("L_name", typeof(string));
    
            var phone_NoParameter = phone_No != null ?
                new ObjectParameter("Phone_No", phone_No) :
                new ObjectParameter("Phone_No", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("Salary", salary) :
                new ObjectParameter("Salary", typeof(long));
    
            var dep_IDParameter = dep_ID.HasValue ?
                new ObjectParameter("Dep_ID", dep_ID) :
                new ObjectParameter("Dep_ID", typeof(int));
    
            var e_AddressParameter = e_Address != null ?
                new ObjectParameter("E_Address", e_Address) :
                new ObjectParameter("E_Address", typeof(string));
    
            var working_HrsParameter = working_Hrs.HasValue ?
                new ObjectParameter("Working_Hrs", working_Hrs) :
                new ObjectParameter("Working_Hrs", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertEmployee", iDParameter, f_nameParameter, m_nameParameter, l_nameParameter, phone_NoParameter, ageParameter, genderParameter, salaryParameter, dep_IDParameter, e_AddressParameter, working_HrsParameter);
        }
    
        public virtual int insertEstablishment(string name, string phone_No, string bank_Account, string email, Nullable<int> total_Donations, Nullable<int> total_Visits, string location)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var phone_NoParameter = phone_No != null ?
                new ObjectParameter("Phone_No", phone_No) :
                new ObjectParameter("Phone_No", typeof(string));
    
            var bank_AccountParameter = bank_Account != null ?
                new ObjectParameter("Bank_Account", bank_Account) :
                new ObjectParameter("Bank_Account", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var total_DonationsParameter = total_Donations.HasValue ?
                new ObjectParameter("Total_Donations", total_Donations) :
                new ObjectParameter("Total_Donations", typeof(int));
    
            var total_VisitsParameter = total_Visits.HasValue ?
                new ObjectParameter("Total_Visits", total_Visits) :
                new ObjectParameter("Total_Visits", typeof(int));
    
            var locationParameter = location != null ?
                new ObjectParameter("Location", location) :
                new ObjectParameter("Location", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertEstablishment", nameParameter, phone_NoParameter, bank_AccountParameter, emailParameter, total_DonationsParameter, total_VisitsParameter, locationParameter);
        }
    
        public virtual int insertEvent(Nullable<int> iD, Nullable<int> is_Visit, string name, Nullable<double> cost, Nullable<int> participants_No, Nullable<int> supervisor_ID, string status, Nullable<System.DateTime> date, Nullable<int> duration)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var is_VisitParameter = is_Visit.HasValue ?
                new ObjectParameter("Is_Visit", is_Visit) :
                new ObjectParameter("Is_Visit", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var costParameter = cost.HasValue ?
                new ObjectParameter("Cost", cost) :
                new ObjectParameter("Cost", typeof(double));
    
            var participants_NoParameter = participants_No.HasValue ?
                new ObjectParameter("Participants_No", participants_No) :
                new ObjectParameter("Participants_No", typeof(int));
    
            var supervisor_IDParameter = supervisor_ID.HasValue ?
                new ObjectParameter("Supervisor_ID", supervisor_ID) :
                new ObjectParameter("Supervisor_ID", typeof(int));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var durationParameter = duration.HasValue ?
                new ObjectParameter("duration", duration) :
                new ObjectParameter("duration", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertEvent", iDParameter, is_VisitParameter, nameParameter, costParameter, participants_NoParameter, supervisor_IDParameter, statusParameter, dateParameter, durationParameter);
        }
    
        public virtual int insertFood(Nullable<int> iD, string name, Nullable<int> quantity, Nullable<System.DateTime> donation_date, Nullable<System.DateTime> expiry_date, Nullable<int> handler_ID, Nullable<int> donor_ID)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var donation_dateParameter = donation_date.HasValue ?
                new ObjectParameter("Donation_date", donation_date) :
                new ObjectParameter("Donation_date", typeof(System.DateTime));
    
            var expiry_dateParameter = expiry_date.HasValue ?
                new ObjectParameter("Expiry_date", expiry_date) :
                new ObjectParameter("Expiry_date", typeof(System.DateTime));
    
            var handler_IDParameter = handler_ID.HasValue ?
                new ObjectParameter("Handler_ID", handler_ID) :
                new ObjectParameter("Handler_ID", typeof(int));
    
            var donor_IDParameter = donor_ID.HasValue ?
                new ObjectParameter("Donor_ID", donor_ID) :
                new ObjectParameter("Donor_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertFood", iDParameter, nameParameter, quantityParameter, donation_dateParameter, expiry_dateParameter, handler_IDParameter, donor_IDParameter);
        }
    
        public virtual int insertMoney(Nullable<int> iD, Nullable<System.DateTime> donation_date, Nullable<int> amount, string destination, Nullable<int> at_office, Nullable<int> handler_ID, Nullable<int> donor_ID)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var donation_dateParameter = donation_date.HasValue ?
                new ObjectParameter("Donation_date", donation_date) :
                new ObjectParameter("Donation_date", typeof(System.DateTime));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("Amount", amount) :
                new ObjectParameter("Amount", typeof(int));
    
            var destinationParameter = destination != null ?
                new ObjectParameter("Destination", destination) :
                new ObjectParameter("Destination", typeof(string));
    
            var at_officeParameter = at_office.HasValue ?
                new ObjectParameter("At_office", at_office) :
                new ObjectParameter("At_office", typeof(int));
    
            var handler_IDParameter = handler_ID.HasValue ?
                new ObjectParameter("Handler_ID", handler_ID) :
                new ObjectParameter("Handler_ID", typeof(int));
    
            var donor_IDParameter = donor_ID.HasValue ?
                new ObjectParameter("Donor_ID", donor_ID) :
                new ObjectParameter("Donor_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertMoney", iDParameter, donation_dateParameter, amountParameter, destinationParameter, at_officeParameter, handler_IDParameter, donor_IDParameter);
        }
    
        public virtual int insertParticipant(Nullable<int> iD, string f_name, string m_name, string l_name, string phone_No, Nullable<int> age, string gender, string address, string email)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var f_nameParameter = f_name != null ?
                new ObjectParameter("F_name", f_name) :
                new ObjectParameter("F_name", typeof(string));
    
            var m_nameParameter = m_name != null ?
                new ObjectParameter("M_name", m_name) :
                new ObjectParameter("M_name", typeof(string));
    
            var l_nameParameter = l_name != null ?
                new ObjectParameter("L_name", l_name) :
                new ObjectParameter("L_name", typeof(string));
    
            var phone_NoParameter = phone_No != null ?
                new ObjectParameter("Phone_No", phone_No) :
                new ObjectParameter("Phone_No", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertParticipant", iDParameter, f_nameParameter, m_nameParameter, l_nameParameter, phone_NoParameter, ageParameter, genderParameter, addressParameter, emailParameter);
        }
    
        public virtual int insertVolunteer(Nullable<int> volunteer_ID, Nullable<int> event_ID)
        {
            var volunteer_IDParameter = volunteer_ID.HasValue ?
                new ObjectParameter("Volunteer_ID", volunteer_ID) :
                new ObjectParameter("Volunteer_ID", typeof(int));
    
            var event_IDParameter = event_ID.HasValue ?
                new ObjectParameter("Event_ID", event_ID) :
                new ObjectParameter("Event_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertVolunteer", volunteer_IDParameter, event_IDParameter);
        }
    }
}