using System.Collections.Generic;
using CS321_W3D2_BookAPI.Models;

namespace CS321_W3D2_BookAPI.Services
{
    public interface IPublisherService
    {
        // CRUDL - create (add), read (get), update, delete (remove), list

        // create
        Publisher Add(Publisher todo);
        // read
        Publisher Get(int id);
        // update
        Publisher Update(Publisher todo);
        // delete
        void Remove(Publisher todo);
        // list
        IEnumerable<Publisher> GetAll();
    }
}
