
  CREATE OR REPLACE FORCE EDITIONABLE VIEW "PRDB"."HMI_V_ROLL_INVENTORY" ("ROLLID", "PLANTTYPE", "ROLLTYPE", "DIAMETER", "STAT", "INITTEMP", "ROLLCLASS", "ROLLCLASSDESC", "SHAPECODE", "SHAPETYPE", "STANDRANGE", "PLANNEDINSTALLTIME", "MOUNTTIME", "DISMOUNTTIME", "ROLLPROPERTYCLASS", "ROLLPROPERTYDESC", "ROLLPOS", "STANDID", "ROLLEDLENGTH", "ROLLEDWEIGHT", "GRINDING", "GRINDINGTIME", "RELATEDROLLID", "PLANNEDSTANDID", "PLANNEDROLLPOS", "REMOVEREASON", "REMARKS", "ROLLCHAMFERCODE", "ROLLCHAMFERDESC", "SHIMM", "ROUGHNESS", "ROLLEDSTRIPS", "ROLLEDTIME", "TOM") AS 
  SELECT
    RD.rollId,
    RD.plantType,
    RD.rollType,
    RD.diameter,
    RD.stat,
    RD.initTemp,
    RC.rollClass,
    RC.description AS ROLLCLASSDESC,
    RD.rollShapeCode AS SHAPECODE,
    RSC.shapeType,
    RC.standRange,
    RD.plannedInstallTime,
    RD.mountTime,
    RD.dismountTime,
    RP.rollPropertyClass,
    RP.description AS ROLLPROPERTYDESC,
    RD.rollPos,
    RD.standId,
    RD.ROLLEDLENGTHACT as rolledlength,
    RD.ROLLEDWEIGTHACT  as rolledweight,
    RD.grinding,
    SYS_EXTRACT_UTC(SYSTIMESTAMP) AS GrindingTime,
    RD.relatedRollId,
    RD.plannedStandId,
    RD.plannedRollPos,
    RD.removeReason,
    RD.remarks,
    RD.rollChamferCode,
    RCH.description AS RollChamferDesc,
    RD.shimm,
    RD.roughness,
    RRU.rolledStrips,
    rru.rolledtime AS RolledTime,
    RD.tom
FROM RollData RD
JOIN RollClass RC
    ON RD.rollClass = RC.rollClass
JOIN RollProperty RP
    ON RD.rollPropertyClass = RP.rollPropertyClass
LEFT JOIN RollShapeCoeff RSC
    ON RD.rollShapeCode = RSC.shapeCode
LEFT JOIN RollChamfer RCH
    ON RD.rollChamferCode = RCH.rollChamferClass
LEFT JOIN hmi_v_rolld_rollusage RRU
    ON RD.rollId = RRU.rollid;

