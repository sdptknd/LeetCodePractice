public class Solution {
    public string SimplifyPath(string path) {
        var pathStack = new Stack<string>();

        var curr = "";

        for(int i = 1; i < path.Length; i++){
            if(path[i] == '/'){
                // Console.WriteLine($"{i}: {curr}");
                if(!string.IsNullOrEmpty(curr)){
                    // Console.WriteLine($"{curr} is Not Null. {curr != "."} and {curr == ".."}");
                    if(curr == "..") {
                        if(pathStack.Count > 0) pathStack.Pop();
                    }
                    else if(curr != "."){
                        // Console.WriteLine($"Pushing {curr}");
                        pathStack.Push(curr);
                    }
                    curr = string.Empty;
                }
                continue;
            }
            curr += path[i];
        }

        if(!string.IsNullOrEmpty(curr)){
            if(curr == "..") {
                if(pathStack.Count > 0) pathStack.Pop();
            }
            else if(curr != "."){
                // Console.WriteLine($"Pushing {curr}");
                pathStack.Push(curr);
                curr = null;
            }
        }

        return "/" + string.Join('/', pathStack.Reverse());
    }
}