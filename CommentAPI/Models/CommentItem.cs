using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommentAPI.Models
{
    public class CommentItem
    {
        public long CommentId { get; set; }
        public string PostSlug { get; set; }
        public string CommentTitle { get; set; }
        public DateTime CommentTime { get; set; }
        public string CommentBody { get; set; }
    }
}
