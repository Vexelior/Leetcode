namespace Merge_Two_Sorted_Lists;

public class ListNode
{
    public static void Main(string[] args)
    {
        // Example usage
        ListNode? list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode? list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        ListNode? mergedList = MergeTwoLists(list1, list2);
        PrintList(mergedList);
    }

    private readonly int _val;
    private ListNode? _next;

    private ListNode(int val = 0, ListNode? next = null)
    {
        _val = val;
        _next = next;
    }

    // Merges two sorted linked lists and returns the head of the merged list.
    // Both input lists are assumed to be sorted in ascending order.
    private static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        // If the first list is null, return the second list (could also be null).
        if (list1 == null)
        {
            return list2;
        }

        // If the second list is null, return the first list.
        if (list2 == null)
        {
            return list1;
        }

        // Create a dummy node to simplify edge cases (e.g., empty input lists).
        ListNode dummy = new ListNode(0);
        // 'current' will point to the last node in the merged list as we build it.
        ListNode current = dummy;

        // Traverse both lists, picking the smaller value each time.
        while (list1 != null && list2 != null)
        {
            if (list1._val < list2._val)
            {
                // Attach the node from list1 to the merged list.
                current._next = list1;
                // Move to the next node in list1.
                list1 = list1._next;
            }
            else
            {
                // Attach the node from list2 to the merged list.
                current._next = list2;
                // Move to the next node in list2.
                list2 = list2._next;
            }
            // Move 'current' to the newly added node.
            current = current._next;
        }

        // If there are remaining nodes in either list, attach them.
        if (list1 != null)
        {
            current._next = list1;
        }

        if (list2 != null)
        {
            current._next = list2;
        }

        // Return the merged list, skipping the dummy node.
        return dummy._next;
    }

    private static void PrintList(ListNode? head)
    {
        while (head != null)
        {
            Console.Write(head._val + " ");
            head = head._next;
        }
        Console.WriteLine();
    }
}
