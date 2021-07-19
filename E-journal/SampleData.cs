using E_journal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_journal
{
    public class SampleData
    {
        public static void Initialize(EjournalContext context)
        {
            if (!context.Courses.Any())
            {
                context.Courses.AddRange(
                    new Course
                    {
                        CourseNumber = "1"
                    },
                    new Course
                    {
                        CourseNumber = "2"
                    },
                    new Course
                    {
                        CourseNumber = "3"
                    },
                    new Course
                    {
                        CourseNumber = "4"
                    });
                context.SaveChanges();
            }
            if (!context.Teachers.Any())
            {
                context.Teachers.AddRange(
                    new Teacher
                    {
                        Name = "Назаров Савва Дмитриевич",
                        Discipline= "Международные отношения"
                    },
                    new Teacher
                    {
                        Name = "Миронов Кирилл Артёмович",
                        Discipline = "Прикладная математика и информатика"
                    },
                    new Teacher
                    {
                        Name = "Герасимова Василиса Артёмовна",
                        Discipline = "Системный анализ и управление"
                    },
                    new Teacher
                    {
                        Name = "Полякова Ариана Максимовна",
                        Discipline = "Международные отношения"
                    },
                    new Teacher
                    {
                        Name = "Ильин Марк Кириллович",
                        Discipline = "Экономика"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
