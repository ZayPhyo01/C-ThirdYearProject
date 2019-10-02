using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.mvp.models;
 
using WebApp.Pages.Account;

namespace WebApp.mvp.presenter
{
    public class Presenter  
    {
        UserModel model;
        Login log;
        

       public Presenter() {
            model =new UserModel();
        }

        public void initLoginView(Login  login){
            log = login;
        }

    


        public  void onTapLogin(string name, string pass) {
            string res = model.login(name,pass);
            log.loginResult(res);
            if (res == ContantsUtils.LOGIN_SUCCESS)
            {
                log.nevigateToIndexPage();

            }
             
        }

       
    }
}