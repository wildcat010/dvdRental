CREATE   VIEW [PRDB].[HMI_V_PRODSEQUENCE_COMPLETE] AS
WITH ProdSequence AS (
    SELECT 
        ROW_NUMBER() OVER (
            PARTITION BY H.sequenceId
            ORDER BY P.majorno, P.minorno
        ) AS position,
        P.NEXT AS PNEXT,
        P.majorno,
        P.minorno,
        H.EnPhExtId,
        H.EnPhMeID,
        H.EdPhySrc,
        H.EnPhStatus,
        H.EnOrMeID,
        H.EnOrExtID,
        H.EdOrSrc,
        H.EnOrMeType,
        H.EnOrStatus,
        H.EnOrCreator,
        H.EnOrMesId,
        H.EnLoMeID,
        H.EnLoExtId,
        H.EnLoStatus,
        H.alloyCode,
        H.hEntry,
        ISNULL(H.hExitCold, H.hExit) AS hExit,
        ISNULL(H.wExitCold, H.wExit) AS wExit,
        H.wEntry,
        H.weightEntry,
        H.lEntry,
        H.lExit,
        H.sequenceId,
        H.PdiStatus,
        H.setpointsPc2Ok,
        H.sbaz,
        H.LastCalc,
        H.apsKey,
        H.simMat,
        H.setpointsCsOk,
        H.tEntryFM,
        H.tExitFM,
        H.tExitCaster,
        H.coolStrategy,
        ISNULL(H.csCoilTempSetp, H.coilTemp) AS coilTemp,
        H.heatId,
        CASE
            WHEN H.plateProduction = 1 THEN 'PLATE'
            WHEN H.flagBatchRolling = 1 THEN 'BATCH'
            ELSE 'ENDLESS'
        END AS flagBatchRolling,
        H.plateProduction,
        ISNULL(H.hExitHRM, H.hExitHRMCalc) as hExitHRM,
        H.profileHRM,
        H.orderNo
    FROM ProdSchedule P
    JOIN HMI_V_MAT_INFO_SHORT H ON P.meId = H.EnPhMeID
    UNION ALL
    SELECT
        ROW_NUMBER() OVER (
            PARTITION BY H.sequenceId
            ORDER BY H.sequenceId, H.EnPhMeID
        ) AS position,
        P.NEXT PNEXT,
        -1,
        -1,
        H.EnPhExtId,
        H.EnPhMeID,
        H.EdPhySrc,
        H.EnPhStatus,
        H.EnOrMeID,
        H.EnOrExtID,
        H.EdOrSrc,
        H.EnOrMeType,
        H.EnOrStatus,
        H.EnOrCreator,
        H.EnOrMesId,
        H.EnLoMeID,
        H.EnLoExtId,
        H.EnLoStatus,
        H.alloyCode,
        H.hEntry,
        ISNULL(H.hExitCold, H.hExit),
        ISNULL(H.wExitCold, H.wExit),
        H.wEntry,
        H.weightEntry,
        H.lEntry,
        H.lExit,
        H.sequenceId,
        H.PdiStatus,
        H.setpointsPc2Ok,
        H.sbaz,
        H.LastCalc,
        H.apsKey,
        H.simMat,
        H.setpointsCsOk,
        H.tEntryFM,
        H.tExitFM,
        H.tExitCaster,
        H.coolStrategy,
        ISNULL(H.csCoilTempSetp, H.coilTemp),
        H.heatId,
        CASE
            WHEN H.plateProduction = 1 THEN 'PLATE'
            WHEN H.flagBatchRolling = 1 THEN 'BATCH'
            ELSE 'ENDLESS'
        END,
        H.plateProduction,
        ISNULL(H.hExitHRM, H.hExitHRMCalc),
        H.profileHRM,
        H.orderNo
    FROM HMI_V_MAT_INFO_SHORT H
    LEFT JOIN ProdSchedule P ON P.meId = H.EnPhMeID
    WHERE P.meId IS NULL
)
SELECT
    ROW_NUMBER() OVER (
        PARTITION BY sequenceId
        ORDER BY majorno, minorno, position
    ) AS position,
    PNEXT,
    majorno,
    minorno,
    EnPhExtId,
    EnPhMeID,
    EdPhySrc,
    EnPhStatus,
    EnOrMeID,
    EnOrExtID,
    EdOrSrc,
    EnOrMeType,
    EnOrStatus,
    EnOrCreator,
    EnOrMesId,
    EnLoMeID,
    EnLoExtId,
    EnLoStatus,
    alloyCode,
    hEntry,
    hExit,
    wExit,
    wEntry,
    weightEntry,
    lEntry,
    lExit,
    sequenceId,
    PdiStatus,
    setpointsPc2Ok,
    sbaz,
    LastCalc,
    apsKey,
    simMat,
    setpointsCsOk,
    tEntryFM,
    tExitFM,
    tExitCaster,
    coolStrategy,
    coilTemp,
    heatId,
    flagBatchRolling,
    plateProduction,
    hExitHRM,
    profileHRM,
    orderNo
FROM ProdSequence