using Microsoft.EntityFrameworkCore;

namespace Assignment.DataBase;

public class StudentDataBase : DbContext
{
    public StudentDataBase(DbContextOptions<StudentDataBase> options) : base(options)
    {

    }
    public DbSet<StudentDataBase> Student{ get; set; }

}

