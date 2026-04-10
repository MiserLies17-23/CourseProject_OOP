using Dapper;
using Npgsql;
using WinFormsApp_OOP_CourseProject.Config;
using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.Repository
{
    public class ExhibitRepository : IExhibitRepository
    {
        private readonly string _connectionString;

        private readonly List<Exhibit> _exhibits;

        public ExhibitRepository()
        {
            _connectionString = AppConfig.ConnectionString;
            _exhibits = [];
        }

        private NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        public IEnumerable<Exhibit> GetAll()
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits";
            return connection.Query<Exhibit>(sql);
        }

        public IEnumerable<Exhibit> GetBySection(SectionEnum section)
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits WHERE Section = @Section";
            return connection.Query<Exhibit>(sql, new { Section = section.ToString() });
        }

        public Exhibit? GetById(int exhibitId)
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits WHERE Id = @Id";
            return connection.QueryFirstOrDefault<Exhibit>(sql, new { Id = exhibitId });
        }

        public void Add(Exhibit newExhibit)
        {
            var connection = CreateConnection();
            var sql = @"
            INSERT INTO Exhibits (Name, Description, Section, Year, Author, CreatedAt)
            VALUES (@Name, @Description, @Section, @Year, @Author, @CreatedAt)
            RETURNING Id";

            newExhibit.Id = connection.QuerySingle<int>(sql, new
            {
                newExhibit.Name,
                newExhibit.Description,
                Section = newExhibit.Section.ToString(),
                newExhibit.Age,
                newExhibit.DateOfDiscovery
            });
        }

        public void Update(Exhibit editExhibit)
        {
            var connection = CreateConnection();
            var sql = @"
            UPDATE Exhibits 
            SET Name = @Name, 
                Description = @Description, 
                Section = @Section,
                Year = @Year,
                Author = @Author
            WHERE Id = @Id";

            connection.Execute(sql, new
            {
                editExhibit.Id,
                editExhibit.Name,
                editExhibit.Description,
                Section = editExhibit.Section.ToString(),
                editExhibit.Age,
                editExhibit.DateOfDiscovery
            });
        }

        public void Delete(int exhibitId)
        {
            using var connection = CreateConnection();
            var sql = "DELETE FROM Exhibits WHERE Id = @Id";
            connection.Execute(sql, new { Id = exhibitId });
        }

        public int GetCount()
        {
            return _exhibits.Count;
        }
    }
}
