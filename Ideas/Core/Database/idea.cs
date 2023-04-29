using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Database
{
    public class Idea
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Idea_text { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}