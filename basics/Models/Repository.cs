namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course() {
                    Id = 1, 
                    Title = "ASP.Net Course",
                    Description = "A Nice Course", 
                    Image = "1.jpg",
                    Tags = new string[] {"aspnet","web development"},
                    isActive = true,
                    isHome = true
                    },
                new Course() {
                    Id = 2, 
                    Title = "PHP Course", 
                    Description = "A Decent Course", 
                    Image = "2.jpg",
                    Tags = new string[] {"PHP","web development"},
                    isActive = true,
                    isHome = true
                    },
                new Course() {
                    Id = 3, 
                    Title = "Django Course", 
                    Description = "An OK Course", 
                    Image = "3.jpg",
                    isActive = true,
                    isHome = true
                    },
                new Course() {
                    Id = 4, 
                    Title = "JavaScript Course", 
                    Description = "A Great Course", 
                    Image = "2.jpg",
                    isActive = true,
                    isHome = true
                    }
            };
        }

        public static List<Course> Courses
        {
            get{
                return _courses;
            }
        }


        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }









    }
}