using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3.Data
{
    public static class Data
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
        public static readonly Dictionary<int, Items.Pocket> Pockets = new Dictionary<int, Items.Pocket>()
        {
            { 0x0000,new Items.Pocket()
            {
                Name = "NaN",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAjElEQVR42uWSYQqAIAxGd+SO0nE8Rj93lP2zJi1USl06MBp8EKLvuRnAWUTkRwbiGg1PJFbwS/IPwbodG5c0vNYtuANrRUXBEygXd3dQu0Cpi65HlguYCOIxDf1NNfMPAkT0LcnhMpbaOZVACw8C55xvSSzg79Zz8whEooHP1cH3R/Q29gIuU7iUFXwH2NaoBslOEkkAAAAASUVORK5CYII="
            } },
            { 0x0001,new Items.Pocket()
            {
                Name = "Item",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAMAAADXqc3KAAAAAXNSR0IArs4c6QAAAwBQTFRFAAAAEBggMDAwODg4IAhYKFAocFgASEhIUFBQSGBQWHBgcHBweHh4EFDAAHD4MFjAMGjYYBjYSHDgcFjAMIBQOKBIYJA4aIBwQMBAMIiAKLCoKNDIeIiIUIDoYIj4iFAgiHAguFB44AAAwGAw+HhAgDjoqFCAmFjwyGiQyGiggIAIsJgouJggiIBwuKhogMBAqOhIyLAg6LgowMAw+Mgg2Nh46OhY+OhAiIiIgJiImJiYqLi4uLi4qLD4qMCwkND4qMDQsMDA2ICo+JCQ6IjA0Mi48OCg8PCw0NDQ2NjYyODQ0ODg0ODo2PDg6Ojo+PDg+Pjo+Pjw+Pj4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAgYoYPgAAAAF0Uk5TAEDm2GYAAAABYktHRACIBR1IAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAB3RJTUUH2gEFASkazSlAzQAAAG9JREFUKM+Nz8ENBCEMQ1FXQBlIU0UuVJD+i0GBYAICDf+2fsqiAVAOAefdpFz6BWUrqCRP9A0oovvjXbiHx6X1/nhiAz5rHthJmxxSyCFbK7TJYfmrAPGk7wTZDgZkHV/uO8HI4s8JW3fAbT8LUAHRuWs1uoMceAAAAABJRU5ErkJggg=="
            } },
            { 0x0002,new Items.Pocket()
            {
                Name = "Key Items",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAMAAADXqc3KAAAAAXNSR0IArs4c6QAAAwBQTFRFAAAAEBggMDAwODg4OGAgQFBgUGhwcEBAcGBAYGBgaGhgaGhoeHh4MGCAEFDAGHDIAHD4MFjAMGjYYBjYeDjAUGiASHDgMIBQOKBIYJA4UIhAQMBAaMBAMIiAKLCoAIjoOJDgIKDIKNDIWICwYICgaIiwaJioUIDoWLD4YIj4cLD4YNj4iEgQiFAgiHAgoFgwqHhAsGBg4AAAyHAQwGAw+HhAqBCQgDjoqFCAkEjYmFjwoFjo0AC42BCg+DDgyGig+GDouJggsJhQgMBAqOhI6LgowLBA4IhI8JB4+KhA+PhQiIiImJiQqLioqLi4uLi4oPCAkMDomMj4kND4qMDQ+JCQ8Kio6IjA+IDo+Jjo8MCo+MC4+Oiw0MjA2NjYwMDgwOD4yOjwwPD40ODo+MD48PDg8PDw+Pj4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAiIXhEAAAAAF0Uk5TAEDm2GYAAAABYktHRACIBR1IAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAB3RJTUUH2gEFATcGDWkjXQAAAHZJREFUKM+NzdEJwCAMBNAbQXAYwTUc4vbfoIn0LNWE9j5E7sUIoAcB4t6lJ/kNTICFIbAUCbZ+SLDPS3DMj/cL0vs1L6A31nfNGzSPb/cP7NbuTJgb5qq2gmqxjjqVD1irNqj6vB7gbwZPcHrVDxzJAVkfC3ABK61kjYNfq5QAAAAASUVORK5CYII="
            } },
            { 0x0003,new Items.Pocket()
            {
                Name = "Balls",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAMAAADXqc3KAAAAAXNSR0IArs4c6QAAAwBQTFRFAAAAEBggMDAwODg4OEhYSEhISFBQUGBoWGh4EFDAAHD4MFjAMGjYYBjYaDDAcDDIeHiASHDgMIBQOKBIYJA4eKA4QMBAMIiAKLCoKNDIcICQUIDoYIj4iFAgiHAguHAI4AAAwGAwwFhI+HhAsACQgDjosDjwqFCAmFjw4CDAyGigyED4uJggqJBAiMA4gMBAqOhIyIgg0KgQ4KA46Lgo8NgQ+NA4+PBYiIiIqLi4uLi4oKDAoLDAuOCAkND4qMDQ4IiA+JCQ6IjA+OiA2NjY2Mjw0ODo+MD4+Pj4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAipYQ+QAAAAF0Uk5TAEDm2GYAAAABYktHRACIBR1IAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAB3RJTUUH2gEFAhY729jE9gAAAHxJREFUKM+N0LsNwCAMBNCrGcITpKR2zf4TxR9kGwJSrkDknvgEAP0Q4Nyr9Et+wLB8YAxuEg6a4LVThexDJrSSArE/5xLEApbRpYDFurgzHslgiYPNtHPYtjIgyX64dga0XpcKLD9YgOqTUAXKR6QVlDTxmbDlDrj1ZwFeBtxYBUMyNSsAAAAASUVORK5CYII="
            } },
            { 0x0004,new Items.Pocket()
            {
                Name = "TMsHMs",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAMAAADXqc3KAAAAAXNSR0IArs4c6QAAAwBQTFRFAAAAEBggMDAwODg4UFBQSEhgYGB4eHh4EFDAAHD4MFjAMGjYYBjYeHiQSHDgMIBQOKBIcJAYYJA4QMBAMIiAKLCoKNDIUJigYKCoeLCwUIDoSKDoWKjoYIj4cLDoaOigeOioiFAgiHAg4AAAwGAw4HAA+HhAgDjoqFCAmFjwyGiggKgguJggkMAwgMBAqOhI4IAY4JA46Lgo6KBY6LB4iIiIqLi4uLi4iLjAiOiwiMDogNDokND4mOjAiODwmOj4oMjIqMDQuNDQoMjwsNDwsPDIqOj4+JCQ6IjA6MCY8NC42NjYwPDQyODgyODwwPD40ODo0PDg0PD44PD46PDw+Ojg+Pj4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA3aMoGgAAAAF0Uk5TAEDm2GYAAAABYktHRACIBR1IAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAB3RJTUUH2gEFAh8LLMNPEwAAAIBJREFUKM+N0MENAzEIBEC+fCnEboA6tv9SAmcQR4Kl7M87AksQ0R5CNPcu+5J/AJYBALYUJVitgBp1AKuq79IUqr7LD+AN0T/f5EiAvZX35hqhZcEp1mJfx/Au4OyIjQfEc0YQ/VMl6AwviT5B6iTSQfKI8g1OVTfouQPd+lmIPmzfXYM/K4PlAAAAAElFTkSuQmCC"
            } },
            { 0x0005,new Items.Pocket()
            {
                Name = "Berries",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAMAAADXqc3KAAAAAXNSR0IArs4c6QAAAwBQTFRFAAAAEBggMDAwODg4MHBAEFDAAHD4MFjAMGjYYBjYUFCAaGi4UHjISHDgGIAwMIBQIKBIOKBIMLhYYJA4WLhAQMBAYMhQMIiAKLCoKNDIUIDoUKDwYIj4WND4iFAgiHAgqFhA4AAAwGAw+HhAgDjoqFCAmFjwyGiguJgggMBAqOhI6Lgo6JBw+LBwiIiImKC4qLi4uLi4qPCYkND4qMDQuMD4+JCQ6IjA+MCY+OCY2NjY0ODo4Oj4+Pj4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA4t+VZgAAAAF0Uk5TAEDm2GYAAAABYktHRACIBR1IAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAB3RJTUUH2gEFASUh0Jfm5QAAAH5JREFUKM91z7ERACEIBEAiUsfgKyG+/tt6EVFk8MJbESWirwhR3at8j9wAoAKAmZ0CQFgjSLB6lwBaQTmD2FHcE/OozM2I4AskP3cswJQDXTMGYEOCblmglV22oWnAO2iWBf65cdUFZ8T7DZIGHJp/sGVQCnWElDfQq6+F6AdAlC/lGEw4hQAAAABJRU5ErkJggg=="
            } },
            { 0x0006,new Items.Pocket()
            {
                Name = "PC",
                img = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAgBAMAAADpp+X/AAAAJFBMVEXo2KDwsHBQUGhgYHiIkFCQkJCQkKC4uKDIuMDIyMDg4ND4+PhNDCzGAAAAAnRSTlMAAHaTzTgAAACXSURBVHhebcoxCsJAEIXhhzdYT2C2CAuWo8ViaW4gFpLOYvEG6VNI+tUiV7BUt8rlfDuJKOLHFD+PgZlbKgyMO3XduTWYB1XAdarFclD3P+HGaOF7FeGjkGesKtrmuLzj+busK9rlZU95ud7oECG9EnhR/BkUI9FjMy2p5nPKaoFMUFp1RBkUowkN7yvsGPbzPAtqAViFFxdHZfOhiq5uAAAAAElFTkSuQmCC"
            } },
        };
        public static readonly Dictionary<int, Items.Item> Items = new Dictionary<int, Items.Item>()
        {
#region "Test"
            {0x000,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0001,
                new Items.Item()
            {
                Name = "Master Ball",
                Pocket = 0x0003,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABAUlEQVRIx+2VvQ3CMBBGPQojuKSkpMwYlJQpGYERMoJHSJkRKBkhpTvIZ+mss3MXnwSIAopPUeK79+z82YUQ3CfjfkPgvX9IeUlQgPazGItMhd93Y44EL8bdVZWI8DjGAjAdYgqHo4bXaZL1CpbCevZvE6xuzdLUuj1FLWIVEPw2zcVRk5CgXsVKkGciwDVJ7rEIzn7KgJYg1TL4yY9tAYq0974OBDwmwbHrCgnOKRqY4KgxCXiGYXklY0xHnEtQnk0BSfr+khsAp9QwHvSYPjQU4WECiKZ6BRIY9Ri3fcmChIJrUjR482+KRg1K4C14cz+gXzGB6lj2he9tOP9Nn/IEfN0fBbbre5sAAAAASUVORK5CYII="
            } },
            {0x0002,
                new Items.Item()
            {
                Name = "Ultra Ball",
                Pocket = 0x0003,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABAElEQVRIx+2VMRKCMBBFOYJHoeQIlpSUlpaWlBzBI1Ba5giUlpQegzId+tHNrDubZB3URos/TCD7XgghKZxzxSdT/IagLMtZy2oBgfxYqbGIknACjafNfOiOIWjzZylJGj41c++GJ/irEhUOAODe+yWaRApiElWwFGcE/Fugf73b5wVh9I9CgGNTxAWAU6QkKdDA2vS8XRAbvUlQbRuzQI4etVnBtq7DFACGNoULaOVwOPqYBDx9P9xX0u2KNmAER2T/pIAkbduFAlqqiITxoMb8H1zO0wJEkXwDDYz+eG4SaBIK7mmJwbObHQpjUAKn4ObtmkAyq7brrxw4/0MfuQJ9AQz8zKT6+QAAAABJRU5ErkJggg=="
            } },
            {0x0003,
                new Items.Item()
            {
                Name = "Great Ball",
                Pocket = 0x0003,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABCklEQVRIx+2VLRKDMBBGOVJkZSWS4yB7BI6ARCIjKyuRPQYyjma32cwSNtkMM61pxTcM7e57Wf7SzPPcfDLNbwiMMZuU0wJotgx0GZyYGpEId9O0meuwmW7JwnnWts2KRDg2EHwJUQQ2M81BAMVR4MHOvZOTwIJsuKRWE9ggwNWcFKRTiDc3FgdJLbxKANBY7G+0dt1TuCqAZg3OF8EXg1EnKIB3El+3A3tplaDtup0Ezil8gkN8D/bWCHjG8Y5PERwRkIDT+qKAJH1/iw30mEJSGA/0qC8aCZ6PFYHQlE4ggaEe/q8SSBIK/CYlBy9+rqEBGnNQApfg6n5ALw6B0pz6XH9lw/lv+jwvAGME6S8eQggAAAAASUVORK5CYII="
            } },
            {0x0004,
                new Items.Item()
            {
                Name = "Poké Ball",
                Pocket = 0x0003,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAA0ElEQVRIx2PYsGEDAy0xw8iwwMDA4D82TLEFMIN+TLDAiomxCK/huAxGxjciLPBagt/wC1BMgSX4Df/xA4IvELYAlyX0tQAj3EkIIlyWkBWxuAwfHBbM8CDfcJBeghZ4BASgWALiwzAug2GGg9QQZQEyXrDgADglgWgQH5uhyBivBTBLKioaEK6GJVUgRjcMGYP0EJ0Pbpz4ADYQpAndB9gMBqkHyRNlATZLYBgkhg3jMpxgYQfSiMtQmMH4DCe6uIYZhI4pKq7pUuGMVvogDAByfxK0YYaRJQAAAABJRU5ErkJggg=="
            } },
            {0x0005,
                new Items.Item()
            {
                Name = "Safari Ball",
                Pocket = 0x0003,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABFklEQVRIx+2VLRLCMBCFcwQkx4jkCJWVyEokMhKJRCJ7hByhEonsMZB1Zd4Or5PZyR/TAQPiTadp9vvadJsa7735ZMxvCKy1cyyrBQQNfrfk6tu5uXSSGlEWDoiGMxw7diYrycIP/iwhDGOAj3cnqZFE4SgCeJomCWFcGgo43rmtJCZJClCcEuhs9rZOQDgL8RQlOAVIbKmSd8/iEhzQMEVB+BJDELsnFPMFvyXAJN0poUC3KIMlamoETdvKRICkCOevhN+EhnNunSBI3w/SSThSAii6Bjei52cFlDh3WgrYqoiGhUFN9Xcw3h4CRJF+ghgY83G9ShCTMBiLJQUvbnYoTEEJzsGrt2uCdFZt11/54fx/+sgTqY7ptSCoJIEAAAAASUVORK5CYII="
            } },
            {0x0006,
                new Items.Item()
            {
                Name = "Net Ball",
                Pocket = 0x0003,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABFklEQVRIx+2VPRKCMBCFORKlJWVKjuERUlp6DI6QI1B6BEtLS0u6yMuwzHPJ36A2jsWbjJF8XzYusXHONd9M8/sC0/e+bVvfdZ3nOXzmuV0CgTAQsfbkRYzsEmChgBjMc8aN3thztpoiPIwAUTC3VjcLEJkrCgAPoAU+TZM/3O5RiVTCR1Yl4N2nBLoSpCgIu6ddAZyC6yow4qi0ZCN46ZQEWMP59ygKuOyURMPXKmoEAGx6nsAbOHWQOdoKAfX4erZL9EvHLSrPVAk4wzCGTsLIRxEy71g/nxXoNkUAl2gYB2uq34Pr5RGAWKQriIHxPL6vEsQkEszFkoIXLzssTEEFnIMXr2u5jgWk89Z1HRPp/P+TP5In7fXcIz+jPNIAAAAASUVORK5CYII="
            } },
            {0x0007,
                new Items.Item()
            {
                Name = "Dive Ball",
                Pocket = 0x0003,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAA9klEQVRIx+2VMQ7CMAxFcxzGHIOxI8dg7MjIyBFyhByBsWNHjsDYMVvQr+TKdZ3EooIFhidIhf9L4pC6GKP7JO43BN77rLFbQEGPYcq355SvQ5rBGFhE1fCU0oImCOE+U5OYwrmAwjk1iRqOIikAWnhLYpo9raAUjpWZBLyhMry0RdQXcDiPG8lGQGEyXGsyvp/CGrNAwmdKyHCTAIXvhpu26Nh1KwnGRCscvzEJODgd6AU+MdZCOVUBSfr+shTw0yTDOKgx/w8wO2wPiuQKtODSEa1eFVxC4JnW7FJ487Lje03IHtTCzdc1F3B2XddfeeH8X/rgBVW+XSxcnSe2AAAAAElFTkSuQmCC"
            } },
            {0x0008,
                new Items.Item()
            {
                Name = "Nest Ball",
                Pocket = 0x0003,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAA+UlEQVRIx+2VMQ6DMAxFORIjY0fGHKHHYOQIHTsyMuYIjByhI0fIyEb7IxkF1zGWonZphy8E2O8pISSV9776ZKrfENR1vUkpFhComxoxFpEKH8c2C6egRpOo8BDumw+6YFl6VSLC0Qj4uq4xkgRgCgTX20WUZAWAkgCyFMgDuEnAPyjAZ3DUkUCaqjcBNeWmIwWn8CKBlhRuEqDIKuFw1zXngta5gwT3lNy0EBw1JkGaYZjiSsIV9xzM61XBvpK6fm+gpYpw2GF0rx7zf/CYQwSiiY9AAqMe700CSULBMyk5+Olmh8YclMAa3LxdE4inaLv+yoHzP/SRJ8P4DtwwZdMiAAAAAElFTkSuQmCC"
            } },
            {0x0009,
                new Items.Item()
            {
                Name = "Repeat Ball",
                Pocket = 0x0003,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABEElEQVRIx+2VMRaCMBBEORJljkBJyVEsLS0pLTkCR7CktOQIlpTp0FkZXfPCEuRpo8UUQPI/STZJ1rZt9slkvyHI83yMZbOAoL5yY9+5sWlOkt1uP7aNSxKZcF87gQ+XVzieIRRx5UyJCffnG3w4CAxQhnBpU9sSE+69l/TdIH+OEVBCOAVzklUCLcEoVgse8Cn36XnClwQxiSng3HOB9RRRoOGrBCxNvbgh/C3BsbD/XldQCEffRUFRltKQcDwzWoKNFsLRJkkQQlFJlMkIJgGhOqaAElQLO7BUkRCmgz7J+wClCSDLUo8gBkZ7fE8SxCQM3sUyB1887NBxDkqwBU8+rnWp6mw6rr9y4fwvfeQKF1EdbO3qftkAAAAASUVORK5CYII="
            } },
            {0x000A,
                new Items.Item()
            {
                Name = "Timer Ball",
                Pocket = 0x0003,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABEElEQVRIx+WVsRHCMAxFPVLKjJAyJaNQMgIlZUbICJSUKRmD0l3Id6ycELJQCNxxR/GLOMd7koPs0Pd9+GbCzwiqqhp5PioAMA71GI9zTk3tlriq5vDrbhbs9wdXNyYcEABl9VinNG1rSkx4150fBLx6HqyXJMX9TvDLba580KvngpLEJ4ixWD3W3IIEz3sNKCQEkHC8p1gSXcB+TABErqfOpi5TtgisrBaUKjXhWaAN4JMA/2u+x3imqOAcwLWZUAU8+ND0wfHMoTRoPKaAb5OsWnYjUzqfVEGa3glI08w7kEmDNnWD9y7BIsGQZckyscreW/CXhx1NswW24O7jmkAym45r6zZbc6uF/7n0380dP70/gMeuA6wAAAAASUVORK5CYII="
            } },
            {0x000B,
                new Items.Item()
            {
                Name = "Luxury Ball",
                Pocket = 0x0003,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABFElEQVRIx+2VIRLCMBBFe6TKHKEykiNwhEqOUFnJEXIEJLKyEolExoX+0GWWnSTdwhQD4k+mneS/bHY3qZxz1ZaqfgNQ13VI6WMAGbXtISkNqGg+9HlzCVoFwIJxZ4K/2iiAvPdxlOobE5w1WUjSHLuC8cXtgx8mUGcewHmEKRdAjbVJSBYwnm9x11GIJBMB5sJcBZAJBQRaygEBUpAiQCNurgJg0qYAeSSUh+PxVDTHOsxZBKDkKMFYgG8kk/7njGmuKgKqEJRp7IG5F2AAsDTlKgI45Gnuu5eG42D0BBmnjqfcaNNO6Xhy5lFzNOpG45BUDuQRUU7UV4UsWZgsVdHqy05e17LWufHb1/VXHpz/ow/dARdX+fXBzer9AAAAAElFTkSuQmCC"
            } },
            {0x000C,
                new Items.Item()
            {
                Name = "Premier Ball",
                Pocket = 0x0003,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAAvElEQVRIx+2VsQ2EMAxFM1LKG4ERbhTKG4OSETLClYxwY1yZDvSRjAxnG4twCAmKryhK8l7iwgkppfDPhGsIYoy9lGIBgXLOYjwiE66BeT7d15QUwT2SYjgJNMmxgi1wLpAku93+PIK2fW+G1/VrXdBUj5kEc4oGJjj2uAQ8JMOIuQTlMQUk4Qd5SZYwHqk8qgC3G0vx/H2BBMZ+rLsEkmSKUHsLvtrscFCDEtiCu9s1gZYpateHfDj3p48MCi2qXPjoPJsAAAAASUVORK5CYII="
            } },
            {0x000D,
                new Items.Item()
            {
                Name = "Potion",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABFElEQVRIx82WPRKCMBCFORKlx7C0tPQIljmGJSUlpSUlR6Ck9AjplJfhZXZ2Qn4AR4s3zoB+32azAauu66pvpvorwfl+e9d17XOYgEBrrcu0JEeSVbEG96/RpRmeSUm06jWwFKQkUQFWMC2SEBgx7aNcgB9MvfW5nIwTSfAhAnyaa+sEgFECqAxWWiwgWArQHg3ftckAEy4FvL5L4FslpshXPq+qMYOXFLdIngM5qqxeCzaNqYRbsblagGw+B4BSwPZQwFC0JkkK5LyHBAxXky3Al9EmKZBwVK4loVXEJ2g+bABBhEg47x0i0CBe0/eKBO75szyLYhK9D+UHTUlCvV+rPuuNxhEMQVPwoncyRTo//1fxAYXeMk3kWks2AAAAAElFTkSuQmCC"
            } },
            {0x000E,
                new Items.Item()
            {
                Name = "Antidote",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAA2ElEQVRIx92WsRHDIAxFPU5KyoyQESgzFmMwQkrKjJEypTrH4iKfIGBkAU2Kf3bj92QJn7x475eZUT9orV2NMXuGCQgIAElqktPV5uAQwuqc0wlqUA6mnBZIwUfwpgBhmFrFLbhYUKpaUr1KgAPn9+/Htb9FJEAg+Eu8EpyiGnLs/+v+I6AQHJ63DsEGKgk4XC1AYN6iCN3eKuYLVwsQRv2O1SOM4CMECElaAX68YA/C/0LAz373KUpmUBF0fWhJpQcC9UbjkpKgtS5FG43v3TxTl/70vwppPjlNRranPNJFAAAAAElFTkSuQmCC"
            } },
            {0x000F,
                new Items.Item()
            {
                Name = "Burn Heal",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAA1klEQVRIx92WsRGEIBBFLYlSDCnB0DIsgTIILYHwQsq4kEzn38w6exwILpBc8EcT31t3cdbJWjuNjPhBrfWhlLrSTUDAEMJXcpLH1cZg59xhjJEJclAOpjwW1ILv4EUBYEiu4hK8WpCquqZ6kQAD5/fLa2lvEQkAnPf5cyU4RTRkgLf39iOgEHz1q1wAUErA4WIBgHGLAMVbIQQXCwCjfiMAEbyLABDeCh98fwEF8P8Q8LPffIr4DHKCpg+NA+4E4o3GJSlBaV1WbTS+d+MMXfrD/ypqcwJPkyteMUC7DQAAAABJRU5ErkJggg=="
            } },
            {0x0010,
                new Items.Item()
            {
                Name = "Ice Heal",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAA1ElEQVRIx92WwRGEIAxFLYlyKMFSLIGjJXDcEijBMvbIzTWZCZNVkBjg4uGPXnwvJjhx8t5PI6N+0Fq7G2NSugkIGGP8S0nyuNozOISwO+d0ghKUgymPBVLwHbwqABikVHENLhbkqpZUrxLAwPn9d1naW0QCBM4zXglOUQ0Z+//xF0EKCdZVLwBQVsDgagEALy06oPBWEIKrBQCjfiP8ABG8iwAhrBVx2/oLUgD+CgE/+82niM+gKGj50DjgTqDeaFySE9TWpWij8b17ztClP/yvQpofYoBQJmteUL0AAAAASUVORK5CYII="
            } },
            {0x0011,
                new Items.Item()
            {
                Name = "Awakening",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAA1klEQVRIx92WsRHDIAxFPRJjZARGyBgZgzEYwSUlI6TMCOrs/EuUUwgYLKBJ8e/c+D1ZgpMX7/0yM+oXrbWbMeaTYQIGEtFXSpLT1abgEMLmnNMJSlAJ5pwWtIKP4FUBYEip4hq8WZCruqV6lQADl892jf0tYgGAF7++wG84RzVkgG8P+hFwGH6Nd70AoJxAwtUCANMWAYqvQhiuF6BK7vczADF8iAAQ2YpINF7AAfw/BPLsd58iOYOSoOuiScCRQL3RpCQnqK3Lpo0m926aqUt/+l9Fa3awIEueTwCBmwAAAABJRU5ErkJggg=="
            } },
            {0x0012,
                new Items.Item()
            {
                Name = "Parlyz Heal",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAA1ElEQVRIx92WsRGDMAxFGcllRnGZkVJ6DI9A6ZKSERhBHdxPToni2NjIdpPiHzS8JyRzYvLeTyOjftBauxtj3ukmYCARfSUnuVxtDA4h7M45nSAHlWDOZUEt+AxeFACG5CouwasFqaprqlcJMHB5v662vUUsAHCeb88rwzmqIb/6//gRcBi+bXe9AKCUQMLVAgDjFgGKt0IYrhYAxv1GAGJ4FwEgshVES3/BJ8ufCOTZbz5FcgY5QdOHJgFnAvVGk5KUoLQuqzaa3Ltxhi794X8VtTkATSBVjvzKfEoAAAAASUVORK5CYII="
            } },
            {0x0013,
                new Items.Item()
            {
                Name = "Full Restore",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////4+NDo6LCo+JDQ0KCY4ECwsIB4wCCQkGBYeDAwMDAGszrHAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAK5JREFUeJxjYMAAHF0r4GyuhSIuC2CchUJqLV4wCUFBwQwPmISgoFhWSgNcIi2rBaKpSUxQLK1lGYSzSEkwLcMNylmhpJTWkgZVtqRDKcOtJQOqTKWjpaUlDWLRMiUVt5a0ti6I0ZOU3NJmToNyLCe5zQyFcYwtZ5aHTssCc7KMjc3LS9OkIAYkAzlpghDTFoolm6cJukC8t8RRDMheBfXOEkc4G8RDsIE8JDYcAADX8jUddKs2mgAAAABJRU5ErkJggg=="
            } },
            {0x0014,
                new Items.Item()
            {
                Name = "Max Potion",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////g4PDIyNiwsMCQqPiQkKBAmOBwcIAgeMAwWHgwMDAEpkJEAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAK5JREFUeJxjYMAA7FXL4WyuhcLGC2CchUKqxVYwCUFBwXBzmISgoGhUcAFcIjSqGKKpSFRQNLR4KYSzSEkwNNwUylmupBRaHApVtrhcKdy0OByqTLm8uLg4FGLRUiVl0+LQ0iqI0ZOUTENnToVyPCeZzkyDcVw8Z3akTY0Cc6JcXDw62kKlIAaEADmhghDTFoqGeIQKGkO8t9hQFMheBfXOYkM4G8RDsIE8JDYcAADNgTI7jAnPZwAAAABJRU5ErkJggg=="
            } },
            {0x0015,
                new Items.Item()
            {
                Name = "Hyper Potion",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////4+Pjg+PjA2Oj4wPiguMj4gMiAmKj4YKhQaHjAOIAwMDByW2nLAAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACgSURBVHicY2DADzh3b4CzuTcKacPFNwopm8KkgGxj02goZ6eisWloNVSHi5dqKJzj3RUUXl4J5XR1BZeXwwzYtTS4ajmMw62kXpFVCbNHUH1FFtQAhomC4SuyVkM5WwXLV3RkQTVtDQVyOlZBOCtDqzoyOrohnC2ZM9rc4Jy0jra0DChniVtGR1pHF8ylaRkdHTAnrO7ogGkB8XbvxggXACKxNjctruq1AAAAAElFTkSuQmCC"
            } },
            {0x0016,
                new Items.Item()
            {
                Name = "Super Potion",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////4+Oj48LD42IDguGj4qJDYgICwiEDAYFiQaDCQUEgwMDD4PQioAAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACgSURBVHicY2DADzh3b4CzuTcKacPFNwopm8CkgGxjE28oZ6eisYlLNVRHaJSKC5wT3eXkXl4J5XR1OZeXwwzYtcS5ajmMw62kXpFVCbNHUH1FFtQAhomC7iuyVkM5WwTLV3RkQTVtcQFyOlZBOCtdqjoyOrohnK2ZM9rC4Jy0jra0DChnaVhGR1pHF8ylaRkdHTAnrO7ogGkB8XbvxggXANIjNeATBEQpAAAAAElFTkSuQmCC"
            } },
            {0x0017,
                new Items.Item()
            {
                Name = "Full Heal",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAA6UlEQVRIx+2WPRKDIBhEOUqO4BE8UkqOkiNYUlpapqS0TGlpSWdm1VVwFMgXLTKTYgdGh/f4E1TGGHVlxA21VkNRFEtOExDo3HNJ78pDyce93YLbTg2NVTLBHtQHV/UUkQANAIqBU/CkADBkD4z3KXjWCCh5VKEgp/ciARYcYAR115fyKdoKADRzyXpr45L0IutQ0NRrCMcGEAvs/RYIAO1eUwgXjwBASBAKRugMxigoEgnQkPONEIaS0/S1gDC/53/BKvBgvyfgRxUT8Jn4RhtPTK+XvoBbWHzYHd29OffwKZf+5X8VuXkDI+wYtkZb/ecAAAAASUVORK5CYII="
            } },
            {0x0018,
                new Items.Item()
            {
                Name = "Revive",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAD1BMVEX////4+Pjg4HigoDgwMDDEED9hAAAABXRSTlMA/////xzQJlIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAEVJREFUeJxjYKAScHFAYgs6ILGFHBBsBIdFUFBQCc5RROUIIThKqBwlJI4iMkfZ2BjBMTZ2gdnJooxgM7AgsRlYkNgkAwCvsAm2MKQY6AAAAABJRU5ErkJggg=="
            } },
            {0x0019,
                new Items.Item()
            {
                Name = "Max Revive",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX////4+Pjw8MDY6Ojg4HigoDhISAAwMDC0HXNTAAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAIlJREFUeJxlz7sOwyAMBVAmMrsSzU7Fn0B3pNxkLVVF1zYD31+eipV6ukcWxhbiVNOHYd84wFq72TiQYhzQAF0Z/NqyfGqDObUcLtp4muvEQBlETRJB36iotBKRsrnudTUilFwffUlh6TlPABbX1/MKQP9zyg24AYVoB2R8S+sexxEvDskhovirH3skIFrhRlJBAAAAAElFTkSuQmCC"
            } },
            {0x001A,
                new Items.Item()
            {
                Name = "Fresh Water",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////4+PjQ+PjA0NCouPCYqKiQoNhwsGBgcKhAgDBAUIgwMDASnrBcAAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACKSURBVHicY2DAC7h3794A5ywSFNSCc1YoKXUhOC4ucA7HrlWrVjdAOZskOjqapKFmGQYpKSkrb4BylIAAxmlUDg420oBywlJcXNxScXGU4BwlFJkSdwQnfWb5NBinrXJm+cwMKEd85vTymY1QjlEoEMBcEBgkKKgqCvXrVmNlI+NomId2AwFGwAAAWPIykdb333YAAAAASUVORK5CYII="
            } },
            {0x001B,
                new Items.Item()
            {
                Name = "Soda Pop",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAALVBMVEX////4+Pjo4OC46PC40PiYyOiAyPjAsLCIuMBouOBQmMg4gLBYeHgwSEgwMDB085gJAAAAD3RSTlMA///////////////////ljZ6mAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACJSURBVHicY2DAAPfeIti8S7IvwDl82cceIDirViM4vKt2I5RdPnvHFs55YdzRB+c8tuiwg3OeNJ/wQxjQcwJhwOMbvXBlPBrGFsdhFvEVWTSWIzhCSupIHFVNOGeSUFA4nFMqqopQNskpKBLG4Z3qGhoJs5X3ZOTMOXAnvOk5cw7h03fvED6FAQBuOTKNvX3mGQAAAABJRU5ErkJggg=="
            } },
            {0x001C,
                new Items.Item()
            {
                Name = "Lemonade",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////4+Mjo6KDg4Pj42LDIyOD4wJjAwIDYoHigoLgwMDBrnPNHAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJxJREFUeJxjYMALVq1atQDOnjlz5iwoj2uqcWiw6Swoxzg4MjjYCsLhNDaePNnYEsJZNNM4ONhyEkTTckWgARPVIZwV5YpCSuoVUE5TeXm5WzuUU6TilqQG5SwvSnFTSiuHctpShNTSYHraEoXSUuAGKLqlJXXA9Ki4pSm1w/UgTFvRluIEN42rTVEoLa0K6rmVQAM0EV5F8jZ2AACpdzxrY1EGHgAAAABJRU5ErkJggg=="
            } },
            {0x001D,
                new Items.Item()
            {
                Name = "Moomoo Milk",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAKlBMVEX////4+Pjw8ODo6NDg4LD4uPjooOiwsHDQkNCwaLCAgDiYUJh4MIgwMDBh8uowAAAADnRSTlMA/////////////////1dK2xQAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAIFJREFUeJxjYMAL9t69exvG5m0US8u4AOXwtIWGZhyAcWZ0dHTCODd3zpw5ey5UYmpn9+6ZMKkdrWGdnTOgnNUzw4ByUD1LTLZ1bvaCWlOi5L1Jyf0ClGMkZGxMEw5XiZOQsYn7Agin3ElJxaUcwmG4Xg4EtVC3ca29e/fWAvSAAQAzUDwEPb/4SAAAAABJRU5ErkJggg=="
            } },
            {0x001E,
                new Items.Item()
            {
                Name = "EnergyPowder",
                Pocket = 0x0001,
                Description = "",
                img = "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"
            } },
            {0x001F,
                new Items.Item()
            {
                Name = "Energy Root",
                Pocket = 0x0001,
                Description = "",
                img = "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"
            } },
            {0x0020,
                new Items.Item()
            {
                Name = "Heal Powder",
                Pocket = 0x0001,
                Description = "",
                img = "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"
            } },
            {0x0021,
                new Items.Item()
            {
                Name = "Revival Herb",
                Pocket = 0x0001,
                Description = "",
                img = "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"
            } },
            {0x0022,
                new Items.Item()
            {
                Name = "Ether",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////g+PjQ4ODw0PigwMDYqOC4iMB4mKCYaKCAUIhIKGAwMDBH//Z1AAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACVSURBVHicY2BAB7uBAMbmFgSCDVDO5rCZSiLVUAlj07SJLu4bMDmbjc0yVVyqYJywTBH3VdJgztbQtEki7gshJuxoA2kRhyjj7OiY6ALTw71qlZILTA93uYtLCUwPdzkQwPQwbAdxoHoYtri4uLvA9Lgg6wF6AGgPlKOkBDS6fANcmYsLzD8gdjnMpyCjEWGAFB4IAADgQDncK61fMAAAAABJRU5ErkJggg=="
            } },
            {0x0023,
                new Items.Item()
            {
                Name = "Max Ether",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////w8PjY+NDo6Pi4+Jig4IDIyNiAwHCgoLBosEAwaEAwMDDhv9aBAAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACVSURBVHicY2BAB7uBAMbmFgSCDVDOJteZxmLdUAklldCJaRkbMDmblFQjzdK6YBzXSLGMVdJgzhaX0MliGQshJmwvBWmRgCjjLC+fmAbTw71qlXEaTA93R1paG0wPdwcQwPQw7ABxoHoYtqWlZaTB9KQh6wF6AGgPlGNsDDS6YwNcWVoazD8gdgfMpyCjEWGAFB4IAABT2T+900ngpAAAAABJRU5ErkJggg=="
            } },
            {0x0024,
                new Items.Item()
            {
                Name = "Elixir",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////w8KDo6KD42ND4uJjIyIDgoICgoFjAgHCwaEBoMEAwMDDonF2yAAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACVSURBVHicY2BAB7uBAMbmFgSCDVDOZreZSqLVUAljk7SJoeEbMDmbjc0yVUOrYBy3TNHwVdJgzhaXtEmi4QshJuxoA2kRhyjj7OiYGArTw71qlVIoTA93eWhoKUwPdzkQwPQwbAdxoHoYtoaGhofC9IQi6wF6AGgPlKOkBDS6fANcWWgozD8gdjnMpyCjEWGAFB4IAAD6nTw5Dr3QwQAAAABJRU5ErkJggg=="
            } },
            {0x0025,
                new Items.Item()
            {
                Name = "Max Elixir",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAMAAADXqc3KAAADAFBMVEX////4+MjQ+Pjw8LCY+Pjo6JiA4ODQ0FhwwMBAsLBAaGgwMDCAgID/AAAA/wD//wAAAP//AP8A//////8AAACAAAAAgACAgAAAAICAAIAAgIDAwMDA3MCmyvD/+/CgoKSAgID/AAAA/wD//wAAAP//AP8A//////8AAACAAAAAgACAgAAAAICAAIAAgIDAwMDA3MCmyvD/+/CgoKSAgID/AAAA/wD//wAAAP//AP8A//////8AAACAAAAAgACAgAAAAICAAIAAgIDAwMDA3MCmyvD/+/CgoKSAgID/AAAA/wD//wAAAP//AP8A//////8AAACAAAAAgACAgAAAAICAAIAAgIDAwMDA3MCmyvD/+/CgoKSAgID/AAAA/wD//wAAAP//AP8A//////8AAACAAAAAgACAgAAAAICAAIAAgIDAwMDA3MCmyvD/+/CgoKSAgID/AAAA/wD//wAAAP//AP8A//////8AAACAAAAAgACAgAAAAICAAIAAgIDAwMDA3MCmyvD/+/CgoKSAgID/AAAA/wD//wAAAP//AP8A//////8AAACAAAAAgACAgAAAAICAAIAAgIDAwMDA3MCmyvD/+/CgoKSAgID/AAAA/wD//wAAAP//AP8A//////8AAACAAAAAgACAgAAAAICAAIAAgIDAwMDA3MCmyvD/+/CgoKSAgID/AAAA/wD//wAAAP//AP8A//////8AAACAAAAAgACAgAAAAICAAIAAgIDAwMDA3MCmyvD/+/CgoKSAgID/AAAA/wD//wAAAP//AP8A//////8AAACAAAAAgACAgAAAAICAAIAAgIDAwMDA3MCmyvD/+/CgoKSAgID/AAAA/wD//wAAAP//AP8A//////8AAACAAAAAgACAgAAAAICAAIAAgIDAwMDA3MCmyvD/+/CgoKSAgID/AAAA/wD//wAAAP//AP8A//////8AAACAAAAAgACAgAAAAICAAIAAgIDAwMDA3MCmyvD/+/CgoKSAgID/AAAA/wD//wBNRQ8/AAAAAXRSTlMAQObYZgAAAAFiS0dEAIgFHUgAAAAJcEhZcwAACxMAAAsTAQCanBgAAAAHdElNRQfWCBsHDBOSn9aaAAAAi0lEQVQoz4WS2xYEEQwERUSQ///fFYwjGXO2H7tQbiH8i6y8elhxRGLKtSICsdg+dpIrEFnyBbSPvUftm1wncGuHX1LSHgeAYy0pJT8GMPJaegawjiCtB6f7dARhHqO9Q8GMd2xCbB1BiNZazrF775hXPs9hAI4oYHu7tMM3t07wL7i2e3nz+1e45Adegwc//0KfaQAAAABJRU5ErkJggg=="
            } },
            {0x0026,
                new Items.Item()
            {
                Name = "Lava Cookie",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////gsBioqIDIiECwYChgYDhwQBgwMDA4MBCm0nJHAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACfSURBVHicY2AgF6SlFcCYbOXChmIwXrGIoYiLOYTNbuhsKGziDJEqdjF2EzR2EQdzEoUFjYEckwSQdheRUGdjIASpYzM0VQ02NjE2AXOEQ0NDg00EwRx2k1CljtBmYbAedlfV0IjWZjcREIehKEIjNMJYGGJrqWqraouJsTuYkxEa2tpi7AJxAVsHUJVJOtSh6R3NJu5w76SXlyWQ4HsA/MUisxhhbf8AAAAASUVORK5CYII="
            } },
            {0x0027,
                new Items.Item()
            {
                Name = "Blue Flute",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////4+PioyPjYoJCIqPBoiNjIcGhIaKjISECgSEAwMDA82N2nAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAIlJREFUeJxjYCAMuBYgcRZpIUkoLkJILRYRWoCQcEUoWyRihkWialXBIpEgiMRyZWd3mASXkqCwqgtUgl1RWE0VpqNISE0pKbQAamioUpKGSjiEs9TFVUOpczqEs8TFJahJJQpqnwtQqnMWnOOi5KLOAFcX4lTAAJcKUYK7cpWrUhXCl6uWYwkTADStIi/qQ8leAAAAAElFTkSuQmCC"
            } },
            {0x0028,
                new Items.Item()
            {
                Name = "Yellow Flute",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////4+Pjo6Kjg4HCg2JDIyFhwyGhIyEBIqECIiEgwMDDs9qiMAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAIpJREFUeJxjYCAMuBYgcRZpIUkoLkJILREWWoCQMEUoWyTshkVi1qoJi4SDIBIrVUwsYRJcSoIiqsZQCU5FETVVmI5JQmpKSaEToIaGKiWpK0dCOEuNTdWVKjohnMXGxkFFylFQ+4yBUhVdcI6xkrEmA1xdsNEEBrhUsBLclatMlWYhfLlqJZYwAQDgViEm6tQmowAAAABJRU5ErkJggg=="
            } },
            {0x0029,
                new Items.Item()
            {
                Name = "Red Flute",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBwYoO8ZZ/GMAAAGcSURBVEjH7ZMhc8JAEEY/Ohj+AThOVh6uUxeJBYVsq4KsZFAMitaRqoIC1GErzzGo5Fzr2LrgWgV1W5FeJoEBwgx0Krrq7iZ5b/d2D/iPREgpWUrJZ4Ozr5h9dXpJDGdmuz6ZRErJ/dGCmZlXqsfMfDpBMvOV6vGi554P3h8t2L33/1Dmyq2yHTspJSu3yieBWxj7ivujRVz+SvXi82PguU148NyKNpVafO6NCc3LAKQ1ikIAAJZEEI6Dyl0XxpjcLsFFctO6KqXg3piAYIpX85H6KSs8JVBulWu3NxE8mKbAXoPQnAgIx8GSCAAwHQwPwlOC7jwEANBDE6R1CmzXTjuSFIVARZRhG78v8slN8o7XRFgSwWs4cNoCukPQnUgCfAEooVl+x1ECC0/uSWvoTlqyphBLItQm4UHB1hTNWo2tj2xTo+wB4A0A8Bk+HuxDPsvbsJVF2UdNLgiB6aCEujHZKzhUhRVF8CHqTy/Zp8iGMSZ33Z3s/KHwI7FTd1QPNisBgFmrEffAzn93HmZ6A3sFmyL70rNcy6/GN9OfUNr01d+AAAAAAElFTkSuQmCC"
            } },
            {0x002A,
                new Items.Item()
            {
                Name = "Black Flute",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////4+Pjo6LjY2IjY2GCwsGCQkJBwcHBQUFAwMDBqLLfBAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAiElEQVR4nGNgIAw4JyBxpmUiSSROQ0hNEhebgJCoQCibJq6MRWLmzAnTxNsgEjOTiiphEpxpgkIZ5VAJzkSh5AyYjmliyWlmHVCjpnWkmaWkd0I4M8orUtJcIyGc6eXlbW4wGc5yoBRMBsgpTyuHOQyorr0M5jCgVHsa3JUzK9JmInw5E4kNBwDvcS24rU5Y0gAAAABJRU5ErkJggg=="
            } },
            {0x002B,
                new Items.Item()
            {
                Name = "White Flute",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////4+Pjg4ODouOjAwMCgoKDYiNjYYNiwYLAwMDDfLrIVAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAhUlEQVR4nGNgIAw4JyBxJmkiSShOQkhNFhKagJBQQSibJGSGRSJyZsAkISeIxFRlZVWYBKeSoLCKElSCVVFYTQWmI0hITSnJJQBqqItSkrqSK4QzRUlFXamiFSqjpORUpOQJtU8JKFXRCecAgSoDQp1SAANcykkJ7sqZKkqRCF/OnIolTAA7NBveDyVCBwAAAABJRU5ErkJggg=="
            } },
            {0x002C,
                new Items.Item()
            {
                Name = "Berry Juice",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAMFBMVEX////o+Pjg+NDg0JjI2ICw0KDouHDIuICouGCgkFjIgEiAkDiIeEBYaBBgUCAwMDAbBM22AAAAEHRSTlMA////////////////////wFCLQwAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAtklEQVR4nGNgIBFcQGLzxiNxLn78gJCQ55cHM/je//9/8QMDWIbvq5KSrnwcRMVTFReXi19CH4AlJnmtWiu/ymk+iMNvsipt1aq0RfYgznOjZWlZy9KSLEEGfN+smJaWlig8E8yZbqykJCg8YzaYc7Ky2NjYeuZuEOf3zD2zK91duveCOPz7Zs6eXrJ7932w0bP3nd7ZUX0XzGH4ufd2d/feuxBH8/+9e3vv3f9Q5/P/BwL8wQAAkVpNEyVmzPQAAAAASUVORK5CYII="
            } },
            {0x002D,
                new Items.Item()
            {
                Name = "Sacred Ash",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAFlXhBdAAAAEXRFWHRTb2Z0d2FyZQBKVEwtRGV2J4CxQ84AAAAkUExURf///6ioKNjYaPDwoGBgGPj4+NjY2MjIyJiYmHBwcFBQUDAwMEZWRaQAAAABYktHRACIBR1IAAAACXBIWXMAAB7CAAAewgFu0HU+AAAAAXRSTlMAQObYZgAAAM5JREFUeJyFjrFOwzAQhv9msnRL7LpTlrjqlqVR+wCJ407ZouYd+gQYmCs1MLEaRsTQrUUCKuXlsBOEWIBvubv/zp8MDy3BQkVUYBfmGOw5AZ0wMvFNVYPJFO8Pfo0fRK2KfdTwRQJcnPGnrLsr8CvEk1DOrQp6M5X++dtamxR0v+HCZ0eXBYu9rf3wYZ8GWX/Cn1Dff/evs0bxr/uzale5LAcHVUrnwpRhddlruRWGZyHvjs4IPR8MdLA37mV8TYcre/24x6juu8798wvgEygRLe7g5+BxAAAAAElFTkSuQmCC"
            } },
            {0x002E,
                new Items.Item()
            {
                Name = "Shoal Salt",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAAvUlEQVRIx+2VwQ3DIAxFGaUjMEqPHaMjMEpHYIQcGYURuFF9JEeWY6v2IZeKw48jBb+H06RJtdZ0Z9IWbMGfCUopE7lFAPAYYyUiCcOR3rtbEoYjrbUVj8S88H49pgbH7hEuyTlPtwBgNGi3hcN5xVrqMwW04Pg8Z2/lhMoq4VyCXilaBw4+E4Cj8n6ck+QyAZdgoTUJhXZOPeoE2m8gRbRLWS2w6ymSIi0W2P0eWBP9Aof/KgCkeMD7e+DOFxTcL15y/w9gAAAAAElFTkSuQmCC"
            } },
            {0x002F,
                new Items.Item()
            {
                Name = "Shoal Shell",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABRUlEQVRIx9VVuRGDMBCkJMqgJJdACSqBkBIcEhISEhI6VIa9wFqn04EYPzN2sMMzYvdu9ySKtm2Lb6L4GYGyLOeqqiJ8RIDE3vsNw4JxHE8JZYlBBPS3aQHvp76fXXeduweORHbJ10q9qjy+UtwdiJjk/JB2aKBqdIAryPnOEokeVq9D5ZY1q3CcBbuAyKWu512B1RptiW0TiZkF7q0ukuqDPfHUSEhi3QWKNAVC9YHEsoeVWkF3OYG48hyGxCJNbmaQmyBCW4RvEfBuB9qqI3ukRVhPck6RFEkEuCCQeDNwEvdNs4DkOodkH3AhhfYAe0AMq+Sm01mYGYCclVGMz24jkuS0021dy81m+o8FHDvtfXdIPpwNeXiKsH2eP4DcI04Enj2LrE0nQ5TjqYlPn6Yy8PhsSqeJa976o7E6a5L+66f/Ku5nDfEqdhKHwQAAAABJRU5ErkJggg=="
            } },
            {0x0030,
                new Items.Item()
            {
                Name = "Red Shard",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAD1BMVEX////wkIjAWHAwMDBYCCAvd5UXAAAABXRSTlMA/////xzQJlIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAEBJREFUeJxjYKAxYDZA4hgKI3jMgoIInqEgkIeQEBR0RpIQgXGMFAUFXWB6jJQU4RIMzEZKLkhGG8El0F1ALQAAXYUF90PN21gAAAAASUVORK5CYII="
            } },
            {0x0031,
                new Items.Item()
            {
                Name = "Blue Shard",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAD1BMVEX///+osPhwWMAwMDAgCFgJ+PxxAAAABXRSTlMA/////xzQJlIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAEBJREFUeJxjYKAxYDZA4hgKI3jMgoIInqEgkIeQEBR0RpIQgXGMFAUFXWB6jJQU4RIMzEZKLkhGG8El0F1ALQAAXYUF90PN21gAAAAASUVORK5CYII="
            } },
            {0x0032,
                new Items.Item()
            {
                Name = "Yellow Shard",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAD1BMVEX////44FjAqEBYQAAwMDB+8iwVAAAABXRSTlMA/////xzQJlIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAD9JREFUeJxjYKAxYHFA4jiKIHgsgoIInqMgkIeQEBQ0QZIQhnGcFAUFjWF6nJQU4RIMLE5KcAkQDy6B7gJqAQCrwwZwnzS3hAAAAABJRU5ErkJggg=="
            } },
            {0x0033,
                new Items.Item()
            {
                Name = "Green Shard",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAD1BMVEX///+Q8IhYwHAIWCAwMDCHR/iRAAAABXRSTlMA/////xzQJlIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAD9JREFUeJxjYKAxYHFA4jiKIHgsgoIInqMgkIeQEBQ0QZIQhnGcFAUFjWF6nJQU4RIMLE5KcAkQDy6B7gJqAQCrwwZwnzS3hAAAAABJRU5ErkJggg=="
            } },
            {0x0034,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0035,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0036,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0037,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0038,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0039,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x003A,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x003B,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x003C,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x003D,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x003E,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x003F,
                new Items.Item()
            {
                Name = "HP Up",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAKlBMVEX////w+PDg8OCg8KDA2MD4wHCQyPiowKhYuFhooOi4kChAiECQWDgwMDD5PEG3AAAADnRSTlMA/////////////////1dK2xQAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJZJREFUeJxjYEAHt3fv3gtj8zYbG1tcgHK4jYFgA4wDkoFzOoAAxuEFcWB67uwAgrNQzqmYM0AAVXVq1Zozp85A1PFWha46s+o4lOPkumrVcncYR0hJSQnOERRLROKkpSE4YoliSQiO5EQ4p0hw5ky4siOSM2dOqoFyToUoKXnBXHBm6apVq6Achrsgd96FBcJdIMAIJQDcjkev7MVnZAAAAABJRU5ErkJggg=="
            } },
            {0x0040,
                new Items.Item()
            {
                Name = "Protein",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////w+PDg8ODA2MD4wHCowKjwoKDwoAC4kCjAYGCQWDiIQEAwMDBpkVghAAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAj0lEQVR4nGNgQAend+/eA2PzTEtLyzwA5XCnAcEGGAckA+fMBAIYhwfEgek5tRMI1kA5K7xWAQFU1YqOrlUrVkHU8US4dKzqWArlGJl0dLSawjhCSkpKcI6geCESp7wcwREvLy9CyAgKwmWCkGUWg2SioJwVzkpKFjAXrGrp6OiAchjOgNx5BhYIZ4AAI5QAoBpBhruoXasAAAAASUVORK5CYII="
            } },
            {0x0041,
                new Items.Item()
            {
                Name = "Iron",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////w+PDg8ODw8KDA2MD4wHCowKi4uFi4kCiIiEAwoACQWDgwMDBw93nUAAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAkElEQVR4nGNgQAcnZ86cA2PzFBsbmx+AcjiNgWACjAOSgXPKgQDG4QFxYHpOTweCPVDOjujdQABVtaOje/eO3RB1PBmhHbs7tkE5Tq4dHW1uMI6QkpISnCMotRCJs2oVgiO1atUihIygIFwmCVlmC0gmG8rZEaKk5AFzwe7Wjo4OKIfhDMidZ2CBcAYIMEIJACLPQWtroAEzAAAAAElFTkSuQmCC"
            } },
            {0x0042,
                new Items.Item()
            {
                Name = "Carbos",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////w+PDg8OCg8PDA2MD4wHCowKhYuLi4kCgooPBAiIiQWDgwMDDpcCS9AAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAkElEQVR4nGNgQAenVq1aA2PzFBsbmx+AcriMgWABjAOSgXPKgQDG4QFxYHpOLweCPVDOjujdQABVtaOje/eO3RB1PBmhHbs7tkE5Tq4dHW1uMI6QkpISnCMoORGJM3MmgiM5c+YkhIygIFwmCVlmC0gmG8rZEaKk5AFzwe7Wjo4OKIfhDMidZ2CBcAYIMEIJAISSQXhWZfKXAAAAAElFTkSuQmCC"
            } },
            {0x0043,
                new Items.Item()
            {
                Name = "Calcium",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////w+PDg8ODA2MD4yKD4wHCowKi4kCjQgEiwaDCQWDjwQAAwMDBMVgdsAAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAkElEQVR4nGNgQAcnZ86cA2PztLi4eByAcjhdgGACjAOSgXM6gADG4QFxYHpOzQCCNVDO8qhVQABVtby8atXyVRB1POmh5avKl0E5Rqbl5WVmMI6QkpISnCMovRGJs3s3giO9e/cmhIygIFwmCVlmMUgmC8pZHqykZA5zwarS8vJyKIfhDMidZ2CBcAYIMEIJAC+1QErz9BwZAAAAAElFTkSuQmCC"
            } },
            {0x0044,
                new Items.Item()
            {
                Name = "Rare Candy",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX////Q6PiYuPh4kOhgcNBQYMAoOJgwMDABHgNIAAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJZJREFUeJxjYCAIypHY7CoFCE6pMBInSCgdxisvCxJWcoewS4yNzUyVzSGajZRUnJOMITIsiiJGxsahED3Jis5KymblEE6xkiOQAzWr2MxIyTgcyikxM1I2gXDCy1xTjI1dE8DmJqkYpbq4QMxiT0tSNA8NTYfqcBM2K4d5gN3NRQzhk7AkcSSvhKUjebLUHdnLSJ5EAAAXOh1jyFr1mQAAAABJRU5ErkJggg=="
            } },
            {0x0045,
                new Items.Item()
            {
                Name = "PP Up",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAKlBMVEX////w+PDg8ODA2MD4wHCowKjwoPBguLi4kChIoKC4WLiQWDiIQIgwMDA5ggb1AAAADnRSTlMA/////////////////1dK2xQAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJBJREFUeJxjYEAHd86cOQtj8y5LS8u6AOXwpAHBARgHJAPnrAICGIcXxIHpuX0KCPZCOTu8dwMBVNWOju7dO3ZD1PFGuHTs7tgK5RiZdHS0msI4QkpKSnCOYHk5giNeKD4JwREUROKUl8M5Qcgym0EGREM5O5yVlCxgLtjd0tHRAeUw3AW58y4sEO4CAUYoAQCuAEberNsKYAAAAABJRU5ErkJggg=="
            } },
            {0x0046,
                new Items.Item()
            {
                Name = "Zinc",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////w+PDg8ODA2MDoyGj4wHCowKiA2AC4kCi4gDB4aACQWDgwMDAfuNIeAAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAj0lEQVR4nGNgQAenVq1aA2PzTHFx8TwA5XC5AMECGAckA+fMBAIYhwfEgek5vRII9kA5O6J3AwFU1Y6O7t07dkPU8WSEduzu2AblGJl2dLSZwThCSkpKcI6geCESp7wcwREvLy9CyAgKwmWSkGU2g2SyoZwdwUpKFjAX7G7t6OiAchjOgNx5BhYIZ4AAI5QAhrdBWkA0I+4AAAAASUVORK5CYII="
            } },
            {0x0047,
                new Items.Item()
            {
                Name = "PP Max",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAKlBMVEX////4+OD48PDw4ODA+HD44FjYwMDgyEjAqKiQuCjAeMCIiAhYkDgwMDDIfQ+HAAAADnRSTlMA/////////////////1dK2xQAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAI5JREFUeJxjYEAHt3fv3gtj8wYKCopegHK4QZwNME5paGg4nBNeXl4K4/CCZGB67mzfvn33WSjnpM8ZIICqOjlzzpmTZyDqeDtdZp6ZeQLKSU6ZOXNGBoyjbGxsDOcoaS1C4qxaheBorVq1GCGjpIRDGbLMMZBMD5RzJtnY2AzqHIa7IHfehQXCXSDACCUASGZGxE1AcXQAAAAASUVORK5CYII="
            } },
            {0x0048,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0049,
                new Items.Item()
            {
                Name = "Guard Spec.",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABJklEQVRIx92VsQ2DMBBFGYURGIMRMkJKRqGkTEnJKJQpKTOCO6KP9NBxsgkmiRSlOGFs895x2KYYhqH4ZhQ/Kahv9VxV1RofFQjYdu0m9kSn4OM0rvAQwnwP0yo6LbDw69gsIThh3yZbYOGXvl7CwhFmCfQhy6ZcQsD+0S0AD9e9FXhJEs6DAisQqt7AGdNcjZPEroCsyRyJwLrqYbV5qyyBh9rMvURzAFMitfWdkgIN2Ac81Gasey/w8KhA2XKNSegTnDmxzJMlIiOypTw2c1se9afgG0GsNK8yR7J3Hm3K4+EI1O+htNV/6LCLCYBTZ9pITgsIC2e52swRHRLY3WsDOLXmLGK1Zf1w2AepYJUdKU3yqEhJyJjxt36ZFsam+6+ffk48AUzoFGJMXaSYAAAAAElFTkSuQmCC"
            } },
            {0x004A,
                new Items.Item()
            {
                Name = "Dire Hit",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABLElEQVRIx92VwRGCMBREOVpOjpZiKR4pgRIsgSMlcKQEjpaQG7J/svET8pGgzjgedghJ2Lf5kFC1bVt9U9VvAmo3OffURwEwvDXNQlugQ+b3oYvm3vvJj30EHQZo87G7iMQ8SK+mGKDN+8aJtDmBZYD5RV7PJ5EYDrUYpOa414AUYprzQRhDBKLeERDGMBfjDLEJYGomjxAYz1c8jDZXVQRYmerkCQRzaMwSoY33ZAJkQD2wSq4S4z4FpOZZANLymoOwD+ack0tuloiJmDaWRyXX5UG/Zb4E5ErzIjkhW+fRojwr8wBAf2rKtqx6z2GXBQRz1pltQo4DgrQ5P1ednKB9x7XavVo0Z615FvFrK/rhcB9Y4le2pzTmUWFBmDiOv/PL1GbcdH/20y/QA7rjM5rK2EihAAAAAElFTkSuQmCC"
            } },
            {0x004B,
                new Items.Item()
            {
                Name = "X Attack",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABLklEQVRIx92VsQ2DMBBFGcljMEZGSJnyRqCkTJmSETICZUrKjOAu4Sx/62P5AKNEilKcQsC89zmw3QzD0Hyzmp8UXNv25ZxL9VGBAvuuW9Sa6BB8GscE996//PRIosMChk9yCRXgsfhpqgUMv5/OoRgOYZVAX6TMg7UU+OxvAZDD9T8LcokJx40K1oJQ+w04rulYvY4QqwKkRnJIFKy/LkrwVFWCHMrJc4mOARgtCsfzezIFeoFvyKGc2MUwPD6HFwUSJ43ElKXkkGBMKbnZIiRCWikk5/boeQu+EJRas5UckrX1aNGeHA6BnpfCi4Vs12JXEgCe+hyPITksQDEcnysnh2iXgGcvF+DoNdYi2bEXmPPAKnxle1pjLhWWRGgH22rL5mrKMEy6/9r0a+oNSBspGmwcTRUAAAAASUVORK5CYII="
            } },
            {0x004C,
                new Items.Item()
            {
                Name = "X Defend",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABKUlEQVRIx92VMRKCMBBFORIlR+AYHsHS0tKSktLSkiN4BEpLSo9Ah/NxHrPsJEhQZxyLHUIS3luWJGRN02TfjOwnBWV5HvI8n+KjAgGrqp7FkmgTvG27Cd73/XDr+km0WWDhh+MzBCfs2yQLLHy/u45h4QiTBPqQRXEaQ8BLfR8BHq57K/CSKJwHBVYgVL2BM6a5GieJRQFZkzkSgXXVw2rzVkkCD7WZe4nmAKZEaus7RQUasA94qM1Y917g4UGBsuUaktAnOHNCmUdLREZkS3ls5rY86o/BZ4JQaV5ljmTpPJqVx8MRqN9Daat/1WEXEgCnzrSRbBYQFs5ytZkjWiWwu9cGcGrNWcRqS/rhsA9iwSpbU5roURGTkDHjb/0yLYxN918//ZR4AJabK3JSH4l4AAAAAElFTkSuQmCC"
            } },
            {0x004D,
                new Items.Item()
            {
                Name = "X Speed",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABIklEQVRIx92VuxGCQBiEKcUSKMMSLIFyDA0NDSnD0JDQMsjQZfic9Z875FBnHIMd5R77LT/3qNq2rb6p6icB28NhqOv6oY8CZLi/A1xzoFXml+v1Yd73/dDdBWg1wM2b83mUzJG/TTHAzXfH4yg3B1gE0IfcNM0oGZ6mskRzPTsgQrLmTJSxBLAzc/o0Vv2EmAWQmuRAuslQk7speTEgmnryCNEYjCnRdvpOWYA6fEI09cR6joBongQoLb8pCG0yZ0wqebZEJCIt5fHkXh6158yfAKnSvEoOZO48eipPNAeg9mjKf7UvOuxSgJMdC/6GQFYDkJuzXD05oEUA370uzKk1ZxGrrejCYR/kxCpbUprsUZGDkJj+t65MN2PT/delX6IbN2pHojKq7qwAAAAASUVORK5CYII="
            } },
            {0x004E,
                new Items.Item()
            {
                Name = "X Accuracy",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABJ0lEQVRIx92VMRKCMBBFORJH8QgcgaNQUlpaUnoES0tLSkvLdDo/42OWnQQJ6oxjsUNIwnvLkoRqGIbqm1H9pGC/6+51XU/xUYGAfdfPYkm0CT6exwkeQriH8TaJNgss/NQeY0T4M+zbFAss/ND0MSwcYZFAH7KtmxgCXodLBHi47q3AS7JwHhRYgVD1Bs6Y5mqcJBYFZE3mSATWVQ+rzVsVCTzUZu4lmgOYEqmt75QVaMA+4KE2Y917gYcnBcqWa0pCn+DMSWWeLREZkS3lsZnb8qg/B58JUqV5lTmSpfNoVh4PR6B+D6Wt/lWHXUoAnDrTRrJZQFg4y9VmjmiVwO5eG8CpNWcRq63oh8M+yAWrbE1pskdFTkLGjL/1y7QwNt1//fRL4gERtEsyxjkR6gAAAABJRU5ErkJggg=="
            } },
            {0x004F,
                new Items.Item()
            {
                Name = "X Special",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABKElEQVRIx92VPRKCMBBGOYpH4BgewSNwHEtKSkuOYWlpyTHo1C+ZB+tOggR1xrHY4Sfw3sdCQtX3ffXNqn5S0Lb7W13XU31UIGDbHp9qSbQJPgyXCT6O46Ouk2izwMLP5yZUhMeyT1MssPCuO4SycIRFAr3IptmFEnAYTgHg4Tq2Ai/JwrlR4AiPQvUbOGO6VuOEWBSQmuRIBNZWN2ufpyoSeKhN7iW6BvDcon14T1lBfJnzDR5qE+vYCzw8KVBatikJ5wTnmlTybItIRFraY5Pb9sSxy+uZnGrNq+RIltajp/Z4OAKd91D2dX7VYpcSAKfP7CPZLKAsnM/VJke0SmBnry3g9Jq1iK+t6IfDPMgVX9ma1mSXipyExIy/9cu0MCbdf/30S+oOo/pHovRLKxAAAAAASUVORK5CYII="
            } },
            {0x0050,
                new Items.Item()
            {
                Name = "Poké Doll",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAFVBMVEX////40NjwsNDQkLCgYIBgQAAwMDCpkR3VAAAAB3RSTlMA////////pX+m+wAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAp0lEQVR4nH3QSxKDIAwG4K7YB53u/WE8gFH3oDfo0DW2ndz/CA2obVcNi+Qjw/Ny+RsiZ2VEqBHZJ0wKBE7pfsBGntJcMYXWw912DAEecLmiazEC/Q6iNVigYqOrDmD+wqKv66kEbNnBNESyke1OlI63eh+zVFjEoK1X0Lpd3ThkPcZ3RJGWuYARyTtuH65g8BiZPeuppmRFL+U+T83CnI9n599f+MQbvk8jZaiNNoIAAAAASUVORK5CYII="
            } },
            {0x0051,
                new Items.Item()
            {
                Name = "Fluffy Tail",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////4+Pjw8Ijw4PD42KDY2FjoqHCwkKjAiFCIYICASBAwMDBRsyCLAAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAADHSURBVHicXZA9CoMwHMWz2ow9gyfIUIqrhKKTgotzCIEeoWsJoS6upUsHDUEXi7SIuVzzUUX6ICE/8n+PvADwLzhs4F3qFWEWNulCu7xo4nS5aUuCT4N3w0ReCa28+xPHGOPKu1XSEEKFmYN5IduSUsYGNzZnoaRc9C5gzgvFmFDDL5pzscBNCSNpIND1ZM83m/1CEbSkDAT7B6qh7jpxNoYjGM3wxG0LGDmAGlg/uh9q9/inWSO6+CJ2M9HaNlyL91pv/8TpCyBATQ5OG5wDAAAAAElFTkSuQmCC"
            } },
            {0x0052,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0053,
                new Items.Item()
            {
                Name = "Super Repel",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBwYqORph/80AAAGJSURBVEjHzVUhbINAFH1sFcO1rsiTJ7YECaICO4fsJTMVNXWTy5ItS+VcLRLk3JhDHvLUgkR06Son526CHi2hsGtZk/2EkHw+7/377/9/wInN0AmybVvu8wshjM4Z2LYtpZTyfbWqPFJK2US8az0dklfOce26NZ+O9XRKQwipARJCypi2Up23gT8tFjD7fVxeXWEwGOAtjvGxXGI0GgEAvgHcTKfIhHhYr9eP2iIr8JRzjBlDFIYYM1aJicIQjusi5RyO6+J+NtsremOJ1I8KPArDyndno4kiOVgDyyQlCYDyBHme1xKxTHKcyL7H8JKEFaJdYJVIpzb1vSJzSi0AQJZ9bvwFcJq2t+vZqVfFyQl6uoF5mgAAkjgGAHjj2787QRI9a/mOImgD0iE5TANKtUujrcHXcFjMACFAliGJY1DfL2fB7HoC32PbVUBpBVzNSOcu8j1WrghFpgPeSCCEMIJgLoE7OE6xIjy7eFsX9dUQBPPG69P47cKZTLYktY2b8lbw/3Hpd7Ufv/y1EFqhNOAAAAAASUVORK5CYII="
            } },
            {0x0054,
                new Items.Item()
            {
                Name = "Max Repel",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBwYrCFKkzrYAAAGGSURBVEjHzVWvT8NAFP4GE8x1jpMnJ1hyshUTtTjkLsEgJpjENSQQMofcJPL6H1Dc5E2egsqKkTE5B+4Q620t28ptpQkvqbl7/b5373s/gIqtZuPEGNPbzpVStdIRMMa01lq/zma5T2utdxFnrW5D8iwlzj1v48zG6japoZRuAFJKVz5FqTouAn8YDtFwHJy122g2m3iJIrxPp+h0OgCALwCXvR5ipe7m8/m9tcgGfCIlupwjFAJdznM+oRBwPQ8TKeF6Hm77/a2i70yR+dGAh0Lk7t1UE0OytwY+TTCWayDzgiRJNgLxaYLoEJEDTjAQcvWan8AmkFJlGnACAGg4y6r5XIxTYJISFRMcVT0qKieo2zq+xTEAIIoUAOD6iv3dC0ZPyursIIIiIBuS/TQgLevUWGuwODld9gChwEeMUaTQ8i8yvVCyTANO1qOAtHLgpkdKV1HACcbpiDBkNuCFK5Mxph8DdzUiGo6f6+TsyLgZTHauz9pvCydLsm3iFoH/j6Vf1r4B2P65zXBNFzUAAAAASUVORK5CYII="
            } },
            {0x0055,
                new Items.Item()
            {
                Name = "Escape Rope",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBwYrCFKkzrYAAAGGSURBVEjHzVWvT8NAFP4GE8x1jpMnJ1hyshUTtTjkLsEgJpjENSQQMofcJPL6H1Dc5E2egsqKkTE5B+4Q620t28ptpQkvqbl7/b5373s/gIqtZuPEGNPbzpVStdIRMMa01lq/zma5T2utdxFnrW5D8iwlzj1v48zG6japoZRuAFJKVz5FqTouAn8YDtFwHJy122g2m3iJIrxPp+h0OgCALwCXvR5ipe7m8/m9tcgGfCIlupwjFAJdznM+oRBwPQ8TKeF6Hm77/a2i70yR+dGAh0Lk7t1UE0OytwY+TTCWayDzgiRJNgLxaYLoEJEDTjAQcvWan8AmkFJlGnACAGg4y6r5XIxTYJISFRMcVT0qKieo2zq+xTEAIIoUAOD6iv3dC0ZPyursIIIiIBuS/TQgLevUWGuwODld9gChwEeMUaTQ8i8yvVCyTANO1qOAtHLgpkdKV1HACcbpiDBkNuCFK5Mxph8DdzUiGo6f6+TsyLgZTHauz9pvCydLsm3iFoH/j6Vf1r4B2P65zXBNFzUAAAAASUVORK5CYII="
            } },
            {0x0056,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0057,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0058,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0059,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x005A,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x005B,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x005C,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x005D,
                new Items.Item()
            {
                Name = "Sun Stone",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX////46Mj4qHDwgEjgcDjAYCiASCgwMDAC+ZohAAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAMBJREFUeJxlkE8TgiAQxT3pGcbqHEJ9gMq7CHiuRK/phF79N/H1A8zGpj3tb9/O47Ge919Bt4J+92m0EWC2TDP/KcrHDIOYQJiUrbZQVSFFsJiQNfEBljdyUtJCAAkIUZSVbg1dIUJ0654aOdgjjGfzkUNIMWtdEkUgo5w5pa+4mSsed9arPudMyDQ28QIs5KVQMs8TI730hkh5b+rceQ+RFEWrXTbPV6kolt8NomnqL3B9OyzQZ950XF3j5yBzvQEmGCxbNVnYQQAAAABJRU5ErkJggg=="
            } },
            {0x005E,
                new Items.Item()
            {
                Name = "Moon Stone",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////Y8ODI4NCowLCAmIhogHBYcGBIYFAwMDA8ngtNAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACfSURBVHiclU+xDoJQDGSTHaP+ga6kGJl5hbjT8gW2+AHkwUji8j5b6cO46OBN19z1cpck/2EK84fS8b7ywFgP15Xnnkc8GU8d7FQlKg90e0/NZEKBMCq3FpCemT1j25tLtfeEbjZhgK0gwnIMHbpC0JXmEmxUCA7xpRO+Ub64NjoKUwPBgutXbN2G2KUQQixjyTQTrLL3lkBwCd82/sQTd3AtBDa5SDIAAAAASUVORK5CYII="
            } },
            {0x005F,
                new Items.Item()
            {
                Name = "Fire Stone",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////4+Oj4+Ij46Jjw6DDg4HjYyBDAwGjwkDCgoEjYcBB4eCAwMDDGqmE2AAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAxklEQVR4nGNgwA+4z5w5swHK5jkaHioocwDCOVpeHhqovgciESheXVruDuEcFRSs3u7iWgORMBacOcWlFMw5Kmwo3OHiHgrmHDQ2NgZywmNAdggaG1t0uLhMB3F4hIHsFicYBySu5FkO5kgA2R5K06tBLtg4o8PFo0Vp904Q5+iMjhaPlszZYAcc3WHc0bEsLXsOxE6LlrS0tJlgRx8UXgVig+1nOCgN5MycDvHNwd27Vk4vr4F6c+bM6dVnoN5k2HMGzkQGAFGPSkR/nQnjAAAAAElFTkSuQmCC"
            } },
            {0x0060,
                new Items.Item()
            {
                Name = "Thunderstone",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////w+PCo8KjQ6HiI0IiwyFhosGhIkEgocCgwMDAVh1yiAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAr0lEQVR4nIWPsQrCMBiEO7ZjQOzuos4Bu4cQ2wcofYCGq7shf7tV0cFNOwh5W5s2BRfxpvs4+P+7KPqjh3P94h2AXfAJS8mK5wyvEYA8BCw1QBEClkp16ELArKxVF4I1FDd7Dxe2AupMe0gEqznnmfCPYmHPIxjp/9w2bTnKwvcZtm1JIJqODXSvJBo6BTASMFO1oa2kWspcG0MEPXdO5JGsLsKaN6DzZWfsvjb/0Ac77DVrBoyuoQAAAABJRU5ErkJggg=="
            } },
            {0x0061,
                new Items.Item()
            {
                Name = "Water Stone",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////o6PjY2PjAwPioyPCQsNiYgPhwkLhoaNhgUMhISLAwMDCGipm8AAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACxSURBVHicY2AgAFbv3r0byuTeZWw5c+YGCGezsZKSklYWRMJISVBJaVU3mLNLSFFISR3GERQUUiqHcLitBAWVpletmg3mGKe1uLhAOZuN0zJcXFdVzQJzzNzSXKJWgu3hNm5LS8vomDltAURLSkZH16psqP6Mjo5Vy8CuWWyW5tHiVZUNsdLMo6OlCiLBsCvFFaYDyJkaOgOqA8iZOXPVMrjPpmW0wdgMXLt37yIUKgwA3vNA8UFmyNMAAAAASUVORK5CYII="
            } },
            {0x0062,
                new Items.Item()
            {
                Name = "Leaf Stone",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////A0KCIsIiYqHh4oHhokGh4iFhYgFBIcEBYaDg4YDhIWCgwMDCRt+VQAAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAwklEQVR4nGNgIADmnFkAZ58RNJ4DZwtnTTQ+AGHzCGeVugpDOQezPMLbE3OgEstbyyOCbcCchVburaWtZWITwKoyWioiwsvAmkCqSto7giEcsSUVrqUugdYgzmSzdveIjlZDMxDnoPDylvDyUuE0EOeYoHlrq2sgjGPVXh4oaJa2AMwRWmwoLLx7D8iaw8nqhoKC2TPBnMXJxYKCZpkzwQ7lSctMM0vLhPrn2LTs3WmZMO+cnDlz9xmYR7nOnDmFGSwAQ1pFIdu9UpAAAAAASUVORK5CYII="
            } },
            {0x0063,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0064,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0065,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0066,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0067,
                new Items.Item()
            {
                Name = "TinyMushroom",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////o2Njw4GDo0EjYyMj4oICwoKD4cFjQOCAwMDDi5pI3AAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAXUlEQVR4nGNgoDrgnDlzApzdqmReCeNMDQ0Nr4BJtSJxOENDg4zhHFUgpwPGUQoNNu6EGWYUXl7RCZMxLy/vmOYJ5QDZnSmSUHUzOjqnOcI4nDMnTBGEuwfEp4onASpRG52VB+4wAAAAAElFTkSuQmCC"
            } },
            {0x0068,
                new Items.Item()
            {
                Name = "Big Mushroom",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////o2Njw4GDo0EjYyMj4oICwoKD4cFiIeHjQOCAwMDCPj+dwAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAItJREFUeJxjYCANrFoAY6xaNVO1CsJeWVxuHqo6C8zmKg0vNi8NhXA4Q8OLy0sjIXqWh5aXl4fCOOXF5sWmEFVAjnG5cSSUs9i8HK6FYXF5cXnorAVwZaGRK7IgnEnlqqGz2lIgUlNDQ2euSHMEc7hUQyNnLUsRhHCA7AVcjlIQp1WCTIL5AO4TsgAAzRAyGf8d1x0AAAAASUVORK5CYII="
            } },
            {0x0069,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x006A,
                new Items.Item()
            {
                Name = "Pearl",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////4+Pj4+Mjo6Ljg4OCw4NiYyMC4uLjQqKigoKCQoKB4iIgwMDBwhN4rAAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAXUlEQVR4nGNgoDE4cwbBPq1kugfG5nFxcTY9AOVwOwq6FG+Acg45CrqX50A5hwsF3Zf3QDnHy1dV74RxjpZ77Z4BM457+e6dHTADeLKnzOiGGc1wumM33FJU51ACAPX0He87reCFAAAAAElFTkSuQmCC"
            } },
            {0x006B,
                new Items.Item()
            {
                Name = "Big Pearl",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAALVBMVEX////4+Pj4+Mjo6Ljg4OCw4NjowMCYyMC4uLjQqKigoKCQoKB4iIhISEgwMDATnz4ZAAAAD3RSTlMA///////////////////ljZ6mAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACMSURBVHicY2AgE/C9e/cAzr7iEtoL4z1xVjKN6INKuCm5OJtmQKR4kwQlWlzDL0BUJQlKt7iEQ9Q9U3L07miJhHKUu3d0t2RCOC8tpHfsPpK5Dsx5VbF7955jM6Gc6bu3nKmcA+Hwnqw5c3zmHIjRfGtmllfOOQV1z6szQLAO5tBbq1atRTgbyQukAgCGTTyJpGwhXwAAAABJRU5ErkJggg=="
            } },
            {0x006C,
                new Items.Item()
            {
                Name = "Stardust",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////4+Pj42NjwoKB4sOhgmNDYcHCYSEgoYJgYOHAwMDDpHqerAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJ5JREFUeJxjYCAbcK1ahWCv6OiA85a6uER0LIBKhLi4uEZ0QTgrQlxdXEI7JoA5K2dGuLiGQtRxTY2Y6hoK0cS1xCWiMyK0A8xZ0Tk11LO1owNkAFdHe2WIywyIBFdHWdpM1xlQS5ebmaVNnQVhcxkqqaWVQq1fLCRklN7JBZVQVFJO72QAK+MyMjIyy5oJdfEqY+O0BXDPrELyGC4AAHDTM6cF1bu7AAAAAElFTkSuQmCC"
            } },
            {0x006D,
                new Items.Item()
            {
                Name = "Star Piece",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX////4+Pj42NjwoKDYcHCYSEiAMDAwMDAZiurrAAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAGhJREFUeJxjYCAbsBUgcQqROOnCcA5buSCck16sKCjiBuWUKCkJmrhDOewuRoouMA5DiouTi3ECTJ2Ls7MxzAQ2Z5OwEHOYJmPTtLTUAhjHNSytHKYuOTS8HO6aknAkp5Uiu7mcgXwAAAPlFHVdcuIzAAAAAElFTkSuQmCC"
            } },
            {0x006E,
                new Items.Item()
            {
                Name = "Nugget",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAAxklEQVRIx2PYsGEDAy0xw6gFQ8cCAwOD/8iYahbADPzxIOH/jxMe/0+s8ADTxFpE0HCwwcgYagmyRWRZgGL4jx8QDLUAhGcUCMAtwmcJ2RaADAZZAsIkWwA2HGQQevDgsACfL/BbgG4JTAzNAny+wGkBLBJRMCiYkCKZbAsaIhhQUgq6y9EtALFBekiKZGTN2DCy/IEZFqSnIpCLYMkRZhAyDWOD1OByPXEZDUuEIhtOdkZDtgRkIHpcEEr/g6ewG61whr4FAKnP6QECCuS4AAAAAElFTkSuQmCC"
            } },
            {0x006F,
                new Items.Item()
            {
                Name = "Heart Scale",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAALGPC/xhBQAAABh0RVh0U29mdHdhcmUAUGFpbnQuTkVUIHYzLjM2qefiJQAAAMpJREFUSEvtlEEOhCAMRT0Sx/MoHsdlj+Gyt2AswyelocJEFhOjSRNF8l/7W1iW9/l7B0IIUcfUhEWYiKuQtSkQiDNztDEFUrI/AaRCYLcB67p9bTHi+LZ9+RlY7CGKbKKqRv5JEmcygA71x/U/wzwIQJcQ2COZ7cdeojTaQFKFuQoBdHsEgBbHe4LcBXjTI5B5gDz72usRAPZcTlWqQB0uQFoA7T961B1ZD2DtgbgW7orLeFlA66qwokPCmN3WKfXWhg7Vu+n5DnwAvTBqlz7qOPgAAAAASUVORK5CYII="
            } },
            {0x0070,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0071,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0072,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0073,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0074,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0075,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0076,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0077,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0078,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x0079,
                new Items.Item()
            {
                Name = "Orange Mail",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////4+Ojw8KDwyIig2IC4oHCgoDiokHB4YFAwMDCaej8qAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAnUlEQVR4nF2QQQqDMBAAcxJyjD/oghXPoT/ICwqLORafIEjaByzNUQQP+a27mtpgTjPLhCxR6nKqVyn3woa6sMGwpVzdjKmTnU9J9jnnirntuyzJNu9vd1Q8n7AH6SphHw/ZmZCAO22RfKSVRpEHEs+RRumWgLQGvuNEYCL8YHCykIbGx8ws8orLiy7Qhh+zwMnc/Vnpgnmh6w/tZwNnejKQrxeZcwAAAABJRU5ErkJggg=="
            } },
            {0x007A,
                new Items.Item()
            {
                Name = "Harbor Mail",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////o+Pjw8MDI6Ojg4LCIyNhokKiIgFhwaEAwMDDJbp3gAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAkUlEQVR4nF3QOw7DIAyAYU9IGa0oQ/deIEIM3XsBV3IfWzvgM/QIHbtk4La1iUtQmP4vMgQBsFvh2ePaKU+dMqqKTxHiVOTbUMSRa/PDYb0ikDYlJpsL9h0To6E2xhkPAIO2HjfGeDIw0wvHxHb44pA/dI+IXWhgvhy9De+zt87dPq1huW9tf2qt2FovtH+hun4tHjGLq7w6kQAAAABJRU5ErkJggg=="
            } },
            {0x007B,
                new Items.Item()
            {
                Name = "Glitter Mail",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////4+Ojo6JDo6HDY2GjgyGjAuJDwoHCwsEDgmGigkHCIeFgwMDBee0o3AAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAr0lEQVR4nF2QMQoCMRBFU26RJgE7m3wQZLEbU1mqFwjGRu+x2MlewcoDWKW2shG2ECGHchLjuuxU7zF/4DNCjKY6D2U+sFYPrFVssaSMUjri2UtEkTaxxqJIhFGYflOc4U3OVdHBABOfJG68B2aHx1EIuSVaeuxDll1NRJ7CPR11gWVNN5fkxVyTdSYVkizBOuRyklZEFqXo+0qNLSy65nL6sZAN9cxHf+ZC4w/l+QADfTKixIZHAQAAAABJRU5ErkJggg=="
            } },
            {0x007C,
                new Items.Item()
            {
                Name = "Mech Mail",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////w+PDY2LDQ2NCosKioqGiAiIBYYFgwMDD8pcyjAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACrSURBVHicXZAxC4MwEIWdxPWQiHPwD0gF9yp2DiV2bSFpZqn2VrPdz26Spla86X3w3uNxSXK49L6HYUeq2pHijii6zpxXBOsGJMQaXZykgDICaTli+XWRuTwNhlBK40sNOAUgJlV3wvHhfBk4qHPEyQMrTAfQIvhya3AuodHChyyyuc57LfygDArsm1aGcRkYvC7vONTictNRJ9aV/7QrZ5t2ob92g44fCvcBhk4tmeXVyPAAAAAASUVORK5CYII="
            } },
            {0x007D,
                new Items.Item()
            {
                Name = "Wood Mail",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////48NjgyMDYyJDoqIDQkGiogEi4eFCQaDAwMDAE+sITAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAArElEQVR4nF2QTQrCMBCFsypkmU0O4MILPFp1K+kF/MWdQjvUAxTdaqWtu4Ig5LZO2qihs3offA8eI8ToomMIu4DyOKAcTNZbayC2bfcDS9R5CzbJ0rMHi9qYw2BZgCb3qfMiSxVIKe2Au4T6pOgphKyzlKo5UbFwYFa6Kq8twN7b3PQj3WOApdKbbYPEDZLcLZsL+nGSuzOf2SvY91m8gizk0P3CP/Og8Yf6+wDXcTRkpLdTqwAAAABJRU5ErkJggg=="
            } },
            {0x007E,
                new Items.Item()
            {
                Name = "Wave Mail",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////o+Pj48ODo2KiQ2PB4mPBggOBAYMAwMDDSeYqvAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACeSURBVHicXdAxDsMgDAVQpqirFXIBunQmJ0A17BnKXKTi9gSdO2Tg2LEpTVE8/Sd9S5aVOsxw7xE75alTBlZprQVgKvjZUbAhS470aijon18MS0EdKTnpDdzHmLQWSPZvDfNFqROiQ09wNRWAGJKzZubeCuhCGo01At4Jj9Gc5SBeusVka2ZoIrLt0BUDUcsMHX5ZlvbM+Gc+6PihOhtdJSuqS+tZqwAAAABJRU5ErkJggg=="
            } },
            {0x007F,
                new Items.Item()
            {
                Name = "Bead Mail",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX////w0HioyODomFiAoLjgYFBIaIAwMDDw8Ee7AAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAIVJREFUeJxdUMERwyAM4wUbZAAuMzBAH84GvNvDcb955OL1a7uGcNFLsiTjI4QH4nsWMClcJ4VZFHvqlfPKdAzBAIenMhPR1wW3UmD7p3Qu0FxkbHsVS4XPrZRQjM9SrZRoQHJnd7R0dUMPSth0G9hx6Z4HK7Xi3Eqd60uDS+nmctDzhww/nFwz+YSmS7EAAAAASUVORK5CYII="
            } },
            {0x0080,
                new Items.Item()
            {
                Name = "Shadow Mail",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////46OjAqKCYoKiYgHj4YGCIcGjAUFBgSEBIODgwMDCmSowLAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAKBJREFUeJxdkDEOAiEQRbck9F6AGKK2JHuE9Qj2u4rsLSzMZGiNIaEzW3JKBxhXsr/6j/kz+aHrNhKPFlxD0DcEhihxajKmT+NnhaQYIHulTwzkGcSUYoyq5kRCUqyQFFiL+Mo5qdXgokUfGO6X4GDOuWV83nbBoa9wPNMEYy4k9WHw1mEpJ/Xe2hm56HINb8eeluD3Xo6vnuDvqdD2h4q+zOg8FNQXFHMAAAAASUVORK5CYII="
            } },
            {0x0081,
                new Items.Item()
            {
                Name = "Tropic Mail",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////g8LjI8Kjo2Iio6IiY2HjwqIDgmHBoqEjAeFBYgEgwMDDNgYT3AAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAAC5SURBVHicY2BAAxwNyJwIJF6rKBKvVRDI2w1VFSgoKLpbdQOcs3tS0AaoKsHd6eVTtaGc3enGZZOiIap2t05PnzkVrIljd+bUsLQZSmBNu8vTMyNnTm1VBWriVi0zy3TRCm0KAmriDko3z3RxcYvoaAKq2zotc9ISd5cQpVYgZ9PMzFaXaa6hESAHcavOVE1xcQWzgZqCIkJdOqAO3araBFEDApsiVOFsBm6NDjgbqAnBBjoIPYTAAABuJDz97RNh3gAAAABJRU5ErkJggg=="
            } },
            {0x0082,
                new Items.Item()
            {
                Name = "Dream Mail",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////4wPjwqOjImNioeLiQYKB4SIhgMHAwMDBfGWwcAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACbSURBVHicXZBBCsJADEWz62xT6AGablw3vUEjuBWMegFn7aZ7EYUc28x0qEOzeg8+/E8Adtc8a7lVtnSVLehmJXVG7Cy+NrFYZMms9yIWVfW0pgwfoiIp1xjiZRLhJM40D8J8AAjONLbMlIWI+5aJ0HNvYu4H5yzMMk7OaVBgkfm4MgTxkiuWoR+vj4Xhq3FjCBW7/NkH7T+U7wfyQSjTW5P7vAAAAABJRU5ErkJggg=="
            } },
            {0x0083,
                new Items.Item()
            {
                Name = "Fab Mail",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAFVBMVEX////4+Pjo8Pjw0NjYsMCocJAwMDCxzAatAAAAB3RSTlMA////////pX+m+wAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAgUlEQVR4nF3QwQ2EIBAFUC5SgLEBI7EAmQYE3PMeLMBsNvRfgn+YiUPk9H7yPyE49zrDtw9Hl07q0hmRqrZyjFTH6wk1hEtb8LivGuC8faTFTqWNBnFuIzEVHnlxLjzy6kAzev9FnRB+UxHzg3yix87PZh6ZMTKjZ8YNZjzo/UPt3JfHIyuZNtucAAAAAElFTkSuQmCC"
            } },
            {0x0084,
                new Items.Item()
            {
                Name = "Retro Mail",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX////wqKh4yEDwiEjIkFhgmOCoYEAwMDBdWyl7AAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAG9JREFUeJxt0LsNwCAMBFAqqJGYwE0GYAKabOA+BQOkibx+bHR8hHB1T7riZOe288+Ke1FNi2pUCVolxiT8DggDVXNmvgDJHb4IGch6XmhCGNBe4COs9x1hgwLQxgEY+hmQG3p2gWhkxcw6aP9Qux+ANyZX3QDJqwAAAABJRU5ErkJggg=="
            } },
            {0x0085,
                new Items.Item()
            {
                Name = "Cheri Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABMklEQVRIx82UIRLCMBBFKzkKMkdAVlYikZXISiRHQHKEyh4BiaxEIpG4MFv4mZ8lm3Y6dAbxVdr3NsluirZtiyVjLqzrlec45/zPBAK8PpqQ823vm66cJTHhAtWZIzHhgCFzd5IUpCAsX0QwZf1/BNZZTxXId5O6SEA8B1rAIP0/CsjOAbcnZCyQNRRg7fALfti4qD1Rqe4iSFEEvtVdFsFl4bLd+PuuCuGpTs0Hi1L3E8EF+DwdQyDITTKLTIEci1Q+gPvunY+AJbiH3L3pAkIVEVwJIMm9qihimkDB+7oadtiVLgLkuictoLPnCFwLAMWuUscTCTRUV68FaEl0j/UIRpcssBQYcIl8qzuIZ8F8izADqQBuXTDa1Lxk/hAwnbHXk4fOnGTrqeBjGZNkd7BEXhCO4o+1k81wAAAAAElFTkSuQmCC"
            } },
            {0x0086,
                new Items.Item()
            {
                Name = "Chesto Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAIVBMVEUwMDDIkPiQcOA4QHhgWKiAWMh4WEjo0GjAsGioqGj////FOsNtAAAAC3RSTlP/////////////AEpPAfIAAAABYktHRApo0PRWAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAAx0lEQVR42oWQMQrCQBBF/5rYpMkGwTrqAUwQch4rrQSvEatcQNBK8BJaiiBqZafJAWQTCyHF7rq7SbARnGKYx8yf+QzZ4hst/IUyAeymFK8GYplT1LBgjPREpYkFA806BkrpggDcQMKuoAjsxIzl8HS6KCgDSF+vCXSHwst8C6bDEUISFzJQd6x24ZFHmOKmgMsJjrvCMxpnL+7+AJUG55R0GSBXGpbqzJCxpzHKi/4pirA2dpzDbAQ+nQNEP+Q9hrVBDT8f8gFRhD9be1m7ZwAAAABJRU5ErkJggg=="
            } },
            {0x0087,
                new Items.Item()
            {
                Name = "Pecha Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDD4wJj44JjokHD4sHBgyFCoWEAwcEBYuED////NKy3MAAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAC8SURBVHjaY5zJgABMSGwGFgiVzsA5Acr5XqD0/z9U2fciQQbGjwUQThE/w4f/UAO+Kwgw/P/AIA7mFDIwMggyMHxAMlqQuQDI+W4A1PAebilQAwOQqw7iMINFmRXAMmBTGfTBykoNlICCRh8gehYwMykpfYAY0O17AWL4TZCMqheYxwxyNWc3A8MFA4a/Z2eCvDDz+wH1TgbWAoh/ODewV/Ayn9CEuG1mZz/zj50MDIyQAPleAPI2I87QAQBTqTAHPO/jbwAAAABJRU5ErkJggg=="
            } },
            {0x0088,
                new Items.Item()
            {
                Name = "Rawst Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDBY0FBAmEAwaECAkKhgWHiQ0NCQ4OCIsND///9AhiJnAAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAADsSURBVHjaY5zJgABMDGicPzkFcM6fHB7xAzDOHgEmwePbQRwWhu8HhPgeMB3kdADJsL6/+wBILwcrywYazqggr5TDwMDsyyvz+7vYeU4G+SUeTAwOvxX+iTgAVcqATDsiwGCsBtTxG8TZxGTO8J+B8QLTASAn4AODACPD3z6GDUDOBkGF978URIGiLAx/At4LfGD4d/6K5wYWht8fBN4/2MXiKLJ8JgsDK1ClQsad/xsigW77/feRHNMdgTc9LCC3/f9z7w7Dh5MsILexHGAQYGA8OIEB5DYG9h8//uybDvWc9Z49kpBgYcQZOgCl70nEsBwyfgAAAABJRU5ErkJggg=="
            } },
            {0x0089,
                new Items.Item()
            {
                Name = "Aspear Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDDw4FCAcED4+GjIsEiw2MiowLDg0FiAkID///9Kayc7AAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAADXSURBVHjaY5zJgABMDBic7+npcM73QiGBdCjne7GRgoFIAYRTaKD0iYHJHcz5bsD0j+EBgwCYU/joH5PMw99sBVDT7n02YFgNkvme6gfkPg2AmPab9QHDPe+tDOYMLAyFot7/jPVYGdggMhtYfzNs8P4L4gBFGDYARVJAnL8JDL9DNzCwnQEru8YANJbN0IEBaEDPDwYDhr8XGICOAFn6l/fsFZc/B14COZw1LCwMNgwM/8B6ehgOMLD8Ydg3AaiHgXOHRswehj3AwGAEBQjIlyCaEWfoAADq3j7xCcaC8wAAAABJRU5ErkJggg=="
            } },
            {0x008A,
                new Items.Item()
            {
                Name = "Leppa Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAJFBMVEUwMDBAmEBY0FAwcED4kDD42DDo4GDgcDDISDCwoGCYUDj///8b2L15AAAADHRSTlP//////////////wAS387OAAAAAWJLR0QLH9fEwAAAAAlwSFlzAAAOxAAADsQBlSsOGwAAAL5JREFUeNpj3M2AAEwMWDlfAxhYoExXBkYuGMdV6f+HX1DOV6H/H97vhunh/8i/G2ZA0Ef+10AKouy/wL3dCKPf7XZ1hXN+uyopQexx5Wb6KvheUBTEcXX58/kcowADYwATw1dXgUP/+N9/+PcAqCcEaNj93+vfvV6/Aajs/wf7A9zcYKO/JjAwWHTAvMDMwCzwH8IBKnNhYGCEyegz/GP4sQHC4S6494BBASazyoCBIxumhzuLgRuiioEROagApsI4ymcug3UAAAAASUVORK5CYII="
            } },
            {0x008B,
                new Items.Item()
            {
                Name = "Oran Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDBQUIDg6PiYoLi4wPhQoPBY0PhoaLhQeMj////bPOk9AAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAC1SURBVHjaY5zJgABMDAQ439MRnO+PlAqAFAuInc4syCcOlUkPLfyrJADhfA8VfG9w1qUAzClVZGC+ZHy2HKLsAwOD3dnrNwqABnwv+PifkcWF4S9Y5sFHxv8MfxgU3EEchX/vPwBVPIDIALUpALEBWIaB4QBQgPkDkMM5mYHBAciWByv7r3yAgcFInmEmyG2dz5PAdoFlOCcA6QUMMyeAXdDZuYAhYeZPBgZGcBikQ+QZiQsQAE9FMeRhR/RDAAAAAElFTkSuQmCC"
            } },
            {0x008C,
                new Items.Item()
            {
                Name = "Persim Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAIVBMVEUwMDBw2FBIqEAwYEBgaED4yJj46KD4uIDgmHC4cFD///9iHs7UAAAAC3RSTlP/////////////AEpPAfIAAAABYktHRApo0PRWAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAAwUlEQVR42mNcxYAATAwYnLAEMMUCIr4J/kdWJhwWBuNwffxvrJQA5YQxMd4T/JYA5nwLc+BneGDIBuakCQgKCMg/EICYxiD4n+meoBxIBqiYQVBAie8UWNn/DwwMjCK3FoCVfTC+x8BgoAEx2uUewwdmAahz/gIpfahzMg4wvLdnYOgCc/79f6/MwPgBLPPNn4FZ8APDjwUgTgqDsgE/A3sX2AAWYwZGhh9NC8CcPwyM3BlcIDYD4yqQa6ChwogzdABUoy+o7mE1AgAAAABJRU5ErkJggg=="
            } },
            {0x008D,
                new Items.Item()
            {
                Name = "Lum Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAFVBMVEUwMDCQ2EhQoEig+EhIYEhwwEj///9VCOe4AAAAB3RSTlP///////8AGksDRgAAAAFiS0dEBmFmuH0AAAAJcEhZcwAADsQAAA7EAZUrDhsAAACvSURBVHjajZBNCsIwEIVffraS1gOU4AEEPYHuPYKLrjyUYPUkUtwLFVxqiBu31i6lRDPTgtsOzOR9ZJi8jNjgHxLDIRRFOMRTk96lyX7W39xT88puHXwqM7bvxDM8RAN8m5KhNBZezQNBsIDD9LwiaFXU4mJPnqfVgLEeJcMiptMJtWlcoerlSJID6bNUhgrIe6NZzJbfWXeWnwzaknY5gzxOJBx9X1DZArwKMWwhPySNLghihGqOAAAAAElFTkSuQmCC"
            } },
            {0x008E,
                new Items.Item()
            {
                Name = "Sitrus Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDBQgEho0Fj46GjgsECIcDjQsEjo0FiocDD///8OnoceAAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAADESURBVHjaY5zJgABMDNg46UicdMECGOd7uqIgO5Tzvdj4/nuYsmITAQPBnxBOesBfBuZ7QAYLUFGwwIMPDGZSYE6xATMD438GAYgyx78M/6GWfje4wMBgwGDwASzj8J5B4ILRe9ECkJ4DDIyMDOdYBCF6BBj+Mwr8Z4JwPvwHqnf4B+JwXgHy/3/5AHHOPxMGARZ9pl8TQAZ0XzNmYJJ7ADGacz4DgwLDr51g5wDd8vHer5UTgAxggHwHepJzAgOEgz10AJd5NugK7q6pAAAAAElFTkSuQmCC"
            } },
            {0x008F,
                new Items.Item()
            {
                Name = "Figy Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAIVBMVEUwMDDQ4HiIkEjw6Ijg0JDIuHj4+NDokDCYeDi4aED///8eHdhTAAAAC3RSTlP/////////////AEpPAfIAAAABYktHRApo0PRWAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAAu0lEQVR42mNcxYAATHBWGBLnm2ACgpPEwMbAAuMwCvyHy3wzNHwF56Qx/lsAUxaWxs/NAOYADTVjZOgCyXxLaF9vwHBBEWxpRjmQfdbhxwIQ5z9Q6CzDP4hzmBhsz7owHIC67QEDyx8GEQhnOhOLAwNDAFTmjwLTgYQ/MC8wKbAxQvVwbWBgSGBk4UiAyPw5wMDi8BeibPYBhz8Mf1ggHK7Ve0BSUANWrd7y58B3oHMYwaHzLYGBC86BAgDXeTJXh3wf3gAAAABJRU5ErkJggg=="
            } },
            {0x0090,
                new Items.Item()
            {
                Name = "Wiki Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDCQcOA4QHhgWKjIoPhAmEBY0FBIYECAWMj///9Y+UUzAAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAADjSURBVHjaY5zJgABMYPLfPSTOrVkPEJyJSuseQDn37vHf+w3isQA1nPpg/E/kT98ksMwFZgYGQWWpByDOTyUBhNHsQHOZ9j9i2Afi3GI4/+Hvm9MfwAYwMCje/8fwnv0nUObfBoa/IJHf30HKhBQeyQE5+W8eMDH8/Pjw3wMlhqINCkAZdqAiRj6h9R/PKjAx3GIULGC4wPCevxIow8QosElRUIDpH0iZLAPD/w+CDPzfQS7gDAAqAWp7BLZUFuzaK5PAbuO05f/I8B4kAHKO5gQGJsNwKIdhJsO/zDQgzYgcVABVh0gYqsYtRQAAAABJRU5ErkJggg=="
            } },
            {0x0091,
                new Items.Item()
            {
                Name = "Mago Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDD48KDY0HCoWED4uJj44JjgeHD4kIDAqGD///9OasElAAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAC0SURBVHjaY5zJgABMDLg4LED8vYCBgXMCVKZQ2UTQPB3KYRR86CLoVgDh9PE6MLD8C4caANLI8ADCKfvPwPCfga0AImPw4f8HuD2f3gPZBhDO3wsgkQ8QTu9fIMEMU2YgwMCgD+VwLjBgMPoA5Xw3/qT06cCvCWBOwQcZBimmA2CZdI2YBUoLol6CON8FXy5Im8UwbwLU1Qyz2OJegt3I+b2BgaGiE+Q5xplgj0KChRFn6AAAhV8xUnvHtbEAAAAASUVORK5CYII="
            } },
            {0x0092,
                new Items.Item()
            {
                Name = "Aguav Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAG1BMVEUwMDCI6Ehw0EhQkEBIYEjg6Gi40FBouEj///+r52euAAAACXRSTlP//////////wBTT3gSAAAAAWJLR0QIht6VegAAAAlwSFlzAAAOxAAADsQBlSsOGwAAANhJREFUeNpNkD0KwkAQhd9kI1hoSBA7kWhtsWgtBPQEehI7ETGtx/AYFhaRNKYIbJlCxAMI/lQWu+huVtRpZj6Gebx5tMavnO/0TP5gf4D7GbfVpPEBuex6Hc+CXAV3h4ryRsbTiF4dqxZPkCC8RgZkHxKKglI6DpUA8lPPwAiCxiBctNrzVsNABeBts+E+0yqcWTtNDsFArgYXO7Oo+NLAhvnOFC1YB6DjPkjtPwstywmqdODmUtuILMjZmUHctAvzQjp81JEXJVSzDAPkOhmy6cxhOv1H9QZazzuCdBfxCgAAAABJRU5ErkJggg=="
            } },
            {0x0093,
                new Items.Item()
            {
                Name = "Iapapa Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAG1BMVEUwMDD46HjoyJBweDDQsHjokDDIcECocDD///+5gBFLAAAACXRSTlP//////////wBTT3gSAAAAAWJLR0QIht6VegAAAAlwSFlzAAAOxAAADsQBlSsOGwAAANdJREFUeNpNUDsKwkAQfbuksBFEbcVBez85gQRsBQt7jxECwtqoZ7ASbGy9QWoLEewl4gG0XPxsnM0adWCZefMeb2ZHLPALmRcaIbwcTFP6At1Nr7lMT3Euq4xhNZ3bR8vocFgN+kbWFYP5KDb0wL7IjB6gl55i4OAMYpGQGzoDAjIXiI5lSuaUwAgfdqjYFllSdrvdW9wLSHpsHcEvVQg3UOYmm4FJnFthhQZIgjEzyjZrHSdjyqbG0+6GF7+1/Hx7ssJuDGwyUIiWR2CpINx1tAIX4v9Ub6XaOlikVy06AAAAAElFTkSuQmCC"
            } },
            {0x0094,
                new Items.Item()
            {
                Name = "Razz Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDCA6EBAqED4qCjYWDAoWDj44EDwiCiYQCj///+I7CbnAAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAADaSURBVHjadZA9CsJAEIXfmoCkU+IF7AWFLWz8CRgQO1svYFpBS49gYes9LANGuxQLEfUeosIqzIq7G9RGpxj49s3PvmErfKOAHyAjnZgti7x7WS5zJeLNUq8/sSDHZTB1KhqQU5x3/qEGuMA0EGzo0PahQfKqL6D2nYHtccTFz/jNDlCZgyevX5sGKgHUkSMwA2YNcQ4VIMx3Ck63LiqbG1IN+jHjBAqNwtpMV6mMTM/inpBe7SZG8ebktiiMafnxE1Nq/ch1mBCNcqdePKc4xdupnORnYX+v8wKWl0xwQj/aRgAAAABJRU5ErkJggg=="
            } },
            {0x0095,
                new Items.Item()
            {
                Name = "Bluk Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAIVBMVEUwMDB4yEA4QHiwcOiAWMhAmEDgkPhwULhAcEA4QGD///+wgHtsAAAAC3RSTlP/////////////AEpPAfIAAAABYktHRApo0PRWAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAA9ElEQVR42mNcxYAATAzYOPeQOP87H0A59+79e87QwMDAAhKdLfhBxsUULPPvuQJD3tHfDWDOuyuBPPsbNtiBOP8W/P938AAzy58PQD0/bI/sZ2A5y8DwQYCJgYPFgUHegZmVtQGo7IfC71ClzRrWN+2Ayp6s+2r/VWqJgMIPoEyToQ/DnwAGAQYOIAdoPlD3P4bwQ0BltSYfeIDuCL0HMmCZw28Xhw2q/w68B3K+b2LY8Jv1A4PDfwbGVQx3P6xmYA34zSopBXRbDUNAqDfDuk1cIIfWM2xgYFj94LoAyD9yCQwbPJ+DAoYRHDrXuhYwwDlQAAD05FG2LWOr4QAAAABJRU5ErkJggg=="
            } },
            {0x0096,
                new Items.Item()
            {
                Name = "Nanab Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDD46IDQwFigmEj4sID42IB4WEDIaGjokGj///+dP0AcAAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAADUSURBVHjaTZAxCsIwGIVf2kDpICbgLJVeoOgFKj1M14ouHqGLds3WC1l0cbOCizg1xSEIYk3TSg2E/B8P/rz3iMBwrP5VyR+snGQAEGeAfU2SHlS83XEHpN2mVmx8C8jZKGvGn14BUD3HkSzB3YPQSsxPbOZdIbSilhNUvOBTs9rGW3/DZAsbH3REZtzYscpGUvDO6KfxmR7oQ1+1rgpW/SI0ZVMFQGCghr04wn5lGtx87h2AsE9aX4BICgNpHtKFTLM2oIC6A6npRbt2U6DriPxX9QUfuDu8HDw5lQAAAABJRU5ErkJggg=="
            } },
            {0x0097,
                new Items.Item()
            {
                Name = "Wepear Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAFVBMVEUwMDCw8GBIYEiQ2EhYoEhwwEj///+pIzGQAAAAB3RSTlP///////8AGksDRgAAAAFiS0dEBmFmuH0AAAAJcEhZcwAADsQAAA7EAZUrDhsAAAC3SURBVHjaTY4xDoJAFESHL7FUMLF2xQuY2FroTag4lQnGY1AYNMbSExjzo/ZgSzaL+xcEp/ovM7szXoJe1F1VDr+DU/HnMHVOhuj1g2xR0KCJ6d3qNtEbBzoNGeU0F9BpAKg6YIHDEgZEUBb0lqVc1eIYI38Y1rGFi/MtwfbwjKJ2pbxrNBLgdt7VObXz5i65xicAhaUSIIYXjmGndT14uhiph5S+HfhnxbgfYwtegmoPDOUW6PUFKKo3vIrVfesAAAAASUVORK5CYII="
            } },
            {0x0098,
                new Items.Item()
            {
                Name = "Pinap Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAJFBMVEUgICAgICBKakFSvVpzajF73lqci0rNvUrmtDH21TH/5jn/7osLb5hNAAAAAXRSTlMAQObYZgAAAMNJREFUeF5tzz0KwkAQBeDsDbIIKnbZ4AEST5DOOuABYjHIpo8Qq4AscwOtLfIzOUDAuZy7q5rGV72PBwMT/IkI5YxFtJMz4jQN3xAyV+oDsXnk21glvq+oSg9KRQ6bkluVb3PphlHz82inxIFvFVexKtyBJfNUEkATvMEX6ga0i+jPJddEvQdxxS3R3aMepycBnIyDpo7scHUHBGiLAa+ZRbAG0ndEDD0MGgA0HsKgzb4IfNYni+z72hKw8d1Lyl+f8wLnIkNyZI3KywAAAABJRU5ErkJggg=="
            } },
            {0x0099,
                new Items.Item()
            {
                Name = "Pomeg Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAG1BMVEUwMDBYsFAwYFDISDD4kDD42FDgcDCAODD////Ve/GnAAAACXRSTlP//////////wBTT3gSAAAAAWJLR0QIht6VegAAAAlwSFlzAAAOxAAADsQBlSsOGwAAALpJREFUeNpj7GBAACYG7JwZSJwZnxhYYOxfH7/DOVUMAgwQzq8GBiOBO2Vgzq+m4P9C//5ATFvkyMB4jwli9A+F/wz/GR4ogfUwMfK/Z2D49w8s0wgx7/ECEEfh/wcw7wGI80AB2W0XwKwPYM7f/wpgUQUQR53hPJB++zcBaPQPHpY/52F6OM6eYXAAsm6A9TQw/J3gwHC2gYGB2YXhj/62/1/Pd0CM5phQ+JehA2ZPR2fDDbABjMhBBQA78jh7GPrbHQAAAABJRU5ErkJggg=="
            } },
            {0x009A,
                new Items.Item()
            {
                Name = "Kelpsy Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAGFBMVEUwMDBwYOCI0PhYUGBgUJhwqPjAwHj////YIuraAAAACHRSTlP/////////AN6DvVkAAAABYktHRAcWYYjrAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAAz0lEQVR42k2QzQqCQBSF76jLSO0BhGgtDLhoFQk9T9BC8DV6IEGxreFYi1aZtS4NXAgxajM6WrOYez/OufNzkAu/JY0dDUARrQfNwxZAb7oxG2y+BvJrgDOgYiFmvLXO9n2nUDWNWMEd+BmgCFrS2eK5jOEZOlzxNiUGODn8NK9IJ4F4DlUBkJZRk0OdyTquDb8Cdo9cGnfJaiqbK0o+ZfYG91/ABDMkPSQWq+EO+Axt31p+rKCDg2Ve46Xdw6okiTtm8CF4DES5bIkA9B/VF/FtQXnpSF/YAAAAAElFTkSuQmCC"
            } },
            {0x009B,
                new Items.Item()
            {
                Name = "Qualot Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDDY0HDo8Hi4sGD40ICYiEj48IDomHDwuHj////UnjNmAAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAADASURBVHjahZA7DsIwEETHiRFKxUfUyA01QVzARJyExm2KXIIK2lwCaiQqDoICbYq4syyiBK8J0CBhN/M83tnVshzfE+APKAWTgpM06Xikgql3TLZCOxto72Sbxw01LDkmQU+DcR+QCapr60/aXGv0HRgJNOFCdH0KdxmEINDN1b0kgSSofBVfD/23SgMhsCWIyYpfg0YHNqmW76m5Lu9O2T1BLSnNxRPsLtL1tScPUXk8FzbfA8wvRCFyuoNfC3kCrw81glFdjA0AAAAASUVORK5CYII="
            } },
            {0x009C,
                new Items.Item()
            {
                Name = "Hondew Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAG1BMVEUwMDDA+EhwwEhIYEj46EhQmEiQ2EjIwEj///+zgx8yAAAACXRSTlP//////////wBTT3gSAAAAAWJLR0QIht6VegAAAAlwSFlzAAAOxAAADsQBlSsOGwAAAMlJREFUeNpj7GBAACYGTM6PBiROIwcSh5GxAcb5UcGoyNEA4fxoCUtmFJJoAHNaHH6vZRZgkgBxfgQwHmCQZRQwAHFaBXkY/j0wZtwB4vz/KODCcI9BFqTnhwMDy3sHljcQoxkF3jMw2H+GcASBfFGo21ovvBcE8g3AHCaD9x8F/jA+2AFW9p+B4c9nJYiyPw+M739mYvgNdlvtvz0KQLkHQBkWILJ59O/enRtgZRwXGBieOPyF+qdywj+HvTfAXuwABwBHA4wDBwCFUz0ZOclELwAAAABJRU5ErkJggg=="
            } },
            {0x009D,
                new Items.Item()
            {
                Name = "Grepa Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDCI0CBYoCD44DiYiEj4+HAwYFDowEjYuEj////GQzyuAAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAACwSURBVHjaY5zJgABMDFg53wuQOIUMDCwgOp2BgbNdvpKBEWhAujEDA+8h/vczgcq+GzMpKV5MeC9YAOQUMygAle7jfD+BCWQKAwNjIFP4TJABB0BmfHHhAtlTwcDwgIHh7tkTBRCj/91Dd4EDiPPHAcIRALmg5zuY7QpRxhgCYguALJj5fQdE3Q9JoAznAWT//IGwOsEc5jdgVRNAekCO83DYcRLCAfuOcwIDjIMtdAAYmSyfVTzn0gAAAABJRU5ErkJggg=="
            } },
            {0x009E,
                new Items.Item()
            {
                Name = "Tamato Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDBw2FAwoFD4kDCAODAwYFDISDD40DDgcDD////8XnhNAAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAADsSURBVHjaY5zJgABMDBicPwzbQRSzLwPD96NdzBf+KkBkDj8P2ASWAnE2KBwIMGKFcoIvMDD8/w1ksDB8P/CYgZF5jyvIhJlhzOUGCoxCbKycM1kYNrAwmM1iemfyPwhotOMbBdZfas4vWR/pMoFsPMDwmeE/z0mgaawBe4BaLzAogYz+/ZTZGMhjZQgAyfzjvWDAwOB3bwNIZgHD3wesxvc+QWQ+MDPrMTz5+xzogt8xN3iALmYI/QuU4VxwDmgQg0xFC1CGYeb3gjQGhjkzQQ5lYOCcmc7iwMkA4YAkr4kiAoRzlgOQZEQOKgDt60WTFllkeQAAAABJRU5ErkJggg=="
            } },
            {0x009F,
                new Items.Item()
            {
                Name = "Cornn Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAJ1BMVEUwMDCYkGCYcFDgoOB4aKC4iNBgUIB40FBQQGhgsFAwkFAwYFD///8DlmvaAAAADXRSTlP///////////////8APegihgAAAAFiS0dEDIGzUWMAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAD3SURBVHjaYzzDgABMDGicPx+QOJbIMg05fz78eQPh/J/w43XNm+oDYM42xgcL/m5kaGBgYGH4/4FPWYiZUakTJLNnAYMCI+8HwQAQp4HtheBZJqazPkDOn4IEBnmGjwIMP94fYPkBtJRBiUnh7+/0WUzcCgwMhxm01yovehfA9FUAaJsxUPo/xwEmDmaFHIU9jPJ3BH4wMJ6xW/DtyYE/B9izvAUYz7z78O1ZFXsBw4KvBxjP2M9nDF1+AeiWQKClBxgEuEBu/wpyAWPi1wWMRgwMQBcwnmH4/5QL6NWwMyBXM3z97cbAwA0KGCCH58MZJG/LwMIAAMT2UeumwX4HAAAAAElFTkSuQmCC"
            } },
            {0x00A0,
                new Items.Item()
            {
                Name = "Magost Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDBgyFAwYFAwmFD4uJj44JjggGD4oIioWED///+62zv2AAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAACrSURBVHjaY5zJgABMDAQ53ycwMLBAmD/LJd7DZQrUQSRYpv0R/wWlnxBOuqvBw///foKV/XQRYL0o9EGxAMQpYmRgCJJjvI9ktMK/CUDO94T/DAwfWM4ngAwAygGtYHABu+AfM1gZMxtIGcN/AxBHn+EB2IBPBgzMSh/AyjgXMHxSkgebi/DCD7CeLqhFYBnORWCPdUKUdQB5TDOAnmMEBcj3AgYGEM2IM3QAnPErKvFiibIAAAAASUVORK5CYII="
            } },
            {0x00A1,
                new Items.Item()
            {
                Name = "Rabuta Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAIVBMVEVQUCAwMDDw6MjAuICQiFAwYBhAiChwuFiI0HCo6Ij///8sYyp6AAAAC3RSTlP/////////////AEpPAfIAAAABYktHRApo0PRWAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAA8UlEQVR42k2QMUsDMRTH/8kdHFlM0grS7a5LZ3d3F1fBRahTR+97tMPNDsWlS4fqFxCcXXQWtIebHJhESzvZZy4p1Czhxy/vvf8Lm2N/ONYlSmyGEVi2ycqrrAwg3DVlhY4GNk84ySrC1AIdtTNIoDuHsWY9JBS5PvWQIs0V70pqgrksXvoSLh2NPOgB1yCJH4Xk7Kl7wcAcyYMZx/dxMMa+VlxMoEg582WP2jm1dXb75vTStwb5N8sa25s26KI2tv/+UcQ45MOdnzwGGN8Dpkl7AcT4zjSrh11qMWlWz70qAuB+26Xa1l59Qtz6m/3/qj+KFFBINQ5mDgAAAABJRU5ErkJggg=="
            } },
            {0x00A2,
                new Items.Item()
            {
                Name = "Nomel Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAGFBMVEUwMDBgYBDg4Ejw8GCgoAjAwCj4+PD////7uNYUAAAACHRSTlP/////////AN6DvVkAAAABYktHRAcWYYjrAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAApUlEQVR42mMsZ0AAJgbsnC4GFhjz50R5JBnj71CZmR8YhYQ+QDgzlf8rHdB+BFb2U5nZ8KLu8QIwZ7Lx3wu8wh/ARv8y/svA8AFqz3+GC0AGI4Sz2AAkAJX58BfNOR+Y/8M5/xkM/hRAOBf+f2AGGwfk8AMVGTAcB3N+Kv4Hsl8XQO35DGSDJIAOnSyvv5qBvQDCYdLbVg63h3t7AcxSFoZ0HKEDAFYHMNUIbJ8IAAAAAElFTkSuQmCC"
            } },
            {0x00A3,
                new Items.Item()
            {
                Name = "Spelon Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEWAQDgwMDD4wHDIWFDweHD4uKj44JjgaGCoWEj///+e2IPcAAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAADFSURBVHjaY5zJgABMICIDmSPagOCk80JlmH0ZfkgzMK094gCRKbwoJBQKVfZdUPA/k3QDhNPGz6B0fwNUpjrx/x9RdqgMR9+HawG/YabZKJ6XlHu11QFsGsfE/wwXhcUrKhhYgLJ/LzDqXRIyOw12QQc/80FG0bsvIG5j+5vK8O9tA4TDwLDr3X9GqKsr/xs4vA+Achg+HGT4MIMBbBrDf0d5sHvAnDLbLQW/90E5Ana+jeycUD2/Z3B2VHxgYGDECB0YAADMnTkaxLL3aAAAAABJRU5ErkJggg=="
            } },
            {0x00A4,
                new Items.Item()
            {
                Name = "Pamtre Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAALVBMVEUwMDBwaEjo2LAwcDCY0IhwsGCIeLiwoOBwYKBQSChYSIjIuJBAMHCgkGj////hGW6yAAAAD3RSTlP//////////////////wDU3JihAAAAAWJLR0QOb70wTwAAAAlwSFlzAAAOxAAADsQBlSsOGwAAAOFJREFUeNpjfMeAAExw1uLfSBxDVQTnUp4wAwuE+VvZgvkFVGadtAWj5lMIZ9Gp+PcCTyCmfbouyMr0TwbC2SbAwPfvwRcGkAGXLwgyfDCVvgmS+Z3B8OE9A8PTKyCZ7wwOBxgUGJhcQJxNEyIYwh8xKHwBKav8sVBCTk6BSQfEOcDDuUGJiUHBiYGB8Z3sBgYxB4aZTEpAfQxXGZgcBSUYRBTA9igxcM6U+8wE9hwPA8MCJQvXCwwgPQzyFxi+vFL6qAB2wQYDBh4lZQWwjOxFFiADHC6M7/4pPYB5nRE5qABnPz0uRbzMWQAAAABJRU5ErkJggg=="
            } },
            {0x00A5,
                new Items.Item()
            {
                Name = "Watmel Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAIVBMVEUwMDCY0FhwqDD4wKiw6ICIwEjwqJD42MhYkDjYkHj///+Khd/PAAAAC3RSTlP/////////////AEpPAfIAAAABYktHRApo0PRWAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAA/klEQVR42mNcxYAALCDiWwID1wIgzQRiJwqVqyVAON8ShY1ufxJLACtLFOAV+PueUQ0k801RMOzvAQY34wSQTCALg+JFBgZVkEz6kV/3GAXF/p4tA3J+f2B5v4HhnjHInm/8DPf/MvxjuKfLkgDUo/f+gpCpKUgHkLP/n8BXJYZ7DLOAXMa/ggy2Z88qsCUAOaKCAmAHCoJckP92QzIDwynm/wsYmLgKHj+6d+/BBYZf/xYwMTAzBDK8NwD7h4lhOsOG3yBNbK9AXtD9z+HwimH+R5AMV1mBwgEGhl/TF4BkprcI/BRL+PcK7FOu6QXujHyvgIHAuAopQBiRgwoARb5Pn3gDHL4AAAAASUVORK5CYII="
            } },
            {0x00A6,
                new Items.Item()
            {
                Name = "Durin Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAIVBMVEUwMDDwyJDA8JhwsEAwWBiIaCig4GA4cBBImDDAqFj////JoMrDAAAAC3RSTlP/////////////AEpPAfIAAAABYktHRApo0PRWAAAACXBIWXMAAA7EAAAOxAGVKw4bAAABAklEQVR42mNcxYAATDDGLyjnVwKQmJsA4cSpLYj6e8UBwnGJuKacZA2V2fvAg7NnF0TPtAaGe567xRaAON+er1dw+KMk/ArEYYl3WXPgPxuzcwKQk7SPUVhX4Jftaykgx9HogAzr5y1HWHgYWL4d+GDzYZ+NrTDjLaBMjKCgQODBK0J7xICcCzr7j/wN5H/vIMLAxHVVWIHx0ReZDYJ/gDK/HzzkO/D7osB9kJ65c0wcGZgNHZnVGFgYkk1eM8hdYhBR+geUcdC/8sH5vcOPimVATuysP/wfHT6wcy0AcrhWneWZcKB75wKIfxZs+eHz9xaQwQIKjJOrwoCKGBgYkYMKAOmFWJHGpXnVAAAAAElFTkSuQmCC"
            } },
            {0x00A7,
                new Items.Item()
            {
                Name = "Belue Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAJFBMVEUwcCAwMDBQmDCY2HBQOJiYeOB4WMDIqPiomGi4sHjo4Kj///8VJer0AAAADHRSTlP//////////////wAS387OAAAAAWJLR0QLH9fEwAAAAAlwSFlzAAAOxAAADsQBlSsOGwAAAN9JREFUeNpdkE9qAjEUxr8EKaiUSW7QwX1B8AIWD+CmWacgOUY9R3HRWXsE3XgBoRRXikPAA0zsIl1IJ81LKgUfJLwfX96fL2yN/+DpNkpBAR3KPZMwD1n5foGsv2wGLeTPJEid4L3Z7uSjuANL3dRI9j+bLilePZcCH8JF8MYUrg33jGpmGgjcShvBPwEWLvbJG9TxlOhWHLOW8oK0qMRdwM5YJuCDMUJBzztgw5KUSwLI7Wm6YZfkZ4FaxJJVNhfiONFmp735SDscq6y8vTabw54UsuA1etUVbn7nL34Bse1BTeoBO/0AAAAASUVORK5CYII="
            } },
            {0x00A8,
                new Items.Item()
            {
                Name = "Liechi Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUwMDDQyJDw6MD4+PCgmICoUBD4qEjQcDD44KD////+gI3NAAAACnRSTlP///////////8AsswszwAAAAFiS0dECfHZpewAAAAJcEhZcwAADsQAAA7EAZUrDhsAAADRSURBVHjaY5zJgABMDLg4LCAinYGBcwJUJl1Q2Vi8ACLz3eS9gBKDAESm6AOjkKAccwFI5ruC0dt3Ap8fsINllPk/Mpw9q+dWAOQUPXj3X4lB8DEjWEb2PQOjAcPff+lgo5k/7P/P8MVwApDD9EBQX/bwe4YHBRAXMHzgNfn/kQsow2hwXhio1JhhJojzHyjDwHBfEmRaF8Of9/8//GNkABnA8PnjXhdmqNs4Dzg7MDtKAbWAZHo+iPwTZO+cAOZw7haSEvwJCgvGmUg+ZcQZOgCyWDyJD5zJ9wAAAABJRU5ErkJggg=="
            } },
            {0x00A9,
                new Items.Item()
            {
                Name = "Ganlon Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAG1BMVEUwMDCYkMjAuPBIQHBwaKDQ0KigkFjY0ID///9oC0WwAAAACXRSTlP//////////wBTT3gSAAAAAWJLR0QIht6VegAAAAlwSFlzAAAOxAAADsQBlSsOGwAAAOtJREFUeNpj7GBAACYkNgMLiPi9gYEhFCrze9399+9Xw5Q9FHj//v4GsLLfG/6/N2bY85qBgdmFYc1nCcHr3///fqUBVHaRQdlQ4D+LAEjPb/6/5+/9/6D/9wKQ8zeN4RPYFmsgZxuDvwHDB2YGhr9Azpl1jy8YMhu8ZWAGcgz+M//9LP/e7ONfoD0XhB783RDAwKDEDOQYPALau5pZSf8ukOO3+VfquwcM///+AOrhCBBewCT/gYEhAOQ2VhuG1ay+Dx9rgF3N8cZIgeHDUagXIg7yXdZvgHm7noFvKczbDKx7mFuBFCPO0AEALt9QK+zgNkwAAAAASUVORK5CYII="
            } },
            {0x00AA,
                new Items.Item()
            {
                Name = "Salac Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAG1BMVEUwMDDQ8LAwcCig0IB4uHDI2Gjg8HhIiEj////AMEQSAAAACXRSTlP//////////wBTT3gSAAAAAWJLR0QIht6VegAAAAlwSFlzAAAOxAAADsQBlSsOGwAAAOdJREFUeNpj7GBAACYgbmiAcliAuIIDSaaxAcH5bwDEFRUQzk9mjh/z09MbIMr+MrQZCsyHyHA4GTJKzSoEm/ajgUU3azHTf4jR7g+uPWBQgnJ0/0p/esDyAMhhdmngYGB8LvFbzwcs816QQeWvwYUJHCDOP4b/r98dsBe0twAaLczwUCCI4aPShwaW//wMzMEMDDnMB080MP1UYHgDNGgD75kGBib2Kwz/fp/9zfID6EsmRga9jwz/GeQnQNy2gWGD/r+9DWBLNW8GvVj3oQTibaF7Pc4VAtAwYOtgeCGACAMGCWgYAACMkEdRHqe00gAAAABJRU5ErkJggg=="
            } },
            {0x00AB,
                new Items.Item()
            {
                Name = "Petaya Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAJFBMVEUwMDCISDBgMBDQuJCgiGD40MDAeFDwoHjA6IiAuGhooFD///8kKe9AAAAADHRSTlP//////////////wAS387OAAAAAWJLR0QLH9fEwAAAAAlwSFlzAAAOxAAADsQBlSsOGwAAAO1JREFUeNpj3M2AAExIbAYWKB3wlXsDTOYruwkrTCbgh/1/BQjnK4Mqy3kmXYgBgQGMf5UEGV2BnK8BwgoCTxgZLhmAZEwVmBkEHf4pCIA4igxMTDLM7x+C9HAvlme8xDBLWeA0SOY/0++g80ofmEAy34oYDNY4MTK9ZgVy/gMtc3rE99pJAeIcpkdOR1yUb4Nc8IlJQeFnAsOrDUAO039ZBgb2hf9/RwOVce4SvcDAkKRsCnbbC8G9DP8/GrIEAJV9bWQTeM+wTuAfyHMRgkmffu82ejkb5B8mtp3f/Rjug+xg3O0K9DwUMCIHFQDqz0IsBPHRKAAAAABJRU5ErkJggg=="
            } },
            {0x00AC,
                new Items.Item()
            {
                Name = "Apicot Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAKlBMVEU4SIAwMDDo6HjIyGB4YBiQqODA0OhogLi42GiIsEhYgCBwmDBQaKD///+aDqTqAAAADnRSTlP/////////////////AEXA3MgAAAABYktHRA32tGH1AAAACXBIWXMAAA7EAAAOxAGVKw4bAAAAtElEQVR42mO8y4AATAx4OY/1EZz/Ser2cM7Xe2fZkj9AOV/CUh9+SYFwvkwU+JDLEPEBzPkgABQU/R8A5oQw/Afprgdx/icAFbAfZBQFcb4y/P+gwMAgwA3icDMxMT0CWcDAwMLw9Z8cUIgRIsMziQlkGdNXsGkgkxm2MoBlGI4yMASEgvUwAj1nsnsDQ4A90wWgAQwMZ94Dbf8vAPUPawDDF7YDDGAZBp4Dpgy8DBA9RAQIAIBXLldPhpq9AAAAAElFTkSuQmCC"
            } },
            {0x00AD,
                new Items.Item()
            {
                Name = "Lansat Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAIVBMVEUwcEig4LgwMDCIyKBgoHiAOCDwwKjwuKDYiGjAaEj///9XBazxAAAAC3RSTlP/////////////AEpPAfIAAAABYktHRApo0PRWAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAA4klEQVR42mNcxYAATCAiAYnzjQ2Jw4Ss7J9iA4TDAsRcn99s+L2aYRUD4yqG39FM9ufDGKU1gDLLrmXcucuyoIkDpGebg6LMJ3krxlkgzhymvwwKAiw/G0CcfwoCDIwfGdo2gDisCy+wCQgwMIA5QMcwHmBgYFQAcf7eZxSIYfjT8ABk6T/FfwwMCzg8gTKMq35s1//A8EGB8Y8qUIbjvP1/BgEGgZ8Qh34UZGRg/M+WAOT8DmCYwCDIeRBoHNA0wZO/GN7P8Ol8ADTgW2srQ12UBsg/jOAA+dHRgOAghw4MAAAwgkFzw97Q8wAAAABJRU5ErkJggg=="
            } },
            {0x00AE,
                new Items.Item()
            {
                Name = "Starf Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAJFBMVEUwMDB4uEC46Jig4GhQkDjQ+MDoWEBAaCjo2EBgkNDYqDj///+4G3vdAAAADHRSTlP//////////////wAS387OAAAAAWJLR0QLH9fEwAAAAAlwSFlzAAAOxAAADsQBlSsOGwAAAMJJREFUeNpj3M2AAEwMWDlfA5A4gUgyQAkGFijblVnIFMpxZQhmOACVcQ3+f/6/AkTP1+D7Fxg+QTmB9z8wvHf6B+Z8dWBk+K/CwHwBLKP8n+GLAsMDqD0C7x0Y/vGCOROYmIDkwwsGQM7X6wwmpfvu8zKcBtoTOeGeAJMhw1lmkLLlDwwOvWU4y/BnA5DD3ff41N+zDAwGYAMEv8kvNmBgPg3mfFC4wMBs/GYD2KFM2WsPTGAAhQXjbgZXeJgw4gwdAHsrOowAvEm6AAAAAElFTkSuQmCC"
            } },
            {0x00AF,
                new Items.Item()
            {
                Name = "Enigma Berry",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAG1BMVEVISEgwMDDw8ODg2MDIuKCAgICwsLCwoIj///99+F9DAAAACXRSTlP//////////wBTT3gSAAAAAWJLR0QIht6VegAAAAlwSFlzAAAOxAAADsQBlSsOGwAAAMVJREFUeNpj7GBAACYkNgMLhKoQ/N4A41QqC/LAlP1QFHj3ZQKUM4lJSeC9BYTzw0BJgIFh6wQwhxGIBRh/Q2RalBjePxBkeAHRw8T/jpEbaprA+7cPBA64MII4PxzePmDkZXnvALb0/wNBod3OjLogGcb3jLK7Gf4eWA7W815oAwPDAWeIAR+lgYSLVgGI0wyUcCnXXQ5y9U85bhZng1nsBSBOo8Pn4l+zyiGeE/j0ZxZ7OdSnHxkelsPDoPYujM3AiDN0AOclNrM96ULJAAAAAElFTkSuQmCC"
            } },
            {0x00B0,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00B1,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00B2,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00B3,
                new Items.Item()
            {
                Name = "BrightPowder",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAA70lEQVRIx+2VzQ3DIAxGMxLHjJAxOkJHYIyMwJFjx2CEjpBjblRGcvWV2papkkvUwycUQt6T+QlTznk6M9NfcIoghFD7HCJg2HJfvqKJhuAxxbqW9SPU14uGBRocJShCiQtOH6FAqwQl822ubgEN5jBEgktVuOD4MT/3YG0tzN2iLSZWIsFNAb1Iz9SC08IhGfUxXNuy4iIjHIPTwmGJBTcF8RFr2UsLVsPT1QvcB63teYBjsBpqh38VNJBh2769gxKSk8CCigIN3kvwEHkkLjgLaIpQgFt6SCC1FDzVw/eBtbgMP+TCkS6TX+HXuJNfDoAOD8u6rGsAAAAASUVORK5CYII="
            } },
            {0x00B4,
                new Items.Item()
            {
                Name = "White Herb",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAAzklEQVRIx+2VOxLDIAxEfSSOl2P4GCkpU/oIlCkpKV3SkVlnlNEQiY8Sdy62MrxdLTZevPfLmVoug9MM1ttaIOfcl34yIGh6phJD/Cg8Qskp2w0kMKAcjmcmAykxgaE97odME2ipoe2+HdCc35qeQOua10JwCDUOv0VYTHCeuq6FqpHSNw2weKSWVnrVgKfv1aJ13zTg6XktgI9WoxpI3Wu19OCiQd09Tz4L7xpIyQGmr9p02WFjfZgcOgpunkHvhjQbzIxuMvg3/PonD+kF2ndgV3IeK6MAAAAASUVORK5CYII="
            } },
            {0x00B5,
                new Items.Item()
            {
                Name = "Macho Brace",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABWUlEQVRIx71WIRLCMBDMkyKRSCQSiazkCUgkshKJrEQikUgkshKJC93A3tyEND2mgLgp6YTdvU02qWuaxv2y3N8JfDUJk/lUynsfvkYAwKY9SGFc7VajSN7A7/dLqGsfNsetEIwhEVuoGuAogrI4ni2W8s5MQPVQjdKK4zp0AlD1bh+Op7M8LURC0Ac+W88jON5D/flyDW17i0+SlUiEgF7HbhS4VAeO93iyQDRE8lwDeNuBUL0Gp/IcgO6oSKBJoq8vz6kcKgFUIuGaFHMgu0Z5jjEsgMqcFbSqz6a3lmBPOlmrZCfoLk0816l8VHQTCab/gN/sBODWxLucpyU7APRJ4t0ni0ZwS+KLx3VfF7QmDSXm6cSbCNKkMh8pOOboxHOrD1447IJBIpBOPJXHLa2CaSLQxwKA9PbMJT4Hbr4y9fnTl3jzNrWUTnwJfNSlz/QO3Qk//6p4AAWN4XWaSNZAAAAAAElFTkSuQmCC"
            } },
            {0x00B6,
                new Items.Item()
            {
                Name = "Exp. Share",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////4+JDg4PjY2HC4yLjAwNiouKigoLiAkICAgJhoeGhAUEAwMDBDD3+lAAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAyklEQVR4nH2PMQ7CMAxFPdNsvQYba0bUiSP0ABVwAxgZIsqExMTKgJIOHRCKiIcAQkDjQ+FQkLqAJUt+kr+/P8D/Er4znOUHrrJtoAhIbtoEECmviNu2yJSuxSAKL0d86CVRXANXnaWx6/x9wdJVYtjMa56TMeEDCZsoSVb+UAqy2jGUE0MlQDAVA2aYBug5toLeajEaBGeXJ2RJ3w5JKaXD3kOSh12mVEk3zTCjplDoxSWCJm8ovmjYyGEb6+6+CfnQEzvRycPvegHN714V9NAOBgAAAABJRU5ErkJggg=="
            } },
            {0x00B7,
                new Items.Item()
            {
                Name = "Quick Claw",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAAsUlEQVRIx+2VsRGAIAxFGYnSMRzDERzFESwZwdLS0lHo9OIdHCCJBGKlxT+qvBchoDLGqDejvivQWh8uogIH3ZfBh5Kw4Q5q9y0KJmHDI7C110p9CR8O0AQMWae+TlAKrxI8wR14HrsrLAEUQHELnBRAQQ6eA7PH1G8NAS+5ZKQgHcPwIEvAqCDqPgNvfot89wJwXJB0Xwu/CcK5l4BnBQBv3ZYigQQcFUjB0UP+f/phTv5VB7iTAWbcAAAAAElFTkSuQmCC"
            } },
            {0x00B8,
                new Items.Item()
            {
                Name = "Soothe Bell",
                Pocket = 0x0001,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////4+Pjg4ODIyMj4uLigoKDQcGh4eHhQUFCAMDAwMDDJFNDXAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJpJREFUeJxjYCAEViGxubzgrJUMS+CcJWmrZmbBJDynpaUtgHGmZKVlwbV4tM1Y1QDjpGpMVjLtgPJmBAWZBhdC5ThblUODi6BGLDI2DjUXDoBwmgVVQ801LCCcxYKqwYWmURDOUiNFc+FWKKc12LjQohnKYTUuF+5aDOVwlAtZdC2GGs0hZBEaagVzalewcSjCqxyrkL2NBQAAIvkn4RCV0DwAAAAASUVORK5CYII="
            } },
            {0x00B9,
                new Items.Item()
            {
                Name = "Mental Herb",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAA0klEQVRIx+2VLRaDMBCEc6TIHokj9BiRlZXIHAHJESKRSCQufcNr+valu/nZFocYRfLN7ASC8d6bM2Uug9MMbs5FyFr7pZ8MEvSxrtEty0f3eY7jvusNODCgFI5nKgMucQJDz207pJpASg0N03RAw1vdE0hd01oCEWpsfouwOMFp6ryWVA2XvmiAxS21lNKLBjR9rZZQSC8a0PS0FsBbqxENuO6lWmpw1iDvnibvhVcNuOQAp69addlhY36YFNoKLp5B7YZUG/SMrjL4N/z6JzfpBU69P3dWB66jAAAAAElFTkSuQmCC"
            } },
            {0x00BA,
                new Items.Item()
            {
                Name = "Choice Band",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABUklEQVRIx7WWLRKDMBCFeySOgkQiKzkGR0D2CDkCshKJrIxE4ui8MA82aX62HSp2Mg3hffsbejPG3P5p6oNVVW3SLgXsgqNnWohKfFnWzdrVCbft/TBNVGoAjKJcJTgVlTpFEKMAf0OUawqiAjAl8FbWg5HJKOr64UGKXUNhimNliujxWQMFgIcpSgALzHWarACd72JPQj7EpbD0lN7KQvtpOzWiABxmp4StSEAoLiF7dAlATlzWItzPReHVQB7yPY9fFbEJzw4aHqJo7PXSNUAHWPywc6IAY9ZtGOzR2+E1EGtbiqsigDheevX9Ns/WG6LQEK0UV0WAlyC+PJ8OQNDcNM7wHE503XgA1BFwcCDOKByg69y+hAAA+yoCAOAdREMAhXMQzkD2umbLIQotoJSe6FXhRFmDQoo0X7bkZecKTFCkyNpvc3GYUrNw+b+KX+0Ntog4tnF5UPIAAAAASUVORK5CYII="
            } },
            {0x00BB,
                new Items.Item()
            {
                Name = "King's Rock",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX////w4Hjg0FjAsDigkCCAcCBIOBgwMDBRU/M2AAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAALVJREFUeJxl0MESgiAQBmBOeKdeoJXynPACKQN3J+iKjk5XIpPXD9EDTXvab1gY/kXor3CO3mUYMmDyAxn21iEMCjbhCvWgNKTJ4ryQWmptXIIh19Oku2p91piG0GW5d/FoHKcepEVTZxGajzYCPfFjwy3Cf3wce4EkIAuq6I7ygrkQKxooS+V5K+KdghI4MMZ5wkyAsUaIt12/UBMmmFApLg6Mq0HILUPBW+eV3ROF4EK+hVRfRyUsY/jCku4AAAAASUVORK5CYII="
            } },
            {0x00BC,
                new Items.Item()
            {
                Name = "SilverPowder",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////4+Pjo6Oi44LjQ0NDAwMCI0IhouGiYmJhwcHBAcEAwMDAxW5VlAAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAABtSURBVHicY2CgJ+CcgMSZGIkkIaSKkJqoGAGXWikkFNI6G8JePVFR1SMicjWYXSbk5NTS0jodyOMuK1NRcfWIiChL3wCUSU9XVVF1nW4OUWeWHh7enrYaaoJZWZnZapjZq83N4WwGhlVIbMIAAGz7HqcwJtuFAAAAAElFTkSuQmCC"
            } },
            {0x00BD,
                new Items.Item()
            {
                Name = "Amulet Coin",
                Pocket = 0x0005,
                Description = "",
                img = "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"
            } },
            {0x00BE,
                new Items.Item()
            {
                Name = "Cleanse Tag",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////4+PjY2NiQkJDYcHC4UFBQUFCgODgwMDAJkpBRAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAAB/SURBVHicY2AgBXQgc5qRee3GSLzmciResnG5cQOUzcZsbFwO43CwlhvDZRICGIrhnBQGBlYYh0NFoYGVOQHCaVJRUmDlgEoIKTkpBUA5jSJOIS5KEC0cgoIiSkpQTqKIi6OLkgZUi6OgiKAjzJYOIEcC4TVHsQYGBA+JjRUAACtwGGgNJEfDAAAAAElFTkSuQmCC"
            } },
            {0x00BF,
                new Items.Item()
            {
                Name = "Soul Dew",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////4+PjY6OjI2PjYwPCokNBgeNBAWLAoQJgwMDCqE1lQAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAcElEQVR4nGNgoAqYORPBnmFs3AljcxqnpRlPgHImC5aXp1lCOc2C7eVlGVBVZhURFeXJEHWcZRGOrR3pUI5GRYtLSxOEw6Ha2uHSEdQA0TQpJMS1RRNq2qRQFxcXGIdTycVFCWYpQ6eS0gzsDqUEAADsQB0Wv+wJbQAAAABJRU5ErkJggg=="
            } },
            {0x00C0,
                new Items.Item()
            {
                Name = "DeepSeaTooth",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////w8ODw6Pjg4Pjg4KDY2MjIwPjAwICoqOCAeEBocKgwMDAYtCy6AAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACOSURBVHicY2AgCXDORGJv9EZwtohEw9ncjq4T4Jyp4uEb4BLLSyPhEjuMWqsZGCDmcSUrmUczzIYYscJI2Sx6diCEs03JOK1Q0LUaokrZLK3NBWIed5JxWkZHCViCYZmRWVpHB9SibcpAdtZsqMHKGR1pq6HWG5nB2QzLlNPgbIbFaVm74Q5bvRvuYNwAAF3HKSPU650EAAAAAElFTkSuQmCC"
            } },
            {0x00C1,
                new Items.Item()
            {
                Name = "DeepSeaScale",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////48Pj46Pj42Pj4wPD4uODooNCwUJgwMDADlFCwAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAABzSURBVHicY2AgAXR0FCDYJsYNcLapi7EElM1hEorgNLsAOYIQdRymYI4EmMfhCuIoKWm0g1SFgjhAYAHjgIAHkNOCzgGDCGROBpDTBlHk4goymwPKcQNzUsGKQjLATmiD6IC6pw2oKAPmB46Ojg64f4gAAINAK86hZZ1+AAAAAElFTkSuQmCC"
            } },
            {0x00C2,
                new Items.Item()
            {
                Name = "Smoke Ball",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////48Pjw2PDgyPDYuODQoODAkNCQeMhwcHCQYKAwMDDGzAHTAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAItJREFUeJxjYCATcKxa1QBjc7WXhlYsgHKWh4ZXTq2CSpQal05SCodIcQQLmqq4qEN0tYI4oaEVYM7SUuMgl7BUiKallTMnuaalQTjLImfOVE1Tg3CWpyppTlUKg3Dak1yclJzCIQZwlLo6ubimQ4zmKk8NCQsrh7pneVloWnkV3KHl5XCHoniBVAAAsZYqhnEnwg8AAAAASUVORK5CYII="
            } },
            {0x00C3,
                new Items.Item()
            {
                Name = "Everstone",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX////Y8PjI4OiwyNCQqLhoiJhAYHAwMDCc6kK6AAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAIFJREFUeJytjzEOwjAMRTu1e26Q+Ab95gI4FgcgVteKhbVIiFyf4BTYEZ7+17O/7WH4R421Pj76HFO+7uYSAti2DmICoKcdACK6uLkRA6S2ehfNAKsPTeGl2dRNbBqHNxGZJRcPmBIRuJib8diSi2pfehfO2kFDRc2W7Xt0XX/9+AkPgRyj30zCzAAAAABJRU5ErkJggg=="
            } },
            {0x00C4,
                new Items.Item()
            {
                Name = "Focus Band",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABPElEQVRIx7WWsRHCMAxFGYFRMgYlIzAGJWXGoKRMmZKSkpKSMiPQBRTucd+KHes4KP75IpL3JdlKWHVdt/qnwjc2TTOqfmpgwH67TRQ1CcEfx9M47PcTuN1sPopUFTYwAWVV41JV4RYZDADXBmUtmYQMaIllq/tBZVoF1VUN6Ctg4LYCIWMUMuBmoBjwMKsa6bN6AGYGHqyZkq1utLbNm8wMLMhJQUB9f/UeraZokIP7c56LL1WR7AEGuR7mXhW5CV8cNB2myLuGBGpDlhrc3pvrjbz02AI/t+tYBTx42e2SIfKy303AYwavCqgCgOl+apJrjWPQ94dlg2mTnYEBcnCNkX3YYBj6aQWuMB+ztdaeZNCmUyEG1+sxgeZilnnYQPfCQArj2seWWlN92QErwaPf5uowlfTzfxXf6glLy+tPAbgGDQAAAABJRU5ErkJggg=="
            } },
            {0x00C5,
                new Items.Item()
            {
                Name = "Lucky Egg",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAElBMVEX////4+PjY6PDI0NigqLAwMDAq/5GOAAAABnRSTlMA//////96eeD+AAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAABjSURBVHicY2AgAbCGBiDYQUqmcE6QkpIyTIpVCQhgUkGKQkpKqsgcFSRVSioBmJwgMMcEmeOCxFFG5phAOcFgCSiH1UhJ2cTFBWqPs7GLiwvMOSFAtjPcoSEuzqFIfkOwiQAAK+kVh6nHTDIAAAAASUVORK5CYII="
            } },
            {0x00C6,
                new Items.Item()
            {
                Name = "Scope Lens",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABeElEQVRIx8WWIXLDMBBFDXuUQh+hMNCwsLDQMEcoDCwMLNQRfAQfodAwsEzN1+R5vmS5nXHdFvxRbMn/7a5WdpoQQvObav4V0LZtPPX3UePuAJlOl4/Yd3fx+fiyGfKl+TQc4mXqEuShe0og6XQOcTPAzVUejQKcw5AgMtdvYKVK+AJA1EjXQIbxPUEEAKR7pQSqAhR9zRyAHgQigNT1b5mAkskqwM0dgIEgpTQPhCxmc9V7LfoSIGmfvCxp364iO40ZwKMH5gDd801GngHZeVsvAP5ACdAah6Q116iPr2MS5dG9rEREzAOkn1p2BaARYxeQLANd0P8sAgakBmD9+Hj4HiCDsjtSu92MqWtaewNovpaB5jMA/T2fYisRmwnAN1tmdJGba23WRQDIgEjpCgeQMa8FP2SY+4txLhEAb0E397QdUqp8684/NFkeHnoac9JGnm1tfnEO6GFEJr6xP/oe+Kb6SWXc5YNDtK7dP5le262R/9m/ik+BtU14xzwOdwAAAABJRU5ErkJggg=="
            } },
            {0x00C7,
                new Items.Item()
            {
                Name = "Metal Coat",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAFVBMVEX////4+PjY6OiwwMBogIBQaGgwMDBVSg49AAAAB3RSTlMA////////pX+m+wAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAdklEQVR4nH2QIQ6AMAxFa1bfCvwQ8wQuABl4koFGwO5/BLZ2YAj76r00+U0LUIvZUh5eiS1HlczU8iEDYWInomybLKhMKp0wLSLDmHkrMvU+BBU4VaQaG5G9FLiYYt8CIp6/Bf9ivMr+2QMYfEo5DjCtuaqPgRsLzyGEj+UROAAAAABJRU5ErkJggg=="
            } },
            {0x00C8,
                new Items.Item()
            {
                Name = "Leftovers",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAABBklEQVRIx9WWsQ2DMBBFPUpG8BiUlJSUGYERKFNmhJQeI2VGoEyZ0h3hn/StixXFxhgpFF9OzuKefea+Mc45s6fM3wGstTO0CwCJh8upHoCrpa5jK9KxYgAentp2fvW9jAQwTqUgyeRD08yu6z4A+I94DuRrEA/78SwiJBZ3BskiigDeB4iWLtGv5MkzYHl0QoglSiVPvkWo+X26BRCFGOaq9AF28vQPSUpVb7QYcjwA6q0BufXPsgomJ4BjaLotVoE+0CvXEKrIKgJgaTIm1zD+xvwmAN750NHRbhCnR5WdwfKwHOYywh7oTbQOPb/pkHHBxHYhVpF58ay6Juk/a65Nc/ivijcSnu57w6s7xAAAAABJRU5ErkJggg=="
            } },
            {0x00C9,
                new Items.Item()
            {
                Name = "Dragon Scale",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////w8KjQ6Lio6Pio6NiY2PiQ0OhoqMhAeJgwMDDczKZGAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAfUlEQVR4nGNgoA7gmDmzAcbumOLiKDEBwu40cVISFJSEsE1TnJQUBcVBCjnNQoEcJSV1kLrJYaEpLlAOpymIAwTuQE5zKhJnKpADBhlA60yhnLBKkJbUsDQQSAfrTwVLpFcywDnpFRPAHJCacjAbaH85EHRCXMk5EwRI8i8Ah7YvUPlkOdkAAAAASUVORK5CYII="
            } },
            {0x00CA,
                new Items.Item()
            {
                Name = "Light Ball",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////4+Pj4+MD4+JjY2Ijg2Ci4uACgoBCAgAAwMDAyuUmSAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAaElEQVR4nGNgIBNwzpw5Ac6e4uLiCeNNCU1LM/aESjgLp5eHmUCkOAMFOzqakyGcKcGC6eUWwRB1U9LalI0qyqCc9HbTYFwcJGWmzeVwAzjNLBrhRnM6p5bDLWWYYoxwDqpDUbxAKgAA8HApHjZOFksAAAAASUVORK5CYII="
            } },
            {0x00CB,
                new Items.Item()
            {
                Name = "Soft Sand",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////48NDw4JjosOjIqHDQmNCYYJiQaEhwOHAwMDCoH561AAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAmklEQVR4nGNgIBtwzpyJYE9LS4Pzphobh6VNgEoEGxubhmVCONOCTY2NQ9MawJwZHWHGpqEQdZytYa2moRBNnJONwzLCQtPAnGkZraEWqWlpIAM409Irgo3bIBKcaSUuHaZtUEunq7i4tHZC2JyKgiIupVDrJwkKKrpncMIkBIXcMxhmQjiKiiqeHVAXz1RScpkA98xMJI/hAgDlDitTmMVWqQAAAABJRU5ErkJggg=="
            } },
            {0x00CC,
                new Items.Item()
            {
                Name = "Hard Stone",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////48PDo4ODIwMiwqKiYkJB4cHBgWFhQSEhIQEAwMDCWtlx0AAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJFJREFUeJxjYCAerFq1agGMzSUoKCgF4yxSFBQ0hUpxGSkJCoZGQTiLjZQUhUNDwVJcxkZKSqKhECkQRyUtLS0LzEk2UnIBcqrAnDQjFSAnHcpJcgFyyqGcdCAnHcYpb3FJK4dy0ss7XNKhHIbl5R0tHR0dEPdwlXd0zujogjp0ecfMmR0wP3B1zpw5C6vniAAA29kvMXeFcuMAAAAASUVORK5CYII="
            } },
            {0x00CD,
                new Items.Item()
            {
                Name = "Miracle Seed",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAFVBMVEX////4+Ojo6FjY2HjAwDCAgAgwMDAYu2d0AAAAB3RSTlMA////////pX+m+wAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAeklEQVR4nJ2PMQqEQAxFp9n0IWLvEO3VE5gN2wuy9SA69z+CionTLpvqPf4PJCH8Pd+cd+ccY/w8jFiZwMVqsp4scgs0iFG5ewJlbl0GFknWIpIiPbGtwERIoi49Et+tAO8GBwvCq11GnZJdtqlK7SeDzrUH1zOFf5kDPIQVADU+sPgAAAAASUVORK5CYII="
            } },
            {0x00CE,
                new Items.Item()
            {
                Name = "BlackGlasses",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAD1BMVEX////IyMhgWGBIQEgwMDAeKyEZAAAABXRSTlMA/////xzQJlIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAFtJREFUeJytzsEJwDAIBVAhTtAN2nQCdQBp3H+maiDtvxYqOfxnRCT6o8whh0Mmh/ygwQxxj9VNbDr/2mUTekZlLtiQI7Jf6MZ7l5rJp4V1Q3jhXS+IgSC84mPdfNkM93HgH20AAAAASUVORK5CYII="
            } },
            {0x00CF,
                new Items.Item()
            {
                Name = "Black Belt",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAD1BMVEX///+AeIBgWGBIQEgwMDD6otnAAAAABXRSTlMA/////xzQJlIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAIpJREFUeJxtj+ENAyEIhUlgAVsXOOsAV3UAVPafqSKn7SXlB+HjAU8BbkH9B3rRjIU3UHV+QpwdgxROoFxa0DkcuWc2oOM5BDCA6nphSi+wq8K6tc1wbK1S2hawPkJcwnCXE9CE4LWdGC7XkV38wtseRzqAzs0x9cN2+Ot7Wdq+TT3nsnyARHb9Pz57kxUPJGe/2QAAAABJRU5ErkJggg=="
            } },
            {0x00D0,
                new Items.Item()
            {
                Name = "Magnet",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////4uLjAwPiouKj4mJCQmPiQoJCoUFBYWLBIWEhwODg4OHAwMDDNTTWdAAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAkElEQVR4nGNgIAFwzjmJYE9OS5sJ4xxOA4IDEDaPWVqyWVoOTCJz5uS05AlgCRfjmTNnmhmD1R1x8YRzuFxcVs48czjZEsThKfRaOQdoxkwwp7xq5YGjwZkwzhqe0NCZMM6BraHRM+eArTlZw3BCdfdMiAs4DzCc6Ng9B+5SIOcAEmcPwj88MxASDAxzGEgAAMEWObJU+sv6AAAAAElFTkSuQmCC"
            } },
            {0x00D1,
                new Items.Item()
            {
                Name = "Mystic Water",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////4+PiY2PjA0NCoqNhYWNBISAAwMDBIAAAglMueAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAABySURBVHicY2DADzo6GuBsDjCCggYohkqgcTgQnLQ0BCeNAYQgHDYQkYBsGhuUU4DEYQ8AGwJRV2yO4LCbmIK1gTnFIs4FcE6JC5gDNoDdSEm5AKgHwjEMDQaanZaAxIHaYhLqDOcwFBubIwKAvRwhgQQAQV8V94Uo4x0AAAAASUVORK5CYII="
            } },
            {0x00D2,
                new Items.Item()
            {
                Name = "Sharp Beak",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////48Lj44Jjw2FjQqDi4kDiIYCBoQBgwMDCtp1bFAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACJSURBVHicY2AgCMKR2OxGBQhOsVIDkoRKA5KEixtcwljFxQMuYexirJgAkzA2VhSEaioEscshHDZhYyPBcqgeVqCEeIoHTJWSWBmUwy5spFyRlgLVYqxkzp7mAuEUGikXlKVBtSQrpTPAtQiZM8BVsSkXwCUYEoESJh5QtxQDvdgB80w79jBhAACsCB4sM8Ea2QAAAABJRU5ErkJggg=="
            } },
            {0x00D3,
                new Items.Item()
            {
                Name = "Poison Barb",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////4+Pj44PjQ0NDouOjAkMCQYJBgYGAwMDDBsdvlAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAABYSURBVHicY2AgDXA0IHGaRZEkDM0RUs3CxQ1IEhYEJBqQJRqQJNg0kCTYNJCMYlNFMopNVRBhB5uqCMKOJJewDAYExzW0A8FxcXHtQCjrgMt0dCD7EQcAAMunGIUSrVFQAAAAAElFTkSuQmCC"
            } },
            {0x00D4,
                new Items.Item()
            {
                Name = "NeverMeltIce",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAFVBMVEX////w+PjY8Pig0OBwoMAweKAwMDA/zKchAAAAB3RSTlMA////////pX+m+wAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAkklEQVR4nH3PsQ6DIBAGYJeyEy7dS0j3Q+tO73SurXEGo33/RyggA4v9Jz7Cz+Wa5m9EjelVIfgTXORQ9eV4gklyLJVeiPDims8+YrwfED0qHkyA9E4oVN0T8IDEtkNwOg17S2UNAun0/3qzmhDYZhgXQUwZ7IA64k/Cxo7j/SNjKZj3NHXZeOa238s+35h685wfnA8fwhpxcuMAAAAASUVORK5CYII="
            } },
            {0x00D5,
                new Items.Item()
            {
                Name = "Spell Tag",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////4+PjIyMjwkJCYmJiQkJDAYGBQUFAwMDA2/TLZAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAAB5SURBVHicY2AgBXQgc1qQee0uSLyWciReuUu5SwOUzVEO5ME5RUgyLerl7nCZorK0IhiHwym4DM5pDQw2LtKASqiGioYqeUA4TYqiioKhEFUcSkqKoaFQTpGioJBgaARUi5CSopIQzJYOIEcD4TUh9QYGBA+JjRUAAG2PHzw4TSMGAAAAAElFTkSuQmCC"
            } },
            {0x00D6,
                new Items.Item()
            {
                Name = "TwistedSpoon",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAElBMVEX////w+Pjg8PCYqKhogIAwMDD+yCO4AAAABnRSTlMA//////96eeD+AAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAABwSURBVHicjY/BDYAgDEU5yAAYHACcAMoAGsodJOy/iiQg7dF/6kt/+1shfiizWh4Mipqt1mX2AfIEAIsDisWuNu06dd83i2ztnViCItiqIaiBbDIgQcXoGIC5lit6nReAZeANW+Y0xTw60WWy8edJL+kuFDfaW2VxAAAAAElFTkSuQmCC"
            } },
            {0x00D7,
                new Items.Item()
            {
                Name = "Charcoal",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAElBMVEX///+4uLiIiIhgYGBAQEAwMDCHl/NeAAAABnRSTlMA//////96eeD+AAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACISURBVHichdA7DsMwCABQhuQCpBdwcPfahr31Z68cfP+rtJLtZAwT6AkEANzF8r7y1fP3LI6PeZ5AiHFSdcbSawDjwwcZHdGlLZQOjtAw5w7oiGof8IfNSy0TAontwAH3EDuo5l1obHOUpHXMBbWiE0Bz49EBkBrlNJdcWXkCQJN0HbY0vf3KD0/RGUbrrooEAAAAAElFTkSuQmCC"
            } },
            {0x00D8,
                new Items.Item()
            {
                Name = "Dragon Fang",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////4+Pjw6ODY0MjgyMCwqKC4oJiQiICAaGAwMDCZSleCAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAjklEQVR4nGNgIAwmIHMkkdicyBwO0QYEZ7IokqYmJA6nogaCM03QDc7pTBFKa4CznYQiocyZRoKCyhDOTENBQUElVbAWzrK0REE3JVMwp628LEPJrQOiaoZxeblSWgbE4OltxulNZp0Qs5IrOsyaI6A2zjBObw+FWsLQ3macEQlzCmd5RyXCjZ0zUbwPAwC+syUE6+HUwAAAAABJRU5ErkJggg=="
            } },
            {0x00D9,
                new Items.Item()
            {
                Name = "Silk Scarf",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////4+Pjg+Pjo8PDY4ODAyMiosLBoeHBQYFgwMDA3l0c/AAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAwElEQVR4nGWQvQ6CMBRG2cAR8AVo+wL0XuNuWhrWQnU3urMQZTMxRkcSYwxva0sbF+70nZzenzSKlnW5vp7/LIzZB0o0ERVn3QwPgpVp+M0LEGchT+MsKB40YWb0QvaES+UFKE2ZrB0cAa0QrYOEQ6VLlMJNvlNUOmctjk5g1dNMNmsL8TRNfYmmYPOaKNblhmZbf9pK57uS1h56kpMMAnwISQG70FKkAML3Dzy3Obx6g80qDBa2Qo4Gu/XbLf/oB0CuMOwocSMEAAAAAElFTkSuQmCC"
            } },
            {0x00DA,
                new Items.Item()
            {
                Name = "Up-Grade",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAALVBMVEX////o+ND48Njo6MD42ADQ0LCg0KDAwMDguLioqJDgkACAgICAgGhgYEgwMDDeAUGRAAAAD3RSTlMA///////////////////ljZ6mAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACSSURBVHicY2AgF/A9QGJfsnuAYCstWfcAwXZx8XsAZSu5PHFZew/Ee6SkpHTFZe1143lAzptD6oWyd28X294Dcc5cFBRUUtK+C+F0NAoqqZdDOGc70rJnpKXtBXNi08rLO9rSdoI4T0OvAzkduTNBpvE9jd5e3tF7cx7E1qfRu+9C2SBe6Mx5CJc+RbBR/UMYAADjs0ZHuZjsngAAAABJRU5ErkJggg=="
            } },
            {0x00DB,
                new Items.Item()
            {
                Name = "Shell Bell",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAYAAAAGAB4TKWmAAABPUlEQVRIx+1VMRKCMBDkSTyDJ/kEnmDJE3iCJSWlJaWlZbrIHi4u5CKMjjZa7ASTc3dz3B1FjLH4JIq/wFcEDnUdq6qKZVka3hIAEclIvo5RkU0yuiKO3SkOw2Cg89ytsgIkBkkI5xHB0F8vtte0re0jDs/rtJDDFcCBEoMA6Ebnl7434Aw3QSxWT4S/s+QkJiGBW2BFHNPFeBVxBbDJ4CXxMkVME2Ig4t0iEXi4n9Kyzj9AYjWAPaaKpG4VISh1n5LrGfZwK7r3qmohgGC+TBVIyc9JVXmVlAhM5Rc2yIM9z+RNY+umABuJVUIhrXt1ve6VXQL8E0Xg9OE+Jed76+49sStFOh605nU88HwSCFn3bh+owxw48KzqxnewW0CbjbPGwzxGNsizw45OdURoT4BYR/bLH5xnqfqdb/IN4LGaj2w3oS8AAAAASUVORK5CYII="
            } },
            {0x00DC,
                new Items.Item()
            {
                Name = "Sea Incense",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////A2PCowNiAwPhgoPBIcMBwYDAwWJgwMDCVBiKkAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACrSURBVHiclY+xDoJADIbdYG1kuLmisEocWA9qdDY2OPsEBiU4egixj+0dIE4OfkPT5m++tLPZH/iPb+8ZdZn6p1HpJ2tgdYZ4DGIDoJohukqjTCz7fmhTFMH21GujPBEJqXR73prJwnNnv2XARcUQ7pw4QLCgdvJO5wuiZBM4Q0fBEWCryQ0lh5ooyDhyauQD85KxP+FVMSIX9+EZqS0y3ObXYqnHH2QqP3kDKEwrXCGIwSQAAAAASUVORK5CYII="
            } },
            {0x00DD,
                new Items.Item()
            {
                Name = "Lax Incense",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////48Lj42JjwwEDYuHjgqBDIkBCocCCYYAgwMDDk2H4uAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAr0lEQVR4nGNgIAFwTkCwOSZpNsDZUyZpesLkJgl5tCh6QiU0JwoKSk6BSDXPnKQ5SXNmJJgzLdJl5kyXqZVgYzWSjWfONDZrAqnjEC0PBYLyQJDpTcZK5RXt5UrGGiCDgwVDg1RDBdVAhk8LUjI2FDRWgnBSlEKVgMgNxGlzcQtSUg1ySckAGd2WluKW5pKWAXbCjLY0IMjohHhmZgcQzIS4jbNjJhB0QP0wE07gBADwUTRAEOwo/QAAAABJRU5ErkJggg=="
            } },
            {0x00DE,
                new Items.Item()
            {
                Name = "Lucky Punch",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBwAgLf7Zv4gAAAGESURBVEjHxVQtd4MwFL3sIOhPQFZWJq6TWCQuyMlZHLqK/YVZHHO1yOKCnMQROzfcm1jDoAGaduzsnYPIe+HevK8L/LE5cwHGGF366rp2biVw54BlsR8H5AbFG+jwfhuRcwneA8vN6GJTnb7dqsMtJK4BfgbWgL+1hynnEjj3PaS76R7NEgxfv9bLFzP4NwKpur7Jc6O8SNBUJ0RlNwteqQaVaiDTAEXgoQi8qyTulDMqOxSBZ4C/vIrzPpR9rAg8RGA0N7au3lAegYY/LYHrEgFAis6+RDr16RqZ4EKI0fl6k/kntvtH8/XPTyNwIQSklEiSBMfj0W6TdZnS3fhC+bE1diNJEnDOIYRAnucQQgDAZB/cS7U8wJwKqX7qLKUE53x0BoA4jhGGoUHi2kjyAazPTCl1VyZXjTFG+suyjIjIOBMRtW1Ltjq1SKaBGGM9WZZlNIzdrUV1XTthGPbTNOyJ1SbbkgCgOI770c3zHADg+/56ajkszbBcq0qyBrdV2FXtC8vQET9Q4qJsAAAAAElFTkSuQmCC"
            } },
            {0x00DF,
                new Items.Item()
            {
                Name = "Metal Powder",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////4+Pjo6OjQ0NDowPDIkNCYmJiYaKBYWFhwQHgwMDDle6QzAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJ9JREFUeJxjYCAbcK1ahWAvS0uD8xYnCpulLYBKmAkKGqdlQTjLzASV1DLaGsCcFR1mSmodbWB1XE1mzWrJEA7XQiGLjGSLjmQQZ4lHc4ZEckeaFUjCNXJGolpbmjFYlev08o7kZmOIpSvDy8ubuyBsrhAX9/KJUOuXioiEVEZwQSUcXVwrPRhWQTghIeFVHVAXrwoNLV8A98wqJI/hAgCE1TBwG/NmwQAAAABJRU5ErkJggg=="
            } },
            {0x00E0,
                new Items.Item()
            {
                Name = "Thick Club",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAFVBMVEX////g6MjQ0Ki4wKCYmICAgGAwMDBBFwRNAAAAB3RSTlMA////////pX+m+wAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAYklEQVR4nGNgIAjSEhBsNkEzBCdR0BQhlShkbIrgKCnB1bEpOiM4ScLCymFwCSHTNLiEoHICQocQwhZcEmlIEmzKhkZwiURBFYSOREUhVYRRRkjmsgULIXvF2A3Jk8g+xgEAxuUQRW/AQ20AAAAASUVORK5CYII="
            } },
            {0x00E1,
                new Items.Item()
            {
                Name = "Stick",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////4+PDg4MDI6GCw0EiwsIh4uAhIkABgYDggYAAwMDCM522UAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAGdJREFUeJxjYCAEViGxucwWIHHcqxCcJelVq+Byy8pnmmTBOTNN0mAKuTLT0srhnLK0dLieJSbpcIu4nF0QJi8ycYOby6WolIWQEFJFlogiLNGEJMERiiTBFRqK5K9WhARQCkkCGQAAw0YdSW6XsGgAAAAASUVORK5CYII="
            } },
            {0x00E2,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00E3,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00E4,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00E5,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00E6,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00E7,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00E8,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00E9,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00EA,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00EB,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00EC,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00ED,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00EE,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00EF,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00F0,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00F1,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00F2,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00F3,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00F4,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00F5,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00F6,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00F7,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00F8,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00F9,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00FA,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00FB,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00FC,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00FD,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x00FE,
                new Items.Item()
            {
                Name = "Red Scarf",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX////4oKjoeHjYcHDIYGC4UFCISEgwMDDDG2SQAAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJ5JREFUeJxtzzsOwyAMBuBMeCZSmp2W5AC9Aj1AB8jaItWsJBL4+uURkqH15E/65UfX/RTR2YPW/sAq0VHjeomrXFpshGFoSWbDs9euzrLzFCgUkLDGTB4w5UBgWBzOXUx44yeYiPaVMaUd6KL1kCaNKUseymTg+S62VfSciKzcceVC3B4Nd6VUBfsHUy7bKuoHULE/4DJi+9oRHf1ZX85BMbGFJeqkAAAAAElFTkSuQmCC"
            } },
            {0x00FF,
                new Items.Item()
            {
                Name = "Blue Scarf",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX///+wqPiAgPB4eOBoaNBYWMBQUJAwMDDQds3KAAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJ5JREFUeJxtzzsOwyAMBuBMeCZSmp2W5AC9Aj1AB8jaItWsJBL4+uURkqH15E/65UfX/RTR2YPW/sAq0VHjeomrXFpshGFoSWbDs9euzrLzFCgUkLDGTB4w5UBgWBzOXUx44yeYiPaVMaUd6KL1kCaNKUseymTg+S62VfSciKzcceVC3B4Nd6VUBfsHUy7bKuoHULE/4DJi+9oRHf1ZX85BMbGFJeqkAAAAAElFTkSuQmCC"
            } },
            {0x0100,
                new Items.Item()
            {
                Name = "Pink Scarf",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX///+w+LCY6JiI4Ih40HhwwHBQkFAwMDBEud8ZAAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJ5JREFUeJxtzzsOwyAMBuBMeCZSmp2W5AC9Aj1AB8jaItWsJBL4+uURkqH15E/65UfX/RTR2YPW/sAq0VHjeomrXFpshGFoSWbDs9euzrLzFCgUkLDGTB4w5UBgWBzOXUx44yeYiPaVMaUd6KL1kCaNKUseymTg+S62VfSciKzcceVC3B4Nd6VUBfsHUy7bKuoHULE/4DJi+9oRHf1ZX85BMbGFJeqkAAAAAElFTkSuQmCC"
            } },
            {0x0101,
                new Items.Item()
            {
                Name = "Green Scarf",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX///+w+LCY6JiI4Ih40HhwwHBQkFAwMDBEud8ZAAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJ5JREFUeJxtzzsOwyAMBuBMeCZSmp2W5AC9Aj1AB8jaItWsJBL4+uURkqH15E/65UfX/RTR2YPW/sAq0VHjeomrXFpshGFoSWbDs9euzrLzFCgUkLDGTB4w5UBgWBzOXUx44yeYiPaVMaUd6KL1kCaNKUseymTg+S62VfSciKzcceVC3B4Nd6VUBfsHUy7bKuoHULE/4DJi+9oRHf1ZX85BMbGFJeqkAAAAAElFTkSuQmCC"
            } },
            {0x0102,
                new Items.Item()
            {
                Name = "Yellow Scarf",
                Pocket = 0x0005,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX////4+Ijo6HDg4GDQ0FDAwEiQkCgwMDBB3DmcAAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJ5JREFUeJxtzzsOwyAMBuBMeCZSmp2W5AC9Aj1AB8jaItWsJBL4+uURkqH15E/65UfX/RTR2YPW/sAq0VHjeomrXFpshGFoSWbDs9euzrLzFCgUkLDGTB4w5UBgWBzOXUx44yeYiPaVMaUd6KL1kCaNKUseymTg+S62VfSciKzcceVC3B4Nd6VUBfsHUy7bKuoHULE/4DJi+9oRHf1ZX85BMbGFJeqkAAAAAElFTkSuQmCC"
            } },
            {0x0103,
                new Items.Item()
            {
                Name = "Mach Bike",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////w+PCouKigsPioqEiYoJhoeLhgYGA4SHAwMDBA1lsuAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAzElEQVR4nH1QMXLCQAxUd/gF9BSY+wAztDSZlBQp8gFz7hzH42M7Zpgxvs6YJMr+Nr4zZQZVkna1K0nkSWSDiAGrmONmqRk5tcQsR3t480xIlsPzY9AhTaz4e76xTiOim23//Z4/xLjtglrjE/b544qAmj7KcewuhZv0o4/W2t8dfRRHvWe5cK5BJUbLHKd72V5fY7Feor1c9TgXFm0RupBoFkDROY3IQAV2PbNEkwanMVRfkUbTEHalntG0eVGhx7zBfFdaYDrf//uaP5//VLlpZV3lAAAAAElFTkSuQmCC"
            } },
            {0x0104,
                new Items.Item()
            {
                Name = "Coin Case",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEX///8wMDBAQEB4EBB4eHioODjAqDjIWFjo6Hj4+PjvrpQ5AAAAAXRSTlMAQObYZgAAAIRJREFUeF6FjzEOwjAMRZMb2EVIrPYVEAdolYEZhJjboRJrl8xdOEOPy6/yRcjEm/6Tvy05/EW7r0QFQjk8gFGOZ+BCuWBCiXfkW5WcFwuNcOWZszfCY7rTFdHt9d5GrXmyn1zWY8mUBBwSdZfrlAY3Oa0QpDSYhFlY6yWgBfgkWhW0Wj7YAyKN0Bb0wgAAAABJRU5ErkJggg=="
            } },
            {0x0105,
                new Items.Item()
            {
                Name = "Itemfinder",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAMAAADXqc3KAAAAB3RJTUUH1QMaExYnUdH3ggAAAAlwSFlzAAAewgAAHsIBbtB1PgAAAARnQU1BAACxjwv8YQUAAAAnUExURf///zAwMHhISNBgYEhISPi4uGCo6ECIyOjoaIjQ+Pj4+Li4uGhoaATq31IAAAABdFJOUwBA5thmAAAAnUlEQVR42o2SWRLEIAhEbUDccv/zDkbNolZq/FH6VQOizn0sAHs9xoitnvOWdLDmq5kMHMcxs1bD1IX1SAZ7ZxTJOafK8HKYzLmUIA9w1jBDKSJEBJJXu2KyI+89YQI1BBH7G8QxEwRNlivI8x7nib0GaJJpumD2bK44LFd7VXcSksqkd6BRsRpsBtr2S7fLNcC8AOye+gb//olp/QB+CQRGfA2XnAAAAABJRU5ErkJggg=="
            } },
            {0x0106,
                new Items.Item()
            {
                Name = "Old Rod",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////4+PjA2ODguGiYsLjAmEBogIjIWDiYaAhwQBAwMDCkW8e1AAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAIpJREFUeJxjYEADXKuQOIstFyBxIrOQlE1TQ5JakjQLIcOVEQmXWsCwtLULJgFEkaELYBIMDCsiomASQKK1dQGcA5OCKOaaOmMBnMOwMrQLomoV0KlcUyEcLvEFQPmVs8Cc5eVVQIprAZizaLoX1EygAi6VBTAOUHoVzDYwD8EBhwGS71YhBwkUAAAptiThYIFoYgAAAABJRU5ErkJggg=="
            } },
            {0x0107,
                new Items.Item()
            {
                Name = "Good Rod",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAMAAADXqc3KAAAAB3RJTUUH1QMaExYJjQf6TQAAAAlwSFlzAAAewgAAHsIBbtB1PgAAAARnQU1BAACxjwv8YQUAAAAhUExURf///zAwMFBQiHh4sMDY4JiwuHCIKMhYOPj4+LDIQNjwYIXR6t0AAAABdFJOUwBA5thmAAAAeUlEQVR42p2QWxaAIAgFuT4w2/+Co0wFtJ/4AuYMoET/Agwwb/pEzLVi05fgemILCJ6MypNZODJzOaDyDjjF2JpYoGY1ACzKk+Ao8MrdQJFoJEZokLjkBkIws5By/5lglHv5u94p6j6nKLAoA0T3ll4oRXYDKqfvuABRuwHSDVwHnwAAAABJRU5ErkJggg=="
            } },
            {0x0108,
                new Items.Item()
            {
                Name = "Super Rod",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////4+PjA2ODIwMBQ6FCYsLjwgGCQgIB4eLDIWDhQUIhYUFAwMDAaisRBAAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAmUlEQVR4nGNgwANOn9kOZ/Mw7K7eAOMcYGDYvgeJw1N8AMFhOG4O1wPE1TCpM2eAumwYENpOw3UBVfKcOXMAzjmZphQDZR9gOJZ2FCIFZDMcOjbH5QCUzcCjeeIM1FIgfebUGoidPJIHGA7wrDgA5pycOYfnAM8qCOfQTpCxp3ogylRBZoA1AdWDDToF1nQG6t5VcOdBHI8MAMqeOdeV2tePAAAAAElFTkSuQmCC"
            } },
            {0x0109,
                new Items.Item()
            {
                Name = "S.S. Ticket",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAElBMVEUgICAgICAxaotSpN5itO7V3t67Ko0OAAAAAXRSTlMAQObYZgAAAGRJREFUeF6lytEJgDAMhOG6gUEXKNQBHCF6GaDQ7L+KaQi2r+I9fQd/+jOarevkcQiq9TUOO2FpYl1Ycdlx+xTWLRCAgaJ+tDHnIrVnewNn2k6zHYDCvbvccYatu4dTNNGZP+0BuokUzsexod4AAAAASUVORK5CYII="
            } },
            {0x010A,
                new Items.Item()
            {
                Name = "Contest Pass",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAKlBMVEX////o6PDw6JjY2Pjo4GjY0Ii4uNjgqIi4sGiQkLDYeGDgYEjAYEgwMDDLHUovAAAADnRSTlMA/////////////////1dK2xQAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAIRJREFUeJxjYCAX8F5A4ly2RfB4rScjeBfLiw1loTxeszOzpyVD5S4aKS1fXm4oC5aw8Ojo7N6dNhdsVEqHS4fHycwLYB1gzjSwxEVjU9XQIFVLsIR4sWmQklJwLlj7zOxtGR0dmRCD7wJ5aRCjILxjmXDX3J2Zcxbh6Lszkb1wlyTfAwCh8TIYMVKdHQAAAABJRU5ErkJggg=="
            } },
            {0x010B,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x010C,
                new Items.Item()
            {
                Name = "Wailmer Pail",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAAIVBMVEUAAAAxMTHe3v+0tNWLi8VaWpQ5OXPe3tX29u69vbT///+1g2OqAAAAAXRSTlMAQObYZgAAAAFiS0dECmjQ9FYAAAAJb0ZGcwAAAAMAAAADAHeTl6MAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAHdElNRQfeCxISIDTCst7zAAAACXZwQWcAAAAeAAAAHgD4T+E9AAAAmUlEQVQY05WPTQrCMBCFMzfoaBXX9ggJ7oMvBwhkuvcIBSFkK0J7bKepgS71reZj3psfY/4R8Q4OrmslM3wDtir/9Vukq9181FtmHlys2d5GZluBhnRfMyGqjxygFAQ6ggK8DyIpoDM0evQnESRR3/kJaMeFcQ29FaIc5VFnAyISb3Xr5aWQ8nY3zUvOZWqHzqVMuxe4M7/rA/fMH/v7vtNeAAAAJXRFWHRkYXRlOmNyZWF0ZQAyMDE1LTAzLTAyVDE3OjE5OjM2LTA2OjAw1oyW+QAAACV0RVh0ZGF0ZTptb2RpZnkAMjAxNC0xMS0xOFQxODozMjo1Mi0wNjowMGfjvMoAAAAASUVORK5CYII="
            } },
            {0x010D,
                new Items.Item()
            {
                Name = "Devon Goods",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAAGFBMVEUAAAAxMTHm5ua9zb2ktKR7i3v29vb///+d4K7jAAAAAXRSTlMAQObYZgAAAAFiS0dEBxZhiOsAAAAJb0ZGcwAAAAMAAAADAHeTl6MAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAHdElNRQfeCxISIDTCst7zAAAACXZwQWcAAAAeAAAAHgD4T+E9AAAAe0lEQVQY043PMQ6AIAwFULgBYGRH1J1gPABBdx28ANH7H0FKJTVxsdN/zR9axr4jhaRsXV/FrVziKBBqG9SVELxp9zH5Aq7lcSVfwFWEPUKfEXJEzNCZugK1Qqci2Nwh5PQbjhGMIDg8s8DV+zPMk1kTbN3DN5SzXvk1NyNeHASbrJlfAAAAJXRFWHRkYXRlOmNyZWF0ZQAyMDE1LTAzLTAyVDE3OjE5OjM2LTA2OjAw1oyW+QAAACV0RVh0ZGF0ZTptb2RpZnkAMjAxNC0xMS0xOFQxODozMjo1Mi0wNjowMGfjvMoAAAAASUVORK5CYII="
            } },
            {0x010E,
                new Items.Item()
            {
                Name = "Soot Sack",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAAJFBMVEUAAAAxMTGcakFKSmq9i1rerHu0rM32xZzu7v+Ui6zVze7///+kAd76AAAAAXRSTlMAQObYZgAAAAFiS0dECx/XxMAAAAAJb0ZGcwAAAAMAAAADAHeTl6MAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAHdElNRQfeCxISIDTCst7zAAAACXZwQWcAAAAeAAAAHgD4T+E9AAAAoUlEQVQY02NgwAcYBQURHCElJQRPWEnFBc5jNHJxCREUgHKSjUNDXAOhUmJpIi6hhVCOxCwTl3Aoh7FrhqGzMVSP2MrmiWaGMInM5pkzLCEyEm0rm6dlNkM5q8CciWBVWatmWKalzQBrYkzLAnPAmqAciCbGaSubZ07LnAnlZCI4DJIzm6elZUItYpScYTlzJsRokLcbBQUbBWDeEwAjVAAAUGwxQVWp15AAAAAldEVYdGRhdGU6Y3JlYXRlADIwMTUtMDMtMDJUMTc6MTk6MzYtMDY6MDDWjJb5AAAAJXRFWHRkYXRlOm1vZGlmeQAyMDE0LTExLTE4VDE4OjMyOjUyLTA2OjAwZ+O8ygAAAABJRU5ErkJggg=="
            } },
            {0x010F,
                new Items.Item()
            {
                Name = "Basement Key",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAFVBMVEX////48PDg2MDIuKCQgGhgUDgwMDB1y13gAAAAB3RSTlMA////////pX+m+wAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAc0lEQVR4nGNgIATS0hBsNiWlBDgn0cRIDS4hnBaoApNiE0lwRHCEQ4RM4BwjJWVXGCdR2cUlDCYhZBIaipBwhVsKlICpAUvArWcTMlZDknCCOwykQyUMLmGUkAqTSTJRUmODaUl2TUIyLI0NYQsQJDAQAgAoAhWvnJhXyAAAAABJRU5ErkJggg=="
            } },
            {0x0110,
                new Items.Item()
            {
                Name = "Acro Bike",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////w8PCouKjAsEDgoHigWDhgYGBoOCAwMDDXcKjmAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAAC4SURBVHicVY+xCsIwFEU7haw6ZbWDZBf8AoM/YDFj6VDfKIiQMU1qej/bvLQBfUPgcMO75zXN78iUH0EbIGEEtkigBYTfiPZeAJWQ/1aQJpOu+4xrJNGaARcv1WFXwqmd3fxQE4Mcoa7GpoEhAfrWOQo918DqbjlhyF4iBejuhXgEO7YBxoI0sZoOeFvlUJIQME+fO0qSxaRenpET9AkNBh95GyIl1j77osaK2dSXUnA30nppPfJ/vu2bQ6RuH7NoAAAAAElFTkSuQmCC"
            } },
            {0x0111,
                new Items.Item()
            {
                Name = "Pokéblock Case",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAMFBMVEX////4+Pjg2PC44PjwwLiA4JDosKjAsMiIsOjgmJDAcGhQeKB4aIAwWIB4SEAwMDB3pjmBAAAAEHRSTlMA////////////////////wFCLQwAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAvUlEQVR4nGNgQAc8Suf//XsA5Rx8lfa8MgXC45FftU5Ra6UfhCM3LU9Qa9UsiKpTqxYJKb1aBlZ36OXMg0JK/1ZCOP/+H1RX118F5vAAOTrqeqs+gDj8N34cVFcqh3B4bbu/qx9SWgnmXL68/0xRjZIeRML617xyJaV6qESv9Z7y8g8QiR/Buz+c/wOV2Gu9H+JiXmPr3827P8A4+9fBJICczZNhEgy8HbvhEiAOXIKB4Uc3XALozP8ICWQAAEAdVwKm3mqAAAAAAElFTkSuQmCC"
            } },
            {0x0112,
                new Items.Item()
            {
                Name = "Letter",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYAgMAAACdGdVrAAAAA3NCSVQICAjb4U/gAAAADFBMVEX////o6PjIwOAwMDBh470hAAAABHRSTlMA////sy1AiAAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAXklEQVR4nGNgwAU+gEn+GDD1FUzxh6aDOWCKPzR06gEQB0QBOWGhBQymEMoyNDQyNIaBd9WqpaE5DHyhQNEPDMxAKp+BgXkqiMPAcBXEYWB4CuYwmII5DFZQSzFdAwCDeh5Fikqn6QAAAABJRU5ErkJggg=="
            } },
            {0x0113,
                new Items.Item()
            {
                Name = "Eon Ticket",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////o8PCIyOjQsIhQyMiIuGDwcGBYmDBAiJigcDgwMDDTpp0YAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAHpJREFUeJxjYKAArEJmCy5AYiM4q5QEBaXgbKVGGAfIFlSEqlulpB4kKAHhrEpSLS9VFBJ0AarjUktTn6ykKNgC0sSllBSuCTRMUQqkbKGQktLU8BYvsH4gR7W8BMJm4BISDIexGbgEJeBsoDoVBJthCRKbgQuJTRQAAH2UHt8nvTCyAAAAAElFTkSuQmCC"
            } },
            {0x0114,
                new Items.Item()
            {
                Name = "Red Orb",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX////4+Pj4yMjYmJjgcGjAUEiQQDgwMDAVfVl8AAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAIdJREFUeJxjYCATsKWXJcDY7CnGxmYFUE6JMRCYQyWclZRNQkwgUmxGgkLGrq4QXSkgTkiIG5iTDOSYuLpCOMXGSsouIaHuEI6zs4mLqxuEk2xi4uLkGmYG4Ti7uLiEhqmBOawmQHZocgDEUtfQ0LC0JKh7SkPT0pLVYQ5NDTFWgzkUxQukAgBAYR1QRUWu8wAAAABJRU5ErkJggg=="
            } },
            {0x0115,
                new Items.Item()
            {
                Name = "Blue Orb",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAGFBMVEX////4+PjIyPiYmNhocOBIUMA4QJAwMDBoC+YhAAAACHRSTlMA/////////9XKVDIAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAIdJREFUeJxjYCATsKWXJcDY7CnGxmYFUE6JMRCYQyWclZRNQkwgUmxGgkLGrq4QXSkgTkiIG5iTDOSYuLpCOMXGSsouIaHuEI6zs4mLqxuEk2xi4uLkGmYG4Ti7uLiEhqmBOawmQHZocgDEUtfQ0LC0JKh7SkPT0pLVYQ5NDTFWgzkUxQukAgBAYR1QRUWu8wAAAABJRU5ErkJggg=="
            } },
            {0x0116,
                new Items.Item()
            {
                Name = "Scanner",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAAJFBMVEUAAAAxMTGctO4A5gAAlAApQXPu7v9SaqTF3v9SUmre1UH///9Vrh/fAAAAAXRSTlMAQObYZgAAAAFiS0dECx/XxMAAAAAJb0ZGcwAAAAMAAAADAHeTl6MAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAHdElNRQfeCxISIDTCst7zAAAACXZwQWcAAAAeAAAAHgD4T+E9AAAAlklEQVQY02NgwACMAkgcIUUEj1ERiSckKAjnMSqaGAN5EI1Cgs7OjoKqYmCOuKKgsLFQUCNYmWiQoqCgqkYhmCPeGqQoFNQOMYFxRmsQTIJBLFGjNAIqAeQolQdBJRgLxZXKw6ESQu1FqoGCUAmNDqUomMuEOppUF8JcXK6BkGAsL4dLgDhwCaBjygOR/F+OHACCDFgBAB+9GitFapdHAAAAJXRFWHRkYXRlOmNyZWF0ZQAyMDE1LTAzLTAyVDE3OjE5OjM2LTA2OjAw1oyW+QAAACV0RVh0ZGF0ZTptb2RpZnkAMjAxNC0xMS0xOFQxODozMjo1Mi0wNjowMGfjvMoAAAAASUVORK5CYII="
            } },
            {0x0117,
                new Items.Item()
            {
                Name = "Go-Goggles",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////4+PD44Ii4uLjYsDDYgACIiIhYWFgwMDCgurWOAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACISURBVHicY2CgDujo6IAxOTqMjc2gPI62dCAwbgBz2sqBqjraLMAS6R0QCixRAVHd3AASgShmaGsAmdoANA5ItgNps7QKhua0tPQKoAqORMHyDjNBQfGKDKAWJZfw9CQlJdeKCginownEaUCWAdmVGlrekR4aGg62rb28AojLyxsgTobYQ7x/ASRDLipgdU0YAAAAAElFTkSuQmCC"
            } },
            {0x0118,
                new Items.Item()
            {
                Name = "Meteorite",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAAHlBMVEUAAAAxMTHVnM2camrmvc2DUlK0i6zNg3taOTn///8uuKcVAAAAAXRSTlMAQObYZgAAAAFiS0dECfHZpewAAAAJb0ZGcwAAAAMAAAADAHeTl6MAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAHdElNRQfeCxISIDTCst7zAAAACXZwQWcAAAAeAAAAHgD4T+E9AAAAo0lEQVQY04XPTQ6CMBAF4PYGtgE9gBDXOGniWltZYzN4gAEOAI29gedW+2NYmDir+fImkzzG/g3frHbZZHEhq75JkN4bGGPEa9T1klBY0BWqDGduhhK8voCxEVK75fjAAF4Z9Ic9hN87baGd6RlQaOvPBDEpWutIkeo+KOfhCneKD+Q0AfQxYFuC91EMWGnhNKJIBVAp7HKzErH7FuVCrEr/nBdnaiFct6c/AQAAACV0RVh0ZGF0ZTpjcmVhdGUAMjAxNS0wMy0wMlQxNzoxOTozNi0wNjowMNaMlvkAAAAldEVYdGRhdGU6bW9kaWZ5ADIwMTQtMTEtMThUMTg6MzI6NTItMDY6MDBn47zKAAAAAElFTkSuQmCC"
            } },
            {0x0119,
                new Items.Item()
            {
                Name = "Rm. 1 Key",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAElBMVEX////4+PigoKBoaGhIQEgwMDC9hTOBAAAABnRSTlMA//////96eeD+AAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAAB2SURBVHiclc+xEYAgDEDRWDCAMgHRCQQXUOwFZP9VDEGijYVUfN5xBIAfS2XIEhFz30ohUh0NcMR8CDgyjkSw0gFTsgVwqnFa2qPnUL2nmna+EwZD1QC12ZzArJN7YFH1la7APQqEAjLxCyC+AJK2AvTLZ/+5LhM1Fr9ChQPoAAAAAElFTkSuQmCC"
            } },
            {0x011A,
                new Items.Item()
            {
                Name = "Rm. 2 Key",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAMAAADXqc3KAAAAB3RJTUUH1QMaExUpnUSJRgAAAAlwSFlzAAAewgAAHsIBbtB1PgAAAARnQU1BAACxjwv8YQUAAAASUExURf///zAwMGhoaPj4+KCgoEhASIZ7Nr4AAAABdFJOUwBA5thmAAAAcklEQVR42rWRSRLAIAgEHZb/fzmAsVzAQw7hYFndiIKt/RIAfMlcRADmUzkfKnNSV8j5Ihpqcop8UqXYYQoHnt2PLQKRq9TLLbWYR5mTi7wqczLl9xec7BE1b1t3C9+HdOE+jZKbqLl1zTaQzOPnKvw1HiUZApce/VY7AAAAAElFTkSuQmCC"
            } },
            {0x011B,
                new Items.Item()
            {
                Name = "Rm. 4 Key",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAElBMVEX////4+PigoKBoaGhIQEgwMDC9hTOBAAAABnRSTlMA//////96eeD+AAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAAB4SURBVHiclc+7EYAgEEXRNaAApALfUAGLFaC5gvTfinwESQwk4s6BYSH6sUSk2MMjylYCSHU0yHU0YHao5wJgtQEKBQYcoGtcrI3BVkLILZney51zXlI1gFqc7WBUsC+sor4yZXhGoTNDn3gA8gNQUNwh/fLdf64bX1IXI0rZMQsAAAAASUVORK5CYII="
            } },
            {0x011C,
                new Items.Item()
            {
                Name = "Rm. 6 Key",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAElBMVEX////4+PigoKBoaGhIQEgwMDC9hTOBAAAABnRSTlMA//////96eeD+AAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAAB6SURBVHiclc+xEYAgDAXQWDCAMoFfJgBcALFXkf1XMYKAjYWp+PeSSyD6USJSrOFA7EsSAKetwOQRtwJWO+S+AOiJOxMFA6cAlcNplAN8CqL3hmFNM/swcioAOS62gpbBNphF3tLd8JxC+w314hfQ8QIK0lTgX7b3Z11vhxcziR5MRwAAAABJRU5ErkJggg=="
            } },
            {0x011D,
                new Items.Item()
            {
                Name = "Storage Key",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAFVBMVEX////Q+PC44MCgwKBoiGg4WDgwMDBEimRZAAAAB3RSTlMA////////pX+m+wAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAd0lEQVR4nGNgIATS0hBsNiWlBDgn0cRIDS4hnBaoApNiE0lwRHCEQ4RM4BwjJWVXGCdR2cUlDCYhZBIaipBwhVsKlICpAUvArWcTMlZDkjCCOwyoQ0klDKEjCa4nyViNDW5YspNSAsKwNBWELQwMqQlIHDYGbAAAIfEV9JrdwXwAAAAASUVORK5CYII="
            } },
            {0x011E,
                new Items.Item()
            {
                Name = "Root Fossil",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAKlBMVEX////w8KDY0HDQ0IC4sFCgoFCIgCCgeCh4eCiIWABgYChgWABIQAAwMDCc/KBhAAAADnRSTlMA/////////////////1dK2xQAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAN1JREFUeJxjYEAHPHeROEdN18LZZy8KlsJ4PMLBwlbhFyAcXkEpc+MVtRDOxeDixYa2HWApHkEpY1lB4YhesCpj48XCgsah7SAp3uBiWUPhWtNwXyDntpexsbGF6NUoIId3istSY+NG49iWuUCOm4pXqHGzhZnLWSDHxcWlalV7o63PXiAn55hKkovb9eDbIM7pIy5uKi65hrdBRu9xSVJTcbldaguy9JCLW1LS3d3BYBdcyXaZc2zb7qVgmWtb9pzetm2XcBfYbUd25969e9kc4qG7dw8AhZCDARMAAFhISWufUY57AAAAAElFTkSuQmCC"
            } },
            {0x011F,
                new Items.Item()
            {
                Name = "Claw Fossil",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAKlBMVEX////w8KDY0HDQ0IC4sFCgoFCIgCCgeCh4eCiIWABgYChgWABIQAAwMDCc/KBhAAAADnRSTlMA/////////////////1dK2xQAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAM9JREFUeJxjYMAH7t49e/fuBQibV8XtarCxFZjHe8llVYewsbEtiANkG5s2Glv0gjhXPAqNjSOEW2OB6ngzF1oIW0SYhsYC1fFmCbc2tnaZhq4FabpoEXE5dG3V8huxQM7i0OW3Vjm5uN0CmsAluiolyWWTis9ckAFRKS5uKm6bju0F2bnEJclbzVvt9F6wPS5nziQlJZ0GO+fOmeydR1z2ZIM513Zn73XxOZ0LdjRPdvbeM8d2Qzi82XfvZu/cC/XPXRD/AtyrvHfxhgQ6AADBek2xtG6kRQAAAABJRU5ErkJggg=="
            } },
            {0x0120,
                new Items.Item()
            {
                Name = "Devon Scope",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAKlBMVEX////4+Pj46IjA6PjI4JiYwNDAmEhwqECQkJBokKBAcIhgYGBISEgwMDAWcKAuAAAADnRSTlMA/////////////////1dK2xQAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAKdJREFUeJxjYKAKOIPEvtODED478/YFKJune6qRku6FM2ClJ7ZGKikp6e7uvQCSmGykVqSUGXtZF8jZahympJQ2NcpU6QID70Xj0LS0mUsXBwE53KXCpjNnhkaZTlMDcsRDjUNDIxdGgji8C92B7FmiM6elATmrJrpXzqyynLk2F2jP2ZVTXNxXha66BXbF2ZUzZ85adRbqoLO3Vq25C3cqz90LDCQAAP0OPsmh5jNgAAAAAElFTkSuQmCC"
            } },
            {0x0121,
            new Items.Item()
            {
            Name = "tm01",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0122,
            new Items.Item()
            {
            Name = "tm02",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0123,
            new Items.Item()
            {
            Name = "tm03",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0124,
            new Items.Item()
            {
            Name = "tm04",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0125,
            new Items.Item()
            {
            Name = "tm05",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0126,
            new Items.Item()
            {
            Name = "tm06",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0127,
            new Items.Item()
            {
            Name = "tm07",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0128,
            new Items.Item()
            {
            Name = "tm08",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0129,
            new Items.Item()
            {
            Name = "tm09",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x012a,
            new Items.Item()
            {
            Name = "tm10",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x012b,
            new Items.Item()
            {
            Name = "tm11",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x012c,
            new Items.Item()
            {
            Name = "tm12",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x012d,
            new Items.Item()
            {
            Name = "tm13",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x012e,
            new Items.Item()
            {
            Name = "tm14",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x012f,
            new Items.Item()
            {
            Name = "tm15",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0130,
            new Items.Item()
            {
            Name = "tm16",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0131,
            new Items.Item()
            {
            Name = "tm17",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0132,
            new Items.Item()
            {
            Name = "tm18",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0133,
            new Items.Item()
            {
            Name = "tm19",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0134,
            new Items.Item()
            {
            Name = "tm20",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0135,
            new Items.Item()
            {
            Name = "tm21",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0136,
            new Items.Item()
            {
            Name = "tm22",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0137,
            new Items.Item()
            {
            Name = "tm23",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0138,
            new Items.Item()
            {
            Name = "tm24",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },


            {0x0139,
            new Items.Item()
            {
            Name = "tm25",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x013a,
            new Items.Item()
            {
            Name = "tm26",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x013b,
            new Items.Item()
            {
            Name = "tm27",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x013c,
            new Items.Item()
            {
            Name = "tm28",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x013d,
            new Items.Item()
            {
            Name = "tm29",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x013e,
            new Items.Item()
            {
            Name = "tm30",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x013f,
            new Items.Item()
            {
            Name = "tm31",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0140,
            new Items.Item()
            {
            Name = "tm32",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0141,
            new Items.Item()
            {
            Name = "tm33",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0142,
            new Items.Item()
            {
            Name = "tm34",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0143,
            new Items.Item()
            {
            Name = "tm35",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0144,
            new Items.Item()
            {
            Name = "tm36",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0145,
            new Items.Item()
            {
            Name = "tm37",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0146,
            new Items.Item()
            {
            Name = "tm38",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0147,
            new Items.Item()
            {
            Name = "tm39",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0148,
            new Items.Item()
            {
            Name = "tm40",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0149,
            new Items.Item()
            {
            Name = "tm41",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x014a,
            new Items.Item()
            {
            Name = "tm42",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x014b,
            new Items.Item()
            {
            Name = "tm43",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x014c,
            new Items.Item()
            {
            Name = "tm44",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x014d,
            new Items.Item()
            {
            Name = "tm45",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x014e,
            new Items.Item()
            {
            Name = "tm46",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x014f,
            new Items.Item()
            {
            Name = "tm47",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0150,
            new Items.Item()
            {
            Name = "tm48",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },

            {0x0151,
            new Items.Item()
            {
            Name = "tm49",
            Pocket = 0x0004,
            Description = "",
            img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
            }
            },
            #endregion
            {0x0152,
                new Items.Item()
                {
                    Name = "tm50",
                    Pocket = 0x0004,
                    Description = "",
                    img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
                }
            },
            {0x0153,
                new Items.Item()
                {
                    Name = "HM01",
                    Pocket = 0x0004,
                    Description = "",
                    img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
                }
            },
            {0x0154,
                new Items.Item()
                {
                    Name = "HM02",
                    Pocket = 0x0004,
                    Description = "",
                    img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
                }
            },
            {0x0155,
                new Items.Item()
                {
                    Name = "HM03",
                    Pocket = 0x0004,
                    Description = "",
                    img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
                }
            },
            {0x0156,
                new Items.Item()
                {
                    Name = "HM04",
                    Pocket = 0x0004,
                    Description = "",
                    img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
                }
            },
            {0x0157,
                new Items.Item()
                {
                    Name = "HM05",
                    Pocket = 0x0004,
                    Description = "",
                    img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
                }
            },
            {0x0158,
                new Items.Item()
                {
                    Name = "HM06",
                    Pocket = 0x0004,
                    Description = "",
                    img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
                }
            },
            {0x0159,
                new Items.Item()
                {
                    Name = "HM07",
                    Pocket = 0x0004,
                    Description = "",
                    img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
                }
            },
            {0x015A,
                new Items.Item()
                {
                    Name = "HM08",
                    Pocket = 0x0004,
                    Description = "",
                    img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAIgSURBVHjatFUtk8IwEN0yJyorIysrg0MiK49/cPL+Ai6uFom7kzjOUYnEEVlZWVmJ6+UlTdPQD7i5YWcytGz6dt9+Bk3T0CtlQS+Wlxt4e/bidrttiqKgsiy9/9M0pSzLgqnvgkc52Gw2DUDT9GOgq6pK/0qZUxzHdDweg6cNwOM8zztgsY5JoRAxdcLQWlDoFxKXShmR6lXS9XoNHhrog2vgMCKKQgPcNwC53YjqWht63+dKVXtMFg/B58SCQ5KEOOeDHA0YLJfLRoOvmPnDemtZxIm7DPBb7d5VESBcRXHuWCzuE8oYJ8Ej4531EgLwiBnQsnDg0NsTG8Z9Fp4BKEDTCwGEMSjp/VOQ2O8NC4DoEN2dqT5A7Dvv+wKvAK4SeDp9BfauUPVPbZk+1WhoIs7XfoW0ORAX2YEPkjzRG9Od3DeAxKojZeVVmVjxSQOGdDw0gPgnSQtqk9rKz2GnCyBRFzQ4kl2Vo+BgwHkyw8ACgwmM1cb7w25nnnUyK6O/YyBkrbs5y1w3jw87Cx5FpoIK6SqEtQxt/feMYFz0w+MZ6BQoP74y4DYfCXdda4F1KJ0R6/39LOr6AJ2X59+6Ez3wAbvIsQjNPYDjW4zu2YUDFqBJ53yyQlyJ1joX4lx24GN7YXQWoeHQ0XoeIVzIgw0R8oGQ9Eb03NIZHdd2yXCetpOCeQ2EZwBPLZmnN9rYmgQo+mFuTf5pZf5XfgUYACtqTfzFZCdUAAAAAElFTkSuQmCC"
                }
            },
            {0x015B,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x015C,
                new Items.Item()
            {
                Name = "unknown",
                Pocket = 0x0000,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kKBhEoOP6Ff0kAAACDSURBVEjH7ZNRDsAgCEOp4f5XZt8ziFXEZMn41gLlVaS4QL6z3f9ghM18fQBTnaiBjYQHjVwtpb0E+u6pG7ymH0zIvJGWWB/9Vl61akyV9bw6B+GdjlDEZiO7gUdOqKPb3ga27FJEJzuNKTv9lRxglZ5DiH9og7YYAlklqfzIP0XTegDdgy0vHpobqgAAAABJRU5ErkJggg=="
            } },
            {0x015D,
                new Items.Item()
            {
                Name = "Oak's Parcel",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUgICAgICBzWhBzcxiUeyCkpDHFxVLNUhDNtFr23oOFfZhLAAAAAXRSTlMAQObYZgAAAItJREFUeF6NzjEKwkAQheHkBlmwiP1eQEiRNjCNvQT3AAqeIB4gkGktlH239Q2Z1VTidD8fD6b6faH5Ro1H+MQeQMF6BF5EhzElQwMQLjfkwRcJz+tssRMugHyyaFWOjLlbQztBFhc9q0Qp0qvGjdw3skyUhhEoE+VAYLX9wk35lBgHA8e4gmP1/70BkdszoevGEWYAAAAASUVORK5CYII="
            } },
            {0x015E,
                new Items.Item()
            {
                Name = "Poké Flute",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAKlBMVEX////4+Pj48IDo6PDo0GDIyNDAqDDwcFh4eIDQUDiQYCi4OCCgIAgwMDBiASr9AAAADnRSTlMA/////////////////1dK2xQAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJ9JREFUeJxjYCAI7t5FsHmdVC7AOTdnuuQiJFymwTlXVO76QDi8d+86uUA5vJeNjTvuuuWADQCyjU173SASJ2ceNjaOSANL8BaKzzlsHAHRfrNQfOYc41CIlTenV86ceRjOmTlz5lEY58zJmTP3QDnHVHwQnCsuaSdn74mFuCX3Wtrp3TDO2rsgDkQV76q7Wbt3w7x5a9VdhJd5kTyPDAAVYUndYhHXnQAAAABJRU5ErkJggg=="
            } },
            {0x015F,
                new Items.Item()
            {
                Name = "Secret Key",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAKlBMVEX////4+Ojo8OjI0Mi4wCiYoJj4cHCQkDDgWFhwcHBwaBDASEhYWFgwMDBGTS8aAAAADnRSTlMA/////////////////1dK2xQAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAJhJREFUeJxjYMAPOOfevQBnT0tLy4TxJncIdnTshUpodwDBVogUr3a39O4dm2MhqnR27N7dfRjCuap0uqNjj/FcCGeS0pkzxjYQzqyVQUrKxkchnItSKycpxYSCTeMVdJFaGmoK0X9RxHGJpLMlXMJx7Z0JcAkpqMPYwRJQR/IiSTDwIkkw8CJJMPAWroJLMDDcvUsgTEAAANqVOF/AOlFJAAAAAElFTkSuQmCC"
            } },
            {0x0160,
                new Items.Item()
            {
                Name = "Bike Voucher",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////g6Ojo6FDIyDCwuLjomJiYoKComJhQWFgwMDBaOPeYAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAcklEQVR4nGNgoADMRGYbT0BiC8I5M40EBSUR4okwDpAtqCgIUQdkh4qKQTgg8dBAIbAmTmPBxkZBwcBEYUsgR1BcsKRFVFDZEqRsonh7mYSgMJjNMFEkRaQFymbglICLAzkIcZA6JDbDZCQ2AycSmygAAMZyG2lj4YTgAAAAAElFTkSuQmCC"
            } },
            {0x0161,
                new Items.Item()
            {
                Name = "Gold Teeth",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////g4Dj4uLjAwDiQkAjYaGh4eAC4WFiQMDAwMDCwAg2zAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAqElEQVR4nH2PwQqDMAyGe1J6LLgXCBTZcUzwXOgLKJTicY8wR0l9C9ml9G3XREVPS09fkn7hF+JfyXyBL6znANr1MnAEkjuzdhP17rzlHOScYIcRAGaYtv8FPOiFYIQWEbRn4C3tkGxVcFQ+krnqifw78jHVI+JHRbLVr4cqrwkkqBtToDPItqGz1hq1A6/dWC3CUODJN4VIrF62TDIV9XLkkznnM+tRP7a3MNzGjngsAAAAAElFTkSuQmCC"
            } },
            {0x0162,
                new Items.Item()
            {
                Name = "Old Amber",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////4+Pj4+Gjw8LDowID4wDDwsADgkADAeACwcACYUAAwMDBHWzvlAAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACqSURBVHicY2AgAXDv3r0Bzt7V0dm9AcYuLy2f2Q3h7FpemqRWOQMsxb28VEnIPBPC2VUeJKgcWglWx91eqihklhoO5QQpKVdCOTvKg4wtXVLToRxVs8pVoemzqkGc0tTQaUtDK7pAnG2lbaGhoeEdK0BGb2tvSw8NrehYDuJs76hICw/rqKwGOyCjvay8o306xDUV5SBQDXHn9oy0jI5qmA+2d8DZqP7EAQCMOUazZscPegAAAABJRU5ErkJggg=="
            } },
            {0x0163,
                new Items.Item()
            {
                Name = "Card Key",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////g8PDY4OC4wMDwmJiYoKDgaGiIeFhYSEgwMDBqfTJgAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAdUlEQVR4nGNgIBdwTkDiTNJE8DiVOjrhvIni5YKSUB6nYHmhI4wHlBBxETT0hOpoSkoyUtOE6RARFHScAJVIg0lMtehQU1NWSgJLGJcXijgaikiCtWsAJZQgEgwMM5vUYDpAPCVlmASYB5cA8ZKQvTCTJN8DACoNHuaugrT1AAAAAElFTkSuQmCC"
            } },
            {0x0164,
                new Items.Item()
            {
                Name = "Lift Key",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////4+PigoKCYmJjQWFhoaGigWFhIQEgwMDDmB8e7AAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACFSURBVHicY2AgBXR0dCDYoaGhMB5HaJhLamgDhNMamuKakhoBl3ALcYVwmkND3FxcoDLNxqGpLqGhUE67cWhKaGgFRI9guXFoaDiE0yikCOSVN0AklEQVi83hEkGizeYIiQgOiGsYQRJQpzA0giRgLm5CkmBoQpJgaBUNhUswcHQg2DgBAIXbJLxh2+kPAAAAAElFTkSuQmCC"
            } },
            {0x0165,
                new Items.Item()
            {
                Name = "Helix Fossil",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////o2JDYuGjAmDi4kCigeAB4UABoQAAwMDBAMADz8V/kAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAv0lEQVR4nH2POw+CMBSFGTv7D7wQmIVAnE1BmOUho7VpmAm0uhECpLNGf6+UR9i80/lyTnLP0bT/J6Xc9MHTi0UjB4yT08z6Bt6Z25OF2hcYHEiooDfB8UpCTJXrAxuMku08BW00OmTv5jPoAJmbVFcVi2zQn6L2jyN0PrHqyzdOlTPgd52Jj39/qBjNM1EnmKuvKI2UtvAEMU0SHPBwKtdRjHEVzEWHFBsWWwBRLhhb13UxC9Zto1XIZpu9ye1+1so3XTxZbPMAAAAASUVORK5CYII="
            } },
            {0x0166,
                new Items.Item()
            {
                Name = "Dome Fossil",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////o2JDYuGjAmDi4kCigeAB4UABoQAAwMDBAMADz8V/kAAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAwklEQVR4nG3QPQ+CMBAGYDdx5Sdco8TREki6t1FXTFFWYimufsBKjGJHo4bEf2tbUWP0pvfJ3XB3nc5v3c+f3ODBWw0AGra5h1yAfttaj0BjavMJYw1k4SR6CACHZs7xAvxGl61mASAIJhrH8cZFHBAxODDiovnVv+UWl5QHib9dGNBwuLuK0jOdPUvDiPBIGpwYF4TyMq406u2KUiolt8jo0isKoew6QhZSZOq59DEWMc/bc5yax6p6Heoo9ectX/UAqwUydDpJDxEAAAAASUVORK5CYII="
            } },
            {0x0167,
                new Items.Item()
            {
                Name = "Silph Scope",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB9kIDgQRG/f/mZUAAAIMSURBVEjH1VY9a9tAGH4UTH6AQpd2cgqdjMBDyBK4pbrGZNIUgQZ1KhQtNvVS/wBPKmQxAe8ePHWUkTt2KRoERjJJIGRKNt9+Wq5De4e+00Az5OBAnJ73fd6PR+9J4xnHc649PPN6+QSdp4CpSUX5LFyH2n/JgJpU+HMfztABAOg9HXpPryV9MgE1qQjXIeJtjMXFAuE61FjC/ikw7TGZUpOK6YEOAJjs2p3WlauRQKY+PdBx9GUMAIi++ZjsGPSeXmsjs8oT7TU5d4YO9N4f5zxNwdMUAODPfbCEVbbsizN0Cn3pNDkPfgRgCQNPU2xWQV05ynYAgACBIgnXoQaecbUJIWL+fS4szxKEEBFdR4JnvLKj60hYnlX7TvoghAie8WoGMvKmOm/uNgCAwfsB7JGNspqkjCslkjo3ugYAwB7ZiLdxLUm8jeGeuXDP3MK5PbJVkBUV5eUIAMbpAFekrwjzGWRfp4Uz43SA/Y+uImEJU0rq5J3PDs+VkbdaIn3110GOZPxpjDdHnwsE3moJA8AV6TfPotnhObonx+rFDMD9xSUwRK3zD66Fm9sHhfVWS+yTfiH6ynfw7u1r9ZwnK6/uyTFubh8UXmLrelZQkYyorKqmVcbLOdVIcPfzVyVyljAskgUew012rH0WUZOKfPPuo8tagzKuDVsZdvkZ0naRlO+ANqz24v8qfgO970IbjD96PwAAAABJRU5ErkJggg=="
            } },
            {0x0168,
                new Items.Item()
            {
                Name = "Bicycle",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////w8PDwqKiouKjAsECwYGBgYGBwQEAwMDA3GuIEAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACtSURBVHicXY47DsIwEERTWe7TcA8E8gEocoEoLi0hrK1BIS5XGG/m2MQfxGeb0dPuzGzX/YyWLxADVngDLlZ7btBfLUQqEkLsj0C7fFjgA1PoNFWXwjoGaQm6txiXQK7E0YORAnK5JiTu0iwoFg/oabH5zsshrljCPGwZFM0ON6I1B9IZhiWm6Z6BjGGYtnF4cgTr4nEKTu+Jhi2NJAtwqj1FqHyg0KT85qv8zwvCr0rgFXe/YAAAAABJRU5ErkJggg=="
            } },
            {0x0169,
                new Items.Item()
            {
                Name = "Town Map",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////o8Pjw4CjI2OjAsCiYoLjoiCiQgJiAeCiQYChYUEgwMDAzZGfuAAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACSSURBVHicY2AgDexGZgtuQLADha1hbG4lzWJjmNQmpSnuxlAp7rTMKS7F0RDOttk7Z7q4Q5RxZ+7euXKKC4SzLXv3ypUzPTZAdGTtmjVz5myoUTNnrpw5cwPUDpdVMIktLjNcPGEShYIWLS5QCW7hUOMOF0+oW7aGBlu0eMMcGRpq3AJ3/9bQcITPuHcj+xI7AADelTN3qrpnWQAAAABJRU5ErkJggg=="
            } },
            {0x016A,
                new Items.Item()
            {
                Name = "VS Seeker",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXZwQWcAAAAgAAAAIACH+pydAAAA6klEQVRIx+2Vuw2DQBBEKelKcOjQoUsgdAkugdChS6AEQpdASEgJl501lgYty93uWYKMYIT4vTcHi2jeY9scmeYU7Cq43tsUQliym4DgGGPqhyFhn/FkLpxgDR/neSP6W/Brd+vS5TmtgmMEQwp59+qzEhOuwVpCuIyWmM2Z5Wa1GnlOPkYpKTZ/fOIKgGfuCXBNlQBwADTcEwBuCmR7bAGWzaWk1L5aQEnu5VpwPU3FqclJNJwrJFy33whyk2K1tpoXBZTkxlSCCSfY/ZJxAW7Sc62hjAcuCrzUgotT5EFrweaHlsv5yzwsX9kAE3uG8GAxAAAAAElFTkSuQmCC"
            } },
            {0x016B,
                new Items.Item()
            {
                Name = "Fame Checker",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAHlBMVEX////Q8PDAwMhwyLj4qEBgmJDoeChgaGBISDgwMDDwa4d0AAAACnRSTlMA////////////fokUVgAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAiklEQVR4nJ3PsQ4CIQyA4a6MNYTElcHkZl/hXuFyMxdTeQEpPoDnjXgbbyslgrMyff/QlAL8/3JOX1s7tMqnC7p7M43OHD/eSGvtUrXnFccaqniOTpPE7nmaeSVaEijjb2fmSHSQoEeJjXAoIybESWzr/DU8xVm2vELwzbAjdYOy2F1/3C23/Hb7Gw/JLWg2UHSEAAAAAElFTkSuQmCC"
            } },
            {0x016C,
                new Items.Item()
            {
                Name = "TM Case",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////I4PDw4CiwyOjguCiwkCh4kIBQkMBYcGBQYHhoYCgwMDC2WW3qAAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAACkSURBVHicY2AgH+zevQHBdnHShvF2OympKEVD2aFKSkoh3hC2klKokourywawehcllRDX0BAgh9sFCJRcQ12WAjlbQJwQVxcIx3PmFKCGkCggh9tlenklkBPVsRqoZUmhYPkUl5CILpD+TGFj8SkuoRG7GUAcYzAnGmQLd6exsTmQA3HZtsXGq2a5roY4bFfWqrS01VAnc+9IS+uGe4Yb2WM4AADMsjm4Edg2oAAAAABJRU5ErkJggg=="
            } },
            {0x016D,
                new Items.Item()
            {
                Name = "Berry Pouch",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////w8PDw6Ijo0FD4yDjgqDjAqFComEDYcDiIaDg4YABYUDgwMDDaxm2rAAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAw0lEQVR4nH3PMQrCQBAFUA8wjeQGAQ+gA2vEY0jA3kJQGxsXJZ2FE0iXIg7JEey0SLpAICmcQ5nd1ZRO9R87w/JHo38jUg8ZAirkh4YoZvmyKYk5vzu1y6oHxfYQcM9cElkILpkr9wJJqvIncmYgt1QhKh2ZrbpZnPqsC7MFM3+utY7sCfjhCs/8SgzaSbhGxNIh8OmKeHibvXZKQY+dtkcOF4ejpzaoLhGYj7rxGHGrHxbQeX0+C7iqkpn86y4y9B7mAwpHT1Z1wCFpAAAAAElFTkSuQmCC"
            } },
            {0x016E,
                new Items.Item()
            {
                Name = "Teachy TV",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAMFBMVEX////w8Oj44Ej4yEjQyKhwyLjYsEjIoEhgmJCYiHCQgEhwcHBgaGBQYGBISDgwMDBlI/uPAAAAEHRSTlMA////////////////////wFCLQwAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAz0lEQVR4nGNgwAD8/z8gOF9D4+Fc/o67rUAuhPOj9+7du60RYDn+/s+FtnfvPgVz/n9SLjc0v/sCxOH/pKRkXl5sDOLwf1IvNwYCuw4g55eSkjFQ3LwOxPleXmZsbF5e/qIfqOX7m+NAblVdB5jzoufM8eW191pAhn1/GtFx5vmSeR1Qzpkzr7ynvGOAKgNyvO+DOW/OgDg7we78VQ7kPF85fz7YmavKy888r/0JcbOL16ry5evnQ3zzf4qL1/qfMI/+/+/iOR8RBv+RAwQKAKf3cEvnJev7AAAAAElFTkSuQmCC"
            } },
            {0x016F,
                new Items.Item()
            {
                Name = "Tri-Pass",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAEXRFWHRTb2Z0d2FyZQBKVEwtRGV2J4CxQ84AAAAGYktHRP//AAD//2nFxcAAAAAJcEhZcwAAHsIAAB7CAW7QdT4AAAElSURBVHic5ZWvkoMwEMY/UMjISGQkogKJpG/QR+kjRFb2EfoGh0QiTiCRdRcZGXEzd5Nw6VEIuaVzVc3MTsiffr/sbjZNPvGBZ7YUT24vCNgV+y9r1P2bkmyFy0vnvrtD6fr3/i35F4AXV+045hVIIBLAixu9XMtYHPQnYH5yZWrXay4g9Om2b82jKGB+cnWt79Z53kQ9spCUcnLdj5bpBlrB2RXiNj81u7+XbTxE87BsaaprYfrjeohCMZ/G2+cglIe5+KLQpjFnBWBYDcaBHIMbD0K6sTdw7uathcTvPAhdxVBSOyOR/7jnkzycw+ILQFbI8Ydl9QtZuZaxsKzWgX9jQiBKQsmVTAFRxEmFFgJRxTe9RVMQVfyh55ryRD8MeM3/5G/J4e/tcrXySwAAAABJRU5ErkJggg=="
            } },
            {0x0170,
                new Items.Item()
            {
                Name = "Rainbow Pass",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////4+MD48FiI4Pj4uKBgyPjomGBIkPhIcMhAULAwMDDOf+2FAAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAH1JREFUeJxjYCAXcC1A4iy2QvC4zIsRvMWhocEwHpd5WVpaMpS3uCxNSQnIA0uYugiKBwq6zAJLlCdpdHQ0aS6A6EiqaC/vgEiEhjiWh4ZGgiVMIRywBNfM8rIkjfZKiMGrZpanKUF0gHllSZpw16yamQaTAPOQvbCKJN8DAB/KKq4t6xGxAAAAAElFTkSuQmCC"
            } },
            {0x0171,
                new Items.Item()
            {
                Name = "Tea",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJFBMVEX////I+Jjw4Njo4OCA+CCQ4BjIuKjAsJiwqJiAcGhgUEAwMDDNNu8sAAAADHRSTlMA//////////////8JxFAmAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAAChSURBVHicfY8hDgIxEEWrW7VXwBFkxW7QK7hAr7ABjUPSZNNaSMp8FAZB12yC216OJp2iCF/Ny8yb5AvxNzKlR53VVa/WM8P7FHHb8GIbQe4yMzxNszsztKbpe8tgW2OOXQFJVuvOl+fSk3M+FFB7gEDshEMmzw6GId+xg0COqjMipzo0AI4dhTE7YHjlBe7cYYlAnGq5JcaplhMqpe/8Ox8FoEPjjfZBSAAAAABJRU5ErkJggg=="
            } },
            {0x0172,
                new Items.Item()
            {
                Name = "MysticTicket",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAG1BMVEX////4+Piw2OjgoNh4kKi4cMCISKhwSGAwMDAYBeQdAAAACXRSTlMA//////////83ApvUAAAACXBIWXMAAArwAAAK8AFCrDSYAAAAIHRFWHRTb2Z0d2FyZQBNYWNyb21lZGlhIEZpcmV3b3JrcyBNWLuRKiQAAAB0SURBVHicpYwxCoAwDEUzdhXxApncxRt4AZHGveLHWTyAiyXHtlWLHQX/9B68hOjHNGfeM35FwVwnnmRNopjFPZ3O1mK8RWHLVsBd6AwwFIVg4ySlwNUx8+ijLNe9F9tUcnPowreHyUypiTvkZfIZk8n4007iyyLPYqOktAAAAABJRU5ErkJggg=="
            } },
            {0x0173,
                new Items.Item()
            {
                Name = "AuroraTicket",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAHlBMVEUAAAAxMTE5OVI5e705nN5Czu9aSqVj7/d7lK3v73sgSHd0AAAAAXRSTlMAQObYZgAAAHxJREFUeF5joAQIIrNnCiCxERzB0pkzJ8LY5aWZMI5gaHl5JFAdhB0aXh4G4QiauLqElpfM7ACqY3Q2dglxDS/PmAniuJiluaS5hkdOBCkTSQOClFBDIBvESVJSS0uE2MkI5CgpAtkQDoQNAWJKSiA2BAhB1EAAI5BNEgAAY+cfFpz8y3wAAAAASUVORK5CYII="
            } },
            {0x0174,
                new Items.Item()
            {
                Name = "Powder Jar",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAIVBMVEX////46Ehw8HDgyDj4sDDQqDBIuFCIgDCAYDBgSDAwMDBiyS58AAAAC3RSTlMA/////////////312fdUAAAAJcEhZcwAACvAAAArwAUKsNJgAAAAgdEVYdFNvZnR3YXJlAE1hY3JvbWVkaWEgRmlyZXdvcmtzIE1Yu5EqJAAAAIpJREFUeJxjYMALuFatWgDnLFJS0oJzlikpZSE4aWlwDueMtLTOCVDO8sqZM6dXQc0qFS0vDw6HmMdVLGhsLGgO5ZQaCgoLwmRKQ4EAwXFxQXBCXFxcERzXEAQnNFAUoSxQNFAUISMoGIrd6IqOjnYYZ3rnzJkzKqF+XVkOBLNgHpq1atUqmH/gAADNmTUKuJutoAAAAABJRU5ErkJggg=="
            } },
            {0x0175,
                new Items.Item()
            {
                Name = "Ruby",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////46Oj42Nj40ND4yMj4wMDgmJjYeHjAUFigSFCIQFB4MEAwMDA9T9MyAAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAn0lEQVR4nGNgIAGcAQIYm0c0NDT8AJRzEMSpgUoIgjjlEKmDgsLGLh4dPRAJQWVjlwgI56CgkJKxaySYA5RQUlIOjZzZA5VQUgJy5gA5x9JKjJSUjS1hHBclY+Pdu/eAOOklzibO1rt3H4BwjE1cVoMlGI6VFxubeK0CSzCcnNm1auasVWsgLpsB5kAdfaJr5cxZa2C+AXFgvkHxJw4AAKUlQSJeyCkbAAAAAElFTkSuQmCC"
            } },
            {0x0176,
                new Items.Item()
            {
                Name = "Sapphire",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYBAMAAAASWSDLAAAAA3NCSVQICAjb4U/gAAAAJ1BMVEX////o6PjY2PjQ0PjIyPjAwPiYmOB4eNhYUMBQSKBQQIhAMHgwMDBEayIZAAAADXRSTlMA////////////////LQRBrQAAAAlwSFlzAAAK8AAACvABQqw0mAAAACB0RVh0U29mdHdhcmUATWFjcm9tZWRpYSBGaXJld29ya3MgTVi7kSokAAAAn0lEQVR4nGNgIAGcAQIYm0c0NDT8AJRzEMSpgUoIgjjlEKmDgsLGLh4dPRAJQWVjlwgI56CgkJKxaySYA5RQUlIOjZzZA5VQUgJy5gA5x9JKjJSUjS1hHBclY+Pdu/eAOOklzibO1rt3H4BwjE1cVoMlGI6VFxubeK0CSzCcnNm1auasVWsgLpsB5kAdfaJr5cxZa2C+AXFgvkHxJw4AAKUlQSJeyCkbAAAAAElFTkSuQmCC"
            } },
            {0x0177,
                new Items.Item()
            {
                Name = "Magma EmbleM",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAABh0RVh0U29mdHdhcmUAUGFpbnQuTkVUIHYzLjM2qefiJQAAATVJREFUSEvtlTESgyAQRS1zHMscISXHSJnSMkfIEXIEjpIjpLRMSUf4C6sLAqJWmUlmdnQY/W/3Cz9d9/8ddWAY7vaiVLF260MYZV7KGmOS0vajFRXDN4FmYe2ESxWgaMAVQE2QnPj4UPZ984X7GOpArZDYEk1iEGUBvsKaGNQIIUCwhARCZ6VrBAnP9n2ftyq1hjtPQQuw/EY1q2T3sIC7fp7OdC+vEiKn4O+UnaJkD4TTOgyQ9uQAWIusCjY1T8AAKc428dpmAA6K3EEQYDG5iyR0grRMQIDx6iHho9YmmGziXeTexeRYr2/VDefA55SPklVx5Eg0hXtp9bBRCDqA656nLXbPQZVCKEnTEz2lqxdv6l4mYRYSRXZI2D3icpIlaI5u2fWqLbUcBwQCpWr6D/jph770ZnWmfCxCRAAAAABJRU5ErkJggg=="
            } },
            {0x0178,
                new Items.Item()
            {
                Name = "Old Sea Map",
                Pocket = 0x0002,
                Description = "",
                img = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAABh0RVh0U29mdHdhcmUAUGFpbnQuTkVUIHYzLjM2qefiJQAAAUpJREFUSEu9lrGtAkEMRCnpQsogpARCwl8C4S+BEq4EQkJCuuFrTv+hwdi7ixAgWSvuvDNe2+O91epbv2mabrJRvv12vfi7lXvlNP/umgQRUP6yy3xYjP1pkHp4PR8fnGJ0ALLKP1oZJASKMgJVgETO6gE+pUoEcmStooug/r9LoEjlVJ2iBa53XQIBy4mCe6oq8Hm7uRcZAu0TVpqmVwgEjr1UhyxNAJx+9jdsaU2RWLt200QdPE0xPQ8E/+DogeBKLcQ6ZOB6JhIXGASIMVW0WOVAR9BNnp6s2K5maliOHNcBaeoRDGtBx4pC0yk8529pAQIvGIQ94KE2zQi8ZbOiZvOo26oU16cpp4qDMDvZEAEdJTIsm7JxKHZnEmlqATtodUc0L68YPeoG2EHjpeQToHn9sjFLj7/LFDt0R7MxRpiO4dGvhE/5/QFMxvKklzSBbwAAAABJRU5ErkJggg=="
            } },

        };
        public static readonly Dictionary<int, Items.Pokemon> Species = new Dictionary<int, Items.Pokemon>()
        {

            {000,
            new Items.Pokemon()
            {
                Name = "??????????",
                img = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAADqSURBVFhH7ZHBCcJAFERTjmWYNjzmZEkePVqCl/SUDiIj/8mwrKLuGhD+wLDJT/7MCxlSqVQqleqlcRxXHKPtpNJl2T28GYR/9fW8v5fr/DmAl07ToXryTqy0yYMo9jK/9pncDKEA/iuuFdVgcBMEAJhAQOSysJx1BQCC4LIMdwHwcgV5Odd6B/NMBqCpnFAgXtkBVO77OiP2fXmAF9WAvMj3sO4j9n1pqSyinBKflwZinufvARRACdb8eDmtCAD+uZ84Ij9XDcIBynLcVFqKr/ACd+1ZVwAEyDNLKpd0H2vbyWFilPoHDcMN89c9lSIYqywAAAAASUVORK5CYII=",
            } },
{001,
            new Items.Pokemon()
            {
                Name = "Bulbasaur",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHfSURBVFhHzZRLVsJAEEXZUhIc6EwcOUxkBXCY4EydEHYgrsDPCtQNiDsQXYW7IFr2C6di0z4+AeHU4J4Or0NyU13dDRExDQ0tQUNL0NASNLQEDS1BQ0vQ0BI0tAQNLUHD/yBpHrhBGnHSLMdNoeG2QG7wNpA4iasxvGddaLgNkIuiSPqPqeTvuZw/ZxLFkZvi96+Chpvgi7UuD0v6T7NrjJDEfPi/VdCwLugziKFaoZiOOle3mjRchW4AALn0OnUSv3K+KLuuI0nDZfgbAEuWpqlko9mL09FfUUWz7KZeT9JwGSo4/BiWdO+7kp1lkmUOJwqBRYL4gL0KQg4vBp27zkzUqyZklL0IhtVrXR1VgvlkMF9Nr6K+4E43CQQ7t53yfFPJRWg1K7nMye3ymIHcy+mxnFzMqqUiqFooDDl8iF9N/K5bPUBDBo4Tf3kBlhiyENEdnU/yUjpEW2HnSxxK6nEznU7dLSK9h14lpZXcq2DYgxD8dEv/XRRzciqE3lNJsFNBAElUzH+pj1YtFBy/jiVJEvcI/txF0HAdVDQkFNf+BOEz1oGGmwJp9CKWuvgqpN1ubyym0HAbwsqG83WhoSVoaAkaWoKGlqChJWhoCRpagoaWoKElaGgJGtpBGj8hieNJEXIVlgAAAABJRU5ErkJggg==",
            } },
{002,
            new Items.Pokemon()
            {
                Name = "Ivysaur",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJISURBVFhHzZU9dtNAFEazFWAF8t+xShs2IJkmlAkNcmgIK0hCFaoADQeqAE1gA5HFavhZhB0e88l+Yhg+gUe4eMU9lq+Ppes3Y2lPRExDpSWotASVlqDSElRagkpLUGkJKi1BpSWo7MpoNJIkSWrCz7pCZRcQ93o8ka8HhXw/nEt/R5FUxoK462xfvrm4t+l0p5FUxoLALy6qyh/IGy/wfp43S9512ancFt1zbHqIBTMXmZ87nrvYXnwklX9jOBy6l/XruBhLlmdS5vvN9BYuVuOawM0k9RwxUNkGJlZcX0o+mzVTSedpExkG6vSKj+vpdYmksg0NnFfv15He8uFYJ6lTS4u0/gGguMpk/il+malsww8E05dnks3WMT7FlYs7+hWFYw2NnSKVjDDu9tOHcuv4sGHy4vT32M3ShqE4jpkilQwETi5OpFi8+yMScb4H+Waf1nv0PGuWGZExU6QyBHG4ldx5ciCPyss6DK9+kNK27NiPCI293VAZooFHQRRi/Mn5cdOL0/q94kfvfIK45/n7D+gUc7eUuKB+HkYh1N+n8Emv507LrxVCJSP8k4Ck36vjlsulPP78oQnzg+ppbnxsHKCSEf5JEIfnLx5rP1YruffqGQ3ED6iqSu46Xy4W0u/33en4NRhUtoFIXBCh/lQUXVJ9r9PCFsH3gJ5rW6j8FxqaZe4RV5b1VFh47HIyqNwWDdVj7EUs9ermRgaDQe3/Fyq7osFdlrINKi1BpSWotASVlqDSElRagkpLUGkJKi1BpR1k7yeMts5ER2VEgQAAAABJRU5ErkJggg==",
            } },
{003,
            new Items.Pokemon()
            {
                Name = "Venusaur",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAL/SURBVFhHzZa9ehJBFIbj5cTKBUkfYhNshE2TlLFy0SJg40/lzw0QvAJ+LkBMA9HKxytJnlwExON8Ez44TA6wEIsp3md3vx123j1ndpIdEYkaM4wJM4wJM4wJM4wJM4wJM4wJM4wJM9yGvb09SZLEE14z2wYz3IRSqeQFrrIz+Tvoilz05GmxsHB987opxaSwlagZ5gVVGn/vzCRu6k05qtWkNuUqa/gMaPnwOaswwzxADlWiQL9ckbRalcnvRyJ/3BDHUfpCOi7vTbl2wqhk+KxVmGEeKAgxTm5VEPdxDxXsHzz3YwsbtNoMLcKPgFm41lhRVpXimk2qaIYaih2eHUqlWfEkhTtR3WKiZSF4O1hcowBVzvvBmCGBnBbTVGvVWRshBQHKAbQTaxJjJkoScpXG/EXDOUPMUENJCvHhWpJQ9ihN/XXLjU2DMfg9O5CnimYYgr0uG3bk8ce6k5pP1hgcy8v2iUcLQ6ztril32jqWWnrX1rytJWYYgipCsP6z5yZKvVjzwkm9rfhzHE/P3dGoLOT4EqDx40QKxXkF1wmbYQgFtRwnwzlAhSDEJQBJylE8/C1fEMLhnMQMNVb1dOVwhFy59VmqU0ldPYrjXEvllbwXaLQcgSQmpCDbmY3m48rtLx4IQ5znGIcK65fjUln2Rd8LCOXw8OyyO5tcS4ZiAOOv1H5HQRKKQnCrFq8S1DKEY66nG7Ilp4Ho1h8J5Kpuk8UEy+Sw5bwadSVx/51gEr6MFtDtxbnOQFJY/yfPDLHv7b7L/J4XtlALPnHrxv8tnkzk2bevs4lD/rsgKkjB3feZr1QoiMqNx2M3XOTNr74ptPuhLvvn8yqORiM5cOejy0spFov4qTm/xgwBJIfDoaTug8BkaDXbSkktRcIqAYii2lxz69adxgwJJPVD91ufFibWoF16jK4e74fPz4MZLiMU1vA+qo42UuwhcsAMHwIksTbx0Uxub/0xKkEQVjq8vwlmGBNmGBNmGBNmGBNmGBNmGBNmGBNmGA+y8w82JFfutJTsdAAAAABJRU5ErkJggg==",
            } },
{004,
            new Items.Pokemon()
            {
                Name = "Charmander",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHiSURBVFhHzZVLTgJBEIY5hzdgBziwB7zAPE4AehH1BOrKeAMCBxjjKYxsSFyZeABeC9CyazI1aTs/80JMLb5IvulJf9b0QIOIVAOlJqDUBJSagFITUGoCSk1AqQkoNQGlJqA8Bb1ez/zB1/KAsgy8YbvdTnCvufDa11GfzkusdYEyDwlb3jVp+9Ck+bh4YwmcjweVI6E8BG8kYTZFkf8W2O12YSDjdVpmCb5H4jb35SZuAyUCTY83403lM9pYppfcs+Z1g1LnVoAS4QZy0Pd+T57nZR5NUQI3K7Nma+67OsEE0fRmYZ/ORiNqmc34Wt6jS+5fVo9joHRBgQxPjB9X0QsgU6wax0CJyB5VeuYYnhqH2aAI+QcPvUh5QHkI3sieGMINtKd/8kBBQhfxNc0vh0lYFPgm/HekPfU6cQyUZUi+Ez8eafv5RFEU0iQY0Dp9WSTSnnSd88dAWYbk0VmBqzTOnqR8rhvHQFkET2/i92nKU7MigyDI4iSwypcyAsoiODCOY5qGQwpNxOL5ht5fbrPzyHB858g4BsoyyIsi+L6fnMM3M8G/imOgrAMH73Y7mkUX9JX+BLpr6gBlXeyputfqAqUmoNQElJqAUhNQagJKTUCpCSg1AaUmoNQElHqgxg+vmRRrkkfLHQAAAABJRU5ErkJggg==",
            } },
{005,
            new Items.Pokemon()
            {
                Name = "Charmeleon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHgSURBVFhHzZNNTsJAGIY5hldwiQKJS9iBK6o3YCfxBF7FnT83cMkJNCy5CGqXn30LbzMZ3kKn1OQzedLpMyV9nJn2zMw1UnpCSk9I6QkpPSGlJ6T0hJSekLJLhsNhcdFzTZCyK0ajkW0fpjbo94tb/cwppEwFIX0R4SIQW/g5HdtvFMK4/HVi+bJ9pJRNqSKWM1vPJnatAr8vLX/cPdMmUspTYDsB49TLy8CXseU/ReB7cW25ilIeA2GMIvfZvP4MbneBg6v0OCBlHSqOxFsMuIrr28O5pkhZx7FAoLYQHxGOgvoHmiClIozDyziOvYoIP6bUcyhlTLxyb5Ob8nqxWBTTVo4RB7IsOziPYSBIiZQyRm1tEFLFAc4jIgxtu4pSKhgZRvAeIDiOxJhbzkA+0/Q8SlkHIsMQjMnm46lycfzdfG5f+zHpPBBxOHuAUXDlym6eS+JIXHkfBqZ8zVLGIGK1WlWBAI5zDASMIiryXwIRhUiMwziuKFYvjmNYeOVvmyKlIgwLHVcUAfhTcRynxgEpm4IXhluPexUH2sQBKVPAiwnv4zjG8zcpSHkuiOGqnhMHpDyXfVAZxw8Lvg1SdgGiSDyXgpSekNITUnpCSk9I6QkpPSGlJ6T0hJR+sN4fBQTWhPZwiykAAAAASUVORK5CYII=",
            } },
{006,
            new Items.Pokemon()
            {
                Name = "Charizard",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKZSURBVFhH7ZQ7bttAFEW9HbkK9YNdSqU7Sk5hIZWVKuniJcQriJ2N2HCpVShQNpAgC8hHRYC8zKV06cfhpSPJEjBFBByQvDOcd/iG4pGZJY0MU0KGKSHDlJBhSsgwJWR4aPr9vmVZFk71uEeGhwRyvy9OrPtfcAcoZ5PTgk0kZXgoer1eIbi8admfyUr0X5IyPBRlB7+0zF6lLvhtM0kZKnodvQiK4pPhPxvMeO3B2PcPYYu/Pko+WxDFlretWlEUuxuc2MPwtKATxjEHApjfbb+Q9/guLj+u5vk5HhnGoHvL2+NalyByPs7tfi1IxnluP9aSStR3sdtplgMy9GBhFPk0HZZFcPz8emi/wr+RxX0nlWQsSsmnugdk6Fl1r2XtdjtcVjMWK7LwCfGSFESH55erh/GieRhHvggPjleD68TIkECAi45Go0KI2c+b6pYDSnq57M2FZW8nNg8ikKEoxfcmCLAYz1+OH4U5H9uGznBrvaCXpOgmkrWAxHJVjstCAHO74RXwc1j8fJTb2ft3dnZ9JUUxjnnPFsRiOOLHxWP8fLKYDgoJvCJelJIUxLmSrFx4IMiieOlxXG9nkaMgwDnBHGSUA34b2c0sdBtrzS8HZd7UxcoF8d1jcWR4cl5DBOLlgyyuSiivJL0E3llIbiXo5WKUXHmPE/SivDeWxD2Uw7ydBLm1AAtjjHKx4OJhWpOjIM8p6N87ouRALQBFwXCTF/Mys9msEMSRcyFASS9HQa5FYsmtBAGlKNY0BnxhyOAXyxHO84JNckCG26IkKdok6B8QazQhw13wBQG2G3KQieWe6liMDPdBKbqW8iQhSCCJH8T4p0K+KTLcN+zmtnJAhikhw5SQYUrIMCVkmBIyTAkZpoMd/QWHAl2oF2RiywAAAABJRU5ErkJggg==",
            } },
{007,
            new Items.Pokemon()
            {
                Name = "Squirtle",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIISURBVFhHzZRLUsJAEIa5ikuqXBgClBwjk2z0CFAuAE8BeAHBE1ieAF352Gi50SNQegBQFkK102MmhuEnPBTtxVcF/0wyX/V0J0dEooGhJGAoCRhKAoaSgKEkYCgJGEoChpKAoSRgKAkYZlEul8nzvAR3HZF+xl1bBgwXwQcFp6fUuH2j5t3YUPCLmQfzM/Xr4cx+d08WMES4B6VRvTPyCoU50VKpNPMM71O9ntmb3pcFDBFZgowKI+pXd8j39hLRtKCRC0OqNKpacPWrhqGLWwl7YPqqrcBTO09XtS9R2w52Ten/W6mgW73K8RF9TCZULBbnKtRWeXqOJUMVJFJWcB05BoYuriDL2J7j3MjFEhMtfhLtGsnIEdzqFKNpbAX5GYF+v0/T6TQRTFdx3cpZYLgIlgyCVFUs8fW5kpd6aP5eMBZRShkezg/o/aVNUaSocTPSa1FyzR3dj0oLbnK1FhhmwZJ84HDQovFrx2Dlkh7VkjwsXEGeZvcd6wDDVWDRe129x4tDCsNvwfQ0/5sgfxf361UK9BWPBu2kirYP+eq5F33f19vxO1YFhsvg6rFgpVnTze/NVNL0Ziz6k96zwHAVbC/a3zzdZkjib+KmU+sCw00wkrpyXNWg25UnyNiq/sbVWmAoCRhKAoaSgKEkYCgJGEoChpKAoSRgKAkYSgKGkoChHCj3CRZAJTkCE32gAAAAAElFTkSuQmCC",
            } },
{008,
            new Items.Pokemon()
            {
                Name = "Wartortle",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKtSURBVFhHzZbLchJBFIbzOpYuZEYoLVdeNkY3M8PGy4rgxssDmOjKpVlh3FhxhfEBGPMEWm4gbLR8glh5AKiwYPTYf1OHtJ0fMmCo6sVXwE+T83FOd5M1EQkaGoYEDUOChiFBw5CgYUjQMCRoGBI0DAkazqJWq5kH/t6qoCGjWq3K98OBxPEV85KvWQU0ZKB7ZQWxtlKpmKf8/UWgoQ8Ktr90pfmyLz9+Hc+UVLHz7DQNfcoIaod/Ho1k71tfojima/AFFukuDX1UEIWzLJsW0UKu3LtPI4mi+V8AlO0wDRkokCSJtNpD2dkbWTa2+pZKFNvi6HD76+nu+XKLSNLQBwUaL7ry9uPxVE7JsropPpzKaYf9z6tgvT5ZP2sb+NDQBwVa7cEpOSboF9brSbum2yRN01J7kYYuKDBLDnvtxv33kqSZketNi+ev1yWOJsVdQXQPYlhbpnuAhi5+97DnMGrIdTodufVwVxqbB6bwpCtP1i8YwTuyvXFNItMh93Ch02X3nkJDH1cSgjcf7JrxRDIej83bIo9f9a1gURT29fN7l6xklib/dHalgv4h2W5el9/FWG4/+mCFMWZ0EJIqiC6mjiQoO1qFhi4qh6sEj5DBSPWK0dHq9YNDo5JPzbhTczWtXBB7rbl1YCVxF0JI6eWpkToRhHRR/LGCbxpXzZoTwUXlAA19IOn+agwOWzI62rHU65O9h18Qv4Mq6P7qLAoNzwKS3U4i/f1J9xqbPck/79uDgK7meS7P7l60I65ULpuP8L9TBhrOA/ea3n2QGZpuoov+c0jGS4zUh4bzQPcgqCcXo3O7ib2IMUNw2bG60PAsdE+qAF67/0jgoOBA6fr/gYbLAEn3GgpOEPidPQ9oGBI0DAkahgQNQ4KGIUHDkKBhSNAwJGgYDrL2FyShG1F8oOOpAAAAAElFTkSuQmCC",
            } },
{009,
            new Items.Pokemon()
            {
                Name = "Blastoise",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALVSURBVFhHzZfLTttAFIZ5nbab2k4i4A1IV/b4CYBV4QVil03bFU03qG/BZZHLhognaMRTVO2mVTdVu0ii0/nHOZPBOnYuBDRIn5j8Mc6XM3NmzA4ReY0Y+oQY+oQY+oQY+oQY+oQY+oQY+oQYLqPValEQBHoov79NxLAOyHU6HRqNBhRFkY7k67aFGNYBwdvbHt3dDQ2rSD6m4mJYR7PZtBWsksQ1EGImkwnep0ajgV8P7rcMMVyGO83d4306ab/QIq+tUO/9AZ3qLIljmk6nRoxF15UUwzpMBS9/UhhGdH64a+T6Hw5o+LFtpDBmudGoT7PZ7PkETeW0XH79m5L8hpJEaRIt1SaVxGYM3mrBLFssA0ji58mn2BV0SVRKGYvrMQvmeW4llVLmi0Thes0ihhJVci77x58p1hXE1J6+eWUlT9ov7VJ4EkHeJuLOJWVXvx5IYS2yuCuIqkESYp/0Wh1sIAfE0AVyEEvyawrC0Mhg/UEUclj46VnxGpKYYqxDVxKCLBrqL1r+jDrE0AVdawR1Q/A6Q6WCIDRdPJsWguOBIpUX13GzsChLdo/2titoq+fIlUE1IXc/THQjLMSSrKg6/rY85dgzy59VhRgyEMSxpt4VHwRJnl7IjQepEXPlxv1izNe6klzJdaoohi7cIDyO9QYMCUnMvtbVs2tyvl9yFXHyQBD35PvWIYZ1sCRPZVnW7ofzSpumwXTPJbEf8vSj6cr3LyOGVUBu9/DcNMjXXmzFwN/vF5Smypy9ZzeL9QkxV5A37VWqB8SwChbcO+qa/e7Ptwv69+OL4X6ou3g+3RDB8ZamxQlj9sfsykqu8xwphnWUJd0pBiwJ3M5nyVWm1UUMl+E+72E9SpV05Z5dsAyqCll3XbqSm8oBMdwUFmX4GETHbvo/jBhuCwg/5nEfiOE24aqW81URQ58QQ58QQ58QQ58QQ58QQ58QQ58QQ3+gnf+0SN4ICfXz0AAAAABJRU5ErkJggg==",
            } },
{010,
            new Items.Pokemon()
            {
                Name = "Caterpie",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAG0SURBVFhHzZVNTgJBEEZJOE3vphlM9AgzuxlwoUs4BT8nGXBluICJG5QTgGw0nmACBzDGZdlFU2YWn2F+SKjFC+ExJC/V1dAiItVAqQkoNQGlJqDUBJSagFITUGoCSk1AqQkoNQGlJqCsQti9ci/4s3MAZVk47unaUGgD99a/t9YekGeaAmVZioEclUeG9rFHopsCZVk6YfcQuCuEPd8Y6iXJ2aYIZRl4etk6ol4vodyF9V1UmqYHsk1MnVBRoETNtzF97wz97A09bKOzREJ5Co4bZRFN5jHN3nyYxLXbLQqCgL5yQ92w+R5CeQqZHkcVIzmQo3j/3pfuolwycDCyNNv4yOHU0njmJ/rxauhzZWg6d0fc8UfMz8t3qwJlGSRyOLFuBxMaZ36aTOr2Um5xv39L+WbgpllvH6EsC0cmhdsrcKxM76KBDP8W5usB7bdDd3P9LvIUOVDiXx7vKDwGVwXKqvAkJXJ6jONbzkddnGYdoKxD8bj/28c6QFkXjly641wt7v8m2fQvD8omcCRHNQ0ToNQElJqAUhNQagJKTUCpCSg1AaUmoNQElJqAUhNQ6oFav8PCOBvQVv9QAAAAAElFTkSuQmCC",
            } },
{011,
            new Items.Pokemon()
            {
                Name = "Metapod",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAEUSURBVFhHzZVLDgFBFEVtqT8WQUzEasROaCsSVtQ8HnlJpZxBf0rcwZmcNji51aUXZiYNSiVQKoFSCZRKoFQCpRIolUCpBEolUCqBci5Nu7Sqqt7kz8aCcioRdrysrLutrW6EAtOwUnEOyrH4cmncoXsF1iKBddN+xckGetjpKnTEfrT74+od5XH9vbe2/QSXWhHlUCIwXe7+6F+PzM63zX9vcb5eBKaUWBHlEOjmUqQzZ0mUQ0gX9Ig8MNab+zVBOZRYkdaTu8Vp3G63LfIddlCOwf8H86OO481/OwWUY4jACItQ+W9xqRVRTsEj/b1L15QKDCJU5pL8GpRKoFQCpRIolUCpBEolUCqBUgmUSqDUwRZPZ4pS+M0J0iYAAAAASUVORK5CYII=",
            } },
{012,
            new Items.Pokemon()
            {
                Name = "Butterfree",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI+SURBVFhHzZY9UttQFIXZkiw2gFmBZa9AggZIkQANdGCqhAa8A4aKIUWYNDF2A6HJT+MMm7EnN+/IXPEQx9bP2OQW30g+fjP65tyrsVdExDQ0tAQNLUFDS9DQEjS0BA0tQUNL0LCIcDWUIAjcLf9+kdCwCBV8C0ka+sySeasWaZhnnqT/WbNFitNwHo2w4S6v7/Vzq9WS4+MP0mi8/K4uNCzCby5/f3T0XrrdXXuCfnv/XRComC+o7c0SxFnd5bJ7SsMyVBFUsfF4jExOTvYliqJSkjQswm8CY9Wrjtd/OM6q2HD4IIPBlHa7vRxBPHArvpOPB7/k0+FvJ9N29z/TK8T8NxhntdXb2/tMDOeW0mDaxpcLOT2cyoHt5CEFwiqJBwM01+l0MiHQ7z+LLlwQezaK1+T04EcmN7m5FPl6Ke82vr+QnEwm2Ugho2Kg291LzyylQYy3ed6TZq8no2Rd/t5cpIKPG+uyk9y9EtSR+oJl2wM0nIUu/ObwsySDa/njpB6TZoYK+nLYSeyftlhFDtBwHpDEGwsJ7Nconsp1opZr9z4VVBHWXNnRKjQsApJ4CMatI/XlVEilNKvaHqBhWXQn9U0GKuy3py9F1fYADcsCwfjblWy5Nzgv6Y9ZxarKARpWQVtM+tepKGswDKc/h3WgYVX0n4yKxf0riZ72rU5rPjSsClpcOzuTwP3EQQhjD5x0/lwdaFgHtIir7qU5QR9I5rO60NASNLQEDS1BQ0vQ0BI0tAQNLUFDO8jKP1z363moOEhyAAAAAElFTkSuQmCC",
            } },
{013,
            new Items.Pokemon()
            {
                Name = "Weedle",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGYSURBVFhHzZbdTcMwFEa7UuIgNYIFGp4cmADKAIUNgAlQ+8IKiBdQXyIlSwCdgg1CuOQauXXDJ3B+UG6lIzWnjXrka0edEJFooJQElJKAUhJQSgJKSUApCSglAaUkoJQElJKA0hcVHVAQBPVb/PkQQOkLB5ZlSVEUmdD/iIXSFxvIr9XFEb0+zEiFw4ZC6QPHPV1PqapKKoqClvNDE7h5TGh9G5vQ5j1dgNIHDnypg1bzmJbn8TbOMmqgjXODEENEQvkXoYro7my6t2qf1Yc5LG74KIG8eu+Le9okV3Sq0zpoF6O13l4PtQ+h/A0z3tnCBDYjbdjoh8SN5MDnm+8oCx+asPGo4Xvca1+g9IF/kJ93/Khx405S/eM5yN/NsoyUUnveByjbwAeG916apga7mnbENi7P8/ECzbjtPjy+pHUd2QzsEsdA2RaOdEfNY+aV5Ej2fQ4MlF1wR+0eGrQn2wBlV3icvGJvyW7Mff84QNkHe7r7hlmglASUkoBSElBKAkpJQCkJKCUBpSSglASUkoBSElDKgSZfW8FEcbhCOMsAAAAASUVORK5CYII=",
            } },
{014,
            new Items.Pokemon()
            {
                Name = "Kakuna",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFjSURBVFhHzZVbTsMwEEW7Hf7iJBsh7UYQrALBBoCV8FgFj40g6Ec+hl7QtMa6onZt0ftxpOhUkY5m7HRhZtJQqQSVSlCpBJVKUKkElUpQqQSVSlCpBJVKUFnKMI4WQtiS/l4Dlbl42Pvzia3fdoxD1yyUyhwQl4alIDR9rxQqc8gJBLWRVO7jr7jV6vTX2p/uOhv6w9dN5T5YoIf4RQH3N2Hjw/8HgjQSq5zn2caNR9zlWbDH27o4QGUu/TBsp8SojQNU5uATxJmbpskeotDlcueOOkFE+gQ9Ko39fK27yVTm4BO8vujs4+XnHOIZ5y6O8/OZvp8LlTnElwRhV+fhOzQOrv3EACpz8RX7pBCEZw/uj3lJQBoYT7LF9ACVJSAS3zyE+flrNT1AZSn4HnpkyzhAZSm+akyvxVpjqDwEROIvLvW1UKkElUpQqQSVSlCpBJVKUKkElUpQqQSVSlCpgy2+AFxeRacTf9vXAAAAAElFTkSuQmCC",
            } },
{015,
            new Items.Pokemon()
            {
                Name = "Beedrill",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJNSURBVFhHzZVNUtswGIa5Tnf45wLtcAHL2sCSniCTnoCyKpyAaVdANyG9RDs5SaccIClZJPDhV8kHingdWwxk5JlnZL2W4iefZHtPRJKGhilBw5SgYUrQMCVomBI0TAkapgQN34KiLCXLsuaUX+8LDWNgIshOvl3I6fl3yfN841osNAxpk0Dm41/biWCXRNjXVuV2JtjW98mLomlW7c4EGRBgkn0FdX7bHw2hYRf+curN9Ib+EvtyRbkSWywWyNxRrn9nGzTsQsWmfzOZ32ZibbVVEBnEfv6ay/39AzJ3vIsgbgYxSM3WrTHGnZdFJlVVydezCyp3PX4mz7vlAA3bwP6ZHlcyX1dOqwc5vw9BY2pX1cvR1AnFVk6hYRsQRDXmt+WTUMhk/EHqelXV5XLZTFsdqGBd26et0BcaMiCH5Zsdm40KOin7USbmk9w1OQRVEoLWWicLLkezqOUFNAzBPsJSoQKhIOQeGpGJPXCStankz+hZUqVOz3+0vnq2QUMfVE73EXCSgaCrHvbmZyO2qZQvqJWD4NXN/6jqARoqWjldFuwf8LsRuPu3/0JQ5Yp8340bDA5lODxq5m6+K2OgoQJB9sPIIan7TYU0075m6PvzY6BhH3x5gAzbIawaBL8MD11f58ZAwxhCUa2Y9n3hcG4faBgLJPUbi5cwE8W410DDGHw5/ZzhgULldJkx7rXQsC8q539n/afdJ5zbFxr2BQ9Fl0g4JrzeBQ3fC8iGWRc0TAkapgQNU4KGKUHDlKBhStAwJWiYEjRMB9l7BDjQ2fZGf1/pAAAAAElFTkSuQmCC",
            } },
{016,
            new Items.Pokemon()
            {
                Name = "Pidgey",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHzSURBVFhHzZY9UsJQFEbZjp0kFFKKK8hPIyWuQLBRt2EV6Bg2EUylY6O4AcXKGRt/ChUL1Oe7iTfEzEdCAjK3OJNwgHDmvrwMFaWUaKCUBJSSgFISUEoCSklAKQkoJQGlJKCUBJSSgLIoZs3UB/zeskCZBwVVq1V9Gp3feBvKNDbD16sGyjwo6vXRUzXTCOPuerPAZDzDLu0XAco8DB1Gga7rxIGuY4UBHE6f4zBvd0v1mnVllIiEMg8ODA521LgbBQadbTV58tTHSy8M5DDHtvSxHh8pMn29LKDMgpd3Xtx1sBfiOHYcZtvROU8xfc0soMyCpnfpt3RgIwycF0dRScpMj4AyC5ogBY4Tk0uHDdtRPN+bb4n7sihQ5kGRlhX9MIV9f33qDePGcUGnES4n8a4/w9M1zTVN8L7fVw+DgZ6OE26G6XT6J5DCbn93d3LC/x6YjGMoku8zhh89vIFGw1apOALKeXDgRedY785ZEC01LSORfDZSHC03YRprCCQokpb1bP8wDr3SE5o8d+NAiuZ7cZk4AspFoMcNhdKOHpw01eh0duTdTO8T6e8WAcoiJEM57Lx9pKdW7rGSBsoy8NL7vq83xOr+fkFZFo5M+2WAUhJQSgJKSUApCSglAaUkoJQElJKAUhJQSgJKSUApB1X5AWszLJv2FddBAAAAAElFTkSuQmCC",
            } },
{017,
            new Items.Pokemon()
            {
                Name = "Pidgeotto",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIoSURBVFhHzZY7UgJBFEXdiqGZ0AQayg5gJjLEFSgaqOUmLCM1UzYxFpGWiZ8N+IksTShdAMGzbw9P26nLZwCpF5xiuN3Sh9vTI0siYhoaWoKGlqChJWhoCRpagoaWoKElaGgJGlqChvOk6qpSqVT8JR8fBw3nBeR6rQ1Jm40gOY0oDcfhas6//F4PWxxjKth7OpY0TUqL0nAUuqgbLITrr616AFk8L1tblqSRy329ngTBXqu+GMHQil8MYrqFxXkqeH/VkiRpytX6snwOvlw8dxQ0HMYwOb3WVnVuoyDX9bjKahifFBoytBEsErbNS8VyyBVIPJ2uSJo0pNmcXg7QkBFvGRbUV5XCe8gAyHXbG5LgC0SHo/iZk0DDYei2QQxtZFnmty/JW9rxLbbr8nK2Iq/neXt6OB67W+LcPwvimfZ2cSEfnY5fPG+k3+/7dtKf5lQSzaHFz+fjIPfvgmhO5RRIQkoPgQqeb67Ls5dDi9jmBz++MMHb9qFvJ5dROSweTimRQ5vAVaeTAzRkQBLber29/yMKwe5uLhHff7HcwgQVFc22/0rgvtN7MGYWOUDDSdATHf8bKx6UaR8tMTQcB+Sw1a6a/5QCd9nvYQE3OwdhvPi3ZaHhOPQ3XtyQSuP+BPOQAzQsC4TxTLzdO5L3y8u5yQEalkUPDoBorVbzMZ9bFhrOAmSL2SzQ0BI0tAQNLUFDS9DQEjS0BA0tQUNL0NASNLSDLH0DvIDy9200KmwAAAAASUVORK5CYII=",
            } },
{018,
            new Items.Pokemon()
            {
                Name = "Pidgeot",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALdSURBVFhHzZY/ctNAFIdzBKighKFKF1uyJ05oHE5gSw1JKocLxKYJdIRTBKfB40vYo4o/FXABO6kY0hj7APbMsr+VnvKyPAnJGGaLb0b6eaX36T2tki2llNOIoUuIoUuIoUuIoUuIoUuIoUuIoUuI4b/Ar9VVpVIx2L/lIYZF4UWlwvz374OBuhkOVbT3RHmVnd/WZiGGefCis8k9tbi+xfN2UlGs41LzTlPdJOdetWrWFEEMJTy/ZoqPdh+rOROLhg80D1PmV7Foq9VSs86BWpwcqKihr9GCdPxj8L6wpBjaQG6mC5hCiRyJQYhkbeEgiCVtQepmEUkxtMG4jOAgFoIEF4v2H5nCRKC71263M+VwDLzkdchDDDl5ciTGi4KwnT1eOi4iB8SQYwvyrnExSKXvqM5xfvG8ofqHDfUT168hB8SQQ4KLKZNDF1/ExSCCcfLdC0kaM0mCIHkIuncRxNDGSLLNYcuNu3p8Pd2Zqu7gadOIjHXH0DWIkiQJEnYdCTG0gaD5bEzuq4WWS8c5GumdGtyRhATOCS6H89nkXD/oW4PnbWAXQ44+uCHJjMf65p5aLpcqDMNUhiSv3m2r6/62Xn8ry8XCMM6KdFEMiVqtlsoRJPll3FHfohO9cc7TghCEXNRrmq5NL2LR+fTNHTFc63kbGHG9Hnfvc++1HlF884/dV+bY7sgkkYEcdZADSTwQsRFBQO8f5LIEo5fPjNTl0W7aNS6GNZAKguKjJcTQhv4Ofzg9M3J8vFwSG4E6CdBNvJNfk/VlOkeIYRboJkTRUZLkUIdosxD/TZDgY7dFbUmSg1iZ0RJimAfk8P3rH+2bnVrN6ChEIUTY9ymKGOZB7yMvjAzvZ/9wz0ija2VHmYUYlgFy+GBfHj9Vn7pn5pNU5j/mPyGGZeAbZ7VaKd/3dSyvXQcxXAcavZ3/LWLoEmLoEmLoEmLoEmLoEmLoEmLoEmLoEmLoDmrrFwvHsoWObUKPAAAAAElFTkSuQmCC",
            } },
{019,
            new Items.Pokemon()
            {
                Name = "Rattata",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIISURBVFhHzZW5TsNQEEX5pcT+kdimAFFRIiiAiqUCKpYG0UEJFdCwFWFpWL4ExAcgRBHC8O4jE1lPF8e2DJriKPHxdjMz72VMRExDpSWotASVlqDSElRagkpLUGkJKi1B5V8QxbG0Wi1PeK4IKpsmG8/keOtBTrefJE3SSiGpbBJU7njz3ocDG4uX0m5H7hS/PoTKJmlH0TAgqre+cG4rIEDITqfjw/1rBXXwQ89AyLX5s0rhAJVl0NkqM/QINzOx6Sp48f8BMVvhS8PK1q0eoLIMGlBnSgOFweHrhgNUlgFB8OKTrcfhFoIQGu7xZlXSNPH7X9W9Lw+VjHzbWLjZyW0/Y3DvL3uSZelwc9bw+qwqUMmI4kjuu0sSRW0fVCvFQMXy4TAGVbcXhcrfwLAjpLYuHwpoFTVQyMP1iv+B4XOLoLII3XTDgKhOr9dzrc2GG3Iy+OfQgIf7qbuu2ixSWQQChu1FuLfpjnx9fsrc1I4LlngwCrqKERDXVV0sVBahAfFCXRAfr3vydLsiRweJO971xyAetBP3VA2mUDkKvBDtvLu7cvOYutla9gExm1o9EN5XBypHgYDd7pn0+32J3ZaTX935dob31YHKMuTbhu/6iYBYHHVbGkJlHRDu7fln/nT2moDKuuSr2hRUWoJKS1BpCSotQaUlqLQElZag0hJUWoJKO8jYN5TFLLpEOTPoAAAAAElFTkSuQmCC",
            } },
{020,
            new Items.Pokemon()
            {
                Name = "Raticate",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKESURBVFhHzZU7chNBFEW1JX1zZDYwnwSWYEcqROBPZJsNGCIXmYEESKBMgAoSG29AZa3A2AsATCBVPeb21EPPrSs8IxQ8VZ0a6c5M6+h296ghIq6hoSdo6AkaeoKGnqChJ2joCRp6goaeoGEVer1eceDn1gkN7wNyH7YfSLvVLD5Ko9vthuO/pHGu2SyvrwMNLfHAKne62w+CODc+KWX1qNdacN/VeFva7VbxcfH8MmhoQTvjs81i4HlbSZLIx52+XL7qy+T1XVRa77fg3rqSNIyxktpYLIZGVTjPknCdYsc5e7sp15c7lSVpyAiSRAyNodHZbCaTNw+D3Phk8Ro7DiSXLYUYGsZg0B9XR/Jpb0N+fT8qRDb+fvF0OpVOpxOOEESONnHd75sX0oma0rV4M9mt1CINYyCIltI0lfPi199ePw9fDiBtp9fKMUFQZ8PQMEYFMY15ngfRn0WjKpHnWcgApvd2SXvK2gUBJDGNeEFSm4Qck8Uu10cR7resVRBiuhsHg0Fo8evTZ5KZFm2DNmOSa12DOrVoK8tSGY1GMhwOZfTkYEEwloWYEu/i4/1H8vLwsbQq7GQaKhgMjwQM9u3dXPLL8PCOoBXTzE6zSmIWMN7F+y069QwaWnSK9dmF958H+1RQm44bBFmayPFB2VzV9gANGSqq7/FcjOXwxRC3zSmQRnN12gM0rAIk8fc3udgq/j3K1oC2aCXxw7Q1/ZFVoeF9QA4LHW2Nz0tJRWVjwbpiCg2roFOuaJune3MxrLtVxRQaroIK618iwKZwIwggid2ONYi1WGczLIOG/4Od+vjcKtDQEzT0BA09QUNP0NATNPQEDT1BQ0/Q0BM09IM0/gAOeOTiA4aW2gAAAABJRU5ErkJggg==",
            } },
{021,
            new Items.Pokemon()
            {
                Name = "Spearow",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHcSURBVFhHzZY7TsNAFEWzpbG9inS2swIQDVSICuiS0AC7ACo+BZ/GUVZAktUgURjlMW/Mw4N1/YkToVccTXJiZ45mMlYGRKQaKDUBpSag1ASUmoBSE1BqAkpNQKkJKDUBpSag1ASUXQijkIwx9iX+nOFrZGy7tg4o2+AJ7/cMBd6kEiEh/P790lAYGDemSdwrEso2/ECJ4ojVdRHkX8NhMi6uys+7AmUTMvHjfhEoYYyskhDHZZx/T/U7m4CyiSAM3GRLuxp+WJIkboXk/SQx1pUj37NpHANlHSjOh1dIYn04sk8cA2UdHOhvqWzZODb08LOV1bivlxuK7H3V7+oKlE1wpPy2OC7Pc7oYRS6Qg/1V5Dh6u6PV9Nwejn6RUNbBcflzMekoTd1B4MCng+hP3MdhQp9HCa1tIMf9S6AfxxOuX29dpJzOahwzHw5pOTnrHcdAiZBAjuLtW9iJUztKoGyrBHKcEPY8IAyUdXCkeyiPT92q+KvnR852FMdA2YaEcuDUPkL4gCxnx7San1CaFqdXHtbVezcFyq78rmhWxvHWb/ObqwLlpkholmUUhsU/mF0BZR8ksuq3BUpNQKkJKDUBpSag1ASUmoBSE1BqAkpNQKkJKDUBpR5o8A1lZQjHZe8gzAAAAABJRU5ErkJggg==",
            } },
{022,
            new Items.Pokemon()
            {
                Name = "Fearow",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKBSURBVFhHzZZLUttAFEXZktTegGEFkrwKU1lACCNgBGYDiTMCMkllks8kn5FtNkBVVkHCIEM7eekr6zqtp2eEg0z14JSk65b66PVH3hGRqDHDmDDDmDDDmDDDmDDDmDDDmDDDmDDDmDDDp8D1nCRJ4k/t34kZbgtKgclpItejRFx6v6QZbgsIQuwwT2R69k+Q0ro9aARdkbq00akW1KJhW9IINkWL8HryfijO1fOLYSKzQGwrgpYQZShWFLlMPyyPbEvBF17qsjq2yQEztKDYr2FfeoFgOWxe6vrTfo3xaFd+/3gpg0FR3pdlWUOQxzR4nsYMNZCgGI7f8l1x/pwVOyyqiviqQWz2cXmEoNyNV0A2lLzav18OmKGGghAb+Qd+zfpS5MuKoBMyPuuXUq/P92pyqCimAKqY57kcVIJtcsAMNRA8rcQoCFlIokOK4npxW69ayJtn6aod52YbZhjC6p0HYpTjJKcor8vV6Yf7z89XNTmsYPzOindSwXXDS5l1QBJzLQ+q+j+SZqjBCv4cVG82nfhO3KoDDBfAUFMgRL8Q979OBTHBv3g5rN75fO6r0Ws8vNwTq28sYaVCyXCjblssZhiCTm/fXsj3kxMZ+Hm2WCxKOf32aMcKaoEnEbx7dyWDopCb42PfYWpWD8P8PKv2xEqA81DL8fxRgpacS+ufOg0rCTFuyOuqh5Uefq8tzBCsk9PtNLiPG7LeH7Fh4/uMc3xVOhNsqxrhPZivvAey3GYgtYkcMEN29FAxgvtujo5qlUY2V9Xr+eyhzzVDPHQTsRB9L675Fwz5ps81w655zAubYUyYYUyYYUyYYUyYYUyYYUyYYUyYYUyYYTzIzl8QOZbPzbsOEgAAAABJRU5ErkJggg==",
            } },
{023,
            new Items.Pokemon()
            {
                Name = "Ekans",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAICSURBVFhHzZZJUgJBEEW9jrqhh0tIuKH7BqALh42KFwC3XgBx68bQhcMJVC6kyDLtX5paVHzpAUNy8QL4PfA6qyqr10TENDS0BA0tQUNL0NASNLQEDS1BQ0vQ0BI0bEKSphJFkSM8tgw0rIOKPQ3uZHL26Eji5M9EaVgVyPliIRANr6kLDasQJ4kcbe3LRXcoL8OHb6lx78yh2bKSNCwDclq5fvtQTtoHDid7Hcv7dF0udwdOciWCGNpOpyPPw/u5yk3fNuTqvCXTQvB0e88JI4+juLiM36sMGi4CcvoJySzLHCqrFVW5fxWE1OvruqRpq/j5NdTdjkx6meRfoiNPbCWCT9dRMa9+WogvCfrtz4XzF3KAhr+hFZzNfqoIIIm+5+Zl8QDjncFqBIFWcXIzX0mVn9y23LHweFNouAhUS6uIVoIK+TvJ+3TTSeb55wJadkehYRmQHHUHbmEcF3PObzcgz/K5xaIPEd6nCjSsAiTDXhjK+e0GD9NEkoZl+BUMBcOdRauIcyFed9HQsAwV1D8OJZFjmwvl8P3fBPVFQQX83UQFMdx+80ZV45rDTMMqaBV1KH0hBcIqhnOa9EQaVkUrGQ5xCOZl3copNKwDJLE6UU19B1R0zi3TC2nYBBUNCc+rCw0tQUNL0NASNLQEDS1BQ0vQ0BI0tAQNLUFDO8jaB/8bCblyu+raAAAAAElFTkSuQmCC",
            } },
{024,
            new Items.Pokemon()
            {
                Name = "Arbok",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIKSURBVFhHzZYxUttQFEXZDqVlNiKJRk4qmCzANmwipDL2KoQrIA20yYZChsLFQ/dnrvP151q2ZTCvOAP/2EJnnr7+cGJmrpHSE1J6QkpPSOkJKT0hpSek9ISU+zA8O7PBYLAm/fxQpNwFhtXfa1v+WAbm07llWfauoVJuA3FxWAwiGZpe1wcpu+iKAwx8r2lK2YUKRMzdzV0rLuaQaUrZRTYctgJx89VqZYvrRYgpi9KKogjMJrN1eN9IKTeRxj0/P1hZlvb0dG/zq3ZcGnn0wOloareT2/VjTCf3MBrZY0PZrOubuvcUpewCe3BcjddxDLuvqhDDuF/1qT1+qWzefA8T5HZI/942pNwGz0Dw5yK315dT+/n1Xwzjfi8/MTAGsSHysrBFM72/l2UIfv2WhzWmfLQ9SDhBrrE38zwPj/rlogix583vWGP/9Z0ekHITDMMexEuSDf7fNI4kh8YBKRUIYBhuriaIILw0DGMcrkuv2RUpFXFgHAkYx6g0Lj6S9p2mlJtIIxmq4jDJSTVpxZF9IqXsApHch4hjBI8SxsWfkT5TlHIX4n2HmzICYTis4RjKNSOPEggQqf71QgwDEcefcB+6BxVpZBqXro8eCPi48ThJHMfADz1mtsGXZzZuhwFMrU8ckPIQGBqTfmcfpPSElJ6Q0hNSekJKT0jpCSk9IaUnpPSDnbwB0fXcZlaEc98AAAAASUVORK5CYII=",
            } },
{025,
            new Items.Pokemon()
            {
                Name = "Pikachu",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKMSURBVFhHzZa7ctNQFEXzLVSxaSRZku0ufAGW/OqBYYah5wNS0NNSMBM7wCcwlBAHKMFO+I5k/BqgONx97asoYhs98DC3WCNpy5KXzzlX8oGIWA0NbYKGNkFDm6ChTdDQJmhoEzS0CRraBA1tgoZFCYJAXNdVu/z8PqBhESAXRVFhQXy+4Tlql5/fBQ2L0GwG0o07hQTx2fnMlc9vaqUlaZgHqnE2rslkfEi/EOc9z9P4DUfmU0fLfXq9oYwkDfMwgi+PjwTVMTn2A9/VrY/jWFd4PvNuyZ2NDqXVCpNr8qDh34AEqnJ+WpMwuGkv8oVq4/q7K71epOUmp/VEzMilf1ARaLgL3Bxiq8uNCGiGrm4ZZgzH2A56XK5M5Qw0ZKCtRsKwvHDU1pFXz+9paRx3u5F8HNXlfA9ygIaMdAuN3Je3d7X0aptBtOG5gh/z4aSWSAZ++ceLgYZZTPUgZdqLwf/184f4vq9XqRFHy3FNu92+JVnlGQhomAVfdv1tU6Hs/PXUil1MPXX8pySqPlGr/b+0OAx9Lbnazp2RWT+KZP0wlvXFjfhy5qjKumoWldy4XlkO0DALKvj+xZ1kASyTKirRx+pZ90AJpubz3bOaDPuRjJ6qB3XF1hpoyGi1Wnr40wsAM7lQlRv2O2rrbVb55aa6qCKehydP0HJf3YLfNw8a5gFJvEkw/IP+fblWM7hUgkbUVLGr5jMMq7cX0DCP9ApFFYeDjvT7cSIHUE28cbLXloWGRTCSeGOkn4UGvOr+tXqAhkVpb+cSIljhmEeIzqeuWrnl3rm7oGEVUFH8N7z6uj85QMOqQHIfbU1DQ5ugoU3Q0CZoaBM0tAka2gQNbYKGNkFDm6ChPcjBb67eHIYRORc9AAAAAElFTkSuQmCC",
            } },
{026,
            new Items.Pokemon()
            {
                Name = "Raichu",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALLSURBVFhH1ZXPbtNAEIf7SPWug9oj9AW8tkPfoeVA+fMAlOYFgAOIR0BCKEnLGYSQoG16RUg9IKX0HAikUJphZs0kW2ccbNVFy+GTo9/a6y8zu+sFAPAaMfQJMfQJMfQJMfQJMfQJMfQJMfQJMfwbSiu8yGN1I4bzILkgCPCnPF43YlgEyW2YJVD/syBX2MUd499lEUMJlrsdL4uCLPZg7So8Wr9mce+j8dO+gVBXq74YSrBgkRyL7XcMjD/HMyL/RNAYM9M6V+7syAAcz8rxfSRYNF6EGOYJGwoaYQBf2wGMtqfQi8rIEZcmSBPnxZg0MSiYrTduLQu4m4PnYcEqkmLoQhMPO8WCcRxPJJM4WwL8HF8po+Xxq5/J1SbI1fuGgt+7U7HeVtZuyliSyFeN59htG0iSGPY68aTKZSXFkFG49gYvAnh+I5NkwfHZKYRhiJVVcLKjJjkhvZQle9uxFaU/UnZHi6GLvqInVXQl0iTCl2SVqCKo/4xz6/meIsQwD0327l4AB63Fc60eH2WSriC1X6tiSRYsixi62Ik3A7sBhl0NJy9DK2Kr2lWw2ozOCdKXpqgyZavmIoYu1GKqXhJH8GPwGmD0FkY7Gpq4OQhahyRGS+CglVWQmCeZz+YhhnlIUocaTIRHxfANpGlijxZ7PmLL6UrtZ7k7SX1VFMMiaPKfg1ewej1FwRV4uL4CX9rY5jSCvfvKyt1FuXltJqpUUQyLUPi5e4/rsf/xsa0i0WymKDdtLfFsDTcKVryONouhBE16M1rCA9mAUgoU7sZPH57A8eFT6LW0FSNRooHnJz0jSV5ai3kdMjZDEdpAJLW/pfBAX4RG7hjJP8fPlkUMq0Btj/E7m+CnbnczO5K4gnUghmWhT+FGtAy3cFMwVNX8fRdBDKswbaGy5Mcvihj6hBj6hBj6hBj6hBj6hBj6hBj6hBj6Ayz8Bjc5xBcmsa1mAAAAAElFTkSuQmCC",
            } },
{027,
            new Items.Pokemon()
            {
                Name = "Sandshrew",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKlSURBVFhHzZbLbtNAFIb7SPXMOLwAYm2P7fY1EGFRdkgJPANpArxCcytSlxUgUQELaHkAeuEitWxTSDmcM2aSEB0ncRKks/iU9HNi//5njtMNABANKyXBSkmwUhKslAQrJcFKSbBSEqyUBCslwUpJsHIeSmt84Y+tG1bOgsJ9/hBBpaLwz7ELgsDh3bpg5SxMqKHXDGD/qQKt8lBnH2P48sk6tF5vUFYWQU11dylQNArUbwVgtBo1SGHJUfjp7y8DK4uggGe4vC+eKRfi4iSGNLWQZRZOMTS159ssCll2/7KSg07cwfZoaX2DFIL24/lx/j5JYjyWN/vofuC2wmRId4N4A3Qj3s2DlRz+5HRxCkntURi35zaVC+9bpVcPhfbLT5+h4/8tYLeJwY7/XcLB1zaEd2p48XHIejXAVuNRi5PN+u9Nn78IVnJQQAqz/9zgHjRwc9mBW5UQzO0atBvaXTjD/Vi7l4eipnwgCkjDVbY9gpVFuJDf2nBz1Ye3L5vw7lXO9lYK1lp4c9jA1pRrj7bB6d+JpkatzUOWnW5WFmGwsZ2dB3B0uOvaimMLaZLA8LIL8KOPE43vh0NsLnX7NUujUaM2jtw+nD7nPFg5Cx0aiKIYL6xw6SK4/t6G31c9F3B7K8PlVvDr57V7T41Rg2X33SSsnAc1+fBu4NpJbOSW9v3rJi57A5+JiQtOQ9FvKXiMg9JpBBBWlvv9ZuUiUEhtjAtqMeQRhqxX6VGUP8hpD9arm26yyw7GJKwsgw/qwCHae5L/FF6c5A3WcEBC/P2e/t6isHIVaNJr2CQNRh0nWi259zysXAUaosFgAL2WgYODPdx7BjX/2UVg5aqMl331f2xZKQlWSoKVkmClJFgpCVZKgpWSYKUkWCkJVkqClXKAjT/1bCZUjRlwnAAAAABJRU5ErkJggg==",
            } },
{028,
            new Items.Pokemon()
            {
                Name = "Sandslash",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAMBSURBVFhHzZbJbhNBEIbzSJmeGYe8AqfZbATiyiW8ADZHljsRLxASzJUsRnE2KWThikjIcyDFEG9SUX87bXfGFeJxjNQjfbLnH2fmc1V1O3NE5DRi6BJi6BJi6BJi6BJi6BJi6BJi6BJi6BJiWBTl+/wiX7svYngbkgiy6mOPlOfduIbc4wzYeVHEUAIPPFr1yFejByKL45hqlqARW156QO+fL46JF0UMJfKCRgTVe/nEoySJb4jNQg6IoYQtCJHLs5iyLNHVg1ySJNQ6S3S2vLRI6bWwTf6ekyCGEmHo0+GKR5Us1iJXFwMZI2afg81XD6nxeoQ9GkUQwzymelkaDWVApTySM4K22CxaLYZ5jOCnt4r+/Iy1TP2Np9//Po/G5IwYQKvNIpqmzWJoYxZDi2fOVMrQOk/otK6onEV67vJiaDXksIgMRasphjYQzMt9qwfk+6PFcrKG2YyG82cwcmYRzbyCkIOALYdWdjodCsJA74H9fp+zjI55BNI0pndWJfNVnGYWxdAAwV/fedVyK68uMjr96FGpFFIYMs+eUo/ler0ePaqw4JrSgjELSe3+b9tMwEJRFOuq4YAQqgZwVCoVlgvohOXxBbAN2W0GqK7ZP/kQn3MbYpgH7TQPw0OUr8gPAtreXqe9vS3a32+wYKgrePljsKohi3PI2e+N6KSyYmiDNu/sbFCtVqNmc0PPnn1tINnQnxlU0x9uRVg4aH1e1jDJ5i2GNgOJz1oM7+1r+HWpVl/Q7u4mC6S67QcHX4bVtKuHX6FjXu1GbGYVxAyinWM5C2P2Mp65aq1K5XJZzycE7YWDDT5NIv0FcR/pXv9CDO8C0mgtKne06usKdbtdPt/Sr9h2vn5QvD8q3WbPU/xn8r3uQgwnwVQWYJU3m+sUcjY/j4050vslOFxRvDVN/x+3GBbFHgPMKaqK1ppfHPO5aRDD+wDZdrut24y9c2GhxLH82UkQw/viX6/4ogtCQgxdQgxdQgxdQgxdQgxdQgxdQgxdQgxdQgzdgeb+AkvryGpauNG5AAAAAElFTkSuQmCC",
            } },
{029,
            new Items.Pokemon()
            {
                Name = "Nidoranâ™€",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIhSURBVFhHzZXNUqNQEEZ9pQRMah4DiEwl48plkqcw6n4S5ykgVunKcml+XshNZkzZ030zjRR+AaQcqhenoL5L4KRvN5wQkWlgaAkYWgKGloChJWBoCRhaAoaWgKElYGgJGNal63l8wGtfBQzrIHKX8xV1u/9XEoZViFyn06kU1OuE4lpdYFiGVi6MIprN13R1u/0gqWLJ6pWWW3J0Pb+RKAzLUEERU0RWK1UU02vSzVsmWrxnGTCsIl/FMAyzSg4G3yld751gNIgpiga89kxXi0OVPf94OxwDhnUQSSfiJNZONmE5qZJkw2lCo3HKf+DQCk2HCYZ1UMH8NougyH2bj5kJS6Y0mqR0+bP5tMOwDB0A7UPtLUUFh5OEhuOEr2tePQGGx8j3nm6n8mN6R7PFJquoVlV6tDVBQbc2LyeT+fT0wJJL13P5wRFJOT/t9fjn+J5lwLCMoqDIvVwE9Lbf0/Wv9y3X4RHJ1iso2zyaLI9uab6Cmus7sni/KmBYhggGQcAPXmeD4uB3XXb+j1luPQhCnubnT1cThlWI5G63o36/72SlYvJwkdTKylYXt7nVF7XfO+XD4fj4eM8ykZM8O4u5Rw9fE/myzBZcaX4PtjYkCJH0fN8hlZXPXRzHrgVueHBaHZIqVFZEz/lL8vvPK/UaVk+A4VcgotKrQnHtM8DQEjC0BAwtAUNLwNASMLQEDC0BQ0vA0BIwtAQM7UAnfwG8wTrXScsh8wAAAABJRU5ErkJggg==",
            } },
{030,
            new Items.Pokemon()
            {
                Name = "Nidorina",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKeSURBVFhHzZZJbhNBGEZzJU9wh2QTd7cvAKwImzgBifECsImdIJQ4h0ACCaRkgRglCBwAxC3Y2CbF/youqzCfZxPV4qnTn8vdz18NyppzLmlkmBIyTAkZpoQMU0KGKSHDlJBhSsgwJWQ4jWqlYhf92aqR4SSQ2z5suXK5bLd6zCqR4TiC3E5n3wuWSiWL9VhgPGOmjZuEDMdRrVWHgoG4yTD1Qaz1+a3b//rBlQf5IshQwQunySGETBBbVg5kqKhVrb1ne64ZCQbJMI2xWCDP80ucYmuDFqEoCk/ry7thUwginZlUlmWuaePaZ+8vZ4rh6pWabzFvFP+0hGiQW7956Na3Oq6e5V5ymR0vw0nwslgOQpOIXnv83V1/8tMEj71k8+jvtTovMpwEMu3BtAbCNG/c6pjgj5XJgQzH4TfCQIbp5Ips49Gd4abZ2DoaisWbY9EzUYYKHhy3VTy87eVqJtLr9Vz+YPdiDdrmqNiOD98LYvW72ybenrtRGSo4ZhDaPT7wOxPJir38143C9U0wNMgS8J/ZeD6Pz87s/o4r/S9B4IV7n9540R1rw2MvRpq/ufppH/wA7uMjZ5H1KEMF00QbNFPf3HS5NQWIdbtd39zBQI7pD03T2jJnoQwV/pC2M5DGkGQ9AWJwevrSnZy88NK0BxzcyCLJ/SKSMhwHB/XrV88vFru9DJBCDphKmgtTHWSR5MoSGX3mNGQ4CSTZMNm9pm+GNYYkNBoNLwJMPQd3uOdH1ey7o8+bhgxnYSgJ1hz8Pj93T7999GuO9sgQRY5/1UafMQsynBUkYxDp9/tejPbYubQ67+EcI8NFiWVZq7SHMBtsdOysyHAVhLW6jBzIMCVkmBIyTAkZpoQMU0KGKSHDlJBhSsgwHdzaH+ZjBo9rPBvDAAAAAElFTkSuQmCC",
            } },
{031,
            new Items.Pokemon()
            {
                Name = "Nidoqueen",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKTSURBVFhHzZZNctNAEIVzJdnmAIhcQJJPYJKNU2xITsDPxjEnYEngAq5s+MkmmE3snAKKDQULllbozBtNK+Op52DJdmoWX8V+kqxPPT2t7IlI1NAwJmgYEzSMCRrGBA1jgoYxQcOYoOEqet2u+cOP7QoaMh71epKN3knS6Ziv/BwF5yZJYgmPNYWGjHUEVWz48UqOvlxbkg2rTsMQlcvH7y2QDKuDc3yxbcgBGoaEgnleyPDTrBbw5fKiMMdze/zhK2jE/JtrNbMssxnkZl+Hcv3tSIrxmQw/zx9GEGiVIKGCWjGVmzxPZfo2k/m0kux2qzbAtW03DA0ZtaCpGioTCk5O9uX8OLXMTRVRQd1Qem2batIwBPNPe9CXs4Lal4bJ8RMrWJwu73Zcrz3aVJKGIVoBXwqi6cFryU7PKkH0pxHDZzaK/BVgx1dBQ59VcqjEYrGQ/cNA0m2isFL4HV2FnQqiaknSkb+DTP6VpfTffKjknKC/gVTSypmdng5eSvr0lX2gdSVpGOIvD6pXCxlmUzNSirxaXldBfLbnmQ2E3Qs5XX4ASTxkeB8GDUO0Ari5zjllSc6J2VYwcn7uPxTYWgUhh17TpcQP11Vx1QqXdkkQQoHk1nsQzV3e3EjPfNbs1/eR/Pk5tvT7uZSmH59duLHjCe9cEGCO6ZtAhXFTvDkw937/GFlJW1G3i/1q2nHkqt1EDtDwPmpBVxn05PlJJWqHdF69l31BPbfN646G/wOSjwcv6nGBG19dun8SzKbBOFFJHeZNK6fQcB0gCTF/6fU7KoxRojOvad/50HBTltpgAzlAw02BoL4Gy/Ju97eBhtsgbIG20DAmaBgTNIwJGsYEDWOChjFBw5igYUzQMB5k7xYmZ9ZYlWL3IwAAAABJRU5ErkJggg==",
            } },
{032,
            new Items.Pokemon()
            {
                Name = "Nidoranâ™‚",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHjSURBVFhH1ZW9UsJAFEZ5JRIaHoONjZaWYOOohaKVVmIlVkinvgBqwwxP4M/bWMG45lvm4rp+ZkNgmGtxJsmJg2fu7kLNWqsaKjVBpSao1ASVmqBSE1RqgkpNUKkJKjVBZRnSRiO/8HfrhMoYiBu0r21ST/JH/jfrgsoY/yZw2Ln5FcmWHq5erzvCdzGojMECJcKfrLiXy5F9v3p2pEnq3pWFyiKSNF3ECQhCRGYy9w7XMKxKHKCyCH96AoJee4/uaoxx9xIlLpx4WaiMIZFhkIT6YebuxDYvduyg0186DlBZBkTKssr0fsTlYeah66gaB6gsQjZ+uMf80Ob5tm3dzwNXmR6g8i9kahKFPfXWe1o8SygCESZxcNgSG1liRB639u1tu2+75mCxrKfm0Dn/8ACJw/3GAjFFBEkcvj7G45Ed7n1HuQPind6NBeJ70F9mhH7sGvs5m9mzrSM3RX9qAqaNQOzd8DOLoDKGvxf9CJmcxPmhCET8slOkMgYCsaRZNg+SUx1OTSYGJpN8K+TTDz8rBpVlkMMiSydOJuv/rEmkPC8DlWVAjP+Pw2WvciAYVFYBgdPpNL+1tpHfw60DKqsiUw39KlCpCSo1QaUmqNQElZqgUhNUaoJKTVCpCSr1YGtf5K4R8PSSE4oAAAAASUVORK5CYII=",
            } },
{033,
            new Items.Pokemon()
            {
                Name = "Nidorino",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIISURBVFhHzZQ7UsJQGIXZUhIax9IVJHS4AxwLRxqFkkqofDQ+Ot0AagNLAN0QxfWe6M/83Dm5QFD8nfmG3JOYfHPuo+GcMw0NLUFDS9DQEjS0BA0tQUNL0NASNLQEDdeRNZv+h9/7bWgYA3L3nWuXJqkf8mcEPJskib/k9zeBhjE2FcRzs6uxy9LMD+vL0jCGCD6e3EYltSDEtOw20LCKNMuWcqEghPQ1hD5H70vqyAEaVlElqNvSY4gdDo7dbPi6H0GAj4dTrIUgouXy50s3H73tT5C1GJM7GLRdktbfyTRch7TYKlrlBsD1x/C7JQiKXPHS268gxCCU57krisLN/dpCW2iSCUJO1l/d85CGDL3OtJSM+0W3FJZNIb+QQ8O94jx6LFVBwyogeZGfuYfOzYqcRrcp06/Xa/jOddAwhjSpG4SMiIuMgOaQy++2kjSsQk+zTCnkJpOx67e6pQA2jm5NkHxvgqVk+8h/MHGLxcI9nd6tiKAxbCRc6+zPBHH+aTkQNiRCMp2SYy0CNJ3594TvjkFDBtrD8aKPllBMxvoZjOX/6xw1NKwCLeIjcg6C6dSvw588vAfpOjtXQ8MYaAI7VtZT2AruS5u7ygEaxpCpCsXknqzTfxOMAUHsaPw1/TWyXaHhLkjDYV4XGlqChpagoSVoaAkaWoKGlqChJWhoCRrawTW+APQv86TFmokoAAAAAElFTkSuQmCC",
            } },
{034,
            new Items.Pokemon()
            {
                Name = "Nidoking",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALSSURBVFhHzZW7ctNAGIXzSpLsGcJbSHKTPEIyFBCaxKkIlWMaLk2ACqgyUHArYKCBSRPIC1li8Vk48p/VUSyCk1nPfBPpSNr99t9L1pxzUSPDmJBhTMgwJmQYEzKMCRnGhAwt2WDgkiSZX+rnV40MLRA82nro0iSd3+p3LGmWrXRAMiSsnhKEiL1ndjp567K0/eyyyJCwejcPNt3R9qNGErkV4UCQnU0/uLIoz+W4viwytKCTG/c2vOCz7cdeMs9z9+PwnRe0YsTm/1tNGXLkHP1guJBEdSAHWcB7Vm79YMOd/r1fxVTLkFNoq2EFMe2hIP4WL/Zc8Wrs1u9veskrEwRWktUpikLK2erlL7slOSucmT7IkEASQj8P3zeiJKwe5CAFIIm/oQja4+D6isrQQkk0akX3i7ut6lnBJF0cS2iDMjiKKElRvqeQoQUN7ua3G5kurGSSLmQggAHacxQ5snGxs1RShha7Fm0VsbasOASxRgEyPMdxxOqHBz2k+lRRhoDTYjcKpxWdf/t07PbLHX/Pjrgm+T4zK0kZtI8KLqtiKwBcd2GHABkam81m7vmtJ41A+C5zSFGQhBkkewsOh8NznYeCtiM8r6rKjUYjP7V7xR3/Pr9TkryG1NOtP/+dmIcuoBVA0I6OnfGa6wx8/3zssiz1033y5bUry7KR7KqkFeN1V/VAK6BgXdW+MviYWHF0iIxyv+p6/rnz31hB5MgoiY0VCnZVD8iQGwR05RSbTseuriu8d6EcB6UGiba7kGEXPBMxcjQ+mex6QYApx3o8e/DRy0GAy4P3FCJh+woZdoEKUpCS2FD82WpZOSs4/8m2u5DhRdgqUtJOOTaK3dGQw/nJdde3ckSGy7BrkR2GGSrJQVDu2gSXAVm7Gci1THFfIMn1efL1jT8vkf8rMlwVdtrDZ32RYUzIMCZkGBMyjAkZxoQMY0KGMSHDeHBrvwEmSIhkXseKcwAAAABJRU5ErkJggg==",
            } },
{035,
            new Items.Pokemon()
            {
                Name = "Clefairy",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGhSURBVFhHzZJdToNAFEa7JaAbkXYV+qR1B/qmu6h1A8YXlVWYuJkaR74pH97gVwboTy7JSZ1DyxzuOAshuEZKT0jpCSk9IaUnpPSElJ6Q0hNSekJKT0g5hGJe1B/63jGRMgXi1tdZyPOsXu7WWZZF+J1jIWUKhCBws9pFbt/WIVSbyLzI66/o301ByhRxUnVMWZbh+/0vzkZyopbuc4YgZYq4WRP49Xgffj6ewnKxaGPp8Pfzbd5OuvucIUiZgoGMBJ8Pd22UBYGL8mLyFKXsA5tgQvHqxCgwWb4Aflfk4/5HpeyD07NTjOCqP+3xMo6BY+OAlPtop2fDGhjM+zbu5eYyvK6u6sATH3GMwNVEMYDrbjzWSxM4JVLKfSAQm9gAu+6C+4zkyzQvKZ+vkLIPHqWiG8tAHvPJjxggEJvaEBCPGlezZhwDET92ekDKFH2RQMWdLRCbVFX1L2Qfh0wPSJkCm5G+UMbh86yBFoaqON6bGgeknEITEa9DoyxSTuWYYURKT0jpCSk9IaUnpPSElJ6Q0hNSekJKT0jpCSn9EGa/oyBV5k9IY6YAAAAASUVORK5CYII=",
            } },
{036,
            new Items.Pokemon()
            {
                Name = "Clefable",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIBSURBVFhHzZVJTsNAEEVzJdvhINjZgFjBLoENrBBLWDFswnAJhJAYVzkB0yUQHAJD0d9RRS3zPZJYZenJzu+O66mqo/RExDQ0tAQNLUFDS9DQEjS0BA0tQUNL0LCKqB9JEATuka/PExqWAbnd9UBC64J7G91I0rAMCK4sB/J8NJQonArWGbnuaXo0aFgGCj0dDuX1eJQBya+bscj9mfSj0G35ux9SbbtOwypQEJJJHEt6O57J/tydZpLaKQD5tSSU1bh59wANq0AhCEHwchjLt5McJEkmi05i7Wo0zfFZMz0STaBhFRB8O9kUebyQ2EkClSuCjb8ONCxCRxSFrhgK48qJMNDd9/1t18Hp+N1F38+gISN7sSuG+/XWIOugZiBNU5GH89lZROYfA4z8w0l+Huxkovn3F0FDBmRQEONUKRTV5yX3a1UpFQTaPYhh/0J/xZD0BQGKqijk/DXNtIsL7aDij7UKyKngws+gUiaYH78viDX/36cuNCxDz6IvBlQOd18OIMOIX7oQBKyLKuiL+YKQ7lQQhX1BFQF5Odwh2PT8ARpWgUIqWYV2D8+dCQIUYx3z+a8coGEdUHAymWQCvkheEPvaygEa1kWLA5VUUZXLf6cpNGwDhPSC5DzkAA3b4nc0v9YWGlqChpagoSVoaAkaWoKGlqChJWhoCRraQXq/ZnQkMcbun3oAAAAASUVORK5CYII=",
            } },
{037,
            new Items.Pokemon()
            {
                Name = "Vulpix",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH8SURBVFhHzZY7VsJQFEWZUkgKKKFTq0QaHQJUYqUyArVSKz+T8DMKPxPwMwl/Da5rTuC6Hs8T4IWF3mKvLE4Cb3NuXqAmIqahoSVoaAkaWoKGlqChJWhoCRpagoaWoKElaLgocZJIFEUT+NfMCw2romKnGw15P2jKxWazOH4eNiWpVxOlYRUgl6ZpLjeScuV8Uf+906DhvPijvO225Hwso1K+KM7XA5qk4SzYKLGoCt7nx8FqJHdEOLRFGjLctl73G7ShTpbmUu0fOSa5tAYheLnVkvWxhDalx49cAIJZlsmuJ6hHXLO0e7Aex4XgzXa7kHzLF3voTYo9HnXl5aQnnfXfkvG4ff9zZ0HDMrRFHamO9arflufjkdxgLZIs380QVtA4BP3PmwcaluGOGQ1CTltTubN84+C8m8eBY3Wh4TQgicUxRh0rxPbyUV73W8XxyZEDuC2qStJwGiroLv41HEritOufV6pI0rAMHbHebwCL4ubfWRk16Ar5/ImgjhRjZBIKmsTmcV8vfRcDbdGVUQFXSJvFr03ow9mFhrPAMxGL488BNgqeee54dZS47l8EFbSpAtqgL6NfRl+HQsMQIIkNgoczmqzaVBk0DAGC+j9wkVGWQcNQIIkxLjLKMmhoCRpagoaWoKElaGgJGlqChpagoSVoaAka2kFq37ek3d9NdHZMAAAAAElFTkSuQmCC",
            } },
{038,
            new Items.Pokemon()
            {
                Name = "Ninetales",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJVSURBVFhHzZW9ThtBFIV5nUQ09pqHYKHxTwOPFJLGgsaiQ0nHU0DyAgg3SKlI/ABJ7MLIlz12jnUZHduzso1u8cmzZ2c939752QMzC40MIyHDSMgwEjKMhAwjIcNIyDASMqxD0TqyRqNRNfX9bZFhDhT78/zJWkWzinS/bZHhJppFy6bTqU1GX9bKoR9eYpsKy3AVvmqT0Wcpxz7gpn9s/36t7puDDBWoBsR6vY79fb6Qg0KOUt+uTpZyYPjj3IqifjVlqICgrwgEHr+fzQfF/VTu62X5pq+/rlNNGaZg8Ha7vawcqgF63c5yOnH/4f7Mxr8v5lVme5Vss5lXSRmmQJDrzstBGDI3/dK63YUg76k2xCiL53KmW4YpEHy4WwzCgTiVEMsV5EvhRXOnWoYKrkHIYe1x+lgNL6kE8dvpLATxnF+/65ChgrsYg85mLzY6PbRhNTBEUQ1IQsALKlG097oGwej0o92WH+zx/4CbJJlRLrd6QIaeVA5goLQqnHIMnkrxGsugjhyQoYdHjK8A1poX8LBCaCvRvRzUkOR5R/yuJl6OUNKfoTutoILHDqYVA/KX1fXV5pT74wXkfk1kmAPXJo8av/78lKZtbqh3EcTa5ML31ULGarJy2OGUBTvbxevA2QhJboRVchR8GpQ2rF5i72uQoIr4uvgvCGQBZH5elzaupt9fF5kHNJFhDl7On29Pg+O5SK/KueMphnb6P5uQYQ4QxIA8I1E9ChHfj8/VRYZ1oMA2EuuQYSRkGAkZRkKGkZBhJGQYCRlGQoaRkGEc7OAVn7b8qHtSXIMAAAAASUVORK5CYII=",
            } },
{039,
            new Items.Pokemon()
            {
                Name = "Jigglypuff",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHZSURBVFhHzZVZTgJREEXZEjQrMGwA6B+QL3Up8MOwCocfhgWgsBEiG2Eo3+1QndfPq/RASJGcxJwWPdQbqImIaai0BJWWoNISVFqCSktQaQkqLUGlJai0BJVFiJqR1Ov1hPDZLaAyL4jbjceyn04l7nTS0FvGUpkXDUTc8XMuslkmIDhqNNyv8PcVgcq8ILDdbmfiwkh/qmUmS2UREHlYZ6enbJ778j2ZyPlrkT5vRsUmS2VewgluXx7TKAT6YXjWvezT8O/8B5V5SCd3Okkcx7K7RGE/doI9GXe7iQN3C2y4perNX+VhOJSjm5RGsP1YdnqAymsk0zscpDUaydFNULarX1Eh+AB3CUQc/hECB6uPdIJ+TMu53uItE68Hp+j1Q+VfIC5z75HpIQ5hmK5G7mez+wQCnSBCcUqxdP6+Gyzfk6kiru9+vnsgQCSuF5xcjUwPiAvC0mscXhpY5tuFyjzocutkfM6XMLyqTA9QmQd/in4cLmr/slbKxAEqr4E7cP3US0Jwv/mXtO7HW8QBKvOgh8VHTzj2I6LxASLnw/cWgcqyIFonq8tcZXqAyir4h6dqHKCyKrr8oS8DlZag0hJUWoJKS1BpCSotQaUlqLQElZag0g5S+wEH21/WGtv7kwAAAABJRU5ErkJggg==",
            } },
{040,
            new Items.Pokemon()
            {
                Name = "Wigglytuff",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIkSURBVFhHzZbdUcJAFIVtCZIKHBuAxAbUBvgrgQbUJ7UD9UXRBxh4AdOAg80QuOYsXGaJJ4EQhN2ZbwKHDPk4u8lyJiJOQ0OXoKFL0NAlaOgSNHQJGroEDfPwfE8qlUrykn9+aGiYBwTH4754npe85ecw9v1hNMyjqKCKzWYz8X0/ifh5WdAwD1zw++FWfp7uxatWkyi7HeQQ03EUwapXlX7jSqaPd2vJ2fhNJPoQ32oV5yEPg0DiON5LDtBwG7g4WjQXn7wbOTBq3yTCyybRHn5IUK+bc2z5ItBwG9qiXhxiw9a1aRWNmjW3am/QXLaty6EoNNwFNFSr1dbr0QYyh2gP0HAbOsWLr55pyZbUabePZZ6bNNyG3gC69iBRT9oCkLLzMnKAhnlgahvjZ4mj3lqEATk0u+/aU2iYR3C5fGxI9LmW6USvct5tSXPysiGu6zH9HUWgYRb1cHMKlYtuW+J5nBw75qjy9k2T/q5doWEWujOEYbhsESOR2WhwMTeZyp1EEAOS5qbQ6YYYRqq9kwn+GSsxgAe3boVlJWmYBQTxT2ahbaXHP0jSMI8sySgaSbB6ODshGEVDCiSxNtNb4NGmWPfYyWRABaeWVFk5QMM8sM1h+wKsybRgGTlAw11Bo7aoLQexsvswoGFRIIq/Xlh72m76nH2hYREgZ98QZac0DQ2LolN9yOYUGroEDV2Chi5BQ5egoUvQ0CVo6BI0dAc5+wWXj2jN6vadGwAAAABJRU5ErkJggg==",
            } },
{041,
            new Items.Pokemon()
            {
                Name = "Zubat",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHDSURBVFhHzZRNUsJAEEa5UhIuIbhJcgs8gcUO9AIUK3WnXADkBAQ2gBdi0ebDdBymPsT8VfXiVZHnQJ49k/RExDRUWoJKS1BpCSotQaUlqLQElZag0hJUWoJKRhhFEgRB/pH/vSuoZET9vtxNZhKEYX7J13QBlQwELh9fZDid/ysS6zHxplOnklElEGtHy408rHdnggbHg8pr4MZxHEuSJBc3dKcFsGa0ymTwNL+gzvGgkuFP5TyZIghnc/S5LX2SpmXgavx6nnqngSwOEZgkQnCdLY6yW3xJ6sWtx2+y/TjKsOYUqfRBoD8ll1UegZA0+Y3TQMQhHCCyk0C8A0+nk/SLs+bGIiTOwzDNwXRWhum2ZkVgFP48KFVfVVQy3AdBY3EznZbiTo1tq/6OXt+Cymu4kYpG6nnDNmOa2fuhnJz/O1Wg8hoI3O83EhXvNYCHR6eHrdZtxtSqbieDyr9ApEbtD1u5f74M0zhdi39Cv1sHKm/hbjVeyn5c0ygXKqvgn0vX6ZomUFkHRLnXeDW513Whsg5+kLlAn7a2mcq28Le9DlS2hfnANqDSElRagkpLUGkJKi1BpSWotASVlqDSDtL7BuLnFafXeqdfAAAAAElFTkSuQmCC",
            } },
{042,
            new Items.Pokemon()
            {
                Name = "Golbat",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIJSURBVFhHzZZLUsJAFEXZUidsQhwRdgC4AD8TceZnA8ouAAcOo45UNgXa5qZ88dFe0jGmyjc4pbnpSp96rz/0vPemoaElaGgJGlqChpagoSVoaAkaWoKGlqBhE9J+v/jD33UJDWNA7uD81rskKR75mK6gYYwkTaOCGOOcqwjfN4WGMWIVxPvx4sVPVusKl3wLh+ProCFDrzkRHFzMqaQI4r0wXr61kqVhiK4YPjocDr0bn/iD2V2t4N30xj9dLf3z9ariUEmDumUCaBiCCd34uJj0tapCNhr5LMt+VEFX77GQm0+uf0gKaUQO0FAj1dMtKts0PfN5MXE4SSgIESbZRA7QUMBkef7gp6tdOQ3Wkx4vcreBlJZsKgdoKMiEWmj7/uH7Rb7ZbPzR/bpaR2h1rLWSdSYIcJ5BBlKQ0O2GDBhmo0LutZILKxZKJq5DQYBKQg6IbHXMTE7L3azltIxuq3wj/H4dNNyHFgUiGYoJbVoaQsN9hII4DwezXUmpVH65qJ7D7/wGGjIghx2dBnesVBHrEM96vIyRrA003AcmxU7FIb3dbsu1KDuXSXYBDeuA5L6djJsFLY9dX7+BhjGkfeWd/NVGvR7/XRCUv/eK+9l9nWlNfiO2gYZNgZT8L+tTX31dQMM2mBcEkAyzv0JDS9DQEjS0BA0tQUNL0NASNLQEDS1BQzv43id4yO38VtIzRwAAAABJRU5ErkJggg==",
            } },
{043,
            new Items.Pokemon()
            {
                Name = "Oddish",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAG/SURBVFhHzZY5csJAEEW5jyOJJTeZRKQhwiGcwHbEcgpMJDiJyz6Bl1v4HOP5qFoe5C8JJJYOXgkesutV94iiY61VDZWaoFITVGqCSk1QqQkqNUGlJqjUBJWaoPJUet2eDYLAvfzviv5UqDyGfq/vLtk1mt/bIMxC8B5R6Udkd9/xnrDbPJLKOhAxTaN9FOLi5dAmJsnDZrt4Dz6/+gQRJxFmnNh4kcWln9m04Ldf7abmQ2UVfiBCxi5ymmavxSEUXs5gmylSWYUEjlZDN7UoD8Sa8V7iMFk4IOezCVTWIWdQzh5iptu/tRtjDmgzRSrrKAuUOJxHxAqy9ibnkspjwPecRCJOrsUoCbvqBBE3X7/a5eY9Z7Yd5ROUlbZZrUBlFVgv4n5Gd3ZViARh2HW38b9tApVlDAYDO3lc28XL20GUH/vwvHFPbehu5//jVKgsQwIRgUhMy181/M0DkySxk6cssoybBQKcQZkiw5hx6wfDh8o65KeUH4oweYKL97eByioQJ2FYJYKw9kvEASrrwJr9GH/t5zx/gMomFKPPBZWaoFITVGqCSk1QqQkqNUGlJqjUBJWaoFITVOrBdn4BCpsDuLozI0EAAAAASUVORK5CYII=",
            } },
{044,
            new Items.Pokemon()
            {
                Name = "Gloom",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJASURBVFhHzZW7UttQFEX5pStj9bjDTiORL4DOpmEYiiRdEhogjWJ/BY+GjkfFwA8kn5FUeTWYg7bso7m+2WMJ2WZOsWakLdtaOg95TURMQ0NL0NASNLQEDS1BQ0vQ0BI0tAQNLUHDJsRxLM65GcLPNIGGdfGlkiSR466Tk5z7y0xOepFES5CkYR3a7XYh9ePbtVzstmQrTeT3eyf/Pjh5mx+nabqUStKwClQOcqd9V4hBJgTXzgeTii5SSRrOQ9t6tOkknbb1zJNBBrmf36+Kyi4qSUOGil1tb5RV8+VUyJdUuZULYt4gdrvTKVAJXQq/gv41XZaVCwK/tX/yZcAihBKhoJ6/2gxC8te7yabqtqqIikLuerszszw4b3mS+rB6Pg8aMuJ40ua/efW+TKV6nzJJ0q1SRGV0FHQcbqbjAUmI4SHXoyUL6hziJpsfM3FRVNwMx93Pw5KjblQK4WFudzZKSZyj8nXlAA0Zfltw3D+9k8H5QwHEIKzZca9VzKmOAiqOOcT367ZWoWEVEMz2MhnuD2Vwdl+KuqhVCEDUl3xJxUJoWAUE0dp+Lvc1lwxF/Spqi1f+mgnxJR/HTzI6GM1IQhBzp8uEEQh/ow40rELnEf/H3fzmj+OxvDkc/bcoWrmXzp0PDeehlVMZvGYg4GcQXKStPjSsQiuoIMNrCMeoKt6Hmi8KDZsCSa1k05kLoWFTtP2dwX5eQYOCQNsf5k2hoSVoaAkaWoKGlqChJWhoCRpagoaWoKElaGgHWXsGCaDIgVxOs3IAAAAASUVORK5CYII=",
            } },
{045,
            new Items.Pokemon()
            {
                Name = "Vileplume",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJySURBVFhHzZW9ctNAFIXzSpKw+/gNJKWxhyqBxqkIbwBJg90BTYZUQAU8QSZPkJAXMJMqDC/AT8HAzZ51rljvHNkrm0lu8Y2lo9Xup7s/3hIR09DQEjS0BA0tQUNL0NASNLQEDS1Bw64UDwrJsowSt+0KDVcRC812S/n78rmc7FXyxvHHXV+5X9znQbu4nxRo2IaKeaHrC5FvlyKvj7xIXVXy/UMmvz5lslOXcrw7F5Wvrp1rA+FiDVEaMiB37MT8oK8OG0K5k0elr+APd70gibYQdR909bj2onH/bdAwptfr+aqhCjp1EAGQO50M5Gw6kJ8f5xU8m277+7qaS2rbLw7tI1WShjH9ft8LqhgG8lN8O3U7TrIKRCGG+5mTw9oMq63v/1dBgCn+fX3upygcVAlFF8Rup1Y/pkv1AA1jtII6AGACqFC8RhX/jqs6PrCLJA1jIIgNomsoHEhFF+RI1ULQFsdPPA6DhgzdxeFCjwdtexbSRQ7QsI28yJtDN5TFoNjN2LFMUqX03bjfZdAwBT20y3K+Y4cHb91v7a9D1pEKoWEqqCg2z0MnN3r6npLluWvK30+BhimgguMX506gkOGTf4KzvXpB+M4FdWoBBPenl14yzlRwU0katgG57eEzGYwOnUzeyDBUTtvGfaVCw2VoBfW6TXIwOpLx5KK5XleShqlAEOtvPPnciIVTi+oND941z7EU4j5WQcNVaBUhp0cLjplQDutO16US95MCDZeBoyXctW0yWKubrD2FhqsI/1EAe64fcW/n4DJ0t2P9mRQE4W7fBBpagoaWoKElaGgJGlqChpagoSVoaAka2kG2bgArQdgj/zZGPQAAAABJRU5ErkJggg==",
            } },
{046,
            new Items.Pokemon()
            {
                Name = "Paras",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJESURBVFhHzZQ7UhtBFEXZDpk1M1KZ0GRANJ8EQuENGJvAwCpk7YByRMECEBPZsAJ7JdgokFSPuT16IHVdiekRwQtOgY7mc/X6dm+JiGmotASVlqDSElRagkpLUGkJKi1BpSWotASVben1etLpdBz+d22hsg3dblcev1/J+Pxaxn8OJInfJySVoWByt5ef5Onvnowv5iErkiiqvub3NIXKUBBwsNeXu/6ZlMfnUl7uyvCgL9E7LDWVoSBgmqYy2O/LcP/YkafZUh/b9pPKNmjIUTW9PE/l32BbxsOaJPpQ97PqZvlzV+KoeUgqQ1iczOM81MPXtCKTpx/bUiDs2WsvQ0NS2QTsWoT69SV1QRAMYbIse5kegubVZ0wVocrPdUdRgab9pPItNNxkMpGH0+IloOKm5oVk/fSfy6ByFRrMdW00kvtv+VI4hCkrX5Zl1cNcfp/Uy6whMV3c3zQcoJKBrmE50S28DC/H/9dHO477kzrcbDaTJEncdIuicNfp9fgbEg5Q6bMYTsHLrg535P98gjdHH+VudCtxHLsQGlA7qf3EPSHnI5U+eoTo1LAD/RD68tl0Ut0izvs91CmGhKTSRyfoL5EeMQg/nU7dhsFy59nyJlmcOKqgP1Cfsw4qfTTgqrNLg2pYTEo3jwbUUOuew6CSgRC+Y+A6/8BeDKQ/Rj+/BZWboAF1U2CaIRPzoXITcFbqMvudbQOVm4IphnZtFVRuSmjP1kGlJai0BJWWoNISVFqCSktQaQkqLUGlJai0g2w9AxqWAHYA4YOTAAAAAElFTkSuQmCC",
            } },
{047,
            new Items.Pokemon()
            {
                Name = "Parasect",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIgSURBVFhHzZY7TsNQEEXZTjryoaBMqKCzTQOlzSb4VMAKgB1AaIANJHI2gUTDZwV8ClDSRBo8TsZ6GS4Jfo7EFKfgGOSTefMiVojINFBaAkpLQGkJKC0BpSWgtASUloDSElBWpbnWonq9XqCflwHKKnDc5eYmvR2c0MfhKV1vbVGjQiSUvjRaTXrdP87DXKpEQlkWDuOj5LjhbUKj5w6N7uIsbjLFNEmo+V+BHNeLY3qfHilTRL5MQtO9hLqeU4TyL8hFQEeq4Qn6ThHKRXCcTE1PS451+LSRu4+j4yLQZ4pQzoPjPh/bszFupBPKPu12JuxlR+0xRSjnIdMbPv2cGkKm5ztFKH9D9o4D+WXuxUDoOKFMJJQIjruP2zQ8r1GrsVpEMnoX3b2b4SSk9Gpy5M3GkgP56+TzrEYPSTujQ9thQGEYUt8Jzbmc7pyzd25YehpkLv7zLkKpQXHj8ZgGgwFFUZSHurGR+llT5qJAqclvrhPIL+j1etTtXuSBOvYr+93RRY22o2AmksPL/vMApUb2T+LE8cuCIIvo94tYiWP4A8kqMDc763S3u778WyyB6GgklOEpS5wE8t/I5eKJlo2EEsEh2rnwcx3It52f8Q7ryKUHLkIHyvTc53IKZfYQSh8kgKek49znaE3mAaUv8nUkR6vh59otAkpffKc0DyirwJHaVQFKS0BpCSgtAaUloLQElJaA0hJQWgJKO9DKN419BjSzbk1PAAAAAElFTkSuQmCC",
            } },
{048,
            new Items.Pokemon()
            {
                Name = "Venonat",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJISURBVFhHzZYxUttAGIW5kiXZB4DO0GjlJpQ4FSFFSBVm0sSugDQhFZQMaeJcIJmcIIQLOFAxyQHiCYVl/uyTvYrYPBt55bHXM99IerZHn9+/krwmIl5DQ5+goU/Q0Cdo6BM09Aka+gQNXYjqod7w96pAw3mB3HA4lCiK9CH/jCs0nAcjh5ctuIhWaTgP09pbVKs0LEuj0Zgph5c3grVaTUfjfFHtARqWxQi2Wi056vQlCMJMdNJeJloUd4GGZQijIJfb3fmoBa9FqZakaZplSqlc2v7uPNCwDGaMpr3j7o2MRvcPjqvKARqWwRa05Z61P+nxBvqj/PtloWEZyghi7CsZMeS+xS/kfrLezLqz5bBfddQ0nIWR+3NwJM/bvUzEbs9m6YK/Xx3mckYCrdnNFXGVpOE0cN/DLeVSvZS9nV4uhO3g4FiudL613pHDNz8WJknDadTr9UxQqUQGp6dylYyFBnrckMPYp0kutcE0Hcnd67dyd3YmWxtdvSbHch+abfke769OEGANQrK53s1EcXFcqn25mMhhu1kQLC4Dl/siDWcBwc/nT2Tv6XjUeKQ1tRBaxHgTfYwfUBQzLEUQmBaLJ0ejYHdy8di4PlVo+BgQjOM4H/Vt/0S+XmzL5kbnP0EjvVRBwCR/3bzXo+89aBL7VZ7JNHwM/NXCOkRrSfJvzbHWVvp/ECc3GEnIfTnfljCoJmagoQsQvu2/y1r9eX0iYeg+1iI0dAXr0jRqv+cKDX2Chj5BQ5+goU/Q0Cdo6BM09AdZ+wvZQh0VVXGmMgAAAABJRU5ErkJggg==",
            } },
{049,
            new Items.Pokemon()
            {
                Name = "Venomoth",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJ4SURBVFhHzZY/T9tQFMX5SokTvkfiLPAtgK3d+mcBJgQLZaPtktIhKR2IsiEWUJYIFiQmFBakDlTtkEi3Pi+6zvXLiWSHJH1IP2GOTfzzuX5PWRORoKFhSNAwJGgYEjQMCRqGBA1DgoYhQUOfaqUspVIpOeTnlwkNLevVSGq1muxt70m5XE6i6fPLlKehBQK7W7uyv7Mv9Xo9I4Nmm6cviXglzRYNDS1WEGiLkDt4dy3fPv/5v4LASlpBtHf4oZdkkcuWAQ19VBAj1ndxFe0BGvqgLSyU5ulvieOGE8Xx2Ze/uQR1F7D418yChgwdKQQP3t+49ux4VcJerzL4PzyMgs/IK0lDBsasgtqetqkSemNfanD7JE93WaIo33tLQ8YsQV9W/2ZSloUKQk4XhbYyS84X655dTREVWPU0tEBuOBxKozERsjA5KzO4HWSE8zan0NACwdb1faYxK2blmJSVLdKcQkMLBHWLsXKj0Uh+9h5S0U7zcqotS9HmFBr6rFfHW4zKtW/u3Q2xWvvP4/FD8rH/mGnMMk97gIYW7Gd4B79/nYy1/zxKBCsZQeyNcT1ORRfRHqChDyQxZoz16GPPiUDy7pekcti0kWPUcTwWBXgI//OKQEMfCF5ctNyNrQwEtLlZDb5mvICGDJXEuLAnQlJF0SyabB9vy+HbzSSbXjRLXSQKJPU3Rod3Ez+Q63TarmFIxnF2wUB0JYI+2mq3e57KocEfnyaSaA8PgON5JGmYFwhi8bh38c1GKnd+spO8d5NvMyq6ckEAydbxlpNSIOdfM+9qpmFRVEDxz78GGoYEDUOChiFBw5CgYUjQMCRoGBI0DAdZ+wdUkC0vn3endAAAAABJRU5ErkJggg==",
            } },
{050,
            new Items.Pokemon()
            {
                Name = "Diglett",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFtSURBVFhHzZQ9TsNAEEZzJXtdgDiF11UoHaokDUlFa7sK5BRRLpCQBsQNIipuQs/gsTSGWJ+i+EfwFU/yvl3Jz7NRRiJCDZRMQMkElExAyQSUTEDJBJRMQMkElExAyQSUTEDJBJRdcFEkQRDUNPe7AmVbNG6XjeVQ3FY8Ta4lHCgSyjY044aOhLINGrhKr+Q5H4sLg5NYXTfPtwXKS3GRk8+HlXwdP2R9d1NNjCowdE7iOJZjupD3yVLW5bXqJCkCLW5fBiXeiy/RZ4v719+gxr3sNpIkiTymp1PTMMP7uPffDpTn0Lgsu5fZzFfo5BQN/R1ngXamaySU59DA6fTnxa/7jbwdtvU0Lcz27EP+LFDRSH2hXrPGzefJSayu83zRO06B8lLsuotiWcdomK7DMKz2+lyvAmUbbJp27fpsQbZnZ7sAZReGiEFAyQSUTEDJBJRMQMkElExAyQSUTEDJBJRMQMkElExAyYOMvgH4HD5kk40J3wAAAABJRU5ErkJggg==",
            } },
{051,
            new Items.Pokemon()
            {
                Name = "Dugtrio",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIVSURBVFhHzZVLTgJBEIa9EmMg6k5d6Q5mhXGlcaMngMGN4CV8XMLXQuIJNJ7G6AK0nL+1JkXn99EIsRZfBv4B+pvq6mJBRFxDQ0/Q0BM09AQNPUFDT9DQEzT0BA09QcNpqdfrUqvVKuL700DDaWg0GnJx1JbrwVbg7GBNshlI0jAVK7eY1arXs5CkYQqQazabcrK/Jlf99oSgCsffSYGGKaDvRqORvBwey0sxkJv+h5grwfv2jjx3+/K4tSu9zeVQSTeCANvc2ViSIpL79x6EGMaJ9iCEYv5NEHIn+6uhYhDJW5OSeN9qtf48D2n4E1bObqdK4nr5ee+vVaThV9h/Cjb38rJiqJrKKSo5TTVpyAgHodMJAuPxOIyV84P1sLAdzLZ6sXy325Usy8qf42swaBiDykGuKIog+PA5VjD3epsrE334VOZv41d53N6TRSOvgviNFEkaxqgg5LBIuJYjBWPltOxFyKmglUeFtU91+1OrSEOGreJweCV5nlenFmJYXA+IyqucfmZuWwxUEHJ3d9dBEFJgOLysMjYPVQ4PN5ctViB5e3tRyWFRFe71PvrzK0E8BL6nor+VpOF3QBLjwh4aW51Y0lZPWwPv5yaoxKK2klY8fgCIpcxDGqZgD48VsJlKpvSeQsNUtJq2MlY8tWoWGs4KFY/zFGjoCRp6goaeoKEnaOgJGnqChp6goSdo6AdZeAeS/9XSOnz/jwAAAABJRU5ErkJggg==",
            } },
{052,
            new Items.Pokemon()
            {
                Name = "Meowth",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIsSURBVFhHzZU5UsNAEEV9HYdaOASGxJITOAKGBEiAW1BELnwCigQKApYIwwVYTsByABYHBjf6UnUxqL4X2cJ08Mryl4Z5dPfIFRExDQ0tQUNL0NASNLQEDS1BQ0vQ0BI0tAQNxyEI55IPfq9MaDgKyL0+HkgY+MnXn0yvy4SGw4CI53lye7UiQeAl0W9h3AP6/LTQcBh+EEq9XpfbTiaoQiqIe1EUlSZJwzyQ0g1V8LhVk5P9mmxurMtdpykPN01pxJGcb3sSR/XZCqKF2lJsfNSal/enqnRfqnLaxvWBNBpxKne58w+CQCVRKVTOxRUsUw7QMI8eDJ0vtNet4P11Jv7xnImqoK6bRpiGebAR2opqBX52IE7bC+l3yPX7n8ljkkiupaI6Cniu+3L463VUFBoyIIkKuhuDfv9LwjCUXq+XPCaJ+GLactxj1cR1EWg4CJxgV+7hZjWtngpqBVHZOP6ZRcidbWUHCB3QvzcONBwGJHFYMG+Q1FZru/GqwTsSotpuldtb9uQiOUhFJGk4CJWDBA6LiqgUPlG1PDMRdCuH1mobVdSVY2t3l4rLARoysAn7iXMr+kZOLdZNOn+AhoPAZm6FtKoQhBwqm28z7uss6roi0HActKJui3EN9HcaoGruP1UUGo4CcpgpDL3vVAqS+RHIry0KDceBtXuaWRsEDYvyV3KAhpOQr2hZ0NASNLQEDS1BQ0vQ0BI0tAQNLUFDS9DQEjS0g1S+AbDm/6Qf7yAfAAAAAElFTkSuQmCC",
            } },
{053,
            new Items.Pokemon()
            {
                Name = "Persian",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIzSURBVFhHzZZBctNAEEVzJUnmEJGzsewThGITcgEgp1CSI7AKcIAEuEQgGwIrqjhAwFlgaPSVfNcw9SVLtlTVi1fl+iOrX3qmx9kzM9fI0BMy9IQMPSFDT8jQEzL0hAw9IUNPyHAo0mxiSZLUxGtdkeEQZJMndveltPtvZzWTLN1KVIa7Esq9O5/a27Pcft2WdvPhqWVZP0kZ7krcPYpCEp2Mn29DhkOA8xd2MU0Tu748tOXX016SMmyChz7Om4iHhNKjCOLlL472rShmUhLbukmeWz+KIF4OwVfPc0sjkbY1gmewxX0HRYYKFJjNZvbyKF93kVCOhJL4Hp65KPft8/vDcaeYncI0cjpPjqe11JvTvL5OKEj5cJr7TjCQYQy7gA6uViv7cTCx5WNhCIZy6O711cO0UoyMcg+GZ2cxL+x7ntiyvLP72/N1UQDB+fxBjlkoyWyULcYEo3tFUdjPYMtwv0EKOcTwB/AzhRSDDgnk0EEUD+UWi3ndzb+r35XowX/nEmttkoNPMS/c8MCj0OtpYn8qwZuPz9bdizuIPJZFhvfFdRQybIK/BGExwvMWdg+d4jTzHJ8c5/apWu/aRRm2wW6Gg8POhd2LBfA93oVqvQkZdgEFMTgXZXXvVf8IhNKxAJ7FWt/uARlugt3A1QI5ZhRUAljndsdrbciwCyzIz03d2xUZ9oFy6OY2v7WbkGFftt2+LsjQEzL0hAw9IUNPyNATMvSEDD0hQ0/I0A+29w82JxFkxKyiEQAAAABJRU5ErkJggg==",
            } },
{054,
            new Items.Pokemon()
            {
                Name = "Psyduck",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIGSURBVFhHzZVLTsJQFIbdErQuQONE4wToxMcK1FX42ATRkY8JcQMqToxugMAKfCxAgwPQY/+Wo5fL36IXYo7JlzYf1n45915cEBHTUGkJKi1BpSWotASVlqDSElRagkpLUBlCFC+ml8n7WaEyBI3CtVKpTNyHQuVv0Je7AfOOA1ROoxrF8tpZlffeWkYc5aEu/jOhUFmGG5ckNanX6/LWyUP9YP/ZEKgsAnFXpxvSPt+URmMyzAeh/t/4K1QWgX2FwOPDZfn4GKYR62NB7fM8vt+dXySVRWgg4uJ4fB8iDh4/txfbWSS2AKaMK54PgcoyENncX8pikiT53oOfn3n0YDBIf02yz+ARjtjQSVJZhk4x24OPLXl/uUxjGlnocJhP8ORoRRr1fHqzLjWVZSCwVktfPoprX2xJ/+kntHmwLDdnk3sxNJLKInCKO3c70n/Og1x6D3spu5Kkk73WCXun/F8CX0eTY2FYZgWR7hT/bYl1iohSdGoIYkTVsDhA5TQQiX2o03KXUr8LXbDcof8GqSwDcXgJTrJ/CIoiEagT/us0qSzCXV5dVj9ynnGAyjL8SPdA+GG6BUKWVqFyGrrMreaGXB5vSjWdjLsnAT7r3u9IFHh6FSp/i4bqvUYheh5xgMpQNHiWJfWh0hJUWoJKS1BpCSotQaUlqLQElZag0hJU2kEWvgDMyDLXk4pETAAAAABJRU5ErkJggg==",
            } },
{055,
            new Items.Pokemon()
            {
                Name = "Golduck",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAMzSURBVFhHzZbNThNRFMd5JDtzp93owuJSE+ejhda4kD6BpSQWcKHwCL6AH5hgYWdc+QJgER/BRNCt0BYCGI/nf9qLzeRMaUmNd/FL2z8z098995xbZojIadTQJdTQJdTQJdTQJdTQJdTQJdTQJdTQJdRwHIzvUy6X47f636eFGl4F5B63OuR5hj/+zf6FsBpm0ZfwKAxDqre6FMUJ5by+WFp4WqhhFhCsND+xWJnqWxAsUXWlze9PaHH79FJQFnJjOtVUwywK+YAqT3aowUJLzIPVL7Q4kKu3euQFBfL9gOqbHcr506mmGo7CGJ8uzs6o9+KjiEIO21td2busZKXZpiDI8+X6M4DhxaYzDTXUwANRHfTfUS2hjbs3qcF9CLkSb3WSJNKXqKRvCnyL/hygDVkWapgGcvhyVAd9V9/8yVvbE0rlOeo8Cun3rwtqbPeourovfZrz85nbbEzAgt3pCA7LyfYtt7laJYrjkF8jOuPt3rh3i87PL+jh033e6s8URbFch/5ENb2cz48aPG8waKj0OH2qhha7FY1tFtzqDwKOlu7BGu1/uEMn39dorhyL7HxzR/oQhJjywaKkP7mqvun3JKoHeSwER5T9rizU0CKCm8d09G1dJHGkoHrdwzU6/bEu9A6fU/t9USRRuZgXUGUBLAaScTInRxJkUU2cAhWWm+cqXjVIQA0t9ljBg/AKAVQvLVfIGwqMkWuqy3uyhahkNCRnqxlzD6OC41QPqOEw+aDfJ5AN74dSPYh1DyA3K3L2WrugKClz5XiYUnIQjvgUmB8s2t43CjXMAgJHX59diqFq6WswVI3WsfRsWg5bj1Ngkt9sNRwFKoreTOc+N7/8Jr/r0DH37BIfOXa4MFh2MMYdDosaTgqEby+8pjCCyK4IWVGcjcOC0n9Dx85VqOGkYOuLj15SsfaGBylh0Uj6TM7D5i5/7g8GBIu8EDNm/wE1vA52iIoLr1go5iEw8hmSkCrWNgT8u5a+dxRqeF0gicGxw2Onerb2VlpABL3/KKhhJe1ZOu7xYlHDaQPJ4ddJUEOXUEOXUEOXUEOXUEOXUEOXUEOXUEOXUEOXUEN3oJk/ZdcD/sMWekgAAAAASUVORK5CYII=",
            } },
{056,
            new Items.Pokemon()
            {
                Name = "Mankey",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALkSURBVFhHzZbfThNBFMb7OiZesN3d+gzUxqTbpVyr3Jj4ABSvKqIG9AH8c6NoIragCL6DjS2+A0G5NQgiLfE437SnmR1Pt0tok7n4pbvfdHe+/c6Z2c0RkdOIokuIokuIokuIokuIokuIokuIokuIokuIokuIokneD8jzPHUoj08bUWRgrnF/ljYfFCmfT5rEmHk+LUQRsLkntz1qLidNYuzXwToFfl6fs2YmPakHEEUQhNfo8U2P3g8SrERl8geGMPnXTzX6/eONNgljMBzHFX3M59IDMKyPQxQZmPSDkGbUDVdveTpNpIiJke7J93U6PXyrjR0rQ3uf72nTOG8sJxM3q6Hvk9GkKNpgAm1wwaO5OKKf+69pa+X60CAbw2+lEmmzPM4JmwZRjawpiqIETH7ZXqT2zhJV5/qJwZwNp2ka5OvL5TJFUTS5EttwHx3tv6L2bj81mOIkTZAmg97FdcM2mZZBAJNYINVBKdkMm63OV3X/dXaXEibB04W8LrG9ZaUhimnAYPfsDx2UrtLeTm24OLYe3dAp9c57qryloUH0JJcVDwaNd4MsiGIaWNnoxarqNUxcUWzUi3Te69Jh8Qr97Z5pg5yaaYhbxD5OQxTHgZsfbTyj082X9G3lrjbZVGXFwrBLKy0KXD/qDWUjiuNAiq36HTpuPKeT5guaV2lidZvGwIeHJW0Qx7xQ+B5ZTYpiFuI4VtuGKrHqsdZ2TSeHHoPRjupNXs3YdjpqxcMkxtgowLZjbugSojiOIAhoTW0Zvrpx6+Miheptg8kLYUG/ed7VZ/Wq5s0bKUIH6F9OeColRmmwn62q9/Sa2tPCwFcy5TA5/wctgJ5sqyTxa4/hnFNkfRSimAYmwEdEGAaJiW36Kc/olO2xiyCK44BJWzNByjCHLyFszlmSGoUoXhY8APqwEIb/lfiiiOIk4JQvYw6IokuIokuIokuIokuIokuIokuIokuIokuIokuIojtQ7h8iMvc/M6ohLgAAAABJRU5ErkJggg==",
            } },
{057,
            new Items.Pokemon()
            {
                Name = "Primeape",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAMTSURBVFhHzZbLUhNBFIZ5JGbSic8AbpKZQUpwI7hCF+qKiytLqiwuGy8L0ZXgxiRUgfoOCooPoejaioCaVB3P38kZmqkzSUgFqhdfzeSfVM/XfU53MkJEXqOGPqGGPqGGPqGGPqGGPqGGPqGGPqGGWcKCoSAI+FZ/fpGooSBi1YUxqi+NUxhevqQaAsitzARUW2zLCa4kviP3Lnn5IKghwEtk5TRBPG983yRTCNPP3fJBUUOAgbMrGEeVtBfxfP/hHB0fblmZ/d0FKvAVcic/39DBh6X0s8gOghoKIrk2G1DEclEUqYLbD67Sl/eLdhJHh5tWLo4j+s1yB8u300m44/a76dTQBYOVK2flCpw1vr1OXy6Cxz+20tXLE8R459l0apgFg1ZYcpVXE4MmeDm/FDICpEQwSWIrd1J/1YZzKXm2r3tJqmEWCLqlxuq5crl05HAP6eriqdiFCU4kEZfzdLUE9J772UVKnhWUCXfrRzXUkDJj9URGyiobIyst4FlWUtt4GmqYByQ/7sxT/dnUGSm5yhGz/Xw6/U5WEDKYKMSEoQkCSOLMg0Dt6VTnftrKTE5esy9rNpsseSOdhAs2iivYTQ6oYTeKpkifdhbsaiRxzD2Z8AHeftmff395MyTUarWsII4eSK3fCm1JcejjsMdpgPLaU2GYgqZ4xZYYcmuzIR3VNuxO/bp8h9bRU7wy1SfX7eqKnJDtP9BLDqhhN4wxLFKmX29f0EntJTWqG3TMogeP5qzE53dnxVxQXpRUToShC7rHTRy1JSe4zHv8k4cyTuQIYjXRq2gPGadX7wlqmAdK/PhmQKssCNBPthf5EAboTZGRK8T3d+fJmMH+MKhhNyA5yrOvlMt2c+yxFFYNlHiF0KOlYint1ZUZ3iAzo3blw2CUh9DHzUMNewHJu2MB3R9v9xH+PBQ65TOmZK/2YOdJVCptSfSt6XznPKhhP0ASUiKWBYL3eBKQjFgyCC6pxP0iq2xMoXMd7J+1Gg4LSLrXQVBDn1BDn1BDn1BDn1BDn1BDn1BDn1BDn1BDf6CR/y+k41/buD7SAAAAAElFTkSuQmCC",
            } },
{058,
            new Items.Pokemon()
            {
                Name = "Growlithe",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALkSURBVFhHzZbNchJREIXzSswArsG4AF1kfiAPYB4ggSxMyArwHVIRrVKjrnRnfAWNgJUi5h1UJJWShESoavtcuEgmPYQfKe/iq7pzhpk5c/p2D0tEZDSiaBKiaBKiaBKiaBKiaBKiaBKiaBKiaBKiOA2WbVEkEuGlfH5eRHEStLHm5yLZvA6e/1eI4m3AHIyd1sv0bscly4osLEVRHMeoufqrPLVqJbVeVIqiOA7Xd6lZ7ZvSGFHiaNSiFce5YQ4pAtv6jwmirI2tFMXtCH0/7JdXl9n33OH+W0RHi2IQO27T0aMUnWyn6HEpRz85xazvUMZzqL2XpE4lyUb/rqPcNPpabXpW46IooU1ePEnSwcMknRRS9GsvQasZ/5pJ13XVMUzClE4azLJXRTEMpKHNaEO9Xo86T5fVusTplst5OueXwLG0X6fdq6IoAXNI7KJyd2goFrWp2+1S59k9ZbhcWg81h3lZ288t1qCz4qgmaY08+ByGKwllcJUbBiWuvsxdm5FYvy30DU6boiiGEYtbysCPQSe3amX68jqvyo7U2oP96bnO0OQoMDZtw4iiBBL89rHID8pxuTyFTgTlQ2k7YLA/M5zm4YuNGwaD970NUQwDCVbZVG1/NJmcSjKb8ehst19qpIkUXR7so0ku1KDN5pAgZmD9zSaXtg/ModwYJzCJcoOvhTQbdenT83X1UtHY9OaAKIaBWTjaKDB7Wi8pc77vUWM7Tcc8zLOcoM8JOpygHbPJ5m4P3mtSRHEc+Ca7/PBmtcjl22BzJR7WnjJztJWmg7UEfVhLUoOHeozNBa+fFlEMA43SKNyn92yiySnCWIb/3WA+Rvk7bTFnu1xibhbs1+D1syCKYaDEl5dXdLzzgL/F+MTx4OahjbLqtGzea3gRfc28iOI4YBJ7CkbblWXq/r6i+J0Yn5J/Py+iOAna6DwNMAmiaBKiaBKiaBKiaBKiaBKiaBKiaBKiaBKiaA609AfRZSnZ4nD8kAAAAABJRU5ErkJggg==",
            } },
{059,
            new Items.Pokemon()
            {
                Name = "Arcanine",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAN8SURBVFhHzZbLThRREIZ5pbnDcoibwY3T3Qxbo/EBwAUR2CC+gxFdia6MJgb1GQRmSLiIz4DcNBhdQCzr76YmRVnMzZnkLL7M9N+nT/1Tl9MzRkRB44oh4Yoh4Yoh4Yoh4Yoh4YqjoFQoUi6XS7H3OuGKw0SMHW89prPtJymFQp5v+estrjgsYE4bS+Jo9BlEUKt5WHOafkrtihYxJUGlRJ3MdjIIppO4J5OuqEGgrbVZKuTz7V7afv0wvT5urrj91Mncu6WITvg52cM+a3FFAYHq9To11+Yo5v6BIQTB5qetLCAM2pJ1y97bxYhar+Z6MumKggTCRtgUv1wHQjYkkA4mWT9tXV8PZC95rluZXREgiC5pN4M2E9Yk1mhQEXwOZBCb7z2q0cf7k3TazEqFzXRGbPYQUJdaDMp9ixgcuMRiMonq7d7T6EBRFNHP1Un6/SKjmM/R+WqVz716eg89LOsF6PK9UxZdUYBJDMlNBmFOjJ21skzjMLaGYdSaRObk878MXlxcUJIk10yKucvLS/r04BYdbS7TCU91YzrmtTFtvJylGZh/nhlENqf5WkzqYZJYN+GKQHoIfYejRPoJ1/LKgnkYjLkNpJRYl5pTGYQ5XepufadxRQEmMcUHS1P0h7OFTOryHSzWmCkepOzglcza8uIH7HI/F7g3S8USb+3H83BFoDOoewulhpEvbEzM2dJ/h8Gr8oL9hal21m2cbriiAJPYVBu1IPCbhX+PHGTxF5v8ytlvYJp52NAqxWKBt/bjebiiBUZlWJBFgAGRaz2hMIdrfO5x5vYXb6c0+PqYz9QjbpmJSpm39WNZXFEjpUZAnSl7DexAYQ1+ACa7yeuONvszB1xRIwbFhAeM4VMfH/YZMS/79oorWjB50odZwLn2d5QT/2xscJjEIb/BzyFz6NeRGESgqH6nPcFitD0kSUTf2ACCy5TiGRzOcsxAH2SCgStqyqUird/jw5bPssON5bSHDj8v86tthbM3ywbi1DzOOjExUR6nH0+rPBw1On82SeOV/s4+jSsKCPT+bpXW+V8NqJSzQNBhcoazh7cE2OGDePzqfrqmVCFkstznwWxxRQ3MIIgNhOD4t7O/wG8TBm8JfX9YuGIvwPjOfI0+cPl32aDO3jBxxV6BSWQS2HvDwhVDwhVDwhVDwhVDwhVDwhVDwhXDgcb+AgDN0TpINCRWAAAAAElFTkSuQmCC",
            } },
{060,
            new Items.Pokemon()
            {
                Name = "Poliwag",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIoSURBVFhHzZRdTttAFEbZUmbsLiQQCZKwCAggArQSUsgCSLODtg8kwEvhIT/P3VJRPL6db1K7jvkS6kZUN+LI9rGxj2bG3hER1VCpCSo1QaUmqNQElZqgUhNUaoJKTVCpCSo1QaUmqPxbjDVSq9VyyueLFK8tn9sElW+BhxhrpfNZVjAmogGIWywW8LK3164USeUmcHNrY2ldPfqoVI4HiSRJIlEUydHtQuq7qwHFuOyHa/3v1b0ZVG4CcWfDNNAZpBLHcQiyfkQR0v74IDVj/KXL6/9rIB6GUZOnr4HzYSLOLSP7/bOwj8DjgQvTnf0PAk+HIomDesdA6298+OlR0udv8uPmRNLvX8Ixwvzf72nHekzzqZ5MJv68ywOrxAEqGRiJ1uVI0tTJbDYT5+MAjhGJqIzm5X2gXm/JdDr14fd+O5P5fB6WQvnem6CSgcCXl5/S63Wk0TjMwTEiMbVZ2J/AphxcjMI+AqvGASoZJjZyfX0UohCEaXMuCZ8NRGJ0VgPHIbB5MRYsjSqfliJUrgPfPoQhqBiGkGLgfvcuOIw6KN+nClQy8CCMyq5f/Hg41hYisR6XWwSOw4hF/q22W4ZlUMmwH2w+ZdjayIZI7CMyi7e22lv6FlSuA1EZxWNEIg7Te9AdrXyot4XKqiASI7sc3ZbYuPrbug4q/4VsNEH53DZQqQkqNUGlJqjUBJWaoFITVGqCSk1QqQkqNUGlJqjUBJV6kJ1fzf1Nha7s85oAAAAASUVORK5CYII=",
            } },
{061,
            new Items.Pokemon()
            {
                Name = "Poliwhirl",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIJSURBVFhHzZVbTsJQEIbdUmlNNHET0MYFQFiAtwdFX7hsQGEjGn3gtik1PtA6npky5ND8QLmZafLF+lHgy+kZekJEpoHSElBaAkpLQGkJKC0BpSWgtASUloDSElCWJTqNKAgCofjaoYCyDBxXf/6kRv9HCCqR0/jafYByExx3Vn+mWZpRc5AH+pGHXFkoN8EBw+GQ4jimNE3pojmg80bfBVUkqriy+4RCuYkwCiUwDMOlGCXNft1ltFjd88ZA4vm92wJlGZLLxMV9yZfXX76X4pIkkVWbzWaLyF33KJSb0AHRleKDbzOHsoui/Lb+e6Bufo3r9e6o270Rsix1lxAlTx9uX2Zyvm8cAyWiOBgcNx6PXFgeo7EcypH+bT96oMZNJhMJ7HSuF3F+2HQ6dee3B42EsggHVqtVGo1GMrnt9pVE+KvI5+o0sFaLZZCOHsjo/tNzHgCN0cOP5PD48X3vSCjX4a+m3vLi+eKvF6gTzxPOn1MWKFchcfev8tSoui/WsJVxrTyQh8o/tomEchUcyM9gDvQfbbqiKE5/D4tH2Ugo16F7Ufej7zi09vC2FKevcyQ/YXg1edp52PT964ByF/T2S9ycoJJHyGvzVeb/y8YxUO6CRvBA1Fr5TwxaZd+VAcpd8SO2DVkFlJaA0hJQWgJKS0BpCSgtAaUloLQElJaA0hJQ2oFO/gBNIUnAjK49TQAAAABJRU5ErkJggg==",
            } },
{062,
            new Items.Pokemon()
            {
                Name = "Poliwrath",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJ0SURBVFhHzZbNdppQFIXzSiB13qYvAGbStKOkLxBNXiA/kzajJnmR/g00+lL9Gwg9ZYObHnETtdq1Lmt9S9gg9+Oce9EDMwsaGYaEDENChiEhw5CQYUjIMCRkGBIyDAkZbsqzpGdRFJW7+vw+kOE6KHby7pud3v6yKE7KePX8PuRl2AUHTtPUTt5/r+QIJClFcSW/LTJUQC49+2hZNrA8z+3o4msp+WNJMhvV2Yvjh5L75vwukjJsk/TiWm705UlBADnm3P9vgmzpeDy2wXkth9b6SnlJ5vjEw+R50TwIp0B7jHXIEKBqELu+PrfHx4lNp1MbDGrBvPhts9nM3t7+XKoUxCCVJInN5/PyNrZS6W2rKcN+v78iR0G0F9vNzUV5ftRwulg0lMTWNQ22kZQhBPEJoclk0oi2j4uiFkE1kUG0KOr5iRZXVc2OqqrvVRBg/qkWX10NGzlfRYhRlJKsXlsSVY7iXjmMHtsjQwLJy8uzSqjX+/sOVFWEbJckBf3iwXW8J8bqQoYermR/XK3qxXxkFSFESX6+fPNg6fBzJYWKceFw48PEcYzDlbGBDNcBSVbSLyC2H4MeHt81cl4QUr7q7A7uq5BhF6zm81cfLC3fiVmWNe32+0oO36MgHgiSm7RZhgq8FyGGnzBCScodvl7kLTl+H/PZTwFseGfifBcyVPjqUTCK4qXMi+FXB+K+OryHF31q/gEZdsEBSFeO+ZkNP9UVdNcRf237XBsZ7gqEmz8Xrs3/ggx3xQtu+2JuI8NdqQRdmzEfN2mnQob7oGu+bosMQ0KGISHDkJBhSMgwJGQYEjIMCRmGhAxDQobhYAd/AArmCnlrAYEFAAAAAElFTkSuQmCC",
            } },
{063,
            new Items.Pokemon()
            {
                Name = "Abra",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH3SURBVFhHzZVNUsJAEIW5UkgWsMQbBLiI4MatpZegYOnKn0uoXAL1Ev5tqBrnhWpphkcySVB78VUlbzLwVad70nHOmYaGlqChJWhoCRpagoaWoKElaGgJGlqChnVIs8wlSeIv+XpbaBgL5PI8d483iUu7SSF6bFkaxgLBBy83v+x5+u7jeeC+Xk9clm5l20rTMBYIzi56P2Ka8XhT2c+XQSEc7o2FhrFA8G21L6dZXk/86+/6x3f36fsyaBhDN00bycm+2KrSMAZUAb1VJrm8SwowQHrfnwnKgOgelAHB2r8J4k/O854bDreDALnFVd893e6K6QnGvtmpn/hp33WVdBk0jEFLrtdrHzm3vM8KsdEo9/lw73iR6i3OflmwqIQ/XlAtkQmZTfo7lRI5aQP5rSpoGIIfRzUE+XqInMiMfDX1vQBJ9CRaIezJKmiogZw0PITeV5thwEEMGYhibT7d9JaWxPDIgY1n6soBGmpwbknFtCSuUREIyD3W8BwmG6J6D6TDnoyBhiHhK9ZnnxYTEX0tFZeq15WkYRW64eVPASoNIamqvF7pvSbfZRqWweTYGpBDWyPPxkLDKvQrD/Om03oIGrZBJI8hB2jYBnnNdXvtEDRsCyTDrCk0tAQNLUFDS9DQEjS0BA0tQUNL0NASNLQEDe3gOt+ghvllfD1AJQAAAABJRU5ErkJggg==",
            } },
{064,
            new Items.Pokemon()
            {
                Name = "Kadabra",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALdSURBVFhHzZY7UhtBGIS50moVYI7gbB+JndqRfQJJKDEiMT4BBScwTgw4QAWJjS8B9gnI/CCQqn5vz26L0VQLrbCgJvhKqHe189HzkDbMLGpkGBMyjAkZxoQMY0KGMSHDmJChIu12LUkSR3jtMZFhCOR6vZ5Np1MbDofW6XSqWN+7bmQY0klTm0wmdnHxxc7PTy2t3of3hOAz62hbhiFo8Ozss5MDRVEsHJxL4dfVpnXTJxTEFI/HJ7a9PXBTvP8uqV7n1yTu+/oxsb8/Nu1wt77Oaw9FhiEYOMsy6/f7lue5fWskbn8+c6Aptob3kLs8Six9CkGsJQ5clpkT/H1Vib3O7Pa6FgyhYFFkTpyEz26DDAHXEqbyYFRT5Nmd3Ku8JpD8/ilxQA5N8z1Ao6uKypBrCYM4oWrgufYgIxpkc4sEySpTL0MK4mEYCGJgf6de+JxywvtwnYJsnGuWcqStpAwB1h42xnh87M49TA1bhcif61qSGwTH0MEonQkC3Hu886ISzW3vzXO79EQpiHE4pkKGAC3iaBkM6mOFGdYkJLCLORAO8cPd7pwcG/QFP7ytoSg+i3/6vjZlCCCDVvxvDWSYXqw1NIhXbiB/7XFJQO509NLhS1IQ92L6Hyzo7zjK8cHYLNg4PBMhi8YgkTevkDlpGoRw2OJ/CfpQDmuOuxkPZltck7hGCUiySf/+sEVOdTgmkWFIKIhmsYF8Gf848nOIUUQJ3icHZKiA5OTmfbVr7zYMJP2WFp2ZoRwFkS07uGWoCAWZ+efl9GavEtpygrMDvRH2pxhyaG6ZHJDhIvwzC3Lh1yAEy3L+xwTlOdVtxYgMlwE5/2DmoGwY52JZlrPWfLnwWcuQYRsgCSm/DWT+NV+UTa7SHpDhuoAo1yhZtUUZrgPIocFu0yZ/gYf3LUOG64DTzL8py+ttkeFjAMkwa4MMY0KGMSHDmJBhTMgwJmQYEzKMCRnGg238A4iUnNf+MsJsAAAAAElFTkSuQmCC",
            } },
{065,
            new Items.Pokemon()
            {
                Name = "Alakazam",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALmSURBVFhHzZZNVhNBFIXZUv8MxB3IrJNMdAnoBhLJRHACuAGOrsCfgYoDODBR2QTKCjg68IdBgmXfDje8rr50t+ngqcE96dyuVH91X73qrDjngpY0Q5I0Q5I0Q5I0Q5I0Q5I065SkqYuiKL/U95ctadYJgD9O77g0+T+Q0qwTAU9eRy6JmyGZ+KKpVwxbQlzTp+B9fBm531+vU1QQ9LCYi7PVhROvGJh4cr6dTxjPP/0xcZKUHsxrfrdgXeCgikFA9313LkLapADw4mnkfn25BlHqAgdVDAU4GPQKqO31e67Xy9ynqxIrIKuucJA0fciLs7vu2aMZ3M/T1aJB6gCR7OdXkev3s3nilP+sJkkTgCjhYJDlUL2SAHhTaTF+b3MGh0VAgHy3ed/tbz0ohM7/F1BpQoAcDoduOp268XhcwO2sr+WfsxI/3ypDAvrycpJ/piVABdnP52oLKU2oKPNk4o6PP7ijo/38If0bAQEX58lg/MmbtASHcf38NwTcfbhWCPO0Kb00IQXol5pwfmIQUuNYLMyCwZue75QaUR1nUMWgcNahxIeH793GxuNiUru/2CQEZFKEGo1GcntgYX++6WNMSZqA45HCB6KsAOMmRxMRlIkxKfwOcH76Cq4JsmKgtIRjGdnN3CsYg9cdgQlry+oDci6oU4IWkA+DUF40gh1ngflqIyhKbLeHv1iqrkEgaaLE+KFNqWkiQGZZNXVf7GYcNdg2Tf+IpEnZlNqIkISxsPYcXAogHnZw8NYleZr+PSWM33sy62a/o/3k8B0NFbdYvDShtoBM2cIRkJ3PNwnSwv7mmdgJEMJe9D0r3MdhjtcbE0MzqRS5Vew26LwH24gJEhRg6HZ4kF8FjGfzsQF5T0mai4igTIqeBcR3bAX/1VgHKc1lClD2mukhaQLaRfmS5m0IcPzzgUSRZBMcJM3bEADtFrhKNhxApSY4SJohSZohSZohSZohSZohSZohSZrhyK38BfXbiJDkQhHbAAAAAElFTkSuQmCC",
            } },
{066,
            new Items.Pokemon()
            {
                Name = "Machop",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGpSURBVFhHzZNBUsJAEEW5UjJs2HqESW7gEVxyBHHjFYBshBNQ7NSVuvQE3kCXSJuP1dQwfsIkoaSpepXwkpBHTzIQEdNQaQkqLUGlJai0BJWWoNISVFqCSktQaQkq2+KGTrIsOyA+pytUtgFxnx/3UpaFfAXbocvrw/yaNlCZyrG4dVXIeu7F5f0nSWUKWMZjcUXhxXt/lqWmMgVMbzX7DdHA1dTv4h5eHmX59lzvF70jqUwFN0cgllOnpnFK7lx9Kr8+BSpPkee5uPrGCEKEbsH3dit3VSWL16fLBGJqRVnKZDY7CAOL0Ujer69ku9nsI/suM5VN4GaT+fxPHMCxZR2JDwJ9HXc7ne5Cu06SyibiwJvxeB8IH4LA8JnsEkllEwhEnEbGUYoe07h/CwSIDCcZhmKiIPyOOOzj5Yp/6xRUpqKh4ZQ0JgbnxdenQGVbwkhMTCeqf6BrHKCyDWGc0mdiMVSmgoj4ZdAJXjwQAeHzpfsh54ikMhUEaITumwpkICp8HvtGUtkXnabJCZ4bKi1BpSWotASVlqDSElRagkpLUGkJKu0ggx+sT0XdhTvu7wAAAABJRU5ErkJggg==",
            } },
{067,
            new Items.Pokemon()
            {
                Name = "Machoke",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJnSURBVFhHzZZNVhNBFIXZUtLZSH4mgiOUScIK1JHoRHSCjvzZRIBJlBUQWQVHFwCHTHIs6zbnhpfHjamYHrzBdzp9k6r68uqneyelFBoZRkKGkZBhJGQYCRlGQoaRkGEkZBgJGW5K1emkVqu1wH+/DTIspV1VtVC3+yRNT4fp6nyU+v3dRiVlWAKqdnN9kgaD3XR7/XFxnf3+VItWVTOSMlzHKjlbwaaqKMN1QPByPKxlKIgpxv3302m6OL/KFazyT3X7TZBhCZDk2oNYr/cgB96/+Zra7fbW1ZRhCRCcjC+z3N6SGO4he3z0OV/36uto9DJL3sv6ftYhw38BMQwEOUoRTOtkMq6rB6zg8dGXpar6flchQw+lwLvX95WxVaPczX43/ZnP04e33xaSxEqyon4chQwtOOsg9ePs56PpgyQy3HshVs9mEEP72/1eushtSzaSDAkqRzkMQMnh8EU9EGWtBMRsTlHmlLOV9+NaZEi4ESjnB2QFKTvP0zsYPK1zCts26INid8/7afaslzpr1qMMia8gB+JnrsPDw1cLWWZekNJWcuspBpS0AwLsRspTkAPb30GOm4t/lFf04cfzyNDDXUxRdmzl7S4FEMO04yDHcxntuVw2OWpkuAqK2ns+8iBy9+vhecy3G/vS4NuXIMMSWD1UinKzg7zw80sEJVHBTYU8MiyB5yOndHo2WqogdzY2VclaW4UMS0AF8bLAXc11BZBTjn/gfyVlWArXlJ9GTj82Dil9tHlk2ASUtMdQybnnkWFT2AqrSpcgw0jIMBIyjIQMIyHDSMgwEjKMhAwjIcM4pJ2/y/Pz94j4KDgAAAAASUVORK5CYII=",
            } },
{068,
            new Items.Pokemon()
            {
                Name = "Machamp",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKKSURBVFhHzZa9UttAFIV5JUsmPZTpJLkxpmJS0YWfF0D4JYA8gXGKkDwBDlWGRiZdOpg8AE7SOFz2KHPE9eYKy0GTWc98s9ZZz+rT3R95TUSCxgxDwgxDwgxDwgxDwgxDwgxDwgxDwgxDwgw166+60ul0Fqjr13lbmCHprsdydDKSNMskV20URZVUkiQyuz2RXi97VhRjsb/uNxZmSFAdSxDtZNSXLEsrObS/vp9VosvGaSpphhoMjiqlaVqhpbTc1Xjg2JI4Wi7ImdC/szBDDQbvvz2Srf3jEgha1YMcMj6EXyFMsX7Q1gQBJTGwXzVdSdz0+GxcwbWKMSDIB7UeoA4z9KkTZNuNIyl2NuRhPpfhu/elRH56viCK6vX38momQKetCgJOkT+9uL55synf8l15+D2X7cOhzO5OZftgURJg7WnJVgWB3jAUxfe5qxw+Q1e9H3d/NstgPy8FIaJFV5U0Q+KfXYC7EWJ6zUGMOxniuo8yF5Op6+u1I4hqfbgsygEvJost1yKEiN7FWo5HysfPN/Lp6msJJV80xc8J4oasogb9EKAcBXUfBVvZxZD0D1g8uX/DwcHQXU+ra+JLkqZywAw1kOT60wc2pgcVpiA2gp5GZpDzZwBtHMduePueGjOsQ8vyGrsa1aU40RX7b4Iays2K1J2HbtO49nr82gk8vc6+jJ6u/Y3TdJrNcBmQ068tUOxsys9pUsmiZR+rrvHHrMMMl6HfqwDr8b5I/qogQOWa/CmowwybwPVIUUiyOnzb6Gn9V0kzXAV/4zDD8QQxXWX2r4IZtgElcfRAFG3Tnasxw7bQ1dUVXgUzDAkzDAkzDAkzDAkzDAkzDAkzDAkzDAkzDAdZewTY1akf6mYTSgAAAABJRU5ErkJggg==",
            } },
{069,
            new Items.Pokemon()
            {
                Name = "Bellsprout",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAF9SURBVFhHzZQ7TsNAFEWzJXuMFxAq0tlmBdDBCiCsIMkKEDtANJGyg4iGKA0Sq0CiSJHy4XF4yWi4Y/xDusWRPccj++iNkpGIUAMlE1AyASUTUDIBJRNQMgElE1AyASUTUDIBJRNQNsEkZxJF0RH/+VBA+Rc2bvd5IfuvyZHE/E8klHXEJvkV50YOPVEo60DTcwN1z1CRUIaoi9u+3pTcSlHkcvU8kSgmCLQT03UoUKfZ9eihDBGaoB93/XIItEGztztZbKeVU++/tw4oQ6BAjbOYnx9JlmUy39zL+cNYxtMDs3JtQy2xicvX4W/4QIlI07T6cJ7nFZv1KUzjdK8eq05PJ6hT1X1NgBJhA3fLpexXq4rLoqgidWq6z8a59/aZor4NUIaw/4F2iu/zR/lYPImJT0dln/WNQUBZhzsV37lrve8LlG3xg/zgPkDZliZT7QqUXUBTdK9dgZIJKJmAkgkomYCSCSiZgJIJKJmAkgkomYCSCSiZgJIHGX0DBBBEmBFfmZMAAAAASUVORK5CYII=",
            } },
{070,
            new Items.Pokemon()
            {
                Name = "Weepinbell",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIcSURBVFhHzZa9UhpRGIa9JVigDx10+9NgqVcgVkk6tVJLbRjb2Dg2maSRkCvIeAOOqRK9AP8KlM991/ngcHhZwN1MvuIZ4GEHnvn2nANrImIaKi1BpSWotASVlqDSElRagkpLUGkJKi1BZVGCWl0qlUqG/96qUFkExO1vfJBvuy35vteWoFoskspFVINa+jDrEfd1ZxJWxhSpzAMRWxcdqQbTX+xOrujUXKich8ZtD9anAuHDMJSDjaYcbjYlisJS1h+gkoGIVq8l3R/T04NHzN2fjiRJlMZF8qsfSeBN+L1QydDptU/aUnFuITziTo8jefjbkafb9fHzWgmRVPrU65PpIVAjdXKI0rAvR5PQeYHYZMsuASp9Go1GFqhxShiHcu8EMtxIXQ77V1vpMqmOfR5U+rw3EGsSQQrCDn9vZ5QaCHSTzAu8HEQZjzdvrxHX7b/t+IPr7jjsnwUCN9Kf3mj0nF4icvkzkTiexClu5LJxgMo8dB3h3HOnh2NlOByml0g6veT/BQI9WnR6CBy95E9QI1eJA1TmgThMD4exrjeNdPEjcbhj8v7nLYLKPHCG3fXOJInjcSSLwy8K0B3sf86yUJlHdnvTwKeT8yxSQ1z6n3Zl8Hkv/dOw2u1kULkInSIiXRCllBEHqFwG3c0XH3dmworcUh8qV0FDi661eVBpCSotQaUlqLQElZag0hJUWoJKS1BpCSrtIGuvfgsWuUJZzh4AAAAASUVORK5CYII=",
            } },
{071,
            new Items.Pokemon()
            {
                Name = "Victreebel",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKVSURBVFhHzZVBbtNAFIZ7pdgmEhIXaGBjO5v0Fk1WwA5YtfQCUVjSTcUSFgk5QUIuUOgKygHa0kVSPfzbes7L8Cdx3CDN4pOc357xlzczzwci4jU09Aka+gQNfYKGPkFDn6ChT9DQJ2i4K2H0RBqNRol7/zHQsCoqNOi1cpIkydmnLA23EYRR/vLD/qGcfO9K0i7ETi+70hsfSRAWYvqcjqsDDTeB5YRYa9DK5d5f9eT5h+U1sJK6/Dp+V2i4DiYHmdMfSzklCINsyHJcXUkargMviuO4XE5XymKrqGP1ehdouAmV7I46K5XDPnSzfVSRhpvAi4Yv30hqqqinV1FRK6hj7e8q0HATrqCeYIZbsf8qqEt007+QdprmAq1+S+K02JOLxULa7XZ+PXr1VsJgtXo6h5ttg4YW7WXHw44kaSK3meD94FMp6QK58et3/wjW7Yk0VDApxHAi0VoAKqaS64j2VD1AQ0UFVc5KolquqFZ1OkokdFoMqmfRe9ugIWg2m7kcehkm1AYNGkFDJpOJpM4yT6dTmc1mMhunGYUkxp5cHpetx7agKqI0BBC0E6AKVhJVRKU+f3wqDw9ziaJI5vO5fDl/Jt++xpn8sg1hiyi2T7rNnEFDhivoSip3vzrZaS7k8I3Gc/Y7bcVQAF0l930KDYFWcFsVb3925P730QoQRAtyxaycnXPTUtMQQHAyjMu9pLlOCFFX8OyqK3fXhSD7VldZUhcaKjjFVtJWFPduSPUAnscexCcPUnZJde6q0NCybgmQQ/7PdaesnMop7p+qAw2roIJW6EW2LyfZCVY5d0wdaFgVuwUUrZr7bF1ouAu6BR67lOugoU/Q0Cdo6BM09Aka+gQNfYKGPkFDn6ChP8jBX/+CvdSgwRyoAAAAAElFTkSuQmCC",
            } },
{072,
            new Items.Pokemon()
            {
                Name = "Tentacool",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIuSURBVFhHzZZBchJBFIZzpZnBC3ADZtgQWSU7dSOWiyQ3CHgKdWXpQqtcMIELaLwMERZAnv331MO2+VNhBohv8RXF313DV//rnuJERExDQ0vQ0BI0tAQNLUFDS9DQEjS0BA0tQcN9aGWpJEniideaQMMmPGtlXmp2diaTPJfCcQhRGtYFcrPxV5kUhTwf/pTT0S8Z3MzlzWQhedHdS5SGdfByrrXF+bn0nZyKqVzpmkSjIGsgScM6qGDXCQzKuy25eflN7tdrmXa7/0cQQLJ3/WNrtBBcr1aymH7342/SIg3rshmza6s/uvWSkC3zSkqZuz2tpxaEXKfTqcbpBMJzGJ5BrOGcPqkg3nk62ty11QvkdNyQvGsoB2i4C+G5U8HwkqikruWuxSavGxruQigYyuE7mmu/+iLtl589veHtpmGsJ2nmHsGfG0PDXdHzh3YAJFUsSVJZLpfSf/d3/NpoHUkaxkDkofHoGtqE2KD8Lav1PfbJ2+m/oz6KIASuL3py8+FSJh+vJEtTF2/vQZPtF5+8IKRwObTZpu0BGsao5Ojq1JOmVZuKriF/PZ5JmrU2uV4OPa915AANGeGYQ9lQGC3iU/djH9Y017U60PAxwv98D/0o9kBseFlJxuu7QsNDER6NppI0PCQqiUuGC/ZY8zE0PDR6fsfvL/ybABRFdXnivTE0PBYQDSXZKyuGhsdE2zQ14n2goSVoaAkaWoKGlqChJWhoCRpagoZ2kJM/dbQB6HiXOyoAAAAASUVORK5CYII=",
            } },
{073,
            new Items.Pokemon()
            {
                Name = "Tentacruel",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJ2SURBVFhHzZZBctMwGIV7pdg9QW4Q25ukPQGwIbChPUJ6i8KKoQsYNnHNhoFNSi6TUm9SfvSU+ZO/4rmRUzqjznwT5cWxvj5Jbo9EJGlomBI0TAkapgQNU4KGKUHDlKBhStAwJWjYl/z4WAaDgRvuxvr+qdAwFpVZjcZSFYUfv56v5E3TyuRiKYMsf7IoDWOA3Gr+WdryxMtN61svNnx1JbfFibTFxHM6u/Gi4fdjoeE+vJxrDQKdcvUX+XN/L211upU8pE0adpHlm0lGo5HUTqw0ckywbb76hu0vkuW7/RoDDRloDfurKCsv1wSCkKuL0ud3xaZdS3g9RMM5GDRkhIKsPRV8IOmabMpN/tZdj8Mzvb6LlqRhiMrhpl2C9jOVDIGgvf5ZBFUEcngt3MQYo8GRazAU1CbtYXoWQRwMOwHk1uu1fKuqB23aFrvkcE3sQaEhA5K4abjUkGACaFY5VA7Q8DHC/RgK7CP29Co07ALPQbvU2HfT+vc/Ehbbpm1On6n6vgsahujyzi/fSVnulk0F8Tp8+ckznv3aPkZUbnY2lovzyVZS75Vnmbs9n1OhoQVyuFnz4dzL1Zdn2zEmHL74KIubH5K7RhaL77Jc/nSflf4zCySv32++C2LkAA2VfXJoUVvCicZP5U61CmlrFm0Q94+BhooKqhAEwzEk8dehcM9AKwJU0or2kQM0VFQQy6H7hgnqfrOtYaxShy4voKEFknaskna5H5PUsS7tf22QAUmdyO5Pux/DvdpXykLDWPAs00Yhof/tWHmlz7JaaNgHbbRrrCA7BBqmBA1TgoYpQcOUoGFK0DAlaJgSNEwJGqaDHP0FW/LGN1RKm6EAAAAASUVORK5CYII=",
            } },
{074,
            new Items.Pokemon()
            {
                Name = "Geodude",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHASURBVFhHzZRLUsJQEEXZEskLe/AzSdgFyMBSN8FngroRUQf+NhaqWm6gsXl1ExKVqh6c4tV5Sfqm6ZeeiLiGSk9Q6QkqPUGlJ6j0BJWeoNITVHqCSk9Q6QkqPUFlHWnIpN/vb5Z8/xRQGZOkoQqW57m8r2aSpslG82sZ+mJKvN8ElZbBYFA99O1pKp8vcxkOi04hEQ736n347RKSSgsCxgX+GrDL/VRasqxdB3QM2BqjURQnCgjQBS2ynI3kYT6WJNkG0PlaTrf+Zny+CbAdBw1hu4hnaNg2IalkoIiG0IAIhsIazIZT4pBsrwkqGShwPTqT+10HwXDXCVtUwf7H80+XbMB4rwkqGdpBdAkhEW69Xsvd5HLfNS3MQqLbeEFcC68jcgwq67Bd1IAhhKozt1cXB0Gxj3nFCxVFvl/H83kMKutAQBwWFEMHdI1AWhxr7JVlKV+viyq4HQtcl+xOeBuobAIh9RMSQnpwcIAGR3cfF5O9sye97d8LqOwCvnNxSIsNY7+PbaGyK9pVe8q1a/G1XaHyt2jQ/wimUOkJKj1BpSeo9ASVnqDSE1R6gkpPUOkJKj1BpSeo9ASVfpDeN9NiEF1ViCT/AAAAAElFTkSuQmCC",
            } },
{075,
            new Items.Pokemon()
            {
                Name = "Graveler",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJKSURBVFhHzZZZVsJAEEXdEgmwD4YfPW7C6cNpAw4/oBsR/XFYGXBaH/qwKF+HluNQH/ckvCTdN1Wd1q2UUmhkGAkZRkKGkZBhJGQYCRlGQoaRkGEkZOip253UarXeTvX1UjYZR4YWDPp4N0ovDzeprqvFBMTfm4Nidhx/Tw4ZWjB4r9dLT5P3wc8Od9L4cj/dXB2kqlo/UVW3vzzf7/eLX1CGpNPppNHF3kJm8DYoBj7Z306nB2WSkEPVBoPB8jmMQdmSSsqQdLvdZTshigmeJuOVSlKQbbSVscsDklYOv0uqKENPXdcrbWJFbBUpArhW8Qyl8EJ4OS+6rooyVLBCmNTK2aoCZOD5fryy3uwL2HvXrWMZNoF1hXZjTULUy0HMnrNC6AKey13PIcN1cG2hXWiVbZtvIWDL8QzFSqoHZNiE3TZyYhSnIGRQcWQUpLgf3yPDJiA4nU7T7fXRciJK8DdlrfDoY81+Rw7IMAf3tfl8ntrt93M7qcdXkpTKARnm4NqDFMXs9oF1huqeH+2urEO/xeA+P3YOGTZhN19Ojq1mNpul4XC4OEIQ2xBfAOdYg2hzyYdhkWEOyNnNl5IeVJdC/LPI468Lcg/kR0AozDb6zXwTOSDDJmyL7ddppSHLdbppa4kMm4Dg8d7nfyaYHBK25Vx3/yIIfBXZUkgDfLFWDkdcr6ryr5fIsATsidguWE1M7qUtfy5IUE3uazynOMVw/M7eZ5HhT2BlN5UDMoyEDCMhw0jIMBIyjIQMIyHDSMgwEjKMQ9p6BS5QyIN15oBiAAAAAElFTkSuQmCC",
            } },
{076,
            new Items.Pokemon()
            {
                Name = "Golem",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJUSURBVFhHzZW9ctNAFIXzOpS2hHugorSkRk7HTxOGIknFAE1+XiBAE6BK8gL8vYTdBfIEvIUVLjrKnGS9cyzZGWvmFt9Ye7TSfntXu94yM9fI0BMy9IQMPSFDT8jQEzL0hAw9IUNPyPC+JOlDGwwGDXHG9rrI8D4Mk9TOzg7s4uKoYTgcNmLM2I6f60KG6xLLgTzP6uxwIQMQjZ9vQ4ZdhEsJdndLOz+/k1kmB/b3J7Xk6pWUYRuQOz3YsS9HrxryLLO9vdKy+jdECW5vP2n69iLIqr15Nra3zxdFVMXijHJ4Zh1JGcaoqrXJEdyDDJYVUI7tVSRlGEK56+vK3r8s7PPhTiNIqWWCYcVIKLcRwdFoZPP5vBHDskKOFYQUB2I1lVw4kVAY15PJ486jR4Yh8fJi1ty5lAthlXAdVxaSl99P7OrnRyvy3MpyA4IA5xwqmaZp3bxpQxASHJBgYCUXCwJUeiOCAJXkL3aykiNKMpbjavD9y5BhG12C/BTijRT2x/0/Pz5YknT/q8iwDQiOx2Mph8pVVWVfj18vHODIrn59WpDDdS+CgFX8HUhisL9PH9i/an4riE2AnZpldxOiICYTv1chw1WA5OW3m0HfvchvjyAubyjHqrJykDut+/fyDRJWEedjeEbyGCrLR41gKFkURbPkkGPf+L0xMlwVHDc8IykW3kMboA+qSjHSuyCgSJyHhBNZRw7IsA/wSUyn0+Z7nc1m9aZK6lj3DZFhX0CSyx7fW4YMPSFDT8jQEzL0hAw9IUNPyNATMvSEDD0hQz/Y1n9L2tDp5qkY3gAAAABJRU5ErkJggg==",
            } },
{077,
            new Items.Pokemon()
            {
                Name = "Ponyta",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKHSURBVFhHzZVNctNAEIVzHVjFksr7wAkk+wR2OADkBv7ZsYLkIlBkARUu4JANVb6IHWsB5UZv7IfHw5Mjq2JqFl95/DSjfu7pbp+ZWdRIMSakGBNSjAkpxoQUY0KKMSHFmJDiKUmz1DqdTrXUz0OkeEpg8NesY1nazKQUm6AyUZcd6P4aBu2hmUkpHoImEGR+eWFptcZ3amHQJE1s8eGFZcm524P1+sf5aQwiGEyU15sg+OQaAbGGkfDMz8GFzYevbPXx8F6FFOvwr4fGkEUGDwNiPzOGfev73dkm5oAUFb45QGOgX+RWFEW1rf6Mvx+oWlVI0afb7bqX5Xluv70MzIe7gKvlyMpyYlmWVEd2dcoz/n6V6UNI0QcGv34aWK9XVLW0CfA32NbY/M1r1yzYD3OoOVwnjPV7uTuH/WwovrsJUgxBUN9kaA5XvNx2KmpuL2PVvn6/ONoYkaLC1dNiVgXruXpbLsfOIIEJloBriOXMrHxwlOX0n+tvaliKChpk0O+3l5ZWc2yx2GSS2UTWfHM0iOcwyaZ59n8SNwM9g9k2EzB4dzu01ePY1uX9njFAc46bl0eNGCDFOphFBJ1Or+yxMoXANIg1Te4Zq0B22WBsqCZIsQ7fIAP75kJQl36t+t3eFCnWAYP+lYYGQsLnbJRjkOIhYBIDWHUy8M1jJGEEffs8sLsvQ9dU4fueQopPAZOYi9fvC1eH/jWz1jgLcaX4QePxO0uS/5BBQIPMCruZWWT2WG+YACcf1D4IyGtmYNYnDbY1FCLFJoRZwXcabNMMdUixDcjgaPTWJpOrVrVWhxTbApPPdbVEijEhxZiQYkxIMSakGBNSjAkpxoQUY0KK8WBnfwBuJioojqnvcgAAAABJRU5ErkJggg==",
            } },
{078,
            new Items.Pokemon()
            {
                Name = "Rapidash",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKHSURBVFhHzZVNctNAEIVzHVjFksr7wAkk+wR2OADkBv7ZsYLkIlBkARUu4JANVb6IHWsB5UZv7IfHw5Mjq2JqFl95/DSjfu7pbp+ZWdRIMSakGBNSjAkpxoQUY0KKMSHFmJDiKUmz1DqdTrXUz0OkeEpg8NesY1nazKQUm6AyUZcd6P4aBu2hmUkpHoImEGR+eWFptcZ3amHQJE1s8eGFZcm524P1+sf5aQwiGEyU15sg+OQaAbGGkfDMz8GFzYevbPXx8F6FFOvwr4fGkEUGDwNiPzOGfev73dkm5oAUFb45QGOgX+RWFEW1rf6Mvx+oWlVI0afb7bqX5Xluv70MzIe7gKvlyMpyYlmWVEd2dcoz/n6V6UNI0QcGv34aWK9XVLW0CfA32NbY/M1r1yzYD3OoOVwnjPV7uTuH/WwovrsJUgxBUN9kaA5XvNx2KmpuL2PVvn6/ONoYkaLC1dNiVgXruXpbLsfOIIEJloBriOXMrHxwlOX0n+tvaliKChpk0O+3l5ZWc2yx2GSS2UTWfHM0iOcwyaZ59n8SNwM9g9k2EzB4dzu01ePY1uX9njFAc46bl0eNGCDFOphFBJ1Or+yxMoXANIg1Te4Zq0B22WBsqCZIsQ7fIAP75kJQl36t+t3eFCnWAYP+lYYGQsLnbJRjkOIhYBIDWHUy8M1jJGEEffs8sLsvQ9dU4fueQopPAZOYi9fvC1eH/jWz1jgLcaX4QePxO0uS/5BBQIPMCruZWWT2WG+YACcf1D4IyGtmYNYnDbY1FCLFJoRZwXcabNMMdUixDcjgaPTWJpOrVrVWhxTbApPPdbVEijEhxZiQYkxIMSakGBNSjAkpxoQUY0KK8WBnfwBuJioojqnvcgAAAABJRU5ErkJggg==",
            } },
{079,
            new Items.Pokemon()
            {
                Name = "Slowpoke",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHRSURBVFhHzZRJTgJRFEXZEt1CaHQBIBPZBc1EHRmdiK6gpDZhwgZQVqFxgMAA8ckteJXv9yJC0TySM+BUJXXyfpMSEdNQaQkqLUGlJai0BJWWoNISVFqCSktQmZR8Pi/pdDrGf74JVCYFgcPgTibd+4hcJrN1KJW7QKfoh/rvrYPKXZLL5RJFUrlr3EjzgYNWS7IbRFK5SxDXbzSiMOVogf71Avy4vQdqBHPuYVDKpZIUi0XpN5sbxwEqV4EQnQg+pFPSMI0BH14sniHyYIFg/Nj5ERVUKjIKOhKeVaXkRW4zPUDlX5ycln9NByAUHnGI1P8ad5BA/9Jl6FKWlxPUONCtViXj7d91UMlA3HQ6lUn4EMfgo1+z2fyxxB4OcXoo3LiXfe5BBF43CnLTKkY8t5pRnIbjN2i3jxOIw/EUnMv47VIm71cRt+1F6Gz2OX9l8UOghrhRGry3PYjA4etFHOeCUERiid2JKbrv/Lvzv1DJiA7IMhJRo/k0e2Fdet16vORsabeZmguVq0AkJoHlRhjIZhbTKRQK0T3oLvHBAxUNdZdND0tYq8WBSeMAldvihrvxSaDSElRagkpLUGkJKi1BpSWotASVlqDSElTaQVLfrUdIdtiWpkYAAAAASUVORK5CYII=",
            } },
{080,
            new Items.Pokemon()
            {
                Name = "Slowbro",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALbSURBVFhHzZZLctpAFEW9JRDOPpC0CpuJISsAtIFUMokz82eC8QLyWQGYicteQT4LyG8A+KVvw1Wal6cyBFHVVJ0C37bow+vuJx2JSNSYYUyYYUyYYUyYYUyYYUyYYUyYYUyYocXxi5Y0Gg2PHjskZqiB3OjkRB4GA3kcDiVpNl28OX4oeTPUQOC+3/dy49NTT3MtBCC/HF3KbWeV6+sBvkNn22CGFphgProQGV9tkGeZLFwO+aebS2mp6vLayWQiSZL8M/YcZqipkpPlUh6LwotB9N5tAS5/WLGDC7aOE7l41Zar16lneeNknVyr5cTnc5Hb6429if+nELYAPs9ms8MIYrLvn9/K72/vSq7fZM5v4YZXL1TREsxcVafTqX9P09R/DiXxf88dLDMkfqL3ZzL71JNfX8+9XFH05OeXc589OUnKhYK8tt1uy2DQ9WKoYFG8lGbwI/r9s/LvKsyQcJLFYiF5nrtlTp3c32pCEkv+MNxsP9hzmJzVg+Rw2PNVxGdIYRzZXoIAk2H/ZVnqJwAQhdjdx67PcTi0IPcd4BJbopynCjMkqCD6X76WCiVZVcrhJFNSLy3BEkNwm8oRMwSUw6RozNlakicZsuh/uvX4vriWxw8J9x/laqmgFsSdApOXFVzL4e7BcQpyKSmj4fjegthH406nnFwDOT2mJQBaEnomvm/XZTZDwlOMyZZuj4UivMXpjO+WqGbvCuIhAHvvh2vU6H/hl2Ny7DXe6kJBVBYv7l1LtJZDQsHph27ZqEmeZ6unmOBAoKKQxMmGHMBLVxOft300M0NAQVYBkmjMIWw7XGocKIC2hHeKUQ5V4yOanq8KMyR6mXUF9R6kIHohJP5nSTVmGAJJ/mrel1k9LCX3XyjHa3kdYLYrZlhFKAtwwnknsQTrwAy3BcLslXfqUaouzHAXwqrqsToww5gww5gww5gww5gww5gww5gww5gww5gww3iQoz/wEOgB0Sc7rQAAAABJRU5ErkJggg==",
            } },
{081,
            new Items.Pokemon()
            {
                Name = "Magnemite",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHVSURBVFhHzZRLTgJBEIa90jwg6i2Y8Qa6khWgK13xuATCisBGPQWEDYSdHkUXM1p2tRS2nR9xxompTr4Evp6m/6mi+4iIVAOlJqDUBJSagFITUGoCSk1AqQkoNQGlJqDUBJSagLIM9XqdgiCw+HN/AcqicLgsy2izWVqiKDIaP1sUKPdRq9V2VZJKSeUajQYlSWKpsopQIjjcvQnxaAL0e23q9zsUhiFN5hlNl0RperYLOFnkFEaxWYZ/qwhQIjigWyUJwuH2UUVIKH24jX44Js9zM/05ZttQb+9fnyWk+7cQzIB7+UDpwpU7vhzSSXNE3V7HttYPJ8MNxnDb1+vF7vAw6e0TJTfPFIS/O0hQuqDWSsA4ju3plSEBO9MxJWm6CzcYXNkXY06bd/ZlgyDkJXBPFyh9/NPLuMFkXM/GJtzI4gbka8dfbwbcywfKQ0hV3Ta74SRgz5x2CflyEdHreUBxgXAMlD/B4VaruW0bt7o9GX4L5sLXULfbsq19MM/yFRX+R0DZlANwu1rbkFw1Cc1z8nyZ1gpQHkI29b9LZSVcFUBZBr+y/nxZoCyLX9kqgFITUGoCSk1AqQkoNQGlJqDUBJSagFITUGoCSk1AqQko9UBHH5dcSmZg1FJqAAAAAElFTkSuQmCC",
            } },
{082,
            new Items.Pokemon()
            {
                Name = "Magneton",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJaSURBVFhHzZZBUqNAGIW9UoDKPUJyEY2zcNyZeIkpXWXixrmFOhvdWeVlQmz79fCYn66HAZJFU/VV4DWhv/6hG86cc0kjw5SQYUrIMCVkmBIyTAkZpoQMU0KGKSHDMeRF7iaTid/V7WORYcyhztE+u3p3kyz3h/qcscjQMp1O3evrk8vz/5IUJmxHW5ZnrcEcW1kZWiCIDmazWSO0edq57V8XmM8X7u3t2f/OQ9ujPy+rhSAH+dvbS5dlWciGIsMYVgGSm+eqkaPganXh1utlgCKsJAfGaw1Fhgp0iMrtP/1RvT0YybIsGxGeaweS5UWrHft9xGWowEV3u53fbW8/Hu7dcnvnyvoWg/PNL/f7Zd/IcVA4FxW+uTl3f/yA+Ch8hwxjIIdbVVWVP2xv6BRyj77DdX2rUc2LWtJWHNti0a72IWQYE5aRWrAoilYlbQXRMcAzSclqvw/n8X8U7CspQwtmMWdmXEUlB5QgtyD4892V1x+91k0ZWrjMYJ+V5OhJyOpOV6vLRg7ygJJ8Bvk/XPMQMlQEufptYS9upa04MitJMf6vLzJUcC2MMyvCmcw2yo4RIzLsA2e2rVIseQpk2IVdYIFdjJfbfxOGjH21xchQATkssHyl4XnDa8+uc5zVtpLHVlOGMZDjUoMOIQrB7xZu9X4egwxjeGu5D0F0ygXbLt5WkDPXfuEMRYZdQM5+mOJYvVUgxkH4rTXAociwC9VRkPYVsmtgk5/gK1uGQ4BI10fpMZUjMhzKKUS6kGFKyDAlZJgSMkwJGaaEDFNChikhw5SQYTq4sy/bJPJEv3DfjwAAAABJRU5ErkJggg==",
            } },
{083,
            new Items.Pokemon()
            {
                Name = "Farfetch'd",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJTSURBVFhHzZXNbtNQEIX7So5N9sCKiI1jvwhEXZS+RUg2bVgh2BRegL8Ngg2lGxAv0qReJNVwz3VGXKzj+LoJYiJ9snNi636ZmWsfiYhpaGgJGlqChpagoSVoaAkaWoKGlqChJWjYhzS7J0mSuFP++77QMBbIvZs+kY+ziaSDgYv4dftAwxggl+e5vJ8+9YJFMf4nlaRhF1o5SIWCOD90JWnYxSDN/hJcTMby4XktakIQQFJbHFs93IMx6DMKNOwi3BxNmKTu9PAeXBcjSsNdhHJobTH+M4fh4ux65Wb1RqrqrSfLdledhiH678PvOn/jrdzt7UZeHJetc8jEwOv5QxkMdleRhspwOJT1eu1Oxf3TDAefQ1LnD3L4Ddd9mh/7quqiYfVCOYgVRb5/i3cJ6sIQLMtSNpuNF0RlsXA4cyoHsVezB7JaXfjvXe0FNAyBTCiJha9/JFL9StyC9/2C2mI2k822hhxEEOgjZbkVawLRxST3gvpMbBPTKnbNnkLDJhDUqqmQVk4/aDM2zXJZt69NrE97AQ0ZKgm51c9EsrSeM23/vHoss2okRZl70TZZiMVsDoWGbbA3gWYnZ4/k/PtIZjcOJ3p+5WTdToWo3hPeFwsN++Are33hWlx4mbPLkSyc3Omi5vLLM0nTuHYyaNgHCPoNtG2niip3qVoIDWOB3MtpvWGwK799PpGrr6cefdNg52Nem/fGQsM+6AyG581H0n8VZPi53FZOj81rYqHhIYBkeLwrNLQEDS1BQ0vQ0BI0tAQNLUFDS9DQEjS0gxz9BjTlKBs7QVa6AAAAAElFTkSuQmCC",
            } },
{084,
            new Items.Pokemon()
            {
                Name = "Doduo",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAG+SURBVFhHzZM7TsNAFEWzJdvxIkjnTwNlxCYIHbCCSDSIVeSzEqQ0ATZBQQMMfkMumjxdO57EiFcc2T52kpPnmZFzzjRUWoJKS1BpCSotQaUlqLQElZag0hJUWoJKS1DZlzTLmgO/NxRU9kHitosrl2WpS5KkUfy5U6HyEIh7XV+79d2Fe1nNfGj4TDYe710fC5VdyA8vbs59lAQCCc3SxE9TkGfkWn8+Fiq7kEBMT1NXpdsuZ79TFYclcOwyoLKLMPDr88PVde2jJG55uz9ZCRWq8if8mPVKZRcSOJ+euefmB+8vJy7dvU5EIC4Ek5VzvVYPQWUbOm7VTExPCVGYrkxV34uJpLKNcPfidWEzyLnEV2XhY8Lp6tesv7cLKhk6LvQ4vj09uPfNYzO5yk9OTxfXMbubSk2e5z4OU9P3dRxiJKxsCGP/LLBt9+m4+XTi1yh2dRgWGydQGQMCx7vpYtLY2RIpUbhu+6NtUBkL1iHOi6LwrzbcFPCxG4XKU5AQvdP1vX8NFCREwnQclgJcH6gcmjAuNpLKocFE9XkfqLQElZag0hJUWoJKS1BpCSotQaUlqLQElZag0g5u9A1s6yVdovT8uwAAAABJRU5ErkJggg==",
            } },
{085,
            new Items.Pokemon()
            {
                Name = "Dodrio",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAP8SURBVFhHzZbJVlNBEIZ5JJI74CsYWGTCwyAbx63gJsOKyTUig+AbqIeT5Ca8g+NRYYFMzyCjAmJZf5GOTU6R5CKLu/hP9/373vTXVdXd6SKiSEs1oyTVjJJUM0pSzShJNaMk1YySVLMTxR2HYrEYd/Xnm5JqtpPjOpRKpRpAgMvn8xSPx+W5WTa877uhFqKarYTJAJdOp2UiCHDFYrEBiAXY8GcfKkSfa+RKP2j0Md5OqtlKBtAAAKZQKDQAHR4HsOu5Mo73f70rEX2q0srdPjp/XxZAA+m5F+9dJdVsJQAlk8lL0YMQUYDacOZ9LOjs9XN6O9zL7SzRx4BWuH/ObbtoquZVao4enm04RNGGwzh8jO9NjFKWW/QPJ8doZSghgH84sv8NiCg48RgFk4PUn0lLi2fAFixAe5MYeLOATCYj7/Rz+2YwQUcM+XPqqUTWvWJzQappCxOlGaQyMUS1KWiQ+wPkOXHaCgp0pz8jwD4vwv4OiwKcATOg+xxJRO+4DtgKDlJNWwCsTAzS7L3bNP+wT/oGbjvI026tKNqpFsXHN4DL5XICBzCkPpvN0FYlLwsCJOAgr2lhzVJNWwAMGMp1YnR6ckIu7zpMBChEbrOSo4VHfbTN3ur0sKTepB9wAEMGsCCM71Qvoo6a9K16vUqqacvzHPnxhYe9VJ0ckMk3SjnarU+EY+KMwVefjVxE1/2X+n6G2673N8t52qlHG5F32qTWSDWNDNwmRwcTzd1PSEogmZAhz3+fChzqM8M1hvdN2o0AlOV0m7H5BwmK10+CdlJNCHAbDAEwXE/d3Zw6rrHDtWXR4uM+ST02DeCwcWxAQKEu0drweDal0DynJtX0PE/SCDDUoHjcN3BzHIH9b0vc9kpag8khrtE4Q6ToOyLLIBhDH/VZ5VoFIOoVcHIKdFB/kGr6PT451hUEuL0vL+lw/ZVMjB/HuBGiWxofEFCkvzKO8zIlB/AJ12dteoTrMSXjiGan0YNU0xYi+IPh/B6vAdT8jut7l0pgkaMGSAAhcohsedw6QzuMHqSatpx6tJr9ZpkSOFpfpoO1JT6OHLlZcNyUuQyyfAOhDRM9SDXDCjCAOuC6rE4NS4SSyRQf1GkBxA1iZO7xTqWaYSQHOacScIgiUg3f5VOgPDPKfx7w7yclBzZgccuYbzuRaoaRXaN4BhA2B+AADA9QWAB2Op7DSDXDCH+vTI0CqDzzhIIXYw04tKi/va9LjUWEkWpeRyaSqEeTRsAB7Jg3znWiB6nmdYSjxj6GDDDu4yDk2WdLNW9CBrjE5yFuneukF1LNm1TPrR6+Mn3u6uPtpJpRkmpGSaoZJalmlKSaUZJqRkmqGSWpZnREXX8B42WNrLMyUgEAAAAASUVORK5CYII=",
            } },
{086,
            new Items.Pokemon()
            {
                Name = "Seel",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALxSURBVFhHzZbbUtNQFIZ5JCAnX6OH2AF9CqkX+hSO3ghFB8ciV8woKr6CnbYUam1fQ6D0mHS5/qQ7hLho02nVvWe+IfmbJl/W2nvTNSLSGjHUCTHUCTHUCTHUCTHUCTHUCTHUCTFcBZuGQRsbG5TJZPhUviYNYrgskHt/UiXfn/ApUT6fxx/x2nmI4TJAbjwe8yHRh9OzSNI0zaCiCh7i95OI4TIkq4eBCnqeNz0LB4R5iPeII4bLouafqqQaqOjh17tV5SHeQyGGqyLe7vhQrddKEG2OV/W/tlgRF1RCqv04ToMYpgUPM5hkDpLtRVuR8fjj2lmIYVpCCY8s2+LT20xaIGftPr9MurbGEcM02LYdbSdH3xpkWbYopgYEsYIXraIYzkNVDm2bTMItAwIYhUKBstnsnX0PnykWraIYzsI0w7l13ulFchiqcoggnsvlIsl/ImhZVtDCvZ1tqjWv+eG3cr7vk2M7003YDzJUESMu91cEIWbwFnHwqUI2z7PLi116U9ymwy+1YP75XKWj0zqNhmN++GZQyUYnlIFkXG7lcxByWAjqxng4NtwSV3E0HJLF4qXiFrWPi+RYfPxki6rNK5bpBUK4tt66iQRXvoptx6KDjxWuVp1Mlu0PB8FDry5ec0sN2mfRXqtE/fY+Xf/Yo87xTpBVeQqU+TuuW4gk8ZJ44eQz5iGGcUze4yBZ/lzjChiU5R+gkOg2d6n3s0S9dimQc103bP/Tx1Q+qVCez2utLi+YRvCZaS4uB8QwCSQxD9fXeZFwG7svn9Hb4qMAiOby4YJAtd7xy7juw6itACu70RmQ7TzAZeIz7kMM7wOiv15Ajlv76jndsCjmHbaewSBsv8lz8fv5JdWn8xCbOPB8LxBN+yNBIYazUJJdFsRisVhO5aiyOoYkWqwGJEe8yBzHwal4bwkxnIeSUUIS6hps1opF5YAYrhL8z1YkP0uDGOqEGOqEGOqEGOqEGOqEGOqEGOqEGOqEGOoDrf0GjhyRVxls/20AAAAASUVORK5CYII=",
            } },
{087,
            new Items.Pokemon()
            {
                Name = "Dewgong",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAK9SURBVFhHzZZZctpAEIZ9JUBLDpADmEXoFDlGXlIG5zkFzh1cZfMar8lj4ng5B+UkCITo9D/K4GHcCAmo1HTVV4hf8sxPLyMfEJHTiKJLiKJLiKJLiKJLiKJLiKJLiKJLiOI+qDcaVKvVFPa9KojirsBcmqZ8mYfnefgQn92EKO4CzH34dEpHgzPKsoylPLY1KYplgBFbA2b2esPzFaPbmBTFTWgT9oZ2aXXAKEz+F4O6hNKG+h6yBm4eftNiscAzdPs4UddVTYqiBDbHRM7nczr+PFopmzmpeO7q57MydDTIS2waRVQxKYo2L1l72cQMlLBez3vSNGgCs9v0oijaYFOzt1aN5tfmpjrbGhhudzoq+zrKmhRFE9scAhlpNDy1cVaidNIaezMYBMGrxd+/e0sZZwObmPeqGESUMSmKGt/31cIdLk+r1VqWCAZ936Nms1lYNl1qyRxiZ4NBGFCSJHxJahPd5DrWZUX33jpjOnY2CLwgz2K326VOFFEym7KMQcko7sacwWITRbEXgwCluvgxptuHCU8jjKLkbbq+5yFZc/Rsyh5iLwZ9zuDl3TNFnMGLuzH1ByOapRkdn5zzAfxHTXRucvXoieN42bd2ayDKmAOiqMGQ4CjpDUeKThQvTWpzmhlnrDc8oz4f2vgB+s0BoxG3BphO8/ZA7MUghuTL9zHdPOZmrjiTOHAv/5XbNBhxP+oe/civwv7JiNK5zmr+idMgnb3+J6MIUTTBkMDk9f0vguEGL3542FTfTYOmUZhEWb89TejrU8LZzHsSQ4Vexjr2PusQRRuYhDHzu5lZyaQ58Yh2u60yX8UcEMUymJktMppw32FQwjBc+ZFlEcWy6MxqoxK6Ley/LYsoViV8E/Krz1+C93fA5oH9bFVE0SVE0SVE0SVE0SVE0SVE0SVE0SVE0SVE0R3o4C+GQ+G77rGX/gAAAABJRU5ErkJggg==",
            } },
{088,
            new Items.Pokemon()
            {
                Name = "Grimer",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKaSURBVFhHzZXbctJgFIX7SuToa5ADM1JfwhZnpNUXcLyQQB7AUt9Bod7oeIGAznh4kY6HC2i3e/3hz1DcTU2qzr74BmYByZe1s8MeEalGDDUhhpoQQ02IoSbEUBNiqAkx1IQYakIMNSGGmhDDpjiuS61Wi9/KnzdBDOtixSbjOb1+8YFc5++JimEdIAexr+9+GLltILr7/bqI4XV4vk+e65XteJ7PcovfxLa5raQYSvgBZIoR9vZH5LQcGh7N6ez0qtDouAA5Xp3/Iehzc5/enJcSEE2TDk037U3HkFkYoYv1Jf+E6MG9nC9gaURv06IY7hKEAb18PiubSeK4lLOtHXZzWq8vKAxDWq1WRnA6XpYtNl0aMZTweMQ4ybOHM0qilCYns0JwM+L8UdHeJReYPy4uBDluh8PuyLTZZNxiWAVEIRlHMUVRZETPTjHKpRGa8vhjbjg7WhgxK9f0fhTDm8D2RiyY9d+zTGJEAaTiuEMHd7MrYrgYK4zl2j1eFWJYBeQGLIYTH3SzskmIttsRSxXLYrHbjO9BvO6oxfA68FDO+nPTBBYgTVJqR23qPxnQ8dMhJUlCr3jkCbeYsLAZO4Mtx2KhRcj+M0F7//V4YycneCZ+pE7KMtwO5PDQhgha/Pz2O/+7/Nw0iPuyY/L73GKdMYthFbbF3n7OEt8KCRa1mxxH3CIvCpr6wpJDfj5auQH/zvcDPox8bAkxrMK2ONosAE6K91m/GB/EIZn1Z9zo0ox7wO8hWFcOiOFNWEl7Ujt2yAEsAhYGy4OFwndcz+OfyserQgz/BEjak24LW7Dt+Nz1mv/NATFsQngnpCAIuC3fsPt5U8RQE2KoCTHUhBhqQgw1IYaaEENNiKEmxFATYqgJMdQD7f0CUudAOq8tnrEAAAAASUVORK5CYII=",
            } },
{089,
            new Items.Pokemon()
            {
                Name = "Muk",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALfSURBVFhHzZa/dhJBFMbzSAF2eQ7Z1ULLJIUnpNJG/lh4TNJoYYA8gIKVJrUnxNIiZqHzVWworvMNfuww3k128YQzxe/AfrNwf9yZu4cdEQkaNQwJNQwJNQwJNQwJNQwJNQwJNfwf6o2G1Gq1Ff56VdSwKq7U1fhWvn+er2jUl2v+Z8qihlWA3KBzK9eTpdCvH7/XBAlE/c+WQQ2rAEF0rX9wIdPxTJUjm0iqYVUoSZHpJJOj9ETaybGRzsIShMTubn4W3c5uTdAdCg4AM773h2UrgpTwi/uFcZ87OKNeDn9EWdRQw+2KNqmQdItT0pWD8IMIFm2ZCyXqf0W1TvM+3OPXKEINXfztYhF3+9rJiQy72SrHK0iTdG2KmT+IIIvj8YGiuIZYlmV2Uke9mV2fjudy3s8FO3tfpbd/YbKZza8+3UrcbJqv1uv5qCFxt5a/HlJ4vtVqdVksFuY2kfPX6x0dduf2R0FwYDrLNVB1ktWQaNtbBDvW3ftiBGer7nHrIc17tnIGUShJEtshXPvZ4/SJlevtX9otxnvAPGrE0mhEpoRel6ihDyRbrZYtroEzmab/ChNI9g8uzfk9NXKzVT7oZPd2Uw1deA7xhezQ08MX0n03lN77kblenjOucYBcIMUthhQG6szsCs5yFN3dRTUk7pCwQ67cs/bLNSl3UAAHqmvOIqSQoYtnnZ8Sx03B9/s1fdSQ+OePksSfUEI5DogPzp9fqwg1dIHkYfLWPL/yB+71JP/fh+ciusJ1Siy3ktczex+Fy5w9ooYuEPz28Uba6bHdLgAZSLpFlwOQC/D/IBmYbaUwruO4XBfV0CdqmkeCOcwfXt1YCXYNIjgCVswMAgeAchgODAPOGz7v4tcoQg2LgOjzR29sNyDFTlD+KDm14hwE3BNF5c+bhhreBbvpdwI5O0yxMlN6H2q4Ka68v7YpahgSahgSahgSahgSahgSahgSahgSahgOsvMHfqH3HUgyAEkAAAAASUVORK5CYII=",
            } },
{090,
            new Items.Pokemon()
            {
                Name = "Shellder",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJeSURBVFhHzZVdbtpAFIWzpOC/fWCbPje46UPoAgJ0JSELqBpD1xClakVJWE2bFhV0O2fccWzr2A1URBfpE/jYMJ+O75gTEVENDTVBQ03QUBM01AQNNUFDTdBQEzTUBA01QUNN0LANPwjF9wPzkZ8Hnu9Lr9craZ7fFxoy/CCQy8ulTCYPVpItDrnxeCXT6brE8wrh5rXPhYZtBFFYSk6nD2Zxz8T11vr9vsRxbK65t4KjbG6vh6j7nX2gYReQgWSSpJKmA9NmKBfDG5nNfsj19c+yuThOaqKHNknDLiAEuXdvPlmhgkfT1MK25UQduBaiV1ff7bHndc9wExq2gdnDIqMsLwUgNKrJFjBhyO7bIg0Z+GHcKmwCLIQZBGhnPP5mzxUiRZsQQzabPZZyuN37ziINGdjFWACzlSTFfDkuhh//Cq/NrV+UjQFk1Xk8miCA5OlpT+7uVjVBMBgM7K1/arIu+WKbBLv49nZZk0vTVLbbrZV0TT7JYQySg+QADbsITIvuWeeAXBiG5rTUJKvz+iLPQbQ3HA4tA9Oam8XNZmNOF6/dbmczSCXJKyuKY+zoQyRp2Ab+SV6fnVk5ma/l7fm5/QwBiAFIO3FsimJjQTA370d8zDgiIwm5r+8X9n2Xo6lCCmRZZoEUHj++aR3N4xi7/ai7GAv9vlnJl+ncygEs7KSqYCax69130T6Oq9lzoGEbWOTXh2XZ3udJXi4KnNyhO5ZBwy4guc3vLc02qrLV/H+g4b+IokhAMz8GNNQEDTVBQ03QUBM01AQNNUFDTdBQEzTUBA01QUM9yMkfLF0Q4XXG0HMAAAAASUVORK5CYII=",
            } },
{091,
            new Items.Pokemon()
            {
                Name = "Cloyster",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJSSURBVFhHzZc7chpBFEW1JT7FPvgksjN9EiuzpUByxogN+JNgOZK9C8mRpESyN2OXHQD13JeqOzxat2EGg6tVdUrDnWbm8Lr7MeyZWdbIMCdkmBMyzAkZ5oQMc0KGOSHDnJBhimarZY1GIxzq87tAhopWu22v9sd28uIqSDZDpMdtGxmmiCU3qSauUed9MkzhBUGv15/frMoNKXY9/mlfr/5Ys9kOsR7rkeEqKAm56/Ev6/cH4biXFKXY8PzRvnz6PZe7fPsjCLaejVXIcBUpQRyfvPwcZBZTj00FMQhBDv/ryAEZxrAKoNvtlkKU84LFxfdSAmOLi6dSrK4ckGEMBIfDd3Zzd2+3Dw92OfowryDlUpIA4yhZVw7IUIHpmlekWIjGshTEBoolcT6+ZhVk6OH0cvfyZl40loQUJb0sxsTXX4cMSafTWWorFPTrD6KUI2qqdyIIfAW93HQ6tePjMzs8fLMEBdFOMI7rjx+CO7wqMlRAFGvQC45GH5fkiuK9zWYzGwwGS1XkB/M9sKqoDBUQxLcAp/bg4HUpBtl2OD+ZTMJQeybIKWajrtOsZahYJcjK4Q9VZcUo6DcKq7f1CgIv6QU9qU0C6brrD8gwBXrhuiqmpneTJg1kqED1/E4ud2loMxD7Fvrh0dGprCKneGffJJRjL+QDAR4E2D5i/rsgF7ZfR8j5tOLFsQz8FG+6/oAM6+Dl+doLomqo/qY/E2T4r3jpeGnEY9chw20CWUpmKQhY0TivggxzQoY5IcOckGFOyDAnZJgTMswJGeaD7f0FNsvILekdIPgAAAAASUVORK5CYII=",
            } },
{092,
            new Items.Pokemon()
            {
                Name = "Gastly",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHLSURBVFhHzZVBTsJQFEXZUmlZCC0r0FUgYaKuAtkBwQFGB5AwUdmA0Y04cNDik/vNI9/vbcFS8DU5KZ42cHztb1siYhoqLUGlJai0BJWWoNISVFqCSktQaQkq6zI4v9/s+LG6UFkXc4EIqooKj9X5B6jcBX7o5uJVxoM3h4b6AXrcd/7nfaGyCj+s3Y4liqIto/7L9phPnTCFyioQqGHdblfSNN1SFnqSwCRJ3A8jLgwL8SMPiQNUhnQ6HZnPZxLHu+MUjTzJPYjAPM9lOBzSGEY4RbZo9oHKEA1cLh/kOYslS8unuFjcSZZl7nMT9yOVIe0odoG9Xk+e0sgF6t4PW6/Xm9PFnccCj3aJEYh7EJPRCWlgURSbU35uq17ijpUtlr+EUhmijxadok4NcVjd8Lr5t8HJAgG+FJPUVYwJfhb5r0A2vaNfYgUx/mNGI3Xzp/svgXqpJ5cjmV6PHVn6vWLB5Grk/m4qDlBZhj7L9FX3PnmUj+lKbjehWMGYsMYh6NA4QGUVGumHAn3TaBzOxf6QOEDlLvy3AtBL3z+bHRwUQuU+hCEsrIlYKpvCfGATUGkJKi1BpSWotASVlqDSElRagkpLUGkHaX0Bq5YoBvk5dscAAAAASUVORK5CYII=",
            } },
{093,
            new Items.Pokemon()
            {
                Name = "Haunter",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJjSURBVFhHzZZBUttAEEW5kmThO4SdJU5g4BCYsEmySnIChxsIWISCDVVZJblAipwkqSxs10RfyTdN63ssbKcyVL1C/iM0zz09I/ZCCEkjw5SQYUrIMCVkmBIyTAkZpoQMN2F/MGh+6bFtkOFzgdz09FvI891LyvC5JC1Y5Hkrd3H2PZwd3YY8262kDGOgWlmWNZePn70gxgnv2xQZxoDQ6fjjUsTKKXiffw7gl419mU6wDgpi8rKswnQSF/wweWjH0Z9WBvRpjU7QB0pawT6SHo7H+laG64DgaDQK9/VNM9Hj5H2kgL0vJgdk2Afs3tlsFs5P7qIyxEr1lQMyXAeX+L6+DYOmt9hLCoigFSbjmydyyGw/+jmIDNeB6qmNosTKspRyPttqk/A48BklucR2MvboYrFo24BjHty7cQUpxiW0rzIrSFCZ+XweiqJo+5M/XpCVjYkRGQIuo19Cnme4h5JqydCfqN6n67vw8ri7rH02CJDhcDiUchZWE5L1q2mo/gqwOvZa9WFfSRl6QTzMyvqHW8n69TRcvbnoXFtBiu9kidnEuOYEXg4bAjI/L7+EX1dfW64bMS93dPC+Q5blUVEZAgjyD4vB/lJQLQslUZUf9eel5GFVhfHBu47M+MXbJ5Ic888FnWAVtqJ+DGAcE5ejPz0HKEcxexpYyVVyQIarQKV8ZsG4rxAmV28a+9+Nf45FhttCUVu1qjzsnAj2XF2FDHcFRO1p4EX/uyDgBuJORg9DGq/HJAQBK8kN5j/HkOG/gH3Jz9j1vI4hw5SQYUrIMCVkmBIyTAkZpoQM0yHs/Qa0fqTgCW3bmAAAAABJRU5ErkJggg==",
            } },
{094,
            new Items.Pokemon()
            {
                Name = "Gengar",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI+SURBVFhHzZVBTsJAFIa9EkW5By0ngB3EheKG4ikQN+gNSFwguNDESxg9BeoBgIzzt3k4PP7SYloziy+0/0z6vr5hpifGGK+hoU/Q0Cdo6BM09Aka+gQNfYKGPkHDLM7qdVOr1ewlH68CGmYBwUF7ZoJa3d7yOWVDwyxEcNhZJJK6m0U7jDmCHtPQ8BCupIhKPhm8mSD4vc96Acy7H378j6BISlEIioSWxThwXywPGh5CC4ZhZCZxKieCTNaVq1QQQLLZbO6IaaKwZeXDnTnHygEa5gFBtysMkbmL37fXQpH/nkDDQ8gSozATA1rI5ZjuARoyToMgefNZd2QLzZNiWlLLaPB/7YYj+5z0WboGg4YadK3bHCUFlvGlue48UgFh3h2bRW9sr9MXEXrheEtpgo1GI5HDQ0WwbrupjxoAsa+4b76H/b2XkO6lcoF9NK+noaGLFozb+937jK8S6eXgIpFb9G5svts98BdJGmqwxFgSgOMlS1LLQSRu74oeK0nDLCD6PJ2ZKIpsoZCKikTeeKmbxAWSq9XKvD48bUU16/XanLdu97oncrKT9bMZNDyEnIMv04XZbDY2MoksruXXlWPdrPxLgjPRlXTF2P8OiCgouryAhnmgi+5mgVSWmKbyJQYQlINbL59Gi4tguovzO0nDIogkCqEoirmHN+uq273KdrGLfJ+lGKTlnn1psDmKigk0LAPZ7a6cnlMEGpaF21E9VhQa+gQNfYKGPkFDn6ChT9DQJ2joEzT0B3PyA9Tjv2UClgIOAAAAAElFTkSuQmCC",
            } },
{095,
            new Items.Pokemon()
            {
                Name = "Onix",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI0SURBVFhH7ZRRbuJAFARzJSBwD+AGwCWAnCq7+xOUs3kpaxu1xx3HYCLNx1oqedwz86Z4dvLSNE3VxLAmYlgTMayJGNZEDGsihonF6+v1lud+khiWIPfx8d4sFovrY17zU8Sw5L/gADEsGSM4v87NZrOWcm4KMXSQOx6PzeXyOwoyjxQ/4PPzTwvrJKr5R+Vj6Pjh2+22cwhdczHx9na+/aBy/t7PJIYOQn7wfr+/dWNITs/8qMvlV2d+Pp+P7mgMBQUQovD5fG7vh8PhdmB5OCDAWkmy5nQ6tc+ps991NIaAHAVKQZ5dSpKlmHfSJct9TxPkrrGgm5vNpne45rSHNWWnvftDkjFcrVadYhyiDjpk6XDkkNY8Y8mytnztrOO7LD2gF8ByuewcmJC0S6prknNBjf1ZwtT7qou9QOgVA8U0BgpzlZIuBvprXa/XPTGXo4t3dZBXrEIuyJ0DdfEsEPBnP1D/7H2e9bvdrj3jX82eB8RQ3yCFuAOFuMi4ePYDOcS5Xp2aSErI5Z4myFgFPZNcWSPhkkM/xokhsFEiLuMZnYAxgnrN/l0+/IrBBb+Su7d7/h1O+gaBTZJSUY3VOcbfCTIPyLGHv+SxchBDweZSSoyVY51wMY0nCQIFXAx04FBx7dNapNQxp9xXEsMSCukgiQ0VZ05CSPp4jJQTw4Skxhzggr5vzN6SGE4BCX0KjwiVxHAK1QsCYs+QgxjWRAxrIoY1EcOaiGFNxLAmYlgPzctf00SbrJPC82kAAAAASUVORK5CYII=",
            } },
{096,
            new Items.Pokemon()
            {
                Name = "Drowzee",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH8SURBVFhHzZRBTgJBEEW90gwje/UEEDYaV7rTuNGl3kA8icoljHgIwUsouEDT8pl8KDpf6RYltXgZeOjMS3X3bIUQXCOlJ6T0hJSekNITUnpCSk9I6QkpPSFlCs1mMxRFMSP+7S+RchWIe7gtQv++plHWoZb4f36LlCkwsntZMxrshPeX3TlVYxG6zrSlTAUPfn1eDrPcXBWhnE7X/g3C4/v8hJQp4EE2JgZxnOrZYStcnx/NYuP7rEJKxXZVBoKlwt576pUzxsM6BC5e8nXigJQxCOJkRoO90G63598Joj4/JqGqqjCZTEK/V83CO53WWodGSgvjMB1cEcfTi+kxkA7YiQKc8vi+qUhpYSBi3gZ1IKPGw+UpWoc9+Hi3CM49HETKGEbiCrjPEGHjal9Ol3UxZQbid/vqSUVKhb0xPtsAgDhM124BwDgCl7PkUqbAaTIkDgM2LCZ1yaXMIQ61YXa/Epzqk/128lJLmQseZiO41NYRBOK92L04Tno3SpkD4hBzelAH4co4O018hkcY+fdAG8crH85IXImNAxsJRBQD4wA4G22BT9mHUuYQRzJIudw4IGUqeAhPLoPgbDSd/Q4QnhIpZQ4MIsrb7wzEJDdyinNAIE81w1ch5X/CScb+O6T0hJSekNITUnpCSk9I6QkpPSGlJ6T0Q9j6Ao+T7g9eRferAAAAAElFTkSuQmCC",
            } },
{097,
            new Items.Pokemon()
            {
                Name = "Hypno",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJ3SURBVFhHzZZhbtpAFIQjbkQM/E97ATAWUqJepG1O0KanaJNDQOEiTXsRbG13nj10tR1jG7dokT45Hpv1l7dv19w455JGhikhw5SQYUrIMCVkmBIyTAkZDmWxWPiDvjYWGQ4Bctuv9y67nfpTfc8YZDgEJYhsOp0azC5Fhn2Zz+cmt39+MCAJqeMPL/arZpaNk5RhXyj49PGNkecrVzZyh+d7V/0cLynDPnBqKQGKohakHI9XF4RcOI0hkNw14l8e71z1Woteuohk2IWqXiyZ57n7/KGe+u/frih4kqtKd3h5d1bSKtncx0UUj9eFDM8RCs5mMznVmNL1OjdBiFHyvwtC7tP7O5syPBjThx4LxSCDT1EU1xW0ym237unxrQm2yVlVj0f/lb8lcQ1jDUGGbdi+5yXX6/VppVIQK5aVNSF/jX2Ic1SvEZdjtyHDGFQPbwjITSYTt1wuTxtyKBhWNNxucB7uhahk31ehDMlJrKmCNf5uZxWkILeU8A2C+8qytClmDkGMtVr5zdxfOxwONk6XpAwBVyvEuJdRcL/f2+AQi89NNhCAIKvHPs6yrP7Hm7/5TIUMAQUpx94KJUOqqvJf+/OJq+c//14Qg3BbQZNzUPQhjkoOlcN5myCmOKz6xVNMKBqf80E2jey35mhTHyyQWBLfJxy3DRl2gYegsvh5BRG+NXhEK8SvQAoORYbnwF4IOfRm3J9EbeKXvEWADM/B6lEQ3PqHhys+lBtTPSDDLkJJyDFjX8U/IK5aQUKhOAebzea0gsnVerALiKOC9uPBL5Qx1QMyHEs43W1V7osMU0KGKSHDlJBhSsgwJWSYEjJMB3fzG5eh/IcGGjlEAAAAAElFTkSuQmCC",
            } },
{098,
            new Items.Pokemon()
            {
                Name = "Krabby",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJHSURBVFhHzZZNbtRAFIRzpbGt2YNyAdvDYqKcgHABwi4kFwisEk4BCRcIyoafy5AwiwEeUz0u66VVgw35e5Y+aVzd6q6u99yaLTMLjRQjIcVISDESUoyEFCMhxUhIMRJSjIQUc4qytMlkksjH7hspesqqsov5E/vxem6Lwx2rioc1KUUPDH4/WJubNc2DpyhF8tjmgBTBdDpN5i53nlrb1NZ0Bu/CJA4+dh0pAhhE73mD4GrVi7fpQ1YF65YjTEoReIPeJAz+78fiW4YMrSNFggV9ijTnT485nP83OC83OZSkFD24A+u6tk/zdZJYjP2DMWzmU4DG317jPKzlKzGUohRJOu3nE/v49pW17boHfXMzDW6Qv1PjPYqbwPfynRlcfHvXU5XFamg9tlwubXG022/C0uUtkH9sqAYv/luX2Jucta19ON63siiSmd+/flqF8c5Yjk/Wm2S7DJkDUszBBu+PX9p5V+qrLyfJLMoEk0yRhvNkscazWdunN9YckKICJtngSBFGfalgzj+Xu9spLV7uvgrUVo/cyyPFHJ9gKq/bzCfiSdfSKmnfGtdfT2/08Rik6KG5w73Giu7U0PzXDZP8AEjfBs4kx8amB6ToUf8F073mUqQhvIOjF61ddwb9GJI7eF7fOOwQUhwDk2XZCFJFK8DE2Zv9vi3Qv7wBMDbWpBTHApNIlv2ZAzNMPu/jvCqbkOK/QqM5ah5MwmA+tgkp3ic8TK5vQoqRkGIkpBgJKUZCipGQYiSkGAkpRkKKkZBiHGzrDyWr2D+RDbTVAAAAAElFTkSuQmCC",
            } },
{099,
            new Items.Pokemon()
            {
                Name = "Kingler",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJfSURBVFhHzZZRTttQEEXZUhwn/6BuILZ/gtgBK2j7R1kB4gu6ilZ0A634AboZKHwkdOr7wqXD5Jo6NIlepCM515bf8cw8JztmljUyzAkZ5oQMc0KGOSHDnJBhTsjQMx6PbTAYPBPPbxoZEsh9n+7a/aepPRzvJ8piu5IyJKPRyG6PFnJNVeVVQVRvFTlcH7N1IEPKXe7vWV1NrOoQpBSvj+1H/r9VlyFujNmj4I/pXjoeusW81GQysbt2Tr1gl/SqyNALUhICfpNQwJ/357i5NiIIvGSXICX4IBRCWynPquP6t7RbhgQ3RftUi3keIthEmFPAB1HV9llfZAjSTa/O7NvpR6vrxeK+Al7OS1GWLWc13yIHZAjSO7AVfPj5OVEOizb+e242m9nlwbsXL3ESx4LSG2mxryIWAF9O3tvj43xJ0M+iF1Nt74sMPZCkFCTvrhdVber6xcIQ+z2fW1mWz9X1VfSw9XEthQwVEE3vOyeIzcNdDDn/aZpm6QF8tVFddqT9yDWBDD2+ghdtq4dFkdoOQbSPOzziq4fvcVbT5mofFuODe8Z1iQwJ5Ch2fFhZ8fS0nE0vCSEcE8hRNspFybgJPUtBhBX0raAgWw2hrycf7NfNuZzPCKX7VHEp6AurSymPEuSO5twi42Z5bQ5l2Be8DzmfFGU1+AfCyynBeM+IDFfFjwGrkcag/QVhlSDM2WRVtybYBST9MX/Xt17Bf0E5Vg+bJP7x6EKG64btZmv7Vg/IcJ1EOc5kvK4LGa4bSPoNtAoyzAkZ5oQMc0KGOSHDnJBhTsgwJ2SYD7bzB2pOu8TmHBIQAAAAAElFTkSuQmCC",
            } },
{100,
            new Items.Pokemon()
            {
                Name = "Voltorb",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFbSURBVFhHzZVraoNAGEWzJevjf7sDHytIlxfsAgy6idBuxtCvc6UjdnppRhPqFQ6EMxgO3zh6MDNpqFSCSiWoVIJKJahUgkolqFSCSiWoVIJKJahUgkolqNxCURSWJMlMuL4VKteQ5/kUdDk+28fry0z6oFAqY8HUwrAQhIb3rYHKGGLiPPdEUhkDAk9lae9HHrXk3wMR13WdtXX9I7CtfgfDtVVlTxsjqbwFAsdxtCzL5m1uXMjlOw6/Kxd1ciBul0CEYeuWgTi1pdv28/k8TdfH1Y6tJ5rKWyAQIX5i4PN6nSaKyeJ6a5o5DsFpmkLT//sLKmPA+w+R2MplqH/mEIa1e+IAlTEgENMahsFqt52IWYKwvu8ndgkE/rD4C7E+6hFxgMo1IBIHAK+dMGz3T90SH+oJ17dCpRJUKkGlElQqQaUSVCpBpRJUKkGlElQqQaUSVCpBpQ52+ALy8UwOOsUiTgAAAABJRU5ErkJggg==",
            } },
{101,
            new Items.Pokemon()
            {
                Name = "Electrode",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFvSURBVFhHzZbbbYNAEEXdEizQB4+yXIGVKhLlE74SV+IugEz2oky8QtdAFovMSEfAsYSOdgX4JCKmodISVFqCSktQaQkqLUGlJai0BJWWoNISVFqCSktQGUOSJBIy/z0WKv9CnudTUN/3/vI+WZY9JZTKLRRFQcPmszeUyi1g5dbidBDph95nDSrXwOptjdOJjaRyDQSWZSnDMPjLbXNY4NLqNU0jVVXR8K7rxDmHU3rfR1C5hAZiRXBEFIL0iAnPMYhr2/bAwNeLZC79Xcl50HwQ+Hk+i0tTXNL7PoLKJRB4KxP5eruIjKNX99FVDUfjrn7rXcTrhso1HkWGgbqte+IAlWvgHYjApirlVv2Evr9MXBGk+DDl0ECgD4s+uSEfnmfEASq3gED91GE7R7/VekS0RiLuXz51SvhnAYF1XU9xe8MUKmPQFVXmv8dCpSWotASVlqDSElRagkpLUGkJKi1BpSWotASVlqDSDnL6BnEDr/5mzrX9AAAAAElFTkSuQmCC",
            } },
{102,
            new Items.Pokemon()
            {
                Name = "Exeggcute",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAISSURBVFhHzZVJVsJQEEXdjs6AwD5oVqFObFZiM7FZDcpEZTUqg0DKVJGXU3wfkoCD4px7kJuP/6WqfjgSkdBQGQkqI0FlJKiMBJWRoDISVEaCykhQGQkqI0HlIQwGA+l0OkZ6bR+obAKCpC5/uJHZ1ZkUj7eSdbsb1/eByl34IL3uOmS/3zcnH68yuz6X4v1F5Onu4JBU/gXCLb5OZLE4lmI+lazXk+FwKKPRSJYabD6zkP4G8N22rafyL3ST6cWpfH+uA04mwzqUMhmP7bNVsWwzQmqw/G1qa/SG0v+7DSq3UbexbJ1uPHYV81jIap2C0PWaFq2nchtaPW2lbm6bLpf1pmipzp4PqH+/XJ6a92uaVpFKhlWvapFuqvOGtlk7Nay+qsAIae+oXlFIlmWS57nI832jKlKZgoOhJ3QjADauWmYbV59ROR0Df3hwvWmbqUyxgFX10CabvyS03xxVRntR0TbhFCo9OLWYIQum7Sxb9KtKbu5QMWu//265Bic73YtBpadub3XnnrQqG961FCHV69y2eRZS6akrWD7TdANUClWwg+JCsnC61k7vHj9/VKboCUZIDZG2SK+jMngM2Wxq6NWq9cn1UMnQSiKEkl4HGAlUDJVV2oZTqDyEXSORrt8FlYfiQ7KRaAOV/0HTkdgFlZGgMhJURoLKSFAZCSojQWUkqIwElZGgMhJUxkGOfgD6BFi1gXlcWQAAAABJRU5ErkJggg==",
            } },
{103,
            new Items.Pokemon()
            {
                Name = "Exeggutor",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJbSURBVFhHzZS9UttQEIV5Jck/74BJI6EmlFZHSGEcipAuSYWhCcmLYMxLJKHJz1M4cZFACoM3e2SOuPFsJCMxmlt8M+ZcD/7m7L27ISJeY4Y+YYY+YYY+YYY+YYY+YYY+YYY+YYZV6Xa7EgSBfrTPq2CGZVDElUH28ktfwpYngpuvn0oUx7nkquBjtWmG60DJ3tsdCcJAorOBBK1Qj+7PDr/Wb9QMi2AzIIoi6b1ZNhmP9zPBLFfZeDKUeFvzu5artmmG/6PT6eStkUxOcUWZZ9n5vhx+S+XV97RSm2ZYBBtke67MP9Iqihb5dyMNukDUlbTkOGKOefV/rIMZlmHdw1xQR0pRjjiTVfiIHoIZFgG5s3d9+aw/vH3XkNUiM463kQZduUttBFCSuGJ1RkvMsAhIftQ1QrmxCl/9GMmf2bFcfEhz4d/TZYbvtSqMlphhERR05SA2eZ/mY4ccG77+OZKT51sSNjFi7EG3Pba0WNxKu92W+XyuMk/kanqUZ7/0M77TrtiiGRaBBvFyKbcK2oKgm81e6JjDhgQBJHH5p4OBzIZDWdzcyOzgQK513EkSyyfdgxgtxHA+OU1VsOFFDTBySl6Oh3Ky19MHEmWPBJK4Csiq3j9ghusAOYya64WMdnty/GwpVWf/ETMsAyM+2t1UoSh7yXjBBHLI64oRMyzDFWRjxM3qjJaYYRl8yRBxW+RudNusK2mG64A7yDtGKM02z0/7lV8vMcOqoFku61tdPUmS1L6LZlgH7kiyev5QzNAnzNAnzNAnzNAnzNAnzNAnzNAnzNAfZOMvAh/btVfqDZkAAAAASUVORK5CYII=",
            } },
{104,
            new Items.Pokemon()
            {
                Name = "Cubone",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH7SURBVFhHzZZNTsMwEIV7pfTvHm2yaeEkpV0BF0CwAXaISyRNT4C4ABIrJA7RVIOfySATvVbYUulY+qTkuUlfnj2T9ETENFS0BBUtQUVLUNESVLQEFS1BRUtQ0RJUtAQVUxmNRpJlmTvk8ylQMYXxeCxlWUpd1zIYDLzRkO/fxD8AFVNQg3meS1VVstvtnCyy2Wy8BmOYhz4cDjFF79OFiqnA5Ha7dYf7BwwjYTfoPbpQMQVNUJPDgBkseZhmjDlAxRS66ak5LO90OvXLrvvTDXoPBhVTYAZh7n4xk8eLueStyZMYZHtvtbqWB2es38/83ObuXOp1fIpUjAG9jxVGURTSNI2vWMzjfLG4dCmu/9dgmJ4WgfZD33JuZj/JLZdXfj/G9EIqxhBWb5gSDCnaG3F8sj2oqYWmkJavYJdinsclp1AxFhicTCY+JTX29vIk9e2ZY/6LgSua7vWHoOI+YCRMQc/LNiEYaz4qkc/a8/767E1izu/FBJNUZIR7DZUZvlux99Dv0OtCg0XRFokzpQ+A86MYZO1EqxZmscRqEsuL9Aqt4jY5NGz0RTfofzCouI/QpKYIHei3oJoNTerb5OgGscww+JeXvu5PED4U5mKg4iFSvpq7xRUDFS1BRUtQ0RJUtAQVLUFFS1DRElS0BBUtQUVLUNEO0vsCy9Fh5JpFr84AAAAASUVORK5CYII=",
            } },
{105,
            new Items.Pokemon()
            {
                Name = "Marowak",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIsSURBVFhHzZVdTsJQEIXdEr/7oPRFXYX6BNEX0A2gbqalbILEFZC4CCDjPVeHjM2hLQWSafJF8jWU47l3em9ExDVUeoJKT1DpCSo9QaUnqPQElZ6g0hNUNmE4HEqn0wkf+f1LQWUdCDeZzCTPl9Lr9WLQa4Wlso7BYCBZlklRFJHxeCy73U76/X64zb/TFiqbgBYREuHyPJf9fh8Dapu20XO2A5VNsAHRXpqm8a9eq9XqsPzb7Ta6Ng1TWQeWWPegBqy72i4/lXXoHrTLW3Vpm+Giz6uCyioQbjQaxWBN2jsnHKDyGNh3i4eRLN9vQ7hEkiShDb68vB3u4Z/QAdFhOWVgqDxGHIzFrRQfdxGEtAG1LQwFQmKP4jWkw6Lf/XhKpNttFpLKKg5LHH4MAe0SI9R7+PF9cAir70kERPPwmHZ8t3eNgGjQTu90Og8Bf9uzjdlgrLnrLvHfCWIHxLb1/PwaQnT/BQNo7JRgCpXHsAHRDj5j/2l72th2k8nq8/5fuPKzmkIlQ8PpkWadBl5nM/kqXg9oQNugos+tg8oyCKLHFS57KuAefhCDg1fLbpOLfBeRNA0v8r9lxkAtHpOTJhhQWaYcEFc5JKZ0HAKu83lsL8UryOxBDXlKe4BKBl4veDiClk8HBESDaAgh0aJtT2mzF6msQoMe8xY9ddq2B6i8FLo1zjmPqbwkOkRl3xQqPUGlJ6j0BJWeoNITVHqCSk9Q6QkqPUGlH+TmB+ytSQgJfPK1AAAAAElFTkSuQmCC",
            } },
{106,
            new Items.Pokemon()
            {
                Name = "Hitmonlee",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH+SURBVFhHzZU7TsNAFEWzpdhJ9hHbDdDxaYANAFkBUCF2EKAJNCAaECsIsAo+C+BXpHj4OjzrZXQDiR2JVxyN5szEc/Nmxm6IiGuo9ASVnqDSE1R6gkpPUOkJKj1BpSeo9ASVdWi329JsNgvCsSpQWYVOp1OEGg725fHisCCOotpBqZwHDdbf2ZSH84MynNJbX5aoRkgqZwXhut2u7K4uycnuppzubU2ERB9E0T8ExFnbyYMlSSL9n3C/UTUklbNgA9oKgr215cLb8AhY5TxSGYKttK2Cvq1imrcIMRqNJMuyMji2XYPPex6ptCAEFmy1WmUbjuMcaqUQ0lYVoWx1591qKi3YStxQXcAuou+8cNwybbv1+X9BpQUVCgPoVt5cHsnny7mc9bYnxkMw/35wIGmayO3V+DetOMofz9e0UGnRgB/Pg4lXB/p318fFYmhtIItuuZ7R96fx7+JFBQQI+ZY/+Ov1oqwWAqIKqCTAZQnPm1ZO++owP1xjGlSGICA+Ybqd7JWBOXqjsY1aVZ2rx2Thl0RBAK1WOKbYSmdZOjFX/yS+z+pmgcqqIAQuDqoXnjP9g9qfFSrroFXsbaxUejGHUFkV/fwhmOIqYHHOhsN8a+OyDefMC5V1QEjb1oVKT1DpCSo9QaUnqPQElZ6g0hNUeoJKT1DpCSr9II1veKoPk3OLQygAAAAASUVORK5CYII=",
            } },
{107,
            new Items.Pokemon()
            {
                Name = "Hitmonchan",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH8SURBVFhHzZU9TgJRFIXdEhjoxcqfZmYq0AriAkQbpfOnQdgAugPEQtENmNgobsYYC0iuc0YvPF8O4gwQb/Elk+9NhsO5d2BFRExDpSWotASVlqDSElRagkpLUGkJKi1BpSWoXBTFYlFyuVx8yc//ApWLoFAoyHO3Ka+9lqzm87Hi982CynnQ1prlDXmJA96f1eKAucxNUpkVhENr7Z2tJBzaw3X/tCqD64tMTVKZFT8g2gMIl3XUVGbB3TnFbRJBW5VNyaccNZVp0J0LgkDuvkfphlR01LqT/nOmQeU0NIy78DpWhMAI3RajKJQwDJPgOu60LVLJQJC3aiAftVBuSuXkQ/zmEAjXURwKZ8PhUNq72+PmljZi7JeGUxBy0P0aJ2tqvVaX0WgkD+d7mcMBKn0QsLtWlvfqJFyvVJH+SXX8G+e2qSFdtFX/2bOg0gfjRUCEAlHw1Zj7gbin2XyMffSjTTQXhpPgaV4QQCVDW0S47vcO+vdoyFbraRzUH33akFROAwF0nP4ZwDnGjFD4Em7jbsilBfwNhNs/6shB4yppzw+oK5F2D6nMituwv7P1447k//u/2MUNq2PHmJf2kswDXrDb+CcJ+3fYuEzVJJWLxt/PNHtI5TJwR+6f/QaVlqDSElRagkpLUGkJKi1BpSWotASVlqDSDrLyCU3ECTp3dnVtAAAAAElFTkSuQmCC",
            } },
{108,
            new Items.Pokemon()
            {
                Name = "Lickitung",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIPSURBVFhHzZS9UsJAFIV9JcjAO6hVSBqw0w61UMcX8adBnkKlQbFBbXwNlYbRxsEC8JqTuJnLzlF+BpxbfMPmJGS/7N27ayJiGhpagoaWoKElaGgJGlqChpagoSVoaAkaWoKGlqDhPJTLZSkUCin+vWVAw1lwYv3Ltry3OilBEEyILkOehtPAxFrMx4n2TxryftaUzu6RBIXiQqI0ZOjVCMMwm/z6Npf6Go8ljuNcKo6ifOwknaj/7r+goQ/k2vWDdIKoUsknbm1uydvPOCgW5XK9ml/7gri+qR8uX1DLOUFM9HZ6kU/O0B/j/3ceSRpqSqXShKCeCJLuuuJl+jl2PaskDX0g+dTt5pu/265LFGVSPloIsiitzudtFhoyUGo9RqNcbVQlCivpb2ujlo7vb+rS2ctk9DZY2R70gRya4XW7lkppHhK5x85uKsj2KBrJf980aPgbkHverkpvJxOCJMZxUkKsHOQGr4nYebZiKK3u5JUKTpOD2GcvEUnknBDKjMYYjUbpGbnygxqCWs4JugaAzMdzIxfV+24ROUBDH3TxtNKiq1HOwUtzYiUXKauGhj5aUANBrAzOSayePpRdk/yLoN5/Dqxk8FM2fABEwXA4RCZ3+8dzHykMGjJ8SSfng+ecrH9vEWj4G8uefBZoaAkaWoKGlqChJWhoCRpagoaWoKElaGgJGlqChnaQtW9lBRwk8qBp3QAAAABJRU5ErkJggg==",
            } },
{109,
            new Items.Pokemon()
            {
                Name = "Koffing",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJnSURBVFhHzZe9ctNAFIXzSpKw38Oym3ioSJdAQQwFODwFVE7yCKQLBQxUGRp+mmC9SZLCdi46Yq5YX52VZFvJrGe+meRI2v10V3dl74lI0NAwJGgYEjQMCRqGBA1DgoYhQUMflx/HAmzO8J23yRiAhoybm/dyd/eh4NNF/QR6rj1vPj+W21t+zAcNLe7AbSSZIKrm3mTTGAoNLRDMssmaZNPg7jKy6zsVBJhQJ2LPUL/flyiKKjnY5gYVGtbhk5vNFnJ2JhLHTyrHwbaSNLRYqV6vV1YLfw8GAzk8/iJHk6+SpkNvJTGO+3yym7XQ0MUuK4QOX36WdHySi8Rl5Y4m3wrB09NVWUmIMlmM1UYO0NDFCmI5B/tvioqpjA9I4xzfsreBhhZ7t5C8/nGdS9xXpCyQjOJk7fpNoGEd2hCrlcj5OZdy2aV6gIZ1uB3LZBaLhbx4/W9pkQ2Ho8pziEZ5kG0GckWD5J06my3X5FBR94PqauNoQ+UfOm4dNPShgn9+zmWUVyZN04ooQNV021G2fQ5pWEe/n+97eRdfPZvK94OpDHNJiLq4crtUD9CwCd0Lrw5OCknlfrmU0dN3a4K7dDCgoQ9sN0kclfsgljr7ncnzV/+X0vJogrphJ0lcNoq7Wc9/ZRVZnJPuv32cJVZBldTXGDZsiGHT1q7VyqHS6Xj68IKuHHDfLPrFQbs7SZLif/eYnrsNNLRAyL6TLU0yvuuaoCEDE9hJIN00MY77fqO0gYZdYX+D1K2ADxp2hSvInt820LBLNv0GbaFh12wjptAwJGgYEjQMCRqGBA1DgoYhQcNwkL2/WMZpoH85ntIAAAAASUVORK5CYII=",
            } },
{110,
            new Items.Pokemon()
            {
                Name = "Weezing",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAK4SURBVFhHzZfBbtpAFEXzSxDIB0T9AQwb6K7dJdm06aZN/6JdkeQLIrqo1C5apZsAmyb9mygLDK++o97kaXKNDbjSIB1h3xl5jt/zGLFnZkkjw5SQYUrIMCVkmBIy3IVvk1Hxpce2QYbbcn//yR4ePtv3LyNrSlSGiqoFKeeBaDyP1L0BGXpwIS7oLxovsImgr3Q8FiNDj1+YrStbYN2Y578I+otVLeCre3BwYK1WK8AMxB0oQ4Yx6mLMKMCcMB+PF3ZxYXZ8+sta7X0puw4ZluFlYoF2uyPHIHZ8em3n58tHURxjPuZWIUMFFj1688Oy0cdi8fbj4mphzPNSMaxmvIZChoput2u94Xs7evuzdGHQ7w/kHH8zYLk063SqqyjDMiDJlpYtDCA5HudBAh+ILBYLu7x8mgPqtFmGxG+OWA5iqo1xBSlJOYxnWRZuYCfB+FWiBPN8GarjnzlWL66sF8PYTs8g5Si4327Z75sbO3l3/axqrBA+qko8z/M8jFN8p13sBSl5N5va5MVLmxyO7KRoIURJlvVDW708RJDHojj378GqF7YMlSCq2Ov17OpwGCRnrz7Y/PVZYFVUZzAY2LTIKI/XUTY6C0IEN+FbW/WLBGQI1DPIZ42VIbfTqa1WqyDJSkIQx6wuvxsTBHH5IYln8c98XrRsFdrohSlHQY75HHjJrVpcBqt4O50FSeA3zt3s6RzE0iH790sUX7sMGSog539JWD2KPasqnkFRVZzXfcUAGXrYAlaPFWCrYzEszhvBMXYsBXHsd3AdZEjURuECPAYQwo5l6/w8wHk83wQZEv+6KdtpbD0Fv14NG/vDBGToqfMqYMUg5+c3ISrDmLoL+YqTdTdWBxluA24iWcG4rXUei7rIcFOUUFMbRYbb0JRQjAxTQoYpIcOUkGFKyDAlZJgOtvcXtio6jo4MLFwAAAAASUVORK5CYII=",
            } },
{111,
            new Items.Pokemon()
            {
                Name = "Rhyhorn",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHLSURBVFhHzZVLUsJAFEXZjkNCyCIchpX424DoBHUl6MTPxM8O3FFCtTyqLnVpbgc6wao3OEVyOvIu73XHUQjBNVJ6QkpPSOkJKT0hpSek9ISUnpDSE1J6QsqhTKfTMB6P15d6PQcph2Dhlq+f4eruMRRFsVb6uWORMhfumNuAFqqYTMLF7SI8v39vAp4ipJS5VFW17RqH45B996SUuXBAUNf1Dpfzh15BpewiPqEI9/Lxsxdu+fa15xAUf38IKVNgr1kY228W1ED3EALh7DljNpttw+WGlDIFB0QgBLEQuOY1Dodu5oxayhQc0AqjIwhgBwRBVTAEz9mHUqZAQITjojxSuPgH4NN+iG2R+PsVUiq6usdjZq/W8Bo62R60YHwYMLq4uN1bAHSP19nhmWNDSsnwWOPCho2qaZpwc/+0LYxAHAaOOWYvSslYQPz7QjcwJivye34WrueLnSBY44Dx/UlfM+hiqhgcPK5xj9cKJmET+JdDYp1E0Thc27ahLMtNEHsOa9wp3s9wh5AyBQrEAbgob4k4YB+kPERXJ2wNh6ZdrTZdjZ/JQcqh9BllCik9IaUnpPSElJ6Q0hNSekJKT0jpCSk9IaUfwugPrCjhQxjQT4EAAAAASUVORK5CYII=",
            } },
{112,
            new Items.Pokemon()
            {
                Name = "Rhydon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKUSURBVFhHzZZNdhJBFIWzHYcQYA/+TKB7FTrSjNQ48WeSxFXkOIpkkBAHJDjTDbSHFaAuwJ8MAF/qlrmkKG83EDieGnwn6VtN8dV7VZVsmVnSyDAlZJgSMkwJGaaEDFNChikhw5SQYRWtVstqtZr7VY9vGhlWAcGnL/esXq+7R/3OJpFhFRTsdDq+koTjzWbzn2wdZLgISB6d9K17NvA8f33gKwop5vXtbfeq/vwqyDCG+45AIssye/Zq3973LrwQno9Oz70sheN5boMMY9C2H6MTGw4OLM86c2IhlEP78Q6rGs+3CjJUQLLo79nvbz0vuutEqiQBx9lu7k/OuQwyVKDNqOLl9zMvCNHdN38l0F5UDS2mKLdA2Orb3AAyjOEexORfLublUJ3R3Tv2ZzK24w8f5+RYSQpRMMwWIcMQTsoKxe0rA5I8VPPzNa3dbi/dahkSyBVF4ar11kvFbQTMCcYpF88HIBjeo/F4jAwJBLFatounEtmc1L2OTScTO36QW9a+EY3vQjVfOK6QYQgmhRRXi5PoL+P7mX16+MQ+P9rxdJ1k97p6YZUhyc9z/2EB8QEqQ4ZVzAQh4CS92LUcslAwbD+E+JM5F12FDMuAHFuEQ4IvAjwwfKYI8/BUc2xjp5hALm7Rr689fy/iyqFcKBW2mpL/TbA43/cXdgz/woSC0+nU8jyfiS3TWiLDMmLJn6NTX0GS5zdSEJy4k/3CXVF4lwclnnMRMlRADnficDic3YuoRv/wsQ3e7Xgy949E3FbKxfMtiwzLgCQrwS+NM1Q4PEBcCOdYFRmuQ7gNkhUcj8f+UGAPNhoNF+t3l0GG6xK2PR5bFRmmhAxTQoYpIcOUkGFKyDAlZJgSMkwJGaaDbV0BuGzoSnOrwwcAAAAASUVORK5CYII=",
            } },
{113,
            new Items.Pokemon()
            {
                Name = "Chansey",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHqSURBVFhHzZZLUsJQEEXZEkTYB5AV8JmoGxCc6QqAlWjJwN/Ez0xXQckigLS5IZ16PG+ABKGaqlOFJ5IcO+8FKyJiGiotQaUlqLQElZag0hJUWoJKS1BpCSotQWUZGo2GVKvVDP94WajcFzdq8fYo8vmScRYE/xJK5S7q9Xpy8WazKcv3p40wH4T6ny8ClXlo2Gw0kvlkItHHM43yOSSSSgbiZlfnMh9eyEO3KytMLlrFAa9/glymvV7yu2UjqcwDa869rbhotva8WA0L2+31xOM/LKgVX5NUbgORGuXeZo1lYWGrJbPBevpFI6nMQ+PcsPn1ZXLhKJ1qXhjel9nVVObhTk8nhfc+SaQT1kJoHB3UavFp+LnzoDIPBN51OkkYAtvxhXU94uds86SRCMNxTBwcPRA7WddZErNcShiGcp9Gu1NUNO4kgSCJXCzit+vXtN/fiHNv/aFxgMpt6PMwiqenL0RiouBnPN4IcwOPvkmA+8BWkt2afrswEP41uJHv4W3hSVK5Czdy37iTTRAgEN8o+vhgYdjFCFL8c+wLldtAHB41uuYCJwJoOHY2jvmfLwqVu0AkmwyLd4+XgcqyuGuzzD8GDCoPQafr+7JQaQkqLUGlJai0BJWWoNISVFqCSktQaQkq7SCVXzXfZEJtSpexAAAAAElFTkSuQmCC",
            } },
{114,
            new Items.Pokemon()
            {
                Name = "Tangela",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHbSURBVFhHzZVNUsJAEEa5DssYYY83SMIGb2G5UnQFnEa9QFK40fJCLlyYVDs9SYdJ8oVgRqxevAo8KHjVnZ8JEakGSk1AqQkoNQGlJqDUBJSagFITUGoCSk1AqQkoT2E2m5lD1wVB0PE+QDkEh6yevim4uKyDxF2/kPXifIOhHEJi4mRJ8X1mgkKKoojiODY+t5Hy2eq5qIPHAOUQ8/m8DFy/mqikG2bei/OJY6A8Bsfx2qK71E6HgzikDqum5nqfNUPZhxsnk+MgOEUnVE6D9u+dApSIzlolrDraaVWfNUKrdY+dIpR91JHmj/M8p+XyENAOdp3Ej5kilH3w1cvrzbI9bbfbMsJgYx97pudEsv/tRQMlor61mEnkeVFPL8syCsOQ0jSl5GF/NHLMmqFENO591eQksCgK8xUqo90VS9x6f/6LRNZbX5lVwGazsYG73e4QJXhMToCyDxvJT4xqKo1JOUFtN3Z6DJQIjnuLFvQRX1ESl4+1RuiR1/8SyHCkvVGDKdpbCa++5X3Wy0A5hJyPHMEBNtp9uhjezaRDzzgGylOQabrvP2+m9HU7NafB4k/iGCjHItG+a3WBUhNQagJKTUCpCSg1AaUmoNQElJqAUhNQagJKPdDkB2JB+emUYsNmAAAAAElFTkSuQmCC",
            } },
{115,
            new Items.Pokemon()
            {
                Name = "Kangaskhan",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAANhSURBVFhHzZY7T9tgFIb5Pd0Sx3b4C50a22HnNpDAkMuSAAOBsMAfaKGVQCwgOhCc7G1FK7VcZqRunXpXSyuagHp63o+YWtaBOKSVvuGR4zf25zfvOedzhohIa0RRJ0RRJ0RRJ0RRJ0RRJ0RRJ0RRJ0RRJ0QxDqZpUjKZoFQqyafyNf8CUYwDDL5o5OhlM0+GkWBJvm5QRDEuUZOGYVAi8desnbbVuZkyrrV+EcW4wGAmk6FisUjlcplKpZIimUwqY2cfduj861P68WmHUsbdWkEU4wBzMLayskKrq6vqGBh0HIfOPm7Tq9Y0JzxFadvmW+R1eiGKEpZp8UAYZHTTKRQK1+ZAYA6667j0DKX3cwP3pyhGgbn9ao4uOm3y52bIcx2VXmAqbC6bzVJtLEOek+F7uDd50qPr9YMohkEpG5WcMlgfd1T5SmwubNBzXdWLHnN5eUn1SY98vh73WXx/dM1+EMUwMLhXmVLmlroGDx9VKeu55HU5XKuqSX13/x797nRoeTKrzGU56Qs+H8SkKIYZHh6mBS7ZIpsDMPj6YYWO12bpiI0erVfpeP3qc3Mur4w1Z3Pchw63wzR/zqv0zf85xTBpWZYyCoOBSZ8fjjRPHs+rfsM5UoNJGOy029San1HJo+R36UdRvInAKPoNJl2X+45L/IuNYDhwvl/JK0MYkr1ummgPmE7xDhBdsxei2AvLMsllk8/3cnTg59kkG+LkDnwuKZe5Pu5SgxNTafIR6Xr8g9Ai2KZAdM2bEMXbwNDURjMqEZhCkp7n0bf323T+ZZdOnsypvkNq9QlXgWsWx66GDNRGH5BtW7yc/IwwongbwbaDHsODsd20ucQjIyP0nV9tPz/vUouHAzQ5OQwIklyAQQbmUIHoujchireBPsS2A4OFYoH3wTK/YUza2DjlHvSUjm0Hk43BWO4m6XBP1thg3OQCRLEXwdaDBDc3T2lr6y3vix4Pj0NveLqDrQdlxqA0+AfZlq0GLLpWL0QxDjCJcgNMNQbG5VJiILAnwuAyJ4e3TPgvWL+IYr8E2w9A+Zv8vvZ5e2nxET2I9KL3xEUUBwFmMTRLEx51+M9FOp1mWb42DqI4KOFEo9/1iyjqhCjqhCjqhCjqhCjqhCjqhCjqhCjqhCjqhCjqAw39AVzm7fUaI5gdAAAAAElFTkSuQmCC",
            } },
{116,
            new Items.Pokemon()
            {
                Name = "Horsea",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI8SURBVFhHzZTPahNRGMX7SplkJsm2VUQQITNJaar4AlohEzeufI6qdWUVqnWv4gO0+bMXwU2hXQiCuCglM3O8352OJsOpmZmIfIsfSX65zBzOvd9dA6AaKjVBpSao1ASVmqBSE1RqgkpNUKkJKjVBpSaorIrruqjVauYr/78KVJYlCzYYzTCcAk698c+CUlkGCZcFm2f7OVBzGmbJas1SWRR5cf/pDOHEhJokeDRNFkKuP3hlgjkLzeafsQwqizLf3tvTc0RxjHsvFkMK822WhcqiSMBwHNkQn/1b+H7wGEkc2UC2VeOlxfX7+7bJKttM5d9wvaZ9Ub3xJ5zQML+/dG4iidKAw8uAecpuM5VXIY1tZWfu8oXhOP389u4JvvZuI5qlWz4Yxb/XSINZi/lnLoPKq2i1WhgcXcDvbdr25Pz1n0U2cGiG5I05h7a5SYyNnX10gs20TQlq3H8Zkna7bUNKQM8E9jzP0t+9wLYJK3S7XXT8wIb3fR9B4BsXYPppiHq9XItULkOalO1mTs7n6GOIGw9fYms3QtDt4fjDwIYbG192UKhcBcdx8PPkAOdnh7hutvnOHkyLgQ0nTefXL4PKqrjNpm3s6P3QNnbNBJw/Cvn1RaCyCtmlLVMtd9+Pk0Pc3UvgVLygM6isQjY8fRNqY+e1md4E4fHMtpdfWwYqq5JdQ7Kt6dY2jeZri0LlKkiT6dWzOOVVoVITVGqCSk1QqQkqNUGlJqjUBJWaoFITVGqCSk1QqQes/QIJaWi59Ot/VwAAAABJRU5ErkJggg==",
            } },
{117,
            new Items.Pokemon()
            {
                Name = "Seadra",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALPSURBVFhHzZbLbtNQEIb7SnHuy6QbkmyInTTZw0M0tw20bwBSSSN2ICEuD1DoA7RJWyFQu0bisgWaJqJOGeY/7nFdMwlO8OIsPtXnj5PzaeaM3TUiMhoxNAkxNAkxNAkxNAkxNAkxNAkxNAkxNAkxNAkxXIV0Ok2JRIIv5c9XRQyjEBTCdWvokpVMqXWciOG/gFCpf04JK6UkIdc5JiWIdZyVFMNFQO7Ozk8qdk6pPfqtxECxe0ql3Qm1j7wsrmqK4SJS6Sytdz76chALymKdsJJ8q3e/PgqrVlUM54HNCu0PfpUgUx7cVC2Ibnew/eHfi4IYziOXy1Hr4JfaEHK6aq3RlfpbHkyVrO3U+LOZn1V5HazgMlUVw0Wks1lVFQhuHrpKBNdV25MKikPUtm1fVld1uPeAJl9fUSpp8U/K+2jEcB6Q05sFN3Rdl2ZXRL3rPIyuImTHn1/S9NvrSHJADMOgJZAJyoFLlqo3GjSbzah34mWooJ5mSez54/v07NE9sqyYWgw5PPNahyx35J01oM7dEV8Dtb4tZNfqVO6P/UwLBomlxfl8Xp05u75BDm+KKqozyI+aYpsfN9dTWhlcKBEtdUuWQT7+8oaO97f8Cob3khDDMEqSpxdyIMPTjPY4jq2o1RyFliv1L5gb0cpgTMN320psGTkghhJ4xKDdQK9/fHpBJ/vbNHz7ULWwO3Kp8nRKhc4Zt7ihKlfa+U4He1s04nsAKgiScQ7JPJrNppKsb3jtr9oOV/qSK+ZV7m7VoUwm8xdRhkMjhsuAKVbnkodkvXemJNHq0pNzymRzfIv8vaiIYVTQ7k2uWJsnucKvPJw722mwIP+ns+KrLYwYRgXDU2y9Z7EJFbreuYMc3tfpzP9XD4jhMviS3NLy7lg9fuKSA2K4LJDUE66nPC7E0CTE0CTE0CTE0CTE0CTE0CTE0CTE0CTE0CTE0Bxo7Q/4NjqQ39WgwgAAAABJRU5ErkJggg==",
            } },
{118,
            new Items.Pokemon()
            {
                Name = "Goldeen",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALNSURBVFhHzZXNbtNAFIW7zOtE+d9BS1g3sUMWvAS0dMEjZJFIVR8BFSQoK/6Uf4k34BUQlE2aIIEoSZwc7plkaGpuit1kMSN9snNij4/PvTPeAeA0qugSqugSqugSqugSqugSqugSqugSqugSqugSqrgtMpmMHPT/oqKK24DmptMp0um0/NSviYIqbgNrkGMTk6oYF5pJJpNyevW71WphNptRQ6/XQyqV4uk/9/4PVYxDoVAwZrrdrjFBo6VSCUEQYHTkYy5HjtumqIpxsYnRJPE8D4ODMrq7uxgelIxJ3/dRLpcN4ftvQhXXES7lqm4NtNttY3L4xPtr0BedidrBa2Vcm2MdqrgOGvnx5RVy2avtI5fLmZJyQbDXKtboijmmOX/zDNKUvM+MqCZVcR00+OnjU/w6PxOTaZOmMdZpYyZH9hzenWIk6VljTNFiy21HlL5UxXXQYK1Ww8+vZ7j89lpS8BBMxmKsgovH8nBJaT6fA++fG6P+shdHh9cTpDGtVTRU8SZMmT+/xKWkODrypNd8k0z/3iKl4PdYLluMarVqyk8zq8hQ59ZQxTDZbNa8dVom5wMHksh3KScJphP07xcxeLRIikZnyzIyzU02aaKKq+TzeTSbTXQ6HXSLRVT29zF9ewp8eEEHqNfruJASt+7eQXtvD8NDMS1l50rm1sOXC88ZB1UMw7LyYYQmuCD4lWBCjUYDk8kEiUQCD6XPpqI/qPioeOXY5dRQxTD8WjBFbilMZDweoycJ9QUapUnuczTMfdD0pZQ7l0mDLxeeLw6qqEGTq+fj42MEJyfoLTdmW1LzFRGDXMVsAQ6+GO+7DaoYBZo0aYrRDksvRmmEZWXCTJN7JJMl7OXwHFFQxThYo3Yx2HZgX9JUVr46xF4fF1XcFBrbtPcsqugSqugSqugSqugSqugSqugSqugSqugSqugSqugSqugO2PkDC9po1YjwPJEAAAAASUVORK5CYII=",
            } },
{119,
            new Items.Pokemon()
            {
                Name = "Seaking",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAK+SURBVFhHzZZLbxJRGIb7l5C7O1v9ATMDJV5Wxf4RWleQsNa4UxfG6MYVw23hT0CaGKMroz+gUSi3z/PO9JscyVscaJuckzxheOfAeeY7F9gTEaehoUvQ0CVo6BI0dAkaugQNXYKGLkFDl6ChS9BwF/L5vGQyGXPJ7+8KDbcFcmEYSr/fl2w2ayLeD+AhtnkQGqZBKwY8z5NutyutVkt6vR6VtCoctVwuh5d/+jBomAYMOJ/PzaVIpVIR3/el2WxSQfTVhocAaGkkaZgWlRwMBrJcLhNRVFMl7QdBPxVE/zRTTcOrsKYpeW8L2qLab72P3W68ghjs/McryWXvmLdxVq1Wo6p5ni+dTieSwWZBDkm7eu12O5G8lTUIwdGnhvz5+TqShMB546FMTh9JxUhCVIFsEASyWCx2rh6g4Sa0ipNfb2Ty7HEkZwNRVFNFLy4uIkEVXa1WqeUADTdxleBquTC3xWRPkmoG5vjx/fgIwrRDDq1YLOKFfv86NNxEJHg5rbacbgysOd3No6N9OTSCYdhJ5LTd2BRDCAMrkPvgl+W94fdJLApBDMgEz+r7EhhJTDHWIe7julQqma/nY9rQUIGc/oQBLPp3Rmz5MZTvpy+N5N1IEhIrMyja2fF9M8VeItc304vPzWazaKoxvYVCAV3pmOvQ0EYlcbiiKl9PXhiBILmG5PjoXiQDVA5i9oPZh/c20NAGgjgydKFjsC+N5/LNyGkVbUEwfnogh5VYSuXw2VsRBOVyOZoW/CnQ92+9eB32uqGMjx/IuB5LYqqHw2Hyi4JKq+AukjRMg0prdUf1A/l8OcXYBJAE2L21Wi3pt80RA2i4DSpqg8MZYrpjddfi3vrn/wcNrwvW7XQ6jaqF613EFBpeF1QVYuv5LtDQJWjoEjR0CRq6BA1dgoYuQUOXoKFL0NAlaOgOsvcXgDdJeUbrGpQAAAAASUVORK5CYII=",
            } },
{120,
            new Items.Pokemon()
            {
                Name = "Staryu",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIbSURBVFhHzZTBThNRFIZ5pc60TbrtsILddDAWWFF8EERNVDamwhNg2EAapOpCN0ZxpU+hQjSKCwVX8Hv/O7mNaX46dNqkZ/Flev47mXw9c87MATCNDC0hQ0vI0BIytIQMLSFDS8jQEjK0hAwtIUNLyLAMtVoNlUrF/dTnZZHhuFDux7tH2F5PEE1ZUobjYlqQr/XlgxWcvX/sBfubbcTR9CRlOIpqNUbkBOIocmUuyO497TTx4t6yZ2aClPn+9iFe3V/Fzp15ULYaR/jmsm4nGQgGSd7/P8PPuwkyvI56vY7Djbbv2K8PW/h5vIW+k7m1lGLJwd+E4s/vtv1r532B2P2Z4WcWIcNRcCEON257OUplWYo/XxZwcbLoa8IzCp0d54KcTY5AmQWS4SgajQaerDWRpin+ni5gfzfF78/5lTVFeUY5ik26ODIsgl1kp86/LiJzMlmr5a+se3t5FzmTFDvaXAZHY/gZN0WGRVCQ3WKnetk8rj6+Rq+VDLoazo6cYNnlCMiwCG4uu0WJq09vgMtLXHRSX/MV+862ZiTI7vEzQhkuyH6a4NzJ8cr64FkuytnrulmdmSA7xMUIol7W1YQzydnbXm8OPuhlkeEouMVd98kgHH4SxEJNOdL3kslEXZRhEUGkqOZHnaLsejgbFxlOC3Z7EjkiQ0vI0BIytIQMLSFDS8jQEjK0hAwtIUNLyNASMrSEDO2AuX8uWzElIAop0AAAAABJRU5ErkJggg==",
            } },
{121,
            new Items.Pokemon()
            {
                Name = "Starmie",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIQSURBVFhHzZY9TgJRFIXdDiUQWASxmRkajRXGBlcA7sJYoZ1auQMINhobldUQaMDrnIGDT3L4Gwze4su8OQPMN/feeeHIzFwjQ0/I0BMy9IQMPSFDT8jQEzL0hAw9IUNPyNATMsxDtVq1YrGYLvX1vMhwG0IhrO8773Z53k+zcpb9FTLcBIQaJ9d2fnqTCpUyUSVYqVQWD5EXGW4CN6ZgHCfWbn9kcu32p11dDaxUKmdi4UMs/8a2yHAdqF4URalYnAlA8L7zWxAZ5Q4qyFmDBIQgAlGCSuIaJZmjmnlbLcNVQLDVereH24E93s1IksRee7G99eN0PZOkHNbhZ9H65d/chAxXwfbyxpCDyHBYsPG4YPX6rPVoOaUAqr38Am2LDBWQaza6WXWajV52hNhbP7LR6OdIUc4lZzNP9YAMFRQMZw+CrBrPIYpW45wzic8fbAbRYswcqgW54VPHvqZTez47tiROz+ftDkX32W5kqODeh2qEgpPJJL1sNr6oW31exVAw3G7ySMpQgerxZmwx6J3UbNSIrH9ayyoIeVaOs7rPnijDVUASs4SthpWkDFjebsJ5zbsXynAdkIQghh9vJmeSYpDhywHybi9EhptgJbl+6UYLQbQTbWSl+SD87q7IcFfC+Qxn7N/+zSjCqv4lMvSEDD0hQ0/I0BMy9IQMPSFDT8jQEzL0hAw9IUM/2NE3fdoIExjg/8QAAAAASUVORK5CYII=",
            } },
{122,
            new Items.Pokemon()
            {
                Name = "Mr. Mime",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIdSURBVFhHzZa9UttAFEZ5JVuxezw00NlSw09F8iRA5aQiVBAqhipAQZLGttwkkyaEhsFPkYkfwD83+y26iqX5kI3MwC3O2DrSeA53l7VXRMQ0VFqCSktQaQkqLUGlJai0BJWWoNISVFqCSktQWUS9XpdKpeLe8vvPDZWPgbjV3bY03n5wkdU0VKNZeNG9RaCyiNlIDR396ojcxp43QZAGgdXD68yz+c+bB5VF1Gq1zBT/fD6W6e9eGgiiMJTG4RdpHH17IHm2zBSpnIcu2/e9PZneZOPSwN330vj4tfTkFCqLQNzZ+rqEzWZ2etOJuy0yvDr9H7hkHKCyiHzg8PKTJ6i6vTga+UBcI7LVasnd5qYEJZZWoXIeiGy6wB/7+/L34iQTONjZkcHWlkQuDn/AYHvbX5eNpLIIxGHvhS4AE5qNBAhCHCaHMOVFAhHXbrel1+tJ6Jaw2+36V4TmOdvYkPsk8ty9r75UYKfTkTiO08D7ZAnBdDx2j4n0+31/H5HLxAEqHwNnoE4wcAcy9qFGxu5VwzFBnS62wM+DA79H85+3CFQWgSnqgav/LIjRuHEyxSiKZHzT9fuyzAGtULkIiMt/L2O6k8nDeYhlxpSXiQNULsrsNPVa9+hzxAEql0GjcQauvcN0X3GCefyy49dL8gPhVb7q5qETVPL3nwqVlqDSElRagkpLUGkJKi1BpSWotASVlqDSElTaQVb+Ae7kLtImP8mkAAAAAElFTkSuQmCC",
            } },
{123,
            new Items.Pokemon()
            {
                Name = "Scyther",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIRSURBVFhHzZZLTuNQFETZUr6CJRB6YjsTPisAJtDqCT3rwAb4TBC7QKwgwStArACJRcRwO/XcFR5RJdiRad1IR7LLiXNc75NsmJlrZOgJGXpChp6QoSdk6AkZekKGnpChJ2ToCRlWpd/vW6vVmh1+HPO8KWRYBQjtXm5bq11K4Xj0eGrtTnt2WX9mHWT4FZQbHG3Z7lUpdp7/DECQTS622ev1ajcsw1VAbvtwM4hBcDT5kBscfz5nmxx+Ns57VUGGq0ALbK+KHN7/Z3xie9cDe3m6tU7NKSDDVXB442GNgSjkkzQJrcVy+cPv7xWEHL9QCUIOQ4/rIM2S2cOUcq/Pd7XlgAyXsUwQYmhrOp3awc2PcC3NUkvTdC64TntAhqugZCxXFFPrdrtB8CL/FeQgxhYn92dryQEZLoOrkYJxk2/vhQ2Hw3lrlMN53a0lRoYKLo7J48SyLAsSkItF0FT2rz3OPz7Auhu4DBWLghAibIxQGNsOmsULUwD3qYsMFdjPxuOx5Xk+m0+d+ca72CAWA1psQg7IUIEGIUg5ZklSDmXTzREZKmJBnscNDg7LPZBzr3grQtuYDv9lkQAMM48pvH+9EyT5r4Zgy8Gqhmzd398YGVYFkhRazGNBPkD8nqrIsAnihrHyOTXqIsOmWNZwHWToCRl6QoaekKEnZOgJGXpChp6QoSdk6AkZekKGfrCNvzci+qhc1Uo+AAAAAElFTkSuQmCC",
            } },
{124,
            new Items.Pokemon()
            {
                Name = "Jynx",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI3SURBVFhHzZSxctNQEEXzS45s91DS5UkNrZPK0EAHGb4gVMLp6JzwATBQIKgSpyHJD8BQwfABCbhQ7EX7rGuelTtEEuOwxRlJV36aM7ve3RAR09DQEjS0BA0tQUNL0NASNLQEDS1BQ0vQ0BI0bEu/35dOp7Ok+r4NNGwKxPKLVGQ68px8fCBR9O+iNGyCyoVikFPmv14sRavn6kLDukAuSWJxzsnVZboiV61m9XwdaFiHXq8nR++HEsdOjrOhl8C9XiEMyW53szjGv/U3aFgHFUT10qenMto998Ru8TzJHnpRSLatIg1vImytysyu5nLyaiEYorKhYJuBoSEDk4p7CB6PTyXajCTPc9l/thCDcByvCq6tgir06H5ayJx5GawUVsHJwflSOEmSlcFpI0nDKip4NP50rXWYXpX8vncoP54fyv7u2bUKqtjL0T2ZfBiuT1Crlj5ZlQwnVvm2N/aC4XvswrUKAlQSbcaauRw4SUrJkLC9WEFrFwwnUZ/zzwOZ7jiZbjuZf/lzr8IQVLksy3zLw/N1oGEddA9eDLaWYvJ126OCkMN/VOVms1lxTIqF3dUL/SaDhjehlXu9dUd+loLKO3fXP0M2SYqWFisI/1kdHJ3qW6mgCqJ6VUFctYqPy9WEoXlTvIv+R4shFd6rICoIubclTSRpWBcMTdjuUBaTDTkVu7UhCWGioFtKNRUDNGwLREOqv2kKDS1BQ0vQ0BI0tAQNLUFDS9DQEjS0BA0tQUM7yMZvr3krFjCqR4EAAAAASUVORK5CYII=",
            } },
{125,
            new Items.Pokemon()
            {
                Name = "Electabuzz",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHbSURBVFhHzZRdTsJQFITZEmi6B32z4UUfcSmUTfizAn920JVg3IQaH69M2wknh2nrpYQcki9wp+Wer9PCLKUUGhlGQoaRkGEkZBgJGUZChpGQYSRkGAkZ5lIUxe5NH5uKDHOA3Nf2Kl1ezHdLfc4UZDgEhObzvYwVRG6PnQIZ9oHhkHl/vk2LRStCQWQ/H9cnb1KGfUDw7ekuVdWqV3C5vDlo0beegwyHwKCyLNPLQ9uilfv9bAW/t/sm7QXwonKQ4RiQrKr7pk2I2fYgB1HA5xIXY1vPQYZDYCDE0CJFCERxjOIQZtNnucUYQhkIUhJtcr1erw7k/D45yLAPK2ilCI+RU0jKcAjVImTtms/hZrNKr4/tLT9WUoZjUJJioHvGGhkvdzZBSBCK+FvLFik2RQ7IUEEpDvcSWNd13WDP6ZqVe/4HGXowBMP438cWkRH+aPBihnPR6hRJGXowgAIc5gUtbBVyfE5x/jGiMvRgYw61Q5hTjDK8GODXuZIyVGBjL2cHU86ulTzb5D5jyHAMDMCPAUMB5QGbBjyGz5Q7iyCwUj5HY1YE71bOf2cIGU6hG960hpeVzJUDMpzKsTIKGUZChpGQYSRkGAkZRkKGkZBhJGQYCRnGIc3+ACjl61shrGpSAAAAAElFTkSuQmCC",
            } },
{126,
            new Items.Pokemon()
            {
                Name = "Magmar",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAILSURBVFhHzZVNUhpBGIa9DrsgA3uNq+yG4gRqLqSVnVcgN2DLBWKZY2QhkZX1pd/W1/nS9cr0DPn5puopnKeBfuxu4MTMQiNlJKSMhJSRkDISUkZCykhIGQkphzKfz206naY/9fgxSDmExWJhj48T2+8n1jQfkuo8oo8Nl7KWQ3HKj0HKGrhCZcifjANS9uEjyPZra7PTLvi/BWLVvl2e2cPVuT3dppCfE1utWtvtujDPP99irN59ikMgWC3bFNzF7r9Mkj+zpxT8XhyPR+kVUvaBN7+/+vhbIIM9MxHB41G7slL2gUmWy2UGIWUk7/HoVwrfl0PigJQ1YGIG2fNzmrSxtm1z9O7mZZs5zpXMq5fGmtO/HDhvZmbbdQYB368vciSvh88XMs5/uGojpTxE3rLXOPLj7u4tyOPPoA8sxw4h5XsgjoF8RBzh5NjmPF68npG1cUBKBSb0AT6MHxgPvgN9ZD5/I35hpCxhHK71py6SlPfb9UsgI8GYOCBlyetK5BBOCBCCIEyMMcJIBjOWP4d4z1qkVDDK3/tAwKAyls/xr69Fyj4wEbYaEzOSj7j8MYAv/7khSHkIToSIzWaTYxgAcI/LR4+NA1L24YPKyXGPKMKtLp9Xi5THghiGhQtECLceF48AxsYg5bEgyFOOD0HKSEgZCSkjIWUkpIyElJGQMhJSRkLKONjJL+HU7BRGgXVmAAAAAElFTkSuQmCC",
            } },
{127,
            new Items.Pokemon()
            {
                Name = "Pinsir",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI1SURBVFhHzZZZTgJBFEXdEuO/wwZoWAHqAkx0Awg/Rn/UHTgsQNQPpw04bAg6z7qtF8v2pukGQx7JCXC7A4f7qkrXzMw1MvSEDD0hQ0/I0BMy9IQMPSFDT8jQEzJchlarZbVaLbzU16siwzK02+3wpPPJZGLNZvNfRGU4D0g8PNxYo9EIb/W1NE3t5eVe3lMFGc6jSBCwRTyWlZRhEZR7fr6z4+G+1ev1EP+9h4J4YNzh8euessiwiFgQxO3gGtYdiAWXaVGGReQFKQmp15tT+7g7t263a4+P49k6zP+QKsiwCAgeDfbs6Wk8+2KKgavhtg23NyxJOpkk7oHwojtahvPAWcdNEsuNdjat/j3e0e5WJpkkiV0c9sNaXaEgQJOD/rq9jb8E0VyaTrORYrQQvAxiyMkikjIsAwTRHsaHlgjagsz77dlMrPt9bZExy7AMEOx0OjadTq3X62XPJ6ODTCRuFXKQhjCXQP6zipBhWSgZN0gO+xuzzcJWQdUxy7AsEMRm4bGCHYvDG4KUQoOQ5XpciSDEsJ6wSbhT88StcQ2y1SpjlmEeChGI4Yvi844tssF4xHwfj7tskzKMwZnHc41jYguQVWswHq96/e+CEOHBzBZ5He1y1PFa49pji9jl+JFpeK7yz4MMFRyzytEiR8gfAC4GP41BmHn+M4qQYVXiNRpnaH0Yzj60dj3aXe1fkjLE4lWbIzL0hAw9IUNPyNATMvSEDD0hQ0/I0BMy9IQM/WBrn9/C9yZf+/6OAAAAAElFTkSuQmCC",
            } },
{128,
            new Items.Pokemon()
            {
                Name = "Tauros",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI3SURBVFhHzZZLUsJAFEXdEgTYRxJXgDMdKSNkqCPACQUTdRX+BiBuxM9GwHrmtvWgq+u2Nh/LR9Wp0JdO+uR1d8KBiJiGhpagoSVoaAkaWoKGlqChJWhoCRpagob7oNlsSq1Wq76m5TFouA9arZZ0u32p1+tVM579Bg03BQOjKmFlNI+1U6BhKjpgt53LzcVxVRk+pTiir2abQEMldseh2O3lyQomua0coKGCCy8WC2k0GitRZHmeS1EUjmtPsKzay+XS9ddr6Dl6xHUU/f0naKio4MvLk8znj5JlmZMbjQby9tyRj3lHDsu1pAqiP/r6N+ULoZ26WWjogzU0nd45wbIs5XV25sR8IIlqqpz2vR8UkpEpB6F0DBr6QHA06lcDFk5uMl5XT+Vms3snpfg38jiMS6ZAwxDcLaY2rB4G12nFB9Ubj4erm9F+WZb+3AuhIUPX42Ry5SoIuc/PpTxdHTpJrEuVw3T/iyCmutM5kbdqcAwKYQhqJXVX47s/xb2jQuqJuzaEhiGQe52eriqiAysQ8ncyNof/O9h2HdIwBIJ3/Vzen9dVAVq18/Z3lQDaunuxS3HenwsCSOLNAYmHSgByvlgo55+3iyQNQ3QQrVhYtd8E8VDu9YYb/YtRaBiCZ6FWgVUuJuefn/pqC6EhI6yETrcvt8tai0HDGJD036+QxONjH5shBg1TgaQed1lnP0HDbfCru09oaAkaWoKGlqChJWhoCRpagoaWoKElaGgJGtpBDr4AzITpAbaQV1AAAAAASUVORK5CYII=",
            } },
{129,
            new Items.Pokemon()
            {
                Name = "Magikarp",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKCSURBVFhHzZZNctpAEIV9He+CBFSSHfYJ9HMRQ7JIsrRPkYpXlHOApLJBBZsYXcgYFoA784Ranpp6MlIUk1HVV5gnYT66e6Q5ExGvoaFP0NAnaOgTNPQJGvoEDX2Chj5BwzYMh0Pzws/9C2jYFMjNpiMJg555y6/pCg2bMhgM5OHhXPr9N9Lr9Qrca7pCw2OgclEUSTa9kPXjuaRpJKvVQdS9tis0PAYEUbn591EhuNkcYIJdZ5SGTVBJlWOCxTVXkfQ7zCgNm4AvxwJJkkjiOC5w51AFn3Y7I9+v8jbQsCkqsJnEksdmHseR3F68k6AU1XMQxPE3kjRsgi2nQFKBbGqquhr/B0FXLs8yedrvZfMxreRsyZ0RzBcLCcPQfJz/zzpoeIzi/mcJ6oxtt9tKUgXR8mU2K34AjrZVpOFLsNZqC3HYVUT1dAGhijhOIvg7GlUStiTauP6QVGKYPz2P7N6MQj6ft2o1DeuA3NfRW9n/nIr8upPFl4msSwFbRMW0smmayvX1WG5uJgVBECCm3+FCwzogOPt0JUlZoZ0RzZPLqpJaOW0nKoqKJUki95jL164ggCSewxDJPo9lac0bnsd4ouDZjHbqwsCB2dPRAGHDjQUN64AcbsAq6Faxmj0jCklUEu3Vp4t+3n7aHIOGjKK95d4Pc5iUkhC8vXwvj9aC0WoWlWxRLQYNXXDfszemeL/98bxQ0OZv5n4HlqaNSXzYfkGwTbUYNHSxq2dn2i57tiBnt/kkgoBJ2ucgopvY+Z0RNbscXTRdNrI0rMNttYv9I/AKyZNVEDQRVCH77y7Q8CXwxW72mtDQJ2joEzT0CRr6BA19goY+QUOfoKE/yNkfNF0Ipiq8Wi4AAAAASUVORK5CYII=",
            } },
{130,
            new Items.Pokemon()
            {
                Name = "Gyarados",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAANRSURBVFhHzZY9ctpQFIW9JSFwbyaNBY0EK3A6TArjNDZZAU4awKtwsgEINPxsgDJOqkzcOEmRmTT83Lzz4MrXzxeDCJmImW8GHQn549z3hA+IKNWoYZpQwzShhmlCDdOEGqYJNdyVw8ND8jzPvNXP74Ia7gLkptMp9ft98n1/b6JqmARuLQxDms1mVnA+n1M2mzWn9c8kQQ2fwx2jbA5ieHGLOP+3qOE6IHN0cUZeJmMOH+eQ5Jdsz/1CSVHDdeRyuSeCyCCgCeJcp9NR2+TPubmLGq5DNoibA6y92nBGswVR8fqOgvYd1UYLyvhZK9fr9WJBbhMcN7+a+2zeTGoI3NGwXL5+TmEUWanzMVFUKlMkjgEkQ5N3u91H7eEekC5URxS0vlFwOjYba/HshlJDINuSxywIKZC/rMXHkIQc40rGgm0jZ853P/Y27ng1ZKQkRill8F62yUKBGZ2UxBjl/aTgbL7YuOPVkGFBSEghTQ7jAmFUiiUh7K4x3BPrb5v2gBpKWBJCEsi5bUGIRw+0DWAFK4ONa49RQwluyONlMfzxoDJcLvRVe7Y5kfG43RGjPVzveevHKlFDFzyzIMmt4JlXfGVGyoJCCOsKr3J5ecxjBmgOcsObKvmZzc9AoIYS/tZ4tkFk8vIFLcxvbiy4ag+/w/xiOSmO62Tje2kQcoObCr0emY1QHZsNsZTUgAgeKXgwl0rLjYLs/lPTCK82TsL2gBoyEGxcHNP32yb9/NKm8YdTelsPqNB62ByQkBuDm+QW72+vrSBEi6sHtFyXm1BDYEdr1gxGwevv6jKg0fuKaWi5g1luaFqGPMA5lrWtrb4EN7jtaBk1xKZgOSxuCKIZtAIZKYidizUIebQL8CWkMK5t1Is2TzJeoIZSEMdoE5KTkzyVozCWtDtz1QwkZZOuLN5nEsoBNdQEJydH9PuqYQQju558/+E3Wv5nArBuXTHkuD4pagjcMf9qNGhhfpowZimI684GU/vvlfwsy+4qxqghg3bwB9BIZEaLhS/l5HWu5L5QQxcI4Hn443OL3r0pPFlL/10QcJvuyP6lHFDDJECQN4l7bh+oYRKsoNlMSX8htkUNk7Ju/PtADdOEGqYJNUwTapgm1DBNqGF6oIM/+ViTf6YublgAAAAASUVORK5CYII=",
            } },
{131,
            new Items.Pokemon()
            {
                Name = "Lapras",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJlSURBVFhHzZZNctNAEIVzJVnYd4jIxpJPYCqbkA0/N7BXxFwgwCUCbCQrFwjFBQisKNhQcAADzbyxW5lMnhzZTopefBXrlTL63D091p6ImIaGlqChJWhoCRpagoaWoKElaGgJGlqChm30+31JksR9XJ/dJTRkDAYD2T8qJXtcO6HUS4FxuZBHtUiSPnC38f/dBRrGQA4yEBzmheR5LtlRJePqj5dT7kOShiGQQ5Wy2RcnN3JSv71MdnzuBfXvfxMEKhmKadUaUfcFkl7qbudrbAsNY3T/xS2FlMfvy/sZFBoywioCtHOxWMjh+VI0rp7u213FaRgTy+XFqJlgtDg7+dwIqlhZnkldv/ek6XLqdb1NoGEMzrpQEHgx19qL6rkcHFd+ukOx6XQq8/m7RhLXvV7PLcef0QYNGVpF3XMQ+1g/80AQGSQnk8kNMb1GJeN1b4OGbYT7ClyUT64EXZtxDFXV2xvVC2U3rSINuwLhRnJ26avLJPFZrzetIg27AsEfX0/l1/fXcvDyUsbzv36AVDAUg2hRLPdpvM46aNiVUPBNPXfDszwnVVJbCzH/83jyyU/7JpI07IK29+e3V14QHK4EVRJSKtYc6iu6/urQcB06KMPhsKmeolWMZfQNyL8NuWHSvIskDdvAeagPwTB8qJ5eqyAYjYqmYrgHFdSW6rujouuug4YMVG7/xapVq4rgIWGbIXdaVfJwdlUlHZyuQjE0bEPbGz4srArarlUNh0bZ5nWMhrugX4JN9zaSNLwLwmqHxPfdBg0tQUNL0NASNLQEDS1BQ0vQ0BI0tAQNLUFDO8jePyzSIJ5UFMhlAAAAAElFTkSuQmCC",
            } },
{132,
            new Items.Pokemon()
            {
                Name = "Ditto",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAE0SURBVFhHzdVdToNQFEXhTgkMzIPbJ51J6SyqM+ijcRT65s+UjhzoSa5kSQUa3A9faBaE7BBCd2YmDaMSjEowKsGoBKMSjEowKsGoBKMSjEowKsGoBONcVVVZURTdTz6/BsY56rq21/O7PR2/rCzvujQ0H3yL0Rj/IkacDsO44CMP98/2dv78MXopjNf4OB+2T3s7tR/9iPHQ3JqRGK+JgTTGjQf/60B/iiml/knGILJ0JMYpPs7fscd2eMdCDM3lozcfeHx46UfGMR875te4sii7W/B9f4Nxin/zmqax9jIy5CPzll+zyUDnT9E/MTR0ymYDw9TQ1L2T3vy45qONcS4fmo/MRy0dFjAuEf/HtxiVw6gEoxKMSjAqwagEoxKMSjAqwagEoxKMSjAqwagEow7bfQMbzE9+N77NfAAAAABJRU5ErkJggg==",
            } },
{133,
            new Items.Pokemon()
            {
                Name = "Eevee",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHzSURBVFhHzZVLUsJQEEXdEt/SoZYTnRGcgGyCjxtQV2G5Cn8DLVeAMsFygjJCXIC/QYA2N9AQUjcQBKkenEq4pB6Hfq87GyJiGhpagoaWoKElaGgJGlqChpagoSVoaAkaWoKGlqBhHLLZrCQSCZ/wd6uEhvOAXOuiIO3roqRSxgRVrna4Iy+XBSrIqotM7xeBhrMICt6dbEkqORFRsU69LO+NqiefHIu6H01Jp1P+c4tAw1lAolzYFsfJeTjSeaiMRW6PN6XrfdbqHuQd/0/0v5oiP8/rE8zlctLyBLqPFf8c4qpSuFaL04KQHnw//b+gVg8/DrEwTO7+dAgkUenwmvOgYRSZTEZc15X2TYkKQuT1aihXKQzPqArirIbXiwMNo9Am0BGjUrXipKpBOeTJUZOE14oLDaOAYFCucb4vg37PO1vpcWe/jZpEq/fXyik0nAUk62d7/lZCEjKoEjoYFYMgRoxKrlUQcphnR6VdvxmCZwxyvc+mJ1ebEly2ijSMQgUx04JACmNE78NNsjZBoJJhKdzjqluOxsBIWnabaTgPSGJY4y2C7YQctj0sg+eW6WBAwzhgJqIx8qNX3rKVioKGcdEKYcSsYqQwaLgoq9jKKGhoCRpagoaWoKElaGgJGlqChpagoSVoaAkaWoKGdpCNX8D4N3bbfBAGAAAAAElFTkSuQmCC",
            } },
{134,
            new Items.Pokemon()
            {
                Name = "Vaporeon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJ7SURBVFhHzZZdUhpBFIXdEgxQMT4lZgPTMyswO4hmA6AviW4gJU+JeUGzgNFhI/l5wviCugCgrn1a7jgMZ2DMRKqn6ivl0Ngft+/tcktEvIaGPkFDn6ChT9DQJ2joEzT0CRr6BA19gob/k06nI41Gw1F8rwo0XEW73bY/+HsMCHZ/juX9xY00mkEmW1WYhmVA7tWngd2oaV8u5mWb4j0IHv65FxPH0pv/3gyCpbUMGpaBauQF9fiQbR9fOIryAJJ7g5H0ft85Oa1mcR2DhgzIJF/fyM7xQEITLYgl33bl7rorQbAsB7Ty+jlW6TJoyIDgeNSVnZNzt9H252pyWvXur9vKx5qHhgwVjGOTyUF0POrJ/c2hEy8eLz4ThqFbvxFBbGbMkyADknqM2gaQe07f5aFhEfRQkiT2GAM3ka9PfjgZbIymx2tUk8kjx4C8uCCqN51O5Wg+hTqRikqjJ9Ozt44oCmvJARrm0epF0eME6p0GsLGJHu+2q7N3TgoDg55Er6qc2e8v9WdVaJgHvTeZTOyGT5csMAd9W9GZtFqt7I67/Xsk6fddVznz4Yv0avSeQsMikHRVPDh1m6ogqpJVyVYSPQjQCvHHfrb2X6ZXoWGRfBVRmb3zayelx2f2T+Xy8krSNJXZbLYgtxFBoJLD4dD1o1YLwpCDGB7Imfnk4tj1i7zYkOSBJAYFonggm4nZ6uYnVu/BfGYf+ndXQcN1qCg2d703Hwh2nFiLdRsVBLqxXjNlvaZfpphXhYbr0H+f3IDYfoNgnWNcBQ2roJXRi7vOpK6Chs+h7hGug4Y+QUOfoKFP0NAnaOgTNPQJGvoEDX2Chj5BQ3+QrQdWfBm3iAtTJgAAAABJRU5ErkJggg==",
            } },
{135,
            new Items.Pokemon()
            {
                Name = "Jolteon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIeSURBVFhHzZVLTgJBFEXdEt/Eocw0TvhsRMGJzpTehNGVGJ2ATDRuAHUFqAug5Vm3Og8LcvsbMY/khOY2yPHWq2JPRExDQ0vQ0BI0tAQNLUFDS9DQEjS0BA0tQcOitNtt98Tv/RU0LEKr1ZLl4lCajZp7yd/zF9AwD5WTryObglhas4Jhe4NBV2q1RBDSes3Iu58GDbNQwSg6le+PpEF8sc7jtrAynxxIo0LbNMwCgpeXJ17u4XbfPSdt6nUojFzHAIKDftI42P67adAwi3CJt9FW/fXoXMbDC/8aozCfdmT1WX5uaZhFmqDKqVgod3f923QZOUDDNLzccum+6HhDTkmTe3s8kPdZZ/czCMFutyvx4lcKs9d3s4UMgq9uKSGDeev1ehtLC3baYHj+ATQUx7E0m02/CUKxcFn1nyizORQaMrycW94oOvPLp4J6hKjcdPosq9XK3Rt4yfubhEa9vBygYRqQnEyeXBv9jdmCABqCXBSN1g0iD99TRZKGDG0Qj9nsZS0Crq7cDv6OfY720PJ4PJR6vb5ut6okDdPQXwdsFF1KlcIDy6o55jL8jIqW3ck0zEPbhBAaxEbRmUNDbDPgM5D8N0G0CCHMns4c5i1NQJvczvOgYRY4C9GEbgzI4ayrsnxFoGEekEQbAOci5HAYlz2Ei0DDMujSVVm+ItDQEjS0BA0tQUNL0NASNLQEDS1BQ0vQ0BI0tIPs/QDZpDI9HE6J3AAAAABJRU5ErkJggg==",
            } },
{136,
            new Items.Pokemon()
            {
                Name = "Flareon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJTSURBVFhHzZZLTtxAEIa50jCPPY9NyMp2nyARK3ZwhbDJY8PjBIjZIHKJABdAcApgFglhMY9K/z3U0Or5PbaRIxXSp8G/relP1V3lWRMR09DQEjS0BA0tQUNL0NASNLQEDS1BQ0vQsIrBYOA/+L22oeEqIHf7aUO6nY6/5M+0CQ1X0e/3Gwni+Y5/FqT36kDDMrR69583A2WSegTwOR6P8b+MRj+k210PeRNoWAYWzLLMS5YL4pnfR5n01uf3cP3w8FVms+m7JGlYhlZk6LblzkvGgriHbYTcy0keBHENudHoewCSvV6v0XbTkAGBXxcfZDadLFVCqwaxw719+bJ3IM/Hubgi94LfFoI3Pz/K0+NcuG4laZiSbpMuoIdf5SCU57n8OVqWi2myzTRMUcF4kfvdLfl7nAURFYJclSCq2H09n3WgYQzktDGeXiVVDlVT0updXezIzeXOYktVDlmrgphjaIyXU7cYL6lcnKmoCqY0kQM0jEEF43MGhsWmFHkWqgW583zOo6/w0G2FDsf1tW+qWKxJ9yo0jIk7VOWmk0kYF8hVMJbTSmMMaSOl31sXGqZAEm8Q3UadcchUTs9ZLFn3dbgKGsZADmfQORfO1pkXUgFtmrgJiuLtTdOGJA1jVBB/OgPL0NlY531dFxqmVEmmsw2df5ZtLL0O3wMNGbpofN6cm48U1gT6MyvNm0JDBhbE1jk/XtKz2EYzlEHDMrDVqIqOF3S1/qz6X9CwCt2+NrawChpagoaWoKElaGgJGlqChpagoSVoaAkaWoKGdpC1f6ofJ5P3ERrhAAAAAElFTkSuQmCC",
            } },
{137,
            new Items.Pokemon()
            {
                Name = "Porygon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIgSURBVFhHzZTPUtpQFMZ5JUhgane6rN0kuKn0CWpdKN1o30J9A0c31Y0OXdCBTa2b/nkKBh5CwjHfZY7e4JekkFYPM78Z+N1k8vGde1MTEdNQaQkqLUGlJai0BJWWoNISVFqCSktQaQkqLUHlMrRaLanX647FtX8BlX+DBru7OhXpnTnCoJEu8euB3rPoi6CyDDxo9OGdzK4fw5WFxD0H3++kEYTpz6freVBZBB7kt6YMO5sy2H4j4zR4sNAS7nm1dyUHN8kLBUySdGn+mey+pwHRXvdyIo1GkFkrg8o8/CamvfOH5pLpVMIwlH6/L+OPnUxA3LP3ZSSHP2ZLtweozEOb+Hwrjm+dt26kszTgcDiUwWAgQfDYEK5fP/opGyd/ZP9ivHR7gEpGs9nMhMO41ro9Ge10ZLKz7diKY3d40CBOaxRFsnH0ywUE9f8Z0G9Pw60f/5ao3ZY4DQYQTg8KAuN7O56HXCUcoDIP3YMIF8XzYH5DAI0imAZFq1Ve5FQWgZB4GPYW2ju8mbpG/YA6bvyBVYMpVJaBkNhfCKd7EmhAhMOahl51vIDKIvRkoj2MF6cTDeI1gpBxeysT/PWnr25LPMseBBoQzSCkjlvb0rH7rVZpkcoy8MrxN77uS+C/itAeTvqzjrgIBEebOu4qzSlUVsHfAlXDASqroiNf9KtApSWotASVlqDSElRagkpLUGkJKi1BpSWotASVdpDaPYAEQCPlrWHKAAAAAElFTkSuQmCC",
            } },
{138,
            new Items.Pokemon()
            {
                Name = "Omanyte",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAG7SURBVFhHzZZNToNQFEa7JVrLAtSJ1ZgATTeiE+vUbqKtm6g/Qyf+bMDoCjQuQI0DaK/ch5e84Fcoj4TeJid5HEp7eA8IHSJSDZSagFITUGoCSk1AqQkoNQGlJqDUBJSagFITUDbB933yPC+nuL8uULrQ7/dN0OfblH4+5nR7GdHNPKRet1kolHXhWVtMAxPEfL9nkRLK2zu9bvpVfHwZUNaB42TW7Cg7tEkklHVAgYKEyZiXu3h8FVBuSnFpi8trh/K+VgPlbt1keS9Odul6lp1I3Ugoq+A7dt2yCrK8k9M9EyeRrQTKdTccHlIYDuir5BqUsFYDmdHomJIkSYeUhh7R1d+1GEWDPHprgTyDcRybMI7hUHvMHzvaNY6BsgoUuD+5o2S5/BctkS43CANlGRx3dh9TOH9Ng1apIhMXzF7MdjGQxxzpEsdAuQ6JO38iCqP0z6fPJnT8uMociGbndXus4G9WAWUZ/IgJggMaPyR5qIwlMsc6CddIKKuQNxcGzSjHBNZ4q28zvOwSyzNrRzYJE6B0xZ7Z4j5XoNQElJqAUhNQagJKTUCpCSg1AaUmoNQElJqAUg/U+QUbiV/KkSS9/AAAAABJRU5ErkJggg==",
            } },
{139,
            new Items.Pokemon()
            {
                Name = "Omastar",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAINSURBVFhHzZQ7UgJBFEVZ2wBTJURipGXEZzOAiZ9IM4tIWYGyAoVVIGwANUHbueDDR3tlZuga6wWnbK5AH273m5JzzjQ0tAQNLUFDS9DQEjS0BA0tQUNL0NASNAwljmMXRVGy5P/PAw1DgeDD3aErl8MlaRiCtNdsHieSjWBJGu6DiC2m5+59frmi0zkJPmoa5qFarW4aW0wvVlJobjRsuLfZWrZSKSdv5Z9Pg4ZZgZw0BjEI6vVoeBQsScMs4Ej94/QFsQ6VpGEWRBAyrdZaSK9FXEv+m6BuT9rSrflA8KYfucf7/I8eGqYBQTznMAjt9no4IAJJf0Agh9eFC8pjBEBOBHRzei1iWg5/CxHEtHaflq4+mLtm+/TXUUKM3T3Jr3vbgvJD/X0YNGTE8Vqy9S2oG5I2fbne89L1J271GZHElajdTl1UriRfy/fS0JAhLcqGkMRUYlhkSrV0f/zzXtxLiKHNPHKAhgwIHiRf3h1/rjZ+nV1tBPURS3Y2+dgIilgtuSKgEEHgS/poaQjKnYXgPu0BGu4CkrjgctyQkunFEcvRArSnmxPZrAMCaJiGNKk3FWQwWHuFHzHQcmDxst1gfbDdmIhhnefxItBwF1oQTcimQIsLWjLv/QM0TEPu4V+5FtU/wn9/FmgYiojuK6WhoSVoaAkaWoKGlqChJWhoCRpagoaWoKEdXOkL8w1HO7vrJR8AAAAASUVORK5CYII=",
            } },
{140,
            new Items.Pokemon()
            {
                Name = "Kabuto",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFvSURBVFhHzZRNToNQFEa7nQ4BYS47eNCJPyMd6kTdgXWoq2jopLoBa1dC7CbUdHjNBW+l5JNSMOQbnORxXkJO7iWMRIQaKJmAkgkomYCSCSiZgJIJKJmAkgkomYCSCSiZgJIJKA8liiLxPG9L/b4PULbFwhb3Tt7fbmW9uisIAv/fQqFsg8blrzfbqDovD4n4fv+JQrmPKAqLOI2oTq6O3lto/R1tgXIfYRgWa02TRPLl34GPV7E8T12vSCibqMbNTpJtpEboOalFP13HRWjXVUPZhAY654q4r4tE5qe/Yeqyn+fFtFyv0TUSyiY08CM/lvm52wm04M3lbnQ1dNDAVTaW7KxctU0PBRqDBSoWeRSUvxFduUXaipezsaRp6ZXBvkFDI6tnDbDYzzyWzTqWycQVoV3jFCi7YpPVOJtunzgFyq5UJ1m/6wqUTEDJBJRMQMkElExAyQSUTEDJBJRMQMkElExAyQSUTEDJg4y+Ac3XRoaSTRiLAAAAAElFTkSuQmCC",
            } },
{141,
            new Items.Pokemon()
            {
                Name = "Kabutops",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHaSURBVFhHzZVLUsJQEEXZEgTYg+gkCRM/I5whbsLPRMLEciX8Bvw2QelmCNW+TlXHV+HmQRIKe3BKOUo4dD9IjYhUA6UmoNQElJqAUhNQagJKTUCpCSg1AWVR2u021et18yv+exWgLALHjV9uyWsoDJS42dudvsBWq5XGSSCv+dyrhvIYdlwYBBQYJq+HsdnnlHkDUB5DAjnODstiT7XsUYDShR23nfQOooS8yWavdwwoXUjg97RHP7PHBDuMyZvsxQK34784OxJNrUocA6ULFDgadKhhztlut6PR8w1NM4Fl4xgoXWRXzAH7fUzdbpfiOKb5+0MaJhMt+sm1gTIPjuMpcYysMnrqHExMwob9jvnp03I5Ic/zzCXwdV1AiZC4zWZuJrY3itLQLHIGOZTj+P+bzSY/BV7bBZQIDlwsxumL8dr4cRiGSUQUfdFqNaX1embi7pM4Xrm8oYsE8gTtF2L30b8yU/NpOPxMIoUgCNPAsutloMyDg7KPfd/EmbPGn2J7qrzqiwfayMqjwXUSJ86+rcmay66XgfJUJAh5uR3+a6ALiazyJc1AWRWOk7vKqsJ3IAPlOZD1oyNQBCg1AaUmoNQElJqAUhNQagJKTUCpCSg1AaUeqPYLs4Ufbt8aa5kAAAAASUVORK5CYII=",
            } },
{142,
            new Items.Pokemon()
            {
                Name = "Aerodactyl",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJPSURBVFhHzZZNThsxGIa5UpwmUqVu2htkpiu6gx2sGjhB1VUmXIDQFSoHoLDJzymq9jJJ5Pp1+oJx3skMkKrf4tEorz3jx59/4MB7bxoZWkKGlpChJWRoCRlaQoaWkKElZGgJGe6bfr8fHrqtCRnuE8hdjkbeORd+6j67kOE+MS1IuavxOPISSRnuCwgOBgN/WVW+LArf6XRCrPvWIcM29Hq98NBtKej3T5cYA2Dm6ezrBlV9mb9UUoaAg6k9lA5IGS7nbDbz3W43ZoRtuXgbZJhu7rPDSeAqMqk2khhoOp36xWLxIM7fSg5tZVlK+SZkCPBhiIw+3/rx2X0Ekq7zKJOTVhnvp9/hhHlY2lZThimpqHPdnXIYvPgrgH6sFquIPvP5/OEdtDeJylBB0XwgLB2uEQpiGXMBvDM+36wCmc+eiubjERnWgcOBwdL9tFwu/beLiyiYSrIPBM4/Yf+uQ7vfwrk34dN6PCBDBeU4awgU10O/Wq+2BFFRVBhi2LfV8G5LEGJNywtkmJPLUSaVwt7jUgOcfoily0rJpqqlyDCH9x6qku85iFGO1WNbNfwRDxYqBXjQ8u/vQoYKSlICz+virf8eKIvHv7d4fj09jbhsCfGNNsuaIsM6UknI/Tp6HwXXq81BwR345eQkyk2CKO/E1yDDXbAKP4Pc7+MPEUiyWpwElvm/CAJI4Hq5+fjuSfXYhgnw36zXSsqwCUrUVYpVxFZ47p7LkWEbKFknwPY8fy4ytIQMLSFDS8jQEjK0hAwtIUNLyNASMrSDP/gDIpnuZ3DY9zsAAAAASUVORK5CYII=",
            } },
{143,
            new Items.Pokemon()
            {
                Name = "Snorlax",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJgSURBVFhHzZZLbtpQFIazJUAwD2IDNgipzQ6SdNA8NtC0kzwmSUeUbKJVO0iUUdpMonQlabuAmp7e3+iYw+X3A+NId/DJ+LeBz+ece2FLRIKGhiFBw5CgYUjQMCRoGBI0DAkahgQNm6Tb7Uqr1XIv+fUyaNgUkNvePXWC7dqSNNyUXq+XCkGuv3eeAkn/uqI5g4abgC//fPpKZr++i/x5SBl9mEr8fiqt9rySURRJf/dMopNPaeZ/hoWGVbGV0PO/z/cyGg0leV4IWlRWeTFByETvJktfBFFU7+v566yCkI3jWL6cLaqqkn7rGTQsA8Ovcsls5iRGKxX7drGzJIrzoRPFfRCsIgdoWIYKqhwqlNdSiNl5BIM3qwsnDxqWkbU3nrfPl9O2WvQelXtRwfF4TMUyuZPFbGa4h8HKVbnIvb9siwE0LEJXqi8Gft59lOEwR9BIVpUDNCxiE0GtXtX2AhoqkLFPivPHm0v59/sHFQSZJGbPiFq5RgS1UliFnfbiZwmCkCiSBLhnsL8sZdlYEFuJ/cnC8OuQP95epQJMVPMiOdCIoK0WjmgdJK2gkrXVYVdrHo3MoJVUCVZF5EmSyPXxQGbuiM27SLKqHKCh4gv6bYNkKuf2Q1zXSuNoR8KnMUFgJTud9tJ/PIA9LW/DZoLryAEa+kBStxt9raIqeH00kOlh3y2q+6zidiTqyAEaVkFF8edzctBP5ZSn23nFVRBi+oDrQsN1gOjk7faKIOQgVVdMoeG6WEkr599XBxrWQVveRNUsNAwJGoYEDUOChiFBw5CgYUjQMCRoGA6y9R/D0/3pVpwhrwAAAABJRU5ErkJggg==",
            } },
{144,
            new Items.Pokemon()
            {
                Name = "Articuno",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH2SURBVFhHzZU9TgJRFEbZ0iAQLUE3wGCDsZJVCB2lS/CnAipkJYqNS9FoAfHJN8mHj5tvGBghucUJ5vh4c7xvZqyEEFwjpSek9ISUnpDSE1J6QkpPSOkJKT0hpSekPDaNRiMkSZJhf2eR8pggrnn7Es56s9Dsz0NSPVlpvRZISfiXWl8W7Hd6M905DkgJsFn3/iNcPX6vNqodJLRer2fTaw3essgkqa60XkukBNgMgWnncvX5uQ6164rAPrzf9o0DUgIGIgwwlNMsmihvj/hIGbfr8QIpQXzE2Lj78LWOJXkT5b0WRxE4fP57giCOtGCiaZrKSeJ7fFIZhVCAyRVNP0ZKEgcyCMfM41bHDnivMSbGXqMIKWMYaaMQ0E472c9qumViFFJaEIkLYjKIavVf14GYKidrQ8s89RYpFXiq2+32Rty2SR5qilIq4sBtcdbx/rT77YqUeeRNkXEWTJHHXzZUyjwYyNfLYrEI109/MdtiQZljl1KBuLvhMDyPx+F8MA/vvYvws1yuAzkh9d6MJ8m1dv88pFQgcDoahdlkkgXG/1niC2Jd3sud7DNFKRW4MI60Vtt8KauLYS28DeUkeYuo71qkzAMXtm4bDFWxpChSymMQx8bYdRYpPSGlJ6T0hJSekNITUnpCSk9I6QkpPSGlH0LlF26T6Uij6NE1AAAAAElFTkSuQmCC",
            } },
{145,
            new Items.Pokemon()
            {
                Name = "Zapdos",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAMoSURBVFhHzZXbbtpAEIbzOEBvONlAniCgSMUHQO1dyatUitJEynPkpD5DQ6K+RkNOt82JVgrSdP7dDizWEOK2qvbik+0fJ/68M7NeIyKvUUOfUEOfUEOfUEOfUEOfUEOfUEOfUEOfUEOfUEMQBAFVq2Wq16p8uZjJ9f9ADcH6+jp9OWjT+UmbgnqFKhXL6KhNtao9z/6NC16mUv77l1FDwZVMkoiiKKI4jmk4fGeOmqQR4/zhqsirbwUbTZvJPXlQQxc88PSwQ2kiYhHLJrS19Z7LPS+/3AuxwaBLj3xshGUrO57L5kUNQaMRmP5LWCgCzupBDuDcXRkIjo42aHJToh+3xRlnx7Yt5L48qGGr1TKlPTvumPL20og+/F49Vy5Nuyw/LzUEv1+w1E1hQXDQ71IQVP+oJ9UQQBIPFNFez0pCTOQeLkvmiGusNsqIlUZ5XcGHywI9XpcIvZh9zirU0AWiYRgaUQyKyOGBKF0/jc31+UnHCGO18Bt68QlHlmu2QvM/sv/7NaihBkRRyiSxAlI6iKHnIIRWuBuXjBikMUzZQcqLGi4DJXLLh3NzzT0H2V4vNqAvsdLoVQxWrVYzokI5Ry+qoUZ2ACC2v71pBkekpaxYPRkmd6jkPM+eqIYaKDEGACWcXBdp72ObptNnXrGESw4xlNxuSZARoflK2m0q5RbBROPrlH2GhhouoxkGvC926fSgQ2FQoenzT/r6edP04DkPzBl/Bvs87VJiIFLDoZW8H7+ZVQEb+SpRNdSA3NVukW73ihRHb7mcGBTePrisENzf3uDcrnB/EJletFKxuQc9KteYdqy6bD/1FyTVMIvIXX4q0PVuiXCNbefpxpZ6dNg2whgi9Ood9yp+wycPojLZMkiYfHyhcK+Qfaaghi6Q+bZjxVqN+X6GnoRIylsLMnefw294AUhPuJQQm/UvX0t55f6XUEMBb3axU1wQc2k1m0s3YNng8RKQwldGVhdlRfYaSTUU5CHZPA+y0tJnrviq/gNq+K/RXhQZVjTkFnLzLGroE2roE2roE2roE2roE2roE2roE2roE2roE2roE2roD7T2C4NotrV6QwkeAAAAAElFTkSuQmCC",
            } },
{146,
            new Items.Pokemon()
            {
                Name = "Moltres",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALgSURBVFhHzZZbUhpREIbdEmRgzvgmmlRJ+QKYPUQ0WUUwr7mtAJBUqgJkC0Z0DYm3RcTiooHp9H9mWsap5lqp1Hn4auCfoc8/f58+ukFETqOKLqGKLqGKLqGKLqGKLqGKLqGKLqGKLqGKLqGKLqGKSXK5HF/0e/8DVRRg7k/DkJfN8NepJp/XBTUymWnNeaiiIAaHhwF5XBBF04aXQV5KjK1SQxWBNXe1RcM3gTXYKQQU1gPqx2bTzwMtGXlJGEI9OonqzaqRRhVBEAR0/6tA4S0XbUVFB8x3NjqoPl1AjN1V2UhKlw6EzYDoJjK4SgdUUZAU6bZAwyNe4GTTLiYJwNSzbNaa0BbG72FaDCZ/m3xuHqooSIowKNiWc4JYCG1Hmvgui0qakqiYWsccUMUkWBAmx9dTk31Os7Md0CTeU3022HlurClJvFYr2f0qpsR0uv4iVDGNMYby+bxdfHBkbHJg0ojosjlrNn4BobMTUHYNU0lUcRZI8yuM1bl1nCLS6SLJn1sUYgAWmEu2P6nPQxXngUV+vzJ2omGwf8Bp7hgKr2JzN/E1cZyIKZnofzYkGr7vUZvTgTEs1t42dN4o0oT36HGtTA+XnCSbxD0wer35uB1gGnu3zd+R7jJJquIskN6I2wkD3RcBfePF3tX2qdfcpbP6Ll+L9HK/TKPLKMXwCx8/fBWzMIqBsmfikuehKs7C50GplEvWQMiJ1d6WaDwe00Vrj8/DDHmeR6cfDqhSKZNMv213Kzo/RzxgYnbZNquiBsz1Plbp4vOhNdDjtuY83lcP93Te3LOG8BzOTky8fH48ntikbT0PFxJEq5dpsyqmEXNnnE7vU2TwR71oWwp8f/Z/ODALk0D+bGJfSpKL0lTFJEjm9H1kzPi+TecJcXLzkGflwAfG5KwmE57+jaCKSaRlIH1vVdappYouoYouoYouoYouoYouoYouoYouoYouoYouoYouoYruQBt/AcIL8rj0sEZMAAAAAElFTkSuQmCC",
            } },
{147,
            new Items.Pokemon()
            {
                Name = "Dratini",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJASURBVFhHzZVbTttAFIbZki+5LSOYvqC+lAJ9h3YDiBfiQBeAWATQPjghYV3Gl9P5ZzSp1f5x7SZCx9InMd9Yyc+ZcyYHIqIaKjVBpSao1ASVmqBSE1RqgkpNUKkJKjVBpSao/BeDwUCCIDB/8v19QmUbCLdYLCSKIrPk7+wTKtsYDoeyXC47BdxHpanchq8eSJLEfnkYxTQE3i2KQuI4/muvD1RuYzweS5ZlNlxZlnJ2u5b0Ry3zn2KD+vd8uPV6vXMrUNkGvvxktpDP85UNd2vCIaAPiWoiHJ5dqweobGM0GsnsqTCBXOXyt0I+fnuQ9Lmy68PkyPboarXayyBRuQ2E80d7fvcqMxMqit0gIDTCYb/5vFsP+r5qPl++v8rx5YMEYWgqWG6qd339Va6uLiQ03jz087pCJWMymUie51LXtVm6pywrObvDoOB43ZEjJAYJxzudTt/3msEUIySO0YfDsHiC0PUcqj09TGxV3fAM/zsolW0gpJ3km0xO5y+mH0241AUMo4F5BZf5aBMOfXpqera53wcqu4CQuLAxrejF3yFjuXnM7bGnz7UN9wnXUro0vPQOSWUX0JPotaqqzNINDEJiaJKjD3J8cW8rjDsT04+fSFQdQbHGZ3SByq6gis3BOTc9iSP3ZKbCzTD4pxDUr7tAZVd8FTE0CImfNhw5jh7XTZ9KbYPKPviQCORxR9p/IBhU9gUhcdyeP/d3gUpNUKkJKjVBpSao1ASVmqBSE1RqgkpNUKkJKvUgB78ACE1mfGgiLrkAAAAASUVORK5CYII=",
            } },
{148,
            new Items.Pokemon()
            {
                Name = "Dragonair",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKuSURBVFhHzZbLbtNAFIb7So5ju1kWVrkUKUkNEjwFCyRaxII04SF4g4rQfa57IPR5SGPnMP9Y47jmd2qnajSRPsX5x5fPZ87YORERq6GhTdDQJmhoEzS0CRraBA1tgoY2QUOboGFVPM8Tx3HUJh9/CjSsCgSn06m4rqt+Fu+Tz8pAw6qUEQT1el198bEiaFiG7LQawcViQSUxvtlskEtVSRruw4hdft9IrZZcDNlg8F7m85kWxHi2J48miAv9Xd/L+ehOnNrDSmXFP/0QDW4AmZFbLpfpDeCYMtCwCEi0Br/kxduxeP6pipK80WhoCQi0h3/karxNJXv9C4miCPvKaPRB4jiqVEUaMiDX7XY12GbjkPx8u6se9jVykI/j+Hmm2Fy8Q6bW4AWBtK+T6kVx0mtZQfN5NsHm4LeeWsepqej/8XzvfTvrSnuwkm6vryVN/+WPfQwaMiCBi7l1Pr2XN+tUEEC4NbzTx+RXdRVoyIDEx5v7tEL5cSwUSF6NI73PRfhaWterwpYoCw0ZEGh++akuHmsBtx5IzX0o6vmB7rteryez2UyvaAgepYIAkuv1Wi8W0FSLwnE9LQpwA2H4RvfcbL6Qfr+vq4ipBkY2f9590HAfkJxMJrpCndFqJ6sWkZHD46QzTBZIVjArmj9vETR8jEbjVNCTRhSEYZg+Ulj1mmpFNw+QpGFZUE3f9/W0mdcZPqhotx/qKW+pNoDQ2bvbdPtoggZUE7253W7VT5FXX5P+hCSenS8zclg4aAc/2L0q90HDqpi+xBRDEg/l85ESyVQMYqjsZDKTQL118ucogoaHkF088/lc/zeEpFlEEMNYFTlAw0MxPZldPIYg8NVY9b/9NHwqEEVfGiCd36csNLQJGtoEDW2ChjZBQ5ugoU3Q0CZoaBM0tAc5+Qe5+yf9bq1tZgAAAABJRU5ErkJggg==",
            } },
{149,
            new Items.Pokemon()
            {
                Name = "Dragonite",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALkSURBVFhHzZbNbhJRGIZ7SzDDzHAJNm4G0LS2C6X2ItRV+bmBpu6N0b38JqV0o8a9adK9SaNrUoRQ0M/znfGjh+FlOlRMzuJJyzt/D++Zcw5bRGQ1MLQJGNoEDG0ChjYBQ5uAoU3A0CZgaBMwjJPL5dQffIzh45lMRv2Lj/8LMDThh19f9ch1HPURH29Vd6lYKCxJbkIchiZJgnzsw9EOdWpPNE72VsYPvMQvlhYYxjElzUY4D8OQto+r1FKC0iITl7tvmzBE8AMuPr2gyy+vyHGykUSzTOPOAZWKBSooueHVGY1/nGvicnKu66wnCcNVSGMi1/07tNwcy5VKxXmD8ev4/O2TGg3bB2s1CcMkzDakPZEbtspLDZnnPzypziXTNglDBD+Ivzk3yCIiyHCTP9t4CEVQ5ML+Oxp2nm9OUMSalWgpMeV+/5qR67oLjZqSvufRgOVeR2IPjisU9t5S4UxJttNJwlBguV6vqd6zvSU5EWH56XRK4+7hQp5zszRoPNXNsVzh/D15fqDPZ/hLbUSQm5tPBDC0nM9mswVBwc9ltWh4+oYyauab987n8wufVwFDE5E0Bc13Lg0syq3F750GGMaR91CGxny4tCjyelbHmmZGemLctuh5yfu7AMMkRJZnMy/OskB363vzVpHkdDqhx49KStLRorx/m1vjKmCYBhbVS46xe4xVSyIkkjzTu/V93XKrGi3sTLOyQ77vqVvh+wswvAvzvbz4/FJvf8JIyck7Klsgw42Zcv9tiBkWbBzt6kb0+6daHH3vqxb7C0NtttmoRGIsmGZoBRimgZcJHmL5Lfj1Y/RDolPHM5wlPbVwrzubYZgWluSHCoNvp3pPHjTKNFL7rchdN59R4PvqEnyfJGB4X0xhLdk5VKJl9dlVh/E1dwHDTcCyk8mE2rV9urmZUBAEKsbnJgHDTcGSPKGY+LG0wNAmYGgTMLQJGNoEDG0ChjYBQ5uAoU3A0B5o6w9aoP3Xs0tAWAAAAABJRU5ErkJggg==",
            } },
{150,
            new Items.Pokemon()
            {
                Name = "Mewtwo",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKLSURBVFhHzZXPUtNQFMZ5paZJxzxGm3QBS/AFADf+eQGb4h4QZpyCrKXgC6C4QHTt+GfhiM44Ko9wyXfkdG7Ld9MmKcxd/Kbtl6b313PuuVkwxngNDX2Chj5BQ5+goU/Q0Cdo6BM09AkazkIURabRaORv+fV5QcNpQO7k8Mw0m83843heJF3lT9FwGlhoqzcw6yuPTdAIZFHw4/Mf8+vb5Q1xvedwdWCO1/dNMwhuXHdBwyKw0OryQ3Px5a/IgAf3n4w+nx5/oJVVuTsR1EpB5nl/f0x2ntUDNHRhyzGmVa+sHKChiziOx1r58+s/eZ+mqdnKBubt0blTsIocoGERWBBS715/FEEIoao7Gy9FMEmSsUm9U0Es1ul0RE4rN1zLKzc8H7UX05105idJQxetVsu8Gb4XOYCKQcyuGmQgGVgyyHqLPTmSNJsVGhYRtSIRg6jsvVwGkrr/2u227MdJQeTZYlZakoYuILe2/EjarNXEMQNBZDpAk4Mi915Xsb/ULyVJQwZaiAMaqEAYhma7vycDgmq6JO0K3pogKgY57DdIhbnA6RFa+7+9GJxutyuSukchiT9my92aINABgIQ+tk5enYmYSqkgjqDdZwcy0VXlAA1d4KDefPrCpEkqi0EwsSoGIIs2724cyCsqXqW1Cg2LQBUxGJDMljKpGFqsgqgcsu+ffssrvoN7wORvzQINXWARiEEQYH9hb6okpnk725NMqCGm0NAFWgwBBRLIVRLTzI6YOtCwiFF1ruUUiKGCkIzCelWzoWFZ0GocPThqtNX2k6QONCyLthhTqwMS34vzS/z7ZaBhFezWT7a/DjT0CRr6BA19goY+QUOfoKFP0NAnaOgTNPQHs3AFuNkXFT0vnroAAAAASUVORK5CYII=",
            } },
{151,
            new Items.Pokemon()
            {
                Name = "Mew",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH7SURBVFhHzZdNUsJAEIW9UohwD4JLVuglVLyA6Ab1Ilq68GflzyUouUiQlherU0PXS8hAsHrxFeElU/nomemEAxFxDQ09QUNP0NATNPQEDT1BQ0/QcBt6vZ4kSbKGvWYbaBgL5O5Hp/I9uZH51W3B4/G5pElndZqPaQoNmxBWbHY5LcXalAM0rKPb7VKpUKyt6QU0ZGjFdCrTzp+IxY7bFRpaINfv9+VhdNZ6hTZBwxArZ8/vGxqG6A4N5XS69fs+oWGICg6yrFxnqOhsMi3XoV63D2kaWlQSuxSikMPxz8uHyNuXHKZpcR7fcWzH7wINGVohkD+/F2IWtBpU1Y7dBRrWgT6IHrh8/SzFnk7Ga9XUH9LGlNOwClQR1UOlVLCQWyxkeCGy+pD59Z0cZYNi14eNe1tZGlahglo5FVSJPM8LwbCJa2PX6Y8VpWEdTHI4XpbVs2swXLtYGqhujCQN68AN7RoMn8X2McjGxmwkGm5CbxROm/bGcH3qeTa2qSQNm6BTp8dhVSFWNZX/JqjoDSG0WLUa23KqrmXyDBrGoH2RCaokZECsHKBhLKgM1mBmHoM61bYn2vF10DAWCLIXCoiFu9qOawINtwGSoYSuN7aTY6BhG2hVd33DoWFb6B8sm8dAQ0/Q0BM09AQNPUFDT9DQEzT0BA39IAe/POULMXjqVigAAAAASUVORK5CYII=",
            } },
{152,
            new Items.Pokemon()
            {
                Name = "Chikorita",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH0SURBVFhHzZXLTQJRFIYtQUsw2sAgEHBpbGBGQjJoBT4WojZgZAO6MVqBkQ1qAbiEYWMNdmC0AB7H+0MujOMfYBgjh+QLk49HPs69c1kREdVQqQkqNUGlJqjUBJWaoFITVGqCSk1QqQkqk5DNZsVxnDHR1+NC5SLYML/lS6lTGuNsJQulMi6Ii4aFyd/lxUktFkllHBCXu82JH/wMtFFJl5rKeclkMuK6rvhtX7w9TzxvRNKoMFTOAybX6J7Kcd1EmbhGryzXHU9SZs9F35sEKmeBuGrLladBWZ7l7BepdMq8jX82LlROA3Hdblde5ELe5dUEnQ+jMMmjRzPJfnn5gR/+pbz0JhPD0gYbazIw4Sf1wp9GUjkNBLbWV+XZ7D8b2JeefB1UZNDry02nMFz6pQbi5sDU7B4MNtfk00wVgVh6uO37yTET/Y44UDkLG4l9VwsmoWHwA3B319rJ7mwqp4GzDwcz9lk0yoLpVQN3HPnvB3WxWByeewixofYaUVH+PRBLfPjgjuNYVJilBDabb7J/tWv22GgpLTgLsS9xjeXFI51O44l+1yyonAdEYjIA07RRpcrOMBo3hn09+tk4UBkXxOLfBYf0XxwtYahcBDvRqE8KlZqgUhNUaoJKTVCpCSo1QaUmqNQElZqgUhNU6kFWvgHxgkYfoNt5nQAAAABJRU5ErkJggg==",
            } },
{153,
            new Items.Pokemon()
            {
                Name = "Bayleef",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJASURBVFhHzZVLTttQFIbZUp4iEhtIZjiZhGFRJ7ZYQF8baJUNBFZR2mk2QJoJggltVkBhyCDUp/5jjnW5/e0kNjUn0qcov69zP51zH3siYhoaWoKGlqChJWhoCRpagoaWoKElaFiWTqcjjUYjw39eBhruQrfbzYSml305ux5kNFvVRWm4DSrmSzGqiNKwCG1jnpjKsOd45v/fJmiYB6qmE0dnAwmGhxIEQZL9K+CPbTT/cwV1QhX78r4n829jWXw/kuEwWItqG125quuQhnlg4nDal9OrgQxHh3IzDyW+Oxa5T4Fs66mKGFtFTKFhEViDqA4EH2/fZGK/fqSy7RLrrAga5gG5i69jmXzoyZ/fqZzEj3Ldbku8WslycfLikjTMA21bPVVNgcxl0koIyv3bLPPfLQsN81BBtDS+S0UfTkJ5iCKJb59Lv8T6AzQswq0iRF1ZZfKxJ9Fpnx4teN/PiqDhJnSHAr/lYLkIZZQcPTrGfe/mIsx2+jbQcBfcioLRKD0Tge5ybTk2GHZ7bYJaSQhCDEL4DqeD7KxUSYDW43CvRRByOLQxIW4SSOGGUUlUcH4+frY+0fpd5AANt0XPRQjiPvYr5gI53VS1r0GVzJPT1r6a4Od3+5mA21L9jW/cPj+Tu3u5iOrdJKvkBpnNZsmkrXUlXUFUrpmchXrcYCyuw9orqAJAJVkrdaybbYKGZdGK4jP5dLCuHvIq0LAKbkX9Z2WgoSVoaAkaWoKGlqChJWhoCRpagoaWoKEdZO8vHKolHp3FZHcAAAAASUVORK5CYII=",
            } },
{154,
            new Items.Pokemon()
            {
                Name = "Meganium",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALOSURBVFhHzZVNVtNQFMerG/C4E/u5AGWgHAeSl00IdCK6gBbYQG0HfjDyY6YDsR3UphOQTcBhBR47EGGQpNf3f/WmyfMCBdPycs7vkPybNj/ue/emQEROI4YuIYYuIYYuIYYuIYYuIYYXUavVqFgs6lP587wRw/OAXLinTw8KVCnf09H8hcVQguUgxkKScN6IoURa0L6+8QpeJMf3zAsxtLGrhXNfPTHn86weEEMbFqy3H1L0/RYNP92h9qBJX0+3aL2zTMWSA0u82npE3ZMGxQe3qRM0jFz3bEq5UtK3Tu7Ns6piaIOHfvnVzMi1gy1aay/T7u9NI4jrUrlEYRjqrxBVKhX8EX/vKohhGpaDBAR7pw2zrFhqGodU7zxOJJXvUfTukOjDMVE8zkVSDNNA8DDsJ1VC9eJxTL7vUxRF1BluZ5Y7kfwraDcSX8+6DcQwDQseU5BIDD7fJaW7GIK9s+0kB6juj43X5HsqEcXBslgN3g74/csQwzTVapVa/SYdxYOMCMvw8v6TP1iln8/e0Pj9kZFExXdPsvvVfpaEGNrwPuQlxkOwlPxAG67iaONtRpCbCr+T2xIzkLT3j1JKlMwIRpP9yvfhs5eDzXwrKAHhUO8xX00fnhbEEqsVT8/PiVC6kXhmzoIYXoaR0/Nu9GLHNEPr21QAchhBo+evzPJK/8BCBcf7ejYuPaV1XSmzx3Tl4r2poNQguTeJDQvi6C3VTbdiv4Hu/bXk2hZkubkLAkji/eypFTPvRhs7mabAjOQD19gGCxXEfMToMW8OyHycvN5w4PWH5Ya853mJnFLT84UIYoCjOVgSlULXpoc3y2A09ft9CoJgMYIAy8wDHNWxuzUtyPen5+gsiOEsoIJolOFwmKkSV9WWuy5iOCtSRZCx5I0LSkDQrqx9z1UQw//lOnvtPMTQJcTQJcTQJcTQJcTQJcTQJcTQHajwB/P1KjBBaXWYAAAAAElFTkSuQmCC",
            } },
{155,
            new Items.Pokemon()
            {
                Name = "Cyndaquil",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGWSURBVFhHzZI7TsNAFEWznXQ4SJZYhg0NUFJmCbQpswKUlu3QgNhCGiRKGsTgO/ELz6M78SdEucXRjE/w+OgNsxCCNFQqQaUSVCpBpRJUKkGlElQqQaUSVCpBpRJU/idlWYaiKJotf+6DyqmwmI/bebgsLqJLn4dA5RAQ4oHzAXDYf97xZzunDyr7wMce1psOxWIRqqraR9zUf3vPmDhA5SHSuHr5GIn7+jpG/Tw1MffN+rZbzxaIsK/tKrJ9WbaRdfh+7QbaiqnifZCem4PKHLk4H4nA8D7vcMwUqcyRC4RHmE0xbLqBkcYh9GRX7OOAj7N9nGD7P9mJbOPsitOzD0ElwwdakAdxz+ur+LtFxtAk8mRXbIGIwR7gWhEFEOjZhzZ/gyis9h5Iz89BZQ5/OFaE4MM2RQu2SATaO/beWKgcin3Y4uyqsbfIqWEGlWNAAKZmkT7u7IHtx2OIXa2/4mPjAJVjQITHpohQicCUNkpnggybZuqnQKUSVCpBpRJUKkGlElQqQaUSVCpBpRJUKkGlDmH2Cy1/H9suUeghAAAAAElFTkSuQmCC",
            } },
{156,
            new Items.Pokemon()
            {
                Name = "Quilava",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH8SURBVFhHzZRBMgNBFIYtXcMOK5NIDmEnZROs2OECytaOpRVxBEdwi8gVbCh2Nkrrv80/ebr+YSIT9abqq9f9T8/0l9dTWQohuEaGnpChJ2ToCRl6QoaekKEnZOgJGXpChp6QYVv0+/1Y9L2myLANIPc0XAvdYiNOp1lRFNW8CTKcB3YtF1TCTZBhHfj1m536DlgJ1JfdtXC7shw6G9P5wgWxCY8J1R4ZBSH1PFxNay3IR6Uwn/kNGdZhBe2Y93u9XtWpj3Gse7Fef1XKUbxpJ2WooBDAMaOG0XdBdhBS4SEyKSVLWT4/yzHLUEHB1/3pRhCwghhvH52G9/F62Dn5qpTEen6PXN8EGVqwKUlSsWus2HwwGFT3weHlKAyOz8LBxU2q7zdREs8sqoMUqwTRkbJCDhKQwn2OSRKMXaQcxLAu3+MnZGihGIEYgSBE8PFznANJdjl/dxNkmGMlKznTrSSYdY8gL4pOfI1+92/IMCcXrJOxpM5FJveHiW53wR3EZhDMRXDlGda+PZ4nKHh3tfWnY5ZhDl7Mja1I6mi8IMCO1cmhLkwQUJJgDkHK5FAIMPtXQSuT/m4iVsTK5PNZkGEd2IQStkO5XP7cPMjwJyhFEVQrzHVtIcNZscJtI0NPyNATMvSEDD0hQ0/I0BMy9IQMPSFDT8jQD2HpE9687t2kB6dIAAAAAElFTkSuQmCC",
            } },
{157,
            new Items.Pokemon()
            {
                Name = "Typhlosion",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKJSURBVFhHzZW/UhNRFMYp1beQsRAqdkPyDjo2JGlAqzA2yguoHWLjn8bRJn+ewNEHcPAVbAi8AKANDoWABcrxfrsc9uz1C7N3Bb3Fb5L7Jdn95Zx77k6JSNTQMCZoGBM0jAkaxgQNY4KGMUHDv6HVarkX/lkdaFgXyO0tzkgjmXPLIkuS5GwdCg1D0ar5gkw4FBqGYCXwur80I6PrVySdK9b/RbDZbGatA30n9G3xZiZz0ndSd3MxlR2eCtdpNQ0Zto24Ue95X5ZfDs9oP3wiP8ezIsNCUOVUvk4laegDKQglaVoSw9qXhSQET8aFKKo6n9ZrMw19ILjw4JH0XgxKchBrtzsuN4IDV8XNXA5iqGhdOUBDH62gSlgptNaKg6zVW7ncaDpvs3/NqtDQxxf0Odhdkx9f1+T+q1wUVbSDUnf/ARpaJsmhxRsfe3L05Wkmp0Byb2m2NM0YFv+6VaGhxQpqOwfT1+TX8bF8eHtHDnfLgvv3XPVOpTC9Xbd38bskSd3l+D3Og4YWnHe2gqgcDuDP4w1XvWclOSt5tLMqoxtX5XB7Vborlyjot3i8vixbn3K6nbYbmLYc7JSryKgrSUOLClqxRiN/gmAPvn9zWzqdhT8k8T1/f843LkEQQBJCiub6uPvu2mlFrJD/WagkDUOA/CRBACH9E/rev8Z50LAqqCBuzNpp0W2Bp1HoRNOwKhDEPtS9aSWZNAYFgiGSNAwBLX73+pZsrheiTBgg6648zuSqtpqGVdEKYpLTtJhsJqlrPQH8a02ChiHohPtrJqt/RL9bBRpeFHoM2fMypHqAhheNPYr++TlYFX8rVIWGMUHDmKBhTNAwJmgYEzSMCRrGBA3jQaZ+A4NuBYitap0hAAAAAElFTkSuQmCC",
            } },
{158,
            new Items.Pokemon()
            {
                Name = "Totodile",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAISSURBVFhHzZU7UgJREEXdDmUiKuRaJg4kM8MKIHMHIm7ET4S4AD+JliuYcVZhGVkaiBg40r5+2PigLtY8oLSDUzUcfpfb/ZgVIlINlJqAUhNQagJKTUCpCSg1AaUmoNQElJqAUhNQFqVarVK5XDaXP9fyeFlAWQQOtJ+8UtDLqLy+Mb4ODk7M43XzEvw+X6AsAgfc7SY2UDt9s+HyzyEdZu8UxY2ltQllEaTBAxOIuV3doc+P3DxFVD88pX4rps3/CCi75oaTxl6bIQ3zfKktQjmLSqVCF08fdP1CVDvPqH0/mAh4U9qiTtK3Lugsp0UoZyFj5UDtdBRkGt5FDi6HZ/ozfIFyFnIw3OaiKKLcjLXRaFDQPrIHRsLyXm6sjRrk98rn+ADlb8gOhmFIt6VtGpi9e29FdGeuZbxuk+5+8rh9dxLKInBQ/lIOJwdDWg266bhlcfxjaqZ937FDWQTZRzcEj7v/sEf1zvHEqK+ehxTzCpjgfxaQccedXjZp8GjCnad2vGEc28B8mGyrZj/nucNA6QOHTC6alF23qN4z4Zw7C1+H0ShoMEd7DJQ+8H+jveV9B3JHKy44u5/7LwfKonB7HI7HGZiGJIwcEA7IK+B7cl2g9EH2UOB95H2T8S4SjoFyEaRV295f30mK4rY6/ZwvUGoCSk1AqQkoNQGlJqDUBJSagFITUGoCSk1AqQda+QIBp0YM2ey8jgAAAABJRU5ErkJggg==",
            } },
{159,
            new Items.Pokemon()
            {
                Name = "Croconaw",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKBSURBVFhHzZU7UttQGIXZDpMmfvbJpEFxo8cKIFUeC8A4G2FCRWABTGjCZAXGXkUgTWZS4NgFxn90ZA6+UY5iyXJxi28kHT3uN/+9/9WOmXmNDH1Chj4hQ5+QoU/I0Cdk6BMy3IRut5se9L06yLAqkLvbD63daKSX+plNkWFZWDUvBV0pHGcHkX3bfWmt5w1rbFFUhmXodDqZGKSmjiDOt1lJGZaBFYSYC6uYf35TZFgGCkLo9enQ+qOpHY1nFpyNrdFspY/o96oiwzJA8OvuCxsMJ5mYCyW3sRZl+D8ghoH3nKqBZqtth8O7p+urZ6+2sh5lWAQa4+LnvV3+sgxX5uF+bu32SjIYnKRVbKav6W+VRYZFuIKUQ+WwFhfzuSVJYv3r1ZTjXt1plmEREOTURvFKZr5YWO98bMMvb2zxMLePj4LbmGYZFpHtfd/f2uzHu4ze+XXWEBCb3i7z8eWBDUaTLA+OPtWeZhkWgQYJw9AmjmQeCPbOluL5LQfv87wsMlTg45heDBrGsUVR9I9okkQWnK7k2OVci9iWqm7iMswDOXQnByYUJYGQI1izVxv8ZWSYh3sfgCgrsnd4nK6/v6eU4m43UxiS/E5+jCJkWARFeT682M/WHBtkMF42x+TmfTbdkGS348gqV/kVynAdXI+oyu/bD09yqBau2cmQClIhLgWcV/1Py3AdFESl2CCuIM85vdhugs+jynJAhuvgho2BJzerLgasHgUB117+O2WQYRlYRW7GXI9xvJxKdnHdf7IMy8CGcZuG19jMg/5xJh9G8cbVAzKsi9tE2JLy96sgw7rkq1sHGfqEDH1Chj4hQ5+QoU/I0Cdk6BMy9Afb+QNPDCsumrEgQgAAAABJRU5ErkJggg==",
            } },
{160,
            new Items.Pokemon()
            {
                Name = "Feraligatr",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAL1SURBVFhHzZVNdhJBFIWznRwn8jvX4yTIBOgVgE7UDQRwI1E3AZIBHFcAh0liVqBxAWAYQPKs2/Rtq4vX3Yghpwbf6eZ2d9VXr344ERGvUUOfUEOfUEOfUEOfUEOfUEOfUMM8qtWquejPHhs1zAJyi3ZbyoWC+Xl8WTXMgoLfTl9K6XkhIZvG/wxCDbOg4KrTkaDZlGWKIKX4ft4g0lBDDXRUMJ2MT1/IXSSIKuLe7dyW4vtHF6xUKvHUUgySrCTk3XdZYbzzJBXk1NqCkKgNr6Q2upFCqZSosv0eBO1B7IsapmFLunKk0QqkaVUOsOrYVG6beahhGhBsNBph57YcpGxR+/fk2aunFTwbXG0FuhfSnf2WprnfbDYSBEnJWu+z1L5+jyUPkQNqqEE5dg45dn6/3grOhm2pj64Tko1mK5zyQ9YfUEMXyJ1PF1Lrf4nlevOVFEvlcE3Wh9eyvP0gq1/vZT7qbCVRQQ7EfAdRWxJt2tc01NCFgpAirNLm/kHml2/l7vbdjiDlONXA3umYdl7dPokaEpxnaOzs/CKsQHe2DNcc1hrE6pc3Mh29ieUAp5i7OVyXUTVDUXNFW5No43DzpC2BnQCgYhRj42gUndlTaYuBINCPHQwsrHpUTWQUbJlTARuuUCyarndddgLIjccDabWMkPkwHn0kCfHFj12xuFqOXKKNaKpZ3fCb6PnegkCTRAOcBlYYZ6IrFRLJpFXPHXiaHFBDQAmiPefaDDuM1pcth/Ox/nG785nZVSMHCWZBOTTOtelWkTI8xO3D3K5ilhxQwzxyBU2+/Jlcm6FU9B7u02bGRQ33wZWM/0UiOWyeev/TdupteQPOQre9NNQwD5yP2ESv+3/XESV59FDOrty/ygE1zAPVww6eTIZSMh1CFldM2XRgKtlLyuEaHyvm99ErCCDJNYR7NyfaUYR/oXK5HH+ThRo+JhRer9eJ3czB5aGGx8CtrPs8DTX0CTX0CTX0CTX0CTX0CTX0CTX0Bzn5A6TXpP/UyPxRAAAAAElFTkSuQmCC",
            } },
{161,
            new Items.Pokemon()
            {
                Name = "Sentret",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHxSURBVFhHzZZNTsJQFEbZEjWwB50BTsBVAE74WQHgBtQdIKsA2YDCCjQuQA0jvfZ78TZN86Xto49wByfB02BO3s+lNRExDZWWoNISVFqCSktQaQkqLUGlD81mU+r1evyRP68KlWVB3Kh7KVEcmI0MFU5lWRBwGE5k0rtykeo1HM+rRlLpQ6PRkM/+SKapSOaOhUofsFrZGOaOhUpfENRqtZItDRUHqCwifQHw+eV+JvvHhWwXE+m027IZjOUiitzzqlCZB4JwAZ4GXYmiuls5xCkaWfVyKFTmgcBlv+tu7mu8cu04RuOwauvZyEWCEKtIZR66gpv5OAnBecPf6UA4HT9VVpPKIhCpIb/f7yKHD9neTZPgNOn47P8pA5VFYM5hm3++3lycwiLPEgjc7V0vk5C8laxyFqksg16W1bAnz//nEZHpQDzDTc9+1wcqy5KOBLvNUvbblaxub4KNGip9QCRCsN2Iu+503Og52xxkIBIDG2E6fkLMQEClL+mtxpkLtXqASl8QiOGdfS8MAZU+YCbq0A5xa7NQWQa9HLpyAOcvdCSVReiW4mVB32D0t1ffcrLfORYqi0AgtnX3ME8CNdJMIG6t/oLo+TN1STQSYacYLwqVZcENRtQpwhQqLUGlJai0BJWWoNISVFqCSjtI7Q/WeRgRYlUSaAAAAABJRU5ErkJggg==",
            } },
{162,
            new Items.Pokemon()
            {
                Name = "Furret",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAISSURBVFhHzZbJUcNAFEQJhgS8FpABR0u+GLgSAMsFuLFEwnIBErCLKAxEwBIENh+1oO1B1ZIloyr+4ZXRwyq1e/5MacXMXCOlJ6T0hJSekNITUnpCSk9I6QkpPSHlIjqdjjUajeRP/f86kbKIbrdr4+GRtVrN5FJ/p06kzAPhTgdrdr61bs2gQTZK6OtASkUYLop6CdEs0OVeL/XTl1uz93tr19iulAoERJDrg6iQZvMfGkS4j6Sdm8PYnkbH9vl2lzaF6zLhcP+yIyBlCMMhEMESYqMgKEMWhQvvf344qbTBpAxRD/icTqzdbs9azWtQ3UvKhpQyBDsUD+n3Y5v8PGx1N2lw9N0grvNaxL3YWFf7vXQ0qoYDUmbBg4abA4t70SxkGGz6+t1kGBDtcdeTx+RHVT0/pVRkl+tiZ+PX0ZJtEd/HnLK1i+2NtMm8Wc1DyjyyIbMgZPxzPrK9cHkRMjzgyyBlEYtCYlbPBvNlJVjeqvMHpMwD4XBYo6VwFkPY4jhojU1WXV4gZREIiSXkOYhQ3OH4vNyP0iVFMLbGkFWXF0hZBraJjYHGEIyfDMilXWb2iJRl4PnI3RuGC1tbdvaIlItAe1jifjyfRYQgdYUDUpaBs8h5ZDC+imGTIFjVl4MsUlYlfGHlEVTXO6GUf4HNZv2ySOkJKT0hpSek9ISUnpDSE1J6QkpPSOkJKf1gK1+E+Ci8OlmiKAAAAABJRU5ErkJggg==",
            } },
{163,
            new Items.Pokemon()
            {
                Name = "Hoothoot",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAG7SURBVFhHzZS9UsJAFEZ5JSDkPfLTaImd6FNoS6NWCG+gTyHayNBpg0Nlb6EzFijXvTEXdnY+mN2QgVucCZwkcLhLtkFEqoFSE1BqAkpNQKkJKDUBpSag1ASUmoBSE1CG0Ol0zAGfqwMoQ+DAZrNpXuLzuwJlCHEcF4GbInf9AVCGsCnQ9gcNZNwYF/f6EKD0RcKSJKHBaUqP10f0dHNMWZbWEsdA6QPHcdhXN6U8TWl8tY5Lrfft1oEmyIGf3YS+T9aBEifUEQnlNuxl5SNHcqBE8UQlWiL3FshbxkP5hbK8H+N3mg+nlGfZKk6wl75qJJTbkAkuZgPK84xmg0kRJ9OLyqkeLJDhSA40oysif8rYTUssT7X7OT5A6YMdKUikwFtPVkZWnSKUPqBA4fX+koZnKQ17/7TM9PY+QYYfGjeS4+xAjnPvCwHKEOTJfrm7qD2OgTIUjuRtx/7/VV1SFyhDKJZ5saDReZ/ebidmlacFo17fTLBlLsH3+QJlCKt90UTOR1PzpLbN3vhMy98lRVFkLsH3+QJlFSTUfb0rUGoCSk1AqQkoNQGlJqDUBJSagFITUGoCSj1Q4w+LMyfpZk7SbQAAAABJRU5ErkJggg==",
            } },
{164,
            new Items.Pokemon()
            {
                Name = "Noctowl",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJMSURBVFhHzZYxbhNBFIbTIk5iQcF6Y4sgGsgF2B03TqhCFSjhBMRpCL4A4hRO4gsg0QTlAkhUgTRIFBAobPSYf5YX1su/Xnud2K/4NON/du3Pb/xmvSYipqGhJWhoCRpagoaWoKElaGgJGlqChtNot9t+yMYoisL8OqFhGZD6fvZU1uNITgY7EvuxeM1VQ8MyVPDX+TM5PX7yn+B1VJeGZbRarQlB59Igomh1dSzeXwcalpEX7L+4IWn6SA4PunL8ektcmsqPv2tgJYL5Le50MiGMkCwKIr+KbabhNPKSKpISOUjHzSULahM45y6F8Fv8+SWb67ZDWLd+UUkalgHB0Wgk/dvrkibJhCQaBmIfDneCmLIywV73rhdKgtRBI5KjwUDc5i0vvSvD/ooEgUp+e38uHdeR8XgchH/7bP/xfbnwVVXB3taGNBdsFBpOA4LJg4Z8fXcmn96eekkXJIfDofS2700ILr1JFJyHH9+cBDn85va3N0K18nI4dlZyzCio5OBV1qlFILfXzaSXvsVgmhykQvM8bASi6I6/hb/PLNCwChWEzJE/73SEoFYPcnvo9AUlaVgFBF/6D59FEGuLbDMNZ6GsimWCdRuGhlVATrsYMkXB/PbqFqPidSpJwyogiIqoJOaJf/Tpo85tZmJB0jdMWPdnJ17PK0nDWcBZiA9WINt/flMuPu9e/tuGFKqHUStZfJ8qaDgvrKKYx83YL//7Mnr9PNCwDiqpIvpa1+tCQ0vQ0BI0tAQNLUFDS9DQEjS0BA0tQUM7yNofHe3wuwfy1DkAAAAASUVORK5CYII=",
            } },
{165,
            new Items.Pokemon()
            {
                Name = "Ledyba",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHzSURBVFhHzZTbTQJRFEVtxWgBDq/E6A+EBhimAh4/oAUIliA/PiowsQgTaAKkAuMXSAEMc7z7moGBbGeGh3pMVoILkOU593IkIqqhUhNUaoJKTVCpCSo1QaUmqNQElZqgUhNUaoLKbSgUCuI4jnnIn98XKtPC4g4dTGUaNkPC3w89TSrTEA2Ksvm6faEyDWHg/L4o8liSXOZ3QqlMAnHDWlGCh5KNCwMRO66XpHd+LBnn7CChVMaRz+elUqmI7/siT+VlIBiMhtIfj+WtUbaRrnndvpFUxoFAfOh8Pl8LRNwiCCSXy8nrcCh3FycyMlPGRLN7RFIZB9a7GWdZ+DYujO9dntoJuq5rjsPukVTGEZ4/z61Ip+VIt+3IqP49qQBrNz/jZtk+j2MwMCvHNHEm8f5toTIJRE4mNzKbdS2315m1UMTVWu8mMLCBVc/beYpUJoFAXJTJpLOMBJ7n2pVisv6DmXL1e8UAq9/lwlCZBAJxERpXH+bDvWXUdGOqiGy2V5PMZrPm7fxv/gSVaUAkJhJOsv9Sks/paqIIxMqjZ/FPA0Oi646L3GW9gMptwPci1o2LgIjX56KNRGzVnMHoZfmXCYJw3dHHUfC9+K+BSUT/gW2hUhNUaoJKTVCpCSo1QaUmqNQElZqgUhNUaoJKPcjRF07WPFGENam+AAAAAElFTkSuQmCC",
            } },
{166,
            new Items.Pokemon()
            {
                Name = "Ledian",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJJSURBVFhHzZW9btNQGIZ7O0UdsN1Erdi4A/9cQdnY+BtiZ4K7AHVCsKAw0SWRcwOU3kClTqAOOM2AOjnqx3mPfYIpb5raTdE3PIr9HCl+8h3b2RIR1VCpCSo1QaUmqNQElZqgUhNUaoJKTVC5jn6/bz742qah8iYQ53meOeTrvV7PfPC1LlC5Clx8XdxN612gkuEmtypg3XpXqGSwrW1G3UccoJLRDHRbWQ6eya7v6wgELhJhkr2wuEC4z/6++BuOpHIVCAzDUKIokkX63MbhHMcueNORVDIQV5alJEnyV+De61/i+bvLqZ5FTySoA5v3qPuetlDJwMW+Ft/lavhyOS1ZLMySyE5yKA8930YiMDE/AFGn4YE9b0a3hUoGHgxMq8xeLQNPZj9keHQlD+Iq0AUh8DQ6kPz9Y8k/VIw6bj2VDExwO3wrZVpPz7ATvZO9N5eyHR3KzyKTs+TfuOGXhWRHIscX53IyP5cgCMzX8WswqFyFvQ/re20+S83FfBuNuPxjNaW4fogmJhBxLsxxr4EAkUUxkPk8syAsjqso+/DU9yUepmNzzzbj/ksgcE+ne+VgWthOhCJwOp2a41g+efvyrRHZNg5QeRsQOR6PbUhRpHaSF2bbk6Sa5GQykVHwyG75XV41VN4WN8nBU09mZtsRGfieDc/z3MZ3DXNQ2RaEYrtTExpFfyYGh22+yz8LlW3BOxLvwFEjBk5NIHDb3Ty/Ht0FKjfF9eguUKkJKjVBpSao1ASVmqBSE1RqgkpNUKkJKvUgW78BpYQYnCLNINsAAAAASUVORK5CYII=",
            } },
{167,
            new Items.Pokemon()
            {
                Name = "Spinarak",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH0SURBVFhHzZS/TsJQGMV5BEd9hCYOlBbeAZz6ZwGdZAN9EWBCXYw+hhMJi8gi8SlIfAAxDkA+OW0u0OZQKTh8wy/c/pr0npz7XQoiohoqNUGlJqjUBJWaoFITVGqCSk1QqQkqNUGlJqjUBJWaoPJYKpWK2LYdkX6XFyr3pVwuJ0KYYPVWRxrtXoRtl44KSuVfbDc0n8/Fdd1EsLvZhdz/1CIat7FD0PR39oHKLNDae+dUnFJxHXA4HEoQBNKfxaEYCHpISCp3gebQEjZCsDAMZTAYyHK5lPD5XPwnS/rf1UQo02hz7Int5D9qKneBgKY9z/PEf7TED1a/vr9uLwi99Xo7IPwhs0hlFgiJcNis/7Vpy4Cm/CAOjHVz7EfPk+6pXLbzHzOVu0C4adWSz5olD7NkuJIbXxqERlto9XoUh8O63uoedFmo3IUJ6NjFRHsIZ2YSIb2to1+MLLm66URrtIjxSH83CyqzQEgTAhfCDH80k6sQ5t3izZKPXhwIF2vSPVvf/PQ3s6ByH8yfNIJNV0eOVk04exVk/ho3hyOFx7Pr5GsPULkvCGlm8sU6Eae4aQjvzF+Sec7bHqAyD2bj9OYYhUNb24bK/8DMatrnhUpNUKkJKjVBpSao1ASVmqBSE1RqgkpNUKkJKjVBpSao1IMUfgHgQRv/h4rDLgAAAABJRU5ErkJggg==",
            } },
{168,
            new Items.Pokemon()
            {
                Name = "Ariados",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJ7SURBVFhHzZbNbtNAFIX7OpG6wImTfQIv4J8nALpxywIQL0DpplVfBiR2ySaITaO+TP8WNr3c4+Ra0+HEsUsqjaVPyRy7ns/3jic9EJGgoWFI0DAkaBgSNAwJGoYEDUOChiFBw5Cg4XOYTCb6wc/9DzTsC+RurgYSj17pkF/zXGjYl+AFx+OxfC1KWV0cymjYLolroyiq8c8xaNgXVBCC345FhlGsEb8GUqj0w3X3atOwL65gmuZNhVxw/m512EsO0LALVhEbo3WoTp4lUn0qRD6rrZKnqZwWVS3fVuFt0HAXrKUmiApBMlUxcLsayNlJe/vboGEbkLM31m1h+bGoq2Viq4uB3KucK4zKxsNuL4dBwzastRBy22gC7hjVgxxajLV5O0vlZzSTkbM0dkHDbZjczTSRR2edPejEebKR0u8Yu5mtQZNEjvv492fQ0Mf2rrIsdbg+8jyvK2YyJuQKAlQsS9ZVxFts7cYS2LVnAhq6oGqu2GKxkPl8LlmW/SNjgn4163yzHq8v12JX53sSBNbaRCuBid3Jj2a/5N3st46zJ4L+ukMVTfLozVLvN9Jb8/lcaOhiby2e/P3rpbb1pKnYmUr8qUQnfCoI6dPisWnpj40gHnLXL44PDQ2Tw5aC6lWV2nz50AhCCJO+nS4bQau0Vcu2GeQvIoib4jteFKzFOI7lezSVO32TIWTtNjn7O6wx7IPYpF0Z96Eta4OG28DN7bOpqB6QNjkD17BqvaigYdXEATlkPhBB67EW/Xbag3aBhl2wvdHPXez3uc9/Lz403Bd928mg4T7p004GDUOChiFBw5CgYUjQMCRoGBI0DAkahgQNw0EO/gK+wuXjzkvhuQAAAABJRU5ErkJggg==",
            } },
{169,
            new Items.Pokemon()
            {
                Name = "Crobat",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIGSURBVFhHzZVNTsJQFIVdgtswjlpDF4ArAJ049WeiK1DjBgR3oFMmKAvQ6AqME6Mj4yrUEXjl0BxyfZ4SIoiX5Bv09LXv6+G9dsnMQiPDSMgwEjKMhAwjIcNIyDASMoyEDKsoisKyLBuTnv8LZJhCse7po121n+1453ZEnq0NT+tr5oUMPZBLxRYlB2RIKOfFFikHZAhqtZodbl9bs7lhR9s3/yIHZAg5NLfR3PwmF0YQcGOgRSXH8zyeFjw83wLTXC9DD/9qL8i1mefTtemluOEI7jFJVIYpEPKSnMQLslE/WVGUYo1Gw7qt8pr19rnVHd320497eX4EVUAAE2FNXraexusTwr4ZTsSW8VAYT7H9+xc7eHgdka2V1/qHSpFhFZwUIoQCqgWOhxzE6mcXY0HI+bFVyFCh5Ei6gfx4yrE1SGZ5/m3sJGSowHqqEgS+Pb6mUrk/FeSkg8Gn9c6e7f191R42t+zjbWV4XK41vx69nF9rk9abQoYeviKwQfr9/jAqf5Ts9ZbteLfc4fzq1Fvno5Z+I5QiQ5K+AynZ6XSGTQ7sZO9udI6wwVmlPDIkFOQG8MIpaG+eYkSGHkilxxDxomyOD7OwBidBUS/jG2brsyLDWZi3pAxnAYL8JIYUBGwxrCCAZJr9BhlGQoaRkGEkZBgJGUZChpGQYSRkGAkZxsGWvgBcJwCjVh8R2AAAAABJRU5ErkJggg==",
            } },
{170,
            new Items.Pokemon()
            {
                Name = "Chinchou",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHhSURBVFhHzZRLTsJQFIYxbkYSB5aWrkNKV+BjIz4mKivxsQATRz42YGBC4go0DkAYkHDsf/FAqX+lbVTO4Avho4+Pc29bExHTUGkJKi1BpSWotASVlqDSElRagkpLUGkJKssQhqF4nkfJHlsFKovQbDZXRhQ5ZhVU/kSVm+KcrCsKlXngRq/3NfH9neQrPyaPqpFUMjTu/alaYBj+YSAeBMSNRlsyHtdzI9kDox6fVaZIZRbcYDCoy3Q6Sb5KErktQbAI1LCzy4FcXI+XaDSCeehaAvW3zs33OCVqx0sTLQOVDPz7yWQWGASB3N4+J8vsuzgsezrw42PbOXB42pcoimXvuC9ew8fp9Pp5UJkHInUSCGx/TSY9QY3DhOGxX+P2rgvcP3kpHUllETRW43Dz86uRC0Rcq9VKJhe52Dhuud//NRAgcu+oPws7iKVzOZxPEFHDYd1FAsThU1cge608qCxDOlL34Nvj5vyVhNDXh415aK8nDt8PktP5NdNQWRZdboTqUs4mFrs47EPE3d31HN3u9H8DlfRDhD2IuPTLfS1LnAdi8QAt3p31UmEKlb+B+UCASH25V4kDVP4mui+zvihUWoJKS1BpCSotQaUlqLQElZag0hJUWoJKS1BpB6l9Aph3QN2d9RJ4AAAAAElFTkSuQmCC",
            } },
{171,
            new Items.Pokemon()
            {
                Name = "Lanturn",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJjSURBVFhHzZZLTttQFIbZDhIDnIfVDkPZgFOvILCCSmyghUmgqwgwCbAAWrqJtJmgdlS1C0iMB0lz6uPoT26ufgebROhE+pTkP35892nviIhpaGgJGlqChpagoSVoaAkaWoKGlqChJWi4Cc1mU4IgyH7yelVo+BLCMMzF7nsteUp2pdHYz2J+bBVoWBWV63x8lKBWl9FoV2azSSbYyEr8+CrQsAwYSqXV6WfftSwuN8R6jJ8VQcN1QKDbH8nFbZrz7vhuIfgcer6eW6uV62EaFoGLq5TeQEV1aM9vnhaZf46Lf75fZ9CQofMMLXeHEDl6E3U2zGE4Fzw6/ZXPV7/OoKGPSkRRVHDTMJ+D3X6SC+pw47fbGLchWxXUC+vKTNM57vbhyzEgow0874/z/1sT9OVcSe0Zd2iLgFC7Ha8Ifrk8lHpt/WpXaAggqPsaPmm6lwuWkQOQOji6lc6nn9sT1FVXVjBJ9hY9/PlutQZBUFZOoaGLSk4mS0F9QjC5s5N9+Xo5f8z5kkzw4epg8x4EKomto0ju33TeiG/Xh7kkBF0xXRh6DX1eb1UQqKhe/OJmvCKYnnRl+LYts8m0UNBdtWgw/q+DhkVgTuLmmHc6JwdvIjn7EEgyXtZ1T8TCKLut+NCwCAhiMfg8XLfk+PRx0Wu97zO5Goq8j+PSPeZDw3X4knEcZXtcO+ulpRjQva83mOaSP/6kUq9XfwWj4XNgDgF9YfDlFB1efcsZ/B7J8O8rCvq4wpCFnFvH8VWg4Sa4sn7tJdDQEjS0BA0tQUNL0NASNLQEDS1BQ0vQ0BI0tIPs/Adk8zC1jyr54gAAAABJRU5ErkJggg==",
            } },
{172,
            new Items.Pokemon()
            {
                Name = "Pichu",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAG1SURBVFhHzZVPTsJAFIe50tS2e7uDXQunwLgwxoUxboxcguhKPAnYkxA9RKHPecUnbfNzWtpKnsmXlE/+fLyZDiMiUg2UmoBSE1BqAkpNQKkJKDUBpSag1ASUmoDSRRiGZIyxl/j/QwOliyAIKI7js0VC6UICkyQ5SySULjhwvbykfD+n2ez/I6F0wYFZNreXVwW+jwNlr/b9AlC6KAcu7gx53iFCQiRsqG0AZRMc+XRjaL87TjJ9jejCxsry8+PptP/NBGUT9WUWeKLl6CH2KJQuDnGZvby2VAPLyETtH3yftkDpggN5KmiC5TB+Tt/pMVA2kdtl/EonlOcSubN3s/8b/ded3QUom6jvQQ4qpnr/RvTwTr7nWY9feypQNsGBfIxslhF9foyPk3xcVeJkO8jjLkDZhEyQ71I+64TyvpO4susClG3ggO16TDN71nHcdjOh9CUqzkBZ8jr192gDlG2QZeYwvmE4bnFrbGz1cO67zFC2gT+YfzU46vkH+dmrP7cPULZFpsOhPMEhDuY6UJ5K32V0AaUmoNQElJqAUhNQagJKTUCpCSg1AaUmoNQElHqg0TftPUedSHE4pgAAAABJRU5ErkJggg==",
            } },
{173,
            new Items.Pokemon()
            {
                Name = "Cleffa",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGYSURBVFhHzZTdUcJQEEZpKcHkHa0gCRUwNAFoA4Qu/CnABx9kfPKnBCtALUJhzSYs3rl+kzAJA9/DGTKHkDmzuUtPRKiBkgkomYCSCSiZgJIJKJmAkgkomYCSCSiZgJIJKNsQx7EEQVBc4u/bAmUTFuPy/Xwt8nYrZ/2wuAX/rg1Q1qFxj5OBPM3OSy7TQD7yuWxeb8pAizzUNKGsww3UuDRN5Oelmt5VFu6uvxYL6YfdQ6GsQwMnSSDL6UCybZyGzbxJDrNMpoXT+/phdQz8Z+0DlE1oZJL8TQ6hgctpdQwMDfWf1QSUTURRVC3FZl3E3P2LowhczeflGbPtRbFuZJs4Bco6NO5+NJK193p1c3exW+wchh0WBco67PU+jMdlpG6rLcb7+EI2zhYfYpOhbMJesfvfZ1iYMUxTWeV5Geo/Zx+gbMICNcCNtKnq52cRdbJAxY10p5Vug9w4vT5JoJ4txQ817Pwd/Qz6oNi2E/OBsgsW6/u2QMkElExAyQSUTEDJBJRMQMkElExAyQSUTEDJBJQ8SO8XY7NjMSsliX0AAAAASUVORK5CYII=",
            } },
{174,
            new Items.Pokemon()
            {
                Name = "Igglybuff",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHHSURBVFhHzZVbTsJAFIbZjpcHe4E9iL6UdgXElYBswssK0BeMbABhE6hPRhbA7aHCcc6YIYP9DR3G6Hn4Avk6Tb6caacVIhINlJKAUhJQSgJKSUApCSglAaUkoJQElJKAUhJQ7ku1WqUgCDTfr+0LlK6YsOl4SsvXJa3vRxSHkbqE17sApQu1Wk2HZVlGs/FsK/A3JgmlCyZw1Lml9d2Qli+Lrdg4itUyfG8ZoHSBA5Mk2QTZ8CSzNFXL8L1lgLIs9vQWz/NCYP+iQ1EQqqX4/jJAWQYTxxFzEGfwfWGgLIMduOo+0ejyBk6R8XkOodwFHyt5nlM/zmiunj2OHLavfwz0mSKUuzDnXi9IdKAJ6UcZPQaNLcdx9B+Bb6cHtFBbbMet8g+K43gTbuL+NFBvb3dQePYm58fqjT3Rk+X4tVpj4nzeZih3YbaYQ3VAmOrYydkRTepfcRzOBzf/RuH+Rw2UZeHQQeuK3uuHhYlxMB/Svp87KF3gSP6SPDTb+k3miTFpwz+OgdIFM0XeRg5ies2W9xfEAKUrHGn/52fT5+thA6UvdrAvUEoCSklAKQkoJQGlJKCUBJSSgFISUEoCSklAKQeqfALk/JFChb/ZoQAAAABJRU5ErkJggg==",
            } },
{175,
            new Items.Pokemon()
            {
                Name = "Togepi",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALKSURBVFhHzZZNTxNRFIb5OyYuOu3MtJWVuDKu+g1VN1ZxLUHc4AZr3doCG0k0xo9f4Aczw4y/A1AS40pbysJolLbzes6d4oIc6dAackmetPMwMzw5t3fKFACtEaVOiFInRKkTotQJUeqEKHVClDohSp0QpU6IUidEOQ6ZjA3TTNFb+ffjIsrTYlkW2t8eo9NpwRpG/q9gUcaFIwwjgcWagReti1i6lcRCLYFUKoF2u4lut4WUmaRT5evjIMo48NR4Yku3TWy7s7g3n8L+Ph1TJMe+XpvBDnnLNCh4/EhRxiFaVprSwZqK6lDcAb3fC65i8aah4jj61foldDvNsScpyjhw4I4zq5ZxL7iuXjmwy1Okqd4dTlRF+1WaokGXyfc6CVHGIZvN4nlzRoUdHv6mkPXhBKNYnuxR8MetKszkGU+QUctMm8FOm2h/jabFsXv+NYpcVXG85Au0iey0RZfI9zkJUY4ibVu0ew0Ui0VsO3NqKcPllzjorMG2Tex6VXTaLXyipd1155Q7fo+4iPIkeGk5qljIo9/vo1wuo17fwNv5Bm2aFsWu0u5eRaVSUueVy0V1nmmOFynKUXBkLpej5TxEEAQIw5A0KKqClZUnKJVKKoqP+bXX651tIMOfP29zE/1BXwX2B8CAOhuPnmEwoIPhTxRaGvtbRZRx4Cl+vnwOHxxHRS6/CbH8LkSP2oYDVaGNxlNa6ugzmc2mWYv3+xeijAtPkSN9z8V0/Sd+9ULcfz+g4BAhLasf+HBdl56BKfC5x6+Pgyjjwn+0kM/BpSlOP/iOC/Uf8LYC+L6PL1fO00fAQaFQoF1s0+nyPUYhyrgc7ejFWlI95xwK9TxP0Xi4gXw+P1EcI8rTkMlk/i4fB9v0jLxzw1D/QGTSk8UxopyUKHTyOEaUOiFKnRClTohSJ0SpE6LUCVHqhCh1QpQ6IUqdEKU+YOoPBMh0dl+NtdkAAAAASUVORK5CYII=",
            } },
{176,
            new Items.Pokemon()
            {
                Name = "Togetic",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIsSURBVFhHzZZbbtpAGIWzj2ygUp/AXNsVVH3iIrKeBMh7H6ukXQNg4y6iC2gAG96ygFSqRDD9O2eQXYcewDGo/CN98vjjdnRmBrgQEdVQqQkqNUGlJqjUBJWaoFITVGqCSk1QmYVyuWwuf+eFQiG5PyVUHgKBVquVlEolGyyebz/vFFB5iDhgu92WKIqMkiRg3OapGqVyH3G4fv+LrNdrozYDYeM2MU7VKJX7qFQqSYj0SLeJcZaAaG8wGCTNLRYLGY/HL5rE8H1fHMfBlL7Pa6ByFwiID043xUa6vWP3JJW7iPdfPNDUvvbSz5/P57lapXIX9Xr9RcBqtZrcI+hsNkua2g73XwICfPByuTRTkd/Rpr3IXNFcq9X6JyBOu+d5ufcklYdAkzjNy8Yn8V1Per07E+RegiC0AYvFog2Hk+26bu5wgMqsoKVGoyHNZtMGCcPQLmWvd29cy17zHo4YKrOCJrHv0FQQBDYcwuJ+MpnYr6CzBgQIiRDThx8SzqZy1bmS5+eVdDodGxh785iQVL4WLPV351IeP7yRuWn09varXV5v/M1y9oBoEUv6+PGthNOpbc71fHnf/yW1m5/2QG2/JitU5qFeq0m3eyejkWsYybvuk92DjlM0D/PXZIHKvGxOddMuKebX159NwOP+NFCZFyw1QuEXBvcIiTbPvgfTIGR6PhwOdezBXaQD54FKTVCpCSo1QaUmqNQElZqgUhNUaoJKTVCpB7n4AzI6gYNjctJSAAAAAElFTkSuQmCC",
            } },
{177,
            new Items.Pokemon()
            {
                Name = "Natu",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI+SURBVFhHzZW9btNgFIZ7CUnVC6DZyhT/JzCVrQZEHLso7QaMTMDCLSAYIOUK2pQBwYAQF4CoKlX9EYiKhQmpwCXgNhUv53ySgURHxHascoZHSp786Mn5fJwZAKoRpSZEqQlRakKUmhClJkSpCVFqQpSaEKUmRKkJUU6L53mwLIseyq8XQZTTwHEfby7i061LcCqIFGVZsrg37WriGFGWIYtLulFlx8uIsih+4MFxbRNWZRwjyrzw1GzHQn9vBU8PVn/D7r8vCcdduF2nuN5IXMblzTosu0lvlT+fF1HmgQOfH93By+/3xEAmi5xmmqKcBMf1d1fw4tvdkcC1g9GjXr7eQbfbpeUpv9WinAQHPt7pYW2PQvZXzTHztJbWawg3a+jv90zc6VYDSRyZyLJTFOUkAtpajxbBcy08odCrz+YQxR3Yto3hcIgkSShuHj+3zpnAM51gELg4/Xwf2G6YAMdpIj35Ac93zfYen6QmcPhuHl8fnTf3xSiKziaw3W7j+G3DHB1z9HABrttEuFE3R5sRJdfw5cGCiftA0/Mp/DX9u9jN4pGi/Bcc6fu+gScTrs8iHPyJY5Y2arBosjw1vvbe31jEIf03t+jSGP++SYgyLxzLkVcGcyYqHNAkiYt0f4yiDl7R1AJaqOwHjX8+D6IsAm90mqZotVpmWnEcm2PlaZWN+htRFiE7cn6cxQZBYJ5XgSjLwrEcOe6nQZSaEKUmRKkJUWpClJoQpSZEqQlRakKUmhClJkSpB8z8Aj6RJG/t4nRwAAAAAElFTkSuQmCC",
            } },
{178,
            new Items.Pokemon()
            {
                Name = "Xatu",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKtSURBVFhHzZbPbhJRFIf7KB1s0qUMDAws9QnKAEn5p2kh7tWNCx+hNhG6qvICpWBi4hOoXSiYNFYTKbKs0WjcYgb685yhgwQOUGAil+QLmY97Z36595w7rAFQGlGqhChVQpQqIUqVEKVKiFIlRKkSolQJUc5DKBSCrusOo795gSivgxus+D6Fgw9ph0DQ+6CinAWHS1U0VC7uo/rt4SAgk65q0AN+GibPnRdRzoID8sodXzwYC8jwSo7OWRRRToPDPX23PRZqFK9CinIaHDBD25ujrSw1qP4a/UDxuAXLslCs92tyZQFNM4Ru8xFw4kN2T0OxsY2A4Xeaw7ZtJBIJpz69qkNRToJXz6Zw9hsfBdSQiMdQqqeR2fchGOp3MNcmr6ZX3SzKSUSjUdivNRhBP2KxGNXivyOG4XBuF7+M3ELQg5CinAavovsds7acmitd1aGV3BqsHP/uRUhRXgczHEa64oNF25ykuksmk2O1xyE/7u4uFVKUs3AenC/g4GpLuz2bNHD3xSbS1Di63g/pBvyczy8cUpSzMM0Ims0fuLO/iU/3Crjs9UgDNgXN1jagGzf50hm7bEhRToMfeH7+E+VymY6VLin6XPIKdpGtbjjHTqbmG2w1N9YpBXwVvf3/A7Zav9Bu/0bvZBPdt3R4P9GQPtaQJXTqdHdOJBIBz3Ov50GU0+AHNb98x/OhgExu74YTLFfT8IfCGqs4qBl3y54dHqJFddj+SiGJ+mODDvB1Wk0NmaN1hEyDhsv3mAdRzsI0TcTpvXu6s4MzKn4mQdepIx9tMb1VVv1vptPp4KxQQISChuk8ZPjNwu9hN7gRCNBw+R7zIMpp8Ba7oYb9cHA+xBdtilFEuQiTgi+LKFVClCohSpUQpUqIUiVEqRKiVAlRqoQoVUKU6oC1v3ehI5WPI/TCAAAAAElFTkSuQmCC",
            } },
{179,
            new Items.Pokemon()
            {
                Name = "Mareep",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKiSURBVFhHzZS7bhNBFIbNo/AGeO9LyRNkLwWGNwg0KKKwBQWQDlFgAgWPwKWHKAYFO5YiLj3YcYVEk0CBBAjHPsyZ9azHk7O2V7LRKT5l8+965tt/dqYCAKwhQ06QISfIkBNkyAky5AQZcoIMOUGGnCBDTpDhOnBdF6rVqsS8Nw8yXDUoNxwOAQY34dv1EOwSkmS4aqRg74YQ3AJ4cA0c6z8I6ku2aNnw2a+bAYzvb0Lr0nnR4AUR08+akOEicMJeuwbj788BfryEN48TsCet6OLqeT2PomjhC+mQ4TxwouFxJqYz6F4F267OiDu2dUZW/r4diHvLSZIhhWpAyWFrrZ0YRidT2TRNZuTfPkmF7At57bm2GAYqvu+UapEMTVCuXq+DZVlSAOWUWNG1iWr477sQ0mTNgjiZak9JYXtxHEtOJy1mslmDCD7zuhnD+CBczxLvNiNIkqkAiqbif5RqNBpw2t+C27cauSTeH508OyP5Zz+AIHDFsPRcOmRYhPzAxYGbpmneVnzvg/ibZIKdi0Kwnguql1CbJms6Bs/zxHD0HCZkWITaKM3dn7DT+p2TbH+SksdPz4lGN3I5UxB3eBAsL4eQYREoqMuNRmNwHAeiu++lIDbX60yPGZQbdK/MHDvmmIsgwyJQEGWae7+koGU7slEliHIoRIGb6uigJneyOe48yHAeYRhmQris4vtLtj8Wyh11Z7Mv7cvrXWKF+hajKIZXDyPZjJLoT0Rxd/c7UzmkbHsIGS4DSm7cOQTPD+Dzfk3KYEN7j2LwfU/uVJXjrl/2YDYhw2XApVbHhfw2RZsogdf6M5jhi7ien+dlIMOy6G2a91BSly4LGZZFb3PVkCEnyJATZMgJMuQEGXKCDDlBhpwgQ06QISfIkA9Q+Qdefj/Lj1/cSwAAAABJRU5ErkJggg==",
            } },
{180,
            new Items.Pokemon()
            {
                Name = "Flaaffy",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALkSURBVFhHzZXPchJBEMbzSrDLAo9g9AIs8gxqLiZePPgCVnmIBNREDyG7cDYQeQFfIJV/pYn6DBb+w2Vp+5swuK69CAjJTNWvZvjYnfno6W5WiMhoRNEkRNEkRNEkRNEkRNEkRNEkRNEkRNEkRHEaMpkMpVKpMfHvF4UoTkIbC4KAP16ON6enZFnWUsyKYhIwp425rkuDwUCto6PWbFI6ncZS3GNWRFECh8IcohUOh8pIGIZq3vJ9tdbDtm1M4j6zIopxcG3FYpH6/T51z87GhrRJjOhaXzkPcb9ZEMU4uFoYLBWKFPz8nXvalI6q1jonJ1drECCKuzfuUI2jF3DuDdkQLGlDMIi8xA9pHx1dvUFEsVAoqGuus6l606cuRw6URsbA+fpTsq6jSACimOHI/HjlEx0w3RZ92fHo04MaucWSMocZRhfVbkQxCRz6/aVPw46nDCL/oPWeN1RruVivXp9BRA6Hvru/SeH+HlHHp3LJVdf5njXkH9JAN+z9BeWhKMbJ5/PqKv1ba1RmIzB5sVFVQAP1VosfpfEstRr9LxTV/oUoSjiOQ1XPU9daqVTILZepzKCKD7iK9UBlo8Lbx8eEd3io9/W/0JNHxOkwfSMXxSRwIKoYJtGwMTDjL08ZYzpsrM6tKGP/Hb3HDwPy3rJBa0kGQeU2R48LASY1z9AL2RhACnzldBi0Pcplc/zK5Xv6epd2xQCH9Lb36AO3ExjR9LYb4zVaEGZ7lH+YUeEfN7bm6o+imASK5fOLXfJX76l2o9GfVW9ksIYhO22pGW3H42dyTpa3kfdOQhQn4WSz1Ly5pnoeKhtmWlzF33b+NIgKd0fGYDBaMLMgikkggq8PD5U5HAhgEsAIcg9GEbUSm2qs3iWH0wKpEd9rWkRxEjAZjYY2iuRH60F09XVGn5sXUZwHmEHv09GNfz8vojgvOppx/X8QRZMQRZMQRZMQRZMQRZMQRZMQRZMQRZMQRXOglV/la1YjlPmNaAAAAABJRU5ErkJggg==",
            } },
{181,
            new Items.Pokemon()
            {
                Name = "Ampharos",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJpSURBVFhHzZZdTsJAFIXdjokPAoWo8aXIBgqsQOMiJLgJf16MbASDmzBxBRhf/Hkw0Qco157CLeN42lpak5nkS8hHyxzu3Jl2S0SchkqXoNIlqHQJKl2CSpeg0iWozKLVakmtVos+8u+rhso0EC4IAhkMBlKv1yPFr6sSKtNoNpsyHfvyPGlLvxfElVTsa6uCyjS0gvP5XL6ud+TxxJfFy34U2JdG439CUpkGAj4c+/J5uS1fV9tJQHlfh6y6olSmgYCzlz15PPWjcO0kHOj3l705fz2Q8+FZZT1KJSMON5tFYQ6TUCZmQHyuqopUMhAQk6KCdjgs72jYll43kOldu9J+pJKhy5sEW8zE87zYISB2tvagfW8ZqGTYAb1VGPvYse8rC5UMPQMXb+ulBaOh/6elxf2b/AEq00AVcQ52u90fIBwqiM8shG4wnJ1efffX91lQmQYm0iXVZbWDsirivo+L5bnZKFhFKhksHJ4oGM/3ncQDtlm0+kWXmco0MAkmADdnvoSrgBgIiaMmfF32Jnv86Z/M6lUbKvPARPGhbQytYlxZ4wmD3R6N5L6iVaQyC63CIlxXT4cZ0t4wep+2gPo8qMxCJ5pM7iQMw0ithwbEUYTj52m1aRBUd3/RJw2VeSCk3YMYo/NO0oN6RiIkQmtliywvoDIPrWK8KYyQeQFBkeoBKrNAOH2rMd8Bx+NxtOwTuR0exSH1BUID6nX27+VBZR4IicnMCdWh19BnGm7TYAqVZYgrvHqpMI+YTaGyDNoC2NFF+41BZVl0uW2/CVS6BJUuQaVLUOkSVLoElS5BpUtQ6Q6y9Q1qYii9y6KjUAAAAABJRU5ErkJggg==",
            } },
{182,
            new Items.Pokemon()
            {
                Name = "Bellossom",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJlSURBVFhHzZa/bhpBEIf9KnTZpLnjAOVPlRLs5o57Auc1UgF+AZI0llyldFwlcmGJzsoLWOIJsGmwKcCmcTye2WNyl9NEt6wRmuKT4bdgPn6ze8ceAKhGDDUhhpoQQ02IoSbEUBNiqAkx1IQYakIMN6HVakEYhpby2jYQQxdY7MIYuOsdwrRjIAoDXJJf74sYVkFyk7aB8WkADzcGRm8MdOP4nxa31awYVkEfHqPQcmJgeoAN9g9hPvgEUT0TImh9VsjL/8MVMayCBGc41tFrAzfYJI03RaH+z3eQdHMxXqcv4CsphlWwIIslSWLlvty3oZvGMMF8hHvzARsenwWQorTvqMXQhWazacfIYl9XHcvgPGuxKDk/8h+1GLpCTQ4Xbfjz9AjfVgd/JQlqsjxqn1Muhq7wqD8k32G43LdiLMujpm1ATUaB3yVIDF0hwbBXg2FhxO/TXLbeyE91+b2uiOEmkGR5L97inkvx4LxEjBFDV7jB3q+39mDQaSbCfg3C+nbuKmLoAh8Qaoz2m5Ua1CBO8jZ5xOX3boIYVkFyC7x8pChGjXUuUeQokxsu81N8dRraW2Ej8m9TDKugayAJNkjqFiXnOFZ83L4MIF6PmhpdXL+C1dRYfCXFsAree1boriS4ft75nbXKkju7k/B4y+1d/Qggoj24zjgnwfGZ/14Uwypsg/iB8Sy2TR1//gj31wZO8O8+7sdiqyROgjv9sUCQJAmGUdaObRX3GYtbwfUaCfpKiqErJPm/xyzPz3c6YheKwi9BDDUhhpoQQ02IoSbEUBNiqAkx1IQYakIMNSGGeoC9Z9UV/gwZFWhnAAAAAElFTkSuQmCC",
            } },
{183,
            new Items.Pokemon()
            {
                Name = "Marill",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIZSURBVFhHzZQ5TsNAFIa5ChINokkIyR0INHZyApYKLkACDYQbcAMEVaBAggIpaQhpWE4AVEgcAJIUWR7zDM+eDL/JIiOepU+xv8l4fr9ZZohINVBqAkpNQKkJKDUBpSag1ASUmoBSE1BqAkpNQDmKXC5H6XTa3OL2JIHyN7LZLO3cvNP6yRulFzNGRW0SPMnwUMbB4d7XPGrOz9KuCbmYWTI6auPg5WaH8oePP8JPC5RxcIUk4Mr+HXl+IayYhGsszIXtSYSE8jc45LIZvNRoh9XioKXGRxCubT6gs+4HITOplOmC3zMuUMbB4brdLu2ZYBzOpbVRDML9S0AOt3b8Gkwb/5ZuvyrYGwxo1VRRKiohl5yNMu0GgtJFXi7rrLp9SGdbFSo3WsFGsafcLxR/hOD+0pexN9cooLSRyvHAvM5kkKejJu1+V9HFPoIkXPV5MPSfcUNC6SIVvL6+oH6/b1R0nb9QOCh/BH9MvhIdM271hEQDMnzOoYB8uSHzB/dhQO5nLwFmknMSyji4GryL0bV5+haE831/KCDD/TgkH0du2yigjIMH8jyPer2eeYyuev2KVioPwdTa02sjy+RPdjEjVZAAPN212mWAG84OIcHkXvy4QBmHO5hUhKvKUyvP0o5+JwXKSeCB7cq6bRJ4WqCclCSCxAGlJqDUBJSagFITUGoCSk1AqQkoNQGlJqDUBJSagFIPNPMJJ05HV99UXlMAAAAASUVORK5CYII=",
            } },
{184,
            new Items.Pokemon()
            {
                Name = "Azumarill",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI/SURBVFhHzZXNMgNBFIW90iSSvZ8XIJOFYhWxwVP4eQG8gbKaYkGxCMnShvIE7FR5AMEi4ZoTdWk3Z0aPSOlUfSVzenR/udO3Z0JEgoaGIUHDkKBhSNAwJGgYEjQMCRqGBA2zqFarEkVR+pWPA597ikBDBhZutB5luf0iUXkyjYbvqVQqg3umt24kKpXTaPieotAwC0hObVxJ4+KZSvr8iKLQMA9IPK4uyMp595uEyp3MxNI0Y6NAwzxU8Gg3kVKplEZfOQS760tD8qNAwzxckUmnGZAnO4k8rS3K7Ob1/+xBBc2AKlpB9uhHhYY/oYJaKRwr46geoOFPQFC7GR07X4ulO4bqARrmoWcdxCx/ef4pNMwC+6zX68lK50tq/uDhs5LKv+xB7V4s7law//oms9s3Y5OkIUMFsXiyvi2Ha1vpgfw0EJnbv/cWxDxF3tU0dNEJ7b673buUppGyWEn3R/pWmIYKJkR10KX9fn+w9/BI3T2YhyuhcsndmzTTsUFDeVSShgoTtBIQxseO4X9cAbd6kPPteBq6YGIspOeeFXKvdWHdj+wRYx5fOUBDRr1el+n0LaFC6FxXBt8xFsexNNIDG1mW5J82iYKJcQaqmBXFdadzJu32qdRqtU9J1gw47G2WBQ2zUEn7UTGlXP54P9s9qH/HVkHsH+wdlbRiANVTAStlpX2gYRZ2oVbrOFPO3q/XOuYLDX2xwkUPYR9o+FtU2OajQMOQoGFI0DAkaBgSNAwJGoYEDUOChuEgE+/eKS5soppTcQAAAABJRU5ErkJggg==",
            } },
{185,
            new Items.Pokemon()
            {
                Name = "Sudowoodo",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHsSURBVFhHzZRPTsJAGMW5DjtbhMSl7sAV1Q14A3GjxgsAXsC49Ab+uQSEC5HY5Wdf6Vcn4yvpZMB8JL+0vOlkfrwZ2hER09DQEjS0BA0tQUNL0NASNLQEDS1BQ0vQMJbBYFBc+FgoNIwBctv3ezlN0+IrfyYEGsYAwdV8Is/TC0mTRJIK/7m20LCJfYtBDGPzybksC7n1YiKb5VS+Px6i2qQhA4u/5iMZbf5K6rbmn49yfZWVcr00kfF4HNUeoCEDC0HOF6zuJf96KgUBGkOT2GI8EwMNm4BMMuvuqBbHNcuyWk7B9qJFnavoUfDzJmjIKOUqQXerIaJS+OwThNzLdiiXmNtrJ0lDH4ioFNpytzqfvdVSbpOuoLaW3HZluD7ZzT20oCuFxXGthRxJlcM45vb7/d/W7vR4nJRjbaAho2ygWtSVrMUgWYm6grgOV7sft7gp/jhFi0cR9MHCKlpLVnIA7eo43ov60j7KGWwCC8rmrJZi6A/B8ziL2ua/CaqIK4rGtEE2h+VN0DAElfSbDJHYBw1DKEUatvkQkjRsCwSwnSp0jBZp2BYIQMSV1HucQdzHStIwBAj4QExF8d2fEwINY4GUNmpSEGibfh4KDS1BQ0vQ0BI0tAQNLUFDS9DQEjS0BA0tQUM7SOcHKlr9V2Tp3UsAAAAASUVORK5CYII=",
            } },
{186,
            new Items.Pokemon()
            {
                Name = "Politoed",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJBSURBVFhHzZSxTttQFIZ5HdrJcRqltEuhLxBTFpSpHVGHEmWARyhloUwQ1i5VX6AKEyU8RekCZEFlQTCEcvB/rWNuL3+UGzuy7vApvv+58f10ju05EQkaGoYEDUOChiFBw5CgYUjQMCRoOC2NRkOiKDK4tbLQcBog9/77pXz4cWWIanEa871FoKEvKhd1vkkrWTYdNOsZStLQF7t7KpVLz0iShtOgz5+9DkoQqCRotVr5tbuvCDT0RcU+HTVl6yKSL8OMzqApq703aRfLS9LQB8iNRiPZHtZzMReI1uJykjT0Ia5H8vkskv7fjVSmZmTu7kfSHbx+0s0ykjScBMaKw/tXm7lI//CnxHFsuto+eCtb54+SlQpCrv4iTg9G117+J7HTnJd/RLBMF2k4DsglSSJD+Sqd44VcICMbM16O67U9uV3rSffXghl3pYJD2ZXfg2eysvLOdFDpnrySPyfPTf3m474RbO8vyfpxVq9EEEASB0IE3TwdzJtrBevV3qJB5ZLl7Nvo3ssHGk4Ch6kEJBXNtKsqh9rZ3Y7E9Vr6d37PcdDQB1fSlrJRudP0sWgX+HjT0BdIQsAdsy1ov0jn99N3kYY+6LMIQVvKltRxq2CRF4WGPuiItYMqp7+oQUr3YL97Dx9oOAkcBikc7ErauXYOoFZEkoY+2JL4xdoGgvZ4KxcEthCrqSTAdeWC44CIPeqicoCGs8CW1EfA3eMDDWcFpBS35gsNQ4KGIUHDkKBhSNAwJGgYEjQMCRqGg8w9AFWI/1pCBhtZAAAAAElFTkSuQmCC",
            } },
{187,
            new Items.Pokemon()
            {
                Name = "Hoppip",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH8SURBVFhHzZRLUsJQEEXZUiJQOFRH4IjPRJegu1BXEGAFlizCz8jSDfkbKNXmBls6z5uERC16cKrg5nfe7Ze0RMQ1NPQEDT1BQ0/Q0BM09AQNPUFDT9DQEzT0BA1Dut2uRFGUIzznv6BhCARP7nsyfe3L7G0gcduhYPLUl9PH3UwSgnWatBMIj1VBwxAVRHsqWdWkSulvvV4Xp+dVQcMQ20DYZHiuolI4xy5OiXY2k6RhEbaJg3kkJw+97EG2EV3MXpKKveTFmuxhGhaBhw+HQxmNRpI85yXtOWFj+7N0EfGqyTpygIZldDqdrCGIhpJ2C0AKDeK3LgDX6n02hYZloKH35Fom43EmqOPWhnSU48m66bqtWWhYRiZ4dCaT9OEQAPtf+02lwGU0kKuU2OzPJtCwCm1RZncixxc5WYgtk5vVsZR2vJNewu+zCTQs41tueSAyX4uEYAt8HJ1LO4rTy/i9NoGGZeTaKwByaNN+fppCwzJUcBEfrkepbZpxa3uQ/I0oDYuAHD4vH19ikMSLYPccJBXIQhS/m46ahkXgO6ZvcCapMtPbQsHfjpqGZaBFHduPvWjkFmh2Gy+JBbKXUX81ZjNKyGdbYduCwL409qOsTev/ptCwDnbk4bG/gIaeoKEnaOgJGnqChp6goSdo6AkaeoKGnqChH6T1CVboDw87c2r0AAAAAElFTkSuQmCC",
            } },
{188,
            new Items.Pokemon()
            {
                Name = "Skiploom",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH1SURBVFhHzZW9MgNhFIaVxpXQ2axkKJNUVJJozLiCKJPcAHewaPw0DBeAuAE/V+KnQiEoMMe+a052fd5lsxmc4mmeTTJPzvedZERETEOlJai0BJWWoNISVFqCSktQaQkqLUGlJai0BJWDUiqVxPO8L7ivywOVWdGww82yPF5NyPNNzMlOWfzC8KFUZgFxGnbfHZXudlnarT1ptfblaKvaD9ZQ9/1ZofInEPdwGQd0tytR3OvrW/hYpNM5iCLh9Qv4/iQe0c/7DirTKBaL0ZHVajXphYGI04B2ezeannJ7NCZP1+P910z9diCmFjzMyvrzXERj4SNSp3h3PBoFJe+gHnPeOEAlww2sboSTbNSkXq9HaCzARBca8/1nwywKlWloJOKCx/RYUAk8aZ5Py/LFjHj+Hy4JIl8WV2Sj9xGnIMRl7Sn+EoWpfJFUpuEeM8OdbpI8kVSmgcByeHTJgLel1U/TRCCONjk95VcDEdc8nY7uEyIr6+mTwoYHzhVQP+jCUJmG/g4CxCLSDdX7Vw+XpnkW30PEYXG8Af9VqMwCJqqhycVIgkjdasTm2WYqB0FD8e+CCWGi+MnRSQMN/pdAoPdTIxCVfK6hSZcVKvOgk3T9sFBpCSotQaUlqLQElZag0hJUWoJKS1BpCSotQaUlqLSDjLwDdmohQpldbqEAAAAASUVORK5CYII=",
            } },
{189,
            new Items.Pokemon()
            {
                Name = "Jumpluff",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIjSURBVFhHzZWxUhpRFIZ9jIxvwSL06hOwS+OMr2EhjI2x0wqlUp9AaVRsTBdjo0mTjI2jZdJoBQONmZP9lznr9fqjdyODp/iG2R92+fjvuZcZETENDS1BQ0vQ0BI0tAQNLUFDS9DQEjS0BA2LUq1WpVQq5fjvvwcahlKpVDKhXu9A7i6aMhgcynDYkbm5aGKiNAwBrd18Xc2lfCBcLkfpR/n9odAwBAiiOSanoEn/vqLQ8C1C5NDgJFqk4Vu4gu7s+Xyo4Lj5U+EPaRBi2J21Wk3iOJab80Yu6TY5KTlAQ4Yuq4rU60km2N1bkNtvjVzKvZ6aIM47tqSQ1CZdsXoST/ccZLtWG4MMJBdaJTnenZfFnXQEkpo0Pl9JFJXT2/kzQ6Ghj7+8Kgi51nFfmhs/UslRmwByyDZ3f2eSaNPFf/5r0NDH37UqB5Htk4HsdIeytfcnk1IxzZOk/mIzFZlNGjJUEl+AeUvSZXw8+ynt7kiEAbl+/+WBfrq/KOUorEkajgOSukw4au4/LUn7qJ8L/f1y/UzYbw/gBxZpkYYhQLZ11MtlwMPsci6MJY/HNDg1wdX1y2zWfjVXpH3yJKaziI2jDUJKX6ciCHA+QvJxsyNrG99zMReVVDHMb+j8ARoWQZscJ4djxz1igP+M16BhESCo/80+kzisaVgU3d3utbZqQpDhS/8vNLQEDS1BQ0vQ0BI0tAQNLUFDS9DQEjS0g8z8A2itbDuqTKNBAAAAAElFTkSuQmCC",
            } },
{190,
            new Items.Pokemon()
            {
                Name = "Aipom",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJmSURBVFhHzZU7UhtBFEXZkr6LMNHMKMGswjYrALMJ20TYJJQIoEhIJU3CZwPY2gS/QJ/nvt08VU/XRdJQouoFp6S5mp4+87pfa0tETENDS9DQEjS0BA0tQUNL0NASNLQEDS1BQ0vQkNHtdqXRaLiv4brT6VSuPwoapkBucHwt5Z87aTVbXgwgw3V6/yahYUosWBSFDI9vKp8fWUkaxkDux/5ARr9vZW/3UvI8iP36XvpMq5qO2ZQ0DWNU8NvnS/l5MFpIKSqqkul20Oe8FxrGqGDxWrlYLgVCkIM0aEaC760qDVPQsZPJRF5ezqQ8qVYwBlsAVX566svR4cgLakM9PJy68X1pt5vukXweBg1T9O0hWZ4EmX+jQubzqftZZFz2XHbjBR8f+15EBSEGKRU8Otx2eZDGs1dBwxQIZlkm0+nUVxETzecz95O4ydteHJJ7uxdecFwWTmS4EAzXn+TvMJNekbt7QtZqrZakYQoEtQIKBCGnlYUgpLSZdP9h7P0gk+fnMB5i4zL3bEwQYKKrq3OZzWZuomoVY7lmI+w7jAHs5Xq99c9OGr4FJsODVRRiqATk0OVsUlbBdSqn0PAtMBmOEfx75Hm+AGLLKqKS6y5rDA2XgcnQMNjoqAi6FQe1nntMFmO+7Jz75Y/zdaDhKnAuxsuGPaWHOA7rVAb347DXxqkDDZehy4Xj4n4YulH3YLzcKqnf486uAw1XAUkVwXJD7OvORaVquqwQS//26kDDOkBED+O0AeIXifM60LAuKpLmm4CGlqChJWhoCRpagoaWoKElaGgJGlqChpagoSVoaAfZ+g/MbzySZUoQeAAAAABJRU5ErkJggg==",
            } },
{191,
            new Items.Pokemon()
            {
                Name = "Sunkern",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHuSURBVFhHzZQ7UsJQFIZdgltIZ7o8gEFdgWUCjY8KVyDqJtAVOLARHSrATfiofDQ+Ch0tKI757/WiMv9MAsThFN8AXxLmm3Nv7oqIqIZKTVCpCSo1QaUmqNQElZqgUhNUaoJKTVCpCSqLUqvVJAxDw/S1sqCyCIjrPB3I6euh4b8iqczDxW301mW9a9m/TCWMbWSZk6UyDwQkSSInT20zPcQh0mt4EoTBZLK/o+eFyiK4KbUGiQlJG6l4qSf1s/pkqp3n9sKRVM5CtVo107w4C2WzW5fWKJvsi50stgAiozjKbuXP50FlUTDFtztfms1E0jQ1kY2G/d4appPpLbIXqSyKC+z3Avm4/wl9/45e2ksCEHeeTexm5MvHgy+fjzbU/UYgQitxkN3O/6MIVBYBgQfbXhaxZuKmcVNdSiDixuOxVCoVs8QIOt6zse7z9tKXeME4QGUeCMSbiz32OzDKzkA4N9kyIqnMA4GtrdU/y4uldFN14UsLBDj/8JL0u+Fkr2Gq7XZ27kXR8gMxxauBL0e7Xnb+BSY0juyZ544eXMOyTz87C1QWxb3J10O73xB0uGODy4gDVM4ClhpTc8vtwuCm750HKucB00RUWWEOKjVBpSao1ASVmqBSE1RqgkpNUKkJKjVBpSao1IOsfAEhyCw4vCvU7AAAAABJRU5ErkJggg==",
            } },
{192,
            new Items.Pokemon()
            {
                Name = "Sunflora",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKNSURBVFhHzZY/cxJBGMbzVdIFbXLHnwG70OnY3EGjSQWpEhuxEjonNOon0KRiTBG1cYxfQMIX0PETBK/xTwEH5es9C0uWm4cLwyGzxW+GfQ52fvu+u8ttiYjV0NAmaGgTNLQJGtoEDW2ChjZBQ5ugoU3QcBXy+bw4jqOIP0sDDW+jUCjMyWD8rbMto/6O/Djflqy7q/J1QMPbgNDgOiPjICO57O5MDmNQrXprqyYNkzDlUK32/o6cPM7M+B7JIguNBaQRpWESEHzxaCIyCi/ky3lLwvCDjMcfJegdRnLTZ0ZFIRmfZ1louAhzr7UPMuL7ngyH75WcBsIn+3dmFUS78ZtV9yUNGWZrIRcOLySXc2UwmAjiM1r5qfNcVbR9cHeu7f9dEGhJCPa7NRmNbuQgarYbgqhi2lNNwyRw32EPvnU8CafVA2e5inzuNJWg3ou6zWkkabgIs4JoMaROHV/Rv9+Uy05Lfl7V5+Q0qx4UGi6C7cPgYUuCB1O6dbl811SHxLxyXGeDLY5LYi8GvboClYOYrh6epzkggIaLgNzeUVG86HrxfV+G03abp9W8/0CaOxDQkIHD8fLXU3n995nUe774lYmgKYM7T4vrcdq/PBoy9NtK7aunBIGTdVS7cUqrFU9q3UkOeYiWj0rRohpqUW7WjabhcydBwyTQZrMqGHvejZwWxPjVn4bcOytJ6TQS/d1YSZKGy2JWFTJasPykFAlOKo0cFYRo7SpqeVT1+DxJ0HAZUDndblMI1do7Lkk5QmdaFJKOuyFBYLa7+KY4k9NiaLV+rr+zUUET85Vfy8RbigXpz8tCw3UQP0yrQkOboKFN0NAmaGgTNLQJGtoEDW2ChjZBQ5ugoT3I1j/3cQPLrhZeBgAAAABJRU5ErkJggg==",
            } },
{193,
            new Items.Pokemon()
            {
                Name = "Yanma",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI/SURBVFhHzZVNTuNAEIW5DhILHJyIn92wmoFNbGeRbSCXmRGbaNhwhQAHIOQ2/ByASCziUPi1KU/ZekMC8qIsfYr9tdv13N3ubImIa6j0BJWeoNITVHqCSk9Q6QkqPUGlJ6j0BJWeoNITVK6j1+sVP7zNgvuiKArYa23fBCo/A0WWv0cSd+qFWHG4h9G2PJ9ty160K8vlUuI4roVeB5UMOxooioK2jYUG3W5X+v2+5H9GISh4y8ugzXsZVCp4uIbC2+PIsqw2KqGtCKfX6KfoS+H+m4PdgkiezHnn49m2TxMqQRiVj1A4EGw2m0maplXALOnXwhZH1ReFp/tRCGKDaSi0wbEXs1AJMHoI+DzeCQ/RB42mQ3k4r4fT8+aIqrfB7PNxbR2DSsVOEYrleS6Xr6fyOC6DgcvFT/n7+isAb4MjWFqsv3UhPoPKJgiKhf4juZLJ4qQKaMMp10dRCDUtpnVl1q2O1lfDUsnQ0Zy81EOt3vLwRapHwPu7O5nP52G9JkkSRh6HLhddCpuEpZKBgFh/SZqEopNFGfA4uyoKdULAs9uhTA/Lr7P5gaEP0OnHVoNj3XZD5f9ASC2AtYbAUbH3YfoROM3+rTfcW4W8GIc+2s+OaqsBAQrrFoFiOpKduAxqA+o06ks1R67VKbbY4or1em4dsNPeyj8JA/uX/VUGg0EVTvc4Pcev9dq2CVR+BzZ6bUDlV7HTqa4tqPQElZ6g0hNUeoJKT1DpCSo9QaUnqPQElZ6g0hNU+kG23gEduul85LMiagAAAABJRU5ErkJggg==",
            } },
{194,
            new Items.Pokemon()
            {
                Name = "Wooper",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHSSURBVFhHzZVBTsJAFIa5UsE2uhRPQOsG3BlXeALgFujKxBMULgDhBCAboxujK5RDoD7nVV+Zlh/oAIlv8UX6VZqPmTdQIiLVQKkJKDUBpSag1ASUmoBSE1BqAkpNQKkJKDUB5TaCIDB/8L1DA+UmOG4WP1KlXDGXv9ee560g/78vUK5DYiSQXzfjGd08fNPtlFKu+3Py/u7nn+EKlAjf95Owef+ZRp0RRWFE3ckn9V6J+m/LODuyenVvIsvm7fiZRYByHbyCg9YgjStXjih+WcDAQ0VCuY4g8DOBKMqGA8PoPDOzrkC5Cd5qnq3TyzsT+ZUJ4hXtjhfp9ZlZvZr5MPbM5p+3DSi3wVvNh4NXJwzDldXksGb8TkMzqx+9p2RuOXCXlYSyCBIp28ihTNWsLMeJH7aHyaGyQ/PP2gSURZGvHQkV5GDwPZlZO9QlEkpXZC5t5J58CA7dZQ6hdIUDj2v1ZCX5C1q8xMlr8S5A6QLaZvkVEWdHuwJlUTiOI3jmTsILQ4Pq7Yk5LFEa1+hM/y+Qkfmrt8ZJDMfxtU3+PS5AuQv5rd5n1Wyg3Af7YBwCKDUBpSag1ASUmoBSE1BqAkpNQKkJKDUBpSag1ASUeqDSDyUUSJgHOGRGAAAAAElFTkSuQmCC",
            } },
{195,
            new Items.Pokemon()
            {
                Name = "Quagsire",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHfSURBVFhHzZZLUsJAFEXZUkAoWUYaJ+oOwImflaA7sMqJsBKVHehIy0X4aftGXtt5uUETQ/EGp4CbdPfJ60/oee9NQ0NL0NASNLQEDS1BQ0vQ0BI0tAQNLUFDS9DwN4bDoc+yrIS+pytoWIeIze/e/NXKR2bLV5/1B1sRpSFjNBpFscWj98unH0Etqtv+BxpqRK4/2Cs+6wTB5OImSPZDM95XU2ioSauHKl0+fFbEUvAguo+20FADwfz02s/vPwqBVFKqunPB6e2zd5MD75wLou8lIYCpjQ9wsgobppu1SEMGdrBUarIWjZyVq7sTQQBJVJKtwUIsoavdTMNNiKQWqtBRFWlYh+xmrLfp4oWLCYkg2rV969CQIXIY3J1XBSWL14LgbPYtuZ8f+rE7KuRQ/SbTT0NGrF7YIHqKRQprs1TdIDl2x1FM7t+KIIBknuelwXD04HdFDteCON4qlQcKbXTfddCwjkIwHNjOTeKgGEzORV1dkZffoOnupmEdEEzF8B1VgjDOQy2T3oNKNt0ggIabgKTsRr22othaOr1P9/NXaNiE9M8r1ifeKrIOuzisadiGdPq7kgM0bEs6/fpaW2hoCRpagoaWoKElaGgJGlqChpagoSVoaAka2sH3vgBS1UowKv7iAwAAAABJRU5ErkJggg==",
            } },
{196,
            new Items.Pokemon()
            {
                Name = "Espeon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIkSURBVFhHzZY9UgJBFIS90rIFB7BMxAgw9ATqBdTYRI0oTLyCmhqIehF/IpRLAM9trNbn2MBugfqCr3R7luHbnhlgzcxCI8NIyDASMoyEDCMhw0jIMBIyjIQMIyFDRaPRKP7osd9EhimQuz25tLxWKy71Pb+FDFPq9fpU8P7semlJzJVlWfGvHk+RYQoa3DzoWv/0qpIgXudlcD24fbTh/Yvlef6Zz0OGKV5wXosUIpChCOW2O9urbxB4SQhSwo+zHeJb4rgXLiMqQwUmbLVaNuj/lGBbaLfT7li73S4e5PuhouD5/rnVslrpPS1DwqcE3d2uvfafbDKe2HBjw4aJKJauedi15lFvSibemJIUW6pBTManRCuj0ciGDx8iF+vNQvZLEK1sHX6IzZIDFCx7QIAMAduDJAS5jF6qt9ebtsoGsbSArafzcYusRJDwc8vLodXxeGzHOzfFfsqnD/F29/wpiv3nlxHwnipyQIYpXG5KcKNTHNd3xen2kmgKkmgZY2X3XIoMFX6J2CRlsQWQ+2XmfTzl6XxlkeEsuC8hilONZtASDxI/XtgkBdN5qiDDRXDJIQYZSnIZuR18ns5RFhnOA3JoD435tnxTPFhs+V8EcUj8nlRLyab/TBDNUA7XEPDfDLyPYHyZAwJkOIv0txyuq34zVEWGZaDcsodgETIsyyqWcBEyjIQMIyHDSMgwEjKMhAwjIcNIyDASMoyEDONga+/6HRmNkX4YVQAAAABJRU5ErkJggg==",
            } },
{197,
            new Items.Pokemon()
            {
                Name = "Umbreon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIcSURBVFhHzZZNUsJAEIW9DqxICOz9uUACJ3CpbpDyAoAXcMkV0FNoeQHRi0jpAqravISGYXwJEWPZi2/By8B89HRP5UhETENDS9DQEjS0BA0tQUNL0NASNLQEDS1Bwyp0u10JgiDDf1YnNNwH5AajkQwnEwnDMI34ujqgYRmdTkfeX47l8+1Ebm5H3wTxXCtbR3VpWIZWbzE/zSSjdi6hR66VZdU9pC1oWIR7tK4A8sdZQz5ej7Oq4lmSJDsiWBNfDCS5HKZ59bagYREqiM1VAGDj6/F4U9X+1fWOBL6Htnh+aEjvavC3gnEcy+Il7z+tJGQhiOo8zZrSDlvp8u13tLqQh6T7fB80LEIrATlUa0cylWPHl/2p9dEu5tuerQoNGdhouVymVTgrFFQ5rHWPv0i+CjRkYNNp0JDheoIhh01Xq5VEUZT1JoZmRwq9epH3I3L/N6tAQwbuN/Qfek2rBqH381iidHN3eCD1m6q50JCBCrpXDDafBk0Jg1ahHHrOn+ifQsMiIDm6m24kVdQXc+UOGQwXGpahA4DjZmJMsN+P/74HXSDpTqfKZJ9TacgA3H+9Xv5H/k0Qcpjop/v8gnZFssFarzu0D2m4DxXEpnpx+y8Gir7d+HlVaFiGXxVMsFbPX1sHNCxDBVUOk1xUvTqg4T50ks0KKirq53VCQ0vQ0BI0tAQNLUFDS9DQEjS0BA0tQUNL0NAOcvQFquTb6FKH2GgAAAAASUVORK5CYII=",
            } },
{198,
            new Items.Pokemon()
            {
                Name = "Murkrow",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHzSURBVFhHzZZLTsJQFIbZiu6gvOaCI3TS0kkJmxDDBhRXYnTiY6DChGUYmZi4CQcMeBzvqZ7mcvMX2guJZ/Cl5aPVL6f3VitEpBooNQGlJqDUBJSagFITUGoCSk1AqQkofWk2mxQEgTnF3/sAZRHcGP6cXLxQUK1l7hBAWYRGo5EFcSif9y7HegLtiUncvwbKIxXCMKRk8JqFMa1olBIE1fQa92f4ACVCJmYHRVHXEKWhEpcM3tLvDjVJKPOQKeaFtqLrbILuvb5AuQsOPQmvsmnZoYd6tAKUu+DA789bOo03HyvjPlq+1j6WBcpt8C9aLBY0/7o33FEcd2kaHNHKuP5wshHJ19o7nY9lJwxlHvzuk7jZ05mhQ+vVkubDmNbLpZnozcYmsdeqbKKy6xPKPCRw9nyexo1HiaFHbbM55NViI+vUN46BMg9Zezy9WnUzRoIkxI3zjYRyGxzJMfZne51JyDQ4pvZfsITZ9xUFyqJInLvO7CDBvbcoUBZBJmm/D91A9x4foNwFx8lmibuhCfr9C3LoOAbKXfBu5ulx5OSmn20Y/gfi/aGTRu/zWG2gLIqEyrlMlV8/H4+dNFyu9QVKH+yp1uv17OheVxYofbEnyutU/D5AqQkoNQGlJqDUBJSagFITUGoCSk1AqQko9UCVH+YI+Hd7SqytAAAAAElFTkSuQmCC",
            } },
{199,
            new Items.Pokemon()
            {
                Name = "Slowking",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKaSURBVFhHzZa/UhpRFMZ9JVjYPmqTmAaWp9DKPykAn8JYITyBWtI4YiPSJLFBaZLxCRxTJKMF4Mn57nLIFc6Cy654d+Y3y36z6I/v3rOwQkROo4YuoYYuoYYuoYYuoYYuoYYuoYZxyefzfJo+p4EaxgEyB8fHlM1m6bLbJc/zxteZTIZv0d/3WtQwDhDcLpepfXNDnV7PsLe/b64hO3l/XNQwDhAsFAo0qNXoaWONOtwiJNOQA2o4C9/3x0sncm2Wevy8Tk+fVo1gUCqlsrxADaOAnOwvXEMQ+06W1mbpDYrc4ekpBUFgGsLe261WDfYeBLgvjUFRQw0RhNxOpTIlhMEQUcjJB8HyJ2lTDaOw95wtZyOidqtLEwQiWSwWx9jCaG5yyZcqCLDc/X6fqNEgqtfpy6ixrycnU4JJh0UN5wHBb9tlut6t0vPREdFwyDFRiR8vMkiQlGlPghrOAnL3Pw/o992h4XqvSh6LSKMlHgws+7s8B4Et2Gys0cOv8DVETZu85CCXQntADaOAHB7M+KawWxREEnJnPEheCi2qYRQi2GLBYDTBdptBEE73YDCgC76nxa+TSqrhLHw/b9p55O/dFp9FFPwdZUMWxIGhwV6U/YhHFM5xUMN54B/9+fjhhQwagzR+MDxzBjn8wpH9CElMPgYKf+O1qOEsIIcGpTkspxyQkjZFDlP9fadiHkngTQUhhxawt27bm9TrbLHA/yW2ReQDJJEDahiFLdisrdLtVSgptFh2GNHcUgTBpGSzHnLOEyxygi25iBxQw3lAUqazexm2aLdnC9pTvAhqGAdbFsPzY9RYGs9AoIaLAlnzncxHLpfDSb0vDmqYBGl0Ml8UNXQJNXQJNXQJNXQJNXQJNXQJNXQHWvkHEfUrp4Z2pFwAAAAASUVORK5CYII=",
            } },
{200,
            new Items.Pokemon()
            {
                Name = "Misdreavus",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIPSURBVFhHzZVLTsJQFIbZisaJjmgR5ho30JYJuAqKqzCOiq4A3QCIm/AxITIh7sCZxoma4z2HHlL0D4+LgTP40puPlv7576MlIjINlJaA0hJQWgJKS0BpCSgtAaUloLQElJaAch1qtZq7/B37AuUqVKtVCoLADSfj+1aPKmFFnI71Xh+gXAYN9paN6TAP1Ghl1G1eUBiE1G2c02N6Ow3I9+uzqwDlInjquJ2Pzgs9tQdCEifUSDOKO7cUXw7ogV1nMA3s2yaUi9CAGiyOY4qzvgRDcFi+dyMBOVyrO5y8PJltbQb3m4TOr4HnWoRyHhqwfTNyL6/j5lyoh7Qv7b67NVp39+lGWhUo58EBo6xH6fWzhGy2r2YabLQv3ZRPAuoalWXg2SKUi5CQUSQv5aDFYLweU9ewrrsbt0mSfI1uMGDVHS/77ngpy9FSbFCblSXAwdYIx0C5CD7ThkctqkexbJJm3l5xLMHy0OyCMHSP4v+bB5TLwCG5PX65Bngd92h0ckYf2YG0q953gzBQLgsKWWzWt7UiUK6CfvJ+B1W3bkgol4XD9XYi+v78oru9OlXKgQTjFk/TznTzbH2K+7sJPR+lMrXD43QaTo4ed91aQOb3FBePHGnP83hRoPSBg/IXhkNxc+vuXgVKX7TN/wimQGkJKC0BpSWgtASUloDSElBaAkpLQGkJKC0BpR2o9AM6gxS4Vdh2ZwAAAABJRU5ErkJggg==",
            } },
{201,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFGSURBVFhHzZYLioMwFEW7JUXdh59V6C7UnQhuRnFDft74MqQUuVNMJuAVDpiTFg5NTH2JCDVQMgElE1AyASUTUDIBJRNQMgElE1D6kqapRFF03uJ5H6D0IcsyGYZBmqYJGgmlDxrYtq0URcEZqMtLG6hxeZ5L13XvwFCRULpgl7bvexOn6F7UcRzH50fw9+4CpQsaWNe1zPMsx3HIsixSlqWJfDzwGmevkJFQ3sUGbtsmVVWZPbjv+zklZkwVOI6jiVnX9Zz6DdTgRwMVjdSoJEnMk6yxehEFpjJNE9yDIY4aKF3Rc9BGhoxToHTh+g+i2EP7v8urQOmCDfyMQc4XKF2g/gVtnH3F0iPn8/7xp/i6lDrWODTnC5R3+RZBEahoyNUpNIHf+CveBSiZgJIJKJmAkgkomYCSCSiZgJIJKJmAkgd5/QCIgEtFpyJdYAAAAABJRU5ErkJggg==",
            } },
{202,
            new Items.Pokemon()
            {
                Name = "Wobbuffet",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGqSURBVFhHzZbLTcNAFEXTkhPsPmJnE0oInQCrQBfewY5PBSAaiGAVQREgHrqWbjSMrm3sQc5bnEXOGM3Rm7HFzMxcI6UnpPSElJ6Q0hNSekJKT0jpCSk9IeUQiqKwLMt+ET+TgpR/gWHb3addv9mBs8cPyxaLfwuVsg/ExWEhiGRo/LdDkbKLPM+buPniZJJIKbtA4HK5lMcbcpTArqPFRBGN+O3u6xCYGillGwysVisry7IJYSBc+PtogZu7vV29fh8iw1BGMuz08sU2D+/TBzJAhXINlNXKNvf76QO5cRgTg+mVZZX8PZSyjb7A0CMwm6e9wUDKLvCZYeT64rm5Y3Eg1xhYFHkzyTHTlLKLOBCT4nFyelhjDJ6v6xurqqq5p0MjpeyCH2psxkDEcZrx9MLn6/rW5gOPXco+sOn6/Kl1egjkC8K4yY4YcCrhBBHBqXKijBwTRqTsAnG4g5yegoFHe4t5vAjghAA87iEjUyZHpOwDkWpzThd3MfW/GCLlWOLpxutjkDKFtumORUpPSOkJKT0hpSek9ISUnpDSE1J6QkpPSOkHm/0AWEExLl3zbD4AAAAASUVORK5CYII=",
            } },
{203,
            new Items.Pokemon()
            {
                Name = "Girafarig",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJmSURBVFhHzZVNctNAEIVzHbGKLNl7mxPo5wSw4+cSwIpkReGNKzuKHIBljNk4lQsEchlLbvqN0pVBPIEsIzKu+srS86jmU/fM+EREgoaGIUHDkKBhSNAwJGgYEjQMCRqGBA3/xmw2kziO9ZL//i+h4Z+A3G6300uRNE1HF6Uhw6oGIFiWpVRVpT81ohgzBjRkuMpdxVIWmayvr6UoioMF/Zds/9YFDRlOMMtE1rEsP35wgiZ6e7aQZNJM3DU5nv+URfJyEUm1PpU06SdJwy6m06ncvp/Lvq7k281NU0UVls0DXRPj2RfzSNbbrWz02SRJNP59XBsadoFJbIPgA8l6oxNBTlsveS5pRwXxbKYdGK3FmOBK377e7/W2kbP27r82gm05tNW+Ub04PnX3h0BDhluDXvWWy6XUdd3sZm3z3fncrUP9uLGo0u7NStLJZLAcoGEbJ/dlK/LuQtRKy5e6tWbHDap4d76QMm9aaGL4xjNlXhzUVh8atnGC95OJToadbJsClYOYv5Nt7GX+RD7nkePH2UOFD4GGDCeJY0Y3AgRNLNd7v4LV29UvYrUeKXiRyyKSyZhrENjaMlbPYleZV0+b8+27HkF2jbMOUv9V0MfORFTOl3rtXZsYKols1F3cxhd0x8z9mvTBMjD5RxHEfzMkmKAdO1gKOGaGStKwL75ku5JotclgnEk+iiBkbINg7Vn12mOHHNg07AsmxTq8eB7rDm3aaesyGMH2pCbNBPECftYHGvaFTdolOBQaHgOr6jHQ8BiGtrILGoYEDUOChiFBw5CgYUjQMCRoGBI0DAkahoOc/AQSU/aN72HdPQAAAABJRU5ErkJggg==",
            } },
{204,
            new Items.Pokemon()
            {
                Name = "Pineco",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHvSURBVFhHzZTLTsJQEIZ5pUJgz+UFWtjoEuIG38LLRlwR30BdqS+AysbLxsQNiS8Dcex/7DTH+tPWNpFZfCHnh7QfM3OmISKmoaElaGgJGlqChpagoSVoaAkaWoKGlqChJWhYh06nE3/w76pAw6q0222ZPy2k2WrFR/6bv0LDskAoCAKHns0IqszF66P0z08kaDZlenMph3fX0kvOvnxVaJgHZgwvDcNQoiiS3uxYprdXEg2HThByKqh/oE5FaZgHBPXFYBiLQRJSYSIcTPZTWWR1KknDPFwFx3vSTSqHlqJ6KqZADBWeP9+nf6ZKJWlYBCQXi7d49k6dpGupJ6X8mEmIV6giDYuA4Hq9lo+DgQxmR6kYqjh/efjVfr0w2eeUgYZ54PbqBXGzFbcb1UHLV5O+fG42MhqN0iqqYPY5ZaHhNnS16NxpCwEkVuOuE1wu39Pq6ZxWlaThNtxiTirmD79KQtqfPb082vZ/uSROMm6ttllFsax1zbA51N2YfV4RNCxC5xAv9m+unlVoJ3tQgWS2lb6USruRqCgHaFgWrSQkIOXvPa1knRsMaFgWCHbPvvegSvqVw+rZqSDQSwMgi+pBqs7c+dCwKiqbzetAQ0vQ0BI0tAQNLUFDS9DQEjS0BA0tQUNL0NASNLSDNL4AGAEEfpAsdPUAAAAASUVORK5CYII=",
            } },
{205,
            new Items.Pokemon()
            {
                Name = "Forretress",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAMiSURBVFhHzZVNTxNRFIb5S2XamWlc0Zq4Zb7qfxFcKCCxFlgjsjEQEqMxWmQvX4kBMXymxJW1hcjnvl0cz3vxlnE8hWmIyV08md4nM7fvnHvunT4iMhpRmoQoTUKUJiFKkxClSYjSJERpEqI0CVGahChNQpRpcB2XstksZTIZHl47jJP+LojyNmzbofryKR2tXdDx+iXZOVuFaqyeqbEGvr+/nx+R50mDKG8il8tR9eUmjQ5VaGxogppr53+FaqycKQeO1i9ocWaTchw+OU9aRHkTCFhfPqHx4al/w3EFS+FDisKIAj+g+sqpuq86s0GWZfHj8pw3Icpu2FyJIAhp5FGFmqvX4fTv8cdXoRH006stejY8wb/PlceLJedLgyiTIJjFvfSikKf651+0NLvV6T+wNPtNoR0CoQUWZ76qoPBYevRpcu7bEGUcvPnzAZcqHK7M1yjA0p2o/tIBdd/FXTJ0KSqR7/n8orzLe9g4ooyTz+fJ8zwqc8DQG6TD2iGFYdjZsQiHse/7qjfjIeOgDUp8355foD1vgKyUx5AokyCkbdu07RXIzloqMMKgajocrgGqGwsZ39Foi13/Pu0MDqjVcFL2pCi7gYP4e63GYQIVKvA9vno0N/eWWq02LSy874TshOeXCZgG9y42GF4UJOfuhigl0IuoyEH0gJcawXza5uWK+NputchxHBVSV1TB92Fj7QcFmireo1ym90NblBKu69IPrsLx2lXD46wDO7zs86/fULvdovn5d6qCqCyCIxz67aL8hC4rI3QQFsnp8TwUZTdQRYSMHzEIi5AIBLDkqOw+M8kBd7Ep/KIaI+hZ5ak6spJzd0OU3dA7usqfL3zumtjJfyqKkAgScZ/pyqqxH6pl3+ZKYgeH/AL/pQc1CPlh+guN8ldibHiSfnJfxpcdx4k6UniMYHiZj9Mb3KNuzxsEiPI2dEj8OYLic9Y5Vvg3vh4AwXAPwiXnSIso04CQ6Ekd9CqIoyqkna5a8tleEGUv6EPctq8PXu30+C6I0iREaRKiNAlRmoQoTUKUJiFKkxClSYjSJERpEqI0B+r7DR7zRY1u9fBiAAAAAElFTkSuQmCC",
            } },
{206,
            new Items.Pokemon()
            {
                Name = "Dunsparce",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKaSURBVFhHzZTbbhJRFIb7OAKeaGGAp7Bzgmfwylhsn6D1GWxB771u2gQG6E3Ta7GKt0IsTWqj8RDjyAy/a+1xqk5WaYGS7Em+wHwM8GXt2bMEQGtEqROi1AlR6oQodUKUOiFKnRClTohSJ0SpE6JcBPl8nl7kzyYhypuG40ajx8jllulUvuYyRHnTaB0YxwFV9DpprKzcp/fytRKinAUOyWaziqQ/bqbQa6cwDqefoiinJZrSiN5GRy6X45f/phdPkEOnmaIop4VDgiBAGIZ0CjiOczFN0zTps7WZ4hhRXgeO4uXiCN/3Vdz+/hEsy4Jb/wCrfoogfKLCHNtUPrn810GUk+Cw7HIOm94XhON1UlVUKjZsjtgeAJ/bwKcWtto/VCRz3MpMPbkYUV5GoWhgdN6kCQ1pOhukonuLeXeQgVumSAryP1IkhxI8uVmnx4hSgif388yD65bh1AcUyPdbNMEYXk7XoSCapD/aUGH/HvHmmQZRSnCgvdOH+/yE4v6G8X0WBOtquXud6HGi7jmK3Ns7wng8JuhSOhYe+KqRwSio0h/So2O8puK2vK8UPYT74hTd1j28bd9Sgba9qjZOtHkOsbt7uNhNkjeKMLf7sGpDdL27NLVHeNr5Tkvuwj9r0Mag++3PhuDAYy+llpsfM2+8NAzDoJ+Rf3sSokzC01t9RnG2A3MneoRwyKb3DSGFVcpRZOwt6wG6jbQKKxaMmeMYUSYplUrqT5jUw5cwaYqvvTu0tO/x6/yAIjtq89i1PrrN2xdR84TFiHISHKsinTLdk7QhagNa9hNFHJf8zjyI8iriJTcK0WT5PCZ57byI8iriJU/6RSBKnRClTohSJ0SpE6LUCVHqhCh1QpQ6IUqdEKVOiFIfsPQb9p1i7vQns/kAAAAASUVORK5CYII=",
            } },
{207,
            new Items.Pokemon()
            {
                Name = "Gligar",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAL7SURBVFhHzZbNThNRFMd5pX4Nbdz5BMydQYM76cqiD0ALC2hrwsdTWDVBkbVtwQWgiShu8CMR5R1IQELacjz/W28dhlOYKVTv4pc7/c9k7q/n3DszI0RkNWJoE2JoE2JoE2JoE2JoE2JoE2JoE2IYl0wmw4N87rqIYRwgt1/bo1QyxT8vnkskEhfyOIihhJnMEMwlwcvE4yCGYTDZvDtN64VV2ph6RRVVomQiyaf+ihw8+9qTkbJBEcMgmKxReKnFwqRYEuI/ap//nyDAhGhrWNRTHimltIzv+foY1xk58yfC9wkukasQw34Eqwm5Jh//fPpFy0gEqxesavjcZYhhPzAJpCA5rvxzEwKId9odevNoTYtLLQ8SRVIMJUz1mlOr5HP11h+u9qqH8axzRul0mlqtFl9OdPC8K2FaP3RBAMkxV5HiSdvtNlX9Wb2jvz/ZO9fqqjejN054neJ38LqhCOYmG5TLb5DLEx8VJ2lN3aaqmtaiBvM4MnIASwMZzhv54AbqhxhKmBbfyjcpm18/J3jM40kpT63TU11VCBq5j0vbPVlIYkQ1h7JJcrkcdatY14KHLPZtStEvloPgXb+73kzFdpfe0qfldxojPNTHjAGiWW71GK9FSB6znP+nWkYI+P6dnvBE+YjuVU4okUzzLeT7SohhFFDJ7P3XXJlxvVMht7scqJjn0cT8oZYCWLf7te4GidpeIIZRcJxRUq6rWwkqbol2Fje1XFXN6KqZturqMajeP2lxNpul+oMVKvOObBRe6NHhimJil6XrhRV67M3qNQhJ5HhGhu8TBTGMAtah4zg9kEFyjj8e8JbZWdjSLf+wuBWrpWHEcBAgV3aLumLvFzb18w4thxzWa/j6qIhhHCAGCVQOUvNj07rd4eoOihhGAZskzWL4HoQYKjfHbxTzIXtTiOFVYP1hk+DDAXKmctix12mnhBhGwWwStLasijTKxzctB8QwDub1F85vCjG0CTG0CTG0CTG0CTG0CTG0CTG0CTG0Bxr5DUKj9u0PW1xLAAAAAElFTkSuQmCC",
            } },
{208,
            new Items.Pokemon()
            {
                Name = "Steelix",
                img = "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",
            } },
{209,
            new Items.Pokemon()
            {
                Name = "Snubbull",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKqSURBVFhHzZbNbtpAEMfzSiZ8iLcA46QiKH2BXtqkfYBicuspyYVgeIAEWrW9JeqpKbf2HRJMOLRRrpVsPJ3ZeNyVNXyYD2kPP2n999r+eXa8sAMARiOGJiGGJiGGJiGGJiGGJiGGJiGGJiGGJiGGJiGGiygUCmBZliJ9btOI4TxIrlqtgm3b4LsXsJvLYSzP3QRiOAu9cn7zAiYtDwYHx5Czckm+6aqKoQRXjqrm2LWkgvqYhAmqKovqL7WKvBimYbnw6hZgMFQ4tf9iUf9HkrMki1Kl+Txdk1VSDNPogvRgqhqPZ8kxNJerS3OzSophmvTyhmEI+Xw+6UPmU+OtkpicdGHiduAjHg+QfWdPVfuyfgR21YZisYi3lZ+VRgwluJfUkk2nMBz+ghpWw3WPYNzqqI9lqrUACY+15aVjByW3ssQMSepV0z8QJRhXNggCVcU+Vmx6+R2iWNqpOWr+xpeY0QWpiiRBYrVYcnj7E6IowqmgztEL3LttmPbj3o0/rK0JEiR5VX+TSOmyXFmG5e+b7USuUqlspwcJrqC+tCRCxzxOQ1sN//IQWeQIMZwHSdID66ch2HFP8ViXJGleSrqGxlnlCDGcBy8xLR/h3TyC9+0JGudRIszSVi6Pl8j3WRYxXARJ1k//gn/SS0QPzwLoXD/L9nHvG2ErjLD31v0zIYbzUH34xYL+wWvoXf9WlfNbXdwLPRR7p2QfcJN2nH3I7z7/1K0jKYaLKJfLqp/u3rdhjDIT14PezR9onIW4rXTh5XkAhyh+1+zgixxDCV8qfY9lEcNlSYu+wK1kz7FhhHufj3JlPEcVT1+XBTHMSiL62YLxVws+vLKgVFpPjBHDVWHRVbaTWYihSYihSYihSYihSYihSYihSYihSYihSYihSYihOcDOP2JVKBPsiPGBAAAAAElFTkSuQmCC",
            } },
{210,
            new Items.Pokemon()
            {
                Name = "Granbull",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKxSURBVFhHzZbfctJAFIf7SkAShscwCS9A6zuI9MpS36FULxylYy3tdS3Be6fFGaXtTUefwD/3Enrc3+KBZT0kgJTZi29ofiG7X87uWbpFRE4jhi4hhi4hhi4hhi4hhi4hhi4hhi4hhvPwfZ8KhYLGvvdQiKEE5L5f3NGv3je6ffGJSsXSRkTFUMIUZEkWtb+7TsTQBpViIfAz+fqPJC/9uqsqhjZBEExkvhxcTv6Oo4j2aq/pR1cWxrPmvl3lBcRQAgNfH15R4Pn0rPaKwjCiNE3p9uVYCpw2enRz2J8RPalf6Mys+jLbQgznAclB61JXjifCNcuN0tGMMGAxlsOzYRguXEkxnMdUsKqrGUWxnmzQutKyw+FQC0ICmSlqyj244Nluj9LfI3q+c6QmjZXsdFlZzvzEPsV3WHBROSCG80CzoHIQOdv9MPmE5P3onuJ4WlEWxNJHar9CirHHzUIMs8AEkDSbAZKoJl8DCJ487VJzu03FQlE9Ko+XhxhmAUHP8+ht/XxmacGNotNINGbl7DGWQQzngcm4IwM/0MvJQmD/8dGkCZiNCvIexPKierZMkiRUjasaXGNvopLFJc49GzHMApLH9ffUVJ1Z/dsUY8YdyhXGPV7qUslTj8rj5SGGeeDnK3wU6n0HEYCGMI8crvA79TLjKhY308UAgsdPzmcaBGcjHznm8qNRdMOovKNeoqz2rj1eFmKYRzkoz1TLBMvKVQXYsxDEcbNKw4hhFpVKhT4ffNTVQIUgwIc3RJCZwtetvs73tt8Q9q89Xh5imAckMZkJhKfSfX0mglO19E0lt+pxI4arYMpCEr8szVqb9nfa+hr71n5mEcTwf4Eklr3T6NJA/YO7qhwQw3VgVtS+twxi6BJi6BJi6BJi6BJi6BJi6BJi6BJi6BJi6A609QcSMCOUqEnBzAAAAABJRU5ErkJggg==",
            } },
{211,
            new Items.Pokemon()
            {
                Name = "Qwilfish",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIcSURBVFhHzZVNUttAFIS5kmXZFdjh5AKWcwI4gX9YYFglWSVwAcJJbHwCUpyESjYJLKzUi1pOqyZTrUQSkHqLr6TpsaSvWqPxnpm5RoaekKEnZOgJGXpChp6QoSdk6AkZekKGnpDhSzAcDq3X61XE83XIsAsQiDOCucOPUxtdzCt6SVJM6d+HyLAtEDhdrSzp94uhnofg+suxbe52vL6cNZKUoYKviOdhznbUAweDQSUHKUo+uyAexJZ4hDDOzzabCubhdbEgj/3+v9eiDBVsapxltlyvLZtMymMoR0YXi7IdiLJdNtemPSDDOiAZN1YnCsnlzbpsdHV7VMmhtRf7imNByilJtsjX21aMyDAGYrj5dru1N5cnZTOUwHkomhVLAHA8+tT8dSpkGBJ+pVh/eCDOKRmKckwxXtOlOSLDGEiOx2O7n13Zt/m1vc12AvnP3NI0/aPZUA48pT0gQwUkbw+n9nX2uZLM87yYslKOQiGzs31Lkm5rj8hQgf3sfnpld6N5KckWY6nvP97b4+MHOzk/KD6OI3t42I3TtFuTMqwDLUISDS6WB4XMu/LhMdxSFuf/sUHIYT+bTLKyGUqwoVAslIvv0xYZ1gFJtAHCzTcWm/9ee/H1XZBhEygLUbY1PX1VttvkP7YpMmwKXzuF4vFzIMM2QOpv46ciQ0/I0BMy9IQMPSFDT8jQEzL0hAw9IUNPyNATMvSD7f0CyrsTWLvynEYAAAAASUVORK5CYII=",
            } },
{212,
            new Items.Pokemon()
            {
                Name = "Scizor",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKgSURBVFhH1ZZLctNAFEWznTDClux5wgr8WUFgA8DMZgXAEpIRsIFAGPg3AVYQyCpSYQGm/NCVdZVH52K1Y4dqUnXK0lVLffL6tewDM0saGaaEDFNChikhw5SQYUrIcBu63W7xoa/tAxnGArnlcml5nhenesyuyDCW/0ZwsVhYlmVFdJvzeFdkGEun07kjWGbn7yzP2uX5rsgwFlRqMpnYYDCwXx/XUpD7+falZe0EBYfF5/WbF6XgsN+3VqtVE96ncoUMQ/wD1WSsGpk/adv8uGU3r5//UU0sP+5HW/CvaYPJ0EMBu/hQT545SVy/rkTA1dNju6mqiGOOLZ9TiZ2dfbbT04uSdvt2cylkSFR1MCknRjW8XDhu2O/VVYccxWazmc3n8xK/+xUyJL46FFt9PSx6rWfTYgkHvV7dc7iGyq2+PbKrZ0e14OXJ+r5Xo5FNp9NaLEYOyJBQED2EKkyO1lL9YgNQEAIUy7PHtvxyWApCjmNGgVzM0hIZetDY/hiS2ACYmMt3ebKuGKpLOYj7CuIY/xjBfXzuJmSoQDUhAjn2n7+G815VXUhxnK86q80+jXlXyvBvUCTMAa5RBkvrdy/EIcf+Rd+uPr2PkpThNnhptgDlCMag+lxmCuLV1fSVKMNt4OSQQqVYvbAF2KeAywzJfyLoew+vExwDSBJfQd+LD7rEkGPf4VUyHo9rAe5g34vcZBiPZd77JvGEE1Lwe7WM/lXk7/FVZb4JGTaBzYAXOEVQJVQSPw7YZ8x4PXxGLDJsgkv7o9oczLgRfMZxsRULkWET5cTF78Dwu5RL6M8pCPH7SMqwiVBkExiLysZ+c4TIcJ9Q8L69KMN9Uy61aIkYZPgQbNMWHhmmhAxTQoYpIcOUkGFKyDAlZJgOdvAbNRaztzcwuJUAAAAASUVORK5CYII=",
            } },
{213,
            new Items.Pokemon()
            {
                Name = "Shuckle",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIeSURBVFhHzZdLUiJBEIa9ErQQ4M4ONz423bBRd8olJvQEztoTGHiBES8w3sDHBmFlhBfwsXA0rb8hnaLiH+i2m5hcfBH0T9B8ZFZWFysiYhoaWoKGlqChJWhoCRpagoaWoKElaGgJGual2WxKrVb7Iny/CmiYB8hdnyXyMWqLjNty108kqlcvScNFQO5t2MrEfJYhScN5NBoNSZJE/gwnUqtRbUYW1+FnykDDeUAwFDIneHawLu/3EyEF7b3rp/+/xQCSmFqI9g9juXXDArl+L5Z6xdNMw7zoJENuGdUDNCyCL2leUFtc5cZNwyKEgrdXJzLY2JbR5q5EFYjSMC+Z3O8T6XZSJzlZh9nrq58y2t6Tl4df0u12SknSMA+Q+7HekmcncXrak44TS9NUntz15bSCEHx9HLi9MXIf4fdZBA3zAMGhkxjEW5kkRIDKjbf2vt4b7+xn7Q7vkQcaLgL7IFp7vLEm91NJxa8cxCB6HLczUVRSByhv22kYgmr5N8YGjWGAoFZIK6aSen00lcNa1HXqT3z4XSE09IFc+Gg77/0VvIg3Z0RQuTC/cdWOonr244pu7DT0gaAeBvQ4pZXEkEDErxIGBVOskuFWo49JP5sHDUP8FrMcoqk7gvlbDUSLiPwLGhZFRf1zor8cyhwgaPhdVBTrTP8KgDJnRBqWxV8SJlq8TGhoCRpagoaWoKElaGgJGlqChpagoR1k5RN5NBVoyjGNmQAAAABJRU5ErkJggg==",
            } },
{214,
            new Items.Pokemon()
            {
                Name = "Heracross",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI0SURBVFhHzZY7UsNAEER9HSDBdtk5cALLnIBPApyEzwUoOAVkcAsVJJDCBXBmYNkW1TDean1siWKCV0atXe/TjHZNL4TgGhl6QoaekKEnZOgJGXpChp6QoSdkWMd4PI4fi9f9fn8h6woZVgGZraPLKDSIl6E3Go3C3mke+oNhcd01MqyCgpNsWlQNcvvnjz4Ft+Pn3tlDIfhXkjKsA22FJOSybLeoJEnHtkWGdUBwMplEwfJ3r6uNI8MqsDDeO1SuTJBjzm5fw2DYru0yrCIV5LtnW8wxxb2WVZRhHbbFkEhl+QD/0mKQCpLt46uY/W6cdN4qyLAMvviQe7pbC7vTRcnn+41wcJ7/iHZx7MhQATkcLVgcZyAEh8PNn3cNoHKz2Vo4vPhtPR6oTTVlqIAgKofDWR3SqB6E396+BSGHMac3L2Hn5DpKfv80LosMLWwrq4eFWBVmEMXnbLa+UD3b/lXbLUNi20o5e4/tpSRlAASzLCskeZ/HEb+jCTIkkMjzPLZOf7GVVGK8xly765eppgwJ25vmgPewMISIbauVsQ+zzC+MDOvgPwvpZrGtZiXtA1rJplWUYR0UhBAkWTUKQo7ibDHmQRDzivexpDMpMmwCF4MUNo/dMFbaVgtz5vM55RpJyrAOVDDdPFgcfxNWig/AuRhnxzMvQ4ZNqFsA9yG56gFNZNgWyKHl7x+f8eBe/ZAGMuwCVrhJG6uQoSdk6AkZekKGnpChJ2ToCRl6QoZ+CL0vWqXNrYMq8tMAAAAASUVORK5CYII=",
            } },
{215,
            new Items.Pokemon()
            {
                Name = "Sneasel",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIFSURBVFhHzZRLTsJQFIbZikPjCAgkDmUHVCYwREe6Ah8rUEbIFhw1TIwwIOrQDRBYhdGRcQDx2L/pIZf6U/ogepp8afu15X7cPkoiYhoqLUGlJai0BJWWoNISVFqCSktQaQkq01Kr1YIVPwbq9bqUy+WQ+LG0UJkGDN698aVcqQS7v48h6q3vy8dgKFVyTlqoTAMijs760vSO12YJftpuyrzjyfudXygOULkNnb3Lxye5Gj2HnPSG4WwibhjEzQIQWS1wewGV28BsXTxM5HN2INejyVqk3zneWRygMgnEIeZrvh+CQIS5eNFtj1+bByqTwMCIQJx7axeLhbRaLene+isXvzYPVCahgQoW3M7v5VLG4xc5jfy/BYJ4ZJxdxQEq04DIxvlgLQz77rOHDzn2XZcVKrehg3qeF0Yp4exFMfgU+dEnpxKdnyeUyiQwiAYhEC8LwrCtM4lzEAYHpu38nx0qk8Dgo+Dt1aDX+71VmBuJbUQirMg3kcpNuHHY1hg3Cmss2EZYr3EYbus1+J0sULkJDdSBsNZnTwPdRcN0Fv8k0I3D4PosaqhG4o9gwW12r8sKldvAYAjQl0VjWWDeMIXKNOisaADWbiDWReMAlVmJQlbPohteFCqzokEauqs4QGVenEh6PA9UWoJKS1BpCSotQaUlqLQElZag0hJUWoJKO0jpB60nEJHr+iuiAAAAAElFTkSuQmCC",
            } },
{216,
            new Items.Pokemon()
            {
                Name = "Teddiursa",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHJSURBVFhHzZRPTsJAFIe5jn8WFAiRrTewehHDCrpl6QkUlp5CegPFG3gEIdHQnc/5TfvMAL/Qpm3kkXxh+FDm481oR0RMQ6UlqLQElZag0hJUWoJKS1BpCSotQaUlqKzCcDiUKIo8+++1CZVlIO7r8Ux+lvci6VgG/Z7T/GebQuUxMDHEZfNdBr2ue5v/ThOoPAYCs/m53N3eSBzH8u1idb1/5G1cAyqPgU1fpiMXFfsorD9fJ7JeJbJ14WlyJf1eHtXGNaCyDESmycgfrYaFx43I7VMeh2mrr3MNqKxCcWw+MFtc+ID124TG4ssg+N8CEad3DhGb90Q2q+lOGNC7iWuASBz9/meVQWUZGiYSy2w29s94rVPNFpcHgXXiAJVl5CHxAeFUPx66/nj1D8Y96GeVQWUVNBJRQCPzuMgfad1jDaGyCgj0Ye5fCMA6fb7+CwNNJqdQWQU9SsUHFmFYtxEHqCwDmyMkjNO1+pNOEBuH90zjgHp93TSSyipopBJGhhM9SWCxqZ+U3r1wouqbxgEqq4DNQxClU8O6jThAZR2KIB+Hh7lAoNNsKw5QaQkqLUGlJai0BJWWoNISVFqCSktQaQkq7SCdXxIgMLyiyv3pAAAAAElFTkSuQmCC",
            } },
{217,
            new Items.Pokemon()
            {
                Name = "Ursaring",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJCSURBVFhHzZRNUhpRFIXdEgjMTTmBGQ0TrYywsoDoCM0o0Q0kshGjbsAkkygbsHQF/iwA9OadZ9/28eo0abub8g6+avoI9tf3562JiGloaAkaWoKGlqChJWhoCRpagoaWoGFROp2ONBoN95H/vQ5oWATI/f0+kunxjqw3G5lo3dI0LEK73ZZ+vy+XqaSKhtLxb8pAw/8RVi/m5nfPXUfvJwi58XgsSZL46p0d9OTqx6LsYJDU1mYaLgOC1xddeX7YFXnc87TWmzKbzWQ6+eQFIf2uFZzdfc7klOlksdV1SdIwD8idjLsySPpy/auXVTGWA0fbH+TQ0XStrtJuGuYBQWzuz/2el9Q5jMUug5nU+7LVpCFDq4fW5cnFUlgWfO/b1ksl4/9ZBBrG4MzTYwWCKjm/e12UsNUQTNKXQLWrzCMNY/xiuC0dDodZe3UGVer5fnEeIYUZ1HZDukwVaciAJIZdRVG9eDkgiUwrjJcJz8gyVaThMnQWn1IZfTikkJ1/eR2BeEZXLhguyo1r8e0fJ5MKhfd+Pudz9wIvBzfQFr/1yKFhHiqI2Trd72ZSispCEAsCST8O6bXMwtBwGZD8urXhBfEwhr4ARHHEYKNx1d+sXDCsYp5ceK+C+Azess00zAPnIbb46OOmPLm2tVotP1M6l0C3V+9DSXx35TOoD8DnOFfCEShTtRAaVkXntKocoGFVIIhRwAjoNf5OUWhYBzoCmFvNykBDS9DQEjS0BA0tQUNL0NASNLQEDS1BQzvI2j89nf+rs9pqUAAAAABJRU5ErkJggg==",
            } },
{218,
            new Items.Pokemon()
            {
                Name = "Slugma",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHjSURBVFhHzZZLUsJAFEXZUvgVDNWROkrIRMsVCU4od0HpwM9KLNkM4LNvkpdqmwtpCIVvcArqNITL7fSDjoiYhkpLUGkJKi1BpSWotASVlqDSElRagspDGQwG7oGvtYXKWIbDoSRJIqu3ufR7Xaf469pAZQwIt3pMRT7mIrOJ9LuJ09uvwRcA4VosVDZRh5tlBcv7sfS8EH6z8vm88wvEQGUTCPB1N5KfaRnS//Cw2XD9UKiMQUO+3IwLutVWpmkq62nZLGv3UKhsomhpdSHyVDaYZ5kLO64b1WDKWQNquDwvm0IAP9gpwwEq94GZ57dXsLl0SwvHVeERLM/SVqdXoXIX4eHQcEWb6zLg8uF07QEqd8FOaNleRdXevwbcatDhhwKn2l5A5T4QEqMEp9YPhVEzqfwpmlOo3IduM0ZLVo0XNKbPERYNYzif/ZAoCFkP5ffyftRZqI0iJB7RZpugVMZSHxp3H2pA/WX59sJq0PD9MVAZA+YhDoy/vQi2qQK/3v4NqdseXqcJKptAc4vrUR3Aby1sUE86AuP3OrxWE1Q2oVuLD/Vb07YUtIb7TwmvEwOVMehB8dH7UWnzN0uh8ljC0OH6MVBpCSotQaUlqLQElZag0hJUWoJKS1BpCSrtIJ1fHU8V9dIEmeMAAAAASUVORK5CYII=",
            } },
{219,
            new Items.Pokemon()
            {
                Name = "Magcargo",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJ0SURBVFhHzZXNbtNQEIX7OhEb7PzIFk8AZWMnitSKFd0BK+ApsNm04SmqdgOsCm9Q2AB5kTZkAXS4x+kkl6vjGAcszeKTnWPL99PcuZM9ETENDS1BQ0vQ0BI0tAQNLUFDS9DQEjS0BA27YjQauQt/VgcNu2A4HMqPV5kM4sj95O8waPi/QeUgt1z0ZDC46yL+HoOGTWDBKPqzEpqF6DMVXC7bSdJwG9iqq6vNQiry5PGxFMUnKcvPkudjd39Z3cdxv5KTMq8Eb16322Ya1oFKQG4yyeT6uifnDxP5dpDKd3cPYeQqppJfD++tn7eVAzSsQwWxmC+HSqq4VvLp0ay6LhZ3qvfnjxLp3255G2jIgNyXg0Ruikzmh+karc78TU/O9hMZZ6sqQvCieOGqeVlVU/uxLTQM0SaXd8ci72eun8YbyRMnN1vJoaKTfFVFCKrks6OTqprox/DbTdAwRGcYGt3Hr6QPJLUXfdF+HLvP8TXqoGHIuoItBT+UL9fVg2QUdSQIIHl6P5Fft6KhUJ7nrkdTOXuQVn14UTyXj+Vme3XkhN9tgoaM6XRaCaiMCuH3qZNC/6mcf5L9Puy0ggCSOI2oJER+FqutnjhZ3OMajhntw13kAA2bwHZnEHzrTrU70RDTqmJrMVpUDNUbu7zTMROiM9HvPb8f/f77lxkIaLgNlfMPiQ8GuVZUexRX/IvsIkrDOjAPm+S2jSA87/y/GPOQLc7whcH5fipxyyrScBuoop5kjBaVqBNDxfC+En6vCRr+DaimLuoPcJXdtedCaNgWX1YJ39kVGlqChpagoSVoaAkaWoKGlqChJWhoCRraQfZ+AwXb4/IkaU8HAAAAAElFTkSuQmCC",
            } },
{220,
            new Items.Pokemon()
            {
                Name = "Swinub",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFsSURBVFhHzZU7UsMwFEWzJQvsPYTODk1CR1aR0AErgI6BFYQ0DM7GgofyoRePZhRxpcRyiluc5viT4ydbmYgINVAyASUTUDIBJRNQMgElE1AyASUTUDIBJRNQMgElE1AOpSxLKYriiPCcXKA8l6qqDjFfj/fSfa7ld/sgH3dG3heFmAuFQnkOGvc2L6TbrI7CQjQ0vHYIUJ4iFeecsnteSmu5MvmRUKbQuL2N0CiNcXF+mI8eHzNFKFO4QD8gFTd2qaGMoXF1XUvTNPKz6T8KhB/m4q+NsbfA900BZQwN9L9YBFpy53KmCGUM3e/2qxfZ3SxsQB95O4tP05/k91P/YEMnCWWMwwSnc+nWr/8iw2UPJ6nn5OyLUKZwka0NbO1UdBuJLbluMzMbPubfBcpTaKT7UX0nNdJH9z13PDfMAeUQ/NhLBIVAyQSUTEDJBJRMQMkElExAyQSUTEDJBJRMQMkElExAyQSUPMjkD6iNU4dZBFfzAAAAAElFTkSuQmCC",
            } },
{221,
            new Items.Pokemon()
            {
                Name = "Piloswine",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHfSURBVFhHzZdPTsJQEIe5ErVwB3VF2424w5260pW6U3fKBYyeAN2Q4AIjFzF6Cf8tIBk7LxkyvvyKfY/UTJMvyqeBj5m2aIuITAOlJaC0BJSWgNISUFoCSktAaQkoLQHlOnQ6HWq32w7/ZzFAGUO323VR76MT+n44c6RJsnYolKFw3PR8QF/3p8s44flyjzaS+EgoQ1gVJ9wd9imJnCSUdZCV3uzv0O1Bnz5H1YHrTBHKv6gzNR8+H/3nqQOUq+A4fSHUJXbNUFYRMjleq/692DVDWQXf40JW60fGrBnKKkLXy2vVF0+jgTEXxr8HyvT81a1CIhs9B/3V6hdFodoXeUZPFwPn+H4ZeiVD6SOB/GIfZZh89VcoaC+BHNdYIOPOwemY8jx3nx55llFWwqF+oLwB/Vg+cTgw5A8IKH04bj6f02z2SJPtXXo9uqK342sqVKRMjWP8cB0YOkkoffj+x4F8FEVBL2XgZKvvQjmSY2RqEsMTlkjteHqNTTBNU/fk482dX4E8scVi4eL1pOQ00K7Rc1B/3+v1lmFy+IE6SiYXMj0GyjrIVOUYDoeUlDdiDvSDQqM0UNZF//8hERy+TpAPlJaA0hJQWgJKS0BpCSgtAaUloLQElJaA0g7U+gEJ+zbeS96YvwAAAABJRU5ErkJggg==",
            } },
{222,
            new Items.Pokemon()
            {
                Name = "Corsola",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIkSURBVFhHzZVNUsJAEIW9EuHnAHoCCCcQ3aAXQDyF5Uplxc8BXHAB0Y1VblAuA7GdN6bjkHqkJEGrF1+RfEklj+6eyZGImIZKS1BpCSotQaUlqLQElZag0hJUWoJKS1BZRKvVcj/82l9A5S4Qbj0eSyOKpFarOcXvOyRUMhAOoRBwHp9J0r+SRi1yl/j9h4JKhlZPLoYik4mvYv4eRtWRoHIXeNlj+1QSBJ1OaUittB6vX5fSqNf9eRmoLMK/tD/wVUQ10WYECtE5RTi5vK40ClQWoQG7nY50HBs3iz6sqygCw4cO81pPK1oGKhnNZjOrULvd3g4W0I1j2aQjoPOK49/ObB4qGQjoW/a28lWJUSkNwsKl5/qn8AxUX5/3W6jchW9vWB2tkPudd3rZ4tkK667pnGI09p1HKovIFknQvjx+nwzC6r5Zpt1U7sKHW69l3j3fCpAnH1ArjMWybxWpZGAGsTh8q/TlSSIym/0EYaDSaZvxnH3nkMo82lads9XZiax6x98VQdhcu0fPH5K4/W+0eJeHl5U/LrsXUsnQbUa/JAj5mVYya2naSj9v7lgDRv/5JdFW63YSzhtW7t1i6UMpcdzNtpkyUFkE2n33tJTh7VQitxo1LIIOb8Zy79qrVRuk5/9aQYCQ4eaLkPjsoXoIE16rUj1A5b5oVavOG4PKMugiyvuqUGkJKi1BpSWotASVlqDSElRagkpLUGkJKu0gR1/+0kxb3GdUcgAAAABJRU5ErkJggg==",
            } },
{223,
            new Items.Pokemon()
            {
                Name = "Remoraid",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGdSURBVFhHzZU9UoNQFIWzJX6SXneASaVd7EztEtLpBpykirFxsgFG3IQzNkY3wsMrB+ciMieEAMUtvkn4eMwczvthJCKmodISVFqCSktQaQkqLUGlJai0BJWWoNISVFqCSktQOQSTyUQ8z8v/8vttobIvCLf5SMUPwvySj2kLlX3QcNm3SBgaDviSvEoQBLni49pCZVd03cVxPEg4QOWpjMfjIhiaW+zWcjGdDrJBAJWngHAItv2Skqv7tVzercTz/XwIf64tVB4DU4lfbS6Kojyk+xdus8+K6747mcomqkdItbnpbFaGrAbt2yKVTWhArLXHz9+W6lRbxIug5a5rksomEPDm+aEMh/PuqRZQ0Q3jnOt8JlJ5CG1PAyDccnkrWebKkAi12K0KML04cpIk6XzsUHkIBHybn8n79bls9678WqRpWgTE1Losy4f+fUXwDO5X3SlQ2QR2bj0kwmlzaK2+3nS3V11bqDwGWtGFr/SdykNQ2QUNXfd9odISVFqCSktQaQkqLUGlJai0BJWWoNISVFqCSktQaQcZ/QB99X5sOk5AgQAAAABJRU5ErkJggg==",
            } },
{224,
            new Items.Pokemon()
            {
                Name = "Octillery",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIiSURBVFhHzZVRTsJAEIa9Dj4JCgF5KngBkItAOYGRF6OnMF5A46NcQOMLwikMHqDAuLMydrL5K20xOiRfoP9u4WNmd3tARKaBoSVgaAkYWgKGloChJWBoCRhaAoaWgGEZGo0GVatV9xGPlwWGRanX65Q8V4heK3RyfOQiPK8MMMwLi3HVZs0mPV1F9HTdoflpi45d9lvVhGEeuKVStelNRMt+jzajEVEcexatL9HwvqLAMA+h4DpO5TQntZqbjr8jDzDcBctdRBG9uSpxa1mOKyboSv65oK/c/S3ROKZJp0NrJxNKyfVHv+8/79NqGGbh5YZDGrgfXm0FWJIrGUrq/N8EtcgmSWg6ndK83fai/yLIiCTLSQsnbj3WnETiJPk1OTujy62gjPG9ZYDhLvT5J4Lr1coNka/iZbf7K9VjYJgFV08fwHytJblqUjnOBr2en7/PoQ1DhG8t797HO/c4S48OrqZIalhu5t5l4/BxU0YUhiF63elzTSr6kyC/991aZXhjFT0XYRjiBfmpMU4ltZjIIEnZ7QzvfhYtUkkYhui1pg/gb4mHWxqcn3/LyJhm6ebpdoe/kQUMEVLFRTttp8jxU0WfjfoP8C7W1S66q2GYhaw5jV+bL4denIXfAzm5V44muc4LDPOStYNDuX2AYRFkfW627ZeWhvPKAsOi6NaHY/sCQ0vA0BIwtAQMLQFDS8DQEjC0BAwtAUNLwNAOdPAJYOj31SNu1+EAAAAASUVORK5CYII=",
            } },
{225,
            new Items.Pokemon()
            {
                Name = "Delibird",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJcSURBVFhHzZZBUuJAFIa9yizdiQQKSjdSXoAkm3HWs9G5wMzoJSjYWJ4ECi6h48aquYQLF4DP/tu82OBPIglar6u+SvITqI/X3S/ZExHT0NASNLQEDS1BQ0vQ0BI0tAQNLUHDMtrttju8HT8TGhYBqfl8LlEU5cf1e3YJDYtQQR2bBHdVZRqW0Wq1ckkmqJ/voso0LCKUw7g6PZXDRkMaGW68u+dLBUE4zbPZTP4dHcnz+Xe573al6STH47Esl0v/uY6qkjT8CKHk/fGxXJ6cyGQyWRGDfLPZzCtbBRqWAbl+vy+LxcJd8pGmaS0xhYZlaPUgoZI4j+N4RbrO2lNoWAYEUR2toopiSpMkyc+n06mf4vXvbwMNi4Dc4+O+PD3ty+jnN0niV0ltKWFVdQ3ie1Wh4SbQPm47HUld5R6ue/L/pidp0s9bTCj45RX0vS1rJRAcDAb5jh2NRn5qsQaxkyG2CzlAQ4bfGE4wXdsI4UDVII0q/un1fAN3g/7eR6HhJiD52/W7OGgxeJKEwrj+6+QW7s/IxZlENSVpWAQksQ6f3Xrzctm06/WdO0fTxhFPF5Ws2hNpWIRO9ZWrkn9y/PrhJSCpQBbTfJtdY82iylX6Ig3LCKuIDbJ0giqJTHewbpxwQ20rScMiIIc+iB541+28SmXTDDC92maGw2HtlwYalgFJ7X0A1VRBlcRG2fTy4Ab9XQYNtwU9EqLY4RDDLsfUIsOrV52+SMOq6PTjMRhFBy5arbbetw00rIMKredVoaElaGgJGlqChpagoSVoaAkaWoKGlqChHWTvBdb6XB63vA2tAAAAAElFTkSuQmCC",
            } },
{226,
            new Items.Pokemon()
            {
                Name = "Mantine",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH1SURBVFhHzZZNUsJAEIW5UkDYyw52iTdAV7jy5wSiF1BXljegvADICZBcgJJLaMlynJeyy67mBQIFVC++quSbJPPonkmohRBcQ6UnqPQElZ6g0hNUeoJKT1DpCSo9QaUnqDwWzWYzJEkSD/k4oPIYINx0/hUajZN4yq8BVB6CVqtVVEtAuHyx3G9APYkdWwfuG46mYfb5U4QSNoUDVFokWJqmIcuy0M6u43m9UlgW7m2Sh3qjEYf5PRoqNZjgNL0KaQzW7T+G7uVzPD4rQnb6T8U5wtr7BAkoobbtAJUaTNCJwdrZTRFSKijhBF1RjQ5nn10FKi0SUgfS9Abv4fx+sgLGhuPZzuEAlRa8EnRAVBP0BmMaTCPXr1sG66CSYVtdJZwmqR+oxQgm60lvlrK2amy1dwlJJZDPEELpDaGD4Rw7GhtnU+h2drtTm6lE1Www2aVoM4JIOGl1Fo+rVBZVlI7YeRlU6l0rwfRY725UTLZNBRlVWk4lsP80ZC1KOICqVd3JZT9EKirzWKi0IKwOBhBu/vEdFvkyXDz8B7FVrLoUyqq5IhjyHpSH6nU0fIlfite8oP7n9bVg01LAeNkGWhFl6NfNJq+dDaupsmGo3Cc6rMVey6DSE1R6gkpPUOkJKj1BpSeo9ASVnqDSE1R6gko/hNovApfC+h0FrPUAAAAASUVORK5CYII=",
            } },
{227,
            new Items.Pokemon()
            {
                Name = "Skarmory",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJqSURBVFhHzZZLUttAGIS5TrLz8wDcwJJPAJzEhgs4YWPgBCQ5AIET8NhAOEUeC4qVyx7UU7T816Rly0iLn6qvLFqD53PPaMxeCME1MvSEDD0hQ0/I0BMy9IQMPSFDT8hwE8PhsHjR9wjGdDqd4lLf3wUZVoGJF4tF6Pf7xa/VY24ff4derxclm4rKsAoKjsfjcnIrgPuTySzcPf2JghTl/Y8gQwXlHp7/hbwQvCsmxzWgxGAwiFLn32/C/a+/4eTkNHS73UYtylCBySlosQ0pwbNv14Xkx1uUYYpdOk4OOTTJdrj3eB+vQMlhbN1WZWjBm80vr8pJrdz88mcpkAqq9iiWHZ63K5guLSe3DSlB7D/7PqOD+bvcOt+GDAneFO0tl8sohsmPj7+G19fP4eLH1X/tQJDyGEdB3ENjo9EoZFkWr1tpEG/M9iiHSV9ePkXB/GjdBj8MxoAsy0sRiLP91WqF8fFn03lKZEisIPcclxXLNf1yXy4Z2wHT6SwK2qMIf5fneTmmtQa5ryBllwZHSilZTAwZjKMIPgwfLIo9HuyH58M1vRqSMiQ819S3Ae5NZrexQdsWm4Ycrq3YOFu33EqDACJpRtAwltYuJQVtaxRrvcFt8MHg2UhByKSSFOI2aa3BTVAQ+4z7DfBJtsdNXaEUGdaFS8yn2wryIAf2vNwVGdYhyr1/M+AhsZIQYrNN5IAMtwE5nI84aLF0kKk6hnb5WlPIcBuY3O4pCKs91oakDNuAcnEL7PgPgkWGTUm3AK/TcXWQYVPSJa/aAnWQoSdk6AkZekKGnpChJ2ToCRl6QoaekKEfwt4bX8D/ZKTb35IAAAAASUVORK5CYII=",
            } },
{228,
            new Items.Pokemon()
            {
                Name = "Houndour",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHuSURBVFhHzZVRTsJAFEXdjokf0hb2gH9tWQV8AWUjRjcDgQ1I2IwmfAA+eweemZRLW2rBZ3Li9NbQw30z9UFETENDS9DQEjS0BA0tQUNL0NASNLQEDS1BQ0vQsA69Xk86nU6+5PfbgoZVdLtdGY/HEgRBfsn/pi1oWAXaU0G0qE1qq202S8MyIBHHsez3+/xSZLVaSZZlThbS0+m01WZpWAYEd7tdvjz+DAYDWSwWThJySZL8X4NMDkIqiPUlQR1/Ma+ChpfAQz6GffnOx4vRLpdLORwOTnQymZwJqhRoeqhoyMDDPl8fZft2ZDPqS5ZLYS/OZjM3Xh0xsiiKfveqNn3TBiGIFvCgr5NoFDy7RtMkdg2qIEauzeoawsXPrAMNGXj3aYNoD2Pevj+5tS/ot4hmdQ3Zm+9BSOIhaG0zenFADhK+oEr6rWJ90z3oo5sfe4zJXeJugkBPdHG8PkV5XF87ZhpWAbn5fO7efevTmIsiuMbv4vpughgvTijehWmangmuh8c9GnpbQV8/xc8rg4ZVqKA2ovtRJf0c6H+fJieZhnXQE61rHTkE0WwYhu6e3ve/kOZ1oGETIKFNsTH6X+gaaNiEv7RUBg2b0rSlMmhoCRpagoaWoKElaGgJGlqChpagoSVoaAka2kEefgAEsATIqabesAAAAABJRU5ErkJggg==",
            } },
{229,
            new Items.Pokemon()
            {
                Name = "Houndoom",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIZSURBVFhHzZZdboJQEIW7nfZNEfdg3/xdhH1CYCO2T12KGjdQ083UpA9qphzsmCseuECMGZIv4gdyDzP3Ik8iYhoqLUGlJai0BJWWoNISVFqCSktQWYd+vy+dTieneOyeUOkD4VarlZxOp+yrSK/Xu4S9d2Aqq0C4w+GQ7Ypst1sZj8cyGo3keDzmDhsCZxv9fVOorMINOJlMbsLpVgzZdkpQ6QODDYdDWSwWVwG11biBsoCuqwOVVYRhKD/LZ0njSOI4zkFId3Cco/tFx45VQWUZuHgURbJ/f7kERPXSNL0JWcZ0Om1USSoZaBEq9/tx5vttIMF/OxEQYbvdbnYq/71LkypSydB5t3dCArfVdQPiWkVXBpVl6ET/mg+yCr7KeHReKBrQbbOeq+g1ZrPZ1XcfVPrQwTEf3XCYj3j04Ji2XucoqosONAkHqKwDQpYF1FDFz7pTwIVKHwiHCuGfJEmSSzj9ZzEQMLy0sBgOc3K9XufB9VOr/LCA+jzUgavADehCelhAgJBYzYmzil122SrHSsezUm/m4QGxKnfzcxD3kYNwCKYrFucul5+y2WwkCILc1YXKOmBQvBNi3iGIvjywSuFczFlsTV/FqPTBBoRDKzHnis+6qmM+qPTBBoRDRctaiONNwwEq6+AOiP22LfRBZVNYRe8FlW1o20IfVFqCSktQaQkqLUGlJai0BJWWoNISVNpBnv4AuM8IA5szT2kAAAAASUVORK5CYII=",
            } },
{230,
            new Items.Pokemon()
            {
                Name = "Kingdra",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJHSURBVFhHzZZLTttgFIXZTtSRcWKVYdIRlImdrAAxSssKYAVJmNDsomoHQNgAISPUCSUrqOiEqpOqDBJ88bF1Xdc6PH4bKRfpk/OfxOHjPizWRMQ0NLQEDS1BQ0vQ0BI0tAQNLUFDS9CwCq1WK7nw9+pAQ1cgN7hayLrfTI78M1WhoStlwSAI0qu+9jwvP7tCQ1cg2D/+IVujmXjrfi4LMeTD67hydWnoigp6vp9KQfDD5GeKZuV7XgoNXUALVa58riOm0NAFVK+9cyxh1M1bGnV7ryIHaOiCthfthFj/JBPEVau4shZrO7EE73bPEqmbfPZAZ3cig+/3MprLapYEgsWFANjk/ulNKgfhOhsMaPgc+mzT1qrU7f6BxMulbB9mZ30Pj57yd7wUGj5GUQyVKcph3j43GnK/WMjeWVbN11gWGjKwDJuD82Sm4nSmIPAUTA7f4SpMw8fQX1BE26xSURTJ9PaPzH7fSRzH0mxm86d/oGvLaehCEGTSYRhKZ+dENocX6TNxmcwifnq9rJKQm/76K77jwtCwCsUKYSa1mpBGBrnx7Fuy0W4LQ0NXVG558Ub2JoWWJ4Jbw2na7ipygIauQHBx3hCZNeTrwVv5eJr9Z4NWH00vUzlIotXle5+Dhq5A8OqoLV/2N+T6U1vm445sj/4tBMTwWs/l+5+ChlXQKs7Hmej74f8bC8mVVVCBJCRQzV43zGewiphCw7ro0mAGTQvmc2dNEGi768gBGlqChpagoSVoaAkaWoKGlqChJWhoB1l7AKdwJkUgnlEdAAAAAElFTkSuQmCC",
            } },
{231,
            new Items.Pokemon()
            {
                Name = "Phanpy",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGnSURBVFhHzZQxUsJgEEa5UkC4gyUJDWCFVIAXsUQ4AWOlVowniGNjiXqKCAdQWfMNboTMF/jz4zBbvCE8Ajw2GyoiYhoqLUGlJai0BJWWoNISVFqCSktQaQkqLUGlJai0BJU+NBoNCYIgI/+6L1SWQcPGi0+ZvEtGtXb2L6FUuoI4hN0vRR5Wf3FK5/ZZgmotPZW/3wUqXTgUpxwbSeUh6vW6tGex3LytadQ2Uat11KWmch+IS3oDWV0O5WL2RCMRNV58Zc+PmSKVRSDufHAtSRqHQDB93YR8r0WmBYEAN03+81ygkoG4u2Rzp2IiSX8kj52hTH4DEYCdZHGKTySVjEN7p2H6+NG/yqarx/rXU2YnqSwCkfp/h5AwDHemhcmGUZQF6grocSs9v53ubZl9pHIfiNQpYKIIQii+GIEaOW8PZNnb3Ejz7kgijzhApSt62TVsGw1X9AecPDCOXyRKY7YnuI+TBgK95M1mcycSIboGvnGASh90mt1cSJF3hUpfdJqu3gUqLUGlJai0BJWWoNISVFqCSktQaQkqLUGlJai0BJV2kMoPQgdpOmmwGJcAAAAASUVORK5CYII=",
            } },
{232,
            new Items.Pokemon()
            {
                Name = "Donphan",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJVSURBVFhHzZVNUttAEIW5kuWfe1jyKewT5GcVssKwMdzAkA1wilSyMfhCdmXgyTxXp3kjyYJFu+orxNN45lP3jHyWUgqNDCMhw0jIMBIyjIQMIyHDSMgwEjKMhAz7MplM0mAwOOLv90GGp0Kx+fxLur59SDd3j2mx+PaaFR+WlWFXlJinqqp0vlylojjI+jnakCEYj8fHpyf2PuQgdr68Tj8vb+qKASWKHOPKsjpZUoaQW63v3y1iWzadTuvKQM7iRfk/gCT+Yh6/Zg4ZAlbQikIAVWCG9pVl+U7USuXoKilDC0V/XKzqiVULITqffz1WyIOHsGAs8i6SMlRwz2EB337gpQCFluun9PD8Lz1uU7q826by7YE+XRBVZJutKCvYJOapqlk9pu3QyFABQX8wKGrl0GZsA96/f9pLQQDJ3oIQste5g+HFbNvteCXKdjdJyhBCu90ujUaj+svA7zvfVgARoPaoF4Vcb0GcXAji83e7PU5uF/aC2PD4ztWvw6JNotibFARFMcRS0kWGwErOZrO6pbZSlOP1fr+vx9kq8SB4WSvZq4KE78Dfm009qT0glLNiuGbF7Z6jCEUpuFh8r7PegoSiOMWYkNWklP3kBAlEUfHl7UGw7V0oQwUk2SbbaisJueFwmC7Wm/9ezBTDQwLu1T/Ph/GYP4cMc+QkuTBBpblHVaXYEcAshwxzYGL83FGO+MXbBE9Bhk3YKtoXtZc8pY1NyLANtoi/zV7QjunSxiZk2JXPkmhChpGQYSRkGAkZRkKGkZBhJGQYCRlGQoZxSGcv74G/pyPGPJEAAAAASUVORK5CYII=",
            } },
{233,
            new Items.Pokemon()
            {
                Name = "Porygon2",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHpSURBVFhHzZVLUsJQEEXdUghkD6ITQlYAsgB/S3Do0ImfUYQNWLoBPxvAYhWUWQCENjfYGJ43ZRILq6k6g5yX1Lt053X2RMQ0VFqCSktQaQkqLUGlJai0BJWWoNISVFqCSktQWYdOpyOe5+W4ay6413W/QWUVgiDIQy0WC5GniSRnt+K3WqVBcX/8vJCW384uf66XQeVvYLPp/kBWD7HI4zgPl5yumXWH4jshcT/+yORNdhtQqwbmx9ebUGC1TCU5v6MhtXrjXQbUTdJVdpX9RneJzE/XgRDu4vJK0jSV2eFoKyCeG1zPJX5dydFtIl7Lz31VqGQUN0IlADZ8PxhlAZfSbrfzNrKATasHqCwDm2mLe72eTLuDPAxASLS4rL1NwgEqq6DjBYdFQ0a9MHdYD4L1Oqpet61FqKyDBtWKonq41kMUhf1N6CZQWReELFby4+RmfXge7jfz0X2mKlRWhbXZDanXxfeyDlRWAeFwaqMo2josLngvw/D73awLlVVAQJzOfj/KD8Lwa+S4weKX5WYkNTksVFZFW6wBlTALjWA61PGJ+5c5WAaCakgNp8Nc+fc56KLV1IrqF6dpaxUq/0oxLHDX60ClJai0BJWWoNISVFqCSktQaQkqLUGlJai0BJWWoNIOsvcJqshIekxSkXwAAAAASUVORK5CYII=",
            } },
{234,
            new Items.Pokemon()
            {
                Name = "Stantler",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJqSURBVFhHzZU/ctNAHIVzJcuxB0qOYMknCNDAUCSpaeKkAhpm0jihSqCJoQh/ikw6jhCSE2SgwhdQxC9663lhrXlSJEsz2eIbW89r7+en3dWamQWNDENChiEhw5CQYUjIMCRkGBIyvI/BYJC/6M+6RoYKSPV6PUeabtr6epTHemyXyLDIcDh0Uj/2I+tH5YIYV8zaIkMFGoTYp9fHlsSJ3dxsLUnyTyBj0/ysDTJUUHA8ji2O40rB0/c9y7JuloEMy6Ck2baDApQra7cNMlSoBvEet3I0Gt1dq3bbIEMFBCFyMZ3Y591te/vyqf06mNjV4a67zrJFq36zXSDDMiB5Md2xcRI7UV/uy95COuuwPSDDKtjk9dejO0G/Tcr3o2VJrNNVdrYMq8BEaPH3t2Mnd5mL/csye/fquc0mW+4aor4gvnN9emR/vn+0fr9ZuzIsw5dje1EukqapXX3Yc+0Vz0D/OxAsyt+HDMvAZD83nthh/Ngu80kxmY+6rVgO2Nlcs2pcFTIsAxNOR4+cYBIvdjQmRJMEjbJFNEcprk2OKf52GTKsApIUONnZdBMmeUNvXmwsrUEFl0DxN6uQYV24o09yMTZIwfnfWb4u/78ia3JriQzrAkG26Mv5gnjPTfUgglhnvkwRiD+YIIDk2dnU5vNZfhY+W3r8nZ8fWJIkbnPw3GyyQYAMm8DbTBk+YfwzEXBHN21Rhk2gII8XHsrFJwaXQ9MWZVgXTMqDmMcHRVRTHM+xdZBhXTAhb6GfVQk2kQMyXBU25DfaFhmuimq0LTIMCRmGhAxDQoYhIcOQkGFIyDAkZBgOtnYLHLsIgrnjcXMAAAAASUVORK5CYII=",
            } },
{235,
            new Items.Pokemon()
            {
                Name = "Smeargle",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAANMSURBVFhHzZbLUhNBFIZ5JJO5JrqBJ2BmukOVutIX8LpgCYJWFEtuLpRLFVWUbrDYkgvuCUmo0hcJl4TSQB3P6aGRxJMwCVLVi6+S+Xsy/efvc7pnBACMhhVNghVNghVNghVNghVNghVNghVNghVNghX/F57n4gc/lhRWvCmO40AqlYLj4yLYtoUSf18SWHFYtLH94iLkcgJOTkrgebHWfW9SWHFQyBglRYmdnu7C1w8vodUsq+9EfXcZnCGTZMVuXNeGVDoFaesOXnaOkbkoClVa2hDHwfePYFnpf35/Hax4lUwmA/nCGDxYTUG+NAq207lcnuuguTi5fjSbpaFSZMVuKKW3xVG4jybnymOYZGyS9P3pAI4OCx1maKmbuMREqxUvdbW8DOsiC+kB65EVu9EpPlxN40SL4Dg2yrHBvalxkGFsUpvK5SQIIXDpI6gUFqFWXoKciKD6KgRnwGVmRQ7f92GvsICTLauip3oig9ShnwMfpAhBSjQVBPBtawva7TZsb2+DQJMh/gEyV5+JsbCeu5/fC1bshUpsZ14loguetBVxF1oXTbKGy3h+dobbiwdn+LmGYyGaplKozxC3bJA6NgpDsK244KWUHR188EbC+e9fNIZG21CdFeDjifIpyCiTlCRd02+TwIq9oFo8xFr78v6FgurJRhoXTUKdqk220WRtVoJrx0lTidAfdN3Bjj9W7AdNQicFdWp1JoIaJpKTkTJex/qkpaZtZwLrUWDalakAXGf4444V++FhApSYwK6kNPbQwPFRfP3j8ST8fDQJAksgrrkQ1mVWmaYjT9cePSPpGc2KvaD0KoV5TExg9/5tEtrbQjS1kX8KtHGrzo6yaO6eMqf3xYPXQpVFFZss6YsEK/aCapBM1Er4MoAmbdtWk2zkn8Dmu2fKHN1HphuNncvGmZiQEGAnV6Yp2fHLxJPUIyv2Q5vcLy5AtbSk8HEiMkXjZNLCDqet5bBRUB1O6WmTZEqjn9kPVrwOMslNpM1TmithRiVK42qDx9Rv7SwehKvmtUZv1ithVm3i1m2cxTeBDNMWtDn3XNWe73so8/dysOL/hks1KaxoEqxoEqxoEqxoEqxoEqxoEqxoEqxoEqxoEqxoDjDyB8rpIriqW2BlAAAAAElFTkSuQmCC",
            } },
{236,
            new Items.Pokemon()
            {
                Name = "Tyrogue",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJwSURBVFhHzZVPbtNAGMV7BcQtWBHHdvAtiF1HAnbtJeqE3gGiwKIt7NMQ9jhpkECsKFSF/lFJUo6BEqge840xjaInZRJnMYufEv9iR09v5htvALAaKm2CSpug0iaotAkqbYJKm6DSJqi0CSpXwfM8lEol9ZX/vipULkMebJh+x/XRBcrl8lqDUmmKhKtWq2jWO+jvf8HRwVdEUYTe3jHKTlndwp9bBipNkHDS2mwo+d5qdHVYawLKsr54moUa98/1tSBh1xGSShN8r6KXd9jLQjJkP84/tyxULkLaayYdjHrnuqnZ5nKk1SiM1O38P0yhchESME1TtFSIsQo56p3pQLL/JPTskhdtkcpFBEGAyWQC13X1Pny5+xYfO/fUT8DgVTY0svTr2IdUmnA7JNny/msKg9cn/6daGnUcRzT9DxOoNEFaTPc+66bGisFBdg6Ky5tbx4FNpSnSokzyh60tfNre1sHiqGbPm0SQkGEYIqyGiDdjvbSeu773MpUmyDko+07CNZNDxHFNL7cMyTA90/vS93x1K3/eFCoXIa0922mjVe/q81CG4vd0guvBBX6+v9TXo74Kqa6LNknlImRAfN/H86StD+PDnQfoNgJMJ79wc/MHtXhTNzudTvVRNP/8MlBpiue5au89RPLoDt7UAzQey2cFnaSiA+avwSItUmmCtCjB6iqU49zXTUmr7STA7pO7amAiXL07RW//WPv5502h0hS91Go/yp7MXUW1+iM9xSj9BlcNUZFwApWrIoGlwXy5ff82+KpQWYRsgLzCzeVQaRNU2gSVNkGlTVBpE1TaBJU2QaVNUGkTVNoDNv4C8qVV0uoO4zgAAAAASUVORK5CYII=",
            } },
{237,
            new Items.Pokemon()
            {
                Name = "Hitmontop",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAMnSURBVFhHzZbbTttAEIZ5pcRxDo8R26QC+gKF3pTShyAOlSCB96BALwpctBwkSpTrSkW9bzldtFAhGqbzrzPYNZNgDJUW6RPJ79X688zuxmNEZDVqaBNqaBNqaBNqaBNqaBNqaBNqaBNqaBNq+BBc1+V/+rWnQA2zArnr62sqlUr8VR8jYGyhULglfX0YapgV3LTe/Erh1iUVneGS8iBBEFC4+Yta27/N+CyiapgVEdxtvySnOPpmMtZrfTMPBEkRTY9NooYPQVq3szQ9UtII1uvkeR55YSza79+MXCJqmAcILL2aoCJLaq3DdTzE2XpIgR9L/mFB/A2TvBPkQaoj6yvZOqnwybsm7XdmTJWl1YWiY64JMl+SO4GGW67EE/GkyKqVOPu+Ok/nGy1TmV2uUmsr3ggQwzXHKd5KiHSWE0ANk5RZDk98sr4QSbSOyA+e0claaL6LmOcFRg4tXNi6MBVChjUnYmlENJ0nUUMBEzQ//ORqXNLpRiT4dvuCmpvRsYLJy+WywbRtICTrS6Slten5s6CGAHK+71N9/gsLxWsLQEBanRyfbLURHQDJJxWs1WpmfXS7XSMJIFVHZcIjKleqPIzGKlw5VBE3xw5tjPM4FkL7b/p9On8/WBYsfF8rh6GGABVB6zDx4eEh9Xo9qlarhFyuf1x8QQ1sjPaMWXtn68k16dHxarRB8B3S2Cgyf1bUMAmqeXV19c9uQ+U+sRxuLHLLc5MsEbUYrMw9v60oWtx5PUmnOSTVMA0k5TMqh3bihqYyfIyYo4QlV95MmRxAWmQxDg+UR1INR4E2o7XLc1PUnp00N3bdktkgZwOh07UmHbM0JLGDxwPPyO3x5x+c/1dBgIpCss03LTkOHXw+oAa/qcjZ2JmdIJePIYxZ4TF4GDwIpGt8wKfnG4UaZgGS2ESQ8LmFaPt+Jzrz3FLRSOP1CmJYp/jlwfj0PPehhg9BRBf5RWFncdrI7DG+VzcZNlQeMUEN8wBRHEkei+HFAVKPERPUMC+yNlG19LW8qOFjwC5PZ49BDW1CDW1CDW1CDW1CDW1CDW1CDW1CDW1CDe2Bxv4CT/LzmSEVT6cAAAAASUVORK5CYII=",
            } },
{238,
            new Items.Pokemon()
            {
                Name = "Smoochum",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJ3SURBVFhHzZZNTxNRFIb5S2U6nY6JP0Bc9Qto0Q24IrIkcYstC1tYmGgMFBfGYMJHMYKFvVoSI9GNbWIMGheybyxNZDp9veeO08LkJJ1pm3IXT2b69LZ5cs/MtGMAlIaVKsFKlWClSrBSJVipEqxUCVaqBCtVgpUqwcog6LqOUCgk8b43DFgZBAq0rLw4XUE4PC6OV6MHDWdlULyR3z/Not0udF676/qBlUGhwFgshpcFE6cnw4sjWOkXCtN1rbN7Lq9WbyARjw3lumSlHy6P1bacHfPy4/McNO0arkFv3OHdDbT+dqPcEQ8jkpW9oMAXj0y0LvI4vFNENVtBObMBu+VE0Yhtuzv2QSJZ6QeKPEivy7ha7lgGurvYtlevRF5LoKEb+Lr0TsZJlo9lMIWW00VsFrqBg9zNrOyFvAYfbOHs9jJq2Q8isIILyxIhYXFtWmLsz2UoRW6uOI+eke6gaZr4dWsJR2LHziZyMvJmbhFhefNYcjcp8PRkDj+/3JOMfMTRaFRG/p7IovpQ7OL7KmqVmjPqGWf33BHTHd/vmFnpFxp1IhHHm/Qa3maKHSaTSXz7OAurlZdxhhERy/nv6AUr/UKjrte3MJlKIplKICWOiXgcjcYOpqacc21cE0v5z/uBlUGgXdx+PI/zPztoNnfx+tlC57z05D7KM0VooRHfxZeRz8MMPV6KaNRLaJ6XsPd0AXv/4/an12BEDLGU/3wvWBkEd8y7IohCD0Qo/bpQ8P70+kBxBCuDQpGRSERCf7vq9W0ZbIjX3rVBYeUgUCyNnfC+1w+sVAlWqgQrVYKVKsFKlWClSrBSJVipEqxUCVaqA8b+AWPzbWVaMV8YAAAAAElFTkSuQmCC",
            } },
{239,
            new Items.Pokemon()
            {
                Name = "Elekid",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJFSURBVFhHzZVNUuJQFIVdQoSu6i20pQNREmDoChQIOtd2I5YMeyNa1XMFXY021dVQDFTSNOr1neCLqXBaEiN6B1+RnPDz5eTdx5KIqIaGmqChJmioCRpqgoaaoKEmaKgJGmqChpqgYVZc15VSqWQO+fU80DALkLu5OZWgtyrlzXUT8fe9FRqmxcr5flP6nWXZTAi+R7M0TMtrgu/VLA3TEkpcrcjwwgmBIBoDrzWbBRqmxQq2Dx05PnBk0JmK+s0dub1VIni078jd1TcJRicSBKfS7xZlb7dhBE9keFn4PEHI9c8dGf0ycr2VCN+vh+1h7dnzPINCw3nY5h7uJ6al4owkGPWm2fDSkYr7QQ1CLBoCs/YggAm1x+DxcVbaDlDy+9JAQwbk6vV6uKbCITBSP39syd31ixxkJ5NZwX7XkfLGAgXteoOYFWw0zCA8Sw6MAISSwgDttb874i6yQQjaZiCHRwxh/LhtislhQHAjADdW8bJL0pARl8R6ij9u2yaTSl7P+q9Cw/9Rq9WiLcPzyvL77EWgaV4HRgitgkG3IK2Y3N7ujrRaU/Es2w4N54E2j8020/K3o5asnBVGw0f7BdkoTduG5Ki3lrlFGs4DTaI9SNUqrnieF52D9sFyOBTrz03hhv50iiIPgVkiXxcvCCAJseQ5Hl+zsR2K2r0P18bjsdluvsj9v79SrVajz82DhnmIt1s16zSeex7adqMsDTTMS7LdPNBQEzTUBA01QUNN0FATNNQEDTVBQ03QUBM01IMsPQGBxBws0BT/3wAAAABJRU5ErkJggg==",
            } },
{240,
            new Items.Pokemon()
            {
                Name = "Magby",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJTSURBVFhHzZVbTttQEIbZUuJctwDlwZcsAIgqVV1Byyq4LaIiJZtA4qVSnyt1B1yK1AJK5DCdf/CRqPUrduKIzsMnx78c+/OcmeMtEXENDT1BQ0/Q0BM09AQNPUFDT9DQEzT0BA09QcO6dLtdabVaRjkL502hYR0g8vv4WJ5OT+XXwYFEhWjIOu22Xsb/uwo0rAJyN/v78nhyYjIgS1P5U8gFNiFJwyoGvZ6MskzOtxN5KEkFQlXL/10VGi4D1bvW6j0V1bsfj/+pJMQuVDyNk430Ig2XYb13dCSPhdBrIBdkg2i7oSQNl9HT5b3Vhz9A5OzMRO6UsmyQbLrMNKwCknEcy9XVd5OY7qRyvbdnwiZeyP03QdDvd/WwkPv3YwMTC+GRTjMqvAk5QMMq0Ifz+SdZLA719IV+P1LfhYllyWYGBNCwiuFwKD++fDAReVZB5Tn/bL2I6k12Eole7YF4oXWFaVgHSE50Sn9OPho34xcxLDHE0ZdYdtustbKZ7pvrSNKwLqEyiQoByIWhCX14p/skjpeX3ySKtA3IfZZBw1VAhVCxLEtMxKSUMCz5fG7HN19igIdC5uJdqqeHNs04RwUhCklUFv2IF3nzJe50OvK16MMwLOjDUEmT1E9eWHLsn+V7VEHDOuBh6CsMCn6HYUHFUEXI3eo3+3w7Njn0a/kedaBhXSAWqhJ+Q3C6OzKp6W5mm3VvTTlAwyZAMs9zk53NZjIYDDTm19aBhk0JVcVeGbJ1oaEnaOgJGnqChp6goSdo6AkaeoKGnqChJ2joB9n6CxHcPEUnuhrIAAAAAElFTkSuQmCC",
            } },
{241,
            new Items.Pokemon()
            {
                Name = "Miltank",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJJSURBVFhHzZVNVhpREIXdEgisIBugOxPNFjLhbwMxbsIkKwAdxBMH+ZvojA6bCZEB2pW+T0qKd24jbaOnBt/Bvpxuv656VRyIiGto6AkaeoKGnqChJ2joCRp6goaeoKEnaFiFTqdTfPDv9gENdwVyy+VSWq1WcfkysjTcBiQajUbg+noqeZ4HQVxb2X1BwzIg1+v1ZDAYSJIkG9zcZBuy8b3PhYbb0ApCdD75IW/TVPr9fpBWIKxVju+vCg2fApJ/x99lcf5LRoNhkIIs/oacFW42m8Ut/Dm7QMNtqJwVg6iyb0kaltFut6Xb7cp8vJbK7+9ldvpFbic/HzO0XVtct800LEOHBBVSyTfv/8jdXb4hiSrWba1CwzLs2VNazcOwXhYXv8P17ONnGe7p/AEaMiCH9trqQca21sq9qqCtHM4XJGPRWC47+SSHrylohwMyabIW1YnFRKusVhZHIH5eFWjIgCQmcvrhLFRqPp/IaLSumF03qLKd9DqSNCwDkphitO/230QWi/M1F5trxgrWkaQhAztQFzSqp2Kz06KdKruS1GWtknXWDg1j7BnEP6MVXAmGF1i1WwdKl7UeE33uLtAwRgWzk4fzl10eF4LjIGUriDPJfvpQPYiNiw4MKlaThox4SKxkEL16J2mahJfQCdaJxsRnl0cyHD5M+4sIKiqqTL8eyezbcSFyFvYeXiAIFaL6idzeEz9zGzSsQiwM9BfHnr/nQsO6WOn4u6rQ0BM09AQNPUFDT9DQEzT0BA09QUNP0NAPcvAfgqYzGc9++HgAAAAASUVORK5CYII=",
            } },
{242,
            new Items.Pokemon()
            {
                Name = "Blissey",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJpSURBVFhHzZXPUtNQGMV5HcdV0z8Pgau2eQLFlxDdiE8B7BjcoD4AJd2AbNTnYMPIAgcWbfp5T/DgbTiBJKUzX2Z+YziW5sf57r3ZMDPXyNATMvSEDD0hQ0/I0BMy9IQMPSFDT8iwKYPBwDqdTrjV/78KMqwLxa6Pju32a2a9pBti/dm2yLAOkJud/ijEsq33Nh6NCtkYfrbf7z/I6iLDOkAQzaXjsY2C3J+jSSFLrj7tWzdJCik2DJq2LMPHiNcb7i8/7trNlxNbfP+1JFgGYm2WggyrKMY6m4Vbs16vVzxwked2+236QIig4fnZz+KekmsXTNPUJq/f2U0Ya9xMWRZyHD1Hjsbxb/m7q5ChAgsdcp/Pp3YSNgXkKEJiWQDBy53dpfXYdKPIUMH20FDczMWrl3ax+SII/xeLgTSkmjZHZFgFJNFQLAggWSWII+jwbGL5Ig9fcbd28V11kWEVEBwOh/frDw/P3mzLcT+HHJBhFRwz12E+n4fYbPr2w5IkD260jI2DC79zeJ5Z0l3TOUg5XNjF839yvGJJLgFsDjQMWRzmYC2bBHIHp8f3o4IgdifbwcWjB0K/d/YsHd29YZBhzGhvHMQPwn2TFmVYhoJ4AJqjIBoiECq3yrHGNJWUoYIvfDYZSyq5+IIoxShZd9QyfIx43JDEGGM5yMRLgVcs+ewjLgNJHDeqNUhBgpL4AzheiK3tTUIgh7cCRpuFDdHtJEWjlOAIOc62YkSGTwFJPJAP5c9olTuXR0tbMSLDtqh2y59pigxXodzuqsjQEzL0hAw9IUNPyNATMvSEDD0hQ0/I0A+28ReObXDN2QgtbgAAAABJRU5ErkJggg==",
            } },
{243,
            new Items.Pokemon()
            {
                Name = "Raikou",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAMXSURBVFhHzZbNUhpBFIV9HZMsAoOWqTxBSDYwbJK3iFkJ+ALqE1DsjNmk8gIY3Ihs/NlYySaVvAg/N32aHOg0B3XERVv1FTNnhu6v7+0Z2TCzpJFhSsgwJWSYEjJMCRmmhAxTQobrsLW1ZaVSyR3q60WR4WPZ3t62y4NfdnP0x7Jy5iJ9XxFkWBRWjXLkKSRlWARWDTKd91/t+vD3XDCvN9ZutwwVEFGThW2FECVxfHW4frtlGAOJ0WjkDs0qlYoXDWVxHWJ5PZ9LUXDdKsowhJWD4NnZmeV5buPx2F1ayFKO1et++ObP6/X6UhWxX/H5UGQYAsG9vT0/GYEgZcMcMpRj9UJBLObj7cjKWcUNreeLkWEIBGu1mjWbTWu1Wh4KdTod63a7HsjGDwlbzRZjrDfH57b7YzqXZIdwrJBhCAaACOUUXjaQC1scbwcI1txidm/HXvK+isqQ7zXA9sYVvDp85SRqc7lQyosNNm2/PfsuJN99GXqx6vHAfyKH5KefVlwQVePK4upx8pujHZtOFg8O8nAR48Ezs+FCEovFmNWToZXcfsQx5MgqyaWAcL9gtZyY1bDhC7Pp7LWDv0ajMb8nFONxJXuJ2/5bODsUnuOemKUAcCCsttlqz+WON0s2ca8bCOGcwjhnSylFkJXLZTfsYuzwmILMYmQI8OVer2dvTy68KJ68sCWg7sROT09n70YnGFYulmUVY0JhhQwBvoiXM6oDiXa7bdXPAy8KYbQ+lgtp5LUl6VWSdyFDAkm8A9lOCuHpQ/WQYe9hcjw0Wdn9xzmfVYt7DOeQ5PV4jvuQIYHg5cGOG3z2SsF+w/uM0pSDAKsT/2DlVrk+em397z3LsmI/HGQIMFG8ek7Ma2wd2qmeQtwHuclk4l9H+MQC4/vuQobcf37Qi+dLe8df/ycfP6Uh3CKoPMYqWj0gQwyMinD14apRFbR9ejETDNur4Fiqwg9BhmDVwGxbv9+X1X1qZLgKSK+7p4oiw1WoPfXY1j0UGd4FWrzOniqKDFNChikhw5SQYUrIMCVkmBIyTAkZpoNt/AU2o8syhlHu+wAAAABJRU5ErkJggg==",
            } },
{244,
            new Items.Pokemon()
            {
                Name = "Entei",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAMFSURBVFhHzZa9ctpAFIX9Op5JYSSgN7ixO0k0TonzEhhXmaSJXSWkAVI5eYPgFwDUGGhw8hQkKcCmAM/NnoWrLDsXIrA9s8U3EkcgfTr7Y+8RkdOIoUuIoUuIoUuIoUuIoUuIoUuIoUuI4f/I5/OUyWTU6er5SyCGEhDh43i8T9nsgRabnQaUVUeWzOVy4vmuiKGNKYXjdLpPpVJA89OQbgoFioKA6p0Oeb5P7dGY4j9T8v2sPoKnSIqhCcsNPh/Qw/1CDudRFFAYhprJZCHcGU0SqWYcU/f3w4rkLqJiaALB248ZujfkWJRhYbQIKcgxLBmVSvoF0Kz9jE2IoQ23aEsNahlNq3iYDDOkoijSzeIzn3O7LIh78v03IYYmuNFsNlNSr1ak4v6QWkdH9KgWCb3+Nxe1TG+oxEor59wuS/Kw28+zEUOG5eLBz4SLi/f0vVCkx/mcbpRgS4mxJCgpqcv6NVWr75TcHV01v1G4bJGb5OF/FsH27VCL9Wu+bg3naAQrmKXQninKkpCD6GXjK3X7P5ImsdrTLhgxNMFeBkkI8tByk3OjNW4IQK5xVqTmWUEThYuh5zkKQfs56xBDE24Rb99Tq3mdYOf8RIvUywup7vkxxdWTBAjustWIoQkEA6xQ9WAIYNIn81ANKctBgtvizza+90L7YLtyrB/e/7RokFco5qEpCGxBs80XEQSQrJcP6dddWf3FCGk0LNOXN3JbPMyQkhrdVlIMbcwWrxrX1Kt5SZPScLKkt5xzAL/HNdwDuf2MdYihBCQrlbd6b8MiYSRJCNqLgecyLxbz2ibE0Ma8ORaJj/9a1MrG0WyHsYeRpwjaY9K2KIY22AvxADRjbxd6n1SCPNek9vCdD2pvxGaNzdvzvJXrmxBDkzRvn2b48B3zxdIihia4MYYTb44GMKz2dZbbdn6lQQxtNr09rnHD2FqkIX4KYpgW3e5y+2EgucuGvA4xTIs9/NsugDSI4TaYw/+cQ8uIoUuIoUuIoUuIoUuIoUuIoUuIoUuIoTvQ3l/xIMM717NiJQAAAABJRU5ErkJggg==",
            } },
{245,
            new Items.Pokemon()
            {
                Name = "Suicune",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALSSURBVFhHzZS9ctNQEIXzOqGT/DMDpUs6S2qc8ATYDaHK8AaEinEaE57AccNPmYoMjY0bO26AvAjGi851jrO5XsdSxmHunflG0llF+2mvnD0RCRozDAkzDAkzDAkzDAkzDAkzDAkzLEq9Xpcoilb4daDv8WtFMMMioPHxZChvZmNJBgOJ4nhNpFaryadXE/n6eiZnBwOJo3hVK4oZboNyTzodOZ6OVoKQoQhEcd1pnEq70ZUPrfP/I0i5Z6dd2W+3V4JJmkqv1ZcvR1eSJpk7h9jno6mbIEQtSX4COtOY4SbwsGa/L0+7t3LcYgi+bLx3Epgi5XBOkIHoZsIAL3LfZM3QwpcD36a/JFXT0xIUtTJ9jSOE/X7EDDV8U4BJ7effnZaDcFMJaiiit5lirN8nB8xQAzG3jUmyFFTfnZajjG6Oc3yTWpo11rf9cMxQw8lBEHLuXMkh9789Nk+TZZ3T9a+L/KrN0AeSvhyOmKybbra+xZA5Gc3l4Cyv37zI5eSnfJ9dS6VScZ+M38fCDAkeQrQclhPOm1oTTJqpk3k3XuTIHcn5fC7VahWPMHv6mCGAFN4W4MEQg9T18yQvL5uiuS8AOCktOP+7cH9XRg6YIf6loEH34sI1xJELuZbDogS5vPq9JpdlWeFt1ZghBbm9/oIwBSmh14uPYzn5sbgj1+qN3HUUV3CL2dfCDLUgrrUot3G5hbdyuGYNC5KoYZppLohtP9yVIKCcn0EAjXnEohyFcY4M8Bfb6g1dDZSRNMNNoBEk0JjfJxZl9ZbjXv2S2BUtWlTSDC0oR0ElsBJEjroW84EoJB9NkNPROacHQb+uQf52+MfdG1eK/bsxQ59Ncn4dbJIDqBG/tgkz1LD5tskU2d6HYIYaNCR+jaC27SUeihmWhYK7lgNmWIbHnB4wwzJAivi1XWCGIWGGIWGGIWGGIWGGIWGGIWGGIWGG4SB7/wDeMdrUzpPi6gAAAABJRU5ErkJggg==",
            } },
{246,
            new Items.Pokemon()
            {
                Name = "Larvitar",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAF9SURBVFhHzZRBTsJQFEXZUlvahKlDh92CM7oL49AVEHcgrsKEoRMThq5AZQEOnr0/vPptbkr7aeAOTvo5LfzDa2FhZtJQqQSVSlCpBJVKUKkElUpQqQSVSlCpBJUplGVpWZa1S34+FSqnUlWVvf9s7OXQWF7MG0nlVBD4/Lm2h51gIOLuX9e2/W40A/Hc+fTkAhFX13V49uQCl2XRheHozB1J5SmKZW57ewrEcduv+SOpHAK3FRFxoE8Rt9tv+dUDHY87/kn/eyYRefT0s8ZA5RDY0KOcEHWzak//BXa+PZ4zTSpPgcjm8S7gMYiO4wBe+3VZnhZJ5RA+QWyOYxzpxBP261JvNZVDYCPfFEdfx4H9aFxzsUAQT/Gjvg30w3DO16lxgMoxYNMQ1P44ENifmn8BXHfxQGy4e9t3zxYi40B4P9d/71SoHEM8GV8j0uOwvmogA0GYLJgjDlB5Dj7Nvk+FSiWoVIJKJahUgkolqFSCSiWoVIJKJajUwRa/BtpNIFnjFg0AAAAASUVORK5CYII=",
            } },
{247,
            new Items.Pokemon()
            {
                Name = "Pupitar",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHESURBVFhHzZVNUsJAEEY5hluPQBDuwc9lMJxA5RTqCj2F6EZ0o+UmwEUItnyhmhrGrzJJhqJ68YrwAuHVTCe0RMQ0VFqCSktQaQkqLUGlJai0BJWWoNISVFqCyrr0ej1pt9u7Q34+BiqrgCh9zbKNdDpXxftTQ2UIRL2876MQ9/YpMhyOilU89UpSGcIPnEymkqZ3slxuj1ZStz4mmsoQ+OH72Ze8fvwWq4fA+WIrj88/RyuJ+PVais80HQEqy0Bcv98/BCIKpOlUBoNBQZblhzCcS5LO7qv8eiGoLKPb7cp4fCMPT9//wuaLvIjSsNg4QGUZur2hMI3HbCZJ0ngOqSxDAzFrus2YQY2FcyMBPrNaNZtDKsvQQDcAsW6crpyOAbb5rCvozqCLhmqs3tH+NepAZQh/FXUeZxeXst1sZDTab7+ewwz616gKlSHcOby+vi1WE8d5nu9Oy1GgPivP9hxUNFJXT4P9Y31o+9+vCpVV8J+Hbpy+j50/QGVV9IZx71gNBdj+mPkDVNbBjXSJeTi7UFkXRCJGtzf2782FyqZoqO9joNISVFqCSktQaQkqLUGlJai0BJWWoNISVFqCSjtI6w9jHVIbtxHf8gAAAABJRU5ErkJggg==",
            } },
{248,
            new Items.Pokemon()
            {
                Name = "Tyranitar",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKKSURBVFhHzZZNctNAFIRzJQXbhwA2ln0CCzayszCwibMjsAFygixhFzgFkA0pXyAFJ+DnAFbySI9oMbxqF4qsVM3iK5V7lJlWvzcz2TOzpJFiSkgxJaSYElJMCSmmhBRTQoopIcW2jEYjy7Is4Mf6Qor/g8bOvpf24dfc9u8lZBDmaCw2R9N8ry+kuI3hcNiYe3E+t3ySW57nTZp3kaQUFUjo+cfS3v+szc3fFHb242+Sk2ltlPi/74oUFSwtzMEkjdEskjz+VI/3maQUPXFpydV1ZQcnj5sUY6N9pihFT2xwcVJYtp/ZZrOxl+cH/6SJsePP/aYoRQ8Mlq9mYfHYkIcp4gP8HF2RogI9OB6Prarq0vpNQrBZuKP7KLUUPUgQC2EX42jhZkCaT589CX0HUygxTGOM7FpqKcbAHIxhMW/OpweDSBagHfroQykSlJWbAebK17OQ0KOHF1bcX9+ktmjKyhTxO/6YO02Q1xdMTqfTYADmVquvdvru2ooH6xsTi5Amey9OV5nDnHy26U8pxnAicnh4afNiHTh9W5tEkkwtThHEJjEXxqHxybFtSHEbWKCcfQkJHh19C6DU+XgSFkSKaAP0H/qwuqpsMBg0H8erktein18hRQXMLZfL0Gvl7CIkCHMAZWbP4YmjCC3B64+bhqnCZNvelKICBnnMYOHV6rIxh0VjE3yHOz4eh7G26QEpemAOG4UHNBYPSf4pJ9OjGZrkOH/fxhiRoocHNY8cJoIrDTqvQepMiyb5np+3DVJUIEUsEhOPofw0RqNIuasxIsUu+DYAffzTIMUuMGGYxNHCp3/vtkhxF2A0fu6KFFNCiikhxZSQYkpIMSWkmBJSTAkppoPt/QZ7ju8aEcCYvAAAAABJRU5ErkJggg==",
            } },
{249,
            new Items.Pokemon()
            {
                Name = "Lugia",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALcSURBVFhHzZZNUttAEIW5kn/3SXEBSd6QyiUCxYJQXIAKt0iykeEAVMEFMN6kkhNQ8Y4cwD8dvSHPaWl67MGx4+mqVx49SaNP3T0jH4hI0jLNlGSaKck0U5JppiTT1Or3+9JqtaqhfX7XMk0KcNPptBqKdLvdvYCaJrMGuJubsVxfj2U+X1SnXkBxzf+SZ/R6PQc2GAxkNps5QMJh3G53MPTu20Qx7eMZBNRgiF3AxbSPZxDQim2WVwOyWtb8tQMoBLgtOJa1LB9qFUJEAUIW5DYA9bwXF1dV1uZuzIgG1OlnxALqxtdjHocAQz1eO9BqQnICPDDU0BDuO/owlVa7u/ylr+GGw1Ftd8A4OoMQJsyyzDUvmjjPczdGhLKpIcY/JnI4uKt67dG9GOdCNHcIRGhOz4CYhTyvgzEwWSiLuBfndPa5ShEWXKi8kGdAGrAJdzi4l6Pj+bJ0IWEOrNTH7z+lUIBWrOpvzyDc2/y+mrS+yppwzBbGlnBel9aKVXCQZxCwHNZLQbh3J+IAuVj0QoA0NMa61DpQ9lUvR3kG9io8VL+0hkPZy3Lk/kCwfHwQ7+ULWHBccDFwkGfgIc2yvD8VB4xfZJZwi8XfDKNUb7JbyfLCLCkXFqHXlZYyTV0arjAcc4wHPXx7qgEicP78PPyF0PNiG+p01v/5ME1MdHZ26R7EbaG5FVj9xWsZus9wPV8KcP8ECBGAE1k9Y0Ey+LVAO+DFAEcwiH4VtTmbMk0KAKFmxjnscydfnmVWZe306y/JP03cWAdhiqKQ0R/IWDjINGPEkhVXEzn+/FyBvgBCzS0KgXJz9e8NkJAfjYWC/kQWARkLB5lmrLAlmVms9kqUk6tclzXUMiGZ5mvEPs0un5Yl1pCEe01ZtUxzE3HRYB/kl4KCvymkaW4i9iQy1tzfeG6vgBDLbfncL2M/cZRp7kIh+HUyzZRkminJNFOSaaYk00xJppmO5OA3q0qT0XYbLQoAAAAASUVORK5CYII=",
            } },
{250,
            new Items.Pokemon()
            {
                Name = "Ho-Oh",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAM/SURBVFhHzZZNctpAEIV9lfxs2FlCUFDJBbDZgHQCYjZxskhiL2zfwhU2BE6Q8iap5AL8bGI4BVgHcBIvQHTmSTQZhrYRWJQ1Va8QT2Lm05ueGfaIKNUSzTRJNNMk0UyTRDNNEk1T+XyeLMtSl/L9XUo0dQGOP58CUjRZgLq8LdH4tEb+pzeUtVMECLjat2c0DSbkn9ZpeFCkbJoS3FV6m5aKaOZyuUV6w/JruvlYSwSQ4fDithOvP9EEIKeHqU0ScPShRrPplBp35ViQosmAg3IxUUAIfTNk/edLsrL7ypafhUQTbzqZRNObNOCmKYrmYwG51ljmPQCi39l0shZSNNEJFkm316HB4avYkAxWqVRoqhJCcxxnCZbhHgUIYbBOZxXQTISF55E6WuO9Q3/GGZrNFIC6DhQImud5NFL96IB4AdVW+mOJJmSm6KpUfo8ydOdnyFGFrYPi2cu31hIUrhvv9mn8JUN/59dutbICuHWCEENW3QpVq1UaNf8PhoGzdrQC8Zx+D3B4Eb722xnyVB86XCKAEAa/nSenD9g4jhIJ60rB4Tug8Wmm53kyHNrWU8zCvgVAQOkJDcuFsC69ebIA+3xshVB+K/qOFwiTN+AYcOttxpReYwAcHERwOKMhHRKAmE4Gw30JLs4mDYmmJL3O/JMoOYaof38e1inuc61JYAwXJzmWaEoCIPY3DA64brdLrusuAK8PC+FKv29KdThX1eR925Up0ZTEiwXpXRWLFKg9D/8TGQ4AAJTS4wWBaUXS2K6wVaHfdRJNUwu4+UIBJNceErtWEKhJnK9oOCLxEoNSkfrdDh39eLGyVe0EEFsNILH/YYp+lQohwM3JUQjMgGj9fj8sAUAxGFY3/1Y1cSxToqlLh9NPEPjNZpN6vZ46PWbwlhoDYvXzpr4JGEs0dfE+aE4JfJy97XZ7BRJwEDycv4C0t4CDRNMU0jI9CD5WNqYQq5rBWq0WBUGgHonautPiIYlmHAHu7OwrXVxcKcCo1jCFEP4F6Yk+KaBt24tP/R7/9cIUb1N7LNGMK4BwatI9PeFtIUUzCTEg4M7PlxPeRKKZlB5KOK5EM00SzTRJNNMk0UyTRDM9or1/7YjAZzMTAh0AAAAASUVORK5CYII=",
            } },
{251,
            new Items.Pokemon()
            {
                Name = "Celebi",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH4SURBVFhHzZa9TsJgFIa9HUcoEBuvQDfaLlQ2N38GfxbRTb0B9C6MiwgDhKvQuJg4Eb0ARBb02LfNJ6G+ST8KCWd4AjzQ5smhp7AmIqqhUhNUaoJKTVCpCSo1QaUmqNQElZqgUhNUaoJKWyqVihQKhejpf592eaHSBkTUHoZScErRy6lDcHO4JcXS//A8UJkFi0MYnOcH0vzclvOOK0Vn8Ugqs0Bg9+lI/MCLJwbC9vgv7na84kCAyGq1KoPPngSBP/N40dmUm9HWUiKptAGBg2FXPsb9GBNnXoP+y6k4TjH6OD+HDVRmUS6XZ+IYiHv/6olTcqJD+HlsoDKL9PQMmKLneX+TXNkE4y3eq818pYibTCbR2xI9D+L3Fp0eoDKLdKCJq3fGMvn+kfphXXrPx/H0zJanz2ELlTYgErcaXGf1wx1Z372TWmsk4UESh1vQ3etA7t8+ok3OP0kqbTGR/ZcT2TkIJdwPlxoHqJwHROJ+2Hs6TkKvXQmv3GhZqvHCpD8/L1TagjhsM7YVU2u0XDlvJ4GDUbLlWJSVXIMG3BMRgCnWLl1pPCaRnp9MFdeoCU0fawOVecA08S/GD6ah+Jlb2RYzEImYs4eN+Ld4GX+5qFwUE5r2eaBSE1RqgkpNUKkJKjVBpSao1ASVmqBSE1Rqgko9yNov0/xdw2RSkhwAAAAASUVORK5CYII=",
            } },
{252,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{253,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{254,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{255,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{256,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{257,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{258,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{259,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{260,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{261,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{262,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{263,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{264,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{265,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{266,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{267,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{268,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{269,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{270,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{271,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{272,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{273,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{274,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{275,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{276,
            new Items.Pokemon()
            {
                Name = "?",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAZpJREFUWEfNkAtqAzEQQ3PnHiHnytm2VhiF8Ujr/SRgPxC0qlfz6GPbtqVjy5Viy5Viy5WixWTER4rJiI8UkxEfKSYjPlJMRnykmIz4SDEZ8ZFiMuIjxWTER4oLPJ9/GxK//gTxkeIklKuJP99GfKQ4gRNzieeXEB8pDsDh1+tlhUaJzw8RHykGUCxzRxbfxKTQJnsfKQwYZHBgj7OyeS9OfGgzvY8UhTyG4MAZ+NalbsapN+3T3keKRB1CcCDDgyP43Z4gEifVR4rAjSBOsB531DcuuNue9j5SBG6AySL5cE0m93WPwd32tPeRInADNfVglkAyuc8bObjbnvY+UgRuwKWKsKs9O6RuMLjbnvY+UgRuwKWK7PFzQeBGaqogOseRYJxUHykKbiynCmaRDDu3EafetKe9jxQGN5rDw4Ai7OrvNXHiAz0YLQa4AzgM+POREBOTAj0YLU6QD1GQjATj8yFtoveR4iIjwXhyiTbR+0hxA/63wDdygB6MFjeB4LdyQHykmIz4SDEZ8anFarHlSrHlSrHlOtke/3cbgn7KjtxlAAAAAElFTkSuQmCC",
            } },
{277,
            new Items.Pokemon()
            {
                Name = "Treecko",
                img = "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",
            } },
{278,
            new Items.Pokemon()
            {
                Name = "Grovyle",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJgSURBVFhHzZZNUttAFIS5TrKKCHbZS7yzWI3MhhzBJAcg5CSGG7hyigAncYUDkMr2RT1yh8erNhYgqmbxle0ezUyr3/z4wMyKRoolIcWSkGJJSLEkpFgSUiwJKZaEFEtCin0Yj8dWVVUmtg2JFJ+DxuaridXX00x1+H5GpbiL0WhkxxfHNr/qjEXew6gUdwGDSC4tkjVN87/E0TSMxr6vRYoKlHa+Sq25xpY33+387tKqz4dt02PZYXR2OctmhzIpxQgMLH9dZFMRmuRzNAmiSb6I1/YhRU80V1+3Cd52CUaDfD6a9EvhpclKkWDNeXOzH7NcXph6ePhg3+66NmXSl3xXon2QIqFBn9qfvx/t6OhTNnh/emZft4ZjX4D+TA/E9j5I0eNLDKNksziz++ZLNojfQ22KiBQjLNl6nux36oyRn3VjJ6vONNeb7+tT9HpfpAjUwNBSSrZpnpo8bc/EemvSGwW8cV6bsBQBUvODd5OlJwY2Lk2YxOHtz0i8DA/0OH5fpEhgEpMgHWwSTOonQ6Io+yI9GgNNe5jDWL16++0iRQBzk+UkG8ImwRHjJ+ESwAvAHEzxk8b8lch+Ea7vqBMpAt8xDuKTXZ80OUGWl+l1CXbLwffDOB4so+fSleI+MBHXI+5mbhB8X293Nc9NGKYZVGR6Ps3wz8W+0kuxDyix3zRYizhy4nqk8emyMwZ8gnHciBT34RNkArF8vIH4jG/jOH2QYh+4SaJO0M5NFtteghTfCtL0d/iuu7oPUhwCJlxkgkMixZKQYklIsSSkWBJSLAkploQUS0KK5WAH/wDzL4Pk2wJHJAAAAABJRU5ErkJggg==",
            } },
{279,
            new Items.Pokemon()
            {
                Name = "Sceptile",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKnSURBVFhHzZdNctNAFIRzHVhhJ/YBzCo2G428cY4AbGJzEsjKCSeAnIKfkyjoAMAuVQ+1Rcuvplo/YEHN4itLPYqmp2feU+XMzJJGiikhxZSQYkpIMSWkmBJSTAkpdjGfz20ymVSXenxspNgGzO2Lt7b7urPp+bSSjmOz2exgfGzzUmzDG1zeBZtMa0MA+l15cyA2fwpSVHhzBCb3D0djQKV7ClJUxAZjc15HsvHf/y1SjOkyh/uPq2C7z9vD9ZjpASnGeIO33941xkIe7EfxxMr1xt5UBsdOD0gxBhXqiwD8LJ/axfkz++4Mjp0ekGIMErz+dN1sLdIDj/fBynxjL/bhn6QHpKhgnyuyjZXhquF+GWxVGcx+bzdSjf/2FKToQXq++fIeRmkO6cHg44dgF//7DHJ74/MFPcsyW1YGt1/qAoFJNm7/7ClIETAp4A1Sv9xntni1sMvb7GCQ55KVza3m87j294R6G1IEeBFNZKFOCkUAjQWBCWAexhav6+e2VTXDJA2g+rE43uN5jOO5IVUvRcLVsgd6YxzHhNABF0OTWBSqPl/njebH+C6+TyFFD3sgVhufRYwxUZ5DmIQJXNNcCKEBxnBWcY3nsPCuJKUYg6T8L69hzp8/pgwDPjF+fWiWxjDelR6QYh8whwrmRB5M6j+LPkFvjGn2NXcpdsFzh6IoQv2Jo7mH/MrW1cQwCGP8VcbYkuL3x0ixC28QLabIj18WNO7nL49V77faGxuSHJFiHzx/7IM4d0T1Ri4G474LDEGKXfD8LaqkMCkMsVUQXzzeFIjf14cU2+D2YlK2FbVVTLht/E+QYhf+v7euRNgjmXA8PhQpngoTRKNeva+qufod8llTSHEMYHJI0n1IMSWkmBJSTAkppoQUU0KKKSHFdLCzX4fPjRfVnSfXAAAAAElFTkSuQmCC",
            } },
{280,
            new Items.Pokemon()
            {
                Name = "Torchic",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGwSURBVFhHzZU7TsNAEIa5jiUKHD96u4PQADlBkircAuGGkscRuABXSeSGR4XIARCkMMngsTPKxvoF3izCU3yy9TmRPo3Xu3tEpBooNQGlJqDUBJSagFITUGoCSk1AqQkoNQGlK1EUke/7Fc1ntkC5C3Ecl5f6Wjx6RC8ehcFB5VyA0haJ4iCJm98nFPTcpwilLebUJG71/DdThNKWZqAZylNs/t4GKNvCYfwK3689Wj15lI/LyZVXDhucnXT7kXAchy1ua/JRQp839TUfpdV91k+o18UajONoK+4nwl4Ha5D3uaIoaHG3D6NMeKKBwxSh/A1Ze9Ph5nWiOKazQI57m01onp9TdpzSx/qVr5YFhWFYLQFZj/8eyHDkw5W/FTkbpjQ4rb9ema5LHANlWzjy4jChy6M6joNMOPZrfcI0/9sWKNvCgbxB876Xj+so2QflJHHdrKG0QaYoE8zKaS6N8zjrp057IZS2NF81R8p9p2vQhPfG1+mEgmDzgXBoJycJgqcoZy/fS6w83xUoXTFjXYFSE1BqAkpNQKkJKDUBpSag1ASUmoBSE1BqAko90N43xNFEF6D/LXMAAAAASUVORK5CYII=",
            } },
{281,
            new Items.Pokemon()
            {
                Name = "Combusken",
                img = "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",
            } },
{282,
            new Items.Pokemon()
            {
                Name = "Blaziken",
                img = "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",
            } },
{283,
            new Items.Pokemon()
            {
                Name = "Mudkip",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIDSURBVFhH7ZW7TgJBFIZ9DB/DhYV3UKsdbPRNhNgoNl6ewlh5KVSeQGOjsUFtVBqNNkYLb8WuHOcfM2QjP2FZ0JxCky/CxwY+zswOYyKiGio1QaUmqNQElZqgUhNUaoJKTVCpCSo1QaUmqByUcrksQRDYh/z1YaByEBC30ozFNB4kKBat4tflhcqs+Ljp5TOJDu7/AwcmvbxTdRtpKiPfi1RmAXGTiyffYXZ6PtDs39FJ4vo88VT2w09u7VI6y4vA6tGNrF60pXbckkIqEtfHcYznEoYh/nW9Zy+o7EWpVHJTiPbuXAgCAZY4/Rz4SFyPuN3Ws+xY0uFZoJKBuJfFQGZMJKvNRD7bIuupoDQINpUZMcZIkiQurrZ56SgUfikQYKlOZsdl/Ty2kwg7ywx8MOJe60U5mxuXiv0yW1ePLmz75ulvJug+eP+2a0l98NtyKB/1oAMm7iP/ZILYU5hiO4llwe4z07jvxPrpIcxPEMtc3WjmigNU9sOH+jsTf9hn7o62R82p/QLvSxNuev7YyXPEACqzgtAoimRq6bT7PLSTQxymOswvDJVZwb7EYb11/X0DpM/Efgd3VqjMCgLnD6/cPkQEpumnhmMGy5p3aT1UDoLfj3jsg3/+kgwDlcOQDh4FVGqCSk1QqQkqNUGlJqjUBJWaoFITVGqCSk1QqQcZ+wIMNGCBBqsvigAAAABJRU5ErkJggg==",
            } },
{284,
            new Items.Pokemon()
            {
                Name = "Marshtomp",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJKSURBVFhHzZa9UhNRGIa5pd2QHYfSsZFUu5vGcAeLDYQGQqVWAg0zXgXS+NdkqPy5AZEmPzehg4XK53mPfDtnMm/iLpvoVzxzwrsweeb7OcuaiJiGhpagoSVoaAkaWoKGlqChJWhoCRpagoZ1aLfbEkVRyezzptCwKpArdp5IlmVS7D7157IlaVgVJogzimP3mP9NXWhYh1VXkYZV0flbZRVpWIUkSeThqzNJ87wUU/67IOSK0Xs5uplI1u16qaOfIzmWqXTenXvpZbWZhouA3PMfI/klN3LihCA1y/b0k2SHe0upIg3nAbl0f8dVayzxesuLqlQoDMHNt+cStf6hIOS+7j+S74OenLh2XnYf+FMFQ2G0+dtgy//uetys1TScByRP70XSeX0mxeSjn0FUCyeEH7u5ROUgd5Xd97QaziINF5Ekbd/m4fhSLqZXcuzkwraGgtcHfyrepIo0/Bu4/9I0leHos5cMyd1yZIO+k+zJi41I4tsK6p1Zd7tpuAh8Ee4/VCp1IptvXspw8qUUw8/I8Vm3WN822/1nnjrbTcN5+C9yc+avkW4u2cFu2WrQuW0xwIzixCaj2uFlXqeKNFxE2CpUcri35WatJxf9nl8erWwx/lDOJS5ufcOstIIh2mq9TgCTxIZjifDGucsrkIZVgSQ2GgsBOZC7tkNMJbWt2uKVL0mIVhEiqIy2XedP/5HQttaVAzSsg86kftYN19dc+Pwu0LAJTYVmoaElaGgJGlqChpagoSVoaAkaWoKGlqChJWhoB1n7DWf+IVjwwf10AAAAAElFTkSuQmCC",
            } },
{285,
            new Items.Pokemon()
            {
                Name = "Swampert",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALmSURBVFhHzZU/ctNAGMVzJSmxJ56kgaEhk8aymzBUDhdITEPoYvsCgSoDVezKEwr+NIGcAIeGDCcw8QUgKYjzobee51mvv1VkkGe2+I3lJ43027fa1YqIBI0ahoQahoQahoQahoQahoQahoQaZlEqlSSKIoN7bhmooY9yuSyNvWM5ePVRklrNK4nrihqEGvrAg18cvTdyjf1jieI4jfVrdptvzEDieHXumkVQQx+uICRsSUy/fT5J/C3nRQ19/Iugr+m8qKGPLEGfnDuIRVHDLFwRClSrVTk4+jAn6E4zdwH+vw81zMIW3DkZSuviLj2uq3K+V2CRVtVQgyMHaIty7W8yI5gkicHXHgXdcz7U0AU3/t54ID92H0o9qRqB1uB2To7Zk97I5D65QgWxMNgaxIatijztTtqDyO34TkadTekM/hg5gnORtQe67aHhPNOshgRybI7tsSWw9fydecjwcH0qePns0cz1bEkTzNOiGtqwQXD4dbYl8NNqD3JXacPX3YqM2pPfm15F1uJoTo5TfV+LaugDLWCq0SKmkIuEQPD6ZCJVr01eCS4YfPZcwUIatIHg472+VNMb21MNMN3I+Z6iPRxjtWPBcEptORwX0iDEMFK8a5i67Wbf3JhTD+n+5y/y8vWntNWxEYIcxHHMVU1ZtlrIFEMONx62N2bk3Gv6Z2dyen4+lbTbhRAkSaP51sj9tyDltpqnstO9MqPnO8NW7QYhSEnui797m0bQlmSLvFcWakgowamx5bj9bO/3zQAAJWuWHBYMW8Q1fE/zvH9ADV0oav9Ha2gVjVCQD+cq/9XbkM7FZAtCjlcEe6ORy9EeUMMsIIdGOV0EXw08FHslVnRrMJ7+sj3ujdgX3fv6UMMs2KbdID9pPMe9Ml5dM8IQ5ECw2PCpXFqDhDLag3jOPkaDHBDJI6mGywAyMztC2mpQggBCNu55DTUMCTUMCTUMCTUMCTUMCTUMCTUMCTUMB1n5C2tmkiTWBid1AAAAAElFTkSuQmCC",
            } },
{286,
            new Items.Pokemon()
            {
                Name = "Poochyena",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHCSURBVFhHzZRNTsJQFEZZgttwWAgswBVY6gqcScuqACfEFTjkZ+LPDlyFJo7ItV+Tj7y8fH3QouYOTrSHhnfefbQDM3ONlJ6Q0hNSekJKT0jpCSk9IaUnpPSElJ6Q0hNSphiPx5ZlWf2v/vy3kTIFAjebFxuNRvXl3wdLmYKBq9WTDYfDJi4MjplMJvWf/huRMgUWzPPctttX2+/frSgKm81mzXUciXsZn9pECinbwBQWi7WVZVVTNlHnBGIjAJ93naKUbSAQMYgL4TTDYwfYzG73dpy02sQppFQgDkcbBi5vMvt4vrK74vYYyRBOjeGMj7/3FFLG4Kg+73N7rIPKOnA6nTYTgvv+urb5/OE4SYTgJ8DIqqpsuVz3jpQypu1oFfH0wkged5djllIRHzEWPBwO9fTmrWEEgfxdgvi7U0jZBiK5SDjRVBzp84oBUp5CPTBhJCaGaz4wfBV1nR6Q8hwQyXdiPEEEIprT5mb+LZATxNNMGIlpMYz3ctL/GhguilhOk6+g+P4+cUDKcwgX5UT7HmMKKbty6TGmkLIPlxxjCik9IaUnpPSElJ6Q0hNSekJKT0jpCSk9IaUnpPSDDX4A4Jcm/KkzDxUAAAAASUVORK5CYII=",
            } },
{287,
            new Items.Pokemon()
            {
                Name = "Mightyena",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIFSURBVFhHzZVLUsJQEEXZjuUIKFiA5QYCO3AXgewGcKKugs/Ez2ZUHD65qbqxaW8g4VPVg1OGax590v1e6KSUQiPDSMgwEjKMhAwjIcNIyDASMoyEDCMhw2swHA5Tt9vdXe5fH0OGdeCLfdYErMvzPPV6vVLMXvt7PTJU2CI+t589XDcajdJkMknT6bS69t+lkKFiMBj8E0S2XL6mfr9fZRaugZSniRyQoccW4hdTbrP5aCWI9U33H5ChxRbBaAAKUG48Hh8syBHbh2uDDC12D61Wb5UUrvGXwn4dwFr8D+tPkQMy9KAQO1YURdkNCs5mT7KLtnOHHuIYMvRQ0MpBlt3EiaQEoZzlaiO23YPc4r6fvr9udtnfPqQkXyWeU7soQ2LlCE7s50OWfnaCRZFXo7bvOI+VbttFGRKcYMg83nXT2ohut7elHIW8HPblYvFSsl6/lw+AnOP3dQ4hQ4t93/k9CAEW54i9HB8Kn6+yBwEk+fQ8LPP5cyVCSSsH7MPgnovvQQVkvQg6ZaW51yCUZdlehy8+Ygs7yaIQtWOEJMV4PzpuD9FFD4mFxbgPIcjOcIwUrFuH++p+t+uQoQKF0Dm+VqwghCmtRsjOtx0vkGEdthDwHT1F4BgybMq542uCDNtwzviaIMNIyDASMoyEDCMhw0jIMBIyjIQMIyHDSMgwDqnzC1M340mpCU2lAAAAAElFTkSuQmCC",
            } },
{288,
            new Items.Pokemon()
            {
                Name = "Zigzagoon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHuSURBVFhHzZRLTgJBFEWZupymA+uQhomfFSCrUJmou0BHRAc6w+gGNGzAz0h0IroASMq+ZW6nrNzGBiV5g5OmT9OvLq9eUXPOmUZKS0hpCSktIaUlpLSElJaQ0hJSWkJKS0hpCSktIeU6aDabLkmS/KN+XoaUyxIvru7fXx5cmqaFq4qUi8BiuDYaDX/l4v3erqvnoRAsDMPnn2/P3uH5Mp2UsgwsNjjquno9Ka53o6Eb35x7+r0dd3rcddPJYxGo1Wq5QeDo49plSFkGAx7ubbssyzz310MfjPcIc3ay52GoTqdTeDh2Mq6vkLIMBNzvbvkuYbEwKAK0o5BhQPiD/F38oI/Xp8pdlFKBmUP32B2CUGHXeI/wYDr5nj+EREDOaVy/DCkVCIh5ircxBOHYIRwaBgzDxXV/Q0pFGJDEneNpZTiE5QFK03peRtdehJQx4fZyzubz+Y/hDzuIQ8Mtxv2q4YCUMewewjDgVbaRf94sAjIcO9Zut/33Vt1aImUMAoanlyHjWQw7iFCj0WXue/7/Mq5ZFSkVCInTFwYF2EaEDbvFU8p3WGMVpFwEFyXYem7tX2atDCmrgrCz2cyNby/WEg5IuQz/sY2LkNISUlpCSktIaQkpLSGlJaS0hJSWkNISUlpCSktIaQdX+wLHTiQluXEd/AAAAABJRU5ErkJggg==",
            } },
{289,
            new Items.Pokemon()
            {
                Name = "Linoone",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHmSURBVFhHzZZNTsJQFEbZEq2wDygT1I1AuwRHCCvwZyMgE35WIXGicaDoBHPtR7z19eUT2qaYOzgJHkp7ct97YENETEOlJai0BJWWoNISVFqCSktQaQkqLUGlJaisk3a7Lc1mM8N//xhU1gXipjcj+di8yOfT656zMEzf4tczqKyDVquVi1vP1xKWjANU1oEfWGV6gMq6wBKPBn3Zbp7tLbEeDkxxHJ9nkfP7iYRBkF7CP+dDZREQwJye1rfH3yA3EEySSwmCYieaymMgBAG6XNhvbpSicf8aqHF4UK/Xy8IQE0WRjIb9LIrFafTJA/Gg+d04i4i6XXlPPaI18uH2OneKy8YBKv8CS6lxGubG6VT1tYv7mZME6veaG+ZPyA/RpcWe0+tXDytJkiSNLHaSqWQgEN9pRcLcOPyC+NQeqEuLSWicPszdhz6r2TILWnqvi/7sUemjgTothH7tdrkDEcdDmf0socZrEKaF0z4YDErFASp9EIibb9PJYSmjq5U0g1A6nY7M0n2pUe6kxsnF/jAgzL2P+3cRqGTozRfTRW5CCuLiON6jE/PvUQUqD6GhCiaLKJ1clX+pDkFlGXR/niIOUFmWKnurKFRagkpLUGkJKi1BpSWotASVlqDSElRagko7SOMbp6ZuhanSlf4AAAAASUVORK5CYII=",
            } },
{290,
            new Items.Pokemon()
            {
                Name = "Wurmple",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKMSURBVFhHzZTNbhJRGIa5JZhfttZV040NNRaoiYL3IJRurBvtqhTYC3gBbV0qSWuB+HsfDX8RmBFq7ev5Dk6lzceUQRZn8STDw2F4+M4cQgCUhpUqwUqVYKVKsFIlWKkSrFQJVqoEK1WClSrBSpVgZVAMw4Cha+KSf/9/YGUQKO7XUQVXxxXo2vIjWRkEy7RweVTGz72X0CIRofh1i8JKP2himhYWlwiZNL3jMty9XfQSaRhhRQIHgwwsS8P71U38FttLcb14CrXVOCLhSbyHZRk3XgeFlX54gc4wg14yJcOm0aYCvbW6PpnsIrGs9EN+6Y8MmsUVdBNP0Yk/uRE6vc22YcrAjY0H0I0IhsPsdey8sNIP0zTQeiTCNikuhWbhPgb95+g+ngTSNtNhoUm2xRq3n0WjeA+uk5Wxtm2K2/D35mDlLGh6BwdZtMUzV1tLoFTYhuNsy6nQl3uTfLi+LtaI67/PZjO/gr74EUHjCFbOggLb7S8oFnPodL6i1/sO192BaWoYim3vbv2Lcl+/wNW7qnxN09ZvHZ55YeUsbNvG+fknNBpVdLvfZCCFOk5Oxrmvdq+jKPLysIzOVhofxLabhi5uwd/XD1b6EY1Gsb+fQav1WcZRLE20ILa7k0zj6nDyt9MRW1xbS6J+WpHvj8dj8SgEj2TlXVCkaZpiKoaMpbh6vYqzs4qY2DNxutOof6yI+LcolXaQz2fF/6ZYLz5z+153wcogWJaFk5M3MrBUyslDRKFe2MXFYpPzYOW80KEZjUaIxWJyklwYrVlkch6snBfaagrwIihyWWEerFyUybO5nDAPVqoEK1WClSrBSpVgpUqwUiVYqRKsVAlWqgQrVYKVKsFKdUDoD7mCWBFUR5+rAAAAAElFTkSuQmCC",
            } },
{291,
            new Items.Pokemon()
            {
                Name = "Silcoon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJUSURBVFhHzZVJTuNAFIa5UmZyBMQuA0LqXbOCmzSjGHONZorEggX0xCy2iOEEXCA4yaP+Cs9trN+BCiC9kj4Zf67U+12DGRMR01BpCSotQaUlqLQElZag0hJUWoJKS1BpCSotQeUolEold+HPPgKVoSDc+e2tFAoFd8v7jAqVWSAIC5EMmMvlXpHuGwqVWSBIp9ORcrkcB4Vb2tiQRcfen0vp9fvwvrX/XsWhXYvHCAlO5TBQ4PTmRtr/BsWjKJL/kQYNwfYdGjYZFP2LxSI0HT8NlcNAwPm1Nen1eu52UFyDqNOGZ5hZoM9CwgEqs0iHYzOHlvT6Aho2n89D0/EZVGaBgFgiBGyfXEs/sd+0YWmTy4uGcJf3997r3n0vVGZRqVR8QJ0VbQisdwiB4DqbaEubm/4AfWlAzB4+Jd3E7HW7XfdIBqf35bBgGSPn8QIIdPXw4K96yr88IIogJNpKqyVPLhiKH05+k6jzJMtbLd8HS6qhNGDo/gNUMhAQnxcs18XdXXxQULjkCj9+n5VGrSa7vy98oOSs4W/8bpQPN5WMstt/i+vr/hTrDGH5mlNTcjAxLY8zc9JoNOKAuCLUzvGZLLjfqceLpsceBpVpMOjPo1NfpF6vy7YruvsyM6DZbPpweo9+GqoyPu7/8wDcg5B9SGWaarUaF1F+rK7Kzq/zuCiC6T3C4cSjX9Y4ST8MKt+DFsO+qrm9t+1mGNsgNMBbUBmCLj/CpZ99BlSGgJkM3fghUGkJKi1BpSWotASVlqDSElRagkpLUGkJKi1BpR1k7BnDrpy4y7gIbQAAAABJRU5ErkJggg==",
            } },
{292,
            new Items.Pokemon()
            {
                Name = "Beautifly",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALOSURBVFhHzZZbjhJBFIbZEnd41PgCM2PkZsKrbw6aQF9gH+oKhIxrGBpmAxqHy8AeNJn4bgPH/os50PQcpGFAq5Mv3fXTpL6cqjoQISKtEUOdEEOdEEOdEEOdEEOdEEOdEEOdEMOnkEwmKRqNeo/y5/sihk/hvwrumrxSqWx8fgxZMZTAZIVCgZwPzykeezxpUI7H/1Sw0WiQaZrkfNyUDFbqWHJADCWCgqVSYSXhF9m2rJwH39+FGG4Dk9TrdU+uRMVikQzDUMIgFov9VcztZoj62RWJeDhJMdxGOp1+JIZxGDHbWn9n5oSXFEMJTDibzci2bbIsy4sogjGuRCKhxgze9YtxzoIseTRBNaHrEi2IWq2WEuVr7mXIWZLluGL3Zo1+eVjmuoIAWwLv70IMg2DS3OVXTww26+vVF6JcZ06zOdF0OqV4PL4hx0Dy9IJtV4nwdX5Fanz+/juN7ybU7/fV4cH+xCmf95b7jGWxpPwcVg6IYRAIDodDtcyLxbKKF55gNJakfO0bOU6fut2uEkQjZ7mbT89U5fhQQHAfOSCGEpBEixmPx2o5X17NVfVyn11yejdULpdXckrMV7lD5YAYBoFcKpUi3K+vr72KOdTr9RT41UCr4SbuB3JcxUPkgBj6yWS8duEbZ7NZ9ZuMVoOWMxqNlCg3byVrmBu9Es8nEUTFcEeV+JnzwWCglrrZbCoBbuD5zozy726pUHq9auLBPrkPYsiwVLVaVXce4w4Z7EeASmIPIrto/6azjktn7TkZlq1aD75zKGLI8HL6x3zHXsTyoUrYk5PJRC3zz8Yl3b55QU1v3xkPve/Q5QVi6AcyOCBgW84Hhw/Sj8ZbujdqZHtyODwnFQyDkn1Yfh5DDEsOaenPRFjE8BgsK7yUxvOhkmJ4ClhyX1ExPBWQ5E4QFjHUCTHUCTHUCTHUCTHUCTHUCTHUCTHUB4r8AYdW6J17OhRVAAAAAElFTkSuQmCC",
            } },
{293,
            new Items.Pokemon()
            {
                Name = "Cascoon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJmSURBVFhHzZVvT9pQFIf9SoBt4WvQwt5Lln2GTfdFaCHx7z7HlJlMgcSgvjeKZG6yJQvTxc2zey5tvV5/1aLOnBdPaH+X3PNwzi2dIyLRwFASMJQEDCUBQ0nAUBIwlAQMJQFDScBQEjCUBAxnwXEc9YHXGF4vFArqEq8/BAzzwsVPBj+pVJpXt3fXWCxrPS8wzAsSNMVGhxdPkmNgiODCpWJJXd7Ojg0RFttd/UanB7901lpqUbFYfJkRs8zRx9/kOW5atPm2ScP9iZZpv2+n1/3177eIFqei9p55gGEWeqRbV7ozw8GEIv6MpRAsx91MRO0J5AGGWbBg0jUuqEUtQS01uCs52r5OR27vex8wzEJ3UJ25033VlQ9jGh3ciJj0N2Ipvo/Fhp2/j+oiDLMoe54WTLtiSHEnzcyUYvgc9tbO/59gcv64a3b3+Dy2lyIlEcWiU0EW6q+PX07wePNKF+ERJ4Is13qzTZMFn1qNDvlVn07U90yp5PoxTzIMESy4s3w2Hd3Wn3iclxQ2PtFwr0sXr4NUsKv+C03B7uq56nCbnHlXbYX3zwKGCM8rU/gupKZCd7FzrR4AonrtFf1YqNKkUaWosUk1v05dQ2pn5YxCNfrdla/UU9KzSsLQhrv3efmLLuz7gS7KxbhLTC2oUxDUNIlcuBhqqXK5Qq7rapI9Znn9wdCmUrkpYhfrrfFDMNYyWk7BHXPVG4d/WNY+Zn4fMMwDF9OvOzVy7qjZKdcSewowzEsyepaz154LGOYlGZmdPycwlAQMJQFDScBQEjCUBAwlAUNJwFASMJQEDCUBQznQ3D+4Josmu7jLwwAAAABJRU5ErkJggg==",
            } },
{294,
            new Items.Pokemon()
            {
                Name = "Dustox",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALQSURBVFhHzZVLctNAEIZzHKwVlh/gGyATqizJpnB2ieEAiTlBkkOAH6lKbGcPhAUQDpCy8R0Ifmx4VPFcNvOP3PIgOg+7DDWLr6T6R+X51D0trxGR1YihTYihTYihTYihTYihTYihTYihTYihTYihTYhhklwuR+l0WpNc+9eIYRIIfhulaNiuUsa9XHLVLyOGSUzBn+MUZTM3Vfz3M5DCc7+m8jPLIIYMb+r7Pg0akRxvblYp+QL/VXC7U6V6b4OCMKDvSqL9qEPjziea9r5Q++ExuWmX+ob8oseAX/IixJBJCja25nLg7f5LCoNQi0Ps6wfnwsrhtzJZV7PTrWrwu+4VLyOGjCnIkqPOx1iOBdH+YWuDQrVuViR/a16pRt+j1rAYU++tQBBAEmcwCOZypiBLYv3N3gt9DyE3o6QGSqZ/hw5wVVK46vt3KxZEFaXqgVatF3O6dxILs9xk3aHx3RRNiymaFG/oa/PM03LbRw8op6qc3NNEDE1MQVRo0v38h9iPkaPPH9qLdVNwvB6JHZxFVWTZStnXXcnn82oLeV9GDJNwm1mAJXg4MMFltSmvQzwpObnnaNoDT+UeZXOu+ml5PxMxTJKsYlwlNdXJCiLHeQS6zcZg4OwtMiBADCXMYeGB4EqZAzJS1ULFyupZs4KgPZvkeld9FRQrFQRmq3kguKWVsELnnhPLBX4Qt5kriNaieujESs8gUygUaOTNqrN5RM1aV8tB9vXuc7qvNkY1UcWyuiIzJR8fR99TkL99tRwQw8uA5PuZJGRe7T6j0/0TKodlOi9iSh0t16x1VBXRfl/9a0RS+Kzg/rpyQAyvApJoDzDPJZ/HJ5uHqnrRmdxRw2WKXaetJmK4CKbs061DLYV7/JuUSiUlV9Uf40XFGDFcFpblewwV4PVlEEObEEObEEObEEObEEObEEObEEObEEObEEObEEObEEN7oLXfZ0PTUmX6rGAAAAAASUVORK5CYII=",
            } },
{295,
            new Items.Pokemon()
            {
                Name = "Lotad",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH9SURBVFhHzZRLTsJQFIbdEpRW2IXcigOHlDDCAVQHatyErxWYGGPVGKMTEwdG3YPPmdEFmOgAOd5z60XAn1Kq0TP40vDdPr6cSztBRKKBUhJQSgJKSUApCSglAaUkoJQElJKAUhJQSgJKSUA5Lq7rUi6X+8bgeVmAMg15J0+WYC/4Ri7/j4HupNsXo+YV+Qu+QYXq1+IYKJPguOZ104T483EUEz6EFN6HZqLdc8HW27W0QDkMfkDz9iuutl+LwzQ8SRvrFBwTU92txhP2FbVuW33xaYFyGCbwRgfOKAqigMK70ERabCx7xq/oLVdxHIdm2Xooh2Gn0rprmYczNsbC4d21nun+SWCpVKLqTrxt9uE2ppdu2L4O08FM1hcHyiSKxWIcGdX6QnsxE+N1jZqe1nGOvhTfbxRQjsIt6O9fY6MbUT+o62PweYwdrzNqfY+cuY1MbzADZRL86Xh7rlBlM6JCY91EvHeI2POxN2xqNSK1FtHS0QV5nqcvx/dMAsok+H/Ybrfp9UnR2fasCV05uaRO552Wj69MmGF1Nw7VbzHHD94nLVCOgqfx8qj6ON2aNdPi7TTTK5dp8fCcvB/EMVCmgSMRvJ0c6k0Wze/B68YFyp9gQwd9VqCUBJSSgFISUEoCSklAKQkoJQGlJKCUBJSSgFISUEoCSjnQxAe/Aikhb8iE8QAAAABJRU5ErkJggg==",
            } },
{296,
            new Items.Pokemon()
            {
                Name = "Lombre",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJZSURBVFhHzZa9ctNAFIXzSnJs94Q0MTRau4lKmzSGBkhD6DC8gJ03yMADwCQvEaB0w08VhgcgmRSOuejIXGW9HCuSHCa3+Gbks/Lq8927K2+IiGloaAkaWoKGlqChJWhoCRpagoaWoKElaFiVdrstURT9Q3hfHWhYFhXrv78ng+OtJaLNOxJUKb1Wuc5+LJ3nLidq3IEghMZf+nmFILrzdCHW/7Alk299Ofw+kIZXvVarlS+5omNloCHDlwurNf66EMOY68ZLMlph5Pi+L18GGjJUsNtLpZ4tV+zB/rKon8XOiUvxKx/OXQQNGdpvkIIkHgpRv5KQ1mphXMW0uv9VEL2EfvMrp6KMUKyOHKDhKlBFlcQDVZThi6Fn6+5qGhYBSTR/HF+LrsLfMOE8ZaHhTUDybGdXejFfXgU9uu55SMObUMGfnSSjd5TI1fxKms2mzGYzmU6n8uh4W4afDtK+a6Rf4fOUgYZlgOSrX2N5fXkoPx4m8uZ8IvPf83RIZO9kO1vi23jd0bAMEEQfuqNdGV1MMlEwOLmfHzPr9J5CwyJ0kwxPX4h7m2Q9phshE07Fhh8P5PHnl/l4OEcVaLgKnIXovSenCwG/vzCmr7XRxVjcuySrrN5Xt5o0XIVWD5Kb3gN1ufXYgSCW2/W6Mjr/e50K16kmDYtQSf8zhPdSOfSeSmIHZ8vcdbkkNpP/w8pAwyqEVcW1vm3wBtE/C2ed6/FwjiJoWJWiqupxU1VMoeG6sKqG95SFhrdBWNW60NASNLQEDS1BQ0vQ0BI0tAQNLUFDS9DQDrLxB2O7y8krVNtRAAAAAElFTkSuQmCC",
            } },
{297,
            new Items.Pokemon()
            {
                Name = "Ludicolo",
                img = "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",
            } },
{298,
            new Items.Pokemon()
            {
                Name = "Seedot",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGrSURBVFhHzZZBTsJQFEXZEkXYg876ywp0VuIGdEbrBHViHBl3QJxonBB1ArKaKgtQ8+z9+ExtbihSUt7gpOkhgZP3fhtaImIaKi1BpSWotASVlqDSElRagkpLUGkJKi1BpSWo3IReryftdttT/qwOVP4XjZvej6XTCbYaSeW6dLtdH3NzNZQocvk18dfkJJYg2M40qVwHTC0MQ3Hubxju9QrqRlJZhcZpmEampwOPxmlonUgqq9DA2cNYbq/T38giiNPYRgMRp2cOP47JIVLRKZYniTNZ/q51oHIVCMTTWp6cTqwYVvSNBup65493lSvW4E3XTGUVGokfLoaW16yxjT8keP99ZEPZy1/KGspIYifpwEnQdCDQKX5miQ9FsCxS6fedd2fHTp7OD6Wz4dlTqFwHBCLq5fJIvt6WkVglnMY9XxztJhBxk9G+RC70a0QMIjFBBCNsG3GAyioQmE3jPOLAR2Jyk9FyYiD6OYPZLM7/POxwxQjTJ7R4j+m+v8aymA92F7iKcnwdqLQElZag0hJUWoJKS1BpCSotQaUlqLQElZag0hJU2kFa34a0G4sbDXcVAAAAAElFTkSuQmCC",
            } },
{299,
            new Items.Pokemon()
            {
                Name = "Nuzleaf",
                img = "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",
            } },
{300,
            new Items.Pokemon()
            {
                Name = "Shiftry",
                img = "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",
            } },
{301,
            new Items.Pokemon()
            {
                Name = "Nincada",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHxSURBVFhHzZRBToNAFIZ7pULhHgVOoDvdAb2A9hTGG1Q3Jm7a6AXadNOlxou09jk/5NGR/BaKmzfJF+CbBP55M4+RiJiGSktQaQkqLUGlJai0BJWWoNISVFqCSktQaQkqLUGlJajsSxzH7vL7eTweN/hzQ6GyDwiz+LiRIDwFWq7X8n08uul6TCaTfwelsg8asChzORwOTtXjfbuVN0dZllIURUUQBJii7+mCyj4g4HQ6lTzPqxB+yNlsJk+ft/L8dVstYLXZSBiGmKLvOgeVXcRxJPv93t2eBkIhCCrXhHPB1Q2tIpWMKIqas9YOp8MPiXC61RjY+iFVpLINwu2WC3l9nEuaJlUINIOetzRNmy3Osqyah9etx1UHGscN+h0GlT5+OA2IjyIcQiIQmiXNao/nJEkqtJqoOgLruCQklT4IiGa4z6+aD7OG0GZANXerekGhO3f6m9GQ+hvqG5JKHwR8ebirKqfhUCVcEQ4OndwOpwH9dyEk/pUIqsG7oLKNNgiaQ1fuOwTGPcBiEG5eXLvOPYXAnJ5XLAbPOncOKhkIhNX7nQjXDo3jgKriSPgBdV4X4vtzUPkX+ED7mYVGFdvbOxQqL4GFvqRCXVBpCSotQaUlqLQElZag0hJUWoJKS1BpCSotQaUlqLQElXaQ0Q/B2F+4y94pWwAAAABJRU5ErkJggg==",
            } },
{302,
            new Items.Pokemon()
            {
                Name = "Ninjask",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIjSURBVFhHzZVRbtpAFEWzJWxAqtKfUjZgwwqgK3JhFVG7ACz4aZWfRvkhYTPQvs41vWhi3TQenI+HdAQ+HuTLmzePGzNzjZSekNITUnpCSk9I6QkpPSGlJ6T0hJSekDKV8Xgc3vS9vkiZAsIdj0cbDofhUq/pg5QpjEYjvwEZ7vBxavlgEJRe1wcpu8Lt/b67tyzPg9Lr+iBlFxBuEKrWtYJcH9Neo5DyLVi5+XxuZVnaXf3zUkHc4zpe84fwtdvtLO9YcSnfogm4/2SP68Jms9IWi4Utl8tLEB4Y/hC80Abftvf2fDu1w4dJ556V8n/gYPyqCvvzNDE7nEHQL8uFnU6ncD21YX5+OAMyHEnpVylfA+GKorDTfhK2t2i2F58ZlGEfV6Xl2cDuNj9eBEutHpDyNThWUCUVkOEAKsr+jEOmnnYp2yAY+gvV24cKzMN7HI69CPdQncOhJx++lo1HyGuqB6SMQbjNZmOr1So8bGZVVdnvp8+XChL0H8YNwuPQIBwqyeCg62iJkTKGAbfbbTMa8JD2IUFYVBYVigO2t/maYS5lTFzBLMuC+teLYcys11XjWV2E4cghDHjtP42UbRiI44MO1QQMxa2MQ3INv5eKlAoEajuCezhAdV03rYBqcpsxbtrrU5AyFQRkn8a92qdyRMoUuP27bf2iT98LKVOJ+7F9ry9SekJKT0jpCSk9IaUnpPSElJ6Q0hNSekJKP9jNX9daJE++Fnk0AAAAAElFTkSuQmCC",
            } },
{303,
            new Items.Pokemon()
            {
                Name = "Shedinja",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH3SURBVFhHzZRLUsJQEEXdEuGzD4gTHeoMnCBM/Iz8bEDcgboBLR2IjkA2AboCPwugtM2NNDwf14SkUDtVp5IcXpJLdzorImIaKi1BpSWotASVlqDSElRagkpLUGkJKi1B5SJUKhUpFAox7HxZUJlGuVyWy15P3j8+pFQqRerLjcdjuRkMpFgsxm4ZUJmEBsGm4ZSk3/JCZRJopYbAhiDaWt9HG71HFqhMw22xv/17i1HBYa8uq2FNarWaXPX7ch2FAmEYzg2JDo/rskBlEnjg7dmaPD7U5WnQmAYFw349qt73qcafwTr1WaHyJ9xwr48dub9YnwY93t+WUb8h7a1NCZxgWAOKwR8FxIP9cG6QdmNDuuezPVw4qbIOk3/fJKhkYDA03NvT6VzAtJDu2iztppKBgNVqVZ6HJ3MPxPnR3rbcTcKwgC5Z2k0lw60gHqIB3WO8hwjpBnPD4t38tRYDDemG0ik+3J0NCY79av7JkAA/pLtHGIQ72mvF+NXME5LKNPR97E4+OVpFPUerEbDV2JxWL88EAyrTQEB8D/XzgaohzMuoE7dd26yfFv/6LFC5CAipVTnYaU6r5bY6CIJoKb9+UajMioZt1jfioMsKB6jMi1tV/7e8UGkJKi1BpSWotASVlqDSElRagkpLUGkJKi1BpR1k5RNFTTfAHJ8KmQAAAABJRU5ErkJggg==",
            } },
{304,
            new Items.Pokemon()
            {
                Name = "Taillow",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFoSURBVFhHzZMxboMwGEZzJWhA6tojMGbtlhyh18jYNWMuUKlrxlwno+vP6h9+WR9gHIbP0hPmgfCLCbsQgjRUKkGlElQqQaUSVCpBpRJUKkGlElQqQaUSVCpB5VZ0XReapolTfr0EKreg7/twPP7EwLd4Orq1wVSW0Lb7tJiBc389D8Ru5sElULkEgk6n3/D4/EpHw3YHRx/DdrMUKufwcXmgRdo9CLLYYTjHeRsfwZ87BZVzYEGLM27vQ7wUnpGIsbmd18QBKudAYLh/JBCHkVwcY9CQGOPqv2Qqp/BxBhy4XB/POB/6Shygcg4smF7p92EMjfM8zmM/oiaWyiWwkP8P2pgK9KyNpHIJLIJd9HEYeM0s0nZvbRygsgQshqB8IBAfhv3/aqI8VJbiAtKw3dsizKByLRaUov6/7PyeWqh8hS3jAJVKUKkElUpQqQSVSlCpBJVKUKkElUpQqQSVSlCpBJU6hN0fteFGXli1YiYAAAAASUVORK5CYII=",
            } },
{305,
            new Items.Pokemon()
            {
                Name = "Swellow",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIJSURBVFhHzZVLTgJBFEXdEipEnOkOuuiJU9EJxAX424RxZJzqTBfgZyQ6MboZjQwgPvvSPHwUF+hGSV4nJ9VcPnW4VBUrIuIaGnqChp6goSdo6AkaeoKGnqChJ2joCRp6gob/Ta1Wk0qlkt3y52dBwzJgch2ZBPKP3UNZr6yOnisjTMMi6CSt1l02ro3GeOJYkAnPgobTUCmQJEkmdS/t9uMAK6mvr1artL2lCOKDIdCpN+Rr90he6kEaSZAQwkjUyoFYsKwcoGGMyn02T6TbPJYD0xwI4TyTm5wUgrbVpQlqE5BTwRAac9uzcvHjotAwBt+897ol3b0jSTMprMFeryfd/dOxNu3k2joy3UzTmp4FDS0qJ+/bOd99SdNU+v3+hKBK5pvoLJN6GDad35dtD9AwBpKD1i52RN6Gopc7ctAelwP60/+iouXbAzRkQPJpIxnsXuxibQ4bR+8hZ48eK4wvGH9mEWgYo+sJk31mcrpR7K5mcjH685eRpWGMFVQJlQPf2XrEupwnaCm6HmnIgCQWvh7UVg5XEcGlNajgLMNfXGe4DlVOLya5iJSFhtPIW0xGE+IsxHV925Wrm5znzXTwF/gXKQsNZwFJHVUC2B2uh7m+5y/QsCy2WR3j1ywKDRfBNqvZf0BDT9DQEzT0BA09QUNP0NATNPQEDT1BQ0/Q0BM09IOs/ACIkOzxdK3s0gAAAABJRU5ErkJggg==",
            } },
{306,
            new Items.Pokemon()
            {
                Name = "Shroomish",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGvSURBVFhHzZRNTsJQFIXZUiEluowWJ25BnKgjYEZgojvwZwXoxOhE1A2grgJ14s8C/Lm+++LFF3KQ9lWTM/gS8vU1PT2X25qIUAMlE1AyASUTUDIBJRNQMgElE1AyASUTUDIBJRNQxtBsNiVJkhnz12OBsiwa7u1pJNdHm3J12JaH2640GnV3CZ8vA5RlsOYu9jfk43kkj3c9H7JR/5smoSyKhluf9OX95XjWnqEtWtD5+8oAZRHSNJXppCOfLpy8nni0PWPtfEdyx7hiSCiLoO31+x25PGj70S4KOK34f4RyGTbaxD1YW9RRDgZdR89zf/MTVKkyaih/w5YiO93y7YRBtCkNHLrwWszSQLkIDWeN6RIMh7ixcLzm7J6y44ZyEWFAe6A+XINaSAtnaMjw/L8GVGzE+t0LQ4ZNtc62fTjdYAsX+12EchnWpG+slUue5zL+DuwDBs5eIHaToSyCfge1kZXdTDLXmG20hV7dyyVzIfVMTHMGlGWwkYe/dcN1xBrazsUCZVXC0FWBkgkomYCSCSiZgJIJKJmAkgkomYCSCSiZgJIJKJmAkgepfQHkhWHzUXM7aAAAAABJRU5ErkJggg==",
            } },
{307,
            new Items.Pokemon()
            {
                Name 
                = "Breloom",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAK4SURBVFhHzZbLUhpBFIZ9JYZLVdw5ZhN3DGwwO/MEYjZJdsa8gLpCXJk8gZVNLisvL0DhJokrlIcAPem/nUOarn8GRiDVi6+gfrqnvzl9Y01EgoaGIUHDkKBhSNAwJGgYEjQMCRrmUavVpFQqTeG3WSY0ZKhYvdOS9tWO7F2/sSTdbSlFqxOloQ/kIHbY/yjHNwcTORcV9fsuCg1dILd7sSNHqVyWIFiFJA1dfEEmpkBw2ZI0dNHpddedD6TivS1L/aT1fwVBtVrNlITc+Xos9/W6fH0Ry2b7VaYknuNns6Ahw1bSSCRJIkkqq5UbH51JJYpkYH5vpr+7guiLXd67eCflcjTJ54GGDAyCAW6uP0izkUzOQEifm8ppBRt4CUdQl0hi+vQu31vBIkcSDX0wyLezljw8jGV4e2olHx/HUqlUbN4wg6OycXvLirkC6Luxa6Y9ma5+VJ5PkoY+GGQ0Glm54W3XgkqgeqgKhH9+2ZZyxuZA/8Pevl2z8dtiG4mGPhhg8KtjJF5bic7+hvRTMSVvbaE/jioIonJLn2KAQfTB+l3XpFYvb2D0QcWLyAEazoNWFdOtkt2DWKKcaUb7le1iF5xnmOa730+CmPr+1b8p9yXQXl9m5YJu5ZTTT5vy43PLSt7/OZmScNsXlQM0zAKDYQ3pgM1mY+q7PUZS0M5tqxvMf+YsaMiwlXAP41TEFcQ5iCMEh/J3cz7qtOcdQbOgIUMF9SrTaw4H8MBkQ8PLVFBzSC4iB2iYBSRxK+i/FkiiWhCEePvy6azTXKfZf04RaJgFBO29agT0StNrDNPrCs57U8yChgx7VDhrUCujGweovFZP+y4CDRkQVBE2OH7XfzZ4AXyWlyBJw+eiGwli+um3KQoNn4tOt/99EWgYEjQMCRqGBA1DgoYhQcOQoGFI0DAcZO0v2hO+272BErEAAAAASUVORK5CYII=",
            } },
{308,
            new Items.Pokemon()
            {
                Name = "Spinda",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKKSURBVFhHzZU7ctpQFIa9JdAgwzJAwnvIqxAIV1lB4nRpMthFwqPPTIogAb1jB9qAgKwhjmOPi8zJ+a98mbE5I4mIMbf4mh8ZfzovDojIaMTQJMTQJMTQJMTQJMTQJMTQJMTQJMTQJMQwjVKpRIVCQfH4s10jhklArlqtUlir0YixEiT1izzOt0EMk8A/DVgQcn6jQd32WyoWi/zR5nOR9zz1JdIQwyS0IOQuwy75fnNDUMv5zQYtmi9ySYphGhDwPE8J9k5PREF8DjlIYhyeVLBSqdBF0FHVg6TjOOulAb+jgPpnJ7TclyBAlbAs11FIt6vRGtd11lnL99ULWNbmjGZFDNPQM7biCt0sHgpqdiEHxDAJLedy2yIWvF0M11Ir/6WSBvh8F3dSDJPQgkeu+6C9x8c+1VgKRI24upN9VRCzdzUPYsFl3M5rbrWuIKqHxfgedp5eUG9w//Qd1esub2yoBCGMBUH1lKCzJ0FgcxXPB59oOuzRdNSnyainWt64P95HLP6NX0K6kdsihkmgxfglqXOV7j58pr/tL7R6/Z4mLAtR3ETId9tvcssBMUyiXC7TgAWHLOgwLgtdcCshB9BWVLNkWfy4/B3bIIZpYA4hWcdR5uWYjrnV474CP2+rZrzFds75A2KYBbT66sfX+A7yJuPU3PDCjHn+cIaW95JWMd8tFMMsqFnkFo+5nX9mAYvymWnFZwbzOWPJufeMyvYhPy5/RxbEMAto8/ngo9rakOdwjp8+voM/W69oxNIOj4Bt2/yo/PdZEcOsQBISABX9NRuombwcdqh8mK9yGjH8X7DhEN1F5TRiaBJiaBJiaBJiaBJiaBJiaBJiaBJiaBJiaBJiaA508A9SlT+8S1U8mQAAAABJRU5ErkJggg==",
            } },
{309,
            new Items.Pokemon()
            {
                Name = "Wingull",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHCSURBVFhHzZVNUsJAEIW5UhLgHkmx0SNgubDUC2DY+HMKfw5AiRt1BXIhFy6S0M4L1dQ4PGUsoKq76ivClyHz0pMJHRExDZWWoNISVFqCSktQaQkqLUGlJai0BJWWoNISVFqCSktQuQ/6/b4kSeIO+flYqPTp9XrtRNsmwzj9xNj7WSUntyJJ2t0pKJUKulBVlTsUeVksJMsyGlbHDQYDqeu6/Rze1PLwIfK4kHVQ/zexUOmDySezmTTLpfsq8uRNqGERDjegY8bjS2maej0WQdPsAAH9DqIwITrSrHKsg4SFsOX4oj3X7R5wiYE+7GB4XUndOOsK4Z7n83XXwtJHwhW9bixU/oYfdjQ62+heuMxpmu7UPUBlDOHy6wZB+UG1k3pj/w1MZQwImOe5vF4dtZ30A/72bKJO735uMFf0+gqVMeB99znJ5WtayHu5Chl2y9/9qHCTobCJXNE5AJXbQPf8cFnKly/cYHjdaLhp5Cai8i8wKTZIWZ7LW3nchgvHMPx/JL+ze++gBiyKYqNjsfidDc+FULkNnSD0h4BKS1BpCSotQaUlqLQElZag0hJUWoJKS1BpCSotQaUlqLSDdL4BjTaHKMNZkEsAAAAASUVORK5CYII=",
            } },
{310,
            new Items.Pokemon()
            {
                Name = "Pelipper",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJeSURBVFhHzZa7ctNAFIbzSvJtJmU8vIDkPEFC5QwNUDm4o2KgYUjD5QlM8gIeuwHSJHHDpXJSmfghLOmw/5pjr+U/sSQw7M58I/mXVvP57EXaERGvoaFP0NAnaOgTNPQJGvoEDX2Chj5BQ5+gYRnq9boEQbBC9p4y0LAIjUbDyrR7F3J0OrI0X57K7tFzk1fMLbxfXmiYF8hlxcDX8bX8uLmxVKtVcyvvnwca5sUVVLE0Tc2lZavVajjQ/nmgYREgufeiZ+UGg4ElSRJz6c/lAA2LoIKxkYLQbDaT4XBoJf+7IOQmn0IZvT+QNIkXYnpE+6dDDCF3G5lN9kSmTRl9ODCSh1KtmMxUMNsgqX1Mo8++Cxpm0T0O1Upvm1aKMT0P5eRpR5I4Nt3WW5lVTUMXHUZXDBVrtSKJolVeP+7I1btDO9zZVnbboWEWHdowDFdk3jw5XtAy2eRztDYf0XD+/Xq+yrciCCB58XZeOVcOYhCOJ/MhVsFutyvx76HG+bfx2FT+oZ2neF5eaJgFclgQ+/vLCioQ0/k3PY8skHx23FkTLPNWoWEWrV76czkPFVfsLkE0SFYqxd/NNGToYsnKMCCIbceVxDzcWgUVreTtFy4GVA5gvrpVfPDqTIKCVaThfWBPxGq+NKKQcGVdORXs9/t2NT86W37xFJGk4X1AEF8w7jcfquqKAaxW3ZravUt7f/vj1eIYVPINNw03gaF2X13ubzfXa/qHIFa0ijT827iSEHP/wCZouA20ytl8EzT0CRr6BA19goY+QUOfoKFP0NAnaOgTNPQJGvqD7PwC+Ztb27PDw1UAAAAASUVORK5CYII=",
            } },
{311,
            new Items.Pokemon()
            {
                Name = "Surskit",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGjSURBVFhHzZVLTsJQFIbZUp97AJnUsILCBnysosoGFEakq1GcGJ2gbAKQQWOPPU0Oua2/fVGTM/iS5uvt5ePeSxkQkWqg1ASUmoBSE1BqAkpNQKkJKDUBpSag1ASU5+B5HlmWlV3i+22Bsiu+71OyCcl1FAb+RxwDZRfUBnIYnzmOm0wuez1/DJRNkLDX1ZDSz5BoO815j0fk2FZvoVDWwXHDMMriLk5xHGZej2dRFmlnw/EcTYGyDg4MVxt6XH/RWzzOg0wW6z1N4y1ZtpMNx3M0Bcoq+D2XJAktX460qKGPSCirkLP38LQrxHynKbmuW/ASeM55hPIvOC4IAtpf39Hy+VAItB03D9ldRad7HDiazbPj8NE5FEqEnDtZFTmDEni4ndPx5v5XHP9QOMx8tjx3FVCW4TjeOlkldvKfKx8syIpJnDmHjG8TCaWJGVe+x0ioCb+CZFvL42UnmkZCaSLfvOyr4GfqIpvOCWUf1K18U6DsC97+cyOh7Av1gQxvddm1AUpNQKkJKDUBpSag1ASUmoBSE1BqAkpNQKkJKPVAgx+ktVQ44VWOiAAAAABJRU5ErkJggg==",
            } },
{312,
            new Items.Pokemon()
            {
                Name = "Masquerain",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJASURBVFhH3ZZNbhNBFIRzJY9/9rFyATvegFg5yiEAsQGyQWKDwgaJi7BgEysXiJSL2IoXtvPomlDWU1PzBxPpiZE+Wa5p93xT3WP7xMxCI8NIyDASMoyEDCMhw0jIMBIyjIQMFZPJJL3oc8+JDHMgt379wkbFIL3VY54LGeb8d4Lj8Ti96HNdkaEHF4Pc9u1Le9zvbTQapViPBRh/s97ZsGEcwNjBoP6mZehhe5DD0SSI8W0E266KDAkm2e12tn33qhT8+fm7DYsinaoeD7mr260Vw2pBymFV/lnQL+/Xs0u7nl5YUbEsFKxrr4sckCHBZL7BOkHK1bXn5+tN0DeIA5J1glXt4YH48embHQ6H9NaON920p2XoyVvk4SemXCpPCuL8l9Nl2f7h9xxtW5Shhy1CjpP6ib2cWl4vlwv20iDA8vgW/d1TjoIfnSQ/x72bt9ebIEAT+FKl6GI+tw+rja0eHo+CuWS+f3HwJnE0yQEZ1kHR9zfrP+TI+WJhmzdPcoo2zREZNgFJNHl/eWb3F1O73ezL5igMwXlqeO+W1LfW9PPmkWEdkJvNZuVFuISQZCv8LsQyz8+fREkXMSLDKiAHATR0t5zag1tGPDAQx76EHAX5Hu02/T4rZKigXLpWCS7GBtniVSbH5lZpC/jP5XPXIUMF/xoRZHxg7panRzk8vcjypc4/2xYZdsXL+yxvnOe6IMO+UNsiH9OEDPuE2+BvlhfIMBIyjIQMIyHDSMgwEjKMhAwjIcNIyDAOdvILlUtGpZFoksMAAAAASUVORK5CYII=",
            } },
{313,
            new Items.Pokemon()
            {
                Name = "Wailmer",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAG7SURBVFhHzZU7UsJQFIbZUsLAAuyky6PRElZAqBxdBeAK0NI2BeoKdGx8rMDRxscGYI6cjCdzuPzATUDnFN8QvjC535ybkAYRmQZKS0BpCSgtAaUloLQElJaA0hJQWgJKS0BpCSir0mq1KAiCFdzf1QFKXySsO3ylzuCBuqM36o3fS4KwuXMolJtot9vlhDhMBzEHvSsY6l7HFygRMq3D/h1FcQLjNlE3EkoXjuMw3sY6cUKdSCg1vKUSpwN5sf+YIpQaHbjL9ISqkVC68BZHUURxHFMnu195CDTbJhsnaaUnG0oER348DilNE6/QbfhOEkqEDpzNZovPtAhl0MT4lpDz7jn5K/KJhBIhgd8v4zIyz3Oaz+dLsZrby0EBH+swOQ6CcHFpvJ4A5Tok8vzsmJLfCB2qg68nGX09j5YC3ci9TpDRgZ9Po6VQjUxaJoimuPd7UNBbLaF8rL/rMI28Iv/kKdZw5HTSp/HpauDNRbY2zr2OD1D6wJG86PDkqIziYBRYN46BsgoSyhPVkc0wLPwucQyUdZDQfURpoLQElJaA0hJQWgJKS0BpCSgtAaUloLQElJaA0g7U+AEfJSjyeCJEQgAAAABJRU5ErkJggg==",
            } },
{314,
            new Items.Pokemon()
            {
                Name = "Wailord",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHnSURBVFhHzZVBTsJAFIa9Uq2w1xvQchGjLow7Ui6BuiJ6CApsjG5MvIxGF6U85wGPvLZ/YbDUvEm+WD6RfsxMxxMiMg2UloDSElBaAkpLQGkJKC0BpSWgbINut0tBEKzw8UJFtAWH9EafFD38UHB6to3Srvw3TEW0iY7U1MUxULYJR57fvlPv/psu7j5cXOg0fi8DpS96/yDK72ckkOOOHtjpdAoB5eUavy7p6Y0oVktXjuXPkMB9cQyUZSRMB3FMvnS/3Yz+49ovNlK/5muJPSSOgVKDNraOe1Yz5oPv0gpQCnVPXVOOEthWnNB4D7YdyOw6/wQo/yOOZ7AXxRRFkbtltUGAstXAuL+KikZfW3fwfxI+VtqcwXQ6ozAMK2ckAkoOHL9khXNu13HCM+D1hWT2HPvCBCg5MMsyms/nlOf59qcMn7NPzrvVPlPLKfg8IAyUDEdOJpNKoE+sxDFpOqM4Xj8M5dA/P8WMzCKPukB9LaE6bDYrovddoyUWUOSu2HKQhuPcgPfZBZQaWeokuXYxC6eKYcPhDU2nKYxiZNbcgJ+/DyjLcCTfZDC43MZwsL5OkqtCaNMwAco6JJSRWUVRxwgToPRBxx47SgOlJaC0BJSWgNISUFoCSktAaQkoLQGlHejkF16yP+U5zoX8AAAAAElFTkSuQmCC",
            } },
{315,
            new Items.Pokemon()
            {
                Name = "Skitty",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJ3SURBVFhHzZXNchJBFIXzSsAMP9vEVdzBsFB38ga60rjiJ1WG+BIKujYBszBxlSrfxUokqYKJVSZc+3RoMpk6wwwJlHfxFXBmpvur2/cOGyKiGhpqgoaaoKEmaKgJGmqChpqgoSZoqAkaaoKGWfB9X3K5nPnKr68KGqYBub8Hn8Qr5K3kOkVpmEapWLKCQa0m14e3ovF7VgUNF+GqJ8O+JU3usa1Aw0X4xaJcf/1o5W4GvdTN4+0Qv54GDZPABm9eHsivZktGnbbUg0B8r2A2L5jLd/e5qgHXCmetlhTyy0vSMAksvtMYWDF3xOCi07GiUSl3bdRuW4JqVcbjrnjecpI0TAILB0FV5Kgv02HvniSom0pFf0flqobTZ9sSjvesZHztJGiYRN4c0Ul/UyaTrsi3+3IAlcTnzeCzFXtnqr3TGBq52yNGhmOOr7sIGjLQV/V6zcjtyzRaQfN9zkwUbQCxuNzaBa+u9u0Rj80xTY+MoJGCMAhR1Zkkjvpt41CKZuLRFmfN5voFK5WKbfIfX55IGHatLMRQVXDc37IZBCHiBgGSp8+35fdsit16WaFhEtjs8vL9XBBi+HT8CT9YwXMj6EVk8Bxwv5eBhosol8tWEtWMyk0me/bFDTkc8c8XT20VPc8zj/G1skDDNNCPu+3X8/4Dx70tKwZcvy3zvkuChmmgH9FXGJgoo87dtF7sdv6fIMDmGBhU7sQMCN6PAJLnZiDQAuVyydzKn88KDbOApocE/iFarVdWFMLfe5t2IB46FHFomBUnAiAK4VWJOWj4EJxoPH8sNNQEDTVBQ03QUBM01AQNNUFDTdBQEzTUBA31IBv/AGRTS2Q52lUtAAAAAElFTkSuQmCC",
            } },
{316,
            new Items.Pokemon()
            {
                Name = "Delcatty",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJMSURBVFhHzZY/ctNAFMZzjHAM27L7GBpCZUnjmTC5AElFqII5AeEETroMVaDBQEGSij+XMPEl4uCCzDz0yXma1eaTLCkEXvEb2Z/W3t++1Vt7TURMQ0NL0NASNLQEDS1BQ0vQ0BI0tAQNLUFDRq/Xk1arlbxcvtb8vqEhA1Jfx1PptDvZ1R/D6Ha7ySW/wDrQkIEJTp5/ke+HF/LjaFZJsOmiXGjooxO9f3Geo10woVar7oIYNGS4k0LOnRi5izumyoLKoGERkBwMBnKyd5oJ+rhCrhjE/e+rAg3LwEPPJJlYFEYShmFjOUDDVaCSuo0MFfPl8Dn3WgUaloEv39pYl/Cmiq7YaPMoySM5ftlPJAe35LAobLde9V4ZNCwCk0w/7Mj2wwdyff1b4jjOKgW2+uvyNGE6eSZvR/1E4ragLuZeBIFKdjotubx8LYvFm5TtR0vpIAjS+7NPuykY5362TvUADVeBiSA3+7wrv64OUsEgaKdbqnJxtHz+3G0eDoe591WgYRUgiW6ezw9SUa0YxPzm0PFaeTdfBQ3LwESYfP/xWN7tneU6FqBx0Cw/J8vt1So2kQM0LAJnIH7yoijOOhiC08mOvHpymAq7HQ1JVBRd7TZMHWhYhG6rXylfTgVx5EC+SeUUGpYBSa0iKnPxMV89Fft2M+afCwJ9DsHx/kZ65o02x5mY/oFo+ty50LAqEIUgqqgHM8T03n8XBBDBmYhz0M9V9i7QsA5/S6QIGlqChpagoSVoaAkaWoKGlqChJWhoCRpagoZ2kLU/tG4A2wzKR1YAAAAASUVORK5CYII=",
            } },
{317,
            new Items.Pokemon()
            {
                Name = "Kecleon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIMSURBVFhHzZZLMgNRGIVtKYn0AjLDKN1ZBTNMhJUEK1A2QBkpJh4TygoUC0AZ/vrcduTqOuF2h8o/+Op2n1QnX5376CyZmWtk6AkZekKGnpChJ2ToCRl6QoaekKEnZOgJGaaQZZl1Op3ysrqOx36/H8a/QIYpQObl8ciWe13bmaxYt9v5uudYf6YNMkwBLUFk73DNdg9WLS+G9lrevz8fByDIhudBhilAcHK1EuRiQQjfX6zbw+VGoNebT1KGKVDw4HbVik+5w9uqTQDJeeWADH+D0wuht6fptAJOOVtcSIMUhBAk0SJEKcxpXkiD2L2YWgpBjoLYGHfn67ZXNohdXX+2DTKcBeSGw++7lesOjUGM48IE0dCoyC3PKygb7954avEMjhvCPBUZ/gTWHyR5jFCWRwzaZHtZ1g+NT66rZYDd3lRShrOAHH4APwqp8WS6WzGtkMN5iBySlAv51qC8Lt84DTeODBVsjiIQqMsiB/s308YgWGxXchybSMpwFmwwniZk8YHN6WSbvA+f/7egAoInwx0rog0zGhXfWkWjbeSADFOBHP7JnBZjO8t3gyTEvtZd2WC+OQjrb7xfvbebHj8yTIWC3Bjx+uOUM+earX/Hb8iwCfG6VEcKqT+XigzbAlm+oxf+h3UWbLSet0WGnpChJ2ToCRl6QoaekKEnZOgJGXpChp6QoR9s6QOzNBff2WXjQwAAAABJRU5ErkJggg==",
            } },
{318,
            new Items.Pokemon()
            {
                Name = "Baltoy",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHaSURBVFhHzZVLUsJQEEXZUqBgD2aW4CS4Ax3xmYgzhU2oO1A2oDDyswGEFVC4jPbdQOMzdQvzqSI9OJVwE4pT3a+bhoiYhoaWoKElaGgJGlqChpagoSVoaAkaWoKGVeh0Ou7Cn5WBhmVpt9uyfLuWVqvpPvJ3ikLDMkDutn8mX+9jmY5CaTYDF/N3i0DDoqCtQRCk1Vt/3qSgisiy7xaFhnnxxVC154dEVh9jmT32ZDIM02pWbTcN8wC5l+RMVk5CqwZJiKmcX83s9/NCwzxAcNO/lEUv/CPJOLkg5J7uE9kOfwUXF2F6r2Sly0rS8D8gGEWRbAY7QbB199/DqwNZyZMLooJzVzUVm+7PHpjvhVUSQ1N27dDwGLrv4jiS12Qnch7Hssy0VFs+GVTbiTQ8BqoHQfwoqtjtxodr7ESVOyeGtVOleoCGx4CgLmBUE2cRQpCEjO5AyEG66rKmYV4gqGex61ruVxCg7bUtagBBXdbb0W5615mzCGpZ1IpWEa31pzo7OCddMz56DjHRs72onj39n65VEKgkJhfrxx8MDFUVSRoWxW8z8NcKntUuCPz9yJ6VXTc0LAtEsllVaGgJGlqChpagoSVoaAkaWoKGlqChJWhoCRraQRo/iWcuMFexPhIAAAAASUVORK5CYII=",
            } },
{319,
            new Items.Pokemon()
            {
                Name = "Claydol",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJmSURBVFhHzZVNjtpAEIXnStjge2DYTJIVM9kkymIG5hL8XIDMDSaZA0yUFYiTRMom2UXKAkylnqVCPZ1nwC0hlaVPtl93u59f29VXIuIaKnqCip6goieo6AkqeoKKnqCiJ6joCSqmUhSFdDodveTtKVAxhV6vJ9PpVObzuWRZphLv1xYqngMM4Wyp9ft9ub8fyXh8I2VZ1pqliT44p0DFU8DcarWSPM/l7m4ks9msNhUahIbrLOsc+sbPOQcqHgNpYMLJ5LY2gSUNzRlmEu24X6/XSSapeAwYtNQwuRGaA6wdacbPOwUVm4C57XYrDw/vqYkmzPRut5Nut6uP4s9nUJGB7w7JYRIcZtI4lWg4rk2SVGTA4K8P1/L88Y1UOhkmwne13+9ls9m8+iZhKG6DwedP7+S3js9b1EoqMmAQpQSl40mNwmR8WKqWVnjAXKZj8ZIXMQiK4nWKmLT6vNT7t/8ZjttS0gNUbMJS/PNjJMNhKbvlUuTxsWY4GNTLiiUd6HXcZmPaboVUZOAPtiV+ebpWE+VhuXCeaB1E7bOaiDP6Ygyuv+mY/JJlJjSIM0x80SXDsmHJB2oCKf39eVMnhe/U2sbaN6UGAioyzGCcTJgYUvr+Vc1quqYZbZfWoGITYYrY7qzmhUZibAvEdYpJKh4DJjERwK6yWCwORquq0i5y+FFgDrXRivXFt7oQS9NMwFy4u+CPNpOWYEqKVDwXmMT2ZwaszFiCZgjYy7RNkYptQG2EARi1lEJjcT+7PxcqphB+mylGmqCiJ6joCSp6goqeoKInqOgJKnqCip6goieo6Ae5+gdfy/uQLqkOFAAAAABJRU5ErkJggg==",
            } },
{320,
            new Items.Pokemon()
            {
                Name = "Nosepass",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHxSURBVFhHzZZPTsJAFIe5EiWUcATYdcoJChuKF3AJBRfiCYyugDsIohuNlwC5hEtjnvOGDBnrD2iLkrf4Fnz9w5c300KJiEQDpSSglASUkoBSElBKAkpJQCkJKCUBpSSglASURalWq1Qul3ekjxcByiJw3OTlk2ZvZOiNnqnsVfQhfH5WoMxLOs4Gjqfv5J0YCWUeDsXdzDbUGz6dNEkos4LiJq9fdOEEMl6lqk/H9zgGlFnhwHiwoKmOQtO7nqxPniKUWeC4IAhIKbUlSihOliaGA5necEmqc0VhZ6Sfak9fhu91CCiPwXGrKKJNu00tG5giTh5JtYd6wnMTerYJctzH4NLE3TebdKcJ9STHkxWpsPUr0P1cJBLKfbhxLnaKHMl7jkM5iJdbqXAb2F+cJ/C20dhNjb8YLXU6zqD3aJF9COUhOJJ/xoJo8GMJ3YfEhtmJ2qkW+fmDMgsc2u0/mCAXjrNh7muG+fcldqnX6+Y1Y5czTgdO17swS61W05fi++0DyqzwFINAUcgPRX9OXf3S7vHTG+ol1thXTNBOyC8Qx0CZFZ5iV4eZKD053/cNQdQ3+5PDmVP+ekGZB460Ya6z4Yx7LC9Q/gUcyVuASR/LA5SSgFISUEoCSklAKQkoJQGlJKCUBJSSgFISUMqBSt+uPi2aiG52NAAAAABJRU5ErkJggg==",
            } },
{321,
            new Items.Pokemon()
            {
                Name = "Torkoal",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIGSURBVFhHzZY7TsNAFEXZUmwlAnZhOw2hC1QJDb8NAF1CE2AFiAqxElCawA74NHwWEMTgO+FZj+HaEAzSK45ijiFz9DxjseCcMw2VlqDSElRagkpLUGkJKi1BpSWotASVlqDSElR+R7PZdI1GwxPe+2uoLEPCHkdd93K85omj/42kkoE4hI230088H3WLyFarVUz2r6ZLZQgW1lMLaWepDzo/P3UXF2cFURTVDqUypCzwpLPkjnOe8ikiEoFZlrk0nV0j8n591cU1IqnUVMUhTK6zNPkyweHwwHO31vGRv5kmlZqyQOw72WujlUUfOBjsf4p6yDn8cP1+39/HYw/XqIJKzTwTvO2uFFE6UOIkfp5IKkPkBCMGe02u9R7Eic7yvYdIPbU6cYBKho4MkVcOAnu93pcwHBpBtkX4/WVQWYa8qC83kyIqBJF6YohCND6vtma/M8/LncrvQGiSJMWCGry4sQ1kYjJR+Vn46RSprAJxOLXYezgYOhJx+tEjVKaHoMlk4sY7bXdzPXFxHOdfx9fQUFmGjhOifGFEIHSjP4vRe1VeR/L3uP7p9ACVZUjgcLDnjjrLPk48FsVj14cEzBPDoLKKqingXnjS6/63Q+VvQeB0OnXj3bZ7e331n6YCgZ5w3ccLqLQElZag0hJUWoJKS1BpCSotQaUlqLQElZag0g5u4R1lzgCmJ7waawAAAABJRU5ErkJggg==",
            } },
{322,
            new Items.Pokemon()
            {
                Name = "Sableye",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAABGdBTUEAALGOfPtRkwAAACBjSFJNAACHDwAAjA8AAP1SAACBQAAAfXkAAOmLAAA85QAAGcxzPIV3AAAKOWlDQ1BQaG90b3Nob3AgSUNDIHByb2ZpbGUAAEjHnZZ3VFTXFofPvXd6oc0wAlKG3rvAANJ7k15FYZgZYCgDDjM0sSGiAhFFRJoiSFDEgNFQJFZEsRAUVLAHJAgoMRhFVCxvRtaLrqy89/Ly++Osb+2z97n77L3PWhcAkqcvl5cGSwGQyhPwgzyc6RGRUXTsAIABHmCAKQBMVka6X7B7CBDJy82FniFyAl8EAfB6WLwCcNPQM4BOB/+fpFnpfIHomAARm7M5GSwRF4g4JUuQLrbPipgalyxmGCVmvihBEcuJOWGRDT77LLKjmNmpPLaIxTmns1PZYu4V8bZMIUfEiK+ICzO5nCwR3xKxRoowlSviN+LYVA4zAwAUSWwXcFiJIjYRMYkfEuQi4uUA4EgJX3HcVyzgZAvEl3JJS8/hcxMSBXQdli7d1NqaQffkZKVwBALDACYrmcln013SUtOZvBwAFu/8WTLi2tJFRbY0tba0NDQzMv2qUP91829K3NtFehn4uWcQrf+L7a/80hoAYMyJarPziy2uCoDOLQDI3fti0zgAgKSobx3Xv7oPTTwviQJBuo2xcVZWlhGXwzISF/QP/U+Hv6GvvmckPu6P8tBdOfFMYYqALq4bKy0lTcinZ6QzWRy64Z+H+B8H/nUeBkGceA6fwxNFhImmjMtLELWbx+YKuGk8Opf3n5r4D8P+pMW5FonS+BFQY4yA1HUqQH7tBygKESDR+8Vd/6NvvvgwIH554SqTi3P/7zf9Z8Gl4iWDm/A5ziUohM4S8jMX98TPEqABAUgCKpAHykAd6ABDYAasgC1wBG7AG/iDEBAJVgMWSASpgA+yQB7YBApBMdgJ9oBqUAcaQTNoBcdBJzgFzoNL4Bq4AW6D+2AUTIBnYBa8BgsQBGEhMkSB5CEVSBPSh8wgBmQPuUG+UBAUCcVCCRAPEkJ50GaoGCqDqqF6qBn6HjoJnYeuQIPQXWgMmoZ+h97BCEyCqbASrAUbwwzYCfaBQ+BVcAK8Bs6FC+AdcCXcAB+FO+Dz8DX4NjwKP4PnEIAQERqiihgiDMQF8UeikHiEj6xHipAKpAFpRbqRPuQmMorMIG9RGBQFRUcZomxRnqhQFAu1BrUeVYKqRh1GdaB6UTdRY6hZ1Ec0Ga2I1kfboL3QEegEdBa6EF2BbkK3oy+ib6Mn0K8xGAwNo42xwnhiIjFJmLWYEsw+TBvmHGYQM46Zw2Kx8lh9rB3WH8vECrCF2CrsUexZ7BB2AvsGR8Sp4Mxw7rgoHA+Xj6vAHcGdwQ3hJnELeCm8Jt4G749n43PwpfhGfDf+On4Cv0CQJmgT7AghhCTCJkIloZVwkfCA8JJIJKoRrYmBRC5xI7GSeIx4mThGfEuSIemRXEjRJCFpB+kQ6RzpLuklmUzWIjuSo8gC8g5yM/kC+RH5jQRFwkjCS4ItsUGiRqJDYkjiuSReUlPSSXK1ZK5kheQJyeuSM1J4KS0pFymm1HqpGqmTUiNSc9IUaVNpf+lU6RLpI9JXpKdksDJaMm4ybJkCmYMyF2TGKQhFneJCYVE2UxopFykTVAxVm+pFTaIWU7+jDlBnZWVkl8mGyWbL1sielh2lITQtmhcthVZKO04bpr1borTEaQlnyfYlrUuGlszLLZVzlOPIFcm1yd2WeydPl3eTT5bfJd8p/1ABpaCnEKiQpbBf4aLCzFLqUtulrKVFS48vvacIK+opBimuVTyo2K84p6Ss5KGUrlSldEFpRpmm7KicpFyufEZ5WoWiYq/CVSlXOavylC5Ld6Kn0CvpvfRZVUVVT1Whar3qgOqCmrZaqFq+WpvaQ3WCOkM9Xr1cvUd9VkNFw08jT6NF454mXpOhmai5V7NPc15LWytca6tWp9aUtpy2l3audov2Ax2yjoPOGp0GnVu6GF2GbrLuPt0berCehV6iXo3edX1Y31Kfq79Pf9AAbWBtwDNoMBgxJBk6GWYathiOGdGMfI3yjTqNnhtrGEcZ7zLuM/5oYmGSYtJoct9UxtTbNN+02/R3Mz0zllmN2S1zsrm7+QbzLvMXy/SXcZbtX3bHgmLhZ7HVosfig6WVJd+y1XLaSsMq1qrWaoRBZQQwShiXrdHWztYbrE9Zv7WxtBHYHLf5zdbQNtn2iO3Ucu3lnOWNy8ft1OyYdvV2o/Z0+1j7A/ajDqoOTIcGh8eO6o5sxybHSSddpySno07PnU2c+c7tzvMuNi7rXM65Iq4erkWuA24ybqFu1W6P3NXcE9xb3Gc9LDzWepzzRHv6eO7yHPFS8mJ5NXvNelt5r/Pu9SH5BPtU+zz21fPl+3b7wX7efrv9HqzQXMFb0ekP/L38d/s/DNAOWBPwYyAmMCCwJvBJkGlQXlBfMCU4JvhI8OsQ55DSkPuhOqHC0J4wybDosOaw+XDX8LLw0QjjiHUR1yIVIrmRXVHYqLCopqi5lW4r96yciLaILoweXqW9KnvVldUKq1NWn46RjGHGnIhFx4bHHol9z/RnNjDn4rziauNmWS6svaxnbEd2OXuaY8cp40zG28WXxU8l2CXsTphOdEisSJzhunCruS+SPJPqkuaT/ZMPJX9KCU9pS8Wlxqae5Mnwknm9acpp2WmD6frphemja2zW7Fkzy/fhN2VAGasyugRU0c9Uv1BHuEU4lmmfWZP5Jiss60S2dDYvuz9HL2d7zmSue+63a1FrWWt78lTzNuWNrXNaV78eWh+3vmeD+oaCDRMbPTYe3kTYlLzpp3yT/LL8V5vDN3cXKBVsLBjf4rGlpVCikF84stV2a9021DbutoHt5turtn8sYhddLTYprih+X8IqufqN6TeV33zaEb9joNSydP9OzE7ezuFdDrsOl0mX5ZaN7/bb3VFOLy8qf7UnZs+VimUVdXsJe4V7Ryt9K7uqNKp2Vr2vTqy+XeNc01arWLu9dn4fe9/Qfsf9rXVKdcV17w5wD9yp96jvaNBqqDiIOZh58EljWGPft4xvm5sUmoqbPhziHRo9HHS4t9mqufmI4pHSFrhF2DJ9NProje9cv+tqNWytb6O1FR8Dx4THnn4f+/3wcZ/jPScYJ1p/0Pyhtp3SXtQBdeR0zHYmdo52RXYNnvQ+2dNt293+o9GPh06pnqo5LXu69AzhTMGZT2dzz86dSz83cz7h/HhPTM/9CxEXbvUG9g5c9Ll4+ZL7pQt9Tn1nL9tdPnXF5srJq4yrndcsr3X0W/S3/2TxU/uA5UDHdavrXTesb3QPLh88M+QwdP6m681Lt7xuXbu94vbgcOjwnZHokdE77DtTd1PuvriXeW/h/sYH6AdFD6UeVjxSfNTws+7PbaOWo6fHXMf6Hwc/vj/OGn/2S8Yv7ycKnpCfVEyqTDZPmU2dmnafvvF05dOJZ+nPFmYKf5X+tfa5zvMffnP8rX82YnbiBf/Fp99LXsq/PPRq2aueuYC5R69TXy/MF72Rf3P4LeNt37vwd5MLWe+x7ys/6H7o/ujz8cGn1E+f/gUDmPP8usTo0wAAAAlwSFlzAAALEwAACxMBAJqcGAAAAbJJREFUWEfVlDFuwlAQRDlK2pRcxSVlrsBVKDkG10jJNVLSOhrLzxptxoCCApuVnvw9HzPPxslmHMfWxLATMexEDDsRw07EsBMx7EQMOxHDTsSwcmu22+3tD61M6nNiWLk2kjvsP8ffSqY+J4aVa/NvBIdhmCRh3v4xdT/1OTGsrI2KkBOnw3k61zGJ6py9OYp9Tgwra6MiiSHFEXSODHLiqYKU7nfHZe0gyb7LaVKfE8NKGhVpVLomB77/dEE9IQms/cwup7VwSTrWiGHFR18u9O7tTpdFDlENmQvyGa3/RBAxivjjQAa54/lrwiUdl9PQsUYMKy7mKHdB5PzJ+r8frbnR2S/2OTGsaPSlPDUv0VEZkvVn1zXAU0RU16c+J4YVxsV8yJFyOaSAPa11Te2qxLBy76hwknp/W+QkoyfKmpsRuib1OTGs3DOUSubyMUxHSSKqI1I+qc+JYeXWIMbPqjUgqfVLBXm3EBFVNkmmPieGlXsGSRfQWlIu+lLBWq5RxjtYb0CT+pwYVh4ZxGGOl0l9Tgw7EcNOxLATMexEDDsRw07EsBMx7EQMOxHDPoybb9GwV77o6gLYAAAAAElFTkSuQmCC",
            } },
{323,
            new Items.Pokemon()
            {
                Name = "Barboach",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGBSURBVFhHzZVdToNAFEa7JUC6B+sTQ1cBrgTYhT8L0PgCYRWmbkbNdS5xyDB8VGlo8j2chDnTlMOd0O5EhBoomYCSCSiZgJIJKJmAkgkomYCSCSiZgJIJKJmAkgko/2K/30sURfYS728JlOdI01Sy6l2iOLHLqb9GNJRL6ORQnPri5VOi5Gb0W00ZSsTaOHWm+Zh9fi1QIsJAN6HFuPwoxevXZO8SoAxBcVmWDQEa0nWdJEkyBLvo8k02OXIoQ1ygMcfhJm3bSp7nk8C+70fy5jQ5WjfVMPo/QInwI40xs+lptB+p+FO9LR4kq09yKJ/sOrZfie8TAuUS/iQc/gR1qhqv66ZpZtyVj/bBvldNEcol/N/A4UWwb6lOtK7rMUIDHer9aw3UKa55s6E8x3jUv3HuqN1RVlUFQ+M4Hh7qcP98vSN2aKTGhNf+2oUqGqd7l/zbQLkFLnRtUAiUTEDJBJRMQMkElExAyQSUTEDJBJRMQMkElExAyQSUTEDJg+x+AEJGMW6m3YHaAAAAAElFTkSuQmCC",
            } },
{324,
            new Items.Pokemon()
            {
                Name = "Whiscash",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI5SURBVFhHzZa9ctNAFEbzSrJs94SKUj8NlCE0dIS3CKkYqsyk0oSGjoQUdsxLBGiYofLAQ1jist+aq1ltPhk5DplbnLF1okQnd9eb7ImIaai0BJWWoNISVFqCSktQaQkqLUGlJai0BJWbmE6nkiSJe8u/ft9Q2QfiZtUjWZzvSzr6d+R9/DJUMjQOYXiovo/vU3D/q9lK8qLcKZLKmDAudH0P1rjXC/GM0rHTm7+nDypjWKB6PDBE/dO33/30juZ1O8XlzbH8+nYiaTry9w2BypDJZHIrDg4PzA4+Sv78U4ckSSXLMh/47N0PDwKXN2+kLHPJ89y/HxpJZUg8PVwjbPnlRMrDS5lXj6U4vGiv29i8aKeocRqdjFK/BXTpN0FlSBgYTg1BWC5lcb4ObQOD0Djw6Pp3Z29ugsoYPzW3bHVdS/niyj9YJ4fXn1+Pu9MjcfmBi3fXWGLsyyFxgEoGIk+rmYuKIgJOq2tpmkbO3n9e3xcH/r0P+zT++X1QGYM4PdPCB8XUdSPj8VhWq9V60g8ZiP2DveMj3TJ5otjOBIvd4wCVjDBSD+BObIgL8p/qIA5hek5uA5UxOPf0yEBA/GmMYVth28kpVMbo9HB+4cgpiqwTGnJrqjssL6CSgUh9xVIhFP/VaKwGI3Be7bf/8YRn538NjNFQRf+86QcJLr5Xr7eByruAiCcvP7hDuBl8CA+Byruyy6T6oNISVFqCSktQaQkqLUGlJai0BJWWoNISVFqCSjvI3h893+h6D9JKHAAAAABJRU5ErkJggg==",
            } },
{325,
            new Items.Pokemon()
            {
                Name = "Luvdisc",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFaSURBVFhHzZZBTsJQFEXZUmvbCaug7IIOZSI4hIk6MmEF6AYgTEwcCWxA4kYIdiDk2Vf9TW1uCe2P+XdwBj0Nyclr/6MdEaEGSiagZAJKJqBkAkomoGQCSiagZAJKJqBkAkoboigSz/MKqvebAmVbNO6x15PTci6yepZZvy++ZSSUbdC4l8Egi3uSdPxQEPh+dhv/5hKgbIMGfi3mf+KU1ySRK4spQtmUMAzh9Aw2U4SyKXXTMzgNNHF6KEyMTvNzdJ9fO3/E5elpzOl4lCAIZH9zl7tZHFudZCgvReP272+Sfmwlvf15nN04ySaYFBN0dopN3HQ6lMnkWg67dRGZs9vk107XDJpgNZDiHTTvWx3O14zuwXORzgN1iuXVUobin0Spi3R6SKpopH7NHH4jbXegAqUNGkn7PfgfQMkElExAyQSUTEDJBJRMQMkElExAyQSUTEDJg3S+AfdRdIKjIeDDAAAAAElFTkSuQmCC",
            } },
{326,
            new Items.Pokemon()
            {
                Name = "Corphish",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIVSURBVFhHzZVNTttQFIXZUnASCWakjOgodiZUXUXbSUFsgrYTFEYVLIKIUUs2QdURtAsoiEEQl3decsjDOqZxnFY30ifLx39fTt511szMNTL0hAw9IUNPyNATMvSEDD0hQ0/I0BMy9IQMl6Hb7YaNPtYEGdYFcn8+bll7vRV29TnLIsNFgFSrNRXCtiyYHm+CDBcBAt92t6LEcGfDbvfmgqtsVIZVsBU20+l0rN/v281ez+72ezZ+07NMtNkEGSrYGCQoAlEKHocW0WQx2/+vgmgqlSNFPpfDT4wWwarkgAzLsD00dDHbsilKkYf7e7s72H4mWV4adZChIkqeHdnw9aZdjI6sKIooOJi1SLl2u22TycTGb7eflgHWJL9A3XZlqKDg+Hz4TO7qcmSDwXQfgvxAkEuAcstIyrAKSlLw9NM7u/4xst8/z6Pk992pZFkuXaMcsPK9q5DhS3A9YXrR3umXD3by+X2QzqOgGqDry7Mg/Srmv8I1WZaFW+n7l5Hh34AkBL8ezhtMW1SCPKeOHJDhS8SfOUwyBNIGq1rEOZT/p1MMnt6HYYqzbD0+8CpphwMESchxm+d5BPt11h+QYRVsjw+BMCQ53SSdcopBFOfWbVGGVXBAqvIUvvsgyax83SLIsCkcIrTY9G9PhqsgbbV8rA4y9IQMPSFDT8jQEzL0hAw9IUNPyNATMvSEDD0hQz/Y2iMmZQu9PXkRSQAAAABJRU5ErkJggg==",
            } },
{327,
            new Items.Pokemon()
            {
                Name = "Crawdaunt",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJ5SURBVFhHzZY9ctNQFIWzJf/2MTQJbix7BUmqwAaAJcAKMnQZaIybZJINhKHhp/GQJpAVeEIBDIUdLjrPPs7Lm6NY9qi4mflG0vFI+nSun5wtM3ONDD0hQ0/I0BMy9IQMPSFDT8jQEzLchHa7bbVaLd/Vn2+KDNcFcr/G29ZsOBNstVqhNcj9vez4EkRrJ0fbdvamY3++dYLgeb7fqFcrKcOycLSQi6mySRmWhYJoDi26apByg0HPTo/mgtif7O1ao8LVLMMiIIVFQXq9udAg69nv8Z3gz/3qJGWYQrGTnXxR7HaW9BeCEIIkZWezWS47COeo68TZKmQYg4uiqdNILJUjlGs2mzadTsM2vs5kb2ftdmUYg3cdm7vJbxALXn0+tpuDJ3a92FKQf2wRUI6UlZRhDJ4cghBCi/EWgtdf3y6JJSGXZdly7GnblQkCfncwatz0w/CF9fuZHQ5n9v3LuyD3bHRrk4NuuDmEKMdjPBQmgGNMoFJBgFFDEHIfRy+DYPZqbIfv/9nTkVn2+jIw2Z9LxqJsPN7HtoykDFPQ4MXweRADjXo9yKJBilE0bpEybByCpOxqlqGC/xjwwpC++nQcRgsxwHGfdR/dW0z3Ws/lcIyH5LUfQoZl4OL5kUtCKN1Sjo1RkhNIr1eEDB8iXTAYI9uKoVw63rKjJTIsgu9Ersb4e0bZtDXIYTVDGuet85IGMiwC7eGFi5vhRmwy/Y5RiLJ83bDddSRlWATHG4+JGVc5G2PD+GzTXxEgw02IVzmlKIKHwG/zefex3S5+q3neKmRYBZBKjykf56uQoSdk6AkZekKGnpChJ2ToCRl6QoaekKEfbOs/HlXO/zztCF8AAAAASUVORK5CYII=",
            } },
{328,
            new Items.Pokemon()
            {
                Name = "Feebas",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI2SURBVFhHzZaxUtRQFIZ5pc3u5h0Um03SYKkd6wuonUCDWwW2waVCXwCxUakUGx0bZ2wQKh0eAAaKXeaY/8azXO78WcKGcU7xzeb+yWS/OTfnJAsiYhoaWoKGlqChJWhoCRpagoaWoKElaGgJGtal2+1Kq9UqDst1HMfX1ncBDesCwXz3VKJ2x4npcXhdE2hYFxXcfHcxxZzg8tZv2dg7lzTNJH97Zk/w3ouvklsVBGgMbDME77pBAA1vAwSxzf3RibSiNpXENWFWFxrWQUfK4aencvzluWyvJfLr8zN33G5HU1Gt8LxbT8ObwJ+qmI8vieMoKkdPk+6m4Swg935nSY4OSpH9Nw8duvYlszRp3Dg0nIUK+lIQSZJEDgsxXxA8WPvmns3wPnWhYRVx3HVb61fNVSnPiy5OqeST0Z9pA4X3qwMNq8DcC589CE4mExkOh04yFMT5+yvzV5GGVYSCqOLl5USyLHOS+EUVt1ZKQZxPC8Em85GGs/AlVbDT6ch4PL4m+PH1koxWE0mLNebkf6kgUEHdxnCLPxQNpGKQ9Yd4eK860LAKyJ2ur8vFYOA4PrjqYAXV29w7c7MPr7+mkjSsAoK9Xk9+PFqWn4/7jqN/VVS5/qvy62Zx9bv7iNAhPe9zSMNZQBJz8Hzw0lURkvs75djRrcVwhhgk591ahYY3AUlURAe2dqpP01ecQsO6qCioOhfmt4WGlqChJWhoCRpagoaWoKElaGgJGlqChpagoR1k4S/sKjNRLs2NSwAAAABJRU5ErkJggg==",
            } },
{329,
            new Items.Pokemon()
            {
                Name = "Milotic",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKySURBVFhHzZZdTttAFIXZUhLHEsuIHUVq1SdbvNC+QHbQn0003QHtSyteGrUb6M8GaPuEyiIMTOdMOOZmOHaMCtI8fMI5Hjyf78ydZM85lzQyTAkZpoQMU0KGKSHDlJBhSsgwJWSYEjK05HnuRqORv+zPHgsZEoh8flK5iRBszt66bDJu88eSliHok/v2sXLXv1d3BM8Pj/z42+whkCHoE0T13J93W4K8pySRq+vpdNpedyFDgH+OBZGxehCMJXE/FkRWnTRuNM7CFlDXHKuQIbGSeCAr9/VZ7f4eHrsvT+sA70NuXhRbe5GC9QcXZDimOrlsM45VyNBCSYhcna1auYvnyzBR4Tk3n2O52WzWjsF9OxbXu/asDGPsvqMgJrj02cWLWzErB1i9opwHmQNfNV4/qOBisQgyVvD618r9PK1dWRZuLZoJQBBLSjEsK/8OWV4gQ4utngXNgYphCbsEgZWEVL184+r3V0E0rrhChhZMEAtCrmkal2XZliCXOZ4YL4nMNssQOSDDmLiK83np1vv77senql3i8mZPHRy/ChVSEnjOkKPFIkNFnm868ruXwt4jsSA6lJLxPgtNc/SyfQHmfcjQgoeiElxKiODYoCgE2ZUVxJav7zAabzo1CJpl5hx9yJBw/4Ul9XI4C60gvlFwj5WDZGgED8YGQVPJUL2b7L8FIWcPWcpBDFXjsRMLotqklYS07961/4ysq+MVMgQQxPGAiTk5pCBEOds0lLQHLyS5zJTDSyLnmF3IkNgqxlIWK0hJVpFLHs4/L8r9OBQZEu5BJUVsN1tJgpcDFI7n2IUMLV2SFCOTyUbAbgssKX9Y7PrO7UKGMZDE5Pgt2CUWj6Ukl5v374sMu+DklngMGTJmCDJMCRmmhAxTQoYpIcOUkGFKyDAlZJgSMkwHt/cPP/m2/sHa5PEAAAAASUVORK5CYII=",
            } },
{330,
            new Items.Pokemon()
            {
                Name = "Carvanha",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIDSURBVFhHzZZNTsJQFEbdUvmLxhHVCTACOtE48mcCy6qOjBsAXYXRCcImJDqAeH1f8cKjfrbQKN7BCc0p0JPb95ruiYhpqLQElZag0hJUWoJKS1BpCSotQaUlqLQElVlUq1UJgsAdbn4u6zd5UJlFrVaT11FdKuX1C2b50fmJlHcd+HATSrm0uigL1Li3l/Bb+KZQmQULxC30nd7Ofw/0g/zA/UbsXGkZ9z5ZfTf9f3lQmQciB/Ei6LAVy3R0tAxWd9C8SSI1vNttF9ooVOahgQhp9J5k+nKcRLT6j9LsPydxCiLx3SLTA1T+BMIwhUbvUYbXx8sg/9iP08B2u9j0AJUMbARMAreq0+lI00UiSKMwySAoJyFYgxo4iBe3398820DlT2CCmMZ8PpcoipLIdidyIYtNMZvNpFKpJIEIexsvNojPtruZyiwQiRAEYpd+fMXqMQJxHLkpD+NwGRlFO9okCETA5OI0QQMx1cnVmdw1Qxm78/jsumljOYA/X4M+6cg0iFMQiUnqOkz/Vx5U5qFrcToKZXK5HpqOu3Wf9y5wp89BgEhcUB/Yd61VWMl5nAO3jXoSuJPnIENfpTBRttZwHpGI9v2mULkt6ZcFdj4dvilUbosGFn1jyYLKIiAy7X4DKi1BpSWotASVlqDSElRagkpLUGkJKi1BpSWotIPsfQLoywKMZNDRdQAAAABJRU5ErkJggg==",
            } },
{331,
            new Items.Pokemon()
            {
                Name = "Sharpedo",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIZSURBVFhHzZRNTsJQFEbdEgKNJE5EN0BhUnAj/qzE6MjIxOhIJxAYugGjK/BnAWocgF7f13rx0XxV2kK8JifiodiT+8pdExHTUGkJKi1BpSWotASVlqDSElRagsoy1Ot1qVQq7iV/Py9UFiUIAon2JlJZr7k/+TV5obIIGtfonrgJrjvFr8sLlUUwHbiqOEBlXhC4ER25wOMYUxPEt1ant+w4QGUeEOhP798miGPEfvN3nLp0YLT/Ea+aZexDKhn+c4YJ4eY42jDsSMMLRFz3QGaU3YlUMvzAVth2IdO5kN8oE0llFohstVry+tCU3cOpnF/15eL6TN6etuXy+lR6Bz/Tw2TDMIwpc9RUZoHAl4cteX9uzsgK8ydcZj9SydA4BGFiiMMUNULjso6+6DFTyQiCZN/pDV8fd+am58chRq8tux+pTKPLWOMURGKKGocwfJF0zehrvR4u7/NIZRoETiYTObkR6R3ORwIE4sa30ZZUv9ePP8U0eC99jyyoZGgk++l0kl2IY8TU9Le/jnR6K5mggkjcQEPH47GMRqOYdrs9t7AVXer4fBGo/AuEYh+eNppy5riLmnLfTRgNh7PgMmEKlX+hx93f3JnFfU6n7q3kuLEHhy60Wq1C0f+xKFQuQvqZrNWSZ2wwGMQTXEYcoHJR9Jn0jxIOkSYCs9DwtC8ClZag0hJUWoJKS1BpCSotQaUlqLSDrH0B0q0XZwZs4sEAAAAASUVORK5CYII=",
            } },
{332,
            new Items.Pokemon()
            {
                Name = "Trapinch",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJBSURBVFhHzZVbbtpQFEUzJSgYMww/0nw3kH4HAx1HHu1cAlbn0AhCptG0pJEK5PRsw22NtR0IsarzsSS8wWZpn3uvj0TENDS0BA0tQUNL0NASNLQEDS1BQ0vQ0BI0tAQN96HZbEqtVtui+JsqoOFLOLGfVz15+tz/y6zfkXf16kVpWAbkvl+cb4kVcaLFew+FhmVAMA5Dedi0V2zRUaUkDRmQi8JA5teJxFEo86tETqJIbpNT+aVZUbJRr+tt/FmvgYYMCOYbyyRzsi5He2g5VKpYjzRkFAUdEHy47Mnj9b/r5XIpcRzbEDyJo6ytAOPH2DfX+FzFmGnIaLfbMunx9QbcqF2TbtRo8S1N0rAMtPjjwrW4LfpeBdHcsW6ciW4cJwhpyB8qScMyIHirLc6SjjzmNga4H3QyKYeTc98fOm4avgRGDcmpSkI0LwWwDLYF15LPq6U0Gg19BH9uGTTche/74tqE6FSFHMc6Toz5bnAm958+6ppMZLVYyGx4lom/9gCn4b54nh7eQaBrLNJDfC2WNTvoyvPit2htMh12JR2PVbj7fwXR4Pg0kK+dUMY3NzLRP7/rq4Q2tdJz8OnLMBtttnmCUL6df8jkfa+lt/NnMmi4D1iLIxVMVbDV8sTzPBmNRpKmacZ8c9xg80QqiO9B8Tm7oOG+QDL/p9m1Not2IY/195YdDGhYBZDFKxDva7/V1Ij/bhc0rIp1w4fLARpagoaWoKElaGgJGlqChpagoSVoaAkaWoKGlqChHeToD2p8ON3ibjrzAAAAAElFTkSuQmCC",
            } },
{333,
            new Items.Pokemon()
            {
                Name = "Vibrava",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJVSURBVFhHzZVbTttAFIbZUuwkUnaBL7CAmJfCk2OyiFbdRAtsgF7euT6RrgXEtVKk0/knHDOy/jR2iNB5+BT7n7Hn85njeEtETENDS9DQEjS0BA0tQUNL0NASNLQEDS1BQ0vQcFMMBgPp9XrukI+3gYabAoJlWUoURe6Uz1kFDd9DWDUcJ18SmVSTWlLHFWT/g4broAuHFVPB9GvqJXW8qirPhwlCBAunP5zI4Vu1dCysYnLqhH+lHycYymHhpqDOub8/kvx3tnTOMmjYlqYcWxxzbm+/Sb8fSxwvaFM5hYZtYYJlVcpwOHTDi3HIQCrsvbbVAzRsS1MQ1QvlIOulppUUs0LGN2PfizqnDTRsSygYbi1yiGQ/MxnPxlL8cXLut0vvKTRchW4dSBL3hk4mkqZpnUG6uCm8mIKHCLe/LTRchopB6vJyX56ejuX5+UTyPPPnWeYqCVkno5Xbm+15qsNuvafQMCSs1sXFvlxfH3hUToEk5ObzubtMZDqd1i8FKoqxrtUDNFQgF0qhQtjKh4cjLxVmQOXyPK8zoA+Ie3aFhiGj0ajeVix2d/ddHh+PfcVw/vL3xf3H9RdfCCd7fo4HWjxUHK8vptCwCSTxJUDVdnezWg69Fg0iifqvn7DXakIScrgWu6BtovfrAg0ZkEQVsfjV1YHs7KSSfF5Ibp9uezn0GFAZXLNO34XQcBm64NnZJ/fWvvWfiuk8VEyP3wsNV6GiTTEAOfSkbm04tg40XJdNbGkTGlqChpagoSVoaAkaWoKGlqChJWhoCRpagoZ2kK1/8n7gjsBuHncAAAAASUVORK5CYII=",
            } },
{334,
            new Items.Pokemon()
            {
                Name = "Flygon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAM6SURBVFhHzZbLTttAFIZ5pdhOlLDDdJOkXdgxlaDdtKgP0MsGkqdg1SbhBVqo1AtPwaVSQTwFbRdUFVRIp+cfc8wwHMdJ6GIWnxL/tjOfz8zxZIGIvEYNfUINfUINfUINfUINfUINfUINfUINZ6Ver1OtVjO452xwnZtVoYbTYEstbSxR3I8pSZMic2Vx/eelVQqdvAo1nISI2VJpmuYMmXEOztWCXEbkfr4a0l78xEiWPYiLGpaBge6IKVL2wLgnSRI6Y7ntgy79eDOkLO2Z41+vxxQGgbmuDDXUqDd4oCFLQaZXLnbrHpY7bj+n0846ZUlKmx9afG8uO9hZpJPu88opV0OXKAxv5FxYdtI0iSQEv8Sr1OPP404uVjW9QA1tAp4CTEX2rkfp6K6cDObeZwNJyGCqsSymERPUUIhYDj8KwZWMBd/yAJAEPNDV1RWdPnxBf7Z+UxREfMvNvSJly5j1yDMhzTMNagjww3vxGvW4GU666zQ+6FC2klCWpQV4AFx3vnV+SxAiZy/zJpBGENnhfpuC8D8INhoNXjNrZjGj60aHXRofdQpwjMUPSchIN8qaG+/fXIvOdWVlnCrUUIDkJ17YqKRICj2u4NflNfrefka4DteL3IC7dXTYvvVArmzV60VQQ5tWq2UqaSS5AyGK9Tf4yJXFNEf5QKgKlgLk+rs5riTkUPVZdhM1dEGFimo+eGqqZw8csiSAMCQhAWSapWp4uFmmF6hhGajm5eUl9XldYmBM9fa3R4Uojs3uwuAhZLeQquNFHczQwUANJxHVI/P+gwwq9vfiwky3keNjgBwPAUmIxZux2W3s/Xla1LAMNAH24uVBbAZG1fDqwaep3PULfHTETfQ4l8RajPv5/j2rHFDDMprNJsUbsRkU1UHVRtdTi6qJYLaNc7n05k6L8GDA/b1pUMNJoFkwaCHJL/CimiwG8H140Db5vGKCGlaBTuzvLhpR6XB8h5iAhmjcUw6oYRUQwsK3Xxl2ZTfeN6nRvL8cUMNpkMrZWRAGprKz7LVVqOE8QBb/clBZ/Ll1z8+LGs6LVtX7ooY+oYY+oYY+oYY+oYY+oYY+oYY+oYY+oYb+QAv/ACDmi6wrTA90AAAAAElFTkSuQmCC",
            } },
{335,
            new Items.Pokemon()
            {
                Name = "Makuhita",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJYSURBVFhHzZTNctJgFIZ7SyQkhKVxBa5IQnodCV34M27q3y20TK/Av25tod6LSodRK52K4vJ4zheCDL4gX5ixZ/EM5WHKPD0np3tEpBooNQGlJqDUBJSagFITUGoCSk1AqQkoNQGlLZ7n8Qv+bFegtEHiplcZ1V2H3/792aqzBUobysBf1z0TWavVWG8OtwFKG8qQJInox1W+CF2OXv0dG6C0RSJfHd6hn99yGl+06c3T0Pz89llIjlNMtCpQ2iBxSczTmweVcTLRct27AOW2NII/zx9i1/UKUG6DTE6eueXnrUSmKa+ybte9hRWbw8ge0OxrcaXlcUz5vazVq7u3dyQSV6s5dMOB4+E9mk04blJMruG7RWg50d4jQ92pHgnlOiSu3z+ng4PHFEURfTpv8YF06PvnjA+jtyBN+Wjyh2bFJrD+HwOPjt6ZyG43oZeHIY0GbUq7EXX5aksu2U3z+yYuTWK65ElXvWgo1xEEAWW8WpmeHMJ+GlMcdejjWctELFPGymdJkhiqREK5iWazSb7v0w2vdXad0+mLuyZSooWYVy5h8v9QQiXs5OTC4LoufwX+3nVAuQ2B75lI+aec7se88oLRoGWePUGC+/3BPHBIPV65Y3kwUP4LmeIHWR1PS57D6ZfMrHw2yWj8nlfMkYJM8vj4bBEnj4dMf/X7NgHlNpSrNvDxyAFJtBzI6fPQHM7rJyFPsUM5X7RgGydAWZXl51MmOhq2qdmY/xEV4gQod6UI9SpHLQOlJqDUBJSagFITUGoCSk1AqQkoNQGlJqDUBJR6oL3fg7JCmDt0/IcAAAAASUVORK5CYII=",
            } },
{336,
            new Items.Pokemon()
            {
                Name = "Hariyama",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAMfSURBVFhHzZbPThNRFMZ5pYKU9hFaWDBzp62IG4os0KcQ3SiwEV0A7owmCj6A/HMNFBIVMQY0MUF8BaGlx/Pd9pTx5gBTCuQufqF8M5n59bvnzrSLiLxGDX1CDX1CDX1CDX1CDX1CDX1CDX1CDTuht7eXUqmUxT12GdTwMohYdW+B6Od7y62ebj6kn58UNUxCvClXDOyuTlHPTQvGpcpDcxSGhmqOmMhFJrTnuddoFzXUgNzBxH368/gBRWFoBWt7i6pY2Dw+euclS3bWohpqnCeoiQk3IphJp8kEg3TwqCFoWKY8NNsSjCLznxiWHrKy/J1sFjWMI81tj+bpkAUr5TyVjKGgKTB297QtEXs1GdLJ/gK9mTb0dWWyo82ihnGy2Sz9ejhumwMlbqu2v0jFwmlrxkR2Q1SrVdpdm7ZLLsQ3i2wyuXYS1NBFWsTsQc6du88fntDOSkPo9VRIhjPk4MvypM3RosxwT3dySTXUkG9//P2tFRS+cWOlYtQSiksJIi0zfC2CAJKfuC3MV1xSA2LSMBA5zLIJg8RLrYYakFt+luJ5C+zNdnn46yxa33tH9R+NZZddK3IihdHQPidpUg1dILfEcqAYBa1NczgxTpvcyM7SUytViE4bs63FNpfGlQliJ0OuEA1SdSNHxWJDsnKvn4q8XFFTbHmmm1afpyw4d30kZx9NrhhavJYlrm7m6OOLFNW38tzkIIsFtMJSWPo1iM005MDJVo5KhcY4QOo30+78ATXUyGYzdLSeo1olT7Sdb4lCGm8S5JLhb20jT3U+L+KZxdLb5Q9Cfm7Os2DyB7cangVaDPmV95eX+WSr3wK5EX7tHW/0W3FhbHiOswErGc9Gbs9SX7qPL6ffw0UNzwKzuF7OUYFbwS4NgsC+k3FDfD7i1moViA/wK3DevmUgif/R8L3h9uSAGp6HSFZ4njJ9aUrzDwnJ09wwhLGMLlFg2po9QQ0vwso0xVyymQxhFHAcrWJToG3saHwh9/yLUMOrwm3bPZ4ENbxKzms7CWroE2roE2roE2roE2roE2roE2roE2roE2roD9T1Dwtt+mRpZpobAAAAAElFTkSuQmCC",
            } },
{337,
            new Items.Pokemon()
            {
                Name = "Electrike",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAG/SURBVFhHzZVNTsJQFEbZDows2M41boDK0BHEAW0YiDsQ3ITRqQvwZ2LUDaisQnQBog5acu1tc+G1+dpaFL2DE8J5JT25fa/UiEg1UGoCSk1AqQkoNQGlJqDUBJSagFITUGoCSk1AqQko14HjONEHXisCyt+G496e67TZ2oi+4mvygLIqtm2TZVkpsuv/EsiT4ZijB4/GEz9Fs5VEyvT2z/pkNdPh3wHKMorC3F2XXDdBptk98ah36v9NIMcVhY0el2vvLw3qdNqx50gOzD7+MqDMoyiOA0ZPaS+BvCbXVJ0ilIiiuFm0x44n/ZQ344ZXfvyIV3nMUCLMQLkZT4xDPl+XgfLdjDu8TpCDUwUo8+BIvuls2ohPJUeG85Duz/foY1pfhMme4+kOL704bpXpMVDmIe8zDmH4vRYEQTS9wWKy5sQkimPXHsjTk7jsfpM4OQiy5ziIT+3BRXKA1vqIJVDibnd6dLfdo3G0L82YdjvZe+bE+LdVXy8ClHnIX9rNVjeOm4dhtBcHqRA+SKseCASUZchEBLRmup8ApSag1ASUmoBSE1BqAkpNQKkJKDUBpSag1ASUmoBSE1DqgWpfTPQqn+BcYqsAAAAASUVORK5CYII=",
            } },
{338,
            new Items.Pokemon()
            {
                Name = "Manectric",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJjSURBVFhHzZY9UttQFIXZki3sHpMNWFLjJF26/DR0mKRi2ECGrCCQBYQkhWxnA8Gp0uFkBUwoMKawyUVHzIVn5UjznhmYW3wzmqNn6/N97155TURMQ0NL0NASNLQEDS1BQ0vQ0BI0tAQNQ2i329JoNPJLfv++0NAXyJ2fb8ufn08lih5Gkoa+tFqtQnD0qSNR05CgbivkLi93bAlC7uRHT9Iklum0X8jNLvqF6Pp6M1/CP1POfKFhHXhY9nHjVkoFq84h1m9np9KMov/u+UDDOlxBt3oQZJKPKlhXvTrBl+8/S3/4dyVJGlZRFlRUbm9vSybHd5JY3+12c8GjxxPUzlWx1/tH8mr/q0zGz5YE0eXaTBDEGtBohknSsAqde5B78+GL/HqxKf8Wi/z6WyGolYTU7u6WDA86kiRdieMbyThJgt86NGS41YPc4upK0jSVRS747vuZDA6fyO9xb0myPziVndFZLpYWgtOL6lFUBQ0ZKojGeDu8ebAyGT+X0WGnENQtx5lTOczLNI3l5Lh3u/3l76+ChlVAEiMDD9YzNTjYXKocBFXOFUTl8eOwttzpddCwDkiiAgAdXd5W7ViVQ9Vms7tZGSIHaOgDRDHfcK6wfdoI5epBUH+A8qAVVFQQnVkWc3ElcU5D/1TQ0Jc6SQxlHAO9jwqHjhhAQ18wF/UsYt7pWHHfGFiTZVnePOFDGtAwBLeK2q1A553bVPqZEGjoCx6O6iS5HAY23ig6jFcVKkNDX9zqgPl8XkiuspVV0HAV7ruVVdDQEjS0BA0tQUNL0NASNLQEDS1BQ0vQ0A6ydg3kIzaW8Ya5UAAAAABJRU5ErkJggg==",
            } },
{339,
            new Items.Pokemon()
            {
                Name = "Numel",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH/SURBVFhHzZY7TgJRFIbdEijsQaxmoAF3oKU2Pjq18bEBoytQNmBiJdIINJQ+VmBiYWEheLz/HU+83vwgL/EUXwzfDOTLOc6FBRExDZWWoNISVFqCSktQaQkqLUGlJai0BJWWoNISVP5GoVCQXC7nia/NGiqHgbgkSaRxUZVmvSaL+SxUY2cdT+UwisWi3HzFne2UpJwm0rsvyfluSfIu9vBuTY4765784vShVA4DgZhgmqYexMlTRqWSyFHrOzAMjT9nVKgchk7w4zGbWv8hi2vWq1Iupz4wdX8RH8ZOGknlIMI4BGnk7eV3XDi5kLkFYr1YqwZirXg9aL2g7+7DlJcmiKRyEAh8v1/2MfH/YLjifwnE8fH6fCVvL9eej6cVOdis+ie32+26wFUfiOCTThapYcpcA8HB5qr0ez13WdxUKz+eaAWxCMWE9dzE540KlQwW2Gnuu8ia7G/UpHGZnYt4quMJatyfBoIwEnFn7gnGQa3fKgoenjgM68d9fxoI9KtMD+vT7ZKfHI6aMDKkfbs3v0AFoadbyz6u3djz04xDEdVy1yaNA1SOAgIxRUwQa0YI1q4xYeQ0Px6oHBVdd4j+kAgD4/eNA5WTomvXNWPlOCfj+8aBymmIpxpfHxcqLUGlJai0BJWWoNISVFqCSktQaQkqLUGlJai0gyx8Ao2cOYIpq3ssAAAAAElFTkSuQmCC",
            } },
{340,
            new Items.Pokemon()
            {
                Name = "Camerupt",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJtSURBVFhHzZZPTiJBFMa9Es3AJWY20GxATgBuFOYSghcAXI1xY+IBnD8XUHtj9CLDjAuGvKmvzes8Xj6wlTYpkl+a/qqp/vGquroORCRqaBgTNIwJGsYEDWOChjFBw5igYUzQMCZoWBWNRkNqtdoG/prXoGEVNJtNOT4eyN3dd8mynznj8ZEkydskafgWIMKqhPz29kbSNJV2u50D2Xq9nreXhYZl2VWl2exUFoup3N//KNpwDpIkCT/nfXpoWBbMMVYlnM9mk1xmNBoWzOcv2YcJ6qS331EpX6U0be8U/DPtyaeSc5GGHvs0/j7t5p2r3DYJSJ6cDDbawHLSk+cgCMpI0tCDufYw6EonDOFy0s07x3cMKSplBWyV9Pqvo8GG2JeLf7Kc9j9GEMe/4WZ6cxx9payMBWLfFtdB/rC0JA0VXUKsnBWzR18ljwrZ48OwL/XQv7+vhYZAq/Y07OVABEMKGX9zbWPtTKwSQaAVbLVaVMyjf0SvtTI6tJfzq2KI9xYEeIJ13nkhxUrZ822Cny/WpeQADS0QXK1W8nzWLwRQKQjbox1mHWomqJXDbyoVzLJf8nh0KFl4U9jFFm2dTmdjvqq4FYSUlQPj8PS/tnmgoQeSeKXZt8V6vQ5NLx8mqHgpVNpeu/ccBF7QSp6fnxVvjm2SipcDlTwkXs5KKkxQhSCh66nP/f08NLRAEMuM3VLZ3YqX06ddRSBm+8K5ovkuaOjRjrE5sO9bgK0T/gAE7VKkVSxTpV3QcBu+AloFrTIk7TzzFXwPNHwPTH5fOUDDmKBhTNAwJmgYEzSMCRrGBA1jgoYxQcN4kIP/Bp/ZdgcY09oAAAAASUVORK5CYII=",
            } },
{341,
            new Items.Pokemon()
            {
                Name = "Spheal",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHhSURBVFhHzZVLTsJQFIbZEs+5yAZouwKUibIBwRXwmLgFxQngwC1onChuoOjI6AIUHfA43r/mNqX8EF6SQ/IF+Arly7m3JSEiqqFSE1RqgkpNUKkJKjVBpSao1ASVmqBSE1RqgkpNULkquVxOksmkecmP7wIqVyGbzUqp/ihHzWdJptJB6H/EUrkMO7WDk0vJn7al3hlKs/cTkkpldhpL5SIQNxqNxPM8aXS+ZsLAYeU6DHZcbyeRVC4CgcVikcbFQSA+h4nGz7MOVDIQV+98Bnuu0f0OQyaT6dxEo5Pca2B0erXauQkdhkuJeBsIEN66+Xu9TSSVDAT6vh9My3GcuWW2S2rfIxAPRO49cPzWMc+uVKvVIBbAlVv9ueUvt7a7DVG5CNz7RiZEPnpB4Hg8DoPhQDQS+xU4jiulxlN4z4yfdxlULgOTnImMxIFCpW1i+jIYvMixmd5eAzFBXCj+fVWm792ZMPD6UAsoVK6CyG3jAJWLQODtRUlc15mJtGHAM8fy5l/GThFbYNP9B6hcBpbY/iDw786CKAQjENFYekzNXhzxc6wDlesQDbZ7E2TSKXOYf2cdqNyUaGz82KZQqQkqNUGlJqjUBJWaoFITVGqCSk1QqQkqNUGlJqjUgyR+AedQZxZ6aEtbAAAAAElFTkSuQmCC",
            } },
{342,
            new Items.Pokemon()
            {
                Name = "Sealeo",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAITSURBVFhHzZZNTsJQFIXdUq0wl7gBaFeBcQH8jdRNGGfGFagr8GdCw4TEicZNiDqAeO0p3ubmcSrFv1ySL9BD+/g4773Cloi4hoaeoKEnaOgJGnqChp6goSdo6AkaeoKGnqChJ2hYl2azKVEUlYTv/wY0XEej0SiEutfPsn/3VhLFO78uSsOvQGvz+VwOjFgIRMPrvgsNFW1KW8Fxu91eaa91OpHu7ev/C6Kt8Xgsk8lE4jgu5Pr9vuzfvBQi/eGweL14f5c0TaV7MyuFo+04H2J1TPuF60BDCyR7vZ5kWVaIguGnmG1MW4VclSDG2j0ZSztJakvSULENQmowGEin05HZw1l+PCiPldZJVgqqpIpYOZxX1XAIDS1hg0n+ARB8ezrPpzWRxWKRn7Z8YJqtLNZlJ0kLScipOCRxTp0WaWixLVq5UHA0Gq3I2jWpzamksq5JGoZAEt8Wm8QKMkk77doik9TpX9ciDauA6HOFoG0Q7bG2dHPUmVqFhl+Be2GVpK7B6cWh3F8dyd5pJtPL4+JZWwvHWwcNq0CDmGa0M3tcykEkTZZTCjGVUkFt7ztygIYMyOlOtGtJZUKhkD8XBLpZFHvrCAk3RDhWXWhYFxW2N2D7m6z3wPC6TaDhpthmIQtJNIfnn/5xoOFPCJdB+P6m0NATNPQEDT1BQ0/Q0BM09AQNPUFDT9DQEzT0BA39IFsfi80xSSA53zIAAAAASUVORK5CYII=",
            } },
{343,
            new Items.Pokemon()
            {
                Name = "Walrein",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJrSURBVFhHzZW9bhpBFIV5pQ0/fVAqp4LlDdLhKkq6dJZdxelSOi+RnyfIal/ADmWqJDRWUqYA6WbPwFnfXB1sMCDNSJ+YOQMzH3dmoWNmWSPDnJBhTsgwJ2SYEzLMCRnmhAxzQoY5IUPFYDCwoiiarp4/FjKMQO7r9Q+rZ3PrdrtNZJ1+v5+EvfQxvoQMPdjw7OylVTc/rZxMWqnFYtFMr1qv10vZaDSy5XLZjpsm19wFGRJsgqqB8Xhs00+3dvrlj51c1jYal0mm/vDM6quhleVKjg2STZPr7oIMSRSE2PTz7yQ5LlfVXFw/NZsNbTK5EzyUHJChJ0qSqrmTOHKOKcf38q56eEdBnNuEDAnlKMHNtwWSlIHc9OOtVd/m9vxdbcWTu7n7kCGgHIDc9/q0FfWgkl6KXFy8tvPzV+nhgqiX4zXBWFXaI0Pgqwc5Cs7WYj6LkpCDGPt8T5TjuLhHUoYEkpShnBKMYribXppjCOFBq25+/Sf7aEEASS/49/JN6tv8fXpNT/RaEq8gVtQ/TF50m3sowwgWYTWVIDZD30sBHi9/P9OXaX6eTt5WSS7uo5ChAoKsVhT0cr6Pynk5wMrF9Tchw02sj6OV4qYUA6ymnyeYO5ogjxkb+AY5bgw49lL4W8Sx8j0HF6TY8MVVM7R2Iw+PFX2IsZrA98FBBSlHKIlGKYoBVm6T5C5yQIaeKIgxJCNeLAq2cs1n4/oPIcMIFiZ+7MUh4eWQURLws7siw22hqCdKUhRgPq7xEDLchyhJscfIARnuC4X2ESMyzAkZ5oQMc0KGOSHDnJBhTsgwJ2SYEzLMB+v8A8TsF5biR05zAAAAAElFTkSuQmCC",
            } },
{344,
            new Items.Pokemon()
            {
                Name = "Cacnea",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHtSURBVFhHzZVNUsJAEIW9jjsDwl5cgasJbPQI4AWEGxA8heItOIHoCVzqCbTcsGjnTezUQL2iJvxVL76a5CVUPrqnkzMRMQ0NLUFDS9DQEjS0BA0tQUNL0NASNLQEDS1BQ0vQcBfa7bZkWeYP14/3hYZ1gIyu35/nctm8qFa9Zx9omEqr1ZKrYTdUC1KLl1tZzO8Cv1+HkaRhKqiac056RS4uz+XHSw4GrloP0WYapgLB7tQLzvIAJFVWV0juI0rDbegAgOnrg8zeJ3LzWArGdEY96RalfNY4gaCKDZ+cjOa55H2Pr1CxHFeCU38MYYDrqCJEj15ByGEYhs9O8knHizkvWkpCMJZS6fgc9+5aRRpuAkFUDnJB0j8YDy3e1uVQqdVq5QdkUEmi2uDogphWSOnDIIz2aVtDNYtClssP6fdLQZU7uiDAO0+HA+cqDZHr+1I0brGKBfH/P9FoNsJv60DDFLTtKqHVjc+D8LhTCapknaGhYQqbbd8q6veuSmLi67SbhilAEJPt/ESjIlpNFUOr8ZrR/RpL1mk3DVOBZLwncayfPrwX9UtSbYVI8iSCDK0sviLaSmSxJN6jqfuQhvsSV3YzU+Jr26ChJWhoCRpagoaWoKElaGgJGlqChpagoSVoaAkaWoKGdpCzP3dC9ERLJlX0AAAAAElFTkSuQmCC",
            } },
{345,
            new Items.Pokemon()
            {
                Name = "Cacturne",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHvSURBVFhHzZY9UgJBEIU9gkdxl4ISMzQSo11IMAQvwc8J1EiN1MxQuYBnUC/AMTRv56ldDFMPGMYt6OCrhQdYX73pmXFPRExDQ0vQ0BI0tAQNLUFDS9AwlUaj4R78s1RomALkWsNTyfLMveXfSYGGm1Kv16V3U8jxuC2926JSSRqmYL7B4XNfji7a0hq17TWI9kwKQizLsp/5G73MBZsDJ+ny8Psp0HAZeoz4Yud35YIcNgqoSpKGDEhBCMunYgoTrEqShsvwG1zVXojOpP5+E2gYgy+JplRQX/uZSqYcQzSMQQVDuaJ0WX/+xBLrMm+tQf/mUDHw+rQvtfxAPmeHMpn2Ja/guKHhOtAEWikKd7y48288HUjZKaUsS/maNaXb/c13JqhAlElWJQdoGIO2iBvEF4NoVXKAhuuAHMQgo82pHHh4v5K8lv/7DAQ0XAWTu3+7kpPJmXteyuPH9QIQDf/GJtBwFb6gLi0EfanOn3QVkjRch86fziCOGr89CIbiqZI0jEXbxMypCBPE8qf+C0bDGCCHqwt3sc6hyqBNSGLjqPTWG1y2WVQIQFJHIfx9LDSMAYLhIR22+N8dDGgYi79ZdMP487hzQR+/UexqzObO7+KQsNHw8xRoaAkaWoKGlqChJWhoCRpagoZ2kL1vyD7TDrlZl7cAAAAASUVORK5CYII=",
            } },
{346,
            new Items.Pokemon()
            {
                Name = "Snorunt",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFhSURBVFhHzZY7TsNAFEWzJTvEG6CCzhOvIqzAdsenAdZDASJlNhFEhcQCQFBg8/Bz9MLIugn+Abc40uh4iqMZa/QmIkINlExAyQSUTEDJBJRMQMkElExAyQSUTEDZlyiKJAiCaom/9wHKPmjcx/pS5PFaDqZhpfC+rkDZFY17OT2SzwfCQIt7Pz+uGTsSyi7MZrM6MHGxvJ6RBfpxzrmasSOhbAt1oP17ftxvREL5E37c4q4QN094A/0wxYLHioRyHxr3dLuQt+pJ0cCiKGS5vJGyLCVJvk+SJtCCmqF+4JBIKPdhgc/3J5LMnWRZto00/LjVxWG9/rNAxSI10KIstFhfbU/t3wKVnVddBVqUBU7D/hMOlG3RyDjexO261qHjF5Rt0cA0TSXPcwnDTYxi0WPMhlB2QSP9kGa0+b5AOZRm9BCgZAJKJqBkAkomoGQCSiagZAJKJqBkAkomoORBJl/O3knbAx7xBgAAAABJRU5ErkJggg==",
            } },
{347,
            new Items.Pokemon()
            {
                Name = "Glalie",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHOSURBVFhHzZVtTsJAFEXZEm1hH7SsQnfBxyaM/9gFBP7orlry7K25+lLvFMtX3iQnDqdKT2amdWJmoZEyElJGQspISBkJKSMhZSSkjISUkZAyElIOMZ/PbTqdtlN9/d5IOQQCV6uVZVnWftS/c0+kHIKBZVk+ZSWlHAKBi8WiC2TkI0OlHMIHrtdrO5/Ptt1uuy1nrIrm2e37S0iZYjab2X6/t6qqrGmaVlkXx9UE9BhFUfxE4VhsNpvRZ1fKFDx/WDWO5XIp47zHSl8TB6RMgcC6rtvp78AK4uapaMRxPnZ7gZQpVKAaPvCWOCCloh/HCL+tHLh2OBy6s3prpJQKBOLpRVB/C/32YpxOJzsejx2MRHCe57gsvz+FlAoEvrzV1rQtqSfXh/Xj8PnhgXz/+VXEnGH9IM81cUBKhX8HIoDbijg4nC+s8Ou7WVl9n0HG8Tq+ZyxSpsAqItKvDG6++2wsywvbffwNxIqCpwb6reQckYzz24w5fj58iwki8brhg+Ijid/eW+KAlJdAJP/l8Z3ng/wKX7u1RMr/gEjcHODpZiTjeK3/d2ORciw+9l5hRMpISBkJKSMhZSSkjISUkZAyElJGQspISBkHm3wBiMlDGeBOFnIAAAAASUVORK5CYII=",
            } },
{348,
            new Items.Pokemon()
            {
                Name = "Lunatone",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAF0SURBVFhHzZXNbYNAEEbdEkZwjztg4UJKsE92cknibpKUkEusVOGfCtzHmAFNtCIf8pJF4js82XrI0tPOrFmICDVQMgElE1AyASUTUDIBJRNQMgElE1AyAeVY8jyXJEla+s9igTIUCzse13K5bFrSdNpQKEPQOD/M+Pl8lPN53Yb2f/MfoLyHxWnM/mklbw2nUxdrgfqZLuMjoQzBxvv9Xv+G9iOrykWPG8oxaCiKNGJHDeUYsiz7E6gn55yTQ+NjxwxlCDbil+1DG7V/Xsnho24jnSvawNdd52IiobzH0A3WSI271jv5chspJzhFKEPQyKLoTqqPnuy13krVfJ8l0L8YPjZemhO0HbTds12cfQd9/H20i1KWBLfYQIH+2GcL1P8/HfFQnO3jLG8SPTXdPX0HG/242N0zoAxh6CZb4HKCOAXKUOwm+6F6arFj9YFyLBY6ZZgBJRNQMgElE1AyASUTUDIBJRNQMgElE1AyASUPsrgBZ1Q1FDZ8pCMAAAAASUVORK5CYII=",
            } },
{349,
            new Items.Pokemon()
            {
                Name = "Solrock",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIjSURBVFhHzZU7UuNAFEXZjomwjZ1PaGcS3gQyyQysAHBCEfFZAUU0w0pmmMRVJHw2wS989G35ubqa60+3qOIFp2wdqeTr26+lDRExDZWWoNISVFqCSktQaQkqLUGlJai0BJW59Pt998HP5UJlDr1eT57vK9nutt0hvyYHKnNAewj4/jT+0pBUrkO4nGG4/zdD6Xa+OSAC/f09mAfB8dXJQG7/DOX6dCgdKwHDtuLQIZjPdrvtic+tgspVaBhtCz8czl8YBNc2mU0q10GX9Xi/ktfzTXl/2JXJwbj+ftGS7c6WDxo3nQqVDASKl8m3c9bygWIm+7vy+lBvmrfH/McPlTGYIV1SbAS04ZcV4Vxzd3ulvJ3XwUY7hbzMQiPkv9n18T3XhUqGNoigE13WoDEfbDZro1E5D4mlju+VApXL0KCf2nPfEW7O5aZvUDdROBopULkOfv5cYxoQTd0PfkjXBSmKQqZVKZNfrmk3hwisGyU1KJWr0BanVTGfPc+sRYS+G9cgcDi/qRuGymUgnP7gTlk3pWFGZemP8Xnk2tM3iv6hnKWmchFhuHA3o0kNCbC02L3YTE1fe1QuAgHxcNbBV4/H0OHPSkrXnLaEP9Lk+adQuQyEYQ6BwjcGHDYRHNBrU6EyBbSqQfTdHJ4LQ+dAZSphyDiMLnnoUqAyFQ3YdN4YVOaAkE2aWgSVlqDSElRagkpLUGkJKi1BpSWotASVdpCND0txD5/bcM5lAAAAAElFTkSuQmCC",
            } },
{350,
            new Items.Pokemon()
            {
                Name = "Azurill",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI7SURBVFhHzZTNbtNAFIX7SnGInTyG7ZRKsCLNqmIJC/4WcQgLkNg3pe9BmxQJUfoOlCq8ApC2CRRxmTNhjKkO7diJxF18yuSzHZ/cO3PXREQ1VGqCSk1QqQkqNUGlJqjUBJWaoFITVGqCyjI0Gg2p1Wpmya8vC5W+IFxn+FGSR0dSC+pG/fEIvYrgVPqAEPGDdzK6dU+6w5M8oPP90bkkaXvpkFT6sAjy1gZMHx5KkqR51aZbz2UwOpPk8d+VrQKVvkRRZNr73lbr6cFMNl9NbNVOt178/4Co4Hw+l2dvZjZcEQS7vC+rQqUPYRhJHMemeqfSH8/k2/cLaT85yqsZ1G+Y2/izZaDyOlC9bH8q49v35ezuS9vOeiOyJ3pwoCAgqtczAYttdVz8+CmD321fRUgqrwLV6+1NJTX7zLUToKJu7XAB8UzVcUPlVbRaLelsfzCH4FAyE9SFa69v2P1YDBhFTQnDMB8/l3/LByqvo9lcvBiHJNv7Iml73YbDiMH3YvUAKujWZaHSF7w4NgMaAbP9r+bzpl0HQWAuL+7Bn3HrKlDpgwu3uXMi3d1PkpoW4xTbYW2CFluKe6tWkUof8MLO8NjOQLfnursT6exMbEg3pLFnsR3cc2Wh0gcE7L3+nIcDmTnVNqSpJAJWrVoRKn1AZdwh6Y8X4wbh7mwf28OyinCASl9c+zB2sBcBhviqwgEqy+KCLrPX/gWVmqBSE1RqgkpNUKkJKjVBpSao1ASVmqBSE1TqQdZ+AX1TTPkDFRPiAAAAAElFTkSuQmCC",
            } },
{351,
            new Items.Pokemon()
            {
                Name = "Spoink",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIhSURBVFhHzZbdktJAEIX3lSA/wGOQBN9nV9jr5Sfeq6tea4kCAX2k9VYktHNGB1nqlJuZ7EVT9VWYj4Q6dE86XImIaqjUBJWaoFITVGqCSk1QqQkqNUGlJqjUBJWhJEkiSRxJp9MxS36OL1SGgHC/Pr0V+fpBZPlOeklsND/XByp9OYWra7M0ry/v5bi8lzjqYkWvaQqVvpwCHg5yPNTycPtKjp8VBUzTVH5+fG1aey8Pk4X8mJRyMIHTZ2gzlT6gerPZjYxGhQn5RmpTOfDCrKuqkiiKzGn82iZQ6QOqhyC73c6EHElRFJJl2cnhB1xe4wOVTUAwjJP1ei3b7daGAfv9Xsry9pFrU0UqnwJVubu7ljwvTMVyWzUXFJ9V1Ua+I5xZbzYbiePwvUjlUwwGAxkOhzKfv7ShEMK1F0HrpRkzZtR8MyHhp9Mb6XbD7mgqm4BKrVYr20JUEXsOuPeuvQAhQ58uVDYBAbNsaKq3lsVibI6VPaKKLux50NB9SGUT0Obp9NpW7BzsPwQqy4ld4wdgC/R6PXMZ/67/QWVT+v2+DYm9OJ+PbQXPwXzEyGkzaqj0wbV6NkPQ8SNwl7f9Z0OlD4O/VfzX5j+DGu/hQ1vroNIXtx+x1zB20F6MlrbhAJUhuNmY55k94klzeU4IVIaC/YgnzHNUzkFlKKhimrb7c3AJlZqgUhNUaoJKTVCpCSo1QaUmqNQElZqgUg9y9RuBtFvEBYFaQQAAAABJRU5ErkJggg==",
            } },
{352,
            new Items.Pokemon()
            {
                Name = "Grumpig",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKaSURBVFhHzZZtctJgEMd7JUAC3ALy0gMAvYD9xEsPoK29ByTQUadqrRxA3pzWqmfQsXoApOv+H7tMJrNjEmhnng+/SfOHpL/us7vTPSKyGjW0CTW0CTW0CTW0CTW0CTW0CTW0CTW0CTW0CTXMQrlcpkKhwD/qnz8UapgG5BqNBrmu++iSapiFpGRcVKqbzLdBDbMACdf1KDx+TYvoC41OzqlYLBmhTqdDvV5vQ7FY5Ef096ShhlmoVCo0Cz+T5/k0j25oOfpK7Xabut2ukbqNLun3aEIllk4+mwc1TAPVmw6ujFQSkZwfHrPc9pUT1DANCEZ8tGcv3pjjhdhseE3r9R21Wi2aP30YOaCG/wNyP8P35vhwHXPvQbJUekKr1cr04kH7YOfhENRQA2Jodvzi74N39Cua0L4fsOQlLcIbCvx9U1UIhs9fkccDJFMcJ/neNNQwCeTiK6Ver9OP4QUPwsRUcnx6Tmenb40c8H1/Myz4vlR8eXiS++jVMA7k3IZLPk+ry5KQcxyHgiCgwbOXRmj9Z010R/Rp/M38EVgzGBZZM8gAqp13stUwTq1WMyI4Phwb5OQzSM551WDdLLkPcQ24ep7nbSoIWZ/vUT3vXjJPJdUwSbVaJVQSSCbHPuXp9bkXZ+G1Eeux2FH/iK//qocMQrfRB3PFaUAyaxXVMAsiKJUSmY+8Hxe8uPv392DBYqgilnetWuEhu3h8QRx9s9k0ApAU0GsiJuLIsBulPfCsvCcNNcyKSGI5QwJVRc/Fq4p7THK8d/OghnmApBPrT1ylmv1e3/TctnJADXcBwuhD/BMxHV4RBiz5nTyo4a6YqjrlnSonqKFNqKFNqKFNqKFNqKFNqKFNqKFNqKFNqKFNqKFNqKE90N5f0ggYgS6I6D0AAAAASUVORK5CYII=",
            } },
{353,
            new Items.Pokemon()
            {
                Name = "Plusle",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAG2SURBVFhHzZVNTsJQFIXZUvmbywx0QmGCu1DjQF0CyyA6Mi4AUjZhcGJkI0CuPW1u81JO20db4x18gX6F5OT+vNcREdNQaQkqLUGlJai0BJWWoNISVFqCSktQaQkqL2U4HEoQBPFX/r4JVF7CYDCQw91C5OFW+t32Q1LpCyqn4cwFRLj1eCyn+zRgNJlI7w/aTKUPbvW2BeF0NpX8ex+o9CEJeHiS7c15OA3mtr/uCFBZBRZjvbqS6HUkp9NzrF6k3+9mlcoHA0VVroLKKrR6COYyn4dyPKaB5bF5OEBlGUXhwPYtrej+K16auPW6OHXnD1BZRjZfJSFns6mEYdgomEJlGSwg5g/PqFxSvXg2ey2diVSWoS3WdmYBsRjvS9nv/jkgOJtDLASW42OZLEWbNwqVZSAcbpDZdCqb1Uh+dotsKdyF0FHQ/9WFyir0HNQW69wlz3E1UUG0vI1KUulDUslcSJyD2F5UNrpO7+mmIan0AQG/PxdJ5dBmfCo4ZjYtnIGASl90ztxjx73y3N/Whco6tLUUeai0BJWWoNISVFqCSktQaQkqLUGlJai0BJWWoNIO0vkF17JRrh9Y44sAAAAASUVORK5CYII=",
            } },
{354,
            new Items.Pokemon()
            {
                Name = "Minun",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAG4SURBVFhHzZVLbsJAEES5ko1hH3ZBbDBsiHIJfoskxyFwCBBcIiKbfC4CVscF6mjiFGYYLNGLJ+DZFqWe8kxNRExDpSWotASVlqDSElRagkpLUGkJKi1BpSWovJRmsylRFOVf+fVroPISEG4428l4LhLHSa74faFQ6YsbzlxAhLsfLmX0mh3CtccbieJ6fonfHwqVPrjTOxVOu6kUr/tApQ/4893uSTrT1b9wGsxd/tAKUHmORqMhy9mdrOctybLnXL1IksS/kyoGA6EVoPIcOj0Ec+n3U9nvj4Gni/3V4QCVZZwKBzaL40S/3x+kM1nlwdaHYKH9A1SWof0qC9nrdSVN06uCKVSWwQKif/iNyQF0sx5Xc7JQWYYusS6nBtQX43P7eNuAoNhDvBAIpt0LfSEYVJaBcDhBumlPVrOWfG0Hf4Jp77QK+lwoVJ5D90FdYu0dfmOa2JCx5FWczVT6gAkVQ2IfxNuLyU7mx6DuMyFQ6QMCfrwNDpPDMuNTwTbTHlXTRSp90Z6524575Ln3hkJlCOhlVaFcqLQElZag0hJUWoJKS1BpCSotQaUlqLQElZag0g5S+wGTylwj06yr/wAAAABJRU5ErkJggg==",
            } },
{355,
            new Items.Pokemon()
            {
                Name = "Mawile",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIsSURBVFhHzZU7UgJBFEVdkAmMkGumGWCCS9AIBjYCuAI/K6HcAJSJn034S9And/BaTdcdGIYJXnCKqjtN95nX/XoOzMw1MvSEDD0hQ0/I0BMy9IQMPSFDT8jQEzLclWazabVaLSN+ti8yLArFRqORTSYTS9PU6vV6paIyLALkKBYCSYrG/ymDDLeRJxcKViUpw21AsNfr2Xg83ihYhaQMN9FoNOztqWtfrxc2HPTXJCnVbrcz+v3+3mdShpsIBcH19UqQYpCKf1nJMp0uw01ge5Vgp9Ox6XRmg8EgExtdntjk6sTSpSCqjOexbDy3QoZ5xHIUjKs3uzmzz5euPd6d2XmnleWQpBjOL0XjNWJkmEeeIKqzWCxsOBxmgu9/YyD4872w+8MjS5dSFGKTFZGUYR6c+P15Jccm4fZxaz+eV9UDSb1mT62uPUznliTJcpr1uSoXxP2HNweU49nDYrOb03+5GMiGcxU5hzJUUI5XCmH1WAl0eSwJsV27l8hQoQRRRZ69cKuysZfHNr89XataGWQYg6ooOXZuKJeN/ZND9dDNR0l5SRmGxJVDBrnp8tDz3IVjub3hNYOuhmSZbZYhwYLxN5eVw2LhghjLKygUpCS7fFdJGZKwehADqJhahIKU4z1JSTZKpYIAC3PibZOz4rwnKUvBeHwRZLgP4Qu1WqutDc/prsiwKkLZ+FlRZOgJGXpChp6QoSdk6AkZekKGnpChJ2ToCRn6wQ5+AUn171CTBAWbAAAAAElFTkSuQmCC",
            } },
{356,
            new Items.Pokemon()
            {
                Name = "Meditite",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAH5SURBVFhHzZRLcoJQEEWzJQSdB1cAugp0lGQFfiZqJindSJKRyCpQJvlsIqlMtKpDP21KqRuVF8vqwSnh+pDjfZ8bIlINDDUBQ03AUBMw1AQMNQFDTcBQEzDUBAw1AUNbGo0GOY6TX+LvbYChDSw3n89ptVqR67p5hMdVBYZVkNbSNKUkSXQJshyLZVlWyMk1S15iumF4DvtyZUG5F9Hys1WA4SlYLggC2N4+l5CE4TGkueHwkRaLhRFTI1iv1w/kWq0WxXFciKAp5jH/WYsw/AtpT17M19wOT7eIDgYTQ/kP2LYIw2OwJJ93/PLNZkOe55l7lqrVasWRIy1Lk7aSMDxFsUmiO8qWy2JKWYAF1+t1Ibjf6FUFb0dvFIRtCsPQTGOx/roPlHXuyXW2bfZ6I2s5BobHYLno+Yv87ox6/Qk1x+/kd2Y5U0MQHm4KHn+1TcJIe/7k86DB5uTDZIZc2Nk1yGOj1x9yXC9/HP/mMWB4CmmlPM2yGXjNcbPxIjHiPCZ6+baShOE58JlomszbSvON0m5vRfv9sfkU/OiJfF4GebNO7UqbROAmy+cii5aluG3bdQjDc2FBORNFtFiLu3VYfqYqMKyCrEcWNYLdqRGzbawMDG0Q0UuJCTDUBAw1AUNNwFATMNQEDDUBQ03AUBMw1AQM9UA3vxWLT+5ysaXKAAAAAElFTkSuQmCC",
            } },
{357,
            new Items.Pokemon()
            {
                Name = "Medicham",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI2SURBVFhHzZZNbtpQFIWzjKY7aGdgwbzJCmwzSbKC0HYQYAVJ2UBkBk2ziqCsIBETDCtAHUXtJD8LIOHW56FbvZgDGNuS3+CT8LGxPu597z72RMRpaOgSNHQJGroEDV2Chi5BQ5egYRGazabUarXkI7+/KzTMC+Qez67kpXstXr2eRPy5XaBhXlRwFHwVr6Qq0jAPkDv3j+Q+aJcmB2i4C41Gw6w5bW0/OJG6K4L2mrOpvMW6UyG3mB3KS29VsrJNArk7v5208lieOu/FbNmyqkjDTdiC2BDPnV8rYgB5GZI03AYkLy/PZTKJZRR++y8FFq+vMmp9N4Ja2SLtpmEWIDkej2U6nRrCMDTrcj6fy2DQl3oiVcbQpmEW0oJKFPUTfiTCgREueuzRMCuYgajSNJ68k0P10s/mhYabQOXsquDa930JgiBZlxelygEarkM3h1YJonqNlsZxbCrped7Kj8jbahquQ6uFSkFKxVA9lUObsbttUV2ruE6/cxs03IRWA0D2YfhJBtFy5ES9j/I2+yKt1rLlKg10l6fftw0aZgWyDzdLwai7b+TsY68VhEZUf1D6+1mgYRYghxMFw/nP8LMMeh9WBIvOQEDDLGj1RuGpkYw6+/LU/WmkcPTJ7wMjW5kgZiDWIM5jCIZJK+2z+e/tUr6Ss1ixNwzGDUaPth1U8m+GoaL6WWX1fhFoWAQIYu7lmXkMGhbFrmhRaOgSNHQJGroEDV2Chi5BQ5egoUvQ0B1k7x8UDSuB41BcHgAAAABJRU5ErkJggg==",
            } },
{358,
            new Items.Pokemon()
            {
                Name = "Swablu",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAG9SURBVFhHzZRdTsJQEEbdUmkhJq6ClpBg3IX6YOKTwCb82YiFvvizCY1PRl40LoCWsV/NyE39wBYamSYn0SOYk7l3uicipqHSElRagkpLUGkJKi1BpSWotASVlqDSElRagkpLUFmHTqcjnuflP/K/bwuVVUHc4PJVDq9n4rX8XC19U9FUVqXdbhch+2e3Mrh6KyLx+8XdXEaPIi0/yD/Gv1sVKuuikwyjngzv0yIMoU1Mkcp19Pt9CcOwwPWIxOSamJoLlatAXJqmkiSJTKdTiaIo18s7p1NsYnIKlYxyXJZluRYJguDnzrm4k9xmaahkIDCO419xusXDhwWN1Mm6W14HKlehkaPRiUwmsfi+L0/vc3n5FDm6mUmaLWTsBOK4t4kDVK5DlwST0TgNRIgeN+L0c+X/UQcqq4B3IALH49N8osfy/JEWkThqxOG+4un1vkPLW18VKquCy69TPDhPipe1G+c+WC7d+jpQWQf3FYNlQSDuKRYJUbpQeDaJpHITNBR0u93iSN1Jlt+dVaGyKcpbv5Mj/gvd+p0syX9ApSWotASVlqDSElRagkpLUGkJKi1BpSWotASVdpC9L6dZdr+juScaAAAAAElFTkSuQmCC",
            } },
{359,
            new Items.Pokemon()
            {
                Name = "Altaria",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJRSURBVFhHzZZbTttQFEWZUpzHP5lBnPyAGAF0AqXqJNLkB5WJ5DUJBD9IHUGlDiA2p96utjncbofcWIh7pSXwNpYX59yHz8wsaWSYEjJMCRmmhAxTQoYpIcOUkGFKyPAURqOR9Xq9hjDndSwyjGU4HNr59Z1d/Hi0y8VTTS/r12IX84f69/CZY5FhDKgQ5SAymUxs7GS7VA/IMAYI+irhGpJ5nneWAzKMgYLjm5+VUGZfV3v7trUattr/bay0DGOh5O3mpRbL+oNaxLce15DHvfD5Q8gwBshB5HZdWj6dvamQv0dx3jsWGR4LBFCV8Zd7m+TTSqRobWtsa4kMD+Ff6Oebx28z4fOxyLAN7Her1cq2261Np/8qpgQB2r1er63f7yYqQwUqRzkK+oVRlGbfd/8LlmV1oxqDQfz8AzJUQBA/Kff8u7Bff8yulq8nB1uOawgWRYFnmnGKpAzbgOR+v69+NZvNZo0kRYvypbkXyi2XS8uyLLrdMmzDC2JABCcGQctV5SDHVu92u3peVkO+I0SGilAOAy/z8xGtbWuvHzGtlqGCi4SVwIAgr1FNrmosmLYROw9l2AYk+SEwn8/fyPo2+uH/CVb8Q1qMPZCnBo+1Q23EgNBisbDNZtNsTx8mCFBBrEJ+BOALpqj66avEwWoBLxkjB2T4HhDlisVmTBEsFq5on/M0OeVEkeExoOV4YXj0+SnAoy58NgYZxsC2Aywgbjef8rHwHpSFpP/k6oIMuwLRMDsVGaaEDFNChikhw5SQYUrIMCVkmBIyTAc7+wvMb2SA5eSv9wAAAABJRU5ErkJggg==",
            } },
{360,
            new Items.Pokemon()
            {
                Name = "Wynaut",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJRSURBVFhHzZbdUhNBEIV5pfxtkkvDE2Q3sUrgRvEFDFcSeQrlRtQqfx9GwSpR4V2UpZ3Tm95MLUeZSYI1F19t9sxu8aW7Z8iWiCQNDVOChilBw5SgYUrQMCVomBI0TAkapgQNY+n1etJqtZTm2rrQMAbIPfnyWw6+iux/vJBWu7NRURqG4ssZkBzNXznRtnuEvxcDDUOB4KP332V2dl3LGZuSpGEMJunLGWh38/lYaBgLJMfj8Q1RVLbd6bpH+Hsh0DCUtmthp7ucw7yYSJ7nMjp8KbPTsp7LdSRpGEKv31eZ2elVLfI3/rsgqnZwVmr1cKQwqSarStLwX6ic+4NoJ652r7iZKyZTlUbbR89e162+M0EI+JjMOC+0ipVYdd0+eiOPP13WQveeLmfxTgSHwyGdMVQnGwx0BiE3LQqZff5VrXvSfgXBKpI09MmyTCV9IIc1tBItvdjZkfuerF1x1PgbyQRxLIX+O6RhE0j6+Pn+hx/yc2/PST6Q6aSQy91dvSLDmlbZydnBDTGcmchDJGkYA6oBkXMnJi/mSvl8rhm+ACTs4IYg5JBttIK3gc2DXV0eHyloOzKsDdw4QNYk291lB0KgYQyohG0M7GAD9ybpV9Eqae/fBg1jQBttzlR08cum+lzqxsgWYwC5h+/Opb/YZCHQMJaqitfa5u35iYqhzZg321T6q+fttyg5QMNYIDE6PFEgBlCxZitxrvr3IdBwFSAJtJUOtN2qtw40XAcT3YQcoGFK0DAlaJgSNEwJGqYEDVOChilBw5SgYTrI1h+eOSe7ZtW/rwAAAABJRU5ErkJggg==",
            } },
{361,
            new Items.Pokemon()
            {
                Name = "Duskull",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJISURBVFhHzZZdbtpAFIWzJDBgwxKiPmF+pLx2BfxmHW3SSokhD/npIghR9pC06iJIojx0Abdzho7juMcmDJFyHz6BPpvhcM8MsCciqqFSE1RqgkpNUKkJKjVBpSao1ASVmqDSlzAMpVKpmKf8ug9Ubkuj0ZBqtSonJ18kCAKj+H0+ULkNCJckRzKff5N6vW4Uv88XKrchG/D09KuuCWLPuXCqJoip1Wo1Gw7MZsdpSPj8/btAZRkINxqN0sn1+z1T7UvIbrdra36voFSW0Wq17F47PJzKdDqVp6dfJmT/v5Cr1b1EUWhPd36NbaByE81mJI+PP+X5+XdKr9d9FXIymdh78CGCoOZ9eKgsAxU/PNynwRAC3N7+kE6nk1af3Z/wePQ5RFQWgXDtdjudHh4xKQRYre5M1S9ThEfVwE0VWyOKIrMUX59BZREIOBgM0oDj8Vh6cSwdQxy3Zbm8fDXFLHA+NVNZBA4IJrhcXtnDgX335/OBzON9GzIb0NXrwsXmOr4382tugsoy8CaLxYXc3FyZAzCRJP70b4KxXF9fmkrXAVGtC4nQvqeZyiJQMf4QuE2fJOs3d2HwPPsdCQ83HA4Fr82v9xaoLMJVjHCoGdOazY7k7Oy7meA6HPZlFoTzqdZBZRkIuVicp9W5uhE2GxDBdg0HqNwEQoamMgTA3gP56SH8e/zcUflWWs2m3VuYEqrPB/2wCTIwVQRCQMeu4QCVvtjqTShH/roPVGqCSk1QqQkqNUGlJqjUBJWaoFITVGqCSj3I3l8QZCRpMFVP7AAAAABJRU5ErkJggg==",
            } },
{362,
            new Items.Pokemon()
            {
                Name = "Dusclops",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAK4SURBVFhHzZZLTttQGEbZUhLlNa3EAmyHIYNCGYSEBVDaBZDAJkq7gL4GvAZN0gzbcQhhGe0k9OJzrd+6sv4QG6fSHRzZ/mTi4+8+zJYxxmvU0CfU0CfU0CfU0CfU0CfU0CfU0CfUsCj1et1UKhXLc9lLUMMiIHJ4uGfu7yfm4WFqarWalSKbTC7i62p8m/63eVDDIiA4n4+tnMt0+qm0HKhhUVzJ8/N35uzsxFSr5eVADYuA3Hh8YRsTNtGcoIZFkDnY6+2nlF0YLmqYF5G7vv5qbm+/p/T7bzYmqYZ5QO7q6oudb257MBy+3dg8VMM8NBp1EwSBWS6X8aWJF8d7c3PzzTaIXBiGG2lRDddBe4PBsXl8XJo/B9vm7/4r8y8WPTo62HiLargO2mN4F4uf5tfutvkds4i3GbaYbItlN2s1XAXNMWy0x+KgJb4giCIni0TmpQiW2XrUUEPkZGFEUWQl3WEFuUbeFeQl+Axmf3cdapil2WzaueTKAdsLDIcn6dBKg26L83nynYaikmoo0BpDM5v9sEPIw8IwsMfLy89WBjlkkRdBrkXuvwsi1+lEVuTubmzPeShbDMOIDNenp8dpc5IhtLPTUSXzbkFq6NJut63MbDYyrVbL/jAySERRaI8iCkGQtIYIsnIUSeYj9+Vd3WqYBTHa5LzRaJhu97UdwsEg2esERPnMIYAQi4jFwb2IMT1k0eRd2Wq4CiR5KA9Hrt9PVi5SMueQlMbIhMnkox0BXpD/fpCTY/Y5Lmq4Coa7203+c0GAphhu2VJ6vT0rC1yPRh/SNhGT35Fz2bok11DD53AloRk/TB6UXSjAeZnPnRquA0lacFtxxaVFwb5IvJfKvUVQw5eCpAy5i/siRVHDMiTt1tOGy8iBGvqEGvqEGvqEGvqEGvqEGvqEGvqEGvqD2XoC82/p57UFakMAAAAASUVORK5CYII=",
            } },
{363,
            new Items.Pokemon()
            {
                Name = "Roselia",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJ6SURBVFhHzZaxctNAEIbzOtDJiv0AdFEqSW5i3sBA4dhPIpzG4y7wAvaIAg9VghoCTyLiIgwpAlnuP88q52NBkg2TLb7R3S/P6Zu92xsfEJFqxFATYqgJMdSEGGpCDDUhhpoQQ02IoSbEcF96vR4FQWCG8vs2iGEdfxPAu+HFiIKwY6a/v2+LGNbR7XbpKDuioBNUosgwhtyLYqxDMJpGFKexFcN8+PHUyj26ILaRBV0pzDl7VEHAZ43lJCCJ6rr469Qhhk1wBf1KgiRNKMq2812qKoZ/ghshjuPq45BbfV3Sy2KyJeiz65aLoQ9fK3eLc6L8LfXTlFblko7Pjq3ch3VuxyyMJyo4vNxUb5/zKIYukCtHM7pfvqH1ZG6fh+aD78uFFWMgyNXkMXe4v2YbxNAFglw5F0nSBZK4J911dmkUMWRw5lC9InpuKrctydvMQmn/YR6GYXWR8zrZp5LSSU7Z1TV1zHv+Rh1iyPD2rsdzK1lEA7o+nVE/SW2TYAtdSYihQrOLzEhszh3WcOUG+T0lk3dGvpmkGLq4kiyaxgklyQOzy4zmxbQiNdXl7YTc9Mu6EmxbRTH0cc8PV4hFVufPzDPeEubuRSdnV2VVNVcQzyZVFMM6WBgX9bfvT+n29gm9KkbV5cwdDNmT5Q8rl4xzM/5Jrz9vqolxEB6a5eRvMGLYBEiyIOT4QoYkxPhsonkgOcjJikIMY/BfBQEkb2421XMFIed3NSp+srirJJvIATFsClfRl3OlgPt7P6tDDNuAOw6SkONu5ivmXyCGbeHK4E8EJNUJMizq5/sghpoQQ02IoSbEUBNiqAkx1IQYakIMNSGGeqCDXwvX/L8wV1J+AAAAAElFTkSuQmCC",
            } },
{364,
            new Items.Pokemon()
            {
                Name = "Slakoth",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIaSURBVFhHzZQ9bhNhEIZzJXttK9CBuMD+NAQq3JkOSGEnp0jixuEGwAWIQgcN2KdwyAGiQGFbk303nmg8vBstlhJN8UjrZ/fb7/XMfLsjIqGhMhJURoLKSFAZCSojQWUkqIwElZGgMhJURoLKSFBZR6/Xk1arVeHvPRRUejTY/OcnuZx9qUiS9qMEpdKCcF8nQ/k9/XwXTjn/eCBJu10+9u8aDW+vt4FKCzawlfMBV6uldDqdjUB4Xitsr/Wd/wOVSrfb3QinFUvTVM4moyrcj9ml5Hkh81+3Qezz4w+v5OT9nlyU9/B7m6BUKgio7bXtRJUQcrlcSlEUkmVZFTjPs+r66N3LjWAIqtd1Y1EHlQqCICBeqi/WtuE3AqFyNkSR55Xz1VOw7vv0oqxmUm7B97VQadEq+kD3oSG9t3+yaauptGjAw/ypXL8ZyPnpiJ5oC4LY6umf2+agUOlBq4fpbjlzCxnvv95oG4IfZE/kuJw761kVbQX9HnVQyUBIvBhBz9YHB3N23R/I3/5bOXQhERCHxc+gDer3YFDJqFr9LJU/ZZsRSEO1y9CLxUK+vSjkZB3IzxqwH3vc1++n38dDZR0IeYU5fJ5VQTGPvsV11cFaDarfzyYnmcr70Fbbz4/SZL6wHhVvUj1AZRM0qMU/UwfWelcHlZGgMhJURoLKSFAZCSojQWUkqIwElZGgMhJURoLKSFAZB9m5AcLeS4r1nDavAAAAAElFTkSuQmCC",
            } },
{365,
            new Items.Pokemon()
            {
                Name = "Vigoroth",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKdSURBVFhHzZZJctNAFIZzJcvDPiEXkK1NUqxisgE2hGJBQTYeLmDMhkouIlu+hIeLMC08PPpv54lG/Ggoi6p+VV9Z9cuSvrzXLedMRLyGhj5BQ5+goU/Q0Cdo6BM09Aka+gQNfYKGVeh0OtJoNMwhP38qNCwL5L7evJSWEfxfkjQsg8pF3a58cyTrFqVhEe1228r97L9KgehutzOnRVqtFj7otVWhYRHaPVduNpvJfr83p0U2m400m81auknDPCA3eXMl3/tHweSiK73wd/dQ4/HYytbRSRrmAcHlcinJZZTKTe6uZPr2WvZPkovFwgpCNAgCRPReZaBhFkjpBkD3gqAhg8FARqORfHLEPr97nh6jdNSm6H3LQENFxdAxPCyKInv848Vr2701OvnwUZqmS9vtVhaP96Zzf3bx1DHTEEAujmNZr9dWDiRJYjsSn4dWcDQYWgmIJQ8fUjldgyiInrJhaAggGIah3Z2QdB+Cc5PzG5le9C3piC9v02NXUgvdrCpKQ4B3HdZZ17xCsjfFufjLe5k+Owqm3B3XI+Tm8/lfglpVxk5DgC5BELuQ/dV2CRhJjBZgF89Nt7FxgB390zpkVVaShgok8kaiy2A4HNqOYY0qKqZjxXpmIzdF763QsAwqZ9+Jjpgrh1IJLAuIYrdr6QYyRZ8BaFgE5CCGtYZxrlYre4zPw+FgvnIsCEDYlcC1Kolril7kNCxCBfHqUUkdsXZP5dxRm0qv/9cGzELDPNybq6R2CQ/LjlHLHafeo8zPIA3z0LWkknhPZtcRBNxNkR01zhd1TqFhESqpZM8D/Q5EIdfr9exur/rPAw3rQjvpypXtnELDOtFx5nU7Dxr6BA19goY+QUOfoKFP0NAnaOgTNPQJGvqDnP0C2bpZtuP8kKYAAAAASUVORK5CYII=",
            } },
{366,
            new Items.Pokemon()
            {
                Name = "Slaking",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAMfSURBVFhHzZZJctpQFEW9JdN4H5a0gqQywfGAbgMGT9xsAOwVCNhAmkkwo1QmxllFUlkAyC//Cl/58XkG3JB8VZ0SXBod7m/EnogEjRmGhBmGhBmGhBmGhBmGhBmGhBnummq16k72az5muEsODg5kNptJpVJxT+33aMxwW9DE/v5+jv+aBeVwQHCbz5rhNuBit2lPfg6vZNhtSqlUcvHqeygB6vW6zOdzabfb8mn8XbL7e3xmbZtmuAktR7QkxWa3qbgXZTK8yLnPsmfJATNcBy6entTlbtBfEaTkt/RsIXQ3KM4UheTXyQ8pl8sbhxeYoQXn2+Hh4Up7FIyjSHqdmmTTx+YoR65PP0qWzd92kUDurPZOIifwlBwFMceuT49zSd2ifqxb9K/lY4Yayl0cvS8EIYMhxrnZbMqgs5A7d+8rYe65lQpJfAb4jT6nRTPU+O1B6mZwnp+z6WL4kiTOmxslp/K70Zc/zSsZRV0ZOrJ5VjRKyavu0W4EwTg9L+YVmkBzyDH3BlEnf/6r0cslQdktGjR6efyhGHYIfnYr+dVDDLneSa2QoFy71ZS5a4/NYevAc0iPkm7eYhLFuSiavKgthrrvfgTlvrx2DmI7wT4GibTTeFwELoMgG/UFKYnhBTfuR+nWIAbi2P04912V8uoGrzFDQEF8eRxHS5IQazQauRxWIy7YarWWJAEXw2R0WXxP8cMeNvEXC2J4seFqOQouDbWTxIEWx27xcH5qSSwqfA+lyCY5YIYEktycIcmthsNMObSIWxckse1oUTTXchna5dzFGe/BAtp0NzFDDSRxa+OeBkHdIIQoigOyGG7kGnwO2xRkp24P5RmS7jCvDczQh03qDRstFu0oQR6cm1wQ1h1okxwww6egKMD81C3qfyg8KIk8SZJ8mvh/Mt6kQQsuIrSom8y3nIczxPkYrXOxURKPrf+RGjPcFjZKUUhi8vOMDKsX92hODb0jkHWSZvhcfFHCfe+/CxI9RwkXlmbgSf4zQQtfmsKU3OkcfAm+sP+6jxmGhBmGhBmGhBmGhBmGhBmGhBmGhBmGg+z9Ba1yHMOgS7MLAAAAAElFTkSuQmCC",
            } },
{367,
            new Items.Pokemon()
            {
                Name = "Gulpin",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFhSURBVFhHzZVLUoNAFEWzncyECPuArMJkJ+ooOrLcgttw4mcVVrmADBw+vcRnUV0XaLqpeAenqJyQyuF1Ayszk4ZKJahUgkolqFSCSiWoVIJKJahUgkolqFSCyqWo69qKougIv4uFylw87Pixtq/PtV1uLn40P3cKKnNAnIflxgEqU1k6DlA5l/6SPj9d2XbbZu27PlTG4mGHl+suqm1PHF5vrNyUi0RSGUNVVV3Y/fvtKAgNfzsHKqfA5GLinJxIKsdA3O5hZ+3vkmI5WVSfswc2TfMXtn/c293bac+NTTU1ksoh+tPDEWFhxFAkLqQo5980VA7hgfizoUgGzj9rIOJi9h4ePX5BKXGAyjHwePHI8CZBED770V3O85DKKTzSl87pT9anlzo5h8oYEInJhKG+NxH2r28SB/sSISHhealQqQSVSlCpBJVKUKkElUpQqQSVSlCpBJVKUKkElTrY6hvfpUZX1dNYcAAAAABJRU5ErkJggg==",
            } },
{368,
            new Items.Pokemon()
            {
                Name = "Swalot",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGRSURBVFhHzZZNUsJAEEa5UqCSO2i5MXFj4s5T+HMK1A3oJUS5RFKcBJcuseUDO4bxS8wESPXiVTEvpPLoSYCBiJiGSktQaQkqLUGlJai0BJWWoNISVFqCSktQaQkquxBFkQRBUOIe7wqVPoRhuAl6neTy/rwoGQ1HBwmlsi2YmhvmglD3PB+obEObOGWfSCrbYDpQ45IkkTiOZTYpypjV6kvmL4eLpLIJxC3zE7lIzsuwx7uFvE23IZ/Xicynv8FKL4F4YhH3dL+eXpzsTO4/egnU6SEQE6tuMab4UZytY+rvyy6RVDKqWzu+LegEmyJxbHjMQIBIfPmOb/LNBRFZfUiyLJNlcbpzf2LK+EC9BAJEaqBLmm4D9R5FvMbhWJdfFirrYHG48MNPhK4ReZVd/vFpmnpHUlmHG6gXBSyGeax9tprKJvTPAUJ9A5WjBioI1UgWUZ2WTh2vj7rFLu5TrQHVdfV9ep4PVPqi267rfYJcqLQElZag0hJUWoJKS1BpCSotQaUlqLQElZag0g4y+AZweUY4R1QdHAAAAABJRU5ErkJggg==",
            } },
{369,
            new Items.Pokemon()
            {
                Name = "Tropius",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAM9SURBVFhHzZVNUttAEIW5kgFbYol3YYVGciryMiGLmFNYMrkH2GQfIBcAkhWVyt9B8reDqk6/sRqN7RaSMJWaxStLz6qZT6+nWxtE5LVU0yeppk9STZ+kmj5JNX2Savok1XyMut0udTodvtT/f6xUs60A92y0S2keUWezHlJepskLqWZbCeDeYd/qoY3xbHSWkvkwJBObWkjVbCs3weGEN61IEc+l2fwZyFyk1Nl6IkC3LCL3v7oEF5JjpU8FKGDu4iIsLjACWZUi/m+bHqSaouW3doUEZDPAALQqRXcdSQ7XawFWwvHBNmauNC8hcb836qsJaoBN4CDVfAgOUJKA3F/Pcvp0OqGY7wHpJoi1pLTwo/PUQjYZR5BqrgDydfI8mSfHG9hNOCncX0/ncHWA8Oq6XNOK4cIBxJwPaT+O6O7ujpKEId+XCQDiappZuKODOaxAVgG2gYNWDBfQnpckoq3NTbq9vbWASRyTiQx7JcD4ZXSf5HKK68BBKwY2xMJRFFHMJZzlhzR5Zaxm+Yhmk0MaJIZupv0FSEnShYwMwy2VvK1UE8Km04yBGBA6ZTAAG9705rRPn1kaIJ4rn13sdDkWrmS/KqmmaGdnh3q9nhUW+/N9l5Pcp78/5oBh2OXHGLBXvMxktAiIM8xpuqBI057togHdYa9JNTUhpZ9fdikItunX1z5tF3MMcNLRJwy5ACfnGGOpALXCFCh8+a2aiytGlQCIJHGNZMVDE6RZsTE3jwBIQveAuGfIKZ9jvIBb5idJUBMAX4w5Pe50CzUofi1cMS+XANHtmArLa1VJNZuqx+VFt7slk1JiVGlw0ulNIVWziQCX8/yzJcXwPuLrsyHFPILw6RskMc9NnplI9KL0/wsgSpsxHGajBeTRA0gDCCclCKBI+fKEx9C7jP/HOGpeZtWsE5oEX4+cAXHgj8dvaMBfGMzLK4DMSkDch2FgGwzdPzmI6Pe3ckTVSTWbyIUMgp6FBCCAL48z+siQkJuUO1fFq5NqNpVseH/NpUc5kdLb14bTG7fqWE2quY7CMLSlxNcGoEHQrJRVUs11VZZyPThINX2Savok1fRJqumTVNMnqaZPUk1/RBv/AMUhLhyCXIScAAAAAElFTkSuQmCC",
            } },
{370,
            new Items.Pokemon()
            {
                Name = "Whismur",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAG6SURBVFhHzZVNUsJAEEa5UhLhIMIJjBewYKcrSG7BDQIeQMqVyEbKDT8bS1f+bFQWarlspwc7psYPCImFvXhV8BJSj2ZmqBCRaqDUBJSagFITUGoCSk1AqQkoNQGlJqDUBJSagFITUOalWq2S53kW99pfAeUmarWajXq+uKfF6MkSBIG5hO8vA5Tr4Li3mwP6vAstixGOlC9RdrpQrsKNs5yHFLc69DJ8oEa9kUYl7SvjHktPF8pV/Ao0cUyjvk+TZELz/twSN2P6GJhrtz8TLhoJ5Tps5JmJ/I7bCzwb93q5nBbDk3wHy6BIJJSbyO5eNw4FSuTOAgUOze7kdZHz/pQCf4eBHNc+alPUjOwGkbC4FafvbeRguRx4KbjPyAOUeZBAN46Ds9Gys93P5wXKPHAgr7/u4Ql1w+M0KDtB2dVFfloByjxwIJ91s94sjZwlUxvUj66tl9f+fwQyMkWZFMNnIE9Q4iLz3vd9czt+xiag3AaO5MP7NB6nQbwGe51x6TgGym3hSDkX5Z+m6LHiAmUZsrHutSJAqQkoNQGlJqDUBJSagFITUGoCSk1AqQkoNQGlJqDUA1W+AB3OhUnIUSgQAAAAAElFTkSuQmCC",
            } },
{371,
            new Items.Pokemon()
            {
                Name = "Loudred",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKCSURBVFhHzZZBUhpBFIa9EgjcIVY2DGySysqYA6i40V2MF1BvQHQDySKGXGKkLwBmZeEBJLAA5qX/nnqkp/NmJkMGq636ivKXmvnm79c97hCR14ihT4ihT4ihT4ihT4ihT4ihT4ihT4hhHo1GgyqVisH9W9mIYRaQC8MFDb7M6fr6iarVXR3L3y0DMUyjXq/Tt94zDQ8uSL3/RIPer1zJ/21bDNNgwVarTY+nXRr0swXLaFsM02DBydntusHOsRJvDLmibUuIYRYsya0ca8Grq4m5sb2URdtOQwzzwM2bzSZdXj7S9/6MhsOIlKLEUkLUbftFBReLBf34Ok/I2XC7d/oB8HvaKOQhhlnwbO1Wa0by5EQlRFarSH+NjLwttvVdbB8Xz6M3pG729M3DREPLZUS1WiyOH5bEw+AamyCGLpDDvGHZMPRTLTj/+dYAUTDoT9eidqN2i+51/wUxdIHg4WFodisEgyDQbS214Lu1qEu7HdBdb2oeapPNwYihCwsGQYuOju7NJwTVh/iMW9Pdo9nDn3YhaTfPI+JePwsxlMDO5RvgiLnfP0/ItXSr3Ky6fW1EWRByaJOXvMhMimEekA33P/4lB0ajkRaL5xSC3DifmUWXWwyzMHLdVxSt4iWGHN4UT2c3CVlbELPLs4gNtHVBPmbUwTlNTj8bOYZbnY3jGeQGIb3VGbRhSd4MLAuxaLkyzdqCRVuzEcMsIMc7mudOOhftTbL1Y8YGgtgInY6i8fjBfOLmWDq7VXf+XkwQQJLnyZ4pO0fL9ttkU0kxLAMeBbyf8Q8Fv6fd7+UhhmWR1nQRxNAnxNAnxNAnxNAnxNAnxNAnxNAnxNAnxNAfaOc3lBY0/IOZWVgAAAAASUVORK5CYII=",
            } },
{372,
            new Items.Pokemon()
            {
                Name = "Exploud",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAR/SURBVFhHzZZbbxpXFIXzl7jDa1tVsmVVAmZMnbqq1Ns7F0dK/NgqfQ3B7g8IkKh2Gim2o/6GeAb8nNaJVF/wa10DETFhd689c8gU7QRboGgeloAFnPPNOnvvmRtEFGqpZpikmmGSaoZJqhkmqWaYpJphkmpeV4lEgiKRiGjyu1mlmtcR4Jz6AvVfrtDrVzcpHpsvpGpeRSa1bDZL3b9WaDQaMuDq3CFVc5oAd8FQlpUjt75Io7fv4HqH8LMCmYhH+ef6GleVak4TAHe2L8i2CgzqgRk4t7lABQbvHnrerGmq5oeUSiXkWHO5HO0+7tKz31+Lei9XqdVYIsu2BbrvA39UQNMQlbLDcP0xnNFapT32Aew2FigW/YiAqVSKikWHXHckELvbvTHcxsYZ7fnv4VfKbYpGY/y3/6+Bi0RtXnUkqaamdCJFjnNJLcA98SHWDiSxcZr+a6Xc4hLIUyweFxDTLCgPNJep2VRyehOp5qRw1Se369RyhgInEDjObQ/o140O1WodTrAvjWNZttRnuzWk3qtvZAwB8uLPL8fN1G4uiqaVgGoGlUymJYWj2w1OqOelxdrkI33GKR6t1+nsTlNSC9YlyqDPdUijgTQOmur8xVfsfU0HPtzMgEju/v0TyuctqvEragxgO9td2mPYk/VHlIgl6PhOnW5xons+II4fNenUlzi9m5xqTo68Vjvl9TrcPF9Qi+GcBwuEY5/cNyjVNEJ6HqBNT7f+oZ2tCzk6iz8jkWJxnzY3GXiLx81jLzlorXJApZLD/1uWi8NYqlaPpAxQGmi0/QdLlE4neRt9byPVhJDevXvHnIS3aDabp2QyKZthUwBCg8GAbD7Cp1vnPmSX/njSk9+USi6V+egta1nqslTa9z7nC7N3MQCRQq12JsdlRkYmk+E0/uYNCx5kNkcWv0I7v51T/3B1fLsDYLV6LMltsGz7XQPFonFZb5pUEwomCMAY11rwOzn6nEWNT3LU9GUx7L8vVviOssgpeQmiPHBB6PjgnIzFZgREUsXic+/qGRDHHIl4KRrAxqfWGM4oz5BoCO942yJAYi3TRKjRqL/WNKmmUTqdlqtH90GpVIZtDTBPj/g9BEDAoREAVyp5kIDe5e6fW4JGSBLNARkvwXcVADY/s6n17U90tt5gNUU2gxRLzzm1ZbkoJA9gNIZ5uJhbgpqQHtLBxi7DdRiuw3MQcB0e2O3vfubazMkFoDQgdHQwPczRJN/XJ9fWpJrvE5LDeADgmzdv6eHnBTrFLZBB2z/cpVMGdb+/yx1t+aXRYdCOjBnMUSRYLrt8GmleTt9jUqqpCU8y3vD1Cr5aPREAAD3kox5eDqn94y9U44EMCNQchrNpFIwppB8slatINSeFOsRArlRcqSdsnpSjNqBeE5lGQspZbhYcLQYzai4e/fAt7X1STU3BZjEpZLjLTSpBH14ZD7Vcb3j6wXhZu8WNoTwfTpNqzqpg4oPB5fgVY2vyt9OkmvPQZOIm3etKNcMk1QyTVDNMUs0wSTXDJNUMk1QzPKIb/wFY1fqXwQ/swwAAAABJRU5ErkJggg==",
            } },
{373,
            new Items.Pokemon()
            {
                Name = "Clamperl",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHqSURBVFhHzZW9UsJAFEZ5JX4fJEmjrR2ONo4VrU8BaGfJEzC0lpSUtj5EAtf9ltywhC+QRGTuzpzJ5iSQ4ybBjoiYhkpLUGkJKi1BpSWotASVlqDSElRagkpLUFmX0Wgk3W7XUz52LaisA+LG01Qe5+Lp9gZOH45dK5rKS/T6Q0nT1E33I3ndSPSycZF9H6bhiP5rKJXnGA6H8vwhst1uJYoiT5ZlRWSW7dxph2gNx2fbQGUVWA2EhXFhJEaSJCfRNwnMb9VJmCfeR5W5RiSVDA3UFSq4nztmksTxwd1N3TYuAsez3cmLVBcqq0DkarUKwnLc/nryIDJf+G1cisR4ej992+tAJYPFTRZrv48wP7DN8SuaR+IcXc2mt5rKKsJIjdOVA/4xCOb+jwlWcjD451sM9MJHqxeA4xpanOdW0zvyfZegsgpc5Og2uy1WUIMK3IAPz1sul9LvN3+TqWQcxTk+v8WD+VFcDvzb148Hc3y2zSpSyci/vAgEYWT4FpePgTZxgMoqNBJDL4xnTJ/H0OkcK9d29QCV58CF8J8BI4zSUd73v30t4wCVlwgjdWA/dLoPbh4IcFGlHBM6zMufbQKVTdGoMKa83xYqLUGlJai0BJWWoNISVFqCSktQaQkqLUGlJai0g3R+AU+BLsFlJro2AAAAAElFTkSuQmCC",
            } },
{374,
            new Items.Pokemon()
            {
                Name = "Huntail",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKISURBVFhHzZbBUtNQGIV5pdukfQDGleMmaTbiG9AVLbyI4kZ9AwcXMvgCgi+AsgH6EuKwSOhvTuOh1zun2qSlcxffkJ4wyTfnT+7NjplFjQxjQoYxIcOYkGFMyDAmZBgTMowJGT4Fg8HAnHP1oT6/DBmuA0T8Y0rh+OW7a3O9pJWoDLvS7/ft52tnac/NJS4PnF1NnCX1b8idjgr7MXZ2NsosWVFShstgI6oBnIMchECRZ5bn+RzI7X2Y2vdJYrc313Z1mNir902b4XVCZBhCMQjcHzv78qcBX9QXhBylAESerEHcOMsyO93P7debhSCPOU78z2V9c1/Of95wHeQbfwbZTCgWSoaC4fg4BT9bBRmG8OIQpRj/ssGDr6Xlw+JRsouMQobL4LjvatFi+LcEzinJdUVlqKDc+LyyyTebA5lQMnyT1bjbIMMQrG9oh2Lk7ji1o4vSekk6F+WzCiiINrG0JEk3SRn6sBWIhHKzh9Lu3zaSaBNrHsYPQTwCfJux/mGxDq+9CjIkkMNuMKsWImytmpmlaWplWdpRLcw1j6JoDosx865jlqGP36DfGlryG6QI6LJjLEOGIXxBMDLc/PC8GTfbRGscpy+JsW7lLaZgVVVWFM0I/eNQru1u8S9k6AM5PGefnr2wYS35cfe5ndTgeJlceI11kCGBHJaXm9upndSCEAMPdXsQpigkOeatCmL9483RFsF4p9NG2hfc1Fh9ZOiDFiEwvpg9roG+MHYWjBafUqt+QrVBhgRyn/cX336EuwqfO8j5XzbhddZBhgSCamzMIX82Wnwnbl3wf0DU3383LQdk2Aa2qZreBDKMCRnGhAxjQoYxIcOYkGFMyDAmZBgPtvMb1lPiguNYcqkAAAAASUVORK5CYII=",
            } },
{375,
            new Items.Pokemon()
            {
                Name = "Gorebyss",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHsSURBVFhHzZTbccIwEEWZoSJsQx8YKiAVBCYNJHzl0QCBRvJqwIQfMjRjYOPrYROhXBsbnJn9ODNwJKTLaqWWiJiGSktQaQkqLUGlJai0BJWWoNISVFqCynPpdrvS6XSyj3z8HKisS6/Xy4Pd36YSBFGm+LxzoLIqbrDHqTQeDlBZBYRLZy/yNN39WzhA5Sk0nMzfc6IgzDSfeylUluGGQ7CmL4UPlWVoQK2a9mGdoHV+Q2URGm4zmUsYBPkG/lGf2hRr9Pt9ebjbShwPT86nsgi8c26gIsp6Emtcj5Is4F4mVysJOuX9SyVDq6chhoOBbGevR8FcikJiHX2Wqtx+Khl+QNntZHOzkGHMg5YFbLSCWNDvNYRrt9uSpqnI4uMomIsfEmutr2f5n2qkB/9UTckCRlFUK6CG08ul6HgRVLpoBYFfRQ2HWw32z2+/4wc0JNZJkkTCsPxIfagsApvgiViPZz9hcFniOJbxaClf43l+fPju9iVConr6PPnrlkFlGW5FdVOEQsD40Fu4negvDYk5q+Vn7eoBKquCN83vK31C3IAasm71AJV1QEX9734b6DG786pC5aUgpB6/hjQVELghcfT+eFWobAq9UL6vA5WWoNISVFqCSktQaQkqLUGlJai0BJWWoNIO0voGFSBKYthIjDoAAAAASUVORK5CYII=",
            } },
{376,
            new Items.Pokemon()
            {
                Name = "Absol",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKDSURBVFhHzZbLbtNAGIX7SrnYUZYsgVWcqGLdKgtASJSLoC2IdaGIh+AlcG5vg3gFGicZfKacMBqOnUxIyoz0aezj6fwn/z+XHhljokaKMSHFmJBiTEgxJqQYE1KMCSluQ5IkptFoWPxv+0SKddDY2flH8/Ly2jSbzVLWY/eBFKuAOdfYobMHpKjwzfnfQ2AVfF0hRR9lDlpIIJAk6Xp5HMRglmV2YlAURfnptrXb7Y0B1Y/cBim6YOKTkyfm9PSpNbhYLEr57zabzUyr1cKjnIPmts0ckaILDbrmXr//XD4v7bPbkMmyyTlg7r8aRAan06nNomvCrcCLi0/BG0yKLm4Av8SDwcBq4/HYmgP9ft+O4brs9XrrH4j3g2UQEzMQg329f88sSzMwSpM0CI6PH9ke30ONESn6wCR7Lvbv2UPzI3tghr9Nuwaxw998+FKa+7MMOp0OOjl/HVKswjWIkrPsrjk8w2BRLMxw+MxmkK1qE9UhxTr8NUmDNAejr95dW53ZZLsTgwAmsfhpzM3icnlbVq5LZHC1WlktTVN0cs4qpFgHzLlZQeMRwzLTMI6c0Whk5vO5NY5x+PuQDSPFTTCD7vqiSZaatwoN5XluJpOJHVN14yikuA2+ySqDBOORTRBSailuAgFgAmZgEMYQmObwjtvGvTXwnwzGhGQPSLEOZMIvF95xzqGUMEHDbpnPzq/s8bT3q86l2+2WR8xje8TAAA9f6Ojxjoyi3H6mMOZOdjED+cFQwpubn+vdGlrKKqQYCkr4/O3V+uDO8287ZUshxVCYVexqXIVputu9q5DirsAosunr/4IUY0KKMSHFmJBiTEgxJqQYE1KMCSnGgzn6Bbj8H2Q9g+zNAAAAAElFTkSuQmCC",
            } },
{377,
            new Items.Pokemon()
            {
                Name = "Shuppet",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGISURBVFhHzZQxTsNAEEVzHUo72D1HsE0DJTkFkApCA9wicIEATeqIC6UFDTtGY41WP+u117KmeEry1rGedj1eEJFpoLQElJaA0hJQWgJKS0BpCSgtAaUloLQElEMpy9J94LVUoBwCx90+7CjPl+4nviYFKIdQFIXdQI6rqoruHj/ofvPVRmZZ5pbw9WOAMgbZubpuusDr1av7/jlpKJR9yHMnQRznw2tZlrvL8T1igTIEx13dPJ8M00wRCWUIDuTj4x30g+Ro9Xrq8EAZggP32wtab/6fOx3HA7M9/FDTXHaRswcy/jFzhES/HX7p/ZsoX553Q5QyMFD2wRPMgfKMccDxeEbrp10bqOP0K8i/TwxQxqAjdSjDvq5r9/nSrsmrx79HDFD2od+BOuQUKZMMZQiJ0wMioaHYsZFQhpCj9d+DKEozWyATE6knfPYpZjhSD4UfK3H+/4YC5VDQjk4Rx0A5Br2jKUfqA6UloLQElJaA0hJQWgJKS0BpCSgtAaUloLQElHagxR+wMx8yushDfQAAAABJRU5ErkJggg==",
            } },
{378,
            new Items.Pokemon()
            {
                Name = "Banette",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIASURBVFhHzZVNUsJAEIW5EkGyl53uEjwBusIVP15CXAGeAjwJlBuQi2jpwrLavFANU+2LkMCiF18RPkj60TPT1ETENVR6gkpPUOkJKj1BpSeo9ASVnqDSE1R6gspjieNY6vV6dsk/PwdUFtFsNneBcD0eP0oURblT9LvngkoGAvV6XUnTNA+CcNPpkwwG97nr97v5dRSdNyiVDA04mYyk3U6zgKNdQBtSg9pnVIFKBvYbuhaGU9ThNeykfUYVqLQgXJIkf4JZbCc1pB6mKktPpQUFVklHngs6Z51damwNDV82JJUWXV4bZJV25CYrisIIGobQUGFQrELZkFQyEFIPCQKu27fSyAp9zxayad/JkCyrhrRLjaDHhqSSgVP8vrqSh+G2KIL+zJc0nBLH+7kZEs7TQ1BZBB68mF3K59s+KPhYX8tFgxfEPdaVgcr/0Hm4nLfyoK8vrWw/JvnBsB3UH9TIfJl9F0IlQ5dFN3qInlosu/716T3YFl+b4g4fgkoLCtlg4SgBcDpycMIREt1Dh7XT6KR99iGotNiAKA7C+RbOQ52F8MvZNph2tSxUWjQgioQjQn3RsMaerBpMoZKBMOGrgvfhf7SGQ2ftoakClWVAwLCjuMbSnyMcoPJUwtCnQqUnqPQElZ6g0hNUeoJKT1DpCSo9QaUnqPQElX6Q2i93Ttrbw8VEBwAAAABJRU5ErkJggg==",
            } },
{379,
            new Items.Pokemon()
            {
                Name = "Seviper",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIYSURBVFhHzZTNLgRBFIW9UnfPzDsgFjM7luwICVb+XsCMpxDsJXgJPImfBYmVXHVmHLnaUboZyV18qerT1V1f36rqGTMLjQwjIcNIyDASMoyEDCMhw0jIMBIyjIQMIyHDadPr9awoitTV93PIcNpA8Glz2Tple0kZNoWVIfX7hIIv2yutJWWYAyKdTmllVdnqzqGt7Y0+KMoyDfn6DAQx9jkJtpWU4XdA7uJkzh5vB7a+P7SNg5GdjF6S3FFWEHjJfxGEHMQoeHk6P24ngiNbWtlOy/y9YLfb/VUVZajw1bs6W7D764kcBXN7EFAQY9tUUYZ1WD1WzF5frVuV40rgGnn5vrwYS/g84TLntkIdGdbBZPhyVgxilBsMJuJo/Ydgj1KEp539NpIy9ODFmNwL4ppQiH1uA4wfL30SOT+etYebvlVVYf1+346Hz6ninfR6PadHhh4IXizNfZLyYgAHBDLMKcfsLu1XVBT9xeWtHw+UR4YeCrLF0npBTOYFvRxBvro7HI9Dn8vdBBnW4QvRQhAt8HI5IMWx/yJIvCCvIaBE69XkGNB0eYEMc/ivRx8T4uDkBHGPVfTPN0GGTcjJeSGC8W3lgAybgMn42/EiwMvhIP1GjMiwCRT0YjzVuIcW/8S/yAEZNoUilEHlKIT2r3JAhm2gyLSE6sgwEjKMhAwjIcNIyDASMoyEDCMhw0jIMBIyjIPNvAGIMeCOMixXhQAAAABJRU5ErkJggg==",
            } },
{380,
            new Items.Pokemon()
            {
                Name = "Zangoose",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIWSURBVFhHzZVLbuJAFEWzJcRnH3wHsINEGaQ7KwgsIxl2T6Iedg9AsKJIGWTQg4ZU6hieVbaug/k0eU86Ktd1yXX0yoarEIJrZOgJGXpChp6QoSdk6AkZekKGnpChJ2RYl06nEwd971zIsA7Izefz0Gw241SvOQcyrEMdQdY0Go14qe/XQYb7aLfbmdxyuZSCJvZyfR2aXyk4m92HXq9X6BJyiL3e3JwsBzLcB4IPD3dhs1nH6bZarVbeNeTg93h8+Q7uupXX6+1teF/vRH8+hWidZWW50WiUXx+CDD9DCQ7iMU+n37YdjZJ/JpOC3HA4DIvFIvT7/Sxjbvf2IcMqynL2/r09/wvvm22GsMnRNdYgxweFIPN17DivBGv2IcMqeDjF+0X9/RUyQUYEkbOPo9vt5mJlOeq/CIJJpmUfBXDcqZjJmRhVVw5kWAXdsk2ti1n9eMzng8GgcKyb+NGktVqtDvr3kaHC5ArHHMWqClEkU8FD5UCGZZDjZwO5VMy6Npt9z0Yr1lmnDcR4Tiy5RxUyTOGhbFgQLJUJsoYqCx7atRQZppggIyDDpuUyeSQZU8ljOmfIMMXE0jmbqmNFzDDBU+RAhlWwmXUQ0i6ZoI2sO1UOZFhF2j1G5pZRyHHPxosLgkmlm++uC4LnkAMZHkMqSbkUTCnfPxYZekKGnpChJ2ToCRl6QoaekKEnZOgJGfohXH0ALCRpJj75cxYAAAAASUVORK5CYII=",
            } },
{381,
            new Items.Pokemon()
            {
                Name = "Relicanth",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIESURBVFhHzZbLUcNAEESdkr952CYDjpxkOQpMBMDNcIIIMERh8AWIgs91ccvVYry0ZIlaqDm8KqlXqn2aWa3UCSG4RoaekKEnZOgJGXpChp6QoSdk6AkZekKGKRkOh6Hb7RbEY02QYSpGo1FY352H67M89Hq9baSvq0OGbYCEqo6Ve7q/CP3+PwtS7O35JmweLn8IYDzLsvC42pereqAqZHgITEIxEktALs/zArZ3MOiXedOWy7AOJWcFMT4ej8NsNitF+JIo6UPIsI4qwaPptJDAusM51h5lwGQyKVguduJXi2aSMqwCW4Zd+FZuvdqJgfl8X45gPfKapm+2DBV1cmwnBOLKEVQM93E8aYvRVsrVCVZhK8fqJhdcnmZlBawgzqfbtVVW8fgkzCNhVu83kjK0UO7j5XZPqqqKENxEkvHaY55MEO39fP0WVEASbylEWUUrxmv4IElaDDnsXe+iemwtpOwbbCVsa/kAINmXJBaEFMWwn9k2EwpaOdyDiiXfqCnIVrF6ViiGgqwWqmu/Mm0lZWjh/ofJWT22NBbmOFusJNr+H8rQgqfGtxXVYFvtelLr77ftVMgwBpLcB221bEVxDBFWxrbzzwUBJsTkEKUchbAE4v9Be0+ct0GGdXBSOzEyHqdGhp6QoSdk6AkZekKGnpChJ2ToCRl6QoaekKEfQucLzFT3MfaN+DkAAAAASUVORK5CYII=",
            } },
{382,
            new Items.Pokemon()
            {
                Name = "Aron",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFiSURBVFhHzZRbboJQFEWdSydQijAPoKOwI+AxjI5G0v5onEVH0fYLklO2zaEUd0AhMftjxeu6xrs8et2YmTRUKkGlElQqQaUSVCpBpRJUKkGlElQqQaUSVCpBpRJUKkHlLcRxbEEQ9Iz310LltSAuz3Nr29beTyd76wjDsNv6218bTeU14PCmabql9XEOIhHm+9vtFg/0feagcg4Wl2WZpWlq9fF4XhdF0U92ONVboXIODxxObhjoz30NlkZSOUUURRe/u6qqrCzLf0EeOAxfEknlFOPpIe6l/rZiFCkT+PD6YY9Poe32n5ZmzxeBWPvzJTeayikQuD8c+oMRmHRhu/qrD/Sp4aJgqlgv/buhcg6PxNeLIETm5e96GOdheO3dLomDyzKcJAIQA5IkOcd6FD7QXSfo+MHjw9cEjaFSCSqVoFIJKpWgUgkqlaBSCSqVoFIJKpWgUgkqlaBSCSp1sM0PsNZvu4EQ+SgAAAAASUVORK5CYII=",
            } },
{383,
            new Items.Pokemon()
            {
                Name = "Lairon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHHSURBVFhHzZJbTgJBEEXZikvgERYC7MId8NiFX8Y/wioUv4BluA0/QFrOxEsqk6tCB01VctLdt4fpQ/V0SimpsWEmbJgJG2bChpmwYSZsmAkbZsKGmbBhJmyYCRvWMBwOS7fbPU39uhYbXgKHSwCZ/X7PvAwGgyaP61PZd1yCDX/jS6wpybzudmV9Yjwel+fNpplrrT9Sgw1/IsohMBqNzjIwn8/L4XA4C2td20kbOhADDqUkhODTanXOqcVi0Ugxqpu1nbRhG3VtNps1IyVBScaSGFLsPS6XzW9rOmnDNrFzVJQDOoiIrhsZrafT6VnyZbst/X7/qk7aMKLucbBKYlFKpQxJiUqSkc7yXfZ6PR63Z0ZsGEEwSkgOJKBiDpJrC2pOfnNBFWI6LEork1Qcgc59HI9lMpn8zRVT7c5pHeW0J/SMvtNr5MCGEV7IAZRkdOjdw1uDcgm2JQXP3VwQ1EWJSY78fv3erCXFyJrSn4ty/yIoCRE7BFynRCQlyK7Bhg5ezuHtK9TBWmufqhFqY8PvkEwk7lFIUu39WmxYi6RuJQc2zIQNM2HDTNgwEzbMhA0zYcNM2DATNsyEDTNhw0zYMA+l8wkYEUiYFbQ5zAAAAABJRU5ErkJggg==",
            } },
{384,
            new Items.Pokemon()
            {
                Name = "Aggron",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKJSURBVFhHzZXLcRpBFEUVizPgmwefJFwuB8AvCu9c5ZWqFIT12UgoCsVhLQC157S4+Kl9QSCx6Fd1amZuN/0OPTNwkVKqGhvWhA1rwoY1YcOasGFN2LAmbFgTNhT9fj+1Wq2MuxYxL8c+iw0FjVerVbp7fEydTic355rqdrs7od/392nz8pJzSmNN2XVPwYaRKDmfz9NwOEzr9boZeq3FYvHmWqUv1ZRd91hsWIIku3T7juR4PH4zFne+Kbv2e9jQQZPBYLBrjkx57gRHo1G+/uhtt6Gj1+s1h3+l5ghdPzzk3dVzyBjXkouFaFO2h8OGEcSiHAqbzSafc2tns1lGkiLK/bq6ynPa7fbJu2hDYKHtYllK7yjNs1jDlx9P6evNn3S9fH02JcuuRn5eXqab5fJDL40NeSlU7AK7A2qO5Pe753y7vt0+7wSZo9sO0+l0d64dPlXShqAdRBY4VzN2A3Q74y2WIHJxR7UeqAePTpmV2NDBIjRCQs+e5Dgi7OQEz19cjy/NrwJzy7GIDUuQUyPtYJTUzkVBjqKUQG4ymVjxEhtGttu/E5SkxCQRxyD+vJQ/Ldq9Q7dW2DDCIiAZXe8TA+Yq59nk91GSp+we2LBEUhCzKAVRVIKS1F+enjvNi2s6bHgMEpSEzjlSOiqDKMa5xg5J2vA9WDBKuXNBaYyjJCUIn36LI9tvm0tNy6M7j3N0LsmzC7IoLwIlCREFNIeKYxrXbp7tFrOQ3mY1IpO0GkOUo+LnNAcOyYEN9yEZNYsNNKY8zgEnps8ewoaH0ML7GigvxahDn9uHDc/BVuI/uabs/H3Y8BxIKFLOOQYb1oQNa8KGNWHDmrBhTdiwJmxYEzash3TxF/R3vQiHk8TEAAAAAElFTkSuQmCC",
            } },
{385,
            new Items.Pokemon()
            {
                Name = "Castform",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFoSURBVFhHzZYLioMwFEXdkoruQ3QjHWYFLd2EuBs/m1LMeDOkvM5c2mhSfIFD5UTKITGtiTFGNVRqgkpNUKkJKjVBpSao1ASVmqBSE1Rqgsq9lGVp0jTdLvl8CFTuAXF935tpmkye55vi9x2FSl+KovhoHKDSFxlY17Xd5thbTeUe5Bbf799mGAa7mrFCqfTFxWH1EIZISYxtp9IHuXKvCI2k0gfVgTgc8zzTIEZIJJXvQGBVVU/P3bqu29TvkHHglECsIIaLwycOy7IsDw+6rjNZlkHR73oHlT7ISIymaexPiwwPjQNU+oDAtm1txDiO/7Z4G8mpgUBGYnvdNcB8aBygcg/uwMg497f3994jUOkL4q7Xiz3NLg5gyzGPFQwNpdIXBL76sXb3nXKKgVxB96Ig405fQYBIROA5vN2+HpExXhQAlUdxsbEOCKBSE1RqgkpNUKkJKjVBpSao1ASVmqBSE1TqwSQ/rCyGQH3Sg9oAAAAASUVORK5CYII=",
            } },
{386,
            new Items.Pokemon()
            {
                Name = "Volbeat",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIvSURBVFhHzZZLTttgFEbZUmInAqkTEJMAEztZAeyAzmAHLWwAwSiYBfAaNJgJhQ0guoo+Bi1lYEcXfw5X/JjPIXZoc5GOQg5xOL72b3tORExDpSWotASVlqDSElRagkpLUGkJKi1BpSWoLKPdbkuj0cgp/u1fQSWj1WrJ79t5efi2IHG0KF6zPBI7UnR1obIMRH7pL8rfu/JI3RHfe58pU1kGJqP/XF/1kIMgCGTQX8p3YGaB7gTjaEnOVjvycz2Qs5UVub8dhSG+1wve5VylchyIxKTCMJQ/WdD52nPgxdP0EN/tBvJ9PRRvykgqx4HA405Hoq+p3N99kN39RA6vRaIbyd9jcohH3K+NEdNEUlmGG4cgF437vJdK2O3NLjBJErk8Wpbo+nXkzv4zbiQOf91IKstAoK7e/lVCw2YaCHCd+7SX5AE413BILw6XZThMZfeAx/3XQIBJIlKn1Wz6+WSxYFhcN1v1eq0sftdbUDkOxOllRifoHlb1J04c3qdpmm0u4vs+Xuh3M6h8C0TqnUODwNbWpmxvf5Qf2fR6T24wGEgcx9kpMMw2Hf1UiaRyUtwHiKObJLs4v5ygTk8jPc+rfJiprAIisaJxHdQnHdxFNBTUPf8AlZOCOBxmTGvHORdPV9deLI7idlWgclI0UKeEBwk8QOgEET7NXQRQWQVE6pT0d3fx6OfqQuW06Cov+jpQaQkqLUGlJai0BJWWoNISVFqCSktQaQkq7SBzjzDwI7pstvpIAAAAAElFTkSuQmCC",
            } },
{387,
            new Items.Pokemon()
            {
                Name = "Illumise",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAI+SURBVFhHzZZNbtpQFIWznXRUsPE+bDNp1U2kPwMo3YRLVpB2VGUFVUc4ngR5AxHdRFIywHD7zkue9eqeODFY6CJ9Ij4G8+nc9+yciIhqaKgJGmqChpqgoSZoqAkaaoKGmqChJmioCRo+RxRF5o2f6xsatjEajeT25kzCYGgO+Wf6hIZtNAVxPBgMLP5n/ONDoGEbGC8Ei8tXEgxfy+LiWorvpcw/lzIcBlasz4Zp2AYEFz9OZb06k/E4kSRJJJsu5epbKWmayt3Ne7n//cGe66NFGj4F5LLJtZVZrz5aiSy/k3lxb+TGVhaCaDdNYyuOVpvX6QINn8K2Z0aKppyYz5/Vp7q9/GJpRx8cS9C1h7U2z9f/yTlBX85fm83rvRQaMpzgttrJu/NSvl5xSYBx+5KHtEhDRhSNasEwDCVb3P4rNntoC+2+nZeSm3V61AYB7m92zEYCLbl1CKFqu5PzL2YnJ2m9s63wo+C+O5qGbWDUcRzLm2xZj3kYhLLZbMz6M9LeLQd/O2GwjyQN24DgZDKpf9QX9deeaw+CVVWZrz68sDzMi16bQcPngCTawLj9hhxuvDj3M1/KdrczX+suB2j4UiDqHnvF5alpMJbpdFqLQu5XUcpsNjPrcL9HHw27YDeO2dH+TdpvE00f8sijYRcgiE2DHY3djPVod/jjmI/6qGM4Qb8tf20e0h6gYVea//81pV2+DzTsA7fTm3lXaKgJGmqChpqgoSZoqAkaaoKGmqChJmioCRrqQU7+As4MRShwpkGmAAAAAElFTkSuQmCC",
            } },
{388,
            new Items.Pokemon()
            {
                Name = "Lileep",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIASURBVFhHzZU9UgJBEIW9jiEg3IOfE6CRZqCBmomnUDM1QhPRRMtIy8SfU6AeQArDdt9uva0RH4iDYgdfFfOYmv2qp3t3wcxcI0NPyNATMvSEDD0hQ0/I0BMy9IQMPSFDT8gwlnK5bIVCIfmp/49BhtNAGQph/XZ2Zu8XF7ZUKuVZuCcGGX5HpVLJZShUrVat3zm0191ja9TqqdTontFzpkGGk0BV+juHdr28m/LSOcqlarVaDmXDfaViMTlCnzsOGU4CgpfNnfSh9UBo0F+1jfWWtdvtT6LgqtlJ95cKcxAEuGJc6aDXy6vXamVyYPC8Zo1GVsXh+bk16tmVj54zDTKcRDgMZFQSVaNcuC+mD2U4jrD/hr2sMrxGVJPr8DfX1ytxfSjDcVCQFevuPVg9EYEAKhQKcs09HJo/FQSQRP9tbd0mMp/lIHN68PRFmntj+lCG34Eh2dy8SR/KCcVEQ2R7+07mxeKc3oMEkqhIeOWhYHilc/+ShFAUFYUcQcVmESMyjIHvRgzJb4gRGf4EVhByt91FuztdTIakmmb/XkEOC/sOn7v31+wrwn6MHQ4iw58Aye7effp6Yf+d7D+m61nlgAynBe9EyIVShNm/VpD9B3DVlOTV/kYfyjCGUHZWqRAZekKGnpChJ2ToCRl6QoaekKEnZOgJGXpChn6whQ9IgSUVETKsMwAAAABJRU5ErkJggg==",
            } },
{389,
            new Items.Pokemon()
            {
                Name = "Cradily",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKvSURBVFhHzZZNdhJBFIWzJUBYQHZAw4RkBm4gYaTO8jMJceYIM4uOEAdqVpHIhGNWgGYB6nFg9Fm3w+0u6lwaJM05NfgO9O3u1K1b772wY2ZRI8WYkGJMSDEmpBgTUowJKcaEFGNCiuvQaDSsUqm4r/p+WUhxFTA3fXZkty9OrFatOkk/VwZSXAZTAzQ43utZdUmS/vPhvXWRogKLjTpd+/L8ODXWTpL0+s/HS3tSW0yRxvh80SZWIUWFf6xYEMbarZbdu8/bi/PsqPHc7w+XZldv7f3+02xDm5aCFEPq9XpqDqklc2AMJmgSKSI1miO4v/UjXpYezU6HA3edm0ZyLW8zndGhVbaZIGBdISGYG9wM7XxyYXvjviXOHEziqMf7vdQc65MpwugmSUqxCBhtNpvpgjQJEmeCSeLz76c3WZqPqUMpKpjg2XVuKoQmmSQ6F5uZep3/vylKMQTmfGM/v/Xt113fXk5eZ8aQJo/bP04/8U1qUYo+WOD77CAzA3P8/nXSWzAJA349+qOnMzpIN7BVgzTHTxpkckxoOjzLahDjZ3bdtTv37NWrXWe6xCPG/MMfZ0oqPSSXHDtz7/Ljw3vodjQIxhK6enbTtVqt5C7GQmFTwBjSyMy5xVV9cbhv2hxEiiQt8KPmwjghPNYfs0Nrt5cbZIJbMQhCk6mxk4fUYA5ptk+dAa+2mDwT5rvV4EfFOkjRJzU4HxPLYHpICRTNSpjkc+FaCimGcEwwuZR5Y2Szz13jvioHH56A31RFSFEBk9g15xlgaigBmodBv9uT03yIDz7nWukGCeorPCKaBxxLMInm8RPlfxweM98vQoqPgRuAUfxwoEE/9fCdIqRYBn6qaBqYQ62umxyRYtn4ZsN7q5BiTEgxJqQYE1KMCSnGhBRjQooxIcV4sJ1/pdXL7A78WBgAAAAASUVORK5CYII=",
            } },
{390,
            new Items.Pokemon()
            {
                Name = "Anorith",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIiSURBVFhHzZZNTsJQFIXdEuVnH1AmOtSwAR2JM3EE7AR1ASCsSuIAkmtP9ZSbeoC2huSSfKEcH7yP8/oeXplZaGQYCRlGQoaRkGEkZBgJGUZChpGQYSRkGAkZ1qHb7Vqr1cou6/2tKjI8BycGi9tbe7u7s6QkgjHT6aMlSZLnTWVleIper1dIfaxWlqaprbLn9Xpt7XY7G3IYR0GIedk6yFCBCTFRv9+3wWBQSAFKQpDNYtxsNs7H4nk+f7qcoG/NN0dRXpPJYmYvb3MbpP+TAzJUUBJybI7t+ZZAWZKtlj+zCjI8BiT9EkOOYmzPv4Ykmlsul/mX4S1Q/txTyFBBuf1+b5vN5s+yejFcUxAN4hrvex+NbHs/tk6N5ZahAoK73c46nU6xCShHyu1BjpsJX+gzk/t6eMqpKilDBc4xLBWW6XkxzSfHhEMh6QXRHB5oL/0dU2eZZXgMtAhJtAGBbdYEBb2sb4+3QpP2gAyP4TeJv78w+Xt2/KAhn7M9PIbDYZ7V3dEyVEAOS5sfHS83hSRe8zhB5sUg1XRzEBkq8vaer23y+tMQmyg2y+S6kONG4u3QdHmBDBVsEO21ksMSUZy53+ncVPwyhO+tggyPQUn+bPll9xkPZrRXV6iMDE+B48ZflwUBJJu0pZBhVSDI+7LpPwPnkGFV2OCl5IAM6+CX/BLIMBIyjIQMIyHDSMgwEjKMhAwjIcNIyDASMoyDXX0DrGrfVuukfgcAAAAASUVORK5CYII=",
            } },
{391,
            new Items.Pokemon()
            {
                Name = "Armaldo",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJ3SURBVFhHzZfBctJQFIb7SqTAe5CwoXZlxwcwwYV13Gh9GloXdXTB1o4vgfQlirIAPOYP/pkz1x9TJOhdfNPwc5n79ZxzQzgxs6iRYUzIMCZkGBMyjAkZxoQMY0KGMSFDT6/Xs06nU17q94+NDEm/37fRm1s7u/poneT0v4jK0IMKTqdT22w2dv7uUy1KwvVtI0MPBFHFdSnY7XZtMBhYnudWFEVFkiS1KMehTXEZhmBjiKVpaounI3tRCuLaA6mXk5m9urmvSFoaCRkqMI8PTg6iy4szG/4SvCzlILVarcrlZq/fbyXx2UOQYQjkUJ2iGO+UW29+2HA4tPV63ZockGEIBdNsWAkRiLGleI+v22ovkKGCkhQi3+ZjW94X9uUmtSzbiqOKy2fn1v2XMwggico8zJ5XUl5s9PaD3V1ntSTwVeRnec28CRk2gQ14qgHkcDOH4Pd5Xs7i71XkZyCJTjx2RmXYBDb7PBnYk6utmGfxdVwJhlWk4L5zKsNd8EaMjRazvGovJFm5sO2+iqwc5Pxha5KUoQIVCDeAJKVYNWS4RtvTNKsyjgC4vJ7X1WutgpTztxJc303SeuZ8jo3x9QhBrOEhoiS+z8M9diFDD7/mIID/nIfDV4hy2BwZBLkOeMl95IAMPRRkO1BNPoKFFUL7fJX9OGDdadLc0hAZengw+NoLUtK318t5yaMJeiCHZ8Msy+p2sZ0Q84KsHF7vcyhCZPgnWFFu5kcA8DBx/v5GyiPDfYEk//pq+gpy7b7I8BAwBngmxM8DHBo8huFJPFz3WGR4KJBky6No8TGRYUzIMCZkGBMyjAkZxoQMY0KGMSHDeLCTnw350Db2y4MJAAAAAElFTkSuQmCC",
            } },
{392,
            new Items.Pokemon()
            {
                Name = "Ralts",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHCSURBVFhHzZZNTsJQFEbdUn9gLjugugKcyYjWSSlMRJfByLgBlQkhTDROjE78WQHRBThwAPX6bvHhC36R11ejt8kJ7aFNTu5rC1tEJBooJQGlJKCUBJSSgFISUEoCSklAKQkoJQGlJKAsQ71eJ8/z1K6dLwuUtnDEa3pCb9kphb5fBGlmzQ69RAkFnq9OxdfbAKUtOpBDmF63S8lFQoPHNkW7EV01Wiqw2hShtIUDL7db9NyMV4GDhzYdPS1JRjH5wT9NsFar0eH9fjGpWRTTdWOPjtWxGceTrBoJpQ1mIC/lwfkyyIzTsX7gvsxQboKXluN0AEfGPwQyrpFQbmI90AxCccyfBjIc2TnrFDFZ7+vhQIHsXO9DKG3hyDRNKcuyb4H8mYwSinaiSi9sKMvAkfP5nPr9fhGqWSwWFIahOgVfZwuUZeHI8fiG8vxdHS6334hjoHTBXG5f/eytf+8KlC7we5GXmvfzPJc1QX0fTqd3xTIPh0OaTG4pCILK/2igLIv5oPDDYW4czaFqg9duAkoXOJKn9bnMqzAREzTRoVXDNFBKAkpJQCkJKCUBpSSglASUkoBSElBKAkpJQCkH2voASLRe3E6NHoMAAAAASUVORK5CYII=",
            } },
{393,
            new Items.Pokemon()
            {
                Name = "Kirlia",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJNSURBVFhHzZa9UttQEIX9SrZsP0C6QKWfBtJRhsoWjWdcxamSjiFPkDcI0GCgosPQJNBk0mWSJpMXsNFG5zIbNOLYkq/BrGa+kedIsj/t6q7cEBHT0NASNLQEDS1BQ0vQ0BI0tAQNLUHDOnS7XWk2m/lHfvypoGEVkJt++Cy/o1SCZiuPpAHZIsVzV7kRGlbR6XT+CyZR5AR6X3oyutmV97e7kh73pRW0XF6+kWWhYRWoys+w5+RGX986IZVToiSS2cd7ubULAki+qyn3IhWEHGSqBPcOU9fu8nfUhYZVLKqeCkZ5+/uHD8dbgd9CoWEVVYIbn7Zl9O2+wsraBCEXhuHcxQG58elE4jh+dI6PJA0XAUGMlCh+vILR2otXO5LNZpIkiTuOXM95dkHMP8ilx6lsHGxLWJCE8Hg8kV/xnhM8P79+kirScB5aPciB/tHDQD45uZSzs2u5u8ucXBAELi+v9mcVBJB8vb/l5FBJHSHIB4OBW736akO2dkGAH4YEFgv2AHJo8XA4dHu0t1xBn3lIw7pAdDqd5h/FLQqIoc1lSQXXLAsNlwGSqOTk+x8nB6lZvkh0a7fb2NFr60DDuuhzByEsjKsffyXLMldNPIvF59EXGtah2F7IbR68cWMHlYSkbsUVnW/0uxZBw7pgLurzhTbj3Yt5qC2GHMaObj7tpqEPqKi+YdBalUS79SZw3rLQ0BdIYkbijwLm3SpiCg19gSDmns87dx40XAVIlrNVoKElaGgJGlqChpagoSVoaAkaWoKGlqChHaTxD9DvHbcJtricAAAAAElFTkSuQmCC",
            } },
{394,
            new Items.Pokemon()
            {
                Name = "Gardevoir",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJdSURBVFhHzZbNUhpBFIV9JRhgb9yZbGZgZVxRWSUrh6yg2ASfgMIXiXGj0RfIz8YkT5BUNnkDBm/mjB5s2jMIOIXdVV+pp7rgm3u777hjZkEjw5CQYUjIMCRkGBIyDAkZhoQMQ0KGq9BqtaxWqy3g76kCGS6DYh+u39rxr3fWO0tzerY/ObBavXpRGZYBuaOPRzb6eS+G3yFKkNejer5df8a6yFDRbDYXquaLuVQpKUMFqgdBX66skvWomlbL0IdyFKLMY5WsQlKGPqp6vtz+yUFxUcDox+3DPJugK0exbJblW81enRxuXxD4Nxg/ITfe69osy+zq6ru9nLyeyz2LIKvIuRe3E/udpHZzJzib3cwruNVLQiiZdBK7uPhaCGGxejx/eIitjxmCeRjHsSVJYv1+vxBtt9s2cm75Vgc1qua+b3EO0eIkb+/4Rde+Xf8r2op2c4//GU9BhoQt5aFndVBBnL2/Sc/en96exyrPnYsMXdzLwdYhG+927U+cFoK8NJSssooy9GGb3b/Pz7/YZO+Nfb67LGhz+ul+PlL0qW2X4TIgN51O52OFP7E6nY6lp4tvGCW7jrAMl0FBVIxvD18SN5y3GiMpy+ekvxqNxkqiMiwDI4Zy7uvNFeSiKEfR5eXDPVgQzZf8PiBDBeRw7vAlHCtuZYbDoayUu/AgEI2iaOVWy1Dhtpb/2lOYC5KDweCBqFvxxyrmI8Myym6z3zq3mu4DrVIxHxmuA6VRXSweft50tBP7NkWGm4Az6ld3k4r5yDAkZBgSMgwJGYaEDENChiEhw5CQYTjYzn9NfjY8eKDehgAAAABJRU5ErkJggg==",
            } },
{395,
            new Items.Pokemon()
            {
                Name = "Bagon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAHlSURBVFhHzZVLTsJQFIbdUh+wCOKkjwk6A9yIOKJ0FUQXwMMBlBWITHQJJC5A1AGQY8+NhzTkt1Bo0jP4Yvm0+OXc3tsrIlINlJqAUhNQagJKTUCpCSg1AaUmoNQElJqAsij1ep0syzIc/u5SoDyFbNR0OqT5fEJBEJQeCeUxOK7X65Hv+zSbjUyc4DhOqZFQ5vFfXL/fNyTJeB96eO85QJkHCkST5FjbttNb8PecCpTH4EjP80wUP3fZOP7MwVEUVRt4P/wkPwj305Ow7XZLcRyXEsdAmUetVjNxD5Mfg0RymOu6tNls6C5e0vo9JtepYIIyPQkUkuSZdrudiWv3l7RKbtONcvluhjIPDmz1Xqg7/t7HcRDj+wG1osX+uoznEMpjSKSESRAvcxiGJlICefkvORehPAWO5H+8mjbpY35jCAOfGq0BeX+TLGOKUBZBQvnYkbjuaG2WnjfQpW8VKIsiS84Tk7hG5ym9/jI/LaviCWbj5NjhJZaNZDtu+qf4/mNAWQQ+FyVw/Ralx8yCGu1HM73sLrfs897NUBYlO8XVrEnXnUE6wVczQdnllQYyslmE7DF0bhwDZRlwsLxxKn0G85CpHvoiQKkJKDUBpSag1ASUmoBSE1BqAkpNQKkJKPVAV7+Hb0ZA2UAM4QAAAABJRU5ErkJggg==",
            } },
{396,
            new Items.Pokemon()
            {
                Name = "Shelgon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIKSURBVFhHzZZNTsJQFEbdjo5sC+wBZi2EhWgcQGGkrsaZfwMaGDnT5cAImmu/wsVn/VpoCea+5MT0NNjDfW3DhYiYhkpLUGkJKi1BpSWotASVlqDSElRagsqmtNtt8TxvT/F8E6isQ6fT2Qet1+tM/axWq4U/9HPHQuUxaBiiFot3SdM009s1nU4ljuMc3/dPmiaVh0DcaDSSzWbzK07D4Iur6TSprGI4HOYBiHED9bi4NBqTzBb9n1VQWQYmhy0txrA4DXN9kylSWUZZYHFVna8bSSVD47CqAg6dq7vVVDLwjnNfIyykLA7e3e46U6SyDJ0iHozJJJYoimQ8HkuSvObH+MteN2503SlSyXBfLbgI4lwQWgwpHiMWXyIIAih6nSJUMtwHZLW6yrbpWsIwLI3UKSNKw+bzt1pxgEqG+5AMBgNZLi/l8a6bhW0jP548CXwvn7LGuGjs2R4SoJEIdCcH7m968nDbk3R3C+jk/m2CAIGz2XN+oX6//ycS24utdSfnUjcOUFkFInHvJckLvcfKwBdq8qOByirwPsR9hokhUgM0loUiDg8Qzp/9HkQcLvQV9STY/Q7UbdcYxOv7Edv6GXZlkh3D150ilVUgEhdxL6S/pDUEX8CNYZ85Fiqb4k64yXYyqDyFU6bFoNISVFqCSktQaQkqLUGlJai0BJWWoNISVNpBLr4BD/x9dnyjvU4AAAAASUVORK5CYII=",
            } },
{397,
            new Items.Pokemon()
            {
                Name = "Salamence",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALKSURBVFhHzZZLctNAEIZzJVu2KzZseGwgKz1OkawgYZEENsa+gPAqJBeRrFwAwmWgYKGYjv6xemiN27KNvRiqviL+x5n51DPTyhEReY0a+oQa+oQa+oQa+oQa+oQa+oQa+oQatjEYDKjT6Vjc8UOjhoBF3Cw9fkGz4UtLV8jy9w/5EGoIsEiYfqNON6g+NnMsKkXjMKSr/JGiODFjP09P6c/ZmaW3h6gaAhaMZj9WJHkckix3XZARTGvh/G1ERc3vWvh/RNWQ6ff7DUmeHDl+DiuRKP1OV/O/Vk5WVUq6orzGJtSQQZWyN6GZ/KOyhUkUrVSvTZCB6LaSagh4C6+zfwK/xNlqk9tGEgRbSKohgOBlVloBu1CeU3ESm4pizBWUtxpHoE0QbJJUQykH8uKegiCgsiyrYaJP98t8dHFHw/NbQxjF9owy8oisY2dBKQeBy3xhRbehG/SqaZbz4Ky6MlxdKd4mqYaY/PjdDYVfHswN5gpF4twBbC0yhiuI398kIb+zsyCwE2QZFUVhieO4cTnQZvAQUZXjHOIMumcvDpfy/ADaOm7OqKGEex5jel9dSRZrCNdj+Uli5WTVcQTkfO56LmrYBp7YNO9ajG8wtyNGyspcjg/f31QvgG6r7ErQhpVD5erqQQLbiRbjSm6CJbkTQNZds/GhDSnHE44/T2h0/tX8vO62y06AbXf7Jwumw1fm/LrrNj6sQ6tcXjXsyWRCi8WCptNpq6jZ7uoypaPXNK9urXltirn23mJXEAvhacfjsRXE//iXJMnKuYMgS6CtxHzzK7S/lCRqKIEct5p49qD+VYM3DEtqgty85XzPLm4py+fmDcVjGmrogkm5Au4Y0FpRm6T8PmfrUMN9gYB8l7uCu6CGhwBVx9Y//3BH5eOCej3PBMEuW7kONfQJNfQJNfQJNfQJNfQJNfQJNfQJNfQJNfQHOnoCBzGSzuvDWOsAAAAASUVORK5CYII=",
            } },
{398,
            new Items.Pokemon()
            {
                Name = "Beldum",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAG6SURBVFhHzZXBTsJAFEX5pYKQuJSd7DrwBXWnfoW4Ev/E6EL0L4wb4orojxh9zm1yyVhvbS2ob3FSONMyt+/NDD0zc42UnpDSE1J6QkpPSOkJKT0hpSek9ISUnpDSE1K2YTQaWZZlG6rju0LKJhCuuFjb/O7dzu+tpD/Yi0P6/m2QsgkEPLt93YQ7unyxycl1rGQ/DutnuiJlEwh4eHxVhiLF4rkMmvUHO225lG1AyDzPLYRgkxiWAQmCVp/pgpTfwc2RtjhMZ2XQYrH+34Bqc0xObzbVC2H2JeS27ZayjuFwWK69+fKtNiDbjc+s6jZBpVSwegyCyattTcfoq0Grv9uElAoGxIQP4317Kg7sMV6ncaMwDHZzHqafAqa+SxWlVCAg2ouJVsXYBnGyVQw5C3nZVh41eAF8x33p7obvUkUp60BIHC11FWQ7GRCe5yQD//Qwl7KOtIoIkobhlY6hEJLVg/vVgAAhsZbSfxJMCge4TvkCoGs4IGUbGDRd+KwwwnDtcZP8ecA6cFbWVbh6bxuk3AWqwl2Q0hNSekJKT0jpCSk9IaUnpPSElJ6Q0hNSekJKT0jpB+t9APKTF9DT+bZ6AAAAAElFTkSuQmCC",
            } },
{399,
            new Items.Pokemon()
            {
                Name = "Metang",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAKBSURBVFhHzZZLctpAFEW9JSFgHmahMkHSCsgsn03EGfFZiSseOMmE30ZcyQq8AyAvuu261EvXRchESbWqTllcWtLhdfeTb8wsaWSYEjJMCRmmhAxTQoYpIcOUkGFKyDAlZNjEYDCwLMsC5/L4u79Bhk1AZLVa2Xa7tTzPT0KfHvb2+bvZ28VPu/32y3p5vxNRGSqGw2F44GQysfl8bkVRBG6/HoKYl/Ofs15eX67v2QYZeiDGv6xcWZY2fndXyx2lHM79Z1ST93spMiSQms4eQxVQvdlsFqo2nT/a+P2XIBjL+HNSlNXV0y1DQkHIgElRBjlKUZIiSm784f407ppKyhBQjjJFUYX1hmrEkhTwghSbzn+cxl0jKUOgqucF/cO9KPHfAf7ATgVf1xuBD8IDuDEgeTgc7M3H+z8qFEsRXIvxOJbLpfV6PZzK58bIEKDfoaVwOrFRIIxK8mE4IInsbjSysh7PTeTlkK3X69ABjsdjuK7fb1dJGQJUEG0FLYU7ENl+v8f56aiqyp6mI8vrMU/TV1YVzz8KFfU/BpVbLBa22WxODb4+5LM9MiQQUnK73S6Is1FjyiEJOWQ+b6oc7snzc8hQQVlMOwV8O8F0xi0GeMl4NvB6vLRpZNgEbsy16EVjQYixmgBibFtcz23ajgwvQUmuMy9CsOPZcrLsedfyOoihT/4zQcAp96JeimLxlLLSEKR4EzJ8CRRV+DGQ8689LIM2TVuGXYOeyv8XAUX/SwUvgeqhPaFfYm1yU7V95cmwS7gE0J7QtCnql0ATMuwaX0X0RLxJ4jHnkGHXxBsp/r4JGaaEDFNChikhw5SQYUrIMCVkmBIyTAkZpoPd/Abn9viBl6sbPgAAAABJRU5ErkJggg==",
            } },
{400,
            new Items.Pokemon()
            {
                Name = "Metagross",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJySURBVFhHzZbNbtNAGEX7SklIJLbdkV3srliGHbCDN4hXlDdBZVPYJMqTVPAKvAAw5Njc8HlyaUxrpIl05PGdv9PPY6sXKaWisWFJ2LAkbFgSNiwJG5aEDUvChiVhw5Kw4VDm83maTCaHpu8fAxsOYbFYpGcvP6RVVf9XSRvmIJBLPEaQuUPn2DDCQs3nZAVXq1WqqqqFfkeco3n8YZvbH2k6e3LSn2NDwQbILV/d9DajrepJcHP7vR2bg0ScK0HWHCJpQ8HCL95/PVYo5hJb/q6GkxPL1x8P86ftfATX7+5awfX1lzSZzo7rOmwIkpNgrKIE1a9q/E0OEcYhIzlxTtKGIEEWkSBX8v1+3xPUuIge//r67nC96rWpusY9SpAFJBAlEXSS3bhOZrfbpaZ527Z1Pqu665Mgclz1+B025JywWRTsNu/OXdO86QkqB8mLuq57gqoiV+1xXxVPgviW5XKxLQHaEo4gJmkEu3l/Hi9HIEqCq2TvBvSWxYkQBbl3UmQcjZvLy+McVY95m08/e1UcchZ7N4AgH2DJCDbWuWTjXE7V+vb8aYvG6W0WOoeqXm+PoYLb7baV0abAPf1cVS1yCfJDSpvRhxCZ5PTJiWewG3t1XD/nJAD+S+EqmXwy9wjk1eQnSSt4aEuQftYBCjKbDXxJcnI5Qc6GUVJVVYZoLgi8IHyGJMVT07o5NhyKKiChWJUoBMhKVGPy9Rw2/Fe0oTblipSEIuRD5cCGY4AEFY1yqnA+9j5sOAaIcC716MG9cOew4VggI1G18zHnsOHYPFQObFgSNiwJG5aEDUvChiVhw5KwYUnYsCRsWA7p4hdbALT5Zy/EbgAAAABJRU5ErkJggg==",
            } },
{401,
            new Items.Pokemon()
            {
                Name = "Regirock",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJySURBVFhHzZZLctNAFEWzJdnYc5gRRpJZQVhBHFZAYAOpZOKYjQAZ8ZnwWUUgCwDC8KEj56ledV3J8q+qB6eiui2pT79+aufIzLJGhjkhw5yQYU7IMCdkmBMyzAkZ5oQMhzCdTq0oivpSj+8LGa4Dud+vSvvy4omNDywpwz4mk0krd39e2qNR0VQykj7j8OymVZdhH7F6CD6vKrv9trC7H0u7evnMPlzPbTwa1bfq5/69rppFpeNdyLCLOMnbqrBZVbZyTpckzy7Kwv7Wi9pEUoYKJvh48tiWtRh8rq8R/HNe2V0tef9m1vztE0xbI453IUNFFESOibyCLhcreLM8ayVj5b36vGPIByZDhW9Rl1yfJAvzyh1MELyKqvdSXHI2q5o2QAzJuAOwTlKGCuTeLU6bCav6y72YH9vPHkkEL8+O2z5Nt3fvgpxhZVk2cvFYQSKKegZpBQ8mSPUuTp+2E8btpc9cCPwYuXoQ9D7kI3E53+a99CBynP5Uj21FYlQfEbdfV5II/Pp+3VTO5VJBFsU7/GMZUjlHho73Xdwu/6liDOn3i3kj6NuLZJTzCvozcWHpWamQIaRy6WR+D1vPPfQh41zHZ7ruZ3xnQX+ZeiHjVPDTyWrLLuerHnVJdb9XD8bj9XIgQ0gFgd6L4/HYQfTmQdCz2A5RjlbYuYIQJaOcjyGIUJSKx5BXKb6HVtibIPT9D8eYSzK5+oVBMi6E+4bKgQw3geqwAIjbCFQKab50F3TJdEe6kOE29PUZ8rGKQ6sHMtyWtC+jSKy0Z0OQ4S5sK9KFDHNChjkhw5yQYU7IMCdkmBMyzAkZ5oQM88GO/gMJRMnafTg62wAAAABJRU5ErkJggg==",
            } },
{402,
            new Items.Pokemon()
            {
                Name = "Regice",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJVSURBVFhHzZY9UttQFIXZkqXYPaHLpLHsxpBNQJIif5vITBp+KkgaJuwEGoNXkJAFxCSFjW/eERzPizgyT8LF9cw3yEey3ud775PZMDPXyNATMvSEDD0hQ0/I0BMy9IQMPSHDNvR6Pet0OuFQn2+LDJsCudlsZm+/TSzL8hD9fw7ibeVl2ATKHU3+2uuvkxJK4tz++LftfDyzTpaVWVNkmArlLn6ZHQZBEEtSbu/k6kFlU5FhCt1u13aPxza/XZTVqwpuf/huRTGwvXBNWzkgwxRQPQhSKBYDqFoxGC5nr+0syvAx2FpsioOrP8vqxRUklMSXgXjTWZThKiDX7/dt+uNFEBzb9OfL0OKp3Vzf/Y3FiqKw+Xxurz6dtW63DOtgW7E4FlYVZBV5DV6c0Sx/hrfy3nXIUEG5ePiV3O1iYcPhMOzgaXlMOUi32SwyrFKVq6sehPCiYHyOrV97i2O5VYKU4wMbLVaSaxfE82707nSlYCx3fr2wN+FcnWBTSRkSVA+PiKog5g8LQbAqF4uso4oyJPGuxSMDPB99tn6QxMIUqUMJDu7nM3VHy5Cwgnjujd6flg9ZvqewqlD8harXQJBZiqQMq2AO+RMFabQcP2VKBnAE4rHAF+R4oMW4H++5Chk+BiRZxXhhyOxf3iyrtbXzJUjcVR3/2aBiqWJEhilAcjPMIwVA3HpAEXSAgvx8KjJMAYtSkFme5+Wm4iaJdyuu53ETZJiKWvQp1VLI8Cmg9a4FASSrWVtk6AkZekKGnpChJ2ToCRl6QoaekKEnZOgH2/gHDNQ3gVfqe2EAAAAASUVORK5CYII=",
            } },
{403,
            new Items.Pokemon()
            {
                Name = "Registeel",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIQSURBVFhHzZXNccIwEIXTEnigD0wutGCcQyghuQEVkE74uyTl0AKj8JR5sNE8E9lAZg/fAE8a62OllZ9CCK6RoSdk6AkZekKGnpChJ2ToCRl6QoaekGFbhsNh6PV6kXTsVmSYy2AwiFLr9TrsdruwXC5Dv98/DV2kObcrMswBchQD4/E4lGUZsdJFUZym62fkIMNrsDIQqOs6TKfTs1hVVfFzs9mcxW+VlGETqNp8Pj/LQISVoxw+IX0vSRkquKUQ4uI4c1bKVg/V5Xf+CVS+7bmUoQJby+qlCzdtLSQ5bsXbSMpQ0ST4NXkPdfW7ehZW/Hg8hv1+H7M22y3DJiA5Go3CYrEI2+02Lo7qHGYf4bm8bL0StNnDBAG7mNXMqeC/bLEFkrYxDrNVrKAVoYy9hsDDmoRQDothq/FpZfkdYBydzjcMxh7YxT+vtc/JW9xSCilJK0Y5PANXVVtJGabwDrTXRo4gxKwMBTEvV1KGFntBY3GcMXQhFuD7FjIYS+XS51Du7oJ4GIXsFUF5NkVKOvchgoSi9jcWZOXSKwYV53zMPbyuwktLOSDDv0irQUkLtppn0J5fXElFsv3XkGEOStJ2r+1cnmGeXz4jBxnmgsVRIVaJjWQraOelZzgHGXaBlcL5Y1enZw1z7O8cZNgVW9FUrisy9IQMPSFDT8jQEzL0hAw9IUNPyNATMvRDePoGLFzQ+j8R1w0AAAAASUVORK5CYII=",
            } },
{404,
            new Items.Pokemon()
            {
                Name = "Kyogre",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJ8SURBVFhHzZXNUhNBFIV5pSE/pbhS2BBXidkEeAJciTyCS1aIL0IMi0zC01i6cQeli0zq2ifhxDudk9QkpLSp+irM6Zmer2//zJ6ZJY0MU0KGKSHDlJBhSsgwJWSYEjJMCRmmhAw3pdlsWpZl4V/d/hxkuAmQezh+Yb9bL62+QpID2GYQMqxKo9GYyR31ru3NyY31WwdWcxIUe/3UDrJsf9FeBRlWGTHuuQ1yh+7lXhDtsdhOKoiOh8Nbu7r6ZKPRV6vVaiFevqfdblun05lBCS8JGd6zjRgpXVDu8PTvy1AhTgva8bLeh6GdfBwv0em8W0iDx7AusTa7QRTPEb4PSyTOYkoXnBaIDULHkPOS59ff7P3NjxlKkEAUcmcX84E8tl7NJHsXuWX78xnBuzBQDmqVaOkCYFRcO5Rrh0683DrJdXJoowjlkPNZyntKFx5OJztDB+efvy/k8tHAptOp3d/f2enlSMqRophat9styXggpqoHloIYTgU7y/O5mP+jZCwIsaOzL+GZ+WbzgyWqah4ZEkx33CHwkr6CgJI4G70Y+gN+ZlZVzSNDskpQgWr5SvaDpD+0t0WGhF+KeE0BLH4cISBu/2eCAFPCb63fmfjuPvw8tnot/EbtHm6AqlMaI8MYSOIA//X2YFG1u6cK4XM3yvs2Hg9m7TxSOBDeT/l1O1YhQwVPfYhCxsONQLBuIecrSlkMIA8Dqiopw3XEu1C9iEeTqiDW5ybfZxk+FwqycpDDL6oHOVT9vwoCSrJipCiKynJAhruCy2EymYRLs3q9vpEckOGuoWicV0GGKSHDlJBhSsgwJWSYEjJMCRmmhAxTQoYpIcN0sL0/r3GsL+9F+OEAAAAASUVORK5CYII=",
            } },
{405,
            new Items.Pokemon()
            {
                Name = "Groudon",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALoSURBVFhHzZXLchJBFIbzOu7kWnEpu8QVM2x0qeUmKRbeXsDLJiZLX8OFGhdA8SJ5jCTlArCdb/DHQ88ZQwFaTdVXDT/D9DenTzcHIYSkccOUcMOUcMOUcMOUcMOUcMOUcMOUcMOYbrdbDNXxf+CGFmSuH98L7cb9yhhf+y9wQ4sEB1k/3ERjo9FYEf9uX7ihQO5L/yjcOoI/nizff82OQ25k43vsihuKuup9z45KqSzLVoKSZun3KeqG0Ol0apcWMdBnJC8LFvN5GAwGZb6vHnVDLS2VUYUYW0Vlrq+OCok/lZTUvBj1arfbe1tyN6wTvL06Dp8/9UKeLwV/zmfF5csXkuPxOLRarbLy6tFdJd0QPEm7tAhQwUkhled5+PjuZWg2myu54cnTcHr6rCLIfb2xDjfkR0yEgHaw5FhK9ZmqhNz5+1cVwZtitJtG97VnqUbNHeOGwCY5e/siTCbjYvLXYbGYh4sPb0pJhFTJWLDfX9/Rs9ms7EnuKcGL3mH54HZs1rRCJbAgyYSqnuSQiQWRO/ldNfUecnohScuc9x6Eb87IBixeFYdKADwpEzChlQL6SplGK0flVD2E6NHL/NFaD9PTHEuWjQWpGk9OnzGphABpwfLbvtOmQJL3XEP1JaPjKN5w+sz1sQusfaBykuPHEhT2JupR23d25+oBuI89IyWpyiHH8bRYLFa9aln7AJKcTqfl8SFJK8c1SGl59VB2c9jeRUjHkc1sJbeqoA7eWO7s4WHICgFyrh8On6+OHzJ6j93p/WerendVTlQCBJhkNBqVct73ZfWK3cfRwHvJxf8kwI7Wble1BPPYh/dwQ0AkzkAV5HhAUBVHjiX0KmgFN6maxQ3vwkpqqYX+HlUluyE4SnRdfM863HAT2MVWTDnykoz7ru6s+xtuuC1I07s6mK3gNnLghrugTaSetL0ZX7sJbrgrSNrl31YO3DAl3DAl3DAl3DAl3DAl3DAl3DAl3DAdwsEvgRZGe2Wx6ggAAAAASUVORK5CYII=",
            } },
{406,
            new Items.Pokemon()
            {
                Name = "Rayquaza",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAL2SURBVFhHzZZBchJBFIZzJaCggjeQcjPDsDDuXEJlERIvIOYCRjcEL6FHCDs1G5KcgKocAvTZf9M/PIYHDESoXvwF/PNgvv7f62lORCRqmWZMMs2YZJoxyTRjkmnGJNPUqtVq7sW+dgyZJgW4pN+WUrnkPto1h5ZpUrsCVqtVKZVKXvlr+8o0KQKmg85WSNTeTUZy/fRVypWys+y6XWWaVFHAQ8FBpqm1qc24hnZ+HH2WT09fTDjU5L1dZJpa61LEvMHvPd6shUPN9+S9VF4wk6ZJceg9YDOdD3+r1ZJeSC3NmpKmqQz7dam4BegNYgHyN/l5m0wTYnJIyEOEFAFKuMbVmfQebvzr9Fddrh8XrfYLSxL5kS4AATduX8hz59J5xWbVNCEA3vVPpTmYgU1/1+XN1VtpXJ5Jcjvz8u8BKfczERaLIyTgslu3SFc/7nQLQZqmT8+tHkn9uX/lbwg4pOVviiQNAZIiLECRKH5v3oWgIpCmCUDsTPwIW4yWTX6eStZ0N3Izx5sxRWwg31blUwnr3Xj471LO2/Z8XTEsOG6CZoBDsnl4/f2ltMLMoq7RXXQBc7sNDloxCIgfoXgjwI3bXT/kWQDFdf2ImS8wLIyLIejw74N/oOe/t04rhk4wD0UweGwPF6N3LsHmi9NJhs9Ify9AiM+qyWQiz+cfFlAKjG1FLSHZxqW5U4D/pcVaSBMgeVk1bCsB10Ey3SLpQaZZVIB7fbFITMMtAQYwvj8KoIbTYvshzuN0OvUbgxuHqb64xZu0lF44TfQNcZ1nOKFQyxnkxmL9OplmERGQcBQTJNxoNHKn0Dtf55+bqHN+fpbXyTSLiinhnMaxloVzmxoOFg93tDn7dj5LNKR50BZDHlCdGgAFpAYGJP+GzZN1tQDc+yzeRXxm8sY+tZAk261r9YKKQJrmPkKaTInK1wAQf2CbatNgNjdBrhiHll4IUmfK1oKgFeOYImze1zLNmGSaMck0Y5JpxiTTjEmmGZNMMx7JyT9z6E0KL7P2TgAAAABJRU5ErkJggg==",
            } },
{407,
            new Items.Pokemon()
            {
                Name = "Latias",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJASURBVFhHzZZBbtpQEIZzJWJjqcum2STtBuxNskyUQzRRbgKriGzaE4DgAlV7i9wgUhfYmb7/SQPD608AU+ggfcL8BvMxM8+PExFxDQ09QUNP0NATNPQEDT1BQ0/Q0BM09AQNGUVRSKfTCYd/Z2n+L6FhCkTG47FkWRZeLsXm8zleS57nMT8ENLSo3HQ6lbIsV8Rms9lC+lDQ0ALBXq8n/X4/Utd1iJePfaqnnUhzCw2Vbrcb5er7G5GHW6kSwX3l5l9vJD/dU1DbKY93URLMJhNpmqaVIK4Zx2QLOUBDEH9hIocLIsPstRGE3NPFR2lCR35dX0ayti3WFmjVfr98kDxbFdxlkcRuhOtZsW1uTzQEVlAv+hbmz8phZW8SLIplS61c+r510FDRVaa3mXUwSf2sFdtVDtAwRQd7nazOI87j/Vr958sz+Xl10VoO0PA9WFUhqA+I6mjY8RgF2dNjCCqYLUhaOX08fzmPQlitKtmmeoCG24C2x5t4srMMh0MZDAaxsqPPnxaVRLuPVkHIoXrYm6Mg7pPhGXJa0bgtmgoeZQbtYllUz+wwkKyqalFVHKPVKqiLaBdoyIAcdgF8oYKWYUFU31+lfriLEtOwDaKyqOAkHOO5rRygYQrksIPo8KucnvsRbiXlt1fpl9VKa/HnAnLIwMErqO1Nv0jPQfQtWbnI06rbz26Chm2wVW7CDNo/EpDU8fhvgsBWed25NN8EDT1BQ0/Q0BM09AQNPUFDT9DQEzT0BA09QUM/yMkft9clWUd1s8wAAAAASUVORK5CYII=",
            } },
{408,
            new Items.Pokemon()
            {
                Name = "Latios",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAJuSURBVFhHzZZLctpAFEW9JQlDxcnUE7sykcSElEeJZ1lBnF2kzCTACvisIrN8NiBgI8h+0W3quR5dt4UQrqQHpwrdhub0658uRCRqaBgTNIwJGsYEDWOChjFBw5igYUzQMCZoeAqDwUCSJKk/8vZzoWEIyPjP8/lcNpuN9Hq9g7bXgoaMfr/vZNI0rR/3z2VZynK5/P+CWinIFEXhphRAcLvdOroKHlsiNPRBJ28+fpOrT49SrtcyHA5fTW70fSdJelk/8u/Q0IJOsiyrO6rkw1RqybFkeXG2YBs5QEMLOlKZu9mzkwTl+ny5269/HEka7oOGCpPDiHe7naxWq06bA5tL5SB27IiiIdBRasVA9fm9XNYdWkFsHN3ZTaA/yFg5/zsMGipWUqejqp4P5NoIoh9sstHkyfWBzZYkxwcFaGjBlGDkesyECEnqlNpBtq0eoCFDpygkq+vRrimdARU7VQ7Q8Bgqa0UhaI8dtN98+Xkgd8rUKjRsC0QhaeWUd/djJ3Tz8Ltz9QAN2wJBHOL20Aaz2Uym06ksFgt5e//oNgfWIA75f1ZBrR7uZgjinMThDbl1fR1CFFei3kBdq0jDJnT9Aa2ef8PYuxqfr+ojRqca16T+3u+bQcMQkNOXBgVThp2KQ/xuUjmJ+WL/1pPn+UuVbx9+OTnI2t/6/+FDQ4a+/+nit3+ANuzYH/m1FHnmxHRq82L4IoccglpF7bsJGoaw0+v/gbZBdDTZT7muOeR+5e0Am6BhVyCpVcZ7o32RsMsDYv4AQ9DwHGyVQ21+3gQNY4KGMUHDmKBhTNAwJmgYEzSMCRrGBA3jQS7+Al0DCTJm8FE+AAAAAElFTkSuQmCC",
            } },
{409,
            new Items.Pokemon()
            {
                Name = "Jirachi",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAALFSURBVFhHzZbNctJQFMd5JfJFgi8hCQk8gyuob6G2rHXbDoza0em002qr7ltRX0HC19qxtONoOd7/jRfSzBkIkcVd/GaSP+TOj3PPPaFERFrDhjrBhjrBhjrBhjrBhjrBhjrBhjrBhjrBhjrBhkWpVGwql8vikv+8CGxYBNu26dePNn396JFpbk+SDTcFcjXfJ1/w53qHbFsjQSlXq9Gj1y/IDwIp+O1TdWtVZMM8VByLLMug/SdlCvz7gnT7mGzxWfaZIrDhKpRY/8KT/dbdMxLBV88pjBLBu+s29ToGObYpHuHXyQsbckSNiAzDoMt3Ln354Eo5ML/ZoUYjoDBcVq/XMWk+S64rlf+TZMMsYRguttBxHLp870nJ/oVLd7OWFAGo3PymvbhXQNI0ivUkG2ZJC+Ie24wt3n9aFlV8IMRaspLdjrW4z0qiqkUk2TCLFBQ9hm3GIP58nlTPEid1OBxSb88RWDSMv9N0OhXVrcpKyoreip6cteX2o0fRJtn1V8GGWZrNJkVRJC6p5Hme3OIDUb1I9N14PJZSwLKEpBDu7ppSqrtriOHdktUOguVJV+vmgQ3XAUn04mAwkGKj0Ygmk4n8ERBGRX//bNPBM4PQDvhuelZm11sFG+YFQxqSaIHRKKkkBHFdr9fvDet0m6gsD2yYF1QHW3d09PJfFcd0dvZWVDIUeUBXohUc8drD3EQF8SrMrrEONlxHeljjwESi+SFwcnIotxqyp6dvpOjVeVXOS8cxxDt685nIhqtQh0QNa99/SHEcE3Jst+rFOB7I7YZ8X57q5eDeRJQN16EkUUF1CFSO7T4+PhQirqwqvgM5nGo1E3GAXDd5Zh1smAfI4JBweVoY/xEhiH84EMM8zCsH2HCbKEklpuTzwobbJl3VTWFDnWBDnWBDnWBDnWBDnWBDnWBDnWBDnWBDnWBDfaDSX1v3RPFoNuRgAAAAAElFTkSuQmCC",
            } },
{410,
            new Items.Pokemon()
            {
                Name = "Deoxys",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAL+SURBVFhHzZbPThNRFMZ5pf6ZaecNnLLqTNG2sJHRRPERXLUF11jERNAHIOhGEh/BDcRIqbomUfdqwUUlx/Pd9oxjOaV02pC7+GU63+3M/frdc+7tAhFZjSrahCrahCrahCrahCrahCrahCrahCrahCqmxXEcymQy/FEfT4MqTosY+9Ws0e/1OuWz8zOpitMAczt+kc5aA3Of6yVDbk5JquIkJLFkatvRV4r2t6m7vGgMvix5lJ2DSVW8Cpg7qfmxifXDA9q6992Yi948M4hJpDhrTariVXieR+VymVb32/Tn4oI2PrxTDZ4Pl1xqMq1RVZwETLquQ35zjdrRt9hcJpulfr9PlUqFegmDSaOj75qEKl4XLPfT1VNjMAhDCoLAUGqtUY8N3X+9FaeK+xs3CGBy8+7AZHKJUX9Sq7PUoipeB9fJx50ccmqre21jDkmKGel2eSYNqjgJTLzLHfyJE8L1jLeaynB5e63/G+NGDcIY9jYsXafqx0v3s1HljXp52Aw1ejU0j06eddNWxVEc16VsLmu2lx3fow5PXmQNY+joY75/Hp3S49J7NrpiTEnDSDenPf5UMQnM+Y0H3JmPTK11E4kgUVwLfIXJbn3REPIPQbKoyTCx5cy9i2HAbzwkmMSEsrRIT+5dnhTmlsoBLYUDHE5bno94q5Ek0yy3KgqeV4yLHClhaZPpfayVTK3dDsrDBPFHwTfG87xpS6P8M1k3zQRN3jsJVUwCY5gM5na5/gp8gkBH7SHdEzbV5TFMCNMwCsNfzHFXN7o7TBzNdCcsU+vowCw/Th6ZZxyqKEgDIBlsJ2JOgKFO9ZYxDhOiIcHzJyumiyUpjONd0JAm9ObhW26+nBkfhyomGZy7bmxgdOwFzPGmndR+NGq0wSkdc8Mkn4N5pCg1iu/KDxiHKk4DJhnVYCTa27y0hPguUkRHF3JzqsE0iBHZK0fHUDL4o1ssXB4fRRXngZasMK5kNFTRJlTRJlTRJlTRJlTRJlTRJlTRJlTRJlTRHmjhL4Etv07XnBw4AAAAAElFTkSuQmCC",
            } },
{411,
            new Items.Pokemon()
            {
                Name = "Chimecho",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAIfSURBVFhHzZbbblJBFIb7Suwj+xHsHRvegnhhtV5I9QXsCzQeGiNyU+s7aBGfQSv1uhE2F0ZNBfo7awik7PxxH2PXxRfCNzPkz5qZNewAUA2VmqBSE1RqgkpNUKkJKjVBpSao1ASVZfB9H41Gw5IeqwKVRZFwZyd38Gvcwuh0F65TX0gqi3Az3O+L2FJnSCrzIuHOJ3N0Oh0MT3Y3FWy3W8Yv4LqemcbX5oXKPKzCLXAxg0VCxnFsuemrhqQyCwn3+myOr9NViH/xZgQ4FUJSmYUE/HHewmC0wDjZDpP+fisBwzBEK25vbeXgE/Bz3NmElmDTBy8wGC7/b0Cp3qv3V+g+fYtHvR6+mEsiAcfJ0p7D/oc/Ntjs/vMNruOYpfz3sqAyi2aziSAI7Dns9Q4sB4+foD9cYLJ/jLsmfPfwFJOK4QQq8yLVlKBSUQkn2yqf3cN36H+strVrqCxKFEU2qDxzjuPW+uRRWZZ1+6mjcmuoLIvcbtliPwjheb5RfF4RqCyDrd5wvtUHb/WpSyPn8PPllQl2vWo7pkeGfmCG+Py8UFkWqaL8eZCAycNjJHvPEJgqeq5rhvmaLKgsy6aK0yW+JdeY7b+0jfr7vSNE5lym5+eByipIyEsTaLa3ekUknGdaT3peXqisirw0EnJqtjgy/TEIyt9oKutAKilnMu2LQqUmqNQElZqgUhNUaoJKTVCpCSo1QaUmqNQDdv4C2yWFk4JxLgIAAAAASUVORK5CYII=",
            } },
{412,
            new Items.Pokemon()
            {
                Name = "PokÃ©mon Egg",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxMAAAsTAQCanBgAAAARdEVYdFNvZnR3YXJlAEpUTC1EZXYngLFDzgAAAX9JREFUWEfNkrFtAzEQBNXSt6EyPnQLLsGAoMChSnArDtWIA6U07qET+LvzdnZkMMmSexzc/+nncp0aDGcCw5nAcCYsaK0NRX0soFIl6mMBlSpRHwuoVIn6WEClStTHAipVoj4WUKkS9bGASpWojwVUqkR9LKBSJepjAZUqUR8LqFSJ+lhApUrUxwIqKcuyEK3DzmkOoT4WUEmRxzep+/3tRWbP8w2aQ6iPBVRSuofb++3cbt/n9nh87fj8WHeSNIdQHwuopKgcCaokzSHUxwIqKSn4l1zQfW6cQ6iPBVRS4tHYDkkFKR6CuUWdcYT6WEAlJR4ksSQF4xfILeqMI9THAiop/wkGITdUMB4OkdxWLxdnPUME49+Kx1MwZXJzub1R/+Briz29XBL34j7NIdTHAiopKZhbPBJc17GCm2RAknn2vIdzCPWxgEpKPtrRC+3EEppDqI8FVKpEfSygUiXqYwGVKlEfC6hUifpYQKVK1MeC2cBwJjCcCQzn4Xr6BbANC9CgG+7rAAAAAElFTkSuQmCC",
            } },
{413,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFiSURBVFhHzZbriYQwFEanJUXtw0cV2oXaiWAzig35uOuXJUNWvh+aFXIHDownDhySGOcjIqqhUhNUaoJKTVCpCSo1QaUmqNQElZqg0pcsyySKovMrH/eBSh8QNwyDNE3zaiSVPiCwbVspikJfIOLyPJeu676Bb0VS+QQ7c33fmziApcZ1HMfnLfx3d6HyCQis61rmeZbjOGRZFinL0kQGD0zT9E+c/bwZSeVd7Oxt2yZVVZk9uO/7OSTmGoEI/c9+pPIubuA4jma21nU9h34D3YcG9/tA5ROwzIhKksQ8yYjFxwYGXWKAwGma6B5846ih8ilYahv5Zhyg8ikIRJD7JlETiCW2bxHsN4SpOajdmXNj4IMf1IhwZ46NBz2o1QcCROCgvj4U8HYvBg0E10hL8D3oYiPxb9qCyOt9PlDpg11Wy3XcFyo1QaUmqNQElZqgUhNUaoJKTVCpCSo1QaUe5PMDyZBCLu8pr6UAAAAASUVORK5CYII=",
            } },
{414,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGGSURBVFhHzZaNjYJAEEZtSaL0gVgFdiF0gtIMhIZU5m42+XCPfMLyk3NIXoIPDC+zgO5ExDRUWoJKS1BpCSotQaUlqLQElZag0hJUWoLKJcRxLPv9vmd4fClUzgFh1+tVbreb3O93RxRFm4RSGYrGaVhRFH0QQLD64ffmQGUIGpckieR5TiP0eJZlqyOpDAHTO51ODn96w3P+PfB4PLrpXC4XF1eWZX/vYbn98z5NOQQqp/CnpxfHFBHrR66dIpVj4IKYnk6oaRrpuk7atpU0TV3k1wMxPcRhQySWFU/01wJfr5ecz+d+Xzf9jOO63P6Sz4XKMVhgVVUu4PF4/J7yDsSDpPhP9xyoHMMP1IDn8ymHw8G9E3VfN0wUS7w0TqFyCj/y0z24JsqHyin0/YZADanr+s9TvFWcQmUI/hSxjGB47hqoDEED1/5KhEBlKMNIUxMEGqlRutz4P7jlRKlcgh9qMlBB5JbLTKUlqLQElZag0hJUWoJKS1BpCSotQaUlqLSD7H4A5XIjerGRSCYAAAAASUVORK5CYII=",
            } },
{415,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFvSURBVFhHzZVhioMwEEZ7JcV6j2pPobeovUnVy7R4IbWz/Swj2fAtazDgCO9HXwQfk2hPImIaKi1BpSWotASVlqDSElRagkpLUGkJKi1BZSh5nkuSJCv++h6oDAFxj8dDuq5buN/vkqZptFAqQ0Dg7XaTuq5X2rZdYhHq3x8KlSFoYFEUv7YZDqF7I6kM4Xw+y+VyWQNdHyOSyq3o9HRL9fzpGsKbpjkm0D17mB7Ay+JHVlW1K5LKLejDX6+XvN9vGYZByrJcImNOkcr/8OP00kg3SCd9SOA0TXK9XpegeZ4/S7L+NhPY9/3y8HEcP0vfQKzpG31IIMCDEZVl2XLOEIsLgW7cIWcQ4Dv3fD7pGdRA/Rb638gQqNwKJqSRflyM6QEqQ0AIohTX750eoHIPGhwjDlAZijtFhOHfJEYcoDIE3UpEuWEx4gCVofx1DmNApSWotASVlqDSElRagkpLUGkJKi1BpSWotASVdpDTDwLjK5+QBZvbAAAAAElFTkSuQmCC",
            } },
{416,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFtSURBVFhHzZbJDYMwEEXTEhHQB0sVIJoAOmFpBkRDLJOMpYks9A9gLGWQ3oHnHJ4Gm/AiItVAqQkoNQGlJqDUBJSagFITUGoCSk1AqQkoXYnjmIIg+HFedwFKFziurmtq25b6vqdhGOj9fj8OhdIFCZSooiioaRoTy+78+6tA6YIdKPc+HjWULkhgmqbe9h8D5V2iKDJxsveyLPMWCeUd7MNRlqWBQ/n+yd4ToLyCvcf4QMzzTMdx0LIsZoJd1/0v0N5vfFIlTi6fkVBeQSbI09u2jfI8N7H7vn+XydxL4JP9COVVOFICx3E0Meu6fpeIqqr6TfjJuxDKO3AkR4VhSEmSmFi+OFD26N8myHDgNE1wDz4JE6C8C78HJdJnHAOlCzxJfsRPH+kZKF2QA+MzjoHSBTvQ5xShdEEC5a9O3fcgw5EyPY5V9T14xo49r90BSk1AqQkoNQGlJqDUBJSagFITUGoCSk1AqQd6fQBlBUx7XxevewAAAABJRU5ErkJggg==",
            } },
{417,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFhSURBVFhHzZSBqYMwFEW7koIOok6hW6ibqOs4ku//K30S5LamNYUbOASOgsfE+DAzaahUgkolqFSCSiWoVIJKJahUgkolqFSCyliKorAsyw7O11NAZQxlWVrf9zbPsy3LYuM4Wp7n/5f4/d9C5RVYLcR1XWdVVe1M0/STSCqvQCDi1nW1bdv2ua7rPRI+5XZT+Y4wLhweidWUCMRADLbVR9M0NgzDsdUpQql8RxiIw/GM2Idvb9u2x+G5G0rlFR6FGavoA4G+xSA85d8eHiqvwMPZN4hAbO/zBfb/JCLvfJdUxhBGYg5XziMx34kDVMbiQU7oU8QBKmPBw/1gsGt34wCVsXhguL3ne+5CZSxhIObgt0Pv/wYqY/FAX73UcYDKGDzo1TeYCiqvQBBOKeJSndZXUBmDr6DHgl9EUvkpHnr2KaBSCSqVoFIJKpWgUgkqlaBSCSqVoFIJKpWgUgd7/AG7KEK1MbsW1AAAAABJRU5ErkJggg==",
            } },
{418,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFSSURBVFhHzZTbrYNADAXTEnzQB48qoAugE6AdqAh870FyhDbnA28WxSuNCJNFGpnHS0RcQ6UnqPQElZ6g0hNUeoJKT1DpCSo9QaWFoigky7IPwn2xUHkXxPV9L/M8y7IsJ+M4nuR5niSUyrsgsCxLGYbhHQTatj2dhobXWaDSgkYyp+HX/6xQaQExmFhVVR8T/DYOUGnlOrGu696h4b4YqLSAEH0xMEUwTVOS5w9QaQGBmNq2bXIch6zrKnVdn5E/D9Q4RO37fgZipYyk8i4aiIVbi9uqq2kaX4H4SONcF4JdfGY0CkdE6cJvfaP/F732DlRaQACeuevCeYo4QKWVaySOmF6KOEBlDAjSqaWKA1TGgCj9WLsLfCoOUGnhyThApQVEaSTQ83BfLFTGwELDPTFQ+Q1uJ/gUVHqCSk9Q6QkqPUGlJ6j0BJWeoNITVPpBXn/Cp0lLmdM7dgAAAABJRU5ErkJggg==",
            } },
{419,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGoSURBVFhHzZUNqsIwEIS9kqLeQ+sp9BbqTUQvU/FC/uxzAgNhmTTRPmQLH7RfUjLdTXRiZqGRMhJSRkLKSEgZCSkjIWUkpIyElJGQMhJSfsJyubTpdPq+1eNjkbIFBtvv93Y8Hm02m721njsGKWsg3Gq1ssPhkMKt1+tiFReLxagKS1kDAVE5BisF8PP8eAtSDsFFfVvZ8jww3Ha7TZX+dgtIOQQD+nCn08nO53MiD48WjwkpZQksxurl7WUbCcL6kP6jWpGyBKuHEDwgWBQVul6v9nq97Ha7Wdd1KSQD8T2/LVqQskTeXlSOJ5nheDFk3la1NVqQsoRfhM/P59M2m00KhHtcfA4T8HK5JH+/3zGWAqL1fq/+JKA/AAg1n89Tyx+PB3wKyFA8VHlFW5FyCF9FBOz7Xu5BVi7/1/lZwN1ulxanY8g8nH/n03BAyhr8XctDwrFieTjO/aZ6QMoaqAjbVloUcxC0Nq+GlC0wgPcg/wAekNLcGlKOhXuObf02HJDyPxiq8CdIGQkpIyFlJKSMhJSRkDISUkZCykhIGQkpIyFlHGzyB3CoAdjOaXyjAAAAAElFTkSuQmCC",
            } },
{420,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAEdSURBVFhH7ZXdiYQwGEWnJUXtw58qtAu1E8FmFBvy51tvFpd5uA9jNjD3QeGAOVE4RI0vM5OGSiWoVIJKJahUgkolqFSCSiWoVIJKJaj0Jcsyi6LoPOXzPlDpA+KGYbCmaYJGUukDAtu2taIonkAvpAMRl+e5dV33Fxgqkso7XCvX972LA/hYMI7j+LyE3/cpVN4hTVOr69rmebbjOGxZFivL0kV+PRCr9x53HSEjqfyUK3DbNquqyr2D+76fU+bGUoHjOLqYdV3Pqd9ABH81ECASUUmSuC8ZsTikAqdpou9giK2Gyru8R4aMA1T6gO0Gj1j2V4fA51/8H57AECAyZBygUgkqlaBSCSqVoFIJKpWgUgkqlaBSCSp1sNcPIBplRGgiZ2gAAAAASUVORK5CYII=",
            } },
{421,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFNSURBVFhHzZZbqoMwFEU7JUU7Dx+jcBitMxGcjOKEfJzbnUtKkP2hbYpbWGCWP4vEaG5mJg2VSlCpBJVKUKkElUpQqQSVSlCpBJVKUBmD+/1uSZK8bvnzo1B5Fh/jgzDuus7atrU0TZ37FCrPgJiiKOz5fL6DfFxZll/PIpVHQdzj8XjHgHDmLl9iBDZNY+M42rZtNk2TVVXlIr9dWg+VR9jH+St2JJVHyPPcBS7LYnVdu3dwXdfXI3PjywP9DCKw73sXM8/z69F/IIIvDQSIRFSWZW4nIxaXVOAwDPQdjLGDAZVnCCNjxwEqz4JILHGMD/MeKj/BbxqpQESF9/irxNgYIVQeAd/B8FuHsVRgOGNYVn9gkAoMTzGxTi97qDyKj/QnmdhxgMozIBJhv4gDVCpBpRJUKkGlElQqQaUSVCpBpRJUKkGlElTqYLc/rX5ZrSSHEAgAAAAASUVORK5CYII=",
            } },
{422,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFcSURBVFhH7ZULaoQwFEVnS4q6Dz+r0F2oO1HcjDIb8vPqTckgclu1scwrVDigJyMcEpN5iIhqqNQElZqgUhNUaoJKTVCpCSo1QaUmqNQElVeJokg8z1tv+bgLVF4BcU3TSFEUvxJJ5RUQWJalJEnyH/gj/nQgxlyjqTwLAuI4lqqqXoE2CGPYPGmaOkVSeYYwDM3M1XVt4gCC8Oz7/uvedempPANmKM9zGYZBlmWR5/NpZsseOdtZ3b97BSqP2MfZax/pGgeoPMIGTtMkWZaZ2ZrneR0S84xALDN+6wqVR2wDu64zMeM4rkOfgQh+ayBAJKKCIDA7GbG4EIj4O74/QOUZENj3Pf0G7Y52PWIAlWfZRto4BAEcQW3bOkdSeQWch1ji/ZLac/Jt56AFs6j2rw58F3gHVF5BfSC4Yym/gkpNUKkJKjVBpSao1ASVmqBSE1RqgkpNUKkHeXwAQxZJuqxyVx0AAAAASUVORK5CYII=",
            } },
{423,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFjSURBVFhHzZbbqYQwFEWnJUXtw0cV2oXaiY9mFBvyca47QwaRDaPXwBxhQVzJxyKOGV8iohoqNUGlJqjUBJWaoFITVGqCSk1QqQkqNUHlFaIoEs/z9iGfdwWV30Bc0zRS17X4vr8rvs4FVH4DgXEcS1VVn0jspuW8/glUXgGReZ5LkiQGhAKMXUZSeRVElmX5CQOuHz2VV7G7OI6jbNsm0zRJmqYm8ueB5zh7uY6k8gphGJrAZVkkyzLzwqzruk+Juf95oN1BBPZ9b2Lmed6n3oEI/mkgQCSigiAwxw5icakKHIaB/gZdHTVU3uEY6ToOUHkXROIRuz6kAZV3sYGu4wCVd0Eg3mi1gfZMtIG4x9hFMJV3Oe4gsP/PRVE8jqTyLjYQQfYTrG1b6brucSSV/wGRdgfxwiD4+L14Xn8VKp9yjH2ye4BKTVCpCSo1QaUmqNQElZqgUhNUaoJKTVCpB3n9AaM/UYIrp57PAAAAAElFTkSuQmCC",
            } },
{424,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGnSURBVFhHzZQNrgExFIVtiRj7MKxi7AI78bMZMhsa9DlNjlzNoTU87iRfMvO10tPbq4MQgmuk9ISUnpDSE1J6QkpPSOkJKT0hpSek9ISUJUwmkzAcDq+vevxTSJkD4TabTZjNZkUh39mMlDmw4HK5DNvtNoxGo6sKg6qqYggL52Iz6/X6NvcVpCyBIbkwQux2uzvoMaeu615VlLIEHhtDLhaLO1arVawwN9AnHJAyh60eKwOaprn7nk6nt6B9jhdImYMB7bGhB21Azns3pJTPQBDbe3S2B9MxhvxKQFaPi9lqkvRfyznoTVa3FCkfwYXSxXG0x+MxXC6X0LZtvB8R0s7pW0UpH8GAaWUYjg9D2kBsjZ8EPJ/PYT6fx0B4x4NvVNb+iX4acL/fR991HcZ+GzDtQYQaj8exz06nE3wMqK6bfw0IVBUPh4PsQRsQv7F3ZClSPoNHZa8MOIZMw2Hsq/cgYEXSkHgndh5aok/1gJQ5sHCuKp8IB6QsAQGeLcqA74QDUn6K3CZKkNITUnpCSk9I6QkpPSGlJ6T0hJSekNITUvohDP4AOLrrlJaI8ykAAAAASUVORK5CYII=",
            } },
{425,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGESURBVFhHzZSLjcIwEERpiShJHwGqIF0QOgnQDIiGgOwxlvbO8o2DOSHdRHpS/Gxrx5vPwsykoVIJKpWgUgkqlaBSCSqVoFIJKpWgUgkqlaBSCSqVoPIVbdvacrl83vL5T0LlHAg3jqPt93urquqpfjxCO+5T3j0clXOgwG63s9VqZcMwhJAoCHc4HOx4PNp6vaYhcoebg8o5PKAH67ouBO37PoQGuRC+F2tLu0hljqZpfhWA2263drlcbJomu16voYMImQb0/aXdA1TmiLuHsRf0cH6xkNiLg/hrAVcClTlyAR+Ph202m1Ac97gwTgNi7TuPF1DJYB2IA55Op+BvtxvmvgOnAX1cCpWMXAcQEqHqug4fzP1+x9z/BUwLIOD5fKbvoB8kd7gSqEzxArn/VxwyDucHiu/Tva+gMqWkA1iDOccd3tv4p+7rS6GSgS7lws2BfQj5l8cLqPw03t3Ul0ClElQqQaUSVCpBpRJUKkGlElQqQaUSVCpBpRJUKkGlDrb4Ai1MKJ/YfZvRAAAAAElFTkSuQmCC",
            } },
{426,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGeSURBVFhHzZaNrYJAEIRtSSP0gVqFdgF2AtqMhoZE9mVI1qzrID/G55J8iXzc5cYBThciEhoqI0FlJKiMBJWRoDISVEaCykhQGQkqI0HlVJIkkeVy+YIfNwcqx5KmaRckz3OpqkpOp9MTq9Xq46BUjgHhsiyToijkeDw+wig2NK75+WOhcggbbrPZ0JZ8u3NDUjkEFsfCNpwGUvzYuSGpfIcuqLdVXVmWj2fPXrNz/jWgDadtKgjrvwDGHA6Hp3bHQGUfaZrQ9vb7vVyvV2nbVuq6lu1224W0jWErmtMilX34RfRcw+mhIfES+bFfDdh3e+/3u+x2uy4QPuPAOZq1L9FPA57P587fbjdc+21A/wwi1Hq97vbGpmngu4Bsu/lqQOAXwvnlcqHPoG+vb1N/B5Xv0MXsloEXQEP6cHbO1PYAlUOwRhASt9i39El7gMohsKj/LQa2JYxRNzccoHIM2pj9N6MBNRj8J+EAlWPRlmxQi4b186ZA5VQ0qMePmwOVkaAyElRGgspIUBkJKiNBZSSojASVkaAyElTGQRZ/FybsQcTHSDIAAAAASUVORK5CYII=",
            } },
{427,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAE9SURBVFhH7ZVbioNAEEWzJUXdh49VuAx1J4KrETfko6arh5JBbqBNesj9iHBAj/1x6NiVh4hQAyUTUDIBJRNQMgElE1AyASUTUDIBJRNQhpLnuSRJ4m7x+xhAGYLGjeMowzBImqZO4XXvAmUIRVFIWZbS9/0ZqbtpXNe/CpShaGTbtlJVlcdi9T5WJJR30Miu684wJeZPD+UdbBfneZbjOGRZFqnr2kd+PPAaZ1fMSChDscBt26RpGv8N7vvuXol/pgjUk6yB0zT5mHVd3avfQA3+aKDOQgvMsuy810sDdXffPc1QhmI7+OwbjDFqoAzFAnW0XE8xxRy0Q2KD+S/Xta8CZSgaqEM65j/HFShD+QY6oAyFPlDn4HcHkbyDRv5XnAIlE1AyASUTUDIBJRNQMgElE1AyASUTUPIgjx/wKFdkbZrmMwAAAABJRU5ErkJggg==",
            } },
{428,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAE8SURBVFhHzZTbqYNAFEXTkqL24aMKy1A7EaxGbMjHuZ65nCDDhmic4B5YH1ljYDGvl4hQAyUTUDIBJRNQMgElE1AyASUTUDIBJRNQMgElE1BeIcsyiaLojT9/FyjPonF5nkvbttJ1ncRxHDwSyjOkaSpN07iwoigcfd+/Q/3vvwXKM2hgXdcyjqNs2ybTNElZli4y5EpC+Qk/zoYfuQ/4/ytA+QkLXJZFqqpyZ3Bd131K3O/HA/VyWOAwDC5mnud96j9Qgx8NVDRSo5IkcTdZY3VQBepW2tbqsDMY8qmB8izHSIvT1dMnxyL1mzvBUF7BAgw9m8dIe8i/3XIo76DBx0h/Ra8C5V3sGbobp0AZglCRUIbiuN00Z9Dn8Vv8a6BkAkomoGQCSiagZAJKJqBkAkomoGQCSiag5EFef4YiYg62KVv0AAAAAElFTkSuQmCC",
            } },
{429,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFESURBVFhH7ZRrqoMwEEa7JUXdh49VuAx1J4KrETfkY66Ty0hbPiHaQL8fFQ7UkwqHkMxDRKiBkgkomYCSCSiZgJIJKJmAkgkomYCSCSiZgPIOWZZJFEUH7+t3gfIqGpfnubRtK13XSVEUwSKhvILGNU1zhCl937v3OI73v+DvfIHyChpY17WM4yjbtsk0TVKWpYv8emCapi9x9oSMhNIXC1yWRaqqcmdwXdd9Sdw7RaBeDg0chsHFzPO8L/0HajBNYJIkx299NFB399PbDKUvNl7ez6Dupp7BEKMGSl8sUEeLRYaMU6D0xUaMDWZFg/XshRrWUPpiQ/o5xqJDRULpCwo0/7yz5u8ApS9ngYre8E/jFCh90YizwFBA6csvcAfKK4Q6a2dAyQSUTEDJBJRMQMkElExAyQSUTEDJBJRMQMmDPP4A5EZUHyBODCAAAAAASUVORK5CYII=",
            } },
{430,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFvSURBVFhHzZZrioQwEAbnSop6Dx+n8BjqTUQvo3ghH712lh6CfD9MzK4tFDgVhSLGjB8iUg2UmoBSE1BqAkpNQKkJKDUBpSag9CXLMoqi6DzF4z5A6YqE9X1PZVkGjYTyLnbYMAyGrusojuNzGN/jCpR34DgO43OJyvOc2rZ9PzBNU2qa5jtb8kjZq1iDPHt/MVsIKO9wjeSZs7le7wuUd5FIDpLY62N/CpQucKSsx6IoDPzyhHqboXSBA+u6pnme6TgOWpbF7IUc+XrgNU6OkJFQ3kUCt22jqqrMGtz3/Rwi8/v1QN73JHAcRxOzrus59BsYYhuC0gWeRY5KksS8yRzLh6rAaZrgGgyx1UDpih0pcTx7vOU8jYTSB47kGBveH59GQhkKjn4aCaUvMov2uf3VI9e5AKUPvOXI/7IdpuYR29+IdtiTOAZKHyQwVJgApS9qvqj/Eyg1AaUmoNQElJqAUhNQagJKTUCpB/r8ABrRNt8xVZOKAAAAAElFTkSuQmCC",
            } },
{431,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFeSURBVFhH7ZXdqYNAEEbTkqL2EbUK7ULtRLQZxYb8metnWDHyPei6kHm4wnnI2QQOk83kJSKqoVITVGqCSk1QqQkqNUGlJqjUBJWaoFITVF4liiLxPG/jfOYKKq8QhqHUdS1N00hVVeL7/h7rMpjKKyDw/X5LHMeSZZnkeS5lWa5Hn/NjsHE2UHmV41dsYk0wYjFZM93zZ69CpQ2IRZiJPMY+mSKVNhwDzVQN5/fegUobEFgUxR54PreFShv+A58QReH+y8W6cXH3DFTeAfsQk8M6wfQAFvjT9WKg8g4IxPT6vpdlWWQYBkmSZIv8eeA5zjwuI6m8igmcpknSNN3u4DzP65Fsr1UFtm27xYzjuB59AhH800CASEQFQbD9HyMWj6rAruu+7iCmiTvoYtVQeZdjpMs4QKUNiDQL2lUcoFITVGqCSk1QqQkqNUGlJqjUBJWaoFITVGqCSj3I6w/DFUzg3wAa5QAAAABJRU5ErkJggg==",
            } },
{432,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGESURBVFhHzZWLjYJAFEVtCQP2oVCFdqF0YqAZiA35ebt3NnczO16Uj8k+kpMwhyFzMoCuzMw1UnpCSk9I6QkpPSGlJ6T0hJSekNITUnpCSk9I6Qkp57DZbCzLskB6bQlSzgGB5/PZyrL8aKSUU2Fc0zSBuq5tvV5/X9LzpyDlKxCTjo/Ho+12u18Q+6lIKYcoiiLExAsjcL/fW9/39ng87HK5hMeMyH8P5O4xjgcjT6fT4kgph3gO/Bnf73erqioE4RwHxofD4c8Hg/t5PhYph0gDMcbjvd1u1rZt8NfrFdeeAtN7xyLlEFyEC3NBROV5btvtNsTiQCA+GAbG8zEei5SvYCQXB13XDb6DnIevOg4ei5SvUI8KjpGMYzzmMnBqHJDyHUOReMTpLsHP3T0g5TsYw58RLAzwwaRx8etAPwUpxxBH8l+DgWRpHJByLIjE4nFoDHc3vW8KUk6FoSnpvDlI6QkpPSGlJ6T0hJSekNITUnpCSk9I6QkpPSGlJ6T0g62+AFVWJqwCp1/MAAAAAElFTkSuQmCC",
            } },
{433,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFnSURBVFhHzZQLioMwFEW7pRZ1H35W0e6iuhPBzShuyNY3vgyvo+HOGD8wVzhgTqQ9BpOLiFADJRNQMgElE1AyASUTUDIBJRNQMgElE1AyAWUocRzL9Xpd4D9zFChD0Ljn8znd/riqquR2uy1C7SVsvBUo17C4x+OxWL00TaUsS5mH1nX9Gfu/EwKUayRJ4gL9P1WvUff7XbIs+8Tpvfr5s6FAucZvgYbNW9jeOAXKEP6KXHuBLUAZgkbYNzcP8VfP/F6gDMWP1KAz4xQot5AksYvUjaG7+sw4BcpQ7LixnaocPVZ8oAxFA3Xluq6TcRyl73vJ89xF/nugH2fX2ZFQhmCBr9dLiqJwG+X9fk9T4sZUgU3TuJhhGKap70D/+NkLlKFopEZFUeR2ssbqRRXYtu3iG9TV1G+Q5hycR54dp0C5FY3UKMOfPwKUTEDJBJRMQMkElExAyQSUTEDJBJRMQMkElDzI5QuY/kMv/ORrbgAAAABJRU5ErkJggg==",
            } },
{434,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFcSURBVFhHzZOLiYNAFEXTkqL24acK7SLaiWA1YkN+3vomvMWVG6NjWK5w0JyRzGFmfIgINVAyASUTUDIBJRNQMgElE1AyASUTUDIBJRNQ+hDHsQRBsD7icV+gvEqSJNK2rTRNI2EYrgq/5wOUV9HA5/MpVVV9fRWhPAJtJU3gu62kCkQhnwJ13Dccynf4BOrYnQ8IyiP0DGqMTZYksaRpKnVd/0b8jX+977v9UB5hgTahPmtYlmWO/Wrt37f/OQuUn9BJy7J0E+q973tZlkWGYZA8z12k3nXcVvdfAxWLtDi79pF34hQoz2CB0zRJURQuZJ7ndUjc7+0q+sYpUJ5hG9h1nTtz4ziuQ69ADfb5avdAeRaN1KgoitxZ01i9qAJ1K21r9bIzeGdbt0B5hW3kt+MUKK+ikfYxfDNOgZIJKJmAkgkomYCSCSiZgJIJKJmAkgkomYCSCSh5kMcPBwBDpuEuYH0AAAAASUVORK5CYII=",
            } },
{435,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFQSURBVFhHzZSBiYNAFAXTkkHtI2oV2oWmEyXNKDak8Z9vjw+58CB7iZAnDNkdA86q68nMpKFSCSqVoFIJKpWgUgkqlaBSCSqVoFIJKpWgUgkqlaAyhizLLEmSfcjPHwWVr8jz3Pq+t+v1aufzeVe/DsGP0e58/g5UvgIXvlwufyLbtg1jnyPseRHvQGUMeMSIRAh+i6IIIApBHgf3yV2kMhZ/D8dxtG3bbJ5nK8vysDhAZSwI9Dg/PPKIOEBlLAhclsWqqrKu6+x+v+/awryua53A2+0W3juMcXjwJ5vDoTIWD0zTNGyUdV13LRKIOERN00Tfwa8+YsQhwO+SP9rHuGEYwvgruxiB+DD7TgWIapomgDnOHxFJZQyIfLywz935IjzY//dfqDyK50W8A5VKUKkElUpQqQSVSlCpBJVKUKkElUpQqQSVSlCpBJU62OkH++1Z41cR9TgAAAAASUVORK5CYII=",
            } },
{436,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFMSURBVFhH7ZbbjYMwFAXTEgjSB48qoItAJ0g0A6IhHnc5rLwi6EgB4o/zsUgj4fFHJnYweZiZNFQqQaUSVCpBpRJUKkGlElQqQaUSVCpB5Rmez6cFQbDe8nlfUPmJOI6taRqr69rCMFzVr0PwPto5N74DlZ/ABydJ8hb5er22e8xjjLDjl7gDlWfAFhdFYWmavoGoLMv+4uC+WUUqz4JIrGTf97Ysiw3D4DUOUHmGY5y7XKSPOEDlGdwWT9NkeZ5bVVU2z/M6ZdsYczKBbdtuD8I4juuUSCBAJKKiKNq2G7G4ZAJx3HRdR3+DPuIAlVfYR/qOA1RexR3cvp7cPVReBYF4k/wH3kU6EHGIwrEiF+hWrizLLQ5vk2//vRyh8gpuBQGeZN+RVN5lH3ucuwuVSlCpBJVKUKkElUpQqQSVSlCpBJVKUKkElTrY4weco08VZWSlxwAAAABJRU5ErkJggg==",
            } },
{437,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGgSURBVFhHzZbtrYJAEEVtSRCEMhShB7UKvxoRmoFIKAhw9G7CiyH3B8uSvNnkJHhYkpvZGXAlIqqhUhNUaoJKTVCpCSo1QaUmqNQElZqgUhNU2hIEgazXa8P4nitU2hDHsVyvV3k+n1IUhSDseI8LVNqCUGEYyvF4XDwklXNBsKVDUjkHBPI8T3zfNyHzPDe/x/tsodIWHO9+v5fL5SL3+10Oh4MkSbLI0FBpAyqHIXk8HpJlmQk2BFVRQVTvfD5LXdfyfr+laRpJ09SE3Gw23y38ualQORVU73Q6yev1krZtpe/7rxYTEpW83W7OVaRyKkPAruv+qoZrLPQhjt61D6mcCgJiYhEKrxZMMCqJhYAI/68B8RXZ7XYm1Ha7NaEQFkeNa4RHj46fs4FKG1DFsizNgGAhHKqJHsQ97HGBShviKDJVrKrKVBLhoq9zrdwAlbbgqNFrCLr0Pxoq5zD0IwZjiRf0AJVzGYdU8y3+5TckvjCY7vEeG6h0BSExJEsMCpWaoFITVGqCSk1QqQkqNUGlJqjUBJWaoFITVOpBVh/T81xy42QTlwAAAABJRU5ErkJggg==",
            } },
{438,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAFZSURBVFhH7ZXdrYJAEEZtSSIayxBsQjD2gEohgHZDRfw4l28Sboz5HtiFxHnw4UQ8LMnJwMJKRExDpSWotASVlqDSElRagkpLUGkJKi1BpSWo9CUMQ1mv18MhP+8DlT4grqoqud/vEgTBoPg6V6j0AYHX69V+YJqmi95mKn34Bc7lFziXX+AcEId3X5Zl/4FLRVLpAuIOh4Pcbjc5Ho/K4/HQF/YSkVS6sN1uNQ5Rz+dTQWRZlrLZbIYl/LqpUDkVTC9JEv0GvwfifxzH+jt3ilROZQw8n8+6QTA1BOZ5LlEUfT9wv9/L6XSSrut0Ytgol8tFQSCCvxoIMMWmaWS32wmOEdv3vT6H2NXwn9e4QKULmGJRFBr2er00rq5rnSg20Od6V6h0ZYxs2/YtLhxO8fUuUOkDInGLwRKTG6HSElRagkpLUGkJKi1BpSWotASVlqDSElTaQVZ/j0NXDFnh7lIAAAAASUVORK5CYII=",
            } },
{439,
            new Items.Pokemon()
            {
                Name = "Unown",
                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAJcEhZcwAACxMAAAsTAQCanBgAAAGMSURBVFhHzZXdrYJAEEZtCUEJZaA0oRB6wJ9CVOzGihSY6zfJmhvyPbCyifNwohwhOZndxYWImIZKS1BpCSotQaUlqLQElZag0hJUWoJKX1arlURRpIx/mwuVPiDudrvJ/X5Xlstl0FAqfUDg4XCQ0+mktG2rnwgd3/sNVPryf4n3+33QSCrngFgXaTIQuH0ZYopUzsXty7IsZx8YKudiOjBkHKDSF0QhJo5j3XuIMxeIMJxchG02myBxgEofEIeTileLCwsVB6icCuLyPJfj8ahxRVF8Xi8mJrherzUOS+v+i7fbrUYmSfK+hT/nA5VTwPSwrG7vuUBcu8if/pO4wKqq3peyuF6vGno+n3W5fx6YZZnsdjvpuk4nhhic4LquNRDBeO2Mn/OFyqlgis/nU9I0FXxHbN/3eliaplE/fsYXKqeCKV4uFw0bhkHjHo+HThQHaHz/N1Dpg4t8vV6fOExzfN+3UOkLIjExhIWMA1RagkpLUGkJKi1BpSWotASVlqDSElRagko7yOIPZklJxiG6ChQAAAAASUVORK5CYII=",
            } },
{440,
            new Items.Pokemon()
            {
                Name = "??????????",
                img = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAADqSURBVFhH7ZHBCcJAFERTjmWYNjzmZEkePVqCl/SUDiIj/8mwrKLuGhD+wLDJT/7MCxlSqVQqleqlcRxXHKPtpNJl2T28GYR/9fW8v5fr/DmAl07ToXryTqy0yYMo9jK/9pncDKEA/iuuFdVgcBMEAJhAQOSysJx1BQCC4LIMdwHwcgV5Odd6B/NMBqCpnFAgXtkBVO77OiP2fXmAF9WAvMj3sO4j9n1pqSyinBKflwZinufvARRACdb8eDmtCAD+uZ84Ij9XDcIBynLcVFqKr/ACd+1ZVwAEyDNLKpd0H2vbyWFilPoHDcMN89c9lSIYqywAAAAASUVORK5CYII=",
            } },
        };
    }
}
