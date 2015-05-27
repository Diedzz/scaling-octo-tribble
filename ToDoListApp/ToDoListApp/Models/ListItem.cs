using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ToDoListApp.Models
{
    public class ListItem
    {
        public Guid Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime? CompletedAt { get; set; }

        public string Description { get; set; }
        public bool Completed { get; set; }

        public ListItem()
        {
            Id = Guid.NewGuid();
            Created = DateTime.Now;
            Completed = false;
        }

        public static ListItem Create(string description)
        {
            return new ListItem { Description = description };
        }

        public void MarkAsCompleted()
        {
            this.CompletedAt = DateTime.Now;
            this.Completed = true;
        }

    }

    public class ListItemAddModel
    {
        public string Description { get; set; }

    }
}