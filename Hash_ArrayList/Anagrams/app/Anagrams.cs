namespace app;
public class Anagrams {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            char[] chars = strs[i].ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);

            if(groups.ContainsKey(sorted)) {
                groups[sorted].Add(strs[i]);
            } 
            else {
                groups.Add(sorted, new List<string>() {strs[i]} );
            }
        }

        return groups.Values.ToList();
    }
}