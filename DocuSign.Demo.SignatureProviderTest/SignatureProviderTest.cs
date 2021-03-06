using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace DocuSign.Demo.SignatureProviderTest
{
    [TestClass]
    public class SignatureProviderTest
    {
        private const string SignerName = "Cyril Thirion";
        private const string SignerEmail = "cyril.thirion+github@gmail.com";
        private const string SignerCountry = "FR";
        private const string SignerOrganization = "Acme";

        private const string Base64encodedHashToSign = "LH8U4Y4iR9XPDptIxXDNSYdQJwAKSCAmk2jxuDwdYbQ=";

        [TestMethod]
        public void TestSignHashWithBouncyCastle()
        {
            byte[] hashBytes = System.Convert.FromBase64String(Base64encodedHashToSign);

            byte[] signedCmsData = SignatureProvider.SignatureProvider.Sign(hashBytes, SignerName, SignerEmail, SignerCountry, SignerOrganization);

            CmsSignedData cmsSignedData = new CmsSignedData(signedCmsData);
            IX509Store x509Certs = cmsSignedData.GetCertificates("Collection");
            SignerInformationStore signers = cmsSignedData.GetSignerInfos();

            foreach (SignerInformation signer in signers.GetSigners())
            {
                ICollection certCollection = x509Certs.GetMatches(signer.SignerID);

                Assert.AreEqual(1, certCollection.Count);

                IEnumerator certEnum = certCollection.GetEnumerator();
                certEnum.MoveNext();
                X509Certificate cert = (X509Certificate)certEnum.Current;

                Assert.AreEqual(cert.SubjectDN.ToString(), "CN=Cyril Thirion,E=cyril.thirion\\+github@gmail.com,C=FR,O=Acme");

                Assert.AreEqual(signer.SignedAttributes[PkcsObjectIdentifiers.Pkcs9AtContentType].AttrValues[0].ToString(), PkcsObjectIdentifiers.Data.ToString());
                Assert.IsNotNull(signer.SignedAttributes[PkcsObjectIdentifiers.Pkcs9AtMessageDigest]);
                Assert.IsNotNull(signer.SignedAttributes[PkcsObjectIdentifiers.IdAASigningCertificateV2]);
                Assert.IsNotNull(signer.SignedAttributes[PkcsObjectIdentifiers.Pkcs9AtSigningTime]);

                Assert.AreEqual(
                    "#" + BitConverter.ToString(hashBytes).Replace("-", ""),
                    signer.SignedAttributes[PkcsObjectIdentifiers.Pkcs9AtMessageDigest].AttrValues[0].ToString(), true
                );

                byte[] signedData = signer.GetEncodedSignedAttributes();
                System.IO.File.WriteAllBytes("/tmp/tmp.txt", signedData);
                ISigner s = SignerUtilities.GetSigner("SHA256withRSA");
                s.Init(false, cert.GetPublicKey());
                s.BlockUpdate(signedData, 0, signedData.Length);
                Assert.IsTrue(s.VerifySignature(signer.GetSignature()), "Signature verification failed.");
            }
        }
    }
}
