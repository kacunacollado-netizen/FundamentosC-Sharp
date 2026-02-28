using System.Security.Cryptography;
using System.Text;

string password = "Pokemon4nivers4rio";
string salt = Guid.NewGuid().ToString();

string passwordConSalt = password + salt;

SHA256 sha256 = SHA256.Create();
byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(passwordConSalt));

string hash = Convert.ToBase64String(bytes);

Console.WriteLine("Contraseña original: " + password);
Console.WriteLine("Salt: " + salt);
Console.WriteLine("Hash generado: " + hash);