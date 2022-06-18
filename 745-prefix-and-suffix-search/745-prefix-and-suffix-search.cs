public class WordFilter {
    public class TrieNode
    {
        public TrieNode[] Children = new TrieNode[27];
        public int Weight;
        
        public static void Insert(TrieNode root, string word, int weight)
        {
            string wrapped = word + "{" + word; //{ - 'a' = 27
            int end = wrapped.Length;
            for(int i=0; i<= word.Length; i++)
                insert(root, wrapped, i, end, weight);
        }
        
        private static void insert(TrieNode root, string word, int start, int end, int weight)
        {
            TrieNode node = root;
            for(int i=start; i<end; i++)
            {
                int index = word[i] - 'a';
                if(node.Children[index] == null)
                    node.Children[index] = new TrieNode();
                
                node = node.Children[index];
                node.Weight = weight;
            }
        }
        
        public static int Search(TrieNode root, string word)
        {
            TrieNode node = root;
            foreach(char c in word)
            {
                int index = c - 'a';
                if(node.Children[index] == null)
                    return -1;
                node = node.Children[index];
            }
            return node.Weight;
        }
    }
    
    TrieNode root;

    public WordFilter(string[] words) {
        root = new TrieNode();
        for(int i=0; i<words.Length; i++)
            TrieNode.Insert(root, words[i], i);
    }
    
    public int F(string prefix, string suffix) {
        TrieNode node = root;
        string searchWord = suffix + "{" + prefix;
        
        int weight = TrieNode.Search(node, searchWord);
        return weight;
    }
}

/**
 * Your WordFilter object will be instantiated and called as such:
 * WordFilter obj = new WordFilter(words);
 * int param_1 = obj.F(prefix,suffix);
 */