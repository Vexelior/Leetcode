# Solution

# Problem Description

You are given the heads of two sorted linked lists `list1` and `list2`. Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

# Problem Explanation

The solution is implemented in C# using the following method:

## Code

```csharp
    private static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
    private static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 == null)
        {
            return list2;
        }

        if (list2 == null)
        {
            return list1;
        }

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
    }
```

### Key Steps in the Algorithm:

1. **Handle Edge Cases**:
   - If `list1` is null, return `list2`.
   - If `list2` is null, return `list1`.
2. **Compare Values**:
   - If the value of the current node in `list1` is less than that in `list2`, set the next node of `list1` to the result of merging the next node of `list1` with `list2`.
   - Otherwise, set the next node of `list2` to the result of merging `list1` with the next node of `list2`.
3. **Return the Merged List**:
   - The function returns the head of the merged list, which is either `list1` or `list2`, depending on which node had the smaller value.
   - The recursion continues until all nodes from both lists are processed.

### Complexity Analysis:

- **Time Complexity**: O(n + m), where n is the number of nodes in `list1` and m is the number of nodes in `list2`. Each node is processed exactly once.
- **Space Complexity**: O(n + m) for the recursive stack space, where n and m are the lengths of the two lists. However, if we use an iterative approach with a dummy node, the space complexity can be reduced to O(1) for the merged list.

## Example Usage

```csharp
ListNode? list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
ListNode? list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
ListNode? mergedList = MergeTwoLists(list1, list2);
PrintList(mergedList); // Output: 1 -> 1 -> 2 -> 3 -> 4 -> 4
```

# Conclusion

The `MergeTwoLists` function efficiently merges two sorted linked lists into one sorted linked list by comparing the nodes and appending them in order. The use of a dummy node simplifies the merging process, and the algorithm runs in linear time with constant space usage, making it optimal for this problem. This solution is useful in scenarios where maintaining sorted order while merging is required, such as in various data processing tasks.
