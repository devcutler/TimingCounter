namespace TimingCounter;

public class Counter(int sampleCount)
{
	private readonly FixedSizeQueue<TimeSpan> Times = new(sampleCount);

	public void Tick(TimeSpan timeSpan)
	{
		Times.Enqueue(timeSpan);
	}

	public TimeSpan Average()
	{
		return TimeSpan.FromMilliseconds(Times.Select(timespan => timespan.TotalMilliseconds).Average());
	}

	public double Per(TimeSpan timeSpan)
	{
		return (int)(timeSpan / Average());
	}

	private static readonly TimeSpan Second = TimeSpan.FromSeconds(1);
	public double PerSecond()
	{
		return Per(Second);
	}
}