using Microsoft.AspNetCore.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
	public class HomeController : Controller
	{
		AppDbContext db;
        public HomeController(AppDbContext appDbContext)
        {
            db = appDbContext;
        }
        public IActionResult Index()
		{
            //Member member1 = new Member()
            //{
            //	FullName = "Dwayne Johnson",
            //	Designation = "Bodyguard",
            //	ImgUrl = "team-1.jpg"
            //         };
            //         Member member2 = new Member()
            //         {
            //             FullName = "Paul Walker",
            //             Designation = "Driver",
            //             ImgUrl = "team-2.jpg"
            //         };
            //         Member member3 = new Member()
            //         {
            //             FullName = "Elza Seyidcahan",
            //             Designation = "Motivator",
            //             ImgUrl = "team-3.jpg"
            //         };

            //         db.Members.AddRange(member1, member2, member3);

            //         ServiceSlide serviceSlide1 = new ServiceSlide()
            //         {
            //             Title = "Best Security Services",
            //             Content = "Safe & Secure Home For Your Family",
            //             ImgUrl = "carousel-1.jpg"
            //         };
            //         ServiceSlide serviceSlide2 = new ServiceSlide()
            //         {
            //             Title = "Security Services",
            //             Content = "Safe Home For Your Family",
            //             ImgUrl = "carousel-2.jpg"
            //         };
            //         ServiceSlide serviceSlide3 = new ServiceSlide()
            //         {
            //             Title = "Best Services",
            //             Content = "Secure Home For Your Family",
            //             ImgUrl = "carousel-3.jpg"
            //         };

            //         db.ServiceSlides.AddRange(serviceSlide1, serviceSlide2, serviceSlide3);


            //         TestimonialSlide testimonialSlide1 = new TestimonialSlide()
            //         {
            //             Comment = "I like it!",
            //             Name = "Farid",
            //             Profession = "Bartender",
            //             ImgUrl = "testimonial-1.jpg"
            //         };
            //         TestimonialSlide testimonialSlide2 = new TestimonialSlide()
            //         {
            //             Comment = "It's amazing!",
            //             Name = "Aysu",
            //             Profession = "Influencer",
            //             ImgUrl = "testimonial-2.jpg"
            //         };
            //         TestimonialSlide testimonialSlide3 = new TestimonialSlide()
            //         {
            //             Comment = "It is very good for safety!",
            //             Name = "Asif",
            //             Profession = "Construction worker",
            //             ImgUrl = "testimonial-3.jpg"
            //         };
            //         TestimonialSlide testimonialSlide4 = new TestimonialSlide()
            //         {
            //             Comment = "Perfect!",
            //             Name = "Nigar",
            //             Profession = "Teacher",
            //             ImgUrl = "testimonial-4.jpg"
            //         };

            //         db.TestimonialSlides.AddRange(testimonialSlide1, testimonialSlide2, testimonialSlide3, testimonialSlide4);

            //         db.SaveChanges();

            List<Member> members = db.Members.ToList();
			List<ServiceSlide> serviceSlides = db.ServiceSlides.ToList();
			List<TestimonialSlide> testimonialSlides = db.TestimonialSlides.ToList();

			HomeVm vm = new HomeVm()
			{
				Members = members,
				ServiceSlides = serviceSlides,
				TestimonialSlides = testimonialSlides
			};



            return View(vm);
		}
	}
}
