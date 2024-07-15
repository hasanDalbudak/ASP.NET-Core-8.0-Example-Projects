using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

// course
public class CourseController: Controller {


    /*It is not mandatory to have an index method but when there isn't there is no default index path to go
    // course
    // course/index
    public IActionResult Index()
    {
        // Using a course object using models
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "Aspnet core kursuZAAAAAA";
        kurs.Description = "Güzel bir kurs";
        kurs.Image = "1.jpg";

        // If the name of the View you call is the same with the method you can call View as below with no parameters
        return View(kurs); 
    }
    */

     public IActionResult Details(int? id)
    {

        if(id==null){
            //ctrl + shift + space
            //ctrl + space
            //return Redirect("/course/list");
            return RedirectToAction("List","Course");
        }

        var course = Repository.GetById(id);

        // If the name of the View you call is the same with the method you can call View as below with no parameters
        return View(course); 
    }

    // course/list
    public IActionResult List()
    {

        return View("CourseList", Repository.Courses);









        /*
        Instead of below code we can use a repository

        // Instead of creating "kurs" instances lets make a kurs list.
        var myCourses = new List<Course>()
        {
            new Course() {Id = 1, Title = "ASP.Net Course", Description = "A Nice Course", Image = "1.jpg"},
            new Course() {Id = 2, Title = "PHP Course", Description = "A Decent Course", Image = "2.jpg"},
            new Course() {Id = 3, Title = "Django Course", Description = "An OK Course", Image = "3.jpg"}
        };

        // This is how you use View() if the name of the View file does not match with the name of the method
        return View("CourseList", myCourses);
        */
    }


}
