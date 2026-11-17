public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    { 
          var map = new Dictionary<string, List<string>>(strs.Length);

        foreach (string str in strs) {
            string key = string.Create(str.Length, str, static (span, source) => {
                source.CopyTo(span);
                span.Sort();
            });

            // Standard TryGetValue avoids double lookup and works everywhere
            if (!map.TryGetValue(key, out var group)) {
                group = [];
                map[key] = group;
            }

            group.Add(str);
        }

        return [.. map.Values];
    }
}
