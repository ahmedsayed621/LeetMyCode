public class Solution {
    public int[][] ReconstructQueue(int[][] people) {
        List<int[]> res = new List<int[]>();
        
        var sortedPeople = people.ToList().OrderByDescending(x=>x[0]).ThenBy(x=>x[1]);        
        foreach(var p in sortedPeople)
            res.Insert(p[1], p);
        
        return res.ToArray();
    }
}


