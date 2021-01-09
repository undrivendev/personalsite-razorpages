using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ldv.PersonalSite.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Experience> Experiences
            => new List<Experience>()
            {
                new Experience()
                {
                    DateFrom = new DateTime(2020, 10, 26),
                    DateTo = null,
                    Company = "ALTEN Switzerland",
                    Role = "Full Stack Developer",
                    CompanyUrl = new Uri("https://www.alten.ch"), 
                    Summary = "Implementing enterprise LOB full-stack solutions using Microsoft technologies.",
                    Accomplishments = new List<string>()
                    {
                        "SwissPost: developed an Angular + ASP.NET Core e-commerce SPA to support delivery services across the entire Swiss territory"
                    },
                },
                new Experience()
                {
                    DateFrom = new DateTime(2019, 5, 1),
                    DateTo = new DateTime(2020, 10, 5),
                    Company = "Texa Spa",
                    Role = "Cloud Solutions Developer",
                    CompanyUrl = new Uri("https://www.texa.com"), 
                    Summary = "Developing Cloud Solutions in C# and .NET Core for Big Data and IoT architectures built on Microsoft Azure.",
                    Accomplishments = new List<string>()
                    {
                        "Developed a new cost-effective solution to store long-term Big Data",
                        "Designed and implemented a highly parallelized set of Web APIs to query ingestion data from multiple data sources",
                        "Implemented a microservice solution to save the ingestion data into the main short-term database",
                        "Developed a highly performant Web API for the realtime processing of geographical data",
                        "Had a key role in the process of migrating the technology stack of the main short-term ingestion database",
                        "Rewritten an Angular SPA and realtime monitoring solution for the cloud infrastructure",
                        "Lead the development of a Blazor SPA for internal customers",
                        "Built a set of web APIs to perform complex aggregations on Big Data for data analysis purposes",
                    },
                },
                new Experience()
                {
                    DateFrom = new DateTime(2017, 11, 1),
                    DateTo = new DateTime(2019, 4, 30),
                    Role = "Full Stack Developer",
                    Company = "Danea Soft",
                    CompanyUrl = new Uri("https://www.danea.it"), 
                    Summary = "Web Development using the Microsoft stack and standard web technologies.",
                    Accomplishments = new List<string>()
                    {
                        "MioCondominio: single-handedly rewrote this core business app by converting it from a legacy ASP MPA to a SPA based on Angular 7+ and ASP.NET Core",
                        "Agyo Console: designed and developed a MPA to expose some functionalities of the centralized TeamSystem invoicing platform to the end-users",
                        "Authentication server: built an IdP based on the highest security standards to provide a centralized authentication platform for the different applications",
                        "Domustudio: built the prototype of the next web-based version of the application using React and ASP.NET Core",
                        "Had a critical role in the refactoring of the codebase by separating it into a three layer structure and by rewriting the DAL using Dapper",
                        "Numilia: integrated the application with the Braintree platform",
                    },
                },
                new Experience()
                {
                    DateFrom = new DateTime(2014, 9, 1),
                    DateTo = new DateTime(2017, 10, 31),
                    Role = "Developer",
                    Company = "Maxima srl",
                    CompanyUrl = new Uri("https://www.linkedin.com/company/maxima-s.r.l.l./"),
                    Summary = "Customer support, development using VB6, SQL Server, VB.NET, C# and ASP.NET. Light project management.",
                    Accomplishments = new List<string>()
                    {
                        "Learnt VB6",
                        "Level 1 and 2 Help Desk customer phone support: troubleshooting, bugfixing, SQL Server data migrations",
                        "Managed the startup of many new customers",
                        ".NET 4.0+ development using VB.NET and C#",
                        "OneStore: participated in the development of this new project using .NET Core 1.0, IdentityServer, Angular 4+, C#",
                    },
                },
                new Experience()
                {
                    DateFrom = new DateTime(2013, 9, 1),
                    DateTo = new DateTime(2014, 8, 31),
                    Role = "Developer intern",
                    Company = "Qfns Italy Srl",
                    CompanyUrl = null,
                    Summary = "Development using C#, .NET, Silverlight.",
                    Accomplishments = new List<string>()
                    {
                        "Self-taught C# and the .NET Framework 4.6",
                        "Participated actively in the development of the main business application",
                        "Came in contact with DevOps best practices by practicing SCRUM diligently",
                    },
                },
            };
    }

    public class Experience
    {
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Role { get; set; }
        public string Company { get; set; }
        public Uri? CompanyUrl { get; set; }
        public string Summary { get; set; }
        public List<string> Accomplishments { get; set; }
    }
}