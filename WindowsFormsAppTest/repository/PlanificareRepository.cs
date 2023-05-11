using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppTest.data;

namespace WindowsFormsAppTest.repository
{
    public class PlanificareRepository
    {

        private string connectionString;
        private DataAcces dataAcces;

        public PlanificareRepository()
        {
            this.dataAcces = new DataAcces();

            this.connectionString =GetConnection();

        }

        public List<Palnificare> getAllPlanificari()
        {
            string sql = "select * from planificari";

            return this.dataAcces.LoadData<Palnificare, dynamic>(sql, new { }, connectionString);
        
        }

        public string GetConnection()
        {
            string c = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();
            string connectionStringIs = configuration.GetConnectionString("Default");
            return connectionStringIs;
        }

    }
}
