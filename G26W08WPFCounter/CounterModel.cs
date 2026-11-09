namespace G26W08WPFCounter;

public class CounterModel
{
    public int Count { get; private set; } = 0;

    public int Increment() => ++Count;

    public int Decrement()
    {
        if (Count > 0) Count--;
        return Count;
    }
}
