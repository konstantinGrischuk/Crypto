using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{

    public static class Hash
    {
        public enum Algorithm 
        {
            Fnv1a64,
            Fnv1a32,
            Adler32,
            SHA1, 
            SHA256, 
            SHA384, 
            SHA512, 
            RIPEMD160, 
            MD5,
            CRC32,
            CRC32Slice16,
            CRC32Slice8,
            CRC64,
            Elf32,
            Tiger,
            MurMur32,
            whirpool,
            CRC16
        }

        public static string Generate(Algorithm algo, string path)
        {
            HashAlgorithm ser;
            switch (algo)
            {
                case Algorithm.MD5:
                    ser = new MD5CryptoServiceProvider();
                    break;
                case Algorithm.RIPEMD160:
                    ser = new RIPEMD160Managed();
                    break;
                case Algorithm.SHA1:
                    ser = new SHA1CryptoServiceProvider();
                    break;
                case Algorithm.SHA256:
                    ser = new SHA256CryptoServiceProvider();
                    break;
                case Algorithm.SHA384:
                    ser = new SHA384CryptoServiceProvider();
                    break;
                case Algorithm.SHA512:
                    ser = new SHA512CryptoServiceProvider();
                    break;
                case Algorithm.CRC32:
                    ser = new CRC32();
                    break;

                case Algorithm.CRC32Slice16:
                    ser = new Crc32Slice16();
                    break;
                case Algorithm.CRC32Slice8:
                    ser = new Crc32Slice8();
                    break;
                case Algorithm.Elf32:
                    ser = new Elf32();
                    break;
                case Algorithm.Fnv1a32:
                    ser = new Fnv1a32();
                    break;
                case Algorithm.Adler32:
                    ser = new Adler32();
                    break;
                case Algorithm.Fnv1a64:
                    ser = new Fnv1a64(); //Crc64Iso
                    break;
                case Algorithm.Tiger:
                    ser = new Tiger(); 
                    break;
                case Algorithm.CRC16:
                    ser = new CRC16();
                    break;

                case Algorithm.whirpool:
                    ser = new Whirlpool();
                    break;



                default:
                    throw new InvalidOperationException();
            }

            if (File.Exists(path))
                using (var stream = new BufferedStream(File.OpenRead(path), 1024 * 20))
                {
                    byte[] checksum = ser.ComputeHash(stream);
                    return BitConverter.ToString(checksum).Replace("-", String.Empty).ToLower();
                }
            else
            {
                byte[] checksum = ser.ComputeHash(new UTF8Encoding().GetBytes(path));
                return BitConverter.ToString(checksum).Replace("-", String.Empty).ToLower();
            }
        }
    }
}
