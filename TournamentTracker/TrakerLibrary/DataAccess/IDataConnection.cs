using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrakerLibrary.Models;

namespace TrakerLibrary.DataAccess
{
   public  interface IDataConnection
    {

        PrizeModel CreatePrize(PrizeModel model); 


    }
}
