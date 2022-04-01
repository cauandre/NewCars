
using System.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCarsLib.DAO
{
    public  class CarDAO
    {
        readonly SqlConnection _connNewCars;

        public CarDAO(string connstring)
        {
            _connNewCars = new SqlConnection(connstring);
        }
        public void CarAdd(Car car)
        {
            try
            {
                _connNewCars.Open();
                SqlCommand cmdsql;
                cmdsql = new SqlCommand("sp_car_create", _connNewCars)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmdsql.Parameters.Add(new SqlParameter("@color",car.Color));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
