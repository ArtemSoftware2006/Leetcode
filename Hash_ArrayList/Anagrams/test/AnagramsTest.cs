using app;

namespace test;

public class AnagramsTest
{
    [Fact]
    public void Test()
    {
        Anagrams service = new Anagrams();

        string[] strings = new string[] {
            "eat","tea","tan","ate","nat","bat"
        };

        var result = service.GroupAnagrams(strings);

        Assert.Equal(3, result.Count);
        Assert.Contains(new List<string>{"bat"}, result);
        Assert.Contains(new List<string>{"tan", "nat"}, result);
        Assert.Contains(new List<string>{"eat", "tea", "ate"}, result);
    }
}