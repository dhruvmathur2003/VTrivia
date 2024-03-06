using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using VTrivia.Model;
using VTrivia.Repository.IRepository;

namespace VTrivia.Repository
{
    public class GroupRepository : IGroupRepository
    {
        private IDbConnection db;
        public GroupRepository(IConfiguration configuration) 
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public Group Add(Group entity)
        {
            var sql = "INSERT INTO Groups (Name, Description, AdminId,TiemStamp) VALUES(@Name, @Description, @AdminId,@TiemStamp);"
              + "SELECT CAST(SCOPE_IDENTITY() as int);";
            var id = db.Query<int>(sql, entity).Single();
            entity.Id = id;
            return entity;
        }

        public Group Get(int id)
        {
            var sql = "SELECT * FROM Groups WHERE Id = @id";
            return db.Query<Group>(sql, new { id }).Single();
        }

        public IEnumerable<Group> GetAll()
        {
            var sql = "SELECT * FROM Groups";
            return db.Query<Group>(sql);
        }

        public void Remove(int id)
        {
            var sql = "DELETE From Groups WHERE Id = @id";
            db.Execute(sql, new { id });
        }

        public void RemoveRange(IEnumerable<Group> entities)
        {
            throw new NotImplementedException();
        }

        public Group Update(Group entity)
        {
            throw new NotImplementedException();
        }
    }
}
