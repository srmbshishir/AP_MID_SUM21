using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace Lecture5.Models.Database
{
    public class Products
    {
        SqlConnection conn;

        public Products(SqlConnection conn) {
            this.conn = conn;
        }
        public void Insert(Product p) {
            string query = String.Format($"Insert into Student values ('{p.Name}','{p.Id}','{p.Dob}',{p.Credit},{p.Cgpa},'{p.Dept_id}')");
            //string query = String.Format("Insert into Student values ('{0}','{1}','{2}',{3},{4},'{5}')", p.Name, p.Id, p.Dob, p.Credit,p.Cgpa,p.Dept_id);
            //string query = "Insert into Student values(@name,@id,@dob,@credit,@cgpa,@dept_id)";
            //insert into Student values('shishir','19','1999-10-10',132,2.50,'16')
            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.Parameters.AddWithValue("@id",p.Id);
            //cmd.Parameters.AddWithValue("@name",p.Name);
            //cmd.Parameters.AddWithValue("@credit",p.Credit);
            //cmd.Parameters.AddWithValue("@cgpa",p.Cgpa);
            //cmd.Parameters.AddWithValue("@dob", p.Dob);
            //cmd.Parameters.AddWithValue("@dept_id", p.Dept_id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Product> GetAll() {
            List<Product> products = new List<Product>();
            string query = "select * from Student";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                Product p = new Product()
                {
                    Id = reader.GetString(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    Cgpa = reader.GetDouble(reader.GetOrdinal("Cgpa")),
                    Dob = reader.GetDateTime(reader.GetOrdinal("Dob")),
                    Dept_id = reader.GetString(reader.GetOrdinal("Dept_id")),

                    //Description = reader.GetString(reader.GetOrdinal("Description")),
                };
                products.Add(p);
            }
            conn.Close();
            return products;
        }
        public Product Get(string id) {
            Product p = null;
            string query = $"select * from Student Where id='{id}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                p = new Product()
                {
                    Id = reader.GetString(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    Cgpa = reader.GetDouble(reader.GetOrdinal("Cgpa")),
                    Dob = reader.GetDateTime(reader.GetOrdinal("Dob")),
                    Dept_id = reader.GetString(reader.GetOrdinal("Dept_id")),


                };
            }
            conn.Close();
            return p;
        }
        
        public void Update(Product p) {
            string query = $"Update Student Set name='{p.Name}',id='{p.Id}' ,credit={p.Credit}, cgpa={p.Cgpa}, dob='{p.Dob}', dept_id='{p.Dept_id}' Where id = '{p.Id}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        
        public void Delete(Product p) {
            string query = $"Delete from Student where id = '{p.Id}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public int Validate(Admin a)
        {
            string query = $"Select count(*) from Admin where username = '{a.Username}' and password = '{a.Password}'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            conn.Close();
            return temp;
        }
    }
}