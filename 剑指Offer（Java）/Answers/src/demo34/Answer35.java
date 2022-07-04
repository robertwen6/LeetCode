package demo34;

import java.util.HashMap;
import java.util.Map;

public class Answer35 {
}

class Node {
    int val;
    Node next;
    Node random;

    public Node(int val) {
        this.val = val;
        this.next = null;
        this.random = null;
    }
}

/**
 *递归
 */
class Solution35One {
    Map<Node, Node> nodeHashMap = new HashMap<>();

    public Node copyRandomList(Node head) {
        if(head == null){
            return null;
        }

        if(!nodeHashMap.containsKey(head)){
            Node newNode = new Node(head.val);
            nodeHashMap.put(head, newNode);
            newNode.next = copyRandomList(head.next);
            newNode.random = copyRandomList(head.random);
        }

        return nodeHashMap.get(head);
    }
}

/**
 *复制拆分
 */
class Solution35Two {
    public Node copyRandomList(Node head) {
        if (head == null) {
            return null;
        }
        for (Node node = head; node != null; node = node.next.next) {
            Node nodeNew = new Node(node.val);
            nodeNew.next = node.next;
            node.next = nodeNew;
        }
        for (Node node = head; node != null; node = node.next.next) {
            Node nodeNew = node.next;
            nodeNew.random = (node.random != null) ? node.random.next : null;
        }
        Node headNew = head.next;
        for (Node node = head; node != null; node = node.next) {
            Node nodeNew = node.next;
            node.next = node.next.next;
            nodeNew.next = (nodeNew.next != null) ? nodeNew.next.next : null;
        }
        return headNew;
    }
}
