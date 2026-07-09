-- PRDB.V_MAT_STRUCT_COMPLETE source

CREATE OR REPLACE FORCE EDITIONABLE VIEW "PRDB"."V_MAT_STRUCT_COMPLETE" ("ENORMEID", "ENOREXTID", "ENORCURMESID", "ENORMETYPE", "ENORSTATUS", "ENORENLOMESID", "ENORCREATOR", "ENLOMEID", "ENLOMESID", "ENLOMETYPE", "ENLOSTATUS", "ENLOENPHMESID", "ENLOCREATOR", "ENPHMEID", "ENPHEXTID", "ENPHMETYPE", "ENPHSTATUS", "ENPHCREATOR", "ENOREXLOMESID", "EXLOMEID", "EXLOEXITID", "EXLOMETYPE", "EXLOCREATOR", "MESID", "EXPHMEID", "EXPHEXTID", "EXPHMETYPE", "EXPHCREATOR", "EXPHSTATUS") AS 
  SELECT         MesEnOrEnLo.meId AS EnOrMeID, EnOR.extId AS EnOrExtID, EnOR.curMesId AS EnOrCurMesId, EnOR.meTyp AS EnOrMeType, EnOr.status As EnOrStatus, MesEnOrEnLo.mesId AS EnOrEnLoMesid, EnOR.meCreator AS EnOrCreator,
                         EnLo.meId AS EnLoMeID, EnLo.extId AS EnLoMesID, EnLo.meTyp AS EnLoMeType, EnLo.status As EnLoStatus, MesEnLoEnPh.mesId AS EnLoEnPhMesId, EnLo.meCreator AS EnLoCreator, EnPh.meId AS EnPhMeID, EnPh.extId AS EnPhExtId,
                         EnPh.meTyp AS EnPhMeType, EnPh.status As EnPhStatus,EnPh.meCreator AS EnPhCreator, MesEnOrExLo.mesId AS EnOrExLoMesID, ExLo.meId AS ExLoMeID, ExLo.extId AS ExLoExitId, ExLo.meTyp AS ExLoMeType, ExLo.meCreator AS ExLoCreator,
                         MesExLoExPh.mesId, ExPh.meId AS ExPhMeid, ExPh.extId AS ExPhExtId, ExPh.meTyp AS ExPhMeType, ExPh.meCreator AS ExPhCreator, ExPh.status As ExPhStatus
FROM            PRDB.Me  ExLo RIGHT OUTER JOIN
                         PRDB.Me  EnPh INNER JOIN
                         PRDB.Mes  MesEnOrEnLo INNER JOIN
                         PRDB.Me  EnOR ON MesEnOrEnLo.meId = EnOR.meId INNER JOIN
                         PRDB.Me  EnLo ON MesEnOrEnLo.compMeId = EnLo.meId INNER JOIN
                         PRDB.Mes  MesEnLoEnPh ON EnLo.meId = MesEnLoEnPh.meId ON EnPh.meId = MesEnLoEnPh.compMeId INNER JOIN
                         PRDB.Mes  MesEnOrExLo ON EnOR.meId = MesEnOrExLo.meId ON ExLo.meId = MesEnOrExLo.compMeId LEFT OUTER JOIN
                         PRDB.Mes  MesExLoExPh LEFT OUTER JOIN
                         PRDB.Me  ExPh ON MesExLoExPh.compMeId = ExPh.meId ON MesExLoExPh.meId = ExLo.meId AND MesExLoExPh.mesId = 2
WHERE        (MesEnOrEnLo.mesId = 1) AND (MesEnLoEnPh.mesId = 1) AND (MesEnOrExLo.mesId = 2)
ORDER BY EnOrMeID;