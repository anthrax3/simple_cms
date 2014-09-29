using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace simple_cms.Models
{
    public class CMSInitializer : DropCreateDatabaseIfModelChanges<CMSContext>
    {
        protected override void Seed(CMSContext context)
        {
            var subjects = new List<Subject>
            {
                new Subject{SubjectName="Study Programmes",SubjectPosition=1,SubjectVisible=true},
                new Subject{SubjectName="Our University",SubjectPosition=2,SubjectVisible=true},
                new Subject{SubjectName="Campus Life",SubjectPosition=3,SubjectVisible=true},
                new Subject{SubjectName="Services",SubjectPosition=4,SubjectVisible=true}
            };
            foreach (var temp in subjects)
            {
                context.Subjects.Add(temp);
            }
            context.SaveChanges();

            var pages = new List<Page>
            {
                new Page{SubjectId=1, PageName="THE BEST CAREER PROSPECTS",PagePosition=1,PageVisible=true,PageContent="A solid foundation and inviting future prospects, freedom plus responsibility: the SRH University Heidelberg offers optimal chances for a successful start to your working life. As one of the oldest and largest private universities in Germany, we have been setting standards in the educational sector for four decades."},
                new Page{SubjectId=1,PageName="Excellent training",PagePosition=2,PageVisible=true,PageContent="We stand for excellent academic training. The knowledge our students gain serves as the basis for discovering new horizons in case studies and management exercises. Our distinguished Heidelberg Study Model lays special emphasis on the optimal mix of theory and practice. From the start, our students benefit from our ever-increasing partnerships with worldwide companies. We are part of a close network of contacts within business and industry, as well as scientific institutions."},
                new Page{SubjectId=2,PageName="STUDY AND SUCCEED",PagePosition=1,PageVisible=true,PageContent="As one of the oldest and largest private universities in Germany, we set the standard for education. We equip you with the knowledge you need for your future – hands-on, innovative and creative. For this, close collaboration between our students and faculty is of particular importance."},
                new Page{SubjectId=2,PageName="Education without borders",PagePosition=2,PageVisible=true,PageContent="Foundation and perspectives, freedom of movement and responsibility:Come study in the SRH Science Tower, our teaching tower. Its architecture symbolizes dynamism, transparence and creativity. We offer you an educational environment with state-of-the-art equipment and an attractive campus in one of the most beautiful cities in Germany."},
                new Page{SubjectId=3,PageName="THE FASCINATION OF HEIDELBERG",PagePosition=1,PageVisible=true,PageContent="Each year, around 3.5 million visitors come to Heidelberg. The city exhibits a broad appeal, captivating people in a wide variety of ways – whether through its architectural beauty or the idyllic location on the Neckar River."},
                new Page{SubjectId=3,PageName="An inspiring campus life",PagePosition=2,PageVisible=true,PageContent="The SRH University Heidelberg is one of the oldest private universities in Germany. With over 2,000 students in five departments, it is also one of the largest of its kind. A personal atmosphere, a close exchange between students and faculty: our campus is a lively home. Library, shopping, bank, gastronomy, sport and culture – we offer everything right here. Even idyllic green spaces can be found right on our doorstep - it’s a five-minute walk to the banks of the Neckar River."},
                new Page{SubjectId=4,PageName="ALWAYS AN OPEN EAR",PagePosition=1,PageVisible=true,PageContent="Interested in studying at the SRH University in Heidelberg? Our Student Services Office is your first contact point for all questions pertaining to your studies. We advise both prospective and current students, explain requirements and prospects. We gladly support you in finding accommodations, planning an internship, or preparing for a semester abroad."},
                new Page{SubjectId=4,PageName="WHERE TO FIND US",PagePosition=2,PageVisible=true,PageContent="Feel free to simply stop by and have a look around, no obligation required. Or perhaps you’d like to visit one of our Open House days."}
                
            };
            foreach (var temp in pages)
            {
                context.Pages.Add(temp);
            }
            context.SaveChanges();

        }
    }
}