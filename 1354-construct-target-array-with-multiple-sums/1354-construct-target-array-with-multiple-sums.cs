public class Solution {
    public bool IsPossible(int[] target) {
        // Initialize the descending priority queue
        PriorityQueue<int, int> pq = 
            new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y-x));
        
        int sum = 0;
        
		// insert all elements from the target array into the priority queue
		// initialize sum to be the total value of the target array
        for (int i=0; i < target.Count(); i++){
            sum += target[i];
            pq.Enqueue(target[i], target[i]);
        }
        
		// Stop condition for returning true is when the root value is equal 1
		// else we have to continuously loop and reduce values of the elements until it equals 1
		// or if the sum value dips below 1, or if num is less than the remaining sum 
        while(pq.Peek() != 1){
            int num = pq.Dequeue();
            sum -= num;
            if(num <= sum || sum < 1){
                return false;
            }
            // We use modulo in order to reduce the number of times we have to loop when the largest element in the queue is 
			// significantly larger than all other elements in the queue.
            num = num % sum;
            sum += num;
            int addNum = num > 0 ? num : sum;
			
			// Re-enter the number which the largest element was reduced to.
            pq.Enqueue(addNum, addNum);
        }
        
        return true;

    }
}