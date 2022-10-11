﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeManage.Models
{
    //dangkhai
    public class Construct
    {
        [Key]
        public int Id_Construct { get; set; }
        public string Link_Construct { get; set; }
        public string Name_Construct { get; set; }
        public string LessonId_Lesson { get; set; }
        public virtual Lesson Lesson { get; set; }

        public Construct()
        {

        }
    }
}
