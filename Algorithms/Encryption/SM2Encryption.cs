using AntdUI;
using Org.BouncyCastle.Asn1.GM;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LittleFancyTool.Algorithms.Encryption
{
    public class SM2Encryption : IEncryptionAsymmetric
    {
        public string Decrypt(string input, string? privateKeyStr = null, string? mode = null, int keyLength = 2048)
        {
            byte[] cipherBytes = Base64.Decode(input);
            if (mode == "C1C3C2")
            {
                cipherBytes = C132ToC123(cipherBytes);
            }
            X9ECParameters curve = ECNamedCurveTable.GetByName("sm2p256v1");
            ECDomainParameters domain = new ECDomainParameters(curve);
            BigInteger d = new BigInteger(1, Base64.Decode(privateKeyStr));
            ECPrivateKeyParameters prik = new ECPrivateKeyParameters(d, domain);
            SM2Engine sm2Engine = new SM2Engine();
            sm2Engine.Init(false, prik);
            byte[] plainBytes = sm2Engine.ProcessBlock(cipherBytes, 0, cipherBytes.Length);            
            return Encoding.UTF8.GetString(plainBytes);
        }

        public string Encrypt(string input, string? publicKeyStr = null, string? mode = null, int keyLength = 2048)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(input);
            X9ECParameters curve = ECNamedCurveTable.GetByName("sm2p256v1");
            ECPoint q = curve.Curve.DecodePoint(Base64.Decode(publicKeyStr));
            ECDomainParameters domain = new ECDomainParameters(curve);
            ECPublicKeyParameters pubk = new ECPublicKeyParameters("EC", q, domain);
            SM2Engine sm2Engine = new SM2Engine();
            sm2Engine.Init(true, new ParametersWithRandom(pubk, new SecureRandom()));
            byte[] cipherBytes = sm2Engine.ProcessBlock(plainBytes, 0, plainBytes.Length);
            if (mode.ToUpper() == "C1C3C2")
            {
                cipherBytes = C123ToC132(cipherBytes);
            }
            return Base64.ToBase64String(cipherBytes);
        }

        public (string publicKey, string privateKey) GenerateKeyPair(int keyLength = 2048, string keyFormat = "PKCS#8")
        {
            X9ECParameters curve = ECNamedCurveTable.GetByName("sm2p256v1");
            KeyGenerationParameters parameters = new ECKeyGenerationParameters(new ECDomainParameters(curve), new SecureRandom());
            // 创建 SM2 密钥对生成器
            ECKeyPairGenerator generator = new ECKeyPairGenerator();
            generator.Init(parameters);
            // 创建密钥对
            var keyPair = generator.GenerateKeyPair();
            // 私钥
            ECPrivateKeyParameters privateKeyParameters = (ECPrivateKeyParameters)keyPair.Private;
            string privateKey = Base64.ToBase64String(privateKeyParameters.D.ToByteArrayUnsigned());
            // 公钥
            ECPublicKeyParameters publicKeyParameters = (ECPublicKeyParameters)keyPair.Public;
            string publicKey = Base64.ToBase64String(publicKeyParameters.Q.GetEncoded());
            return (publicKey, privateKey);
        }

        private static byte[] C123ToC132(byte[] c1c2c3)
        {
            var gn = GMNamedCurves.GetByName("sm2p256v1");
            int c1Len = (gn.Curve.FieldSize + 7) / 8 * 2 + 1;
            int c3Len = 32;
            byte[] result = new byte[c1c2c3.Length];
            Array.Copy(c1c2c3, 0, result, 0, c1Len); //c1
            Array.Copy(c1c2c3, c1c2c3.Length - c3Len, result, c1Len, c3Len); //c3
            Array.Copy(c1c2c3, c1Len, result, c1Len + c3Len, c1c2c3.Length - c1Len - c3Len); //c2
            return result;
        }
        private static byte[] C132ToC123(byte[] c1c3c2)
        {
            var gn = GMNamedCurves.GetByName("SM2P256V1");
            int c1Len = (gn.Curve.FieldSize + 7) / 8 * 2 + 1;
            int c3Len = 32;
            byte[] result = new byte[c1c3c2.Length];
            Array.Copy(c1c3c2, 0, result, 0, c1Len); //c1: 0->65
            Array.Copy(c1c3c2, c1Len + c3Len, result, c1Len, c1c3c2.Length - c1Len - c3Len); //c2
            Array.Copy(c1c3c2, c1Len, result, c1c3c2.Length - c3Len, c3Len); //c3
            return result;
        }

        public async Task EncryptFileAsync(string inputFilePath, string outputFilePath, string publicKey, int keyLength)
        {
            throw new NotImplementedException();
        }

        public async Task DecryptFileAsync(string inputFilePath, string outputFilePath, string privateKey, int keyLength)
        {
            throw new NotImplementedException();
        }
    }
}
