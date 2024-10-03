using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Models
{
    public class Product
    {
        private int Order_ID;
        private int Qty;
        private decimal Buy_Price;
        private string User_Name;
        private int Pro_ID;
        private string Pro_Name;
        private string Ref;
        private int Selected;

        public int Select
        {
            get
            {
                return this.Selected;
            }
            set
            {
                this.Selected = value;
            }
        }
        public string Reference
        {
            get
            {
                return this.Ref;
            }
            set
            {
                this.Ref = value;
            }
        }

        public string ProName
        {
            get
            {
                return this.Pro_Name;
            }
            set
            {
                this.Pro_Name = value;
            }
        }

        public int ProID
        {
            get
            {
                return this.Pro_ID;
            }
            set
            {
                this.Pro_ID = value;
            }
        }
        public string UserName
        {
            get
            {
                return this.User_Name;
            }
            set
            {
                this.User_Name = value;
            }
        }
        public decimal BuyPrice
        {
            get
            {
                return this.Buy_Price;
            }
            set
            {
                this.Buy_Price = value;
            }
        }
        public int OrderID
        {
            get
            {
                return this.Order_ID;
            }
            set
            {
                this.Order_ID = value;
            }
        }

        public int Qte
        {
            get
            {
                return this.Qty;
            }
            set
            {
                this.Qty = value;
            }
        }


        public Product()
        {

        }

        public Product(
            int Order_ID,
            int Qty,
            decimal Buy_Price,
            string User_Name,
            int Pro_ID,
            string Pro_Name,
            string Ref,
            int Selected
        )
        {
            this.Order_ID = Order_ID;
            this.Pro_ID = Pro_ID;
            this.Pro_Name = Pro_Name;
            this.Ref = Ref;
            this.Qty = Qty;
            this.User_Name = User_Name;
            this.Buy_Price = Buy_Price;
            this.Selected = Selected;
        }

    }
}
