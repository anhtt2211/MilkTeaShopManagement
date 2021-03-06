using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DTO
{
    public class Menu
    {
        private int idBill;
        private int idDrink;
        private string drinkName;
        private long price;
        private int count;

        public string DrinkName { get => drinkName; set => drinkName = value; }
        public long Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
        public int IdDrink { get => idDrink; set => idDrink = value; }
        public int IdBill { get => idBill; set => idBill = value; }

        public Menu(int idBill, int idDrink, string drinkName, long price, int count)
        {
            this.idBill = idBill;
            this.idDrink = idDrink;
            this.drinkName = drinkName;
            this.price = price;
            this.count = count; 
        }

        public Menu(DataRow row)
        {
            this.idBill = (int)row["BillID"];
            this.IdDrink = (int)row["IDDrink"];
            this.drinkName = row["Name"].ToString();
            this.price = (long)row["Price"];
            this.count = (int)row["Count"];
        }
    }
}
