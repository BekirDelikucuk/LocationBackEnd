using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;
using System.Xml;
using WebApplication2.Context;
using WebApplication2.Models;
using WebApplication2.Repository.IRepo;
using WebApplication2.Repository.Repo;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoorController : ControllerBase
    {
        private readonly DoorContext context;
        private readonly Repository<Door> _doorRepository;
        public DoorController(DoorContext context)
        {
            this.context = context;
            _doorRepository = new Repository<Door>(context);


        }

        [HttpGet]
        public List<Door> GetAllLocation()
        {
            return _doorRepository.Select(null).Select(d => new Door
            {
                Id = d.Id,
                CoordinateY = d.CoordinateY,
                CoordinateX = d.CoordinateX,
                LocationName = d.LocationName
            }).ToList();

            //List<Door> getLocation = null;
            //using (DoorContext db = context)
            //{
            //    getLocation = (from d in db.Door
            //                   select new Door()
            //                   {
            //                       Id = d.Id,
            //                       CoordinateY = d.CoordinateY,
            //                       CoordinateX = d.CoordinateX,
            //                       LocationName = d.LocationName
            //                   }
            //                 ).ToList();
            //};



        }
        //[HttpDelete]
        //public int DeleteDoor(Door door)
        //{
        //    int a = 0;
        //    int id=door.Id;

        //    using (DoorContext db = context)
        //    {
        //        var deletedData = db.Door.Where
        //            (x => x.Id == id).SingleOrDefault();
        //        db.Door.Remove(deletedData);
        //        a = db.SaveChanges();

        //    }
        //    return a;
        //}


        [HttpPost]
        public int AddDoor(Door addDoorInfo)
        {

            return _doorRepository.Insert(addDoorInfo);
            //int affectedRows = 0;

            //if (string.IsNullOrWhiteSpace(addDoorInfo.LocationName))
            //{
            //    return 0;

            //}

            //using (DoorContext db = context)
            //{
            //    db.Door.Add(new Door()
            //    {
            //        LocationName = addDoorInfo.LocationName,
            //        CoordinateY = addDoorInfo.CoordinateY,
            //        CoordinateX = addDoorInfo.CoordinateX,
            //    });

            //    affectedRows = db.SaveChanges();
            //}
            //return affectedRows;
        }


        [HttpPut]
        public int UpdateDoor(Door updateDoorInfo)
        {
           
            return _doorRepository.Update(updateDoorInfo);
            //int changed = 0;

            //using (DoorContext db = context)
            //{

            //    var newData = db.Door.Where(x => x.Id == updateDoorInfo.Id).SingleOrDefault();

            //    newData.LocationName = updateDoorInfo.LocationName;
            //    newData.CoordinateY = updateDoorInfo.CoordinateY;
            //    newData.CoordinateX = updateDoorInfo.CoordinateX;
            //    if (newData != null)
            //    {
            //        changed = db.SaveChanges();
            //    }


            //}
            //return changed;

        }

        //[HttpPost]
        //public int AddDoor2(Door addDoorInfo)
        //{
        //    int affectedRows = 0;
        //    using (DoorContext db = context)
        //    {

        //        db.Door.Add(new Door()
        //        {

        //            LocationName = addDoorInfo.LocationName,
        //            CoordinateY = addDoorInfo.CoordinateY,
        //            CoordinateX = addDoorInfo.CoordinateX,
        //        });

        //        affectedRows = db.SaveChanges();
        //    }
        //    return affectedRows;
        //}

        //[HttpPut]
        //public int UpdateDoor(Door updateDoorInfo)
        //{
        //    int changed = 0;
        //    using (DoorContext db = context)
        //    {
        //        var newData = db.Door.Where(x => x.Id == updateDoorInfo.Id).SingleOrDefault();
        //        newData.LocationName = updateDoorInfo.LocationName;
        //        newData.CoordinateY = updateDoorInfo.CoordinateY;
        //        newData.CoordinateX = updateDoorInfo.CoordinateX;
        //        changed = db.SaveChanges();

        //    }
        //    return changed;

        //}

        [HttpDelete]

        public int DeleteDoor(int DoorID)
        {

            return _doorRepository.Delete(DoorID);
            //int a = 0;
            //using (DoorContext db = context)
            //{
            //    var deletedData = db.Door.Where(x => x.Id ==
            //    DoorID).SingleOrDefault();
            //    db.Door.Remove(deletedData);
            //    a = db.SaveChanges();
            //}
            //return a;
        }




    }
}
