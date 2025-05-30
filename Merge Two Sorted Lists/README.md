# Solution

# Problem Description

You are given the heads of two sorted linked lists `list1` and `list2`. Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

# Problem Explanation

The solution is implemented in C# using the following method:

## Code

```csharp
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

        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1._val < list2._val)
            {
                current._next = list1;
                list1 = list1._next;
            }
            else
            {
                current._next = list2;
                list2 = list2._next;
            }
            current = current._next;
        }

        if (list1 != null)
        {
            current._next = list1;
        }

        if (list2 != null)
        {
            current._next = list2;
        }

        return dummy._next;
    }
```

### Key Steps in the Algorithm:

1. **Handle Edge Cases**:
   - If either `list1` or `list2` is `null`, return the other list.
2. **Initialize a Dummy Node**:
   - Create a dummy node to simplify the merging process.
   - Use a pointer `current` to track the end of the merged list.
3. **Merge the Lists**:
   - Use a `while` loop to iterate through both lists.
   - Compare the values of the current nodes in `list1` and `list2`.
   - Append the smaller node to the merged list and move the pointer of that list forward.
4. **Append Remaining Nodes**:
   - After the loop, if there are remaining nodes in either list, append them to the merged list.
5. **Return the Merged List**:
   - Return the next node of the dummy node, which is the head of the merged list.

### Complexity Analysis:

- **Time Complexity**: O(n + m), where `n` is the number of nodes in `list1` and `m` is the number of nodes in `list2`. We traverse both lists once.
- **Space Complexity**: O(1), as we are using a constant amount of extra space (the dummy node).

## Example Usage

```csharp
ListNode? list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
ListNode? list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
ListNode? mergedList = MergeTwoLists(list1, list2);
PrintList(mergedList); // Output: 1 -> 1 -> 2 -> 3 -> 4 -> 4
```

# Conclusion

The `MergeTwoLists` function efficiently merges two sorted linked lists into one sorted linked list by comparing the nodes and appending them in order. The use of a dummy node simplifies the merging process, and the algorithm runs in linear time with constant space usage, making it optimal for this problem. This solution is useful in scenarios where maintaining sorted order while merging is required, such as in various data processing tasks.
