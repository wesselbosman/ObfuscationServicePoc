using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ObfuscationServicePoc
{
	public static class PatientStoredprocedureExtensions
	{
		public static IEnumerable<Patient> GetPatients(this DbContext dbContext)
		{
			var result = dbContext.ExecuteStoredProcedure<Patient>("fakeProc", new SqlParameter("@Derp", DBNull.Value));

			return result;
		}
	}
}