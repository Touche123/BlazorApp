namespace BlazorApp.Data
{
    public class ServiceNotifyChange
    {
        public event Action OnChange;
        public void NotifyDataChanged() => OnChange?.Invoke();
    }
}
