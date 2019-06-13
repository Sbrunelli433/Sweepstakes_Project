using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project_
{
    public class MarketingFirm
    {
        ISweepstakesManager sweepstakesManager;

        //implement dependency injection to utilize a Sweepstakes Manager here.

            public MarketingFirm(ISweepstakesManager sweepstakesManager)
            {
            this.sweepstakesManager = sweepstakesManager;
            
            }


    }
}
