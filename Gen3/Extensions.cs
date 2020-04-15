﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3
{
    public static class Extensions
    {
        public static readonly Dictionary<byte, string> characters = new Dictionary<byte, string>()
        {
            { 0x01,"À" },
            { 0x02,"Á" },
            { 0x03,"Â" },
            { 0x04,"Ç" },
            { 0x05,"È" },
            { 0x06,"É" },
            { 0x07,"Ê" },
            { 0x08,"Ë" },
            { 0x09,"Ì" },
            { 0x0A," " },
            { 0x0B,"Î" },
            { 0x0C,"Ï" },
            { 0x0D,"Ò" },
            { 0x0E,"Ó" },
            { 0x0F,"Ô" },
            { 0x10,"Œ" },
            { 0x11,"Ù" },
            { 0x12,"Ú" },
            { 0x13,"Û" },
            { 0x14,"Ñ" },
            { 0x15,"ß" },
            { 0x16,"à" },
            { 0x17,"á" },
            { 0x18," " },
            { 0x19,"ç" },
            { 0x1A,"è" },
            { 0x1B,"é" },
            { 0x1C,"ê" },
            { 0x1D,"ë" },
            { 0x1E,"ì" },
            { 0x1F," " },
            { 0x20,"î" },
            { 0x21,"ï" },
            { 0x22,"ò" },
            { 0x23,"ó" },
            { 0x24,"ô" },
            { 0x25,"œ" },
            { 0x26,"ù" },
            { 0x27,"ú" },
            { 0x28,"û" },
            { 0x29,"ñ" },
            { 0x2A,"º" },
            { 0x2B,"ª" },
            { 0x2C,"ᵉʳ" },
            { 0x2D,"&" },
            { 0x2E,"+" },
            { 0x2F," " },
            { 0x30," " },
            { 0x31," " },
            { 0x32," " },
            { 0x33," " },
            { 0x34," " },
            { 0x35,"=" },
            { 0x36,";" },
            { 0x37," " },
            { 0x38," " },
            { 0x39," " },
            { 0x3A," " },
            { 0x3B," " },
            { 0x3C," " },
            { 0x3D," " },
            { 0x3E," " },
            { 0x3F," " },
            { 0x40," " },
            { 0x41," " },
            { 0x42," " },
            { 0x43," " },
            { 0x44," " },
            { 0x45," " },
            { 0x46," " },
            { 0x47," " },
            { 0x48," " },
            { 0x49," " },
            { 0x4A," " },
            { 0x4B," " },
            { 0x4C," " },
            { 0x4D," " },
            { 0x4E," " },
            { 0x4F," " },
            { 0x50,"▯" },
            { 0x51,"¿" },
            { 0x52,"¡" },
            { 0x53,"PK" },
            { 0x54,"MN" },
            { 0x55,"PO" },
            { 0x56,"Ké" },
            { 0x57,"BU" },
            { 0x58,"OCI" },
            { 0x59,"K" },
            { 0x5A,"Í" },
            { 0x5B,"%" },
            { 0x5C,"(" },
            { 0x5D,")" },
            { 0x5E," " },
            { 0x5F," " },
            { 0x60," " },
            { 0x61," " },
            { 0x62," " },
            { 0x63," " },
            { 0x64," " },
            { 0x65," " },
            { 0x66," " },
            { 0x67," " },
            { 0x68,"â" },
            { 0x69," " },
            { 0x6A," " },
            { 0x6B," " },
            { 0x6C," " },
            { 0x6D," " },
            { 0x6E," " },
            { 0x6F,"í" },
            { 0x70," " },
            { 0x71," " },
            { 0x72," " },
            { 0x73," " },
            { 0x74," " },
            { 0x75," " },
            { 0x76," " },
            { 0x77," " },
            { 0x78," " },
            { 0x79,"⬆" },
            { 0x7A,"⬇" },
            { 0x7B,"⬅" },
            { 0x7C,"➡" },
            { 0x7D,"*" },
            { 0x7E,"*" },
            { 0x7F,"*" },
            { 0x80,"*" },
            { 0x81,"*" },
            { 0x82,"*" },
            { 0x83,"*" },
            { 0x84,"ᵉ" },
            { 0x85,"<" },
            { 0x86,">" },
            { 0x87," " },
            { 0x88," " },
            { 0x89," " },
            { 0x8A," " },
            { 0x8B," " },
            { 0x8C," " },
            { 0x8D," " },
            { 0x8E," " },
            { 0x8F," " },
            { 0x90," " },
            { 0x91," " },
            { 0x92," " },
            { 0x93," " },
            { 0x94," " },
            { 0x95," " },
            { 0x96," " },
            { 0x97," " },
            { 0x98," " },
            { 0x99," " },
            { 0x9A," " },
            { 0x9B," " },
            { 0x9C," " },
            { 0x9D," " },
            { 0x9E," " },
            { 0x9F," " },
            { 0xA0,"ʳᵉ" },
            { 0xA1,"0" },
            { 0xA2,"1" },
            { 0xA3,"2" },
            { 0xA4,"3" },
            { 0xA5,"4" },
            { 0xA6,"5" },
            { 0xA7,"6" },
            { 0xA8,"7" },
            { 0xA9,"8" },
            { 0xAA,"9" },
            { 0xAB,"!" },
            { 0xAC,"?" },
            { 0xAD,"." },
            { 0xAE,"-" },
            { 0xAF,"・" },
            { 0xB1,"“" },
            { 0xB2,"”" },
            { 0xB3,"‘" },
            { 0xB4,"’" },
            { 0xB5,"♂" },
            { 0xB6,"♀" },
            { 0xB7,"£" },
            { 0xB8,"," },
            { 0xB9,"×" },
            { 0xBA,"/" },
            { 0xBB,"A" },
            { 0xBC,"B" },
            { 0xBD,"C" },
            { 0xBE,"D" },
            { 0xBF,"E" },
            { 0xC0,"F" },
            { 0xC1,"G" },
            { 0xC2,"H" },
            { 0xC3,"I" },
            { 0xC4,"J" },
            { 0xC5,"K" },
            { 0xC6,"L" },
            { 0xC7,"M" },
            { 0xC8,"N" },
            { 0xC9,"O" },
            { 0xCA,"P" },
            { 0xCB,"Q" },
            { 0xCC,"R" },
            { 0xCD,"S" },
            { 0xCE,"T" },
            { 0xCF,"U" },
            { 0xD0,"V" },
            { 0xD1,"W" },
            { 0xD2,"X" },
            { 0xD3,"Y" },
            { 0xD4,"Z" },
            { 0xD5,"a" },
            { 0xD6,"b" },
            { 0xD7,"c" },
            { 0xD8,"d" },
            { 0xD9,"e" },
            { 0xDA,"f" },
            { 0xDB,"g" },
            { 0xDC,"h" },
            { 0xDD,"i" },
            { 0xDE,"j" },
            { 0xDF,"k" },
            { 0xE0,"l" },
            { 0xE1,"m" },
            { 0xE2,"n" },
            { 0xE3,"o" },
            { 0xE4,"p" },
            { 0xE5,"q" },
            { 0xE6,"r" },
            { 0xE7,"s" },
            { 0xE8,"t" },
            { 0xE9,"u" },
            { 0xEA,"v" },
            { 0xEB,"w" },
            { 0xEC,"x" },
            { 0xED,"y" },
            { 0xEE,"z" },
            { 0xEF,"▶" },
            { 0xF0,":" },
            { 0xF1,"Ä" },
            { 0xF2,"Ö" },
            { 0xF3,"Ü" },
            { 0xF4,"ä" },
            { 0xF5,"ö" },
            { 0xF6,"ü" },
        };
        public static byte[] SubArray(this byte[] arr, uint start, uint lenght)
        {
            List<byte> result = new List<byte>();
            for (uint i = start; i < start + lenght; i++)
                result.Add(arr[i]);
            return result.ToArray();
        }
        public static string Decode(this byte[] arr)
        {
            string result = string.Empty;
            foreach(var x in arr)
            {
                if(x != 0xFF && x != 0)
                    result += characters[x];
            }
            return result;
        }
        public static byte[] Encode(this string str)
        {
            List<byte> result = new List<byte>();
            foreach(var x in str)
            {
                string te = x.ToString();
                foreach(var z in characters)
                    if(z.Value == te)
                        result.Add(z.Key);
            }
            while (result.Count != 7)
                result.Add(255);
            return result.ToArray();
        }
        public static byte[] Replace(this byte[] arr, uint start, byte[] bytes)
        {
            for (uint i = start; i < start+bytes.Length; i++)
            {
                arr[i] = bytes[i - start];
            }
            return arr;
        }

    }
}
