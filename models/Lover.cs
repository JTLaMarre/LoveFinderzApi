using System;

namespace LoveFinderz.models
{
    public class LoveFinderz
    {

        [Key]
        public string UserName {get;set;}

        public string LoverName{get;set;}

        public string Bio{get;set;}

        public string Sex{get;set;}



    }


}