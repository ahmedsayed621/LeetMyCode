public class Solution {
    
        public int ScheduleCourse(int[][] courses) {
        courses = courses.OrderBy(x => x[1]).ToArray();
        SortedDictionary<int, List<int[]>> dict = new();
        int totalDuration = 0, count = 0;
        
        for(int i=0; i<courses.Length; i++)
        {
            if(totalDuration + courses[i][0] <= courses[i][1])
            {
                totalDuration += courses[i][0];
                if(dict.ContainsKey(courses[i][0]))
                    dict[courses[i][0]].Add(courses[i]);
                else
                    dict.Add(courses[i][0], new List<int[]>() { courses[i] });
                count++;
            }
            else
            {
                totalDuration += courses[i][0];
                if(dict.ContainsKey(courses[i][0]))
                    dict[courses[i][0]].Add(courses[i]);
                else
                    dict.Add(courses[i][0], new List<int[]>() { courses[i] });
                
                var max = dict.Last().Value[dict.Last().Value.Count - 1];
                totalDuration -= max[0];
                dict.Last().Value.RemoveAt(dict.Last().Value.Count - 1);
                if(dict.Last().Value.Count() == 0)
                    dict.Remove(max[0]);
            }
        }
        
        return count;
    }
}