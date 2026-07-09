
  CREATE OR REPLACE FORCE EDITIONABLE VIEW "PRDB"."HMI_V_MAT_INFO_SHORT" ("ENPHEXTID", "ENPHMEID", "EDPHYSRC", "ENPHSTATUS", "ENORMEID", "ENOREXTID", "ENORMETYPE", "ENORMESID", "ENORCREATOR", "ENORBASID", "EDORSRC", "ENLOMEID", "EDLOSRC", "ALLOYCODE", "HENTRY", "HEXIT", "WENTRY", "WEIGHTENTRY", "LENTRY", "WEXIT", "SEQUENCEID", "PDISTATUS", "SETPOINTSPC2OK", "SBAZ", "LASTCALC", "SPTLFAULTCS", "SPTLFAULTFM", "APSKEY", "SIMMAT", "SETPOINTSCSOK", "TENTRYFM", "TEXITFM", "TEXITCASTER", "COILTEMP", "COOLSTRATEGY", "CSCOILTEMPSETP", "HEXITCOLD", "WEXITCOLD", "HEATID", "FLAGBATCHROLLING", "PLATEPRODUCTION", "PRODSTARTTIME", "PRODENDTIME", "LEXIT", "HEXITHRM", "HEXITHRMCALC", "PROFILEHRM", "ORDERNO", "ENLOEXTID", "ENLOMESID", "ENLOMETYPE", "ENPHMETYPE", "ENPHMESID", "ENORSTATUS", "ENLOSTATUS", "ENPHCREATOR", "ENLOCREATOR", "IDSEQ", "IDRIGA") AS 
  SELECT V_MAT_STRUCT_ENTRY.EnPhExtId
	,V_MAT_STRUCT_ENTRY.EnPhMeID
	,EdPhyEnt.source AS EdPhySrc
	,V_MAT_STRUCT_ENTRY.EnPhStatus
	,V_MAT_STRUCT_ENTRY.EnOrMeID
	,V_MAT_STRUCT_ENTRY.EnOrExtID
	,V_MAT_STRUCT_ENTRY.EnOrMeType
	,V_MAT_STRUCT_ENTRY.EnOrMesId
	,V_MAT_STRUCT_ENTRY.EnOrCreator
       ,prdb.v_mat_struct_entry.enorbasid
	,EdOrdEnt.source AS EdOrSrc
	,V_MAT_STRUCT_ENTRY.EnLoMeID
	,EdLogEnt.source AS EdLoSrc
	,EdLogEnt.alloyCode
	,EdPhyEnt.aimSlabThickness AS hEntry
	,EdOrdEnt.hExit
	,EdPhyEnt.slabWidth AS wEntry
	,EdPhyEnt.slabWeight AS weightEntry
	,EdPhyEnt.slabLength AS lEntry
	,EdOrdEnt.widthExit AS wExit
	,EdPhyEnt.sequenceId
	,EdPhyEnt.okAll AS PdiStatus
	,SpOrd2Pc.setpointsPc2Ok
	,SpOrd2Pc.sbaz
	,SpOrd2Pc.tom AS LastCalc
    ,spord2pc.sptlfaultcs
    ,spord2pc.sptlfaultfm
	,EdLogEnt.apsKey
	,EdPhyEnt.simMat
	,SpOrd2Pc.setpointsCsOk
	,SpOrd2Pc.tEntry AS tEntryFM
	,EdOrdEnt.tExit AS tExitFM
	,EdOrdEnt.tExitCaster
	,EdOrdEnt.coilTemp
	,EdOrdEnt.coolStrategy
	,SpOrd2Pc.csCoilTempSetp
	,SpOrd2Pc.hExitCold
	,SpOrd2Pc.wExitCold
	,EdPhyEnt.heatId
	,EdOrdEnt.flagBatchRolling
	,EdPhyEnt.plateProduction
	,opt1.DATETIME AS prodStartTime
	,opt3.DATETIME AS prodEndTime
	,SpOrd2Pc.lExit
	,EdOrdEnt.hIntermediate AS hExitHRM
	,SpOrd2Pc.hEntryColdFM AS hExitHRMCalc
	,EdOrdEnt.exitCrownC25 AS profileHRM
	,EdOrdEnt.orderNo
	,V_MAT_STRUCT_ENTRY.EnLoExtId
	,V_MAT_STRUCT_ENTRY.EnLoMesid
	,V_MAT_STRUCT_ENTRY.EnLoMeType
	,V_MAT_STRUCT_ENTRY.EnPhMeType
	,V_MAT_STRUCT_ENTRY.EnPhMesId
	,V_MAT_STRUCT_ENTRY.EnOrStatus
	,V_MAT_STRUCT_ENTRY.EnLoStatus
	,V_MAT_STRUCT_ENTRY.EnPhCreator
	,V_MAT_STRUCT_ENTRY.EnLoCreator
    ,Edordent.IDSEQ
    ,Edordent.IDRIGA
FROM V_MAT_STRUCT_ENTRY
INNER JOIN EdOrdEnt ON V_MAT_STRUCT_ENTRY.EnOrMeID = EdOrdEnt.meId
	AND EdOrdEnt.source = 'E'
INNER JOIN EdLogEnt ON V_MAT_STRUCT_ENTRY.EnLoMeID = EdLogEnt.meId
	AND EdLogEnt.source = 'E'
INNER JOIN EdPhyEnt ON V_MAT_STRUCT_ENTRY.EnPhMeID = EdPhyEnt.meId
	AND EdPhyEnt.source = 'E'
LEFT OUTER JOIN SpOrd2Pc ON V_MAT_STRUCT_ENTRY.EnOrMeID = SpOrd2Pc.meId
	AND SpOrd2Pc.source = 'E'
	AND SpOrd2Pc.thickHead = 0
LEFT OUTER JOIN SpOrdEnt ON V_MAT_STRUCT_ENTRY.EnOrMeID = SpOrdEnt.meId
	AND SpOrdEnt.source = 'E'
	AND SpOrdEnt.thickHead = 0
LEFT OUTER JOIN OperTime opt1 ON opt1.meId = V_MAT_STRUCT_ENTRY.EnOrMeID
	AND opt1.meCreator = V_MAT_STRUCT_ENTRY.EnOrCreator
	AND opt1.STATUS = 1
LEFT OUTER JOIN OperTime opt3 ON opt3.meId = V_MAT_STRUCT_ENTRY.EnOrMeID
	AND opt3.meCreator = V_MAT_STRUCT_ENTRY.EnOrCreator
	AND opt3.STATUS = 3;

