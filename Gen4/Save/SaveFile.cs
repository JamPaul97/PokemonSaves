using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gen4.Save
{
    public class SaveFile
    {
        internal Data data;
        internal string FileName = string.Empty;
        public GeneralBlockClass GeneralBlock1;
        public GeneralBlockClass GeneralBlock2;
        public StorageBlockClass StorageBlock1;
        public StorageBlockClass StorageBlock2;
        public SaveFile(string FileName)
        {
            this.FileName = FileName;
            this.data = new Data(File.ReadAllBytes(FileName));
            //Check first General Block Save Count
            //Check Second General Block Save Count
            //Get highest General Block Save Count;
            //Check the checksum if !correct check the other one. If both not corrent throw error.
            //If highest checksum is correct
            //Chose highest storage block save count
            //If same save count chose the one under the chosen general block





            this.GeneralBlock1 = new GeneralBlockClass(this.data, Offsets.GeneralBlock1);
            this.GeneralBlock2 = new GeneralBlockClass(this.data, Offsets.GeneralBlock2);
            this.StorageBlock1 = new StorageBlockClass(this.data, Offsets.StorageBlock1);
            this.StorageBlock2 = new StorageBlockClass(this.data, Offsets.StorageBlock2);
        }

        public class GeneralBlockClass
        {
            internal Data data;
            internal uint offset;


            internal uint ChecksumOffset                { get { return this.offset + 0xC0FE ; } }
            internal uint StorageBlockSaveCountOffset   { get { return this.offset + 0xC0EC; } }
            internal uint SaveCountOffset               { get { return this.offset + 0xC0F0; } }
            internal uint BlockSizeOffset               { get { return this.offset + 0xC0F4; } }


            public ushort Checksum                      { get { return this.data.Read.Ushort(ChecksumOffset); } }
            public uint StorageBlockSaveCount           { get { return this.data.Read.Uint(StorageBlockSaveCountOffset); } }
            public uint SaveCount                       { get { return this.data.Read.Uint(SaveCountOffset); } }
            public uint BlockSize                       { get { return this.data.Read.Uint(BlockSizeOffset); } }


            internal GeneralBlockClass(Data data,uint offset)
            {
                this.data = data;
                this.offset = offset;
            }
        }
        public class StorageBlockClass
        {
            internal Data data;
            internal uint offset;


            internal uint ChecksumOffset                { get { return this.offset + 0x121DE; } }
            internal uint StorageBlockSaveCountOffset   { get { return this.offset + 0x121CC; } }
            internal uint SaveCountOffset               { get { return this.offset + 0x121D0; } }
            internal uint BlockSizeOffset               { get { return this.offset + 0x121D4; } }


            public ushort Checksum                      { get { return this.data.Read.Ushort(ChecksumOffset); } }
            public uint StorageBlockSaveCount           { get { return this.data.Read.Uint(StorageBlockSaveCountOffset); } }
            public uint SaveCount                       { get { return this.data.Read.Uint(SaveCountOffset); } }
            public uint BlockSize                       { get { return this.data.Read.Uint(BlockSizeOffset); } }
            
            public uint SelectedBox                     { get { return this.data.Read.Uint(this.offset); } }
            internal StorageBoxClass[] _storageBoxes;
            public StorageBoxClass this[uint index]{ get { return this._storageBoxes[index]; } }
            internal StorageBlockClass(Data data, uint offset)
            {
                this.data = data;
                this.offset = offset;
                this._storageBoxes = new StorageBoxClass[18];
                for (int i = 0; i < 18; i++)
                    _storageBoxes[i] = new StorageBoxClass(data, (uint)(this.offset + (4 + (i * 4080))));
            }

            public class StorageBoxClass
            {
                internal Data data;
                internal uint offset;
                internal PokemonBoxClass[] _pokemons;
                public PokemonBoxClass this[uint index] { get { return this._pokemons[index]; } }
                internal StorageBoxClass(Data data,uint offset) 
                { 
                    this.data = data;
                    this.offset = offset;
                    this._pokemons = new PokemonBoxClass[30];
                    for (int i = 0; i < 30; i++)
                        this._pokemons[i] = new PokemonBoxClass(data,(uint)(this.offset + (i*136)));
                }
                public class PokemonBoxClass
                {
                    internal Data data;
                    internal uint offset;
                    private uint PersonalityValue { get { return this.data.Read.Uint(this.offset); } }
                    private ushort Checksum { get { return this.data.Read.Ushort(this.offset + 6); } }
                    internal byte[] pkmData;
                    internal byte[] DecryptedDataCache  { get { if (pkmData == null) { this.pkmData = DecryptData(); return this.DecryptData(); } else return this.pkmData; } }
                    internal byte[] DecryptedData       { get { return DecryptedDataCache; } }

                    public Primatives.Pokemon Data
                    {
                        get
                        {
                            return new Primatives.Pokemon(new Save.Data(this.DecryptedData));
                        }
                    }
                    internal PokemonBoxClass(Data data, uint offset)
                    {
                        this.data = data;
                        this.offset = offset;
                    }
                    private byte[] DecryptData()
                    {
                        byte[] encrypted = this.data.Read.Array(this.offset, 136);
                        uint start = this.offset + 0x08;
                        uint seed = this.Checksum;
                        uint indexer = 8;
                        do
                        {
                            seed = Decrypt(encrypted, seed, indexer);
                            indexer += 2;
                            seed = Decrypt(encrypted, seed, indexer);
                            indexer += 2;
                        } while (indexer < 136);

                        var order = ((this.PersonalityValue & 0x3E000) >> 0xD) % 24;
                        return UnShuffleArray(encrypted, order , 32);
                    }
                    private static readonly byte[,] BlockPosition =
                    {
                        { 0, 1, 2, 3 },
                        { 0, 1, 3, 2 },
                        { 0, 2, 1, 3 },
                        { 0, 3, 1, 2 },
                        { 0, 2, 3, 1 },
                        { 0, 3, 2, 1 },
                        { 1, 0, 2, 3 },
                        { 1, 0, 3, 2 },
                        { 2, 0, 1, 3 },
                        { 3, 0, 1, 2 },
                        { 2, 0, 3, 1 },
                        { 3, 0, 2, 1 },
                        { 1, 2, 0, 3 },
                        { 1, 3, 0, 2 },
                        { 2, 1, 0, 3 },
                        { 3, 1, 0, 2 },
                        { 2, 3, 0, 1 },
                        { 3, 2, 0, 1 },
                        { 1, 2, 3, 0 },
                        { 1, 3, 2, 0 },
                        { 2, 1, 3, 0 },
                        { 3, 1, 2, 0 },
                        { 2, 3, 1, 0 },
                        { 3, 2, 1, 0 },
                    };
                    private static byte[] UnShuffleArray(byte[] data, uint sv, int blockSize)
                    {
                        byte[] sdata = (byte[])data.Clone();
                        uint index = sv * 4;
                        const int start = 8;
                        for (int block = 0; block < 4; block++)
                        {
                            int ofs = BlockPosition[sv,block];
                            Array.Copy(data, start + (blockSize * ofs), sdata, start + (blockSize * block), blockSize);
                        }
                        return sdata;
                    }
                    private uint Decrypt(byte[] data, uint seed,uint i)
                    {
                        uint result = seed;
                        result = (0x41C64E6D * result) + 0x00006073;
                        data[i] ^= (byte)(result >> 16);
                        data[i + 1] ^= (byte)(result >> 24);
                        return result;
                    }





                }
            }

        }


    }
    internal static class Offsets
    {
        public const uint Block1                = 0x00000;
        public const uint GeneralBlock1         = 0x00000;
        public const uint StorageBlock1         = 0x0C100;
        public const uint HoF1                  = 0x20000;
        //=================================\\
        //              BLOCK              \\
        //=================================\\
        //          GENERAL BLOCK          \\
        //---------------------------------\\
        //          STORAGE BLOCK          \\
        //---------------------------------\\
        //           HALL OF FAME          \\
        //=================================\\

        //=================================\\
        //          GENERAL BLOCK          \\
        //=================================\\
        //              DATA               \\
        //---------------------------------\\
        //             FOOTER              \\
        //---------------------------------\\


        //=================================\\
        //         STORAGE BLOCK           \\
        //=================================\\
        //4Byte BoxInUse (uint)            \\
        //18*4080 Byte BoxData             \\
        //
        public const uint Block2                = 0x40000;
        public const uint GeneralBlock2         = 0x40000;
        public const uint StorageBlock2         = 0x4C100;
        public const uint HoF2                  = 0x60000;

    }
}
