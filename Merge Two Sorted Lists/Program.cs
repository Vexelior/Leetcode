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
        // Base cases: if either list is null, return the other list.
        if (list1 == null)
        {
            return list2;
        }

        if (list2 == null)
        {
            return list1;
        }

        // Recursive case: compare the values of the nodes and merge accordingly.
        if (list1._val < list2._val)
        {
            list1._next = MergeTwoLists(list1._next, list2);
            return list1;
        }
        else
        {
            list2._next = MergeTwoLists(list1, list2._next);
            return list2;
        }
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
