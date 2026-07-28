USE [PRDB]
GO

/****** Object:  View [PRDB].[HMI_V_PRODSEQUENCE]    Script Date: 7/28/2026 3:13:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER OFF
GO


CREATE   VIEW [PRDB].[HMI_V_PRODSEQUENCE] AS 
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
		H.heatName,
        CASE
            WHEN H.plateProduction = 1 THEN 'PLATE'
            WHEN H.flagBatchRolling = 1 THEN 'BATCH'
            ELSE 'ENDLESS'
        END AS flagBatchRolling,
        H.plateProduction,
        ISNULL(H.hExitHRM, H.hExitHRMCalc) as hExitHRM,
        H.profileHRM,
        H.orderNo,
		P.calcFlag
    FROM ProdSchedule P
    JOIN HMI_V_MAT_INFO_SHORT H ON P.meId = H.EnPhMeID
GO


