USE [PRDB]
GO

/****** Object:  View [PRDB].[HMI_V_PRODUCTION_HISTORY]    Script Date: 7/27/2026 11:23:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [PRDB].[HMI_V_PRODUCTION_HISTORY]
AS
SELECT     PRDB.ProdDataCore.meId, PRDB.ProdDataCore.coilId, PRDB.ProdDataCore.slabId, PRDB.ProdDataCore.seqId AS SequenceId, PRDB.ProdDataCore.heatId1, PRDB.EdOrdEnt.flagBatchRolling, PRDB.EdLogEnt.alloyCode, PRDB.ProdDataCore.prodStart, PRDB.ProdDataCore.prodEnd, 
                  PRDB.ProdDataCore.wExit, PRDB.ProdDataCore.wExitAver, PRDB.ProdDataCore.wExitMin, PRDB.ProdDataCore.wExitMax, PRDB.ProdDataCore.hExit, PRDB.ProdDataCore.hExitAver, PRDB.ProdDataCore.hExitMin, PRDB.ProdDataCore.hExitMax, PRDB.ProdDataCore.tExitCS, 
                  PRDB.ProdDataCore.tExitCsAver, PRDB.ProdDataCore.tExitCsMin, PRDB.ProdDataCore.tExitCsMax, PRDB.ProdDataCore.coilLengthX, PRDB.Me.meCreator AS EnOrCreator, PRDB.Me.meId AS EnOrMeid, PRDB.Me.status AS EnOrStatus, PRDB.Me.extId AS EnOrExitId, 
                  PRDB.Me.meTyp AS EnOrMeType, PRDB.Me.curMesId AS EnOrCurMesId
FROM        PRDB.ProdDataCore INNER JOIN
                  PRDB.Me AS meLo ON meLo.extId = PRDB.ProdDataCore.coilId AND meLo.meTyp = 'LO' INNER JOIN
                  PRDB.Me ON PRDB.ProdDataCore.meId = PRDB.Me.meId LEFT OUTER JOIN
                  PRDB.EdLogEnt ON PRDB.EdLogEnt.meId = meLo.meId AND PRDB.EdLogEnt.source = 'E' LEFT OUTER JOIN
                  PRDB.EdOrdEnt ON PRDB.EdOrdEnt.meId = PRDB.ProdDataCore.meId AND PRDB.EdOrdEnt.source = 'E'
GO


