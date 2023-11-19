using app;

namespace test;

public class TopKFrequentTest
{
    [Fact]
    public void Test()
    {
        TopKFrequentHandler topK = new TopKFrequentHandler();

        int[] nums = new int[] {4,1,-1,2,-1,2,3};
        int k = 2;

        int[] result = topK.TopKFrequent(nums, k);

        Assert.Equal(new int[] {-1,2}, result);
    }
     [Fact]
     public void Test2()
    {
        TopKFrequentHandler topK = new TopKFrequentHandler();

        int[] nums = new int[] {4,1,-1,2,-1,2,3};
        int k = 2;
        var expected = new int[] {-1, 2};

        int[] result = topK.TopKFrequent2(nums, k);

        Assert.Equal(expected, result);
    }
     [Fact]
     public void Test3()
    {
        TopKFrequentHandler topK = new TopKFrequentHandler();

        int[] nums = new int[] {4,1,-1,2,-1,2,3};
        int k = 2;
        var expected = new int[] {-1, 2};

        int[] result = topK.TopKFrequent3(nums, k);

        Assert.Equal(expected, result);
    }
     [Fact]
     public void Test4()
    {
        TopKFrequentHandler topK = new TopKFrequentHandler();

        int[] nums = new int[] {4,1,-1,2,-1,2,3};
        int k = 2;
        var expected = new int[] {-1, 2};

        int[] result = topK.TopKFrequent4(nums, k);

        Assert.Equal(expected, result);
    }
}