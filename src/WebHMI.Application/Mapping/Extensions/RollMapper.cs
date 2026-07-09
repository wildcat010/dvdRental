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
        public static RollClassDto ToRollClassDto(this Rollclass entity) => new()
        {
            RollClass = entity.Rollclass1,
            CaliberDiaDiff = entity.Caliberdiadiff,
            CaliberLength = entity.Caliberlength,
            CheckerHeight = entity.Checkerheight,
            CheckerRoll = entity.Checkerroll,
            DNeck = entity.Dneck,
            Description = entity.Description,
            LNeck = entity.Lneck,
            Length = entity.Length,
            PlantType = entity.Planttype,
            RollType = entity.Rolltype,
            StandRange = entity.Standrange,
            Toc = entity.Toc,
            Tom = entity.Tom,
        };

        public static void MapRollClassEntity(this Rollclass entity, RollClassDto dto)
        {
            entity.Rollclass1 = dto.RollClass;
            entity.Caliberdiadiff = dto.CaliberDiaDiff;
            entity.Caliberlength = dto.CaliberLength;
            entity.Checkerheight = dto.CheckerHeight;
            entity.Checkerroll = dto.CheckerRoll;
            entity.Dneck = dto.DNeck;
            entity.Description = dto.Description;
            entity.Lneck = dto.LNeck;
            entity.Length = dto.Length;
            entity.Planttype = dto.PlantType;
            entity.Rolltype = dto.RollType;
            entity.Standrange = dto.StandRange;
        }

        public static Rollclass ToRollClassEntity(this RollClassDto dto)
        {
            var entity = new Rollclass();
            entity.MapRollClassEntity(dto);
            return entity;
        }

        public static RollChamferDto ToRollChamferDto(this Rollchamfer entity) => new()
        {
            Rollchamferclass = entity.Rollchamferclass,
            Conedistds = entity.Conedistds,
            Conedistos = entity.Conedistos,
            Coneheightds = entity.Coneheightds,
            Coneheightos = entity.Coneheightos,
            Conelengthds = entity.Conelengthds,
            Conelengthos = entity.Conelengthos,
            Conetype = entity.Conetype,
            Description = entity.Description,
            Standrange = entity.Standrange,
        };

        public static void MapRollChamferEntity(this Rollchamfer entity, RollChamferDto dto)
        {
            entity.Rollchamferclass = dto.Rollchamferclass;
            entity.Conedistds = dto.Conedistds;
            entity.Conedistos = dto.Conedistos;
            entity.Coneheightds = dto.Coneheightds;
            entity.Coneheightos = dto.Coneheightos;
            entity.Conelengthds = dto.Conelengthds;
            entity.Conelengthos = dto.Conelengthos;
            entity.Conetype = dto.Conetype;
            entity.Description = dto.Description;
            entity.Standrange = dto.Standrange;
        }

        public static Rollchamfer ToRollChamferEntity(this RollChamferDto dto)
        {
            var entity = new Rollchamfer();
            entity.MapRollChamferEntity(dto);
            return entity;
        }

        public static SingleRollDetailsDto ToRollDetailsDto(this HmiVRollInventory entity) => new()
        {
            Rollid = entity.Rollid,
            Planttype = entity.Planttype,
            Rolltype = entity.Rolltype,
            Diameter = entity.Diameter,
            InitTemp = entity.Inittemp,
            Stat = entity.Stat,
            Rollclass = entity.Rollclass,
            RollClassName = entity.Rollclassdesc,
            ShapeCode = entity.Shapecode,
            Mounttime = entity.Mounttime,
            Dismounttime = entity.Dismounttime,
            RollPropertyClass = entity.Rollpropertyclass,
            Rollpos = entity.Rollpos,
            Standid = entity.Standid,
            RolledLength = entity.Rolledlength,
            RolledWeight = entity.Rolledweight,
            Grinding = entity.Grinding,
            RelatedRollid = entity.Relatedrollid,
            PlannedStandId = entity.Plannedstandid,
            PlannedRollPos = entity.Plannedrollpos,
            ReasonId = entity.Removereason,
            Remarks = entity.Remarks,
            RollChamferClassId = entity.Rollchamfercode,
            Shimm = entity.Shimm,
            Roughness = entity.Roughness,
            StandRange = entity.Standrange
        };

        public static SingleRollDataCoreDto ToRollDataCoreDto(this Rolldatum entity) => new()
        {
            Rollid = entity.Rollid,
            Rolltype = entity.Rolltype,
            Planttype = entity.Planttype,
            Standid = entity.Standid,
            Stat = entity.Stat,
            Rollpos = entity.Rollpos,
            Diameter = entity.Diameter,
            Rollclass = entity.Rollclass,
            RollPropertyClass = entity.Rollpropertyclass,
            Mounttime = entity.Mounttime,
            Dismounttime = entity.Dismounttime,
            RolledWeight = entity.Rolledweight,
            RolledLength = entity.Rolledlength,
            RollChamferClassId = entity.Rollchamfercode,
            Shimm = entity.Shimm
        };

        public static Rolldatum ToRollDetailsEntity(this SingleRollDetailsDto dto)
        {
            var entity = new Rolldatum();
            entity.MapRollDetailsEntity(dto);
            return entity;
        }

        public static void MapRollDetailsEntity(this Rolldatum entity, SingleRollDetailsDto dto)
        {
            entity.Rollid = dto.Rollid;
            entity.Rolltype = dto.Rolltype;
            entity.Planttype = dto.Planttype;
            entity.Diameter = dto.Diameter;
            entity.Rollclass = dto.Rollclass;
            entity.Rollpropertyclass = dto.RollPropertyClass;
            entity.Roughness = dto.Roughness;
            entity.Rollshapecode = dto.ShapeCode;
            entity.Grinding = dto.Grinding;
            entity.Rollpos = dto.Rollpos;
            entity.Rollchamfercode = dto.RollChamferClassId;
            entity.Stat = dto.Stat;
            entity.Shimm = dto.Shimm;
            entity.Dismounttime = dto.Dismounttime;
            entity.Relatedrollid = dto.RelatedRollid;
        }

        public static SingleRollDataCoreDto ToRollDataCoreDto(this HmiVRollInventory entity) => new()
        {
            Rollid = entity.Rollid,
            Rolltype = entity.Rolltype,
            Planttype = entity.Planttype,
            Standid = entity.Standid,
            Stat = entity.Stat,
            Rollpos = entity.Rollpos,
            Diameter = entity.Diameter,
            Rollclass = entity.Rollclass,
            RollClassDesc = entity.Rollclassdesc,
            RollPropertyClass = entity.Rollpropertyclass,
            RollPropertyClassName = entity.Rollpropertydesc,
            Mounttime = entity.Mounttime,
            Dismounttime = entity.Dismounttime,
            Grinding = entity.Grinding,
            GrindingTime = entity.Grindingtime,
            RolledWeight = entity.Rolledweight,
            RolledLength = entity.Rolledlength,
            RelatedRollid = entity.Relatedrollid,
            ResonId = entity.Removereason,
            Remarks = entity.Remarks,
            RollChamferClassId = entity.Rollchamfercode,
            RollChamferDesc = entity.Rollchamferdesc,
            Shimm = entity.Shimm,
            PlannedInstallTime = entity.Plannedinstalltime,
            RollShapeCode = entity.Shapecode,
            RollShapeType = entity.Shapetype,
            RolledStrips = entity.Rolledstrips,
            RolledTime = (double?)entity.Rolledtime,
            Tom = entity.Tom
        };

        public static ShapeCodeDto ToShapeCodeDto(this Rollshapecoeff entity) => new()
        {
            ShapeCode = entity.Shapecode,
            Description = entity.Description,
            ShapeType = entity.Shapetype,
            ShapeX1 = entity.Shapex1,
            ShapeX2 = entity.Shapex2,
            ShapeX3 = entity.Shapex3,
            ShapeX4 = entity.Shapex4,
            ShapeX5 = entity.Shapex5,
            ShapeX6 = entity.Shapex6,
            ShapeX7 = entity.Shapex7,
            ShapeX8 = entity.Shapex8,
            ShapeX9 = entity.Shapex9,
        };

        public static RollPropertyClassDto ToRollPropertyClassDto(this Rollproperty entity) => new()
        {
            RollPropertyClass = entity.Rollpropertyclass,
            CwIn = entity.Cwin,
            CwOut = entity.Cwout,
            DensityIn = entity.Densityin,
            DensityOut = entity.Densityout,
            Description = entity.Description,
            EmodIn = entity.Emodin,
            EmodOut = entity.Emodout,
            ExpansionCoefIn = entity.Expansioncoefin,
            ExpansionCoefOut = entity.Expansioncoefout,
            HtEnv = entity.Htenv,
            HtEnv2 = entity.Htenv2,
            HtNeck = entity.Htneck,
            LambdaIn = entity.Lambdain,
            LambdaOut = entity.Lambdaout,
            PlantType = entity.Planttype,
            RollType = entity.Rolltype,
            TInit = entity.Tinit,
            TNeck = entity.Tneck,
            TNeckMax = entity.Tneckmax,
            WEffBotRoll = entity.Weffbotroll,
            WEffTopRoll = entity.Wefftoproll,
            YieldPolynomCInd0 = entity.YieldpolynomcInd0,
            YieldPolynomCInd1 = entity.YieldpolynomcInd1,
            YieldPolynomCInd2 = entity.YieldpolynomcInd2,
            YieldPolynomCInd3 = entity.YieldpolynomcInd3,
            YieldStress = entity.Yieldstress,
            Mop = entity.Mop,
            Toc = entity.Toc,
            Tom = entity.Tom,
        };

        public static Rollproperty ToRollPropertyEntity(this RollPropertyClassDto dto)
        {
            var entity = new Rollproperty();
            entity.MapRollPropertyEntity(dto);
            return entity;
        }

        public static void MapRollPropertyEntity(this Rollproperty entity, RollPropertyClassDto dto)
        {
            entity.Rollpropertyclass = dto.RollPropertyClass;
            entity.Cwin = dto.CwIn;
            entity.Cwout = dto.CwOut;
            entity.Densityin = dto.DensityIn;
            entity.Densityout = dto.DensityOut;
            entity.Description = dto.Description;
            entity.Emodin = dto.EmodIn;
            entity.Emodout = dto.EmodOut;
            entity.Expansioncoefin = dto.ExpansionCoefIn;
            entity.Expansioncoefout = dto.ExpansionCoefOut;
            entity.Htenv = dto.HtEnv;
            entity.Htenv2 = dto.HtEnv2;
            entity.Htneck = dto.HtNeck;
            entity.Lambdain = dto.LambdaIn;
            entity.Lambdaout = dto.LambdaOut;
            entity.Planttype = dto.PlantType;
            entity.Rolltype = dto.RollType;
            entity.Tinit = dto.TInit;
            entity.Tneck = dto.TNeck;
            entity.Tneckmax = dto.TNeckMax;
            entity.Weffbotroll = dto.WEffBotRoll;
            entity.Wefftoproll = dto.WEffTopRoll;
            entity.YieldpolynomcInd0 = dto.YieldPolynomCInd0;
            entity.YieldpolynomcInd1 = dto.YieldPolynomCInd1;
            entity.YieldpolynomcInd2 = dto.YieldPolynomCInd2;
            entity.YieldpolynomcInd3 = dto.YieldPolynomCInd3;
            entity.Yieldstress = dto.YieldStress;
        }

        public static RollShapeCoeffDto ToRollShapeCoeffDto(this Rollshapecoeff entity)
        {
            var dto = new RollShapeCoeffDto();
            dto.ShapeCode = entity.Shapecode;
            dto.Description = entity.Description;
            dto.ShapeType = entity.Shapetype;
            dto.ShapeX1 = entity.Shapex1;
            dto.ShapeX2 = entity.Shapex2;
            dto.ShapeX3 = entity.Shapex3;
            dto.ShapeX4 = entity.Shapex4;
            dto.ShapeX5 = entity.Shapex5;
            dto.ShapeX6 = entity.Shapex6;
            dto.ShapeX7 = entity.Shapex7;
            dto.ShapeX8 = entity.Shapex8;
            dto.ShapeX9 = entity.Shapex9;
            dto.StandRange = entity.Standrange;
            dto.ShapeCurveCode = entity.Shapecurvecode;

            return dto;
        }

        public static Rollshapecoeff ToRollShapeCoeffEntity(this RollShapeCoeffDto dto)
        {
            var entity = new Rollshapecoeff();
            entity.Shapecode = dto.ShapeCode;
            entity.Description = dto.Description;
            entity.Shapetype = dto.ShapeType;
            entity.Shapex1 = dto.ShapeX1;
            entity.Shapex2 = dto.ShapeX2;
            entity.Shapex3 = dto.ShapeX3;
            entity.Shapex4 = dto.ShapeX4;
            entity.Shapex5 = dto.ShapeX5;
            entity.Shapex6 = dto.ShapeX6;
            entity.Shapex7 = dto.ShapeX7;
            entity.Shapex8 = dto.ShapeX8;
            entity.Shapex9 = dto.ShapeX9;
            entity.Standrange = dto.StandRange;
            entity.Shapecurvecode = dto.ShapeCurveCode;

            return entity;
        }

        public static CustomRollShapeCurveDto ToCustomRollShapeCurve(this Rollshapecurvecustom entity)
        {
            var dto = new CustomRollShapeCurveDto();

            dto.Shapecurvecode = entity.Shapecurvecode;
            dto.Description = entity.Description;
            dto.Validpoints = entity.Validpoints;
            dto.Values = ToCustomRollShapeCurveValues(entity);

            return dto;
        }

        private static List<double> ToCustomRollShapeCurveValues(Rollshapecurvecustom entity)
        {
            return entity.GetType()
                .GetProperties()
                .Where(prop => prop.Name.StartsWith("ValueInd", StringComparison.OrdinalIgnoreCase))
                .Select(prop => new { Number = int.Parse(prop.Name["ValueInd".Length..]), Value = (double)prop.GetValue(entity) })
                .OrderBy(x => x.Number)
                .Select(x => x.Value)
                .ToList();
        }

        public static CustomRollShapeCurveItem ToCustomRollShapeCurveItem(this Rollshapecurvecustom entity)
        {
            var curveItem = new CustomRollShapeCurveItem();

            curveItem.ShapeCurveCode = entity.Shapecurvecode;
            curveItem.ValidPoints = entity.Validpoints;
            curveItem.Description = entity.Description;

            return curveItem;
        }


    }
}
