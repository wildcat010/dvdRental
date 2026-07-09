-- PRDB.V_MAT_STRUCT_ENTRY source

CREATE OR REPLACE FORCE EDITIONABLE VIEW "PRDB"."V_MAT_STRUCT_ENTRY" ("ENORMEID", "ENOREXTID", "ENORMETYPE", "ENORMESID", "ENORBASID", "ENLOMEID", "ENLOEXTID", "ENLOMETYPE", "ENLOMESID", "ENLOBASID", "ENPHMEID", "ENPHEXTID", "ENPHBASID", "ENPHMETYPE", "ENPHMESID", "ENORSTATUS", "ENORCREATOR", "ENLOSTATUS", "ENLOCREATOR", "ENPHSTATUS", "ENPHCREATOR", "LASTUPDATE") AS 
  SELECT
   EnOR.meId AS EnOrMeID,
   EnOR.extId AS EnOrExtID,
   EnOR.meTyp AS EnOrMeType,
   EnOR.entMesId AS EnOrMesId,
   EnOR.basId AS EnOrBasId,
   EnLo.meId AS EnLoMeID,
   EnLo.extId AS EnLoExtId,
   EnLo.meTyp AS EnLoMeType,
   EnLo.entMesId AS EnLoMesid,
   EnLo.basId AS EnLoBasId,
   EnPh.meId AS EnPhMeID,
   EnPh.extId AS EnPhExtId,
   EnPh.basId AS EnPhBasId,
   EnPh.meTyp AS EnPhMeType,
   EnPh.entMesId AS EnPhMesId,
   EnOR.status AS EnOrStatus,
   EnOR.meCreator AS EnOrCreator,
   EnLo.status AS EnLoStatus,
   EnLo.meCreator AS EnLoCreator,
   EnPh.status AS EnPhStatus,
   EnPh.meCreator AS EnPhCreator,
   EnOr.tom as LastUpdate 
FROM
    (PRDB.Me EnOR
     INNER JOIN PRDB.Mes MesEnOrEnLo 
         ON MesEnOrEnLo.meId = EnOR.meId
     INNER JOIN PRDB.Me EnLo 
         ON MesEnOrEnLo.compMeId = EnLo.meId)
    INNER JOIN PRDB.Mes MesEnLoEnPh 
        ON EnLo.meId = MesEnLoEnPh.meId
    INNER JOIN PRDB.Me EnPh 
        ON EnPh.meId = MesEnLoEnPh.compMeId
WHERE
    (MesEnOrEnLo.mesId = 1) 
    AND (MesEnLoEnPh.mesId = 1);