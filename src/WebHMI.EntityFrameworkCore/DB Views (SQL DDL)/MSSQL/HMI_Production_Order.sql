CREATE OR ALTER VIEW PRDB.HMI_Production_Order
AS
WITH Numbers AS
(
    SELECT a.n * 10 + b.n + 1 AS RowNo
    FROM (VALUES
        (0), (1), (2), (3), (4), (5), (6),
        (7), (8), (9), (10), (11), (12), (13)
    ) AS a(n)
    CROSS JOIN (VALUES
        (0), (1), (2), (3), (4),
        (5), (6), (7), (8), (9)
    ) AS b(n)
)
SELECT
    CAST(
        N'ORD-' + RIGHT(N'0000' + CAST(RowNo AS nvarchar(4)), 4)
        AS nvarchar(50)
    ) AS OrderNo,

    CAST(
        0.50 + ((RowNo * 37) % 451) / 100.0
        AS float
    ) AS Thickness,

    CAST(
        800 + ((RowNo * 73) % 1201)
        AS decimal(10, 2)
    ) AS [Width],

    CAST(
        1000 + ((RowNo * 137) % 24001)
        AS decimal(12, 2)
    ) AS [Weight],

    CAST(
        ((RowNo * 19) % 101) / 10.0
        AS decimal(10, 2)
    ) AS [Profile],

    CAST(N'E-Q' AS nvarchar(10)) AS CoolType,

    CAST(
        450 + ((RowNo * 29) % 251)
        AS decimal(10, 2)
    ) AS CoilerTemp,

    CAST(
        1 + ((RowNo * 17) % 100)
        AS int
    ) AS AvailableQuantity
FROM Numbers;
GO