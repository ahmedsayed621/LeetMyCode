public class NumArray {
private readonly SegmentTree st;

    public NumArray(int[] nums) {
        st = new SegmentTree(nums, 0, nums.Length > 0 ? nums.Length - 1 : 0);
    }
    
    public void Update(int i, int val) {
        st.UpdateSegmentAtIndex(i, val);
    }
    
    public int SumRange(int i, int j) {
        return st.FindRangeSum(i, j);
    }
}

/// <summary>
/// Segment Tree
/// </summary>
public class SegmentTree
{
    private readonly int[] _elements;
    private readonly int _leftMostIndex;
    private readonly int _rightMostIndex;

    private readonly SegmentTree _leftSubTree;
    private readonly SegmentTree _rightSubTree;

    // Store here additional properties of the Segment Tree
    public int RangeSum { get; private set; }

    /// <summary>
    /// Construction of the SegmentTree
    /// </summary>
    /// <param name="elements"></param>
    /// <param name="leftMostIndex"></param>
    /// <param name="rightMostIndex"></param>
    public SegmentTree(int[] elements, int leftMostIndex, int rightMostIndex)
    {
        this._elements = elements;
        this._leftMostIndex = leftMostIndex;
        this._rightMostIndex = rightMostIndex;

        if (!IsLeafNode)
        {
            // Composite node
            var middleIndex = leftMostIndex + (rightMostIndex - leftMostIndex) / 2;
            _leftSubTree = new SegmentTree(elements, leftMostIndex, middleIndex);
            _rightSubTree = new SegmentTree(elements, middleIndex + 1, rightMostIndex);
        }

        CalculateRangeSum();
    }

    public bool IsLeafNode => _leftMostIndex == _rightMostIndex;

    public int FindRangeSum(int leftIndex, int rightIndex)
    {
        if (leftIndex == rightIndex) // Leaf node
        {
            return _elements[leftIndex];
        }

        // 3 cases:
        // 1. Disjoint sets
        if (rightIndex < _leftMostIndex || leftIndex > _rightMostIndex)
        {
            return 0;
        }

        // 2. Range covers this set
        if (leftIndex <= _leftMostIndex && rightIndex >= _rightMostIndex)
        {
            return RangeSum;
        }

        // 3. Overlap left or right / delegate to subtrees
        return _leftSubTree.FindRangeSum(leftIndex, rightIndex)
               + _rightSubTree.FindRangeSum(leftIndex, rightIndex);
    }

    public void UpdateSegmentAtIndex(int index, int val)
    {
        // Base Case
        if (IsLeafNode)
        {
            // Update the leaf sum with its new value
            RangeSum = val;

            // Leaf node can also be responsible for updating the inner array
            _elements[index] = val;

            return;
        }

        // Composite Node
        if (index <= _leftSubTree._rightMostIndex && index >= _leftSubTree._leftMostIndex)
        {
            _leftSubTree.UpdateSegmentAtIndex(index, val);
        }
        else
        {
            _rightSubTree.UpdateSegmentAtIndex(index, val);
        }

        // For each traversed node recalculate the segment sum following the child update
        CalculateRangeSum();
    }

    /// <summary>
    /// Re/Calculate the Range sum after the update of a child node
    /// </summary>
    private void CalculateRangeSum()
    {
        if (!_elements.Any())
        {
            return;
        }

        if (IsLeafNode)
        {
            // Leaf node
            RangeSum = _elements[_leftMostIndex];
        }
        else
        {
            // Composite node
            RangeSum = _leftSubTree.RangeSum + _rightSubTree.RangeSum;
        }
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */