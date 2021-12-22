using System.Security.Cryptography;
using Neo.Wallets;
using Neo.SmartContract;

namespace VanityAddress
{
    public class NeoN3
    {
        public static Account GenerateAccount()
        {
            byte[] privateKeys = new byte[32];
            byte version = 53;

            using (RandomNumberGenerator nums = RandomNumberGenerator.Create())
            {
                nums.GetBytes(privateKeys);
            }
            KeyPair key = new KeyPair(privateKeys);

            var contract = Contract.CreateSignatureContract(key.PublicKey);
            var privateKey = key.Export();
            var publicAddress = contract.ScriptHash.ToAddress(version);

            Account account = new Account()
            {
                PrivateKey = privateKey,
                PublicAddress = publicAddress
            };

            return account;
        }

        public static bool CheckAccount(Account account, string[] startsWith, string[] contains, string[] endsWith, bool requireAll)
        {
            return (!requireAll &&
                    (
                        startsWith.Any(x => startsWith.Length != 0 && x.Length != 0 && account.PublicAddress.ToUpperInvariant().StartsWith(x.ToUpperInvariant())) ||
                        contains.Any(x => contains.Length != 0 && x.Length != 0 && account.PublicAddress.ToUpperInvariant().Contains(x.ToUpperInvariant())) ||
                        endsWith.Any(x => endsWith.Length != 0 && x.Length != 0 && account.PublicAddress.ToUpperInvariant().EndsWith(x.ToUpperInvariant()))
                    )
                   ) ||
                   (requireAll &&
                    (startsWith.Any(x => startsWith.Length != 0 && x.Length != 0 && account.PublicAddress.ToUpperInvariant().StartsWith(x.ToUpperInvariant())) || startsWith.Length == 0) &&
                    (contains.Any(x => contains.Length != 0 && x.Length != 0 && account.PublicAddress.ToUpperInvariant().Contains(x.ToUpperInvariant())) || contains.Length == 0) &&
                    (endsWith.Any(x => endsWith.Length != 0 && x.Length != 0 && account.PublicAddress.ToUpperInvariant().EndsWith(x.ToUpperInvariant())) || endsWith.Length == 0) &&
                    (startsWith.Length != 0 || contains.Length != 0 || endsWith.Length != 0)
                   );
        }
    }
}
