using PaparaSecondWeek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaparaSecondWeek.Services
{
    public class OwnerServices : IOwnerServices
    {

      

        public bool Add()
        {
            return true;
        }

        public bool Delete()
        {
            return true;
        }

        public string Get()
        {
          

            return "Ownerlar getirildi";
        }
        public string GetColorEnum()
        {
            var sringBuilder = new StringBuilder();
            foreach (var color in Enum.GetNames(typeof(ColorEnum)))
            {
                sringBuilder.Append(color + "|");
            } 
            return sringBuilder.ToString();
        }
    }
}
