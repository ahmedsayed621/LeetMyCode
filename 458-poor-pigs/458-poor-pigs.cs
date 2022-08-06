public class Solution {
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest) {
        var n = minutesToTest / minutesToDie +1;
        var x = Math.Log(buckets, n);
        return (int) Math.Ceiling(x);
    }
}