internal class FixedSizeQueue<T>(int size) : Queue<T>(size)
{
	private readonly int _size = size;

	public new void Enqueue(T item)
	{
		if (Count + 1 > _size)
		{
			Dequeue();
		}
		base.Enqueue(item);
	}
}