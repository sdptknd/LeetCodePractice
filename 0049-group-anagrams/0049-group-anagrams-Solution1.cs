public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var mappings = new Dictionary<string, IList<string>>();

        foreach(var str in strs){
            var chars = str.ToCharArray();
            Array.Sort(chars);
            var sortedString = new String(chars);
            if(!mappings.ContainsKey(sortedString)) mappings.Add(sortedString, new List<string>());
            mappings[sortedString].Add(str);
        }

        return mappings.Values.ToList();
    }
}