﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }


        public string CommentUserName { get; set; }

        public string CommentTitle { get; set; }

        public string CommentContent { get; set; }

        public DateTime CommentDate { get; set; }

        public bool CommentStatus { get; set; }

        //public int MyProperty { get; set; }

        //yorum yapmak istediğimiz yer,bir bloga yorum yapacağız
        public int BlogID { get; set; }//1

        public Blog Blog { get; set; }//1

    }
}
