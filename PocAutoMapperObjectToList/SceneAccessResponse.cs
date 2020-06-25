using System;
using System.Collections.Generic;
using System.Text;

namespace PocAutoMapperObjectToList
{
    public class SceneAccessResponse
    {
      
        public long Id { get; set; }

       
        public long ProgramId { get; set; }

       
        public int ChapterNumber { get; set; }

       
        public bool? IsSecret { get; set; }

      
        public bool IsReleased { get; set; }

      
        public bool ReleasedToEva { get; set; }

       
        public DateTime? SecrecyExpirationDate { get; set; }

     
        public SceneAccessType? SceneAccessType { get; set; }

     
        public int? CountDaysBeforeShooting { get; set; }

       
        public List<string> ReleasedUsers { get; set; }
    }
}
