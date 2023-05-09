namespace BlazorApp.Data
{
	public class CounterService : ServiceNotifyChange, IService
	{
		public CounterService()
		{
            string folder = @"C:\test\";
            string fileName = "count.txt";
            string fullPath = folder + fileName;

			try
			{
                string readText = File.ReadAllText(fullPath);
                CurrentCount = Int32.Parse(readText);
            } catch (Exception ex)
			{

			}
		}

        private int currentCount;
		public int CurrentCount 
		{ 
			get { return currentCount; } 
			set
			{
				currentCount = value;
				NotifyDataChanged();
			}
		}

		public void Save()
		{
			string folder = @"C:\test\";
			string fileName = "count.txt";
			string fullPath = folder + fileName;
			using (StreamWriter writer = new StreamWriter(fullPath))
			{
				writer.WriteLine(CurrentCount.ToString());
			}
		}
 	}
}
