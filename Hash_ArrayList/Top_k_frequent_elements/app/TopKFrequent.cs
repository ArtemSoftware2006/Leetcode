namespace app;
public class TopKFrequentHandler
{
    //My Variant
    public int[] TopKFrequent(int[] nums, int k) {
        var numbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)  {
            if (numbers.ContainsKey(nums[i]))
            {
                numbers[nums[i]]++;
            }
            else 
            {
                numbers.Add(nums[i], 1);
            }
        }

        return numbers.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
    }
    //Priority Queue variant
    public int[] TopKFrequent2(int[] nums, int k) {
        var numbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)  {
            if (numbers.ContainsKey(nums[i]))
            {
                numbers[nums[i]]++;
            }
            else 
            {
                numbers.Add(nums[i], 1);
            }
        }

        PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

        foreach(int key in numbers.Keys) {
            priorityQueue.Enqueue(key, numbers[key]);
            if (priorityQueue.Count > k)
            {
                priorityQueue.Dequeue();
            }
        }

        int[] result = new int[k];
        for (int i = k - 1; i >= 0; i--)
        {
            result[i] = priorityQueue.Dequeue();
        }

        return result;
    }
    //Bucket sort variant
    public int[] TopKFrequent3(int[] nums, int k) {
        var numbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)  {
            if (numbers.ContainsKey(nums[i]))
            {
                numbers[nums[i]]++;
            }
            else 
            {
                numbers.Add(nums[i], 1);
            }
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach (var key in numbers.Keys)
        {
            int count = numbers[key];
            if (buckets[count] == null)
            {
                buckets[count] = new List<int>();
            }
            buckets[count].Add(key);
        }

        List<int> result = new List<int>();

        for (int i = buckets.Length - 1; i > result.Count && i >= 0; i--)
        {
            if (buckets[i] != null)
            {
                result.AddRange(buckets[i]);
            }
        }

        return result.ToArray();
    }

    //linq variant
    public int[] TopKFrequent4(int[] nums, int k) {
       return nums
       .GroupBy(x => x)
       .OrderByDescending(x => x.Count())
       .Take(k)
       .Select(x => x.Key)
       .ToArray();
    }
}
