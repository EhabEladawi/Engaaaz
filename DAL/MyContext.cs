using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class MyContext: DbContext
    {
        public MyContext()
        : base("Data Source=PARSLEY.arvixe.com; Initial Catalog=dental; User ID=dental; Password=01004808458")
        //: base("DentalDB")
        {

        }
        public DbSet<personcs> Person { get; set; }
        public DbSet<gendercs> Gender { get; set; }
        public DbSet<diagnosis> diagnosis { get; set; }
        public DbSet<person_diagnosis> diagnosis_person { get; set; }
        public DbSet<extraction> extraction { get; set; }
        public DbSet<person_extraction> extraction_person { get; set; }
        public DbSet<periodontal> periodontal { get; set; }
        public DbSet<person_periodontal> periodontal_Person { get; set; }
        public DbSet<dentalbleeching> dentalbleeching { get; set; }
        public DbSet<person_dentalbleeching> dentalbleeching_person { get; set; }
        public DbSet<dentalraidiology> dentalraidiology { get; set; }
        public DbSet<person_dentalraidiology> dentalraidiology_person { get; set; }
        public DbSet<resroration> resroration { get; set; }
        public DbSet<person_resroration> resroration_person { get; set; }
        public DbSet<rootcanal> rootcanal { get; set; }
        public DbSet<person_rootcanal> rootcanal_person { get; set; }
        public DbSet<subroot> subroot { get; set; }
        public DbSet<person_subroot> subroot_person { get; set; }
        public DbSet<dentalsurgery> dentalsurgery { get; set; }
        public DbSet<person_dentalsurgery> dentalsurgery_person { get; set; }
        public DbSet<dentalprothesis> dentalprothesis { get; set; }
        public DbSet<person_dentalprothesis > dentalprothesis_person { get; set; }
        public DbSet<subdentalprothesis> subdentalprothesis { get; set; }
        public DbSet<person_subdentalprothesis> subdentalprothesis_person { get; set; }
        public DbSet<subsubdentalprothesis> subsubdentalprothesis { get; set; }
        public DbSet<person_subsubdentalprothesis> subsubdentalprothesis_person { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Doctorclinicinformation> Doctorclinicinformation { get; set; }
        public DbSet<doctorscientific> doctorscientific { get; set; }
        public DbSet<Doctrorpersonal> Doctrorpersonal { get; set; }
        public DbSet<EMP> EMP { get; set; }
        public DbSet<EMPClinic> EMPClinic { get; set; }
        public DbSet<EmpPersonal> EmpPersonal { get; set; }
        public DbSet<process> process { get; set; }

        public DbSet<medicalhistory> medicalhistory { get; set; }
    }
}
