using Registeration.Entities;
using Registeration.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registeration.Controllers
{
    public class TeamController : Controller
    {
        Contextdb db = new Contextdb();
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public void Create(TeamMembers model)
        {
            db.teamMembers.Add(model);
            db.SaveChanges();
        }
        public ActionResult Teams()
        {
            var teams = db.teamMembers.ToList();
            return View(teams);
        }
        public ActionResult TeamDetail(int Id)
        {

            TeamMembers teamMembers = db.teamMembers.Find(Id);
            return View(teamMembers);

        }

        [HttpPost]
        public JsonResult UploadPicture()
        {
            JsonResult result = new JsonResult();
            var pictures = Request.Files[0];
            var picture = pictures;
            var filename = Guid.NewGuid() + Path.GetExtension(picture.FileName);
            var path = Server.MapPath("~/Content/images/") + filename;
            picture.SaveAs(path);
            result.Data = path;
            return result;
        }

        
        public ActionResult DownLoadFile(string fullfilepath)
        {
            string directoryPath = Path.GetDirectoryName(fullfilepath);
            string fileName = Path.GetFileName(fullfilepath);
            var memory = DownloadSinghFile(fileName, directoryPath);
            var contentType = GetContentTypeForFile(fileName);
            return File(memory.ToArray(), contentType, fileName);
            
        }

        private string GetContentTypeForFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".png":
                    return "image/png";
                case ".pdf":
                    return "application/pdf";
                default:
                    return "application/octet-stream"; 
            }
        }


        private MemoryStream DownloadSinghFile(string filename, string uploadPath)
        {
            var path = Path.Combine(uploadPath, filename);
            var memory = new MemoryStream();

            if (System.IO.File.Exists(path))
            {
                try
                {
                    var data = System.IO.File.ReadAllBytes(path);
                    var content = new System.IO.MemoryStream(data);
                    memory = content;
                }
                catch (Exception ex)
                { 
                    Debug.WriteLine("Exception while reading the file: " + ex.Message);
                }
            }
            return memory;
        }



    }
}