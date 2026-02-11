public class MedianFinder {

    private readonly PriorityQueue<int, int> leftQueue;
    private readonly PriorityQueue<int, int> rightQueue;

    public MedianFinder() {
        leftQueue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        rightQueue = new PriorityQueue<int, int>();
    }
    
    public void AddNum(int num) {
        leftQueue.Enqueue(num, num);

        var maxFromLeft = leftQueue.Dequeue();
        rightQueue.Enqueue(maxFromLeft, maxFromLeft);

        if(rightQueue.Count > leftQueue.Count){
            var minFromRight = rightQueue.Dequeue();
            leftQueue.Enqueue(minFromRight, minFromRight);
        }
    }
    
    public double FindMedian() {
        if(leftQueue.Count > rightQueue.Count) return leftQueue.Peek();
        return ((double)leftQueue.Peek() + rightQueue.Peek()) / 2;
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */