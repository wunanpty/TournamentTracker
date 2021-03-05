using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerUI
{
    /// <summary>
    /// Anyone who implement this interface can call CreatePrizeForm, loose coupled
    /// </summary>
    public interface IPrizeRequester
    {
        void PrizeComplete(PrizeModel model);
    }
}
