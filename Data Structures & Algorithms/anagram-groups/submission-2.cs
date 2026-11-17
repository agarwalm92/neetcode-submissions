public class Solution {
     public List<List<string>> GroupAnagrams(string[] strs) {
        // 1. Pre-size the dictionary to avoid slow internal resizing
        var groups = new Dictionary<string, List<string>>(strs.Length);

        foreach (string word in strs) {
            // 2. Sort the word's letters to create a shared anagram key
            char[] letters = word.ToCharArray();
            Array.Sort(letters);
            string key = new string(letters);

            // 3. Look up the group once; create it if this is the first match
            if (!groups.TryGetValue(key, out var list)) {
                list = [];
                groups[key] = list;
            }

            // 4. Add the original word to its anagram group
            list.Add(word);
        }

        // 5. Return all grouped lists
        return [.. groups.Values];
    }
}
