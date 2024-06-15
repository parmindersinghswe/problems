# Top Travellers

## Problem Statement
Given two tables, `Users` and `Rides`, write a solution to report the distance traveled by each user.

### Users Table:
| Column Name | Type    |
|-------------|---------|
| id          | int     |
| name        | varchar |

- `id` is the column with unique values for this table.
- `name` is the name of the user.

### Rides Table:
| Column Name | Type    |
|-------------|---------|
| id          | int     |
| user_id     | int     |
| distance    | int     |

- `id` is the column with unique values for this table.
- `user_id` is the id of the user who traveled the distance "distance".

### Requirements:
Return the result table ordered by `travelled_distance` in descending order. If two or more users traveled the same distance, order them by their `name` in ascending order.

### Example:

#### Input:
Users table:
| id  | name     |
|-----|----------|
| 1   | Alice    |
| 2   | Bob      |
| 3   | Alex     |
| 4   | Donald   |
| 7   | Lee      |
| 13  | Jonathan |
| 19  | Elvis    |

Rides table:
| id  | user_id | distance |
|-----|---------|----------|
| 1   | 1       | 120      |
| 2   | 2       | 317      |
| 3   | 3       | 222      |
| 4   | 7       | 100      |
| 5   | 13      | 312      |
| 6   | 19      | 50       |
| 7   | 7       | 120      |
| 8   | 19      | 400      |
| 9   | 7       | 230      |

#### Output:
| name     | travelled_distance |
|----------|--------------------|
| Elvis    | 450                |
| Lee      | 450                |
| Bob      | 317                |
| Jonathan | 312                |
| Alex     | 222                |
| Alice    | 120                |
| Donald   | 0                  |

#### Explanation:
- Elvis and Lee traveled 450 miles each. Elvis is listed first as his name is alphabetically smaller than Lee.
- Bob, Jonathan, Alex, and Alice are ordered by their total distances.
- Donald did not have any rides, so the distance traveled by him is 0.

## Constraints:
- The number of rows in both tables is in the range [0, 5000].
- -100 <= distance <= 10000

## SQL Solution:
```sql
SELECT u.name, COALESCE(SUM(r.distance), 0) AS travelled_distance
FROM Users u
LEFT JOIN Rides r ON u.id = r.user_id
GROUP BY u.id, u.name
ORDER BY travelled_distance DESC, u.name ASC;
```

## Notes:
- The solution uses a LEFT JOIN to include users who have not taken any rides, ensuring they appear in the result with a travelled distance of 0.
- The `COALESCE` function is used to handle NULL values for users with no rides.
- The results are ordered by `travelled_distance` in descending order and `name` in ascending order.