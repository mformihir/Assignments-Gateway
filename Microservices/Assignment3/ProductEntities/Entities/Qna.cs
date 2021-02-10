using System;
using System.Collections.Generic;
using System.Text;

namespace ProductEntities.Entities
{
    public class Qna
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string QuestionDesc { get; set; }
        public string AnswerDesc { get; set; }
        public int SellerId { get; set; }
        public DateTime Date { get; set; }
    }
}
