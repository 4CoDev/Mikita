using System;

namespace Mikita.Observation;

public static class BackCallingAssign
	{
		public static void AssignTo<T>
			(
				this T value,
				ref T field,
				Action then
			)
			{
				field = value;
				then();
			}
	}