public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] r = new int[m+n];
        
        int i=0,j=0,k=0;
        
        while(i<m && j< n )
        {
            if(nums1[i]<= nums2[j])
            {
                r[k]=nums1[i];
                k++;
                i++;
                
            }
            else{
                r[k]=nums2[j];
                k++;
                j++;
            }
        }
        
        while(i<m)
        {
            r[k]=nums1[i];
            i++;
            k++;
            
        }
        while(j<n)
        {
            r[k]=nums2[j];
            j++;
            k++;
        }
        
        Array.Copy(r,nums1,m+n);
    }
}