public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
     if (nums1.Length > nums2.Length)
		return Intersect(nums2, nums1);

	var myDict = new Dictionary<int, int>();

	foreach (int n in nums1)
	{
		if (!myDict.ContainsKey(n)) myDict[n] = 0;
		myDict[n]++;
	}

	var result = new List<int>();
	foreach (int n in nums2)
	{
		if (myDict.ContainsKey(n) && myDict[n] > 0)
		{
			result.Add(n);
			myDict[n] --;
		}
	}
	return result.ToArray();
    }
}