using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.mvp.presenter
{
    interface IPresenter
    {
        void onTapLogin(string name, string pass);
        void onTapRegister(string name, string pass);
    }
}
