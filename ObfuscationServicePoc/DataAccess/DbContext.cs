using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ObfuscationServicePoc
{
	public class DbContext
	{
		public IEnumerable<T> ExecuteStoredProcedure<T>(string storedProcName, params SqlParameter[] sqlParameters) where T: Patient, new()
		{
			var list = new List<T>
			{
				new T{
					Age = 12,
					DateOfBirth = DateTime.UtcNow,
					Name = "Andrew Ross"
				},
				new T
				{
					Age = 99,
					DateOfBirth = DateTime.UtcNow,
					Name = "Derpy McDerpface"
				},
				new T
				{
					Age = 6,
					DateOfBirth = DateTime.UtcNow,
					Name = "Lazola Sifuba"
				}
			};

			return list;
		}
	}
}