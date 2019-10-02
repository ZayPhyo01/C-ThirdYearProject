using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.mvp.models
{
    interface IDeliveryModel
    {
        string addDeliveyInfo(string address, string phone);
    }
}
