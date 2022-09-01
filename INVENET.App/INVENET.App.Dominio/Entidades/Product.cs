using System;
namespace INVENET.App.Dominio{
    public class Product{
        public int ID {set;get;}
        private string Description {set;get;}
        private string Brand {set;get;}
        private string Category {set;get;}
        private string Lot {set;get;}
        private int Stock {set;get;}
        private int AmountOrdered {set;get;}
        private int ExpirationDate {set;get;}
        private double Buyprice {set;get;}
    }
}