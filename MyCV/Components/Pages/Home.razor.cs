using System.Globalization;

namespace MyCV.Components.Pages
{
    public partial class Home
    {
        private string? AboutMe;
        private Dictionary<string, string[]> ExpertiseAreaList = new();
        private List<CarrerBackground> CarrerBackgroundList = new();
        private List<Education> EducationList = new();
        private List<Language> LanguageList = new();
        private List<Award> AwardsList = new();
        private CultureInfo EN = new CultureInfo("en-US");

        protected override void OnInitialized()
        {
            AboutMe = $@"I graduated in information systems, have worked in different business areas, and am an expert software engineer.
My knowledge includes .NET Framework, .NET Core 6+, WPF, WebService, Windows Services, XML, Blazor, JQuery, Ajax, MySQL, SQL Server, Git, GitHub and others. I have proven experience with technical leadership and team management.

With a passion for innovation and a solid commitment to delivering exceptional results, I am confident I would be an asset to any organisation looking for a skilled and motivated back-end developer.";

            ExpertiseAreaList.Add("Front-end development", 
                new string[] 
                {
                    "Knowledge of JavaScript, JQuery and Ajax, with experience in developing dynamic and interactive web applications.",
                    "Experience with Web Forms on .NET Framework, Blazor on .NET Core and Windows Forms on both versions."
                });
            ExpertiseAreaList.Add("Back-end development", 
                new string[] 
                {
                    "Experience using C# to develop scalable and robust systems.",
                    "Experience on implementing Workers, Schedulers, Messaging and Caching",
                    "Experience with Dapper and Entity Framework to connect to databases such as MySQL, Postgresql and SQL Server.",
                    "Knowledge to implement best practices and pattern designs on new or refactored projects.",
                    "Knowledge on microservices.",
                    "Knowledge of unit and integration tests and project documentation.",
                });
            ExpertiseAreaList.Add("DevOps", 
                new string[] 
                {
                    "Experience using DevOps tools like GitHub, GitLab, Kubernetes, Azure, Jenkins, Growroot, and Argo to support software development and deployment processes.",
                    "Proficiency in using GitHub and GitLab for version control, code collaboration, and continuous integration and delivery (CI/CD).",
                    "Knowledge of Kubernetes and Azure for container orchestration, deployment, and management with skills as a tool user.",
                    "Experience in code review."
                });

            CarrerBackgroundList.Add(new CarrerBackground()
            {
                Position = "Senior Software Engineer",
                StartDate = new DateTime(2023, 11, 1),
                EndDate = new DateTime(2024, 6, 1),
                CompanyName = "Wake",
                Link = "https://wake.tech/",
                Description = $"I developed libraries and classes that facilitated other tasks and developments. {Environment.NewLine}I can mention a library to communicate with Redis and code/query improvements to increase performance.",
                Local = "Curitiba, Brazil",
                Type = "Contract"
            });
            CarrerBackgroundList.Add(new CarrerBackground()
            {
                Position = "System Development Coordinator",
                StartDate = new DateTime(2021, 10, 1),
                EndDate = new DateTime(2023, 10, 1),
                CompanyName = "Ideris",
                Link = "https://www.ideris.com.br/",
                Description = $"I managed two squads focusing on bug fixes. {Environment.NewLine}My main daily tasks are people and tasks management, technical and business rules for developers and code time.",
                Local = "Curitiba, Brazil",
                Type = "Contract"
            });
            CarrerBackgroundList.Add(new CarrerBackground()
            {
                Position = "Software Engineer",
                StartDate = new DateTime(2022, 11, 1),
                EndDate = new DateTime(2022, 12, 1),
                CompanyName = "CANJA Audio Culture",
                Link = "https://www.canja.audio/",
                Description = $"A short project (more like a challenge) to create a solution that reads rom a sheet and plays a signal based on time and frequency.{Environment.NewLine}The most beautiful song idea is to 'play' a new method of cancer combat destroying cancer cells.{Environment.NewLine}The project was very successful and won the most prestigious propaganda awards.",
                Local = "Curitiba, Brazil",
                Type = "Freelancer"
            });
            CarrerBackgroundList.Add(new CarrerBackground()
            {
                Position = "Software Engineer",
                StartDate = new DateTime(2020, 08, 1),
                EndDate = new DateTime(2021, 09, 1),
                CompanyName = "Ideris",
                Link = "https://www.ideris.com.br/",
                Description = $"The team was focused on code refractory, updating from .NET Framework 4.5 to .NET Core 6.{Environment.NewLine}Some developers were selected to code key functionalities; I was one of these chosen.{Environment.NewLine}This group had to decide and develop premises and design patterns for the project.",
                Local = "Curitiba, Brazil",
                Type = "Contract"
            });
            CarrerBackgroundList.Add(new CarrerBackground()
            {
                Position = "Software Developer",
                StartDate = new DateTime(2019, 08, 1),
                EndDate = new DateTime(2020, 07, 1),
                CompanyName = "Ideris",
                Link = "https://www.ideris.com.br/",
                Description = $"Responsible for developing, supporting, and documenting the open API from the beginning, where customers or ERP platforms would be able to fetch relevant information for their business.{Environment.NewLine}I also developed a library to support the NoSQL database.",
                Local = "Curitiba, Brazil",
                Type = "Contract"
            });
            CarrerBackgroundList.Add(new CarrerBackground()
            {
                Position = "Software Developer",
                StartDate = new DateTime(2018, 07, 1),
                EndDate = new DateTime(2019, 07, 1),
                CompanyName = "OAK Vendas",
                Link = "",
                Description = $"A project that I participated in from the beginning.{Environment.NewLine}An ERP in C# .NET Framework, WebForms and MySQL and services necessary for the proper functioning of the application.{Environment.NewLine}I worked as an analyst, programmer, DBA and DevOps in this start-up due to the low number of collaborators involved in the project.{Environment.NewLine}Due to the acceptance and quality of the code, Ideris acquired this company, where employees were included as part of the capital due to technical knowledge and business rules.",
                Local = "Curitiba, Brazil",
                Type = "Contract"
            });
            CarrerBackgroundList.Add(new CarrerBackground()
            {
                Position = "Software Developer",
                StartDate = new DateTime(2018, 04, 1),
                EndDate = new DateTime(2018, 06, 1),
                CompanyName = "Senff",
                Link = "https://www.senff.com.br/",
                Description = $"I worked on the bug fix team found in applications used by customers and intranet applications.",
                Local = "Curitiba, Brazil",
                Type = "Contract"
            });
            CarrerBackgroundList.Add(new CarrerBackground()
            {
                Position = "Software Developer",
                StartDate = new DateTime(2017, 12, 1),
                EndDate = new DateTime(2018, 02, 1),
                CompanyName = "Made Software",
                Link = "",
                Description = $"Developed a mobile application for UWP (Universal Windows Platform) using C# for the back-end.{Environment.NewLine}Triggers and events are communicated between the application and the server.{Environment.NewLine}The application controls and saves all user usage information in an SQLite database on the mobile device.",
                Local = "Curitiba, Brazil",
                Type = "Contract"
            });
            CarrerBackgroundList.Add(new CarrerBackground()
            {
                Position = "Customer service",
                StartDate = new DateTime(2014, 05, 1),
                EndDate = new DateTime(2017, 09, 1),
                CompanyName = "Stellent",
                Link = "",
                Description = $"Responsible for assisting customers via telephone, email or chat, helping them with questions or services related to the 188Bet.com website in a foreign language environment (English).{Environment.NewLine}I also translated texts and emails, depending on what was needed",
                Local = "Dublin, Ireland",
                Type = "Contract"
            });
            CarrerBackgroundList.Add(new CarrerBackground()
            {
                Position = "Software Developer",
                StartDate = new DateTime(2012, 12, 1),
                EndDate = new DateTime(2013, 09, 1),
                CompanyName = "Regazzo Soluções Em Tecnologia",
                Link = "https://www.regazzo.com.br/",
                Description = $"WMS: The Warehouse Management System application controls stock and financial input and output, following the client's business rules.{Environment.NewLine}As it is a large warehouse, it was necessary to develop an application for warehouse workers using WebService to send the information saved in the collectors to the mainstream.{Environment.NewLine}{Environment.NewLine}LMS: The Logistic Management System application was developed for Renault of Brazil in VB6 to control cars parked in the factory's parking lot.{Environment.NewLine}I represented Ragazzo Soluções em Tecnologia at Renault, seeking and developing solutions for this application and developing new applications in C# to help/replace and refactor the current system.",
                Local = "Curitiba, Brazil",
                Type = "Contract"
            });
            CarrerBackgroundList.Add(new CarrerBackground()
            {
                Position = "Software Developer",
                StartDate = new DateTime(2012, 9, 1),
                EndDate = new DateTime(2013, 11, 1),
                CompanyName = "Advocacia Bellinati Perez",
                Link = "https://www.bellinatiperez.com.br/",
                Description = $"Development and support of the system that assists the company's employees in controlling cases and having a history of cases that have already been closed.{Environment.NewLine}XLM was used to communicate with applications from other company departments, and Web Service/API was used to integrate with third-party applications.",
                Local = "Curitiba, Brazil",
                Type = "Contract"
            });
            CarrerBackgroundList.Add(new CarrerBackground()
            {
                Position = "Junior Software Developer",
                StartDate = new DateTime(2012, 4, 1),
                EndDate = new DateTime(2012, 6, 1),
                CompanyName = "Midas Code",
                Link = "",
                Description = $"Development and support of Distance Learning application with more than 3000 IFPR students.{Environment.NewLine}The portal features user control, video lessons, class attendance, and student grades",
                Local = "Curitiba, Brazil",
                Type = "Contract"
            });

            LanguageList.Add(new Language() { Name = "English", Level = "Full Professional Proficiency" });
            LanguageList.Add(new Language() { Name = "Portuguese", Level = "Native"  });

            EducationList.Add(new Education() { College = "Universidade Federal do Paraná", Local = "Curitiba - Brazil", Name = "System Information", StartDate = new DateTime(2008, 6, 1), EndDate = new DateTime(2012, 12, 1) });
            EducationList.Add(new Education() { College = "NCBA", Local = "Dublin - Ireland", Name = "English", StartDate = new DateTime(2014, 3, 1), EndDate = new DateTime(2014, 8, 1) });
            EducationList.Add(new Education() { College = "NCBA", Local = "Dublin - Ireland", Name = "Business English", StartDate = new DateTime(2015, 3, 1), EndDate = new DateTime(2017, 2, 1) });

            AwardsList.Add(new Award() { Description = "Cannes Lions and New York Festivals Awards winner with The Most Beautiful Song project." });
        }
    }

    internal class CarrerBackground
    {
        public string? Position { get; set; }
        public string? CompanyName { get; set; }
        public string? Link { get; set; }
        public string? Type { get; set; }
        public string? Local { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
    }

    internal class Education
    {
        public string? Name { get; set; }
        public string? College { get; set; }
        public string? Local { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    internal class Language
    {
        public string? Name { get; set; }
        public string? Level { get; set; }
    }

    internal class Award
    {
        public string? Description { get; set; }
    }
}