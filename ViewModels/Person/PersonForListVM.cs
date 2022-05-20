﻿using System.ComponentModel.DataAnnotations;
namespace Serwis.ViewModels.Person
{
    public class PersonForListVM
    {
        
        public string FullName { get; set; }

        public string? Rok { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }  
    }

}
