CREATE VIEW HMI_V_ROLLINGHISTORYSEQ
AS
     select   ROW_NUMBER() OVER (ORDER BY ProdSchedule.majorno, PRODSCHEDULE.minorno) AS Position, ProdSchedule.meId as enphmeid, e.enormeid, e.EnOrMeType,  e.enorextid, e.enorcreator, e.enorstatus, null as optstatdatetime from ProdSchedule inner join v_mat_struct_entry e on e.enphmeid = ProdSchedule.meId
	 union
select -1 as seqno, e.EnPhMeID , e.enormeid, e.enormetype, e.enorextid, e.enorcreator, e.enorstatus, opt.dateTime as opstatdatetime from v_mat_struct_entry e
inner join operTime opt on opt.meid = e.EnphMeid and opt.status = 1 and e.enormesid = 1;