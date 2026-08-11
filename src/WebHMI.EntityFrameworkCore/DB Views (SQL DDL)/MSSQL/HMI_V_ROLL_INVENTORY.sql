
CREATE   VIEW [PRDB].[HMI_V_ROLL_INVENTORY] AS
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
    RRU.rolledlength,
    RRU.rolledweight,
    RD.grinding,
    SYSDATETIME() AS GrindingTime,
    RD.relatedRollId,
    RD.plannedStandId,
    RD.plannedRollPos,
    RD.removeReason,
    RD.remarks,
    RD.rollChamferCode,
    RCH.description AS RollChamferDesc,
    RD.shimm,
    RD.roughness,
    RD.rolledStrips,
    DATEDIFF(MINUTE, RD.mountTime, RD.dismountTime) AS RolledTime,
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
    ON RD.rollId = RRU.rollid
GO


