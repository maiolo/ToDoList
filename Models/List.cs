using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class List
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime When { get; set; }
        public string? Details { get; set; }
        public Boolean Finished { get; set; }
    }
}