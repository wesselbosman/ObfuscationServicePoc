using System;

namespace ObfuscationServicePoc
{
	public static class PatientCollectionObfuscationStrategy
	{
		public static Patient Obfuscate(Patient patient)
		{
			patient.Age = -1;
			patient.Name = Guid.NewGuid().ToString("N");
			patient.DateOfBirth = DateTime.MinValue;

			return patient;
		}
	}
}