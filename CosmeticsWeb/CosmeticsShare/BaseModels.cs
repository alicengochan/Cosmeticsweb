using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CosmeticsShare
{
    public class BaseModels
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifierDate { get; set; }
        public string CreateUser { get; set; }
        public string LastModifierUser { get; set; }

        //upload image
        public HttpPostedFileBase PictureUpload { get; set; }

        public byte[] PictureByte { get; set; }
    }
}
