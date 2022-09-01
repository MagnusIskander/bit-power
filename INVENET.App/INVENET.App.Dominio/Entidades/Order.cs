using System;
namespace INVENET.App.Dominio{
    public class Order{
        public int ID {set;get;}
        private State State {set;get;}
        private DateTime CreationDate {set;get;}
        private DateTime ReceptionDate {set;get;}
        private double Total {set;get;}

    }
}