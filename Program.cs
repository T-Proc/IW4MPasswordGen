using SimpleCrypto;

/// <summary>
///     Generate password hash and salt
/// </summary>
/// <param name="password">plaintext password</param>
/// <param name="saltStr">salt of password</param>
/// <returns></returns>
/// 

//Crap hacked out code by https://tproc.net ¯\_(ツ)_/¯
Console.WriteLine("IW4M Pass:");
string pass =Console.ReadLine();
Console.WriteLine(Hash("Password"));
Console.WriteLine("\nTop - Password\nBottom - PasswordSalt");
Console.WriteLine("Any Button to exit");
Console.ReadLine();

static string[] Hash(string password, string saltStr = null)
{
    string hash;
    string salt;
    var CryptoSvc = new PBKDF2();

    // generate new hash 
    if (saltStr == null)
    {
        hash = CryptoSvc.Compute(password);
        Console.WriteLine(hash);
        salt = CryptoSvc.Salt;
        Console.WriteLine(salt);
        return new[] {
      hash,
      salt
    };
    }

    hash = CryptoSvc.Compute(password, saltStr);
    return new[] {
    hash,
    ""

  };

    
}