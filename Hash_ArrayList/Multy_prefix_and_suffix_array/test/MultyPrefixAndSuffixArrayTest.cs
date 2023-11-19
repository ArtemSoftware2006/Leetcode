using System.Diagnostics.CodeAnalysis;
using app;

namespace test;

public class MultyPrefixAndSuffixArrayTest
{
    private MultyPrefixAndSuffixArray service = new MultyPrefixAndSuffixArray();

    [Fact]
    public void Test()
    {
        int[] nums = { 1, 2, 3, 4 };
        int[] expected = { 24, 12, 8, 6 };

        int[] result = service.ProductExceptSelf(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestWithZero()
    {
        int[] nums = { -1, 1, 0, -3, 3 };
        int[] expected = { 0, 0, 9, 0, 0 };

        int[] result = service.ProductExceptSelf(nums);

        Assert.Equal(expected, result);
    }
    [Fact]
    public void RigthAndKeft_1234()
    {
        int[] nums = { 1, 2, 3, 4 };
        int[] expected = { 24, 12, 8, 6 };

        int[] result = service.RigthAnfLeftWay(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void RigthAndLeft_withNull()
    {
        int[] nums = { -1, 1, 0, -3, 3 };
        int[] expected = { 0, 0, 9, 0, 0 };

        int[] result = service.RigthAnfLeftWay(nums);

        Assert.Equal(expected, result);
    }
}
