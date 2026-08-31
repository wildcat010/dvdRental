using Abp;
using Castle.MicroKernel.Internal;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.API.Prdb;
using WebHMI.Dtos;
using WebHMI.Dtos.Roll;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
    public static class RollMapper
    {
        public static RollClassDto ToRollClassDto(this RollClass entity) => new()
        {
            RollClass = entity.RollClass1,
            CaliberDiaDiff = entity.CaliberDiaDiff,
            CaliberLength = entity.CaliberLength,
            CheckerHeight = entity.CheckerHeight,
            CheckerRoll = entity.CheckerRoll,
            DNeck = entity.DNeck,
            Description = entity.Description,
            LNeck = entity.LNeck,
            Length = entity.Length,
            PlantType = entity.PlantType,
            RollType = entity.RollType,
            StandRange = entity.StandRange,
            Toc = entity.Toc,
            Tom = entity.Tom,
        };

        public static void MapRollClassEntity(this RollClass entity, RollClassDto dto)
        {
            entity.RollClass1 = dto.RollClass;
            entity.CaliberDiaDiff = dto.CaliberDiaDiff;
            entity.CaliberLength = dto.CaliberLength;
            entity.CheckerHeight = dto.CheckerHeight;
            entity.CheckerRoll = dto.CheckerRoll;
            entity.DNeck = dto.DNeck;
            entity.Description = dto.Description;
            entity.LNeck = dto.LNeck;
            entity.Length = dto.Length;
            entity.PlantType = dto.PlantType;
            entity.RollType = dto.RollType;
            entity.StandRange = dto.StandRange;
        }

        public static RollClass ToRollClassEntity(this RollClassDto dto)
        {
            var entity = new RollClass();
            entity.MapRollClassEntity(dto);
            return entity;
        }

        public static RollChamferDto ToRollChamferDto(this RollChamfer entity) => new()
        {
            Rollchamferclass = entity.RollChamferClass,
            Conedistds = entity.ConeDistDs,
            Conedistos = entity.ConeDistOs,
            Coneheightds = entity.ConeHeightDs,
            Coneheightos = entity.ConeHeightOs,
            Conelengthds = entity.ConeLengthDs,
            Conelengthos = entity.ConeLengthOs,
            Conetype = entity.ConeType,
            Description = entity.Description,
            Standrange = entity.StandRange,
        };

        public static void MapRollChamferEntity(this RollChamfer entity, RollChamferDto dto)
        {
            entity.RollChamferClass = dto.Rollchamferclass;
            entity.ConeDistDs = dto.Conedistds;
            entity.ConeDistOs = dto.Conedistos;
            entity.ConeHeightDs = dto.Coneheightds;
            entity.ConeHeightOs = dto.Coneheightos;
            entity.ConeLengthDs = dto.Conelengthds;
            entity.ConeLengthOs = dto.Conelengthos;
            entity.ConeType = dto.Conetype;
            entity.Description = dto.Description;
            entity.StandRange = dto.Standrange;
        }

        public static RollChamfer ToRollChamferEntity(this RollChamferDto dto)
        {
            var entity = new RollChamfer();
            entity.MapRollChamferEntity(dto);
            return entity;
        }

        public static SingleRollDetailsDto ToRollDetailsDto(this HmiVRollInventory entity) => new()
        {
            Rollid = entity.RollId,
            Planttype = entity.PlantType,
            Rolltype = entity.RollType,
            Diameter = entity.Diameter,
            InitTemp = entity.InitTemp,
            Stat = entity.Stat,
            Rollclass = entity.RollClass,
            RollClassName = entity.Rollclassdesc,
            ShapeCode = entity.Shapecode,
            Mounttime = entity.MountTime,
            Dismounttime = entity.DismountTime,
            RollPropertyClass = entity.RollPropertyClass,
            Rollpos = entity.RollPos,
            Standid = entity.StandId,
            RolledLength = entity.Rolledlength,
            RolledWeight = entity.Rolledweight,
            Grinding = entity.Grinding,
            RelatedRollid = entity.RelatedRollId,
            PlannedStandId = entity.PlannedStandId,
            PlannedRollPos = entity.PlannedRollPos,
            ReasonId = entity.RemoveReason,
            Remarks = entity.Remarks,
            RollChamferClassId = entity.RollChamferCode,
            Shimm = entity.Shimm,
            Roughness = entity.Roughness,
            StandRange = entity.StandRange
        };

        public static SingleRollDataCoreDto ToRollDataCoreDto(this RollDatum entity) => new()
        {
            Rollid = entity.RollId,
            Rolltype = entity.RollType,
            Planttype = entity.PlantType,
            Standid = entity.StandId,
            Stat = entity.Stat,
            Rollpos = entity.RollPos,
            Diameter = entity.Diameter,
            Rollclass = entity.RollClass,
            RollPropertyClass = entity.RollPropertyClass,
            Mounttime = entity.MountTime,
            Dismounttime = entity.DismountTime,
            RolledWeight = entity.RolledWeight,
            RolledLength = entity.RolledLength,
            RollChamferClassId = entity.RollChamferCode,
            Shimm = entity.Shimm
        };

        public static RollDatum ToRollDetailsEntity(this SingleRollDetailsDto dto)
        {
            var entity = new RollDatum();
            entity.MapRollDetailsEntity(dto);
            return entity;
        }

        public static void MapRollDetailsEntity(this RollDatum entity, SingleRollDetailsDto dto)
        {
            entity.RollId = dto.Rollid;
            entity.RollType = dto.Rolltype;
            entity.PlantType = dto.Planttype;
            entity.Diameter = dto.Diameter;
            entity.RollClass = dto.Rollclass;
            entity.RollPropertyClass = dto.RollPropertyClass;
            entity.StandId = dto.Standid;
            entity.InitTemp = dto.InitTemp;
            entity.Roughness = dto.Roughness;
            entity.RollShapeCode = dto.ShapeCode;
            entity.Grinding = dto.Grinding;
            entity.RollPos = dto.Rollpos;
            entity.RollChamferCode = dto.RollChamferClassId;
            entity.Stat = dto.Stat;
            entity.Shimm = dto.Shimm;
            entity.DismountTime = dto.Dismounttime;
            entity.RelatedRollId = dto.RelatedRollid;
        }

        public static SingleRollDataCoreDto ToRollDataCoreDto(this HmiVRollInventory entity) => new()
        {
            Rollid = entity.RollId,
            Rolltype = entity.RollType,
            Planttype = entity.PlantType,
            Standid = entity.StandId,
            Stat = entity.Stat,
            Rollpos = entity.RollPos,
            Diameter = entity.Diameter,
            Rollclass = entity.RollClass,
            RollClassDesc = entity.Rollclassdesc,
            RollPropertyClass = entity.RollPropertyClass,
            RollPropertyClassName = entity.Rollpropertydesc,
            Mounttime = entity.MountTime,
            Dismounttime = entity.DismountTime,
            Grinding = entity.Grinding,
            GrindingTime = entity.GrindingTime,
            RolledWeight = entity.Rolledweight,
            RolledLength = entity.Rolledlength,
            RelatedRollid = entity.RelatedRollId,
            ResonId = entity.RemoveReason,
            Remarks = entity.Remarks,
            RollChamferClassId = entity.RollChamferCode,
            RollChamferDesc = entity.RollChamferDesc,
            Shimm = entity.Shimm,
            PlannedInstallTime = entity.PlannedInstallTime,
            RollShapeCode = entity.Shapecode,
            RollShapeType = entity.ShapeType,
            RolledStrips = entity.RolledStrips,
            RolledTime = (double?)entity.RolledTime,
            Tom = entity.Tom
        };

        public static ShapeCodeDto ToShapeCodeDto(this RollShapeCoeff entity) => new()
        {
            ShapeCode = entity.ShapeCode,
            Description = entity.Description,
            ShapeType = entity.ShapeType,
            ShapeX1 = entity.ShapeX1,
            ShapeX2 = entity.ShapeX2,
            ShapeX3 = entity.ShapeX3,
            ShapeX4 = entity.ShapeX4,
            ShapeX5 = entity.ShapeX5,
            ShapeX6 = entity.ShapeX6,
            ShapeX7 = entity.ShapeX7,
            ShapeX8 = entity.ShapeX8,
            ShapeX9 = entity.ShapeX9,
        };

        public static RollPropertyClassDto ToRollPropertyClassDto(this RollProperty entity) => new()
        {
            RollPropertyClass = entity.RollPropertyClass,
            CwIn = entity.CwIn,
            CwOut = entity.CwOut,
            DensityIn = entity.DensityIn,
            DensityOut = entity.DensityOut,
            Description = entity.Description,
            EmodIn = entity.EmodIn,
            EmodOut = entity.EmodOut,
            ExpansionCoefIn = entity.ExpansionCoefIn,
            ExpansionCoefOut = entity.ExpansionCoefOut,
            HtEnv = entity.HtEnv,
            HtEnv2 = entity.HtEnv2,
            HtNeck = entity.HtNeck,
            LambdaIn = entity.LambdaIn,
            LambdaOut = entity.LambdaOut,
            PlantType = entity.PlantType,
            RollType = entity.RollType,
            TInit = entity.TInit,
            TNeck = entity.TNeck,
            TNeckMax = entity.TNeckMax,
            WEffBotRoll = entity.WEffBotRoll,
            WEffTopRoll = entity.WEffTopRoll,
            YieldPolynomCInd0 = entity.YieldPolynomCInd0,
            YieldPolynomCInd1 = entity.YieldPolynomCInd1,
            YieldPolynomCInd2 = entity.YieldPolynomCInd2,
            YieldPolynomCInd3 = entity.YieldPolynomCInd3,
            YieldStress = entity.YieldStress,
            Mop = entity.Mop,
            Toc = entity.Toc,
            Tom = entity.Tom,
        };

        public static RollProperty ToRollPropertyEntity(this RollPropertyClassDto dto)
        {
            var entity = new RollProperty();
            entity.MapRollPropertyEntity(dto);
            return entity;
        }

        public static void MapRollPropertyEntity(this RollProperty entity, RollPropertyClassDto dto)
        {
            entity.RollPropertyClass = dto.RollPropertyClass;
            entity.CwIn = dto.CwIn;
            entity.CwOut = dto.CwOut;
            entity.DensityIn = dto.DensityIn;
            entity.DensityOut = dto.DensityOut;
            entity.Description = dto.Description;
            entity.EmodIn = dto.EmodIn;
            entity.EmodOut = dto.EmodOut;
            entity.ExpansionCoefIn = dto.ExpansionCoefIn;
            entity.ExpansionCoefOut = dto.ExpansionCoefOut;
            entity.HtEnv = dto.HtEnv;
            entity.HtEnv2 = dto.HtEnv2;
            entity.HtNeck = dto.HtNeck;
            entity.LambdaIn = dto.LambdaIn;
            entity.LambdaOut = dto.LambdaOut;
            entity.PlantType = dto.PlantType;
            entity.RollType = dto.RollType;
            entity.TInit = dto.TInit;
            entity.TNeck = dto.TNeck;
            entity.TNeckMax = dto.TNeckMax;
            entity.WEffBotRoll = dto.WEffBotRoll;
            entity.WEffTopRoll = dto.WEffTopRoll;
            entity.YieldPolynomCInd0 = dto.YieldPolynomCInd0;
            entity.YieldPolynomCInd1 = dto.YieldPolynomCInd1;
            entity.YieldPolynomCInd2 = dto.YieldPolynomCInd2;
            entity.YieldPolynomCInd3 = dto.YieldPolynomCInd3;
            entity.YieldStress = dto.YieldStress;
        }

        public static RollShapeCoeffDto ToRollShapeCoeffDto(this RollShapeCoeff entity)
        {
            var dto = new RollShapeCoeffDto();
            dto.ShapeCode = entity.ShapeCode;
            dto.Description = entity.Description;
            dto.ShapeType = entity.ShapeType;
            dto.ShapeX1 = entity.ShapeX1;
            dto.ShapeX2 = entity.ShapeX2;
            dto.ShapeX3 = entity.ShapeX3;
            dto.ShapeX4 = entity.ShapeX4;
            dto.ShapeX5 = entity.ShapeX5;
            dto.ShapeX6 = entity.ShapeX6;
            dto.ShapeX7 = entity.ShapeX7;
            dto.ShapeX8 = entity.ShapeX8;
            dto.ShapeX9 = entity.ShapeX9;
            dto.StandRange = entity.StandRange;
            dto.ShapeCurveCode = entity.ShapeCurveCode;

            return dto;
        }

        public static RollShapeCoeff ToRollShapeCoeffEntity(this RollShapeCoeffDto dto)
        {
            var entity = new RollShapeCoeff();
            entity.ShapeCode = dto.ShapeCode;
            entity.Description = dto.Description;
            entity.ShapeType = dto.ShapeType;
            entity.ShapeX1 = dto.ShapeX1;
            entity.ShapeX2 = dto.ShapeX2;
            entity.ShapeX3 = dto.ShapeX3;
            entity.ShapeX4 = dto.ShapeX4;
            entity.ShapeX5 = dto.ShapeX5;
            entity.ShapeX6 = dto.ShapeX6;
            entity.ShapeX7 = dto.ShapeX7;
            entity.ShapeX8 = dto.ShapeX8;
            entity.ShapeX9 = dto.ShapeX9;
            entity.StandRange = dto.StandRange;
            entity.ShapeCurveCode = dto.ShapeCurveCode;

            return entity;
        }

        public static CustomRollShapeCurveDto ToCustomRollShapeCurve(this RollShapeCurveCustom entity)
        {
            var dto = new CustomRollShapeCurveDto();

            dto.Shapecurvecode = entity.ShapeCurveCode;
            dto.Description = entity.Description;
            dto.Validpoints = entity.ValidPoints;
            dto.Values = ToCustomRollShapeCurveValues(entity);

            return dto;
        }

        private static List<double> ToCustomRollShapeCurveValues(RollShapeCurveCustom entity)
        {
            return entity.GetType()
                .GetProperties()
                .Where(prop => prop.Name.StartsWith("ValueInd", StringComparison.OrdinalIgnoreCase))
                .Select(prop => new { Number = int.Parse(prop.Name["ValueInd".Length..]), Value = (double)prop.GetValue(entity) })
                .OrderBy(x => x.Number)
                .Select(x => x.Value)
                .ToList();
        }

        public static CustomRollShapeCurveItem ToCustomRollShapeCurveItem(this RollShapeCurveCustom entity)
        {
            var curveItem = new CustomRollShapeCurveItem();

            curveItem.ShapeCurveCode = entity.ShapeCurveCode;
            curveItem.ValidPoints = entity.ValidPoints;
            curveItem.Description = entity.Description;

            return curveItem;
        }


    }
}
