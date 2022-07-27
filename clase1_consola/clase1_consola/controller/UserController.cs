using System;
using System.Collections;
using System.Collections.Generic;
using clase1_consola.model;

namespace clase1_consola.controller
{
    public class UserController
    {

        // registrar un usuario

        // validar un usuario

        // listar T0d0s los usuarios

        // borrar un usuario por id

        private IList<User> listUser; // <----

        public UserController()
        {
            this.listUser = new List<User>();
        }

        public string saveUser(User user)
        {
            // nos faltaria guardar el usuari
            this.listUser.Add(user);
            
            return "save user";
        }

        public bool checkUser(User user)
        {
            bool rta = false;
            foreach (var item in this.listUser)
            {
                if(item.username.Equals(user.username) && item.password.Equals(user.password))
                {
                    rta = true;
                    break;
                }
            }
            return rta;
        }

        public IList<User> showAllUser()
        {

            return this.listUser;
        }
    }
}

