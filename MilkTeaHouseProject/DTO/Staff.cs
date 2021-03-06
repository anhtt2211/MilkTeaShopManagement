using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DTO
{
    public class Staff
    {
        private int iD;
        private string name;
        private byte[] image;
        private DateTime birthDate;
        private string position;
        private string userName;
        private int overTime;
        private long salaryReceived;
        private int fault;
        private string phoneNumber;
        private string cmnd;
        private string address;
        private bool sex;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Position { get => position; set => position = value; }
        public string UserName { get => userName; set => userName = value; }
        public int OverTime { get => overTime; set => overTime = value; }
        public byte[] Image { get => image; set => image = value; }
        public long SalaryReceived { get => salaryReceived; set => salaryReceived = value; }
        public int Fault { get => fault; set => fault = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string CMND { get => cmnd; set => cmnd = value; }
        public string Address { get => address; set => address = value; }
        public bool Sex { get => sex; set => sex = value; }

        public Staff(int id, string name, byte[] image, DateTime birthdate, string position, string username, int overtime, long salaryreceived, int fault, string phonenumber, string cmnd, string address, bool sex)
        {
            this.iD = id;
            this.name = name;
            this.image = image;
            this.birthDate = birthdate;
            this.position = position;
            this.userName = username;
            this.overTime = overtime;
            this.salaryReceived = salaryreceived;
            this.fault = fault;
            this.phoneNumber = phonenumber;
            this.cmnd = cmnd;
            this.address = address;
            this.sex = sex;
        }

        public Staff(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = row["Name"].ToString();
            this.birthDate = (DateTime)row["BirthDate"];
            this.position = row["Position"].ToString();
            this.userName = row["UserName"].ToString();
            this.overTime = int.Parse(row["OverTime"].ToString());
            if (!Convert.IsDBNull(row["Image"]))
                this.Image = (byte[])row["Image"];
            this.fault = (int)row["Fault"];
            this.phoneNumber = row["PhoneNumber"].ToString();
            this.cmnd = row["CMND"].ToString();
            this.address = row["Address"].ToString();
            this.sex = (bool)row["Sex"];
            this.salaryReceived = long.Parse(row["SalaryReceived"].ToString());
        }
    }
}
