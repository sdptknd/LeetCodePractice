public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        var result = new List<string>();
        BackTrack(s, 0, 4, new List<string>(), result);
        return result;
    }

    public void BackTrack(string s, int indx, int remaining, IList<string> curr, IList<string> result){
        // Console.WriteLine($"curr: {string.Join('.', curr)}, remaining: {remaining}, indx: {indx}");
        if(remaining == 0){
            if(indx == s.Length)
                result.Add(string.Join('.', curr));
            return;
        }

        if(indx >= s.Length) return;

        var part = s[indx].ToString();
        curr.Add(part);
        BackTrack(s, indx+1, remaining-1, curr, result);
        curr.RemoveAt(curr.Count-1);

        if(part == "0" || indx == s.Length-1) return;

        part += s[indx+1];
        curr.Add(part);
        BackTrack(s, indx+2, remaining-1, curr, result);
        curr.RemoveAt(curr.Count-1);

        if(indx == s.Length - 2 || string.Compare(part, "25") > 0 || (part == "25" && s[indx+2] > '5')) return;

        part += s[indx+2];
        curr.Add(part);
        BackTrack(s, indx+3, remaining-1, curr, result);
        curr.RemoveAt(curr.Count-1);
    }
}