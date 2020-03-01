# C# Live Project
C# .NET Framework project completed with the Tech Academy

## Table of Contents
* [General Info](#general-info)
* [Story Index](#story-index)

## General Info
### About This Project
Software designed for a theater company to manage its website content without needing any technical knowledge. It will have multiple areas to manage admin needs, subscriber needs, and general public needs. The site will include information on the current season, past productions, the current cast members. It will allow the acting company to easily upload content. It will allow subscribers to easily manage their subscriptions.

## Story Index
* [Create Admin Controller and Views](#create-admin-controller-and-views)
* [Auto Create Calendar Items from RentalRequest](#auto-create-calendar-items-from-rentalrequest)
* [New ProductionPhotos Class](#new-productionphotos-class)
* [Fix DisplayInfo Null Bug](#fix-displayinfo-null-bug)
* [Restyle ProductionPhotos Views](#restyle-productionphotos-views)
* [Front End: Update Create & Edit Pages](#front-end-update-create--edit-pages)
* [Create New ImageUpload Helper Method](#create-new-imageupload-helper-method)

### Create Admin Controller and Views
The site required an area for admins to manage content and various other items via special views (not based on a specific model) that could access the database. 

Created a new Admin Controller with a Dashboard view that provided navigation to other index pages.

AdminController.cs	
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheatreCMS.Models;
namespace TheatreCMS.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}
```

Dashboard.cshtml
```
@{
    Layout = "~/Views/Shared/_Layout.cshtml";
}
@{
    ViewBag.Title = "Dashboard";
}
<!DOCTYPE html>
<h2>Dashboard</h2>
<ul>
    <li>
        @Html.ActionLink("Info", "Index", "DisplayInfo")
    </li>
    <li>
        @Html.ActionLink("Display Links", "Index", "DisplayLinks")
    </li>
    <li>
        @Html.ActionLink("Sponsors", "Index", "Sponsors")
    </li>
    <li>
        @Html.ActionLink("Content Section", "Index", "ContentSection")
    </li>
    <li>
        @Html.ActionLink("Productions", "Index", "Productions")
    </li>
    <li>
        @Html.ActionLink("Cast Members", "Index", "CastMembers")
    </li>
    <li>
        @Html.ActionLink("Part", "Index", "Part")
    </li>
    <li>
        @Html.ActionLink("Subscriber", "Index", "Subscribers/Subscriber")
    </li>
    <li>
        @Html.ActionLink("Rental Request", "Index", "RentalRequest")
    </li>
</ul>
```
[Back to Top](#table-of-contents)

### Auto Create Calendar Items from RentalRequest
When creating a RentalRequest item the CalandarEvent class needs to automatically pull from the RentalRequest and Productions tables and populate a new CalendarEvent item. 

Utilized the Edit and Create methods in the RentalRequest Controller to create the new CalendarEvent items. Created a bool to only create a new CalendarEvent item if the RentalRequest item had been accepted. When a RentalRequest is edited or created with accepted as true, it will be edited or added to the CalendarEvents table. If the RentalRequest is edited to accepted as false, the existing CalendarEvent is deleted. If the RentalRequest is deleted, it is removed from the CalendarEvents.

RentalRequestController.cs
```
public void RentalAddCalendar(RentalRequest rentalRequest)
        {
            CalendarEvent calendar = new CalendarEvent();
            calendar.RentalRequestId = rentalRequest.RentalRequestId;
            calendar.Title = rentalRequest.Company;
            calendar.StartDate = rentalRequest.StartTime;
            calendar.EndDate = rentalRequest.EndTime;
            db.CalendarEvent.Add(calendar);
            db.SaveChanges();
            
        }
        public void RentalEditCalendar(RentalRequest rentalRequest)
        {
            // CalendarEvent calendar = new CalendarEvent();
            //int calendarId = Convert.ToInt32(calendarEvent);
            //int rental = rentalRequest.RentalRequestId;
            //CalendarEvent calendar = db.CalendarEvents.Where(rentalRequest.RentalRequestId);
            CalendarEvent calendar = db.CalendarEvent.Where(x => x.RentalRequestId == rentalRequest.RentalRequestId).FirstOrDefault();
            if (calendar == null)
            {
                RentalAddCalendar(rentalRequest);
            }
            else if (rentalRequest.RentalRequestId == calendar.RentalRequestId)
            {
                //calendar.RentalRequestId = rentalRequest.RentalRequestId;
                calendar.Title = rentalRequest.Company;
                calendar.StartDate = rentalRequest.StartTime;
                calendar.EndDate = rentalRequest.EndTime;
                db.Entry(calendar).State = EntityState.Modified;
                db.SaveChanges();
            }
            
        }
        public void RentalDeleteCalendar(RentalRequest rentalRequest)
        {
            CalendarEvent calendar = db.CalendarEvent.Where(x => x.RentalRequestId == rentalRequest.RentalRequestId).FirstOrDefault();
            if (calendar != null)
            {
                db.CalendarEvent.Remove(calendar);
                db.SaveChanges();
            }
            
        }
```

```
    if (rentalRequest.Accepted == true)
        {
            RentalAddCalendar(rentalRequest);
        }
```

```
    if (rentalRequest.Accepted == true)
                {
                    RentalEditCalendar(rentalRequest);
                }
                else if (rentalRequest.Accepted == false)
                {
                    RentalDeleteCalendar(rentalRequest);
                }
```

```
    if (rentalRequest.Accepted == true)
        {
            RentalDeleteCalendar(rentalRequest);
        }
```

[Back to Top](#table-of-contents)

### New ProductionPhotos Class
Each production will have a primary image as part of the Production class, but there needs to be an additional database to store all related images of that Production. 

Created a new class for the ProductionPhotos, added the DbSet to the Identity Models, created a controller and scaffoled the basic views. Used the Production table to assign a productionId to the ProductionPhotos table. Create view utilizes the ImageUploader helper to convert and add the photo as a byte array. The Index displays the list of entries in the ProductionPhotos table and a thumbnail of the image by utilizing the helper. Productions were formatted as a dropdown selection in the Create and Edit Views.

ProductionPhotosController.cs
```
// POST: ProductionPhotos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProPhotoId,Title,Description")] ProductionPhotos productionPhotos, HttpPostedFileBase file)
        {
            int productionID = Convert.ToInt32(Request.Form["Productions"]);
            byte[] photo = Helpers.ImageUploader.ImageBytes(file, out string _64);
            productionPhotos.Photo = photo;
            
            if (ModelState.IsValid)
            {
                var production = db.Productions.Find(productionID);
                productionPhotos.Production = production;
                db.ProductionPhotos.Add(productionPhotos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productionPhotos);
        }
```
```
 // POST: ProductionPhotos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProPhotoId,Photo,Title,Description,Production")] ProductionPhotos productionPhotos, HttpPostedFileBase file)
        {
            int productionID = Convert.ToInt32(Request.Form["Productions"]);
            if (ModelState.IsValid)
            {
                var currentProPhoto = db.ProductionPhotos.Find(productionPhotos.ProPhotoId);
                currentProPhoto.Title = productionPhotos.Title;
                currentProPhoto.Description = productionPhotos.Description;
                //ViewData["Productions"] = new SelectList(db.Productions.ToList(), "ProductionId");
                var production = db.Productions.Find(productionID);
                currentProPhoto.Production = production;
                if (file != null && file.ContentLength > 0)
                {
                    var photo = ImageUploader.ImageBytes(file, out string _64);
                    currentProPhoto.Photo = photo;
                }
                else
                {
                    currentProPhoto.Photo = productionPhotos.Photo;
                }
                db.Entry(currentProPhoto.Production).State = EntityState.Modified;
                db.SaveChanges();
                db.Entry(currentProPhoto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productionPhotos);
        }
```

IdentityModels.cs
```
public DbSet<ProductionPhotos> ProductionPhotos { get; set; }
```

Production.cs
```
public virtual ICollection<ProductionPhotos> ProductionPhotos { get; set; }
```

ProductionPhotos.cs
```	
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace TheatreCMS.Models
{
    public class ProductionPhotos
    {
        [Key]
        public int ProPhotoId { get; set; }
        public virtual Production Production { get; set; }
        public byte[] Photo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
```

Create.cshtml
```
    <div class="form-group">
        @Html.LabelFor(model => model.Production, htmlAttributes: new { @class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.DropDownList("Productions", string.Empty)
            @Html.ValidationMessageFor(model => model.Production)
        </div>
    </div>
```

Delete.cshtml, Details.cshtml, Index.cshtml
```
     <dd>
        @*@Html.DisplayFor(model => model.Photo)*@
        <td>
            @{
                string img = "";
                if (Model.Photo != null)
                {
                    byte[] thumbBytes = ImageUploader.ImageThumbnail(Model.Photo, 100, 100);
                    var base64 = System.Convert.ToBase64String(thumbBytes);
                    img = String.Format("data:image/png;base64,{0}", base64);
                }
            }
            <img src="@img" />
        </td>
    </dd>
```

Edit.cshtml
```
@using (Html.BeginForm("Edit", "ProductionPhotos", null, FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    @Html.AntiForgeryToken()
<div class="form-horizontal">
    <h4>ProductionPhotos</h4>
    <hr />
    @Html.ValidationSummary(true, "", new { @class = "text-danger" })
    @Html.HiddenFor(model => model.ProPhotoId)
    @Html.HiddenFor(model => model.Photo)
    <div class="form-group">
        @Html.LabelFor(model => model.Production, htmlAttributes: new { @class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.DropDownList("Productions")
            @Html.ValidationMessageFor(model => model.Production)
        </div>
    </div>
    <div class="form-group">
        @Html.LabelFor(model => model.Photo, htmlAttributes: new { @class = "control-label col-md-2" })
        <div class="col-md-10">
            @{
                string img = "";
                if (Model.Photo != null)
                {
                    byte[] thumbBytes = ImageUploader.ImageThumbnail(Model.Photo, 100, 100);
                    var base64 = System.Convert.ToBase64String(thumbBytes);
                    img = String.Format("data:image/png;base64,{0}", base64);
                }
            }
            <img src="@img" />
            <input type="file" name="file" />
            <hr />
            <!--displays photo as byte[]-->
            @*@Html.EditorFor(model => model.Photo, new { htmlAttributes = new { @class = "form-control" } })*@
            @Html.ValidationMessageFor(model => model.Photo, "", new { @class = "text-danger" })
        </div>
    </div>
```

[Back to Top](#table-of-contents)

### Fix DisplayInfo Null Bug
If you don't change the image when trying to edit the object, the DisplayInfo Edit view will throw a null reference error.

File property was not being passed to the controller from the view. Combined the file and image input in the view to successfully pass the file information on to the controller. Created an if/else statement to check if the file was null(unchanged) or if the file has been uploaded.

DisplayInfoController.cs
```
- public ActionResult Edit([Bind(Include = "InfoId,Title,Description")] DisplayInfo displayInfo, HttpPostedFileBase file)
+ public ActionResult Edit([Bind(Include = "InfoId,Title,Description,Image, File")] DisplayInfo displayInfo, HttpPostedFileBase file)
    {
        if (ModelState.IsValid)
        {
-            displayInfo.File = file.FileName;
-            var img = ImageUploader.ImageBytes(file, out _);
-            displayInfo.Image = img;
-            db.Entry(displayInfo).State = EntityState.Modified;
+            var currentInfo = db.DisplayInfo.Find(displayInfo.InfoId);
+            currentInfo.Title = displayInfo.Title;
+            currentInfo.Description = displayInfo.Description;
+            if (file != null && file.ContentLength > 0)
+            {
+                var img = ImageUploader.ImageBytes(file, out string convertedLogo);
+                currentInfo.Image = img;
+                currentInfo.File = file.FileName;
+            }
+            else
+            {
+                currentInfo.Image = displayInfo.Image;
+                currentInfo.File = displayInfo.File;
+            }
+            db.Entry(currentInfo).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
```

Edit.cshtml
```
- @using (Html.BeginForm("Edit", "DisplayInfo", FormMethod.Post, new { enctype = "multipart/form-data" }))
+ @using (Html.BeginForm("Edit", "DisplayInfo", null, FormMethod.Post, new { enctype = "multipart/form-data" }))
```
```
    <div class="form-group">
+        @Html.LabelFor(model => model.Image, htmlAttributes: new { @class = "control-label col-md-2" })
         <div class="control-label col-md-2">
-        @Html.LabelFor(model => model.File)
+            @*@Html.LabelFor(model => model.File)*@
             @{
-            var img = Model.Image;
+                string imgSrc = "";
+                if (Model.Image != null)
+                {
                     //displays the image using inline <img tag
-            byte[] thumbBytes = ImageUploader.ImageThumbnail(img, 200, 200);
+                    byte[] thumbBytes = ImageUploader.ImageThumbnail(Model.Image, 200, 200);
                     var thumbBase64 = Convert.ToBase64String(thumbBytes);
-            var imgSrc = String.Format("data:image/png;base64,{0}", thumbBase64);
+                    imgSrc = String.Format("data:image/png;base64,{0}", thumbBase64);
+                }
             }
             <img src="@imgSrc" />
-        @Html.TextBoxFor(m => m.File, new { type = "file" })
+            <input type="file" name="file" />
+            <hr />
+            @Html.ValidationMessageFor(model => model.Image, "", new { @class = "text-danger" })
+            @*@Html.TextBoxFor(m => m.File, "file", new { type = "file" })*@
         </div>
     </div>
```

[Back to Top](#table-of-contents)

### Restyle ProductionPhotos Views
Pages associated with ProductionPhotos needs to be restyled and modified to display information as desired.

Styled all five of the pages for the ProductionPhotos: Index, Create, Edit, Details, Delete. Added Production Title and Season to Details and Delete views in the ProductionPhotos class. Added existing styling classes to the ProductionPhotos views.

ProductionPhotosController.cs
```
// GET: ProductionPhotos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
+           ProductionPhotos productionPhotos = db.ProductionPhotos.Find(id);
            if (productionPhotos == null)
            {
                return HttpNotFound();
            }
            return View(productionPhotos);
        }
```

Delete.cshtml
```
<div class="container">
```
```
    <div class="row">
        <dl class="dl-horizontal justify-content-start col-md-9">
            <dt>
                @Html.DisplayNameFor(model => model.Production)
            </dt>
            <dd>
                @Html.DisplayFor(model => model.Production.Title)
            </dd>
            <dt>
                @Html.DisplayNameFor(model => model.Production.Season)
            </dt>
            <dd>
                @Html.DisplayFor(model => model.Production.Season)
            </dd>
```
```
-       <div class="form-actions no-color">
-            <input type="submit" value="Delete" class="btn btn-default" /> |
+            <div class="form-actions no-color" style="padding-left: 100px">
+                <input type="submit" value="Delete" class="btn btn-danger btn-default" /> |
```

Details.cshtml
```
<div class="container">
```
```
    <div class="row">
        <dl class="dl-horizontal justify-content-start col-md-9">
            <dt>
                @Html.DisplayNameFor(model => model.Production)
            </dt>
            <dd>
                @Html.DisplayFor(model => model.Production.Title)
            </dd>
            <dt>
                @Html.DisplayNameFor(model => model.Production.Season)
            </dt>
            <dd>
                @Html.DisplayFor(model => model.Production.Season)
            </dd>
```

Index.cshtml
```
<table class="table-styling">
    <tr class="tr-styling">
        <th class="th-styling">
```
[Back to Top](#table-of-contents)

### Front End: Update Create & Edit Pages
Need to restyle the Create & Edit pages to take up more of the sceen and be easier to view. Styling needs to fit with the rest of the site.

Added classes to the Site.css for the forms in the Edit and Create views. Styling including centering all fields and making alignment consistent throughout all elements. Chose sans serif font and appropriate weight for each field of text. Ensured each dropdown was formatted visually consistent with the text boxes and made edits to display options from their corresponding database. Reformatted the create and save button to submit the data working within the site colors.

Site.css
```
.formContainer2 {
    display: block;
    margin-left: auto;
    margin-right: auto;
    margin-top: 20px;
    text-align: center;
    max-width: 65%;
    background-color: var(--main-secondary-color);
    /*background-image: linear-gradient(var(--light-color), var(--main-secondary-color));*/
    box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
    border-radius: 2px;
    font-family: Tahoma, Geneva, sans-serif;
    animation-duration: 1s;
    -webkit-animation-duration: 1s;
    animation-name: fadeIn;
    -webkit-animation-name: fadeIn;
}
.formBox {
    display: block;
    margin-left: auto;
    margin-right: auto;
    text-align: center;
    color: #666;
    font-family: Lato;
    font-size: 13px;
    font-weight: normal;
}
.fileSelect {
    display: block;
    /*box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
    border-radius: 2px;*/
    margin-left: auto;
    margin-right: auto;
    padding: 5px;
    padding-top: 10px;
    padding-left:12%;
    padding-right:5px;
    text-align: center;
    color: #FFFBFB;
    font-family: Tahoma, Geneva, sans-serif;
    font-size: 15px;
    font-weight: normal;
}
.formHeader {
    color: var(--dark-color);
    font-family: Lato;
    margin-left: auto;
    margin-right: auto;
    text-align: center;
    text-shadow: .5px 1px #FFFBFB;
    font-family: Tahoma, Geneva, sans-serif;
    letter-spacing: 3px;
    font-size: 40px;
    font-weight: 400;
.inputBox2 {
    color: var(--dark-color);
    margin-left: auto;
    margin-right: auto;
    padding-bottom: 15px;
    max-width: 85%;
    letter-spacing: 1px;
    font-size: 15px;
    font-weight: bolder;
    animation-duration: 1s;
    -webkit-animation-duration: 1s;
    animation-name: fadeIn2;
    -webkit-animation-name: fadeIn2;
}
.inputLabel {
    color: var(--dark-color);
    /*text-shadow: 1px 1px #000000;*/
    font-family: Tahoma, Geneva, sans-serif; 
    border: none;
}
.submitButton2 {
    display: inline-block;
    width: 30%;
    letter-spacing: 1px;
    font-family: Lato;
    font-weight: bolder;
    padding: 10px 0px;
    margin: 10px auto 10px auto;
    border: 0px solid;
    border-color: var(--dark-color);
    color: var(--light-color);
    background-color: var(--dark-color);
    text-align: center;
    vertical-align: middle;
    font-size: 1rem;
    line-height: 1.5;
    border-radius: 15px;
    user-select: none;
    transition: all .5s;
    box-shadow: 0px 4px #D6972A;
    animation-duration: 3s;
    -webkit-animation-duration: 3s;
    animation-name: fadeIn3;
    -webkit-animation-name: fadeIn3;
}			
.submitButton2:hover {
    color: var(--dark-color);
    background-color: var(--main-bg-color);
}
```
[Back to Top](#table-of-contents)

### Create New ImageUpload Helper Method
Need to create a method that the entire project can access within the UploadController to accept a byte array and return a file that is a jpeg image. 

Created a new method with the Image Upload Controller to accept a byte array and return a file that is a jpeg image. Tested the function within the Sponsor class. In order to create a universal method for any of the classes to use, it was necessary to create a method that received parameters for the photo id and the database name. In the method, a switch statement was created with cases for each class that specified the field name for those specific photo files. This solution revealed that restructuring the photo files to exist within a singular database rather than within each model may be a more efficient approach. In order to resize the rendered image, began to include Memory Stream and utilize System.Drawing. Successfully passed parameters to save the image file with new dimensions in the database, but did not successfully return a resized file to render in the view. Upon discussing with the instructors, this story has been useful in revealing what is not working and due to the end of the sprint, it will be restructured into a new story for a more effective solution.

ImageUploadController.cs
```
public FileContentResult ImageView(int id, string table, int thumbWidth, int thumbHeight)
{
    byte[] imgArray = null;

    switch (table)
    {
        case "Sponsor":
            var sponsor = db.Sponsors.Find(id);
            imgArray = sponsor.Logo;
            break;
        case "CastMembers":
            var castMembers = db.CastMembers.Find(id);
            imgArray = castMembers.Photo;
            break;
        case "DisplayInfo":
            var displayInfo = db.DisplayInfo.Find(id);
            imgArray = displayInfo.Image;
            break;
        case "Productions":
            var production = db.Productions.Find(id);
            imgArray = production.DefaultPhoto.Photo;
            break;
        case "ProductionPhotos":
            var productionPhotos = db.ProductionPhotos.Find(id);
            imgArray = productionPhotos.Photo;
            break;

        default:
            break;
    }
    using (MemoryStream ms = new MemoryStream())
    using (Image thumbnail = Image.FromStream(new MemoryStream(imgArray)).GetThumbnailImage(thumbWidth, thumbHeight, null, new IntPtr()))
    {
        thumbnail.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        ms.ToArray();
        //saves to db, but cannot plug into FileContentResult. Need diff way to combine methods.
    }
    //image not returning at input size, will need to fix later
    return new FileContentResult(imgArray, "image/jpg");
}
```

Index.cshtml
```		
<img src="@Url.Action("ImageView", "ImageUpload", new { id = item.SponsorId, table="Sponsor", thumbHeight = 100, thumbWidth = 100})" />
```
