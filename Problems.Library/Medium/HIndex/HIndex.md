# H-Index Calculation

## Description

This repository provides a solution to the H-Index problem. The H-Index is a metric that measures both the productivity and citation impact of a researcher's publications. The H-Index is defined as the maximum value of `h` such that the researcher has published at least `h` papers that have each been cited at least `h` times.

## Problem Statement

Given an array of integers `citations` where `citations[i]` is the number of citations a researcher received for their ith paper, return the researcher's h-index.

According to the definition of h-index on Wikipedia: The h-index is defined as the maximum value of `h` such that the given researcher has published at least `h` papers that have each been cited at least `h` times.

## Examples

### Example 1

- **Input:** `citations = [3,0,6,1,5]`
- **Output:** `3`
- **Explanation:** The researcher has 5 papers with the following citation counts: `[3,0,6,1,5]`. The researcher has 3 papers with at least 3 citations each, and the remaining two papers have no more than 3 citations each. Thus, the h-index is 3.

### Example 2

- **Input:** `citations = [1,3,1]`
- **Output:** `1`
- **Explanation:** The researcher has 3 papers with the following citation counts: `[1,3,1]`. The researcher has 1 paper with at least 1 citation. Thus, the h-index is 1.

## Constraints

- `n == citations.length`
- `1 <= n <= 5000`
- `0 <= citations[i] <= 1000`