using System;
using System.Collections.Generic;

namespace AutoKolcsonzoApp.Models
{
   
    
    public partial class Kolcsonzesek
    {
        private int kolcsonzesID;
        public int KolcsonzesID
        {
            get { return kolcsonzesID; }
            set
            {
                if (value > 0 && value < 10)
                    kolcsonzesID = value;
                else throw new Exception("Hibás kolcsonzesID :" + value);
            }
        }
        private int vevokID;
        public int VevokID
        {
            get { return vevokID; }
            set
            {
                if (value > 0 && value < 10)
                    vevokID = value;
                else throw new Exception("Hibás vevokID: " + value);
            }
        }
        private int autoID;
        public int AutoID
        {
            get
            {
                return autoID;
            }
            set
            {
                if (value > 0 && value < 10)
                    autoID = value;
                else throw new Exception("Hibás autoID: " + value);
            }
        }
        public System.DateTime KolcsonzesIdeje { get; set; }
    
        public virtual Autok Autok { get; set; }
        public virtual Vevok Vevok { get; set; }
    }
}
