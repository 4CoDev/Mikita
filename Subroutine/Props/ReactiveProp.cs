namespace Mikita.Subroutine.Props;

public sealed class ReactiveProp<T>
	(
		Prop<T> origin,
		Action callback
	) : Prop<T>
	{
		public T Value
			{
				get => origin.Value;
				set
					{
						origin.Value = value;
						callback();
					}
			}
	}