# Rotate List

## Problem Statement
Given the head of a linked list, rotate the list to the right by `k` places.

## Examples

### Example 1:
```
Input: head = [1,2,3,4,5], k = 2
Output: [4,5,1,2,3]
```

### Example 2:
```
Input: head = [0,1,2], k = 4
Output: [2,0,1]
```

## Constraints:
- The number of nodes in the list is in the range [0, 500].
- -100 <= Node.val <= 100
- 0 <= k <= 2 * 10^9

## Notes:
- The function should rotate the linked list to the right by `k` places.
- If `k` is greater than the length of the list, rotating the list `k` times is the same as rotating it `k % length` times.
- The linked list should remain intact and the rotations should be performed in-place.