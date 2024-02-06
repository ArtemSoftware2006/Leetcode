using app;

namespace test;

public class UnitTest1
{
    [Fact]
    public void FindTopKFrequent_sevenWords_kIsTwo_iAndLove()
    {
        string[] words = ["i","love","leetcode","i","love","coding"];
        int k = 2;

        string[] expect = {"i", "love"};

        string[] result = TopKFrequrntWords.FindTopKFrequent(words, k);

        Assert.Equal(expect, result);
    }

     [Fact]
    public void FindTopKFrequent_sevenWords_kIsThree_iAndLoveAndCoding()
    {
        string[] words = ["i","love","leetcode","i","love","coding"];
        int k = 3;

        string[] expect = {"i", "love", "coding"};

        string[] result = TopKFrequrntWords.FindTopKFrequent(words, k);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void FindTopKFrequent_sevenWords_kIsOne_I()
    {
        string[] words = ["i","love","leetcode","i","love","coding"];
        int k = 1;

        string[] expect = {"i"};

        string[] result = TopKFrequrntWords.FindTopKFrequent(words, k);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void FindTopKFrequent_tenWords_kIsFour_theAndIsAndSunnyAndDat()
    {
        string[] words = ["the","day","is","sunny","the","the","the","sunny","is","is"];
        int k = 4;

        string[] expect =  {"the","is","sunny","day"};

        string[] result = TopKFrequrntWords.FindTopKFrequent(words, k);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void FindTopKFrequent_manyWord_kIsOne_jnoqzdute()
    {
        string[] words = ["plpaboutit","jnoqzdute","sfvkdqf","mjc","nkpllqzjzp","foqqenbey","ssnanizsav","nkpllqzjzp","sfvkdqf","isnjmy","pnqsz","hhqpvvt","fvvdtpnzx","jkqonvenhx","cyxwlef","hhqpvvt","fvvdtpnzx","plpaboutit","sfvkdqf","mjc","fvvdtpnzx","bwumsj","foqqenbey","isnjmy","nkpllqzjzp","hhqpvvt","foqqenbey","fvvdtpnzx","bwumsj","hhqpvvt","fvvdtpnzx","jkqonvenhx","jnoqzdute","foqqenbey","jnoqzdute","foqqenbey","hhqpvvt","ssnanizsav","mjc","foqqenbey","bwumsj","ssnanizsav","fvvdtpnzx","nkpllqzjzp","jkqonvenhx","hhqpvvt","mjc","isnjmy","bwumsj","pnqsz","hhqpvvt","nkpllqzjzp","jnoqzdute","pnqsz","nkpllqzjzp","jnoqzdute","foqqenbey","nkpllqzjzp","hhqpvvt","fvvdtpnzx","plpaboutit","jnoqzdute","sfvkdqf","fvvdtpnzx","jkqonvenhx","jnoqzdute","nkpllqzjzp","jnoqzdute","fvvdtpnzx","jkqonvenhx","hhqpvvt","isnjmy","jkqonvenhx","ssnanizsav","jnoqzdute","jkqonvenhx","fvvdtpnzx","hhqpvvt","bwumsj","nkpllqzjzp","bwumsj","jkqonvenhx","jnoqzdute","pnqsz","foqqenbey","sfvkdqf","sfvkdqf"];

        int k = 1;

        string[] expect =  {"jnoqzdute"};

        string[] result = TopKFrequrntWords.FindTopKFrequent(words, k);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void FindTopKFrequentList_manyWord_kIsOne_jnoqzdute()
    {
        string[] words = ["plpaboutit","jnoqzdute","sfvkdqf","mjc","nkpllqzjzp","foqqenbey","ssnanizsav","nkpllqzjzp","sfvkdqf","isnjmy","pnqsz","hhqpvvt","fvvdtpnzx","jkqonvenhx","cyxwlef","hhqpvvt","fvvdtpnzx","plpaboutit","sfvkdqf","mjc","fvvdtpnzx","bwumsj","foqqenbey","isnjmy","nkpllqzjzp","hhqpvvt","foqqenbey","fvvdtpnzx","bwumsj","hhqpvvt","fvvdtpnzx","jkqonvenhx","jnoqzdute","foqqenbey","jnoqzdute","foqqenbey","hhqpvvt","ssnanizsav","mjc","foqqenbey","bwumsj","ssnanizsav","fvvdtpnzx","nkpllqzjzp","jkqonvenhx","hhqpvvt","mjc","isnjmy","bwumsj","pnqsz","hhqpvvt","nkpllqzjzp","jnoqzdute","pnqsz","nkpllqzjzp","jnoqzdute","foqqenbey","nkpllqzjzp","hhqpvvt","fvvdtpnzx","plpaboutit","jnoqzdute","sfvkdqf","fvvdtpnzx","jkqonvenhx","jnoqzdute","nkpllqzjzp","jnoqzdute","fvvdtpnzx","jkqonvenhx","hhqpvvt","isnjmy","jkqonvenhx","ssnanizsav","jnoqzdute","jkqonvenhx","fvvdtpnzx","hhqpvvt","bwumsj","nkpllqzjzp","bwumsj","jkqonvenhx","jnoqzdute","pnqsz","foqqenbey","sfvkdqf","sfvkdqf"];

        int k = 1;

        IList<string> expect = new List<string>() {"jnoqzdute"};

        IList<string> result = TopKFrequrntWords.TopKFrequentList(words, k);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void FindTopKFrequentPriorityQueue_sevenWords_kIsTwo_iAndLove()
    {
        string[] words = ["i","love","leetcode","i","love","coding"];
        int k = 2;

        string[] expect = {"i", "love"};

        string[] result = TopKFrequrntWords.TopKFrequentPriorityQueueWithCompare(words, k);

        Assert.Equal(expect, result);
    }

     [Fact]
    public void FindTopKFrequentPriorityQueue_sevenWords_kIsThree_iAndLoveAndCoding()
    {
        string[] words = ["i","love","leetcode","i","love","coding"];
        int k = 3;

        string[] expect = {"i", "love", "coding"};

        string[] result = TopKFrequrntWords.TopKFrequentPriorityQueueWithCompare(words, k);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void FindTopKFrequentPriorityQueue_sevenWords_kIsOne_I()
    {
        string[] words = ["i","love","leetcode","i","love","coding"];
        int k = 1;

        string[] expect = {"i"};

        string[] result = TopKFrequrntWords.TopKFrequentPriorityQueueWithCompare(words, k);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void FindTopKFrequentPriorityQueue_tenWords_kIsFour_theAndIsAndSunnyAndDat()
    {
        string[] words = ["the","day","is","sunny","the","the","the","sunny","is","is"];
        int k = 4;

        string[] expect =  {"the","is","sunny","day"};

        string[] result = TopKFrequrntWords.TopKFrequentPriorityQueueWithCompare(words, k);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void FindTopKFrequentPriorityQueue_manyWord_kIsOne_jnoqzdute()
    {
        string[] words = ["plpaboutit","jnoqzdute","sfvkdqf","mjc","nkpllqzjzp","foqqenbey","ssnanizsav","nkpllqzjzp","sfvkdqf","isnjmy","pnqsz","hhqpvvt","fvvdtpnzx","jkqonvenhx","cyxwlef","hhqpvvt","fvvdtpnzx","plpaboutit","sfvkdqf","mjc","fvvdtpnzx","bwumsj","foqqenbey","isnjmy","nkpllqzjzp","hhqpvvt","foqqenbey","fvvdtpnzx","bwumsj","hhqpvvt","fvvdtpnzx","jkqonvenhx","jnoqzdute","foqqenbey","jnoqzdute","foqqenbey","hhqpvvt","ssnanizsav","mjc","foqqenbey","bwumsj","ssnanizsav","fvvdtpnzx","nkpllqzjzp","jkqonvenhx","hhqpvvt","mjc","isnjmy","bwumsj","pnqsz","hhqpvvt","nkpllqzjzp","jnoqzdute","pnqsz","nkpllqzjzp","jnoqzdute","foqqenbey","nkpllqzjzp","hhqpvvt","fvvdtpnzx","plpaboutit","jnoqzdute","sfvkdqf","fvvdtpnzx","jkqonvenhx","jnoqzdute","nkpllqzjzp","jnoqzdute","fvvdtpnzx","jkqonvenhx","hhqpvvt","isnjmy","jkqonvenhx","ssnanizsav","jnoqzdute","jkqonvenhx","fvvdtpnzx","hhqpvvt","bwumsj","nkpllqzjzp","bwumsj","jkqonvenhx","jnoqzdute","pnqsz","foqqenbey","sfvkdqf","sfvkdqf"];

        int k = 1;

        string[] expect =  {"jnoqzdute"};

        string[] result = TopKFrequrntWords.TopKFrequentPriorityQueueWithCompare(words, k);

        Assert.Equal(expect, result);
    }

}