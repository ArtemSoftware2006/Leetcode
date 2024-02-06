namespace app;

public class TopKFrequrntWords
{
    //Нельзя пройти тест FindTopKFrequent_sevenWords_kIsOne_I
    public static string[] FindTopKFrequentPriorityQueue(string[] words, int k) {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++) {
            if (dict.ContainsKey(words[i])) {
                dict[words[i]]++;
            } else {
                dict.Add(words[i], 1);
            }
        }

        PriorityQueue<KeyValuePair<string, int>, int> queue = new PriorityQueue<KeyValuePair<string, int>, int>(k);

        for (int i = 0; i < dict.Count; i++)
        {
            queue.Enqueue(new KeyValuePair<string, int>(dict.ElementAt(i).Key, dict.ElementAt(i).Value), dict.ElementAt(i).Value);
            if (queue.Count > k)
            {
                queue.Dequeue();
            }
        }

        List<KeyValuePair<int, List<string>>> result = new List<KeyValuePair<int, List<string>>>(k);

        KeyValuePair<string, int> value = queue.Dequeue();

        result.Add(new KeyValuePair<int, List<string>>(value.Value, new List<string>(){value.Key}));

        for (int i = 1; i > k; i++)
        {
            value = queue.Dequeue();

            if (value.Value == result.Last().Key)
            {
                result.Last().Value.Add(value.Key);
            } 
            else {
                result.Add(new KeyValuePair<int, List<string>>(value.Value, new List<string>(){value.Key}));
            }
        }

        result.ForEach(x => x.Value.Sort());
        List<string> resultArray = new List<string>(k);

        for (int i = result.Count - 1; i >= 0; i--)
        {
            resultArray = resultArray.Concat(result[i].Value).ToList();
        }

        return resultArray.ToArray();
    }

    public static string[] FindTopKFrequent(string[] words, int k) {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++) {
            if (dict.ContainsKey(words[i])) {
                dict[words[i]]++;
            } else {
                dict.Add(words[i], 1);
            }
        }

        List<KeyValuePair<int, List<string>>> result = new List<KeyValuePair<int, List<string>>>(k);

        KeyValuePair<string, int> value = new KeyValuePair<string, int>(dict.ElementAt(0).Key, dict.ElementAt(0).Value);
        result.Add(new KeyValuePair<int, List<string>>(value.Value, new List<string>(){value.Key}));

        for (int i = 1; i < dict.Count; i++)
        {
            value = new KeyValuePair<string, int>(dict.ElementAt(i).Key, dict.ElementAt(i).Value);
            
            if (value.Value == result.Last().Key)
            {
                result.Last().Value.Add(value.Key);
            } 
            else {
                result.Add(new KeyValuePair<int, List<string>>(value.Value, new List<string>(){value.Key}));
            }
        }

        result = result.OrderByDescending(x => x.Key).ToList();
        result.ForEach(x => x.Value.Sort());
        List<string> resultArray = new List<string>();

        for (int i = 0; i < result.Count; i++)
        {
            resultArray.AddRange(result[i].Value);
        }

        return resultArray.Take(k).ToArray();
    }

    public static IList<string> TopKFrequentList(string[] words, int k) {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++) {
            if (dict.ContainsKey(words[i])) {
                dict[words[i]]++;
            } else {
                dict.Add(words[i], 1);
            }
        }

        List<KeyValuePair<int, List<string>>> result = new List<KeyValuePair<int, List<string>>>(k);

        KeyValuePair<string, int> value = new KeyValuePair<string, int>(dict.ElementAt(0).Key, dict.ElementAt(0).Value);
        result.Add(new KeyValuePair<int, List<string>>(value.Value, new List<string>(){value.Key}));

        for (int i = 1; i < dict.Count; i++)
        {
            value = new KeyValuePair<string, int>(dict.ElementAt(i).Key, dict.ElementAt(i).Value);
            
            if (value.Value == result.Last().Key)
            {
                result.Last().Value.Add(value.Key);
            } 
            else {
                result.Add(new KeyValuePair<int, List<string>>(value.Value, new List<string>(){value.Key}));
            }
        }

        result = result.OrderByDescending(x => x.Key).ToList();
        result.ForEach(x => x.Value.Sort());
        List<string> resultArray = new List<string>();

        for (int i = 0; i < result.Count; i++)
        {
            resultArray.AddRange(result[i].Value);
        }

        return resultArray.Take(k).ToList();
    }

    public static IList<string> TopKFrequentLINQ(string[] words, int k) {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++) {
            if (dict.ContainsKey(words[i])) {
                dict[words[i]]++;
            } else {
                dict[words[i]] = 0;
            }
        }

        return dict
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .Take(k)
            .Select(x => x.Key)
            .ToList();
    }

    public static IList<string> TopKFrequentList2(string[] words, int k) {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++) {
            if (dict.ContainsKey(words[i])) {
                dict[words[i]]++;
            } else {
                dict.Add(words[i], 1);
            }
        }

        var freq = dict.ToList();

        freq.Sort((p1, p2) => {
            if (p2.Value - p1.Value == 0)
            {
                return String.Compare(p1.Key, p2.Key);
            }
            return p2.Value - p1.Value;
        }); 

        List<string> result = new List<string>();
        result = freq.Take(k).Select(x => x.Key).ToList();

        return result; 
    }

    //В PriotityQueue можно добавить Компоратор)))
    public static string[] TopKFrequentPriorityQueueWithCompare(string[] words, int k) {
        Dictionary<string, int> frequencyMap = new Dictionary<string, int>();
        
        foreach(string word in words) {
            if(!frequencyMap.ContainsKey(word)) {
                frequencyMap[word] = 0;
            }
            frequencyMap[word]++;
        }
        
        PriorityQueue<string, KeyValuePair<string, int>> maxHeap = new(new NameComparer());
        
        foreach(KeyValuePair<string, int> entry in frequencyMap)
        {
           maxHeap.Enqueue(entry.Key, entry);
        }

        List<string> result = new List<string>();
        
        while(k > 0 && maxHeap.Count > 0) {
            string word = maxHeap.Dequeue();
            result.Add(word);
            k--;        
        }   
        
        return result.ToArray();
    }
    
    public class NameComparer: IComparer<KeyValuePair<string, int>>
	{
		public int Compare(KeyValuePair<string, int> x, KeyValuePair<string,int> y) => 
			(x.Value == y.Value) ? (x.Key.CompareTo(y.Key)) : (y.Value-x.Value);
	}
}

