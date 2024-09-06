using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

	//@PlaceNumber int,
	//@PlaceName nvarchar(50),
	//@PrizeAmount money,
	//@PrizePercentage float,
	//@id int = 0 output


namespace TrackerLibrary.DataAccess
{
	public class SqlConnector : IDataConnection
	{
		///TODO - Make the create prize method to actually save to the database
		/// <summary>
		/// Saves a new prize to the database
		/// </summary>
		/// <param name="model">The prize information</param>
		/// <returns>The prize information, including the unique identifier</returns>
		public PrizeModel CreatePrize(PrizeModel model)

		{

			try
			{
				using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
				{
					var p = new DynamicParameters();
					p.Add("@PlaceNumber", model.PlaceNumber);
					p.Add("@PlaceName", model.PlaceName);
					p.Add("@PrizeAmount", model.PrizeAmount);
					p.Add("@PrizePercentage", model.PrizePercentage);
					p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);

					connection.Execute("dbo.spPrizes_Insert", p, CommandType: CommandType.StoredProcedure);

					model.Id = p.Get<int>("@id");

					return model;
				}
			}
			catch (Exception ex)
			{
				// Log the exception (you can log it to a file, database, etc.)
				Console.WriteLine($"An error occurred: {ex.Message}");
				// Optionally rethrow the exception if you want it to propagate further
				throw;
			}

		}

	
	}

	
}
