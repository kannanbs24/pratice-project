using BAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL1
    {
        public bool Insert(Laptop school)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-LUAVTH3;Initial Catalog=Ecommerce;Integrated Security=True");

            SqlCommand cmdInsert = new SqlCommand("insert into laptop(laptop_id,laptop_name,cost,Descr) values(@laptop_id,@laptop_name,@cost,@Descr)", cn);
            cmdInsert.Parameters.AddWithValue("@laptop_id", school.laptop_id);
            cmdInsert.Parameters.AddWithValue("@laptop_name", school.laptop_name);
            cmdInsert.Parameters.AddWithValue("@cost", school.Cost);
            cmdInsert.Parameters.AddWithValue("@Descr", school.Descr);




            cn.Open();
            int i = cmdInsert.ExecuteNonQuery();

            bool status = false;

            if (i == 1)
            {
                status = true;
            }

            cn.Close();//finally
            cn.Dispose();//finally
            return status;



        }
        public bool Update(Laptop school)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-LUAVTH3;Initial Catalog=Ecommerce;Integrated Security=True");


            SqlCommand cmdUpdate = new SqlCommand("[dbo].[Update]", cn);

            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdUpdate.Parameters.AddWithValue("@p_id", school.laptop_id);
            cmdUpdate.Parameters.AddWithValue("@p_name", school.laptop_name);
            cmdUpdate.Parameters.AddWithValue("@p_cost", school.Cost);
            cmdUpdate.Parameters.AddWithValue("@p_des", school.Descr);

            cn.Open();
            int s = cmdUpdate.ExecuteNonQuery();
            bool statusd = false;
            if (s == 1)
            {
                statusd = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return statusd;

        }

        public Laptop Find(int id)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-LUAVTH3;Initial Catalog=Ecommerce;Integrated Security=True");

            SqlCommand cmdSelect = new SqlCommand("[dbo].sp_Find", cn);
            cmdSelect.CommandType = System.Data.CommandType.StoredProcedure;
            cmdSelect.Parameters.AddWithValue("@p_id", id);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@p_name";
            p1.SqlDbType = System.Data.SqlDbType.NVarChar;
            p1.Size = 10;
            p1.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p1);


            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@p_cost";
            p2.SqlDbType = System.Data.SqlDbType.Int;
            p2.Size = 20;
            p2.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p2);



            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@p_des";
            p3.SqlDbType = System.Data.SqlDbType.NVarChar;
            p3.Size = 120;
            p3.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p3);


            cn.Open();
            cmdSelect.ExecuteNonQuery();

            Laptop found = new Laptop();

            found.laptop_name = p1.Value.ToString();
            found.Cost = Convert.ToInt32(p2.Value);
            found.Descr = p3.Value.ToString();





            cn.Close();
            cn.Dispose();


            return found;



        }
        public List<Laptop> List()
        {

            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-LUAVTH3;Initial Catalog=Ecommerce;Integrated Security=True");


            SqlCommand cmdlist = new SqlCommand("select laptop_id,laptop_name,cost,Descr from laptop", cn);

            cn.Open();
            SqlDataReader dr = cmdlist.ExecuteReader();
            List<Laptop> emplist = new List<Laptop>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Laptop bal = new Laptop();
                    bal.laptop_id = Convert.ToInt32(dr["laptop_id"]);
                    bal.laptop_name = dr["laptop_name"].ToString();
                    bal.Cost = Convert.ToInt32(dr["cost"]);
                    bal.Descr = dr["Descr"].ToString();

                    emplist.Add(bal);
                }
            }
            cn.Close();
            cn.Dispose();
            return emplist;

        }
        public bool Delete(int stuid)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-LUAVTH3;Initial Catalog=Ecommerce;Integrated Security=True");

            SqlCommand cmdDelete = new SqlCommand("[dbo].sp_Delete", cn);
            cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;
            cmdDelete.Parameters.AddWithValue("@p_id", stuid);
            cn.Open();
            int i = cmdDelete.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;

        }
    }
}
