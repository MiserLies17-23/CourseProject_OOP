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

        public async Task<IEnumerable<Exhibit>> GetAllAsync()
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits";
            return await connection.QueryAsync<Exhibit>(sql);
        }

        public async Task<IEnumerable<Exhibit>> GetBySectionAsync(SectionEnum section)
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits WHERE Section = @Section";
            return await connection.QueryAsync<Exhibit>(sql, new { Section = section.ToString() });
        }

        public async Task<Exhibit?> GetByIdAsync(int exhibitId)
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits WHERE Id = @Id";
            return await connection.QueryFirstOrDefaultAsync<Exhibit>(sql, new { Id = exhibitId });
        }

        public async Task<IEnumerable<Exhibit>> GetByNameAsync(string name)
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits WHERE Name LIKE @Name";
            return await connection.QueryAsync<Exhibit>(sql, new { Name = $"%{name}%" });
        }

        public async Task<IEnumerable<Exhibit>> GetByDateAsync(DateTime date)
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits WHERE DateTime = @DateOfDiscovery";
            return await connection.QueryAsync<Exhibit>(sql, new { DateTime = date });
        }

        public async Task<IEnumerable<Exhibit>> GetByAgeAsync(int age)
        {
            using var connection = CreateConnection();
            var sql = "SELECT * FROM Exhibits WHERE Age = @Age";
            return await connection.QueryAsync<Exhibit>(sql, new { Age = age });
        }

        public async Task AddAsync(Exhibit newExhibit)
        {
            var connection = CreateConnection();
            var sql = @"
            INSERT INTO Exhibits (Name, Description, Section, Age, DateTime)
            VALUES (@Name, @Description, @Section, @Age, @DateOfDiscovery)
            RETURNING Id";

            newExhibit.Id = await connection.QuerySingleAsync<int>(sql, new
            {
                newExhibit.Name,
                newExhibit.Description,
                Section = newExhibit.Section.ToString(),
                newExhibit.Age,
                newExhibit.DateOfDiscovery
            });
        }

        public async Task UpdateAsync(Exhibit editExhibit)
        {
            var connection = CreateConnection();
            var sql = @"
            UPDATE Exhibits 
            SET Name = @Name, 
                Description = @Description, 
                Section = @Section,
                Age = @Age,
                DateTime = @DateOfDiscovery
            WHERE Id = @Id";

            await connection.ExecuteAsync(sql, new
            {
                editExhibit.Id,
                editExhibit.Name,
                editExhibit.Description,
                Section = editExhibit.Section.ToString(),
                editExhibit.Age,
                editExhibit.DateOfDiscovery
            });
        }

        public async Task DeleteAsync(int exhibitId)
        {
            using var connection = CreateConnection();
            var sql = "DELETE FROM Exhibits WHERE Id = @Id";
            await connection.ExecuteAsync(sql, new { Id = exhibitId });
        }

        public int GetCount()
        {
            return _exhibits.Count;
        }
    }
}
