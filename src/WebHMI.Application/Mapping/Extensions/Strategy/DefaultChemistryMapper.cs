using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using WebHMI.Dtos.Common;
using WebHMI.Dtos.Strategy.DefaultChemistry;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public static class DefaultChemistryMapper
    {
        public static void UpdateMapEntity(MatDat entity, DefaultChemistryDto dto)
        {
            entity.AlloyCode = dto.Alloycode;
            entity.Description = dto.Description;

            entity.CaInd00 = dto.ChemistryElement0.Value;
            entity.CaInd01 = dto.ChemistryElement1.Value;
            entity.CaInd02 = dto.ChemistryElement2.Value;
            entity.CaInd03 = dto.ChemistryElement3.Value;
            entity.CaInd04 = dto.ChemistryElement4.Value;
            entity.CaInd05 = dto.ChemistryElement5.Value;
            entity.CaInd06 = dto.ChemistryElement6.Value;
            entity.CaInd07 = dto.ChemistryElement7.Value;
            entity.CaInd08 = dto.ChemistryElement8.Value;
            entity.CaInd09 = dto.ChemistryElement9.Value;
            entity.CaInd10 = dto.ChemistryElement10.Value;
            entity.CaInd11 = dto.ChemistryElement11.Value;
            entity.CaInd12 = dto.ChemistryElement12.Value;
            entity.CaInd13 = dto.ChemistryElement13.Value;
            entity.CaInd14 = dto.ChemistryElement14.Value;
            entity.CaInd15 = dto.ChemistryElement15.Value;
            entity.CaInd16 = dto.ChemistryElement16.Value;
            entity.CaInd17 = dto.ChemistryElement17.Value;
            entity.CaInd18 = dto.ChemistryElement18.Value;
            entity.CaInd19 = dto.ChemistryElement19.Value;
            entity.CaInd20 = dto.ChemistryElement20.Value;
            entity.CaInd21 = dto.ChemistryElement21.Value;
            entity.CaInd22 = dto.ChemistryElement22.Value;
            entity.CaInd23 = dto.ChemistryElement23.Value;
            entity.CaInd24 = dto.ChemistryElement24.Value;
            entity.CaInd25 = dto.ChemistryElement25.Value;
            entity.CaInd26 = dto.ChemistryElement26.Value;
            entity.CaInd27 = dto.ChemistryElement27.Value;
            entity.CaInd28 = dto.ChemistryElement28.Value;
            entity.CaInd29 = dto.ChemistryElement29.Value;
            entity.CaInd30 = dto.ChemistryElement30.Value;
            entity.CaInd31 = dto.ChemistryElement31.Value;
            entity.CaInd32 = dto.ChemistryElement32.Value;
            entity.CaInd33 = dto.ChemistryElement33.Value;
            entity.CaInd34 = dto.ChemistryElement34.Value;
            entity.CaInd35 = dto.ChemistryElement35.Value;
            entity.CaInd36 = dto.ChemistryElement36.Value;
            entity.CaInd37 = dto.ChemistryElement37.Value;
            entity.CaInd38 = dto.ChemistryElement38.Value;
            entity.CaInd39 = dto.ChemistryElement39.Value;
        }

        public static void InsertMapEntity(MatDat entity, DefaultChemistryDto dto)
        {
            entity.AlloyCode = dto.Alloycode;
            entity.Description = dto.Description;

            entity.CaInd00 = dto.ChemistryElement0.Value;
            entity.CaInd01 = dto.ChemistryElement1.Value;
            entity.CaInd02 = dto.ChemistryElement2.Value;
            entity.CaInd03 = dto.ChemistryElement3.Value;
            entity.CaInd04 = dto.ChemistryElement4.Value;
            entity.CaInd05 = dto.ChemistryElement5.Value;
            entity.CaInd06 = dto.ChemistryElement6.Value;
            entity.CaInd07 = dto.ChemistryElement7.Value;
            entity.CaInd08 = dto.ChemistryElement8.Value;
            entity.CaInd09 = dto.ChemistryElement9.Value;
            entity.CaInd10 = dto.ChemistryElement10.Value;
            entity.CaInd11 = dto.ChemistryElement11.Value;
            entity.CaInd12 = dto.ChemistryElement12.Value;
            entity.CaInd13 = dto.ChemistryElement13.Value;
            entity.CaInd14 = dto.ChemistryElement14.Value;
            entity.CaInd15 = dto.ChemistryElement15.Value;
            entity.CaInd16 = dto.ChemistryElement16.Value;
            entity.CaInd17 = dto.ChemistryElement17.Value;
            entity.CaInd18 = dto.ChemistryElement18.Value;
            entity.CaInd19 = dto.ChemistryElement19.Value;
            entity.CaInd20 = dto.ChemistryElement20.Value;
            entity.CaInd21 = dto.ChemistryElement21.Value;
            entity.CaInd22 = dto.ChemistryElement22.Value;
            entity.CaInd23 = dto.ChemistryElement23.Value;
            entity.CaInd24 = dto.ChemistryElement24.Value;
            entity.CaInd25 = dto.ChemistryElement25.Value;
            entity.CaInd26 = dto.ChemistryElement26.Value;
            entity.CaInd27 = dto.ChemistryElement27.Value;
            entity.CaInd28 = dto.ChemistryElement28.Value;
            entity.CaInd29 = dto.ChemistryElement29.Value;
            entity.CaInd30 = dto.ChemistryElement30.Value;
            entity.CaInd31 = dto.ChemistryElement31.Value;
            entity.CaInd32 = dto.ChemistryElement32.Value;
            entity.CaInd33 = dto.ChemistryElement33.Value;
            entity.CaInd34 = dto.ChemistryElement34.Value;
            entity.CaInd35 = dto.ChemistryElement35.Value;
            entity.CaInd36 = dto.ChemistryElement36.Value;
            entity.CaInd37 = dto.ChemistryElement37.Value;
            entity.CaInd38 = dto.ChemistryElement38.Value;
            entity.CaInd39 = dto.ChemistryElement39.Value;

            entity.CnInd00 = Encode(dto.ChemistryElement0.Name);
            entity.CnInd01 = Encode(dto.ChemistryElement1.Name);
            entity.CnInd02 = Encode(dto.ChemistryElement2.Name);
            entity.CnInd03 = Encode(dto.ChemistryElement3.Name);
            entity.CnInd04 = Encode(dto.ChemistryElement4.Name);
            entity.CnInd05 = Encode(dto.ChemistryElement5.Name);
            entity.CnInd06 = Encode(dto.ChemistryElement6.Name);
            entity.CnInd07 = Encode(dto.ChemistryElement7.Name);
            entity.CnInd08 = Encode(dto.ChemistryElement8.Name);
            entity.CnInd09 = Encode(dto.ChemistryElement9.Name);
            entity.CnInd10 = Encode(dto.ChemistryElement10.Name);
            entity.CnInd11 = Encode(dto.ChemistryElement11.Name);
            entity.CnInd12 = Encode(dto.ChemistryElement12.Name);
            entity.CnInd13 = Encode(dto.ChemistryElement13.Name);
            entity.CnInd14 = Encode(dto.ChemistryElement14.Name);
            entity.CnInd15 = Encode(dto.ChemistryElement15.Name);
            entity.CnInd16 = Encode(dto.ChemistryElement16.Name);
            entity.CnInd17 = Encode(dto.ChemistryElement17.Name);
            entity.CnInd18 = Encode(dto.ChemistryElement18.Name);
            entity.CnInd19 = Encode(dto.ChemistryElement19.Name);
            entity.CnInd20 = Encode(dto.ChemistryElement20.Name);
            entity.CnInd21 = Encode(dto.ChemistryElement21.Name);
            entity.CnInd22 = Encode(dto.ChemistryElement22.Name);
            entity.CnInd23 = Encode(dto.ChemistryElement23.Name);
            entity.CnInd24 = Encode(dto.ChemistryElement24.Name);
            entity.CnInd25 = Encode(dto.ChemistryElement25.Name);
            entity.CnInd26 = Encode(dto.ChemistryElement26.Name);
            entity.CnInd27 = Encode(dto.ChemistryElement27.Name);
            entity.CnInd28 = Encode(dto.ChemistryElement28.Name);
            entity.CnInd29 = Encode(dto.ChemistryElement29.Name);
            entity.CnInd30 = Encode(dto.ChemistryElement30.Name);
            entity.CnInd31 = Encode(dto.ChemistryElement31.Name);
            entity.CnInd32 = Encode(dto.ChemistryElement32.Name);
            entity.CnInd33 = Encode(dto.ChemistryElement33.Name);
            entity.CnInd34 = Encode(dto.ChemistryElement34.Name);
            entity.CnInd35 = Encode(dto.ChemistryElement35.Name);
            entity.CnInd36 = Encode(dto.ChemistryElement36.Name);
            entity.CnInd37 = Encode(dto.ChemistryElement37.Name);
            entity.CnInd38 = Encode(dto.ChemistryElement38.Name);
            entity.CnInd39 = Encode(dto.ChemistryElement39.Name);
        }

        public static DefaultChemistryDto ToDto(MatDat entity) => new()
        {
            Alloycode = entity.AlloyCode,
            Description = entity.Description,

            ChemistryElement0 = new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd00),
                Value = entity.CaInd00
            },
            ChemistryElement1 = new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd01),
                Value = entity.CaInd01
            },
            ChemistryElement2 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd02),
                Value = entity.CaInd02
            },
            ChemistryElement3 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd03),
                Value = entity.CaInd03
            },
            ChemistryElement4 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd04),
                Value = entity.CaInd04
            },
            ChemistryElement5 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd05),
                Value = entity.CaInd05
            },
            ChemistryElement6 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd06),
                Value = entity.CaInd06
            },
            ChemistryElement7 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd07),
                Value = entity.CaInd07
            },
            ChemistryElement8 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd08),
                Value = entity.CaInd08
            },
            ChemistryElement9 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd09),
                Value = entity.CaInd09
            },
            ChemistryElement10 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd10),
                Value = entity.CaInd10
            },
            ChemistryElement11 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd11),
                Value = entity.CaInd11
            },
            ChemistryElement12 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd12),
                Value = entity.CaInd12
            },
            ChemistryElement13 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd13),
                Value = entity.CaInd13
            },
            ChemistryElement14 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd14),
                Value = entity.CaInd14
            },
            ChemistryElement15 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd15),
                Value = entity.CaInd15
            },
            ChemistryElement16 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd16),
                Value = entity.CaInd16
            },
            ChemistryElement17 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd17),
                Value = entity.CaInd17
            },
            ChemistryElement18 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd18),
                Value = entity.CaInd18
            },
            ChemistryElement19 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd19),
                Value = entity.CaInd19
            },
            ChemistryElement20 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd20),
                Value = entity.CaInd20
            },
            ChemistryElement21 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd21),
                Value = entity.CaInd21
            },
            ChemistryElement22 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd22),
                Value = entity.CaInd22
            },
            ChemistryElement23 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd23),
                Value = entity.CaInd23
            },
            ChemistryElement24 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd24),
                Value = entity.CaInd24
            },
            ChemistryElement25 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd25),
                Value = entity.CaInd25
            },
            ChemistryElement26 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd26),
                Value = entity.CaInd26
            },
            ChemistryElement27 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd27),
                Value = entity.CaInd27
            },
            ChemistryElement28 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd28),
                Value = entity.CaInd28
            },
            ChemistryElement29 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd29),
                Value = entity.CaInd29
            },
            ChemistryElement30 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd30),
                Value = entity.CaInd30
            },
            ChemistryElement31 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd31),
                Value = entity.CaInd31
            },
            ChemistryElement32 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd32),
                Value = entity.CaInd32
            },
            ChemistryElement33 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd33),
                Value = entity.CaInd33
            },
            ChemistryElement34 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd34),
                Value = entity.CaInd34
            },
            ChemistryElement35 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd35),
                Value = entity.CaInd35
            },
            ChemistryElement36 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd36),
                Value = entity.CaInd36
            },
            ChemistryElement37 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd37),
                Value = entity.CaInd37
            },
            ChemistryElement38 =  new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd38),
                Value = entity.CaInd38
            },
            ChemistryElement39 = new ApsChemistryElement()
            {
                Name = Decode(entity.CnInd39),
                Value = entity.CaInd39
            },
            Total = SumCaInd(entity)
        };

        private static double SumCaInd(MatDat entity)
        {
            return
                (entity.CaInd00 ?? 0.0) +
                (entity.CaInd01 ?? 0.0) +
                (entity.CaInd02 ?? 0.0) +
                (entity.CaInd03 ?? 0.0) +
                (entity.CaInd04 ?? 0.0) +
                (entity.CaInd05 ?? 0.0) +
                (entity.CaInd06 ?? 0.0) +
                (entity.CaInd07 ?? 0.0) +
                (entity.CaInd08 ?? 0.0) +
                (entity.CaInd09 ?? 0.0) +
                (entity.CaInd10 ?? 0.0) +
                (entity.CaInd11 ?? 0.0) +
                (entity.CaInd12 ?? 0.0) +
                (entity.CaInd13 ?? 0.0) +
                (entity.CaInd14 ?? 0.0) +
                (entity.CaInd15 ?? 0.0) +
                (entity.CaInd16 ?? 0.0) +
                (entity.CaInd17 ?? 0.0) +
                (entity.CaInd18 ?? 0.0) +
                (entity.CaInd19 ?? 0.0) +
                (entity.CaInd20 ?? 0.0) +
                (entity.CaInd21 ?? 0.0) +
                (entity.CaInd22 ?? 0.0) +
                (entity.CaInd23 ?? 0.0) +
                (entity.CaInd24 ?? 0.0) +
                (entity.CaInd25 ?? 0.0) +
                (entity.CaInd26 ?? 0.0) +
                (entity.CaInd27 ?? 0.0) +
                (entity.CaInd28 ?? 0.0) +
                (entity.CaInd29 ?? 0.0) +
                (entity.CaInd30 ?? 0.0) +
                (entity.CaInd31 ?? 0.0) +
                (entity.CaInd32 ?? 0.0) +
                (entity.CaInd33 ?? 0.0) +
                (entity.CaInd34 ?? 0.0) +
                (entity.CaInd35 ?? 0.0) +
                (entity.CaInd36 ?? 0.0) +
                (entity.CaInd37 ?? 0.0) +
                (entity.CaInd38 ?? 0.0) +
                (entity.CaInd39 ?? 0.0);
        }


        private static string Decode(int? value)
        {
            if (!value.HasValue)
                return string.Empty;

            var chars = new List<char>();

            for (int i = 0; i < 4; i++)
            {
                char ch = (char)((value.Value >> (i * 8)) & 0xFF);

                if (ch == '\0')
                    break;

                chars.Add(ch);
            }

            return new string(chars.ToArray());
        }

        public static int? Encode(string text)
        {
            if(string.IsNullOrEmpty(text)) return null;
            uint result = 0;

            for (int i = 0; i < text.Length && i < 4; i++)
            {
                result |= ((uint)text[i]) << (i * 8);
            }

            return (int?)result;
        }

        //Encoding is done in PapRcv so we decode it.
        // AlloyEncoder.hpp
        //# ifndef ALLOYENCODER_HPP
        //#define ALLOYENCODER_HPP

        //# include <string>

        //        class AlloyEncoder
        //        {
        //            public:
        //    // Encodes a null-terminated C-string (up to 4 characters) into an unsigned long
        //    static inline unsigned long encode(const char* input) {
        //        unsigned long result = 0; // Initialize result to 0
        //        for (int i = 0; input[i] != '\0' && i< 4; ++i) {
        //            // Shift character into its position and add it to result
        //            result |= static_cast<unsigned long>(input[i]) << (i* 8);
        //        }
        //        return result;
        //    }

        //    // Overloaded encode method to handle std::string input
        //    static inline unsigned long encode(const std::string& input)
        //        {
        //            return encode(input.c_str()); // Delegate to the char* version
        //        }

        //        // Decodes an unsigned long back into a string
        //        static inline std::string decode(unsigned long input)
        //        {
        //            std::string result;
        //            for (int i = 0; i < 4; ++i)
        //            {
        //                // Extract each byte and convert it to a character
        //                char ch = (input >> (i * 8)) & 0xFF;
        //                if (ch != 0)
        //                { // Stop if we hit a null character
        //                    result += ch;
        //                }
        //                else
        //                {
        //                    break; // Stop processing if a null character is found
        //                }
        //            }
        //            return result;
        //        }
        //    };
        //#endif // ALLOYENCODER_HPP
    }
}
