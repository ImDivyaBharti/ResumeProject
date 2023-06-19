using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoResume.Models
{
    public class ResumeViewModel
    {
        //personalDetails
        public int ID { get; set; }
        public string FullName { get; set; }

        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public Nullable<System.DateTime> DOB { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Nationality { get; set; }
        public string ShortAddress { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string Hobby { get; set; }
        public string LanguageName { get; set; }
        public string MaritalStatus { get; set; }
        public string PerPhoto { get; set; }
        public string Profile { get; set; }
        public string PerSignature { get; set; }
        public string Place { get; set; }
        public Nullable<System.DateTime> CurrentDate { get; set; }

        //objective
        public int ObjectiveId { get; set; }
        public string Objective1 { get; set; }
        public string Objective2 { get; set; }

        //EducationalInfo
        public int Eduld { get; set; }
        public string ExamPassed { get; set; }
        public string Institution { get; set; }
        public string Board { get; set; }
        public Nullable<int> YearOfPassing { get; set; }

        //TechnicalInfo
        public int TSkillId { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }

        //WorkExperience
        //public int ExpId { get; set; }
        //public string OrgName { get; set; }
        //public string JobTitle { get; set; }
        //public string FromYear { get; set; }
        //public string ToYear { get; set; }
        //public string ExpDescription { get; set; }

        //Summary
        public int ProfId { get; set; }
        public string Details1 { get; set; }
        public string Details2 { get; set; }

        //Projectinfo

        //public int ProjectId { get; set; }
        //public string ProjectName { get; set; }
        //public string ProjectRole { get; set; }
        //public Nullable<int> TeamSize { get; set; }
        //public string Duration { get; set; }
        //public string ProjectDescription { get; set; }

        //declartion 
        public int DeclartaionId { get; set; }
        public string add1 { get; set; }
        public string dPlace { get; set; }
        public DateTime dDate { get; set; }
        public string sig { get; set; }

        //work3
        public int ExpId { get; set; }
        public string OrgName { get; set; }
        public string JobTitle { get; set; }

        // new projectinfo2
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectRole { get; set; }


        //databind
        public IEnumerable<Personal_Details> personalDetails { get; set; }
        //public virtual Personal_Details Personal_Details { get; set; }
        public IEnumerable<Objective> objectives { get; set; }
        //public virtual Objective Objective { get; set; }

        public IEnumerable<EducationalInfo> educationalInfos { get; set; }
        //public virtual EducationalInfo EducationalInfo { get; set; }

        public IEnumerable<TechnicalInfo> technicalInfos { get; set; }
        //public virtual TechnicalInfo TechnicalInfo { get; set; }

        public IEnumerable<Summary> summaries { get; set; }
        //public virtual Summary Summary { get; set; }
        public IEnumerable<Declartaion> Declartions { get; set; }
        //public virtual Declartaion Declartaion { get; set; }

        public IEnumerable<WorkExperience> workExperience { get; set; }
        //public virtual WorkExperience WorkExperience { get; set; }

        public IEnumerable<ProjectInfo> projectInfos { get; set; }
        //public virtual ProjectInfo Projectinfo { get; set; }

    }
}