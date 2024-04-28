using System.Data.SqlClient;
using AnimalsCRUD_cw3.Model;
using AnimalsCRUD_cw3.Services;

namespace AnimalsCRUD_cw3.Repositories;

public class AnimalsRepository : IAnimalsRepository
{
    private IConfiguration _configuration;
    
    public AnimalsRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public IEnumerable<Animal> GetAnimals()
    {
        // using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        using var con = new SqlConnection(_configuration["Data Source=db-mssql;Initial Catalog=s18839;Integrated Security=True;Trust Server Certificate=True"]);
        con.Open();
        
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        // cmd.CommandText = "SELECT * FROM animals;";
        cmd.CommandText = "SELECT IdStudent, FirstName, LastName, Email, Address, IndexNumber FROM Student ORDER BY LastName, FirstName";
        
        var dr = cmd.ExecuteReader();
        var animals = new List<Animal>();
        while (dr.Read())
        {
            var eAnimal = new Animal
            {
                // IdStudent = (int)dr["IdStudent"],
                // FirstName = dr["FirstName"].ToString(),
                // LastName = dr["LastName"].ToString(),
                // Email = dr["Email"].ToString(),
                // Address = dr["Address"].ToString(),
                // IndexNumber = (int)dr["IndexNumber"]
                IdAnimal = (int)dr["IdAnimal"]
            };
            animals.Add(eAnimal);
        }
        
        return animals;
    }

    public int CreateAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public Animal GetAnimal(int idAnimal)
    {
        throw new NotImplementedException();
    }

    public int UpdateAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public int DeleteAnimal(int idAnimal)
    {
        throw new NotImplementedException();
    }
}