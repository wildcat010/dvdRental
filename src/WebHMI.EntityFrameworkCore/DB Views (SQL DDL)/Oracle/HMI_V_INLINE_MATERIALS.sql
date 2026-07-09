CREATE OR REPLACE VIEW HMI_V_INLINE_MATERIALS
AS
SELECT        PRDB.V_MAT_STRUCT_ENTRY.EnPhExtId, PRDB.V_MAT_STRUCT_ENTRY.EnPhMeID, PRDB.EdPhyEnt.source AS EdPhySrc, PRDB.V_MAT_STRUCT_ENTRY.EnPhStatus, PRDB.V_MAT_STRUCT_ENTRY.EnOrMeID, 
                         PRDB.V_MAT_STRUCT_ENTRY.EnOrExtID, PRDB.V_MAT_STRUCT_ENTRY.EnOrMeType, PRDB.V_MAT_STRUCT_ENTRY.EnOrMesId, PRDB.V_MAT_STRUCT_ENTRY.EnOrCreator, PRDB.EdOrdEnt.source AS EdOrSrc, 
                         PRDB.V_MAT_STRUCT_ENTRY.EnLoMeID, PRDB.EdLogEnt.source AS EdLoSrc, PRDB.EdLogEnt.alloyCode, PRDB.EdPhyEnt.aimSlabThickness AS hEntry, PRDB.EdOrdEnt.hExit, PRDB.EdPhyEnt.slabWidth AS wEntry, 
                         PRDB.EdPhyEnt.slabWeight AS weightEntry, PRDB.EdPhyEnt.slabLength AS lEntry, PRDB.EdOrdEnt.widthExit AS wExit, PRDB.EdPhyEnt.sequenceId, PRDB.SpOrdEnt.setpointsEdOk AS PdiStatus, 
                         PRDB.SpOrd2Pc.setpointsPc2Ok, PRDB.SpOrd2Pc.sbaz, PRDB.SpOrd2Pc.tom AS LastCalc, PRDB.EdLogEnt.apsKey, PRDB.EdPhyEnt.simMat, PRDB.SpOrd2Pc.setpointsCsOk, PRDB.SpOrd2Pc.tEntry AS tEntryFM, 
                         PRDB.EdOrdEnt.tExit AS tExitFM, PRDB.EdOrdEnt.tExitCaster, PRDB.EdOrdEnt.coilTemp, PRDB.EdPhyEnt.heatId, PRDB.EdOrdEnt.flagBatchRolling, opt.dateTime AS prodStartTime, PRDB.EdPhyEnt.plateProduction
FROM            PRDB.V_MAT_STRUCT_ENTRY INNER JOIN
                         PRDB.EdOrdEnt ON PRDB.V_MAT_STRUCT_ENTRY.EnOrMeID = PRDB.EdOrdEnt.meId AND PRDB.EdOrdEnt.source = 'E' INNER JOIN
                         PRDB.EdLogEnt ON PRDB.V_MAT_STRUCT_ENTRY.EnLoMeID = PRDB.EdLogEnt.meId AND PRDB.EdLogEnt.source = 'E' INNER JOIN
                         PRDB.EdPhyEnt ON PRDB.V_MAT_STRUCT_ENTRY.EnPhMeID = PRDB.EdPhyEnt.meId AND PRDB.EdPhyEnt.source = 'E' LEFT OUTER JOIN
                         PRDB.SpOrd2Pc ON PRDB.V_MAT_STRUCT_ENTRY.EnOrMeID = PRDB.SpOrd2Pc.meId AND PRDB.SpOrd2Pc.source = 'E' AND PRDB.SpOrd2Pc.thickHead = 0 LEFT OUTER JOIN
                         PRDB.SpOrdEnt ON PRDB.V_MAT_STRUCT_ENTRY.EnOrMeID = PRDB.SpOrdEnt.meId AND PRDB.SpOrdEnt.source = 'E' AND PRDB.SpOrdEnt.thickHead = 0 LEFT OUTER JOIN
                         PRDB.OperTime opt ON opt.meId = PRDB.V_MAT_STRUCT_ENTRY.EnOrMeID AND opt.meCreator = PRDB.V_MAT_STRUCT_ENTRY.EnOrCreator AND opt.status = 1
WHERE        (PRDB.V_MAT_STRUCT_ENTRY.EnOrStatus IN (1, 2)) and opt.dateTime > SYSDATE-0.5;
GO