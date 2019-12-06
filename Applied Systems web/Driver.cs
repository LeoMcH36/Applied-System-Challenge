using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Applied_Systems_web
{
    public class Driver
    {
        private string name, occupation;
        private DateTime DOB;
        private double premium;
        private DateTime PolicyStart;

        public Driver()
        {
            this.name = "name";
            this.occupation = "occupation";
            this.DOB = DateTime.Parse("01-02-1999");
            this.PolicyStart = DateTime.Parse("10/12/2019");
            this.premium = 500;

        }

        public double PremiumCalc(string occupation, DateTime DOB, DateTime PolicyStart)
        {
            double adjustedPremium;
            adjustedPremium = premium;
            TimeSpan difference = DateTime.Today.Date - DOB.Date;
            double ageDays = (int)difference.Days;
            double age = ageDays / 365;
            if (occupation.Equals("Chauffeur", StringComparison.CurrentCultureIgnoreCase))
            {

                if (age < 26 && PolicyStart > DateTime.Today)
                {
                    adjustedPremium = adjustedPremium * 1.3;
                }
                else if (age < 76 && PolicyStart > DateTime.Today)
                {
                    adjustedPremium = adjustedPremium * 1.0;
                }
                if (PolicyStart < DateTime.Today)
                {
                    throw new Exception("Start Date of Policy cannot be in the past");

                }


            }
            if (occupation.Equals("Accountant", StringComparison.CurrentCultureIgnoreCase))
            {


                if (age < 26 && PolicyStart > DateTime.Today)
                {
                    adjustedPremium = adjustedPremium * 1.1;
                }
                else if (age < 76 && PolicyStart > DateTime.Today)
                {
                    adjustedPremium = adjustedPremium * 0.8;
                }
                if (PolicyStart < DateTime.Today)
                {
                    throw new Exception("Start Date of Policy cannot be in the past");

                }


            }
            else
            {
                if (age < 17)
                
                    {
                        throw new Exception("Driver is too young");
                    }

                else if(age >75)
                    {
                        throw new Exception("Driver is too old");
                    }
                
            }


            return adjustedPremium;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetOccupation(string occupation)
        {
            this.occupation = occupation;
        }
        public void SetDOB(DateTime DOB)
        {
            this.DOB = DOB;
        }
        public void SetPolicyStart(DateTime policyStart)
        {
            this.PolicyStart = policyStart;
        }

    }
}