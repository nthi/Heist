using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    public class Bank 
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure 
        {
            get
            {
                if (SecurityGuardScore <= 0 || AlarmScore <=0 || VaultScore <= 0) 
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        //should put a report method in here. Abstraction.
        //make a new list of key/value pairs that are string/int to hold all the scores
        //use .linq method to sort by highest
        //or use query method
    }
}