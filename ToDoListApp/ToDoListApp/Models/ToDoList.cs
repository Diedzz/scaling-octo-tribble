using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListApp.Models
{
    public class ToDoList
    {
        public ToDoList()
        {
            Items = new List<ListItem>();
            SeedList();
        }

        #region Properties
        public List<ListItem> Items { get; set; }

        #endregion


        #region Methods 
        public void AddListItem(string description)
        {
            Items.Add(ListItem.Create(description));
        }

        public string MarkItemAsCompleted(Guid id)
        {
            var item = Items.FirstOrDefault(x => x.Id == id);

            if (item == null) return "Item not found";

            item.MarkAsCompleted();
            return String.Format("{0} is now marked as complete", item.Description);
        }

        public string Delete(Guid id)
        {
            var item = Items.FirstOrDefault(x => x.Id == id);

            if (item == null) return "Item not found";

            Items.Remove(item);
            return String.Format("{0} is now deleted", item.Description);
        }


        private void SeedList()
        {
            if (this.Items.Any()) return;
            this.AddListItem("Chris is gay");
            this.AddListItem("Joost is gay");
            this.AddListItem("Diederik is Cool");
        }
        #endregion





    }
}