CREATE   VIEW [PRDB].[V_MAT_STRUCT_COMPLETE] AS 
  SELECT         MesEnOrEnLo.meId AS EnOrMeID, EnOR.extId AS EnOrExtID, EnOR.curMesId AS EnOrCurMesId, EnOR.meTyp AS EnOrMeType, EnOr.status As EnOrStatus, MesEnOrEnLo.mesId AS EnOrEnLoMesid, EnOR.meCreator AS EnOrCreator,
                         EnLo.meId AS EnLoMeID, EnLo.extId AS EnLoMesID, EnLo.meTyp AS EnLoMeType, EnLo.status As EnLoStatus, MesEnLoEnPh.mesId AS EnLoEnPhMesId, EnLo.meCreator AS EnLoCreator, EnPh.meId AS EnPhMeID, EnPh.extId AS EnPhExtId,
                         EnPh.meTyp AS EnPhMeType, EnPh.status As EnPhStatus,EnPh.meCreator AS EnPhCreator, MesEnOrExLo.mesId AS EnOrExLoMesID, ExLo.meId AS ExLoMeID, ExLo.extId AS ExLoExitId, ExLo.meTyp AS ExLoMeType, ExLo.meCreator AS ExLoCreator,
                         MesExLoExPh.mesId, ExPh.meId AS ExPhMeid, ExPh.extId AS ExPhExtId, ExPh.meTyp AS ExPhMeType, ExPh.meCreator AS ExPhCreator, ExPh.status As ExPhStatus
FROM            Me  ExLo RIGHT OUTER JOIN
                         Me  EnPh INNER JOIN
                         Mes  MesEnOrEnLo INNER JOIN
                         Me  EnOR ON MesEnOrEnLo.meId = EnOR.meId INNER JOIN
                         Me  EnLo ON MesEnOrEnLo.compMeId = EnLo.meId INNER JOIN
                         Mes  MesEnLoEnPh ON EnLo.meId = MesEnLoEnPh.meId ON EnPh.meId = MesEnLoEnPh.compMeId INNER JOIN
                         Mes  MesEnOrExLo ON EnOR.meId = MesEnOrExLo.meId ON ExLo.meId = MesEnOrExLo.compMeId LEFT OUTER JOIN
                         Mes  MesExLoExPh LEFT OUTER JOIN
                         Me  ExPh ON MesExLoExPh.compMeId = ExPh.meId ON MesExLoExPh.meId = ExLo.meId AND MesExLoExPh.mesId = 2
WHERE        (MesEnOrEnLo.mesId = 1) AND (MesEnLoEnPh.mesId = 1) AND (MesEnOrExLo.mesId = 2)
GO