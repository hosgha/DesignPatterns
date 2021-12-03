namespace ObjectPool
{
    public class ClinetClass
    {
        public int[] Nums { get; set; }
        public long GetValue(long i)
        {
            return Nums[i];
        }
        public ClinetClass()
        {
            Nums = new int[100000];
            Random rand = new Random();
            for (int i = 0; i < Nums.Length; i++)
                Nums[i] = rand.Next();
        }
    }
}
