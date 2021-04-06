using System;
using System.ComponentModel.DataAnnotations;

namespace LoveFinderz.Models
{
    public class Lover
    {

        [Key]
        public string UserName {get;set;}

        public string LoverName{get;set;}

        public string Bio{get;set;}

        public string Sex{get;set;}



    }


}