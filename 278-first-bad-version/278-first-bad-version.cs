/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int start = 1;
        int end = n;
        int sni = 1;
        
        while(start<=end)
        {
            int mid = start+(end-start)/2;
            bool bad = IsBadVersion(mid);
            if(bad==true)
            {
                sni=mid;
                end=mid-1;
            }
            if(bad==false)
                start = mid+1;
            else
                end=mid-1;
            
        }
        return sni;
    }
}