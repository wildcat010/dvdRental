CREATE OR ALTER VIEW HMI_V_PRODUCTION_HISTORY AS 
SELECT 
PRODDATACORE.Meid as MeId,
PRODDATACORE.CoilId,
PRODDATACORE.SlabId,
PRODDATACORE.Seqid as SequenceId,
PRODDATACORE.HeatId1,
EdOrdEnt.FLAGBATCHROLLING as FlagBatchRolling,
EdLogEnt.ALLOYCODE as AlloyCode,
PRODDATACORE.PRODSTART as ProdStart,
PRODDATACORE.prodEnd as ProdEnd, 
PRODDATACORE.wExit,
PRODDATACORE.wExitAver,
PRODDATACORE.wExitMin,
PRODDATACORE.wExitMax,
PRODDATACORE.hExit,
PRODDATACORE.hExitAver,
PRODDATACORE.hExitMin,
PRODDATACORE.hExitMax,
PRODDATACORE.tExitCS,
PRODDATACORE.tExitCSAver as TExitCsAver,
PRODDATACORE.tExitCSMin as TExitCsMin,
PRODDATACORE.tExitCSMax as TExitCsMax,
PRODDATACORE.coilLengthX,
meOr.meId as EnOrMeId,
meOr.meTyp as EnOrMeType,
meOr.status as EnOrStatus,
meOr.extId as EnOrExitId,
meOr.curMesId as EnOrCurMesId,
meOr.meCreator as EnOrCreator
FROM 
PRDB.PRODDATACORE
inner join PRDB.ME meLo on melo.ExtId = PRODDATACORE.CoilId and meLo.meTyp = 'LO'
inner join PRDB.ME meOR on meOr.meId = PRODDATACORE.Meid 
left join PRDB.EDLOGENT on EDLOGENT.Meid = meLo.MEID and EDLOGENT.Source = 'E'
left join PRDB.Edordent on Edordent.Meid = PRODDATACORE.MEID and Edordent.Source = 'E'