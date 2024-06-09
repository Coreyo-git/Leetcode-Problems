public class LongestCommonPrefix {
    public string LongestCommonPrefix(string[] strs) {
        // return "" if empty array
        if(strs.Length == 0) return "";
        // return first word if only one exists
        if(strs.Length == 1) return strs[0];

        // set prefix as first word in the array
        string prefix = strs[0];

        // check other strings against first string from start to end?
        // loop through each string in array starting at 1 as to skip first
        // as it's already assigned as the prefix
        for(int i = 1; i < strs.Length; i++) 
        {   
            // if the prefix doesn't match the current string 
            // shave off by 1 till it does or 
            while(strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Remove(prefix.Length - 1);
            } 
        }
        return prefix;
    }
}