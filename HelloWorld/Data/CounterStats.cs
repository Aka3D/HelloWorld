namespace HelloWorld.Data
{
    public class CounterState
    {
        public EventHandler<int> CounterChanged { get; set; }
        public int count { get; private set; } = 0;

        public void UpdateCounter()
        {
            count++;
            CounterChanged.Invoke(this, count);
        }
    }
}