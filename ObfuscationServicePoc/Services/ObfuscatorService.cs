using System;
using System.Collections.Generic;
using System.Linq;

namespace ObfuscationServicePoc
{
	public class ObfuscatorService
	{
		public static IEnumerable<T> ObfuscateResults<T>(Func<DbContext, IEnumerable<T>> dataAccessMethod, Type strategyType, DbContext dbContext)
		{
			var invoke = dataAccessMethod.Invoke(dbContext);

			var methodInfo = strategyType.GetMethod("Obfuscate");
			var obfuscationStrategy = (Func<T, T>)Delegate.CreateDelegate(typeof(Func<T, T>), methodInfo);

			return invoke.Select(x => obfuscationStrategy(x));
		}
	}
}