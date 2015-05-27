using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Mvc;
using ToDoListApp.Models;

namespace ToDoListApp.Controllers
{
    public class ToDoListController : ApiController
    {
        private static ToDoList _toDoList = new ToDoList();
        
        // GET: api/ToDoList
        public ToDoList Get()
        {
            return _toDoList;
        }

        // GET: api/ToDoList/5
        public ListItem Get(Guid id)
        {
            var item = _toDoList.Items.FirstOrDefault();

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return _toDoList.Items.FirstOrDefault(x => x.Id == id);
        }

        // POST: api/ToDoList
        public ActionResult Post(ListItemAddModel item)
        {
            _toDoList.AddListItem(item.Description);

            return new HttpStatusCodeResult(HttpStatusCode.Created);
        }

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.Route("api/todolist/{id}/markascompleted")]
        // POST: api/ToDoList
        public ActionResult MarkAsCompleted(Guid id)
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK, _toDoList.MarkItemAsCompleted(id));
        }


        // DELETE: api/ToDoList/5
        public string Delete(Guid id)
        {
            return _toDoList.Delete(id);

        }


      
    }
}
