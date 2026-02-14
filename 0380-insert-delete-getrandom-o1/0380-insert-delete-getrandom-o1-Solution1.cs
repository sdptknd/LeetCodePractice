public class RandomizedSet {

    private readonly Dictionary<int, int> elementIndex = new Dictionary<int, int>();
    private readonly List<int> elements = new List<int>();
    private readonly Random random = new Random();

    public RandomizedSet() {
        
    }
    
    public bool Insert(int val) {
        if(elementIndex.ContainsKey(val)) return false;
        elementIndex.Add(val, elements.Count);
        elements.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if(!elementIndex.ContainsKey(val)) return false;
        var lastVal = elements[elements.Count - 1];
        elements[elementIndex[val]] = lastVal;
        elementIndex[lastVal] = elementIndex[val];
        elements.RemoveAt(elements.Count - 1);
        elementIndex.Remove(val);
        return true;
    }
    
    public int GetRandom() {
        int index = random.Next(0, elements.Count);
        return elements[index];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */