package demo34;

import java.util.ArrayList;
import java.util.List;

public class Answer34 {
}

class TreeNode {
    int val;
    TreeNode left;
    TreeNode right;
    TreeNode() {}
    TreeNode(int val) { this.val = val; }
    TreeNode(int val, TreeNode left, TreeNode right) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

class Solution34 {
    private  List<List<Integer>> result = new ArrayList<>();
    private List<Integer> path = new ArrayList<>();

    public List<List<Integer>> pathSum(TreeNode root, int target) {
        getResult(root, target, 0);
        return result;
    }

    public void getResult(TreeNode node, int target, int sum){
        sum += node.val;
        path.add(node.val);

        if(node.left == null && node.right == null){
            if(sum == target){
                result.add(new ArrayList<>(path));
            }
        }

        else{
            if(node.left != null){
                getResult(node.left, target, sum);
            }
            if(node.right != null){
                getResult(node.right, target, sum);
            }
        }

        path.remove(path.size() - 1);
    }
}
