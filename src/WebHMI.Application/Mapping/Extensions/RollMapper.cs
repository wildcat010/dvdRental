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
            DNeck = entity.DNeck,
            Description = entity.Description,
            LNeck = entity.LNeck,
            Length = entity.Length,
            PlantType = entity.PlantType,
            RollType = entity.RollType,
            StandRange = entity.StandRange,
        };

        public static void MapRollClassEntity(this RollClass entity, RollClassDto dto)
        {
            entity.RollClass1 = dto.RollClass;
            entity.CaliberDiaDiff = dto.CaliberDiaDiff;
            entity.CaliberLength = dto.CaliberLength;
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

        public static SingleRollDetailsDto ToRollDetailsDto(this RollDatum entity) => new()
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
            Roughness = entity.Roughness,
            ShapeCode = entity.RollShapeCode,
            Grinding = entity.Grinding,
            RelatedRollid = entity.RelatedRollId,
            MinDiameter = entity.MinDiameter,
            MaxDiameter = entity.MaxDiameter,
            RolledWeight = entity.RolledWeight,
            RolledLength = entity.RolledLength,
            RollChamferClassId = entity.RollChamferCode,
            Shimm = entity.Shimm,
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
            entity.MinDiameter = dto.MinDiameter;
            entity.MaxDiameter = dto.MaxDiameter;
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
            Rollid = entity.Rollid,
            Rolltype = entity.Rolltype,
            Planttype = entity.Planttype,
            Standid = entity.Standid,
            Stat = entity.Stat,
            Rollpos = entity.Rollpos,
            Diameter = entity.Diameter,
            Rollclass = entity.Rollclass,
            RollClassName = entity.Rollclassdesc,
            RollPropertyClass = entity.Rollpropertyclass,
            RollPropertyClassName = entity.Rollpropertydesc,
            Mounttime = entity.Mounttime,
            Dismounttime = entity.Dismounttime,
            Grinding = entity.Grinding,
            RolledWeight = entity.Rolledweight,
            RolledLength = entity.Rolledlength,
            RelatedRollid = entity.Relatedrollid,
            ResonId = entity.Removereason,
            Remarks = entity.Remarks,
            RollChamferClassId = entity.Rollchamfercode,
            Shimm = entity.Shimm
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
        }
    }
}
