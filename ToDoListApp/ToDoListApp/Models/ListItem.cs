using System;


namespace ToDoListApp.Models
{
    public class ListItem
    {
        //constructor
        public ListItem()
        {
            Id = Guid.NewGuid();
            Created = DateTime.Now;
            Completed = false;
        }

        #region Properties

        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        #endregion


        #region Methods
        public static ListItem Create(string description)
        {
            return new ListItem { Description = description };
        }

        public void MarkAsCompleted()
        {
            this.CompletedAt = DateTime.Now;
            this.Completed = true;
        }
        #endregion

      


    }
}