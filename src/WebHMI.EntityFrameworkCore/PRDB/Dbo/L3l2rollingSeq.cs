using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class L3l2rollingSeq
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// insert behind this slab ID in schedule, if it is NULL the first slab of the new schedule will be inserted as next to be rolled (when insertBehindSlabId is not in schedule, rolling sequence is not changed)
    /// </summary>
    public string InsertBehindSlabId { get; set; }

    /// <summary>
    /// slab number 0. This slab is inserted behind the next slab entering the mill area
    /// </summary>
    public string SlabId0 { get; set; }

    /// <summary>
    /// slab number 1
    /// </summary>
    public string SlabId1 { get; set; }

    /// <summary>
    /// slab number 10
    /// </summary>
    public string SlabId10 { get; set; }

    /// <summary>
    /// slab number 11
    /// </summary>
    public string SlabId11 { get; set; }

    /// <summary>
    /// slab number 12
    /// </summary>
    public string SlabId12 { get; set; }

    /// <summary>
    /// slab number 13
    /// </summary>
    public string SlabId13 { get; set; }

    /// <summary>
    /// slab number 14
    /// </summary>
    public string SlabId14 { get; set; }

    /// <summary>
    /// slab number 15
    /// </summary>
    public string SlabId15 { get; set; }

    /// <summary>
    /// slab number 16
    /// </summary>
    public string SlabId16 { get; set; }

    /// <summary>
    /// slab number 17
    /// </summary>
    public string SlabId17 { get; set; }

    /// <summary>
    /// slab number 18
    /// </summary>
    public string SlabId18 { get; set; }

    /// <summary>
    /// slab number 19
    /// </summary>
    public string SlabId19 { get; set; }

    /// <summary>
    /// slab number 2
    /// </summary>
    public string SlabId2 { get; set; }

    /// <summary>
    /// slab number 20
    /// </summary>
    public string SlabId20 { get; set; }

    /// <summary>
    /// slab number 21
    /// </summary>
    public string SlabId21 { get; set; }

    /// <summary>
    /// slab number 22
    /// </summary>
    public string SlabId22 { get; set; }

    /// <summary>
    /// slab number 23
    /// </summary>
    public string SlabId23 { get; set; }

    /// <summary>
    /// slab number 24
    /// </summary>
    public string SlabId24 { get; set; }

    /// <summary>
    /// slab number 25
    /// </summary>
    public string SlabId25 { get; set; }

    /// <summary>
    /// slab number 26
    /// </summary>
    public string SlabId26 { get; set; }

    /// <summary>
    /// slab number 27
    /// </summary>
    public string SlabId27 { get; set; }

    /// <summary>
    /// slab number 28
    /// </summary>
    public string SlabId28 { get; set; }

    /// <summary>
    /// slab number 29
    /// </summary>
    public string SlabId29 { get; set; }

    /// <summary>
    /// slab number 3
    /// </summary>
    public string SlabId3 { get; set; }

    /// <summary>
    /// slab number 30
    /// </summary>
    public string SlabId30 { get; set; }

    /// <summary>
    /// slab number 31
    /// </summary>
    public string SlabId31 { get; set; }

    /// <summary>
    /// slab number 32
    /// </summary>
    public string SlabId32 { get; set; }

    /// <summary>
    /// slab number 33
    /// </summary>
    public string SlabId33 { get; set; }

    /// <summary>
    /// slab number 34
    /// </summary>
    public string SlabId34 { get; set; }

    /// <summary>
    /// slab number 35
    /// </summary>
    public string SlabId35 { get; set; }

    /// <summary>
    /// slab number 36
    /// </summary>
    public string SlabId36 { get; set; }

    /// <summary>
    /// slab number 37
    /// </summary>
    public string SlabId37 { get; set; }

    /// <summary>
    /// slab number 38
    /// </summary>
    public string SlabId38 { get; set; }

    /// <summary>
    /// slab number 39
    /// </summary>
    public string SlabId39 { get; set; }

    /// <summary>
    /// slab number 4
    /// </summary>
    public string SlabId4 { get; set; }

    /// <summary>
    /// slab number 40
    /// </summary>
    public string SlabId40 { get; set; }

    /// <summary>
    /// slab number 41
    /// </summary>
    public string SlabId41 { get; set; }

    /// <summary>
    /// slab number 42
    /// </summary>
    public string SlabId42 { get; set; }

    /// <summary>
    /// slab number 43
    /// </summary>
    public string SlabId43 { get; set; }

    /// <summary>
    /// slab number 44
    /// </summary>
    public string SlabId44 { get; set; }

    /// <summary>
    /// slab number 45
    /// </summary>
    public string SlabId45 { get; set; }

    /// <summary>
    /// slab number 46
    /// </summary>
    public string SlabId46 { get; set; }

    /// <summary>
    /// slab number 47
    /// </summary>
    public string SlabId47 { get; set; }

    /// <summary>
    /// slab number 48
    /// </summary>
    public string SlabId48 { get; set; }

    /// <summary>
    /// slab number 49
    /// </summary>
    public string SlabId49 { get; set; }

    /// <summary>
    /// slab number 5
    /// </summary>
    public string SlabId5 { get; set; }

    /// <summary>
    /// slab number 50
    /// </summary>
    public string SlabId50 { get; set; }

    /// <summary>
    /// slab number 51
    /// </summary>
    public string SlabId51 { get; set; }

    /// <summary>
    /// slab number 52
    /// </summary>
    public string SlabId52 { get; set; }

    /// <summary>
    /// slab number 53
    /// </summary>
    public string SlabId53 { get; set; }

    /// <summary>
    /// slab number 54
    /// </summary>
    public string SlabId54 { get; set; }

    /// <summary>
    /// slab number 55
    /// </summary>
    public string SlabId55 { get; set; }

    /// <summary>
    /// slab number 56
    /// </summary>
    public string SlabId56 { get; set; }

    /// <summary>
    /// slab number 57
    /// </summary>
    public string SlabId57 { get; set; }

    /// <summary>
    /// slab number 58
    /// </summary>
    public string SlabId58 { get; set; }

    /// <summary>
    /// slab number 59
    /// </summary>
    public string SlabId59 { get; set; }

    /// <summary>
    /// slab number 6
    /// </summary>
    public string SlabId6 { get; set; }

    /// <summary>
    /// slab number 60
    /// </summary>
    public string SlabId60 { get; set; }

    /// <summary>
    /// slab number 61
    /// </summary>
    public string SlabId61 { get; set; }

    /// <summary>
    /// slab number 62
    /// </summary>
    public string SlabId62 { get; set; }

    /// <summary>
    /// slab number 63
    /// </summary>
    public string SlabId63 { get; set; }

    /// <summary>
    /// slab number 64
    /// </summary>
    public string SlabId64 { get; set; }

    /// <summary>
    /// slab number 65
    /// </summary>
    public string SlabId65 { get; set; }

    /// <summary>
    /// slab number 66
    /// </summary>
    public string SlabId66 { get; set; }

    /// <summary>
    /// slab number 67
    /// </summary>
    public string SlabId67 { get; set; }

    /// <summary>
    /// slab number 68
    /// </summary>
    public string SlabId68 { get; set; }

    /// <summary>
    /// slab number 69
    /// </summary>
    public string SlabId69 { get; set; }

    /// <summary>
    /// slab number 7
    /// </summary>
    public string SlabId7 { get; set; }

    /// <summary>
    /// slab number 70
    /// </summary>
    public string SlabId70 { get; set; }

    /// <summary>
    /// slab number 71
    /// </summary>
    public string SlabId71 { get; set; }

    /// <summary>
    /// slab number 72
    /// </summary>
    public string SlabId72 { get; set; }

    /// <summary>
    /// slab number 73
    /// </summary>
    public string SlabId73 { get; set; }

    /// <summary>
    /// slab number 74
    /// </summary>
    public string SlabId74 { get; set; }

    /// <summary>
    /// slab number 75
    /// </summary>
    public string SlabId75 { get; set; }

    /// <summary>
    /// slab number 76
    /// </summary>
    public string SlabId76 { get; set; }

    /// <summary>
    /// slab number 77
    /// </summary>
    public string SlabId77 { get; set; }

    /// <summary>
    /// slab number 78
    /// </summary>
    public string SlabId78 { get; set; }

    /// <summary>
    /// slab number 79
    /// </summary>
    public string SlabId79 { get; set; }

    /// <summary>
    /// slab number 8
    /// </summary>
    public string SlabId8 { get; set; }

    /// <summary>
    /// slab number 80
    /// </summary>
    public string SlabId80 { get; set; }

    /// <summary>
    /// slab number 81
    /// </summary>
    public string SlabId81 { get; set; }

    /// <summary>
    /// slab number 82
    /// </summary>
    public string SlabId82 { get; set; }

    /// <summary>
    /// slab number 83
    /// </summary>
    public string SlabId83 { get; set; }

    /// <summary>
    /// slab number 84
    /// </summary>
    public string SlabId84 { get; set; }

    /// <summary>
    /// slab number 85
    /// </summary>
    public string SlabId85 { get; set; }

    /// <summary>
    /// slab number 86
    /// </summary>
    public string SlabId86 { get; set; }

    /// <summary>
    /// slab number 87
    /// </summary>
    public string SlabId87 { get; set; }

    /// <summary>
    /// slab number 88
    /// </summary>
    public string SlabId88 { get; set; }

    /// <summary>
    /// slab number 89
    /// </summary>
    public string SlabId89 { get; set; }

    /// <summary>
    /// slab number 9
    /// </summary>
    public string SlabId9 { get; set; }

    /// <summary>
    /// slab number 90
    /// </summary>
    public string SlabId90 { get; set; }

    /// <summary>
    /// slab number 91
    /// </summary>
    public string SlabId91 { get; set; }

    /// <summary>
    /// slab number 92
    /// </summary>
    public string SlabId92 { get; set; }

    /// <summary>
    /// slab number 93
    /// </summary>
    public string SlabId93 { get; set; }

    /// <summary>
    /// slab number 94
    /// </summary>
    public string SlabId94 { get; set; }

    /// <summary>
    /// slab number 95
    /// </summary>
    public string SlabId95 { get; set; }

    /// <summary>
    /// slab number 96
    /// </summary>
    public string SlabId96 { get; set; }

    /// <summary>
    /// slab number 97
    /// </summary>
    public string SlabId97 { get; set; }

    /// <summary>
    /// slab number 98
    /// </summary>
    public string SlabId98 { get; set; }

    /// <summary>
    /// slab number 99
    /// </summary>
    public string SlabId99 { get; set; }

    /// <summary>
    /// modifying process
    /// </summary>
    public string Mop { get; set; }

    /// <summary>
    /// time of creation
    /// </summary>
    public DateTime? Toc { get; set; }

    /// <summary>
    /// time of modification
    /// </summary>
    public DateTime? Tom { get; set; }
}
