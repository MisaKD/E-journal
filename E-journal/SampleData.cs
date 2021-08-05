using E_journal.Models;
using System.Linq;

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
                        CourseNumber = "Первый"
                    },
                    new Course
                    {
                        CourseNumber = "Второй"
                    },
                    new Course
                    {
                        CourseNumber = "Третий"
                    },
                    new Course
                    {
                        CourseNumber = "Четвертый"
                    });
                context.SaveChanges();
            }
            if (!context.Teachers.Any())
            {
                context.Teachers.AddRange(
                    new Teacher
                    {
                        Name = "Назаров Савва Дмитриевич",
                        Discipline = "Международные отношения"
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
                        Discipline = "Юриспруденция"
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
