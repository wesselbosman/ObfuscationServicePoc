using System;

namespace ObfuscationServicePoc
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var dbContext = new DbContext();

			var obfuscateResults = ObfuscatorService
				.ObfuscateResults(
					PatientStoredprocedureExtensions.GetPatients, 
					typeof(PatientCollectionObfuscationStrategy), 
					dbContext
				);

			foreach (var patient in obfuscateResults)
			{
				Console.WriteLine($"{patient.Name} - {patient.Age} - {patient.DateOfBirth}");
			}

			Console.ReadLine();
		}
	}
}
